#nullable enable
using System;
using System.Text;
using QuickFix.Fields;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Collections.Generic;
using QuickFix.DataDictionary;
using DD = QuickFix.DataDictionary.DataDictionary;

namespace QuickFix
{
    /// <summary>
    /// Represents a FIX message
    /// </summary>
    public class Message : FieldMap
    {
        public const char SOH = '\u0001';

        /// <summary>
        /// If message is invalid, then this is set to the tag that caused it
        /// </summary>
        private int _invalidField = 0;

        private bool _isValid = false;

        public Header Header { get; }
        public Trailer Trailer { get; }

        public Message()
        {
            Header = new Header();
            Trailer = new Trailer();
            _isValid = true;
        }

        public Message(
            string msgStr,
            bool validate = true)
            : this(msgStr, null, null, validate)
        { }

        /// <summary>
        /// </summary>
        /// <param name="msgstr"></param>
        /// <param name="transportDict">(if FIX4, transportDict and appDict should be the same)</param>
        /// <param name="appDict">(if FIX4, transportDict and appDict should be the same)</param>
        /// <param name="validate"></param>
        public Message(string msgstr, DD? transportDict, DD? appDict, bool validate)
            : this()
        {
            PopulateHeaderFromMessageString(msgstr);
            if (IsAdmin())
                FromString(msgstr, validate, transportDict, transportDict, null, false);
            else
                FromString(msgstr, validate, transportDict, appDict, null, false);
        }

        public Message(Message src)
            : base(src)
        {
            Header = new Header(src.Header);
            Trailer = new Trailer(src.Trailer);
            _isValid = src._isValid;
            _invalidField = src._invalidField;
        }

        #region Static Methods

        public static bool IsAdminMsgType(string msgType)
        {
            return msgType.Length == 1 && "0A12345n".Contains(msgType[0]);
        }

        /// <summary>
        /// Parse the message type (tag 35) from a FIX string
        /// </summary>
        /// <param name="fixstring">the FIX string to parse</param>
        /// <returns>the message type as a MsgType object</returns>
        /// <exception cref="MessageParseError">if 35 tag is missing or malformed</exception>
        public static MsgType IdentifyType(string fixstring)
        {
            return new MsgType(GetMsgType(fixstring));
        }

        public static int ExtractFieldTag(string msgstr, int pos)
        {
            int tagend = msgstr.IndexOf('=', pos);
            int tag = Convert.ToInt32(msgstr.Substring(pos, tagend - pos));
            return tag;
        }

        public static StringField ExtractDataField(string msgstr, int dataLength, ref int pos)
        {
            try
            {
                int tagend = msgstr.IndexOf('=', pos);
                int tag = Convert.ToInt32(msgstr.Substring(pos, tagend - pos));
                pos = tagend + 1;
                StringField field = new StringField(tag, msgstr.Substring(pos, dataLength));

                pos += dataLength + 1;
                return field;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new MessageParseError($"Error at position ({pos}) while parsing msg ({msgstr})", e);
            }
            catch (OverflowException e)
            {
                throw new MessageParseError($"Error at position ({pos}) while parsing msg ({msgstr})", e);
            }
            catch (FormatException e)
            {
                throw new MessageParseError($"Error at position ({pos}) while parsing msg ({msgstr})", e);
            }
        }

        public static StringField ExtractField(string msgstr, ref int pos)
        {
            try
            {
                int tagend = msgstr.IndexOf('=', pos);
                int tag = Convert.ToInt32(msgstr.Substring(pos, tagend - pos));
                pos = tagend + 1;
                int fieldvalend = msgstr.IndexOf((char)1, pos);
                StringField field =  new StringField(tag, msgstr.Substring(pos, fieldvalend - pos));

                pos = fieldvalend + 1;
                return field;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new MessageParseError("Error at position (" + pos + ") while parsing msg (" + msgstr + ")", e);
            }
            catch (OverflowException e)
            {
                throw new MessageParseError("Error at position (" + pos + ") while parsing msg (" + msgstr + ")", e);
            }
            catch (FormatException e)
            {
                throw new MessageParseError("Error at position (" + pos + ") while parsing msg (" + msgstr + ")", e);
            }
        }

        public static string ExtractBeginString(string msgstr)
        {
            int i = 0;
            return ExtractField(msgstr, ref i).Obj;
        }

        public static bool IsHeaderField(int tag)
        {
            switch (tag)
            {
                case Tags.BeginString:
                case Tags.BodyLength:
                case Tags.MsgType:
                case Tags.SenderCompID:
                case Tags.TargetCompID:
                case Tags.OnBehalfOfCompID:
                case Tags.DeliverToCompID:
                case Tags.SecureDataLen:
                case Tags.MsgSeqNum:
                case Tags.SenderSubID:
                case Tags.SenderLocationID:
                case Tags.TargetSubID:
                case Tags.TargetLocationID:
                case Tags.OnBehalfOfSubID:
                case Tags.OnBehalfOfLocationID:
                case Tags.DeliverToSubID:
                case Tags.DeliverToLocationID:
                case Tags.PossDupFlag:
                case Tags.PossResend:
                case Tags.SendingTime:
                case Tags.OrigSendingTime:
                case Tags.XmlDataLen:
                case Tags.XmlData:
                case Tags.MessageEncoding:
                case Tags.LastMsgSeqNumProcessed:
                    // case Tags.OnBehalfOfSendingTime: TODO 
                    return true;
                default:
                    return false;
            }
        }
        public static bool IsHeaderField(int tag, DD? dd)
        {
            if (IsHeaderField(tag))
                return true;
            if (dd is not null)
                return dd.IsHeaderField(tag);
            return false;
        }

        public static bool IsTrailerField(int tag)
        {
            switch (tag)
            {
                case Tags.SignatureLength:
                case Tags.Signature:
                case Tags.CheckSum:
                    return true;
                default:
                    return false;
            }
        }
        public static bool IsTrailerField(int tag, DD? dd)
        {
            if (IsTrailerField(tag))
                return true;
            if (dd is not null)
                return dd.IsTrailerField(tag);
            return false;
        }

        private static string GetFieldOrDefault(FieldMap fields, int tag, string defaultValue)
        {
            if (!fields.IsSetField(tag))
                return defaultValue;

            try
            {
                return fields.GetString(tag);
            }
            catch (FieldNotFoundException)
            {
                return defaultValue;
            }
        }

        private static SessionID GetReverseSessionId(Message msg)
        {
            return new SessionID(
                GetFieldOrDefault(msg.Header, Tags.BeginString, SessionID.NOT_SET),
                GetFieldOrDefault(msg.Header, Tags.TargetCompID, SessionID.NOT_SET),
                GetFieldOrDefault(msg.Header, Tags.TargetSubID, SessionID.NOT_SET),
                GetFieldOrDefault(msg.Header, Tags.TargetLocationID, SessionID.NOT_SET),
                GetFieldOrDefault(msg.Header, Tags.SenderCompID, SessionID.NOT_SET),
                GetFieldOrDefault(msg.Header, Tags.SenderSubID, SessionID.NOT_SET),
                GetFieldOrDefault(msg.Header, Tags.SenderLocationID, SessionID.NOT_SET)
            );
        }

        public static SessionID GetReverseSessionId(string msg)
        {
            Message m = new Message(msg);
            return GetReverseSessionId(m);
        }

        /// <summary>
        /// Parse the message type (tag 35) from a FIX string
        /// </summary>
        /// <param name="fixstring">the FIX string to parse</param>
        /// <returns>message type</returns>
        /// <exception cref="MessageParseError">if 35 tag is missing or malformed</exception>
        public static string GetMsgType(string fixstring)
        {
            Match match = Regex.Match(fixstring, SOH + "35=([^" + SOH + "]*)" + SOH);
            if (match.Success)
                return match.Groups[1].Value;

            throw new MessageParseError("missing or malformed tag 35 in msg: " + fixstring);
        }

        public static ApplVerID GetApplVerID(string beginString)
        {
            switch (beginString)
            {
                case FixValues.BeginString.FIX40:
                    return new ApplVerID(ApplVerID.FIX40);
                case FixValues.BeginString.FIX41:
                    return new ApplVerID(ApplVerID.FIX41);
                case FixValues.BeginString.FIX42:
                    return new ApplVerID(ApplVerID.FIX42);
                case FixValues.BeginString.FIX43:
                    return new ApplVerID(ApplVerID.FIX43);
                case FixValues.BeginString.FIX44:
                    return new ApplVerID(ApplVerID.FIX44);
                case FixValues.BeginString.FIX50:
                    return new ApplVerID(ApplVerID.FIX50);
                case FixValues.BeginString.FIX50SP1:
                    return new ApplVerID(ApplVerID.FIX50SP1);
                case FixValues.BeginString.FIX50SP2:
                    return new ApplVerID(ApplVerID.FIX50SP2);
                default:
                    throw new ArgumentException($"ApplVerID for {beginString} not supported");
            }
        }

        #endregion

        public override void Clear()
        {
            _invalidField = 0;
            Header.Clear();
            base.Clear();
            Trailer.Clear();
        }

        private void PopulateHeaderFromMessageString(string msgstr)
        {
            Clear();

            int pos = 0;
            int count = 0;
            while(pos < msgstr.Length)
            {
                StringField f = ExtractField(msgstr, ref pos);

                if (count < 3 && Header.HEADER_FIELD_ORDER[count++] != f.Tag)
                    return;
                
                if(IsHeaderField(f.Tag))
                    Header.SetField(f, false);
                else
                    break;
            }
        }

        /// <summary>
        /// Creates a Message from a FIX string
        /// </summary>
        /// <param name="msgstr"></param>
        /// <param name="validate"></param>
        /// <param name="transportDict">(if FIX4, transportDict and appDict should be the same)</param>
        /// <param name="appDict">(if FIX4, transportDict and appDict will be the same)</param>
        /// <param name="msgFactory">If null, any groups will be constructed as generic Group objects</param>
        /// <param name="ignoreBody">(default false) if true, ignores all non-header non-trailer fields.
        ///   Intended for callers that only need rejection-related information from the header.
        ///   </param>
        public void FromString(
            string msgstr,
            bool validate,
            DD? transportDict,
            DD? appDict,
            IMessageFactory? msgFactory = null,
            bool ignoreBody = false)
        {
            Clear();

            bool expectingHeader = true;
            bool expectingBody = true;
            int count = 0;
            int pos = 0;
            IFieldMapSpec? msgMap = null;

            while (pos < msgstr.Length)
            {
                StringField? f = null;

                int fieldTag = ExtractFieldTag(msgstr, pos);
                if (fieldTag == Tags.XmlData)
                {
                    if (IsHeaderField(Tags.XmlDataLen))
                        f = ExtractDataField(msgstr, Header.GetInt(Tags.XmlDataLen), ref pos);
                    else if (IsSetField(Tags.XmlDataLen))
                        f = ExtractDataField(msgstr, GetInt(Tags.XmlDataLen), ref pos);
                }

                f ??= ExtractField(msgstr, ref pos);

                if (validate && (count < 3) && (Header.HEADER_FIELD_ORDER[count++] != f.Tag))
                    throw new InvalidMessage("Header fields out of order");

                if (IsHeaderField(f.Tag, transportDict))
                {
                    if (!expectingHeader)
                    {
                        if (0 == _invalidField)
                            _invalidField = f.Tag;
                        _isValid = false;
                    }

                    if (Tags.MsgType.Equals(f.Tag))
                    {
                        string msgType = f.Obj;
                        if (appDict is not null)
                        {
                            msgMap = appDict.GetMapForMessage(msgType);
                        }
                    }

                    if (!Header.SetField(f, false))
                        Header.RepeatedTags.Add(f);

                    if (transportDict is not null && transportDict.Header.IsGroup(f.Tag))
                    {
                        pos = SetGroup(f, msgstr, pos, Header, transportDict.Header.GetGroupSpec(f.Tag), msgFactory);
                    }
                }
                else if (IsTrailerField(f.Tag, transportDict))
                {
                    expectingHeader = false;
                    expectingBody = false;
                    if (!Trailer.SetField(f, false))
                        Trailer.RepeatedTags.Add(f);

                    if (transportDict is not null && transportDict.Trailer.IsGroup(f.Tag))
                    {
                        pos = SetGroup(f, msgstr, pos, Trailer, transportDict.Trailer.GetGroup(f.Tag), msgFactory);
                    }
                }
                else if (ignoreBody==false)
                {
                    if (!expectingBody)
                    {
                        if (0 == _invalidField)
                            _invalidField = f.Tag;
                        _isValid = false;
                    }

                    expectingHeader = false;
                    if (!SetField(f, false))
                    {
                        RepeatedTags.Add(f);
                    }

                    if(msgMap is not null && msgMap.IsGroup(f.Tag))
                    {
                        pos = SetGroup(f, msgstr, pos, this, msgMap.GetGroupSpec(f.Tag), msgFactory);
                    }
                }
            }

            if (validate)
            {
                Validate();
            }
        }

        /// <summary>
        /// Creates a Message from FIX JSON Encoding.
        /// See: https://github.com/FIXTradingCommunity/fix-json-encoding-spec
        /// </summary>
        /// <param name="json"></param>
        /// <param name="validate"></param>
        /// <param name="transportDict"></param>
        /// <param name="appDict"></param>
        /// <param name="msgFactory">If null, any groups will be constructed as generic Group objects</param>
        public void FromJson(string json, bool validate,
            DD transportDict,
            DD appDict,
            IMessageFactory? msgFactory)
        {
            Clear();

            using (JsonDocument document = JsonDocument.Parse(json)) {
                string? beginString = document.RootElement.GetProperty("Header").GetProperty("BeginString").GetString();
                string? msgType     = document.RootElement.GetProperty("Header").GetProperty("MsgType").GetString();

                if (beginString is null || msgType is null) {
                    throw new ArgumentException(
                        $"JSON message has invalid/missing beginString ({beginString}) and/or msgType ({msgType})");
                }

                IFieldMapSpec msgMap = appDict.GetMapForMessage(msgType);
                FromJson(document.RootElement.GetProperty("Header"),  beginString, msgType, msgMap, msgFactory, transportDict, Header);
                FromJson(document.RootElement.GetProperty("Body"),    beginString, msgType, msgMap, msgFactory, appDict, this);
                FromJson(document.RootElement.GetProperty("Trailer"), beginString, msgType, msgMap, msgFactory, transportDict, Trailer);
            }

            Header.SetField(new BodyLength(BodyLength()), true);
            Trailer.SetField(new CheckSum(Fields.Converters.CheckSumConverter.Convert(CheckSum())), true);

            if (validate)
            {
                Validate();
            }
        }

        protected void FromJson(JsonElement jsonElement,
            string beginString,
            string msgType,
            IFieldMapSpec msgMap,
            IMessageFactory? msgFactory,
            DD dataDict,
            FieldMap fieldMap)
        {
            foreach (JsonProperty field in jsonElement.EnumerateObject())
            {
                if (dataDict.FieldsByName.TryGetValue(field.Name, out DDField? ddField))
                {
                    if (msgMap is not null && msgMap.IsGroup(ddField.Tag) && JsonValueKind.Array == field.Value.ValueKind)
                    {
                        foreach (JsonElement jsonGrp in field.Value.EnumerateArray())
                        {
                            IGroupSpec grpSpec = msgMap.GetGroupSpec(ddField.Tag);

                            Group grp = msgFactory?.Create(beginString, msgType, ddField.Tag)
                                ?? new Group(ddField.Tag, grpSpec.Delim);
                            FromJson(jsonGrp, beginString, msgType, grpSpec, msgFactory, dataDict, grp);
                            fieldMap.AddGroup(grp);
                        }
                    }

                    if (JsonValueKind.Array != field.Value.ValueKind)
                    {
                        fieldMap.SetField(new StringField(ddField.Tag, field.Value.ToString()));
                    }
                }
                else
                {
                    // this may be a custom tag given by number instead of name
                    if (int.TryParse(field.Name, out int customTagNumber))
                    {
                        fieldMap.SetField(new StringField(customTagNumber, field.Value.ToString()));
                    }
                }
            }
        }

        /// <summary>
        /// Constructs a group and stores it in this Message object
        /// </summary>
        /// <param name="grpNoFld">the group's counter field</param>
        /// <param name="msgstr">full message string</param>
        /// <param name="pos">starting character position of group</param>
        /// <param name="fieldMap">full message as FieldMap</param>
        /// <param name="groupSpec">group definition structure from dd</param>
        /// <param name="msgFactory">if null, then this method will use the generic Group class constructor</param>
        /// <returns></returns>
        protected int SetGroup(
            StringField grpNoFld, string msgstr, int pos, FieldMap fieldMap, IGroupSpec groupSpec,
            IMessageFactory? msgFactory)
        {
            int grpEntryDelimiterTag = groupSpec.Delim;
            int grpPos = pos;
            Group? grp = null; // the group entry being constructed

            while (pos < msgstr.Length)
            {
                grpPos = pos;
                StringField f = ExtractField(msgstr, ref pos);
                if (f.Tag == grpEntryDelimiterTag)
                {
                    // This is the start of a group entry.

                    if (grp is not null)
                    {
                        // We were already building an entry, so the delimiter means it's done.
                        fieldMap.AddGroup(grp, false);
                    }

                    // Create a new group!
                    grp = msgFactory?.Create(ExtractBeginString(msgstr), GetMsgType(msgstr), grpNoFld.Tag)
                        ?? new Group(grpNoFld.Tag, grpEntryDelimiterTag);
                }
                else if (!groupSpec.IsField(f.Tag))
                {
                    // This field is not in the group, thus the repeating group is done.
                    if (grp is not null)
                    {
                        fieldMap.AddGroup(grp, false);
                    }
                    return grpPos;
                }
                else if(groupSpec.IsField(f.Tag) && grp is not null && grp.IsSetField(f.Tag))
                {
                    // Tag is appearing for the second time within a group element.
                    // Presumably the sender didn't set the delimiter (or their DD has a different delimiter).
                    throw new RepeatedTagWithoutGroupDelimiterTagException(grpNoFld.Tag, f.Tag);
                }

                if (grp is null)
                {
                    // This means we got into the group's fields without finding a delimiter tag.
                    throw new GroupDelimiterTagException(grpNoFld.Tag, grpEntryDelimiterTag);
                }

                // f is just a field in our group entry.  Add it and iterate again.
                grp.SetField(f);
                if(groupSpec.IsGroup(f.Tag))
                {
                    // f is a counter for a nested group.  Recurse!
                    pos = SetGroup(f, msgstr, pos, grp, groupSpec.GetGroupSpec(f.Tag), msgFactory);
                }
            }
            
            return grpPos;
        }

        /// <summary>
        /// Check if this message was deemed valid.
        /// </summary>
        /// <param name="problemField">If invalid, then this is set to the field that is the problem</param>
        /// <returns></returns>
        public bool HasValidStructure(out int problemField) {
            problemField = _isValid ? 0 : _invalidField;
            return _isValid;
        }

        public void Validate()
        {
            try
            {
                int receivedBodyLength = Header.GetInt(Tags.BodyLength);
                if (BodyLength() != receivedBodyLength)
                    throw new InvalidMessage("Expected BodyLength=" + BodyLength() + ", Received BodyLength=" + receivedBodyLength + ", Message.SeqNum=" + Header.GetInt(Tags.MsgSeqNum));

                int receivedCheckSum = Trailer.GetInt(Tags.CheckSum);
                if (CheckSum() != receivedCheckSum)
                    throw new InvalidMessage("Expected CheckSum=" + CheckSum() + ", Received CheckSum=" + receivedCheckSum + ", Message.SeqNum=" + Header.GetInt(Tags.MsgSeqNum));
            }
            catch (FieldNotFoundException e)
            {
                throw new InvalidMessage("BodyLength or CheckSum missing", e);
            }
            catch (FieldConvertError e)
            {
                throw new InvalidMessage("BodyLength or Checksum has wrong format", e);
            }
        }

        public void ReverseRoute(Header header)
        {
            // required routing tags
            Header.RemoveField(Tags.BeginString);
            Header.RemoveField(Tags.SenderCompID);
            Header.RemoveField(Tags.SenderSubID);
            Header.RemoveField(Tags.SenderLocationID);
            Header.RemoveField(Tags.TargetCompID);
            Header.RemoveField(Tags.TargetSubID);
            Header.RemoveField(Tags.TargetLocationID);

            if (header.IsSetField(Tags.BeginString))
            {
                string beginString = header.GetString(Tags.BeginString);
                if (beginString.Length > 0)
                    Header.SetField(new BeginString(beginString));

                Header.RemoveField(Tags.OnBehalfOfLocationID);
                Header.RemoveField(Tags.DeliverToLocationID);

                if (string.CompareOrdinal(beginString, "FIX.4.1") >= 0)
                {
                    if (header.IsSetField(Tags.OnBehalfOfLocationID))
                    {
                        string onBehalfOfLocationId = header.GetString(Tags.OnBehalfOfLocationID);
                        if (onBehalfOfLocationId.Length > 0)
                            Header.SetField(new DeliverToLocationID(onBehalfOfLocationId));
                    }

                    if (header.IsSetField(Tags.DeliverToLocationID))
                    {
                        string deliverToLocationId = header.GetString(Tags.DeliverToLocationID);
                        if (deliverToLocationId.Length > 0)
                            Header.SetField(new OnBehalfOfLocationID(deliverToLocationId));
                    }
                }
            }

            if (header.IsSetField(Tags.SenderCompID))
            {
                SenderCompID senderCompId = new SenderCompID();
                header.GetField(senderCompId);
                if (senderCompId.Obj.Length > 0)
                    Header.SetField(new TargetCompID(senderCompId.Obj));
            }

            if (header.IsSetField(Tags.SenderSubID))
            {
                SenderSubID senderSubId = new SenderSubID();
                header.GetField(senderSubId);
                if (senderSubId.Obj.Length > 0)
                    Header.SetField(new TargetSubID(senderSubId.Obj));
            }

            if (header.IsSetField(Tags.SenderLocationID))
            {
                SenderLocationID senderLocationId = new SenderLocationID();
                header.GetField(senderLocationId);
                if (senderLocationId.Obj.Length > 0)
                    Header.SetField(new TargetLocationID(senderLocationId.Obj));
            }

            if (header.IsSetField(Tags.TargetCompID))
            {
                TargetCompID targetCompId = new TargetCompID();
                header.GetField(targetCompId);
                if (targetCompId.Obj.Length > 0)
                    Header.SetField(new SenderCompID(targetCompId.Obj));
            }

            if (header.IsSetField(Tags.TargetSubID))
            {
                TargetSubID targetSubId = new TargetSubID();
                header.GetField(targetSubId);
                if (targetSubId.Obj.Length > 0)
                    Header.SetField(new SenderSubID(targetSubId.Obj));
            }

            if (header.IsSetField(Tags.TargetLocationID))
            {
                TargetLocationID targetLocationId = new TargetLocationID();
                header.GetField(targetLocationId);
                if (targetLocationId.Obj.Length > 0)
                    Header.SetField(new SenderLocationID(targetLocationId.Obj));
            }

            // optional routing tags
            Header.RemoveField(Tags.OnBehalfOfCompID);
            Header.RemoveField(Tags.OnBehalfOfSubID);
            Header.RemoveField(Tags.DeliverToCompID);
            Header.RemoveField(Tags.DeliverToSubID);

            if(header.IsSetField(Tags.OnBehalfOfCompID))
            {
                string onBehalfOfCompId = header.GetString(Tags.OnBehalfOfCompID);
                if(onBehalfOfCompId.Length > 0)
                    Header.SetField(new DeliverToCompID(onBehalfOfCompId));
            }

            if(header.IsSetField(Tags.OnBehalfOfSubID))
            {
                string onBehalfOfSubId = header.GetString(  Tags.OnBehalfOfSubID);
                if(onBehalfOfSubId.Length > 0)
                    Header.SetField(new DeliverToSubID(onBehalfOfSubId));
            }

            if(header.IsSetField(Tags.DeliverToCompID))
            {
                string deliverToCompId = header.GetString(Tags.DeliverToCompID);
                if(deliverToCompId.Length > 0)
                    Header.SetField(new OnBehalfOfCompID(deliverToCompId));
            }

            if(header.IsSetField(Tags.DeliverToSubID))
            {
                string deliverToSubId = header.GetString(Tags.DeliverToSubID);
                if(deliverToSubId.Length > 0)
                    Header.SetField(new OnBehalfOfSubID(deliverToSubId));
            }
        }

        public int CheckSum()
        {
            return (
                (Header.CalculateTotal()
                + CalculateTotal()
                + Trailer.CalculateTotal()) % 256);
        }

        public bool IsAdmin()
        {
            return Header.IsSetField(Tags.MsgType) && IsAdminMsgType(Header.GetString(Tags.MsgType));
        }

        public bool IsApp()
        {
            return Header.IsSetField(Tags.MsgType) && !IsAdminMsgType(Header.GetString(Tags.MsgType));
        }

        /// <summary>
        /// FIXME less operator new
        /// </summary>
        /// <param name="sessionId"></param>
        public void SetSessionID(SessionID sessionId)
        {
            Header.SetField(new BeginString(sessionId.BeginString));
            Header.SetField(new SenderCompID(sessionId.SenderCompID));
            if (SessionID.IsSet(sessionId.SenderSubID))
                Header.SetField(new SenderSubID(sessionId.SenderSubID));
            if (SessionID.IsSet(sessionId.SenderLocationID))
                Header.SetField(new SenderLocationID(sessionId.SenderLocationID));
            Header.SetField(new TargetCompID(sessionId.TargetCompID));
            if (SessionID.IsSet(sessionId.TargetSubID))
                Header.SetField(new TargetSubID(sessionId.TargetSubID));
            if (SessionID.IsSet(sessionId.TargetLocationID))
                Header.SetField(new TargetLocationID(sessionId.TargetLocationID));
        }

        public SessionID GetSessionID(Message m)
        {
            bool isSetSenderSubId = m.Header.IsSetField(Tags.SenderSubID);
            bool isSetSenderLocationId = m.Header.IsSetField(Tags.SenderLocationID);
            bool isSetTargetSubId = m.Header.IsSetField(Tags.TargetSubID);
            bool isSetTargetLocationId = m.Header.IsSetField(Tags.TargetLocationID);

            if (isSetSenderSubId && isSetSenderLocationId && isSetTargetSubId && isSetTargetLocationId)
                return new SessionID(m.Header.GetString(Tags.BeginString),
                    m.Header.GetString(Tags.SenderCompID), m.Header.GetString(Tags.SenderSubID), m.Header.GetString(Tags.SenderLocationID),
                    m.Header.GetString(Tags.TargetCompID), m.Header.GetString(Tags.TargetSubID), m.Header.GetString(Tags.TargetLocationID));

            if (isSetSenderSubId && isSetTargetSubId)
                return new SessionID(m.Header.GetString(Tags.BeginString),
                    m.Header.GetString(Tags.SenderCompID), m.Header.GetString(Tags.SenderSubID),
                    m.Header.GetString(Tags.TargetCompID), m.Header.GetString(Tags.TargetSubID));

            return new SessionID(
                m.Header.GetString(Tags.BeginString),
                m.Header.GetString(Tags.SenderCompID),
                m.Header.GetString(Tags.TargetCompID));
        }

        private Object lock_ConstructString = new Object();
        /// <summary>
        /// Update BodyLength in Header, update CheckSum in Trailer, and return a FIX string.
        /// (This function changes the object state!)
        /// </summary>
        /// <returns></returns>
        public string ConstructString()
        {
            lock (lock_ConstructString)
            {
                Header.SetField(new BodyLength(BodyLength()), true);
                Trailer.SetField(new CheckSum(Fields.Converters.CheckSumConverter.Convert(CheckSum())), true);

                return Header.CalculateString() + CalculateString() + Trailer.CalculateString();
            }
        }

        /// <summary>
        /// Create a FIX-style string from the message.
        /// This does NOT add/update BodyLength or CheckSum to the message header, or otherwise change the object state.
        /// (Use <see cref="ConstructString"/> to compute and add/update BodyLength &amp; CheckSum.)
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return Header.CalculateString() + CalculateString() + Trailer.CalculateString();
        }

        protected int BodyLength()
        {
            return Header.CalculateLength() + CalculateLength() + Trailer.CalculateLength();
        }

        private static string FieldMapToXML(DD? dd, FieldMap fields, int space)
        {
            StringBuilder s = new StringBuilder();

            // fields
            foreach (var f in fields)
            {
               s.Append("<field ");
               if (dd is not null && dd.FieldsByTag.TryGetValue(f.Key, out var value))
               {
                   s.Append("name=\"" + value.Name + "\" ");
               }
               s.Append("number=\"" + f.Key + "\">");
               s.Append("<![CDATA[" + f.Value + "]]>");
               s.Append("</field>");
            }
            // now groups
            List<int> groupTags = fields.GetGroupTags();
            foreach (int groupTag in groupTags)
            {
                for (int counter = 1; counter <= fields.GroupCount(groupTag); counter++)
                {
                    s.Append("<group>");
                    s.Append(FieldMapToXML(dd, fields.GetGroup(counter, groupTag), space+1));
                    s.Append("</group>");
                }
            }

            return s.ToString();
        }


        /// <summary>
        /// ToJSON() helper method.
        /// </summary>
        /// <returns>an XML string</returns>
        private static StringBuilder FieldMapToJSON(StringBuilder sb, DD? dd, FieldMap fields, bool humanReadableValues)
        {
            IList<int> numInGroupTagList = fields.GetGroupTags();
            IList<IField> numInGroupFieldList = new List<IField>();

            // Non-Group Fields
            foreach (var (_, field) in fields)
            {
                if (QuickFix.Fields.CheckSum.TAG == field.Tag)
                    continue; // FIX JSON Encoding does not include CheckSum

                if (numInGroupTagList.Contains(field.Tag))
                {
                    numInGroupFieldList.Add(field);
                    continue; // Groups will be handled below
                }

                if (dd is not null && dd.FieldsByTag.ContainsKey(field.Tag))
                {
                    sb.Append("\"" + dd.FieldsByTag[field.Tag].Name + "\":");
                    if (humanReadableValues) {
                        if (dd.FieldsByTag[field.Tag].EnumDict.TryGetValue(field.ToString(), out var valueDescription))
                        {
                            sb.Append("\"" + valueDescription + "\",");
                        }
                        else
                            sb.Append("\"" + field + "\",");
                    }
                    else
                    {
                        sb.Append("\"" + field + "\",");
                    }
                }
                else
                {
                    sb.Append("\"" + field.Tag + "\":");
                    sb.Append("\"" + field + "\",");
                }
            }

            // Group Fields
            foreach(IField numInGroupField in numInGroupFieldList)
            {
                // The name of the NumInGroup field is the key of the JSON list containing the Group items
                if (dd is not null && dd.FieldsByTag.ContainsKey(numInGroupField.Tag))
                    sb.Append("\"" + dd.FieldsByTag[numInGroupField.Tag].Name + "\":[");
                else
                    sb.Append("\"" + numInGroupField.Tag + "\":[");

                // Populate the JSON list with the Group items
                for (int counter = 1; counter <= fields.GroupCount(numInGroupField.Tag); counter++)
                {
                    sb.Append("{");
                    FieldMapToJSON(sb, dd, fields.GetGroup(counter, numInGroupField.Tag), humanReadableValues);
                    sb.Append("},");
                }

                // Remove trailing comma
                if (sb.Length > 0 && sb[^1] == ',')
                    sb.Remove(sb.Length - 1, 1);

                sb.Append("],");
            }
            // Remove trailing comma
            if (sb.Length > 0 && sb[^1] == ',')
                sb.Remove(sb.Length - 1, 1);

            return sb;
        }

        /// <summary>
        /// Get a representation of the message as an XML string.
        /// (NOTE: this is just an ad-hoc XML; it is NOT FIXML.)
        /// </summary>
        /// <param name="dataDictionary">if null, then field names cannot and will not be in the output</param>
        /// <returns>an XML string</returns>
        public string ToXML(DD? dataDictionary = null)
        {
            StringBuilder s = new StringBuilder();
            s.Append("<message>");
            s.Append("<header>");
            s.Append(FieldMapToXML(dataDictionary, Header, 4));
            s.Append("</header>");
            s.Append("<body>");
            s.Append(FieldMapToXML(dataDictionary, this, 4));
            s.Append("</body>");
            s.Append("<trailer>");
            s.Append(FieldMapToXML(dataDictionary, Trailer, 4));
            s.Append("</trailer>");
            s.Append("</message>");
            return s.ToString();
        }

        /// <summary>
        /// Get a representation of the message as a string in FIX JSON Encoding.
        /// See: https://github.com/FIXTradingCommunity/fix-json-encoding-spec
        ///
        /// Per the FIX JSON Encoding spec, tags are converted to human-readable form, but values are not.
        /// </summary>
        /// <param name="dataDictionary">Needed if you want tag names emitted or humanReadableValues to work</param>
        /// <param name="convertEnumsToDescriptions">
        ///   True will cause enums to be converted to their description strings, but only if dataDictionary is provided.
        ///   If true and dataDictionary is null, then throws an ArgumentNullException.
        /// </param>
        /// <returns>a JSON string</returns>
        public string ToJSON(DD? dataDictionary = null, bool convertEnumsToDescriptions = false) {
            if (convertEnumsToDescriptions && dataDictionary is null) {
                throw new ArgumentNullException(
                    nameof(dataDictionary),
                    $"Must be non-null if '{nameof(convertEnumsToDescriptions)}' is true.");
            }

            StringBuilder sb = new StringBuilder().Append('{').Append("\"Header\":{");
            FieldMapToJSON(sb, dataDictionary, Header, convertEnumsToDescriptions).Append("},\"Body\":{");
            FieldMapToJSON(sb, dataDictionary, this, convertEnumsToDescriptions).Append("},\"Trailer\":{");
            FieldMapToJSON(sb, dataDictionary, Trailer, convertEnumsToDescriptions).Append("}}");
            return sb.ToString();
        }
    }
}
