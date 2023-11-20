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
    /// <param name="baseDir"></param>
    /// <param name="fields"></param>
    /// <returns></returns>
    public static string WriteFile(string baseDir, List<DDField> fields) {
        string fieldsPath = Path.Join(baseDir, "QuickFIXn", "Fields", "Fields.cs");
        File.WriteAllText(fieldsPath, Generate(fields));
        return fieldsPath;
    }

    private static string Generate(List<DDField> fields) {
        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "using System;",
            "",
            "namespace QuickFix.Fields",
            "{"
        };

        foreach (var field in fields) {
            switch (field.CsClass) {
                case "DateTimeField":
                case "TimeOnlyField":
                    AppendDateField(lines, field);
                    break;
                default:
                    AppendNonDateField(lines, field);
                    break;
            }
        }

        lines.Add("}");
        lines.Add("");
        return string.Join(Environment.NewLine, lines);
    }

    private static void AppendDateField(List<string> lines, DDField field) {
        lines.Add("    /// <summary>");
        lines.Add($"    /// {field.Name} Field");
        lines.Add("    /// </summary>");
        lines.Add($"    public sealed class {field.Name} : {field.CsClass}");
        lines.Add("    {");
        lines.Add($"        public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"        public {field.Name}()");
        lines.Add($"            :base(Tags.{field.Name}) {{}}");
        lines.Add($"        public {field.Name}({field.BaseType} val)");
        lines.Add($"            :base(Tags.{field.Name}, val) {{}}");
        lines.Add($"        public {field.Name}({field.BaseType} val, bool showMilliseconds)");
        lines.Add($"            :base(Tags.{field.Name}, val, showMilliseconds) {{}}");
        lines.Add($"        public {field.Name}({field.BaseType} val, Converters.TimeStampPrecision precision)");
        lines.Add($"            :base(Tags.{field.Name}, val, precision) {{}}");
        lines.Add("");

        AppendFieldEnumerations(lines, field);

        lines.Add("    }");
        lines.Add("");
        lines.Add("");
    }

    private static void AppendNonDateField(List<string> lines, DDField field) {
        lines.Add("    /// <summary>");
        lines.Add($"    /// {field.Name} Field");
        lines.Add("    /// </summary>");
        lines.Add($"    public sealed class {field.Name} : {field.CsClass}");
        lines.Add("    {");
        lines.Add($"        public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"        public {field.Name}()");
        lines.Add($"            :base(Tags.{field.Name}) {{}}");
        lines.Add($"        public {field.Name}({field.BaseType} val)");
        lines.Add($"            :base(Tags.{field.Name}, val) {{}}");
        lines.Add("");

        AppendFieldEnumerations(lines, field);

        lines.Add("    }");
        lines.Add("");
        lines.Add("");
    }

    private static void AppendFieldEnumerations(List<string> lines, DDField field) {
        if (field.Enums.Count < 1)
            return;

        lines.Add("");
        lines.Add("        // Field Enumerations");

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

            lines.Add($"        public const {field.BaseType} {desc} = {outVal};");
        }
    }
}
