using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET
{
    public class Message : FieldMap
    {
        public Message() 
        {
            Header = new FieldMap();
            Trailer = new FieldMap();
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
            int valend = msgstr.IndexOf("\u0001",valbeg);
            if (valend.Equals(-1))
                throw new MessageParseException("no SOH after tag 35 in msg: " + msgstr);

            return( new Fields.MsgType( msgstr.Substring(valbeg, (valend-valbeg) )) );
        }

        #region Private Members
        FieldMap _header;
        FieldMap _trailer;
        #endregion
    }
}
