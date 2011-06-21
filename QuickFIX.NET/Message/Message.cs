using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix.Fields;

namespace QuickFix
{
    public class Message : FieldMap
    {
        public Message()
        {
            Header = new FieldMap();
            Trailer = new FieldMap();
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
        public FieldMap Header
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

        public int CheckSum()
        {
            return (
                (_header.CalculateTotal()
                + CalculateTotal()
                + _trailer.CalculateTotal()) % 256);
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

        public override string ToString()
        {
            _header.setField(new BodyLength(BodyLength()), true);
            _trailer.setField(new CheckSum(CheckSum().ToString()), true);

            return _header.CalculateString() + CalculateString() + _trailer.CalculateString();
        }

        private decimal BodyLength()
        {
            return _header.CalculateLength() + CalculateLength() + _trailer.CalculateLength();
        }

        public const string SOH = "\u0001";

        #region Private Members
        FieldMap _header;
        FieldMap _trailer;
        #endregion
    }
}
