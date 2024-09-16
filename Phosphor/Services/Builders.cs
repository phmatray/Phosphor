using System;
using System.Collections.Generic;
using System.Text;

namespace Phosphor.Services;

public class NamespaceBuilder
{
    private string _namespaceName;
    private List<ClassBuilder> _classes = new List<ClassBuilder>();

    public NamespaceBuilder(string namespaceName)
    {
        _namespaceName = namespaceName;
    }

    public NamespaceBuilder AddClass(ClassBuilder classBuilder)
    {
        _classes.Add(classBuilder);
        return this;
    }

    public string Build(int indentLevel = 0)
    {
        var indent = new string(' ', indentLevel * 4);
        var sb = new StringBuilder();

        sb.AppendLine($"{indent}namespace {_namespaceName}");
        sb.AppendLine($"{indent}{{");
        foreach (var classBuilder in _classes)
        {
            sb.Append(classBuilder.Build(indentLevel + 1));
        }
        sb.AppendLine($"{indent}}}");
        return sb.ToString();
    }
}

public class ClassBuilder
{
    private string _className;
    private string _accessModifier;
    private bool _isStatic;
    private List<ClassBuilder> _nestedClasses = new List<ClassBuilder>();
    private List<ConstantBuilder> _constants = new List<ConstantBuilder>();

    public ClassBuilder(string className, string accessModifier = "public", bool isStatic = false)
    {
        _className = className;
        _accessModifier = accessModifier;
        _isStatic = isStatic;
    }

    public ClassBuilder AddNestedClass(ClassBuilder classBuilder)
    {
        _nestedClasses.Add(classBuilder);
        return this;
    }

    public ClassBuilder AddConstant(ConstantBuilder constantBuilder)
    {
        _constants.Add(constantBuilder);
        return this;
    }

    public string Build(int indentLevel)
    {
        var indent = new string(' ', indentLevel * 4);
        var staticText = _isStatic ? "static " : "";
        var sb = new StringBuilder();

        sb.AppendLine($"{indent}{_accessModifier} {staticText}class {_className}");
        sb.AppendLine($"{indent}{{");

        foreach (var constant in _constants)
        {
            sb.AppendLine(constant.Build(indentLevel + 1));
        }

        foreach (var nestedClass in _nestedClasses)
        {
            sb.Append(nestedClass.Build(indentLevel + 1));
        }

        sb.AppendLine($"{indent}}}");
        return sb.ToString();
    }
}

public class ConstantBuilder
{
    private string _type;
    private string _name;
    private string _value;
    private string _accessModifier;

    public ConstantBuilder(string type, string name, string value, string accessModifier = "public")
    {
        _type = type;
        _name = name;
        _value = value;
        _accessModifier = accessModifier;
    }

    public string Build(int indentLevel)
    {
        var indent = new string(' ', indentLevel * 4);
        return $"{indent}{_accessModifier} const {_type} {_name} = \"{_value}\";";
    }
}
