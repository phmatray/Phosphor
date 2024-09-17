using System.Collections.Generic;
using System.Text;

namespace Helpers;

public class NamespaceBuilder(string namespaceName)
{
    private readonly List<ClassBuilder> Classes = [];

    public NamespaceBuilder AddClass(ClassBuilder classBuilder)
    {
        Classes.Add(classBuilder);
        return this;
    }

    public string Build(int indentLevel = 0)
    {
        var indent = new string(' ', indentLevel * 4);
        var sb = new StringBuilder();

        sb.AppendLine($"{indent}namespace {namespaceName}");
        sb.AppendLine($"{indent}{{");
        foreach (var classBuilder in Classes)
        {
            sb.Append(classBuilder.Build(indentLevel + 1));
        }
        sb.AppendLine($"{indent}}}");
        return sb.ToString();
    }
}

public class ClassBuilder(
    string className,
    string accessModifier = "public",
    bool isStatic = false)
{
    private readonly List<ClassBuilder> NestedClasses = [];
    private readonly List<ConstantBuilder> Constants = [];

    public ClassBuilder AddNestedClass(ClassBuilder classBuilder)
    {
        NestedClasses.Add(classBuilder);
        return this;
    }

    public ClassBuilder AddConstant(ConstantBuilder constantBuilder)
    {
        Constants.Add(constantBuilder);
        return this;
    }

    public string Build(int indentLevel)
    {
        var indent = new string(' ', indentLevel * 4);
        var staticText = isStatic ? "static " : "";
        var sb = new StringBuilder();

        sb.AppendLine($"{indent}{accessModifier} {staticText}class {className}");
        sb.AppendLine($"{indent}{{");

        foreach (var constant in Constants)
        {
            sb.AppendLine(constant.Build(indentLevel + 1));
        }

        foreach (var nestedClass in NestedClasses)
        {
            sb.Append(nestedClass.Build(indentLevel + 1));
        }

        sb.AppendLine($"{indent}}}");
        return sb.ToString();
    }
}

public class ConstantBuilder(
    string type,
    string name,
    string value,
    string accessModifier = "public")
{
    public string Build(int indentLevel)
    {
        var indent = new string(' ', indentLevel * 4);
        return $"{indent}{accessModifier} const {type} {name} = \"{value}\";";
    }
}
