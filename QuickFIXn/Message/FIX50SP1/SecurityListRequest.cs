﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class SecurityListRequest : Message
    {
        public const string MsgType = "x";

        public SecurityListRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
