using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using DDTool.Structures;

namespace DDTool.Generators;

/// <summary>
/// Generates QuickFIXn/Fields/Fields.cs
/// </summary>
public static class GenFields {
    /// <summary>
    /// Returns path of file that is written
    /// </summary>
    /// <param name="fieldsPath"></param>
    /// <param name="ddName"></param>
    /// <param name="fields"></param>
    /// <returns></returns>
    public static string WriteFile(string fieldsPath, string? ddName, List<DDField> fields)
    {
        Directory.CreateDirectory(
            Path.GetDirectoryName(fieldsPath)!);
        File.WriteAllText(fieldsPath, Generate(fields, ddName));
        return fieldsPath;
    }

    private static string Generate(List<DDField> fields, string? ddName) {
        var ns = ddName != null
            ? $"QuickFix.{ddName}.Fields"
            : "QuickFix.Fields";

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "using System;",
            "using QuickFix.Fields;",
            "",
            "using SeqNumType = System.UInt64;",
            "using SeqNumFieldType = QuickFix.Fields.ULongField;",
            "",
            $"namespace {ns};",
        };
        foreach (var field in fields) {
            lines.Add("");
            switch (field.CsClass) {
                case "DateTimeField":
                    AppendDateTimeField(lines, field);
                    break;
                case "TimeOnlyField":
                    AppendTimeOnlyField(lines, field);
                    break;
                default:
                    AppendVanillaField(lines, field);
                    break;
            }
        }

        lines.Add("");
        return string.Join(Environment.NewLine, lines);
    }

    private static void AppendDateTimeField(List<string> lines, DDField field) {
        lines.Add("/// <summary>");
        lines.Add($"/// {field.Name} Field");
        lines.Add("/// </summary>");
        lines.Add($"public sealed class {field.Name} : {field.CsClass}");
        lines.Add("{");
        lines.Add($"    public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"    public {field.Name}()");
        lines.Add($"        : base(Tags.{field.Name}) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val)");
        lines.Add($"        : base(Tags.{field.Name}, val) {{}}");
        lines.Add("    [Obsolete(\"Use the ctor that takes TimePrecision instead.  This ctor will be removed in 1.15.\")]");
        lines.Add($"    public {field.Name}({field.BaseType} val, bool showMilliseconds)");
        lines.Add($"        : base(Tags.{field.Name}, val, showMilliseconds) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val, TimePrecision precision)");
        lines.Add($"        : base(Tags.{field.Name}, val, precision) {{}}");

        AppendFieldEnumerations(lines, field);

        lines.Add("}");
    }

    private static void AppendTimeOnlyField(List<string> lines, DDField field) {
        lines.Add("/// <summary>");
        lines.Add($"/// {field.Name} Field");
        lines.Add("/// </summary>");
        lines.Add($"public sealed class {field.Name} : {field.CsClass}");
        lines.Add("{");
        lines.Add($"    public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"    public {field.Name}()");
        lines.Add($"        : base(Tags.{field.Name}) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val)");
        lines.Add($"        : base(Tags.{field.Name}, val) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val, TimePrecision precision)");
        lines.Add($"        : base(Tags.{field.Name}, val, precision) {{}}");

        AppendFieldEnumerations(lines, field);

        lines.Add("}");
    }

    private static void AppendVanillaField(List<string> lines, DDField field) {
        lines.Add("/// <summary>");
        lines.Add($"/// {field.Name} Field");
        lines.Add("/// </summary>");
        lines.Add($"public sealed class {field.Name} : {field.CsClass}");
        lines.Add("{");
        lines.Add($"    public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"    public {field.Name}()");
        lines.Add($"        : base(Tags.{field.Name}) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val)");
        lines.Add($"        : base(Tags.{field.Name}, val) {{}}");

        AppendFieldEnumerations(lines, field);

        lines.Add("}");
    }

    private static void AppendFieldEnumerations(List<string> lines, DDField field) {
        if (field.Enums.Count < 1)
            return;

        lines.Add("");
        lines.Add("    // Field Enumerations");

        foreach (var enumVal in field.Enums) {
            string desc = enumVal.Desc.Replace('.', '_');

            if (Regex.IsMatch(desc, @"^(\d+)(.*)")) {
                desc = $"VAL_{desc}";
            }

            string outVal = field.BaseType switch
            {
                "int" => enumVal.Val,
                "string" => $"\"{enumVal.Val}\"",
                "char" => $"'{enumVal.Val}'",
                "Boolean" => enumVal.Val == "Y" ? "true" : "false",
                _ => throw new Exception(
                    $"unsupported field type '{field.BaseType}' ({field})")
            };

            lines.Add($"    public const {field.BaseType} {desc} = {outVal};");
        }
    }
}
