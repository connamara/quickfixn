using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFIX.NET.Fields;

namespace QuickFIX.NET
{
    /// <summary>
    /// TODO: I think this should be generated.
    /// </summary>
    public class Header : FieldMap
    {
        public MsgType MessageType
        {
            get { return _msgType; }
            set { _msgType = value; }
        }
            
        public Header(MsgType msgType)
        {
            _msgType = msgType;
        }

        private MsgType _msgType;
        private int _seqNo = 0;
    }
}
