using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Helpers;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using Phosphor;
using Serilog;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;

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
            Log.Information("Generating `Icons` class");
            
            var iconsNamespace = new NamespaceBuilder("Phosphor.Components");
            var iconsClass = new ClassBuilder("Icons", isStatic: true);
            var phosphorClass = new ClassBuilder("Phosphor", isStatic: true);
            
            foreach (var style in Styles)
            {
                var styleClass = new ClassBuilder(style, isStatic: true);
            
                foreach (var iconName in GetIconNames(style))
                {
                    //ph-thin ph-thumbs-up
                    var constant = new ConstantBuilder(
                        "string",
                        iconName.PropertyName,
                        iconName.CssClasses);
                    
                    styleClass.AddConstant(constant);
                }

                phosphorClass.AddNestedClass(styleClass);
            }

            iconsClass.AddNestedClass(phosphorClass);
            iconsNamespace.AddClass(iconsClass);

            string code = iconsNamespace.Build();
        
            // Write code to file
            var iconsFile = OutputDirectory / "Icons.cs";
            iconsFile.WriteAllText(code);

            Log.Information("Icons.cs file has been generated.");
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

public record IconName(string Name)
{
    public string PropertyName => GetIconPropertyNames();
    public string CssClasses => GetCssClasses();

    private static readonly HashSet<string> weights = new(StringComparer.OrdinalIgnoreCase)
    {
        "thin", "light", "regular", "bold", "fill", "duotone"
    };

    private string GetWeight()
    {
        var parts = Name.Split('-');

        return weights.Contains(parts[^1])
            ? parts[^1].ToLowerInvariant()
            : "regular";
    }

    private string GetBaseName()
    {
        var parts = Name.Split('-');

        return weights.Contains(parts[^1])
            ? string.Join("-", parts.Take(parts.Length - 1))
            : Name;
    }

    private string GetCssClasses()
    {
        var weight = GetWeight();
        var baseName = GetBaseName().ToLowerInvariant();

        var sb = new StringBuilder();

        if (weight == "regular")
        {
            sb.Append("ph");
        }
        else
        {
            sb.Append($"ph-{weight}");
        }

        sb.Append($" ph-{baseName}");

        return sb.ToString();
    }

    private string GetIconPropertyNames()
    {
        var baseName = GetBaseName();
        return ConvertKebabToPascal(baseName);
    }

    private string ConvertKebabToPascal(string kebabCase)
    {
        var words = kebabCase
            .Split('-')
            .Select(word => char.ToUpperInvariant(word[0]) + word[1..]);

        return string.Concat(words);
    }
}