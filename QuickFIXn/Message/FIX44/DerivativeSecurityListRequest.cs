﻿using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class DerivativeSecurityListRequest : Message
    {
        public const string MsgType = "z";

        public DerivativeSecurityListRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
