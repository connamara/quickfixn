using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class AllocationACK : Message
    {
        public const string MsgType = "P";

        public AllocationACK():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public AllocationACK(QuickFix.Fields.AllocID aAllocID,
				QuickFix.Fields.TradeDate aTradeDate,
				QuickFix.Fields.AllocStatus aAllocStatus)
               : this()
        {
            this.AllocID = aAllocID;
			this.TradeDate = aTradeDate;
			this.AllocStatus = aAllocStatus;
        }

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

        public QuickFix.Fields.AllocID AllocID
        {
            get
            {
                var val = new QuickFix.Fields.AllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocID val) { this.AllocID = val; }

        public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocID val) { return IsSetAllocID(); }

        public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

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

        public QuickFix.Fields.AllocStatus AllocStatus
        {
            get
            {
                var val = new QuickFix.Fields.AllocStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocStatus val) { this.AllocStatus = val; }

        public QuickFix.Fields.AllocStatus Get(QuickFix.Fields.AllocStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocStatus val) { return IsSetAllocStatus(); }

        public bool IsSetAllocStatus() { return IsSetField(Tags.AllocStatus); }

        public QuickFix.Fields.AllocRejCode AllocRejCode
        {
            get
            {
                var val = new QuickFix.Fields.AllocRejCode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocRejCode val) { this.AllocRejCode = val; }

        public QuickFix.Fields.AllocRejCode Get(QuickFix.Fields.AllocRejCode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocRejCode val) { return IsSetAllocRejCode(); }

        public bool IsSetAllocRejCode() { return IsSetField(Tags.AllocRejCode); }

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


    }
}
