﻿using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class QuoteCancel : Message
    {
        public const string MsgType = "Z";

        public QuoteCancel():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
