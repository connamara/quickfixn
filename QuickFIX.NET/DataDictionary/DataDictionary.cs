using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;

namespace QuickFix.DataDictionary
{
    public class DataDictionary
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

        public DDMap Header = new DDMap();
        public DDMap Trailer = new DDMap();

        public DataDictionary()
        {
            CheckFieldsHaveValues = true;
            CheckFieldsOutOfOrder = true;
            CheckUserDefinedFields = true;
        }

        public DataDictionary(String path)
            :this()
        {
            Load(path);
        }

        
        public DataDictionary(DataDictionary src)
            :this()
        {
            this.Messages = src.Messages;
            this.FieldsByName = src.FieldsByName;
            this.FieldsByTag = src.FieldsByTag;
            if (null != src.MajorVersion)
                this.MajorVersion = string.Copy(src.MajorVersion);
            if (null != src.MinorVersion)
                this.MinorVersion = string.Copy(src.MinorVersion);
            if (null != src.Version)
                this.Version = string.Copy(src.Version);
            this.CheckFieldsHaveValues = src.CheckFieldsHaveValues;
            this.CheckFieldsOutOfOrder = src.CheckFieldsOutOfOrder;
            this.CheckUserDefinedFields = src.CheckUserDefinedFields;
            this.Header = src.Header;
            this.Trailer = src.Trailer;
        }

        public void Validate(Message message, DataDictionary sessionDataDict, DataDictionary appDataDict, string beginString, string msgType)
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
            DataDictionary sessionDataDict = null;
            if (!bodyOnly)
                sessionDataDict = this;
            Validate(message, sessionDataDict, this, beginString, msgType);
        }

        public static void CheckHasNoRepeatedTags(FieldMap map)
        {
            if (map.RepeatedTags.Count > 0)
                throw new RepeatedTag(map.RepeatedTags[0].Tag);
        }

        public DDMap GetMapForMessage(string msgType)
        {
	        if(Messages.ContainsKey(msgType)) {
                return Messages[msgType];
            }
	        return null;
        }

        public void CheckMsgType(string msgType)
        {
            if (!Messages.ContainsKey(msgType))
                throw new InvalidMessageType();
        }

        public void CheckHasRequired(Message message, string msgType)
        {
            foreach (int field in Header.ReqFields)
            {
                if (!message.Header.IsSetField(field))
                    throw new RequiredTagMissing(field);
            }

            foreach (int field in Trailer.ReqFields)
            {
                if (!message.Trailer.IsSetField(field))
                    throw new RequiredTagMissing(field);
            }

            foreach (int field in Messages[msgType].ReqFields)
            {
                if (!message.IsSetField(field))
                    throw new RequiredTagMissing(field);
            }

            /** FIXME TODO group stuff
            foreach (DDGroup grp in _messages[msgType].Groups.Values)
                if (_messages[msgType].ReqFields.Contains(grp.Field))
                    ReqFieldsSetInGroups(grp, fields);
            */
        }

        public void Iterate(FieldMap map, string msgType)
        {
            DataDictionary.CheckHasNoRepeatedTags(map);

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
                    
                    if (ShouldCheckTag(field))
                    {
                        CheckValidTagNumber(field.Tag);
                        CheckValue(field);
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

        public void CheckHasValue(Fields.IField field)
        {
            if (this.CheckFieldsHaveValues && (field.ToString().Length < 1))
                throw new NoTagValue(field.Tag);
        }

        public void CheckValidFormat(Fields.IField field)
        {
            try
            {
                Type type;
                if (!TryGetFieldType(field.Tag, out type))
                    return;

                if (type.Equals(typeof(Fields.StringField)))
                    return;
                else if (type.Equals(typeof(Fields.CharField)))
                    Fields.Converters.CharConverter.Convert(field.ToString());
                else if (type.Equals(typeof(Fields.DateTimeField)))
                    Fields.Converters.DateTimeConverter.Convert(field.ToString());
                else if (type.Equals(typeof(Fields.IntField)))
                    Fields.Converters.IntConverter.Convert(field.ToString());
                else if (type.Equals(typeof(Fields.DecimalField)))
                    Fields.Converters.DecimalConverter.Convert(field.ToString());
                else if (type.Equals(typeof(Fields.BooleanField)))
                    Fields.Converters.BoolConverter.Convert(field.ToString());
                else
                    return;

            }
            catch (FieldConvertError e)
            {
                throw new IncorrectDataFormat(field.Tag, e);
            }
        }

        public bool TryGetFieldType(int tag, out Type result)
        {
            
            if (FieldsByTag.ContainsKey(tag))
            {
                result = FieldsByTag[tag].FieldType;
                return true;
            }
            result = null;
            return false;
        }

        public void CheckValidTagNumber(int tag)
        {
            if (!FieldsByTag.ContainsKey(tag))
            {
                throw new InvalidTagNumber(tag);
            }
        }

        public void CheckValue(Fields.IField field)
        {
            DDField fld = FieldsByTag[field.Tag];
            if (fld.HasEnums() && !fld.Enums.Contains(field.ToString()))
            {
                throw new IncorrectTagValue(field.Tag);
            }
        }

        public void CheckIsInMessage(Fields.IField field, string msgType)
        {
            DDMap dd;
            if (Messages.TryGetValue(msgType, out dd))
                if (dd.Fields.ContainsKey(field.Tag))
                    return;
            throw new TagNotDefinedForMessage(field.Tag, msgType);
        }

        
        public void CheckGroupCount(Fields.IField field, FieldMap map, string msgType)
        {
            if(IsGroup(msgType, field.Tag))
            {
                if (map.GetInt(field.Tag) != map.GroupCount(field.Tag))
                {
                    throw new RepeatingGroupCountMismatch(field.Tag);
                }
            }
        }

        public bool IsGroup(string msgType, int tag)
        {
            if (Messages.ContainsKey(msgType))
            {
                return Messages[msgType].IsGroup(tag);
            }
            return false;
        }

        public bool ShouldCheckTag(Fields.IField field)
        {
            if (!this.CheckUserDefinedFields && (field.Tag >= Fields.Limits.USER_MIN))
                return false;
            return true;
        }

        public bool IsHeaderField(int tag)
        {
            return Header.IsField(tag);
        }

        public bool IsTrailerField(int tag)
        {
            return Trailer.IsField(tag);
        }

		public void Load(String path) {
            XmlDocument doc = new XmlDocument();
            RootDoc = doc;
            doc.Load(path);
            setVersionInfo(doc);
            parseFields(doc);
            parseMessages(doc);
            parseHeader(doc);
            parseTrailer(doc);
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

        private void parseHeader(XmlDocument doc)
        {
            parseMsgEl(doc.SelectSingleNode("//header"), Header);
        }

        private void parseTrailer(XmlDocument doc)
        {
            parseMsgEl(doc.SelectSingleNode("//trailer"), Trailer);
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
                        ddmap.ReqFields.Add(fld.Tag);
                    }
                    if (!ddmap.IsField(fld.Tag))
                    {
                        ddmap.Fields.Add(fld.Tag, fld);
                    }

                    // if first field in group, make it the DELIM <3 FIX
                    if ((ddmap.GetType() == typeof(DDGrp) && ((DDGrp)ddmap).Delim == 0))
                    {
                        ((DDGrp)ddmap).Delim = fld.Tag;
                    }
                }
                else if(childNode.Name == "group")
                {
                    DDField fld = FieldsByName[childNode.Attributes["name"].Value];
                    DDGrp grp = new DDGrp();
                    if (childNode.Attributes["required"].Value == "Y")
                    {
                        fld.Required = true;
                        ddmap.ReqFields.Add(fld.Tag);
                        grp.Required = true;
                    }
                    if (!ddmap.IsField(fld.Tag))
                    {
                        ddmap.Fields.Add(fld.Tag, fld);
                    }
                    grp.NumFld = fld.Tag; 
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
