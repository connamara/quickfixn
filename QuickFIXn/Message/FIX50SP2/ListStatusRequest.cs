﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class ListStatusRequest : Message
    {
        public const string MsgType = "M";

        public ListStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
