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
            foreach (XmlNode fldEl in node.SelectNodes(".//field"))
            {
                DDField fld = FieldsByName[fldEl.Attributes["name"].Value];
                if(fldEl.Attributes["required"].Value == "Y") {
                    fld.Required = true;
                }
                if (!ddmap.Fields.ContainsKey(fld.Tag))
                {
                    ddmap.Fields.Add(fld.Tag, fld);
                }
            }
            foreach (XmlNode grpEl in node.SelectNodes(".//group"))
            {
                DDField fld = FieldsByName[grpEl.Attributes["name"].Value];
                DDGrp grp = new DDGrp();
                if (grpEl.Attributes["required"].Value == "Y") {
                    fld.Required = true;
                    grp.Required = true;
                }
                grp.Delim = fld;
                parseMsgEl(grpEl, grp);
                ddmap.Groups.Add(fld.Tag, grp);
            }

            foreach (XmlNode compEl in node.SelectNodes(".//component"))
            {
                String name = compEl.Attributes["name"].Value;
                XmlNode compNode = RootDoc.SelectSingleNode("//components/component[@name='" + name + "']");
                parseMsgEl(compNode, ddmap);
            }
        }
    }
}
