using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX40 
    {
        public class ExecutionReport : Message
        {
            public ExecutionReport() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("8"));
            }

            public ExecutionReport(
                    QuickFix.Fields.OrderID aOrderID,
                    QuickFix.Fields.ExecID aExecID,
                    QuickFix.Fields.ExecTransType aExecTransType,
                    QuickFix.Fields.OrdStatus aOrdStatus,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.OrderQty aOrderQty,
                    QuickFix.Fields.LastShares aLastShares,
                    QuickFix.Fields.LastPx aLastPx,
                    QuickFix.Fields.CumQty aCumQty,
                    QuickFix.Fields.AvgPx aAvgPx
                ) : this()
            {
                this.orderID = aOrderID;
                this.execID = aExecID;
                this.execTransType = aExecTransType;
                this.ordStatus = aOrdStatus;
                this.symbol = aSymbol;
                this.side = aSide;
                this.orderQty = aOrderQty;
                this.lastShares = aLastShares;
                this.lastPx = aLastPx;
                this.cumQty = aCumQty;
                this.avgPx = aAvgPx;
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
            public QuickFix.Fields.ExecTransType execTransType
            { 
                get 
                {
                    QuickFix.Fields.ExecTransType val = new QuickFix.Fields.ExecTransType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecTransType val) 
            { 
                this.execTransType = val;
            }
            
            public QuickFix.Fields.ExecTransType get(QuickFix.Fields.ExecTransType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecTransType val) 
            { 
                return isSetExecTransType();
            }
            
            public bool isSetExecTransType() 
            { 
                return isSetField(Tags.ExecTransType);
            }
            public QuickFix.Fields.ExecRefID execRefID
            { 
                get 
                {
                    QuickFix.Fields.ExecRefID val = new QuickFix.Fields.ExecRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecRefID val) 
            { 
                this.execRefID = val;
            }
            
            public QuickFix.Fields.ExecRefID get(QuickFix.Fields.ExecRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecRefID val) 
            { 
                return isSetExecRefID();
            }
            
            public bool isSetExecRefID() 
            { 
                return isSetField(Tags.ExecRefID);
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
            public QuickFix.Fields.Account account
            { 
                get 
                {
                    QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Account val) 
            { 
                this.account = val;
            }
            
            public QuickFix.Fields.Account get(QuickFix.Fields.Account val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Account val) 
            { 
                return isSetAccount();
            }
            
            public bool isSetAccount() 
            { 
                return isSetField(Tags.Account);
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
            public QuickFix.Fields.OrderQty orderQty
            { 
                get 
                {
                    QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrderQty val) 
            { 
                this.orderQty = val;
            }
            
            public QuickFix.Fields.OrderQty get(QuickFix.Fields.OrderQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrderQty val) 
            { 
                return isSetOrderQty();
            }
            
            public bool isSetOrderQty() 
            { 
                return isSetField(Tags.OrderQty);
            }
            public QuickFix.Fields.OrdType ordType
            { 
                get 
                {
                    QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrdType val) 
            { 
                this.ordType = val;
            }
            
            public QuickFix.Fields.OrdType get(QuickFix.Fields.OrdType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrdType val) 
            { 
                return isSetOrdType();
            }
            
            public bool isSetOrdType() 
            { 
                return isSetField(Tags.OrdType);
            }
            public QuickFix.Fields.Price price
            { 
                get 
                {
                    QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Price val) 
            { 
                this.price = val;
            }
            
            public QuickFix.Fields.Price get(QuickFix.Fields.Price val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Price val) 
            { 
                return isSetPrice();
            }
            
            public bool isSetPrice() 
            { 
                return isSetField(Tags.Price);
            }
            public QuickFix.Fields.StopPx stopPx
            { 
                get 
                {
                    QuickFix.Fields.StopPx val = new QuickFix.Fields.StopPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StopPx val) 
            { 
                this.stopPx = val;
            }
            
            public QuickFix.Fields.StopPx get(QuickFix.Fields.StopPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StopPx val) 
            { 
                return isSetStopPx();
            }
            
            public bool isSetStopPx() 
            { 
                return isSetField(Tags.StopPx);
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
            public QuickFix.Fields.TimeInForce timeInForce
            { 
                get 
                {
                    QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TimeInForce val) 
            { 
                this.timeInForce = val;
            }
            
            public QuickFix.Fields.TimeInForce get(QuickFix.Fields.TimeInForce val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TimeInForce val) 
            { 
                return isSetTimeInForce();
            }
            
            public bool isSetTimeInForce() 
            { 
                return isSetField(Tags.TimeInForce);
            }
            public QuickFix.Fields.ExpireTime expireTime
            { 
                get 
                {
                    QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExpireTime val) 
            { 
                this.expireTime = val;
            }
            
            public QuickFix.Fields.ExpireTime get(QuickFix.Fields.ExpireTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExpireTime val) 
            { 
                return isSetExpireTime();
            }
            
            public bool isSetExpireTime() 
            { 
                return isSetField(Tags.ExpireTime);
            }
            public QuickFix.Fields.ExecInst execInst
            { 
                get 
                {
                    QuickFix.Fields.ExecInst val = new QuickFix.Fields.ExecInst();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecInst val) 
            { 
                this.execInst = val;
            }
            
            public QuickFix.Fields.ExecInst get(QuickFix.Fields.ExecInst val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecInst val) 
            { 
                return isSetExecInst();
            }
            
            public bool isSetExecInst() 
            { 
                return isSetField(Tags.ExecInst);
            }
            public QuickFix.Fields.Rule80A rule80A
            { 
                get 
                {
                    QuickFix.Fields.Rule80A val = new QuickFix.Fields.Rule80A();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Rule80A val) 
            { 
                this.rule80A = val;
            }
            
            public QuickFix.Fields.Rule80A get(QuickFix.Fields.Rule80A val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Rule80A val) 
            { 
                return isSetRule80A();
            }
            
            public bool isSetRule80A() 
            { 
                return isSetField(Tags.Rule80A);
            }
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
            public QuickFix.Fields.ReportToExch reportToExch
            { 
                get 
                {
                    QuickFix.Fields.ReportToExch val = new QuickFix.Fields.ReportToExch();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ReportToExch val) 
            { 
                this.reportToExch = val;
            }
            
            public QuickFix.Fields.ReportToExch get(QuickFix.Fields.ReportToExch val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ReportToExch val) 
            { 
                return isSetReportToExch();
            }
            
            public bool isSetReportToExch() 
            { 
                return isSetField(Tags.ReportToExch);
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
