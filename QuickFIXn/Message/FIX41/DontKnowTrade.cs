﻿using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class DontKnowTrade : Message
    {
        public const string MsgType = "Q";

        public DontKnowTrade():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
