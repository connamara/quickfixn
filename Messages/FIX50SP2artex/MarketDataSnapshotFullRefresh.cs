// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class MarketDataSnapshotFullRefresh : Message
        {
            public const string MsgType = "W";

            public MarketDataSnapshotFullRefresh() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("W"));
            }

            public MarketDataSnapshotFullRefresh(
                    QuickFix.Fields.LastUpdateTime aLastUpdateTime
                ) : this()
            {
                this.LastUpdateTime = aLastUpdateTime;
            }

            public QuickFix.Fields.MarketDepth MarketDepth
            {
                get
                {
                    QuickFix.Fields.MarketDepth val = new QuickFix.Fields.MarketDepth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketDepth val)
            {
                this.MarketDepth = val;
            }

            public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketDepth val)
            {
                return IsSetMarketDepth();
            }

            public bool IsSetMarketDepth()
            {
                return IsSetField(Tags.MarketDepth);
            }

            public QuickFix.Fields.MDReqID MDReqID
            {
                get
                {
                    QuickFix.Fields.MDReqID val = new QuickFix.Fields.MDReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MDReqID val)
            {
                this.MDReqID = val;
            }

            public QuickFix.Fields.MDReqID Get(QuickFix.Fields.MDReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MDReqID val)
            {
                return IsSetMDReqID();
            }

            public bool IsSetMDReqID()
            {
                return IsSetField(Tags.MDReqID);
            }

            public QuickFix.Fields.Symbol Symbol
            {
                get
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Symbol val)
            {
                this.Symbol = val;
            }

            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Symbol val)
            {
                return IsSetSymbol();
            }

            public bool IsSetSymbol()
            {
                return IsSetField(Tags.Symbol);
            }

            public QuickFix.Fields.SecurityID SecurityID
            {
                get
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityID val)
            {
                this.SecurityID = val;
            }

            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityID val)
            {
                return IsSetSecurityID();
            }

            public bool IsSetSecurityID()
            {
                return IsSetField(Tags.SecurityID);
            }

            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            {
                get
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityIDSource val)
            {
                this.SecurityIDSource = val;
            }

            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityIDSource val)
            {
                return IsSetSecurityIDSource();
            }

            public bool IsSetSecurityIDSource()
            {
                return IsSetField(Tags.SecurityIDSource);
            }

            public QuickFix.Fields.Currency Currency
            {
                get
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Currency val)
            {
                this.Currency = val;
            }

            public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Currency val)
            {
                return IsSetCurrency();
            }

            public bool IsSetCurrency()
            {
                return IsSetField(Tags.Currency);
            }

            public QuickFix.Fields.NoMDEntries NoMDEntries
            {
                get
                {
                    QuickFix.Fields.NoMDEntries val = new QuickFix.Fields.NoMDEntries();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMDEntries val)
            {
                this.NoMDEntries = val;
            }

            public QuickFix.Fields.NoMDEntries Get(QuickFix.Fields.NoMDEntries val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMDEntries val)
            {
                return IsSetNoMDEntries();
            }

            public bool IsSetNoMDEntries()
            {
                return IsSetField(Tags.NoMDEntries);
            }

            public QuickFix.Fields.LastUpdateTime LastUpdateTime
            {
                get
                {
                    QuickFix.Fields.LastUpdateTime val = new QuickFix.Fields.LastUpdateTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.LastUpdateTime val)
            {
                this.LastUpdateTime = val;
            }

            public QuickFix.Fields.LastUpdateTime Get(QuickFix.Fields.LastUpdateTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.LastUpdateTime val)
            {
                return IsSetLastUpdateTime();
            }

            public bool IsSetLastUpdateTime()
            {
                return IsSetField(Tags.LastUpdateTime);
            }

            public QuickFix.Fields.TransactTime TransactTime
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
                this.TransactTime = val;
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

            public class NoMDEntriesGroup : Group
            {
                public static int[] fieldOrder = {Tags.MDEntryType, Tags.MDEntryPx, Tags.OrdType, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.TradeCondition, Tags.OpenCloseSettlFlag, Tags.OrderID, Tags.QuoteEntryID, Tags.TradeID, Tags.Text, 0};

                public NoMDEntriesGroup()
                  : base(Tags.NoMDEntries, Tags.MDEntryType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMDEntriesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MDEntryType MDEntryType
                {
                    get
                    {
                        QuickFix.Fields.MDEntryType val = new QuickFix.Fields.MDEntryType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDEntryType val)
                {
                    this.MDEntryType = val;
                }

                public QuickFix.Fields.MDEntryType Get(QuickFix.Fields.MDEntryType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDEntryType val)
                {
                    return IsSetMDEntryType();
                }

                public bool IsSetMDEntryType()
                {
                    return IsSetField(Tags.MDEntryType);
                }

                public QuickFix.Fields.MDEntryPx MDEntryPx
                {
                    get
                    {
                        QuickFix.Fields.MDEntryPx val = new QuickFix.Fields.MDEntryPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDEntryPx val)
                {
                    this.MDEntryPx = val;
                }

                public QuickFix.Fields.MDEntryPx Get(QuickFix.Fields.MDEntryPx val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDEntryPx val)
                {
                    return IsSetMDEntryPx();
                }

                public bool IsSetMDEntryPx()
                {
                    return IsSetField(Tags.MDEntryPx);
                }

                public QuickFix.Fields.OrdType OrdType
                {
                    get
                    {
                        QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.OrdType val)
                {
                    this.OrdType = val;
                }

                public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.OrdType val)
                {
                    return IsSetOrdType();
                }

                public bool IsSetOrdType()
                {
                    return IsSetField(Tags.OrdType);
                }

                public QuickFix.Fields.MDEntrySize MDEntrySize
                {
                    get
                    {
                        QuickFix.Fields.MDEntrySize val = new QuickFix.Fields.MDEntrySize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDEntrySize val)
                {
                    this.MDEntrySize = val;
                }

                public QuickFix.Fields.MDEntrySize Get(QuickFix.Fields.MDEntrySize val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDEntrySize val)
                {
                    return IsSetMDEntrySize();
                }

                public bool IsSetMDEntrySize()
                {
                    return IsSetField(Tags.MDEntrySize);
                }

                public QuickFix.Fields.MDEntryDate MDEntryDate
                {
                    get
                    {
                        QuickFix.Fields.MDEntryDate val = new QuickFix.Fields.MDEntryDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDEntryDate val)
                {
                    this.MDEntryDate = val;
                }

                public QuickFix.Fields.MDEntryDate Get(QuickFix.Fields.MDEntryDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDEntryDate val)
                {
                    return IsSetMDEntryDate();
                }

                public bool IsSetMDEntryDate()
                {
                    return IsSetField(Tags.MDEntryDate);
                }

                public QuickFix.Fields.MDEntryTime MDEntryTime
                {
                    get
                    {
                        QuickFix.Fields.MDEntryTime val = new QuickFix.Fields.MDEntryTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDEntryTime val)
                {
                    this.MDEntryTime = val;
                }

                public QuickFix.Fields.MDEntryTime Get(QuickFix.Fields.MDEntryTime val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDEntryTime val)
                {
                    return IsSetMDEntryTime();
                }

                public bool IsSetMDEntryTime()
                {
                    return IsSetField(Tags.MDEntryTime);
                }

                public QuickFix.Fields.TradeCondition TradeCondition
                {
                    get
                    {
                        QuickFix.Fields.TradeCondition val = new QuickFix.Fields.TradeCondition();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TradeCondition val)
                {
                    this.TradeCondition = val;
                }

                public QuickFix.Fields.TradeCondition Get(QuickFix.Fields.TradeCondition val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TradeCondition val)
                {
                    return IsSetTradeCondition();
                }

                public bool IsSetTradeCondition()
                {
                    return IsSetField(Tags.TradeCondition);
                }

                public QuickFix.Fields.OpenCloseSettlFlag OpenCloseSettlFlag
                {
                    get
                    {
                        QuickFix.Fields.OpenCloseSettlFlag val = new QuickFix.Fields.OpenCloseSettlFlag();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.OpenCloseSettlFlag val)
                {
                    this.OpenCloseSettlFlag = val;
                }

                public QuickFix.Fields.OpenCloseSettlFlag Get(QuickFix.Fields.OpenCloseSettlFlag val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.OpenCloseSettlFlag val)
                {
                    return IsSetOpenCloseSettlFlag();
                }

                public bool IsSetOpenCloseSettlFlag()
                {
                    return IsSetField(Tags.OpenCloseSettlFlag);
                }

                public QuickFix.Fields.OrderID OrderID
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
                    this.OrderID = val;
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

                public QuickFix.Fields.QuoteEntryID QuoteEntryID
                {
                    get
                    {
                        QuickFix.Fields.QuoteEntryID val = new QuickFix.Fields.QuoteEntryID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.QuoteEntryID val)
                {
                    this.QuoteEntryID = val;
                }

                public QuickFix.Fields.QuoteEntryID Get(QuickFix.Fields.QuoteEntryID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.QuoteEntryID val)
                {
                    return IsSetQuoteEntryID();
                }

                public bool IsSetQuoteEntryID()
                {
                    return IsSetField(Tags.QuoteEntryID);
                }

                public QuickFix.Fields.TradeID TradeID
                {
                    get
                    {
                        QuickFix.Fields.TradeID val = new QuickFix.Fields.TradeID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TradeID val)
                {
                    this.TradeID = val;
                }

                public QuickFix.Fields.TradeID Get(QuickFix.Fields.TradeID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TradeID val)
                {
                    return IsSetTradeID();
                }

                public bool IsSetTradeID()
                {
                    return IsSetField(Tags.TradeID);
                }

                public QuickFix.Fields.Text Text
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
                    this.Text = val;
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


            }
        }
    }
}
