// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX41;

public class ListStatus : Message
{
    public const string MsgType = "N";

    public ListStatus() : base()
    {
        Header.SetField(new MsgType("N"));
    }

    public ListStatus(
            ListID aListID,
            NoRpts aNoRpts,
            RptSeq aRptSeq
        ) : this()
    {
        ListID = aListID;
        NoRpts = aNoRpts;
        RptSeq = aRptSeq;
    }

    public ListID ListID
    {
        get
        {
            ListID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListID val) { ListID = val; }
    public ListID Get(ListID val) { GetField(val); return val; }
    public bool IsSet(ListID val) { return IsSetListID(); }
    public bool IsSetListID() { return IsSetField(Tags.ListID); }

    public WaveNo WaveNo
    {
        get
        {
            WaveNo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(WaveNo val) { WaveNo = val; }
    public WaveNo Get(WaveNo val) { GetField(val); return val; }
    public bool IsSet(WaveNo val) { return IsSetWaveNo(); }
    public bool IsSetWaveNo() { return IsSetField(Tags.WaveNo); }

    public NoRpts NoRpts
    {
        get
        {
            NoRpts val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRpts val) { NoRpts = val; }
    public NoRpts Get(NoRpts val) { GetField(val); return val; }
    public bool IsSet(NoRpts val) { return IsSetNoRpts(); }
    public bool IsSetNoRpts() { return IsSetField(Tags.NoRpts); }

    public RptSeq RptSeq
    {
        get
        {
            RptSeq val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RptSeq val) { RptSeq = val; }
    public RptSeq Get(RptSeq val) { GetField(val); return val; }
    public bool IsSet(RptSeq val) { return IsSetRptSeq(); }
    public bool IsSetRptSeq() { return IsSetField(Tags.RptSeq); }

    public NoOrders NoOrders
    {
        get
        {
            NoOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoOrders val) { NoOrders = val; }
    public NoOrders Get(NoOrders val) { GetField(val); return val; }
    public bool IsSet(NoOrders val) { return IsSetNoOrders(); }
    public bool IsSetNoOrders() { return IsSetField(Tags.NoOrders); }

    public class NoOrdersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClOrdID, Tags.CumQty, Tags.LeavesQty, Tags.CxlQty, Tags.AvgPx, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ClOrdID, Tags.CumQty, Tags.LeavesQty, Tags.CxlQty, Tags.AvgPx, 0};

        public NoOrdersGroup()
          : base(Tags.NoOrders, Tags.ClOrdID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoOrdersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ClOrdID ClOrdID
        {
            get
            {
                ClOrdID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClOrdID val) { ClOrdID = val; }
        public ClOrdID Get(ClOrdID val) { GetField(val); return val; }
        public bool IsSet(ClOrdID val) { return IsSetClOrdID(); }
        public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

        public CumQty CumQty
        {
            get
            {
                CumQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CumQty val) { CumQty = val; }
        public CumQty Get(CumQty val) { GetField(val); return val; }
        public bool IsSet(CumQty val) { return IsSetCumQty(); }
        public bool IsSetCumQty() { return IsSetField(Tags.CumQty); }

        public LeavesQty LeavesQty
        {
            get
            {
                LeavesQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LeavesQty val) { LeavesQty = val; }
        public LeavesQty Get(LeavesQty val) { GetField(val); return val; }
        public bool IsSet(LeavesQty val) { return IsSetLeavesQty(); }
        public bool IsSetLeavesQty() { return IsSetField(Tags.LeavesQty); }

        public CxlQty CxlQty
        {
            get
            {
                CxlQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CxlQty val) { CxlQty = val; }
        public CxlQty Get(CxlQty val) { GetField(val); return val; }
        public bool IsSet(CxlQty val) { return IsSetCxlQty(); }
        public bool IsSetCxlQty() { return IsSetField(Tags.CxlQty); }

        public AvgPx AvgPx
        {
            get
            {
                AvgPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AvgPx val) { AvgPx = val; }
        public AvgPx Get(AvgPx val) { GetField(val); return val; }
        public bool IsSet(AvgPx val) { return IsSetAvgPx(); }
        public bool IsSetAvgPx() { return IsSetField(Tags.AvgPx); }
    }
}
