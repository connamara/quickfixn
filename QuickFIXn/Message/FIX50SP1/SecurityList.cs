﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class SecurityList : Message
    {
        public const string MsgType = "y";

        public SecurityList():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
