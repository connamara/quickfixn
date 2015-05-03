﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class CollateralInquiryAck : Message
    {
        public const string MsgType = "BG";

        public CollateralInquiryAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
