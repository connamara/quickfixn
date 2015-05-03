﻿using QuickFix.Fields;
namespace QuickFix.FIXT11
{
    public class Logout : Message
    {
        public const string MsgType = "5";

        public Logout():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
