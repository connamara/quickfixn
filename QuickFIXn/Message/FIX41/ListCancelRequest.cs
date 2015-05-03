﻿using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class ListCancelRequest : Message
    {
        public const string MsgType = "K";

        public ListCancelRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
