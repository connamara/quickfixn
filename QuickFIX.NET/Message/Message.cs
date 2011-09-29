using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix.Fields;

namespace QuickFix
{
    public class Header : FieldMap
    {
        public int[] HEADER_FIELD_ORDER = { Tags.BeginString, Tags.BodyLength, Tags.MsgType };

        public Header()
            : base()
        { }

        public Header(Header src)
            : base(src)
        { }

        public override string CalculateString()
        {
            return base.CalculateString(new StringBuilder(), HEADER_FIELD_ORDER);
        }

        public override string CalculateString(StringBuilder sb, int[] preFields)
        {
            return base.CalculateString(sb, HEADER_FIELD_ORDER);
        }
    }

    public class Trailer : FieldMap
    {
        public Trailer()
            : base()
        { }

        public Trailer(Trailer src)
            : base(src)
        { }
    }

    public class Message : FieldMap
    {
        public const string SOH = "\u0001";
        private int field_ = 0;
        private bool validStructure_;
        
        #region Properties

        public Header Header { get; private set; }
        public Trailer Trailer { get; private set; }
        
        #endregion

        #region Constructors

        public Message()
        {
            this.Header = new Header();
            this.Trailer = new Trailer();
            this.validStructure_ = true;
        }

        public Message(string msgstr)
            : this(msgstr, true)
        { }

        public Message(string msgstr, bool validate)
            : this(msgstr, null, null, validate)
        {  }

        public Message(string msgstr, DataDictionary.DataDictionary dataDictionary, bool validate)
            : this()
        {
            FromString(msgstr, validate, dataDictionary, dataDictionary);
        }

        public Message(string msgstr, DataDictionary.DataDictionary sessionDataDictionary, DataDictionary.DataDictionary appDD, bool validate)
            : this()
        {
            FromStringHeader(msgstr);
            if(IsAdmin())
                FromString(msgstr, validate, sessionDataDictionary, sessionDataDictionary);
            else
                FromString(msgstr, validate, sessionDataDictionary, appDD);
        }

        public Message(Message src)
            : base(src)
        {
            this.Header = new Header(src.Header);
            this.Trailer = new Trailer(src.Trailer);
            this.validStructure_ = src.validStructure_;
            this.field_= src.field_;
        }

        #endregion

        #region Static Methods

        public static bool IsAdminMsgType(string msgType)
        {
            return msgType.Length == 1 && "0A12345h".IndexOf(msgType) != -1;
        }

        /// <summary>
        /// Parse the MsgType from a FIX string
        /// </summary>
        /// <param name="msgstr">string of a FIX message</param>
        /// <returns>MsgType object</returns>
        public static MsgType IdentifyType(string msgstr)
        {
            int valbeg = msgstr.IndexOf("\u000135=") + 4;
            if (valbeg.Equals(-1))
                throw new MessageParseError("no tag 35 found in msg: " + msgstr);
            int valend = msgstr.IndexOf("\u0001", valbeg);
            if (valend.Equals(-1))
                throw new MessageParseError("no SOH after tag 35 in msg: " + msgstr);

            return (new MsgType(msgstr.Substring(valbeg, (valend - valbeg))));
        }

        public static StringField ExtractField(string msgstr, ref int pos, DataDictionary.DataDictionary sessionDD, DataDictionary.DataDictionary appDD)
        {
            try
            {
                int tagend = msgstr.IndexOf("=", pos);
                int tag = Convert.ToInt32(msgstr.Substring(pos, tagend - pos));
                pos = tagend + 1;
                int fieldvalend = msgstr.IndexOf("\u0001", pos);
                StringField field =  new StringField(tag, msgstr.Substring(pos, fieldvalend - pos));

                /** TODO data dict stuff
                if (((null != sessionDD) && sessionDD.IsDataField(field.Tag)) || ((null != appDD) && appDD.IsDataField(field.Tag)))
                {
                    string fieldLength = "";
                    // Assume length field is 1 less
                    int lenField = field.Tag - 1;
                    // Special case for Signature which violates above assumption
                    if (Tags.Signature.Equals(field.Tag))
                        lenField = Tags.SignatureLength;

                    if ((null != group) && group.isSetField(lenField))
                    {
                        fieldLength = group.GetField(lenField);
                        soh = equalSign + 1 + atol(fieldLength.c_str());
                    }
                    else if (isSetField(lenField))
                    {
                        fieldLength = getField(lenField);
                        soh = equalSign + 1 + atol(fieldLength.c_str());
                    }
                }
                */

                pos = fieldvalend + 1;
                return field;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw new MessageParseError("Error at position (" + pos + ") while parsing msg (" + msgstr + ")", e);
            }
            catch (System.OverflowException e)
            {
                throw new MessageParseError("Error at position (" + pos + ") while parsing msg (" + msgstr + ")", e);
            }
            catch (System.FormatException e)
            {
                throw new MessageParseError("Error at position (" + pos + ") while parsing msg (" + msgstr + ")", e);
            }
        }

        public static StringField ExtractField(string msgstr, ref int pos)
        {
            return ExtractField(msgstr, ref pos, null, null);
        }

        public static string ExtractBeginString(string msgstr)
        {
            int i = 0;
            return ExtractField(msgstr, ref i, null, null).Obj;
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
        public static bool IsHeaderField(int tag, DataDictionary.DataDictionary dd)
        {
            if (IsHeaderField(tag))
                return true;
            if (null != dd)
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
        public static bool IsTrailerField(int tag, DataDictionary.DataDictionary dd)
        {
            if (IsTrailerField(tag))
                return true;
            if (null != dd)
                return dd.IsTrailerField(tag);
            return false;
        }

        public static string GetFieldOrDefault(FieldMap fields, int tag, string defaultValue)
        {
            if (!fields.IsSetField(tag))
                return defaultValue;

            try
            {
                return fields.GetField(tag);
            }
            catch (FieldNotFoundException)
            {
                return defaultValue;
            }
        }

        public static SessionID GetReverseSessionID(Message msg)
        {
            return new SessionID(
                GetFieldOrDefault(msg.Header, Tags.BeginString, null),
                GetFieldOrDefault(msg.Header, Tags.TargetCompID, null),
                GetFieldOrDefault(msg.Header, Tags.SenderCompID, null)
            );
        }

        /// <summary>
        /// FIXME totally bogus
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static SessionID GetReverseSessionID(string msg)
        {
            Message FIXME = new Message(msg);
            return GetReverseSessionID(FIXME);
        }

        /// <summary>
        /// FIXME totally bogus
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static string GetMsgType(string msg)
        {
            Message FIXME = new Message(msg);
            return FIXME.GetField(Tags.MsgType);
        }

        #endregion

        public bool FromStringHeader(string msgstr)
        {
            Clear();
            
            int pos = 0;
            int count = 0;
            while(pos < msgstr.Length)
            {
                StringField f = ExtractField(msgstr, ref pos);
                
                if((count < 3) && (Header.HEADER_FIELD_ORDER[count++] != f.Tag))
                    return false;
                
                if(IsHeaderField(f.Tag))
                    this.Header.SetField(f, false);
                else
                    break;
            }
            return true;
        }

        public void FromString(string msgstr, bool validate, DataDictionary.DataDictionary sessionDD, DataDictionary.DataDictionary appDD)
        {
            Clear();

            string msgType = "";
            bool expectingHeader = true;
            bool expectingBody = true;
            int count = 0;
            int pos = 0;
	        DataDictionary.IFieldMapSpec msgMap = null;

            while (pos < msgstr.Length)
            {
                StringField f = ExtractField(msgstr, ref pos, sessionDD, appDD);
                
                if (validate && (count < 3) && (Header.HEADER_FIELD_ORDER[count++] != f.Tag))
                    throw new InvalidMessage("Header fields out of order");

                if (IsHeaderField(f.Tag, sessionDD))
                {
                    if (!expectingHeader)
                    {
                        if (0 == field_)
                            field_ = f.Tag;
                        validStructure_ = false;
                    }

                    if (Tags.MsgType.Equals(f.Tag))
                    {
                        msgType = string.Copy(f.Obj);
                        if (appDD != null)
                        {
                            msgMap = appDD.GetMapForMessage(msgType);
                        }
		            }

                    if (!this.Header.SetField(f, false))
                        this.Header.RepeatedTags.Add(f);

                    if ((null != sessionDD) && sessionDD.Header.IsGroup(f.Tag))
                    {
                        pos = SetGroup(f, msgstr, pos, this.Header, sessionDD.Header.GetGroupSpec(f.Tag), sessionDD, appDD);
                    }
                }
                else if (IsTrailerField(f.Tag, sessionDD))
                {
                    expectingHeader = false;
                    expectingBody = false;
                    if (!this.Trailer.SetField(f, false))
                        this.Trailer.RepeatedTags.Add(f);

                    if ((null != sessionDD) && sessionDD.Trailer.IsGroup(f.Tag))
                    {
                        pos = SetGroup(f, msgstr, pos, this.Trailer, sessionDD.Trailer.GetGroup(f.Tag), sessionDD, appDD);
                    }
                }
                else
                {
                    if (!expectingBody)
                    {
                        if (0 == field_)
                            field_ = f.Tag;
                        validStructure_ = false;
                    }

                    expectingHeader = false;
                    if (!SetField(f, false))
                    {
                        this.RepeatedTags.Add(f);
                    }

                    
                    if((null != msgMap) && (msgMap.IsGroup(f.Tag))) 
                    {
                        pos = SetGroup(f, msgstr, pos, this, msgMap.GetGroupSpec(f.Tag), sessionDD, appDD);
                    }
                }
            }

            if (validate)
            {
                Validate();
            }
        }

        protected int SetGroup(StringField grpNoFld, string msgstr, int pos, FieldMap fieldMap, DataDictionary.IGroupSpec dd, DataDictionary.DataDictionary sessionDataDictionary, DataDictionary.DataDictionary appDD)
        {
            int delim = dd.Delim;
            int grpPos = pos;
            Group grp = null;

            while (pos < msgstr.Length)
            {
                grpPos = pos;
                StringField f = ExtractField(msgstr, ref pos, sessionDataDictionary, appDD);
                if (f.Tag == delim)
                {
                    if (grp != null)
                    {
                        fieldMap.AddGroup(grp);
                    }
                    grp = new Group(grpNoFld.Tag, delim);
                }
                else if (!dd.IsField(f.Tag))
                {
                    if (grp != null)
                    {
                        fieldMap.AddGroup(grp);
                    }
                    return grpPos;
                }
                grp.SetField(f);
                if(dd.IsGroup(f.Tag))
                {
                    pos = SetGroup(f, msgstr, pos, grp, dd.GetGroupSpec(f.Tag), sessionDataDictionary, appDD);
                }
            }
            
            return grpPos;
        }

        public bool HasValidStructure(out int field)
        {
            field = field_;
            return validStructure_;
        }

        public void Validate()
        {
            try
            {
                int receivedBodyLength = this.Header.GetInt(Tags.BodyLength);
                if (BodyLength() != receivedBodyLength)
                    throw new InvalidMessage("Expected BodyLength=" + BodyLength() + ", Received BodyLength=" + receivedBodyLength);

                int receivedCheckSum = this.Trailer.GetInt(Tags.CheckSum);
                if (CheckSum() != receivedCheckSum)
                    throw new InvalidMessage("Expected CheckSum=" + CheckSum() + ", Received CheckSum=" + receivedCheckSum);
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
            this.Header.RemoveField(Tags.BeginString);
            this.Header.RemoveField(Tags.SenderCompID);
            this.Header.RemoveField(Tags.TargetCompID);

            if (header.IsSetField(Tags.BeginString))
            {
                string beginString = header.GetField(Tags.BeginString);
                if (beginString.Length > 0)
                    this.Header.SetField(new BeginString(beginString));

                this.Header.RemoveField(Tags.OnBehalfOfLocationID);
                this.Header.RemoveField(Tags.DeliverToLocationID);

                if (beginString.CompareTo("FIX.4.1") >= 0)
                {
                    if (header.IsSetField(Tags.OnBehalfOfLocationID))
                    {
                        string onBehalfOfLocationID = header.GetField(Tags.OnBehalfOfLocationID);
                        if (onBehalfOfLocationID.Length > 0)
                            this.Header.SetField(new DeliverToLocationID(onBehalfOfLocationID));
                    }

                    if (header.IsSetField(Tags.DeliverToLocationID))
                    {
                        string deliverToLocationID = header.GetField(Tags.DeliverToLocationID);
                        if (deliverToLocationID.Length > 0)
                            this.Header.SetField(new OnBehalfOfLocationID(deliverToLocationID));
                    }
                }
            }

            if (header.IsSetField(Tags.SenderCompID))
            {
                SenderCompID senderCompID = new SenderCompID();
                header.GetField(senderCompID);
                if (senderCompID.Obj.Length > 0)
                    this.Header.SetField(new TargetCompID(senderCompID.Obj));
            }

            if (header.IsSetField(Tags.TargetCompID))
            {
                TargetCompID targetCompID = new TargetCompID();
                header.GetField(targetCompID);
                if (targetCompID.Obj.Length > 0)
                    this.Header.SetField(new SenderCompID(targetCompID.Obj));
            }

            // optional routing tags
            this.Header.RemoveField(Tags.OnBehalfOfCompID);
            this.Header.RemoveField(Tags.OnBehalfOfSubID);
            this.Header.RemoveField(Tags.DeliverToCompID);
            this.Header.RemoveField(Tags.DeliverToSubID);

            if(header.IsSetField(Tags.OnBehalfOfCompID))
            {
                string onBehalfOfCompID = header.GetField(Tags.OnBehalfOfCompID);
                if(onBehalfOfCompID.Length > 0)
                    this.Header.SetField(new DeliverToCompID(onBehalfOfCompID));
            }

            if(header.IsSetField(Tags.OnBehalfOfSubID))
            {
                string onBehalfOfSubID = header.GetField(  Tags.OnBehalfOfSubID);
                if(onBehalfOfSubID.Length > 0)
                    this.Header.SetField(new DeliverToSubID(onBehalfOfSubID));
            }

            if(header.IsSetField(Tags.DeliverToCompID))
            {
                string deliverToCompID = header.GetField(Tags.DeliverToCompID);
                if(deliverToCompID.Length > 0)
                    this.Header.SetField(new OnBehalfOfCompID(deliverToCompID));
            }

            if(header.IsSetField(Tags.DeliverToSubID))
            {
                string deliverToSubID = header.GetField(Tags.DeliverToSubID);
                if(deliverToSubID.Length > 0)
                    this.Header.SetField(new OnBehalfOfSubID(deliverToSubID));
            }
        }

        public int CheckSum()
        {
            return (
                (this.Header.CalculateTotal()
                + CalculateTotal()
                + this.Trailer.CalculateTotal()) % 256);
        }

        public bool IsAdmin()
        {
            if(!IsSetField(Tags.MsgType))
                return false;
            string msgType = this.Header.GetField(Tags.MsgType); /// FIXME
            return IsAdminMsgType(msgType);
        }

        public bool IsApp()
        {
            if (!IsSetField(Tags.MsgType))
                return false;
            string msgType = this.Header.GetField(Tags.MsgType); /// FIXME
            return !IsAdminMsgType(msgType);
        }

        /// <summary>
        /// FIXME less operator new
        /// </summary>
        /// <param name="sessionID"></param>
        public void SetSessionID(SessionID sessionID)
        {
            this.Header.SetField(new BeginString(sessionID.BeginString));
            this.Header.SetField(new SenderCompID(sessionID.SenderCompID));
            this.Header.SetField(new TargetCompID(sessionID.TargetCompID));            
        }

        public SessionID GetSessionID(Message m)
        {
            return new SessionID(
                m.Header.GetField(Tags.BeginString),
                m.Header.GetField(Tags.SenderCompID),
                m.Header.GetField(Tags.TargetCompID));
        }

        public override void Clear()
        {
            field_ = 0;
            this.Header.Clear();
            base.Clear();
            this.Trailer.Clear();
        }

        public override string ToString()
        {
            this.Header.SetField(new BodyLength(BodyLength()), true);
            this.Trailer.SetField(new CheckSum(Fields.Converters.CheckSumConverter.Convert(CheckSum())), true);

            return this.Header.CalculateString() + CalculateString() + this.Trailer.CalculateString();
        }

        protected int BodyLength()
        {
            return this.Header.CalculateLength() + CalculateLength() + this.Trailer.CalculateLength();
        }
    }
}
