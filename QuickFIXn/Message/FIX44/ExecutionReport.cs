﻿using QuickFix.Fields;
namespace QuickFix.FIX44
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
