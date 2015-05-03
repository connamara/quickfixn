﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class ExecutionReport : Message
    {
        public const string MsgType = "8";

        public ExecutionReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
