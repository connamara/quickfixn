using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFIX.NET.Fields;

namespace QuickFIX.NET
{
    public class Message : FieldMap
    {
        public static char SOH = '\x01';

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
                StringField f = ExtractField(msgstr, ref pos);
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
        public static MsgType IdentifyType(string msgstr)
        {
            int valbeg = msgstr.IndexOf(SOH + "35=") + 4;
            if (valbeg.Equals(-1))
                throw new MessageParseException("no tag 35 found in msg: " + msgstr);
            int valend = msgstr.IndexOf(SOH, valbeg);
            if (valend.Equals(-1))
                throw new MessageParseException("no SOH after tag 35 in msg: " + msgstr);

            return (new MsgType(msgstr.Substring(valbeg, (valend - valbeg))));
        }

        public static StringField ExtractField(string msgstr, ref int pos)
        {
            try
            {
                int tagend = msgstr.IndexOf("=", pos);
                int tag = Convert.ToInt32(msgstr.Substring(pos, tagend - pos));
                pos = tagend + 1;
                int fieldvalend = msgstr.IndexOf(SOH, pos);
                StringField field =
                    new StringField(tag, msgstr.Substring(pos, fieldvalend - pos));
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

        #region Private Members
        FieldMap _header;
        FieldMap _trailer;
        #endregion
    }
}
