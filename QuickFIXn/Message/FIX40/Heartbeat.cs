﻿using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class Heartbeat : Message
    {
        public const string MsgType = "0";

        public Heartbeat():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
