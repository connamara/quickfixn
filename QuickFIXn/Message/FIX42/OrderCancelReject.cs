using QuickFix.Fields;
namespace QuickFix.FIX42
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

        public QuickFix.Fields.ClientID ClientID
        {
            get
            {
                var val = new QuickFix.Fields.ClientID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClientID val) { this.ClientID = val; }

        public QuickFix.Fields.ClientID Get(QuickFix.Fields.ClientID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClientID val) { return IsSetClientID(); }

        public bool IsSetClientID() { return IsSetField(Tags.ClientID); }

        public QuickFix.Fields.ExecBroker ExecBroker
        {
            get
            {
                var val = new QuickFix.Fields.ExecBroker();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExecBroker val) { this.ExecBroker = val; }

        public QuickFix.Fields.ExecBroker Get(QuickFix.Fields.ExecBroker val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExecBroker val) { return IsSetExecBroker(); }

        public bool IsSetExecBroker() { return IsSetField(Tags.ExecBroker); }

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
