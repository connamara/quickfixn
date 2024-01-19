using System;
using System.Xml;
using DDTool.Exceptions;
using DDTool.Structures;

namespace DDTool.Parsers;

public static class MessageParser {
    public static void ParseMessages(XmlDocument doc, DataDictionary dd) {
        XmlNodeList nodeList = doc.SelectNodes("//messages/message");
        foreach (XmlNode msgNode in nodeList) {
            dd.AddMessage(CreateMessage(msgNode, dd, doc));
        }
    }

    private static DDMessage CreateMessage(XmlNode node, DataDictionary dd, XmlDocument doc) {
        var ddMsg = new DDMessage(
            node.Attributes["name"].Value,
            node.Attributes["msgtype"].Value,
            node.Attributes["msgcat"].Value);

        foreach (XmlNode childNode in node.ChildNodes)
            ReadChildNode(childNode, ddMsg, dd, doc);

        return ddMsg;
    }

    private static DDGroup CreateGroup(XmlNode node, DataDictionary dd, XmlDocument doc) {
        var groupName = node.Attributes["name"].Value;
        var counterField = dd.LookupField(groupName);

        if (node.ChildNodes.Count < 1)
            throw new ParsingException(
                $"Group {groupName} is illegal.  It must have at least one child (the delimiter).");

        DDGroup ddGroup = new DDGroup(counterField);

        foreach (XmlNode childNode in node.ChildNodes) {
            ReadChildNode(childNode, ddGroup, dd, doc);
        }

        return ddGroup;
    }

    private static void ReadChildNode(
        XmlNode childNode, IElementSequence elSeq, DataDictionary dd, XmlDocument doc, bool overrideReq = false) {
        bool req = childNode.Attributes["required"]?.Value == "Y" && !overrideReq;

        switch (childNode.Name.ToLowerInvariant()) {
            case "field":
                elSeq.AddElement(dd.LookupField(childNode.Attributes["name"].Value), req);
                break;

            case "group":
                elSeq.AddElement(CreateGroup(childNode, dd, doc), req);
                break;

            case "component":
                var componentName = childNode.Attributes["name"].Value;
                XmlNode compNode = doc.SelectSingleNode($"//components/component[@name='{componentName}']");

                if (compNode == null)
                    throw new ParsingException($"Can't find component: {componentName}");

                foreach (XmlNode innerCompNode in compNode.ChildNodes)
                    ReadChildNode(innerCompNode, elSeq, dd, doc, !req);

                break;

            default:
                throw new ParsingException(
                    $"Unrecognized or unsupported child node type \"{childNode.Name}\" within \"{elSeq.Name}\"");
        }
    }
}
