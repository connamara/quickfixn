﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class MarketDataRequest : Message
    {
        public const string MsgType = "V";

        public MarketDataRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
