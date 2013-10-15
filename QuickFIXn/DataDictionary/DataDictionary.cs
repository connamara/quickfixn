using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace QuickFix.DataDictionary
{
	/// <summary>
	/// Provide the message metadata for various versions of FIX
	/// </summary>
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

		/// <summary>
		/// Initialize a data dictionary from a file path
		/// </summary>
		/// <param name="path"></param>
		public DataDictionary(String path)
			:this()
		{
			Load(path);
		}

        /// <summary>
        /// Initialize a data dictionary from a stream
        /// </summary>
        /// <param name="stream"></param>
        public DataDictionary(Stream stream)
            :this()
        {
            Load(stream);
        }

		/// <summary>
		/// Copy a data dictionary
		/// </summary>
		/// <param name="src">the source dictionary that will be copied into this dictionary</param>
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

		public static void Validate(Message message, DataDictionary sessionDataDict, DataDictionary appDataDict, string beginString, string msgType)
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

		/// <summary>
		/// Validate the message body, with header and trailer fields being validated conditionally
		/// </summary>
		/// <param name="message">the message</param>
		/// <param name="bodyOnly">whether to validate just the message body, or to validate the header and trailer sections as well</param>
		/// <param name="beginString"></param>
		/// <param name="msgType"></param>
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

			// check non-group fields
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
			DataDictionary.CheckHasNoRepeatedTags(group);

			int lastField = 0;
			foreach(KeyValuePair<int, Fields.IField> kvp in group)
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
		public void CheckHasValue(Fields.IField field)
		{
			if (this.CheckFieldsHaveValues && (field.ToString().Length < 1))
				throw new NoTagValue(field.Tag);
		}

		/// <summary>
		/// Check that the field contents match the DataDictionary-defined type
		/// </summary>
		/// <param name="field"></param>
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
				else if (type.Equals(typeof(Fields.IntField)))
					Fields.Converters.IntConverter.Convert(field.ToString());
				else if (type.Equals(typeof(Fields.DecimalField)))
					Fields.Converters.DecimalConverter.Convert(field.ToString());
				else if (type.Equals(typeof(Fields.BooleanField)))
					Fields.Converters.BoolConverter.Convert(field.ToString());

				else if (type.Equals(typeof(Fields.DateTimeField)))
					Fields.Converters.DateTimeConverter.ConvertToDateTime(field.ToString());
				else if (type.Equals(typeof(Fields.DateOnlyField)))
					Fields.Converters.DateTimeConverter.ConvertToDateOnly(field.ToString());
				else if (type.Equals(typeof(Fields.TimeOnlyField)))
					Fields.Converters.DateTimeConverter.ConvertToTimeOnly(field.ToString());
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

		/// <summary>
		/// Check that this tag is defined in the DataDictionary
		/// </summary>
		/// <param name="tag"></param>
		public void CheckValidTagNumber(int tag)
		{
			if (!FieldsByTag.ContainsKey(tag))
			{
				throw new InvalidTagNumber(tag);
			}
		}

		/// <summary>
		/// If field is an enum, make sure the value is valid.
		/// </summary>
		/// <param name="field"></param>
		public void CheckValue(Fields.IField field)
		{
			DDField fld = FieldsByTag[ field.Tag ];
			if( fld.HasEnums() )
				if( fld.IsMultipleValueFieldWithEnums )
				{
					string [] splitted = field.ToString().Split( ' ' );

					foreach( string value in splitted )
						if( !fld.EnumDict.ContainsKey( value ) )
							throw new IncorrectTagValue( field.Tag );
				}
				else if( !fld.EnumDict.ContainsKey( field.ToString() ) )
					throw new IncorrectTagValue( field.Tag );
		}

		/// <summary>
		/// Check that <paramref name="field"/> is supposed to be in the message type indicated by <paramref name="msgType"/>.
		/// </summary>
		/// <param name="field"></param>
		/// <param name="msgType"></param>
		public void CheckIsInMessage(Fields.IField field, string msgType)
		{
			DDMap dd;
			if (Messages.TryGetValue(msgType, out dd))
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
		public void CheckIsInGroup(Fields.IField field, DDGrp ddgrp, string msgType)
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

		/// <summary>
		/// Determine if this is a field that should be checked for validity according to config
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
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

		public void Load(String path)
		{
			var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
			Load(stream);
		}

		public void Load(Stream stream)
		{
			XmlDocument doc = new XmlDocument();
			RootDoc = doc;
			doc.Load(stream);
			setVersionInfo(doc);
			parseFields(doc);
			parseMessages(doc);
			parseHeader(doc);
			parseTrailer(doc);
		}

		public Boolean FieldHasValue(int tag, String val) {
			return FieldsByTag[tag].EnumDict.ContainsKey(val);
		}

		private void setVersionInfo(XmlDocument doc) {
			MajorVersion = doc.SelectSingleNode("/fix/@major").Value;
			MinorVersion = doc.SelectSingleNode("/fix/@minor").Value;
			string type;
			XmlNode node = doc.SelectSingleNode("/fix/@type");
			if (node == null)
				type = "FIX";//FIXME has to be a better way to do this, but for now, only >=5.0 have type
			else
				type = node.Value;
			
			
			if (!type.Equals("FIX") && !type.Equals("FIXT"))
				throw new System.ArgumentException("Type must be FIX of FIXT in cofig");
			Version = String.Format("{0}.{1}.{2}", type, MajorVersion, MinorVersion);
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
			Dictionary<String, String> enums = new Dictionary<String, String>();
			if (fldEl.HasChildNodes)
			{
				foreach (XmlNode enumEl in fldEl.SelectNodes(".//value"))
				{
					string description = String.Empty;
					if (enumEl.Attributes["description"] != null)
						description = enumEl.Attributes["description"].Value;
					enums[enumEl.Attributes["enum"].Value] = description;
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

        /// <summary>
        /// Implied null third componentRequired parameter
        /// </summary>
        /// <param name="node"></param>
        /// <param name="ddmap"></param>
        private void parseMsgEl(XmlNode node, DDMap ddmap)
        {
            parseMsgEl(node, ddmap, null);
        }

        /// <summary>
        /// Parse a message element
        /// </summary>
        /// <param name="node"></param>
        /// <param name="ddmap"></param>
        /// <param name="componentRequired">
        /// If non-null, parsing is inside a component that is required (true) or not (false).
        /// If null, parser is not inside a component.
        /// </param>
		private void parseMsgEl(XmlNode node, DDMap ddmap, bool? componentRequired)
		{
            /* 
            // This code is great for debugging DD parsing issues.
            string s = "+ " + node.Name;
            if (node.Attributes["name"] != null)
                s += " | " + node.Attributes["name"].Value;
            Console.WriteLine(s);
            */

			if (!node.HasChildNodes) { return; }
			foreach (XmlNode childNode in node.ChildNodes)
			{
                /*
                // Continuation of code that's great for debugging DD parsing issues.
                s = "    + " + childNode.Name;
                if (node.Attributes["name"] != null)
                    s += " | " + childNode.Attributes["name"].Value;
                Console.WriteLine(s);
                */

				if( childNode.Name == "field" )
				{
					DDField fld = FieldsByName[childNode.Attributes["name"].Value];
                    XmlAttribute req = childNode.Attributes["required"];
                    if (req != null && req.Value == "Y"
                        && (componentRequired == null || componentRequired.Value == true))
                    {
                        ddmap.ReqFields.Add(fld.Tag);
                    }
					if (!ddmap.IsField(fld.Tag))
					{
						ddmap.Fields.Add(fld.Tag, fld);
					}

					// if first field in group, make it the DELIM
					if ((ddmap.GetType() == typeof(DDGrp) && ((DDGrp)ddmap).Delim == 0))
					{
						((DDGrp)ddmap).Delim = fld.Tag;
					}
				}
				else if(childNode.Name == "group")
				{
					DDField fld = FieldsByName[childNode.Attributes["name"].Value];
					DDGrp grp = new DDGrp();
                    XmlAttribute req = childNode.Attributes["required"];
                    if (req != null && req.Value == "Y"
                        && (componentRequired == null || componentRequired.Value == true))
					{
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
                else if (childNode.Name == "component")
                {
                    String name = childNode.Attributes["name"].Value;
                    XmlNode compNode = RootDoc.SelectSingleNode("//components/component[@name='" + name + "']");
                    XmlAttribute req = childNode.Attributes["required"];
                    bool? compRequired = (req != null && req.Value == "Y");
                    parseMsgEl(compNode, ddmap, compRequired);
                }
			}
		}
	}
}
