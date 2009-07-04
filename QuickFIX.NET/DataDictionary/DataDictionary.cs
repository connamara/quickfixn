using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace QuickFIX.NET
{
    public sealed partial class DataDictionary
    {
        public DataDictionary()
        {
            this._fields = new HashSet<int>();
            this._fieldTypes = new Dictionary<int, FieldEntry>();
            this._fieldNameToTagMap = new Dictionary<string, int>();
        }

        public void Load( string filename )
        {
            XmlReader reader = new XmlTextReader(filename);
            reader.Read();
            if (!reader.LocalName.Equals("fix"))
                throw new DictionaryParseException("Invalid XML File - no FIX identifier at the top");
            MakeVersion(reader);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "fields":
                            ProcessFields(reader);
                            break;
                        case "messages":
                            ProcessMessages(reader);
                            break;
                    }
                }
            }
        }

        public int GetFieldTagFromName(string name)
        {
            if (_fieldNameToTagMap.ContainsKey(name))
                return _fieldNameToTagMap[name];
            else
                throw new FieldNotFoundException("field not found with name: "+name);
        }

        public bool ValidFieldTag(int tag)
        {
            return _fields.Contains(tag);
        }

        public Type GetFieldType(int tag)
        {
            if (_fieldTypes.ContainsKey(tag))
                return _fieldTypes[tag].FieldType;
            else
                throw new FieldNotFoundException(tag);
        }

        private void ProcessMessages(XmlReader reader)
        {
        }

        private void ProcessFields(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("field"))
                        AddField(reader);
                    else if(reader.LocalName.Equals("value"))
                        continue;
                    else
                        throw new DictionaryParseException("bad field found in fields element: " + reader.LocalName);
                }
            }
        }

        private void AddField(XmlReader reader)
        {
            string name = reader.GetAttribute("name");
            string typestr = reader.GetAttribute("type");
            string tagstr = reader.GetAttribute("number");
            int tag = Fields.Converters.IntConverter.Convert(tagstr);
            _fieldTypes.Add(tag, FieldEntry.MakeFromType(name, tag, typestr));
            _fields.Add(tag);
            _fieldNameToTagMap.Add(name, tag);
        }

        private void MakeVersion(XmlReader reader)
        {
            MajorVersion = reader.GetAttribute("major");
            MinorVersion = reader.GetAttribute("minor");
            Version = "FIX." + MajorVersion + "." + MinorVersion;
        }

        #region Properties
        public string MajorVersion { get; private set; }
        public string MinorVersion { get; private set; }
        public string Version { get; private set; }
        #endregion

        #region Private Members
        private HashSet<int> _fields;
        private Dictionary<int, FieldEntry> _fieldTypes;
        private Dictionary<string, int> _fieldNameToTagMap;
        #endregion
    }
}
