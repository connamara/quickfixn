using System;
using System.Collections.Generic;
using System.IO;
using DDTool.Structures;

namespace DDTool.Generators;

/// <summary>
/// Generates QuickFIXn/Fields/FieldTags.cs
/// </summary>
public static class GenFieldTags {
    /// <summary>
    /// Returns path of file that is written
    /// </summary>
    /// <param name="baseDir"></param>
    /// <param name="fields"></param>
    /// <returns></returns>
    public static string WriteFile(string baseDir, List<DDField> fields) {
        string fieldTagsPath = Path.Join(baseDir, "QuickFIXn", "Fields", "FieldTags.cs");
        File.WriteAllText(fieldTagsPath, Generate(fields));
        return fieldTagsPath;
    }

    private static string Generate(List<DDField> fields) {
        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "using System;",
            "",
            "namespace QuickFix.Fields",
            "{",
            "    /// <summary>",
            "    /// FIX Field Tag Values",
            "    /// </summary>",
            "    public static class Tags",
            "    {"
        };

        foreach (var fld in fields)
            lines.Add($"        public const int {fld.Name} = {fld.Tag};");

        lines.Add("    }");
        lines.Add("}");
        lines.Add("");

        return string.Join(Environment.NewLine, lines);
    }
}
