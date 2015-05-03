﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class MarketDefinitionUpdateReport : Message
    {
        public const string MsgType = "BV";

        public MarketDefinitionUpdateReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
