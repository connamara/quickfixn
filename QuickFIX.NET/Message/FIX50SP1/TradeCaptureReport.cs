// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class TradeCaptureReport : Message
        {
            public const string MsgType = "AE";

            public TradeCaptureReport() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("AE"));
            }

            public TradeCaptureReport(
                    QuickFix.Fields.LastQty aLastQty,
                    QuickFix.Fields.LastPx aLastPx
                ) : this()
            {
                this.lastQty = aLastQty;
                this.lastPx = aLastPx;
            }

            public QuickFix.Fields.TradeReportID tradeReportID
            { 
                get 
                {
                    QuickFix.Fields.TradeReportID val = new QuickFix.Fields.TradeReportID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeReportID val) 
            { 
                this.tradeReportID = val;
            }
            
            public QuickFix.Fields.TradeReportID get(QuickFix.Fields.TradeReportID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeReportID val) 
            { 
                return isSetTradeReportID();
            }
            
            public bool isSetTradeReportID() 
            { 
                return isSetField(Tags.TradeReportID);
            }
            public QuickFix.Fields.TradeReportTransType tradeReportTransType
            { 
                get 
                {
                    QuickFix.Fields.TradeReportTransType val = new QuickFix.Fields.TradeReportTransType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeReportTransType val) 
            { 
                this.tradeReportTransType = val;
            }
            
            public QuickFix.Fields.TradeReportTransType get(QuickFix.Fields.TradeReportTransType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeReportTransType val) 
            { 
                return isSetTradeReportTransType();
            }
            
            public bool isSetTradeReportTransType() 
            { 
                return isSetField(Tags.TradeReportTransType);
            }
            public QuickFix.Fields.TradeReportType tradeReportType
            { 
                get 
                {
                    QuickFix.Fields.TradeReportType val = new QuickFix.Fields.TradeReportType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeReportType val) 
            { 
                this.tradeReportType = val;
            }
            
            public QuickFix.Fields.TradeReportType get(QuickFix.Fields.TradeReportType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeReportType val) 
            { 
                return isSetTradeReportType();
            }
            
            public bool isSetTradeReportType() 
            { 
                return isSetField(Tags.TradeReportType);
            }
            public QuickFix.Fields.TradeRequestID tradeRequestID
            { 
                get 
                {
                    QuickFix.Fields.TradeRequestID val = new QuickFix.Fields.TradeRequestID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeRequestID val) 
            { 
                this.tradeRequestID = val;
            }
            
            public QuickFix.Fields.TradeRequestID get(QuickFix.Fields.TradeRequestID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeRequestID val) 
            { 
                return isSetTradeRequestID();
            }
            
            public bool isSetTradeRequestID() 
            { 
                return isSetField(Tags.TradeRequestID);
            }
            public QuickFix.Fields.TrdType trdType
            { 
                get 
                {
                    QuickFix.Fields.TrdType val = new QuickFix.Fields.TrdType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TrdType val) 
            { 
                this.trdType = val;
            }
            
            public QuickFix.Fields.TrdType get(QuickFix.Fields.TrdType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TrdType val) 
            { 
                return isSetTrdType();
            }
            
            public bool isSetTrdType() 
            { 
                return isSetField(Tags.TrdType);
            }
            public QuickFix.Fields.TrdSubType trdSubType
            { 
                get 
                {
                    QuickFix.Fields.TrdSubType val = new QuickFix.Fields.TrdSubType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TrdSubType val) 
            { 
                this.trdSubType = val;
            }
            
            public QuickFix.Fields.TrdSubType get(QuickFix.Fields.TrdSubType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TrdSubType val) 
            { 
                return isSetTrdSubType();
            }
            
            public bool isSetTrdSubType() 
            { 
                return isSetField(Tags.TrdSubType);
            }
            public QuickFix.Fields.SecondaryTrdType secondaryTrdType
            { 
                get 
                {
                    QuickFix.Fields.SecondaryTrdType val = new QuickFix.Fields.SecondaryTrdType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryTrdType val) 
            { 
                this.secondaryTrdType = val;
            }
            
            public QuickFix.Fields.SecondaryTrdType get(QuickFix.Fields.SecondaryTrdType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryTrdType val) 
            { 
                return isSetSecondaryTrdType();
            }
            
            public bool isSetSecondaryTrdType() 
            { 
                return isSetField(Tags.SecondaryTrdType);
            }
            public QuickFix.Fields.TransferReason transferReason
            { 
                get 
                {
                    QuickFix.Fields.TransferReason val = new QuickFix.Fields.TransferReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TransferReason val) 
            { 
                this.transferReason = val;
            }
            
            public QuickFix.Fields.TransferReason get(QuickFix.Fields.TransferReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TransferReason val) 
            { 
                return isSetTransferReason();
            }
            
            public bool isSetTransferReason() 
            { 
                return isSetField(Tags.TransferReason);
            }
            public QuickFix.Fields.ExecType execType
            { 
                get 
                {
                    QuickFix.Fields.ExecType val = new QuickFix.Fields.ExecType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecType val) 
            { 
                this.execType = val;
            }
            
            public QuickFix.Fields.ExecType get(QuickFix.Fields.ExecType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecType val) 
            { 
                return isSetExecType();
            }
            
            public bool isSetExecType() 
            { 
                return isSetField(Tags.ExecType);
            }
            public QuickFix.Fields.TotNumTradeReports totNumTradeReports
            { 
                get 
                {
                    QuickFix.Fields.TotNumTradeReports val = new QuickFix.Fields.TotNumTradeReports();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotNumTradeReports val) 
            { 
                this.totNumTradeReports = val;
            }
            
            public QuickFix.Fields.TotNumTradeReports get(QuickFix.Fields.TotNumTradeReports val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotNumTradeReports val) 
            { 
                return isSetTotNumTradeReports();
            }
            
            public bool isSetTotNumTradeReports() 
            { 
                return isSetField(Tags.TotNumTradeReports);
            }
            public QuickFix.Fields.LastRptRequested lastRptRequested
            { 
                get 
                {
                    QuickFix.Fields.LastRptRequested val = new QuickFix.Fields.LastRptRequested();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastRptRequested val) 
            { 
                this.lastRptRequested = val;
            }
            
            public QuickFix.Fields.LastRptRequested get(QuickFix.Fields.LastRptRequested val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastRptRequested val) 
            { 
                return isSetLastRptRequested();
            }
            
            public bool isSetLastRptRequested() 
            { 
                return isSetField(Tags.LastRptRequested);
            }
            public QuickFix.Fields.UnsolicitedIndicator unsolicitedIndicator
            { 
                get 
                {
                    QuickFix.Fields.UnsolicitedIndicator val = new QuickFix.Fields.UnsolicitedIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                this.unsolicitedIndicator = val;
            }
            
            public QuickFix.Fields.UnsolicitedIndicator get(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                return isSetUnsolicitedIndicator();
            }
            
            public bool isSetUnsolicitedIndicator() 
            { 
                return isSetField(Tags.UnsolicitedIndicator);
            }
            public QuickFix.Fields.SubscriptionRequestType subscriptionRequestType
            { 
                get 
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                this.subscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return isSetSubscriptionRequestType();
            }
            
            public bool isSetSubscriptionRequestType() 
            { 
                return isSetField(Tags.SubscriptionRequestType);
            }
            public QuickFix.Fields.TradeReportRefID tradeReportRefID
            { 
                get 
                {
                    QuickFix.Fields.TradeReportRefID val = new QuickFix.Fields.TradeReportRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeReportRefID val) 
            { 
                this.tradeReportRefID = val;
            }
            
            public QuickFix.Fields.TradeReportRefID get(QuickFix.Fields.TradeReportRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeReportRefID val) 
            { 
                return isSetTradeReportRefID();
            }
            
            public bool isSetTradeReportRefID() 
            { 
                return isSetField(Tags.TradeReportRefID);
            }
            public QuickFix.Fields.SecondaryTradeReportRefID secondaryTradeReportRefID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryTradeReportRefID val = new QuickFix.Fields.SecondaryTradeReportRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryTradeReportRefID val) 
            { 
                this.secondaryTradeReportRefID = val;
            }
            
            public QuickFix.Fields.SecondaryTradeReportRefID get(QuickFix.Fields.SecondaryTradeReportRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryTradeReportRefID val) 
            { 
                return isSetSecondaryTradeReportRefID();
            }
            
            public bool isSetSecondaryTradeReportRefID() 
            { 
                return isSetField(Tags.SecondaryTradeReportRefID);
            }
            public QuickFix.Fields.SecondaryTradeReportID secondaryTradeReportID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryTradeReportID val = new QuickFix.Fields.SecondaryTradeReportID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryTradeReportID val) 
            { 
                this.secondaryTradeReportID = val;
            }
            
            public QuickFix.Fields.SecondaryTradeReportID get(QuickFix.Fields.SecondaryTradeReportID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryTradeReportID val) 
            { 
                return isSetSecondaryTradeReportID();
            }
            
            public bool isSetSecondaryTradeReportID() 
            { 
                return isSetField(Tags.SecondaryTradeReportID);
            }
            public QuickFix.Fields.TradeLinkID tradeLinkID
            { 
                get 
                {
                    QuickFix.Fields.TradeLinkID val = new QuickFix.Fields.TradeLinkID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeLinkID val) 
            { 
                this.tradeLinkID = val;
            }
            
            public QuickFix.Fields.TradeLinkID get(QuickFix.Fields.TradeLinkID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeLinkID val) 
            { 
                return isSetTradeLinkID();
            }
            
            public bool isSetTradeLinkID() 
            { 
                return isSetField(Tags.TradeLinkID);
            }
            public QuickFix.Fields.TrdMatchID trdMatchID
            { 
                get 
                {
                    QuickFix.Fields.TrdMatchID val = new QuickFix.Fields.TrdMatchID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TrdMatchID val) 
            { 
                this.trdMatchID = val;
            }
            
            public QuickFix.Fields.TrdMatchID get(QuickFix.Fields.TrdMatchID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TrdMatchID val) 
            { 
                return isSetTrdMatchID();
            }
            
            public bool isSetTrdMatchID() 
            { 
                return isSetField(Tags.TrdMatchID);
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
            public QuickFix.Fields.SecondaryExecID secondaryExecID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryExecID val = new QuickFix.Fields.SecondaryExecID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryExecID val) 
            { 
                this.secondaryExecID = val;
            }
            
            public QuickFix.Fields.SecondaryExecID get(QuickFix.Fields.SecondaryExecID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryExecID val) 
            { 
                return isSetSecondaryExecID();
            }
            
            public bool isSetSecondaryExecID() 
            { 
                return isSetField(Tags.SecondaryExecID);
            }
            public QuickFix.Fields.ExecRestatementReason execRestatementReason
            { 
                get 
                {
                    QuickFix.Fields.ExecRestatementReason val = new QuickFix.Fields.ExecRestatementReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecRestatementReason val) 
            { 
                this.execRestatementReason = val;
            }
            
            public QuickFix.Fields.ExecRestatementReason get(QuickFix.Fields.ExecRestatementReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecRestatementReason val) 
            { 
                return isSetExecRestatementReason();
            }
            
            public bool isSetExecRestatementReason() 
            { 
                return isSetField(Tags.ExecRestatementReason);
            }
            public QuickFix.Fields.PreviouslyReported previouslyReported
            { 
                get 
                {
                    QuickFix.Fields.PreviouslyReported val = new QuickFix.Fields.PreviouslyReported();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PreviouslyReported val) 
            { 
                this.previouslyReported = val;
            }
            
            public QuickFix.Fields.PreviouslyReported get(QuickFix.Fields.PreviouslyReported val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PreviouslyReported val) 
            { 
                return isSetPreviouslyReported();
            }
            
            public bool isSetPreviouslyReported() 
            { 
                return isSetField(Tags.PreviouslyReported);
            }
            public QuickFix.Fields.PriceType priceType
            { 
                get 
                {
                    QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceType val) 
            { 
                this.priceType = val;
            }
            
            public QuickFix.Fields.PriceType get(QuickFix.Fields.PriceType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceType val) 
            { 
                return isSetPriceType();
            }
            
            public bool isSetPriceType() 
            { 
                return isSetField(Tags.PriceType);
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
            public QuickFix.Fields.SecurityIDSource securityIDSource
            { 
                get 
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityIDSource val) 
            { 
                this.securityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource get(QuickFix.Fields.SecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return isSetSecurityIDSource();
            }
            
            public bool isSetSecurityIDSource() 
            { 
                return isSetField(Tags.SecurityIDSource);
            }
            public QuickFix.Fields.NoSecurityAltID noSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                this.noSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return isSetNoSecurityAltID();
            }
            
            public bool isSetNoSecurityAltID() 
            { 
                return isSetField(Tags.NoSecurityAltID);
            }
            public QuickFix.Fields.Product product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Product val) 
            { 
                this.product = val;
            }
            
            public QuickFix.Fields.Product get(QuickFix.Fields.Product val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Product val) 
            { 
                return isSetProduct();
            }
            
            public bool isSetProduct() 
            { 
                return isSetField(Tags.Product);
            }
            public QuickFix.Fields.CFICode cFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CFICode val) 
            { 
                this.cFICode = val;
            }
            
            public QuickFix.Fields.CFICode get(QuickFix.Fields.CFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CFICode val) 
            { 
                return isSetCFICode();
            }
            
            public bool isSetCFICode() 
            { 
                return isSetField(Tags.CFICode);
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
            public QuickFix.Fields.SecuritySubType securitySubType
            { 
                get 
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySubType val) 
            { 
                this.securitySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType get(QuickFix.Fields.SecuritySubType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return isSetSecuritySubType();
            }
            
            public bool isSetSecuritySubType() 
            { 
                return isSetField(Tags.SecuritySubType);
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
            public QuickFix.Fields.MaturityDate maturityDate
            { 
                get 
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityDate val) 
            { 
                this.maturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate get(QuickFix.Fields.MaturityDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityDate val) 
            { 
                return isSetMaturityDate();
            }
            
            public bool isSetMaturityDate() 
            { 
                return isSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.CouponPaymentDate couponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                this.couponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return isSetCouponPaymentDate();
            }
            
            public bool isSetCouponPaymentDate() 
            { 
                return isSetField(Tags.CouponPaymentDate);
            }
            public QuickFix.Fields.IssueDate issueDate
            { 
                get 
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IssueDate val) 
            { 
                this.issueDate = val;
            }
            
            public QuickFix.Fields.IssueDate get(QuickFix.Fields.IssueDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IssueDate val) 
            { 
                return isSetIssueDate();
            }
            
            public bool isSetIssueDate() 
            { 
                return isSetField(Tags.IssueDate);
            }
            public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                this.repoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return isSetRepoCollateralSecurityType();
            }
            
            public bool isSetRepoCollateralSecurityType() 
            { 
                return isSetField(Tags.RepoCollateralSecurityType);
            }
            public QuickFix.Fields.RepurchaseTerm repurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                this.repurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return isSetRepurchaseTerm();
            }
            
            public bool isSetRepurchaseTerm() 
            { 
                return isSetField(Tags.RepurchaseTerm);
            }
            public QuickFix.Fields.RepurchaseRate repurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepurchaseRate val) 
            { 
                this.repurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate get(QuickFix.Fields.RepurchaseRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return isSetRepurchaseRate();
            }
            
            public bool isSetRepurchaseRate() 
            { 
                return isSetField(Tags.RepurchaseRate);
            }
            public QuickFix.Fields.Factor factor
            { 
                get 
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Factor val) 
            { 
                this.factor = val;
            }
            
            public QuickFix.Fields.Factor get(QuickFix.Fields.Factor val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Factor val) 
            { 
                return isSetFactor();
            }
            
            public bool isSetFactor() 
            { 
                return isSetField(Tags.Factor);
            }
            public QuickFix.Fields.CreditRating creditRating
            { 
                get 
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CreditRating val) 
            { 
                this.creditRating = val;
            }
            
            public QuickFix.Fields.CreditRating get(QuickFix.Fields.CreditRating val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CreditRating val) 
            { 
                return isSetCreditRating();
            }
            
            public bool isSetCreditRating() 
            { 
                return isSetField(Tags.CreditRating);
            }
            public QuickFix.Fields.InstrRegistry instrRegistry
            { 
                get 
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.InstrRegistry val) 
            { 
                this.instrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry get(QuickFix.Fields.InstrRegistry val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return isSetInstrRegistry();
            }
            
            public bool isSetInstrRegistry() 
            { 
                return isSetField(Tags.InstrRegistry);
            }
            public QuickFix.Fields.CountryOfIssue countryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CountryOfIssue val) 
            { 
                this.countryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue get(QuickFix.Fields.CountryOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return isSetCountryOfIssue();
            }
            
            public bool isSetCountryOfIssue() 
            { 
                return isSetField(Tags.CountryOfIssue);
            }
            public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                this.stateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return isSetStateOrProvinceOfIssue();
            }
            
            public bool isSetStateOrProvinceOfIssue() 
            { 
                return isSetField(Tags.StateOrProvinceOfIssue);
            }
            public QuickFix.Fields.LocaleOfIssue localeOfIssue
            { 
                get 
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                this.localeOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return isSetLocaleOfIssue();
            }
            
            public bool isSetLocaleOfIssue() 
            { 
                return isSetField(Tags.LocaleOfIssue);
            }
            public QuickFix.Fields.RedemptionDate redemptionDate
            { 
                get 
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RedemptionDate val) 
            { 
                this.redemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate get(QuickFix.Fields.RedemptionDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return isSetRedemptionDate();
            }
            
            public bool isSetRedemptionDate() 
            { 
                return isSetField(Tags.RedemptionDate);
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
            public QuickFix.Fields.StrikeCurrency strikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikeCurrency val) 
            { 
                this.strikeCurrency = val;
            }
            
            public QuickFix.Fields.StrikeCurrency get(QuickFix.Fields.StrikeCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikeCurrency val) 
            { 
                return isSetStrikeCurrency();
            }
            
            public bool isSetStrikeCurrency() 
            { 
                return isSetField(Tags.StrikeCurrency);
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
            public QuickFix.Fields.ContractMultiplier contractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ContractMultiplier val) 
            { 
                this.contractMultiplier = val;
            }
            
            public QuickFix.Fields.ContractMultiplier get(QuickFix.Fields.ContractMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ContractMultiplier val) 
            { 
                return isSetContractMultiplier();
            }
            
            public bool isSetContractMultiplier() 
            { 
                return isSetField(Tags.ContractMultiplier);
            }
            public QuickFix.Fields.CouponRate couponRate
            { 
                get 
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CouponRate val) 
            { 
                this.couponRate = val;
            }
            
            public QuickFix.Fields.CouponRate get(QuickFix.Fields.CouponRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CouponRate val) 
            { 
                return isSetCouponRate();
            }
            
            public bool isSetCouponRate() 
            { 
                return isSetField(Tags.CouponRate);
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
            public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                this.encodedIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedIssuerLen get(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                return isSetEncodedIssuerLen();
            }
            
            public bool isSetEncodedIssuerLen() 
            { 
                return isSetField(Tags.EncodedIssuerLen);
            }
            public QuickFix.Fields.EncodedIssuer encodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedIssuer val) 
            { 
                this.encodedIssuer = val;
            }
            
            public QuickFix.Fields.EncodedIssuer get(QuickFix.Fields.EncodedIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedIssuer val) 
            { 
                return isSetEncodedIssuer();
            }
            
            public bool isSetEncodedIssuer() 
            { 
                return isSetField(Tags.EncodedIssuer);
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
            public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                this.encodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen get(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                return isSetEncodedSecurityDescLen();
            }
            
            public bool isSetEncodedSecurityDescLen() 
            { 
                return isSetField(Tags.EncodedSecurityDescLen);
            }
            public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                this.encodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDesc get(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                return isSetEncodedSecurityDesc();
            }
            
            public bool isSetEncodedSecurityDesc() 
            { 
                return isSetField(Tags.EncodedSecurityDesc);
            }
            public QuickFix.Fields.Pool pool
            { 
                get 
                {
                    QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Pool val) 
            { 
                this.pool = val;
            }
            
            public QuickFix.Fields.Pool get(QuickFix.Fields.Pool val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Pool val) 
            { 
                return isSetPool();
            }
            
            public bool isSetPool() 
            { 
                return isSetField(Tags.Pool);
            }
            public QuickFix.Fields.ContractSettlMonth contractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ContractSettlMonth val) 
            { 
                this.contractSettlMonth = val;
            }
            
            public QuickFix.Fields.ContractSettlMonth get(QuickFix.Fields.ContractSettlMonth val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ContractSettlMonth val) 
            { 
                return isSetContractSettlMonth();
            }
            
            public bool isSetContractSettlMonth() 
            { 
                return isSetField(Tags.ContractSettlMonth);
            }
            public QuickFix.Fields.CPProgram cPProgram
            { 
                get 
                {
                    QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CPProgram val) 
            { 
                this.cPProgram = val;
            }
            
            public QuickFix.Fields.CPProgram get(QuickFix.Fields.CPProgram val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CPProgram val) 
            { 
                return isSetCPProgram();
            }
            
            public bool isSetCPProgram() 
            { 
                return isSetField(Tags.CPProgram);
            }
            public QuickFix.Fields.CPRegType cPRegType
            { 
                get 
                {
                    QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CPRegType val) 
            { 
                this.cPRegType = val;
            }
            
            public QuickFix.Fields.CPRegType get(QuickFix.Fields.CPRegType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CPRegType val) 
            { 
                return isSetCPRegType();
            }
            
            public bool isSetCPRegType() 
            { 
                return isSetField(Tags.CPRegType);
            }
            public QuickFix.Fields.NoEvents noEvents
            { 
                get 
                {
                    QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoEvents val) 
            { 
                this.noEvents = val;
            }
            
            public QuickFix.Fields.NoEvents get(QuickFix.Fields.NoEvents val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoEvents val) 
            { 
                return isSetNoEvents();
            }
            
            public bool isSetNoEvents() 
            { 
                return isSetField(Tags.NoEvents);
            }
            public QuickFix.Fields.DatedDate datedDate
            { 
                get 
                {
                    QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DatedDate val) 
            { 
                this.datedDate = val;
            }
            
            public QuickFix.Fields.DatedDate get(QuickFix.Fields.DatedDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DatedDate val) 
            { 
                return isSetDatedDate();
            }
            
            public bool isSetDatedDate() 
            { 
                return isSetField(Tags.DatedDate);
            }
            public QuickFix.Fields.InterestAccrualDate interestAccrualDate
            { 
                get 
                {
                    QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.InterestAccrualDate val) 
            { 
                this.interestAccrualDate = val;
            }
            
            public QuickFix.Fields.InterestAccrualDate get(QuickFix.Fields.InterestAccrualDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.InterestAccrualDate val) 
            { 
                return isSetInterestAccrualDate();
            }
            
            public bool isSetInterestAccrualDate() 
            { 
                return isSetField(Tags.InterestAccrualDate);
            }
            public QuickFix.Fields.SecurityStatus securityStatus
            { 
                get 
                {
                    QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityStatus val) 
            { 
                this.securityStatus = val;
            }
            
            public QuickFix.Fields.SecurityStatus get(QuickFix.Fields.SecurityStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityStatus val) 
            { 
                return isSetSecurityStatus();
            }
            
            public bool isSetSecurityStatus() 
            { 
                return isSetField(Tags.SecurityStatus);
            }
            public QuickFix.Fields.SettleOnOpenFlag settleOnOpenFlag
            { 
                get 
                {
                    QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                this.settleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.SettleOnOpenFlag get(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                return isSetSettleOnOpenFlag();
            }
            
            public bool isSetSettleOnOpenFlag() 
            { 
                return isSetField(Tags.SettleOnOpenFlag);
            }
            public QuickFix.Fields.InstrmtAssignmentMethod instrmtAssignmentMethod
            { 
                get 
                {
                    QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                this.instrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.InstrmtAssignmentMethod get(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                return isSetInstrmtAssignmentMethod();
            }
            
            public bool isSetInstrmtAssignmentMethod() 
            { 
                return isSetField(Tags.InstrmtAssignmentMethod);
            }
            public QuickFix.Fields.StrikeMultiplier strikeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikeMultiplier val) 
            { 
                this.strikeMultiplier = val;
            }
            
            public QuickFix.Fields.StrikeMultiplier get(QuickFix.Fields.StrikeMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikeMultiplier val) 
            { 
                return isSetStrikeMultiplier();
            }
            
            public bool isSetStrikeMultiplier() 
            { 
                return isSetField(Tags.StrikeMultiplier);
            }
            public QuickFix.Fields.StrikeValue strikeValue
            { 
                get 
                {
                    QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikeValue val) 
            { 
                this.strikeValue = val;
            }
            
            public QuickFix.Fields.StrikeValue get(QuickFix.Fields.StrikeValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikeValue val) 
            { 
                return isSetStrikeValue();
            }
            
            public bool isSetStrikeValue() 
            { 
                return isSetField(Tags.StrikeValue);
            }
            public QuickFix.Fields.MinPriceIncrement minPriceIncrement
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MinPriceIncrement val) 
            { 
                this.minPriceIncrement = val;
            }
            
            public QuickFix.Fields.MinPriceIncrement get(QuickFix.Fields.MinPriceIncrement val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MinPriceIncrement val) 
            { 
                return isSetMinPriceIncrement();
            }
            
            public bool isSetMinPriceIncrement() 
            { 
                return isSetField(Tags.MinPriceIncrement);
            }
            public QuickFix.Fields.PositionLimit positionLimit
            { 
                get 
                {
                    QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PositionLimit val) 
            { 
                this.positionLimit = val;
            }
            
            public QuickFix.Fields.PositionLimit get(QuickFix.Fields.PositionLimit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PositionLimit val) 
            { 
                return isSetPositionLimit();
            }
            
            public bool isSetPositionLimit() 
            { 
                return isSetField(Tags.PositionLimit);
            }
            public QuickFix.Fields.NTPositionLimit nTPositionLimit
            { 
                get 
                {
                    QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NTPositionLimit val) 
            { 
                this.nTPositionLimit = val;
            }
            
            public QuickFix.Fields.NTPositionLimit get(QuickFix.Fields.NTPositionLimit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NTPositionLimit val) 
            { 
                return isSetNTPositionLimit();
            }
            
            public bool isSetNTPositionLimit() 
            { 
                return isSetField(Tags.NTPositionLimit);
            }
            public QuickFix.Fields.NoInstrumentParties noInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoInstrumentParties val) 
            { 
                this.noInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoInstrumentParties get(QuickFix.Fields.NoInstrumentParties val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoInstrumentParties val) 
            { 
                return isSetNoInstrumentParties();
            }
            
            public bool isSetNoInstrumentParties() 
            { 
                return isSetField(Tags.NoInstrumentParties);
            }
            public QuickFix.Fields.UnitOfMeasure unitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnitOfMeasure val) 
            { 
                this.unitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnitOfMeasure get(QuickFix.Fields.UnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnitOfMeasure val) 
            { 
                return isSetUnitOfMeasure();
            }
            
            public bool isSetUnitOfMeasure() 
            { 
                return isSetField(Tags.UnitOfMeasure);
            }
            public QuickFix.Fields.TimeUnit timeUnit
            { 
                get 
                {
                    QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TimeUnit val) 
            { 
                this.timeUnit = val;
            }
            
            public QuickFix.Fields.TimeUnit get(QuickFix.Fields.TimeUnit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TimeUnit val) 
            { 
                return isSetTimeUnit();
            }
            
            public bool isSetTimeUnit() 
            { 
                return isSetField(Tags.TimeUnit);
            }
            public QuickFix.Fields.MaturityTime maturityTime
            { 
                get 
                {
                    QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityTime val) 
            { 
                this.maturityTime = val;
            }
            
            public QuickFix.Fields.MaturityTime get(QuickFix.Fields.MaturityTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityTime val) 
            { 
                return isSetMaturityTime();
            }
            
            public bool isSetMaturityTime() 
            { 
                return isSetField(Tags.MaturityTime);
            }
            public QuickFix.Fields.SecurityGroup securityGroup
            { 
                get 
                {
                    QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityGroup val) 
            { 
                this.securityGroup = val;
            }
            
            public QuickFix.Fields.SecurityGroup get(QuickFix.Fields.SecurityGroup val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityGroup val) 
            { 
                return isSetSecurityGroup();
            }
            
            public bool isSetSecurityGroup() 
            { 
                return isSetField(Tags.SecurityGroup);
            }
            public QuickFix.Fields.MinPriceIncrementAmount minPriceIncrementAmount
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                this.minPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.MinPriceIncrementAmount get(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                return isSetMinPriceIncrementAmount();
            }
            
            public bool isSetMinPriceIncrementAmount() 
            { 
                return isSetField(Tags.MinPriceIncrementAmount);
            }
            public QuickFix.Fields.UnitOfMeasureQty unitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                this.unitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnitOfMeasureQty get(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                return isSetUnitOfMeasureQty();
            }
            
            public bool isSetUnitOfMeasureQty() 
            { 
                return isSetField(Tags.UnitOfMeasureQty);
            }
            public QuickFix.Fields.SecurityXMLLen securityXMLLen
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityXMLLen val) 
            { 
                this.securityXMLLen = val;
            }
            
            public QuickFix.Fields.SecurityXMLLen get(QuickFix.Fields.SecurityXMLLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityXMLLen val) 
            { 
                return isSetSecurityXMLLen();
            }
            
            public bool isSetSecurityXMLLen() 
            { 
                return isSetField(Tags.SecurityXMLLen);
            }
            public QuickFix.Fields.SecurityXML securityXML
            { 
                get 
                {
                    QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityXML val) 
            { 
                this.securityXML = val;
            }
            
            public QuickFix.Fields.SecurityXML get(QuickFix.Fields.SecurityXML val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityXML val) 
            { 
                return isSetSecurityXML();
            }
            
            public bool isSetSecurityXML() 
            { 
                return isSetField(Tags.SecurityXML);
            }
            public QuickFix.Fields.SecurityXMLSchema securityXMLSchema
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                this.securityXMLSchema = val;
            }
            
            public QuickFix.Fields.SecurityXMLSchema get(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                return isSetSecurityXMLSchema();
            }
            
            public bool isSetSecurityXMLSchema() 
            { 
                return isSetField(Tags.SecurityXMLSchema);
            }
            public QuickFix.Fields.ProductComplex productComplex
            { 
                get 
                {
                    QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ProductComplex val) 
            { 
                this.productComplex = val;
            }
            
            public QuickFix.Fields.ProductComplex get(QuickFix.Fields.ProductComplex val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ProductComplex val) 
            { 
                return isSetProductComplex();
            }
            
            public bool isSetProductComplex() 
            { 
                return isSetField(Tags.ProductComplex);
            }
            public QuickFix.Fields.PriceUnitOfMeasure priceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                this.priceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasure get(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                return isSetPriceUnitOfMeasure();
            }
            
            public bool isSetPriceUnitOfMeasure() 
            { 
                return isSetField(Tags.PriceUnitOfMeasure);
            }
            public QuickFix.Fields.PriceUnitOfMeasureQty priceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                this.priceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasureQty get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                return isSetPriceUnitOfMeasureQty();
            }
            
            public bool isSetPriceUnitOfMeasureQty() 
            { 
                return isSetField(Tags.PriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.SettlMethod settlMethod
            { 
                get 
                {
                    QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlMethod val) 
            { 
                this.settlMethod = val;
            }
            
            public QuickFix.Fields.SettlMethod get(QuickFix.Fields.SettlMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlMethod val) 
            { 
                return isSetSettlMethod();
            }
            
            public bool isSetSettlMethod() 
            { 
                return isSetField(Tags.SettlMethod);
            }
            public QuickFix.Fields.ExerciseStyle exerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExerciseStyle val) 
            { 
                this.exerciseStyle = val;
            }
            
            public QuickFix.Fields.ExerciseStyle get(QuickFix.Fields.ExerciseStyle val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExerciseStyle val) 
            { 
                return isSetExerciseStyle();
            }
            
            public bool isSetExerciseStyle() 
            { 
                return isSetField(Tags.ExerciseStyle);
            }
            public QuickFix.Fields.OptPayAmount optPayAmount
            { 
                get 
                {
                    QuickFix.Fields.OptPayAmount val = new QuickFix.Fields.OptPayAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OptPayAmount val) 
            { 
                this.optPayAmount = val;
            }
            
            public QuickFix.Fields.OptPayAmount get(QuickFix.Fields.OptPayAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OptPayAmount val) 
            { 
                return isSetOptPayAmount();
            }
            
            public bool isSetOptPayAmount() 
            { 
                return isSetField(Tags.OptPayAmount);
            }
            public QuickFix.Fields.PriceQuoteMethod priceQuoteMethod
            { 
                get 
                {
                    QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                this.priceQuoteMethod = val;
            }
            
            public QuickFix.Fields.PriceQuoteMethod get(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                return isSetPriceQuoteMethod();
            }
            
            public bool isSetPriceQuoteMethod() 
            { 
                return isSetField(Tags.PriceQuoteMethod);
            }
            public QuickFix.Fields.ListMethod listMethod
            { 
                get 
                {
                    QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListMethod val) 
            { 
                this.listMethod = val;
            }
            
            public QuickFix.Fields.ListMethod get(QuickFix.Fields.ListMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListMethod val) 
            { 
                return isSetListMethod();
            }
            
            public bool isSetListMethod() 
            { 
                return isSetField(Tags.ListMethod);
            }
            public QuickFix.Fields.CapPrice capPrice
            { 
                get 
                {
                    QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CapPrice val) 
            { 
                this.capPrice = val;
            }
            
            public QuickFix.Fields.CapPrice get(QuickFix.Fields.CapPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CapPrice val) 
            { 
                return isSetCapPrice();
            }
            
            public bool isSetCapPrice() 
            { 
                return isSetField(Tags.CapPrice);
            }
            public QuickFix.Fields.FloorPrice floorPrice
            { 
                get 
                {
                    QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FloorPrice val) 
            { 
                this.floorPrice = val;
            }
            
            public QuickFix.Fields.FloorPrice get(QuickFix.Fields.FloorPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FloorPrice val) 
            { 
                return isSetFloorPrice();
            }
            
            public bool isSetFloorPrice() 
            { 
                return isSetField(Tags.FloorPrice);
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
            public QuickFix.Fields.FlexibleIndicator flexibleIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FlexibleIndicator val) 
            { 
                this.flexibleIndicator = val;
            }
            
            public QuickFix.Fields.FlexibleIndicator get(QuickFix.Fields.FlexibleIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FlexibleIndicator val) 
            { 
                return isSetFlexibleIndicator();
            }
            
            public bool isSetFlexibleIndicator() 
            { 
                return isSetField(Tags.FlexibleIndicator);
            }
            public QuickFix.Fields.FlexProductEligibilityIndicator flexProductEligibilityIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                this.flexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.FlexProductEligibilityIndicator get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                return isSetFlexProductEligibilityIndicator();
            }
            
            public bool isSetFlexProductEligibilityIndicator() 
            { 
                return isSetField(Tags.FlexProductEligibilityIndicator);
            }
            public QuickFix.Fields.FuturesValuationMethod futuresValuationMethod
            { 
                get 
                {
                    QuickFix.Fields.FuturesValuationMethod val = new QuickFix.Fields.FuturesValuationMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                this.futuresValuationMethod = val;
            }
            
            public QuickFix.Fields.FuturesValuationMethod get(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                return isSetFuturesValuationMethod();
            }
            
            public bool isSetFuturesValuationMethod() 
            { 
                return isSetField(Tags.FuturesValuationMethod);
            }
            public QuickFix.Fields.AgreementDesc agreementDesc
            { 
                get 
                {
                    QuickFix.Fields.AgreementDesc val = new QuickFix.Fields.AgreementDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AgreementDesc val) 
            { 
                this.agreementDesc = val;
            }
            
            public QuickFix.Fields.AgreementDesc get(QuickFix.Fields.AgreementDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AgreementDesc val) 
            { 
                return isSetAgreementDesc();
            }
            
            public bool isSetAgreementDesc() 
            { 
                return isSetField(Tags.AgreementDesc);
            }
            public QuickFix.Fields.AgreementID agreementID
            { 
                get 
                {
                    QuickFix.Fields.AgreementID val = new QuickFix.Fields.AgreementID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AgreementID val) 
            { 
                this.agreementID = val;
            }
            
            public QuickFix.Fields.AgreementID get(QuickFix.Fields.AgreementID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AgreementID val) 
            { 
                return isSetAgreementID();
            }
            
            public bool isSetAgreementID() 
            { 
                return isSetField(Tags.AgreementID);
            }
            public QuickFix.Fields.AgreementDate agreementDate
            { 
                get 
                {
                    QuickFix.Fields.AgreementDate val = new QuickFix.Fields.AgreementDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AgreementDate val) 
            { 
                this.agreementDate = val;
            }
            
            public QuickFix.Fields.AgreementDate get(QuickFix.Fields.AgreementDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AgreementDate val) 
            { 
                return isSetAgreementDate();
            }
            
            public bool isSetAgreementDate() 
            { 
                return isSetField(Tags.AgreementDate);
            }
            public QuickFix.Fields.AgreementCurrency agreementCurrency
            { 
                get 
                {
                    QuickFix.Fields.AgreementCurrency val = new QuickFix.Fields.AgreementCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AgreementCurrency val) 
            { 
                this.agreementCurrency = val;
            }
            
            public QuickFix.Fields.AgreementCurrency get(QuickFix.Fields.AgreementCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AgreementCurrency val) 
            { 
                return isSetAgreementCurrency();
            }
            
            public bool isSetAgreementCurrency() 
            { 
                return isSetField(Tags.AgreementCurrency);
            }
            public QuickFix.Fields.TerminationType terminationType
            { 
                get 
                {
                    QuickFix.Fields.TerminationType val = new QuickFix.Fields.TerminationType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TerminationType val) 
            { 
                this.terminationType = val;
            }
            
            public QuickFix.Fields.TerminationType get(QuickFix.Fields.TerminationType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TerminationType val) 
            { 
                return isSetTerminationType();
            }
            
            public bool isSetTerminationType() 
            { 
                return isSetField(Tags.TerminationType);
            }
            public QuickFix.Fields.StartDate startDate
            { 
                get 
                {
                    QuickFix.Fields.StartDate val = new QuickFix.Fields.StartDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StartDate val) 
            { 
                this.startDate = val;
            }
            
            public QuickFix.Fields.StartDate get(QuickFix.Fields.StartDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StartDate val) 
            { 
                return isSetStartDate();
            }
            
            public bool isSetStartDate() 
            { 
                return isSetField(Tags.StartDate);
            }
            public QuickFix.Fields.EndDate endDate
            { 
                get 
                {
                    QuickFix.Fields.EndDate val = new QuickFix.Fields.EndDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EndDate val) 
            { 
                this.endDate = val;
            }
            
            public QuickFix.Fields.EndDate get(QuickFix.Fields.EndDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EndDate val) 
            { 
                return isSetEndDate();
            }
            
            public bool isSetEndDate() 
            { 
                return isSetField(Tags.EndDate);
            }
            public QuickFix.Fields.DeliveryType deliveryType
            { 
                get 
                {
                    QuickFix.Fields.DeliveryType val = new QuickFix.Fields.DeliveryType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DeliveryType val) 
            { 
                this.deliveryType = val;
            }
            
            public QuickFix.Fields.DeliveryType get(QuickFix.Fields.DeliveryType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DeliveryType val) 
            { 
                return isSetDeliveryType();
            }
            
            public bool isSetDeliveryType() 
            { 
                return isSetField(Tags.DeliveryType);
            }
            public QuickFix.Fields.MarginRatio marginRatio
            { 
                get 
                {
                    QuickFix.Fields.MarginRatio val = new QuickFix.Fields.MarginRatio();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarginRatio val) 
            { 
                this.marginRatio = val;
            }
            
            public QuickFix.Fields.MarginRatio get(QuickFix.Fields.MarginRatio val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarginRatio val) 
            { 
                return isSetMarginRatio();
            }
            
            public bool isSetMarginRatio() 
            { 
                return isSetField(Tags.MarginRatio);
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
            public QuickFix.Fields.CashOrderQty cashOrderQty
            { 
                get 
                {
                    QuickFix.Fields.CashOrderQty val = new QuickFix.Fields.CashOrderQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CashOrderQty val) 
            { 
                this.cashOrderQty = val;
            }
            
            public QuickFix.Fields.CashOrderQty get(QuickFix.Fields.CashOrderQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CashOrderQty val) 
            { 
                return isSetCashOrderQty();
            }
            
            public bool isSetCashOrderQty() 
            { 
                return isSetField(Tags.CashOrderQty);
            }
            public QuickFix.Fields.OrderPercent orderPercent
            { 
                get 
                {
                    QuickFix.Fields.OrderPercent val = new QuickFix.Fields.OrderPercent();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrderPercent val) 
            { 
                this.orderPercent = val;
            }
            
            public QuickFix.Fields.OrderPercent get(QuickFix.Fields.OrderPercent val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrderPercent val) 
            { 
                return isSetOrderPercent();
            }
            
            public bool isSetOrderPercent() 
            { 
                return isSetField(Tags.OrderPercent);
            }
            public QuickFix.Fields.RoundingDirection roundingDirection
            { 
                get 
                {
                    QuickFix.Fields.RoundingDirection val = new QuickFix.Fields.RoundingDirection();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RoundingDirection val) 
            { 
                this.roundingDirection = val;
            }
            
            public QuickFix.Fields.RoundingDirection get(QuickFix.Fields.RoundingDirection val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RoundingDirection val) 
            { 
                return isSetRoundingDirection();
            }
            
            public bool isSetRoundingDirection() 
            { 
                return isSetField(Tags.RoundingDirection);
            }
            public QuickFix.Fields.RoundingModulus roundingModulus
            { 
                get 
                {
                    QuickFix.Fields.RoundingModulus val = new QuickFix.Fields.RoundingModulus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RoundingModulus val) 
            { 
                this.roundingModulus = val;
            }
            
            public QuickFix.Fields.RoundingModulus get(QuickFix.Fields.RoundingModulus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RoundingModulus val) 
            { 
                return isSetRoundingModulus();
            }
            
            public bool isSetRoundingModulus() 
            { 
                return isSetField(Tags.RoundingModulus);
            }
            public QuickFix.Fields.QtyType qtyType
            { 
                get 
                {
                    QuickFix.Fields.QtyType val = new QuickFix.Fields.QtyType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.QtyType val) 
            { 
                this.qtyType = val;
            }
            
            public QuickFix.Fields.QtyType get(QuickFix.Fields.QtyType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.QtyType val) 
            { 
                return isSetQtyType();
            }
            
            public bool isSetQtyType() 
            { 
                return isSetField(Tags.QtyType);
            }
            public QuickFix.Fields.YieldType yieldType
            { 
                get 
                {
                    QuickFix.Fields.YieldType val = new QuickFix.Fields.YieldType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.YieldType val) 
            { 
                this.yieldType = val;
            }
            
            public QuickFix.Fields.YieldType get(QuickFix.Fields.YieldType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.YieldType val) 
            { 
                return isSetYieldType();
            }
            
            public bool isSetYieldType() 
            { 
                return isSetField(Tags.YieldType);
            }
            public QuickFix.Fields.Yield yield
            { 
                get 
                {
                    QuickFix.Fields.Yield val = new QuickFix.Fields.Yield();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Yield val) 
            { 
                this.yield = val;
            }
            
            public QuickFix.Fields.Yield get(QuickFix.Fields.Yield val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Yield val) 
            { 
                return isSetYield();
            }
            
            public bool isSetYield() 
            { 
                return isSetField(Tags.Yield);
            }
            public QuickFix.Fields.YieldCalcDate yieldCalcDate
            { 
                get 
                {
                    QuickFix.Fields.YieldCalcDate val = new QuickFix.Fields.YieldCalcDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.YieldCalcDate val) 
            { 
                this.yieldCalcDate = val;
            }
            
            public QuickFix.Fields.YieldCalcDate get(QuickFix.Fields.YieldCalcDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.YieldCalcDate val) 
            { 
                return isSetYieldCalcDate();
            }
            
            public bool isSetYieldCalcDate() 
            { 
                return isSetField(Tags.YieldCalcDate);
            }
            public QuickFix.Fields.YieldRedemptionDate yieldRedemptionDate
            { 
                get 
                {
                    QuickFix.Fields.YieldRedemptionDate val = new QuickFix.Fields.YieldRedemptionDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                this.yieldRedemptionDate = val;
            }
            
            public QuickFix.Fields.YieldRedemptionDate get(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                return isSetYieldRedemptionDate();
            }
            
            public bool isSetYieldRedemptionDate() 
            { 
                return isSetField(Tags.YieldRedemptionDate);
            }
            public QuickFix.Fields.YieldRedemptionPrice yieldRedemptionPrice
            { 
                get 
                {
                    QuickFix.Fields.YieldRedemptionPrice val = new QuickFix.Fields.YieldRedemptionPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                this.yieldRedemptionPrice = val;
            }
            
            public QuickFix.Fields.YieldRedemptionPrice get(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                return isSetYieldRedemptionPrice();
            }
            
            public bool isSetYieldRedemptionPrice() 
            { 
                return isSetField(Tags.YieldRedemptionPrice);
            }
            public QuickFix.Fields.YieldRedemptionPriceType yieldRedemptionPriceType
            { 
                get 
                {
                    QuickFix.Fields.YieldRedemptionPriceType val = new QuickFix.Fields.YieldRedemptionPriceType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                this.yieldRedemptionPriceType = val;
            }
            
            public QuickFix.Fields.YieldRedemptionPriceType get(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                return isSetYieldRedemptionPriceType();
            }
            
            public bool isSetYieldRedemptionPriceType() 
            { 
                return isSetField(Tags.YieldRedemptionPriceType);
            }
            public QuickFix.Fields.NoUnderlyings noUnderlyings
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyings val = new QuickFix.Fields.NoUnderlyings();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoUnderlyings val) 
            { 
                this.noUnderlyings = val;
            }
            
            public QuickFix.Fields.NoUnderlyings get(QuickFix.Fields.NoUnderlyings val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoUnderlyings val) 
            { 
                return isSetNoUnderlyings();
            }
            
            public bool isSetNoUnderlyings() 
            { 
                return isSetField(Tags.NoUnderlyings);
            }
            public QuickFix.Fields.UnderlyingTradingSessionID underlyingTradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingTradingSessionID val = new QuickFix.Fields.UnderlyingTradingSessionID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingTradingSessionID val) 
            { 
                this.underlyingTradingSessionID = val;
            }
            
            public QuickFix.Fields.UnderlyingTradingSessionID get(QuickFix.Fields.UnderlyingTradingSessionID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingTradingSessionID val) 
            { 
                return isSetUnderlyingTradingSessionID();
            }
            
            public bool isSetUnderlyingTradingSessionID() 
            { 
                return isSetField(Tags.UnderlyingTradingSessionID);
            }
            public QuickFix.Fields.UnderlyingTradingSessionSubID underlyingTradingSessionSubID
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingTradingSessionSubID val = new QuickFix.Fields.UnderlyingTradingSessionSubID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingTradingSessionSubID val) 
            { 
                this.underlyingTradingSessionSubID = val;
            }
            
            public QuickFix.Fields.UnderlyingTradingSessionSubID get(QuickFix.Fields.UnderlyingTradingSessionSubID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingTradingSessionSubID val) 
            { 
                return isSetUnderlyingTradingSessionSubID();
            }
            
            public bool isSetUnderlyingTradingSessionSubID() 
            { 
                return isSetField(Tags.UnderlyingTradingSessionSubID);
            }
            public QuickFix.Fields.LastQty lastQty
            { 
                get 
                {
                    QuickFix.Fields.LastQty val = new QuickFix.Fields.LastQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastQty val) 
            { 
                this.lastQty = val;
            }
            
            public QuickFix.Fields.LastQty get(QuickFix.Fields.LastQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastQty val) 
            { 
                return isSetLastQty();
            }
            
            public bool isSetLastQty() 
            { 
                return isSetField(Tags.LastQty);
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
            public QuickFix.Fields.LastParPx lastParPx
            { 
                get 
                {
                    QuickFix.Fields.LastParPx val = new QuickFix.Fields.LastParPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastParPx val) 
            { 
                this.lastParPx = val;
            }
            
            public QuickFix.Fields.LastParPx get(QuickFix.Fields.LastParPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastParPx val) 
            { 
                return isSetLastParPx();
            }
            
            public bool isSetLastParPx() 
            { 
                return isSetField(Tags.LastParPx);
            }
            public QuickFix.Fields.LastSpotRate lastSpotRate
            { 
                get 
                {
                    QuickFix.Fields.LastSpotRate val = new QuickFix.Fields.LastSpotRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastSpotRate val) 
            { 
                this.lastSpotRate = val;
            }
            
            public QuickFix.Fields.LastSpotRate get(QuickFix.Fields.LastSpotRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastSpotRate val) 
            { 
                return isSetLastSpotRate();
            }
            
            public bool isSetLastSpotRate() 
            { 
                return isSetField(Tags.LastSpotRate);
            }
            public QuickFix.Fields.LastForwardPoints lastForwardPoints
            { 
                get 
                {
                    QuickFix.Fields.LastForwardPoints val = new QuickFix.Fields.LastForwardPoints();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastForwardPoints val) 
            { 
                this.lastForwardPoints = val;
            }
            
            public QuickFix.Fields.LastForwardPoints get(QuickFix.Fields.LastForwardPoints val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastForwardPoints val) 
            { 
                return isSetLastForwardPoints();
            }
            
            public bool isSetLastForwardPoints() 
            { 
                return isSetField(Tags.LastForwardPoints);
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
            public QuickFix.Fields.ClearingBusinessDate clearingBusinessDate
            { 
                get 
                {
                    QuickFix.Fields.ClearingBusinessDate val = new QuickFix.Fields.ClearingBusinessDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                this.clearingBusinessDate = val;
            }
            
            public QuickFix.Fields.ClearingBusinessDate get(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                return isSetClearingBusinessDate();
            }
            
            public bool isSetClearingBusinessDate() 
            { 
                return isSetField(Tags.ClearingBusinessDate);
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
            public QuickFix.Fields.Spread spread
            { 
                get 
                {
                    QuickFix.Fields.Spread val = new QuickFix.Fields.Spread();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Spread val) 
            { 
                this.spread = val;
            }
            
            public QuickFix.Fields.Spread get(QuickFix.Fields.Spread val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Spread val) 
            { 
                return isSetSpread();
            }
            
            public bool isSetSpread() 
            { 
                return isSetField(Tags.Spread);
            }
            public QuickFix.Fields.BenchmarkCurveCurrency benchmarkCurveCurrency
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkCurveCurrency val = new QuickFix.Fields.BenchmarkCurveCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                this.benchmarkCurveCurrency = val;
            }
            
            public QuickFix.Fields.BenchmarkCurveCurrency get(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                return isSetBenchmarkCurveCurrency();
            }
            
            public bool isSetBenchmarkCurveCurrency() 
            { 
                return isSetField(Tags.BenchmarkCurveCurrency);
            }
            public QuickFix.Fields.BenchmarkCurveName benchmarkCurveName
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkCurveName val = new QuickFix.Fields.BenchmarkCurveName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                this.benchmarkCurveName = val;
            }
            
            public QuickFix.Fields.BenchmarkCurveName get(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                return isSetBenchmarkCurveName();
            }
            
            public bool isSetBenchmarkCurveName() 
            { 
                return isSetField(Tags.BenchmarkCurveName);
            }
            public QuickFix.Fields.BenchmarkCurvePoint benchmarkCurvePoint
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkCurvePoint val = new QuickFix.Fields.BenchmarkCurvePoint();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                this.benchmarkCurvePoint = val;
            }
            
            public QuickFix.Fields.BenchmarkCurvePoint get(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                return isSetBenchmarkCurvePoint();
            }
            
            public bool isSetBenchmarkCurvePoint() 
            { 
                return isSetField(Tags.BenchmarkCurvePoint);
            }
            public QuickFix.Fields.BenchmarkPrice benchmarkPrice
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkPrice val = new QuickFix.Fields.BenchmarkPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BenchmarkPrice val) 
            { 
                this.benchmarkPrice = val;
            }
            
            public QuickFix.Fields.BenchmarkPrice get(QuickFix.Fields.BenchmarkPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BenchmarkPrice val) 
            { 
                return isSetBenchmarkPrice();
            }
            
            public bool isSetBenchmarkPrice() 
            { 
                return isSetField(Tags.BenchmarkPrice);
            }
            public QuickFix.Fields.BenchmarkPriceType benchmarkPriceType
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkPriceType val = new QuickFix.Fields.BenchmarkPriceType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                this.benchmarkPriceType = val;
            }
            
            public QuickFix.Fields.BenchmarkPriceType get(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                return isSetBenchmarkPriceType();
            }
            
            public bool isSetBenchmarkPriceType() 
            { 
                return isSetField(Tags.BenchmarkPriceType);
            }
            public QuickFix.Fields.BenchmarkSecurityID benchmarkSecurityID
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkSecurityID val = new QuickFix.Fields.BenchmarkSecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                this.benchmarkSecurityID = val;
            }
            
            public QuickFix.Fields.BenchmarkSecurityID get(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                return isSetBenchmarkSecurityID();
            }
            
            public bool isSetBenchmarkSecurityID() 
            { 
                return isSetField(Tags.BenchmarkSecurityID);
            }
            public QuickFix.Fields.BenchmarkSecurityIDSource benchmarkSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkSecurityIDSource val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                this.benchmarkSecurityIDSource = val;
            }
            
            public QuickFix.Fields.BenchmarkSecurityIDSource get(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                return isSetBenchmarkSecurityIDSource();
            }
            
            public bool isSetBenchmarkSecurityIDSource() 
            { 
                return isSetField(Tags.BenchmarkSecurityIDSource);
            }
            public QuickFix.Fields.AvgPxIndicator avgPxIndicator
            { 
                get 
                {
                    QuickFix.Fields.AvgPxIndicator val = new QuickFix.Fields.AvgPxIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AvgPxIndicator val) 
            { 
                this.avgPxIndicator = val;
            }
            
            public QuickFix.Fields.AvgPxIndicator get(QuickFix.Fields.AvgPxIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AvgPxIndicator val) 
            { 
                return isSetAvgPxIndicator();
            }
            
            public bool isSetAvgPxIndicator() 
            { 
                return isSetField(Tags.AvgPxIndicator);
            }
            public QuickFix.Fields.NoPosAmt noPosAmt
            { 
                get 
                {
                    QuickFix.Fields.NoPosAmt val = new QuickFix.Fields.NoPosAmt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoPosAmt val) 
            { 
                this.noPosAmt = val;
            }
            
            public QuickFix.Fields.NoPosAmt get(QuickFix.Fields.NoPosAmt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoPosAmt val) 
            { 
                return isSetNoPosAmt();
            }
            
            public bool isSetNoPosAmt() 
            { 
                return isSetField(Tags.NoPosAmt);
            }
            public QuickFix.Fields.MultiLegReportingType multiLegReportingType
            { 
                get 
                {
                    QuickFix.Fields.MultiLegReportingType val = new QuickFix.Fields.MultiLegReportingType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MultiLegReportingType val) 
            { 
                this.multiLegReportingType = val;
            }
            
            public QuickFix.Fields.MultiLegReportingType get(QuickFix.Fields.MultiLegReportingType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MultiLegReportingType val) 
            { 
                return isSetMultiLegReportingType();
            }
            
            public bool isSetMultiLegReportingType() 
            { 
                return isSetField(Tags.MultiLegReportingType);
            }
            public QuickFix.Fields.TradeLegRefID tradeLegRefID
            { 
                get 
                {
                    QuickFix.Fields.TradeLegRefID val = new QuickFix.Fields.TradeLegRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeLegRefID val) 
            { 
                this.tradeLegRefID = val;
            }
            
            public QuickFix.Fields.TradeLegRefID get(QuickFix.Fields.TradeLegRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeLegRefID val) 
            { 
                return isSetTradeLegRefID();
            }
            
            public bool isSetTradeLegRefID() 
            { 
                return isSetField(Tags.TradeLegRefID);
            }
            public QuickFix.Fields.NoLegs noLegs
            { 
                get 
                {
                    QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoLegs val) 
            { 
                this.noLegs = val;
            }
            
            public QuickFix.Fields.NoLegs get(QuickFix.Fields.NoLegs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoLegs val) 
            { 
                return isSetNoLegs();
            }
            
            public bool isSetNoLegs() 
            { 
                return isSetField(Tags.NoLegs);
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
            public QuickFix.Fields.NoTrdRegTimestamps noTrdRegTimestamps
            { 
                get 
                {
                    QuickFix.Fields.NoTrdRegTimestamps val = new QuickFix.Fields.NoTrdRegTimestamps();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                this.noTrdRegTimestamps = val;
            }
            
            public QuickFix.Fields.NoTrdRegTimestamps get(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                return isSetNoTrdRegTimestamps();
            }
            
            public bool isSetNoTrdRegTimestamps() 
            { 
                return isSetField(Tags.NoTrdRegTimestamps);
            }
            public QuickFix.Fields.SettlType settlType
            { 
                get 
                {
                    QuickFix.Fields.SettlType val = new QuickFix.Fields.SettlType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlType val) 
            { 
                this.settlType = val;
            }
            
            public QuickFix.Fields.SettlType get(QuickFix.Fields.SettlType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlType val) 
            { 
                return isSetSettlType();
            }
            
            public bool isSetSettlType() 
            { 
                return isSetField(Tags.SettlType);
            }
            public QuickFix.Fields.SettlDate settlDate
            { 
                get 
                {
                    QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlDate val) 
            { 
                this.settlDate = val;
            }
            
            public QuickFix.Fields.SettlDate get(QuickFix.Fields.SettlDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlDate val) 
            { 
                return isSetSettlDate();
            }
            
            public bool isSetSettlDate() 
            { 
                return isSetField(Tags.SettlDate);
            }
            public QuickFix.Fields.MatchStatus matchStatus
            { 
                get 
                {
                    QuickFix.Fields.MatchStatus val = new QuickFix.Fields.MatchStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MatchStatus val) 
            { 
                this.matchStatus = val;
            }
            
            public QuickFix.Fields.MatchStatus get(QuickFix.Fields.MatchStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MatchStatus val) 
            { 
                return isSetMatchStatus();
            }
            
            public bool isSetMatchStatus() 
            { 
                return isSetField(Tags.MatchStatus);
            }
            public QuickFix.Fields.MatchType matchType
            { 
                get 
                {
                    QuickFix.Fields.MatchType val = new QuickFix.Fields.MatchType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MatchType val) 
            { 
                this.matchType = val;
            }
            
            public QuickFix.Fields.MatchType get(QuickFix.Fields.MatchType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MatchType val) 
            { 
                return isSetMatchType();
            }
            
            public bool isSetMatchType() 
            { 
                return isSetField(Tags.MatchType);
            }
            public QuickFix.Fields.NoSides noSides
            { 
                get 
                {
                    QuickFix.Fields.NoSides val = new QuickFix.Fields.NoSides();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoSides val) 
            { 
                this.noSides = val;
            }
            
            public QuickFix.Fields.NoSides get(QuickFix.Fields.NoSides val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoSides val) 
            { 
                return isSetNoSides();
            }
            
            public bool isSetNoSides() 
            { 
                return isSetField(Tags.NoSides);
            }
            public QuickFix.Fields.CopyMsgIndicator copyMsgIndicator
            { 
                get 
                {
                    QuickFix.Fields.CopyMsgIndicator val = new QuickFix.Fields.CopyMsgIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CopyMsgIndicator val) 
            { 
                this.copyMsgIndicator = val;
            }
            
            public QuickFix.Fields.CopyMsgIndicator get(QuickFix.Fields.CopyMsgIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CopyMsgIndicator val) 
            { 
                return isSetCopyMsgIndicator();
            }
            
            public bool isSetCopyMsgIndicator() 
            { 
                return isSetField(Tags.CopyMsgIndicator);
            }
            public QuickFix.Fields.PublishTrdIndicator publishTrdIndicator
            { 
                get 
                {
                    QuickFix.Fields.PublishTrdIndicator val = new QuickFix.Fields.PublishTrdIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PublishTrdIndicator val) 
            { 
                this.publishTrdIndicator = val;
            }
            
            public QuickFix.Fields.PublishTrdIndicator get(QuickFix.Fields.PublishTrdIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PublishTrdIndicator val) 
            { 
                return isSetPublishTrdIndicator();
            }
            
            public bool isSetPublishTrdIndicator() 
            { 
                return isSetField(Tags.PublishTrdIndicator);
            }
            public QuickFix.Fields.ShortSaleReason shortSaleReason
            { 
                get 
                {
                    QuickFix.Fields.ShortSaleReason val = new QuickFix.Fields.ShortSaleReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ShortSaleReason val) 
            { 
                this.shortSaleReason = val;
            }
            
            public QuickFix.Fields.ShortSaleReason get(QuickFix.Fields.ShortSaleReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ShortSaleReason val) 
            { 
                return isSetShortSaleReason();
            }
            
            public bool isSetShortSaleReason() 
            { 
                return isSetField(Tags.ShortSaleReason);
            }
            public QuickFix.Fields.TrdRptStatus trdRptStatus
            { 
                get 
                {
                    QuickFix.Fields.TrdRptStatus val = new QuickFix.Fields.TrdRptStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TrdRptStatus val) 
            { 
                this.trdRptStatus = val;
            }
            
            public QuickFix.Fields.TrdRptStatus get(QuickFix.Fields.TrdRptStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TrdRptStatus val) 
            { 
                return isSetTrdRptStatus();
            }
            
            public bool isSetTrdRptStatus() 
            { 
                return isSetField(Tags.TrdRptStatus);
            }
            public QuickFix.Fields.AsOfIndicator asOfIndicator
            { 
                get 
                {
                    QuickFix.Fields.AsOfIndicator val = new QuickFix.Fields.AsOfIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AsOfIndicator val) 
            { 
                this.asOfIndicator = val;
            }
            
            public QuickFix.Fields.AsOfIndicator get(QuickFix.Fields.AsOfIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AsOfIndicator val) 
            { 
                return isSetAsOfIndicator();
            }
            
            public bool isSetAsOfIndicator() 
            { 
                return isSetField(Tags.AsOfIndicator);
            }
            public QuickFix.Fields.SettlSessID settlSessID
            { 
                get 
                {
                    QuickFix.Fields.SettlSessID val = new QuickFix.Fields.SettlSessID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlSessID val) 
            { 
                this.settlSessID = val;
            }
            
            public QuickFix.Fields.SettlSessID get(QuickFix.Fields.SettlSessID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlSessID val) 
            { 
                return isSetSettlSessID();
            }
            
            public bool isSetSettlSessID() 
            { 
                return isSetField(Tags.SettlSessID);
            }
            public QuickFix.Fields.SettlSessSubID settlSessSubID
            { 
                get 
                {
                    QuickFix.Fields.SettlSessSubID val = new QuickFix.Fields.SettlSessSubID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlSessSubID val) 
            { 
                this.settlSessSubID = val;
            }
            
            public QuickFix.Fields.SettlSessSubID get(QuickFix.Fields.SettlSessSubID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlSessSubID val) 
            { 
                return isSetSettlSessSubID();
            }
            
            public bool isSetSettlSessSubID() 
            { 
                return isSetField(Tags.SettlSessSubID);
            }
            public QuickFix.Fields.TierCode tierCode
            { 
                get 
                {
                    QuickFix.Fields.TierCode val = new QuickFix.Fields.TierCode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TierCode val) 
            { 
                this.tierCode = val;
            }
            
            public QuickFix.Fields.TierCode get(QuickFix.Fields.TierCode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TierCode val) 
            { 
                return isSetTierCode();
            }
            
            public bool isSetTierCode() 
            { 
                return isSetField(Tags.TierCode);
            }
            public QuickFix.Fields.MessageEventSource messageEventSource
            { 
                get 
                {
                    QuickFix.Fields.MessageEventSource val = new QuickFix.Fields.MessageEventSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MessageEventSource val) 
            { 
                this.messageEventSource = val;
            }
            
            public QuickFix.Fields.MessageEventSource get(QuickFix.Fields.MessageEventSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MessageEventSource val) 
            { 
                return isSetMessageEventSource();
            }
            
            public bool isSetMessageEventSource() 
            { 
                return isSetField(Tags.MessageEventSource);
            }
            public QuickFix.Fields.LastUpdateTime lastUpdateTime
            { 
                get 
                {
                    QuickFix.Fields.LastUpdateTime val = new QuickFix.Fields.LastUpdateTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastUpdateTime val) 
            { 
                this.lastUpdateTime = val;
            }
            
            public QuickFix.Fields.LastUpdateTime get(QuickFix.Fields.LastUpdateTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastUpdateTime val) 
            { 
                return isSetLastUpdateTime();
            }
            
            public bool isSetLastUpdateTime() 
            { 
                return isSetField(Tags.LastUpdateTime);
            }
            public QuickFix.Fields.RndPx rndPx
            { 
                get 
                {
                    QuickFix.Fields.RndPx val = new QuickFix.Fields.RndPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RndPx val) 
            { 
                this.rndPx = val;
            }
            
            public QuickFix.Fields.RndPx get(QuickFix.Fields.RndPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RndPx val) 
            { 
                return isSetRndPx();
            }
            
            public bool isSetRndPx() 
            { 
                return isSetField(Tags.RndPx);
            }
            public QuickFix.Fields.TradeID tradeID
            { 
                get 
                {
                    QuickFix.Fields.TradeID val = new QuickFix.Fields.TradeID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeID val) 
            { 
                this.tradeID = val;
            }
            
            public QuickFix.Fields.TradeID get(QuickFix.Fields.TradeID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeID val) 
            { 
                return isSetTradeID();
            }
            
            public bool isSetTradeID() 
            { 
                return isSetField(Tags.TradeID);
            }
            public QuickFix.Fields.SecondaryTradeID secondaryTradeID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryTradeID val = new QuickFix.Fields.SecondaryTradeID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryTradeID val) 
            { 
                this.secondaryTradeID = val;
            }
            
            public QuickFix.Fields.SecondaryTradeID get(QuickFix.Fields.SecondaryTradeID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryTradeID val) 
            { 
                return isSetSecondaryTradeID();
            }
            
            public bool isSetSecondaryTradeID() 
            { 
                return isSetField(Tags.SecondaryTradeID);
            }
            public QuickFix.Fields.FirmTradeID firmTradeID
            { 
                get 
                {
                    QuickFix.Fields.FirmTradeID val = new QuickFix.Fields.FirmTradeID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FirmTradeID val) 
            { 
                this.firmTradeID = val;
            }
            
            public QuickFix.Fields.FirmTradeID get(QuickFix.Fields.FirmTradeID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FirmTradeID val) 
            { 
                return isSetFirmTradeID();
            }
            
            public bool isSetFirmTradeID() 
            { 
                return isSetField(Tags.FirmTradeID);
            }
            public QuickFix.Fields.SecondaryFirmTradeID secondaryFirmTradeID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryFirmTradeID val = new QuickFix.Fields.SecondaryFirmTradeID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryFirmTradeID val) 
            { 
                this.secondaryFirmTradeID = val;
            }
            
            public QuickFix.Fields.SecondaryFirmTradeID get(QuickFix.Fields.SecondaryFirmTradeID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryFirmTradeID val) 
            { 
                return isSetSecondaryFirmTradeID();
            }
            
            public bool isSetSecondaryFirmTradeID() 
            { 
                return isSetField(Tags.SecondaryFirmTradeID);
            }
            public QuickFix.Fields.CalculatedCcyLastQty calculatedCcyLastQty
            { 
                get 
                {
                    QuickFix.Fields.CalculatedCcyLastQty val = new QuickFix.Fields.CalculatedCcyLastQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CalculatedCcyLastQty val) 
            { 
                this.calculatedCcyLastQty = val;
            }
            
            public QuickFix.Fields.CalculatedCcyLastQty get(QuickFix.Fields.CalculatedCcyLastQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CalculatedCcyLastQty val) 
            { 
                return isSetCalculatedCcyLastQty();
            }
            
            public bool isSetCalculatedCcyLastQty() 
            { 
                return isSetField(Tags.CalculatedCcyLastQty);
            }
            public QuickFix.Fields.LastSwapPoints lastSwapPoints
            { 
                get 
                {
                    QuickFix.Fields.LastSwapPoints val = new QuickFix.Fields.LastSwapPoints();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastSwapPoints val) 
            { 
                this.lastSwapPoints = val;
            }
            
            public QuickFix.Fields.LastSwapPoints get(QuickFix.Fields.LastSwapPoints val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastSwapPoints val) 
            { 
                return isSetLastSwapPoints();
            }
            
            public bool isSetLastSwapPoints() 
            { 
                return isSetField(Tags.LastSwapPoints);
            }
            public QuickFix.Fields.UnderlyingSettlementDate underlyingSettlementDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSettlementDate val = new QuickFix.Fields.UnderlyingSettlementDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSettlementDate val) 
            { 
                this.underlyingSettlementDate = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlementDate get(QuickFix.Fields.UnderlyingSettlementDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSettlementDate val) 
            { 
                return isSetUnderlyingSettlementDate();
            }
            
            public bool isSetUnderlyingSettlementDate() 
            { 
                return isSetField(Tags.UnderlyingSettlementDate);
            }
            public QuickFix.Fields.GrossTradeAmt grossTradeAmt
            { 
                get 
                {
                    QuickFix.Fields.GrossTradeAmt val = new QuickFix.Fields.GrossTradeAmt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.GrossTradeAmt val) 
            { 
                this.grossTradeAmt = val;
            }
            
            public QuickFix.Fields.GrossTradeAmt get(QuickFix.Fields.GrossTradeAmt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.GrossTradeAmt val) 
            { 
                return isSetGrossTradeAmt();
            }
            
            public bool isSetGrossTradeAmt() 
            { 
                return isSetField(Tags.GrossTradeAmt);
            }
            public QuickFix.Fields.NoRootPartyIDs noRootPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoRootPartyIDs val = new QuickFix.Fields.NoRootPartyIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                this.noRootPartyIDs = val;
            }
            
            public QuickFix.Fields.NoRootPartyIDs get(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                return isSetNoRootPartyIDs();
            }
            
            public bool isSetNoRootPartyIDs() 
            { 
                return isSetField(Tags.NoRootPartyIDs);
            }
            public QuickFix.Fields.OrderCategory orderCategory
            { 
                get 
                {
                    QuickFix.Fields.OrderCategory val = new QuickFix.Fields.OrderCategory();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrderCategory val) 
            { 
                this.orderCategory = val;
            }
            
            public QuickFix.Fields.OrderCategory get(QuickFix.Fields.OrderCategory val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrderCategory val) 
            { 
                return isSetOrderCategory();
            }
            
            public bool isSetOrderCategory() 
            { 
                return isSetField(Tags.OrderCategory);
            }
            public QuickFix.Fields.TradeHandlingInstr tradeHandlingInstr
            { 
                get 
                {
                    QuickFix.Fields.TradeHandlingInstr val = new QuickFix.Fields.TradeHandlingInstr();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeHandlingInstr val) 
            { 
                this.tradeHandlingInstr = val;
            }
            
            public QuickFix.Fields.TradeHandlingInstr get(QuickFix.Fields.TradeHandlingInstr val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeHandlingInstr val) 
            { 
                return isSetTradeHandlingInstr();
            }
            
            public bool isSetTradeHandlingInstr() 
            { 
                return isSetField(Tags.TradeHandlingInstr);
            }
            public QuickFix.Fields.OrigTradeHandlingInstr origTradeHandlingInstr
            { 
                get 
                {
                    QuickFix.Fields.OrigTradeHandlingInstr val = new QuickFix.Fields.OrigTradeHandlingInstr();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigTradeHandlingInstr val) 
            { 
                this.origTradeHandlingInstr = val;
            }
            
            public QuickFix.Fields.OrigTradeHandlingInstr get(QuickFix.Fields.OrigTradeHandlingInstr val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigTradeHandlingInstr val) 
            { 
                return isSetOrigTradeHandlingInstr();
            }
            
            public bool isSetOrigTradeHandlingInstr() 
            { 
                return isSetField(Tags.OrigTradeHandlingInstr);
            }
            public QuickFix.Fields.OrigTradeDate origTradeDate
            { 
                get 
                {
                    QuickFix.Fields.OrigTradeDate val = new QuickFix.Fields.OrigTradeDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigTradeDate val) 
            { 
                this.origTradeDate = val;
            }
            
            public QuickFix.Fields.OrigTradeDate get(QuickFix.Fields.OrigTradeDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigTradeDate val) 
            { 
                return isSetOrigTradeDate();
            }
            
            public bool isSetOrigTradeDate() 
            { 
                return isSetField(Tags.OrigTradeDate);
            }
            public QuickFix.Fields.OrigTradeID origTradeID
            { 
                get 
                {
                    QuickFix.Fields.OrigTradeID val = new QuickFix.Fields.OrigTradeID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigTradeID val) 
            { 
                this.origTradeID = val;
            }
            
            public QuickFix.Fields.OrigTradeID get(QuickFix.Fields.OrigTradeID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigTradeID val) 
            { 
                return isSetOrigTradeID();
            }
            
            public bool isSetOrigTradeID() 
            { 
                return isSetField(Tags.OrigTradeID);
            }
            public QuickFix.Fields.OrigSecondaryTradeID origSecondaryTradeID
            { 
                get 
                {
                    QuickFix.Fields.OrigSecondaryTradeID val = new QuickFix.Fields.OrigSecondaryTradeID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigSecondaryTradeID val) 
            { 
                this.origSecondaryTradeID = val;
            }
            
            public QuickFix.Fields.OrigSecondaryTradeID get(QuickFix.Fields.OrigSecondaryTradeID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigSecondaryTradeID val) 
            { 
                return isSetOrigSecondaryTradeID();
            }
            
            public bool isSetOrigSecondaryTradeID() 
            { 
                return isSetField(Tags.OrigSecondaryTradeID);
            }
            public QuickFix.Fields.TZTransactTime tZTransactTime
            { 
                get 
                {
                    QuickFix.Fields.TZTransactTime val = new QuickFix.Fields.TZTransactTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TZTransactTime val) 
            { 
                this.tZTransactTime = val;
            }
            
            public QuickFix.Fields.TZTransactTime get(QuickFix.Fields.TZTransactTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TZTransactTime val) 
            { 
                return isSetTZTransactTime();
            }
            
            public bool isSetTZTransactTime() 
            { 
                return isSetField(Tags.TZTransactTime);
            }
            public QuickFix.Fields.ReportedPxDiff reportedPxDiff
            { 
                get 
                {
                    QuickFix.Fields.ReportedPxDiff val = new QuickFix.Fields.ReportedPxDiff();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ReportedPxDiff val) 
            { 
                this.reportedPxDiff = val;
            }
            
            public QuickFix.Fields.ReportedPxDiff get(QuickFix.Fields.ReportedPxDiff val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ReportedPxDiff val) 
            { 
                return isSetReportedPxDiff();
            }
            
            public bool isSetReportedPxDiff() 
            { 
                return isSetField(Tags.ReportedPxDiff);
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
            public QuickFix.Fields.RejectText rejectText
            { 
                get 
                {
                    QuickFix.Fields.RejectText val = new QuickFix.Fields.RejectText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RejectText val) 
            { 
                this.rejectText = val;
            }
            
            public QuickFix.Fields.RejectText get(QuickFix.Fields.RejectText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RejectText val) 
            { 
                return isSetRejectText();
            }
            
            public bool isSetRejectText() 
            { 
                return isSetField(Tags.RejectText);
            }
            public QuickFix.Fields.FeeMultiplier feeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.FeeMultiplier val = new QuickFix.Fields.FeeMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FeeMultiplier val) 
            { 
                this.feeMultiplier = val;
            }
            
            public QuickFix.Fields.FeeMultiplier get(QuickFix.Fields.FeeMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FeeMultiplier val) 
            { 
                return isSetFeeMultiplier();
            }
            
            public bool isSetFeeMultiplier() 
            { 
                return isSetField(Tags.FeeMultiplier);
            }
            public QuickFix.Fields.Volatility volatility
            { 
                get 
                {
                    QuickFix.Fields.Volatility val = new QuickFix.Fields.Volatility();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Volatility val) 
            { 
                this.volatility = val;
            }
            
            public QuickFix.Fields.Volatility get(QuickFix.Fields.Volatility val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Volatility val) 
            { 
                return isSetVolatility();
            }
            
            public bool isSetVolatility() 
            { 
                return isSetField(Tags.Volatility);
            }
            public QuickFix.Fields.DividendYield dividendYield
            { 
                get 
                {
                    QuickFix.Fields.DividendYield val = new QuickFix.Fields.DividendYield();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DividendYield val) 
            { 
                this.dividendYield = val;
            }
            
            public QuickFix.Fields.DividendYield get(QuickFix.Fields.DividendYield val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DividendYield val) 
            { 
                return isSetDividendYield();
            }
            
            public bool isSetDividendYield() 
            { 
                return isSetField(Tags.DividendYield);
            }
            public QuickFix.Fields.RiskFreeRate riskFreeRate
            { 
                get 
                {
                    QuickFix.Fields.RiskFreeRate val = new QuickFix.Fields.RiskFreeRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RiskFreeRate val) 
            { 
                this.riskFreeRate = val;
            }
            
            public QuickFix.Fields.RiskFreeRate get(QuickFix.Fields.RiskFreeRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RiskFreeRate val) 
            { 
                return isSetRiskFreeRate();
            }
            
            public bool isSetRiskFreeRate() 
            { 
                return isSetField(Tags.RiskFreeRate);
            }
            public QuickFix.Fields.CurrencyRatio currencyRatio
            { 
                get 
                {
                    QuickFix.Fields.CurrencyRatio val = new QuickFix.Fields.CurrencyRatio();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CurrencyRatio val) 
            { 
                this.currencyRatio = val;
            }
            
            public QuickFix.Fields.CurrencyRatio get(QuickFix.Fields.CurrencyRatio val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CurrencyRatio val) 
            { 
                return isSetCurrencyRatio();
            }
            
            public bool isSetCurrencyRatio() 
            { 
                return isSetField(Tags.CurrencyRatio);
            }
            public QuickFix.Fields.NoTrdRepIndicators noTrdRepIndicators
            { 
                get 
                {
                    QuickFix.Fields.NoTrdRepIndicators val = new QuickFix.Fields.NoTrdRepIndicators();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoTrdRepIndicators val) 
            { 
                this.noTrdRepIndicators = val;
            }
            
            public QuickFix.Fields.NoTrdRepIndicators get(QuickFix.Fields.NoTrdRepIndicators val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoTrdRepIndicators val) 
            { 
                return isSetNoTrdRepIndicators();
            }
            
            public bool isSetNoTrdRepIndicators() 
            { 
                return isSetField(Tags.NoTrdRepIndicators);
            }
            public QuickFix.Fields.TradePublishIndicator tradePublishIndicator
            { 
                get 
                {
                    QuickFix.Fields.TradePublishIndicator val = new QuickFix.Fields.TradePublishIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradePublishIndicator val) 
            { 
                this.tradePublishIndicator = val;
            }
            
            public QuickFix.Fields.TradePublishIndicator get(QuickFix.Fields.TradePublishIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradePublishIndicator val) 
            { 
                return isSetTradePublishIndicator();
            }
            
            public bool isSetTradePublishIndicator() 
            { 
                return isSetField(Tags.TradePublishIndicator);
            }
            public QuickFix.Fields.ApplID applID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID get(QuickFix.Fields.ApplID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplID val) 
            { 
                return isSetApplID();
            }
            
            public bool isSetApplID() 
            { 
                return isSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum get(QuickFix.Fields.ApplSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return isSetApplSeqNum();
            }
            
            public bool isSetApplSeqNum() 
            { 
                return isSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return isSetApplLastSeqNum();
            }
            
            public bool isSetApplLastSeqNum() 
            { 
                return isSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag get(QuickFix.Fields.ApplResendFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return isSetApplResendFlag();
            }
            
            public bool isSetApplResendFlag() 
            { 
                return isSetField(Tags.ApplResendFlag);
            }
            public class NoSecurityAltID : Group
            {
                public NoSecurityAltID() 
                  :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                            public QuickFix.Fields.SecurityAltID securityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityAltID val) 
                { 
                    this.securityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID get(QuickFix.Fields.SecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return isSetSecurityAltID();
                }
                
                public bool isSetSecurityAltID() 
                { 
                    return isSetField(Tags.SecurityAltID);
                }
                public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    this.securityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return isSetSecurityAltIDSource();
                }
                
                public bool isSetSecurityAltIDSource() 
                { 
                    return isSetField(Tags.SecurityAltIDSource);
                }
            
            }
            public class NoEvents : Group
            {
                public NoEvents() 
                  :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                            public QuickFix.Fields.EventType eventType
                { 
                    get 
                    {
                        QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventType val) 
                { 
                    this.eventType = val;
                }
                
                public QuickFix.Fields.EventType get(QuickFix.Fields.EventType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventType val) 
                { 
                    return isSetEventType();
                }
                
                public bool isSetEventType() 
                { 
                    return isSetField(Tags.EventType);
                }
                public QuickFix.Fields.EventDate eventDate
                { 
                    get 
                    {
                        QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventDate val) 
                { 
                    this.eventDate = val;
                }
                
                public QuickFix.Fields.EventDate get(QuickFix.Fields.EventDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventDate val) 
                { 
                    return isSetEventDate();
                }
                
                public bool isSetEventDate() 
                { 
                    return isSetField(Tags.EventDate);
                }
                public QuickFix.Fields.EventPx eventPx
                { 
                    get 
                    {
                        QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventPx val) 
                { 
                    this.eventPx = val;
                }
                
                public QuickFix.Fields.EventPx get(QuickFix.Fields.EventPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventPx val) 
                { 
                    return isSetEventPx();
                }
                
                public bool isSetEventPx() 
                { 
                    return isSetField(Tags.EventPx);
                }
                public QuickFix.Fields.EventText eventText
                { 
                    get 
                    {
                        QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventText val) 
                { 
                    this.eventText = val;
                }
                
                public QuickFix.Fields.EventText get(QuickFix.Fields.EventText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventText val) 
                { 
                    return isSetEventText();
                }
                
                public bool isSetEventText() 
                { 
                    return isSetField(Tags.EventText);
                }
                public QuickFix.Fields.EventTime eventTime
                { 
                    get 
                    {
                        QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventTime val) 
                { 
                    this.eventTime = val;
                }
                
                public QuickFix.Fields.EventTime get(QuickFix.Fields.EventTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventTime val) 
                { 
                    return isSetEventTime();
                }
                
                public bool isSetEventTime() 
                { 
                    return isSetField(Tags.EventTime);
                }
            
            }
            public class NoInstrumentParties : Group
            {
                public NoInstrumentParties() 
                  :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.InstrumentPartyID instrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    this.instrumentPartyID = val;
                }
                
                public QuickFix.Fields.InstrumentPartyID get(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    return isSetInstrumentPartyID();
                }
                
                public bool isSetInstrumentPartyID() 
                { 
                    return isSetField(Tags.InstrumentPartyID);
                }
                public QuickFix.Fields.InstrumentPartyIDSource instrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    this.instrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.InstrumentPartyIDSource get(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    return isSetInstrumentPartyIDSource();
                }
                
                public bool isSetInstrumentPartyIDSource() 
                { 
                    return isSetField(Tags.InstrumentPartyIDSource);
                }
                public QuickFix.Fields.InstrumentPartyRole instrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    this.instrumentPartyRole = val;
                }
                
                public QuickFix.Fields.InstrumentPartyRole get(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    return isSetInstrumentPartyRole();
                }
                
                public bool isSetInstrumentPartyRole() 
                { 
                    return isSetField(Tags.InstrumentPartyRole);
                }
                public QuickFix.Fields.NoInstrumentPartySubIDs noInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    this.noInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoInstrumentPartySubIDs get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    return isSetNoInstrumentPartySubIDs();
                }
                
                public bool isSetNoInstrumentPartySubIDs() 
                { 
                    return isSetField(Tags.NoInstrumentPartySubIDs);
                }
                            public class NoInstrumentPartySubIDs : Group
                {
                    public NoInstrumentPartySubIDs() 
                      :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.InstrumentPartySubID instrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        this.instrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubID get(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        return isSetInstrumentPartySubID();
                    }
                    
                    public bool isSetInstrumentPartySubID() 
                    { 
                        return isSetField(Tags.InstrumentPartySubID);
                    }
                    public QuickFix.Fields.InstrumentPartySubIDType instrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        this.instrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubIDType get(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        return isSetInstrumentPartySubIDType();
                    }
                    
                    public bool isSetInstrumentPartySubIDType() 
                    { 
                        return isSetField(Tags.InstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoUnderlyings : Group
            {
                public NoUnderlyings() 
                  :base( Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, 0};
                            public QuickFix.Fields.UnderlyingSymbol underlyingSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    this.underlyingSymbol = val;
                }
                
                public QuickFix.Fields.UnderlyingSymbol get(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    return isSetUnderlyingSymbol();
                }
                
                public bool isSetUnderlyingSymbol() 
                { 
                    return isSetField(Tags.UnderlyingSymbol);
                }
                public QuickFix.Fields.UnderlyingSymbolSfx underlyingSymbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    this.underlyingSymbolSfx = val;
                }
                
                public QuickFix.Fields.UnderlyingSymbolSfx get(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    return isSetUnderlyingSymbolSfx();
                }
                
                public bool isSetUnderlyingSymbolSfx() 
                { 
                    return isSetField(Tags.UnderlyingSymbolSfx);
                }
                public QuickFix.Fields.UnderlyingSecurityID underlyingSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    this.underlyingSecurityID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityID get(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    return isSetUnderlyingSecurityID();
                }
                
                public bool isSetUnderlyingSecurityID() 
                { 
                    return isSetField(Tags.UnderlyingSecurityID);
                }
                public QuickFix.Fields.UnderlyingSecurityIDSource underlyingSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    this.underlyingSecurityIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityIDSource get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    return isSetUnderlyingSecurityIDSource();
                }
                
                public bool isSetUnderlyingSecurityIDSource() 
                { 
                    return isSetField(Tags.UnderlyingSecurityIDSource);
                }
                public QuickFix.Fields.NoUnderlyingSecurityAltID noUnderlyingSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    this.noUnderlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoUnderlyingSecurityAltID get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    return isSetNoUnderlyingSecurityAltID();
                }
                
                public bool isSetNoUnderlyingSecurityAltID() 
                { 
                    return isSetField(Tags.NoUnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingProduct underlyingProduct
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    this.underlyingProduct = val;
                }
                
                public QuickFix.Fields.UnderlyingProduct get(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    return isSetUnderlyingProduct();
                }
                
                public bool isSetUnderlyingProduct() 
                { 
                    return isSetField(Tags.UnderlyingProduct);
                }
                public QuickFix.Fields.UnderlyingCFICode underlyingCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    this.underlyingCFICode = val;
                }
                
                public QuickFix.Fields.UnderlyingCFICode get(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    return isSetUnderlyingCFICode();
                }
                
                public bool isSetUnderlyingCFICode() 
                { 
                    return isSetField(Tags.UnderlyingCFICode);
                }
                public QuickFix.Fields.UnderlyingSecurityType underlyingSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    this.underlyingSecurityType = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityType get(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    return isSetUnderlyingSecurityType();
                }
                
                public bool isSetUnderlyingSecurityType() 
                { 
                    return isSetField(Tags.UnderlyingSecurityType);
                }
                public QuickFix.Fields.UnderlyingSecuritySubType underlyingSecuritySubType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    this.underlyingSecuritySubType = val;
                }
                
                public QuickFix.Fields.UnderlyingSecuritySubType get(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    return isSetUnderlyingSecuritySubType();
                }
                
                public bool isSetUnderlyingSecuritySubType() 
                { 
                    return isSetField(Tags.UnderlyingSecuritySubType);
                }
                public QuickFix.Fields.UnderlyingMaturityMonthYear underlyingMaturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    this.underlyingMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityMonthYear get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    return isSetUnderlyingMaturityMonthYear();
                }
                
                public bool isSetUnderlyingMaturityMonthYear() 
                { 
                    return isSetField(Tags.UnderlyingMaturityMonthYear);
                }
                public QuickFix.Fields.UnderlyingMaturityDate underlyingMaturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    this.underlyingMaturityDate = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityDate get(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    return isSetUnderlyingMaturityDate();
                }
                
                public bool isSetUnderlyingMaturityDate() 
                { 
                    return isSetField(Tags.UnderlyingMaturityDate);
                }
                public QuickFix.Fields.UnderlyingCouponPaymentDate underlyingCouponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    this.underlyingCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.UnderlyingCouponPaymentDate get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    return isSetUnderlyingCouponPaymentDate();
                }
                
                public bool isSetUnderlyingCouponPaymentDate() 
                { 
                    return isSetField(Tags.UnderlyingCouponPaymentDate);
                }
                public QuickFix.Fields.UnderlyingIssueDate underlyingIssueDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    this.underlyingIssueDate = val;
                }
                
                public QuickFix.Fields.UnderlyingIssueDate get(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    return isSetUnderlyingIssueDate();
                }
                
                public bool isSetUnderlyingIssueDate() 
                { 
                    return isSetField(Tags.UnderlyingIssueDate);
                }
                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType underlyingRepoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    this.underlyingRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    return isSetUnderlyingRepoCollateralSecurityType();
                }
                
                public bool isSetUnderlyingRepoCollateralSecurityType() 
                { 
                    return isSetField(Tags.UnderlyingRepoCollateralSecurityType);
                }
                public QuickFix.Fields.UnderlyingRepurchaseTerm underlyingRepurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    this.underlyingRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseTerm get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    return isSetUnderlyingRepurchaseTerm();
                }
                
                public bool isSetUnderlyingRepurchaseTerm() 
                { 
                    return isSetField(Tags.UnderlyingRepurchaseTerm);
                }
                public QuickFix.Fields.UnderlyingRepurchaseRate underlyingRepurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    this.underlyingRepurchaseRate = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseRate get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    return isSetUnderlyingRepurchaseRate();
                }
                
                public bool isSetUnderlyingRepurchaseRate() 
                { 
                    return isSetField(Tags.UnderlyingRepurchaseRate);
                }
                public QuickFix.Fields.UnderlyingFactor underlyingFactor
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    this.underlyingFactor = val;
                }
                
                public QuickFix.Fields.UnderlyingFactor get(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    return isSetUnderlyingFactor();
                }
                
                public bool isSetUnderlyingFactor() 
                { 
                    return isSetField(Tags.UnderlyingFactor);
                }
                public QuickFix.Fields.UnderlyingCreditRating underlyingCreditRating
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    this.underlyingCreditRating = val;
                }
                
                public QuickFix.Fields.UnderlyingCreditRating get(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    return isSetUnderlyingCreditRating();
                }
                
                public bool isSetUnderlyingCreditRating() 
                { 
                    return isSetField(Tags.UnderlyingCreditRating);
                }
                public QuickFix.Fields.UnderlyingInstrRegistry underlyingInstrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    this.underlyingInstrRegistry = val;
                }
                
                public QuickFix.Fields.UnderlyingInstrRegistry get(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    return isSetUnderlyingInstrRegistry();
                }
                
                public bool isSetUnderlyingInstrRegistry() 
                { 
                    return isSetField(Tags.UnderlyingInstrRegistry);
                }
                public QuickFix.Fields.UnderlyingCountryOfIssue underlyingCountryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    this.underlyingCountryOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingCountryOfIssue get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    return isSetUnderlyingCountryOfIssue();
                }
                
                public bool isSetUnderlyingCountryOfIssue() 
                { 
                    return isSetField(Tags.UnderlyingCountryOfIssue);
                }
                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue underlyingStateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    this.underlyingStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    return isSetUnderlyingStateOrProvinceOfIssue();
                }
                
                public bool isSetUnderlyingStateOrProvinceOfIssue() 
                { 
                    return isSetField(Tags.UnderlyingStateOrProvinceOfIssue);
                }
                public QuickFix.Fields.UnderlyingLocaleOfIssue underlyingLocaleOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    this.underlyingLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingLocaleOfIssue get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    return isSetUnderlyingLocaleOfIssue();
                }
                
                public bool isSetUnderlyingLocaleOfIssue() 
                { 
                    return isSetField(Tags.UnderlyingLocaleOfIssue);
                }
                public QuickFix.Fields.UnderlyingRedemptionDate underlyingRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    this.underlyingRedemptionDate = val;
                }
                
                public QuickFix.Fields.UnderlyingRedemptionDate get(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    return isSetUnderlyingRedemptionDate();
                }
                
                public bool isSetUnderlyingRedemptionDate() 
                { 
                    return isSetField(Tags.UnderlyingRedemptionDate);
                }
                public QuickFix.Fields.UnderlyingStrikePrice underlyingStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    this.underlyingStrikePrice = val;
                }
                
                public QuickFix.Fields.UnderlyingStrikePrice get(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    return isSetUnderlyingStrikePrice();
                }
                
                public bool isSetUnderlyingStrikePrice() 
                { 
                    return isSetField(Tags.UnderlyingStrikePrice);
                }
                public QuickFix.Fields.UnderlyingStrikeCurrency underlyingStrikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    this.underlyingStrikeCurrency = val;
                }
                
                public QuickFix.Fields.UnderlyingStrikeCurrency get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    return isSetUnderlyingStrikeCurrency();
                }
                
                public bool isSetUnderlyingStrikeCurrency() 
                { 
                    return isSetField(Tags.UnderlyingStrikeCurrency);
                }
                public QuickFix.Fields.UnderlyingOptAttribute underlyingOptAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    this.underlyingOptAttribute = val;
                }
                
                public QuickFix.Fields.UnderlyingOptAttribute get(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    return isSetUnderlyingOptAttribute();
                }
                
                public bool isSetUnderlyingOptAttribute() 
                { 
                    return isSetField(Tags.UnderlyingOptAttribute);
                }
                public QuickFix.Fields.UnderlyingContractMultiplier underlyingContractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    this.underlyingContractMultiplier = val;
                }
                
                public QuickFix.Fields.UnderlyingContractMultiplier get(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    return isSetUnderlyingContractMultiplier();
                }
                
                public bool isSetUnderlyingContractMultiplier() 
                { 
                    return isSetField(Tags.UnderlyingContractMultiplier);
                }
                public QuickFix.Fields.UnderlyingCouponRate underlyingCouponRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    this.underlyingCouponRate = val;
                }
                
                public QuickFix.Fields.UnderlyingCouponRate get(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    return isSetUnderlyingCouponRate();
                }
                
                public bool isSetUnderlyingCouponRate() 
                { 
                    return isSetField(Tags.UnderlyingCouponRate);
                }
                public QuickFix.Fields.UnderlyingSecurityExchange underlyingSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    this.underlyingSecurityExchange = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityExchange get(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    return isSetUnderlyingSecurityExchange();
                }
                
                public bool isSetUnderlyingSecurityExchange() 
                { 
                    return isSetField(Tags.UnderlyingSecurityExchange);
                }
                public QuickFix.Fields.UnderlyingIssuer underlyingIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    this.underlyingIssuer = val;
                }
                
                public QuickFix.Fields.UnderlyingIssuer get(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    return isSetUnderlyingIssuer();
                }
                
                public bool isSetUnderlyingIssuer() 
                { 
                    return isSetField(Tags.UnderlyingIssuer);
                }
                public QuickFix.Fields.EncodedUnderlyingIssuerLen encodedUnderlyingIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    this.encodedUnderlyingIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingIssuerLen get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    return isSetEncodedUnderlyingIssuerLen();
                }
                
                public bool isSetEncodedUnderlyingIssuerLen() 
                { 
                    return isSetField(Tags.EncodedUnderlyingIssuerLen);
                }
                public QuickFix.Fields.EncodedUnderlyingIssuer encodedUnderlyingIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    this.encodedUnderlyingIssuer = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingIssuer get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    return isSetEncodedUnderlyingIssuer();
                }
                
                public bool isSetEncodedUnderlyingIssuer() 
                { 
                    return isSetField(Tags.EncodedUnderlyingIssuer);
                }
                public QuickFix.Fields.UnderlyingSecurityDesc underlyingSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    this.underlyingSecurityDesc = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityDesc get(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    return isSetUnderlyingSecurityDesc();
                }
                
                public bool isSetUnderlyingSecurityDesc() 
                { 
                    return isSetField(Tags.UnderlyingSecurityDesc);
                }
                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen encodedUnderlyingSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    this.encodedUnderlyingSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    return isSetEncodedUnderlyingSecurityDescLen();
                }
                
                public bool isSetEncodedUnderlyingSecurityDescLen() 
                { 
                    return isSetField(Tags.EncodedUnderlyingSecurityDescLen);
                }
                public QuickFix.Fields.EncodedUnderlyingSecurityDesc encodedUnderlyingSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    this.encodedUnderlyingSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingSecurityDesc get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    return isSetEncodedUnderlyingSecurityDesc();
                }
                
                public bool isSetEncodedUnderlyingSecurityDesc() 
                { 
                    return isSetField(Tags.EncodedUnderlyingSecurityDesc);
                }
                public QuickFix.Fields.UnderlyingCPProgram underlyingCPProgram
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    this.underlyingCPProgram = val;
                }
                
                public QuickFix.Fields.UnderlyingCPProgram get(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    return isSetUnderlyingCPProgram();
                }
                
                public bool isSetUnderlyingCPProgram() 
                { 
                    return isSetField(Tags.UnderlyingCPProgram);
                }
                public QuickFix.Fields.UnderlyingCPRegType underlyingCPRegType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    this.underlyingCPRegType = val;
                }
                
                public QuickFix.Fields.UnderlyingCPRegType get(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    return isSetUnderlyingCPRegType();
                }
                
                public bool isSetUnderlyingCPRegType() 
                { 
                    return isSetField(Tags.UnderlyingCPRegType);
                }
                public QuickFix.Fields.UnderlyingCurrency underlyingCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    this.underlyingCurrency = val;
                }
                
                public QuickFix.Fields.UnderlyingCurrency get(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    return isSetUnderlyingCurrency();
                }
                
                public bool isSetUnderlyingCurrency() 
                { 
                    return isSetField(Tags.UnderlyingCurrency);
                }
                public QuickFix.Fields.UnderlyingQty underlyingQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingQty val) 
                { 
                    this.underlyingQty = val;
                }
                
                public QuickFix.Fields.UnderlyingQty get(QuickFix.Fields.UnderlyingQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingQty val) 
                { 
                    return isSetUnderlyingQty();
                }
                
                public bool isSetUnderlyingQty() 
                { 
                    return isSetField(Tags.UnderlyingQty);
                }
                public QuickFix.Fields.UnderlyingPx underlyingPx
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingPx val) 
                { 
                    this.underlyingPx = val;
                }
                
                public QuickFix.Fields.UnderlyingPx get(QuickFix.Fields.UnderlyingPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingPx val) 
                { 
                    return isSetUnderlyingPx();
                }
                
                public bool isSetUnderlyingPx() 
                { 
                    return isSetField(Tags.UnderlyingPx);
                }
                public QuickFix.Fields.UnderlyingDirtyPrice underlyingDirtyPrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    this.underlyingDirtyPrice = val;
                }
                
                public QuickFix.Fields.UnderlyingDirtyPrice get(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    return isSetUnderlyingDirtyPrice();
                }
                
                public bool isSetUnderlyingDirtyPrice() 
                { 
                    return isSetField(Tags.UnderlyingDirtyPrice);
                }
                public QuickFix.Fields.UnderlyingEndPrice underlyingEndPrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    this.underlyingEndPrice = val;
                }
                
                public QuickFix.Fields.UnderlyingEndPrice get(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    return isSetUnderlyingEndPrice();
                }
                
                public bool isSetUnderlyingEndPrice() 
                { 
                    return isSetField(Tags.UnderlyingEndPrice);
                }
                public QuickFix.Fields.UnderlyingStartValue underlyingStartValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    this.underlyingStartValue = val;
                }
                
                public QuickFix.Fields.UnderlyingStartValue get(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    return isSetUnderlyingStartValue();
                }
                
                public bool isSetUnderlyingStartValue() 
                { 
                    return isSetField(Tags.UnderlyingStartValue);
                }
                public QuickFix.Fields.UnderlyingCurrentValue underlyingCurrentValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    this.underlyingCurrentValue = val;
                }
                
                public QuickFix.Fields.UnderlyingCurrentValue get(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    return isSetUnderlyingCurrentValue();
                }
                
                public bool isSetUnderlyingCurrentValue() 
                { 
                    return isSetField(Tags.UnderlyingCurrentValue);
                }
                public QuickFix.Fields.UnderlyingEndValue underlyingEndValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    this.underlyingEndValue = val;
                }
                
                public QuickFix.Fields.UnderlyingEndValue get(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    return isSetUnderlyingEndValue();
                }
                
                public bool isSetUnderlyingEndValue() 
                { 
                    return isSetField(Tags.UnderlyingEndValue);
                }
                public QuickFix.Fields.NoUnderlyingStips noUnderlyingStips
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    this.noUnderlyingStips = val;
                }
                
                public QuickFix.Fields.NoUnderlyingStips get(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    return isSetNoUnderlyingStips();
                }
                
                public bool isSetNoUnderlyingStips() 
                { 
                    return isSetField(Tags.NoUnderlyingStips);
                }
                public QuickFix.Fields.UnderlyingAllocationPercent underlyingAllocationPercent
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAllocationPercent val = new QuickFix.Fields.UnderlyingAllocationPercent();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingAllocationPercent val) 
                { 
                    this.underlyingAllocationPercent = val;
                }
                
                public QuickFix.Fields.UnderlyingAllocationPercent get(QuickFix.Fields.UnderlyingAllocationPercent val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
                { 
                    return isSetUnderlyingAllocationPercent();
                }
                
                public bool isSetUnderlyingAllocationPercent() 
                { 
                    return isSetField(Tags.UnderlyingAllocationPercent);
                }
                public QuickFix.Fields.UnderlyingSettlementType underlyingSettlementType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSettlementType val = new QuickFix.Fields.UnderlyingSettlementType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSettlementType val) 
                { 
                    this.underlyingSettlementType = val;
                }
                
                public QuickFix.Fields.UnderlyingSettlementType get(QuickFix.Fields.UnderlyingSettlementType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSettlementType val) 
                { 
                    return isSetUnderlyingSettlementType();
                }
                
                public bool isSetUnderlyingSettlementType() 
                { 
                    return isSetField(Tags.UnderlyingSettlementType);
                }
                public QuickFix.Fields.UnderlyingCashAmount underlyingCashAmount
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCashAmount val = new QuickFix.Fields.UnderlyingCashAmount();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCashAmount val) 
                { 
                    this.underlyingCashAmount = val;
                }
                
                public QuickFix.Fields.UnderlyingCashAmount get(QuickFix.Fields.UnderlyingCashAmount val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCashAmount val) 
                { 
                    return isSetUnderlyingCashAmount();
                }
                
                public bool isSetUnderlyingCashAmount() 
                { 
                    return isSetField(Tags.UnderlyingCashAmount);
                }
                public QuickFix.Fields.UnderlyingCashType underlyingCashType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCashType val = new QuickFix.Fields.UnderlyingCashType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCashType val) 
                { 
                    this.underlyingCashType = val;
                }
                
                public QuickFix.Fields.UnderlyingCashType get(QuickFix.Fields.UnderlyingCashType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCashType val) 
                { 
                    return isSetUnderlyingCashType();
                }
                
                public bool isSetUnderlyingCashType() 
                { 
                    return isSetField(Tags.UnderlyingCashType);
                }
                public QuickFix.Fields.UnderlyingUnitOfMeasure underlyingUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    this.underlyingUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnderlyingUnitOfMeasure get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    return isSetUnderlyingUnitOfMeasure();
                }
                
                public bool isSetUnderlyingUnitOfMeasure() 
                { 
                    return isSetField(Tags.UnderlyingUnitOfMeasure);
                }
                public QuickFix.Fields.UnderlyingTimeUnit underlyingTimeUnit
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingTimeUnit val = new QuickFix.Fields.UnderlyingTimeUnit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingTimeUnit val) 
                { 
                    this.underlyingTimeUnit = val;
                }
                
                public QuickFix.Fields.UnderlyingTimeUnit get(QuickFix.Fields.UnderlyingTimeUnit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingTimeUnit val) 
                { 
                    return isSetUnderlyingTimeUnit();
                }
                
                public bool isSetUnderlyingTimeUnit() 
                { 
                    return isSetField(Tags.UnderlyingTimeUnit);
                }
                public QuickFix.Fields.UnderlyingCapValue underlyingCapValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCapValue val = new QuickFix.Fields.UnderlyingCapValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingCapValue val) 
                { 
                    this.underlyingCapValue = val;
                }
                
                public QuickFix.Fields.UnderlyingCapValue get(QuickFix.Fields.UnderlyingCapValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingCapValue val) 
                { 
                    return isSetUnderlyingCapValue();
                }
                
                public bool isSetUnderlyingCapValue() 
                { 
                    return isSetField(Tags.UnderlyingCapValue);
                }
                public QuickFix.Fields.NoUndlyInstrumentParties noUndlyInstrumentParties
                { 
                    get 
                    {
                        QuickFix.Fields.NoUndlyInstrumentParties val = new QuickFix.Fields.NoUndlyInstrumentParties();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoUndlyInstrumentParties val) 
                { 
                    this.noUndlyInstrumentParties = val;
                }
                
                public QuickFix.Fields.NoUndlyInstrumentParties get(QuickFix.Fields.NoUndlyInstrumentParties val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
                { 
                    return isSetNoUndlyInstrumentParties();
                }
                
                public bool isSetNoUndlyInstrumentParties() 
                { 
                    return isSetField(Tags.NoUndlyInstrumentParties);
                }
                public QuickFix.Fields.UnderlyingSettlMethod underlyingSettlMethod
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    this.underlyingSettlMethod = val;
                }
                
                public QuickFix.Fields.UnderlyingSettlMethod get(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    return isSetUnderlyingSettlMethod();
                }
                
                public bool isSetUnderlyingSettlMethod() 
                { 
                    return isSetField(Tags.UnderlyingSettlMethod);
                }
                public QuickFix.Fields.UnderlyingAdjustedQuantity underlyingAdjustedQuantity
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAdjustedQuantity val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                { 
                    this.underlyingAdjustedQuantity = val;
                }
                
                public QuickFix.Fields.UnderlyingAdjustedQuantity get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                { 
                    return isSetUnderlyingAdjustedQuantity();
                }
                
                public bool isSetUnderlyingAdjustedQuantity() 
                { 
                    return isSetField(Tags.UnderlyingAdjustedQuantity);
                }
                public QuickFix.Fields.UnderlyingFXRate underlyingFXRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFXRate val = new QuickFix.Fields.UnderlyingFXRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingFXRate val) 
                { 
                    this.underlyingFXRate = val;
                }
                
                public QuickFix.Fields.UnderlyingFXRate get(QuickFix.Fields.UnderlyingFXRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingFXRate val) 
                { 
                    return isSetUnderlyingFXRate();
                }
                
                public bool isSetUnderlyingFXRate() 
                { 
                    return isSetField(Tags.UnderlyingFXRate);
                }
                public QuickFix.Fields.UnderlyingFXRateCalc underlyingFXRateCalc
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFXRateCalc val = new QuickFix.Fields.UnderlyingFXRateCalc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingFXRateCalc val) 
                { 
                    this.underlyingFXRateCalc = val;
                }
                
                public QuickFix.Fields.UnderlyingFXRateCalc get(QuickFix.Fields.UnderlyingFXRateCalc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
                { 
                    return isSetUnderlyingFXRateCalc();
                }
                
                public bool isSetUnderlyingFXRateCalc() 
                { 
                    return isSetField(Tags.UnderlyingFXRateCalc);
                }
                public QuickFix.Fields.UnderlyingMaturityTime underlyingMaturityTime
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityTime val = new QuickFix.Fields.UnderlyingMaturityTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingMaturityTime val) 
                { 
                    this.underlyingMaturityTime = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityTime get(QuickFix.Fields.UnderlyingMaturityTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingMaturityTime val) 
                { 
                    return isSetUnderlyingMaturityTime();
                }
                
                public bool isSetUnderlyingMaturityTime() 
                { 
                    return isSetField(Tags.UnderlyingMaturityTime);
                }
                public QuickFix.Fields.UnderlyingPutOrCall underlyingPutOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    this.underlyingPutOrCall = val;
                }
                
                public QuickFix.Fields.UnderlyingPutOrCall get(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    return isSetUnderlyingPutOrCall();
                }
                
                public bool isSetUnderlyingPutOrCall() 
                { 
                    return isSetField(Tags.UnderlyingPutOrCall);
                }
                public QuickFix.Fields.UnderlyingExerciseStyle underlyingExerciseStyle
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingExerciseStyle val = new QuickFix.Fields.UnderlyingExerciseStyle();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingExerciseStyle val) 
                { 
                    this.underlyingExerciseStyle = val;
                }
                
                public QuickFix.Fields.UnderlyingExerciseStyle get(QuickFix.Fields.UnderlyingExerciseStyle val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
                { 
                    return isSetUnderlyingExerciseStyle();
                }
                
                public bool isSetUnderlyingExerciseStyle() 
                { 
                    return isSetField(Tags.UnderlyingExerciseStyle);
                }
                public QuickFix.Fields.UnderlyingUnitOfMeasureQty underlyingUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                { 
                    this.underlyingUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.UnderlyingUnitOfMeasureQty get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                { 
                    return isSetUnderlyingUnitOfMeasureQty();
                }
                
                public bool isSetUnderlyingUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.UnderlyingUnitOfMeasureQty);
                }
                public QuickFix.Fields.UnderlyingPriceUnitOfMeasure underlyingPriceUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPriceUnitOfMeasure val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                { 
                    this.underlyingPriceUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnderlyingPriceUnitOfMeasure get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                { 
                    return isSetUnderlyingPriceUnitOfMeasure();
                }
                
                public bool isSetUnderlyingPriceUnitOfMeasure() 
                { 
                    return isSetField(Tags.UnderlyingPriceUnitOfMeasure);
                }
                public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty underlyingPriceUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                { 
                    this.underlyingPriceUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                { 
                    return isSetUnderlyingPriceUnitOfMeasureQty();
                }
                
                public bool isSetUnderlyingPriceUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.UnderlyingPriceUnitOfMeasureQty);
                }
                            public class NoUnderlyingSecurityAltID : Group
                {
                    public NoUnderlyingSecurityAltID() 
                      :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
                                    public QuickFix.Fields.UnderlyingSecurityAltID underlyingSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        this.underlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityAltID get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        return isSetUnderlyingSecurityAltID();
                    }
                    
                    public bool isSetUnderlyingSecurityAltID() 
                    { 
                        return isSetField(Tags.UnderlyingSecurityAltID);
                    }
                    public QuickFix.Fields.UnderlyingSecurityAltIDSource underlyingSecurityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        this.underlyingSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityAltIDSource get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        return isSetUnderlyingSecurityAltIDSource();
                    }
                    
                    public bool isSetUnderlyingSecurityAltIDSource() 
                    { 
                        return isSetField(Tags.UnderlyingSecurityAltIDSource);
                    }
                
                }
                public class NoUnderlyingStips : Group
                {
                    public NoUnderlyingStips() 
                      :base( Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};
                                    public QuickFix.Fields.UnderlyingStipType underlyingStipType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        this.underlyingStipType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStipType get(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        return isSetUnderlyingStipType();
                    }
                    
                    public bool isSetUnderlyingStipType() 
                    { 
                        return isSetField(Tags.UnderlyingStipType);
                    }
                    public QuickFix.Fields.UnderlyingStipValue underlyingStipValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        this.underlyingStipValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStipValue get(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        return isSetUnderlyingStipValue();
                    }
                    
                    public bool isSetUnderlyingStipValue() 
                    { 
                        return isSetField(Tags.UnderlyingStipValue);
                    }
                
                }
                public class NoUndlyInstrumentParties : Group
                {
                    public NoUndlyInstrumentParties() 
                      :base( Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
                                    public QuickFix.Fields.UndlyInstrumentPartyID undlyInstrumentPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.UndlyInstrumentPartyID val = new QuickFix.Fields.UndlyInstrumentPartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UndlyInstrumentPartyID val) 
                    { 
                        this.undlyInstrumentPartyID = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartyID get(QuickFix.Fields.UndlyInstrumentPartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UndlyInstrumentPartyID val) 
                    { 
                        return isSetUndlyInstrumentPartyID();
                    }
                    
                    public bool isSetUndlyInstrumentPartyID() 
                    { 
                        return isSetField(Tags.UndlyInstrumentPartyID);
                    }
                    public QuickFix.Fields.UndlyInstrumentPartyIDSource undlyInstrumentPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.UndlyInstrumentPartyIDSource val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                    { 
                        this.undlyInstrumentPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartyIDSource get(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                    { 
                        return isSetUndlyInstrumentPartyIDSource();
                    }
                    
                    public bool isSetUndlyInstrumentPartyIDSource() 
                    { 
                        return isSetField(Tags.UndlyInstrumentPartyIDSource);
                    }
                    public QuickFix.Fields.UndlyInstrumentPartyRole undlyInstrumentPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.UndlyInstrumentPartyRole val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                    { 
                        this.undlyInstrumentPartyRole = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartyRole get(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                    { 
                        return isSetUndlyInstrumentPartyRole();
                    }
                    
                    public bool isSetUndlyInstrumentPartyRole() 
                    { 
                        return isSetField(Tags.UndlyInstrumentPartyRole);
                    }
                    public QuickFix.Fields.NoUndlyInstrumentPartySubIDs noUndlyInstrumentPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUndlyInstrumentPartySubIDs val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                    { 
                        this.noUndlyInstrumentPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoUndlyInstrumentPartySubIDs get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                    { 
                        return isSetNoUndlyInstrumentPartySubIDs();
                    }
                    
                    public bool isSetNoUndlyInstrumentPartySubIDs() 
                    { 
                        return isSetField(Tags.NoUndlyInstrumentPartySubIDs);
                    }
                                    public class NoUndlyInstrumentPartySubIDs : Group
                    {
                        public NoUndlyInstrumentPartySubIDs() 
                          :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};
                                            public QuickFix.Fields.UndlyInstrumentPartySubID undlyInstrumentPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.UndlyInstrumentPartySubID val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                        { 
                            this.undlyInstrumentPartySubID = val;
                        }
                        
                        public QuickFix.Fields.UndlyInstrumentPartySubID get(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                        { 
                            return isSetUndlyInstrumentPartySubID();
                        }
                        
                        public bool isSetUndlyInstrumentPartySubID() 
                        { 
                            return isSetField(Tags.UndlyInstrumentPartySubID);
                        }
                        public QuickFix.Fields.UndlyInstrumentPartySubIDType undlyInstrumentPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.UndlyInstrumentPartySubIDType val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                        { 
                            this.undlyInstrumentPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.UndlyInstrumentPartySubIDType get(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                        { 
                            return isSetUndlyInstrumentPartySubIDType();
                        }
                        
                        public bool isSetUndlyInstrumentPartySubIDType() 
                        { 
                            return isSetField(Tags.UndlyInstrumentPartySubIDType);
                        }
                    
                    }
                }
            }
            public class NoPosAmt : Group
            {
                public NoPosAmt() 
                  :base( Tags.NoPosAmt, Tags.PosAmtType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PosAmtType, Tags.PosAmt, Tags.PositionCurrency, 0};
                            public QuickFix.Fields.PosAmtType posAmtType
                { 
                    get 
                    {
                        QuickFix.Fields.PosAmtType val = new QuickFix.Fields.PosAmtType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PosAmtType val) 
                { 
                    this.posAmtType = val;
                }
                
                public QuickFix.Fields.PosAmtType get(QuickFix.Fields.PosAmtType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PosAmtType val) 
                { 
                    return isSetPosAmtType();
                }
                
                public bool isSetPosAmtType() 
                { 
                    return isSetField(Tags.PosAmtType);
                }
                public QuickFix.Fields.PosAmt posAmt
                { 
                    get 
                    {
                        QuickFix.Fields.PosAmt val = new QuickFix.Fields.PosAmt();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PosAmt val) 
                { 
                    this.posAmt = val;
                }
                
                public QuickFix.Fields.PosAmt get(QuickFix.Fields.PosAmt val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PosAmt val) 
                { 
                    return isSetPosAmt();
                }
                
                public bool isSetPosAmt() 
                { 
                    return isSetField(Tags.PosAmt);
                }
                public QuickFix.Fields.PositionCurrency positionCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.PositionCurrency val = new QuickFix.Fields.PositionCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PositionCurrency val) 
                { 
                    this.positionCurrency = val;
                }
                
                public QuickFix.Fields.PositionCurrency get(QuickFix.Fields.PositionCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PositionCurrency val) 
                { 
                    return isSetPositionCurrency();
                }
                
                public bool isSetPositionCurrency() 
                { 
                    return isSetField(Tags.PositionCurrency);
                }
            
            }
            public class NoLegs : Group
            {
                public NoLegs() 
                  :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegReportID, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, Tags.LegNumber, Tags.NoOfLegUnderlyings, Tags.LegVolatility, Tags.LegDividendYield, Tags.LegCurrencyRatio, Tags.LegExecInst, Tags.LegLastQty, 0};
                            public QuickFix.Fields.LegSymbol legSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSymbol val) 
                { 
                    this.legSymbol = val;
                }
                
                public QuickFix.Fields.LegSymbol get(QuickFix.Fields.LegSymbol val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSymbol val) 
                { 
                    return isSetLegSymbol();
                }
                
                public bool isSetLegSymbol() 
                { 
                    return isSetField(Tags.LegSymbol);
                }
                public QuickFix.Fields.LegSymbolSfx legSymbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    this.legSymbolSfx = val;
                }
                
                public QuickFix.Fields.LegSymbolSfx get(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    return isSetLegSymbolSfx();
                }
                
                public bool isSetLegSymbolSfx() 
                { 
                    return isSetField(Tags.LegSymbolSfx);
                }
                public QuickFix.Fields.LegSecurityID legSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityID val) 
                { 
                    this.legSecurityID = val;
                }
                
                public QuickFix.Fields.LegSecurityID get(QuickFix.Fields.LegSecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityID val) 
                { 
                    return isSetLegSecurityID();
                }
                
                public bool isSetLegSecurityID() 
                { 
                    return isSetField(Tags.LegSecurityID);
                }
                public QuickFix.Fields.LegSecurityIDSource legSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    this.legSecurityIDSource = val;
                }
                
                public QuickFix.Fields.LegSecurityIDSource get(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    return isSetLegSecurityIDSource();
                }
                
                public bool isSetLegSecurityIDSource() 
                { 
                    return isSetField(Tags.LegSecurityIDSource);
                }
                public QuickFix.Fields.NoLegSecurityAltID noLegSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    this.noLegSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoLegSecurityAltID get(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    return isSetNoLegSecurityAltID();
                }
                
                public bool isSetNoLegSecurityAltID() 
                { 
                    return isSetField(Tags.NoLegSecurityAltID);
                }
                public QuickFix.Fields.LegProduct legProduct
                { 
                    get 
                    {
                        QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegProduct val) 
                { 
                    this.legProduct = val;
                }
                
                public QuickFix.Fields.LegProduct get(QuickFix.Fields.LegProduct val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegProduct val) 
                { 
                    return isSetLegProduct();
                }
                
                public bool isSetLegProduct() 
                { 
                    return isSetField(Tags.LegProduct);
                }
                public QuickFix.Fields.LegCFICode legCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCFICode val) 
                { 
                    this.legCFICode = val;
                }
                
                public QuickFix.Fields.LegCFICode get(QuickFix.Fields.LegCFICode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCFICode val) 
                { 
                    return isSetLegCFICode();
                }
                
                public bool isSetLegCFICode() 
                { 
                    return isSetField(Tags.LegCFICode);
                }
                public QuickFix.Fields.LegSecurityType legSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityType val) 
                { 
                    this.legSecurityType = val;
                }
                
                public QuickFix.Fields.LegSecurityType get(QuickFix.Fields.LegSecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityType val) 
                { 
                    return isSetLegSecurityType();
                }
                
                public bool isSetLegSecurityType() 
                { 
                    return isSetField(Tags.LegSecurityType);
                }
                public QuickFix.Fields.LegSecuritySubType legSecuritySubType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    this.legSecuritySubType = val;
                }
                
                public QuickFix.Fields.LegSecuritySubType get(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    return isSetLegSecuritySubType();
                }
                
                public bool isSetLegSecuritySubType() 
                { 
                    return isSetField(Tags.LegSecuritySubType);
                }
                public QuickFix.Fields.LegMaturityMonthYear legMaturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    this.legMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.LegMaturityMonthYear get(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    return isSetLegMaturityMonthYear();
                }
                
                public bool isSetLegMaturityMonthYear() 
                { 
                    return isSetField(Tags.LegMaturityMonthYear);
                }
                public QuickFix.Fields.LegMaturityDate legMaturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegMaturityDate val) 
                { 
                    this.legMaturityDate = val;
                }
                
                public QuickFix.Fields.LegMaturityDate get(QuickFix.Fields.LegMaturityDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegMaturityDate val) 
                { 
                    return isSetLegMaturityDate();
                }
                
                public bool isSetLegMaturityDate() 
                { 
                    return isSetField(Tags.LegMaturityDate);
                }
                public QuickFix.Fields.LegCouponPaymentDate legCouponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    this.legCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.LegCouponPaymentDate get(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    return isSetLegCouponPaymentDate();
                }
                
                public bool isSetLegCouponPaymentDate() 
                { 
                    return isSetField(Tags.LegCouponPaymentDate);
                }
                public QuickFix.Fields.LegIssueDate legIssueDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegIssueDate val) 
                { 
                    this.legIssueDate = val;
                }
                
                public QuickFix.Fields.LegIssueDate get(QuickFix.Fields.LegIssueDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegIssueDate val) 
                { 
                    return isSetLegIssueDate();
                }
                
                public bool isSetLegIssueDate() 
                { 
                    return isSetField(Tags.LegIssueDate);
                }
                public QuickFix.Fields.LegRepoCollateralSecurityType legRepoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    this.legRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.LegRepoCollateralSecurityType get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return isSetLegRepoCollateralSecurityType();
                }
                
                public bool isSetLegRepoCollateralSecurityType() 
                { 
                    return isSetField(Tags.LegRepoCollateralSecurityType);
                }
                public QuickFix.Fields.LegRepurchaseTerm legRepurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    this.legRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.LegRepurchaseTerm get(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    return isSetLegRepurchaseTerm();
                }
                
                public bool isSetLegRepurchaseTerm() 
                { 
                    return isSetField(Tags.LegRepurchaseTerm);
                }
                public QuickFix.Fields.LegRepurchaseRate legRepurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    this.legRepurchaseRate = val;
                }
                
                public QuickFix.Fields.LegRepurchaseRate get(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    return isSetLegRepurchaseRate();
                }
                
                public bool isSetLegRepurchaseRate() 
                { 
                    return isSetField(Tags.LegRepurchaseRate);
                }
                public QuickFix.Fields.LegFactor legFactor
                { 
                    get 
                    {
                        QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegFactor val) 
                { 
                    this.legFactor = val;
                }
                
                public QuickFix.Fields.LegFactor get(QuickFix.Fields.LegFactor val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegFactor val) 
                { 
                    return isSetLegFactor();
                }
                
                public bool isSetLegFactor() 
                { 
                    return isSetField(Tags.LegFactor);
                }
                public QuickFix.Fields.LegCreditRating legCreditRating
                { 
                    get 
                    {
                        QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCreditRating val) 
                { 
                    this.legCreditRating = val;
                }
                
                public QuickFix.Fields.LegCreditRating get(QuickFix.Fields.LegCreditRating val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCreditRating val) 
                { 
                    return isSetLegCreditRating();
                }
                
                public bool isSetLegCreditRating() 
                { 
                    return isSetField(Tags.LegCreditRating);
                }
                public QuickFix.Fields.LegInstrRegistry legInstrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    this.legInstrRegistry = val;
                }
                
                public QuickFix.Fields.LegInstrRegistry get(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    return isSetLegInstrRegistry();
                }
                
                public bool isSetLegInstrRegistry() 
                { 
                    return isSetField(Tags.LegInstrRegistry);
                }
                public QuickFix.Fields.LegCountryOfIssue legCountryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    this.legCountryOfIssue = val;
                }
                
                public QuickFix.Fields.LegCountryOfIssue get(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    return isSetLegCountryOfIssue();
                }
                
                public bool isSetLegCountryOfIssue() 
                { 
                    return isSetField(Tags.LegCountryOfIssue);
                }
                public QuickFix.Fields.LegStateOrProvinceOfIssue legStateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    this.legStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.LegStateOrProvinceOfIssue get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return isSetLegStateOrProvinceOfIssue();
                }
                
                public bool isSetLegStateOrProvinceOfIssue() 
                { 
                    return isSetField(Tags.LegStateOrProvinceOfIssue);
                }
                public QuickFix.Fields.LegLocaleOfIssue legLocaleOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    this.legLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.LegLocaleOfIssue get(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    return isSetLegLocaleOfIssue();
                }
                
                public bool isSetLegLocaleOfIssue() 
                { 
                    return isSetField(Tags.LegLocaleOfIssue);
                }
                public QuickFix.Fields.LegRedemptionDate legRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    this.legRedemptionDate = val;
                }
                
                public QuickFix.Fields.LegRedemptionDate get(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    return isSetLegRedemptionDate();
                }
                
                public bool isSetLegRedemptionDate() 
                { 
                    return isSetField(Tags.LegRedemptionDate);
                }
                public QuickFix.Fields.LegStrikePrice legStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegStrikePrice val) 
                { 
                    this.legStrikePrice = val;
                }
                
                public QuickFix.Fields.LegStrikePrice get(QuickFix.Fields.LegStrikePrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegStrikePrice val) 
                { 
                    return isSetLegStrikePrice();
                }
                
                public bool isSetLegStrikePrice() 
                { 
                    return isSetField(Tags.LegStrikePrice);
                }
                public QuickFix.Fields.LegStrikeCurrency legStrikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.LegStrikeCurrency val = new QuickFix.Fields.LegStrikeCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    this.legStrikeCurrency = val;
                }
                
                public QuickFix.Fields.LegStrikeCurrency get(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    return isSetLegStrikeCurrency();
                }
                
                public bool isSetLegStrikeCurrency() 
                { 
                    return isSetField(Tags.LegStrikeCurrency);
                }
                public QuickFix.Fields.LegOptAttribute legOptAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegOptAttribute val) 
                { 
                    this.legOptAttribute = val;
                }
                
                public QuickFix.Fields.LegOptAttribute get(QuickFix.Fields.LegOptAttribute val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegOptAttribute val) 
                { 
                    return isSetLegOptAttribute();
                }
                
                public bool isSetLegOptAttribute() 
                { 
                    return isSetField(Tags.LegOptAttribute);
                }
                public QuickFix.Fields.LegContractMultiplier legContractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    this.legContractMultiplier = val;
                }
                
                public QuickFix.Fields.LegContractMultiplier get(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    return isSetLegContractMultiplier();
                }
                
                public bool isSetLegContractMultiplier() 
                { 
                    return isSetField(Tags.LegContractMultiplier);
                }
                public QuickFix.Fields.LegCouponRate legCouponRate
                { 
                    get 
                    {
                        QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCouponRate val) 
                { 
                    this.legCouponRate = val;
                }
                
                public QuickFix.Fields.LegCouponRate get(QuickFix.Fields.LegCouponRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCouponRate val) 
                { 
                    return isSetLegCouponRate();
                }
                
                public bool isSetLegCouponRate() 
                { 
                    return isSetField(Tags.LegCouponRate);
                }
                public QuickFix.Fields.LegSecurityExchange legSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    this.legSecurityExchange = val;
                }
                
                public QuickFix.Fields.LegSecurityExchange get(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    return isSetLegSecurityExchange();
                }
                
                public bool isSetLegSecurityExchange() 
                { 
                    return isSetField(Tags.LegSecurityExchange);
                }
                public QuickFix.Fields.LegIssuer legIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegIssuer val) 
                { 
                    this.legIssuer = val;
                }
                
                public QuickFix.Fields.LegIssuer get(QuickFix.Fields.LegIssuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegIssuer val) 
                { 
                    return isSetLegIssuer();
                }
                
                public bool isSetLegIssuer() 
                { 
                    return isSetField(Tags.LegIssuer);
                }
                public QuickFix.Fields.EncodedLegIssuerLen encodedLegIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    this.encodedLegIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuerLen get(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    return isSetEncodedLegIssuerLen();
                }
                
                public bool isSetEncodedLegIssuerLen() 
                { 
                    return isSetField(Tags.EncodedLegIssuerLen);
                }
                public QuickFix.Fields.EncodedLegIssuer encodedLegIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    this.encodedLegIssuer = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuer get(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    return isSetEncodedLegIssuer();
                }
                
                public bool isSetEncodedLegIssuer() 
                { 
                    return isSetField(Tags.EncodedLegIssuer);
                }
                public QuickFix.Fields.LegSecurityDesc legSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    this.legSecurityDesc = val;
                }
                
                public QuickFix.Fields.LegSecurityDesc get(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    return isSetLegSecurityDesc();
                }
                
                public bool isSetLegSecurityDesc() 
                { 
                    return isSetField(Tags.LegSecurityDesc);
                }
                public QuickFix.Fields.EncodedLegSecurityDescLen encodedLegSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    this.encodedLegSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDescLen get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return isSetEncodedLegSecurityDescLen();
                }
                
                public bool isSetEncodedLegSecurityDescLen() 
                { 
                    return isSetField(Tags.EncodedLegSecurityDescLen);
                }
                public QuickFix.Fields.EncodedLegSecurityDesc encodedLegSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    this.encodedLegSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDesc get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    return isSetEncodedLegSecurityDesc();
                }
                
                public bool isSetEncodedLegSecurityDesc() 
                { 
                    return isSetField(Tags.EncodedLegSecurityDesc);
                }
                public QuickFix.Fields.LegRatioQty legRatioQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRatioQty val) 
                { 
                    this.legRatioQty = val;
                }
                
                public QuickFix.Fields.LegRatioQty get(QuickFix.Fields.LegRatioQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRatioQty val) 
                { 
                    return isSetLegRatioQty();
                }
                
                public bool isSetLegRatioQty() 
                { 
                    return isSetField(Tags.LegRatioQty);
                }
                public QuickFix.Fields.LegSide legSide
                { 
                    get 
                    {
                        QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSide val) 
                { 
                    this.legSide = val;
                }
                
                public QuickFix.Fields.LegSide get(QuickFix.Fields.LegSide val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSide val) 
                { 
                    return isSetLegSide();
                }
                
                public bool isSetLegSide() 
                { 
                    return isSetField(Tags.LegSide);
                }
                public QuickFix.Fields.LegCurrency legCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.LegCurrency val = new QuickFix.Fields.LegCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCurrency val) 
                { 
                    this.legCurrency = val;
                }
                
                public QuickFix.Fields.LegCurrency get(QuickFix.Fields.LegCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCurrency val) 
                { 
                    return isSetLegCurrency();
                }
                
                public bool isSetLegCurrency() 
                { 
                    return isSetField(Tags.LegCurrency);
                }
                public QuickFix.Fields.LegPool legPool
                { 
                    get 
                    {
                        QuickFix.Fields.LegPool val = new QuickFix.Fields.LegPool();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegPool val) 
                { 
                    this.legPool = val;
                }
                
                public QuickFix.Fields.LegPool get(QuickFix.Fields.LegPool val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegPool val) 
                { 
                    return isSetLegPool();
                }
                
                public bool isSetLegPool() 
                { 
                    return isSetField(Tags.LegPool);
                }
                public QuickFix.Fields.LegDatedDate legDatedDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegDatedDate val = new QuickFix.Fields.LegDatedDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegDatedDate val) 
                { 
                    this.legDatedDate = val;
                }
                
                public QuickFix.Fields.LegDatedDate get(QuickFix.Fields.LegDatedDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegDatedDate val) 
                { 
                    return isSetLegDatedDate();
                }
                
                public bool isSetLegDatedDate() 
                { 
                    return isSetField(Tags.LegDatedDate);
                }
                public QuickFix.Fields.LegContractSettlMonth legContractSettlMonth
                { 
                    get 
                    {
                        QuickFix.Fields.LegContractSettlMonth val = new QuickFix.Fields.LegContractSettlMonth();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    this.legContractSettlMonth = val;
                }
                
                public QuickFix.Fields.LegContractSettlMonth get(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    return isSetLegContractSettlMonth();
                }
                
                public bool isSetLegContractSettlMonth() 
                { 
                    return isSetField(Tags.LegContractSettlMonth);
                }
                public QuickFix.Fields.LegInterestAccrualDate legInterestAccrualDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegInterestAccrualDate val = new QuickFix.Fields.LegInterestAccrualDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    this.legInterestAccrualDate = val;
                }
                
                public QuickFix.Fields.LegInterestAccrualDate get(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    return isSetLegInterestAccrualDate();
                }
                
                public bool isSetLegInterestAccrualDate() 
                { 
                    return isSetField(Tags.LegInterestAccrualDate);
                }
                public QuickFix.Fields.LegUnitOfMeasure legUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.LegUnitOfMeasure val = new QuickFix.Fields.LegUnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegUnitOfMeasure val) 
                { 
                    this.legUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.LegUnitOfMeasure get(QuickFix.Fields.LegUnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegUnitOfMeasure val) 
                { 
                    return isSetLegUnitOfMeasure();
                }
                
                public bool isSetLegUnitOfMeasure() 
                { 
                    return isSetField(Tags.LegUnitOfMeasure);
                }
                public QuickFix.Fields.LegTimeUnit legTimeUnit
                { 
                    get 
                    {
                        QuickFix.Fields.LegTimeUnit val = new QuickFix.Fields.LegTimeUnit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegTimeUnit val) 
                { 
                    this.legTimeUnit = val;
                }
                
                public QuickFix.Fields.LegTimeUnit get(QuickFix.Fields.LegTimeUnit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegTimeUnit val) 
                { 
                    return isSetLegTimeUnit();
                }
                
                public bool isSetLegTimeUnit() 
                { 
                    return isSetField(Tags.LegTimeUnit);
                }
                public QuickFix.Fields.LegOptionRatio legOptionRatio
                { 
                    get 
                    {
                        QuickFix.Fields.LegOptionRatio val = new QuickFix.Fields.LegOptionRatio();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegOptionRatio val) 
                { 
                    this.legOptionRatio = val;
                }
                
                public QuickFix.Fields.LegOptionRatio get(QuickFix.Fields.LegOptionRatio val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegOptionRatio val) 
                { 
                    return isSetLegOptionRatio();
                }
                
                public bool isSetLegOptionRatio() 
                { 
                    return isSetField(Tags.LegOptionRatio);
                }
                public QuickFix.Fields.LegPrice legPrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegPrice val = new QuickFix.Fields.LegPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegPrice val) 
                { 
                    this.legPrice = val;
                }
                
                public QuickFix.Fields.LegPrice get(QuickFix.Fields.LegPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegPrice val) 
                { 
                    return isSetLegPrice();
                }
                
                public bool isSetLegPrice() 
                { 
                    return isSetField(Tags.LegPrice);
                }
                public QuickFix.Fields.LegMaturityTime legMaturityTime
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityTime val = new QuickFix.Fields.LegMaturityTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegMaturityTime val) 
                { 
                    this.legMaturityTime = val;
                }
                
                public QuickFix.Fields.LegMaturityTime get(QuickFix.Fields.LegMaturityTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegMaturityTime val) 
                { 
                    return isSetLegMaturityTime();
                }
                
                public bool isSetLegMaturityTime() 
                { 
                    return isSetField(Tags.LegMaturityTime);
                }
                public QuickFix.Fields.LegPutOrCall legPutOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.LegPutOrCall val = new QuickFix.Fields.LegPutOrCall();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegPutOrCall val) 
                { 
                    this.legPutOrCall = val;
                }
                
                public QuickFix.Fields.LegPutOrCall get(QuickFix.Fields.LegPutOrCall val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegPutOrCall val) 
                { 
                    return isSetLegPutOrCall();
                }
                
                public bool isSetLegPutOrCall() 
                { 
                    return isSetField(Tags.LegPutOrCall);
                }
                public QuickFix.Fields.LegExerciseStyle legExerciseStyle
                { 
                    get 
                    {
                        QuickFix.Fields.LegExerciseStyle val = new QuickFix.Fields.LegExerciseStyle();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegExerciseStyle val) 
                { 
                    this.legExerciseStyle = val;
                }
                
                public QuickFix.Fields.LegExerciseStyle get(QuickFix.Fields.LegExerciseStyle val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegExerciseStyle val) 
                { 
                    return isSetLegExerciseStyle();
                }
                
                public bool isSetLegExerciseStyle() 
                { 
                    return isSetField(Tags.LegExerciseStyle);
                }
                public QuickFix.Fields.LegUnitOfMeasureQty legUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegUnitOfMeasureQty val = new QuickFix.Fields.LegUnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegUnitOfMeasureQty val) 
                { 
                    this.legUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.LegUnitOfMeasureQty get(QuickFix.Fields.LegUnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegUnitOfMeasureQty val) 
                { 
                    return isSetLegUnitOfMeasureQty();
                }
                
                public bool isSetLegUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.LegUnitOfMeasureQty);
                }
                public QuickFix.Fields.LegPriceUnitOfMeasure legPriceUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.LegPriceUnitOfMeasure val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                { 
                    this.legPriceUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.LegPriceUnitOfMeasure get(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                { 
                    return isSetLegPriceUnitOfMeasure();
                }
                
                public bool isSetLegPriceUnitOfMeasure() 
                { 
                    return isSetField(Tags.LegPriceUnitOfMeasure);
                }
                public QuickFix.Fields.LegPriceUnitOfMeasureQty legPriceUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegPriceUnitOfMeasureQty val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                { 
                    this.legPriceUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.LegPriceUnitOfMeasureQty get(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                { 
                    return isSetLegPriceUnitOfMeasureQty();
                }
                
                public bool isSetLegPriceUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.LegPriceUnitOfMeasureQty);
                }
                public QuickFix.Fields.LegQty legQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegQty val = new QuickFix.Fields.LegQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegQty val) 
                { 
                    this.legQty = val;
                }
                
                public QuickFix.Fields.LegQty get(QuickFix.Fields.LegQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegQty val) 
                { 
                    return isSetLegQty();
                }
                
                public bool isSetLegQty() 
                { 
                    return isSetField(Tags.LegQty);
                }
                public QuickFix.Fields.LegSwapType legSwapType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSwapType val = new QuickFix.Fields.LegSwapType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSwapType val) 
                { 
                    this.legSwapType = val;
                }
                
                public QuickFix.Fields.LegSwapType get(QuickFix.Fields.LegSwapType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSwapType val) 
                { 
                    return isSetLegSwapType();
                }
                
                public bool isSetLegSwapType() 
                { 
                    return isSetField(Tags.LegSwapType);
                }
                public QuickFix.Fields.NoLegStipulations noLegStipulations
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegStipulations val = new QuickFix.Fields.NoLegStipulations();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoLegStipulations val) 
                { 
                    this.noLegStipulations = val;
                }
                
                public QuickFix.Fields.NoLegStipulations get(QuickFix.Fields.NoLegStipulations val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoLegStipulations val) 
                { 
                    return isSetNoLegStipulations();
                }
                
                public bool isSetNoLegStipulations() 
                { 
                    return isSetField(Tags.NoLegStipulations);
                }
                public QuickFix.Fields.LegPositionEffect legPositionEffect
                { 
                    get 
                    {
                        QuickFix.Fields.LegPositionEffect val = new QuickFix.Fields.LegPositionEffect();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegPositionEffect val) 
                { 
                    this.legPositionEffect = val;
                }
                
                public QuickFix.Fields.LegPositionEffect get(QuickFix.Fields.LegPositionEffect val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegPositionEffect val) 
                { 
                    return isSetLegPositionEffect();
                }
                
                public bool isSetLegPositionEffect() 
                { 
                    return isSetField(Tags.LegPositionEffect);
                }
                public QuickFix.Fields.LegCoveredOrUncovered legCoveredOrUncovered
                { 
                    get 
                    {
                        QuickFix.Fields.LegCoveredOrUncovered val = new QuickFix.Fields.LegCoveredOrUncovered();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    this.legCoveredOrUncovered = val;
                }
                
                public QuickFix.Fields.LegCoveredOrUncovered get(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    return isSetLegCoveredOrUncovered();
                }
                
                public bool isSetLegCoveredOrUncovered() 
                { 
                    return isSetField(Tags.LegCoveredOrUncovered);
                }
                public QuickFix.Fields.NoNestedPartyIDs noNestedPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNestedPartyIDs val = new QuickFix.Fields.NoNestedPartyIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    this.noNestedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoNestedPartyIDs get(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    return isSetNoNestedPartyIDs();
                }
                
                public bool isSetNoNestedPartyIDs() 
                { 
                    return isSetField(Tags.NoNestedPartyIDs);
                }
                public QuickFix.Fields.LegRefID legRefID
                { 
                    get 
                    {
                        QuickFix.Fields.LegRefID val = new QuickFix.Fields.LegRefID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRefID val) 
                { 
                    this.legRefID = val;
                }
                
                public QuickFix.Fields.LegRefID get(QuickFix.Fields.LegRefID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRefID val) 
                { 
                    return isSetLegRefID();
                }
                
                public bool isSetLegRefID() 
                { 
                    return isSetField(Tags.LegRefID);
                }
                public QuickFix.Fields.LegSettlType legSettlType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSettlType val = new QuickFix.Fields.LegSettlType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSettlType val) 
                { 
                    this.legSettlType = val;
                }
                
                public QuickFix.Fields.LegSettlType get(QuickFix.Fields.LegSettlType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSettlType val) 
                { 
                    return isSetLegSettlType();
                }
                
                public bool isSetLegSettlType() 
                { 
                    return isSetField(Tags.LegSettlType);
                }
                public QuickFix.Fields.LegSettlDate legSettlDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegSettlDate val = new QuickFix.Fields.LegSettlDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSettlDate val) 
                { 
                    this.legSettlDate = val;
                }
                
                public QuickFix.Fields.LegSettlDate get(QuickFix.Fields.LegSettlDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSettlDate val) 
                { 
                    return isSetLegSettlDate();
                }
                
                public bool isSetLegSettlDate() 
                { 
                    return isSetField(Tags.LegSettlDate);
                }
                public QuickFix.Fields.LegLastPx legLastPx
                { 
                    get 
                    {
                        QuickFix.Fields.LegLastPx val = new QuickFix.Fields.LegLastPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegLastPx val) 
                { 
                    this.legLastPx = val;
                }
                
                public QuickFix.Fields.LegLastPx get(QuickFix.Fields.LegLastPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegLastPx val) 
                { 
                    return isSetLegLastPx();
                }
                
                public bool isSetLegLastPx() 
                { 
                    return isSetField(Tags.LegLastPx);
                }
                public QuickFix.Fields.LegReportID legReportID
                { 
                    get 
                    {
                        QuickFix.Fields.LegReportID val = new QuickFix.Fields.LegReportID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegReportID val) 
                { 
                    this.legReportID = val;
                }
                
                public QuickFix.Fields.LegReportID get(QuickFix.Fields.LegReportID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegReportID val) 
                { 
                    return isSetLegReportID();
                }
                
                public bool isSetLegReportID() 
                { 
                    return isSetField(Tags.LegReportID);
                }
                public QuickFix.Fields.LegSettlCurrency legSettlCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.LegSettlCurrency val = new QuickFix.Fields.LegSettlCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSettlCurrency val) 
                { 
                    this.legSettlCurrency = val;
                }
                
                public QuickFix.Fields.LegSettlCurrency get(QuickFix.Fields.LegSettlCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSettlCurrency val) 
                { 
                    return isSetLegSettlCurrency();
                }
                
                public bool isSetLegSettlCurrency() 
                { 
                    return isSetField(Tags.LegSettlCurrency);
                }
                public QuickFix.Fields.LegLastForwardPoints legLastForwardPoints
                { 
                    get 
                    {
                        QuickFix.Fields.LegLastForwardPoints val = new QuickFix.Fields.LegLastForwardPoints();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegLastForwardPoints val) 
                { 
                    this.legLastForwardPoints = val;
                }
                
                public QuickFix.Fields.LegLastForwardPoints get(QuickFix.Fields.LegLastForwardPoints val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegLastForwardPoints val) 
                { 
                    return isSetLegLastForwardPoints();
                }
                
                public bool isSetLegLastForwardPoints() 
                { 
                    return isSetField(Tags.LegLastForwardPoints);
                }
                public QuickFix.Fields.LegCalculatedCcyLastQty legCalculatedCcyLastQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegCalculatedCcyLastQty val = new QuickFix.Fields.LegCalculatedCcyLastQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCalculatedCcyLastQty val) 
                { 
                    this.legCalculatedCcyLastQty = val;
                }
                
                public QuickFix.Fields.LegCalculatedCcyLastQty get(QuickFix.Fields.LegCalculatedCcyLastQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCalculatedCcyLastQty val) 
                { 
                    return isSetLegCalculatedCcyLastQty();
                }
                
                public bool isSetLegCalculatedCcyLastQty() 
                { 
                    return isSetField(Tags.LegCalculatedCcyLastQty);
                }
                public QuickFix.Fields.LegGrossTradeAmt legGrossTradeAmt
                { 
                    get 
                    {
                        QuickFix.Fields.LegGrossTradeAmt val = new QuickFix.Fields.LegGrossTradeAmt();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegGrossTradeAmt val) 
                { 
                    this.legGrossTradeAmt = val;
                }
                
                public QuickFix.Fields.LegGrossTradeAmt get(QuickFix.Fields.LegGrossTradeAmt val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegGrossTradeAmt val) 
                { 
                    return isSetLegGrossTradeAmt();
                }
                
                public bool isSetLegGrossTradeAmt() 
                { 
                    return isSetField(Tags.LegGrossTradeAmt);
                }
                public QuickFix.Fields.LegNumber legNumber
                { 
                    get 
                    {
                        QuickFix.Fields.LegNumber val = new QuickFix.Fields.LegNumber();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegNumber val) 
                { 
                    this.legNumber = val;
                }
                
                public QuickFix.Fields.LegNumber get(QuickFix.Fields.LegNumber val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegNumber val) 
                { 
                    return isSetLegNumber();
                }
                
                public bool isSetLegNumber() 
                { 
                    return isSetField(Tags.LegNumber);
                }
                public QuickFix.Fields.NoOfLegUnderlyings noOfLegUnderlyings
                { 
                    get 
                    {
                        QuickFix.Fields.NoOfLegUnderlyings val = new QuickFix.Fields.NoOfLegUnderlyings();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoOfLegUnderlyings val) 
                { 
                    this.noOfLegUnderlyings = val;
                }
                
                public QuickFix.Fields.NoOfLegUnderlyings get(QuickFix.Fields.NoOfLegUnderlyings val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoOfLegUnderlyings val) 
                { 
                    return isSetNoOfLegUnderlyings();
                }
                
                public bool isSetNoOfLegUnderlyings() 
                { 
                    return isSetField(Tags.NoOfLegUnderlyings);
                }
                public QuickFix.Fields.LegVolatility legVolatility
                { 
                    get 
                    {
                        QuickFix.Fields.LegVolatility val = new QuickFix.Fields.LegVolatility();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegVolatility val) 
                { 
                    this.legVolatility = val;
                }
                
                public QuickFix.Fields.LegVolatility get(QuickFix.Fields.LegVolatility val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegVolatility val) 
                { 
                    return isSetLegVolatility();
                }
                
                public bool isSetLegVolatility() 
                { 
                    return isSetField(Tags.LegVolatility);
                }
                public QuickFix.Fields.LegDividendYield legDividendYield
                { 
                    get 
                    {
                        QuickFix.Fields.LegDividendYield val = new QuickFix.Fields.LegDividendYield();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegDividendYield val) 
                { 
                    this.legDividendYield = val;
                }
                
                public QuickFix.Fields.LegDividendYield get(QuickFix.Fields.LegDividendYield val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegDividendYield val) 
                { 
                    return isSetLegDividendYield();
                }
                
                public bool isSetLegDividendYield() 
                { 
                    return isSetField(Tags.LegDividendYield);
                }
                public QuickFix.Fields.LegCurrencyRatio legCurrencyRatio
                { 
                    get 
                    {
                        QuickFix.Fields.LegCurrencyRatio val = new QuickFix.Fields.LegCurrencyRatio();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCurrencyRatio val) 
                { 
                    this.legCurrencyRatio = val;
                }
                
                public QuickFix.Fields.LegCurrencyRatio get(QuickFix.Fields.LegCurrencyRatio val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCurrencyRatio val) 
                { 
                    return isSetLegCurrencyRatio();
                }
                
                public bool isSetLegCurrencyRatio() 
                { 
                    return isSetField(Tags.LegCurrencyRatio);
                }
                public QuickFix.Fields.LegExecInst legExecInst
                { 
                    get 
                    {
                        QuickFix.Fields.LegExecInst val = new QuickFix.Fields.LegExecInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegExecInst val) 
                { 
                    this.legExecInst = val;
                }
                
                public QuickFix.Fields.LegExecInst get(QuickFix.Fields.LegExecInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegExecInst val) 
                { 
                    return isSetLegExecInst();
                }
                
                public bool isSetLegExecInst() 
                { 
                    return isSetField(Tags.LegExecInst);
                }
                public QuickFix.Fields.LegLastQty legLastQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegLastQty val = new QuickFix.Fields.LegLastQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegLastQty val) 
                { 
                    this.legLastQty = val;
                }
                
                public QuickFix.Fields.LegLastQty get(QuickFix.Fields.LegLastQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegLastQty val) 
                { 
                    return isSetLegLastQty();
                }
                
                public bool isSetLegLastQty() 
                { 
                    return isSetField(Tags.LegLastQty);
                }
                            public class NoLegSecurityAltID : Group
                {
                    public NoLegSecurityAltID() 
                      :base( Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};
                                    public QuickFix.Fields.LegSecurityAltID legSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        this.legSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltID get(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        return isSetLegSecurityAltID();
                    }
                    
                    public bool isSetLegSecurityAltID() 
                    { 
                        return isSetField(Tags.LegSecurityAltID);
                    }
                    public QuickFix.Fields.LegSecurityAltIDSource legSecurityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        this.legSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltIDSource get(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        return isSetLegSecurityAltIDSource();
                    }
                    
                    public bool isSetLegSecurityAltIDSource() 
                    { 
                        return isSetField(Tags.LegSecurityAltIDSource);
                    }
                
                }
                public class NoLegStipulations : Group
                {
                    public NoLegStipulations() 
                      :base( Tags.NoLegStipulations, Tags.LegStipulationType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.LegStipulationType, Tags.LegStipulationValue, 0};
                                    public QuickFix.Fields.LegStipulationType legStipulationType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStipulationType val = new QuickFix.Fields.LegStipulationType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegStipulationType val) 
                    { 
                        this.legStipulationType = val;
                    }
                    
                    public QuickFix.Fields.LegStipulationType get(QuickFix.Fields.LegStipulationType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegStipulationType val) 
                    { 
                        return isSetLegStipulationType();
                    }
                    
                    public bool isSetLegStipulationType() 
                    { 
                        return isSetField(Tags.LegStipulationType);
                    }
                    public QuickFix.Fields.LegStipulationValue legStipulationValue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStipulationValue val = new QuickFix.Fields.LegStipulationValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        this.legStipulationValue = val;
                    }
                    
                    public QuickFix.Fields.LegStipulationValue get(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        return isSetLegStipulationValue();
                    }
                    
                    public bool isSetLegStipulationValue() 
                    { 
                        return isSetField(Tags.LegStipulationValue);
                    }
                
                }
                public class NoNestedPartyIDs : Group
                {
                    public NoNestedPartyIDs() 
                      :base( Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};
                                    public QuickFix.Fields.NestedPartyID nestedPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyID val = new QuickFix.Fields.NestedPartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NestedPartyID val) 
                    { 
                        this.nestedPartyID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyID get(QuickFix.Fields.NestedPartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NestedPartyID val) 
                    { 
                        return isSetNestedPartyID();
                    }
                    
                    public bool isSetNestedPartyID() 
                    { 
                        return isSetField(Tags.NestedPartyID);
                    }
                    public QuickFix.Fields.NestedPartyIDSource nestedPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyIDSource val = new QuickFix.Fields.NestedPartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        this.nestedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource get(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        return isSetNestedPartyIDSource();
                    }
                    
                    public bool isSetNestedPartyIDSource() 
                    { 
                        return isSetField(Tags.NestedPartyIDSource);
                    }
                    public QuickFix.Fields.NestedPartyRole nestedPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyRole val = new QuickFix.Fields.NestedPartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        this.nestedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyRole get(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        return isSetNestedPartyRole();
                    }
                    
                    public bool isSetNestedPartyRole() 
                    { 
                        return isSetField(Tags.NestedPartyRole);
                    }
                    public QuickFix.Fields.NoNestedPartySubIDs noNestedPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNestedPartySubIDs val = new QuickFix.Fields.NoNestedPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        this.noNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartySubIDs get(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        return isSetNoNestedPartySubIDs();
                    }
                    
                    public bool isSetNoNestedPartySubIDs() 
                    { 
                        return isSetField(Tags.NoNestedPartySubIDs);
                    }
                                    public class NoNestedPartySubIDs : Group
                    {
                        public NoNestedPartySubIDs() 
                          :base( Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};
                                            public QuickFix.Fields.NestedPartySubID nestedPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartySubID val = new QuickFix.Fields.NestedPartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            this.nestedPartySubID = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubID get(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            return isSetNestedPartySubID();
                        }
                        
                        public bool isSetNestedPartySubID() 
                        { 
                            return isSetField(Tags.NestedPartySubID);
                        }
                        public QuickFix.Fields.NestedPartySubIDType nestedPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartySubIDType val = new QuickFix.Fields.NestedPartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            this.nestedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubIDType get(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            return isSetNestedPartySubIDType();
                        }
                        
                        public bool isSetNestedPartySubIDType() 
                        { 
                            return isSetField(Tags.NestedPartySubIDType);
                        }
                    
                    }
                }
                public class NoOfLegUnderlyings : Group
                {
                    public NoOfLegUnderlyings() 
                      :base( Tags.NoOfLegUnderlyings, Tags.UnderlyingLegSymbol, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UnderlyingLegSymbol, Tags.UnderlyingLegSymbolSfx, Tags.UnderlyingLegSecurityID, Tags.UnderlyingLegSecurityIDSource, Tags.NoUnderlyingLegSecurityAltID, Tags.UnderlyingLegCFICode, Tags.UnderlyingLegSecurityType, Tags.UnderlyingLegSecuritySubType, Tags.UnderlyingLegMaturityMonthYear, Tags.UnderlyingLegMaturityDate, Tags.UnderlyingLegMaturityTime, Tags.UnderlyingLegStrikePrice, Tags.UnderlyingLegOptAttribute, Tags.UnderlyingLegPutOrCall, Tags.UnderlyingLegSecurityExchange, Tags.UnderlyingLegSecurityDesc, 0};
                                    public QuickFix.Fields.UnderlyingLegSymbol underlyingLegSymbol
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegSymbol val = new QuickFix.Fields.UnderlyingLegSymbol();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegSymbol val) 
                    { 
                        this.underlyingLegSymbol = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegSymbol get(QuickFix.Fields.UnderlyingLegSymbol val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegSymbol val) 
                    { 
                        return isSetUnderlyingLegSymbol();
                    }
                    
                    public bool isSetUnderlyingLegSymbol() 
                    { 
                        return isSetField(Tags.UnderlyingLegSymbol);
                    }
                    public QuickFix.Fields.UnderlyingLegSymbolSfx underlyingLegSymbolSfx
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegSymbolSfx val = new QuickFix.Fields.UnderlyingLegSymbolSfx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegSymbolSfx val) 
                    { 
                        this.underlyingLegSymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegSymbolSfx get(QuickFix.Fields.UnderlyingLegSymbolSfx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegSymbolSfx val) 
                    { 
                        return isSetUnderlyingLegSymbolSfx();
                    }
                    
                    public bool isSetUnderlyingLegSymbolSfx() 
                    { 
                        return isSetField(Tags.UnderlyingLegSymbolSfx);
                    }
                    public QuickFix.Fields.UnderlyingLegSecurityID underlyingLegSecurityID
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegSecurityID val = new QuickFix.Fields.UnderlyingLegSecurityID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegSecurityID val) 
                    { 
                        this.underlyingLegSecurityID = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegSecurityID get(QuickFix.Fields.UnderlyingLegSecurityID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegSecurityID val) 
                    { 
                        return isSetUnderlyingLegSecurityID();
                    }
                    
                    public bool isSetUnderlyingLegSecurityID() 
                    { 
                        return isSetField(Tags.UnderlyingLegSecurityID);
                    }
                    public QuickFix.Fields.UnderlyingLegSecurityIDSource underlyingLegSecurityIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegSecurityIDSource val = new QuickFix.Fields.UnderlyingLegSecurityIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegSecurityIDSource val) 
                    { 
                        this.underlyingLegSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegSecurityIDSource get(QuickFix.Fields.UnderlyingLegSecurityIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegSecurityIDSource val) 
                    { 
                        return isSetUnderlyingLegSecurityIDSource();
                    }
                    
                    public bool isSetUnderlyingLegSecurityIDSource() 
                    { 
                        return isSetField(Tags.UnderlyingLegSecurityIDSource);
                    }
                    public QuickFix.Fields.NoUnderlyingLegSecurityAltID noUnderlyingLegSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUnderlyingLegSecurityAltID val = new QuickFix.Fields.NoUnderlyingLegSecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoUnderlyingLegSecurityAltID val) 
                    { 
                        this.noUnderlyingLegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoUnderlyingLegSecurityAltID get(QuickFix.Fields.NoUnderlyingLegSecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoUnderlyingLegSecurityAltID val) 
                    { 
                        return isSetNoUnderlyingLegSecurityAltID();
                    }
                    
                    public bool isSetNoUnderlyingLegSecurityAltID() 
                    { 
                        return isSetField(Tags.NoUnderlyingLegSecurityAltID);
                    }
                    public QuickFix.Fields.UnderlyingLegCFICode underlyingLegCFICode
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegCFICode val = new QuickFix.Fields.UnderlyingLegCFICode();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegCFICode val) 
                    { 
                        this.underlyingLegCFICode = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegCFICode get(QuickFix.Fields.UnderlyingLegCFICode val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegCFICode val) 
                    { 
                        return isSetUnderlyingLegCFICode();
                    }
                    
                    public bool isSetUnderlyingLegCFICode() 
                    { 
                        return isSetField(Tags.UnderlyingLegCFICode);
                    }
                    public QuickFix.Fields.UnderlyingLegSecurityType underlyingLegSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegSecurityType val = new QuickFix.Fields.UnderlyingLegSecurityType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegSecurityType val) 
                    { 
                        this.underlyingLegSecurityType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegSecurityType get(QuickFix.Fields.UnderlyingLegSecurityType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegSecurityType val) 
                    { 
                        return isSetUnderlyingLegSecurityType();
                    }
                    
                    public bool isSetUnderlyingLegSecurityType() 
                    { 
                        return isSetField(Tags.UnderlyingLegSecurityType);
                    }
                    public QuickFix.Fields.UnderlyingLegSecuritySubType underlyingLegSecuritySubType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegSecuritySubType val = new QuickFix.Fields.UnderlyingLegSecuritySubType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegSecuritySubType val) 
                    { 
                        this.underlyingLegSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegSecuritySubType get(QuickFix.Fields.UnderlyingLegSecuritySubType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegSecuritySubType val) 
                    { 
                        return isSetUnderlyingLegSecuritySubType();
                    }
                    
                    public bool isSetUnderlyingLegSecuritySubType() 
                    { 
                        return isSetField(Tags.UnderlyingLegSecuritySubType);
                    }
                    public QuickFix.Fields.UnderlyingLegMaturityMonthYear underlyingLegMaturityMonthYear
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegMaturityMonthYear val = new QuickFix.Fields.UnderlyingLegMaturityMonthYear();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegMaturityMonthYear val) 
                    { 
                        this.underlyingLegMaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegMaturityMonthYear get(QuickFix.Fields.UnderlyingLegMaturityMonthYear val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegMaturityMonthYear val) 
                    { 
                        return isSetUnderlyingLegMaturityMonthYear();
                    }
                    
                    public bool isSetUnderlyingLegMaturityMonthYear() 
                    { 
                        return isSetField(Tags.UnderlyingLegMaturityMonthYear);
                    }
                    public QuickFix.Fields.UnderlyingLegMaturityDate underlyingLegMaturityDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegMaturityDate val = new QuickFix.Fields.UnderlyingLegMaturityDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegMaturityDate val) 
                    { 
                        this.underlyingLegMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegMaturityDate get(QuickFix.Fields.UnderlyingLegMaturityDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegMaturityDate val) 
                    { 
                        return isSetUnderlyingLegMaturityDate();
                    }
                    
                    public bool isSetUnderlyingLegMaturityDate() 
                    { 
                        return isSetField(Tags.UnderlyingLegMaturityDate);
                    }
                    public QuickFix.Fields.UnderlyingLegMaturityTime underlyingLegMaturityTime
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegMaturityTime val = new QuickFix.Fields.UnderlyingLegMaturityTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegMaturityTime val) 
                    { 
                        this.underlyingLegMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegMaturityTime get(QuickFix.Fields.UnderlyingLegMaturityTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegMaturityTime val) 
                    { 
                        return isSetUnderlyingLegMaturityTime();
                    }
                    
                    public bool isSetUnderlyingLegMaturityTime() 
                    { 
                        return isSetField(Tags.UnderlyingLegMaturityTime);
                    }
                    public QuickFix.Fields.UnderlyingLegStrikePrice underlyingLegStrikePrice
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegStrikePrice val = new QuickFix.Fields.UnderlyingLegStrikePrice();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegStrikePrice val) 
                    { 
                        this.underlyingLegStrikePrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegStrikePrice get(QuickFix.Fields.UnderlyingLegStrikePrice val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegStrikePrice val) 
                    { 
                        return isSetUnderlyingLegStrikePrice();
                    }
                    
                    public bool isSetUnderlyingLegStrikePrice() 
                    { 
                        return isSetField(Tags.UnderlyingLegStrikePrice);
                    }
                    public QuickFix.Fields.UnderlyingLegOptAttribute underlyingLegOptAttribute
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegOptAttribute val = new QuickFix.Fields.UnderlyingLegOptAttribute();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegOptAttribute val) 
                    { 
                        this.underlyingLegOptAttribute = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegOptAttribute get(QuickFix.Fields.UnderlyingLegOptAttribute val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegOptAttribute val) 
                    { 
                        return isSetUnderlyingLegOptAttribute();
                    }
                    
                    public bool isSetUnderlyingLegOptAttribute() 
                    { 
                        return isSetField(Tags.UnderlyingLegOptAttribute);
                    }
                    public QuickFix.Fields.UnderlyingLegPutOrCall underlyingLegPutOrCall
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegPutOrCall val = new QuickFix.Fields.UnderlyingLegPutOrCall();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegPutOrCall val) 
                    { 
                        this.underlyingLegPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegPutOrCall get(QuickFix.Fields.UnderlyingLegPutOrCall val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegPutOrCall val) 
                    { 
                        return isSetUnderlyingLegPutOrCall();
                    }
                    
                    public bool isSetUnderlyingLegPutOrCall() 
                    { 
                        return isSetField(Tags.UnderlyingLegPutOrCall);
                    }
                    public QuickFix.Fields.UnderlyingLegSecurityExchange underlyingLegSecurityExchange
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegSecurityExchange val = new QuickFix.Fields.UnderlyingLegSecurityExchange();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegSecurityExchange val) 
                    { 
                        this.underlyingLegSecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegSecurityExchange get(QuickFix.Fields.UnderlyingLegSecurityExchange val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegSecurityExchange val) 
                    { 
                        return isSetUnderlyingLegSecurityExchange();
                    }
                    
                    public bool isSetUnderlyingLegSecurityExchange() 
                    { 
                        return isSetField(Tags.UnderlyingLegSecurityExchange);
                    }
                    public QuickFix.Fields.UnderlyingLegSecurityDesc underlyingLegSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLegSecurityDesc val = new QuickFix.Fields.UnderlyingLegSecurityDesc();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLegSecurityDesc val) 
                    { 
                        this.underlyingLegSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLegSecurityDesc get(QuickFix.Fields.UnderlyingLegSecurityDesc val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLegSecurityDesc val) 
                    { 
                        return isSetUnderlyingLegSecurityDesc();
                    }
                    
                    public bool isSetUnderlyingLegSecurityDesc() 
                    { 
                        return isSetField(Tags.UnderlyingLegSecurityDesc);
                    }
                                    public class NoUnderlyingLegSecurityAltID : Group
                    {
                        public NoUnderlyingLegSecurityAltID() 
                          :base( Tags.NoUnderlyingLegSecurityAltID, Tags.UnderlyingLegSecurityAltID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UnderlyingLegSecurityAltID, Tags.UnderlyingLegSecurityAltIDSource, 0};
                                            public QuickFix.Fields.UnderlyingLegSecurityAltID underlyingLegSecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingLegSecurityAltID val = new QuickFix.Fields.UnderlyingLegSecurityAltID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingLegSecurityAltID val) 
                        { 
                            this.underlyingLegSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingLegSecurityAltID get(QuickFix.Fields.UnderlyingLegSecurityAltID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingLegSecurityAltID val) 
                        { 
                            return isSetUnderlyingLegSecurityAltID();
                        }
                        
                        public bool isSetUnderlyingLegSecurityAltID() 
                        { 
                            return isSetField(Tags.UnderlyingLegSecurityAltID);
                        }
                        public QuickFix.Fields.UnderlyingLegSecurityAltIDSource underlyingLegSecurityAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingLegSecurityAltIDSource val = new QuickFix.Fields.UnderlyingLegSecurityAltIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingLegSecurityAltIDSource val) 
                        { 
                            this.underlyingLegSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingLegSecurityAltIDSource get(QuickFix.Fields.UnderlyingLegSecurityAltIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingLegSecurityAltIDSource val) 
                        { 
                            return isSetUnderlyingLegSecurityAltIDSource();
                        }
                        
                        public bool isSetUnderlyingLegSecurityAltIDSource() 
                        { 
                            return isSetField(Tags.UnderlyingLegSecurityAltIDSource);
                        }
                    
                    }
                }
            }
            public class NoTrdRegTimestamps : Group
            {
                public NoTrdRegTimestamps() 
                  :base( Tags.NoTrdRegTimestamps, Tags.TrdRegTimestamp, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0};
                            public QuickFix.Fields.TrdRegTimestamp trdRegTimestamp
                { 
                    get 
                    {
                        QuickFix.Fields.TrdRegTimestamp val = new QuickFix.Fields.TrdRegTimestamp();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    this.trdRegTimestamp = val;
                }
                
                public QuickFix.Fields.TrdRegTimestamp get(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    return isSetTrdRegTimestamp();
                }
                
                public bool isSetTrdRegTimestamp() 
                { 
                    return isSetField(Tags.TrdRegTimestamp);
                }
                public QuickFix.Fields.TrdRegTimestampType trdRegTimestampType
                { 
                    get 
                    {
                        QuickFix.Fields.TrdRegTimestampType val = new QuickFix.Fields.TrdRegTimestampType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    this.trdRegTimestampType = val;
                }
                
                public QuickFix.Fields.TrdRegTimestampType get(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    return isSetTrdRegTimestampType();
                }
                
                public bool isSetTrdRegTimestampType() 
                { 
                    return isSetField(Tags.TrdRegTimestampType);
                }
                public QuickFix.Fields.TrdRegTimestampOrigin trdRegTimestampOrigin
                { 
                    get 
                    {
                        QuickFix.Fields.TrdRegTimestampOrigin val = new QuickFix.Fields.TrdRegTimestampOrigin();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    this.trdRegTimestampOrigin = val;
                }
                
                public QuickFix.Fields.TrdRegTimestampOrigin get(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    return isSetTrdRegTimestampOrigin();
                }
                
                public bool isSetTrdRegTimestampOrigin() 
                { 
                    return isSetField(Tags.TrdRegTimestampOrigin);
                }
                public QuickFix.Fields.DeskType deskType
                { 
                    get 
                    {
                        QuickFix.Fields.DeskType val = new QuickFix.Fields.DeskType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DeskType val) 
                { 
                    this.deskType = val;
                }
                
                public QuickFix.Fields.DeskType get(QuickFix.Fields.DeskType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DeskType val) 
                { 
                    return isSetDeskType();
                }
                
                public bool isSetDeskType() 
                { 
                    return isSetField(Tags.DeskType);
                }
                public QuickFix.Fields.DeskTypeSource deskTypeSource
                { 
                    get 
                    {
                        QuickFix.Fields.DeskTypeSource val = new QuickFix.Fields.DeskTypeSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DeskTypeSource val) 
                { 
                    this.deskTypeSource = val;
                }
                
                public QuickFix.Fields.DeskTypeSource get(QuickFix.Fields.DeskTypeSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DeskTypeSource val) 
                { 
                    return isSetDeskTypeSource();
                }
                
                public bool isSetDeskTypeSource() 
                { 
                    return isSetField(Tags.DeskTypeSource);
                }
                public QuickFix.Fields.DeskOrderHandlingInst deskOrderHandlingInst
                { 
                    get 
                    {
                        QuickFix.Fields.DeskOrderHandlingInst val = new QuickFix.Fields.DeskOrderHandlingInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DeskOrderHandlingInst val) 
                { 
                    this.deskOrderHandlingInst = val;
                }
                
                public QuickFix.Fields.DeskOrderHandlingInst get(QuickFix.Fields.DeskOrderHandlingInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DeskOrderHandlingInst val) 
                { 
                    return isSetDeskOrderHandlingInst();
                }
                
                public bool isSetDeskOrderHandlingInst() 
                { 
                    return isSetField(Tags.DeskOrderHandlingInst);
                }
            
            }
            public class NoSides : Group
            {
                public NoSides() 
                  :base( Tags.NoSides, Tags.Side, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Side, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoPartyIDs, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.OrderInputDevice, Tags.ComplianceID, Tags.SolicitedFlag, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.OrdType, Tags.ExecInst, Tags.TransBkdTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TimeBracket, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.InterestAtMaturity, Tags.EndAccruedInterestAmt, Tags.StartCash, Tags.EndCash, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SideMultiLegReportingType, Tags.NoContAmts, Tags.NoStipulations, Tags.NoMiscFees, Tags.ExchangeRule, Tags.TradeAllocIndicator, Tags.PreallocMethod, Tags.AllocID, Tags.NoAllocs, Tags.SideQty, Tags.SideTradeReportID, Tags.SideFillStationCd, Tags.SideReasonCd, Tags.RptSeq, Tags.SideTrdSubTyp, Tags.NoSideTrdRegTS, Tags.ExecRefID, Tags.LotType, Tags.SideGrossTradeAmt, Tags.AggressorIndicator, Tags.ExchangeSpecialInstructions, Tags.NetGrossInd, Tags.SideCurrency, Tags.SideSettlCurrency, Tags.NoSettlDetails, 0};
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
                public QuickFix.Fields.NoPartyIDs noPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoPartyIDs val) 
                { 
                    this.noPartyIDs = val;
                }
                
                public QuickFix.Fields.NoPartyIDs get(QuickFix.Fields.NoPartyIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoPartyIDs val) 
                { 
                    return isSetNoPartyIDs();
                }
                
                public bool isSetNoPartyIDs() 
                { 
                    return isSetField(Tags.NoPartyIDs);
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
                public QuickFix.Fields.AcctIDSource acctIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.AcctIDSource val = new QuickFix.Fields.AcctIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AcctIDSource val) 
                { 
                    this.acctIDSource = val;
                }
                
                public QuickFix.Fields.AcctIDSource get(QuickFix.Fields.AcctIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AcctIDSource val) 
                { 
                    return isSetAcctIDSource();
                }
                
                public bool isSetAcctIDSource() 
                { 
                    return isSetField(Tags.AcctIDSource);
                }
                public QuickFix.Fields.AccountType accountType
                { 
                    get 
                    {
                        QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AccountType val) 
                { 
                    this.accountType = val;
                }
                
                public QuickFix.Fields.AccountType get(QuickFix.Fields.AccountType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AccountType val) 
                { 
                    return isSetAccountType();
                }
                
                public bool isSetAccountType() 
                { 
                    return isSetField(Tags.AccountType);
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
                public QuickFix.Fields.OddLot oddLot
                { 
                    get 
                    {
                        QuickFix.Fields.OddLot val = new QuickFix.Fields.OddLot();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OddLot val) 
                { 
                    this.oddLot = val;
                }
                
                public QuickFix.Fields.OddLot get(QuickFix.Fields.OddLot val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OddLot val) 
                { 
                    return isSetOddLot();
                }
                
                public bool isSetOddLot() 
                { 
                    return isSetField(Tags.OddLot);
                }
                public QuickFix.Fields.NoClearingInstructions noClearingInstructions
                { 
                    get 
                    {
                        QuickFix.Fields.NoClearingInstructions val = new QuickFix.Fields.NoClearingInstructions();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoClearingInstructions val) 
                { 
                    this.noClearingInstructions = val;
                }
                
                public QuickFix.Fields.NoClearingInstructions get(QuickFix.Fields.NoClearingInstructions val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoClearingInstructions val) 
                { 
                    return isSetNoClearingInstructions();
                }
                
                public bool isSetNoClearingInstructions() 
                { 
                    return isSetField(Tags.NoClearingInstructions);
                }
                public QuickFix.Fields.TradeInputSource tradeInputSource
                { 
                    get 
                    {
                        QuickFix.Fields.TradeInputSource val = new QuickFix.Fields.TradeInputSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradeInputSource val) 
                { 
                    this.tradeInputSource = val;
                }
                
                public QuickFix.Fields.TradeInputSource get(QuickFix.Fields.TradeInputSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradeInputSource val) 
                { 
                    return isSetTradeInputSource();
                }
                
                public bool isSetTradeInputSource() 
                { 
                    return isSetField(Tags.TradeInputSource);
                }
                public QuickFix.Fields.TradeInputDevice tradeInputDevice
                { 
                    get 
                    {
                        QuickFix.Fields.TradeInputDevice val = new QuickFix.Fields.TradeInputDevice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradeInputDevice val) 
                { 
                    this.tradeInputDevice = val;
                }
                
                public QuickFix.Fields.TradeInputDevice get(QuickFix.Fields.TradeInputDevice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradeInputDevice val) 
                { 
                    return isSetTradeInputDevice();
                }
                
                public bool isSetTradeInputDevice() 
                { 
                    return isSetField(Tags.TradeInputDevice);
                }
                public QuickFix.Fields.OrderInputDevice orderInputDevice
                { 
                    get 
                    {
                        QuickFix.Fields.OrderInputDevice val = new QuickFix.Fields.OrderInputDevice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderInputDevice val) 
                { 
                    this.orderInputDevice = val;
                }
                
                public QuickFix.Fields.OrderInputDevice get(QuickFix.Fields.OrderInputDevice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderInputDevice val) 
                { 
                    return isSetOrderInputDevice();
                }
                
                public bool isSetOrderInputDevice() 
                { 
                    return isSetField(Tags.OrderInputDevice);
                }
                public QuickFix.Fields.ComplianceID complianceID
                { 
                    get 
                    {
                        QuickFix.Fields.ComplianceID val = new QuickFix.Fields.ComplianceID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ComplianceID val) 
                { 
                    this.complianceID = val;
                }
                
                public QuickFix.Fields.ComplianceID get(QuickFix.Fields.ComplianceID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ComplianceID val) 
                { 
                    return isSetComplianceID();
                }
                
                public bool isSetComplianceID() 
                { 
                    return isSetField(Tags.ComplianceID);
                }
                public QuickFix.Fields.SolicitedFlag solicitedFlag
                { 
                    get 
                    {
                        QuickFix.Fields.SolicitedFlag val = new QuickFix.Fields.SolicitedFlag();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SolicitedFlag val) 
                { 
                    this.solicitedFlag = val;
                }
                
                public QuickFix.Fields.SolicitedFlag get(QuickFix.Fields.SolicitedFlag val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SolicitedFlag val) 
                { 
                    return isSetSolicitedFlag();
                }
                
                public bool isSetSolicitedFlag() 
                { 
                    return isSetField(Tags.SolicitedFlag);
                }
                public QuickFix.Fields.OrderCapacity orderCapacity
                { 
                    get 
                    {
                        QuickFix.Fields.OrderCapacity val = new QuickFix.Fields.OrderCapacity();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderCapacity val) 
                { 
                    this.orderCapacity = val;
                }
                
                public QuickFix.Fields.OrderCapacity get(QuickFix.Fields.OrderCapacity val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderCapacity val) 
                { 
                    return isSetOrderCapacity();
                }
                
                public bool isSetOrderCapacity() 
                { 
                    return isSetField(Tags.OrderCapacity);
                }
                public QuickFix.Fields.OrderRestrictions orderRestrictions
                { 
                    get 
                    {
                        QuickFix.Fields.OrderRestrictions val = new QuickFix.Fields.OrderRestrictions();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderRestrictions val) 
                { 
                    this.orderRestrictions = val;
                }
                
                public QuickFix.Fields.OrderRestrictions get(QuickFix.Fields.OrderRestrictions val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderRestrictions val) 
                { 
                    return isSetOrderRestrictions();
                }
                
                public bool isSetOrderRestrictions() 
                { 
                    return isSetField(Tags.OrderRestrictions);
                }
                public QuickFix.Fields.CustOrderCapacity custOrderCapacity
                { 
                    get 
                    {
                        QuickFix.Fields.CustOrderCapacity val = new QuickFix.Fields.CustOrderCapacity();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    this.custOrderCapacity = val;
                }
                
                public QuickFix.Fields.CustOrderCapacity get(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    return isSetCustOrderCapacity();
                }
                
                public bool isSetCustOrderCapacity() 
                { 
                    return isSetField(Tags.CustOrderCapacity);
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
                public QuickFix.Fields.TransBkdTime transBkdTime
                { 
                    get 
                    {
                        QuickFix.Fields.TransBkdTime val = new QuickFix.Fields.TransBkdTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TransBkdTime val) 
                { 
                    this.transBkdTime = val;
                }
                
                public QuickFix.Fields.TransBkdTime get(QuickFix.Fields.TransBkdTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TransBkdTime val) 
                { 
                    return isSetTransBkdTime();
                }
                
                public bool isSetTransBkdTime() 
                { 
                    return isSetField(Tags.TransBkdTime);
                }
                public QuickFix.Fields.TradingSessionID tradingSessionID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradingSessionID val) 
                { 
                    this.tradingSessionID = val;
                }
                
                public QuickFix.Fields.TradingSessionID get(QuickFix.Fields.TradingSessionID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradingSessionID val) 
                { 
                    return isSetTradingSessionID();
                }
                
                public bool isSetTradingSessionID() 
                { 
                    return isSetField(Tags.TradingSessionID);
                }
                public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    this.tradingSessionSubID = val;
                }
                
                public QuickFix.Fields.TradingSessionSubID get(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    return isSetTradingSessionSubID();
                }
                
                public bool isSetTradingSessionSubID() 
                { 
                    return isSetField(Tags.TradingSessionSubID);
                }
                public QuickFix.Fields.TimeBracket timeBracket
                { 
                    get 
                    {
                        QuickFix.Fields.TimeBracket val = new QuickFix.Fields.TimeBracket();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TimeBracket val) 
                { 
                    this.timeBracket = val;
                }
                
                public QuickFix.Fields.TimeBracket get(QuickFix.Fields.TimeBracket val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TimeBracket val) 
                { 
                    return isSetTimeBracket();
                }
                
                public bool isSetTimeBracket() 
                { 
                    return isSetField(Tags.TimeBracket);
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
                public QuickFix.Fields.CommCurrency commCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.CommCurrency val = new QuickFix.Fields.CommCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CommCurrency val) 
                { 
                    this.commCurrency = val;
                }
                
                public QuickFix.Fields.CommCurrency get(QuickFix.Fields.CommCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CommCurrency val) 
                { 
                    return isSetCommCurrency();
                }
                
                public bool isSetCommCurrency() 
                { 
                    return isSetField(Tags.CommCurrency);
                }
                public QuickFix.Fields.FundRenewWaiv fundRenewWaiv
                { 
                    get 
                    {
                        QuickFix.Fields.FundRenewWaiv val = new QuickFix.Fields.FundRenewWaiv();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    this.fundRenewWaiv = val;
                }
                
                public QuickFix.Fields.FundRenewWaiv get(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    return isSetFundRenewWaiv();
                }
                
                public bool isSetFundRenewWaiv() 
                { 
                    return isSetField(Tags.FundRenewWaiv);
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
                public QuickFix.Fields.ExDate exDate
                { 
                    get 
                    {
                        QuickFix.Fields.ExDate val = new QuickFix.Fields.ExDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExDate val) 
                { 
                    this.exDate = val;
                }
                
                public QuickFix.Fields.ExDate get(QuickFix.Fields.ExDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExDate val) 
                { 
                    return isSetExDate();
                }
                
                public bool isSetExDate() 
                { 
                    return isSetField(Tags.ExDate);
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
                public QuickFix.Fields.InterestAtMaturity interestAtMaturity
                { 
                    get 
                    {
                        QuickFix.Fields.InterestAtMaturity val = new QuickFix.Fields.InterestAtMaturity();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InterestAtMaturity val) 
                { 
                    this.interestAtMaturity = val;
                }
                
                public QuickFix.Fields.InterestAtMaturity get(QuickFix.Fields.InterestAtMaturity val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InterestAtMaturity val) 
                { 
                    return isSetInterestAtMaturity();
                }
                
                public bool isSetInterestAtMaturity() 
                { 
                    return isSetField(Tags.InterestAtMaturity);
                }
                public QuickFix.Fields.EndAccruedInterestAmt endAccruedInterestAmt
                { 
                    get 
                    {
                        QuickFix.Fields.EndAccruedInterestAmt val = new QuickFix.Fields.EndAccruedInterestAmt();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EndAccruedInterestAmt val) 
                { 
                    this.endAccruedInterestAmt = val;
                }
                
                public QuickFix.Fields.EndAccruedInterestAmt get(QuickFix.Fields.EndAccruedInterestAmt val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EndAccruedInterestAmt val) 
                { 
                    return isSetEndAccruedInterestAmt();
                }
                
                public bool isSetEndAccruedInterestAmt() 
                { 
                    return isSetField(Tags.EndAccruedInterestAmt);
                }
                public QuickFix.Fields.StartCash startCash
                { 
                    get 
                    {
                        QuickFix.Fields.StartCash val = new QuickFix.Fields.StartCash();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StartCash val) 
                { 
                    this.startCash = val;
                }
                
                public QuickFix.Fields.StartCash get(QuickFix.Fields.StartCash val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StartCash val) 
                { 
                    return isSetStartCash();
                }
                
                public bool isSetStartCash() 
                { 
                    return isSetField(Tags.StartCash);
                }
                public QuickFix.Fields.EndCash endCash
                { 
                    get 
                    {
                        QuickFix.Fields.EndCash val = new QuickFix.Fields.EndCash();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EndCash val) 
                { 
                    this.endCash = val;
                }
                
                public QuickFix.Fields.EndCash get(QuickFix.Fields.EndCash val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EndCash val) 
                { 
                    return isSetEndCash();
                }
                
                public bool isSetEndCash() 
                { 
                    return isSetField(Tags.EndCash);
                }
                public QuickFix.Fields.Concession concession
                { 
                    get 
                    {
                        QuickFix.Fields.Concession val = new QuickFix.Fields.Concession();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Concession val) 
                { 
                    this.concession = val;
                }
                
                public QuickFix.Fields.Concession get(QuickFix.Fields.Concession val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Concession val) 
                { 
                    return isSetConcession();
                }
                
                public bool isSetConcession() 
                { 
                    return isSetField(Tags.Concession);
                }
                public QuickFix.Fields.TotalTakedown totalTakedown
                { 
                    get 
                    {
                        QuickFix.Fields.TotalTakedown val = new QuickFix.Fields.TotalTakedown();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TotalTakedown val) 
                { 
                    this.totalTakedown = val;
                }
                
                public QuickFix.Fields.TotalTakedown get(QuickFix.Fields.TotalTakedown val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TotalTakedown val) 
                { 
                    return isSetTotalTakedown();
                }
                
                public bool isSetTotalTakedown() 
                { 
                    return isSetField(Tags.TotalTakedown);
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
                public QuickFix.Fields.PositionEffect positionEffect
                { 
                    get 
                    {
                        QuickFix.Fields.PositionEffect val = new QuickFix.Fields.PositionEffect();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PositionEffect val) 
                { 
                    this.positionEffect = val;
                }
                
                public QuickFix.Fields.PositionEffect get(QuickFix.Fields.PositionEffect val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PositionEffect val) 
                { 
                    return isSetPositionEffect();
                }
                
                public bool isSetPositionEffect() 
                { 
                    return isSetField(Tags.PositionEffect);
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
                public QuickFix.Fields.SideMultiLegReportingType sideMultiLegReportingType
                { 
                    get 
                    {
                        QuickFix.Fields.SideMultiLegReportingType val = new QuickFix.Fields.SideMultiLegReportingType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideMultiLegReportingType val) 
                { 
                    this.sideMultiLegReportingType = val;
                }
                
                public QuickFix.Fields.SideMultiLegReportingType get(QuickFix.Fields.SideMultiLegReportingType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideMultiLegReportingType val) 
                { 
                    return isSetSideMultiLegReportingType();
                }
                
                public bool isSetSideMultiLegReportingType() 
                { 
                    return isSetField(Tags.SideMultiLegReportingType);
                }
                public QuickFix.Fields.NoContAmts noContAmts
                { 
                    get 
                    {
                        QuickFix.Fields.NoContAmts val = new QuickFix.Fields.NoContAmts();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoContAmts val) 
                { 
                    this.noContAmts = val;
                }
                
                public QuickFix.Fields.NoContAmts get(QuickFix.Fields.NoContAmts val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoContAmts val) 
                { 
                    return isSetNoContAmts();
                }
                
                public bool isSetNoContAmts() 
                { 
                    return isSetField(Tags.NoContAmts);
                }
                public QuickFix.Fields.NoStipulations noStipulations
                { 
                    get 
                    {
                        QuickFix.Fields.NoStipulations val = new QuickFix.Fields.NoStipulations();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoStipulations val) 
                { 
                    this.noStipulations = val;
                }
                
                public QuickFix.Fields.NoStipulations get(QuickFix.Fields.NoStipulations val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoStipulations val) 
                { 
                    return isSetNoStipulations();
                }
                
                public bool isSetNoStipulations() 
                { 
                    return isSetField(Tags.NoStipulations);
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
                public QuickFix.Fields.ExchangeRule exchangeRule
                { 
                    get 
                    {
                        QuickFix.Fields.ExchangeRule val = new QuickFix.Fields.ExchangeRule();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExchangeRule val) 
                { 
                    this.exchangeRule = val;
                }
                
                public QuickFix.Fields.ExchangeRule get(QuickFix.Fields.ExchangeRule val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExchangeRule val) 
                { 
                    return isSetExchangeRule();
                }
                
                public bool isSetExchangeRule() 
                { 
                    return isSetField(Tags.ExchangeRule);
                }
                public QuickFix.Fields.TradeAllocIndicator tradeAllocIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.TradeAllocIndicator val = new QuickFix.Fields.TradeAllocIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradeAllocIndicator val) 
                { 
                    this.tradeAllocIndicator = val;
                }
                
                public QuickFix.Fields.TradeAllocIndicator get(QuickFix.Fields.TradeAllocIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradeAllocIndicator val) 
                { 
                    return isSetTradeAllocIndicator();
                }
                
                public bool isSetTradeAllocIndicator() 
                { 
                    return isSetField(Tags.TradeAllocIndicator);
                }
                public QuickFix.Fields.PreallocMethod preallocMethod
                { 
                    get 
                    {
                        QuickFix.Fields.PreallocMethod val = new QuickFix.Fields.PreallocMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PreallocMethod val) 
                { 
                    this.preallocMethod = val;
                }
                
                public QuickFix.Fields.PreallocMethod get(QuickFix.Fields.PreallocMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PreallocMethod val) 
                { 
                    return isSetPreallocMethod();
                }
                
                public bool isSetPreallocMethod() 
                { 
                    return isSetField(Tags.PreallocMethod);
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
                public QuickFix.Fields.SideQty sideQty
                { 
                    get 
                    {
                        QuickFix.Fields.SideQty val = new QuickFix.Fields.SideQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideQty val) 
                { 
                    this.sideQty = val;
                }
                
                public QuickFix.Fields.SideQty get(QuickFix.Fields.SideQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideQty val) 
                { 
                    return isSetSideQty();
                }
                
                public bool isSetSideQty() 
                { 
                    return isSetField(Tags.SideQty);
                }
                public QuickFix.Fields.SideTradeReportID sideTradeReportID
                { 
                    get 
                    {
                        QuickFix.Fields.SideTradeReportID val = new QuickFix.Fields.SideTradeReportID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideTradeReportID val) 
                { 
                    this.sideTradeReportID = val;
                }
                
                public QuickFix.Fields.SideTradeReportID get(QuickFix.Fields.SideTradeReportID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideTradeReportID val) 
                { 
                    return isSetSideTradeReportID();
                }
                
                public bool isSetSideTradeReportID() 
                { 
                    return isSetField(Tags.SideTradeReportID);
                }
                public QuickFix.Fields.SideFillStationCd sideFillStationCd
                { 
                    get 
                    {
                        QuickFix.Fields.SideFillStationCd val = new QuickFix.Fields.SideFillStationCd();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideFillStationCd val) 
                { 
                    this.sideFillStationCd = val;
                }
                
                public QuickFix.Fields.SideFillStationCd get(QuickFix.Fields.SideFillStationCd val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideFillStationCd val) 
                { 
                    return isSetSideFillStationCd();
                }
                
                public bool isSetSideFillStationCd() 
                { 
                    return isSetField(Tags.SideFillStationCd);
                }
                public QuickFix.Fields.SideReasonCd sideReasonCd
                { 
                    get 
                    {
                        QuickFix.Fields.SideReasonCd val = new QuickFix.Fields.SideReasonCd();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideReasonCd val) 
                { 
                    this.sideReasonCd = val;
                }
                
                public QuickFix.Fields.SideReasonCd get(QuickFix.Fields.SideReasonCd val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideReasonCd val) 
                { 
                    return isSetSideReasonCd();
                }
                
                public bool isSetSideReasonCd() 
                { 
                    return isSetField(Tags.SideReasonCd);
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
                public QuickFix.Fields.SideTrdSubTyp sideTrdSubTyp
                { 
                    get 
                    {
                        QuickFix.Fields.SideTrdSubTyp val = new QuickFix.Fields.SideTrdSubTyp();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideTrdSubTyp val) 
                { 
                    this.sideTrdSubTyp = val;
                }
                
                public QuickFix.Fields.SideTrdSubTyp get(QuickFix.Fields.SideTrdSubTyp val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideTrdSubTyp val) 
                { 
                    return isSetSideTrdSubTyp();
                }
                
                public bool isSetSideTrdSubTyp() 
                { 
                    return isSetField(Tags.SideTrdSubTyp);
                }
                public QuickFix.Fields.NoSideTrdRegTS noSideTrdRegTS
                { 
                    get 
                    {
                        QuickFix.Fields.NoSideTrdRegTS val = new QuickFix.Fields.NoSideTrdRegTS();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoSideTrdRegTS val) 
                { 
                    this.noSideTrdRegTS = val;
                }
                
                public QuickFix.Fields.NoSideTrdRegTS get(QuickFix.Fields.NoSideTrdRegTS val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoSideTrdRegTS val) 
                { 
                    return isSetNoSideTrdRegTS();
                }
                
                public bool isSetNoSideTrdRegTS() 
                { 
                    return isSetField(Tags.NoSideTrdRegTS);
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
                public QuickFix.Fields.LotType lotType
                { 
                    get 
                    {
                        QuickFix.Fields.LotType val = new QuickFix.Fields.LotType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LotType val) 
                { 
                    this.lotType = val;
                }
                
                public QuickFix.Fields.LotType get(QuickFix.Fields.LotType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LotType val) 
                { 
                    return isSetLotType();
                }
                
                public bool isSetLotType() 
                { 
                    return isSetField(Tags.LotType);
                }
                public QuickFix.Fields.SideGrossTradeAmt sideGrossTradeAmt
                { 
                    get 
                    {
                        QuickFix.Fields.SideGrossTradeAmt val = new QuickFix.Fields.SideGrossTradeAmt();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideGrossTradeAmt val) 
                { 
                    this.sideGrossTradeAmt = val;
                }
                
                public QuickFix.Fields.SideGrossTradeAmt get(QuickFix.Fields.SideGrossTradeAmt val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideGrossTradeAmt val) 
                { 
                    return isSetSideGrossTradeAmt();
                }
                
                public bool isSetSideGrossTradeAmt() 
                { 
                    return isSetField(Tags.SideGrossTradeAmt);
                }
                public QuickFix.Fields.AggressorIndicator aggressorIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.AggressorIndicator val = new QuickFix.Fields.AggressorIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AggressorIndicator val) 
                { 
                    this.aggressorIndicator = val;
                }
                
                public QuickFix.Fields.AggressorIndicator get(QuickFix.Fields.AggressorIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AggressorIndicator val) 
                { 
                    return isSetAggressorIndicator();
                }
                
                public bool isSetAggressorIndicator() 
                { 
                    return isSetField(Tags.AggressorIndicator);
                }
                public QuickFix.Fields.ExchangeSpecialInstructions exchangeSpecialInstructions
                { 
                    get 
                    {
                        QuickFix.Fields.ExchangeSpecialInstructions val = new QuickFix.Fields.ExchangeSpecialInstructions();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExchangeSpecialInstructions val) 
                { 
                    this.exchangeSpecialInstructions = val;
                }
                
                public QuickFix.Fields.ExchangeSpecialInstructions get(QuickFix.Fields.ExchangeSpecialInstructions val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExchangeSpecialInstructions val) 
                { 
                    return isSetExchangeSpecialInstructions();
                }
                
                public bool isSetExchangeSpecialInstructions() 
                { 
                    return isSetField(Tags.ExchangeSpecialInstructions);
                }
                public QuickFix.Fields.NetGrossInd netGrossInd
                { 
                    get 
                    {
                        QuickFix.Fields.NetGrossInd val = new QuickFix.Fields.NetGrossInd();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NetGrossInd val) 
                { 
                    this.netGrossInd = val;
                }
                
                public QuickFix.Fields.NetGrossInd get(QuickFix.Fields.NetGrossInd val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NetGrossInd val) 
                { 
                    return isSetNetGrossInd();
                }
                
                public bool isSetNetGrossInd() 
                { 
                    return isSetField(Tags.NetGrossInd);
                }
                public QuickFix.Fields.SideCurrency sideCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.SideCurrency val = new QuickFix.Fields.SideCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideCurrency val) 
                { 
                    this.sideCurrency = val;
                }
                
                public QuickFix.Fields.SideCurrency get(QuickFix.Fields.SideCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideCurrency val) 
                { 
                    return isSetSideCurrency();
                }
                
                public bool isSetSideCurrency() 
                { 
                    return isSetField(Tags.SideCurrency);
                }
                public QuickFix.Fields.SideSettlCurrency sideSettlCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.SideSettlCurrency val = new QuickFix.Fields.SideSettlCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideSettlCurrency val) 
                { 
                    this.sideSettlCurrency = val;
                }
                
                public QuickFix.Fields.SideSettlCurrency get(QuickFix.Fields.SideSettlCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideSettlCurrency val) 
                { 
                    return isSetSideSettlCurrency();
                }
                
                public bool isSetSideSettlCurrency() 
                { 
                    return isSetField(Tags.SideSettlCurrency);
                }
                public QuickFix.Fields.NoSettlDetails noSettlDetails
                { 
                    get 
                    {
                        QuickFix.Fields.NoSettlDetails val = new QuickFix.Fields.NoSettlDetails();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoSettlDetails val) 
                { 
                    this.noSettlDetails = val;
                }
                
                public QuickFix.Fields.NoSettlDetails get(QuickFix.Fields.NoSettlDetails val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoSettlDetails val) 
                { 
                    return isSetNoSettlDetails();
                }
                
                public bool isSetNoSettlDetails() 
                { 
                    return isSetField(Tags.NoSettlDetails);
                }
                            public class NoPartyIDs : Group
                {
                    public NoPartyIDs() 
                      :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
                                    public QuickFix.Fields.PartyID partyID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartyID val) 
                    { 
                        this.partyID = val;
                    }
                    
                    public QuickFix.Fields.PartyID get(QuickFix.Fields.PartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartyID val) 
                    { 
                        return isSetPartyID();
                    }
                    
                    public bool isSetPartyID() 
                    { 
                        return isSetField(Tags.PartyID);
                    }
                    public QuickFix.Fields.PartyIDSource partyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartyIDSource val) 
                    { 
                        this.partyIDSource = val;
                    }
                    
                    public QuickFix.Fields.PartyIDSource get(QuickFix.Fields.PartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartyIDSource val) 
                    { 
                        return isSetPartyIDSource();
                    }
                    
                    public bool isSetPartyIDSource() 
                    { 
                        return isSetField(Tags.PartyIDSource);
                    }
                    public QuickFix.Fields.PartyRole partyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartyRole val) 
                    { 
                        this.partyRole = val;
                    }
                    
                    public QuickFix.Fields.PartyRole get(QuickFix.Fields.PartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartyRole val) 
                    { 
                        return isSetPartyRole();
                    }
                    
                    public bool isSetPartyRole() 
                    { 
                        return isSetField(Tags.PartyRole);
                    }
                    public QuickFix.Fields.NoPartySubIDs noPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        this.noPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoPartySubIDs get(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        return isSetNoPartySubIDs();
                    }
                    
                    public bool isSetNoPartySubIDs() 
                    { 
                        return isSetField(Tags.NoPartySubIDs);
                    }
                                    public class NoPartySubIDs : Group
                    {
                        public NoPartySubIDs() 
                          :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                                            public QuickFix.Fields.PartySubID partySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.PartySubID val) 
                        { 
                            this.partySubID = val;
                        }
                        
                        public QuickFix.Fields.PartySubID get(QuickFix.Fields.PartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.PartySubID val) 
                        { 
                            return isSetPartySubID();
                        }
                        
                        public bool isSetPartySubID() 
                        { 
                            return isSetField(Tags.PartySubID);
                        }
                        public QuickFix.Fields.PartySubIDType partySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.PartySubIDType val) 
                        { 
                            this.partySubIDType = val;
                        }
                        
                        public QuickFix.Fields.PartySubIDType get(QuickFix.Fields.PartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.PartySubIDType val) 
                        { 
                            return isSetPartySubIDType();
                        }
                        
                        public bool isSetPartySubIDType() 
                        { 
                            return isSetField(Tags.PartySubIDType);
                        }
                    
                    }
                }
                public class NoClearingInstructions : Group
                {
                    public NoClearingInstructions() 
                      :base( Tags.NoClearingInstructions, Tags.ClearingInstruction, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.ClearingInstruction, 0};
                                    public QuickFix.Fields.ClearingInstruction clearingInstruction
                    { 
                        get 
                        {
                            QuickFix.Fields.ClearingInstruction val = new QuickFix.Fields.ClearingInstruction();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ClearingInstruction val) 
                    { 
                        this.clearingInstruction = val;
                    }
                    
                    public QuickFix.Fields.ClearingInstruction get(QuickFix.Fields.ClearingInstruction val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ClearingInstruction val) 
                    { 
                        return isSetClearingInstruction();
                    }
                    
                    public bool isSetClearingInstruction() 
                    { 
                        return isSetField(Tags.ClearingInstruction);
                    }
                
                }
                public class NoContAmts : Group
                {
                    public NoContAmts() 
                      :base( Tags.NoContAmts, Tags.ContAmtType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0};
                                    public QuickFix.Fields.ContAmtType contAmtType
                    { 
                        get 
                        {
                            QuickFix.Fields.ContAmtType val = new QuickFix.Fields.ContAmtType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ContAmtType val) 
                    { 
                        this.contAmtType = val;
                    }
                    
                    public QuickFix.Fields.ContAmtType get(QuickFix.Fields.ContAmtType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ContAmtType val) 
                    { 
                        return isSetContAmtType();
                    }
                    
                    public bool isSetContAmtType() 
                    { 
                        return isSetField(Tags.ContAmtType);
                    }
                    public QuickFix.Fields.ContAmtValue contAmtValue
                    { 
                        get 
                        {
                            QuickFix.Fields.ContAmtValue val = new QuickFix.Fields.ContAmtValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ContAmtValue val) 
                    { 
                        this.contAmtValue = val;
                    }
                    
                    public QuickFix.Fields.ContAmtValue get(QuickFix.Fields.ContAmtValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ContAmtValue val) 
                    { 
                        return isSetContAmtValue();
                    }
                    
                    public bool isSetContAmtValue() 
                    { 
                        return isSetField(Tags.ContAmtValue);
                    }
                    public QuickFix.Fields.ContAmtCurr contAmtCurr
                    { 
                        get 
                        {
                            QuickFix.Fields.ContAmtCurr val = new QuickFix.Fields.ContAmtCurr();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ContAmtCurr val) 
                    { 
                        this.contAmtCurr = val;
                    }
                    
                    public QuickFix.Fields.ContAmtCurr get(QuickFix.Fields.ContAmtCurr val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ContAmtCurr val) 
                    { 
                        return isSetContAmtCurr();
                    }
                    
                    public bool isSetContAmtCurr() 
                    { 
                        return isSetField(Tags.ContAmtCurr);
                    }
                
                }
                public class NoStipulations : Group
                {
                    public NoStipulations() 
                      :base( Tags.NoStipulations, Tags.StipulationType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};
                                    public QuickFix.Fields.StipulationType stipulationType
                    { 
                        get 
                        {
                            QuickFix.Fields.StipulationType val = new QuickFix.Fields.StipulationType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StipulationType val) 
                    { 
                        this.stipulationType = val;
                    }
                    
                    public QuickFix.Fields.StipulationType get(QuickFix.Fields.StipulationType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StipulationType val) 
                    { 
                        return isSetStipulationType();
                    }
                    
                    public bool isSetStipulationType() 
                    { 
                        return isSetField(Tags.StipulationType);
                    }
                    public QuickFix.Fields.StipulationValue stipulationValue
                    { 
                        get 
                        {
                            QuickFix.Fields.StipulationValue val = new QuickFix.Fields.StipulationValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StipulationValue val) 
                    { 
                        this.stipulationValue = val;
                    }
                    
                    public QuickFix.Fields.StipulationValue get(QuickFix.Fields.StipulationValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StipulationValue val) 
                    { 
                        return isSetStipulationValue();
                    }
                    
                    public bool isSetStipulationValue() 
                    { 
                        return isSetField(Tags.StipulationValue);
                    }
                
                }
                public class NoMiscFees : Group
                {
                    public NoMiscFees() 
                      :base( Tags.NoMiscFees, Tags.MiscFeeAmt, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0};
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
                    public QuickFix.Fields.MiscFeeBasis miscFeeBasis
                    { 
                        get 
                        {
                            QuickFix.Fields.MiscFeeBasis val = new QuickFix.Fields.MiscFeeBasis();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MiscFeeBasis val) 
                    { 
                        this.miscFeeBasis = val;
                    }
                    
                    public QuickFix.Fields.MiscFeeBasis get(QuickFix.Fields.MiscFeeBasis val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MiscFeeBasis val) 
                    { 
                        return isSetMiscFeeBasis();
                    }
                    
                    public bool isSetMiscFeeBasis() 
                    { 
                        return isSetField(Tags.MiscFeeBasis);
                    }
                
                }
                public class NoAllocs : Group
                {
                    public NoAllocs() 
                      :base( Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNested2PartyIDs, Tags.AllocQty, Tags.AllocCustomerCapacity, Tags.AllocMethod, Tags.SecondaryIndividualAllocID, Tags.AllocClearingFeeIndicator, 0};
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
                    public QuickFix.Fields.AllocAcctIDSource allocAcctIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocAcctIDSource val = new QuickFix.Fields.AllocAcctIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        this.allocAcctIDSource = val;
                    }
                    
                    public QuickFix.Fields.AllocAcctIDSource get(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        return isSetAllocAcctIDSource();
                    }
                    
                    public bool isSetAllocAcctIDSource() 
                    { 
                        return isSetField(Tags.AllocAcctIDSource);
                    }
                    public QuickFix.Fields.AllocSettlCurrency allocSettlCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocSettlCurrency val = new QuickFix.Fields.AllocSettlCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        this.allocSettlCurrency = val;
                    }
                    
                    public QuickFix.Fields.AllocSettlCurrency get(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        return isSetAllocSettlCurrency();
                    }
                    
                    public bool isSetAllocSettlCurrency() 
                    { 
                        return isSetField(Tags.AllocSettlCurrency);
                    }
                    public QuickFix.Fields.IndividualAllocID individualAllocID
                    { 
                        get 
                        {
                            QuickFix.Fields.IndividualAllocID val = new QuickFix.Fields.IndividualAllocID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        this.individualAllocID = val;
                    }
                    
                    public QuickFix.Fields.IndividualAllocID get(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        return isSetIndividualAllocID();
                    }
                    
                    public bool isSetIndividualAllocID() 
                    { 
                        return isSetField(Tags.IndividualAllocID);
                    }
                    public QuickFix.Fields.NoNested2PartyIDs noNested2PartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNested2PartyIDs val = new QuickFix.Fields.NoNested2PartyIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        this.noNested2PartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNested2PartyIDs get(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        return isSetNoNested2PartyIDs();
                    }
                    
                    public bool isSetNoNested2PartyIDs() 
                    { 
                        return isSetField(Tags.NoNested2PartyIDs);
                    }
                    public QuickFix.Fields.AllocQty allocQty
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocQty val = new QuickFix.Fields.AllocQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocQty val) 
                    { 
                        this.allocQty = val;
                    }
                    
                    public QuickFix.Fields.AllocQty get(QuickFix.Fields.AllocQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocQty val) 
                    { 
                        return isSetAllocQty();
                    }
                    
                    public bool isSetAllocQty() 
                    { 
                        return isSetField(Tags.AllocQty);
                    }
                    public QuickFix.Fields.AllocCustomerCapacity allocCustomerCapacity
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocCustomerCapacity val = new QuickFix.Fields.AllocCustomerCapacity();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocCustomerCapacity val) 
                    { 
                        this.allocCustomerCapacity = val;
                    }
                    
                    public QuickFix.Fields.AllocCustomerCapacity get(QuickFix.Fields.AllocCustomerCapacity val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocCustomerCapacity val) 
                    { 
                        return isSetAllocCustomerCapacity();
                    }
                    
                    public bool isSetAllocCustomerCapacity() 
                    { 
                        return isSetField(Tags.AllocCustomerCapacity);
                    }
                    public QuickFix.Fields.AllocMethod allocMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocMethod val = new QuickFix.Fields.AllocMethod();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocMethod val) 
                    { 
                        this.allocMethod = val;
                    }
                    
                    public QuickFix.Fields.AllocMethod get(QuickFix.Fields.AllocMethod val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocMethod val) 
                    { 
                        return isSetAllocMethod();
                    }
                    
                    public bool isSetAllocMethod() 
                    { 
                        return isSetField(Tags.AllocMethod);
                    }
                    public QuickFix.Fields.SecondaryIndividualAllocID secondaryIndividualAllocID
                    { 
                        get 
                        {
                            QuickFix.Fields.SecondaryIndividualAllocID val = new QuickFix.Fields.SecondaryIndividualAllocID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SecondaryIndividualAllocID val) 
                    { 
                        this.secondaryIndividualAllocID = val;
                    }
                    
                    public QuickFix.Fields.SecondaryIndividualAllocID get(QuickFix.Fields.SecondaryIndividualAllocID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SecondaryIndividualAllocID val) 
                    { 
                        return isSetSecondaryIndividualAllocID();
                    }
                    
                    public bool isSetSecondaryIndividualAllocID() 
                    { 
                        return isSetField(Tags.SecondaryIndividualAllocID);
                    }
                    public QuickFix.Fields.AllocClearingFeeIndicator allocClearingFeeIndicator
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocClearingFeeIndicator val = new QuickFix.Fields.AllocClearingFeeIndicator();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocClearingFeeIndicator val) 
                    { 
                        this.allocClearingFeeIndicator = val;
                    }
                    
                    public QuickFix.Fields.AllocClearingFeeIndicator get(QuickFix.Fields.AllocClearingFeeIndicator val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocClearingFeeIndicator val) 
                    { 
                        return isSetAllocClearingFeeIndicator();
                    }
                    
                    public bool isSetAllocClearingFeeIndicator() 
                    { 
                        return isSetField(Tags.AllocClearingFeeIndicator);
                    }
                                    public class NoNested2PartyIDs : Group
                    {
                        public NoNested2PartyIDs() 
                          :base( Tags.NoNested2PartyIDs, Tags.Nested2PartyID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};
                                            public QuickFix.Fields.Nested2PartyID nested2PartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyID val = new QuickFix.Fields.Nested2PartyID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            this.nested2PartyID = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyID get(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            return isSetNested2PartyID();
                        }
                        
                        public bool isSetNested2PartyID() 
                        { 
                            return isSetField(Tags.Nested2PartyID);
                        }
                        public QuickFix.Fields.Nested2PartyIDSource nested2PartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyIDSource val = new QuickFix.Fields.Nested2PartyIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            this.nested2PartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyIDSource get(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            return isSetNested2PartyIDSource();
                        }
                        
                        public bool isSetNested2PartyIDSource() 
                        { 
                            return isSetField(Tags.Nested2PartyIDSource);
                        }
                        public QuickFix.Fields.Nested2PartyRole nested2PartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyRole val = new QuickFix.Fields.Nested2PartyRole();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            this.nested2PartyRole = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyRole get(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            return isSetNested2PartyRole();
                        }
                        
                        public bool isSetNested2PartyRole() 
                        { 
                            return isSetField(Tags.Nested2PartyRole);
                        }
                        public QuickFix.Fields.NoNested2PartySubIDs noNested2PartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoNested2PartySubIDs val = new QuickFix.Fields.NoNested2PartySubIDs();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoNested2PartySubIDs val) 
                        { 
                            this.noNested2PartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoNested2PartySubIDs get(QuickFix.Fields.NoNested2PartySubIDs val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoNested2PartySubIDs val) 
                        { 
                            return isSetNoNested2PartySubIDs();
                        }
                        
                        public bool isSetNoNested2PartySubIDs() 
                        { 
                            return isSetField(Tags.NoNested2PartySubIDs);
                        }
                                            public class NoNested2PartySubIDs : Group
                        {
                            public NoNested2PartySubIDs() 
                              :base( Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};
                                                    public QuickFix.Fields.Nested2PartySubID nested2PartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.Nested2PartySubID val = new QuickFix.Fields.Nested2PartySubID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.Nested2PartySubID val) 
                            { 
                                this.nested2PartySubID = val;
                            }
                            
                            public QuickFix.Fields.Nested2PartySubID get(QuickFix.Fields.Nested2PartySubID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.Nested2PartySubID val) 
                            { 
                                return isSetNested2PartySubID();
                            }
                            
                            public bool isSetNested2PartySubID() 
                            { 
                                return isSetField(Tags.Nested2PartySubID);
                            }
                            public QuickFix.Fields.Nested2PartySubIDType nested2PartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.Nested2PartySubIDType val = new QuickFix.Fields.Nested2PartySubIDType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.Nested2PartySubIDType val) 
                            { 
                                this.nested2PartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.Nested2PartySubIDType get(QuickFix.Fields.Nested2PartySubIDType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.Nested2PartySubIDType val) 
                            { 
                                return isSetNested2PartySubIDType();
                            }
                            
                            public bool isSetNested2PartySubIDType() 
                            { 
                                return isSetField(Tags.Nested2PartySubIDType);
                            }
                        
                        }
                    }
                }
                public class NoSideTrdRegTS : Group
                {
                    public NoSideTrdRegTS() 
                      :base( Tags.NoSideTrdRegTS, Tags.SideTrdRegTimestamp, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.SideTrdRegTimestamp, Tags.SideTrdRegTimestampType, Tags.SideTrdRegTimestampSrc, 0};
                                    public QuickFix.Fields.SideTrdRegTimestamp sideTrdRegTimestamp
                    { 
                        get 
                        {
                            QuickFix.Fields.SideTrdRegTimestamp val = new QuickFix.Fields.SideTrdRegTimestamp();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SideTrdRegTimestamp val) 
                    { 
                        this.sideTrdRegTimestamp = val;
                    }
                    
                    public QuickFix.Fields.SideTrdRegTimestamp get(QuickFix.Fields.SideTrdRegTimestamp val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SideTrdRegTimestamp val) 
                    { 
                        return isSetSideTrdRegTimestamp();
                    }
                    
                    public bool isSetSideTrdRegTimestamp() 
                    { 
                        return isSetField(Tags.SideTrdRegTimestamp);
                    }
                    public QuickFix.Fields.SideTrdRegTimestampType sideTrdRegTimestampType
                    { 
                        get 
                        {
                            QuickFix.Fields.SideTrdRegTimestampType val = new QuickFix.Fields.SideTrdRegTimestampType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SideTrdRegTimestampType val) 
                    { 
                        this.sideTrdRegTimestampType = val;
                    }
                    
                    public QuickFix.Fields.SideTrdRegTimestampType get(QuickFix.Fields.SideTrdRegTimestampType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SideTrdRegTimestampType val) 
                    { 
                        return isSetSideTrdRegTimestampType();
                    }
                    
                    public bool isSetSideTrdRegTimestampType() 
                    { 
                        return isSetField(Tags.SideTrdRegTimestampType);
                    }
                    public QuickFix.Fields.SideTrdRegTimestampSrc sideTrdRegTimestampSrc
                    { 
                        get 
                        {
                            QuickFix.Fields.SideTrdRegTimestampSrc val = new QuickFix.Fields.SideTrdRegTimestampSrc();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SideTrdRegTimestampSrc val) 
                    { 
                        this.sideTrdRegTimestampSrc = val;
                    }
                    
                    public QuickFix.Fields.SideTrdRegTimestampSrc get(QuickFix.Fields.SideTrdRegTimestampSrc val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SideTrdRegTimestampSrc val) 
                    { 
                        return isSetSideTrdRegTimestampSrc();
                    }
                    
                    public bool isSetSideTrdRegTimestampSrc() 
                    { 
                        return isSetField(Tags.SideTrdRegTimestampSrc);
                    }
                
                }
                public class NoSettlDetails : Group
                {
                    public NoSettlDetails() 
                      :base( Tags.NoSettlDetails, Tags.SettlObligSource, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.SettlObligSource, Tags.NoSettlPartyIDs, 0};
                                    public QuickFix.Fields.SettlObligSource settlObligSource
                    { 
                        get 
                        {
                            QuickFix.Fields.SettlObligSource val = new QuickFix.Fields.SettlObligSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SettlObligSource val) 
                    { 
                        this.settlObligSource = val;
                    }
                    
                    public QuickFix.Fields.SettlObligSource get(QuickFix.Fields.SettlObligSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SettlObligSource val) 
                    { 
                        return isSetSettlObligSource();
                    }
                    
                    public bool isSetSettlObligSource() 
                    { 
                        return isSetField(Tags.SettlObligSource);
                    }
                    public QuickFix.Fields.NoSettlPartyIDs noSettlPartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoSettlPartyIDs val = new QuickFix.Fields.NoSettlPartyIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        this.noSettlPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoSettlPartyIDs get(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        return isSetNoSettlPartyIDs();
                    }
                    
                    public bool isSetNoSettlPartyIDs() 
                    { 
                        return isSetField(Tags.NoSettlPartyIDs);
                    }
                                    public class NoSettlPartyIDs : Group
                    {
                        public NoSettlPartyIDs() 
                          :base( Tags.NoSettlPartyIDs, Tags.SettlPartyID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};
                                            public QuickFix.Fields.SettlPartyID settlPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyID val = new QuickFix.Fields.SettlPartyID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.SettlPartyID val) 
                        { 
                            this.settlPartyID = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyID get(QuickFix.Fields.SettlPartyID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.SettlPartyID val) 
                        { 
                            return isSetSettlPartyID();
                        }
                        
                        public bool isSetSettlPartyID() 
                        { 
                            return isSetField(Tags.SettlPartyID);
                        }
                        public QuickFix.Fields.SettlPartyIDSource settlPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyIDSource val = new QuickFix.Fields.SettlPartyIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            this.settlPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyIDSource get(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            return isSetSettlPartyIDSource();
                        }
                        
                        public bool isSetSettlPartyIDSource() 
                        { 
                            return isSetField(Tags.SettlPartyIDSource);
                        }
                        public QuickFix.Fields.SettlPartyRole settlPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyRole val = new QuickFix.Fields.SettlPartyRole();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            this.settlPartyRole = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyRole get(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            return isSetSettlPartyRole();
                        }
                        
                        public bool isSetSettlPartyRole() 
                        { 
                            return isSetField(Tags.SettlPartyRole);
                        }
                        public QuickFix.Fields.NoSettlPartySubIDs noSettlPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoSettlPartySubIDs val = new QuickFix.Fields.NoSettlPartySubIDs();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            this.noSettlPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoSettlPartySubIDs get(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            return isSetNoSettlPartySubIDs();
                        }
                        
                        public bool isSetNoSettlPartySubIDs() 
                        { 
                            return isSetField(Tags.NoSettlPartySubIDs);
                        }
                                            public class NoSettlPartySubIDs : Group
                        {
                            public NoSettlPartySubIDs() 
                              :base( Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};
                                                    public QuickFix.Fields.SettlPartySubID settlPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.SettlPartySubID val = new QuickFix.Fields.SettlPartySubID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                this.settlPartySubID = val;
                            }
                            
                            public QuickFix.Fields.SettlPartySubID get(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                return isSetSettlPartySubID();
                            }
                            
                            public bool isSetSettlPartySubID() 
                            { 
                                return isSetField(Tags.SettlPartySubID);
                            }
                            public QuickFix.Fields.SettlPartySubIDType settlPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.SettlPartySubIDType val = new QuickFix.Fields.SettlPartySubIDType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                this.settlPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.SettlPartySubIDType get(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                return isSetSettlPartySubIDType();
                            }
                            
                            public bool isSetSettlPartySubIDType() 
                            { 
                                return isSetField(Tags.SettlPartySubIDType);
                            }
                        
                        }
                    }
                }
            }
            public class NoRootPartyIDs : Group
            {
                public NoRootPartyIDs() 
                  :base( Tags.NoRootPartyIDs, Tags.RootPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RootPartyID, Tags.RootPartyIDSource, Tags.RootPartyRole, Tags.NoRootPartySubIDs, 0};
                            public QuickFix.Fields.RootPartyID rootPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyID val = new QuickFix.Fields.RootPartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RootPartyID val) 
                { 
                    this.rootPartyID = val;
                }
                
                public QuickFix.Fields.RootPartyID get(QuickFix.Fields.RootPartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RootPartyID val) 
                { 
                    return isSetRootPartyID();
                }
                
                public bool isSetRootPartyID() 
                { 
                    return isSetField(Tags.RootPartyID);
                }
                public QuickFix.Fields.RootPartyIDSource rootPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyIDSource val = new QuickFix.Fields.RootPartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    this.rootPartyIDSource = val;
                }
                
                public QuickFix.Fields.RootPartyIDSource get(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    return isSetRootPartyIDSource();
                }
                
                public bool isSetRootPartyIDSource() 
                { 
                    return isSetField(Tags.RootPartyIDSource);
                }
                public QuickFix.Fields.RootPartyRole rootPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyRole val = new QuickFix.Fields.RootPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RootPartyRole val) 
                { 
                    this.rootPartyRole = val;
                }
                
                public QuickFix.Fields.RootPartyRole get(QuickFix.Fields.RootPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RootPartyRole val) 
                { 
                    return isSetRootPartyRole();
                }
                
                public bool isSetRootPartyRole() 
                { 
                    return isSetField(Tags.RootPartyRole);
                }
                public QuickFix.Fields.NoRootPartySubIDs noRootPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoRootPartySubIDs val = new QuickFix.Fields.NoRootPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    this.noRootPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoRootPartySubIDs get(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    return isSetNoRootPartySubIDs();
                }
                
                public bool isSetNoRootPartySubIDs() 
                { 
                    return isSetField(Tags.NoRootPartySubIDs);
                }
                            public class NoRootPartySubIDs : Group
                {
                    public NoRootPartySubIDs() 
                      :base( Tags.NoRootPartySubIDs, Tags.RootPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.RootPartySubID, Tags.RootPartySubIDType, 0};
                                    public QuickFix.Fields.RootPartySubID rootPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.RootPartySubID val = new QuickFix.Fields.RootPartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RootPartySubID val) 
                    { 
                        this.rootPartySubID = val;
                    }
                    
                    public QuickFix.Fields.RootPartySubID get(QuickFix.Fields.RootPartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RootPartySubID val) 
                    { 
                        return isSetRootPartySubID();
                    }
                    
                    public bool isSetRootPartySubID() 
                    { 
                        return isSetField(Tags.RootPartySubID);
                    }
                    public QuickFix.Fields.RootPartySubIDType rootPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.RootPartySubIDType val = new QuickFix.Fields.RootPartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        this.rootPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.RootPartySubIDType get(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        return isSetRootPartySubIDType();
                    }
                    
                    public bool isSetRootPartySubIDType() 
                    { 
                        return isSetField(Tags.RootPartySubIDType);
                    }
                
                }
            }
            public class NoTrdRepIndicators : Group
            {
                public NoTrdRepIndicators() 
                  :base( Tags.NoTrdRepIndicators, Tags.TrdRepPartyRole, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.TrdRepPartyRole, Tags.TrdRepIndicator, 0};
                            public QuickFix.Fields.TrdRepPartyRole trdRepPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.TrdRepPartyRole val = new QuickFix.Fields.TrdRepPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TrdRepPartyRole val) 
                { 
                    this.trdRepPartyRole = val;
                }
                
                public QuickFix.Fields.TrdRepPartyRole get(QuickFix.Fields.TrdRepPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TrdRepPartyRole val) 
                { 
                    return isSetTrdRepPartyRole();
                }
                
                public bool isSetTrdRepPartyRole() 
                { 
                    return isSetField(Tags.TrdRepPartyRole);
                }
                public QuickFix.Fields.TrdRepIndicator trdRepIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.TrdRepIndicator val = new QuickFix.Fields.TrdRepIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TrdRepIndicator val) 
                { 
                    this.trdRepIndicator = val;
                }
                
                public QuickFix.Fields.TrdRepIndicator get(QuickFix.Fields.TrdRepIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TrdRepIndicator val) 
                { 
                    return isSetTrdRepIndicator();
                }
                
                public bool isSetTrdRepIndicator() 
                { 
                    return isSetField(Tags.TrdRepIndicator);
                }
            
            }
        }
    }
}
