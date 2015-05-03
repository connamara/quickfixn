﻿using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class SecurityDefinitionUpdateReport : Message
    {
        public const string MsgType = "BP";

        public SecurityDefinitionUpdateReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
