﻿using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class Allocation : Message
    {
        public const string MsgType = "J";

        public Allocation():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
