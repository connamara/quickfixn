﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class SettlementObligationReport : Message
    {
        public const string MsgType = "BQ";

        public SettlementObligationReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
