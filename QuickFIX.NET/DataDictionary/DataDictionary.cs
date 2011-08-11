using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace QuickFix
{
    public sealed partial class DataDictionaryParser
    {
        #region Properties

        public string MajorVersion { get; private set; }
        public string MinorVersion { get; private set; }
        public string Version { get; private set; }
        public bool CheckFieldsOutOfOrder { get; set; }
        public bool CheckFieldsHaveValues { get; set; }
        public bool CheckUserDefinedFields { get; set; }

        #endregion

        #region Private Members

        private HashSet<int> _fields;
        private Dictionary<int, string> _fieldNames;
        private Dictionary<int, FieldEntry> _fieldTypes;
        private Dictionary<string, int> _fieldNameToTag;
        private Dictionary<string, List<XMLMsgComponent>> _components;
        /// <summary>
        /// all message dictionaries indexed by msgtype
        /// </summary>
        private HashSet<string> _msgTypes;
        private Dictionary<string, HashSet<XMLMsgComponent>> _messageComponents;
        private Dictionary<string, DDFieldMap> _messages;

        #endregion

        public DataDictionaryParser()
        {
            this._fields = new HashSet<int>();
            this._fieldTypes = new Dictionary<int, FieldEntry>();
            this._fieldNameToTag = new Dictionary<string, int>();
            this._fieldNames = new Dictionary<int, string>();
            this._messages = new Dictionary<string, DDFieldMap>();
            this._msgTypes = new HashSet<string>();
            this._messageComponents = new Dictionary<string, HashSet<XMLMsgComponent>>();
            this._components = new Dictionary<string, List<XMLMsgComponent>>();

            this.CheckFieldsHaveValues  = true;
            this.CheckFieldsOutOfOrder  = true;
            this.CheckUserDefinedFields = true;
        }

        public DataDictionaryParser(string filename)
            : this()
        {
            Load(filename);
        }

        // TODO need to make deeper copy?
        public DataDictionaryParser(DataDictionaryParser src)
        {
            this._fields = new HashSet<int>(src._fields);
            this._fieldTypes = new Dictionary<int, FieldEntry>(src._fieldTypes);
            this._fieldNameToTag = new Dictionary<string, int>(src._fieldNameToTag);
            this._fieldNames = new Dictionary<int, string>(src._fieldNames);
            this._messages = new Dictionary<string, DDFieldMap>(src._messages);
            this._msgTypes = new HashSet<string>(src._msgTypes);
            this._messageComponents = new Dictionary<string, HashSet<XMLMsgComponent>>(src._messageComponents);
            this._components = new Dictionary<string, List<XMLMsgComponent>>(src._components);
            
            if(null != src.MajorVersion)
                this.MajorVersion = string.Copy(src.MajorVersion);
            if (null != src.MinorVersion)
                this.MinorVersion = string.Copy(src.MinorVersion);
            if (null != src.Version)
                this.Version = string.Copy(src.Version);
            this.CheckFieldsHaveValues  = src.CheckFieldsHaveValues;
            this.CheckFieldsOutOfOrder  = src.CheckFieldsOutOfOrder;
            this.CheckUserDefinedFields = src.CheckUserDefinedFields;
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
                            ProcessXMLMessages(reader);
                            break;
                        case "fields":
                            ProcessXMLFields(reader);
                            break;
                        case "components":
                            ProcessXMLComponents(reader);
                            break;
                    }
                }
            }
            PostProcess();
        }

        public static void Validate(Message message, DataDictionaryParser pSessionDD, DataDictionaryParser pAppDD, string beginString, string msgType)
        {
            bool bodyOnly = (null == pSessionDD);

            if ((null != pSessionDD) && (null != pSessionDD.Version))
                if (!pSessionDD.Version.Equals(beginString))
                    throw new UnsupportedVersion();

            if (((null != pSessionDD) && pSessionDD.CheckFieldsOutOfOrder) || ((null != pAppDD) && pAppDD.CheckFieldsOutOfOrder))
            {
                int field;
                if (!message.HasValidStructure(out field))
                    throw new TagOutOfOrder(field);
            }

            if ((null != pAppDD) && (null != pAppDD.Version))
            {
                pAppDD.CheckMsgType(msgType);
                pAppDD.CheckHasRequired(message.Header, message, message.Trailer, msgType);
            }
            
            if (!bodyOnly)
            {
                pSessionDD.Iterate(message.Header, msgType);
                pSessionDD.Iterate(message.Trailer, msgType);
            }

            pAppDD.Iterate(message, msgType);
        }

        public void Validate(Message message, string beginString, string msgType)
        {
            Validate(message, false, beginString, msgType);
        }

        public void Validate(Message message, bool bodyOnly, string beginString, string msgType)
        {
            DataDictionaryParser sessionDataDict = null;
            if(!bodyOnly)
                sessionDataDict = this;
            Validate(message, sessionDataDict, this, beginString, msgType);
        }

        /// FIXME
        public void CheckMsgType(string msgType)
        {
        }

        /// FIXME
        public void CheckHasRequired(Header header, Message message, Trailer trailer, string msgType)
        {
        }

        /// FIXME
        public void Iterate(Message message, string msgType)
        {
        }

        /// FIXME
        public void Iterate(Header message, string msgType)
        {
        }

        /// FIXME
        public void Iterate(Trailer trailer, string msgType)
        {
        }

        # region Parsing Methods

        public int GetTagFromName(string name)
        {
            if (_fieldNameToTag.ContainsKey(name))
                return _fieldNameToTag[name];
            else
                throw new FieldNotFoundException("field not found with name: "+name);
        }

        public bool ReqFieldsSet(string msgtype, HashSet<int> fields)
        {
            if (!_messages.ContainsKey(msgtype))
                throw new InvalidMessageTypeException("message type not found: " + msgtype);

            foreach (int field in _messages[msgtype].ReqFields )
            {
                if (!fields.Contains(field))
                    throw new MissingRequiredFieldException(field);
            }

            foreach(DDGroup grp in _messages[msgtype].Groups.Values)
            {
                if( _messages[msgtype].ReqFields.Contains(grp.Field))
                {
                    ReqFieldsSetInGroups(grp, fields);
                }
            }
            return true;
        }

        private bool ReqFieldsSetInGroups( DDGroup group, HashSet<int> fields )
        {
            foreach(DDGroup grp in group.Groups.Values)
            {
                if (group.ReqFields.Contains(grp.Field))
                {
                    foreach (int field in grp.ReqFields)
                    {
                        if (!fields.Contains(field))
                            throw new MissingRequiredFieldException(field);
                    }
                    ReqFieldsSetInGroups(grp, fields);
                }
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

        public Type GetFieldType(int tag)
        {
            if (_fieldTypes.ContainsKey(tag))
                return _fieldTypes[tag].FieldType;
            else
                throw new FieldNotFoundException(tag);
        }

        private void PostProcess()
        {
            foreach (string msgstr in _messageComponents.Keys)
            {
                DDFieldMap msg = new DDFieldMap();
                foreach (XMLMsgComponent msgcomp in _messageComponents[msgstr])
                {
                    if (msgcomp.ComponentType == XMLMsgComponent.TypeEnum.Field)
                        PostProcessField(msgcomp, msg);
                    else if (msgcomp.ComponentType == XMLMsgComponent.TypeEnum.Group)
                        PostProcessGroup(msgcomp, msg, msgstr);
                    else
                        PostProcessComponent(msgcomp, msg, msgstr);
                }
                _messages.Add(msgstr, msg);
            }
        }

        private void PostProcessComponent(XMLMsgComponent comp, DDFieldMap msg, string msgname)
        {
            PostProcessComponentGroup(_components[comp.Name][0], msg, msgname);
        }

        private void PostProcessComponentGroup(XMLMsgComponent parentcomp, DDFieldMap msg, string msgname)
        {
            if (parentcomp.ComponentType == XMLMsgComponent.TypeEnum.Component)
                parentcomp = _components[parentcomp.Name][0];

            foreach (XMLMsgComponent msgcomp in parentcomp.SubComponents)
            {
                switch (msgcomp.ComponentType)
                {
                    case XMLMsgComponent.TypeEnum.Field: 
                        PostProcessField(msgcomp, msg); 
                        break;
                    case XMLMsgComponent.TypeEnum.Component: 
                        PostProcessComponent(msgcomp, msg, msgname); 
                        break;
                    case XMLMsgComponent.TypeEnum.Group:
                        PostProcessGroup(msgcomp, msg, msgname);
                        break;
                }
            }
        }

        private void PostProcessField(XMLMsgComponent msgcomp, DDFieldMap msg)
        {
            int tag = GetTagFromName(msgcomp.Name);
            msg.Fields.Add(tag);
            if (msgcomp.Required)
                msg.ReqFields.Add(tag);
        }

        private void PostProcessGroup(XMLMsgComponent msgcomp, DDFieldMap msg, string msgstr)
        {
            DDGroup grp = new DDGroup();
            grp.Field = GetTagFromName(msgcomp.Name);

            if (msgcomp.Required)
                msg.ReqFields.Add(grp.Field);

            msg.Groups.Add(grp.Field, grp);
            PostProcessComponentGroup(msgcomp, msg, msgstr);
        }

        private void ProcessXMLMessages(XmlReader reader)
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

        private void ProcessXMLFields(XmlReader reader)
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

            _msgTypes.Add(msgtype);
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
                        _messageComponents.Add(msgtype, new HashSet<XMLMsgComponent>());
                    XMLMsgComponent.TypeEnum ctype = XMLMsgComponent.GetComponentType(reader.LocalName, msgname);
                    XMLMsgComponent component = new XMLMsgComponent(name, req, ctype );
                    _messageComponents[msgtype].Add(component);

                    if( ctype.Equals( XMLMsgComponent.TypeEnum.Group ))
                        ProcessGroup( reader, component );
                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("message"))
                    break;
            }
        }

        private void ProcessXMLComponents(XmlReader reader)
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
            _components.Add(name, new List<XMLMsgComponent>());

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string reqstr = reader.GetAttribute("required");
                    bool req = false;
                    if (reqstr.Equals("Y")) req = true;
                    XMLMsgComponent.TypeEnum ctype = XMLMsgComponent.GetComponentType(reader.LocalName, name);
                    XMLMsgComponent component = new XMLMsgComponent(name, req, ctype);
                    _components[name].Add(component);
                    if( ctype.Equals( XMLMsgComponent.TypeEnum.Group ))
                        ProcessGroup(reader,component);

                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("component"))
                    break;
            }

        }

        private void ProcessGroup(XmlReader reader, XMLMsgComponent group)
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
                    XMLMsgComponent.TypeEnum ctype = XMLMsgComponent.GetComponentType(reader.LocalName, grpname);
                    XMLMsgComponent component = new XMLMsgComponent(grpname, req, ctype );
                    group.SubComponents.Add(component);
                    if (component.ComponentType.Equals(XMLMsgComponent.TypeEnum.Group))
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
            catch(FieldConvertError e)
            {
                throw new DictionaryParseException("could not parse field. name=<" 
                    + name + "> type=<" + typestr + "> tag=<" + tagstr + ">", e );
            }
        }

        private void MakeVersion(XmlReader reader)
        {
            MajorVersion = reader.GetAttribute("major");
         
            MinorVersion = reader.GetAttribute("minor");
            Version = "FIX." + MajorVersion + "." + MinorVersion;
        }

        #endregion

    }
}
