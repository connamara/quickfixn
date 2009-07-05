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
            this._messageComponents = new Dictionary<string, HashSet<MessageComponent>>();
            this._groups = new Dictionary<string, HashSet<int>>();
            this._components = new Dictionary<string, HashSet<MessageComponent>>();
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
                        case "components":
                            ProcessComponents(reader);
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
            foreach (string msg in _messageComponents.Keys)
            {
                HashSet<int> fields = new HashSet<int>();
                HashSet<int> reqFields = new HashSet<int>();
                foreach (MessageComponent msgcomp in _messageComponents[msg])
                {
                    if (msgcomp.ComponentType == MessageComponent.TypeEnum.Field)
                        PostProcessField(msgcomp, fields, reqFields);
                    else if (msgcomp.ComponentType == MessageComponent.TypeEnum.Group)
                        PostProcessGroup(msgcomp, fields, reqFields, msg);
                    else
                        PostProcessComponentGroup(msgcomp, fields, reqFields, msg);
                }
                _messageFields.Add(msg, fields);
                _reqMsgFields.Add(msg, reqFields);
            }
        }

        private void PostProcessComponentGroup(
            MessageComponent parentcomp, HashSet<int> fields, 
            HashSet<int> reqFields, string msgname)
        {
            foreach (MessageComponent msgcomp in parentcomp.SubComponents)
            {
                switch (msgcomp.ComponentType)
                {
                    case MessageComponent.TypeEnum.Field: 
                        PostProcessField(msgcomp, fields, reqFields); 
                        break;
                    case MessageComponent.TypeEnum.Component: 
                        PostProcessComponentGroup(msgcomp, fields, reqFields, msgname); 
                        break;
                    case MessageComponent.TypeEnum.Group:
                        PostProcessGroup(msgcomp, fields, reqFields, msgname);
                        break;
                }
            }
        }

        private void PostProcessField(MessageComponent msgcomp, HashSet<int> fields, HashSet<int> reqFields)
        {
            int tag = GetTagFromName(msgcomp.Name);
            fields.Add(tag);
            if (msgcomp.Required)
                reqFields.Add(tag);
        }

        private void PostProcessGroup(MessageComponent msgcomp, HashSet<int> fields, HashSet<int> reqFields, string msg)
        {
            if (!_groups.ContainsKey(msg))
                _groups.Add(msg, new HashSet<int>());
            _groups[msg].Add(GetTagFromName(msgcomp.Name));

            if (msgcomp.Required)
                reqFields.Add(GetTagFromName(msgcomp.Name));
            PostProcessComponentGroup(msgcomp, fields, reqFields, msg);
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
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string name = reader.GetAttribute("name");
                    string reqstr = reader.GetAttribute("required");
                    bool req = false;
                    if (reqstr.Equals("Y"))
                        req = true;
                    if (!_messageComponents.ContainsKey(msgtype))
                        _messageComponents.Add(msgtype, new HashSet<MessageComponent>());
                    MessageComponent.TypeEnum ctype = MessageComponent.GetComponentType(reader.LocalName, msgname);
                    MessageComponent component = new MessageComponent(name, req, ctype );
                    _messageComponents[msgtype].Add(component);

                    if( ctype.Equals( MessageComponent.TypeEnum.Group ))
                        ProcessGroup( reader, component );
                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("message"))
                    break;
            }
        }

        private void ProcessComponents(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("component"))
                        AddComponent(reader);
                    else
                        throw new DictionaryParseException("bad item in components: " + reader.LocalName);
                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("components"))
                    break;
            }
        }

        private void AddComponent(XmlReader reader)
        {
            string name = reader.GetAttribute("name");
            if (name == null)
                throw new DictionaryParseException("component with no name!");
            if (_components.ContainsKey(name))
                throw new DictionaryParseException("duplicate component: " + name);
            _components.Add(name, new HashSet<MessageComponent>());

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string reqstr = reader.GetAttribute("required");
                    bool req = false;
                    if (reqstr.Equals("Y")) req = true;
                    MessageComponent.TypeEnum ctype = MessageComponent.GetComponentType(reader.LocalName, name);
                    MessageComponent component = new MessageComponent(name, req, ctype);
                    _components[name].Add(component);
                    if( ctype.Equals( MessageComponent.TypeEnum.Group ))
                        ProcessGroup(reader,component);

                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("component"))
                    break;
            }

        }

        private void ProcessGroup(XmlReader reader, MessageComponent group)
        {
            while( reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string grpname = reader.GetAttribute("name");
                    string reqstr = reader.GetAttribute("required");
                    bool req = false;
                    if (reqstr.Equals("Y"))
                        req = true;
                    MessageComponent.TypeEnum ctype = MessageComponent.GetComponentType(reader.LocalName, grpname);
                    MessageComponent component = new MessageComponent(grpname, req, ctype );
                    group.SubComponents.Add(component);
                    if (component.ComponentType.Equals(MessageComponent.TypeEnum.Group))
                        ProcessGroup(reader, component);
                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("group"))
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
        private Dictionary<string, HashSet<MessageComponent>> _components;

        /// <summary>
        /// all message dictionaries indexed by msgtype
        /// </summary>
        private HashSet<string> _messages; 
        private Dictionary<string, HashSet<MessageComponent>> _messageComponents;
        private Dictionary<string, HashSet<int>> _messageFields;
        private Dictionary<string, HashSet<int>> _reqMsgFields;
        private Dictionary<string, HashSet<int>> _groups;
        #endregion
    }
}
