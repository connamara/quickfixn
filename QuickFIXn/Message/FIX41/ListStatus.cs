using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class ListStatus : Message
    {
        public const string MsgType = "N";

        public ListStatus():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public ListStatus(QuickFix.Fields.ListID aListID,
				QuickFix.Fields.NoRpts aNoRpts,
				QuickFix.Fields.RptSeq aRptSeq)
               : this()
        {
            this.ListID = aListID;
			this.NoRpts = aNoRpts;
			this.RptSeq = aRptSeq;
        }

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

        public QuickFix.Fields.WaveNo WaveNo
        {
            get
            {
                var val = new QuickFix.Fields.WaveNo();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.WaveNo val) { this.WaveNo = val; }

        public QuickFix.Fields.WaveNo Get(QuickFix.Fields.WaveNo val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.WaveNo val) { return IsSetWaveNo(); }

        public bool IsSetWaveNo() { return IsSetField(Tags.WaveNo); }

        public QuickFix.Fields.NoRpts NoRpts
        {
            get
            {
                var val = new QuickFix.Fields.NoRpts();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRpts val) { this.NoRpts = val; }

        public QuickFix.Fields.NoRpts Get(QuickFix.Fields.NoRpts val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRpts val) { return IsSetNoRpts(); }

        public bool IsSetNoRpts() { return IsSetField(Tags.NoRpts); }

        public QuickFix.Fields.RptSeq RptSeq
        {
            get
            {
                var val = new QuickFix.Fields.RptSeq();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RptSeq val) { this.RptSeq = val; }

        public QuickFix.Fields.RptSeq Get(QuickFix.Fields.RptSeq val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RptSeq val) { return IsSetRptSeq(); }

        public bool IsSetRptSeq() { return IsSetField(Tags.RptSeq); }

        public QuickFix.Fields.NoOrders NoOrders
        {
            get
            {
                var val = new QuickFix.Fields.NoOrders();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoOrders val) { this.NoOrders = val; }

        public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoOrders val) { return IsSetNoOrders(); }

        public bool IsSetNoOrders() { return IsSetField(Tags.NoOrders); }


        public class NoOrdersGroup : Group
        {
            public static int[] fieldOrder = {Tags.ClOrdID, Tags.CumQty, Tags.LeavesQty, Tags.CxlQty, Tags.AvgPx, 0};

            public NoOrdersGroup() : base(Tags.NoOrders, Tags.ClOrdID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoOrdersGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
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

        public QuickFix.Fields.CumQty CumQty
        {
            get
            {
                var val = new QuickFix.Fields.CumQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CumQty val) { this.CumQty = val; }

        public QuickFix.Fields.CumQty Get(QuickFix.Fields.CumQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CumQty val) { return IsSetCumQty(); }

        public bool IsSetCumQty() { return IsSetField(Tags.CumQty); }

        public QuickFix.Fields.LeavesQty LeavesQty
        {
            get
            {
                var val = new QuickFix.Fields.LeavesQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LeavesQty val) { this.LeavesQty = val; }

        public QuickFix.Fields.LeavesQty Get(QuickFix.Fields.LeavesQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LeavesQty val) { return IsSetLeavesQty(); }

        public bool IsSetLeavesQty() { return IsSetField(Tags.LeavesQty); }

        public QuickFix.Fields.CxlQty CxlQty
        {
            get
            {
                var val = new QuickFix.Fields.CxlQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CxlQty val) { this.CxlQty = val; }

        public QuickFix.Fields.CxlQty Get(QuickFix.Fields.CxlQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CxlQty val) { return IsSetCxlQty(); }

        public bool IsSetCxlQty() { return IsSetField(Tags.CxlQty); }

        public QuickFix.Fields.AvgPx AvgPx
        {
            get
            {
                var val = new QuickFix.Fields.AvgPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AvgPx val) { this.AvgPx = val; }

        public QuickFix.Fields.AvgPx Get(QuickFix.Fields.AvgPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AvgPx val) { return IsSetAvgPx(); }

        public bool IsSetAvgPx() { return IsSetField(Tags.AvgPx); }


        }


    }
}
