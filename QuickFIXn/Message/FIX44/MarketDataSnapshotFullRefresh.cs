﻿using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class MarketDataSnapshotFullRefresh : Message
    {
        public const string MsgType = "W";

        public MarketDataSnapshotFullRefresh():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
