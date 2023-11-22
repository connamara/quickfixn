using System;
using System.Collections.Generic;
using System.Xml;
using DDTool.Structures;

namespace DDTool.Parsers;

public static class FieldParser {
    public static void ParseFields(XmlDocument doc, DataDictionary dd) {
        XmlNodeList nodeList = doc.SelectNodes("//fields/field")!;
        foreach (XmlNode fldEl in nodeList) {
            dd.AddField(CreateField(fldEl));
        }
    }

    private static DDField CreateField(XmlNode node) {
        string tagstr = node.Attributes["number"].Value;
        string name = node.Attributes["name"].Value;
        string fldType = node.Attributes["type"].Value;
        int tag = int.Parse(tagstr);
        List<EnumValue> enums = new();

        if (node.HasChildNodes) {
            foreach (XmlNode enumEl in node.SelectNodes(".//value")) {
                if (enumEl.Attributes["description"] is null)
                    throw new Exception($"Node {tagstr}/{name} contains a <value> without a 'description' attribute");
                if (enumEl.Attributes["enum"] is null)
                    throw new Exception($"Node {tagstr}/{name} contains a <value> without a 'enum' attribute");

                enums.Add(new EnumValue(
                    enumEl.Attributes["description"].Value,
                    enumEl.Attributes["enum"].Value));
            }
        }

        return new DDField(tag, name, enums, fldType);
    }
}
