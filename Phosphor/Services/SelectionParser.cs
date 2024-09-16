namespace Phosphor.Services;

public class SelectionParser
{
    public void GenerateIconClasses()
    {
        var iconsNamespace = new NamespaceBuilder("Phosphor.Components");
        var iconsClass = new ClassBuilder("Icons", "public", isStatic: true);
        var phosphorClass = new ClassBuilder("Phosphor", "public", isStatic: true);

        string[] styles = ["Bold", "Duotone", "Fill", "Light", "Regular", "Thin"];

        foreach (var style in styles)
        {
            var styleClass = new ClassBuilder(style, "public", isStatic: true);
            var iconNames = GetIconNames(style.ToLower());
            
            foreach (var iconName in iconNames)
            {
                var constant = new ConstantBuilder("string", ConvertKebabToPascal(iconName), $"ph ph-{iconName.ToLower()}");
                styleClass.AddConstant(constant);
            }

            phosphorClass.AddNestedClass(styleClass);
        }

        iconsClass.AddNestedClass(phosphorClass);
        iconsNamespace.AddClass(iconsClass);

        string code = iconsNamespace.Build();
        
        // Write code to file
        File.WriteAllText("PhosphoreIcons.cs", code);

        Console.WriteLine("Icons.cs file has been generated.");
    }
    
    public string ConvertKebabToPascal(string kebab)
    {
        var words = kebab
            .Split('-')
            .Select(word => word.First().ToString().ToUpper() + word[1..]);
        
        var pascal = string.Join("", words);
        
        return pascal;
    }
    
    public List<string> GetIconNames(string style)
    {
        // read wwwroot/fonts/{style}/selection.json
        var path = Path.Combine("wwwroot", "fonts", style, "selection.json");
        var json = File.ReadAllText(path);

        // parse JSON using QuickType
        var selection = Selection.FromJson(json);
        
        // return icon names
        var iconNames = selection.Icons
            .Select(iconElement => iconElement.Properties.Name)
            .ToList();
        
        return iconNames;
    }
}