﻿using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class BidResponse : Message
    {
        public const string MsgType = "l";

        public BidResponse():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
