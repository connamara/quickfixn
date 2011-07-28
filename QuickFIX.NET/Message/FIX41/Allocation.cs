using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
    {
        public class Allocation : Message
        {
            public Allocation() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("J"));
            }

            public Allocation(
                    QuickFix.Fields.AllocID aAllocID,
                    QuickFix.Fields.AllocTransType aAllocTransType,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Shares aShares,
                    QuickFix.Fields.AvgPx aAvgPx,
                    QuickFix.Fields.TradeDate aTradeDate
                ) : this()
            {
                this.allocID = aAllocID;
                this.allocTransType = aAllocTransType;
                this.side = aSide;
                this.symbol = aSymbol;
                this.shares = aShares;
                this.avgPx = aAvgPx;
                this.tradeDate = aTradeDate;
            }

            public QuickFix.Fields.AllocID allocID
            { 
                get 
                {
                    QuickFix.Fields.AllocID val = new QuickFix.Fields.AllocID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocID val) 
            { 
                this.allocID = val;
            }
            
            public QuickFix.Fields.AllocID get(QuickFix.Fields.AllocID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocID val) 
            { 
                return isSetAllocID();
            }
            
            public bool isSetAllocID() 
            { 
                return isSetField(Tags.AllocID);
            }
            public QuickFix.Fields.AllocTransType allocTransType
            { 
                get 
                {
                    QuickFix.Fields.AllocTransType val = new QuickFix.Fields.AllocTransType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocTransType val) 
            { 
                this.allocTransType = val;
            }
            
            public QuickFix.Fields.AllocTransType get(QuickFix.Fields.AllocTransType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocTransType val) 
            { 
                return isSetAllocTransType();
            }
            
            public bool isSetAllocTransType() 
            { 
                return isSetField(Tags.AllocTransType);
            }
            public QuickFix.Fields.RefAllocID refAllocID
            { 
                get 
                {
                    QuickFix.Fields.RefAllocID val = new QuickFix.Fields.RefAllocID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RefAllocID val) 
            { 
                this.refAllocID = val;
            }
            
            public QuickFix.Fields.RefAllocID get(QuickFix.Fields.RefAllocID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RefAllocID val) 
            { 
                return isSetRefAllocID();
            }
            
            public bool isSetRefAllocID() 
            { 
                return isSetField(Tags.RefAllocID);
            }
            public QuickFix.Fields.AllocLinkID allocLinkID
            { 
                get 
                {
                    QuickFix.Fields.AllocLinkID val = new QuickFix.Fields.AllocLinkID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocLinkID val) 
            { 
                this.allocLinkID = val;
            }
            
            public QuickFix.Fields.AllocLinkID get(QuickFix.Fields.AllocLinkID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocLinkID val) 
            { 
                return isSetAllocLinkID();
            }
            
            public bool isSetAllocLinkID() 
            { 
                return isSetField(Tags.AllocLinkID);
            }
            public QuickFix.Fields.AllocLinkType allocLinkType
            { 
                get 
                {
                    QuickFix.Fields.AllocLinkType val = new QuickFix.Fields.AllocLinkType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocLinkType val) 
            { 
                this.allocLinkType = val;
            }
            
            public QuickFix.Fields.AllocLinkType get(QuickFix.Fields.AllocLinkType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocLinkType val) 
            { 
                return isSetAllocLinkType();
            }
            
            public bool isSetAllocLinkType() 
            { 
                return isSetField(Tags.AllocLinkType);
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
            public QuickFix.Fields.NoExecs noExecs
            { 
                get 
                {
                    QuickFix.Fields.NoExecs val = new QuickFix.Fields.NoExecs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoExecs val) 
            { 
                this.noExecs = val;
            }
            
            public QuickFix.Fields.NoExecs get(QuickFix.Fields.NoExecs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoExecs val) 
            { 
                return isSetNoExecs();
            }
            
            public bool isSetNoExecs() 
            { 
                return isSetField(Tags.NoExecs);
            }
            public QuickFix.Fields.Side side
            { 
                get 
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Side val) 
            { 
                this.side = val;
            }
            
            public QuickFix.Fields.Side get(QuickFix.Fields.Side val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Side val) 
            { 
                return isSetSide();
            }
            
            public bool isSetSide() 
            { 
                return isSetField(Tags.Side);
            }
            public QuickFix.Fields.Symbol symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Symbol val) 
            { 
                this.symbol = val;
            }
            
            public QuickFix.Fields.Symbol get(QuickFix.Fields.Symbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Symbol val) 
            { 
                return isSetSymbol();
            }
            
            public bool isSetSymbol() 
            { 
                return isSetField(Tags.Symbol);
            }
            public QuickFix.Fields.SymbolSfx symbolSfx
            { 
                get 
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SymbolSfx val) 
            { 
                this.symbolSfx = val;
            }
            
            public QuickFix.Fields.SymbolSfx get(QuickFix.Fields.SymbolSfx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SymbolSfx val) 
            { 
                return isSetSymbolSfx();
            }
            
            public bool isSetSymbolSfx() 
            { 
                return isSetField(Tags.SymbolSfx);
            }
            public QuickFix.Fields.SecurityID securityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityID val) 
            { 
                this.securityID = val;
            }
            
            public QuickFix.Fields.SecurityID get(QuickFix.Fields.SecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityID val) 
            { 
                return isSetSecurityID();
            }
            
            public bool isSetSecurityID() 
            { 
                return isSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.IDSource iDSource
            { 
                get 
                {
                    QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IDSource val) 
            { 
                this.iDSource = val;
            }
            
            public QuickFix.Fields.IDSource get(QuickFix.Fields.IDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IDSource val) 
            { 
                return isSetIDSource();
            }
            
            public bool isSetIDSource() 
            { 
                return isSetField(Tags.IDSource);
            }
            public QuickFix.Fields.SecurityType securityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityType val) 
            { 
                this.securityType = val;
            }
            
            public QuickFix.Fields.SecurityType get(QuickFix.Fields.SecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityType val) 
            { 
                return isSetSecurityType();
            }
            
            public bool isSetSecurityType() 
            { 
                return isSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.MaturityMonthYear maturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityMonthYear val) 
            { 
                this.maturityMonthYear = val;
            }
            
            public QuickFix.Fields.MaturityMonthYear get(QuickFix.Fields.MaturityMonthYear val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityMonthYear val) 
            { 
                return isSetMaturityMonthYear();
            }
            
            public bool isSetMaturityMonthYear() 
            { 
                return isSetField(Tags.MaturityMonthYear);
            }
            public QuickFix.Fields.MaturityDay maturityDay
            { 
                get 
                {
                    QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityDay val) 
            { 
                this.maturityDay = val;
            }
            
            public QuickFix.Fields.MaturityDay get(QuickFix.Fields.MaturityDay val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityDay val) 
            { 
                return isSetMaturityDay();
            }
            
            public bool isSetMaturityDay() 
            { 
                return isSetField(Tags.MaturityDay);
            }
            public QuickFix.Fields.PutOrCall putOrCall
            { 
                get 
                {
                    QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PutOrCall val) 
            { 
                this.putOrCall = val;
            }
            
            public QuickFix.Fields.PutOrCall get(QuickFix.Fields.PutOrCall val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PutOrCall val) 
            { 
                return isSetPutOrCall();
            }
            
            public bool isSetPutOrCall() 
            { 
                return isSetField(Tags.PutOrCall);
            }
            public QuickFix.Fields.StrikePrice strikePrice
            { 
                get 
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikePrice val) 
            { 
                this.strikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice get(QuickFix.Fields.StrikePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikePrice val) 
            { 
                return isSetStrikePrice();
            }
            
            public bool isSetStrikePrice() 
            { 
                return isSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.OptAttribute optAttribute
            { 
                get 
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OptAttribute val) 
            { 
                this.optAttribute = val;
            }
            
            public QuickFix.Fields.OptAttribute get(QuickFix.Fields.OptAttribute val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OptAttribute val) 
            { 
                return isSetOptAttribute();
            }
            
            public bool isSetOptAttribute() 
            { 
                return isSetField(Tags.OptAttribute);
            }
            public QuickFix.Fields.SecurityExchange securityExchange
            { 
                get 
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityExchange val) 
            { 
                this.securityExchange = val;
            }
            
            public QuickFix.Fields.SecurityExchange get(QuickFix.Fields.SecurityExchange val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityExchange val) 
            { 
                return isSetSecurityExchange();
            }
            
            public bool isSetSecurityExchange() 
            { 
                return isSetField(Tags.SecurityExchange);
            }
            public QuickFix.Fields.Issuer issuer
            { 
                get 
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Issuer val) 
            { 
                this.issuer = val;
            }
            
            public QuickFix.Fields.Issuer get(QuickFix.Fields.Issuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Issuer val) 
            { 
                return isSetIssuer();
            }
            
            public bool isSetIssuer() 
            { 
                return isSetField(Tags.Issuer);
            }
            public QuickFix.Fields.SecurityDesc securityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.securityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc get(QuickFix.Fields.SecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return isSetSecurityDesc();
            }
            
            public bool isSetSecurityDesc() 
            { 
                return isSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.Shares shares
            { 
                get 
                {
                    QuickFix.Fields.Shares val = new QuickFix.Fields.Shares();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Shares val) 
            { 
                this.shares = val;
            }
            
            public QuickFix.Fields.Shares get(QuickFix.Fields.Shares val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Shares val) 
            { 
                return isSetShares();
            }
            
            public bool isSetShares() 
            { 
                return isSetField(Tags.Shares);
            }
            public QuickFix.Fields.LastMkt lastMkt
            { 
                get 
                {
                    QuickFix.Fields.LastMkt val = new QuickFix.Fields.LastMkt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastMkt val) 
            { 
                this.lastMkt = val;
            }
            
            public QuickFix.Fields.LastMkt get(QuickFix.Fields.LastMkt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastMkt val) 
            { 
                return isSetLastMkt();
            }
            
            public bool isSetLastMkt() 
            { 
                return isSetField(Tags.LastMkt);
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
            public QuickFix.Fields.Currency currency
            { 
                get 
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Currency val) 
            { 
                this.currency = val;
            }
            
            public QuickFix.Fields.Currency get(QuickFix.Fields.Currency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Currency val) 
            { 
                return isSetCurrency();
            }
            
            public bool isSetCurrency() 
            { 
                return isSetField(Tags.Currency);
            }
            public QuickFix.Fields.AvgPrxPrecision avgPrxPrecision
            { 
                get 
                {
                    QuickFix.Fields.AvgPrxPrecision val = new QuickFix.Fields.AvgPrxPrecision();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AvgPrxPrecision val) 
            { 
                this.avgPrxPrecision = val;
            }
            
            public QuickFix.Fields.AvgPrxPrecision get(QuickFix.Fields.AvgPrxPrecision val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AvgPrxPrecision val) 
            { 
                return isSetAvgPrxPrecision();
            }
            
            public bool isSetAvgPrxPrecision() 
            { 
                return isSetField(Tags.AvgPrxPrecision);
            }
            public QuickFix.Fields.TradeDate tradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeDate val) 
            { 
                this.tradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate get(QuickFix.Fields.TradeDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeDate val) 
            { 
                return isSetTradeDate();
            }
            
            public bool isSetTradeDate() 
            { 
                return isSetField(Tags.TradeDate);
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
            public QuickFix.Fields.SettlmntTyp settlmntTyp
            { 
                get 
                {
                    QuickFix.Fields.SettlmntTyp val = new QuickFix.Fields.SettlmntTyp();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlmntTyp val) 
            { 
                this.settlmntTyp = val;
            }
            
            public QuickFix.Fields.SettlmntTyp get(QuickFix.Fields.SettlmntTyp val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlmntTyp val) 
            { 
                return isSetSettlmntTyp();
            }
            
            public bool isSetSettlmntTyp() 
            { 
                return isSetField(Tags.SettlmntTyp);
            }
            public QuickFix.Fields.FutSettDate futSettDate
            { 
                get 
                {
                    QuickFix.Fields.FutSettDate val = new QuickFix.Fields.FutSettDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FutSettDate val) 
            { 
                this.futSettDate = val;
            }
            
            public QuickFix.Fields.FutSettDate get(QuickFix.Fields.FutSettDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FutSettDate val) 
            { 
                return isSetFutSettDate();
            }
            
            public bool isSetFutSettDate() 
            { 
                return isSetField(Tags.FutSettDate);
            }
            public QuickFix.Fields.NetMoney netMoney
            { 
                get 
                {
                    QuickFix.Fields.NetMoney val = new QuickFix.Fields.NetMoney();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NetMoney val) 
            { 
                this.netMoney = val;
            }
            
            public QuickFix.Fields.NetMoney get(QuickFix.Fields.NetMoney val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NetMoney val) 
            { 
                return isSetNetMoney();
            }
            
            public bool isSetNetMoney() 
            { 
                return isSetField(Tags.NetMoney);
            }
            public QuickFix.Fields.OpenClose openClose
            { 
                get 
                {
                    QuickFix.Fields.OpenClose val = new QuickFix.Fields.OpenClose();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OpenClose val) 
            { 
                this.openClose = val;
            }
            
            public QuickFix.Fields.OpenClose get(QuickFix.Fields.OpenClose val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OpenClose val) 
            { 
                return isSetOpenClose();
            }
            
            public bool isSetOpenClose() 
            { 
                return isSetField(Tags.OpenClose);
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
            public QuickFix.Fields.NumDaysInterest numDaysInterest
            { 
                get 
                {
                    QuickFix.Fields.NumDaysInterest val = new QuickFix.Fields.NumDaysInterest();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NumDaysInterest val) 
            { 
                this.numDaysInterest = val;
            }
            
            public QuickFix.Fields.NumDaysInterest get(QuickFix.Fields.NumDaysInterest val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NumDaysInterest val) 
            { 
                return isSetNumDaysInterest();
            }
            
            public bool isSetNumDaysInterest() 
            { 
                return isSetField(Tags.NumDaysInterest);
            }
            public QuickFix.Fields.AccruedInterestRate accruedInterestRate
            { 
                get 
                {
                    QuickFix.Fields.AccruedInterestRate val = new QuickFix.Fields.AccruedInterestRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AccruedInterestRate val) 
            { 
                this.accruedInterestRate = val;
            }
            
            public QuickFix.Fields.AccruedInterestRate get(QuickFix.Fields.AccruedInterestRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AccruedInterestRate val) 
            { 
                return isSetAccruedInterestRate();
            }
            
            public bool isSetAccruedInterestRate() 
            { 
                return isSetField(Tags.AccruedInterestRate);
            }
            public QuickFix.Fields.NoAllocs noAllocs
            { 
                get 
                {
                    QuickFix.Fields.NoAllocs val = new QuickFix.Fields.NoAllocs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoAllocs val) 
            { 
                this.noAllocs = val;
            }
            
            public QuickFix.Fields.NoAllocs get(QuickFix.Fields.NoAllocs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoAllocs val) 
            { 
                return isSetNoAllocs();
            }
            
            public bool isSetNoAllocs() 
            { 
                return isSetField(Tags.NoAllocs);
            }
            public class NoOrders : Group
            {
                public NoOrders() 
                  :base( Tags.NoOrders, Tags.ClOrdID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.ListID, Tags.WaveNo, 0};
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
                public QuickFix.Fields.OrderID orderID
                { 
                    get 
                    {
                        QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderID val) 
                { 
                    this.orderID = val;
                }
                
                public QuickFix.Fields.OrderID get(QuickFix.Fields.OrderID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderID val) 
                { 
                    return isSetOrderID();
                }
                
                public bool isSetOrderID() 
                { 
                    return isSetField(Tags.OrderID);
                }
                public QuickFix.Fields.SecondaryOrderID secondaryOrderID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryOrderID val = new QuickFix.Fields.SecondaryOrderID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    this.secondaryOrderID = val;
                }
                
                public QuickFix.Fields.SecondaryOrderID get(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    return isSetSecondaryOrderID();
                }
                
                public bool isSetSecondaryOrderID() 
                { 
                    return isSetField(Tags.SecondaryOrderID);
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
            
            }
            public class NoExecs : Group
            {
                public NoExecs() 
                  :base( Tags.NoExecs, Tags.LastShares, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.LastShares, Tags.ExecID, Tags.LastPx, Tags.LastCapacity, 0};
                            public QuickFix.Fields.LastShares lastShares
                { 
                    get 
                    {
                        QuickFix.Fields.LastShares val = new QuickFix.Fields.LastShares();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LastShares val) 
                { 
                    this.lastShares = val;
                }
                
                public QuickFix.Fields.LastShares get(QuickFix.Fields.LastShares val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LastShares val) 
                { 
                    return isSetLastShares();
                }
                
                public bool isSetLastShares() 
                { 
                    return isSetField(Tags.LastShares);
                }
                public QuickFix.Fields.ExecID execID
                { 
                    get 
                    {
                        QuickFix.Fields.ExecID val = new QuickFix.Fields.ExecID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExecID val) 
                { 
                    this.execID = val;
                }
                
                public QuickFix.Fields.ExecID get(QuickFix.Fields.ExecID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExecID val) 
                { 
                    return isSetExecID();
                }
                
                public bool isSetExecID() 
                { 
                    return isSetField(Tags.ExecID);
                }
                public QuickFix.Fields.LastPx lastPx
                { 
                    get 
                    {
                        QuickFix.Fields.LastPx val = new QuickFix.Fields.LastPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LastPx val) 
                { 
                    this.lastPx = val;
                }
                
                public QuickFix.Fields.LastPx get(QuickFix.Fields.LastPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LastPx val) 
                { 
                    return isSetLastPx();
                }
                
                public bool isSetLastPx() 
                { 
                    return isSetField(Tags.LastPx);
                }
                public QuickFix.Fields.LastCapacity lastCapacity
                { 
                    get 
                    {
                        QuickFix.Fields.LastCapacity val = new QuickFix.Fields.LastCapacity();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LastCapacity val) 
                { 
                    this.lastCapacity = val;
                }
                
                public QuickFix.Fields.LastCapacity get(QuickFix.Fields.LastCapacity val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LastCapacity val) 
                { 
                    return isSetLastCapacity();
                }
                
                public bool isSetLastCapacity() 
                { 
                    return isSetField(Tags.LastCapacity);
                }
            
            }
            public class NoAllocs : Group
            {
                public NoAllocs() 
                  :base( Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocShares, Tags.ProcessCode, Tags.BrokerOfCredit, Tags.NotifyBrokerOfCredit, Tags.AllocHandlInst, Tags.AllocText, Tags.ExecBroker, Tags.ClientID, Tags.Commission, Tags.CommType, Tags.AllocAvgPx, Tags.AllocNetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.AccruedInterestAmt, Tags.SettlInstMode, Tags.NoMiscFees, 0};
                            public QuickFix.Fields.AllocAccount allocAccount
                { 
                    get 
                    {
                        QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AllocAccount val) 
                { 
                    this.allocAccount = val;
                }
                
                public QuickFix.Fields.AllocAccount get(QuickFix.Fields.AllocAccount val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AllocAccount val) 
                { 
                    return isSetAllocAccount();
                }
                
                public bool isSetAllocAccount() 
                { 
                    return isSetField(Tags.AllocAccount);
                }
                public QuickFix.Fields.AllocShares allocShares
                { 
                    get 
                    {
                        QuickFix.Fields.AllocShares val = new QuickFix.Fields.AllocShares();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AllocShares val) 
                { 
                    this.allocShares = val;
                }
                
                public QuickFix.Fields.AllocShares get(QuickFix.Fields.AllocShares val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AllocShares val) 
                { 
                    return isSetAllocShares();
                }
                
                public bool isSetAllocShares() 
                { 
                    return isSetField(Tags.AllocShares);
                }
                public QuickFix.Fields.ProcessCode processCode
                { 
                    get 
                    {
                        QuickFix.Fields.ProcessCode val = new QuickFix.Fields.ProcessCode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ProcessCode val) 
                { 
                    this.processCode = val;
                }
                
                public QuickFix.Fields.ProcessCode get(QuickFix.Fields.ProcessCode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ProcessCode val) 
                { 
                    return isSetProcessCode();
                }
                
                public bool isSetProcessCode() 
                { 
                    return isSetField(Tags.ProcessCode);
                }
                public QuickFix.Fields.BrokerOfCredit brokerOfCredit
                { 
                    get 
                    {
                        QuickFix.Fields.BrokerOfCredit val = new QuickFix.Fields.BrokerOfCredit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BrokerOfCredit val) 
                { 
                    this.brokerOfCredit = val;
                }
                
                public QuickFix.Fields.BrokerOfCredit get(QuickFix.Fields.BrokerOfCredit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BrokerOfCredit val) 
                { 
                    return isSetBrokerOfCredit();
                }
                
                public bool isSetBrokerOfCredit() 
                { 
                    return isSetField(Tags.BrokerOfCredit);
                }
                public QuickFix.Fields.NotifyBrokerOfCredit notifyBrokerOfCredit
                { 
                    get 
                    {
                        QuickFix.Fields.NotifyBrokerOfCredit val = new QuickFix.Fields.NotifyBrokerOfCredit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NotifyBrokerOfCredit val) 
                { 
                    this.notifyBrokerOfCredit = val;
                }
                
                public QuickFix.Fields.NotifyBrokerOfCredit get(QuickFix.Fields.NotifyBrokerOfCredit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NotifyBrokerOfCredit val) 
                { 
                    return isSetNotifyBrokerOfCredit();
                }
                
                public bool isSetNotifyBrokerOfCredit() 
                { 
                    return isSetField(Tags.NotifyBrokerOfCredit);
                }
                public QuickFix.Fields.AllocHandlInst allocHandlInst
                { 
                    get 
                    {
                        QuickFix.Fields.AllocHandlInst val = new QuickFix.Fields.AllocHandlInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AllocHandlInst val) 
                { 
                    this.allocHandlInst = val;
                }
                
                public QuickFix.Fields.AllocHandlInst get(QuickFix.Fields.AllocHandlInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AllocHandlInst val) 
                { 
                    return isSetAllocHandlInst();
                }
                
                public bool isSetAllocHandlInst() 
                { 
                    return isSetField(Tags.AllocHandlInst);
                }
                public QuickFix.Fields.AllocText allocText
                { 
                    get 
                    {
                        QuickFix.Fields.AllocText val = new QuickFix.Fields.AllocText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AllocText val) 
                { 
                    this.allocText = val;
                }
                
                public QuickFix.Fields.AllocText get(QuickFix.Fields.AllocText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AllocText val) 
                { 
                    return isSetAllocText();
                }
                
                public bool isSetAllocText() 
                { 
                    return isSetField(Tags.AllocText);
                }
                public QuickFix.Fields.ExecBroker execBroker
                { 
                    get 
                    {
                        QuickFix.Fields.ExecBroker val = new QuickFix.Fields.ExecBroker();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExecBroker val) 
                { 
                    this.execBroker = val;
                }
                
                public QuickFix.Fields.ExecBroker get(QuickFix.Fields.ExecBroker val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExecBroker val) 
                { 
                    return isSetExecBroker();
                }
                
                public bool isSetExecBroker() 
                { 
                    return isSetField(Tags.ExecBroker);
                }
                public QuickFix.Fields.ClientID clientID
                { 
                    get 
                    {
                        QuickFix.Fields.ClientID val = new QuickFix.Fields.ClientID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ClientID val) 
                { 
                    this.clientID = val;
                }
                
                public QuickFix.Fields.ClientID get(QuickFix.Fields.ClientID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ClientID val) 
                { 
                    return isSetClientID();
                }
                
                public bool isSetClientID() 
                { 
                    return isSetField(Tags.ClientID);
                }
                public QuickFix.Fields.Commission commission
                { 
                    get 
                    {
                        QuickFix.Fields.Commission val = new QuickFix.Fields.Commission();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Commission val) 
                { 
                    this.commission = val;
                }
                
                public QuickFix.Fields.Commission get(QuickFix.Fields.Commission val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Commission val) 
                { 
                    return isSetCommission();
                }
                
                public bool isSetCommission() 
                { 
                    return isSetField(Tags.Commission);
                }
                public QuickFix.Fields.CommType commType
                { 
                    get 
                    {
                        QuickFix.Fields.CommType val = new QuickFix.Fields.CommType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CommType val) 
                { 
                    this.commType = val;
                }
                
                public QuickFix.Fields.CommType get(QuickFix.Fields.CommType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CommType val) 
                { 
                    return isSetCommType();
                }
                
                public bool isSetCommType() 
                { 
                    return isSetField(Tags.CommType);
                }
                public QuickFix.Fields.AllocAvgPx allocAvgPx
                { 
                    get 
                    {
                        QuickFix.Fields.AllocAvgPx val = new QuickFix.Fields.AllocAvgPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AllocAvgPx val) 
                { 
                    this.allocAvgPx = val;
                }
                
                public QuickFix.Fields.AllocAvgPx get(QuickFix.Fields.AllocAvgPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AllocAvgPx val) 
                { 
                    return isSetAllocAvgPx();
                }
                
                public bool isSetAllocAvgPx() 
                { 
                    return isSetField(Tags.AllocAvgPx);
                }
                public QuickFix.Fields.AllocNetMoney allocNetMoney
                { 
                    get 
                    {
                        QuickFix.Fields.AllocNetMoney val = new QuickFix.Fields.AllocNetMoney();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AllocNetMoney val) 
                { 
                    this.allocNetMoney = val;
                }
                
                public QuickFix.Fields.AllocNetMoney get(QuickFix.Fields.AllocNetMoney val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AllocNetMoney val) 
                { 
                    return isSetAllocNetMoney();
                }
                
                public bool isSetAllocNetMoney() 
                { 
                    return isSetField(Tags.AllocNetMoney);
                }
                public QuickFix.Fields.SettlCurrAmt settlCurrAmt
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrAmt val = new QuickFix.Fields.SettlCurrAmt();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    this.settlCurrAmt = val;
                }
                
                public QuickFix.Fields.SettlCurrAmt get(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    return isSetSettlCurrAmt();
                }
                
                public bool isSetSettlCurrAmt() 
                { 
                    return isSetField(Tags.SettlCurrAmt);
                }
                public QuickFix.Fields.SettlCurrency settlCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrency val = new QuickFix.Fields.SettlCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlCurrency val) 
                { 
                    this.settlCurrency = val;
                }
                
                public QuickFix.Fields.SettlCurrency get(QuickFix.Fields.SettlCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlCurrency val) 
                { 
                    return isSetSettlCurrency();
                }
                
                public bool isSetSettlCurrency() 
                { 
                    return isSetField(Tags.SettlCurrency);
                }
                public QuickFix.Fields.SettlCurrFxRate settlCurrFxRate
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrFxRate val = new QuickFix.Fields.SettlCurrFxRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    this.settlCurrFxRate = val;
                }
                
                public QuickFix.Fields.SettlCurrFxRate get(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    return isSetSettlCurrFxRate();
                }
                
                public bool isSetSettlCurrFxRate() 
                { 
                    return isSetField(Tags.SettlCurrFxRate);
                }
                public QuickFix.Fields.SettlCurrFxRateCalc settlCurrFxRateCalc
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrFxRateCalc val = new QuickFix.Fields.SettlCurrFxRateCalc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlCurrFxRateCalc val) 
                { 
                    this.settlCurrFxRateCalc = val;
                }
                
                public QuickFix.Fields.SettlCurrFxRateCalc get(QuickFix.Fields.SettlCurrFxRateCalc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlCurrFxRateCalc val) 
                { 
                    return isSetSettlCurrFxRateCalc();
                }
                
                public bool isSetSettlCurrFxRateCalc() 
                { 
                    return isSetField(Tags.SettlCurrFxRateCalc);
                }
                public QuickFix.Fields.AccruedInterestAmt accruedInterestAmt
                { 
                    get 
                    {
                        QuickFix.Fields.AccruedInterestAmt val = new QuickFix.Fields.AccruedInterestAmt();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AccruedInterestAmt val) 
                { 
                    this.accruedInterestAmt = val;
                }
                
                public QuickFix.Fields.AccruedInterestAmt get(QuickFix.Fields.AccruedInterestAmt val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AccruedInterestAmt val) 
                { 
                    return isSetAccruedInterestAmt();
                }
                
                public bool isSetAccruedInterestAmt() 
                { 
                    return isSetField(Tags.AccruedInterestAmt);
                }
                public QuickFix.Fields.SettlInstMode settlInstMode
                { 
                    get 
                    {
                        QuickFix.Fields.SettlInstMode val = new QuickFix.Fields.SettlInstMode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlInstMode val) 
                { 
                    this.settlInstMode = val;
                }
                
                public QuickFix.Fields.SettlInstMode get(QuickFix.Fields.SettlInstMode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlInstMode val) 
                { 
                    return isSetSettlInstMode();
                }
                
                public bool isSetSettlInstMode() 
                { 
                    return isSetField(Tags.SettlInstMode);
                }
                public QuickFix.Fields.NoMiscFees noMiscFees
                { 
                    get 
                    {
                        QuickFix.Fields.NoMiscFees val = new QuickFix.Fields.NoMiscFees();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoMiscFees val) 
                { 
                    this.noMiscFees = val;
                }
                
                public QuickFix.Fields.NoMiscFees get(QuickFix.Fields.NoMiscFees val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoMiscFees val) 
                { 
                    return isSetNoMiscFees();
                }
                
                public bool isSetNoMiscFees() 
                { 
                    return isSetField(Tags.NoMiscFees);
                }
                            public class NoMiscFees : Group
                {
                    public NoMiscFees() 
                      :base( Tags.NoMiscFees, Tags.MiscFeeAmt, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, 0};
                                    public QuickFix.Fields.MiscFeeAmt miscFeeAmt
                    { 
                        get 
                        {
                            QuickFix.Fields.MiscFeeAmt val = new QuickFix.Fields.MiscFeeAmt();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MiscFeeAmt val) 
                    { 
                        this.miscFeeAmt = val;
                    }
                    
                    public QuickFix.Fields.MiscFeeAmt get(QuickFix.Fields.MiscFeeAmt val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MiscFeeAmt val) 
                    { 
                        return isSetMiscFeeAmt();
                    }
                    
                    public bool isSetMiscFeeAmt() 
                    { 
                        return isSetField(Tags.MiscFeeAmt);
                    }
                    public QuickFix.Fields.MiscFeeCurr miscFeeCurr
                    { 
                        get 
                        {
                            QuickFix.Fields.MiscFeeCurr val = new QuickFix.Fields.MiscFeeCurr();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MiscFeeCurr val) 
                    { 
                        this.miscFeeCurr = val;
                    }
                    
                    public QuickFix.Fields.MiscFeeCurr get(QuickFix.Fields.MiscFeeCurr val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MiscFeeCurr val) 
                    { 
                        return isSetMiscFeeCurr();
                    }
                    
                    public bool isSetMiscFeeCurr() 
                    { 
                        return isSetField(Tags.MiscFeeCurr);
                    }
                    public QuickFix.Fields.MiscFeeType miscFeeType
                    { 
                        get 
                        {
                            QuickFix.Fields.MiscFeeType val = new QuickFix.Fields.MiscFeeType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MiscFeeType val) 
                    { 
                        this.miscFeeType = val;
                    }
                    
                    public QuickFix.Fields.MiscFeeType get(QuickFix.Fields.MiscFeeType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MiscFeeType val) 
                    { 
                        return isSetMiscFeeType();
                    }
                    
                    public bool isSetMiscFeeType() 
                    { 
                        return isSetField(Tags.MiscFeeType);
                    }
                
                }
            }
        }
    }
}
