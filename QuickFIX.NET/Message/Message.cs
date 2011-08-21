using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix.Fields;

namespace QuickFix
{
    public class Header : FieldMap
    {
        public int[] HEADER_FIELD_ORDER = { Fields.Tags.BeginString, Fields.Tags.BodyLength, Fields.Tags.MsgType };

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

        public Message(string msgstr, DataDictionary.DataDictionary sessionDataDictionary, DataDictionary.DataDictionary applicationDataDictionary, bool validate)
            : this()
        {
            FromStringHeader(msgstr);
            if(IsAdmin())
                FromString(msgstr, validate, sessionDataDictionary, sessionDataDictionary);
            else
                FromString(msgstr, validate, sessionDataDictionary, applicationDataDictionary);
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
        public static Fields.MsgType IdentifyType(string msgstr)
        {
            int valbeg = msgstr.IndexOf("\u000135=") + 4;
            if (valbeg.Equals(-1))
                throw new MessageParseError("no tag 35 found in msg: " + msgstr);
            int valend = msgstr.IndexOf("\u0001", valbeg);
            if (valend.Equals(-1))
                throw new MessageParseError("no SOH after tag 35 in msg: " + msgstr);

            return (new Fields.MsgType(msgstr.Substring(valbeg, (valend - valbeg))));
        }

        public static Fields.StringField ExtractField(string msgstr, ref int pos, DataDictionary.DataDictionary sessionDD, DataDictionary.DataDictionary appDD)
        {
            try
            {
                int tagend = msgstr.IndexOf("=", pos);
                int tag = Convert.ToInt32(msgstr.Substring(pos, tagend - pos));
                pos = tagend + 1;
                int fieldvalend = msgstr.IndexOf("\u0001", pos);
                Fields.StringField field =  new Fields.StringField(tag, msgstr.Substring(pos, fieldvalend - pos));

                /** TODO data dict stuff
                if (((null != sessionDD) && sessionDD.IsDataField(field.Tag)) || ((null != appDD) && appDD.IsDataField(field.Tag)))
                {
                    string fieldLength = "";
                    // Assume length field is 1 less
                    int lenField = field.Tag - 1;
                    // Special case for Signature which violates above assumption
                    if (Fields.Tags.Signature.Equals(field.Tag))
                        lenField = Fields.Tags.SignatureLength;

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

        public static Fields.StringField ExtractField(string msgstr, ref int pos)
        {
            return ExtractField(msgstr, ref pos, null, null);
        }

        public static bool IsHeaderField(int tag)
        {
            switch (tag)
            {
                case Fields.Tags.BeginString:
                case Fields.Tags.BodyLength:
                case Fields.Tags.MsgType:
                case Fields.Tags.SenderCompID:
                case Fields.Tags.TargetCompID:
                case Fields.Tags.OnBehalfOfCompID:
                case Fields.Tags.DeliverToCompID:
                case Fields.Tags.SecureDataLen:
                case Fields.Tags.MsgSeqNum:
                case Fields.Tags.SenderSubID:
                case Fields.Tags.SenderLocationID:
                case Fields.Tags.TargetSubID:
                case Fields.Tags.TargetLocationID:
                case Fields.Tags.OnBehalfOfSubID:
                case Fields.Tags.OnBehalfOfLocationID:
                case Fields.Tags.DeliverToSubID:
                case Fields.Tags.DeliverToLocationID:
                case Fields.Tags.PossDupFlag:
                case Fields.Tags.PossResend:
                case Fields.Tags.SendingTime:
                case Fields.Tags.OrigSendingTime:
                case Fields.Tags.XmlDataLen:
                case Fields.Tags.XmlData:
                case Fields.Tags.MessageEncoding:
                case Fields.Tags.LastMsgSeqNumProcessed:
                    // case Fields.Tags.OnBehalfOfSendingTime: TODO 
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
                case Fields.Tags.SignatureLength:
                case Fields.Tags.Signature:
                case Fields.Tags.CheckSum:
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
            if (!fields.isSetField(tag))
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
                GetFieldOrDefault(msg.Header, Fields.Tags.BeginString, null),
                GetFieldOrDefault(msg.Header, Fields.Tags.TargetCompID, null),
                GetFieldOrDefault(msg.Header, Fields.Tags.SenderCompID, null)
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
            return FIXME.GetField(Fields.Tags.MsgType);
        }

        #endregion

        public bool FromStringHeader(string msgstr)
        {
            Clear();
            
            int pos = 0;
            int count = 0;
            while(pos < msgstr.Length)
            {
                Fields.StringField f = ExtractField(msgstr, ref pos);
                
                if((count < 3) && (Header.HEADER_FIELD_ORDER[count++] != f.Tag))
                    return false;
                
                if(IsHeaderField(f.Tag))
                    this.Header.setField(f, false);
                else
                    break;
            }
            return true;
        }

        public void FromString(string msgstr, bool validate, DataDictionary.DataDictionary sessionDataDictionary, DataDictionary.DataDictionary applicationDataDictionary)
        {
            Clear();

            string msg = "";
            bool expectingHeader = true;
            bool expectingBody = true;
            int count = 0;
            int pos = 0;
            while (pos < msgstr.Length)
            {
                Fields.StringField f = ExtractField(msgstr, ref pos, sessionDataDictionary, applicationDataDictionary);
                
                if (validate && (count < 3) && (Header.HEADER_FIELD_ORDER[count++] != f.Tag))
                    throw new InvalidMessage("Header fields out of order");

                if (IsHeaderField(f.Tag, sessionDataDictionary))
                {
                    if (!expectingHeader)
                    {
                        if (0 == field_)
                            field_ = f.Tag;
                        validStructure_ = false;
                    }

                    if (Fields.Tags.MsgType.Equals(f.Tag))
                        msg = string.Copy(f.Obj);

                    if (!this.Header.setField(f, false))
                        this.Header.RepeatedTags.Add(f);

                    /** TODO group stuff
                    if(null != sessionDataDictionary)
                        setGroup("_header_", f, msgstr, pos, this.Header, sessionDataDictionary);
                    */
                }
                else if (IsTrailerField(f.Tag, sessionDataDictionary))
                {
                    expectingHeader = false;
                    expectingBody = false;
                    if (!this.Trailer.setField(f, false))
                        this.Trailer.RepeatedTags.Add(f);

                    /** TODO group stuff
                    if (null != sessionDataDictionary)
                        setGroup("_trailer_", f, msgstr, pos, this.Trailer, sessionDataDictionary);
                    */
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
                    if (!setField(f, false))
                        this.RepeatedTags.Add(f);

                    /** TODO group stuff
                    if(null != applicationDataDictionary)
                        setGroup(msg, f, msgstr, pos, this, applicationDataDictionary);
                    */
                }
            }

            if (validate)
                Validate();
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
                int receivedBodyLength = Fields.Converters.IntConverter.Convert(this.Header.GetField(Fields.Tags.BodyLength)); /// FIXME
                if (BodyLength() != receivedBodyLength)
                    throw new InvalidMessage("Expected BodyLength=" + BodyLength() + ", Received BodyLength=" + receivedBodyLength);

                int receivedCheckSum = Fields.Converters.IntConverter.Convert(this.Trailer.GetField(Fields.Tags.CheckSum)); /// FIXME
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
            this.Header.RemoveField(Fields.Tags.BeginString);
            this.Header.RemoveField(Fields.Tags.SenderCompID);
            this.Header.RemoveField(Fields.Tags.TargetCompID);

            if (header.isSetField(Fields.Tags.BeginString))
            {
                string beginString = header.GetField(Fields.Tags.BeginString);
                if (beginString.Length > 0)
                    this.Header.setField(new BeginString(beginString));

                this.Header.RemoveField(Fields.Tags.OnBehalfOfLocationID);
                this.Header.RemoveField(Fields.Tags.DeliverToLocationID);

                if (beginString.CompareTo("FIX.4.1") >= 0)
                {
                    if (header.isSetField(Fields.Tags.OnBehalfOfLocationID))
                    {
                        string onBehalfOfLocationID = header.GetField(Fields.Tags.OnBehalfOfLocationID);
                        if (onBehalfOfLocationID.Length > 0)
                            this.Header.setField(new DeliverToLocationID(onBehalfOfLocationID));
                    }

                    if (header.isSetField(Fields.Tags.DeliverToLocationID))
                    {
                        string deliverToLocationID = header.GetField(Fields.Tags.DeliverToLocationID);
                        if (deliverToLocationID.Length > 0)
                            this.Header.setField(new OnBehalfOfLocationID(deliverToLocationID));
                    }
                }
            }

            if (header.isSetField(Fields.Tags.SenderCompID))
            {
                SenderCompID senderCompID = new SenderCompID();
                header.getField(senderCompID);
                if (senderCompID.Obj.Length > 0)
                    this.Header.setField(new TargetCompID(senderCompID.Obj));
            }

            if (header.isSetField(Fields.Tags.TargetCompID))
            {
                TargetCompID targetCompID = new TargetCompID();
                header.getField(targetCompID);
                if (targetCompID.Obj.Length > 0)
                    this.Header.setField(new SenderCompID(targetCompID.Obj));
            }

            // optional routing tags
            this.Header.RemoveField(Fields.Tags.OnBehalfOfCompID);
            this.Header.RemoveField(Fields.Tags.OnBehalfOfSubID);
            this.Header.RemoveField(Fields.Tags.DeliverToCompID);
            this.Header.RemoveField(Fields.Tags.DeliverToSubID);

            if(header.isSetField(Fields.Tags.OnBehalfOfCompID))
            {
                string onBehalfOfCompID = header.GetField(Fields.Tags.OnBehalfOfCompID);
                if(onBehalfOfCompID.Length > 0)
                    this.Header.setField(new DeliverToCompID(onBehalfOfCompID));
            }

            if(header.isSetField(Fields.Tags.OnBehalfOfSubID))
            {
                string onBehalfOfSubID = header.GetField(  Fields.Tags.OnBehalfOfSubID);
                if(onBehalfOfSubID.Length > 0)
                    this.Header.setField(new DeliverToSubID(onBehalfOfSubID));
            }

            if(header.isSetField(Fields.Tags.DeliverToCompID))
            {
                string deliverToCompID = header.GetField(Fields.Tags.DeliverToCompID);
                if(deliverToCompID.Length > 0)
                    this.Header.setField(new OnBehalfOfCompID(deliverToCompID));
            }

            if(header.isSetField(Fields.Tags.DeliverToSubID))
            {
                string deliverToSubID = header.GetField(Fields.Tags.DeliverToSubID);
                if(deliverToSubID.Length > 0)
                    this.Header.setField(new OnBehalfOfSubID(deliverToSubID));
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
            if(!isSetField(Fields.Tags.MsgType))
                return false;
            string msgType = this.Header.GetField(Fields.Tags.MsgType); /// FIXME
            return IsAdminMsgType(msgType);
        }

        public bool IsApp()
        {
            if (!isSetField(Fields.Tags.MsgType))
                return false;
            string msgType = this.Header.GetField(Fields.Tags.MsgType); /// FIXME
            return !IsAdminMsgType(msgType);
        }

        /// <summary>
        /// FIXME less operator new
        /// </summary>
        /// <param name="sessionID"></param>
        public void SetSessionID(SessionID sessionID)
        {
            this.Header.setField(new BeginString(sessionID.BeginString));
            this.Header.setField(new SenderCompID(sessionID.SenderCompID));
            this.Header.setField(new TargetCompID(sessionID.TargetCompID));            
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
            this.Header.setField(new BodyLength(BodyLength()), true);
            this.Trailer.setField(new CheckSum(Fields.Converters.CheckSumConverter.Convert(CheckSum())), true);

            return this.Header.CalculateString() + CalculateString() + this.Trailer.CalculateString();
        }

        protected int BodyLength()
        {
            return this.Header.CalculateLength() + CalculateLength() + this.Trailer.CalculateLength();
        }
    }
}
