using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using QuickFix.DataDictionary;
using QuickFix.Fields;

namespace QuickFix.Util
{
    public class MessageSerializer : IMessageSerializer
    {
        private readonly DataDictionary.DataDictionary _dataDictionary;

        public MessageSerializer(DataDictionary.DataDictionary dataDictionary)
        {
            _dataDictionary = dataDictionary;
        }

        public XDocument ToXDocument(Message message)
        {
            string msgTypeStr = message.Header.GetField(Tags.MsgType);
            MsgType msgType = new MsgType(msgTypeStr);
            string msgName = _dataDictionary.GetEnumLabel(msgType);

            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", null));

            XElement root = new XElement("Message");
            root.Add(new XAttribute("MsgType", message.Header.GetField(Tags.MsgType)));
            root.Add(new XAttribute("MsgName", msgName));
            doc.Add(root);

            XElement header = new XElement("Header");
            root.Add(header);
            FieldMapToXml(message.Header, header, message.Header.HEADER_FIELD_ORDER);

            XElement body = new XElement("Body");
            root.Add(body);
            FieldMapToXml(message, body, new int[0]);

            XElement trailer = new XElement("Trailer");
            root.Add(trailer);
            FieldMapToXml(message.Trailer, trailer, new int[0]);

            // Cleanup namespaces decorations.
            foreach (XElement descendant in header.Descendants()
                                                  .Concat(body.Descendants())
                                                  .Concat(trailer.Descendants()))
            {
                descendant.Attributes().Where(x => x.IsNamespaceDeclaration).Remove();
                descendant.Name = descendant.Name.LocalName;
            }

            return doc;
        }

        public XmlDocument ToXmlDocument(Message message)
        {
            XDocument document = ToXDocument(message);
            XmlDocument xmlDocument = new XmlDocument();
            using (XmlReader xmlReader = document.CreateReader())
            {
                xmlDocument.Load(xmlReader);
            }

            return xmlDocument;
        }

        //public string ToJson(Message message)
        //{
        //    XmlDocument doc = ToXmlDocument(message);
        //    return JsonConvert.SerializeXmlNode(doc);
        //}

        private void FieldMapToXml(FieldMap fieldMap, XElement parent, int[] precedingFields)
        {
            // Sort by preceding tags first then by other tags.
            IEnumerable<int> sortedTags = fieldMap.Where(x => precedingFields.Contains(x.Key))
                                                  .Concat(fieldMap.Where(x => !precedingFields.Contains(x.Key)))
                                                  .Select(x => x.Key);

            AppendToXml(fieldMap, sortedTags, parent);
        }

        private void AppendToXml(FieldMap fieldMap, IEnumerable<int> sortedTags, XElement parent)
        {
            foreach (int tag in sortedTags)
            {
                XElement child;
                Type fieldType;
                string value = fieldMap.GetField(tag);

                if (_dataDictionary.TryGetFieldType(tag, out fieldType))
                {
                    DDField ddField = _dataDictionary.FieldsByTag[tag];

                    child = new XElement(ddField.Name);
                    child.Add(new XAttribute("Tag", tag));
                    child.Add(new XAttribute("FixType", ddField.FixFldType));

                    if (ddField.FixFldType == "DATA")
                    {
                        try
                        {
                            // Try to parse the value as XML content.
                            XElement data = XElement.Parse(value);
                            child.Add(new XAttribute("ContentType", "XML"));
                            child.Add(data);
                        }
                        catch
                        {
                            // XML parsing failed, add the value as CDATA.
                            XCData data = new XCData(value);
                            child.Add(new XAttribute("ContentType", "DATA"));
                            child.Add(data);
                        }
                    }
                    else
                    {
                        child.Add(new XAttribute("Value", value));
                    }

                    if (ddField.HasEnums())
                    {
                        child.Add(new XAttribute("HasEnums", true));
                        string enumValue = ddField.EnumDict
                                                  .FirstOrDefault(t => t.Key == value)
                                                  .Value;
                        if (!string.IsNullOrEmpty(enumValue))
                        {
                            child.Add(new XAttribute("EnumValue", enumValue));
                        }
                    }

                    int groupCount = fieldMap.GroupCount(tag);
                    if (groupCount > 0)
                    {
                        child.Add(new XAttribute("IsGroup", "Y"));
                        child.Add(new XAttribute("GroupCount", groupCount));
                        for (int i = 1; i <= groupCount; i++)
                        {
                            Group group = fieldMap.GetGroup(i, tag);
                            DDField grpDdField = _dataDictionary.FieldsByTag[group.Delim];
                            XElement grpElt = new XElement(grpDdField.Name + "Group" + i);
                            child.Add(grpElt);
                            FieldMapToXml(group, grpElt, new[] {group.Delim});
                        }
                    }
                }
                else
                {
                    child = new XElement("CustomTag_" + tag);
                    child.Add(new XAttribute("Tag", tag));
                    child.Add(new XAttribute("Value", value));
                }

                parent.Add(child);
            }
        }
    }
}
