using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DDTool.Structures;

namespace DDTool.Generators;

public static class GenMessages {

    /// <summary>
    ///
    /// </summary>
    /// <param name="baseDir"></param>
    /// <param name="dd"></param>
    /// <returns>List of filenames that were written</returns>
    public static List<string> WriteFilesForDD(string baseDir, DataDictionary dd) {
        List<string> rv = new();
        rv.Add(WriteBaseMessageFile(baseDir, dd));
        foreach (var msg in dd.Messages.Values) {
            rv.Add(WriteMessageFile(baseDir, msg, dd));
        }

        rv.Sort();
        return rv;
    }

    private static string WriteBaseMessageFile(string baseDir, DataDictionary dd) {
        var beginString = dd.IdentifierNoDots.Contains("FIX50") ? "FIXT11" : dd.IdentifierNoDots;
        string filePath = Path.Join($"{baseDir}", "Messages", dd.IdentifierNoDots, "Message.cs");

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "namespace QuickFix",
            "{",
            $"    namespace {dd.IdentifierNoDots}",
            "    {",
            "        public abstract class Message : QuickFix.Message",
            "        {",
            "            public Message()",
            "                : base()",
            "            {",
            $"                this.Header.SetField(new QuickFix.Fields.BeginString(QuickFix.FixValues.BeginString.{beginString}));",
            "            }",
            "        }",
            "    }",
            "}"
        };

        File.WriteAllText(filePath, string.Join(Environment.NewLine, lines) + "\n");

        return filePath;
    }

    private static string WriteMessageFile(string baseDir, DDMessage msg, DataDictionary dd) {
        var beginString = dd.IdentifierNoDots.Contains("FIX50") ? "FIXT11" : dd.IdentifierNoDots;
        string filePath = Path.Join($"{baseDir}", "Messages", dd.IdentifierNoDots, $"{msg.Name}.cs");

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "using QuickFix.Fields;",
            "namespace QuickFix",
            "{",
            $"    namespace {dd.IdentifierNoDots}",
            "    {",
            $"        public class {msg.Name} : Message",
            "        {",
            $"            public const string MsgType = \"{msg.MsgType}\";",
            "",
            $"            public {msg.Name}() : base()",
            "            {",
            $"                this.Header.SetField(new QuickFix.Fields.MsgType(\"{msg.MsgType}\"));",
            "            }",
            ""
        };

        if (msg.RequiredFields.Any()) {
            lines.AddRange(GenerateCtorWithRequiredFields(msg));
        } else {
            lines.Add("");
        }

        lines.AddRange(GenerateFields(msg, 12));
        lines.AddRange(GenerateGroups(msg, 12));

        lines.AddRange(new List<string>
        {
            "        }",
            "    }",
            "}"
        });

        File.WriteAllText(filePath, string.Join(Environment.NewLine, lines) + "\n");

        return filePath;
    }

    private static List<string> GenerateCtorWithRequiredFields(DDMessage msg) {
        List<string> rv = new();

        var requiredFields = msg.RequiredFields;

        if (requiredFields.Count < 1) {
            return new();
        }

        var reqArgs = requiredFields.Select(rf => $"{new string(' ', 20)}QuickFix.Fields.{rf.Name} a{rf.Name}");
        var reqSetters = requiredFields.Select(rf => $"{new string(' ', 16)}this.{rf.Name} = a{rf.Name};");

        rv.Add($"            public {msg.Name}(");
        foreach (var arg in reqArgs) {
            if (arg == reqArgs.Last())
                rv.Add(arg);
            else
                rv.Add(arg + ",");
        }

        rv.Add("                ) : this()");
        rv.Add("            {");
        foreach (var setter in reqSetters) {
            rv.Add(setter);
        }
        rv.Add("            }");
        rv.Add("");

        return rv;
    }

    private static List<string> GenerateFields(IElementSequence seq, int indentSpaces) {
        List<string> rv = new();

        foreach (IElement el in seq.Elements.Values) {
            rv.AddRange(GenerateSingleField(el, seq, indentSpaces));
        }

        return rv;
    }

    private static List<string> GenerateSingleField(IElement field, IElementSequence seq, int indentSpaces) {
        var fldName = field.Name;
        if (field.Name == seq.Name) {
            fldName += "_";
        }

        var lines = new List<string>
        {
            $"public QuickFix.Fields.{field.Name} {fldName}",
            "{",
            "    get",
            "    {",
            $"        QuickFix.Fields.{field.Name} val = new QuickFix.Fields.{field.Name}();",
            "        GetField(val);",
            "        return val;",
            "    }",
            "    set { SetField(value); }",
            "}",
            "",
            $"public void Set(QuickFix.Fields.{field.Name} val)",
            "{",
            $"    this.{fldName} = val;",
            "}",
            "",
            $"public QuickFix.Fields.{field.Name} Get(QuickFix.Fields.{field.Name} val)",
            "{",
            "    GetField(val);",
            "    return val;",
            "}",
            "",
            // TODO: this "val" param is never used!  I'm going to deprecate this function and then get rid of it.  It's stupid.
            $"public bool IsSet(QuickFix.Fields.{field.Name} val)",
            "{",
            $"    return IsSet{field.Name}();",
            "}",
            "",
            $"public bool IsSet{field.Name}()",
            "{",
            $"    return IsSetField(Tags.{field.Name});",
            "}",
            ""
        };

        var indent = new string(' ', indentSpaces);
        var rv = lines.Select(line => string.IsNullOrEmpty(line) ? "" : (indent + line)).ToList();
        return rv;
    }

    private static List<string> GenerateGroups(IElementSequence seq, int indentSpaces) {
        List<string> rv = new();

        foreach (DDGroup grp in seq.Groups) {
            rv.AddRange(GenerateSingleGroup(grp, indentSpaces));
        }

        return rv;
    }

    private static List<string> GenerateSingleGroup(DDGroup group, int indentSpaces) {
        List<string> fieldOrderStrings = group.Elements.Values.Select(ddf => $"Tags.{ddf.Name}").ToList();
        fieldOrderStrings.Add("0"); // TODO all QFs do this, I should figure out why

        var lines = new List<string>
        {
            $"public class {group.Name}Group : Group",
            "{",
            $"    public static int[] fieldOrder = {{{string.Join(", ", fieldOrderStrings)}}};",
            "",
            $"    public {group.Name}Group()",
            $"      : base(Tags.{group.CounterField.Name}, Tags.{group.Delimiter.Name}, fieldOrder)",
            "    {",
            "    }",
            "",
            "    public override Group Clone()",
            "    {",
            $"        var clone = new {group.Name}Group();",
            "        clone.CopyStateFrom(this);",
            "        return clone;",
            "    }",
            ""
        };

        lines.AddRange(GenerateFields(group, 4));
        lines.AddRange(GenerateGroups(group, 4));

        // this line just to keep it the same as current impl
        if (!group.Groups.Any())
            lines.Add("");

        lines.Add("}");

        var indent = new string(' ', indentSpaces);
        var rv = lines.Select(line => string.IsNullOrEmpty(line) ? "" : (indent + line)).ToList();
        return rv;
    }
}
