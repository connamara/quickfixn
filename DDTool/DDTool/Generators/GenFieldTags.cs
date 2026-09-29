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
    /// <param name="fieldsTagsPath"></param>
    /// <param name="ddName"></param>
    /// <param name="fields"></param>
    /// <returns></returns>
    public static string WriteFile(string fieldsTagsPath, string? ddName, List<DDField> fields) 
    {
        Directory.CreateDirectory(
            Path.GetDirectoryName(fieldsTagsPath)!);
        File.WriteAllText(fieldsTagsPath, Generate(fields, ddName));
        return fieldsTagsPath;
    }

    private static string Generate(List<DDField> fields, string? ddName) {

        string ns = ddName != null
            ? $"QuickFix.{ddName}.Fields" 
            : "QuickFix.Fields";

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            $"namespace {ns};",
            "",
            "/// <summary>",
            "/// FIX Field Tag Values",
            "/// </summary>",
            "public static class Tags",
            "{"
        };

        foreach (var fld in fields)
            lines.Add($"    public const int {fld.Name} = {fld.Tag};");

        lines.Add("}");
        lines.Add("");

        return string.Join(Environment.NewLine, lines);
    }
}
