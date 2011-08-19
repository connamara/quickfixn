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

		public void Load(String path) {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            setVersionInfo(doc);
            parseFields(doc);
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
                String tagstr = fldEl.Attributes["number"].Value;
                String name = fldEl.Attributes["name"].Value;
                String fldType = fldEl.Attributes["type"].Value;
                int tag = QuickFix.Fields.Converters.IntConverter.Convert(tagstr);
                HashSet<String> enums = new HashSet<string>();
                if (fldEl.HasChildNodes)
                {
                    foreach(XmlNode enumEl in fldEl.SelectNodes(".//value"))
                    {
                        enums.Add(enumEl.Attributes["enum"].Value);
                    }
                }
                DDField fld = new DDField(tag, name, enums, fldType);
                FieldsByTag[tag] = fld;
                FieldsByName[fld.Name] = fld;
            }
        }
    }
}
