﻿using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class QuoteRequestReject : Message
    {
        public const string MsgType = "AG";

        public QuoteRequestReject():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
