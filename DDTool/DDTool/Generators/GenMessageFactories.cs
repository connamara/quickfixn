using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DDTool.Structures;

namespace DDTool.Generators;

public static class GenMessageFactories {
    public static List<string> WriteFiles(string baseDir, List<DataDictionary> dds) {
        List<string> rv = new();
        foreach (var dd in dds.OrderBy(x => x.Identifier)) {
            rv.Add(WriteFile(baseDir, dd));
        }

        return rv;
    }

    private static string WriteFile(string baseDir, DataDictionary dd) {
        string filePath = Path.Join(baseDir, "Messages", dd.IdentifierNoDots, "MessageFactory.cs");
        File.WriteAllText(filePath, Generate(dd));
        return filePath;
    }

    private static string Generate(DataDictionary dd) {
        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "using System.Collections.Generic;",
            "using QuickFix.FixValues;",
            "",
            "namespace QuickFix",
            "{",
            $"    namespace {dd.IdentifierNoDots}",
            "    {",
            "        public class MessageFactory : IMessageFactory",
            "        {",
            "            public ICollection<string> GetSupportedBeginStrings()",
            "            {",
            $"                return new [] {{ BeginString.{dd.IdentifierNoDots} }};",
            "            }",
            "",
            "",
            "            public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)",
            "            {",
            "                return Create(beginString, msgType);",
            "            }",
            "",
            "",
            "            public QuickFix.Message Create(string beginString, string msgType)",
            "            {",
            "                switch (msgType)",
            "                {"
        };

        // TODO: foreach order is technically non-deterministic (though not in practice)
        foreach (var msg in dd.Messages.Values) {
            var fullname = $"QuickFix.{dd.IdentifierNoDots}.{msg.Name}";
            lines.Add(new string(' ', 20) + $"case {fullname}.MsgType: return new {fullname}();");
        }

        lines.AddRange(new List<string>
        {
            "                }",
            "",
            "                return new QuickFix.Message();",
            "            }",
            "",
            "",
            "            public Group Create(string beginString, string msgType, int correspondingFieldID)",
            "            {"
        });

        // TODO: foreach order is technically non-deterministic (though not in practice)
        foreach (var msg in dd.Messages.Values) {

            var groups = msg.Groups;
            if (!groups.Any())
                continue;

            List<string> xLines = new();

            xLines.Add($"if (QuickFix.{dd.IdentifierNoDots}.{msg.Name}.MsgType.Equals(msgType))");
            xLines.Add("{");
            xLines.Add("    switch (correspondingFieldID)");
            xLines.Add("    {");

            foreach (var group in groups) {
                AppendGroupCases(xLines, group, $"QuickFix.{dd.IdentifierNoDots}.{msg.Name}");
            }

            xLines.Add("    }");
            xLines.Add("}");

            // indent lines
            lines.AddRange(xLines.Select(xl => new string(' ', 16) + xl));
            lines.Add("");
        }

        lines.AddRange(new List<string>{
            "                return null;",
            "            }",
            "",
            "        }",
            "    }",
            "}",
            ""
        });

        return string.Join(Environment.NewLine, lines);
    }

    private static void AppendGroupCases(List<string> lines, DDGroup group, string namePath) {
        var newNamePath = $"{namePath}.{group.Name}Group";
        lines.Add(
            $"        case QuickFix.Fields.Tags.{group.Name}: return new {newNamePath}();");

        var subgroups = group.Elements.Values.OfType<DDGroup>();
        foreach (var subgroup in subgroups) {
            AppendGroupCases(lines, subgroup, newNamePath);
        }
    }
}

