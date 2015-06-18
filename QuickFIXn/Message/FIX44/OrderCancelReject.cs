using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class OrderCancelReject : Message
    {
        public const string MsgType = "9";

        public OrderCancelReject():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public OrderCancelReject(QuickFix.Fields.OrderID aOrderID,
				QuickFix.Fields.ClOrdID aClOrdID,
				QuickFix.Fields.OrigClOrdID aOrigClOrdID,
				QuickFix.Fields.OrdStatus aOrdStatus,
				QuickFix.Fields.CxlRejResponseTo aCxlRejResponseTo)
               : this()
        {
            this.OrderID = aOrderID;
			this.ClOrdID = aClOrdID;
			this.OrigClOrdID = aOrigClOrdID;
			this.OrdStatus = aOrdStatus;
			this.CxlRejResponseTo = aCxlRejResponseTo;
        }

        public QuickFix.Fields.OrderID OrderID
        {
            get
            {
                var val = new QuickFix.Fields.OrderID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderID val) { this.OrderID = val; }

        public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderID val) { return IsSetOrderID(); }

        public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

        public QuickFix.Fields.SecondaryOrderID SecondaryOrderID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryOrderID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryOrderID val) { this.SecondaryOrderID = val; }

        public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryOrderID val) { return IsSetSecondaryOrderID(); }

        public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }

        public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryClOrdID val) { this.SecondaryClOrdID = val; }

        public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }

        public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

        public QuickFix.Fields.ClOrdID ClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.ClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClOrdID val) { this.ClOrdID = val; }

        public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClOrdID val) { return IsSetClOrdID(); }

        public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

        public QuickFix.Fields.ClOrdLinkID ClOrdLinkID
        {
            get
            {
                var val = new QuickFix.Fields.ClOrdLinkID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClOrdLinkID val) { this.ClOrdLinkID = val; }

        public QuickFix.Fields.ClOrdLinkID Get(QuickFix.Fields.ClOrdLinkID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClOrdLinkID val) { return IsSetClOrdLinkID(); }

        public bool IsSetClOrdLinkID() { return IsSetField(Tags.ClOrdLinkID); }

        public QuickFix.Fields.OrigClOrdID OrigClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.OrigClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigClOrdID val) { this.OrigClOrdID = val; }

        public QuickFix.Fields.OrigClOrdID Get(QuickFix.Fields.OrigClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigClOrdID val) { return IsSetOrigClOrdID(); }

        public bool IsSetOrigClOrdID() { return IsSetField(Tags.OrigClOrdID); }

        public QuickFix.Fields.OrdStatus OrdStatus
        {
            get
            {
                var val = new QuickFix.Fields.OrdStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrdStatus val) { this.OrdStatus = val; }

        public QuickFix.Fields.OrdStatus Get(QuickFix.Fields.OrdStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrdStatus val) { return IsSetOrdStatus(); }

        public bool IsSetOrdStatus() { return IsSetField(Tags.OrdStatus); }

        public QuickFix.Fields.WorkingIndicator WorkingIndicator
        {
            get
            {
                var val = new QuickFix.Fields.WorkingIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.WorkingIndicator val) { this.WorkingIndicator = val; }

        public QuickFix.Fields.WorkingIndicator Get(QuickFix.Fields.WorkingIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.WorkingIndicator val) { return IsSetWorkingIndicator(); }

        public bool IsSetWorkingIndicator() { return IsSetField(Tags.WorkingIndicator); }

        public QuickFix.Fields.OrigOrdModTime OrigOrdModTime
        {
            get
            {
                var val = new QuickFix.Fields.OrigOrdModTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigOrdModTime val) { this.OrigOrdModTime = val; }

        public QuickFix.Fields.OrigOrdModTime Get(QuickFix.Fields.OrigOrdModTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigOrdModTime val) { return IsSetOrigOrdModTime(); }

        public bool IsSetOrigOrdModTime() { return IsSetField(Tags.OrigOrdModTime); }

        public QuickFix.Fields.ListID ListID
        {
            get
            {
                var val = new QuickFix.Fields.ListID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ListID val) { this.ListID = val; }

        public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ListID val) { return IsSetListID(); }

        public bool IsSetListID() { return IsSetField(Tags.ListID); }

        public QuickFix.Fields.Account Account
        {
            get
            {
                var val = new QuickFix.Fields.Account();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Account val) { this.Account = val; }

        public QuickFix.Fields.Account Get(QuickFix.Fields.Account val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Account val) { return IsSetAccount(); }

        public bool IsSetAccount() { return IsSetField(Tags.Account); }

        public QuickFix.Fields.AcctIDSource AcctIDSource
        {
            get
            {
                var val = new QuickFix.Fields.AcctIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AcctIDSource val) { this.AcctIDSource = val; }

        public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AcctIDSource val) { return IsSetAcctIDSource(); }

        public bool IsSetAcctIDSource() { return IsSetField(Tags.AcctIDSource); }

        public QuickFix.Fields.AccountType AccountType
        {
            get
            {
                var val = new QuickFix.Fields.AccountType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AccountType val) { this.AccountType = val; }

        public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AccountType val) { return IsSetAccountType(); }

        public bool IsSetAccountType() { return IsSetField(Tags.AccountType); }

        public QuickFix.Fields.TradeOriginationDate TradeOriginationDate
        {
            get
            {
                var val = new QuickFix.Fields.TradeOriginationDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeOriginationDate val) { this.TradeOriginationDate = val; }

        public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeOriginationDate val) { return IsSetTradeOriginationDate(); }

        public bool IsSetTradeOriginationDate() { return IsSetField(Tags.TradeOriginationDate); }

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

        public QuickFix.Fields.CxlRejResponseTo CxlRejResponseTo
        {
            get
            {
                var val = new QuickFix.Fields.CxlRejResponseTo();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CxlRejResponseTo val) { this.CxlRejResponseTo = val; }

        public QuickFix.Fields.CxlRejResponseTo Get(QuickFix.Fields.CxlRejResponseTo val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CxlRejResponseTo val) { return IsSetCxlRejResponseTo(); }

        public bool IsSetCxlRejResponseTo() { return IsSetField(Tags.CxlRejResponseTo); }

        public QuickFix.Fields.CxlRejReason CxlRejReason
        {
            get
            {
                var val = new QuickFix.Fields.CxlRejReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CxlRejReason val) { this.CxlRejReason = val; }

        public QuickFix.Fields.CxlRejReason Get(QuickFix.Fields.CxlRejReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CxlRejReason val) { return IsSetCxlRejReason(); }

        public bool IsSetCxlRejReason() { return IsSetField(Tags.CxlRejReason); }

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
