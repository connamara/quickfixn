// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42
    {
        public class NewOrderList : Message
        {
            public const string MsgType = "E";

            public NewOrderList() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("E"));
            }

            public NewOrderList(
                    QuickFix.Fields.ListID aListID,
                    QuickFix.Fields.BidType aBidType,
                    QuickFix.Fields.TotNoOrders aTotNoOrders
                ) : this()
            {
                this.ListID = aListID;
                this.BidType = aBidType;
                this.TotNoOrders = aTotNoOrders;
            }

            public QuickFix.Fields.ListID ListID
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
                this.ListID = val;
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

            public QuickFix.Fields.BidID BidID
            {
                get
                {
                    QuickFix.Fields.BidID val = new QuickFix.Fields.BidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BidID val)
            {
                this.BidID = val;
            }

            public QuickFix.Fields.BidID Get(QuickFix.Fields.BidID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BidID val)
            {
                return IsSetBidID();
            }

            public bool IsSetBidID()
            {
                return IsSetField(Tags.BidID);
            }

            public QuickFix.Fields.ClientBidID ClientBidID
            {
                get
                {
                    QuickFix.Fields.ClientBidID val = new QuickFix.Fields.ClientBidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ClientBidID val)
            {
                this.ClientBidID = val;
            }

            public QuickFix.Fields.ClientBidID Get(QuickFix.Fields.ClientBidID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ClientBidID val)
            {
                return IsSetClientBidID();
            }

            public bool IsSetClientBidID()
            {
                return IsSetField(Tags.ClientBidID);
            }

            public QuickFix.Fields.ProgRptReqs ProgRptReqs
            {
                get
                {
                    QuickFix.Fields.ProgRptReqs val = new QuickFix.Fields.ProgRptReqs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ProgRptReqs val)
            {
                this.ProgRptReqs = val;
            }

            public QuickFix.Fields.ProgRptReqs Get(QuickFix.Fields.ProgRptReqs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ProgRptReqs val)
            {
                return IsSetProgRptReqs();
            }

            public bool IsSetProgRptReqs()
            {
                return IsSetField(Tags.ProgRptReqs);
            }

            public QuickFix.Fields.BidType BidType
            {
                get
                {
                    QuickFix.Fields.BidType val = new QuickFix.Fields.BidType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BidType val)
            {
                this.BidType = val;
            }

            public QuickFix.Fields.BidType Get(QuickFix.Fields.BidType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BidType val)
            {
                return IsSetBidType();
            }

            public bool IsSetBidType()
            {
                return IsSetField(Tags.BidType);
            }

            public QuickFix.Fields.ProgPeriodInterval ProgPeriodInterval
            {
                get
                {
                    QuickFix.Fields.ProgPeriodInterval val = new QuickFix.Fields.ProgPeriodInterval();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ProgPeriodInterval val)
            {
                this.ProgPeriodInterval = val;
            }

            public QuickFix.Fields.ProgPeriodInterval Get(QuickFix.Fields.ProgPeriodInterval val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ProgPeriodInterval val)
            {
                return IsSetProgPeriodInterval();
            }

            public bool IsSetProgPeriodInterval()
            {
                return IsSetField(Tags.ProgPeriodInterval);
            }

            public QuickFix.Fields.ListExecInstType ListExecInstType
            {
                get
                {
                    QuickFix.Fields.ListExecInstType val = new QuickFix.Fields.ListExecInstType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ListExecInstType val)
            {
                this.ListExecInstType = val;
            }

            public QuickFix.Fields.ListExecInstType Get(QuickFix.Fields.ListExecInstType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ListExecInstType val)
            {
                return IsSetListExecInstType();
            }

            public bool IsSetListExecInstType()
            {
                return IsSetField(Tags.ListExecInstType);
            }

            public QuickFix.Fields.ListExecInst ListExecInst
            {
                get
                {
                    QuickFix.Fields.ListExecInst val = new QuickFix.Fields.ListExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ListExecInst val)
            {
                this.ListExecInst = val;
            }

            public QuickFix.Fields.ListExecInst Get(QuickFix.Fields.ListExecInst val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ListExecInst val)
            {
                return IsSetListExecInst();
            }

            public bool IsSetListExecInst()
            {
                return IsSetField(Tags.ListExecInst);
            }

            public QuickFix.Fields.EncodedListExecInstLen EncodedListExecInstLen
            {
                get
                {
                    QuickFix.Fields.EncodedListExecInstLen val = new QuickFix.Fields.EncodedListExecInstLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedListExecInstLen val)
            {
                this.EncodedListExecInstLen = val;
            }

            public QuickFix.Fields.EncodedListExecInstLen Get(QuickFix.Fields.EncodedListExecInstLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedListExecInstLen val)
            {
                return IsSetEncodedListExecInstLen();
            }

            public bool IsSetEncodedListExecInstLen()
            {
                return IsSetField(Tags.EncodedListExecInstLen);
            }

            public QuickFix.Fields.EncodedListExecInst EncodedListExecInst
            {
                get
                {
                    QuickFix.Fields.EncodedListExecInst val = new QuickFix.Fields.EncodedListExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedListExecInst val)
            {
                this.EncodedListExecInst = val;
            }

            public QuickFix.Fields.EncodedListExecInst Get(QuickFix.Fields.EncodedListExecInst val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedListExecInst val)
            {
                return IsSetEncodedListExecInst();
            }

            public bool IsSetEncodedListExecInst()
            {
                return IsSetField(Tags.EncodedListExecInst);
            }

            public QuickFix.Fields.TotNoOrders TotNoOrders
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
                this.TotNoOrders = val;
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

            public QuickFix.Fields.NoOrders NoOrders
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
                this.NoOrders = val;
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

            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.ListSeqNo, Tags.SettlInstMode, Tags.ClientID, Tags.ExecBroker, Tags.Account, Tags.NoAllocs, Tags.SettlmntTyp, Tags.FutSettDate, Tags.HandlInst, Tags.ExecInst, Tags.MinQty, Tags.MaxFloor, Tags.ExDestination, Tags.NoTradingSessions, Tags.ProcessCode, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.PrevClosePx, Tags.Side, Tags.SideValueInd, Tags.LocateReqd, Tags.TransactTime, Tags.OrderQty, Tags.CashOrderQty, Tags.OrdType, Tags.Price, Tags.StopPx, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.IOIid, Tags.QuoteID, Tags.TimeInForce, Tags.EffectiveTime, Tags.ExpireDate, Tags.ExpireTime, Tags.GTBookingInst, Tags.Commission, Tags.CommType, Tags.Rule80A, Tags.ForexReq, Tags.SettlCurrency, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.FutSettDate2, Tags.OrderQty2, Tags.OpenClose, Tags.CoveredOrUncovered, Tags.CustomerOrFirm, Tags.MaxShow, Tags.PegDifference, Tags.DiscretionInst, Tags.DiscretionOffset, Tags.ClearingFirm, Tags.ClearingAccount, 0};

                public NoOrdersGroup()
                  : base(Tags.NoOrders, Tags.ClOrdID, fieldOrder)
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
                        QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ClOrdID val)
                {
                    this.ClOrdID = val;
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

                public QuickFix.Fields.ListSeqNo ListSeqNo
                {
                    get
                    {
                        QuickFix.Fields.ListSeqNo val = new QuickFix.Fields.ListSeqNo();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ListSeqNo val)
                {
                    this.ListSeqNo = val;
                }

                public QuickFix.Fields.ListSeqNo Get(QuickFix.Fields.ListSeqNo val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ListSeqNo val)
                {
                    return IsSetListSeqNo();
                }

                public bool IsSetListSeqNo()
                {
                    return IsSetField(Tags.ListSeqNo);
                }

                public QuickFix.Fields.SettlInstMode SettlInstMode
                {
                    get
                    {
                        QuickFix.Fields.SettlInstMode val = new QuickFix.Fields.SettlInstMode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlInstMode val)
                {
                    this.SettlInstMode = val;
                }

                public QuickFix.Fields.SettlInstMode Get(QuickFix.Fields.SettlInstMode val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlInstMode val)
                {
                    return IsSetSettlInstMode();
                }

                public bool IsSetSettlInstMode()
                {
                    return IsSetField(Tags.SettlInstMode);
                }

                public QuickFix.Fields.ClientID ClientID
                {
                    get
                    {
                        QuickFix.Fields.ClientID val = new QuickFix.Fields.ClientID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ClientID val)
                {
                    this.ClientID = val;
                }

                public QuickFix.Fields.ClientID Get(QuickFix.Fields.ClientID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ClientID val)
                {
                    return IsSetClientID();
                }

                public bool IsSetClientID()
                {
                    return IsSetField(Tags.ClientID);
                }

                public QuickFix.Fields.ExecBroker ExecBroker
                {
                    get
                    {
                        QuickFix.Fields.ExecBroker val = new QuickFix.Fields.ExecBroker();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ExecBroker val)
                {
                    this.ExecBroker = val;
                }

                public QuickFix.Fields.ExecBroker Get(QuickFix.Fields.ExecBroker val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ExecBroker val)
                {
                    return IsSetExecBroker();
                }

                public bool IsSetExecBroker()
                {
                    return IsSetField(Tags.ExecBroker);
                }

                public QuickFix.Fields.Account Account
                {
                    get
                    {
                        QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Account val)
                {
                    this.Account = val;
                }

                public QuickFix.Fields.Account Get(QuickFix.Fields.Account val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Account val)
                {
                    return IsSetAccount();
                }

                public bool IsSetAccount()
                {
                    return IsSetField(Tags.Account);
                }

                public QuickFix.Fields.NoAllocs NoAllocs
                {
                    get
                    {
                        QuickFix.Fields.NoAllocs val = new QuickFix.Fields.NoAllocs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoAllocs val)
                {
                    this.NoAllocs = val;
                }

                public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoAllocs val)
                {
                    return IsSetNoAllocs();
                }

                public bool IsSetNoAllocs()
                {
                    return IsSetField(Tags.NoAllocs);
                }

                public QuickFix.Fields.SettlmntTyp SettlmntTyp
                {
                    get
                    {
                        QuickFix.Fields.SettlmntTyp val = new QuickFix.Fields.SettlmntTyp();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlmntTyp val)
                {
                    this.SettlmntTyp = val;
                }

                public QuickFix.Fields.SettlmntTyp Get(QuickFix.Fields.SettlmntTyp val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlmntTyp val)
                {
                    return IsSetSettlmntTyp();
                }

                public bool IsSetSettlmntTyp()
                {
                    return IsSetField(Tags.SettlmntTyp);
                }

                public QuickFix.Fields.FutSettDate FutSettDate
                {
                    get
                    {
                        QuickFix.Fields.FutSettDate val = new QuickFix.Fields.FutSettDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.FutSettDate val)
                {
                    this.FutSettDate = val;
                }

                public QuickFix.Fields.FutSettDate Get(QuickFix.Fields.FutSettDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.FutSettDate val)
                {
                    return IsSetFutSettDate();
                }

                public bool IsSetFutSettDate()
                {
                    return IsSetField(Tags.FutSettDate);
                }

                public QuickFix.Fields.HandlInst HandlInst
                {
                    get
                    {
                        QuickFix.Fields.HandlInst val = new QuickFix.Fields.HandlInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.HandlInst val)
                {
                    this.HandlInst = val;
                }

                public QuickFix.Fields.HandlInst Get(QuickFix.Fields.HandlInst val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.HandlInst val)
                {
                    return IsSetHandlInst();
                }

                public bool IsSetHandlInst()
                {
                    return IsSetField(Tags.HandlInst);
                }

                public QuickFix.Fields.ExecInst ExecInst
                {
                    get
                    {
                        QuickFix.Fields.ExecInst val = new QuickFix.Fields.ExecInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ExecInst val)
                {
                    this.ExecInst = val;
                }

                public QuickFix.Fields.ExecInst Get(QuickFix.Fields.ExecInst val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ExecInst val)
                {
                    return IsSetExecInst();
                }

                public bool IsSetExecInst()
                {
                    return IsSetField(Tags.ExecInst);
                }

                public QuickFix.Fields.MinQty MinQty
                {
                    get
                    {
                        QuickFix.Fields.MinQty val = new QuickFix.Fields.MinQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MinQty val)
                {
                    this.MinQty = val;
                }

                public QuickFix.Fields.MinQty Get(QuickFix.Fields.MinQty val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MinQty val)
                {
                    return IsSetMinQty();
                }

                public bool IsSetMinQty()
                {
                    return IsSetField(Tags.MinQty);
                }

                public QuickFix.Fields.MaxFloor MaxFloor
                {
                    get
                    {
                        QuickFix.Fields.MaxFloor val = new QuickFix.Fields.MaxFloor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MaxFloor val)
                {
                    this.MaxFloor = val;
                }

                public QuickFix.Fields.MaxFloor Get(QuickFix.Fields.MaxFloor val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MaxFloor val)
                {
                    return IsSetMaxFloor();
                }

                public bool IsSetMaxFloor()
                {
                    return IsSetField(Tags.MaxFloor);
                }

                public QuickFix.Fields.ExDestination ExDestination
                {
                    get
                    {
                        QuickFix.Fields.ExDestination val = new QuickFix.Fields.ExDestination();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ExDestination val)
                {
                    this.ExDestination = val;
                }

                public QuickFix.Fields.ExDestination Get(QuickFix.Fields.ExDestination val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ExDestination val)
                {
                    return IsSetExDestination();
                }

                public bool IsSetExDestination()
                {
                    return IsSetField(Tags.ExDestination);
                }

                public QuickFix.Fields.NoTradingSessions NoTradingSessions
                {
                    get
                    {
                        QuickFix.Fields.NoTradingSessions val = new QuickFix.Fields.NoTradingSessions();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoTradingSessions val)
                {
                    this.NoTradingSessions = val;
                }

                public QuickFix.Fields.NoTradingSessions Get(QuickFix.Fields.NoTradingSessions val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoTradingSessions val)
                {
                    return IsSetNoTradingSessions();
                }

                public bool IsSetNoTradingSessions()
                {
                    return IsSetField(Tags.NoTradingSessions);
                }

                public QuickFix.Fields.ProcessCode ProcessCode
                {
                    get
                    {
                        QuickFix.Fields.ProcessCode val = new QuickFix.Fields.ProcessCode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ProcessCode val)
                {
                    this.ProcessCode = val;
                }

                public QuickFix.Fields.ProcessCode Get(QuickFix.Fields.ProcessCode val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ProcessCode val)
                {
                    return IsSetProcessCode();
                }

                public bool IsSetProcessCode()
                {
                    return IsSetField(Tags.ProcessCode);
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

                public QuickFix.Fields.SymbolSfx SymbolSfx
                {
                    get
                    {
                        QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SymbolSfx val)
                {
                    this.SymbolSfx = val;
                }

                public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SymbolSfx val)
                {
                    return IsSetSymbolSfx();
                }

                public bool IsSetSymbolSfx()
                {
                    return IsSetField(Tags.SymbolSfx);
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

                public QuickFix.Fields.IDSource IDSource
                {
                    get
                    {
                        QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.IDSource val)
                {
                    this.IDSource = val;
                }

                public QuickFix.Fields.IDSource Get(QuickFix.Fields.IDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.IDSource val)
                {
                    return IsSetIDSource();
                }

                public bool IsSetIDSource()
                {
                    return IsSetField(Tags.IDSource);
                }

                public QuickFix.Fields.SecurityType SecurityType
                {
                    get
                    {
                        QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityType val)
                {
                    this.SecurityType = val;
                }

                public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityType val)
                {
                    return IsSetSecurityType();
                }

                public bool IsSetSecurityType()
                {
                    return IsSetField(Tags.SecurityType);
                }

                public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
                {
                    get
                    {
                        QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MaturityMonthYear val)
                {
                    this.MaturityMonthYear = val;
                }

                public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MaturityMonthYear val)
                {
                    return IsSetMaturityMonthYear();
                }

                public bool IsSetMaturityMonthYear()
                {
                    return IsSetField(Tags.MaturityMonthYear);
                }

                public QuickFix.Fields.MaturityDay MaturityDay
                {
                    get
                    {
                        QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MaturityDay val)
                {
                    this.MaturityDay = val;
                }

                public QuickFix.Fields.MaturityDay Get(QuickFix.Fields.MaturityDay val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MaturityDay val)
                {
                    return IsSetMaturityDay();
                }

                public bool IsSetMaturityDay()
                {
                    return IsSetField(Tags.MaturityDay);
                }

                public QuickFix.Fields.PutOrCall PutOrCall
                {
                    get
                    {
                        QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PutOrCall val)
                {
                    this.PutOrCall = val;
                }

                public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PutOrCall val)
                {
                    return IsSetPutOrCall();
                }

                public bool IsSetPutOrCall()
                {
                    return IsSetField(Tags.PutOrCall);
                }

                public QuickFix.Fields.StrikePrice StrikePrice
                {
                    get
                    {
                        QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.StrikePrice val)
                {
                    this.StrikePrice = val;
                }

                public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.StrikePrice val)
                {
                    return IsSetStrikePrice();
                }

                public bool IsSetStrikePrice()
                {
                    return IsSetField(Tags.StrikePrice);
                }

                public QuickFix.Fields.OptAttribute OptAttribute
                {
                    get
                    {
                        QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.OptAttribute val)
                {
                    this.OptAttribute = val;
                }

                public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.OptAttribute val)
                {
                    return IsSetOptAttribute();
                }

                public bool IsSetOptAttribute()
                {
                    return IsSetField(Tags.OptAttribute);
                }

                public QuickFix.Fields.ContractMultiplier ContractMultiplier
                {
                    get
                    {
                        QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ContractMultiplier val)
                {
                    this.ContractMultiplier = val;
                }

                public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ContractMultiplier val)
                {
                    return IsSetContractMultiplier();
                }

                public bool IsSetContractMultiplier()
                {
                    return IsSetField(Tags.ContractMultiplier);
                }

                public QuickFix.Fields.CouponRate CouponRate
                {
                    get
                    {
                        QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CouponRate val)
                {
                    this.CouponRate = val;
                }

                public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CouponRate val)
                {
                    return IsSetCouponRate();
                }

                public bool IsSetCouponRate()
                {
                    return IsSetField(Tags.CouponRate);
                }

                public QuickFix.Fields.SecurityExchange SecurityExchange
                {
                    get
                    {
                        QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityExchange val)
                {
                    this.SecurityExchange = val;
                }

                public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityExchange val)
                {
                    return IsSetSecurityExchange();
                }

                public bool IsSetSecurityExchange()
                {
                    return IsSetField(Tags.SecurityExchange);
                }

                public QuickFix.Fields.Issuer Issuer
                {
                    get
                    {
                        QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Issuer val)
                {
                    this.Issuer = val;
                }

                public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Issuer val)
                {
                    return IsSetIssuer();
                }

                public bool IsSetIssuer()
                {
                    return IsSetField(Tags.Issuer);
                }

                public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
                {
                    get
                    {
                        QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedIssuerLen val)
                {
                    this.EncodedIssuerLen = val;
                }

                public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedIssuerLen val)
                {
                    return IsSetEncodedIssuerLen();
                }

                public bool IsSetEncodedIssuerLen()
                {
                    return IsSetField(Tags.EncodedIssuerLen);
                }

                public QuickFix.Fields.EncodedIssuer EncodedIssuer
                {
                    get
                    {
                        QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedIssuer val)
                {
                    this.EncodedIssuer = val;
                }

                public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedIssuer val)
                {
                    return IsSetEncodedIssuer();
                }

                public bool IsSetEncodedIssuer()
                {
                    return IsSetField(Tags.EncodedIssuer);
                }

                public QuickFix.Fields.SecurityDesc SecurityDesc
                {
                    get
                    {
                        QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityDesc val)
                {
                    this.SecurityDesc = val;
                }

                public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityDesc val)
                {
                    return IsSetSecurityDesc();
                }

                public bool IsSetSecurityDesc()
                {
                    return IsSetField(Tags.SecurityDesc);
                }

                public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
                {
                    get
                    {
                        QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedSecurityDescLen val)
                {
                    this.EncodedSecurityDescLen = val;
                }

                public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val)
                {
                    return IsSetEncodedSecurityDescLen();
                }

                public bool IsSetEncodedSecurityDescLen()
                {
                    return IsSetField(Tags.EncodedSecurityDescLen);
                }

                public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
                {
                    get
                    {
                        QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedSecurityDesc val)
                {
                    this.EncodedSecurityDesc = val;
                }

                public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val)
                {
                    return IsSetEncodedSecurityDesc();
                }

                public bool IsSetEncodedSecurityDesc()
                {
                    return IsSetField(Tags.EncodedSecurityDesc);
                }

                public QuickFix.Fields.PrevClosePx PrevClosePx
                {
                    get
                    {
                        QuickFix.Fields.PrevClosePx val = new QuickFix.Fields.PrevClosePx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PrevClosePx val)
                {
                    this.PrevClosePx = val;
                }

                public QuickFix.Fields.PrevClosePx Get(QuickFix.Fields.PrevClosePx val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PrevClosePx val)
                {
                    return IsSetPrevClosePx();
                }

                public bool IsSetPrevClosePx()
                {
                    return IsSetField(Tags.PrevClosePx);
                }

                public QuickFix.Fields.Side Side
                {
                    get
                    {
                        QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Side val)
                {
                    this.Side = val;
                }

                public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Side val)
                {
                    return IsSetSide();
                }

                public bool IsSetSide()
                {
                    return IsSetField(Tags.Side);
                }

                public QuickFix.Fields.SideValueInd SideValueInd
                {
                    get
                    {
                        QuickFix.Fields.SideValueInd val = new QuickFix.Fields.SideValueInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SideValueInd val)
                {
                    this.SideValueInd = val;
                }

                public QuickFix.Fields.SideValueInd Get(QuickFix.Fields.SideValueInd val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SideValueInd val)
                {
                    return IsSetSideValueInd();
                }

                public bool IsSetSideValueInd()
                {
                    return IsSetField(Tags.SideValueInd);
                }

                public QuickFix.Fields.LocateReqd LocateReqd
                {
                    get
                    {
                        QuickFix.Fields.LocateReqd val = new QuickFix.Fields.LocateReqd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LocateReqd val)
                {
                    this.LocateReqd = val;
                }

                public QuickFix.Fields.LocateReqd Get(QuickFix.Fields.LocateReqd val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LocateReqd val)
                {
                    return IsSetLocateReqd();
                }

                public bool IsSetLocateReqd()
                {
                    return IsSetField(Tags.LocateReqd);
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

                public QuickFix.Fields.OrderQty OrderQty
                {
                    get
                    {
                        QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.OrderQty val)
                {
                    this.OrderQty = val;
                }

                public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.OrderQty val)
                {
                    return IsSetOrderQty();
                }

                public bool IsSetOrderQty()
                {
                    return IsSetField(Tags.OrderQty);
                }

                public QuickFix.Fields.CashOrderQty CashOrderQty
                {
                    get
                    {
                        QuickFix.Fields.CashOrderQty val = new QuickFix.Fields.CashOrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CashOrderQty val)
                {
                    this.CashOrderQty = val;
                }

                public QuickFix.Fields.CashOrderQty Get(QuickFix.Fields.CashOrderQty val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CashOrderQty val)
                {
                    return IsSetCashOrderQty();
                }

                public bool IsSetCashOrderQty()
                {
                    return IsSetField(Tags.CashOrderQty);
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

                public QuickFix.Fields.Price Price
                {
                    get
                    {
                        QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Price val)
                {
                    this.Price = val;
                }

                public QuickFix.Fields.Price Get(QuickFix.Fields.Price val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Price val)
                {
                    return IsSetPrice();
                }

                public bool IsSetPrice()
                {
                    return IsSetField(Tags.Price);
                }

                public QuickFix.Fields.StopPx StopPx
                {
                    get
                    {
                        QuickFix.Fields.StopPx val = new QuickFix.Fields.StopPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.StopPx val)
                {
                    this.StopPx = val;
                }

                public QuickFix.Fields.StopPx Get(QuickFix.Fields.StopPx val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.StopPx val)
                {
                    return IsSetStopPx();
                }

                public bool IsSetStopPx()
                {
                    return IsSetField(Tags.StopPx);
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

                public QuickFix.Fields.ComplianceID ComplianceID
                {
                    get
                    {
                        QuickFix.Fields.ComplianceID val = new QuickFix.Fields.ComplianceID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ComplianceID val)
                {
                    this.ComplianceID = val;
                }

                public QuickFix.Fields.ComplianceID Get(QuickFix.Fields.ComplianceID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ComplianceID val)
                {
                    return IsSetComplianceID();
                }

                public bool IsSetComplianceID()
                {
                    return IsSetField(Tags.ComplianceID);
                }

                public QuickFix.Fields.SolicitedFlag SolicitedFlag
                {
                    get
                    {
                        QuickFix.Fields.SolicitedFlag val = new QuickFix.Fields.SolicitedFlag();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SolicitedFlag val)
                {
                    this.SolicitedFlag = val;
                }

                public QuickFix.Fields.SolicitedFlag Get(QuickFix.Fields.SolicitedFlag val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SolicitedFlag val)
                {
                    return IsSetSolicitedFlag();
                }

                public bool IsSetSolicitedFlag()
                {
                    return IsSetField(Tags.SolicitedFlag);
                }

                public QuickFix.Fields.IOIid IOIid
                {
                    get
                    {
                        QuickFix.Fields.IOIid val = new QuickFix.Fields.IOIid();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.IOIid val)
                {
                    this.IOIid = val;
                }

                public QuickFix.Fields.IOIid Get(QuickFix.Fields.IOIid val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.IOIid val)
                {
                    return IsSetIOIid();
                }

                public bool IsSetIOIid()
                {
                    return IsSetField(Tags.IOIid);
                }

                public QuickFix.Fields.QuoteID QuoteID
                {
                    get
                    {
                        QuickFix.Fields.QuoteID val = new QuickFix.Fields.QuoteID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.QuoteID val)
                {
                    this.QuoteID = val;
                }

                public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.QuoteID val)
                {
                    return IsSetQuoteID();
                }

                public bool IsSetQuoteID()
                {
                    return IsSetField(Tags.QuoteID);
                }

                public QuickFix.Fields.TimeInForce TimeInForce
                {
                    get
                    {
                        QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TimeInForce val)
                {
                    this.TimeInForce = val;
                }

                public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TimeInForce val)
                {
                    return IsSetTimeInForce();
                }

                public bool IsSetTimeInForce()
                {
                    return IsSetField(Tags.TimeInForce);
                }

                public QuickFix.Fields.EffectiveTime EffectiveTime
                {
                    get
                    {
                        QuickFix.Fields.EffectiveTime val = new QuickFix.Fields.EffectiveTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EffectiveTime val)
                {
                    this.EffectiveTime = val;
                }

                public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EffectiveTime val)
                {
                    return IsSetEffectiveTime();
                }

                public bool IsSetEffectiveTime()
                {
                    return IsSetField(Tags.EffectiveTime);
                }

                public QuickFix.Fields.ExpireDate ExpireDate
                {
                    get
                    {
                        QuickFix.Fields.ExpireDate val = new QuickFix.Fields.ExpireDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ExpireDate val)
                {
                    this.ExpireDate = val;
                }

                public QuickFix.Fields.ExpireDate Get(QuickFix.Fields.ExpireDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ExpireDate val)
                {
                    return IsSetExpireDate();
                }

                public bool IsSetExpireDate()
                {
                    return IsSetField(Tags.ExpireDate);
                }

                public QuickFix.Fields.ExpireTime ExpireTime
                {
                    get
                    {
                        QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ExpireTime val)
                {
                    this.ExpireTime = val;
                }

                public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ExpireTime val)
                {
                    return IsSetExpireTime();
                }

                public bool IsSetExpireTime()
                {
                    return IsSetField(Tags.ExpireTime);
                }

                public QuickFix.Fields.GTBookingInst GTBookingInst
                {
                    get
                    {
                        QuickFix.Fields.GTBookingInst val = new QuickFix.Fields.GTBookingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.GTBookingInst val)
                {
                    this.GTBookingInst = val;
                }

                public QuickFix.Fields.GTBookingInst Get(QuickFix.Fields.GTBookingInst val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.GTBookingInst val)
                {
                    return IsSetGTBookingInst();
                }

                public bool IsSetGTBookingInst()
                {
                    return IsSetField(Tags.GTBookingInst);
                }

                public QuickFix.Fields.Commission Commission
                {
                    get
                    {
                        QuickFix.Fields.Commission val = new QuickFix.Fields.Commission();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Commission val)
                {
                    this.Commission = val;
                }

                public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Commission val)
                {
                    return IsSetCommission();
                }

                public bool IsSetCommission()
                {
                    return IsSetField(Tags.Commission);
                }

                public QuickFix.Fields.CommType CommType
                {
                    get
                    {
                        QuickFix.Fields.CommType val = new QuickFix.Fields.CommType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CommType val)
                {
                    this.CommType = val;
                }

                public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CommType val)
                {
                    return IsSetCommType();
                }

                public bool IsSetCommType()
                {
                    return IsSetField(Tags.CommType);
                }

                public QuickFix.Fields.Rule80A Rule80A
                {
                    get
                    {
                        QuickFix.Fields.Rule80A val = new QuickFix.Fields.Rule80A();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Rule80A val)
                {
                    this.Rule80A = val;
                }

                public QuickFix.Fields.Rule80A Get(QuickFix.Fields.Rule80A val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Rule80A val)
                {
                    return IsSetRule80A();
                }

                public bool IsSetRule80A()
                {
                    return IsSetField(Tags.Rule80A);
                }

                public QuickFix.Fields.ForexReq ForexReq
                {
                    get
                    {
                        QuickFix.Fields.ForexReq val = new QuickFix.Fields.ForexReq();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ForexReq val)
                {
                    this.ForexReq = val;
                }

                public QuickFix.Fields.ForexReq Get(QuickFix.Fields.ForexReq val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ForexReq val)
                {
                    return IsSetForexReq();
                }

                public bool IsSetForexReq()
                {
                    return IsSetField(Tags.ForexReq);
                }

                public QuickFix.Fields.SettlCurrency SettlCurrency
                {
                    get
                    {
                        QuickFix.Fields.SettlCurrency val = new QuickFix.Fields.SettlCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlCurrency val)
                {
                    this.SettlCurrency = val;
                }

                public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlCurrency val)
                {
                    return IsSetSettlCurrency();
                }

                public bool IsSetSettlCurrency()
                {
                    return IsSetField(Tags.SettlCurrency);
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

                public QuickFix.Fields.EncodedTextLen EncodedTextLen
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
                    this.EncodedTextLen = val;
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

                public QuickFix.Fields.EncodedText EncodedText
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
                    this.EncodedText = val;
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

                public QuickFix.Fields.FutSettDate2 FutSettDate2
                {
                    get
                    {
                        QuickFix.Fields.FutSettDate2 val = new QuickFix.Fields.FutSettDate2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.FutSettDate2 val)
                {
                    this.FutSettDate2 = val;
                }

                public QuickFix.Fields.FutSettDate2 Get(QuickFix.Fields.FutSettDate2 val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.FutSettDate2 val)
                {
                    return IsSetFutSettDate2();
                }

                public bool IsSetFutSettDate2()
                {
                    return IsSetField(Tags.FutSettDate2);
                }

                public QuickFix.Fields.OrderQty2 OrderQty2
                {
                    get
                    {
                        QuickFix.Fields.OrderQty2 val = new QuickFix.Fields.OrderQty2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.OrderQty2 val)
                {
                    this.OrderQty2 = val;
                }

                public QuickFix.Fields.OrderQty2 Get(QuickFix.Fields.OrderQty2 val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.OrderQty2 val)
                {
                    return IsSetOrderQty2();
                }

                public bool IsSetOrderQty2()
                {
                    return IsSetField(Tags.OrderQty2);
                }

                public QuickFix.Fields.OpenClose OpenClose
                {
                    get
                    {
                        QuickFix.Fields.OpenClose val = new QuickFix.Fields.OpenClose();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.OpenClose val)
                {
                    this.OpenClose = val;
                }

                public QuickFix.Fields.OpenClose Get(QuickFix.Fields.OpenClose val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.OpenClose val)
                {
                    return IsSetOpenClose();
                }

                public bool IsSetOpenClose()
                {
                    return IsSetField(Tags.OpenClose);
                }

                public QuickFix.Fields.CoveredOrUncovered CoveredOrUncovered
                {
                    get
                    {
                        QuickFix.Fields.CoveredOrUncovered val = new QuickFix.Fields.CoveredOrUncovered();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CoveredOrUncovered val)
                {
                    this.CoveredOrUncovered = val;
                }

                public QuickFix.Fields.CoveredOrUncovered Get(QuickFix.Fields.CoveredOrUncovered val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CoveredOrUncovered val)
                {
                    return IsSetCoveredOrUncovered();
                }

                public bool IsSetCoveredOrUncovered()
                {
                    return IsSetField(Tags.CoveredOrUncovered);
                }

                public QuickFix.Fields.CustomerOrFirm CustomerOrFirm
                {
                    get
                    {
                        QuickFix.Fields.CustomerOrFirm val = new QuickFix.Fields.CustomerOrFirm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CustomerOrFirm val)
                {
                    this.CustomerOrFirm = val;
                }

                public QuickFix.Fields.CustomerOrFirm Get(QuickFix.Fields.CustomerOrFirm val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CustomerOrFirm val)
                {
                    return IsSetCustomerOrFirm();
                }

                public bool IsSetCustomerOrFirm()
                {
                    return IsSetField(Tags.CustomerOrFirm);
                }

                public QuickFix.Fields.MaxShow MaxShow
                {
                    get
                    {
                        QuickFix.Fields.MaxShow val = new QuickFix.Fields.MaxShow();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MaxShow val)
                {
                    this.MaxShow = val;
                }

                public QuickFix.Fields.MaxShow Get(QuickFix.Fields.MaxShow val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MaxShow val)
                {
                    return IsSetMaxShow();
                }

                public bool IsSetMaxShow()
                {
                    return IsSetField(Tags.MaxShow);
                }

                public QuickFix.Fields.PegDifference PegDifference
                {
                    get
                    {
                        QuickFix.Fields.PegDifference val = new QuickFix.Fields.PegDifference();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PegDifference val)
                {
                    this.PegDifference = val;
                }

                public QuickFix.Fields.PegDifference Get(QuickFix.Fields.PegDifference val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PegDifference val)
                {
                    return IsSetPegDifference();
                }

                public bool IsSetPegDifference()
                {
                    return IsSetField(Tags.PegDifference);
                }

                public QuickFix.Fields.DiscretionInst DiscretionInst
                {
                    get
                    {
                        QuickFix.Fields.DiscretionInst val = new QuickFix.Fields.DiscretionInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.DiscretionInst val)
                {
                    this.DiscretionInst = val;
                }

                public QuickFix.Fields.DiscretionInst Get(QuickFix.Fields.DiscretionInst val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.DiscretionInst val)
                {
                    return IsSetDiscretionInst();
                }

                public bool IsSetDiscretionInst()
                {
                    return IsSetField(Tags.DiscretionInst);
                }

                public QuickFix.Fields.DiscretionOffset DiscretionOffset
                {
                    get
                    {
                        QuickFix.Fields.DiscretionOffset val = new QuickFix.Fields.DiscretionOffset();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.DiscretionOffset val)
                {
                    this.DiscretionOffset = val;
                }

                public QuickFix.Fields.DiscretionOffset Get(QuickFix.Fields.DiscretionOffset val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.DiscretionOffset val)
                {
                    return IsSetDiscretionOffset();
                }

                public bool IsSetDiscretionOffset()
                {
                    return IsSetField(Tags.DiscretionOffset);
                }

                public QuickFix.Fields.ClearingFirm ClearingFirm
                {
                    get
                    {
                        QuickFix.Fields.ClearingFirm val = new QuickFix.Fields.ClearingFirm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ClearingFirm val)
                {
                    this.ClearingFirm = val;
                }

                public QuickFix.Fields.ClearingFirm Get(QuickFix.Fields.ClearingFirm val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ClearingFirm val)
                {
                    return IsSetClearingFirm();
                }

                public bool IsSetClearingFirm()
                {
                    return IsSetField(Tags.ClearingFirm);
                }

                public QuickFix.Fields.ClearingAccount ClearingAccount
                {
                    get
                    {
                        QuickFix.Fields.ClearingAccount val = new QuickFix.Fields.ClearingAccount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ClearingAccount val)
                {
                    this.ClearingAccount = val;
                }

                public QuickFix.Fields.ClearingAccount Get(QuickFix.Fields.ClearingAccount val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ClearingAccount val)
                {
                    return IsSetClearingAccount();
                }

                public bool IsSetClearingAccount()
                {
                    return IsSetField(Tags.ClearingAccount);
                }

                public class NoAllocsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocShares, 0};

                    public NoAllocsGroup()
                      : base(Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoAllocsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.AllocAccount AllocAccount
                    {
                        get
                        {
                            QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.AllocAccount val)
                    {
                        this.AllocAccount = val;
                    }

                    public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.AllocAccount val)
                    {
                        return IsSetAllocAccount();
                    }

                    public bool IsSetAllocAccount()
                    {
                        return IsSetField(Tags.AllocAccount);
                    }

                    public QuickFix.Fields.AllocShares AllocShares
                    {
                        get
                        {
                            QuickFix.Fields.AllocShares val = new QuickFix.Fields.AllocShares();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.AllocShares val)
                    {
                        this.AllocShares = val;
                    }

                    public QuickFix.Fields.AllocShares Get(QuickFix.Fields.AllocShares val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.AllocShares val)
                    {
                        return IsSetAllocShares();
                    }

                    public bool IsSetAllocShares()
                    {
                        return IsSetField(Tags.AllocShares);
                    }


                }
                public class NoTradingSessionsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.TradingSessionID, 0};

                    public NoTradingSessionsGroup()
                      : base(Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoTradingSessionsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.TradingSessionID TradingSessionID
                    {
                        get
                        {
                            QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.TradingSessionID val)
                    {
                        this.TradingSessionID = val;
                    }

                    public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.TradingSessionID val)
                    {
                        return IsSetTradingSessionID();
                    }

                    public bool IsSetTradingSessionID()
                    {
                        return IsSetField(Tags.TradingSessionID);
                    }


                }
            }
        }
    }
}
