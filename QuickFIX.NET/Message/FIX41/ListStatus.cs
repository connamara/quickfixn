// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
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
                    QuickFix.Fields.NoRpts aNoRpts,
                    QuickFix.Fields.RptSeq aRptSeq
                ) : this()
            {
                this.listID = aListID;
                this.noRpts = aNoRpts;
                this.rptSeq = aRptSeq;
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
            public QuickFix.Fields.WaveNo waveNo
            { 
                get 
                {
                    QuickFix.Fields.WaveNo val = new QuickFix.Fields.WaveNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.WaveNo val) 
            { 
                this.waveNo = val;
            }
            
            public QuickFix.Fields.WaveNo Get(QuickFix.Fields.WaveNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.WaveNo val) 
            { 
                return IsSetWaveNo();
            }
            
            public bool IsSetWaveNo() 
            { 
                return IsSetField(Tags.WaveNo);
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
            public class NoOrders : Group
            {
                public NoOrders() 
                  :base( Tags.NoOrders, Tags.ClOrdID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.CumQty, Tags.LeavesQty, Tags.CxlQty, Tags.AvgPx, 0};
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
            
            }
        }
    }
}
