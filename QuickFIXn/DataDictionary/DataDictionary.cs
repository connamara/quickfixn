using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using QuickFix.Fields;

namespace QuickFix.DataDictionary
{
    /// <summary>
    /// Provide the message metadata for various versions of FIX
    /// </summary>
    public class DataDictionary
    {
        public string? MajorVersion { get; private set; }
        public string? MinorVersion { get; private set; }
        public string? Version { get; private set; }
        public readonly Dictionary<int, DDField> FieldsByTag = new();
        public readonly Dictionary<string, DDField> FieldsByName = new();
        public readonly Dictionary<string, DDMap> Messages = new();
        private readonly Dictionary<string, XmlNode> _componentsByName = new();

        public bool CheckFieldsOutOfOrder { get; set; }
        public bool CheckFieldsHaveValues { get; set; }
        public bool CheckUserDefinedFields { get; set; }
        public bool AllowUnknownFieldValues { get; set; }
        public bool AllowUnknownMessageFields { get; set; }

        public DDMap Header = new();
        public DDMap Trailer = new();

        public DataDictionary()
        {
            CheckFieldsHaveValues = true;
            CheckFieldsOutOfOrder = true;
            CheckUserDefinedFields = true;
            AllowUnknownMessageFields = false;
        }

        /// <summary>
        /// Initialize a data dictionary from a file path
        /// </summary>
        /// <param name="path"></param>
        public DataDictionary(string path)
            : this()
        {
            Load(path);
        }

        /// <summary>
        /// Initialize a data dictionary from a stream
        /// </summary>
        /// <param name="stream"></param>
        public DataDictionary(Stream stream)
            : this()
        {
            Load(stream);
        }

        /// <summary>
        /// Copy a data dictionary
        /// </summary>
        /// <param name="src">the source dictionary that will be copied into this dictionary</param>
        public DataDictionary(DataDictionary src)
            : this()
        {
            Messages = src.Messages;
            FieldsByName = src.FieldsByName;
            FieldsByTag = src.FieldsByTag;
            MajorVersion = src.MajorVersion;
            MinorVersion = src.MinorVersion;
            Version = src.Version;
            CheckFieldsHaveValues = src.CheckFieldsHaveValues;
            CheckFieldsOutOfOrder = src.CheckFieldsOutOfOrder;
            CheckUserDefinedFields = src.CheckUserDefinedFields;
            Header = src.Header;
            Trailer = src.Trailer;
        }

        public static void Validate(Message message, DataDictionary? transportDataDict, DataDictionary appDataDict, string beginString, string msgType)
        {
            if (transportDataDict?.Version is not null && !transportDataDict.Version.Equals(beginString)) {
                throw new UnsupportedVersion(beginString);
            }

            // TODO: this check is not well-designed. The ex is only triggered if Message.FromString sets an invalid state.
            // (no other Message function can set this state!)
            // Furthermore, this is the only time we throw a TagOutOfOrder exception.
            // It's not clear to me that this logic is useful.
            if(transportDataDict?.CheckFieldsOutOfOrder == true || appDataDict.CheckFieldsOutOfOrder) {
                if (!message.HasValidStructure(out var field))
                    throw new TagOutOfOrder(field);
            }

            if(appDataDict.Version is not null)
            {
                appDataDict.CheckMsgType(msgType);
                appDataDict.CheckHasRequired(message, msgType);
            }

            if (transportDataDict is not null)
            {
                transportDataDict.Iterate(message.Header, msgType);
                transportDataDict.Iterate(message.Trailer, msgType);
            }

            appDataDict.Iterate(message, msgType);
        }

        public static void CheckHasNoRepeatedTags(FieldMap map)
        {
            if (map.RepeatedTags.Count > 0)
                throw new RepeatedTag(map.RepeatedTags[0].Tag);
        }

        public DDMap? GetMapForMessage(string msgType) {
            return Messages.ContainsKey(msgType)
                ? Messages[msgType]
                : null;
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

            /* FIXME TODO group stuff
            foreach (DDGroup grp in _messages[msgType].Groups.Values)
              if (_messages[msgType].ReqFields.Contains(grp.Field))
                ReqFieldsSetInGroups(grp, fields);
            */
        }

        public void Iterate(FieldMap map, string msgType)
        {
            CheckHasNoRepeatedTags(map);

            // check non-group fields
            int lastField = 0;
            foreach (KeyValuePair<int, IField> kvp in map)
            {
                IField field = kvp.Value;
                if (lastField != 0 && field.Tag == lastField)
                    throw new RepeatedTag(lastField);
                CheckHasValue(field);

                if (!string.IsNullOrEmpty(this.Version))
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

            // check contents of each group
            foreach (int groupTag in map.GetGroupTags())
            {
                for (int i = 1; i <= map.GroupCount(groupTag); i++)
                {
                    Group g = map.GetGroup(i, groupTag);
                    DDGrp ddg = this.Messages[msgType].GetGroup(groupTag);
                    IterateGroup(g, ddg, msgType);
                }
            }
        }

        public void IterateGroup(Group group, DDGrp ddgroup, string msgType)
        {
            CheckHasNoRepeatedTags(group);

            int lastField = 0;
            foreach (KeyValuePair<int, IField> kvp in group)
            {
                IField field = kvp.Value;
                if (lastField != 0 && field.Tag == lastField)
                    throw new RepeatedTag(lastField);
                CheckHasValue(field);

                if (!string.IsNullOrEmpty(this.Version))
                {
                    CheckValidFormat(field);

                    if (ShouldCheckTag(field))
                    {
                        CheckValidTagNumber(field.Tag);
                        CheckValue(field);

                        CheckIsInGroup(field, ddgroup, msgType);
                        CheckGroupCount(field, group, msgType);
                    }
                }
                lastField = field.Tag;
            }

            // check contents of each nested group
            foreach (int groupTag in group.GetGroupTags())
            {
                for (int i = 1; i <= group.GroupCount(groupTag); i++)
                {
                    Group g = group.GetGroup(i, groupTag);
                    DDGrp ddg = ddgroup.GetGroup(groupTag);
                    IterateGroup(g, ddg, msgType);
                }
            }
        }

        /// <summary>
        /// Check that the field has a value (i.e. that there's something after the equal sign);
        /// does nothing if configuration has "ValidateFieldsHaveValues=N".
        /// </summary>
        /// <param name="field"></param>
        public void CheckHasValue(IField field)
        {
            if (this.CheckFieldsHaveValues && (field.ToString().Length < 1))
                throw new NoTagValue(field.Tag);
        }

        /// <summary>
        /// Check that the field contents match the DataDictionary-defined type
        /// </summary>
        /// <param name="field"></param>
        public void CheckValidFormat(IField field)
        {
            try
            {
                Type type;
                if (!TryGetFieldType(field.Tag, out type))
                    return;
                if (type == typeof(StringField))
                    return;

                if (false == CheckFieldsHaveValues && field.ToString().Length < 1)
                {
                    // If ValidateFieldsHaveValues=N, don't check empty non-string fields
                    // because engine should not decide how to convert empty to e.g. float or datetime.
                    // (User code may see IncorrectDataFormat exceptions
                    //  when attempting to extract fields in not-string formats.)
                    return;
                }

                if (type == typeof(CharField))
                    Fields.Converters.CharConverter.Convert(field.ToString());
                else if (type == typeof(IntField))
                    Fields.Converters.IntConverter.Convert(field.ToString());
                else if (type == typeof(DecimalField))
                    Fields.Converters.DecimalConverter.Convert(field.ToString());
                else if (type == typeof(BooleanField))
                    Fields.Converters.BoolConverter.Convert(field.ToString());

                else if (type == typeof(DateTimeField))
                    Fields.Converters.DateTimeConverter.ParseToDateTime(field.ToString());
                else if (type == typeof(DateOnlyField))
                    Fields.Converters.DateTimeConverter.ParseToDateOnly(field.ToString());
                else if (type == typeof(TimeOnlyField))
                    Fields.Converters.DateTimeConverter.ParseToTimeOnly(field.ToString());
            }
            catch (FieldConvertError e)
            {
                throw new IncorrectDataFormat(field.Tag, e);
            }
        }

        public bool TryGetFieldType(int tag, out Type result)
        {
            if (FieldsByTag.TryGetValue(tag, out DDField? value))
            {
                result = value.FieldType;
                return true;
            }
            result = typeof(object); // doesn't matter
            return false;
        }

        /// <summary>
        /// Check that this tag is defined in the DataDictionary
        /// </summary>
        /// <param name="tag"></param>
        public void CheckValidTagNumber(int tag)
        {
            if (AllowUnknownMessageFields)
                return;
            if (!FieldsByTag.ContainsKey(tag))
                throw new InvalidTagNumber(tag);
        }

        /// <summary>
        /// If field is an enum or multiple value field, make sure the value(s) is/are valid.
        /// (If field is unknown, ignore it.  It's not this function's job to test that.)
        /// </summary>
        /// <param name="field"></param>
        public void CheckValue(IField field)
        {
            if (AllowUnknownFieldValues)
                return;
            if (FieldsByTag.TryGetValue(field.Tag, out var fld))
            {
                if (fld.HasEnums())
                {
                    if (fld.IsMultipleValueFieldWithEnums) {
                        string[] splitted = field.ToString().Split(' ');

                        if (splitted.Any(value => !fld.EnumDict.ContainsKey(value))) {
                            throw new IncorrectTagValue(field.Tag);
                        }
                    }
                    else if (!fld.EnumDict.ContainsKey(field.ToString()))
                        throw new IncorrectTagValue(field.Tag);
                }
            }
        }

        /// <summary>
        /// Check that <paramref name="field"/> is supposed to be in the message type indicated by <paramref name="msgType"/>.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="msgType"></param>
        public void CheckIsInMessage(IField field, string msgType)
        {
            if (AllowUnknownMessageFields)
                return;
            if (Messages.TryGetValue(msgType, out DDMap? dd))
                if (dd.Fields.ContainsKey(field.Tag))
                    return;
            throw new TagNotDefinedForMessage(field.Tag, msgType);
        }

        /// <summary>
        /// Check that <paramref name="field"/> is supposed to be in the group defined in <paramref name="ddgrp"/>
        /// </summary>
        /// <param name="field"></param>
        /// <param name="ddgrp"></param>
        /// <param name="msgType">Message type that contains the group (included in exceptions thrown on failure)</param>
        public static void CheckIsInGroup(IField field, DDGrp ddgrp, string msgType)
        {
            if (ddgrp.IsField(field.Tag))
                return;
            throw new TagNotDefinedForMessage(field.Tag, msgType);
        }

        /// <summary>
        /// If <paramref name="field"/> is a group-counter for <paramref name="msgType"/>, check that it is accurate, else do nothing.
        /// </summary>
        /// <param name="field">a group's counter field</param>
        /// <param name="map">the FieldMap that contains the group being checked</param>
        /// <param name="msgType">msg type of message that is/contains <paramref name="map"/></param>
        public void CheckGroupCount(IField field, FieldMap map, string msgType)
        {
            if (IsGroup(msgType, field.Tag))
            {
                if (map.GetInt(field.Tag) != map.GroupCount(field.Tag))
                {
                    throw new RepeatingGroupCountMismatch(field.Tag);
                }
            }
        }

        public bool IsGroup(string msgType, int tag)
        {
            return Messages.ContainsKey(msgType) && Messages[msgType].IsGroup(tag);
        }

        /// <summary>
        /// Determine if this is a field that should be checked for validity according to config
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public bool ShouldCheckTag(IField field)
        {
            return this.CheckUserDefinedFields || field.Tag < Fields.Limits.USER_MIN;
        }

        public bool IsHeaderField(int tag)
        {
            return Header.IsField(tag);
        }

        public bool IsTrailerField(int tag)
        {
            return Trailer.IsField(tag);
        }

        public void Load(string path)
        {
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            Load(stream);
        }

        public void Load(Stream stream)
        {
            XmlReaderSettings readerSettings = new()
            {
                IgnoreComments = true
            };

            using (XmlReader reader = XmlReader.Create(stream, readerSettings)) {
                XmlDocument rootDoc = new();
                rootDoc.Load(reader);
                SetVersionInfo(rootDoc);
                ParseFields(rootDoc);
                CacheComponents(rootDoc);
                ParseMessages(rootDoc);
                ParseHeader(rootDoc);
                ParseTrailer(rootDoc);
            }
        }

        public bool FieldHasValue(int tag, string val)
        {
            return FieldsByTag[tag].EnumDict.ContainsKey(val);
        }

        private void SetVersionInfo(XmlDocument doc)
        {
            XmlNode? majorVerNode = doc.SelectSingleNode("/fix/@major");
            XmlNode? minorVerNode = doc.SelectSingleNode("/fix/@minor");

            if (majorVerNode is null || minorVerNode is null) {
                throw new DictionaryParseException("Failed to find attributes 'major' and 'minor' in <fix> tag");
            }

            MajorVersion = majorVerNode.Value;
            MinorVersion = minorVerNode.Value;
            XmlNode? node = doc.SelectSingleNode("/fix/@type");

            string typeAtt = node?.Value ?? "FIX"; // att is omitted in non-FIXT DDs

            if (!typeAtt.Equals("FIX") && !typeAtt.Equals("FIXT"))
                throw new DictionaryParseException("<fix> 'type' attribute must be FIX or FIXT (assumes FIX if not present)");
            Version = $"{typeAtt}.{MajorVersion}.{MinorVersion}";
        }

        private void ParseFields(XmlDocument doc)
        {
            XmlNodeList? nodeList = doc.SelectNodes("//fields/field");
            if (nodeList is null)
                throw new DictionaryParseException("No <fields> tag in dictionary");
            foreach (XmlNode fldEl in nodeList)
            {
                DDField fld = NewField(fldEl);
                FieldsByTag[fld.Tag] = fld;
                FieldsByName[fld.Name] = fld;
            }
        }

        private void CacheComponents(XmlDocument doc)
        {
            XmlNodeList? nodeList = doc.SelectNodes("//components/component");
            if(nodeList is null)
                throw new DictionaryParseException("No <components> tag in dictionary");
            foreach (XmlNode compEl in nodeList)
            {
                XmlAttribute? nameAtt = compEl.Attributes?["name"];
                if (nameAtt != null)
                    _componentsByName[nameAtt.Value] = compEl;
            }
        }

        private DDField NewField(XmlNode fldEl)
        {
            XmlAttribute? tagAtt = fldEl.Attributes?["number"];
            XmlAttribute? nameAtt = fldEl.Attributes?["name"];
            XmlAttribute? typeAtt = fldEl.Attributes?["type"];

            if (tagAtt is null)
                throw new DictionaryParseException("A <field> is missing its 'number' attribute");
            string tagstr = tagAtt.Value;

            if(nameAtt is null)
                throw new DictionaryParseException($"<field number='{tagstr}'> is missing its 'name' attribute");
            if(typeAtt is null)
                throw new DictionaryParseException($"<field number='{tagstr}'> is missing its 'type' attribute");

            string name = nameAtt.Value;
            string fldType = typeAtt.Value;

            int tag = QuickFix.Fields.Converters.IntConverter.Convert(tagstr);
            Dictionary<string, string> enums = new Dictionary<string, string>();
            if (fldEl.HasChildNodes)
            {
                XmlNodeList? enumNodeList = fldEl.SelectNodes(".//value");
                if (enumNodeList is not null)
                {
                    foreach (XmlNode enumEl in enumNodeList)
                    {
                        string description = string.Empty;
                        if (enumEl.Attributes?["description"] is not null)
                            description = enumEl.Attributes["description"]!.Value;

                        XmlAttribute? enumAtt = enumEl.Attributes?["enum"];
                        if (enumAtt is null)
                            throw new DictionaryParseException(
                                $"Field {tagstr} has an <value> that is missing its 'enum' attribute");
                        enums[enumAtt.Value] = description;
                    }
                }
            }
            return new DDField(tag, name, enums, fldType);
        }

        private void ParseMessages(XmlDocument doc)
        {
            XmlNodeList? nodeList = doc.SelectNodes("//messages/message");
            if (nodeList is null)
                throw new DictionaryParseException("No <messages> tag in dictionary");
            foreach (XmlNode msgEl in nodeList)
            {
                DDMap msg = new DDMap();
                ParseMsgNode(msgEl, msg);
                string? msgtype = msgEl.Attributes?["msgtype"]?.Value;
                if (msgtype is null)
                    throw new DictionaryParseException("A <message> is missing its 'msgtype' attribute");
                Messages.Add(msgtype, msg);
            }
        }

        private void ParseHeader(XmlDocument doc)
        {
            XmlNode? node = doc.SelectSingleNode("//header");
            if (node is null)
                throw new DictionaryParseException("No <header> tag in the dictionary");
            ParseMsgNode(node, Header);
        }

        private void ParseTrailer(XmlDocument doc)
        {
            XmlNode? node = doc.SelectSingleNode("//trailer");
            if (node is null)
                throw new DictionaryParseException("No <trailer> tag in the dictionary");
            ParseMsgNode(node, Trailer);
        }

        /// <summary>
        /// Checks that node has 'name' attribute, and is not a stray text node.
        /// Throws a DictionaryParseException if a field or component node is malformed.
        /// </summary>
        /// <param name="childNode"></param>
        /// <param name="parentNode"></param>
        internal static string VerifyChildNodeAndReturnNameAtt(XmlNode childNode, XmlNode parentNode)
        {
            if (childNode.Attributes == null)
            {
                throw new DictionaryParseException($"Malformed data dictionary: Found text-only node containing '{childNode.InnerText.Trim()}'");
            }

            string? nameatt = childNode.Attributes["name"]?.Value;

            if (nameatt is null)
            {
                string messageTypeName = parentNode.Attributes?["name"]?.Value ?? parentNode.Name;
                throw new DictionaryParseException($"Malformed data dictionary: Found '{childNode.Name}' node without 'name' within parent '{parentNode.Name}/{messageTypeName}'");
            }

            return nameatt;
        }

        /// <summary>
        /// Parse a message node (message, group, or component).  Its data is added to parameter `ddmap`.
        /// </summary>
        /// <param name="node">a message, group, or component node</param>
        /// <param name="ddmap">the still-being-constructed DDMap for this node</param>
        /// <param name="componentRequired">
        /// If non-null, parsing is inside a component that is required (true) or not (false).
        /// If null, parser is not inside a component.
        /// </param>
        private void ParseMsgNode(XmlNode node, DDMap ddmap, bool? componentRequired = null)
        {
            /* 
            // This code is great for debugging DD parsing issues.
            string s = "+ " + node.Name;  // node.Name is probably "message"
            if (node.Attributes["name"] != null)
                s += " | " + node.Attributes["name"].Value;
            Console.WriteLine(s);
            */

            string? messageTypeName = node.Name switch
            {
                "header" => "header",
                "trailer" => "trailer",
                _ => node.Attributes?["name"]?.Value
            };

            if (messageTypeName is null)
                throw new DictionaryParseException($"Found <{node.Name}> that is missing its 'name' attribute");

            if (!node.HasChildNodes) { return; }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                /*
                // Continuation of code that's great for debugging DD parsing issues.
                s = "    + " + childNode.Name;  // childNode.Name is probably "field"
                if (childNode.Attributes["name"] != null)
                    s += " | " + childNode.Attributes["name"].Value;
                Console.WriteLine(s);
                */

                string nameAttribute = VerifyChildNodeAndReturnNameAtt(childNode, node);

                switch (childNode.Name)
                {
                    case "field":
                    case "group":
                        if (FieldsByName.TryGetValue(nameAttribute, out DDField? fld) == false)
                        {
                            throw new DictionaryParseException(
                                $"Field '{nameAttribute}' is not defined in <fields> section.");
                        }

                        // If this child is in non-required component (componentRequired=false),
                        //   then ignore the "required" attribute
                        bool required = childNode.Attributes?["required"]?.Value == "Y" && componentRequired.GetValueOrDefault(true);

                        if (required)
                            ddmap.ReqFields.Add(fld.Tag);

                        if (ddmap.IsField(fld.Tag) == false)
                            ddmap.Fields.Add(fld.Tag, fld);

                        // if this is in a group whose delim is unset, then this must be the delim (i.e. first field)
                        if (ddmap is DDGrp ddGroup && ddGroup.Delim == 0)
                            ddGroup.Delim = fld.Tag;

                        if (childNode.Name == "group")
                        {
                            DDGrp grp = new() { NumFld = fld.Tag };
                            if (required)
                                grp.Required = true;

                            ParseMsgNode(childNode, grp);
                            ddmap.Groups.Add(fld.Tag, grp);
                        }
                        break;

                    case "component":
                        XmlNode compNode = _componentsByName[nameAttribute];
                        ParseMsgNode(compNode, ddmap, childNode.Attributes?["required"]?.Value == "Y");
                        break;

                    default:
                        throw new DictionaryParseException($"Malformed data dictionary: child node type should be one of {{field,group,component}} but is '{childNode.Name}' within parent '{node.Name}/{messageTypeName}'");
                }
            }
        }
    }
}
