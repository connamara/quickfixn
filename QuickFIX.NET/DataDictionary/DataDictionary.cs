using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace QuickFix
{
    public sealed partial class DataDictionaryParser
    {
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
        private Dictionary<string, List<XMLMsgComponent>> _components;

        /// <summary>
        /// all message dictionaries indexed by msgtype
        /// </summary>
        private HashSet<string> _msgTypes; 
        private Dictionary<string, HashSet<XMLMsgComponent>> _messageComponents;
        private Dictionary<string, DDFieldMap> _messages;
        #endregion
    }
}
