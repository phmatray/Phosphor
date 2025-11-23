using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Helpers;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tools.DotNet;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using Phosphor;
using Serilog;

class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.GenerateIconsClass);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;
    
    AbsolutePath InputDirectory => RootDirectory / "input";
    AbsolutePath OutputDirectory => RootDirectory / "output";
    AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";
    AbsolutePath ProjectFile => RootDirectory / "src" / "Phosphor.MudBlazor" / "Phosphor.MudBlazor.csproj";

    readonly string[] Styles = ["Bold", "Duotone", "Fill", "Light", "Regular", "Thin"];

    Target Clean => _ => _
        .Executes(() =>
        {
            Log.Information("Cleaning output directory...");
            OutputDirectory.CreateOrCleanDirectory();
            Log.Information("Output directory cleaned successfully!");
        });

    Target GenerateIconsClass => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            Log.Information("Generating `Icons` class files");

            // Generate main Icons.cs file with empty partial class structure
            GenerateMainIconsFile();

            // Generate one file per style with constants
            foreach (var style in Styles)
            {
                GenerateStyleIconsFile(style);
            }

            Log.Information($"Generated 7 Icons class files (1 main + {Styles.Length} styles)");
        });

    private void GenerateMainIconsFile()
    {
        var iconsNamespace = new NamespaceBuilder("Phosphor.Components");
        var iconsClass = new ClassBuilder("Icons", isStatic: true, isPartial: true);
        var phosphorClass = new ClassBuilder("Phosphor", isStatic: true, isPartial: true);

        // Add empty style classes
        foreach (var style in Styles)
        {
            var styleClass = new ClassBuilder(style, isStatic: true, isPartial: true);
            phosphorClass.AddNestedClass(styleClass);
        }

        iconsClass.AddNestedClass(phosphorClass);
        iconsNamespace.AddClass(iconsClass);

        string code = iconsNamespace.Build();
        var iconsFile = OutputDirectory / "Icons.cs";
        iconsFile.WriteAllText(code);

        Log.Information("Generated Icons.cs (main file)");
    }

    private void GenerateStyleIconsFile(string style)
    {
        var iconsNamespace = new NamespaceBuilder("Phosphor.Components");
        var iconsClass = new ClassBuilder("Icons", isStatic: true, isPartial: true);
        var phosphorClass = new ClassBuilder("Phosphor", isStatic: true, isPartial: true);
        var styleClass = new ClassBuilder(style, isStatic: true, isPartial: true);

        // Add icon constants for this style
        foreach (var iconName in GetIconNames(style))
        {
            var constant = new ConstantBuilder(
                "string",
                iconName.PropertyName,
                iconName.CssClasses);

            styleClass.AddConstant(constant);
        }

        phosphorClass.AddNestedClass(styleClass);
        iconsClass.AddNestedClass(phosphorClass);
        iconsNamespace.AddClass(iconsClass);

        string code = iconsNamespace.Build();
        var fileName = $"Icons.Phosphor.{style}.cs";
        var iconsFile = OutputDirectory / fileName;
        iconsFile.WriteAllText(code);

        Log.Information($"Generated {fileName}");
    }

    Target Pack => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            Log.Information("Creating NuGet package...");

            ArtifactsDirectory.CreateOrCleanDirectory();

            DotNetPack(s => s
                .SetProject(ProjectFile)
                .SetConfiguration(Configuration)
                .SetOutputDirectory(ArtifactsDirectory)
                .EnableNoBuild()
                .EnableIncludeSymbols()
                .SetSymbolPackageFormat(DotNetSymbolPackageFormat.snupkg)
            );

            Log.Information($"NuGet package created in: {ArtifactsDirectory}");
        });

    Target Compile => _ => _
        .DependsOn(GenerateIconsClass)
        .Executes(() =>
        {
            Log.Information("Building solution...");

            DotNetBuild(s => s
                .SetProjectFile(RootDirectory / "Phosphor.sln")
                .SetConfiguration(Configuration)
            );

            Log.Information("Build completed successfully!");
        });

    private List<IconName> GetIconNames(string style)
    {
        // read wwwroot/fonts/{style}/selection.json
        var path = InputDirectory / "fonts" / style.ToLower() / "selection.json";
        var json = path.ReadAllText();

        // parse JSON using QuickType
        var selection = IconsSelection.FromJson(json);
        
        // return icon names
        var iconNames = selection.Icons
            .Select(iconElement => iconElement.Icon.Tags[0])
            .Select(iconName => new IconName(iconName))
            .ToList();
        
        return iconNames;
    }
}