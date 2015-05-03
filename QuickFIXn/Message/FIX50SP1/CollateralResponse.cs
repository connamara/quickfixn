﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class CollateralResponse : Message
    {
        public const string MsgType = "AZ";

        public CollateralResponse():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
