using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;

namespace QuickFix.DataDictionary
{
    public class DD2
    {
		public string MajorVersion { get; private set; }
		public string MinorVersion { get; private set; }
		public string Version { get; private set; }
        public Dictionary<int, DDField> FieldsByTag = new Dictionary<int, DDField>();
        public Dictionary<String, DDField> FieldsByName = new Dictionary<string, DDField>();
        public Dictionary<String, DDMap> Messages = new Dictionary<string, DDMap>();
        private XmlDocument RootDoc;

        public bool CheckFieldsOutOfOrder { get; set; }
        public bool CheckFieldsHaveValues { get; set; }
        public bool CheckUserDefinedFields { get; set; }

        public DD2()
        {
        }

        public DD2(String path)
            :this()
        {
            Load(path);
        }

        public void Validate(Message message, DD2 sessionDataDict, DD2 appDataDict, string beginString, string msgType)
        {
        }

        public void Validate(Message message, string beginString, string msgType)
        {
            Validate(message, false, beginString, msgType);
        }

        public void Validate(Message message, bool bodyOnly, string beginString, string msgType)
        {
            DD2 sessionDataDict = null;
            if (!bodyOnly)
                sessionDataDict = this;
            Validate(message, sessionDataDict, this, beginString, msgType);
        }

        public DD2(DD2 src)
        {
            this.Messages = src.Messages;
            this.FieldsByName = src.FieldsByName;
            this.FieldsByTag = src.FieldsByTag;
        }

        /// FIXME
        public bool IsHeaderField(int tag)
        {
            System.Console.WriteLine("FIXME - IsHeaderField not implemented!");
            return false;
        }

        /// FIXME
        public bool IsTrailerField(int tag)
        {
            System.Console.WriteLine("FIXME - IsTrailerField not implemented!");
            return false;
        }


		public void Load(String path) {
            XmlDocument doc = new XmlDocument();
            RootDoc = doc;
            doc.Load(path);
            setVersionInfo(doc);
            parseFields(doc);
            parseMessages(doc);
		}

        public Boolean FieldHasValue(int tag, String val) {
            return FieldsByTag[tag].Enums.Contains(val);
        }

        private void setVersionInfo(XmlDocument doc) {
            MajorVersion = doc.SelectSingleNode("/fix/@major").Value;
            MinorVersion = doc.SelectSingleNode("/fix/@minor").Value;
            Version = "FIX." + MajorVersion + "." + MinorVersion;
        }

        private void parseFields(XmlDocument doc)
        {
            XmlNodeList nodeList = doc.SelectNodes("//fields/field");
            foreach(XmlNode fldEl in nodeList) {
                DDField fld = newField(fldEl);
                FieldsByTag[fld.Tag] = fld;
                FieldsByName[fld.Name] = fld;
            }
        }

        private DDField newField(XmlNode fldEl)
        {
            String tagstr = fldEl.Attributes["number"].Value;
            String name = fldEl.Attributes["name"].Value;
            String fldType = fldEl.Attributes["type"].Value;
            int tag = QuickFix.Fields.Converters.IntConverter.Convert(tagstr);
            HashSet<String> enums = new HashSet<string>();
            if (fldEl.HasChildNodes)
            {
                foreach (XmlNode enumEl in fldEl.SelectNodes(".//value"))
                {
                    enums.Add(enumEl.Attributes["enum"].Value);
                }
            }
            return new DDField(tag, name, enums, fldType);
        }

        private void parseMessages(XmlDocument doc)
        {
            XmlNodeList nodeList = doc.SelectNodes("//messages/message");
            foreach (XmlNode msgEl in nodeList)
            {
                DDMap msg = new DDMap();
                parseMsgEl(msgEl, msg);
                String msgtype = msgEl.Attributes["msgtype"].Value;
                Messages.Add(msgtype, msg);
            }
        }

        private void parseMsgEl(XmlNode node, DDMap ddmap)
        {
            if (!node.HasChildNodes) { return; }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if( childNode.Name == "field" )
                {
                    DDField fld = FieldsByName[childNode.Attributes["name"].Value];
                    if (childNode.Attributes["required"].Value == "Y")
                    {
                        fld.Required = true;
                    }
                    if (!ddmap.Fields.ContainsKey(fld.Tag))
                    {
                        ddmap.Fields.Add(fld.Tag, fld);
                    }
                }
                else if(childNode.Name == "group")
                {
                    DDField fld = FieldsByName[childNode.Attributes["name"].Value];
                    DDGrp grp = new DDGrp();
                    if (childNode.Attributes["required"].Value == "Y")
                    {
                        fld.Required = true;
                        grp.Required = true;
                    }
                    grp.Delim = fld;
                    parseMsgEl(childNode, grp);
                    ddmap.Groups.Add(fld.Tag, grp);
                }
                else if(childNode.Name == "component")
                {
                    String name = childNode.Attributes["name"].Value;
                    XmlNode compNode = RootDoc.SelectSingleNode("//components/component[@name='" + name + "']");
                    parseMsgEl(compNode, ddmap);
                }
            }
        }
    }
}
