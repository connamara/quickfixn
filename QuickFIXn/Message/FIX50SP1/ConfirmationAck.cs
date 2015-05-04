using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class ConfirmationAck : Message
    {
        public const string MsgType = "AU";

        public ConfirmationAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public ConfirmationAck(QuickFix.Fields.ConfirmID aConfirmID,
				QuickFix.Fields.TradeDate aTradeDate,
				QuickFix.Fields.TransactTime aTransactTime,
				QuickFix.Fields.AffirmStatus aAffirmStatus)
               : this()
        {
            this.ConfirmID = aConfirmID;
			this.TradeDate = aTradeDate;
			this.TransactTime = aTransactTime;
			this.AffirmStatus = aAffirmStatus;
        }

        public QuickFix.Fields.ConfirmID ConfirmID
        {
            get
            {
                var val = new QuickFix.Fields.ConfirmID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ConfirmID val) { this.ConfirmID = val; }

        public QuickFix.Fields.ConfirmID Get(QuickFix.Fields.ConfirmID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ConfirmID val) { return IsSetConfirmID(); }

        public bool IsSetConfirmID() { return IsSetField(Tags.ConfirmID); }

        public QuickFix.Fields.TradeDate TradeDate
        {
            get
            {
                var val = new QuickFix.Fields.TradeDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeDate val) { this.TradeDate = val; }

        public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeDate val) { return IsSetTradeDate(); }

        public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

        public QuickFix.Fields.TransactTime TransactTime
        {
            get
            {
                var val = new QuickFix.Fields.TransactTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TransactTime val) { this.TransactTime = val; }

        public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TransactTime val) { return IsSetTransactTime(); }

        public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

        public QuickFix.Fields.AffirmStatus AffirmStatus
        {
            get
            {
                var val = new QuickFix.Fields.AffirmStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AffirmStatus val) { this.AffirmStatus = val; }

        public QuickFix.Fields.AffirmStatus Get(QuickFix.Fields.AffirmStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AffirmStatus val) { return IsSetAffirmStatus(); }

        public bool IsSetAffirmStatus() { return IsSetField(Tags.AffirmStatus); }

        public QuickFix.Fields.ConfirmRejReason ConfirmRejReason
        {
            get
            {
                var val = new QuickFix.Fields.ConfirmRejReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ConfirmRejReason val) { this.ConfirmRejReason = val; }

        public QuickFix.Fields.ConfirmRejReason Get(QuickFix.Fields.ConfirmRejReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ConfirmRejReason val) { return IsSetConfirmRejReason(); }

        public bool IsSetConfirmRejReason() { return IsSetField(Tags.ConfirmRejReason); }

        public QuickFix.Fields.MatchStatus MatchStatus
        {
            get
            {
                var val = new QuickFix.Fields.MatchStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MatchStatus val) { this.MatchStatus = val; }

        public QuickFix.Fields.MatchStatus Get(QuickFix.Fields.MatchStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MatchStatus val) { return IsSetMatchStatus(); }

        public bool IsSetMatchStatus() { return IsSetField(Tags.MatchStatus); }

        public QuickFix.Fields.Text Text
        {
            get
            {
                var val = new QuickFix.Fields.Text();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Text val) { this.Text = val; }

        public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Text val) { return IsSetText(); }

        public bool IsSetText() { return IsSetField(Tags.Text); }

        public QuickFix.Fields.EncodedTextLen EncodedTextLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedTextLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedTextLen val) { this.EncodedTextLen = val; }

        public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedTextLen val) { return IsSetEncodedTextLen(); }

        public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

        public QuickFix.Fields.EncodedText EncodedText
        {
            get
            {
                var val = new QuickFix.Fields.EncodedText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedText val) { this.EncodedText = val; }

        public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedText val) { return IsSetEncodedText(); }

        public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }


    }
}
