using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Helpers;
using Nuke.Common;
using Nuke.Common.IO;
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

            Log.Information("Icons.cs file has been generated");
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