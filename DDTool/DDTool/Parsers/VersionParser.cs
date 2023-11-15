using System;
using System.Xml;
using System.Linq;
using DDTool.Exceptions;
using DDTool.Structures;

namespace DDTool.Parsers;

public static class VersionParser
{
    public static void SetVersionInfo(XmlDocument doc, DataDictionary dd)
    {
        dd.MajorVersion = int.Parse(doc.SelectSingleNode("/fix/@major").Value);
        dd.MinorVersion = int.Parse(doc.SelectSingleNode("/fix/@minor").Value);

        XmlNode node = doc.SelectSingleNode("/fix/@type");
        if (node != null)
        {
            if (new[] { "FIX", "FIXT" }.Contains(node.Value) == false)
                throw new ParsingException($"Unsupported /fix/type value: '{node.Value}' (expected FIX or FIXT)");

            if (node.Value == "FIXT")
                dd.IsFIXT = true;
        }

        node = doc.SelectSingleNode("/fix/@servicepack");
        if (node != null && !string.IsNullOrEmpty(node.Value)) {
            dd.ServicePack = int.Parse(node.Value);
            if (dd.ServicePack == 0)
                dd.ServicePack = null;
        }
    }
}
