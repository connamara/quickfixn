﻿using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class MarketDataRequestReject : Message
    {
        public const string MsgType = "Y";

        public MarketDataRequestReject():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
