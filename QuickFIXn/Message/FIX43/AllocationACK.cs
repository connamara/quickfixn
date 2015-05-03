﻿using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class AllocationACK : Message
    {
        public const string MsgType = "P";

        public AllocationACK():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
