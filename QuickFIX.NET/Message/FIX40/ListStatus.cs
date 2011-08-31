// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX40 
    {
        public class ListStatus : Message
        {
            public const string MsgType = "N";

            public ListStatus() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("N"));
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
            public QuickFix.Fields.WaveNo waveNo
            { 
                get 
                {
                    QuickFix.Fields.WaveNo val = new QuickFix.Fields.WaveNo();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.WaveNo val) 
            { 
                this.waveNo = val;
            }
            
            public QuickFix.Fields.WaveNo get(QuickFix.Fields.WaveNo val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.WaveNo val) 
            { 
                return isSetWaveNo();
            }
            
            public bool isSetWaveNo() 
            { 
                return isSetField(Tags.WaveNo);
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
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.CumQty, Tags.CxlQty, Tags.AvgPx, 0};
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
            
            }
        }
    }
}
