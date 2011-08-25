// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class ListStatus : Message
        {
            public ListStatus() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("N"));
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
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListID val) 
            { 
                this.listID = val;
            }
            
            public QuickFix.Fields.ListID get(QuickFix.Fields.ListID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListID val) 
            { 
                return isSetListID();
            }
            
            public bool isSetListID() 
            { 
                return isSetField(Tags.ListID);
            }
            public QuickFix.Fields.ListStatusType listStatusType
            { 
                get 
                {
                    QuickFix.Fields.ListStatusType val = new QuickFix.Fields.ListStatusType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListStatusType val) 
            { 
                this.listStatusType = val;
            }
            
            public QuickFix.Fields.ListStatusType get(QuickFix.Fields.ListStatusType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListStatusType val) 
            { 
                return isSetListStatusType();
            }
            
            public bool isSetListStatusType() 
            { 
                return isSetField(Tags.ListStatusType);
            }
            public QuickFix.Fields.NoRpts noRpts
            { 
                get 
                {
                    QuickFix.Fields.NoRpts val = new QuickFix.Fields.NoRpts();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRpts val) 
            { 
                this.noRpts = val;
            }
            
            public QuickFix.Fields.NoRpts get(QuickFix.Fields.NoRpts val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRpts val) 
            { 
                return isSetNoRpts();
            }
            
            public bool isSetNoRpts() 
            { 
                return isSetField(Tags.NoRpts);
            }
            public QuickFix.Fields.ListOrderStatus listOrderStatus
            { 
                get 
                {
                    QuickFix.Fields.ListOrderStatus val = new QuickFix.Fields.ListOrderStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListOrderStatus val) 
            { 
                this.listOrderStatus = val;
            }
            
            public QuickFix.Fields.ListOrderStatus get(QuickFix.Fields.ListOrderStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListOrderStatus val) 
            { 
                return isSetListOrderStatus();
            }
            
            public bool isSetListOrderStatus() 
            { 
                return isSetField(Tags.ListOrderStatus);
            }
            public QuickFix.Fields.RptSeq rptSeq
            { 
                get 
                {
                    QuickFix.Fields.RptSeq val = new QuickFix.Fields.RptSeq();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RptSeq val) 
            { 
                this.rptSeq = val;
            }
            
            public QuickFix.Fields.RptSeq get(QuickFix.Fields.RptSeq val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RptSeq val) 
            { 
                return isSetRptSeq();
            }
            
            public bool isSetRptSeq() 
            { 
                return isSetField(Tags.RptSeq);
            }
            public QuickFix.Fields.ListStatusText listStatusText
            { 
                get 
                {
                    QuickFix.Fields.ListStatusText val = new QuickFix.Fields.ListStatusText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListStatusText val) 
            { 
                this.listStatusText = val;
            }
            
            public QuickFix.Fields.ListStatusText get(QuickFix.Fields.ListStatusText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListStatusText val) 
            { 
                return isSetListStatusText();
            }
            
            public bool isSetListStatusText() 
            { 
                return isSetField(Tags.ListStatusText);
            }
            public QuickFix.Fields.EncodedListStatusTextLen encodedListStatusTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedListStatusTextLen val = new QuickFix.Fields.EncodedListStatusTextLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                this.encodedListStatusTextLen = val;
            }
            
            public QuickFix.Fields.EncodedListStatusTextLen get(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                return isSetEncodedListStatusTextLen();
            }
            
            public bool isSetEncodedListStatusTextLen() 
            { 
                return isSetField(Tags.EncodedListStatusTextLen);
            }
            public QuickFix.Fields.EncodedListStatusText encodedListStatusText
            { 
                get 
                {
                    QuickFix.Fields.EncodedListStatusText val = new QuickFix.Fields.EncodedListStatusText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedListStatusText val) 
            { 
                this.encodedListStatusText = val;
            }
            
            public QuickFix.Fields.EncodedListStatusText get(QuickFix.Fields.EncodedListStatusText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedListStatusText val) 
            { 
                return isSetEncodedListStatusText();
            }
            
            public bool isSetEncodedListStatusText() 
            { 
                return isSetField(Tags.EncodedListStatusText);
            }
            public QuickFix.Fields.TransactTime transactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TransactTime val) 
            { 
                this.transactTime = val;
            }
            
            public QuickFix.Fields.TransactTime get(QuickFix.Fields.TransactTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TransactTime val) 
            { 
                return isSetTransactTime();
            }
            
            public bool isSetTransactTime() 
            { 
                return isSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.TotNoOrders totNoOrders
            { 
                get 
                {
                    QuickFix.Fields.TotNoOrders val = new QuickFix.Fields.TotNoOrders();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotNoOrders val) 
            { 
                this.totNoOrders = val;
            }
            
            public QuickFix.Fields.TotNoOrders get(QuickFix.Fields.TotNoOrders val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotNoOrders val) 
            { 
                return isSetTotNoOrders();
            }
            
            public bool isSetTotNoOrders() 
            { 
                return isSetField(Tags.TotNoOrders);
            }
            public QuickFix.Fields.NoOrders noOrders
            { 
                get 
                {
                    QuickFix.Fields.NoOrders val = new QuickFix.Fields.NoOrders();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoOrders val) 
            { 
                this.noOrders = val;
            }
            
            public QuickFix.Fields.NoOrders get(QuickFix.Fields.NoOrders val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoOrders val) 
            { 
                return isSetNoOrders();
            }
            
            public bool isSetNoOrders() 
            { 
                return isSetField(Tags.NoOrders);
            }
            public class NoOrders : Group
            {
                public NoOrders() 
                  :base( Tags.NoOrders, Tags.ClOrdID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.CumQty, Tags.OrdStatus, Tags.WorkingIndicator, Tags.LeavesQty, Tags.CxlQty, Tags.AvgPx, Tags.OrdRejReason, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};
                            public QuickFix.Fields.ClOrdID clOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ClOrdID val) 
                { 
                    this.clOrdID = val;
                }
                
                public QuickFix.Fields.ClOrdID get(QuickFix.Fields.ClOrdID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ClOrdID val) 
                { 
                    return isSetClOrdID();
                }
                
                public bool isSetClOrdID() 
                { 
                    return isSetField(Tags.ClOrdID);
                }
                public QuickFix.Fields.SecondaryClOrdID secondaryClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    this.secondaryClOrdID = val;
                }
                
                public QuickFix.Fields.SecondaryClOrdID get(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    return isSetSecondaryClOrdID();
                }
                
                public bool isSetSecondaryClOrdID() 
                { 
                    return isSetField(Tags.SecondaryClOrdID);
                }
                public QuickFix.Fields.CumQty cumQty
                { 
                    get 
                    {
                        QuickFix.Fields.CumQty val = new QuickFix.Fields.CumQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CumQty val) 
                { 
                    this.cumQty = val;
                }
                
                public QuickFix.Fields.CumQty get(QuickFix.Fields.CumQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CumQty val) 
                { 
                    return isSetCumQty();
                }
                
                public bool isSetCumQty() 
                { 
                    return isSetField(Tags.CumQty);
                }
                public QuickFix.Fields.OrdStatus ordStatus
                { 
                    get 
                    {
                        QuickFix.Fields.OrdStatus val = new QuickFix.Fields.OrdStatus();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrdStatus val) 
                { 
                    this.ordStatus = val;
                }
                
                public QuickFix.Fields.OrdStatus get(QuickFix.Fields.OrdStatus val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrdStatus val) 
                { 
                    return isSetOrdStatus();
                }
                
                public bool isSetOrdStatus() 
                { 
                    return isSetField(Tags.OrdStatus);
                }
                public QuickFix.Fields.WorkingIndicator workingIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.WorkingIndicator val = new QuickFix.Fields.WorkingIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.WorkingIndicator val) 
                { 
                    this.workingIndicator = val;
                }
                
                public QuickFix.Fields.WorkingIndicator get(QuickFix.Fields.WorkingIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.WorkingIndicator val) 
                { 
                    return isSetWorkingIndicator();
                }
                
                public bool isSetWorkingIndicator() 
                { 
                    return isSetField(Tags.WorkingIndicator);
                }
                public QuickFix.Fields.LeavesQty leavesQty
                { 
                    get 
                    {
                        QuickFix.Fields.LeavesQty val = new QuickFix.Fields.LeavesQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LeavesQty val) 
                { 
                    this.leavesQty = val;
                }
                
                public QuickFix.Fields.LeavesQty get(QuickFix.Fields.LeavesQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LeavesQty val) 
                { 
                    return isSetLeavesQty();
                }
                
                public bool isSetLeavesQty() 
                { 
                    return isSetField(Tags.LeavesQty);
                }
                public QuickFix.Fields.CxlQty cxlQty
                { 
                    get 
                    {
                        QuickFix.Fields.CxlQty val = new QuickFix.Fields.CxlQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CxlQty val) 
                { 
                    this.cxlQty = val;
                }
                
                public QuickFix.Fields.CxlQty get(QuickFix.Fields.CxlQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CxlQty val) 
                { 
                    return isSetCxlQty();
                }
                
                public bool isSetCxlQty() 
                { 
                    return isSetField(Tags.CxlQty);
                }
                public QuickFix.Fields.AvgPx avgPx
                { 
                    get 
                    {
                        QuickFix.Fields.AvgPx val = new QuickFix.Fields.AvgPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AvgPx val) 
                { 
                    this.avgPx = val;
                }
                
                public QuickFix.Fields.AvgPx get(QuickFix.Fields.AvgPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AvgPx val) 
                { 
                    return isSetAvgPx();
                }
                
                public bool isSetAvgPx() 
                { 
                    return isSetField(Tags.AvgPx);
                }
                public QuickFix.Fields.OrdRejReason ordRejReason
                { 
                    get 
                    {
                        QuickFix.Fields.OrdRejReason val = new QuickFix.Fields.OrdRejReason();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrdRejReason val) 
                { 
                    this.ordRejReason = val;
                }
                
                public QuickFix.Fields.OrdRejReason get(QuickFix.Fields.OrdRejReason val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrdRejReason val) 
                { 
                    return isSetOrdRejReason();
                }
                
                public bool isSetOrdRejReason() 
                { 
                    return isSetField(Tags.OrdRejReason);
                }
                public QuickFix.Fields.Text text
                { 
                    get 
                    {
                        QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Text val) 
                { 
                    this.text = val;
                }
                
                public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Text val) 
                { 
                    return isSetText();
                }
                
                public bool isSetText() 
                { 
                    return isSetField(Tags.Text);
                }
                public QuickFix.Fields.EncodedTextLen encodedTextLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedTextLen val) 
                { 
                    this.encodedTextLen = val;
                }
                
                public QuickFix.Fields.EncodedTextLen get(QuickFix.Fields.EncodedTextLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedTextLen val) 
                { 
                    return isSetEncodedTextLen();
                }
                
                public bool isSetEncodedTextLen() 
                { 
                    return isSetField(Tags.EncodedTextLen);
                }
                public QuickFix.Fields.EncodedText encodedText
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedText val) 
                { 
                    this.encodedText = val;
                }
                
                public QuickFix.Fields.EncodedText get(QuickFix.Fields.EncodedText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedText val) 
                { 
                    return isSetEncodedText();
                }
                
                public bool isSetEncodedText() 
                { 
                    return isSetField(Tags.EncodedText);
                }
            
            }
        }
    }
}
