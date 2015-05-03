﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class PositionMaintenanceRequest : Message
    {
        public const string MsgType = "AL";

        public PositionMaintenanceRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
