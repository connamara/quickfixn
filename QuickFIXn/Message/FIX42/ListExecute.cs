﻿using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class ListExecute : Message
    {
        public const string MsgType = "L";

        public ListExecute():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
