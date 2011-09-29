// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class OrderCancelReplaceRequest : Message
        {
            public const string MsgType = "G";

            public OrderCancelReplaceRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("G"));
            }

            public OrderCancelReplaceRequest(
                    QuickFix.Fields.OrigClOrdID aOrigClOrdID,
                    QuickFix.Fields.ClOrdID aClOrdID,
                    QuickFix.Fields.HandlInst aHandlInst,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.TransactTime aTransactTime,
                    QuickFix.Fields.OrdType aOrdType
                ) : this()
            {
                this.origClOrdID = aOrigClOrdID;
                this.clOrdID = aClOrdID;
                this.handlInst = aHandlInst;
                this.symbol = aSymbol;
                this.side = aSide;
                this.transactTime = aTransactTime;
                this.ordType = aOrdType;
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
            public QuickFix.Fields.ClientID clientID
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
                this.clientID = val;
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
            public QuickFix.Fields.ExecBroker execBroker
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
                this.execBroker = val;
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
            public QuickFix.Fields.OrigClOrdID origClOrdID
            { 
                get 
                {
                    QuickFix.Fields.OrigClOrdID val = new QuickFix.Fields.OrigClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigClOrdID val) 
            { 
                this.origClOrdID = val;
            }
            
            public QuickFix.Fields.OrigClOrdID Get(QuickFix.Fields.OrigClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigClOrdID val) 
            { 
                return IsSetOrigClOrdID();
            }
            
            public bool IsSetOrigClOrdID() 
            { 
                return IsSetField(Tags.OrigClOrdID);
            }
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
            public QuickFix.Fields.Account account
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
                this.account = val;
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
            public QuickFix.Fields.NoAllocs noAllocs
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
                this.noAllocs = val;
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
            public QuickFix.Fields.SettlmntTyp settlmntTyp
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
                this.settlmntTyp = val;
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
            public QuickFix.Fields.FutSettDate futSettDate
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
                this.futSettDate = val;
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
            public QuickFix.Fields.HandlInst handlInst
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
                this.handlInst = val;
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
            public QuickFix.Fields.ExecInst execInst
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
                this.execInst = val;
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
            public QuickFix.Fields.MinQty minQty
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
                this.minQty = val;
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
            public QuickFix.Fields.MaxFloor maxFloor
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
                this.maxFloor = val;
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
            public QuickFix.Fields.ExDestination exDestination
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
                this.exDestination = val;
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
            public QuickFix.Fields.NoTradingSessions noTradingSessions
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
                this.noTradingSessions = val;
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
            public QuickFix.Fields.Symbol symbol
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
                this.symbol = val;
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
            public QuickFix.Fields.SymbolSfx symbolSfx
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
                this.symbolSfx = val;
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
            public QuickFix.Fields.SecurityID securityID
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
                this.securityID = val;
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
            public QuickFix.Fields.IDSource iDSource
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
                this.iDSource = val;
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
            public QuickFix.Fields.SecurityType securityType
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
                this.securityType = val;
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
            public QuickFix.Fields.MaturityMonthYear maturityMonthYear
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
                this.maturityMonthYear = val;
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
            public QuickFix.Fields.MaturityDay maturityDay
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
                this.maturityDay = val;
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
            public QuickFix.Fields.PutOrCall putOrCall
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
                this.putOrCall = val;
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
            public QuickFix.Fields.StrikePrice strikePrice
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
                this.strikePrice = val;
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
            public QuickFix.Fields.OptAttribute optAttribute
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
                this.optAttribute = val;
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
            public QuickFix.Fields.ContractMultiplier contractMultiplier
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
                this.contractMultiplier = val;
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
            public QuickFix.Fields.CouponRate couponRate
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
                this.couponRate = val;
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
            public QuickFix.Fields.SecurityExchange securityExchange
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
                this.securityExchange = val;
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
            public QuickFix.Fields.Issuer issuer
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
                this.issuer = val;
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
            public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
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
                this.encodedIssuerLen = val;
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
            public QuickFix.Fields.EncodedIssuer encodedIssuer
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
                this.encodedIssuer = val;
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
            public QuickFix.Fields.SecurityDesc securityDesc
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
                this.securityDesc = val;
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
            public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
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
                this.encodedSecurityDescLen = val;
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
            public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
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
                this.encodedSecurityDesc = val;
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
            public QuickFix.Fields.Side side
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
                this.side = val;
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
            public QuickFix.Fields.OrderQty orderQty
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
                this.orderQty = val;
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
            public QuickFix.Fields.CashOrderQty cashOrderQty
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
                this.cashOrderQty = val;
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
            public QuickFix.Fields.OrdType ordType
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
                this.ordType = val;
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
            public QuickFix.Fields.Price price
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
                this.price = val;
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
            public QuickFix.Fields.StopPx stopPx
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
                this.stopPx = val;
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
            public QuickFix.Fields.PegDifference pegDifference
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
                this.pegDifference = val;
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
            public QuickFix.Fields.DiscretionInst discretionInst
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
                this.discretionInst = val;
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
            public QuickFix.Fields.DiscretionOffset discretionOffset
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
                this.discretionOffset = val;
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
            public QuickFix.Fields.ComplianceID complianceID
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
                this.complianceID = val;
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
            public QuickFix.Fields.SolicitedFlag solicitedFlag
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
                this.solicitedFlag = val;
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
            public QuickFix.Fields.Currency currency
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
                this.currency = val;
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
            public QuickFix.Fields.TimeInForce timeInForce
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
                this.timeInForce = val;
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
            public QuickFix.Fields.EffectiveTime effectiveTime
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
                this.effectiveTime = val;
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
            public QuickFix.Fields.ExpireDate expireDate
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
                this.expireDate = val;
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
            public QuickFix.Fields.ExpireTime expireTime
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
                this.expireTime = val;
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
            public QuickFix.Fields.GTBookingInst gTBookingInst
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
                this.gTBookingInst = val;
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
            public QuickFix.Fields.Commission commission
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
                this.commission = val;
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
            public QuickFix.Fields.CommType commType
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
                this.commType = val;
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
            public QuickFix.Fields.Rule80A rule80A
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
                this.rule80A = val;
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
            public QuickFix.Fields.ForexReq forexReq
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
                this.forexReq = val;
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
            public QuickFix.Fields.SettlCurrency settlCurrency
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
                this.settlCurrency = val;
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
            public QuickFix.Fields.FutSettDate2 futSettDate2
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
                this.futSettDate2 = val;
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
            public QuickFix.Fields.OrderQty2 orderQty2
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
                this.orderQty2 = val;
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
            public QuickFix.Fields.OpenClose openClose
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
                this.openClose = val;
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
            public QuickFix.Fields.CoveredOrUncovered coveredOrUncovered
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
                this.coveredOrUncovered = val;
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
            public QuickFix.Fields.CustomerOrFirm customerOrFirm
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
                this.customerOrFirm = val;
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
            public QuickFix.Fields.MaxShow maxShow
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
                this.maxShow = val;
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
            public QuickFix.Fields.LocateReqd locateReqd
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
                this.locateReqd = val;
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
            public QuickFix.Fields.ClearingFirm clearingFirm
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
                this.clearingFirm = val;
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
            public QuickFix.Fields.ClearingAccount clearingAccount
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
                this.clearingAccount = val;
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
            public class NoAllocs : Group
            {
                public NoAllocs() 
                  :base( Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocShares, 0};
                            public QuickFix.Fields.AllocAccount allocAccount
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
                    this.allocAccount = val;
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
                public QuickFix.Fields.AllocShares allocShares
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
                    this.allocShares = val;
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
            public class NoTradingSessions : Group
            {
                public NoTradingSessions() 
                  :base( Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.TradingSessionID, 0};
                            public QuickFix.Fields.TradingSessionID tradingSessionID
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
                    this.tradingSessionID = val;
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
