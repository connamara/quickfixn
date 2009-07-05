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
            this._fieldNameToTag = new Dictionary<string, int>();
            this._fieldNames = new Dictionary<int, string>();
            this._messageFields = new Dictionary<string, HashSet<int>>();
            this._messages = new HashSet<string>();
            this._reqMsgFields = new Dictionary<string, HashSet<int>>();
            this._messageFieldEntries = new Dictionary<string, HashSet<MessageFieldEntry>>();
        }

        public void Load( string filename )
        {
            XmlReader reader = new XmlTextReader(filename);
            reader.Read();
            reader.MoveToElement();
            if (!reader.LocalName.Equals("fix"))
                throw new DictionaryParseException("Invalid XML File - no FIX identifier at the top");
            MakeVersion(reader);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "messages":
                            ProcessMessages(reader);
                            break;
                        case "fields":
                            ProcessFields(reader);
                            break;
                    }
                }
            }
            PostProcess();
        }

        public int GetTagFromName(string name)
        {
            if (_fieldNameToTag.ContainsKey(name))
                return _fieldNameToTag[name];
            else
                throw new FieldNotFoundException("field not found with name: "+name);
        }

        public bool ReqFieldsSet(string msgtype, HashSet<int> fields)
        {
            if (!_reqMsgFields.ContainsKey(msgtype))
                throw new InvalidMessageTypeException("message type not found: " + msgtype);

            if (_reqMsgFields[msgtype].Count > fields.Count)
                return false;

            foreach (int field in _reqMsgFields[msgtype] )
            {
                if (!fields.Contains(field))
                    return false;
            }

            return true;
        }

        public string GetFieldName(int tag)
        {
            if (_fieldNames.ContainsKey(tag))
                return _fieldNames[tag];
            else
                throw new FieldNotFoundException(tag);
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

        private void PostProcess()
        {
            foreach (string msg in _messageFieldEntries.Keys)
            {
                HashSet<int> fields = new HashSet<int>();
                HashSet<int> reqFields = new HashSet<int>();
                foreach (MessageFieldEntry fieldentry in _messageFieldEntries[msg])
                {
                    int tag = GetTagFromName(fieldentry.Name);
                    fields.Add(tag);
                    if (fieldentry.Required)
                        reqFields.Add(tag);
                }
                _messageFields.Add(msg, fields);
                _reqMsgFields.Add(msg, reqFields);
            }
        }

        private void ProcessMessages(XmlReader reader)
        {
            while(reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("message"))
                        AddMessage(reader);
                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("messages"))
                    break;
            }
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
                if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("fields"))
                    break;
            }
        }

        private void AddMessage(XmlReader reader)
        {
            string msgname = reader.GetAttribute("name");
            string msgtype = reader.GetAttribute("msgtype");
            string msgcat = reader.GetAttribute("msgcat");
            if (msgname == null)
                throw new DictionaryParseException("empty name for msg");
            if (msgtype == null)
                throw new DictionaryParseException("no type for msg: " + msgname);
            if (msgcat == null)
                throw new DictionaryParseException("no cat for msg: " + msgname);

            _messages.Add(msgtype);
            while( reader.Read())
            {
                reader.MoveToElement();
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if( reader.LocalName.Equals("field"))
                    {
                        string fieldname = reader.GetAttribute("name");
                        string reqstr = reader.GetAttribute("required");
                        bool req = false;
                        if (reqstr.Equals("Y"))
                            req = true;
                        if (!_messageFieldEntries.ContainsKey(msgtype))
                            _messageFieldEntries.Add(msgtype, new HashSet<MessageFieldEntry>());
                        _messageFieldEntries[msgtype].Add(new MessageFieldEntry(fieldname, req));
                            
                    }
                    if (reader.LocalName.Equals("message"))
                        throw new DictionaryParseException("message inside of message!");
                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("message"))
                    break;
            }
        }

        private void AddField(XmlReader reader)
        {
            string name = reader.GetAttribute("name");
            string typestr = reader.GetAttribute("type");
            string tagstr = reader.GetAttribute("number");
            if (name == null)
                throw new DictionaryParseException("empty name for field: " + tagstr);
            if (typestr == null)
                throw new DictionaryParseException("no type for field: " + name);
            if (tagstr == null)
                throw new DictionaryParseException("no tag for field: " + name);

            try 
            {
                int tag = Fields.Converters.IntConverter.Convert(tagstr);
                if (_fields.Contains(tag))
                    throw new DictionaryParseException("duplicate field for message: " + tagstr);
                _fieldTypes.Add(tag, FieldEntry.MakeFromType(name, tag, typestr));
                _fields.Add(tag);
                _fieldNameToTag.Add(name, tag);
                _fieldNames.Add(tag, name);
            }
            catch (Fields.Converters.BadConversionException ex)
            {
                throw new DictionaryParseException("could not parse field. name=<" 
                    + name + "> type=<" + typestr + "> tag=<" + tagstr + ">", ex );
            }
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
        private Dictionary<int, string> _fieldNames;
        private Dictionary<int, FieldEntry> _fieldTypes;
        private Dictionary<string, int> _fieldNameToTag;

        /// <summary>
        /// all message dictionaries indexed by msgtype
        /// </summary>
        private HashSet<string> _messages; 
        private Dictionary<string, HashSet<MessageFieldEntry>> _messageFieldEntries;
        private Dictionary<string, HashSet<int>> _messageFields;
        private Dictionary<string, HashSet<int>> _reqMsgFields;
        #endregion
    }
}
