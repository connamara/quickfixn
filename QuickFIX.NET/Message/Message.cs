using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix.Fields;

namespace QuickFix
{
    public class Header : FieldMap
    {
        private int[] EXCLUDED_HEADER_FIELDS = { Fields.Tags.BeginString, Fields.Tags.BodyLength, Fields.Tags.MsgType };

        public override string CalculateString()
        {
            return base.CalculateString(new StringBuilder(), EXCLUDED_HEADER_FIELDS);
        }

        public override string CalculateString(StringBuilder sb, int[] preFields)
        {
            return base.CalculateString(sb, EXCLUDED_HEADER_FIELDS);
        }
    }

    public class Message : FieldMap
    {
        public Message()
        {
            this.Header = new Header();
            this.Trailer = new FieldMap();
        }

        public Message(string msgstr)
            : this()
        {
            FromString(msgstr);
        }

        public void FromString(string msgstr)
        {
            int pos = 0;
            while (pos < msgstr.Length)
            {
                Fields.StringField f = ExtractField(msgstr, ref pos);
                if (IsHeaderField(f.Tag))
                    _header.setField(f);
                else if (IsTrailerField(f.Tag))
                    _trailer.setField(f);
                else
                    setField(f);
            }
        }

        #region Properties
        public Header Header
        {
            get { return _header; }
            private set { _header = value; }
        }

        public FieldMap Trailer
        {
            get { return _trailer; }
            private set { _trailer = value; }
        }
        #endregion

        #region Static Methods
        
        public static bool IsAdminMsgType(string msgType)
        {
            return msgType.Length == 1 && "0A12345h".IndexOf(msgType) != -1;
        }

        /// <summary>
        /// Parse the MstType from a FIX string
        /// </summary>
        /// <param name="msgstr">string of a FIX message</param>
        /// <returns>MsgType object</returns>
        public static Fields.MsgType IdentifyType(string msgstr)
        {
            int valbeg = msgstr.IndexOf("\u000135=") + 4;
            if (valbeg.Equals(-1))
                throw new MessageParseException("no tag 35 found in msg: " + msgstr);
            int valend = msgstr.IndexOf("\u0001", valbeg);
            if (valend.Equals(-1))
                throw new MessageParseException("no SOH after tag 35 in msg: " + msgstr);

            return (new Fields.MsgType(msgstr.Substring(valbeg, (valend - valbeg))));
        }

        public static Fields.StringField ExtractField(string msgstr, ref int pos)
        {
            try
            {
                int tagend = msgstr.IndexOf("=", pos);
                int tag = Convert.ToInt32(msgstr.Substring(pos, tagend - pos));
                pos = tagend + 1;
                int fieldvalend = msgstr.IndexOf("\u0001", pos);
                Fields.StringField field =
                    new Fields.StringField(tag, msgstr.Substring(pos, fieldvalend - pos));
                pos = fieldvalend + 1;
                return field;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw new MessageParseException("", e);
            }
            catch (System.OverflowException e)
            {
                throw new MessageParseException("", e);
            }
            catch (System.FormatException e)
            {
                throw new MessageParseException("", e);
            }
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

        public static string GetFieldOrDefault(FieldMap fields, int tag, string defaultValue)
        {
            if(!fields.isSetField(tag))
                return defaultValue;
            
            try 
            {
                return fields.GetField(tag);
            }
            catch(FieldNotFoundException)
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
                (_header.CalculateTotal()
                + CalculateTotal()
                + _trailer.CalculateTotal()) % 256);
        }

        public override string ToString()
        {
            _header.setField(new BodyLength(BodyLength()), true);
            _trailer.setField(new CheckSum(Fields.Converters.CheckSumConverter.Convert(CheckSum())), true);

            return _header.CalculateString() + CalculateString() + _trailer.CalculateString();
        }

        private decimal BodyLength()
        {
            return _header.CalculateLength() + CalculateLength() + _trailer.CalculateLength();
        }

        public const string SOH = "\u0001";

        #region Private Members
        Header _header;
        FieldMap _trailer;
        #endregion
    }
}
