// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class ListStatus : Message
{
    public const string MsgType = "N";

    public ListStatus() : base()
    {
        Header.SetField(new MsgType("N"));
    }

    public ListStatus(
            ListID aListID,
            ListStatusType aListStatusType,
            NoRpts aNoRpts,
            ListOrderStatus aListOrderStatus,
            RptSeq aRptSeq,
            TotNoOrders aTotNoOrders
        ) : this()
    {
        ListID = aListID;
        ListStatusType = aListStatusType;
        NoRpts = aNoRpts;
        ListOrderStatus = aListOrderStatus;
        RptSeq = aRptSeq;
        TotNoOrders = aTotNoOrders;
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

    public ListStatusType ListStatusType
    {
        get
        {
            ListStatusType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListStatusType val) { ListStatusType = val; }
    public ListStatusType Get(ListStatusType val) { GetField(val); return val; }
    public bool IsSet(ListStatusType val) { return IsSetListStatusType(); }
    public bool IsSetListStatusType() { return IsSetField(Tags.ListStatusType); }

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

    public ListOrderStatus ListOrderStatus
    {
        get
        {
            ListOrderStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListOrderStatus val) { ListOrderStatus = val; }
    public ListOrderStatus Get(ListOrderStatus val) { GetField(val); return val; }
    public bool IsSet(ListOrderStatus val) { return IsSetListOrderStatus(); }
    public bool IsSetListOrderStatus() { return IsSetField(Tags.ListOrderStatus); }

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

    public ListStatusText ListStatusText
    {
        get
        {
            ListStatusText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListStatusText val) { ListStatusText = val; }
    public ListStatusText Get(ListStatusText val) { GetField(val); return val; }
    public bool IsSet(ListStatusText val) { return IsSetListStatusText(); }
    public bool IsSetListStatusText() { return IsSetField(Tags.ListStatusText); }

    public EncodedListStatusTextLen EncodedListStatusTextLen
    {
        get
        {
            EncodedListStatusTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedListStatusTextLen val) { EncodedListStatusTextLen = val; }
    public EncodedListStatusTextLen Get(EncodedListStatusTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedListStatusTextLen val) { return IsSetEncodedListStatusTextLen(); }
    public bool IsSetEncodedListStatusTextLen() { return IsSetField(Tags.EncodedListStatusTextLen); }

    public EncodedListStatusText EncodedListStatusText
    {
        get
        {
            EncodedListStatusText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedListStatusText val) { EncodedListStatusText = val; }
    public EncodedListStatusText Get(EncodedListStatusText val) { GetField(val); return val; }
    public bool IsSet(EncodedListStatusText val) { return IsSetEncodedListStatusText(); }
    public bool IsSetEncodedListStatusText() { return IsSetField(Tags.EncodedListStatusText); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public TotNoOrders TotNoOrders
    {
        get
        {
            TotNoOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNoOrders val) { TotNoOrders = val; }
    public TotNoOrders Get(TotNoOrders val) { GetField(val); return val; }
    public bool IsSet(TotNoOrders val) { return IsSetTotNoOrders(); }
    public bool IsSetTotNoOrders() { return IsSetField(Tags.TotNoOrders); }

    public LastFragment LastFragment
    {
        get
        {
            LastFragment val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastFragment val) { LastFragment = val; }
    public LastFragment Get(LastFragment val) { GetField(val); return val; }
    public bool IsSet(LastFragment val) { return IsSetLastFragment(); }
    public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }

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
        public static int[] DefaultFieldOrder = [Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.CumQty, Tags.OrdStatus, Tags.WorkingIndicator, Tags.LeavesQty, Tags.CxlQty, Tags.AvgPx, Tags.OrdRejReason, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.CumQty, Tags.OrdStatus, Tags.WorkingIndicator, Tags.LeavesQty, Tags.CxlQty, Tags.AvgPx, Tags.OrdRejReason, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};

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

        public SecondaryClOrdID SecondaryClOrdID
        {
            get
            {
                SecondaryClOrdID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryClOrdID val) { SecondaryClOrdID = val; }
        public SecondaryClOrdID Get(SecondaryClOrdID val) { GetField(val); return val; }
        public bool IsSet(SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }
        public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

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

        public OrdStatus OrdStatus
        {
            get
            {
                OrdStatus val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrdStatus val) { OrdStatus = val; }
        public OrdStatus Get(OrdStatus val) { GetField(val); return val; }
        public bool IsSet(OrdStatus val) { return IsSetOrdStatus(); }
        public bool IsSetOrdStatus() { return IsSetField(Tags.OrdStatus); }

        public WorkingIndicator WorkingIndicator
        {
            get
            {
                WorkingIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(WorkingIndicator val) { WorkingIndicator = val; }
        public WorkingIndicator Get(WorkingIndicator val) { GetField(val); return val; }
        public bool IsSet(WorkingIndicator val) { return IsSetWorkingIndicator(); }
        public bool IsSetWorkingIndicator() { return IsSetField(Tags.WorkingIndicator); }

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

        public OrdRejReason OrdRejReason
        {
            get
            {
                OrdRejReason val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrdRejReason val) { OrdRejReason = val; }
        public OrdRejReason Get(OrdRejReason val) { GetField(val); return val; }
        public bool IsSet(OrdRejReason val) { return IsSetOrdRejReason(); }
        public bool IsSetOrdRejReason() { return IsSetField(Tags.OrdRejReason); }

        public Text Text
        {
            get
            {
                Text val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Text val) { Text = val; }
        public Text Get(Text val) { GetField(val); return val; }
        public bool IsSet(Text val) { return IsSetText(); }
        public bool IsSetText() { return IsSetField(Tags.Text); }

        public EncodedTextLen EncodedTextLen
        {
            get
            {
                EncodedTextLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedTextLen val) { EncodedTextLen = val; }
        public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
        public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
        public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

        public EncodedText EncodedText
        {
            get
            {
                EncodedText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedText val) { EncodedText = val; }
        public EncodedText Get(EncodedText val) { GetField(val); return val; }
        public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
        public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }
    }
}
