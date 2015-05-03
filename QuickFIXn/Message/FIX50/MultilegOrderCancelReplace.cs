﻿using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class MultilegOrderCancelReplace : Message
    {
        public const string MsgType = "AC";

        public MultilegOrderCancelReplace():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
