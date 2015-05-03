﻿namespace QuickFix.FIX50SP2
{
    public abstract class Message : QuickFix.Message
    {
        public Message() : base()
        {
            this.Header.SetField(new QuickFix.Fields.BeginString(QuickFix.FixValues.BeginString.FIX50SP2));
        }
    }
}

     