﻿using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class RegistrationInstructions : Message
    {
        public const string MsgType = "o";

        public RegistrationInstructions():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
