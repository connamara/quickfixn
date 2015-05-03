﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class Advertisement : Message
    {
        public const string MsgType = "7";

        public Advertisement():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
