﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class BusinessMessageReject : Message
    {
        public const string MsgType = "j";

        public BusinessMessageReject():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
