// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class ListStatus : Message
        {
            public const string MsgType = "N";

            public ListStatus() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("N"));
            }

            public ListStatus(
                    QuickFix.Fields.ListID aListID,
                    QuickFix.Fields.ListStatusType aListStatusType,
                    QuickFix.Fields.NoRpts aNoRpts,
                    QuickFix.Fields.ListOrderStatus aListOrderStatus,
                    QuickFix.Fields.RptSeq aRptSeq,
                    QuickFix.Fields.TotNoOrders aTotNoOrders
                ) : this()
            {
                this.listID = aListID;
                this.listStatusType = aListStatusType;
                this.noRpts = aNoRpts;
                this.listOrderStatus = aListOrderStatus;
                this.rptSeq = aRptSeq;
                this.totNoOrders = aTotNoOrders;
            }

            public QuickFix.Fields.ListID listID
            { 
                get 
                {
                    QuickFix.Fields.ListID val = new QuickFix.Fields.ListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListID val) 
            { 
                this.listID = val;
            }
            
            public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListID val) 
            { 
                return IsSetListID();
            }
            
            public bool IsSetListID() 
            { 
                return IsSetField(Tags.ListID);
            }
            public QuickFix.Fields.ListStatusType listStatusType
            { 
                get 
                {
                    QuickFix.Fields.ListStatusType val = new QuickFix.Fields.ListStatusType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListStatusType val) 
            { 
                this.listStatusType = val;
            }
            
            public QuickFix.Fields.ListStatusType Get(QuickFix.Fields.ListStatusType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListStatusType val) 
            { 
                return IsSetListStatusType();
            }
            
            public bool IsSetListStatusType() 
            { 
                return IsSetField(Tags.ListStatusType);
            }
            public QuickFix.Fields.NoRpts noRpts
            { 
                get 
                {
                    QuickFix.Fields.NoRpts val = new QuickFix.Fields.NoRpts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRpts val) 
            { 
                this.noRpts = val;
            }
            
            public QuickFix.Fields.NoRpts Get(QuickFix.Fields.NoRpts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRpts val) 
            { 
                return IsSetNoRpts();
            }
            
            public bool IsSetNoRpts() 
            { 
                return IsSetField(Tags.NoRpts);
            }
            public QuickFix.Fields.ListOrderStatus listOrderStatus
            { 
                get 
                {
                    QuickFix.Fields.ListOrderStatus val = new QuickFix.Fields.ListOrderStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListOrderStatus val) 
            { 
                this.listOrderStatus = val;
            }
            
            public QuickFix.Fields.ListOrderStatus Get(QuickFix.Fields.ListOrderStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListOrderStatus val) 
            { 
                return IsSetListOrderStatus();
            }
            
            public bool IsSetListOrderStatus() 
            { 
                return IsSetField(Tags.ListOrderStatus);
            }
            public QuickFix.Fields.RptSeq rptSeq
            { 
                get 
                {
                    QuickFix.Fields.RptSeq val = new QuickFix.Fields.RptSeq();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RptSeq val) 
            { 
                this.rptSeq = val;
            }
            
            public QuickFix.Fields.RptSeq Get(QuickFix.Fields.RptSeq val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RptSeq val) 
            { 
                return IsSetRptSeq();
            }
            
            public bool IsSetRptSeq() 
            { 
                return IsSetField(Tags.RptSeq);
            }
            public QuickFix.Fields.ListStatusText listStatusText
            { 
                get 
                {
                    QuickFix.Fields.ListStatusText val = new QuickFix.Fields.ListStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListStatusText val) 
            { 
                this.listStatusText = val;
            }
            
            public QuickFix.Fields.ListStatusText Get(QuickFix.Fields.ListStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListStatusText val) 
            { 
                return IsSetListStatusText();
            }
            
            public bool IsSetListStatusText() 
            { 
                return IsSetField(Tags.ListStatusText);
            }
            public QuickFix.Fields.EncodedListStatusTextLen encodedListStatusTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedListStatusTextLen val = new QuickFix.Fields.EncodedListStatusTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                this.encodedListStatusTextLen = val;
            }
            
            public QuickFix.Fields.EncodedListStatusTextLen Get(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                return IsSetEncodedListStatusTextLen();
            }
            
            public bool IsSetEncodedListStatusTextLen() 
            { 
                return IsSetField(Tags.EncodedListStatusTextLen);
            }
            public QuickFix.Fields.EncodedListStatusText encodedListStatusText
            { 
                get 
                {
                    QuickFix.Fields.EncodedListStatusText val = new QuickFix.Fields.EncodedListStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedListStatusText val) 
            { 
                this.encodedListStatusText = val;
            }
            
            public QuickFix.Fields.EncodedListStatusText Get(QuickFix.Fields.EncodedListStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedListStatusText val) 
            { 
                return IsSetEncodedListStatusText();
            }
            
            public bool IsSetEncodedListStatusText() 
            { 
                return IsSetField(Tags.EncodedListStatusText);
            }
            public QuickFix.Fields.TransactTime transactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                this.transactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.TotNoOrders totNoOrders
            { 
                get 
                {
                    QuickFix.Fields.TotNoOrders val = new QuickFix.Fields.TotNoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoOrders val) 
            { 
                this.totNoOrders = val;
            }
            
            public QuickFix.Fields.TotNoOrders Get(QuickFix.Fields.TotNoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoOrders val) 
            { 
                return IsSetTotNoOrders();
            }
            
            public bool IsSetTotNoOrders() 
            { 
                return IsSetField(Tags.TotNoOrders);
            }
            public QuickFix.Fields.LastFragment lastFragment
            { 
                get 
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastFragment val) 
            { 
                this.lastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(Tags.LastFragment);
            }
            public QuickFix.Fields.NoOrders noOrders
            { 
                get 
                {
                    QuickFix.Fields.NoOrders val = new QuickFix.Fields.NoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoOrders val) 
            { 
                this.noOrders = val;
            }
            
            public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoOrders val) 
            { 
                return IsSetNoOrders();
            }
            
            public bool IsSetNoOrders() 
            { 
                return IsSetField(Tags.NoOrders);
            }
            public QuickFix.Fields.ContingencyType contingencyType
            { 
                get 
                {
                    QuickFix.Fields.ContingencyType val = new QuickFix.Fields.ContingencyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContingencyType val) 
            { 
                this.contingencyType = val;
            }
            
            public QuickFix.Fields.ContingencyType Get(QuickFix.Fields.ContingencyType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContingencyType val) 
            { 
                return IsSetContingencyType();
            }
            
            public bool IsSetContingencyType() 
            { 
                return IsSetField(Tags.ContingencyType);
            }
            public QuickFix.Fields.ListRejectReason listRejectReason
            { 
                get 
                {
                    QuickFix.Fields.ListRejectReason val = new QuickFix.Fields.ListRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListRejectReason val) 
            { 
                this.listRejectReason = val;
            }
            
            public QuickFix.Fields.ListRejectReason Get(QuickFix.Fields.ListRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListRejectReason val) 
            { 
                return IsSetListRejectReason();
            }
            
            public bool IsSetListRejectReason() 
            { 
                return IsSetField(Tags.ListRejectReason);
            }
            public class NoOrders : Group
            {
                public NoOrders() 
                  :base( Tags.NoOrders, Tags.ClOrdID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.CumQty, Tags.OrdStatus, Tags.WorkingIndicator, Tags.LeavesQty, Tags.CxlQty, Tags.AvgPx, Tags.OrdRejReason, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.OrderID, 0};
                            public QuickFix.Fields.ClOrdID clOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClOrdID val) 
                { 
                    this.clOrdID = val;
                }
                
                public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClOrdID val) 
                { 
                    return IsSetClOrdID();
                }
                
                public bool IsSetClOrdID() 
                { 
                    return IsSetField(Tags.ClOrdID);
                }
                public QuickFix.Fields.SecondaryClOrdID secondaryClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    this.secondaryClOrdID = val;
                }
                
                public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    return IsSetSecondaryClOrdID();
                }
                
                public bool IsSetSecondaryClOrdID() 
                { 
                    return IsSetField(Tags.SecondaryClOrdID);
                }
                public QuickFix.Fields.CumQty cumQty
                { 
                    get 
                    {
                        QuickFix.Fields.CumQty val = new QuickFix.Fields.CumQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CumQty val) 
                { 
                    this.cumQty = val;
                }
                
                public QuickFix.Fields.CumQty Get(QuickFix.Fields.CumQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CumQty val) 
                { 
                    return IsSetCumQty();
                }
                
                public bool IsSetCumQty() 
                { 
                    return IsSetField(Tags.CumQty);
                }
                public QuickFix.Fields.OrdStatus ordStatus
                { 
                    get 
                    {
                        QuickFix.Fields.OrdStatus val = new QuickFix.Fields.OrdStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrdStatus val) 
                { 
                    this.ordStatus = val;
                }
                
                public QuickFix.Fields.OrdStatus Get(QuickFix.Fields.OrdStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrdStatus val) 
                { 
                    return IsSetOrdStatus();
                }
                
                public bool IsSetOrdStatus() 
                { 
                    return IsSetField(Tags.OrdStatus);
                }
                public QuickFix.Fields.WorkingIndicator workingIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.WorkingIndicator val = new QuickFix.Fields.WorkingIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.WorkingIndicator val) 
                { 
                    this.workingIndicator = val;
                }
                
                public QuickFix.Fields.WorkingIndicator Get(QuickFix.Fields.WorkingIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.WorkingIndicator val) 
                { 
                    return IsSetWorkingIndicator();
                }
                
                public bool IsSetWorkingIndicator() 
                { 
                    return IsSetField(Tags.WorkingIndicator);
                }
                public QuickFix.Fields.LeavesQty leavesQty
                { 
                    get 
                    {
                        QuickFix.Fields.LeavesQty val = new QuickFix.Fields.LeavesQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LeavesQty val) 
                { 
                    this.leavesQty = val;
                }
                
                public QuickFix.Fields.LeavesQty Get(QuickFix.Fields.LeavesQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LeavesQty val) 
                { 
                    return IsSetLeavesQty();
                }
                
                public bool IsSetLeavesQty() 
                { 
                    return IsSetField(Tags.LeavesQty);
                }
                public QuickFix.Fields.CxlQty cxlQty
                { 
                    get 
                    {
                        QuickFix.Fields.CxlQty val = new QuickFix.Fields.CxlQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CxlQty val) 
                { 
                    this.cxlQty = val;
                }
                
                public QuickFix.Fields.CxlQty Get(QuickFix.Fields.CxlQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CxlQty val) 
                { 
                    return IsSetCxlQty();
                }
                
                public bool IsSetCxlQty() 
                { 
                    return IsSetField(Tags.CxlQty);
                }
                public QuickFix.Fields.AvgPx avgPx
                { 
                    get 
                    {
                        QuickFix.Fields.AvgPx val = new QuickFix.Fields.AvgPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AvgPx val) 
                { 
                    this.avgPx = val;
                }
                
                public QuickFix.Fields.AvgPx Get(QuickFix.Fields.AvgPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AvgPx val) 
                { 
                    return IsSetAvgPx();
                }
                
                public bool IsSetAvgPx() 
                { 
                    return IsSetField(Tags.AvgPx);
                }
                public QuickFix.Fields.OrdRejReason ordRejReason
                { 
                    get 
                    {
                        QuickFix.Fields.OrdRejReason val = new QuickFix.Fields.OrdRejReason();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrdRejReason val) 
                { 
                    this.ordRejReason = val;
                }
                
                public QuickFix.Fields.OrdRejReason Get(QuickFix.Fields.OrdRejReason val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrdRejReason val) 
                { 
                    return IsSetOrdRejReason();
                }
                
                public bool IsSetOrdRejReason() 
                { 
                    return IsSetField(Tags.OrdRejReason);
                }
                public QuickFix.Fields.Text text
                { 
                    get 
                    {
                        QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Text val) 
                { 
                    this.text = val;
                }
                
                public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Text val) 
                { 
                    return IsSetText();
                }
                
                public bool IsSetText() 
                { 
                    return IsSetField(Tags.Text);
                }
                public QuickFix.Fields.EncodedTextLen encodedTextLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedTextLen val) 
                { 
                    this.encodedTextLen = val;
                }
                
                public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
                { 
                    return IsSetEncodedTextLen();
                }
                
                public bool IsSetEncodedTextLen() 
                { 
                    return IsSetField(Tags.EncodedTextLen);
                }
                public QuickFix.Fields.EncodedText encodedText
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedText val) 
                { 
                    this.encodedText = val;
                }
                
                public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedText val) 
                { 
                    return IsSetEncodedText();
                }
                
                public bool IsSetEncodedText() 
                { 
                    return IsSetField(Tags.EncodedText);
                }
                public QuickFix.Fields.OrderID orderID
                { 
                    get 
                    {
                        QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderID val) 
                { 
                    this.orderID = val;
                }
                
                public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderID val) 
                { 
                    return IsSetOrderID();
                }
                
                public bool IsSetOrderID() 
                { 
                    return IsSetField(Tags.OrderID);
                }
            
            }
        }
    }
}
