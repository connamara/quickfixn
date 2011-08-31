// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class TradeCaptureReport : Message
        {
            public const string MsgType = "AE";

            public TradeCaptureReport() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("AE"));
            }

            public TradeCaptureReport(
                    QuickFix.Fields.TradeReportID aTradeReportID,
                    QuickFix.Fields.ExecType aExecType,
                    QuickFix.Fields.PreviouslyReported aPreviouslyReported,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.LastQty aLastQty,
                    QuickFix.Fields.LastPx aLastPx,
                    QuickFix.Fields.TradeDate aTradeDate,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.tradeReportID = aTradeReportID;
                this.execType = aExecType;
                this.previouslyReported = aPreviouslyReported;
                this.symbol = aSymbol;
                this.lastQty = aLastQty;
                this.lastPx = aLastPx;
                this.tradeDate = aTradeDate;
                this.transactTime = aTransactTime;
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
            public class NoSides : Group
            {
                public NoSides() 
                  :base( Tags.NoSides, Tags.Side, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Side, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.NoPartyIDs, Tags.Account, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.ClearingFeeIndicator, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.TransBkdTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.GrossTradeAmt, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.MultiLegReportingType, Tags.NoContAmts, Tags.NoMiscFees, 0};
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
                public QuickFix.Fields.ClearingFeeIndicator clearingFeeIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.ClearingFeeIndicator val = new QuickFix.Fields.ClearingFeeIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    this.clearingFeeIndicator = val;
                }
                
                public QuickFix.Fields.ClearingFeeIndicator get(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    return isSetClearingFeeIndicator();
                }
                
                public bool isSetClearingFeeIndicator() 
                { 
                    return isSetField(Tags.ClearingFeeIndicator);
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
                            public class NoPartyIDs : Group
                {
                    public NoPartyIDs() 
                      :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};
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
