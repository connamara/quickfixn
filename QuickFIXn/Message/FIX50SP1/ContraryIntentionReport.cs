﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class ContraryIntentionReport : Message
    {
        public const string MsgType = "BO";

        public ContraryIntentionReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
