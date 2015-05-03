﻿using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class BidRequest : Message
    {
        public const string MsgType = "k";

        public BidRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
