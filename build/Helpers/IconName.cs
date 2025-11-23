using System;
using System.Collections.Generic;
using System.Linq;

public record IconName(string Name)
{
    public string PropertyName => GetIconPropertyNames();
    public string CssClasses => GetCssClasses();

    private static readonly HashSet<string> Weights = new(StringComparer.OrdinalIgnoreCase)
    {
        "thin", "light", "regular", "bold", "fill", "duotone"
    };

    private string GetWeight()
    {
        var parts = Name.Split('-');

        return Weights.Contains(parts[^1])
            ? parts[^1].ToLowerInvariant()
            : "regular";
    }

    private string GetBaseName()
    {
        var parts = Name.Split('-');

        return Weights.Contains(parts[^1])
            ? string.Join("-", parts.Take(parts.Length - 1))
            : Name;
    }

    private string GetCssClasses()
    {
        var weight = GetWeight();
        var baseName = GetBaseName().ToLowerInvariant();

        var sb = new System.Text.StringBuilder();

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