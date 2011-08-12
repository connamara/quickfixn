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
        private HashSet<XMLMsgComponent> _headerComponents;
        private HashSet<XMLMsgComponent> _trailerComponents;
        private Dictionary<string, DDFieldMap> _messages;
        private DDFieldMap _header;
        private DDFieldMap _trailer;

        #endregion

        public DataDictionaryParser()
        {
            this._fields = new HashSet<int>();
            this._fieldTypes = new Dictionary<int, FieldEntry>();
            this._fieldNameToTag = new Dictionary<string, int>();
            this._fieldNames = new Dictionary<int, string>();
            this._messages = new Dictionary<string, DDFieldMap>();
            this._header = new DDFieldMap();
            this._trailer = new DDFieldMap();
            this._msgTypes = new HashSet<string>();
            this._messageComponents = new Dictionary<string, HashSet<XMLMsgComponent>>();
            this._headerComponents = new HashSet<XMLMsgComponent>();
            this._trailerComponents = new HashSet<XMLMsgComponent>();
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
            this._header = new DDFieldMap(src._header);
            this._trailer = new DDFieldMap(src._trailer);
            this._msgTypes = new HashSet<string>(src._msgTypes);
            this._messageComponents = new Dictionary<string, HashSet<XMLMsgComponent>>(src._messageComponents);
            this._headerComponents = new HashSet<XMLMsgComponent>(src._headerComponents);
            this._trailerComponents = new HashSet<XMLMsgComponent>(src._trailerComponents);
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
                        case "header":
                            DataDictionaryParser.ProcessXMLNonBodyFields(reader, "header", _headerComponents);
                            break;
                        case "trailer":
                            DataDictionaryParser.ProcessXMLNonBodyFields(reader, "trailer", _trailerComponents);
                            break;
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

        public static void Validate(Message message, DataDictionaryParser sessionDataDict, DataDictionaryParser appDataDict, string beginString, string msgType)
        {
            bool bodyOnly = (null == sessionDataDict);

            if ((null != sessionDataDict) && (null != sessionDataDict.Version))
                if (!sessionDataDict.Version.Equals(beginString))
                    throw new UnsupportedVersion();

            if (((null != sessionDataDict) && sessionDataDict.CheckFieldsOutOfOrder) || ((null != appDataDict) && appDataDict.CheckFieldsOutOfOrder))
            {
                int field;
                if (!message.HasValidStructure(out field))
                    throw new TagOutOfOrder(field);
            }

            if ((null != appDataDict) && (null != appDataDict.Version))
            {
                appDataDict.CheckMsgType(msgType);
                appDataDict.CheckHasRequired(message, msgType);
            }
            
            if (!bodyOnly)
            {
                sessionDataDict.Iterate(message.Header, msgType);
                sessionDataDict.Iterate(message.Trailer, msgType);
            }

            appDataDict.Iterate(message, msgType);
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

        public static void CheckHasNoRepeatedTags(FieldMap map)
        {
            if (map.RepeatedTags.Count > 0)
                throw new RepeatedTag(map.RepeatedTags[0].Tag);
        }

        public void CheckMsgType(string msgType)
        {
            if (!_messages.ContainsKey(msgType))
                throw new InvalidMessageType(msgType);
        }

        public void CheckHasRequired(Message message, string msgType)
        {
            foreach(int field in _header.ReqFields)
                if (!message.Header.isSetField(field))
                    throw new RequiredTagMissing(field);

            foreach (int field in _trailer.ReqFields)
                if (!message.Trailer.isSetField(field))
                    throw new RequiredTagMissing(field);

            foreach (int field in _messages[msgType].ReqFields)
                if (!message.isSetField(field))
                    throw new RequiredTagMissing(field);

            /** TODO group stuff
            foreach (DDGroup grp in _messages[msgType].Groups.Values)
                if (_messages[msgType].ReqFields.Contains(grp.Field))
                    ReqFieldsSetInGroups(grp, fields);
            */
        }

        public void Iterate(FieldMap map, string msgType)
        {
            DataDictionaryParser.CheckHasNoRepeatedTags(map);

            int lastField = 0;
            foreach (KeyValuePair<int, Fields.IField> kvp in map)
            {
                Fields.IField field = kvp.Value;
                if (lastField != 0 && field.Tag == lastField)
                    throw new RepeatedTag(lastField);
                CheckHasValue(field);

                if (null != this.Version && this.Version.Length > 0)
                {
                    CheckValidFormat(field);
                    CheckValue(field);

                    if (ShouldCheckTag(field))
                    {
                        CheckValidTagNumber(field.Tag);
                        if (!Message.IsHeaderField(field.Tag, this) && !Message.IsTrailerField(field.Tag, this))
                        {
                            CheckIsInMessage(field, msgType);
                            CheckGroupCount(field, map, msgType);
                        }
                    }
                }

                lastField = field.Tag;
            }
        }

        /// FIXME
        public void CheckHasValue(Fields.IField field)
        {
            if (this.CheckFieldsHaveValues && (field.ToString().Length < 1))
                throw new NoTagValue(field.Tag);
        }

        /// FIXME
        public void CheckValidFormat(Fields.IField field)
        {
        }

        public void CheckValidTagNumber(int tag)
        {
            if (!_fields.Contains(tag))
                throw new InvalidTagNumber(tag);
        }

        /// FIXME
        public void CheckValue(Fields.IField field)
        {
        }

        public void CheckIsInMessage(Fields.IField field, string msgType)
        {
            DDFieldMap dd;
            if (_messages.TryGetValue(msgType, out dd))
                if (dd.Fields.Contains(field.Tag))
                    return;
            throw new TagNotDefinedForMessage(field.Tag, msgType);
        }

        /// FIXME
        public void CheckGroupCount(Fields.IField field, FieldMap map, string msgType)
        {
        }

        public bool ShouldCheckTag(Fields.IField field)
        {
            if (!this.CheckUserDefinedFields && (field.Tag >= Fields.Limits.USER_MIN))
                return false;
            return true;
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

        /// <summary>
        /// Useful for unit testing
        /// </summary>
        /// <returns>a copy of the set of required Header fields</returns>
        public HashSet<int> GetRequiredHeaderFields()
        {
            return new HashSet<int>(_header.ReqFields);
        }

        /// <summary>
        /// Useful for unit testing
        /// </summary>
        /// <returns>a copy of the set of required Trailer fields</returns>
        public HashSet<int> GetRequiredTrailerFields()
        {
            return new HashSet<int>(_trailer.ReqFields);
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

            foreach (XMLMsgComponent msgcomp in _headerComponents)
                PostProcessField(msgcomp, _header);

            foreach (XMLMsgComponent msgcomp in _trailerComponents)
                PostProcessField(msgcomp, _trailer);
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

        private static void ProcessXMLNonBodyFields(XmlReader reader, string localName, HashSet<XMLMsgComponent> components)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string name = reader.GetAttribute("name");
                    string reqstr = reader.GetAttribute("required");
                    bool req = false;
                    if (reqstr.Equals("Y"))
                        req = true;
                    
                    XMLMsgComponent.TypeEnum ctype = XMLMsgComponent.GetComponentType(reader.LocalName, "[" + localName + "]");
                    XMLMsgComponent component = new XMLMsgComponent(name, req, ctype);
                    components.Add(component);

                    if (ctype.Equals(XMLMsgComponent.TypeEnum.Group))
                        DataDictionaryParser.ProcessGroup(reader, component);
                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals(localName))
                {
                    break;
                }
            }
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
                        DataDictionaryParser.ProcessGroup(reader, component);
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
                        DataDictionaryParser.ProcessGroup(reader,component);

                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName.Equals("component"))
                    break;
            }

        }

        private static void ProcessGroup(XmlReader reader, XMLMsgComponent group)
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
                        DataDictionaryParser.ProcessGroup(reader, component);
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
