﻿using QuickFix.Fields;
namespace QuickFix.FIX43
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
