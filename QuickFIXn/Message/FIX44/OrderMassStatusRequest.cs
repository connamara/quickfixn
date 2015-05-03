﻿using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class OrderMassStatusRequest : Message
    {
        public const string MsgType = "AF";

        public OrderMassStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
