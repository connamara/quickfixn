﻿using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class SecurityDefinitionRequest : Message
    {
        public const string MsgType = "c";

        public SecurityDefinitionRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
