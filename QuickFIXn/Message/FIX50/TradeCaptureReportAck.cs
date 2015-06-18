using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class TradeCaptureReportAck : Message
    {
        public const string MsgType = "AR";

        public TradeCaptureReportAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }

        public QuickFix.Fields.TradeReportID TradeReportID
        {
            get
            {
                var val = new QuickFix.Fields.TradeReportID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeReportID val) { this.TradeReportID = val; }

        public QuickFix.Fields.TradeReportID Get(QuickFix.Fields.TradeReportID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeReportID val) { return IsSetTradeReportID(); }

        public bool IsSetTradeReportID() { return IsSetField(Tags.TradeReportID); }

        public QuickFix.Fields.TradeReportTransType TradeReportTransType
        {
            get
            {
                var val = new QuickFix.Fields.TradeReportTransType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeReportTransType val) { this.TradeReportTransType = val; }

        public QuickFix.Fields.TradeReportTransType Get(QuickFix.Fields.TradeReportTransType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeReportTransType val) { return IsSetTradeReportTransType(); }

        public bool IsSetTradeReportTransType() { return IsSetField(Tags.TradeReportTransType); }

        public QuickFix.Fields.TradeReportType TradeReportType
        {
            get
            {
                var val = new QuickFix.Fields.TradeReportType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeReportType val) { this.TradeReportType = val; }

        public QuickFix.Fields.TradeReportType Get(QuickFix.Fields.TradeReportType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeReportType val) { return IsSetTradeReportType(); }

        public bool IsSetTradeReportType() { return IsSetField(Tags.TradeReportType); }

        public QuickFix.Fields.TrdType TrdType
        {
            get
            {
                var val = new QuickFix.Fields.TrdType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdType val) { this.TrdType = val; }

        public QuickFix.Fields.TrdType Get(QuickFix.Fields.TrdType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdType val) { return IsSetTrdType(); }

        public bool IsSetTrdType() { return IsSetField(Tags.TrdType); }

        public QuickFix.Fields.TrdSubType TrdSubType
        {
            get
            {
                var val = new QuickFix.Fields.TrdSubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdSubType val) { this.TrdSubType = val; }

        public QuickFix.Fields.TrdSubType Get(QuickFix.Fields.TrdSubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdSubType val) { return IsSetTrdSubType(); }

        public bool IsSetTrdSubType() { return IsSetField(Tags.TrdSubType); }

        public QuickFix.Fields.SecondaryTrdType SecondaryTrdType
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryTrdType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryTrdType val) { this.SecondaryTrdType = val; }

        public QuickFix.Fields.SecondaryTrdType Get(QuickFix.Fields.SecondaryTrdType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryTrdType val) { return IsSetSecondaryTrdType(); }

        public bool IsSetSecondaryTrdType() { return IsSetField(Tags.SecondaryTrdType); }

        public QuickFix.Fields.TransferReason TransferReason
        {
            get
            {
                var val = new QuickFix.Fields.TransferReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TransferReason val) { this.TransferReason = val; }

        public QuickFix.Fields.TransferReason Get(QuickFix.Fields.TransferReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TransferReason val) { return IsSetTransferReason(); }

        public bool IsSetTransferReason() { return IsSetField(Tags.TransferReason); }

        public QuickFix.Fields.ExecType ExecType
        {
            get
            {
                var val = new QuickFix.Fields.ExecType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExecType val) { this.ExecType = val; }

        public QuickFix.Fields.ExecType Get(QuickFix.Fields.ExecType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExecType val) { return IsSetExecType(); }

        public bool IsSetExecType() { return IsSetField(Tags.ExecType); }

        public QuickFix.Fields.TradeReportRefID TradeReportRefID
        {
            get
            {
                var val = new QuickFix.Fields.TradeReportRefID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeReportRefID val) { this.TradeReportRefID = val; }

        public QuickFix.Fields.TradeReportRefID Get(QuickFix.Fields.TradeReportRefID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeReportRefID val) { return IsSetTradeReportRefID(); }

        public bool IsSetTradeReportRefID() { return IsSetField(Tags.TradeReportRefID); }

        public QuickFix.Fields.SecondaryTradeReportRefID SecondaryTradeReportRefID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryTradeReportRefID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryTradeReportRefID val) { this.SecondaryTradeReportRefID = val; }

        public QuickFix.Fields.SecondaryTradeReportRefID Get(QuickFix.Fields.SecondaryTradeReportRefID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryTradeReportRefID val) { return IsSetSecondaryTradeReportRefID(); }

        public bool IsSetSecondaryTradeReportRefID() { return IsSetField(Tags.SecondaryTradeReportRefID); }

        public QuickFix.Fields.TrdRptStatus TrdRptStatus
        {
            get
            {
                var val = new QuickFix.Fields.TrdRptStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdRptStatus val) { this.TrdRptStatus = val; }

        public QuickFix.Fields.TrdRptStatus Get(QuickFix.Fields.TrdRptStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdRptStatus val) { return IsSetTrdRptStatus(); }

        public bool IsSetTrdRptStatus() { return IsSetField(Tags.TrdRptStatus); }

        public QuickFix.Fields.TradeReportRejectReason TradeReportRejectReason
        {
            get
            {
                var val = new QuickFix.Fields.TradeReportRejectReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeReportRejectReason val) { this.TradeReportRejectReason = val; }

        public QuickFix.Fields.TradeReportRejectReason Get(QuickFix.Fields.TradeReportRejectReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeReportRejectReason val) { return IsSetTradeReportRejectReason(); }

        public bool IsSetTradeReportRejectReason() { return IsSetField(Tags.TradeReportRejectReason); }

        public QuickFix.Fields.SecondaryTradeReportID SecondaryTradeReportID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryTradeReportID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryTradeReportID val) { this.SecondaryTradeReportID = val; }

        public QuickFix.Fields.SecondaryTradeReportID Get(QuickFix.Fields.SecondaryTradeReportID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryTradeReportID val) { return IsSetSecondaryTradeReportID(); }

        public bool IsSetSecondaryTradeReportID() { return IsSetField(Tags.SecondaryTradeReportID); }

        public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
        {
            get
            {
                var val = new QuickFix.Fields.SubscriptionRequestType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SubscriptionRequestType val) { this.SubscriptionRequestType = val; }

        public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SubscriptionRequestType val) { return IsSetSubscriptionRequestType(); }

        public bool IsSetSubscriptionRequestType() { return IsSetField(Tags.SubscriptionRequestType); }

        public QuickFix.Fields.TradeLinkID TradeLinkID
        {
            get
            {
                var val = new QuickFix.Fields.TradeLinkID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeLinkID val) { this.TradeLinkID = val; }

        public QuickFix.Fields.TradeLinkID Get(QuickFix.Fields.TradeLinkID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeLinkID val) { return IsSetTradeLinkID(); }

        public bool IsSetTradeLinkID() { return IsSetField(Tags.TradeLinkID); }

        public QuickFix.Fields.TrdMatchID TrdMatchID
        {
            get
            {
                var val = new QuickFix.Fields.TrdMatchID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdMatchID val) { this.TrdMatchID = val; }

        public QuickFix.Fields.TrdMatchID Get(QuickFix.Fields.TrdMatchID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdMatchID val) { return IsSetTrdMatchID(); }

        public bool IsSetTrdMatchID() { return IsSetField(Tags.TrdMatchID); }

        public QuickFix.Fields.ExecID ExecID
        {
            get
            {
                var val = new QuickFix.Fields.ExecID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExecID val) { this.ExecID = val; }

        public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExecID val) { return IsSetExecID(); }

        public bool IsSetExecID() { return IsSetField(Tags.ExecID); }

        public QuickFix.Fields.SecondaryExecID SecondaryExecID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryExecID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryExecID val) { this.SecondaryExecID = val; }

        public QuickFix.Fields.SecondaryExecID Get(QuickFix.Fields.SecondaryExecID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryExecID val) { return IsSetSecondaryExecID(); }

        public bool IsSetSecondaryExecID() { return IsSetField(Tags.SecondaryExecID); }

        public QuickFix.Fields.Symbol Symbol
        {
            get
            {
                var val = new QuickFix.Fields.Symbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Symbol val) { this.Symbol = val; }

        public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Symbol val) { return IsSetSymbol(); }

        public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

        public QuickFix.Fields.SymbolSfx SymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.SymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SymbolSfx val) { this.SymbolSfx = val; }

        public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SymbolSfx val) { return IsSetSymbolSfx(); }

        public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

        public QuickFix.Fields.SecurityID SecurityID
        {
            get
            {
                var val = new QuickFix.Fields.SecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityID val) { this.SecurityID = val; }

        public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityID val) { return IsSetSecurityID(); }

        public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

        public QuickFix.Fields.SecurityIDSource SecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.SecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityIDSource val) { this.SecurityIDSource = val; }

        public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityIDSource val) { return IsSetSecurityIDSource(); }

        public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }

        public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSecurityAltID val) { this.NoSecurityAltID = val; }

        public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSecurityAltID val) { return IsSetNoSecurityAltID(); }

        public bool IsSetNoSecurityAltID() { return IsSetField(Tags.NoSecurityAltID); }

        public QuickFix.Fields.Product Product
        {
            get
            {
                var val = new QuickFix.Fields.Product();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Product val) { this.Product = val; }

        public QuickFix.Fields.Product Get(QuickFix.Fields.Product val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Product val) { return IsSetProduct(); }

        public bool IsSetProduct() { return IsSetField(Tags.Product); }

        public QuickFix.Fields.CFICode CFICode
        {
            get
            {
                var val = new QuickFix.Fields.CFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CFICode val) { this.CFICode = val; }

        public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CFICode val) { return IsSetCFICode(); }

        public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

        public QuickFix.Fields.SecurityType SecurityType
        {
            get
            {
                var val = new QuickFix.Fields.SecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityType val) { this.SecurityType = val; }

        public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityType val) { return IsSetSecurityType(); }

        public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

        public QuickFix.Fields.SecuritySubType SecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.SecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecuritySubType val) { this.SecuritySubType = val; }

        public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecuritySubType val) { return IsSetSecuritySubType(); }

        public bool IsSetSecuritySubType() { return IsSetField(Tags.SecuritySubType); }

        public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.MaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaturityMonthYear val) { this.MaturityMonthYear = val; }

        public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaturityMonthYear val) { return IsSetMaturityMonthYear(); }

        public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

        public QuickFix.Fields.MaturityDate MaturityDate
        {
            get
            {
                var val = new QuickFix.Fields.MaturityDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaturityDate val) { this.MaturityDate = val; }

        public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaturityDate val) { return IsSetMaturityDate(); }

        public bool IsSetMaturityDate() { return IsSetField(Tags.MaturityDate); }

        public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
        {
            get
            {
                var val = new QuickFix.Fields.CouponPaymentDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CouponPaymentDate val) { this.CouponPaymentDate = val; }

        public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CouponPaymentDate val) { return IsSetCouponPaymentDate(); }

        public bool IsSetCouponPaymentDate() { return IsSetField(Tags.CouponPaymentDate); }

        public QuickFix.Fields.IssueDate IssueDate
        {
            get
            {
                var val = new QuickFix.Fields.IssueDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IssueDate val) { this.IssueDate = val; }

        public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IssueDate val) { return IsSetIssueDate(); }

        public bool IsSetIssueDate() { return IsSetField(Tags.IssueDate); }

        public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.RepoCollateralSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RepoCollateralSecurityType val) { this.RepoCollateralSecurityType = val; }

        public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) { return IsSetRepoCollateralSecurityType(); }

        public bool IsSetRepoCollateralSecurityType() { return IsSetField(Tags.RepoCollateralSecurityType); }

        public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
        {
            get
            {
                var val = new QuickFix.Fields.RepurchaseTerm();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RepurchaseTerm val) { this.RepurchaseTerm = val; }

        public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RepurchaseTerm val) { return IsSetRepurchaseTerm(); }

        public bool IsSetRepurchaseTerm() { return IsSetField(Tags.RepurchaseTerm); }

        public QuickFix.Fields.RepurchaseRate RepurchaseRate
        {
            get
            {
                var val = new QuickFix.Fields.RepurchaseRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RepurchaseRate val) { this.RepurchaseRate = val; }

        public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RepurchaseRate val) { return IsSetRepurchaseRate(); }

        public bool IsSetRepurchaseRate() { return IsSetField(Tags.RepurchaseRate); }

        public QuickFix.Fields.Factor Factor
        {
            get
            {
                var val = new QuickFix.Fields.Factor();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Factor val) { this.Factor = val; }

        public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Factor val) { return IsSetFactor(); }

        public bool IsSetFactor() { return IsSetField(Tags.Factor); }

        public QuickFix.Fields.CreditRating CreditRating
        {
            get
            {
                var val = new QuickFix.Fields.CreditRating();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CreditRating val) { this.CreditRating = val; }

        public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CreditRating val) { return IsSetCreditRating(); }

        public bool IsSetCreditRating() { return IsSetField(Tags.CreditRating); }

        public QuickFix.Fields.InstrRegistry InstrRegistry
        {
            get
            {
                var val = new QuickFix.Fields.InstrRegistry();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InstrRegistry val) { this.InstrRegistry = val; }

        public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InstrRegistry val) { return IsSetInstrRegistry(); }

        public bool IsSetInstrRegistry() { return IsSetField(Tags.InstrRegistry); }

        public QuickFix.Fields.CountryOfIssue CountryOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.CountryOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CountryOfIssue val) { this.CountryOfIssue = val; }

        public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CountryOfIssue val) { return IsSetCountryOfIssue(); }

        public bool IsSetCountryOfIssue() { return IsSetField(Tags.CountryOfIssue); }

        public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.StateOrProvinceOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) { this.StateOrProvinceOfIssue = val; }

        public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) { return IsSetStateOrProvinceOfIssue(); }

        public bool IsSetStateOrProvinceOfIssue() { return IsSetField(Tags.StateOrProvinceOfIssue); }

        public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.LocaleOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LocaleOfIssue val) { this.LocaleOfIssue = val; }

        public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LocaleOfIssue val) { return IsSetLocaleOfIssue(); }

        public bool IsSetLocaleOfIssue() { return IsSetField(Tags.LocaleOfIssue); }

        public QuickFix.Fields.RedemptionDate RedemptionDate
        {
            get
            {
                var val = new QuickFix.Fields.RedemptionDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RedemptionDate val) { this.RedemptionDate = val; }

        public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RedemptionDate val) { return IsSetRedemptionDate(); }

        public bool IsSetRedemptionDate() { return IsSetField(Tags.RedemptionDate); }

        public QuickFix.Fields.StrikePrice StrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.StrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikePrice val) { this.StrikePrice = val; }

        public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikePrice val) { return IsSetStrikePrice(); }

        public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

        public QuickFix.Fields.StrikeCurrency StrikeCurrency
        {
            get
            {
                var val = new QuickFix.Fields.StrikeCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikeCurrency val) { this.StrikeCurrency = val; }

        public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikeCurrency val) { return IsSetStrikeCurrency(); }

        public bool IsSetStrikeCurrency() { return IsSetField(Tags.StrikeCurrency); }

        public QuickFix.Fields.OptAttribute OptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.OptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OptAttribute val) { this.OptAttribute = val; }

        public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OptAttribute val) { return IsSetOptAttribute(); }

        public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

        public QuickFix.Fields.ContractMultiplier ContractMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.ContractMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContractMultiplier val) { this.ContractMultiplier = val; }

        public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContractMultiplier val) { return IsSetContractMultiplier(); }

        public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }

        public QuickFix.Fields.CouponRate CouponRate
        {
            get
            {
                var val = new QuickFix.Fields.CouponRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CouponRate val) { this.CouponRate = val; }

        public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CouponRate val) { return IsSetCouponRate(); }

        public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }

        public QuickFix.Fields.SecurityExchange SecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.SecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityExchange val) { this.SecurityExchange = val; }

        public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityExchange val) { return IsSetSecurityExchange(); }

        public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

        public QuickFix.Fields.Issuer Issuer
        {
            get
            {
                var val = new QuickFix.Fields.Issuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Issuer val) { this.Issuer = val; }

        public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Issuer val) { return IsSetIssuer(); }

        public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

        public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedIssuerLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedIssuerLen val) { this.EncodedIssuerLen = val; }

        public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }

        public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }

        public QuickFix.Fields.EncodedIssuer EncodedIssuer
        {
            get
            {
                var val = new QuickFix.Fields.EncodedIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedIssuer val) { this.EncodedIssuer = val; }

        public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedIssuer val) { return IsSetEncodedIssuer(); }

        public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }

        public QuickFix.Fields.SecurityDesc SecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.SecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityDesc val) { this.SecurityDesc = val; }

        public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityDesc val) { return IsSetSecurityDesc(); }

        public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

        public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedSecurityDescLen val) { this.EncodedSecurityDescLen = val; }

        public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }

        public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }

        public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.EncodedSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedSecurityDesc val) { this.EncodedSecurityDesc = val; }

        public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }

        public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }

        public QuickFix.Fields.Pool Pool
        {
            get
            {
                var val = new QuickFix.Fields.Pool();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Pool val) { this.Pool = val; }

        public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Pool val) { return IsSetPool(); }

        public bool IsSetPool() { return IsSetField(Tags.Pool); }

        public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
        {
            get
            {
                var val = new QuickFix.Fields.ContractSettlMonth();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContractSettlMonth val) { this.ContractSettlMonth = val; }

        public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContractSettlMonth val) { return IsSetContractSettlMonth(); }

        public bool IsSetContractSettlMonth() { return IsSetField(Tags.ContractSettlMonth); }

        public QuickFix.Fields.CPProgram CPProgram
        {
            get
            {
                var val = new QuickFix.Fields.CPProgram();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CPProgram val) { this.CPProgram = val; }

        public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CPProgram val) { return IsSetCPProgram(); }

        public bool IsSetCPProgram() { return IsSetField(Tags.CPProgram); }

        public QuickFix.Fields.CPRegType CPRegType
        {
            get
            {
                var val = new QuickFix.Fields.CPRegType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CPRegType val) { this.CPRegType = val; }

        public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CPRegType val) { return IsSetCPRegType(); }

        public bool IsSetCPRegType() { return IsSetField(Tags.CPRegType); }

        public QuickFix.Fields.NoEvents NoEvents
        {
            get
            {
                var val = new QuickFix.Fields.NoEvents();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoEvents val) { this.NoEvents = val; }

        public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoEvents val) { return IsSetNoEvents(); }

        public bool IsSetNoEvents() { return IsSetField(Tags.NoEvents); }

        public QuickFix.Fields.DatedDate DatedDate
        {
            get
            {
                var val = new QuickFix.Fields.DatedDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DatedDate val) { this.DatedDate = val; }

        public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DatedDate val) { return IsSetDatedDate(); }

        public bool IsSetDatedDate() { return IsSetField(Tags.DatedDate); }

        public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
        {
            get
            {
                var val = new QuickFix.Fields.InterestAccrualDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InterestAccrualDate val) { this.InterestAccrualDate = val; }

        public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InterestAccrualDate val) { return IsSetInterestAccrualDate(); }

        public bool IsSetInterestAccrualDate() { return IsSetField(Tags.InterestAccrualDate); }

        public QuickFix.Fields.SecurityStat SecurityStat
        {
            get
            {
                var val = new QuickFix.Fields.SecurityStat();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityStat val) { this.SecurityStat = val; }

        public QuickFix.Fields.SecurityStat Get(QuickFix.Fields.SecurityStat val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityStat val) { return IsSetSecurityStat(); }

        public bool IsSetSecurityStat() { return IsSetField(Tags.SecurityStat); }

        public QuickFix.Fields.SettleOnOpenFlag SettleOnOpenFlag
        {
            get
            {
                var val = new QuickFix.Fields.SettleOnOpenFlag();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettleOnOpenFlag val) { this.SettleOnOpenFlag = val; }

        public QuickFix.Fields.SettleOnOpenFlag Get(QuickFix.Fields.SettleOnOpenFlag val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettleOnOpenFlag val) { return IsSetSettleOnOpenFlag(); }

        public bool IsSetSettleOnOpenFlag() { return IsSetField(Tags.SettleOnOpenFlag); }

        public QuickFix.Fields.InstrmtAssignmentMethod InstrmtAssignmentMethod
        {
            get
            {
                var val = new QuickFix.Fields.InstrmtAssignmentMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InstrmtAssignmentMethod val) { this.InstrmtAssignmentMethod = val; }

        public QuickFix.Fields.InstrmtAssignmentMethod Get(QuickFix.Fields.InstrmtAssignmentMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InstrmtAssignmentMethod val) { return IsSetInstrmtAssignmentMethod(); }

        public bool IsSetInstrmtAssignmentMethod() { return IsSetField(Tags.InstrmtAssignmentMethod); }

        public QuickFix.Fields.StrikeMultiplier StrikeMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.StrikeMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikeMultiplier val) { this.StrikeMultiplier = val; }

        public QuickFix.Fields.StrikeMultiplier Get(QuickFix.Fields.StrikeMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikeMultiplier val) { return IsSetStrikeMultiplier(); }

        public bool IsSetStrikeMultiplier() { return IsSetField(Tags.StrikeMultiplier); }

        public QuickFix.Fields.StrikeValue StrikeValue
        {
            get
            {
                var val = new QuickFix.Fields.StrikeValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikeValue val) { this.StrikeValue = val; }

        public QuickFix.Fields.StrikeValue Get(QuickFix.Fields.StrikeValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikeValue val) { return IsSetStrikeValue(); }

        public bool IsSetStrikeValue() { return IsSetField(Tags.StrikeValue); }

        public QuickFix.Fields.MinPriceIncrement MinPriceIncrement
        {
            get
            {
                var val = new QuickFix.Fields.MinPriceIncrement();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MinPriceIncrement val) { this.MinPriceIncrement = val; }

        public QuickFix.Fields.MinPriceIncrement Get(QuickFix.Fields.MinPriceIncrement val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MinPriceIncrement val) { return IsSetMinPriceIncrement(); }

        public bool IsSetMinPriceIncrement() { return IsSetField(Tags.MinPriceIncrement); }

        public QuickFix.Fields.PositionLimit PositionLimit
        {
            get
            {
                var val = new QuickFix.Fields.PositionLimit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PositionLimit val) { this.PositionLimit = val; }

        public QuickFix.Fields.PositionLimit Get(QuickFix.Fields.PositionLimit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PositionLimit val) { return IsSetPositionLimit(); }

        public bool IsSetPositionLimit() { return IsSetField(Tags.PositionLimit); }

        public QuickFix.Fields.NTPositionLimit NTPositionLimit
        {
            get
            {
                var val = new QuickFix.Fields.NTPositionLimit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NTPositionLimit val) { this.NTPositionLimit = val; }

        public QuickFix.Fields.NTPositionLimit Get(QuickFix.Fields.NTPositionLimit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NTPositionLimit val) { return IsSetNTPositionLimit(); }

        public bool IsSetNTPositionLimit() { return IsSetField(Tags.NTPositionLimit); }

        public QuickFix.Fields.NoInstrumentParties NoInstrumentParties
        {
            get
            {
                var val = new QuickFix.Fields.NoInstrumentParties();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoInstrumentParties val) { this.NoInstrumentParties = val; }

        public QuickFix.Fields.NoInstrumentParties Get(QuickFix.Fields.NoInstrumentParties val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoInstrumentParties val) { return IsSetNoInstrumentParties(); }

        public bool IsSetNoInstrumentParties() { return IsSetField(Tags.NoInstrumentParties); }

        public QuickFix.Fields.UnitOfMeasure UnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.UnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnitOfMeasure val) { this.UnitOfMeasure = val; }

        public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnitOfMeasure val) { return IsSetUnitOfMeasure(); }

        public bool IsSetUnitOfMeasure() { return IsSetField(Tags.UnitOfMeasure); }

        public QuickFix.Fields.TimeUnit TimeUnit
        {
            get
            {
                var val = new QuickFix.Fields.TimeUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TimeUnit val) { this.TimeUnit = val; }

        public QuickFix.Fields.TimeUnit Get(QuickFix.Fields.TimeUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TimeUnit val) { return IsSetTimeUnit(); }

        public bool IsSetTimeUnit() { return IsSetField(Tags.TimeUnit); }

        public QuickFix.Fields.MaturityTime MaturityTime
        {
            get
            {
                var val = new QuickFix.Fields.MaturityTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaturityTime val) { this.MaturityTime = val; }

        public QuickFix.Fields.MaturityTime Get(QuickFix.Fields.MaturityTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaturityTime val) { return IsSetMaturityTime(); }

        public bool IsSetMaturityTime() { return IsSetField(Tags.MaturityTime); }

        public QuickFix.Fields.TransactTime TransactTime
        {
            get
            {
                var val = new QuickFix.Fields.TransactTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TransactTime val) { this.TransactTime = val; }

        public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TransactTime val) { return IsSetTransactTime(); }

        public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

        public QuickFix.Fields.NoTrdRegTimestamps NoTrdRegTimestamps
        {
            get
            {
                var val = new QuickFix.Fields.NoTrdRegTimestamps();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoTrdRegTimestamps val) { this.NoTrdRegTimestamps = val; }

        public QuickFix.Fields.NoTrdRegTimestamps Get(QuickFix.Fields.NoTrdRegTimestamps val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoTrdRegTimestamps val) { return IsSetNoTrdRegTimestamps(); }

        public bool IsSetNoTrdRegTimestamps() { return IsSetField(Tags.NoTrdRegTimestamps); }

        public QuickFix.Fields.ResponseTransportType ResponseTransportType
        {
            get
            {
                var val = new QuickFix.Fields.ResponseTransportType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ResponseTransportType val) { this.ResponseTransportType = val; }

        public QuickFix.Fields.ResponseTransportType Get(QuickFix.Fields.ResponseTransportType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ResponseTransportType val) { return IsSetResponseTransportType(); }

        public bool IsSetResponseTransportType() { return IsSetField(Tags.ResponseTransportType); }

        public QuickFix.Fields.ResponseDestination ResponseDestination
        {
            get
            {
                var val = new QuickFix.Fields.ResponseDestination();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ResponseDestination val) { this.ResponseDestination = val; }

        public QuickFix.Fields.ResponseDestination Get(QuickFix.Fields.ResponseDestination val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ResponseDestination val) { return IsSetResponseDestination(); }

        public bool IsSetResponseDestination() { return IsSetField(Tags.ResponseDestination); }

        public QuickFix.Fields.Text Text
        {
            get
            {
                var val = new QuickFix.Fields.Text();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Text val) { this.Text = val; }

        public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Text val) { return IsSetText(); }

        public bool IsSetText() { return IsSetField(Tags.Text); }

        public QuickFix.Fields.EncodedTextLen EncodedTextLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedTextLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedTextLen val) { this.EncodedTextLen = val; }

        public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedTextLen val) { return IsSetEncodedTextLen(); }

        public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

        public QuickFix.Fields.EncodedText EncodedText
        {
            get
            {
                var val = new QuickFix.Fields.EncodedText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedText val) { this.EncodedText = val; }

        public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedText val) { return IsSetEncodedText(); }

        public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

        public QuickFix.Fields.NoLegs NoLegs
        {
            get
            {
                var val = new QuickFix.Fields.NoLegs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoLegs val) { this.NoLegs = val; }

        public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoLegs val) { return IsSetNoLegs(); }

        public bool IsSetNoLegs() { return IsSetField(Tags.NoLegs); }

        public QuickFix.Fields.ClearingFeeIndicator ClearingFeeIndicator
        {
            get
            {
                var val = new QuickFix.Fields.ClearingFeeIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClearingFeeIndicator val) { this.ClearingFeeIndicator = val; }

        public QuickFix.Fields.ClearingFeeIndicator Get(QuickFix.Fields.ClearingFeeIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClearingFeeIndicator val) { return IsSetClearingFeeIndicator(); }

        public bool IsSetClearingFeeIndicator() { return IsSetField(Tags.ClearingFeeIndicator); }

        public QuickFix.Fields.OrdStatus OrdStatus
        {
            get
            {
                var val = new QuickFix.Fields.OrdStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrdStatus val) { this.OrdStatus = val; }

        public QuickFix.Fields.OrdStatus Get(QuickFix.Fields.OrdStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrdStatus val) { return IsSetOrdStatus(); }

        public bool IsSetOrdStatus() { return IsSetField(Tags.OrdStatus); }

        public QuickFix.Fields.ExecRestatementReason ExecRestatementReason
        {
            get
            {
                var val = new QuickFix.Fields.ExecRestatementReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExecRestatementReason val) { this.ExecRestatementReason = val; }

        public QuickFix.Fields.ExecRestatementReason Get(QuickFix.Fields.ExecRestatementReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExecRestatementReason val) { return IsSetExecRestatementReason(); }

        public bool IsSetExecRestatementReason() { return IsSetField(Tags.ExecRestatementReason); }

        public QuickFix.Fields.PreviouslyReported PreviouslyReported
        {
            get
            {
                var val = new QuickFix.Fields.PreviouslyReported();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PreviouslyReported val) { this.PreviouslyReported = val; }

        public QuickFix.Fields.PreviouslyReported Get(QuickFix.Fields.PreviouslyReported val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PreviouslyReported val) { return IsSetPreviouslyReported(); }

        public bool IsSetPreviouslyReported() { return IsSetField(Tags.PreviouslyReported); }

        public QuickFix.Fields.PriceType PriceType
        {
            get
            {
                var val = new QuickFix.Fields.PriceType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PriceType val) { this.PriceType = val; }

        public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PriceType val) { return IsSetPriceType(); }

        public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

        public QuickFix.Fields.UnderlyingTradingSessionID UnderlyingTradingSessionID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingTradingSessionID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingTradingSessionID val) { this.UnderlyingTradingSessionID = val; }

        public QuickFix.Fields.UnderlyingTradingSessionID Get(QuickFix.Fields.UnderlyingTradingSessionID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingTradingSessionID val) { return IsSetUnderlyingTradingSessionID(); }

        public bool IsSetUnderlyingTradingSessionID() { return IsSetField(Tags.UnderlyingTradingSessionID); }

        public QuickFix.Fields.QtyType QtyType
        {
            get
            {
                var val = new QuickFix.Fields.QtyType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QtyType val) { this.QtyType = val; }

        public QuickFix.Fields.QtyType Get(QuickFix.Fields.QtyType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QtyType val) { return IsSetQtyType(); }

        public bool IsSetQtyType() { return IsSetField(Tags.QtyType); }

        public QuickFix.Fields.UnderlyingTradingSessionSubID UnderlyingTradingSessionSubID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingTradingSessionSubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingTradingSessionSubID val) { this.UnderlyingTradingSessionSubID = val; }

        public QuickFix.Fields.UnderlyingTradingSessionSubID Get(QuickFix.Fields.UnderlyingTradingSessionSubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingTradingSessionSubID val) { return IsSetUnderlyingTradingSessionSubID(); }

        public bool IsSetUnderlyingTradingSessionSubID() { return IsSetField(Tags.UnderlyingTradingSessionSubID); }

        public QuickFix.Fields.LastQty LastQty
        {
            get
            {
                var val = new QuickFix.Fields.LastQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastQty val) { this.LastQty = val; }

        public QuickFix.Fields.LastQty Get(QuickFix.Fields.LastQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastQty val) { return IsSetLastQty(); }

        public bool IsSetLastQty() { return IsSetField(Tags.LastQty); }

        public QuickFix.Fields.LastPx LastPx
        {
            get
            {
                var val = new QuickFix.Fields.LastPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastPx val) { this.LastPx = val; }

        public QuickFix.Fields.LastPx Get(QuickFix.Fields.LastPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastPx val) { return IsSetLastPx(); }

        public bool IsSetLastPx() { return IsSetField(Tags.LastPx); }

        public QuickFix.Fields.LastParPx LastParPx
        {
            get
            {
                var val = new QuickFix.Fields.LastParPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastParPx val) { this.LastParPx = val; }

        public QuickFix.Fields.LastParPx Get(QuickFix.Fields.LastParPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastParPx val) { return IsSetLastParPx(); }

        public bool IsSetLastParPx() { return IsSetField(Tags.LastParPx); }

        public QuickFix.Fields.LastSpotRate LastSpotRate
        {
            get
            {
                var val = new QuickFix.Fields.LastSpotRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastSpotRate val) { this.LastSpotRate = val; }

        public QuickFix.Fields.LastSpotRate Get(QuickFix.Fields.LastSpotRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastSpotRate val) { return IsSetLastSpotRate(); }

        public bool IsSetLastSpotRate() { return IsSetField(Tags.LastSpotRate); }

        public QuickFix.Fields.LastForwardPoints LastForwardPoints
        {
            get
            {
                var val = new QuickFix.Fields.LastForwardPoints();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastForwardPoints val) { this.LastForwardPoints = val; }

        public QuickFix.Fields.LastForwardPoints Get(QuickFix.Fields.LastForwardPoints val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastForwardPoints val) { return IsSetLastForwardPoints(); }

        public bool IsSetLastForwardPoints() { return IsSetField(Tags.LastForwardPoints); }

        public QuickFix.Fields.LastMkt LastMkt
        {
            get
            {
                var val = new QuickFix.Fields.LastMkt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastMkt val) { this.LastMkt = val; }

        public QuickFix.Fields.LastMkt Get(QuickFix.Fields.LastMkt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastMkt val) { return IsSetLastMkt(); }

        public bool IsSetLastMkt() { return IsSetField(Tags.LastMkt); }

        public QuickFix.Fields.TradeDate TradeDate
        {
            get
            {
                var val = new QuickFix.Fields.TradeDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeDate val) { this.TradeDate = val; }

        public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeDate val) { return IsSetTradeDate(); }

        public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

        public QuickFix.Fields.ClearingBusinessDate ClearingBusinessDate
        {
            get
            {
                var val = new QuickFix.Fields.ClearingBusinessDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClearingBusinessDate val) { this.ClearingBusinessDate = val; }

        public QuickFix.Fields.ClearingBusinessDate Get(QuickFix.Fields.ClearingBusinessDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClearingBusinessDate val) { return IsSetClearingBusinessDate(); }

        public bool IsSetClearingBusinessDate() { return IsSetField(Tags.ClearingBusinessDate); }

        public QuickFix.Fields.AvgPx AvgPx
        {
            get
            {
                var val = new QuickFix.Fields.AvgPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AvgPx val) { this.AvgPx = val; }

        public QuickFix.Fields.AvgPx Get(QuickFix.Fields.AvgPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AvgPx val) { return IsSetAvgPx(); }

        public bool IsSetAvgPx() { return IsSetField(Tags.AvgPx); }

        public QuickFix.Fields.AvgPxIndicator AvgPxIndicator
        {
            get
            {
                var val = new QuickFix.Fields.AvgPxIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AvgPxIndicator val) { this.AvgPxIndicator = val; }

        public QuickFix.Fields.AvgPxIndicator Get(QuickFix.Fields.AvgPxIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AvgPxIndicator val) { return IsSetAvgPxIndicator(); }

        public bool IsSetAvgPxIndicator() { return IsSetField(Tags.AvgPxIndicator); }

        public QuickFix.Fields.MultiLegReportingType MultiLegReportingType
        {
            get
            {
                var val = new QuickFix.Fields.MultiLegReportingType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MultiLegReportingType val) { this.MultiLegReportingType = val; }

        public QuickFix.Fields.MultiLegReportingType Get(QuickFix.Fields.MultiLegReportingType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MultiLegReportingType val) { return IsSetMultiLegReportingType(); }

        public bool IsSetMultiLegReportingType() { return IsSetField(Tags.MultiLegReportingType); }

        public QuickFix.Fields.TradeLegRefID TradeLegRefID
        {
            get
            {
                var val = new QuickFix.Fields.TradeLegRefID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeLegRefID val) { this.TradeLegRefID = val; }

        public QuickFix.Fields.TradeLegRefID Get(QuickFix.Fields.TradeLegRefID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeLegRefID val) { return IsSetTradeLegRefID(); }

        public bool IsSetTradeLegRefID() { return IsSetField(Tags.TradeLegRefID); }

        public QuickFix.Fields.SettlType SettlType
        {
            get
            {
                var val = new QuickFix.Fields.SettlType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlType val) { this.SettlType = val; }

        public QuickFix.Fields.SettlType Get(QuickFix.Fields.SettlType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlType val) { return IsSetSettlType(); }

        public bool IsSetSettlType() { return IsSetField(Tags.SettlType); }

        public QuickFix.Fields.MatchStatus MatchStatus
        {
            get
            {
                var val = new QuickFix.Fields.MatchStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MatchStatus val) { this.MatchStatus = val; }

        public QuickFix.Fields.MatchStatus Get(QuickFix.Fields.MatchStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MatchStatus val) { return IsSetMatchStatus(); }

        public bool IsSetMatchStatus() { return IsSetField(Tags.MatchStatus); }

        public QuickFix.Fields.MatchType MatchType
        {
            get
            {
                var val = new QuickFix.Fields.MatchType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MatchType val) { this.MatchType = val; }

        public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MatchType val) { return IsSetMatchType(); }

        public bool IsSetMatchType() { return IsSetField(Tags.MatchType); }

        public QuickFix.Fields.CopyMsgIndicator CopyMsgIndicator
        {
            get
            {
                var val = new QuickFix.Fields.CopyMsgIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CopyMsgIndicator val) { this.CopyMsgIndicator = val; }

        public QuickFix.Fields.CopyMsgIndicator Get(QuickFix.Fields.CopyMsgIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CopyMsgIndicator val) { return IsSetCopyMsgIndicator(); }

        public bool IsSetCopyMsgIndicator() { return IsSetField(Tags.CopyMsgIndicator); }

        public QuickFix.Fields.PublishTrdIndicator PublishTrdIndicator
        {
            get
            {
                var val = new QuickFix.Fields.PublishTrdIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PublishTrdIndicator val) { this.PublishTrdIndicator = val; }

        public QuickFix.Fields.PublishTrdIndicator Get(QuickFix.Fields.PublishTrdIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PublishTrdIndicator val) { return IsSetPublishTrdIndicator(); }

        public bool IsSetPublishTrdIndicator() { return IsSetField(Tags.PublishTrdIndicator); }

        public QuickFix.Fields.ShortSaleReason ShortSaleReason
        {
            get
            {
                var val = new QuickFix.Fields.ShortSaleReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ShortSaleReason val) { this.ShortSaleReason = val; }

        public QuickFix.Fields.ShortSaleReason Get(QuickFix.Fields.ShortSaleReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ShortSaleReason val) { return IsSetShortSaleReason(); }

        public bool IsSetShortSaleReason() { return IsSetField(Tags.ShortSaleReason); }

        public QuickFix.Fields.SettlDate SettlDate
        {
            get
            {
                var val = new QuickFix.Fields.SettlDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlDate val) { this.SettlDate = val; }

        public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlDate val) { return IsSetSettlDate(); }

        public bool IsSetSettlDate() { return IsSetField(Tags.SettlDate); }

        public QuickFix.Fields.SettlSessID SettlSessID
        {
            get
            {
                var val = new QuickFix.Fields.SettlSessID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlSessID val) { this.SettlSessID = val; }

        public QuickFix.Fields.SettlSessID Get(QuickFix.Fields.SettlSessID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlSessID val) { return IsSetSettlSessID(); }

        public bool IsSetSettlSessID() { return IsSetField(Tags.SettlSessID); }

        public QuickFix.Fields.SettlSessSubID SettlSessSubID
        {
            get
            {
                var val = new QuickFix.Fields.SettlSessSubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlSessSubID val) { this.SettlSessSubID = val; }

        public QuickFix.Fields.SettlSessSubID Get(QuickFix.Fields.SettlSessSubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlSessSubID val) { return IsSetSettlSessSubID(); }

        public bool IsSetSettlSessSubID() { return IsSetField(Tags.SettlSessSubID); }

        public QuickFix.Fields.NoPosAmt NoPosAmt
        {
            get
            {
                var val = new QuickFix.Fields.NoPosAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPosAmt val) { this.NoPosAmt = val; }

        public QuickFix.Fields.NoPosAmt Get(QuickFix.Fields.NoPosAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPosAmt val) { return IsSetNoPosAmt(); }

        public bool IsSetNoPosAmt() { return IsSetField(Tags.NoPosAmt); }

        public QuickFix.Fields.TierCode TierCode
        {
            get
            {
                var val = new QuickFix.Fields.TierCode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TierCode val) { this.TierCode = val; }

        public QuickFix.Fields.TierCode Get(QuickFix.Fields.TierCode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TierCode val) { return IsSetTierCode(); }

        public bool IsSetTierCode() { return IsSetField(Tags.TierCode); }

        public QuickFix.Fields.MessageEventSource MessageEventSource
        {
            get
            {
                var val = new QuickFix.Fields.MessageEventSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MessageEventSource val) { this.MessageEventSource = val; }

        public QuickFix.Fields.MessageEventSource Get(QuickFix.Fields.MessageEventSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MessageEventSource val) { return IsSetMessageEventSource(); }

        public bool IsSetMessageEventSource() { return IsSetField(Tags.MessageEventSource); }

        public QuickFix.Fields.LastUpdateTime LastUpdateTime
        {
            get
            {
                var val = new QuickFix.Fields.LastUpdateTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastUpdateTime val) { this.LastUpdateTime = val; }

        public QuickFix.Fields.LastUpdateTime Get(QuickFix.Fields.LastUpdateTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastUpdateTime val) { return IsSetLastUpdateTime(); }

        public bool IsSetLastUpdateTime() { return IsSetField(Tags.LastUpdateTime); }

        public QuickFix.Fields.RndPx RndPx
        {
            get
            {
                var val = new QuickFix.Fields.RndPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RndPx val) { this.RndPx = val; }

        public QuickFix.Fields.RndPx Get(QuickFix.Fields.RndPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RndPx val) { return IsSetRndPx(); }

        public bool IsSetRndPx() { return IsSetField(Tags.RndPx); }

        public QuickFix.Fields.NoSides NoSides
        {
            get
            {
                var val = new QuickFix.Fields.NoSides();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSides val) { this.NoSides = val; }

        public QuickFix.Fields.NoSides Get(QuickFix.Fields.NoSides val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSides val) { return IsSetNoSides(); }

        public bool IsSetNoSides() { return IsSetField(Tags.NoSides); }

        public QuickFix.Fields.AsOfIndicator AsOfIndicator
        {
            get
            {
                var val = new QuickFix.Fields.AsOfIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AsOfIndicator val) { this.AsOfIndicator = val; }

        public QuickFix.Fields.AsOfIndicator Get(QuickFix.Fields.AsOfIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AsOfIndicator val) { return IsSetAsOfIndicator(); }

        public bool IsSetAsOfIndicator() { return IsSetField(Tags.AsOfIndicator); }

        public QuickFix.Fields.TradeID TradeID
        {
            get
            {
                var val = new QuickFix.Fields.TradeID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeID val) { this.TradeID = val; }

        public QuickFix.Fields.TradeID Get(QuickFix.Fields.TradeID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeID val) { return IsSetTradeID(); }

        public bool IsSetTradeID() { return IsSetField(Tags.TradeID); }

        public QuickFix.Fields.SecondaryTradeID SecondaryTradeID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryTradeID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryTradeID val) { this.SecondaryTradeID = val; }

        public QuickFix.Fields.SecondaryTradeID Get(QuickFix.Fields.SecondaryTradeID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryTradeID val) { return IsSetSecondaryTradeID(); }

        public bool IsSetSecondaryTradeID() { return IsSetField(Tags.SecondaryTradeID); }

        public QuickFix.Fields.FirmTradeID FirmTradeID
        {
            get
            {
                var val = new QuickFix.Fields.FirmTradeID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FirmTradeID val) { this.FirmTradeID = val; }

        public QuickFix.Fields.FirmTradeID Get(QuickFix.Fields.FirmTradeID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FirmTradeID val) { return IsSetFirmTradeID(); }

        public bool IsSetFirmTradeID() { return IsSetField(Tags.FirmTradeID); }

        public QuickFix.Fields.SecondaryFirmTradeID SecondaryFirmTradeID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryFirmTradeID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryFirmTradeID val) { this.SecondaryFirmTradeID = val; }

        public QuickFix.Fields.SecondaryFirmTradeID Get(QuickFix.Fields.SecondaryFirmTradeID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryFirmTradeID val) { return IsSetSecondaryFirmTradeID(); }

        public bool IsSetSecondaryFirmTradeID() { return IsSetField(Tags.SecondaryFirmTradeID); }

        public QuickFix.Fields.CalculatedCcyLastQty CalculatedCcyLastQty
        {
            get
            {
                var val = new QuickFix.Fields.CalculatedCcyLastQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CalculatedCcyLastQty val) { this.CalculatedCcyLastQty = val; }

        public QuickFix.Fields.CalculatedCcyLastQty Get(QuickFix.Fields.CalculatedCcyLastQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CalculatedCcyLastQty val) { return IsSetCalculatedCcyLastQty(); }

        public bool IsSetCalculatedCcyLastQty() { return IsSetField(Tags.CalculatedCcyLastQty); }

        public QuickFix.Fields.LastSwapPoints LastSwapPoints
        {
            get
            {
                var val = new QuickFix.Fields.LastSwapPoints();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastSwapPoints val) { this.LastSwapPoints = val; }

        public QuickFix.Fields.LastSwapPoints Get(QuickFix.Fields.LastSwapPoints val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastSwapPoints val) { return IsSetLastSwapPoints(); }

        public bool IsSetLastSwapPoints() { return IsSetField(Tags.LastSwapPoints); }

        public QuickFix.Fields.GrossTradeAmt GrossTradeAmt
        {
            get
            {
                var val = new QuickFix.Fields.GrossTradeAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.GrossTradeAmt val) { this.GrossTradeAmt = val; }

        public QuickFix.Fields.GrossTradeAmt Get(QuickFix.Fields.GrossTradeAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.GrossTradeAmt val) { return IsSetGrossTradeAmt(); }

        public bool IsSetGrossTradeAmt() { return IsSetField(Tags.GrossTradeAmt); }

        public QuickFix.Fields.NoRootPartyIDs NoRootPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRootPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRootPartyIDs val) { this.NoRootPartyIDs = val; }

        public QuickFix.Fields.NoRootPartyIDs Get(QuickFix.Fields.NoRootPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRootPartyIDs val) { return IsSetNoRootPartyIDs(); }

        public bool IsSetNoRootPartyIDs() { return IsSetField(Tags.NoRootPartyIDs); }

        public QuickFix.Fields.TradeHandlingInstr TradeHandlingInstr
        {
            get
            {
                var val = new QuickFix.Fields.TradeHandlingInstr();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeHandlingInstr val) { this.TradeHandlingInstr = val; }

        public QuickFix.Fields.TradeHandlingInstr Get(QuickFix.Fields.TradeHandlingInstr val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeHandlingInstr val) { return IsSetTradeHandlingInstr(); }

        public bool IsSetTradeHandlingInstr() { return IsSetField(Tags.TradeHandlingInstr); }

        public QuickFix.Fields.OrigTradeHandlingInstr OrigTradeHandlingInstr
        {
            get
            {
                var val = new QuickFix.Fields.OrigTradeHandlingInstr();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigTradeHandlingInstr val) { this.OrigTradeHandlingInstr = val; }

        public QuickFix.Fields.OrigTradeHandlingInstr Get(QuickFix.Fields.OrigTradeHandlingInstr val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigTradeHandlingInstr val) { return IsSetOrigTradeHandlingInstr(); }

        public bool IsSetOrigTradeHandlingInstr() { return IsSetField(Tags.OrigTradeHandlingInstr); }

        public QuickFix.Fields.OrigTradeDate OrigTradeDate
        {
            get
            {
                var val = new QuickFix.Fields.OrigTradeDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigTradeDate val) { this.OrigTradeDate = val; }

        public QuickFix.Fields.OrigTradeDate Get(QuickFix.Fields.OrigTradeDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigTradeDate val) { return IsSetOrigTradeDate(); }

        public bool IsSetOrigTradeDate() { return IsSetField(Tags.OrigTradeDate); }

        public QuickFix.Fields.OrigTradeID OrigTradeID
        {
            get
            {
                var val = new QuickFix.Fields.OrigTradeID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigTradeID val) { this.OrigTradeID = val; }

        public QuickFix.Fields.OrigTradeID Get(QuickFix.Fields.OrigTradeID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigTradeID val) { return IsSetOrigTradeID(); }

        public bool IsSetOrigTradeID() { return IsSetField(Tags.OrigTradeID); }

        public QuickFix.Fields.OrigSecondaryTradeID OrigSecondaryTradeID
        {
            get
            {
                var val = new QuickFix.Fields.OrigSecondaryTradeID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigSecondaryTradeID val) { this.OrigSecondaryTradeID = val; }

        public QuickFix.Fields.OrigSecondaryTradeID Get(QuickFix.Fields.OrigSecondaryTradeID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigSecondaryTradeID val) { return IsSetOrigSecondaryTradeID(); }

        public bool IsSetOrigSecondaryTradeID() { return IsSetField(Tags.OrigSecondaryTradeID); }

        public QuickFix.Fields.NoUnderlyings NoUnderlyings
        {
            get
            {
                var val = new QuickFix.Fields.NoUnderlyings();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUnderlyings val) { this.NoUnderlyings = val; }

        public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUnderlyings val) { return IsSetNoUnderlyings(); }

        public bool IsSetNoUnderlyings() { return IsSetField(Tags.NoUnderlyings); }

        public QuickFix.Fields.RptSys RptSys
        {
            get
            {
                var val = new QuickFix.Fields.RptSys();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RptSys val) { this.RptSys = val; }

        public QuickFix.Fields.RptSys Get(QuickFix.Fields.RptSys val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RptSys val) { return IsSetRptSys(); }

        public bool IsSetRptSys() { return IsSetField(Tags.RptSys); }


        public class NoSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

            public NoSecurityAltIDGroup() : base(Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SecurityAltID SecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.SecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityAltID val) { this.SecurityAltID = val; }

        public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityAltID val) { return IsSetSecurityAltID(); }

        public bool IsSetSecurityAltID() { return IsSetField(Tags.SecurityAltID); }

        public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.SecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityAltIDSource val) { this.SecurityAltIDSource = val; }

        public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) { return IsSetSecurityAltIDSource(); }

        public bool IsSetSecurityAltIDSource() { return IsSetField(Tags.SecurityAltIDSource); }


        }


        public class NoEventsGroup : Group
        {
            public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0};

            public NoEventsGroup() : base(Tags.NoEvents, Tags.EventType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoEventsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.EventType EventType
        {
            get
            {
                var val = new QuickFix.Fields.EventType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EventType val) { this.EventType = val; }

        public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EventType val) { return IsSetEventType(); }

        public bool IsSetEventType() { return IsSetField(Tags.EventType); }

        public QuickFix.Fields.EventDate EventDate
        {
            get
            {
                var val = new QuickFix.Fields.EventDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EventDate val) { this.EventDate = val; }

        public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EventDate val) { return IsSetEventDate(); }

        public bool IsSetEventDate() { return IsSetField(Tags.EventDate); }

        public QuickFix.Fields.EventPx EventPx
        {
            get
            {
                var val = new QuickFix.Fields.EventPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EventPx val) { this.EventPx = val; }

        public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EventPx val) { return IsSetEventPx(); }

        public bool IsSetEventPx() { return IsSetField(Tags.EventPx); }

        public QuickFix.Fields.EventText EventText
        {
            get
            {
                var val = new QuickFix.Fields.EventText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EventText val) { this.EventText = val; }

        public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EventText val) { return IsSetEventText(); }

        public bool IsSetEventText() { return IsSetField(Tags.EventText); }


        }


        public class NoInstrumentPartiesGroup : Group
        {
            public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};

            public NoInstrumentPartiesGroup() : base(Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.InstrumentPartyID InstrumentPartyID
        {
            get
            {
                var val = new QuickFix.Fields.InstrumentPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InstrumentPartyID val) { this.InstrumentPartyID = val; }

        public QuickFix.Fields.InstrumentPartyID Get(QuickFix.Fields.InstrumentPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InstrumentPartyID val) { return IsSetInstrumentPartyID(); }

        public bool IsSetInstrumentPartyID() { return IsSetField(Tags.InstrumentPartyID); }

        public QuickFix.Fields.InstrumentPartyIDSource InstrumentPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.InstrumentPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InstrumentPartyIDSource val) { this.InstrumentPartyIDSource = val; }

        public QuickFix.Fields.InstrumentPartyIDSource Get(QuickFix.Fields.InstrumentPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InstrumentPartyIDSource val) { return IsSetInstrumentPartyIDSource(); }

        public bool IsSetInstrumentPartyIDSource() { return IsSetField(Tags.InstrumentPartyIDSource); }

        public QuickFix.Fields.InstrumentPartyRole InstrumentPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.InstrumentPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InstrumentPartyRole val) { this.InstrumentPartyRole = val; }

        public QuickFix.Fields.InstrumentPartyRole Get(QuickFix.Fields.InstrumentPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InstrumentPartyRole val) { return IsSetInstrumentPartyRole(); }

        public bool IsSetInstrumentPartyRole() { return IsSetField(Tags.InstrumentPartyRole); }

        public QuickFix.Fields.NoInstrumentPartySubIDs NoInstrumentPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoInstrumentPartySubIDs val) { this.NoInstrumentPartySubIDs = val; }

        public QuickFix.Fields.NoInstrumentPartySubIDs Get(QuickFix.Fields.NoInstrumentPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoInstrumentPartySubIDs val) { return IsSetNoInstrumentPartySubIDs(); }

        public bool IsSetNoInstrumentPartySubIDs() { return IsSetField(Tags.NoInstrumentPartySubIDs); }


        public class NoInstrumentPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};

            public NoInstrumentPartySubIDsGroup() : base(Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.InstrumentPartySubID InstrumentPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.InstrumentPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InstrumentPartySubID val) { this.InstrumentPartySubID = val; }

        public QuickFix.Fields.InstrumentPartySubID Get(QuickFix.Fields.InstrumentPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InstrumentPartySubID val) { return IsSetInstrumentPartySubID(); }

        public bool IsSetInstrumentPartySubID() { return IsSetField(Tags.InstrumentPartySubID); }

        public QuickFix.Fields.InstrumentPartySubIDType InstrumentPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.InstrumentPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InstrumentPartySubIDType val) { this.InstrumentPartySubIDType = val; }

        public QuickFix.Fields.InstrumentPartySubIDType Get(QuickFix.Fields.InstrumentPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InstrumentPartySubIDType val) { return IsSetInstrumentPartySubIDType(); }

        public bool IsSetInstrumentPartySubIDType() { return IsSetField(Tags.InstrumentPartySubIDType); }


        }
        }


        public class NoTrdRegTimestampsGroup : Group
        {
            public static int[] fieldOrder = {Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0};

            public NoTrdRegTimestampsGroup() : base(Tags.NoTrdRegTimestamps, Tags.TrdRegTimestamp, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoTrdRegTimestampsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.TrdRegTimestamp TrdRegTimestamp
        {
            get
            {
                var val = new QuickFix.Fields.TrdRegTimestamp();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdRegTimestamp val) { this.TrdRegTimestamp = val; }

        public QuickFix.Fields.TrdRegTimestamp Get(QuickFix.Fields.TrdRegTimestamp val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdRegTimestamp val) { return IsSetTrdRegTimestamp(); }

        public bool IsSetTrdRegTimestamp() { return IsSetField(Tags.TrdRegTimestamp); }

        public QuickFix.Fields.TrdRegTimestampType TrdRegTimestampType
        {
            get
            {
                var val = new QuickFix.Fields.TrdRegTimestampType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdRegTimestampType val) { this.TrdRegTimestampType = val; }

        public QuickFix.Fields.TrdRegTimestampType Get(QuickFix.Fields.TrdRegTimestampType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdRegTimestampType val) { return IsSetTrdRegTimestampType(); }

        public bool IsSetTrdRegTimestampType() { return IsSetField(Tags.TrdRegTimestampType); }

        public QuickFix.Fields.TrdRegTimestampOrigin TrdRegTimestampOrigin
        {
            get
            {
                var val = new QuickFix.Fields.TrdRegTimestampOrigin();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdRegTimestampOrigin val) { this.TrdRegTimestampOrigin = val; }

        public QuickFix.Fields.TrdRegTimestampOrigin Get(QuickFix.Fields.TrdRegTimestampOrigin val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdRegTimestampOrigin val) { return IsSetTrdRegTimestampOrigin(); }

        public bool IsSetTrdRegTimestampOrigin() { return IsSetField(Tags.TrdRegTimestampOrigin); }

        public QuickFix.Fields.DeskType DeskType
        {
            get
            {
                var val = new QuickFix.Fields.DeskType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DeskType val) { this.DeskType = val; }

        public QuickFix.Fields.DeskType Get(QuickFix.Fields.DeskType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DeskType val) { return IsSetDeskType(); }

        public bool IsSetDeskType() { return IsSetField(Tags.DeskType); }

        public QuickFix.Fields.DeskTypeSource DeskTypeSource
        {
            get
            {
                var val = new QuickFix.Fields.DeskTypeSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DeskTypeSource val) { this.DeskTypeSource = val; }

        public QuickFix.Fields.DeskTypeSource Get(QuickFix.Fields.DeskTypeSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DeskTypeSource val) { return IsSetDeskTypeSource(); }

        public bool IsSetDeskTypeSource() { return IsSetField(Tags.DeskTypeSource); }

        public QuickFix.Fields.DeskOrderHandlingInst DeskOrderHandlingInst
        {
            get
            {
                var val = new QuickFix.Fields.DeskOrderHandlingInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DeskOrderHandlingInst val) { this.DeskOrderHandlingInst = val; }

        public QuickFix.Fields.DeskOrderHandlingInst Get(QuickFix.Fields.DeskOrderHandlingInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DeskOrderHandlingInst val) { return IsSetDeskOrderHandlingInst(); }

        public bool IsSetDeskOrderHandlingInst() { return IsSetField(Tags.DeskOrderHandlingInst); }


        }


        public class NoLegsGroup : Group
        {
            public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegPrice, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegReportID, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, 0};

            public NoLegsGroup() : base(Tags.NoLegs, Tags.LegSymbol, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.LegSymbol LegSymbol
        {
            get
            {
                var val = new QuickFix.Fields.LegSymbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSymbol val) { this.LegSymbol = val; }

        public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSymbol val) { return IsSetLegSymbol(); }

        public bool IsSetLegSymbol() { return IsSetField(Tags.LegSymbol); }

        public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.LegSymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSymbolSfx val) { this.LegSymbolSfx = val; }

        public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSymbolSfx val) { return IsSetLegSymbolSfx(); }

        public bool IsSetLegSymbolSfx() { return IsSetField(Tags.LegSymbolSfx); }

        public QuickFix.Fields.LegSecurityID LegSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityID val) { this.LegSecurityID = val; }

        public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityID val) { return IsSetLegSecurityID(); }

        public bool IsSetLegSecurityID() { return IsSetField(Tags.LegSecurityID); }

        public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityIDSource val) { this.LegSecurityIDSource = val; }

        public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) { return IsSetLegSecurityIDSource(); }

        public bool IsSetLegSecurityIDSource() { return IsSetField(Tags.LegSecurityIDSource); }

        public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoLegSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoLegSecurityAltID val) { this.NoLegSecurityAltID = val; }

        public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) { return IsSetNoLegSecurityAltID(); }

        public bool IsSetNoLegSecurityAltID() { return IsSetField(Tags.NoLegSecurityAltID); }

        public QuickFix.Fields.LegProduct LegProduct
        {
            get
            {
                var val = new QuickFix.Fields.LegProduct();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegProduct val) { this.LegProduct = val; }

        public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegProduct val) { return IsSetLegProduct(); }

        public bool IsSetLegProduct() { return IsSetField(Tags.LegProduct); }

        public QuickFix.Fields.LegCFICode LegCFICode
        {
            get
            {
                var val = new QuickFix.Fields.LegCFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCFICode val) { this.LegCFICode = val; }

        public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCFICode val) { return IsSetLegCFICode(); }

        public bool IsSetLegCFICode() { return IsSetField(Tags.LegCFICode); }

        public QuickFix.Fields.LegSecurityType LegSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityType val) { this.LegSecurityType = val; }

        public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityType val) { return IsSetLegSecurityType(); }

        public bool IsSetLegSecurityType() { return IsSetField(Tags.LegSecurityType); }

        public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.LegSecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecuritySubType val) { this.LegSecuritySubType = val; }

        public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecuritySubType val) { return IsSetLegSecuritySubType(); }

        public bool IsSetLegSecuritySubType() { return IsSetField(Tags.LegSecuritySubType); }

        public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.LegMaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegMaturityMonthYear val) { this.LegMaturityMonthYear = val; }

        public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) { return IsSetLegMaturityMonthYear(); }

        public bool IsSetLegMaturityMonthYear() { return IsSetField(Tags.LegMaturityMonthYear); }

        public QuickFix.Fields.LegMaturityDate LegMaturityDate
        {
            get
            {
                var val = new QuickFix.Fields.LegMaturityDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegMaturityDate val) { this.LegMaturityDate = val; }

        public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegMaturityDate val) { return IsSetLegMaturityDate(); }

        public bool IsSetLegMaturityDate() { return IsSetField(Tags.LegMaturityDate); }

        public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
        {
            get
            {
                var val = new QuickFix.Fields.LegCouponPaymentDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCouponPaymentDate val) { this.LegCouponPaymentDate = val; }

        public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) { return IsSetLegCouponPaymentDate(); }

        public bool IsSetLegCouponPaymentDate() { return IsSetField(Tags.LegCouponPaymentDate); }

        public QuickFix.Fields.LegIssueDate LegIssueDate
        {
            get
            {
                var val = new QuickFix.Fields.LegIssueDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegIssueDate val) { this.LegIssueDate = val; }

        public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegIssueDate val) { return IsSetLegIssueDate(); }

        public bool IsSetLegIssueDate() { return IsSetField(Tags.LegIssueDate); }

        public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) { this.LegRepoCollateralSecurityType = val; }

        public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) { return IsSetLegRepoCollateralSecurityType(); }

        public bool IsSetLegRepoCollateralSecurityType() { return IsSetField(Tags.LegRepoCollateralSecurityType); }

        public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
        {
            get
            {
                var val = new QuickFix.Fields.LegRepurchaseTerm();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRepurchaseTerm val) { this.LegRepurchaseTerm = val; }

        public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) { return IsSetLegRepurchaseTerm(); }

        public bool IsSetLegRepurchaseTerm() { return IsSetField(Tags.LegRepurchaseTerm); }

        public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
        {
            get
            {
                var val = new QuickFix.Fields.LegRepurchaseRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRepurchaseRate val) { this.LegRepurchaseRate = val; }

        public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) { return IsSetLegRepurchaseRate(); }

        public bool IsSetLegRepurchaseRate() { return IsSetField(Tags.LegRepurchaseRate); }

        public QuickFix.Fields.LegFactor LegFactor
        {
            get
            {
                var val = new QuickFix.Fields.LegFactor();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegFactor val) { this.LegFactor = val; }

        public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegFactor val) { return IsSetLegFactor(); }

        public bool IsSetLegFactor() { return IsSetField(Tags.LegFactor); }

        public QuickFix.Fields.LegCreditRating LegCreditRating
        {
            get
            {
                var val = new QuickFix.Fields.LegCreditRating();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCreditRating val) { this.LegCreditRating = val; }

        public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCreditRating val) { return IsSetLegCreditRating(); }

        public bool IsSetLegCreditRating() { return IsSetField(Tags.LegCreditRating); }

        public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
        {
            get
            {
                var val = new QuickFix.Fields.LegInstrRegistry();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegInstrRegistry val) { this.LegInstrRegistry = val; }

        public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegInstrRegistry val) { return IsSetLegInstrRegistry(); }

        public bool IsSetLegInstrRegistry() { return IsSetField(Tags.LegInstrRegistry); }

        public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.LegCountryOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCountryOfIssue val) { this.LegCountryOfIssue = val; }

        public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) { return IsSetLegCountryOfIssue(); }

        public bool IsSetLegCountryOfIssue() { return IsSetField(Tags.LegCountryOfIssue); }

        public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) { this.LegStateOrProvinceOfIssue = val; }

        public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) { return IsSetLegStateOrProvinceOfIssue(); }

        public bool IsSetLegStateOrProvinceOfIssue() { return IsSetField(Tags.LegStateOrProvinceOfIssue); }

        public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.LegLocaleOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegLocaleOfIssue val) { this.LegLocaleOfIssue = val; }

        public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) { return IsSetLegLocaleOfIssue(); }

        public bool IsSetLegLocaleOfIssue() { return IsSetField(Tags.LegLocaleOfIssue); }

        public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
        {
            get
            {
                var val = new QuickFix.Fields.LegRedemptionDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRedemptionDate val) { this.LegRedemptionDate = val; }

        public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRedemptionDate val) { return IsSetLegRedemptionDate(); }

        public bool IsSetLegRedemptionDate() { return IsSetField(Tags.LegRedemptionDate); }

        public QuickFix.Fields.LegStrikePrice LegStrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.LegStrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegStrikePrice val) { this.LegStrikePrice = val; }

        public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegStrikePrice val) { return IsSetLegStrikePrice(); }

        public bool IsSetLegStrikePrice() { return IsSetField(Tags.LegStrikePrice); }

        public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
        {
            get
            {
                var val = new QuickFix.Fields.LegStrikeCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegStrikeCurrency val) { this.LegStrikeCurrency = val; }

        public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) { return IsSetLegStrikeCurrency(); }

        public bool IsSetLegStrikeCurrency() { return IsSetField(Tags.LegStrikeCurrency); }

        public QuickFix.Fields.LegOptAttribute LegOptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.LegOptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegOptAttribute val) { this.LegOptAttribute = val; }

        public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegOptAttribute val) { return IsSetLegOptAttribute(); }

        public bool IsSetLegOptAttribute() { return IsSetField(Tags.LegOptAttribute); }

        public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.LegContractMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegContractMultiplier val) { this.LegContractMultiplier = val; }

        public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegContractMultiplier val) { return IsSetLegContractMultiplier(); }

        public bool IsSetLegContractMultiplier() { return IsSetField(Tags.LegContractMultiplier); }

        public QuickFix.Fields.LegCouponRate LegCouponRate
        {
            get
            {
                var val = new QuickFix.Fields.LegCouponRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCouponRate val) { this.LegCouponRate = val; }

        public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCouponRate val) { return IsSetLegCouponRate(); }

        public bool IsSetLegCouponRate() { return IsSetField(Tags.LegCouponRate); }

        public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityExchange val) { this.LegSecurityExchange = val; }

        public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityExchange val) { return IsSetLegSecurityExchange(); }

        public bool IsSetLegSecurityExchange() { return IsSetField(Tags.LegSecurityExchange); }

        public QuickFix.Fields.LegIssuer LegIssuer
        {
            get
            {
                var val = new QuickFix.Fields.LegIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegIssuer val) { this.LegIssuer = val; }

        public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegIssuer val) { return IsSetLegIssuer(); }

        public bool IsSetLegIssuer() { return IsSetField(Tags.LegIssuer); }

        public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedLegIssuerLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedLegIssuerLen val) { this.EncodedLegIssuerLen = val; }

        public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) { return IsSetEncodedLegIssuerLen(); }

        public bool IsSetEncodedLegIssuerLen() { return IsSetField(Tags.EncodedLegIssuerLen); }

        public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
        {
            get
            {
                var val = new QuickFix.Fields.EncodedLegIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedLegIssuer val) { this.EncodedLegIssuer = val; }

        public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) { return IsSetEncodedLegIssuer(); }

        public bool IsSetEncodedLegIssuer() { return IsSetField(Tags.EncodedLegIssuer); }

        public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityDesc val) { this.LegSecurityDesc = val; }

        public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityDesc val) { return IsSetLegSecurityDesc(); }

        public bool IsSetLegSecurityDesc() { return IsSetField(Tags.LegSecurityDesc); }

        public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) { this.EncodedLegSecurityDescLen = val; }

        public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) { return IsSetEncodedLegSecurityDescLen(); }

        public bool IsSetEncodedLegSecurityDescLen() { return IsSetField(Tags.EncodedLegSecurityDescLen); }

        public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.EncodedLegSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) { this.EncodedLegSecurityDesc = val; }

        public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) { return IsSetEncodedLegSecurityDesc(); }

        public bool IsSetEncodedLegSecurityDesc() { return IsSetField(Tags.EncodedLegSecurityDesc); }

        public QuickFix.Fields.LegRatioQty LegRatioQty
        {
            get
            {
                var val = new QuickFix.Fields.LegRatioQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRatioQty val) { this.LegRatioQty = val; }

        public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRatioQty val) { return IsSetLegRatioQty(); }

        public bool IsSetLegRatioQty() { return IsSetField(Tags.LegRatioQty); }

        public QuickFix.Fields.LegSide LegSide
        {
            get
            {
                var val = new QuickFix.Fields.LegSide();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSide val) { this.LegSide = val; }

        public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSide val) { return IsSetLegSide(); }

        public bool IsSetLegSide() { return IsSetField(Tags.LegSide); }

        public QuickFix.Fields.LegCurrency LegCurrency
        {
            get
            {
                var val = new QuickFix.Fields.LegCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCurrency val) { this.LegCurrency = val; }

        public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCurrency val) { return IsSetLegCurrency(); }

        public bool IsSetLegCurrency() { return IsSetField(Tags.LegCurrency); }

        public QuickFix.Fields.LegPool LegPool
        {
            get
            {
                var val = new QuickFix.Fields.LegPool();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegPool val) { this.LegPool = val; }

        public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegPool val) { return IsSetLegPool(); }

        public bool IsSetLegPool() { return IsSetField(Tags.LegPool); }

        public QuickFix.Fields.LegDatedDate LegDatedDate
        {
            get
            {
                var val = new QuickFix.Fields.LegDatedDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegDatedDate val) { this.LegDatedDate = val; }

        public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegDatedDate val) { return IsSetLegDatedDate(); }

        public bool IsSetLegDatedDate() { return IsSetField(Tags.LegDatedDate); }

        public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
        {
            get
            {
                var val = new QuickFix.Fields.LegContractSettlMonth();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegContractSettlMonth val) { this.LegContractSettlMonth = val; }

        public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) { return IsSetLegContractSettlMonth(); }

        public bool IsSetLegContractSettlMonth() { return IsSetField(Tags.LegContractSettlMonth); }

        public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
        {
            get
            {
                var val = new QuickFix.Fields.LegInterestAccrualDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegInterestAccrualDate val) { this.LegInterestAccrualDate = val; }

        public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) { return IsSetLegInterestAccrualDate(); }

        public bool IsSetLegInterestAccrualDate() { return IsSetField(Tags.LegInterestAccrualDate); }

        public QuickFix.Fields.LegUnitOfMeasure LegUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.LegUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegUnitOfMeasure val) { this.LegUnitOfMeasure = val; }

        public QuickFix.Fields.LegUnitOfMeasure Get(QuickFix.Fields.LegUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegUnitOfMeasure val) { return IsSetLegUnitOfMeasure(); }

        public bool IsSetLegUnitOfMeasure() { return IsSetField(Tags.LegUnitOfMeasure); }

        public QuickFix.Fields.LegTimeUnit LegTimeUnit
        {
            get
            {
                var val = new QuickFix.Fields.LegTimeUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegTimeUnit val) { this.LegTimeUnit = val; }

        public QuickFix.Fields.LegTimeUnit Get(QuickFix.Fields.LegTimeUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegTimeUnit val) { return IsSetLegTimeUnit(); }

        public bool IsSetLegTimeUnit() { return IsSetField(Tags.LegTimeUnit); }

        public QuickFix.Fields.LegQty LegQty
        {
            get
            {
                var val = new QuickFix.Fields.LegQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegQty val) { this.LegQty = val; }

        public QuickFix.Fields.LegQty Get(QuickFix.Fields.LegQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegQty val) { return IsSetLegQty(); }

        public bool IsSetLegQty() { return IsSetField(Tags.LegQty); }

        public QuickFix.Fields.LegSwapType LegSwapType
        {
            get
            {
                var val = new QuickFix.Fields.LegSwapType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSwapType val) { this.LegSwapType = val; }

        public QuickFix.Fields.LegSwapType Get(QuickFix.Fields.LegSwapType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSwapType val) { return IsSetLegSwapType(); }

        public bool IsSetLegSwapType() { return IsSetField(Tags.LegSwapType); }

        public QuickFix.Fields.NoLegStipulations NoLegStipulations
        {
            get
            {
                var val = new QuickFix.Fields.NoLegStipulations();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoLegStipulations val) { this.NoLegStipulations = val; }

        public QuickFix.Fields.NoLegStipulations Get(QuickFix.Fields.NoLegStipulations val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoLegStipulations val) { return IsSetNoLegStipulations(); }

        public bool IsSetNoLegStipulations() { return IsSetField(Tags.NoLegStipulations); }

        public QuickFix.Fields.LegPositionEffect LegPositionEffect
        {
            get
            {
                var val = new QuickFix.Fields.LegPositionEffect();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegPositionEffect val) { this.LegPositionEffect = val; }

        public QuickFix.Fields.LegPositionEffect Get(QuickFix.Fields.LegPositionEffect val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegPositionEffect val) { return IsSetLegPositionEffect(); }

        public bool IsSetLegPositionEffect() { return IsSetField(Tags.LegPositionEffect); }

        public QuickFix.Fields.LegCoveredOrUncovered LegCoveredOrUncovered
        {
            get
            {
                var val = new QuickFix.Fields.LegCoveredOrUncovered();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCoveredOrUncovered val) { this.LegCoveredOrUncovered = val; }

        public QuickFix.Fields.LegCoveredOrUncovered Get(QuickFix.Fields.LegCoveredOrUncovered val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCoveredOrUncovered val) { return IsSetLegCoveredOrUncovered(); }

        public bool IsSetLegCoveredOrUncovered() { return IsSetField(Tags.LegCoveredOrUncovered); }

        public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoNestedPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoNestedPartyIDs val) { this.NoNestedPartyIDs = val; }

        public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) { return IsSetNoNestedPartyIDs(); }

        public bool IsSetNoNestedPartyIDs() { return IsSetField(Tags.NoNestedPartyIDs); }

        public QuickFix.Fields.LegRefID LegRefID
        {
            get
            {
                var val = new QuickFix.Fields.LegRefID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRefID val) { this.LegRefID = val; }

        public QuickFix.Fields.LegRefID Get(QuickFix.Fields.LegRefID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRefID val) { return IsSetLegRefID(); }

        public bool IsSetLegRefID() { return IsSetField(Tags.LegRefID); }

        public QuickFix.Fields.LegPrice LegPrice
        {
            get
            {
                var val = new QuickFix.Fields.LegPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegPrice val) { this.LegPrice = val; }

        public QuickFix.Fields.LegPrice Get(QuickFix.Fields.LegPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegPrice val) { return IsSetLegPrice(); }

        public bool IsSetLegPrice() { return IsSetField(Tags.LegPrice); }

        public QuickFix.Fields.LegSettlType LegSettlType
        {
            get
            {
                var val = new QuickFix.Fields.LegSettlType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSettlType val) { this.LegSettlType = val; }

        public QuickFix.Fields.LegSettlType Get(QuickFix.Fields.LegSettlType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSettlType val) { return IsSetLegSettlType(); }

        public bool IsSetLegSettlType() { return IsSetField(Tags.LegSettlType); }

        public QuickFix.Fields.LegSettlDate LegSettlDate
        {
            get
            {
                var val = new QuickFix.Fields.LegSettlDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSettlDate val) { this.LegSettlDate = val; }

        public QuickFix.Fields.LegSettlDate Get(QuickFix.Fields.LegSettlDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSettlDate val) { return IsSetLegSettlDate(); }

        public bool IsSetLegSettlDate() { return IsSetField(Tags.LegSettlDate); }

        public QuickFix.Fields.LegLastPx LegLastPx
        {
            get
            {
                var val = new QuickFix.Fields.LegLastPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegLastPx val) { this.LegLastPx = val; }

        public QuickFix.Fields.LegLastPx Get(QuickFix.Fields.LegLastPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegLastPx val) { return IsSetLegLastPx(); }

        public bool IsSetLegLastPx() { return IsSetField(Tags.LegLastPx); }

        public QuickFix.Fields.LegReportID LegReportID
        {
            get
            {
                var val = new QuickFix.Fields.LegReportID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegReportID val) { this.LegReportID = val; }

        public QuickFix.Fields.LegReportID Get(QuickFix.Fields.LegReportID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegReportID val) { return IsSetLegReportID(); }

        public bool IsSetLegReportID() { return IsSetField(Tags.LegReportID); }

        public QuickFix.Fields.LegSettlCurrency LegSettlCurrency
        {
            get
            {
                var val = new QuickFix.Fields.LegSettlCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSettlCurrency val) { this.LegSettlCurrency = val; }

        public QuickFix.Fields.LegSettlCurrency Get(QuickFix.Fields.LegSettlCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSettlCurrency val) { return IsSetLegSettlCurrency(); }

        public bool IsSetLegSettlCurrency() { return IsSetField(Tags.LegSettlCurrency); }

        public QuickFix.Fields.LegLastForwardPoints LegLastForwardPoints
        {
            get
            {
                var val = new QuickFix.Fields.LegLastForwardPoints();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegLastForwardPoints val) { this.LegLastForwardPoints = val; }

        public QuickFix.Fields.LegLastForwardPoints Get(QuickFix.Fields.LegLastForwardPoints val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegLastForwardPoints val) { return IsSetLegLastForwardPoints(); }

        public bool IsSetLegLastForwardPoints() { return IsSetField(Tags.LegLastForwardPoints); }

        public QuickFix.Fields.LegCalculatedCcyLastQty LegCalculatedCcyLastQty
        {
            get
            {
                var val = new QuickFix.Fields.LegCalculatedCcyLastQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCalculatedCcyLastQty val) { this.LegCalculatedCcyLastQty = val; }

        public QuickFix.Fields.LegCalculatedCcyLastQty Get(QuickFix.Fields.LegCalculatedCcyLastQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCalculatedCcyLastQty val) { return IsSetLegCalculatedCcyLastQty(); }

        public bool IsSetLegCalculatedCcyLastQty() { return IsSetField(Tags.LegCalculatedCcyLastQty); }

        public QuickFix.Fields.LegGrossTradeAmt LegGrossTradeAmt
        {
            get
            {
                var val = new QuickFix.Fields.LegGrossTradeAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegGrossTradeAmt val) { this.LegGrossTradeAmt = val; }

        public QuickFix.Fields.LegGrossTradeAmt Get(QuickFix.Fields.LegGrossTradeAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegGrossTradeAmt val) { return IsSetLegGrossTradeAmt(); }

        public bool IsSetLegGrossTradeAmt() { return IsSetField(Tags.LegGrossTradeAmt); }


        public class NoLegSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};

            public NoLegSecurityAltIDGroup() : base(Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityAltID val) { this.LegSecurityAltID = val; }

        public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityAltID val) { return IsSetLegSecurityAltID(); }

        public bool IsSetLegSecurityAltID() { return IsSetField(Tags.LegSecurityAltID); }

        public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityAltIDSource val) { this.LegSecurityAltIDSource = val; }

        public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) { return IsSetLegSecurityAltIDSource(); }

        public bool IsSetLegSecurityAltIDSource() { return IsSetField(Tags.LegSecurityAltIDSource); }


        }
        public class NoLegStipulationsGroup : Group
        {
            public static int[] fieldOrder = {Tags.LegStipulationType, Tags.LegStipulationValue, 0};

            public NoLegStipulationsGroup() : base(Tags.NoLegStipulations, Tags.LegStipulationType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegStipulationsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.LegStipulationType LegStipulationType
        {
            get
            {
                var val = new QuickFix.Fields.LegStipulationType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegStipulationType val) { this.LegStipulationType = val; }

        public QuickFix.Fields.LegStipulationType Get(QuickFix.Fields.LegStipulationType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegStipulationType val) { return IsSetLegStipulationType(); }

        public bool IsSetLegStipulationType() { return IsSetField(Tags.LegStipulationType); }

        public QuickFix.Fields.LegStipulationValue LegStipulationValue
        {
            get
            {
                var val = new QuickFix.Fields.LegStipulationValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegStipulationValue val) { this.LegStipulationValue = val; }

        public QuickFix.Fields.LegStipulationValue Get(QuickFix.Fields.LegStipulationValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegStipulationValue val) { return IsSetLegStipulationValue(); }

        public bool IsSetLegStipulationValue() { return IsSetField(Tags.LegStipulationValue); }


        }
        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};

            public NoNestedPartyIDsGroup() : base(Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.NestedPartyID NestedPartyID
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartyID val) { this.NestedPartyID = val; }

        public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartyID val) { return IsSetNestedPartyID(); }

        public bool IsSetNestedPartyID() { return IsSetField(Tags.NestedPartyID); }

        public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartyIDSource val) { this.NestedPartyIDSource = val; }

        public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) { return IsSetNestedPartyIDSource(); }

        public bool IsSetNestedPartyIDSource() { return IsSetField(Tags.NestedPartyIDSource); }

        public QuickFix.Fields.NestedPartyRole NestedPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartyRole val) { this.NestedPartyRole = val; }

        public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartyRole val) { return IsSetNestedPartyRole(); }

        public bool IsSetNestedPartyRole() { return IsSetField(Tags.NestedPartyRole); }

        public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoNestedPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoNestedPartySubIDs val) { this.NoNestedPartySubIDs = val; }

        public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) { return IsSetNoNestedPartySubIDs(); }

        public bool IsSetNoNestedPartySubIDs() { return IsSetField(Tags.NoNestedPartySubIDs); }


        public class NoNestedPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};

            public NoNestedPartySubIDsGroup() : base(Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.NestedPartySubID NestedPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartySubID val) { this.NestedPartySubID = val; }

        public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartySubID val) { return IsSetNestedPartySubID(); }

        public bool IsSetNestedPartySubID() { return IsSetField(Tags.NestedPartySubID); }

        public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartySubIDType val) { this.NestedPartySubIDType = val; }

        public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) { return IsSetNestedPartySubIDType(); }

        public bool IsSetNestedPartySubIDType() { return IsSetField(Tags.NestedPartySubIDType); }


        }
        }
        }


        public class NoPosAmtGroup : Group
        {
            public static int[] fieldOrder = {Tags.PosAmtType, Tags.PosAmt, Tags.PositionCurrency, 0};

            public NoPosAmtGroup() : base(Tags.NoPosAmt, Tags.PosAmtType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPosAmtGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PosAmtType PosAmtType
        {
            get
            {
                var val = new QuickFix.Fields.PosAmtType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PosAmtType val) { this.PosAmtType = val; }

        public QuickFix.Fields.PosAmtType Get(QuickFix.Fields.PosAmtType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PosAmtType val) { return IsSetPosAmtType(); }

        public bool IsSetPosAmtType() { return IsSetField(Tags.PosAmtType); }

        public QuickFix.Fields.PosAmt PosAmt
        {
            get
            {
                var val = new QuickFix.Fields.PosAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PosAmt val) { this.PosAmt = val; }

        public QuickFix.Fields.PosAmt Get(QuickFix.Fields.PosAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PosAmt val) { return IsSetPosAmt(); }

        public bool IsSetPosAmt() { return IsSetField(Tags.PosAmt); }

        public QuickFix.Fields.PositionCurrency PositionCurrency
        {
            get
            {
                var val = new QuickFix.Fields.PositionCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PositionCurrency val) { this.PositionCurrency = val; }

        public QuickFix.Fields.PositionCurrency Get(QuickFix.Fields.PositionCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PositionCurrency val) { return IsSetPositionCurrency(); }

        public bool IsSetPositionCurrency() { return IsSetField(Tags.PositionCurrency); }


        }


        public class NoSidesGroup : Group
        {
            public static int[] fieldOrder = {Tags.Side, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoPartyIDs, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.OrderInputDevice, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.OrdType, Tags.ExecInst, Tags.TransBkdTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TimeBracket, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.InterestAtMaturity, Tags.EndAccruedInterestAmt, Tags.StartCash, Tags.EndCash, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.SideMultiLegReportingType, Tags.NoContAmts, Tags.NoStipulations, Tags.NoMiscFees, Tags.ExchangeRule, Tags.TradeAllocIndicator, Tags.PreallocMethod, Tags.AllocID, Tags.NoAllocs, Tags.LotType, Tags.SideGrossTradeAmt, Tags.AggressorIndicator, Tags.SideQty, Tags.SideTradeReportID, Tags.SideFillStationCd, Tags.SideReasonCd, Tags.RptSeq, Tags.SideTrdSubTyp, Tags.NoSideTrdRegTS, 0};

            public NoSidesGroup() : base(Tags.NoSides, Tags.Side, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSidesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.Side Side
        {
            get
            {
                var val = new QuickFix.Fields.Side();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Side val) { this.Side = val; }

        public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Side val) { return IsSetSide(); }

        public bool IsSetSide() { return IsSetField(Tags.Side); }

        public QuickFix.Fields.OrderID OrderID
        {
            get
            {
                var val = new QuickFix.Fields.OrderID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderID val) { this.OrderID = val; }

        public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderID val) { return IsSetOrderID(); }

        public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

        public QuickFix.Fields.SecondaryOrderID SecondaryOrderID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryOrderID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryOrderID val) { this.SecondaryOrderID = val; }

        public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryOrderID val) { return IsSetSecondaryOrderID(); }

        public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }

        public QuickFix.Fields.ClOrdID ClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.ClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClOrdID val) { this.ClOrdID = val; }

        public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClOrdID val) { return IsSetClOrdID(); }

        public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

        public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryClOrdID val) { this.SecondaryClOrdID = val; }

        public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }

        public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

        public QuickFix.Fields.ListID ListID
        {
            get
            {
                var val = new QuickFix.Fields.ListID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ListID val) { this.ListID = val; }

        public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ListID val) { return IsSetListID(); }

        public bool IsSetListID() { return IsSetField(Tags.ListID); }

        public QuickFix.Fields.NoPartyIDs NoPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyIDs val) { this.NoPartyIDs = val; }

        public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyIDs val) { return IsSetNoPartyIDs(); }

        public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

        public QuickFix.Fields.Account Account
        {
            get
            {
                var val = new QuickFix.Fields.Account();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Account val) { this.Account = val; }

        public QuickFix.Fields.Account Get(QuickFix.Fields.Account val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Account val) { return IsSetAccount(); }

        public bool IsSetAccount() { return IsSetField(Tags.Account); }

        public QuickFix.Fields.AcctIDSource AcctIDSource
        {
            get
            {
                var val = new QuickFix.Fields.AcctIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AcctIDSource val) { this.AcctIDSource = val; }

        public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AcctIDSource val) { return IsSetAcctIDSource(); }

        public bool IsSetAcctIDSource() { return IsSetField(Tags.AcctIDSource); }

        public QuickFix.Fields.AccountType AccountType
        {
            get
            {
                var val = new QuickFix.Fields.AccountType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AccountType val) { this.AccountType = val; }

        public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AccountType val) { return IsSetAccountType(); }

        public bool IsSetAccountType() { return IsSetField(Tags.AccountType); }

        public QuickFix.Fields.ProcessCode ProcessCode
        {
            get
            {
                var val = new QuickFix.Fields.ProcessCode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ProcessCode val) { this.ProcessCode = val; }

        public QuickFix.Fields.ProcessCode Get(QuickFix.Fields.ProcessCode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ProcessCode val) { return IsSetProcessCode(); }

        public bool IsSetProcessCode() { return IsSetField(Tags.ProcessCode); }

        public QuickFix.Fields.OddLot OddLot
        {
            get
            {
                var val = new QuickFix.Fields.OddLot();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OddLot val) { this.OddLot = val; }

        public QuickFix.Fields.OddLot Get(QuickFix.Fields.OddLot val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OddLot val) { return IsSetOddLot(); }

        public bool IsSetOddLot() { return IsSetField(Tags.OddLot); }

        public QuickFix.Fields.NoClearingInstructions NoClearingInstructions
        {
            get
            {
                var val = new QuickFix.Fields.NoClearingInstructions();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoClearingInstructions val) { this.NoClearingInstructions = val; }

        public QuickFix.Fields.NoClearingInstructions Get(QuickFix.Fields.NoClearingInstructions val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoClearingInstructions val) { return IsSetNoClearingInstructions(); }

        public bool IsSetNoClearingInstructions() { return IsSetField(Tags.NoClearingInstructions); }

        public QuickFix.Fields.TradeInputSource TradeInputSource
        {
            get
            {
                var val = new QuickFix.Fields.TradeInputSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeInputSource val) { this.TradeInputSource = val; }

        public QuickFix.Fields.TradeInputSource Get(QuickFix.Fields.TradeInputSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeInputSource val) { return IsSetTradeInputSource(); }

        public bool IsSetTradeInputSource() { return IsSetField(Tags.TradeInputSource); }

        public QuickFix.Fields.TradeInputDevice TradeInputDevice
        {
            get
            {
                var val = new QuickFix.Fields.TradeInputDevice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeInputDevice val) { this.TradeInputDevice = val; }

        public QuickFix.Fields.TradeInputDevice Get(QuickFix.Fields.TradeInputDevice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeInputDevice val) { return IsSetTradeInputDevice(); }

        public bool IsSetTradeInputDevice() { return IsSetField(Tags.TradeInputDevice); }

        public QuickFix.Fields.OrderInputDevice OrderInputDevice
        {
            get
            {
                var val = new QuickFix.Fields.OrderInputDevice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderInputDevice val) { this.OrderInputDevice = val; }

        public QuickFix.Fields.OrderInputDevice Get(QuickFix.Fields.OrderInputDevice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderInputDevice val) { return IsSetOrderInputDevice(); }

        public bool IsSetOrderInputDevice() { return IsSetField(Tags.OrderInputDevice); }

        public QuickFix.Fields.Currency Currency
        {
            get
            {
                var val = new QuickFix.Fields.Currency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Currency val) { this.Currency = val; }

        public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Currency val) { return IsSetCurrency(); }

        public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

        public QuickFix.Fields.ComplianceID ComplianceID
        {
            get
            {
                var val = new QuickFix.Fields.ComplianceID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplianceID val) { this.ComplianceID = val; }

        public QuickFix.Fields.ComplianceID Get(QuickFix.Fields.ComplianceID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplianceID val) { return IsSetComplianceID(); }

        public bool IsSetComplianceID() { return IsSetField(Tags.ComplianceID); }

        public QuickFix.Fields.SolicitedFlag SolicitedFlag
        {
            get
            {
                var val = new QuickFix.Fields.SolicitedFlag();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SolicitedFlag val) { this.SolicitedFlag = val; }

        public QuickFix.Fields.SolicitedFlag Get(QuickFix.Fields.SolicitedFlag val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SolicitedFlag val) { return IsSetSolicitedFlag(); }

        public bool IsSetSolicitedFlag() { return IsSetField(Tags.SolicitedFlag); }

        public QuickFix.Fields.OrderCapacity OrderCapacity
        {
            get
            {
                var val = new QuickFix.Fields.OrderCapacity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderCapacity val) { this.OrderCapacity = val; }

        public QuickFix.Fields.OrderCapacity Get(QuickFix.Fields.OrderCapacity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderCapacity val) { return IsSetOrderCapacity(); }

        public bool IsSetOrderCapacity() { return IsSetField(Tags.OrderCapacity); }

        public QuickFix.Fields.OrderRestrictions OrderRestrictions
        {
            get
            {
                var val = new QuickFix.Fields.OrderRestrictions();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderRestrictions val) { this.OrderRestrictions = val; }

        public QuickFix.Fields.OrderRestrictions Get(QuickFix.Fields.OrderRestrictions val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderRestrictions val) { return IsSetOrderRestrictions(); }

        public bool IsSetOrderRestrictions() { return IsSetField(Tags.OrderRestrictions); }

        public QuickFix.Fields.CustOrderCapacity CustOrderCapacity
        {
            get
            {
                var val = new QuickFix.Fields.CustOrderCapacity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CustOrderCapacity val) { this.CustOrderCapacity = val; }

        public QuickFix.Fields.CustOrderCapacity Get(QuickFix.Fields.CustOrderCapacity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CustOrderCapacity val) { return IsSetCustOrderCapacity(); }

        public bool IsSetCustOrderCapacity() { return IsSetField(Tags.CustOrderCapacity); }

        public QuickFix.Fields.OrdType OrdType
        {
            get
            {
                var val = new QuickFix.Fields.OrdType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrdType val) { this.OrdType = val; }

        public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrdType val) { return IsSetOrdType(); }

        public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }

        public QuickFix.Fields.ExecInst ExecInst
        {
            get
            {
                var val = new QuickFix.Fields.ExecInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExecInst val) { this.ExecInst = val; }

        public QuickFix.Fields.ExecInst Get(QuickFix.Fields.ExecInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExecInst val) { return IsSetExecInst(); }

        public bool IsSetExecInst() { return IsSetField(Tags.ExecInst); }

        public QuickFix.Fields.TransBkdTime TransBkdTime
        {
            get
            {
                var val = new QuickFix.Fields.TransBkdTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TransBkdTime val) { this.TransBkdTime = val; }

        public QuickFix.Fields.TransBkdTime Get(QuickFix.Fields.TransBkdTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TransBkdTime val) { return IsSetTransBkdTime(); }

        public bool IsSetTransBkdTime() { return IsSetField(Tags.TransBkdTime); }

        public QuickFix.Fields.TradingSessionID TradingSessionID
        {
            get
            {
                var val = new QuickFix.Fields.TradingSessionID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradingSessionID val) { this.TradingSessionID = val; }

        public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradingSessionID val) { return IsSetTradingSessionID(); }

        public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

        public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
        {
            get
            {
                var val = new QuickFix.Fields.TradingSessionSubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradingSessionSubID val) { this.TradingSessionSubID = val; }

        public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradingSessionSubID val) { return IsSetTradingSessionSubID(); }

        public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

        public QuickFix.Fields.TimeBracket TimeBracket
        {
            get
            {
                var val = new QuickFix.Fields.TimeBracket();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TimeBracket val) { this.TimeBracket = val; }

        public QuickFix.Fields.TimeBracket Get(QuickFix.Fields.TimeBracket val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TimeBracket val) { return IsSetTimeBracket(); }

        public bool IsSetTimeBracket() { return IsSetField(Tags.TimeBracket); }

        public QuickFix.Fields.Commission Commission
        {
            get
            {
                var val = new QuickFix.Fields.Commission();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Commission val) { this.Commission = val; }

        public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Commission val) { return IsSetCommission(); }

        public bool IsSetCommission() { return IsSetField(Tags.Commission); }

        public QuickFix.Fields.CommType CommType
        {
            get
            {
                var val = new QuickFix.Fields.CommType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CommType val) { this.CommType = val; }

        public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CommType val) { return IsSetCommType(); }

        public bool IsSetCommType() { return IsSetField(Tags.CommType); }

        public QuickFix.Fields.CommCurrency CommCurrency
        {
            get
            {
                var val = new QuickFix.Fields.CommCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CommCurrency val) { this.CommCurrency = val; }

        public QuickFix.Fields.CommCurrency Get(QuickFix.Fields.CommCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CommCurrency val) { return IsSetCommCurrency(); }

        public bool IsSetCommCurrency() { return IsSetField(Tags.CommCurrency); }

        public QuickFix.Fields.FundRenewWaiv FundRenewWaiv
        {
            get
            {
                var val = new QuickFix.Fields.FundRenewWaiv();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FundRenewWaiv val) { this.FundRenewWaiv = val; }

        public QuickFix.Fields.FundRenewWaiv Get(QuickFix.Fields.FundRenewWaiv val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FundRenewWaiv val) { return IsSetFundRenewWaiv(); }

        public bool IsSetFundRenewWaiv() { return IsSetField(Tags.FundRenewWaiv); }

        public QuickFix.Fields.NumDaysInterest NumDaysInterest
        {
            get
            {
                var val = new QuickFix.Fields.NumDaysInterest();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NumDaysInterest val) { this.NumDaysInterest = val; }

        public QuickFix.Fields.NumDaysInterest Get(QuickFix.Fields.NumDaysInterest val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NumDaysInterest val) { return IsSetNumDaysInterest(); }

        public bool IsSetNumDaysInterest() { return IsSetField(Tags.NumDaysInterest); }

        public QuickFix.Fields.ExDate ExDate
        {
            get
            {
                var val = new QuickFix.Fields.ExDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExDate val) { this.ExDate = val; }

        public QuickFix.Fields.ExDate Get(QuickFix.Fields.ExDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExDate val) { return IsSetExDate(); }

        public bool IsSetExDate() { return IsSetField(Tags.ExDate); }

        public QuickFix.Fields.AccruedInterestRate AccruedInterestRate
        {
            get
            {
                var val = new QuickFix.Fields.AccruedInterestRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AccruedInterestRate val) { this.AccruedInterestRate = val; }

        public QuickFix.Fields.AccruedInterestRate Get(QuickFix.Fields.AccruedInterestRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AccruedInterestRate val) { return IsSetAccruedInterestRate(); }

        public bool IsSetAccruedInterestRate() { return IsSetField(Tags.AccruedInterestRate); }

        public QuickFix.Fields.AccruedInterestAmt AccruedInterestAmt
        {
            get
            {
                var val = new QuickFix.Fields.AccruedInterestAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AccruedInterestAmt val) { this.AccruedInterestAmt = val; }

        public QuickFix.Fields.AccruedInterestAmt Get(QuickFix.Fields.AccruedInterestAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AccruedInterestAmt val) { return IsSetAccruedInterestAmt(); }

        public bool IsSetAccruedInterestAmt() { return IsSetField(Tags.AccruedInterestAmt); }

        public QuickFix.Fields.InterestAtMaturity InterestAtMaturity
        {
            get
            {
                var val = new QuickFix.Fields.InterestAtMaturity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InterestAtMaturity val) { this.InterestAtMaturity = val; }

        public QuickFix.Fields.InterestAtMaturity Get(QuickFix.Fields.InterestAtMaturity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InterestAtMaturity val) { return IsSetInterestAtMaturity(); }

        public bool IsSetInterestAtMaturity() { return IsSetField(Tags.InterestAtMaturity); }

        public QuickFix.Fields.EndAccruedInterestAmt EndAccruedInterestAmt
        {
            get
            {
                var val = new QuickFix.Fields.EndAccruedInterestAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EndAccruedInterestAmt val) { this.EndAccruedInterestAmt = val; }

        public QuickFix.Fields.EndAccruedInterestAmt Get(QuickFix.Fields.EndAccruedInterestAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EndAccruedInterestAmt val) { return IsSetEndAccruedInterestAmt(); }

        public bool IsSetEndAccruedInterestAmt() { return IsSetField(Tags.EndAccruedInterestAmt); }

        public QuickFix.Fields.StartCash StartCash
        {
            get
            {
                var val = new QuickFix.Fields.StartCash();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StartCash val) { this.StartCash = val; }

        public QuickFix.Fields.StartCash Get(QuickFix.Fields.StartCash val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StartCash val) { return IsSetStartCash(); }

        public bool IsSetStartCash() { return IsSetField(Tags.StartCash); }

        public QuickFix.Fields.EndCash EndCash
        {
            get
            {
                var val = new QuickFix.Fields.EndCash();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EndCash val) { this.EndCash = val; }

        public QuickFix.Fields.EndCash Get(QuickFix.Fields.EndCash val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EndCash val) { return IsSetEndCash(); }

        public bool IsSetEndCash() { return IsSetField(Tags.EndCash); }

        public QuickFix.Fields.Concession Concession
        {
            get
            {
                var val = new QuickFix.Fields.Concession();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Concession val) { this.Concession = val; }

        public QuickFix.Fields.Concession Get(QuickFix.Fields.Concession val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Concession val) { return IsSetConcession(); }

        public bool IsSetConcession() { return IsSetField(Tags.Concession); }

        public QuickFix.Fields.TotalTakedown TotalTakedown
        {
            get
            {
                var val = new QuickFix.Fields.TotalTakedown();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotalTakedown val) { this.TotalTakedown = val; }

        public QuickFix.Fields.TotalTakedown Get(QuickFix.Fields.TotalTakedown val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotalTakedown val) { return IsSetTotalTakedown(); }

        public bool IsSetTotalTakedown() { return IsSetField(Tags.TotalTakedown); }

        public QuickFix.Fields.NetMoney NetMoney
        {
            get
            {
                var val = new QuickFix.Fields.NetMoney();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NetMoney val) { this.NetMoney = val; }

        public QuickFix.Fields.NetMoney Get(QuickFix.Fields.NetMoney val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NetMoney val) { return IsSetNetMoney(); }

        public bool IsSetNetMoney() { return IsSetField(Tags.NetMoney); }

        public QuickFix.Fields.SettlCurrAmt SettlCurrAmt
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrAmt val) { this.SettlCurrAmt = val; }

        public QuickFix.Fields.SettlCurrAmt Get(QuickFix.Fields.SettlCurrAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrAmt val) { return IsSetSettlCurrAmt(); }

        public bool IsSetSettlCurrAmt() { return IsSetField(Tags.SettlCurrAmt); }

        public QuickFix.Fields.SettlCurrency SettlCurrency
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrency val) { this.SettlCurrency = val; }

        public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrency val) { return IsSetSettlCurrency(); }

        public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }

        public QuickFix.Fields.SettlCurrFxRate SettlCurrFxRate
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrFxRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrFxRate val) { this.SettlCurrFxRate = val; }

        public QuickFix.Fields.SettlCurrFxRate Get(QuickFix.Fields.SettlCurrFxRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrFxRate val) { return IsSetSettlCurrFxRate(); }

        public bool IsSetSettlCurrFxRate() { return IsSetField(Tags.SettlCurrFxRate); }

        public QuickFix.Fields.SettlCurrFxRateCalc SettlCurrFxRateCalc
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrFxRateCalc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrFxRateCalc val) { this.SettlCurrFxRateCalc = val; }

        public QuickFix.Fields.SettlCurrFxRateCalc Get(QuickFix.Fields.SettlCurrFxRateCalc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrFxRateCalc val) { return IsSetSettlCurrFxRateCalc(); }

        public bool IsSetSettlCurrFxRateCalc() { return IsSetField(Tags.SettlCurrFxRateCalc); }

        public QuickFix.Fields.PositionEffect PositionEffect
        {
            get
            {
                var val = new QuickFix.Fields.PositionEffect();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PositionEffect val) { this.PositionEffect = val; }

        public QuickFix.Fields.PositionEffect Get(QuickFix.Fields.PositionEffect val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PositionEffect val) { return IsSetPositionEffect(); }

        public bool IsSetPositionEffect() { return IsSetField(Tags.PositionEffect); }

        public QuickFix.Fields.SideMultiLegReportingType SideMultiLegReportingType
        {
            get
            {
                var val = new QuickFix.Fields.SideMultiLegReportingType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideMultiLegReportingType val) { this.SideMultiLegReportingType = val; }

        public QuickFix.Fields.SideMultiLegReportingType Get(QuickFix.Fields.SideMultiLegReportingType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideMultiLegReportingType val) { return IsSetSideMultiLegReportingType(); }

        public bool IsSetSideMultiLegReportingType() { return IsSetField(Tags.SideMultiLegReportingType); }

        public QuickFix.Fields.NoContAmts NoContAmts
        {
            get
            {
                var val = new QuickFix.Fields.NoContAmts();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoContAmts val) { this.NoContAmts = val; }

        public QuickFix.Fields.NoContAmts Get(QuickFix.Fields.NoContAmts val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoContAmts val) { return IsSetNoContAmts(); }

        public bool IsSetNoContAmts() { return IsSetField(Tags.NoContAmts); }

        public QuickFix.Fields.NoStipulations NoStipulations
        {
            get
            {
                var val = new QuickFix.Fields.NoStipulations();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoStipulations val) { this.NoStipulations = val; }

        public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoStipulations val) { return IsSetNoStipulations(); }

        public bool IsSetNoStipulations() { return IsSetField(Tags.NoStipulations); }

        public QuickFix.Fields.NoMiscFees NoMiscFees
        {
            get
            {
                var val = new QuickFix.Fields.NoMiscFees();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoMiscFees val) { this.NoMiscFees = val; }

        public QuickFix.Fields.NoMiscFees Get(QuickFix.Fields.NoMiscFees val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoMiscFees val) { return IsSetNoMiscFees(); }

        public bool IsSetNoMiscFees() { return IsSetField(Tags.NoMiscFees); }

        public QuickFix.Fields.ExchangeRule ExchangeRule
        {
            get
            {
                var val = new QuickFix.Fields.ExchangeRule();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExchangeRule val) { this.ExchangeRule = val; }

        public QuickFix.Fields.ExchangeRule Get(QuickFix.Fields.ExchangeRule val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExchangeRule val) { return IsSetExchangeRule(); }

        public bool IsSetExchangeRule() { return IsSetField(Tags.ExchangeRule); }

        public QuickFix.Fields.TradeAllocIndicator TradeAllocIndicator
        {
            get
            {
                var val = new QuickFix.Fields.TradeAllocIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeAllocIndicator val) { this.TradeAllocIndicator = val; }

        public QuickFix.Fields.TradeAllocIndicator Get(QuickFix.Fields.TradeAllocIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeAllocIndicator val) { return IsSetTradeAllocIndicator(); }

        public bool IsSetTradeAllocIndicator() { return IsSetField(Tags.TradeAllocIndicator); }

        public QuickFix.Fields.PreallocMethod PreallocMethod
        {
            get
            {
                var val = new QuickFix.Fields.PreallocMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PreallocMethod val) { this.PreallocMethod = val; }

        public QuickFix.Fields.PreallocMethod Get(QuickFix.Fields.PreallocMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PreallocMethod val) { return IsSetPreallocMethod(); }

        public bool IsSetPreallocMethod() { return IsSetField(Tags.PreallocMethod); }

        public QuickFix.Fields.AllocID AllocID
        {
            get
            {
                var val = new QuickFix.Fields.AllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocID val) { this.AllocID = val; }

        public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocID val) { return IsSetAllocID(); }

        public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

        public QuickFix.Fields.NoAllocs NoAllocs
        {
            get
            {
                var val = new QuickFix.Fields.NoAllocs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoAllocs val) { this.NoAllocs = val; }

        public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoAllocs val) { return IsSetNoAllocs(); }

        public bool IsSetNoAllocs() { return IsSetField(Tags.NoAllocs); }

        public QuickFix.Fields.LotType LotType
        {
            get
            {
                var val = new QuickFix.Fields.LotType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LotType val) { this.LotType = val; }

        public QuickFix.Fields.LotType Get(QuickFix.Fields.LotType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LotType val) { return IsSetLotType(); }

        public bool IsSetLotType() { return IsSetField(Tags.LotType); }

        public QuickFix.Fields.SideGrossTradeAmt SideGrossTradeAmt
        {
            get
            {
                var val = new QuickFix.Fields.SideGrossTradeAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideGrossTradeAmt val) { this.SideGrossTradeAmt = val; }

        public QuickFix.Fields.SideGrossTradeAmt Get(QuickFix.Fields.SideGrossTradeAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideGrossTradeAmt val) { return IsSetSideGrossTradeAmt(); }

        public bool IsSetSideGrossTradeAmt() { return IsSetField(Tags.SideGrossTradeAmt); }

        public QuickFix.Fields.AggressorIndicator AggressorIndicator
        {
            get
            {
                var val = new QuickFix.Fields.AggressorIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AggressorIndicator val) { this.AggressorIndicator = val; }

        public QuickFix.Fields.AggressorIndicator Get(QuickFix.Fields.AggressorIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AggressorIndicator val) { return IsSetAggressorIndicator(); }

        public bool IsSetAggressorIndicator() { return IsSetField(Tags.AggressorIndicator); }

        public QuickFix.Fields.SideQty SideQty
        {
            get
            {
                var val = new QuickFix.Fields.SideQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideQty val) { this.SideQty = val; }

        public QuickFix.Fields.SideQty Get(QuickFix.Fields.SideQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideQty val) { return IsSetSideQty(); }

        public bool IsSetSideQty() { return IsSetField(Tags.SideQty); }

        public QuickFix.Fields.SideTradeReportID SideTradeReportID
        {
            get
            {
                var val = new QuickFix.Fields.SideTradeReportID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideTradeReportID val) { this.SideTradeReportID = val; }

        public QuickFix.Fields.SideTradeReportID Get(QuickFix.Fields.SideTradeReportID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideTradeReportID val) { return IsSetSideTradeReportID(); }

        public bool IsSetSideTradeReportID() { return IsSetField(Tags.SideTradeReportID); }

        public QuickFix.Fields.SideFillStationCd SideFillStationCd
        {
            get
            {
                var val = new QuickFix.Fields.SideFillStationCd();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideFillStationCd val) { this.SideFillStationCd = val; }

        public QuickFix.Fields.SideFillStationCd Get(QuickFix.Fields.SideFillStationCd val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideFillStationCd val) { return IsSetSideFillStationCd(); }

        public bool IsSetSideFillStationCd() { return IsSetField(Tags.SideFillStationCd); }

        public QuickFix.Fields.SideReasonCd SideReasonCd
        {
            get
            {
                var val = new QuickFix.Fields.SideReasonCd();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideReasonCd val) { this.SideReasonCd = val; }

        public QuickFix.Fields.SideReasonCd Get(QuickFix.Fields.SideReasonCd val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideReasonCd val) { return IsSetSideReasonCd(); }

        public bool IsSetSideReasonCd() { return IsSetField(Tags.SideReasonCd); }

        public QuickFix.Fields.RptSeq RptSeq
        {
            get
            {
                var val = new QuickFix.Fields.RptSeq();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RptSeq val) { this.RptSeq = val; }

        public QuickFix.Fields.RptSeq Get(QuickFix.Fields.RptSeq val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RptSeq val) { return IsSetRptSeq(); }

        public bool IsSetRptSeq() { return IsSetField(Tags.RptSeq); }

        public QuickFix.Fields.SideTrdSubTyp SideTrdSubTyp
        {
            get
            {
                var val = new QuickFix.Fields.SideTrdSubTyp();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideTrdSubTyp val) { this.SideTrdSubTyp = val; }

        public QuickFix.Fields.SideTrdSubTyp Get(QuickFix.Fields.SideTrdSubTyp val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideTrdSubTyp val) { return IsSetSideTrdSubTyp(); }

        public bool IsSetSideTrdSubTyp() { return IsSetField(Tags.SideTrdSubTyp); }

        public QuickFix.Fields.NoSideTrdRegTS NoSideTrdRegTS
        {
            get
            {
                var val = new QuickFix.Fields.NoSideTrdRegTS();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSideTrdRegTS val) { this.NoSideTrdRegTS = val; }

        public QuickFix.Fields.NoSideTrdRegTS Get(QuickFix.Fields.NoSideTrdRegTS val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSideTrdRegTS val) { return IsSetNoSideTrdRegTS(); }

        public bool IsSetNoSideTrdRegTS() { return IsSetField(Tags.NoSideTrdRegTS); }


        public class NoPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

            public NoPartyIDsGroup() : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyID PartyID
        {
            get
            {
                var val = new QuickFix.Fields.PartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyID val) { this.PartyID = val; }

        public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyID val) { return IsSetPartyID(); }

        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public QuickFix.Fields.PartyIDSource PartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.PartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyIDSource val) { this.PartyIDSource = val; }

        public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyIDSource val) { return IsSetPartyIDSource(); }

        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public QuickFix.Fields.PartyRole PartyRole
        {
            get
            {
                var val = new QuickFix.Fields.PartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyRole val) { this.PartyRole = val; }

        public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyRole val) { return IsSetPartyRole(); }

        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartySubIDs val) { this.NoPartySubIDs = val; }

        public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartySubIDs val) { return IsSetNoPartySubIDs(); }

        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }


        public class NoPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup() : base(Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartySubID PartySubID
        {
            get
            {
                var val = new QuickFix.Fields.PartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartySubID val) { this.PartySubID = val; }

        public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartySubID val) { return IsSetPartySubID(); }

        public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }

        public QuickFix.Fields.PartySubIDType PartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.PartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartySubIDType val) { this.PartySubIDType = val; }

        public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartySubIDType val) { return IsSetPartySubIDType(); }

        public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }


        }
        }
        public class NoClearingInstructionsGroup : Group
        {
            public static int[] fieldOrder = {Tags.ClearingInstruction, 0};

            public NoClearingInstructionsGroup() : base(Tags.NoClearingInstructions, Tags.ClearingInstruction, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoClearingInstructionsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ClearingInstruction ClearingInstruction
        {
            get
            {
                var val = new QuickFix.Fields.ClearingInstruction();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClearingInstruction val) { this.ClearingInstruction = val; }

        public QuickFix.Fields.ClearingInstruction Get(QuickFix.Fields.ClearingInstruction val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClearingInstruction val) { return IsSetClearingInstruction(); }

        public bool IsSetClearingInstruction() { return IsSetField(Tags.ClearingInstruction); }


        }
        public class NoContAmtsGroup : Group
        {
            public static int[] fieldOrder = {Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0};

            public NoContAmtsGroup() : base(Tags.NoContAmts, Tags.ContAmtType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoContAmtsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ContAmtType ContAmtType
        {
            get
            {
                var val = new QuickFix.Fields.ContAmtType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContAmtType val) { this.ContAmtType = val; }

        public QuickFix.Fields.ContAmtType Get(QuickFix.Fields.ContAmtType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContAmtType val) { return IsSetContAmtType(); }

        public bool IsSetContAmtType() { return IsSetField(Tags.ContAmtType); }

        public QuickFix.Fields.ContAmtValue ContAmtValue
        {
            get
            {
                var val = new QuickFix.Fields.ContAmtValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContAmtValue val) { this.ContAmtValue = val; }

        public QuickFix.Fields.ContAmtValue Get(QuickFix.Fields.ContAmtValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContAmtValue val) { return IsSetContAmtValue(); }

        public bool IsSetContAmtValue() { return IsSetField(Tags.ContAmtValue); }

        public QuickFix.Fields.ContAmtCurr ContAmtCurr
        {
            get
            {
                var val = new QuickFix.Fields.ContAmtCurr();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContAmtCurr val) { this.ContAmtCurr = val; }

        public QuickFix.Fields.ContAmtCurr Get(QuickFix.Fields.ContAmtCurr val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContAmtCurr val) { return IsSetContAmtCurr(); }

        public bool IsSetContAmtCurr() { return IsSetField(Tags.ContAmtCurr); }


        }
        public class NoStipulationsGroup : Group
        {
            public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};

            public NoStipulationsGroup() : base(Tags.NoStipulations, Tags.StipulationType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoStipulationsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.StipulationType StipulationType
        {
            get
            {
                var val = new QuickFix.Fields.StipulationType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StipulationType val) { this.StipulationType = val; }

        public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StipulationType val) { return IsSetStipulationType(); }

        public bool IsSetStipulationType() { return IsSetField(Tags.StipulationType); }

        public QuickFix.Fields.StipulationValue StipulationValue
        {
            get
            {
                var val = new QuickFix.Fields.StipulationValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StipulationValue val) { this.StipulationValue = val; }

        public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StipulationValue val) { return IsSetStipulationValue(); }

        public bool IsSetStipulationValue() { return IsSetField(Tags.StipulationValue); }


        }
        public class NoMiscFeesGroup : Group
        {
            public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0};

            public NoMiscFeesGroup() : base(Tags.NoMiscFees, Tags.MiscFeeAmt, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoMiscFeesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.MiscFeeAmt MiscFeeAmt
        {
            get
            {
                var val = new QuickFix.Fields.MiscFeeAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MiscFeeAmt val) { this.MiscFeeAmt = val; }

        public QuickFix.Fields.MiscFeeAmt Get(QuickFix.Fields.MiscFeeAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MiscFeeAmt val) { return IsSetMiscFeeAmt(); }

        public bool IsSetMiscFeeAmt() { return IsSetField(Tags.MiscFeeAmt); }

        public QuickFix.Fields.MiscFeeCurr MiscFeeCurr
        {
            get
            {
                var val = new QuickFix.Fields.MiscFeeCurr();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MiscFeeCurr val) { this.MiscFeeCurr = val; }

        public QuickFix.Fields.MiscFeeCurr Get(QuickFix.Fields.MiscFeeCurr val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MiscFeeCurr val) { return IsSetMiscFeeCurr(); }

        public bool IsSetMiscFeeCurr() { return IsSetField(Tags.MiscFeeCurr); }

        public QuickFix.Fields.MiscFeeType MiscFeeType
        {
            get
            {
                var val = new QuickFix.Fields.MiscFeeType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MiscFeeType val) { this.MiscFeeType = val; }

        public QuickFix.Fields.MiscFeeType Get(QuickFix.Fields.MiscFeeType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MiscFeeType val) { return IsSetMiscFeeType(); }

        public bool IsSetMiscFeeType() { return IsSetField(Tags.MiscFeeType); }

        public QuickFix.Fields.MiscFeeBasis MiscFeeBasis
        {
            get
            {
                var val = new QuickFix.Fields.MiscFeeBasis();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MiscFeeBasis val) { this.MiscFeeBasis = val; }

        public QuickFix.Fields.MiscFeeBasis Get(QuickFix.Fields.MiscFeeBasis val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MiscFeeBasis val) { return IsSetMiscFeeBasis(); }

        public bool IsSetMiscFeeBasis() { return IsSetField(Tags.MiscFeeBasis); }


        }
        public class NoAllocsGroup : Group
        {
            public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNested2PartyIDs, Tags.AllocQty, Tags.AllocCustomerCapacity, Tags.AllocMethod, Tags.SecondaryIndividualAllocID, Tags.AllocClearingFeeIndicator, 0};

            public NoAllocsGroup() : base(Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
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
                var val = new QuickFix.Fields.AllocAccount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocAccount val) { this.AllocAccount = val; }

        public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocAccount val) { return IsSetAllocAccount(); }

        public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }

        public QuickFix.Fields.AllocAcctIDSource AllocAcctIDSource
        {
            get
            {
                var val = new QuickFix.Fields.AllocAcctIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocAcctIDSource val) { this.AllocAcctIDSource = val; }

        public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) { return IsSetAllocAcctIDSource(); }

        public bool IsSetAllocAcctIDSource() { return IsSetField(Tags.AllocAcctIDSource); }

        public QuickFix.Fields.AllocSettlCurrency AllocSettlCurrency
        {
            get
            {
                var val = new QuickFix.Fields.AllocSettlCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocSettlCurrency val) { this.AllocSettlCurrency = val; }

        public QuickFix.Fields.AllocSettlCurrency Get(QuickFix.Fields.AllocSettlCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocSettlCurrency val) { return IsSetAllocSettlCurrency(); }

        public bool IsSetAllocSettlCurrency() { return IsSetField(Tags.AllocSettlCurrency); }

        public QuickFix.Fields.IndividualAllocID IndividualAllocID
        {
            get
            {
                var val = new QuickFix.Fields.IndividualAllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IndividualAllocID val) { this.IndividualAllocID = val; }

        public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IndividualAllocID val) { return IsSetIndividualAllocID(); }

        public bool IsSetIndividualAllocID() { return IsSetField(Tags.IndividualAllocID); }

        public QuickFix.Fields.NoNested2PartyIDs NoNested2PartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoNested2PartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoNested2PartyIDs val) { this.NoNested2PartyIDs = val; }

        public QuickFix.Fields.NoNested2PartyIDs Get(QuickFix.Fields.NoNested2PartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoNested2PartyIDs val) { return IsSetNoNested2PartyIDs(); }

        public bool IsSetNoNested2PartyIDs() { return IsSetField(Tags.NoNested2PartyIDs); }

        public QuickFix.Fields.AllocQty AllocQty
        {
            get
            {
                var val = new QuickFix.Fields.AllocQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocQty val) { this.AllocQty = val; }

        public QuickFix.Fields.AllocQty Get(QuickFix.Fields.AllocQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocQty val) { return IsSetAllocQty(); }

        public bool IsSetAllocQty() { return IsSetField(Tags.AllocQty); }

        public QuickFix.Fields.AllocCustomerCapacity AllocCustomerCapacity
        {
            get
            {
                var val = new QuickFix.Fields.AllocCustomerCapacity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocCustomerCapacity val) { this.AllocCustomerCapacity = val; }

        public QuickFix.Fields.AllocCustomerCapacity Get(QuickFix.Fields.AllocCustomerCapacity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocCustomerCapacity val) { return IsSetAllocCustomerCapacity(); }

        public bool IsSetAllocCustomerCapacity() { return IsSetField(Tags.AllocCustomerCapacity); }

        public QuickFix.Fields.AllocMethod AllocMethod
        {
            get
            {
                var val = new QuickFix.Fields.AllocMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocMethod val) { this.AllocMethod = val; }

        public QuickFix.Fields.AllocMethod Get(QuickFix.Fields.AllocMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocMethod val) { return IsSetAllocMethod(); }

        public bool IsSetAllocMethod() { return IsSetField(Tags.AllocMethod); }

        public QuickFix.Fields.SecondaryIndividualAllocID SecondaryIndividualAllocID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryIndividualAllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryIndividualAllocID val) { this.SecondaryIndividualAllocID = val; }

        public QuickFix.Fields.SecondaryIndividualAllocID Get(QuickFix.Fields.SecondaryIndividualAllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryIndividualAllocID val) { return IsSetSecondaryIndividualAllocID(); }

        public bool IsSetSecondaryIndividualAllocID() { return IsSetField(Tags.SecondaryIndividualAllocID); }

        public QuickFix.Fields.AllocClearingFeeIndicator AllocClearingFeeIndicator
        {
            get
            {
                var val = new QuickFix.Fields.AllocClearingFeeIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocClearingFeeIndicator val) { this.AllocClearingFeeIndicator = val; }

        public QuickFix.Fields.AllocClearingFeeIndicator Get(QuickFix.Fields.AllocClearingFeeIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocClearingFeeIndicator val) { return IsSetAllocClearingFeeIndicator(); }

        public bool IsSetAllocClearingFeeIndicator() { return IsSetField(Tags.AllocClearingFeeIndicator); }


        public class NoNested2PartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};

            public NoNested2PartyIDsGroup() : base(Tags.NoNested2PartyIDs, Tags.Nested2PartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNested2PartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.Nested2PartyID Nested2PartyID
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartyID val) { this.Nested2PartyID = val; }

        public QuickFix.Fields.Nested2PartyID Get(QuickFix.Fields.Nested2PartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartyID val) { return IsSetNested2PartyID(); }

        public bool IsSetNested2PartyID() { return IsSetField(Tags.Nested2PartyID); }

        public QuickFix.Fields.Nested2PartyIDSource Nested2PartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartyIDSource val) { this.Nested2PartyIDSource = val; }

        public QuickFix.Fields.Nested2PartyIDSource Get(QuickFix.Fields.Nested2PartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartyIDSource val) { return IsSetNested2PartyIDSource(); }

        public bool IsSetNested2PartyIDSource() { return IsSetField(Tags.Nested2PartyIDSource); }

        public QuickFix.Fields.Nested2PartyRole Nested2PartyRole
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartyRole val) { this.Nested2PartyRole = val; }

        public QuickFix.Fields.Nested2PartyRole Get(QuickFix.Fields.Nested2PartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartyRole val) { return IsSetNested2PartyRole(); }

        public bool IsSetNested2PartyRole() { return IsSetField(Tags.Nested2PartyRole); }

        public QuickFix.Fields.NoNested2PartySubIDs NoNested2PartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoNested2PartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoNested2PartySubIDs val) { this.NoNested2PartySubIDs = val; }

        public QuickFix.Fields.NoNested2PartySubIDs Get(QuickFix.Fields.NoNested2PartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoNested2PartySubIDs val) { return IsSetNoNested2PartySubIDs(); }

        public bool IsSetNoNested2PartySubIDs() { return IsSetField(Tags.NoNested2PartySubIDs); }


        public class NoNested2PartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};

            public NoNested2PartySubIDsGroup() : base(Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNested2PartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.Nested2PartySubID Nested2PartySubID
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartySubID val) { this.Nested2PartySubID = val; }

        public QuickFix.Fields.Nested2PartySubID Get(QuickFix.Fields.Nested2PartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartySubID val) { return IsSetNested2PartySubID(); }

        public bool IsSetNested2PartySubID() { return IsSetField(Tags.Nested2PartySubID); }

        public QuickFix.Fields.Nested2PartySubIDType Nested2PartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartySubIDType val) { this.Nested2PartySubIDType = val; }

        public QuickFix.Fields.Nested2PartySubIDType Get(QuickFix.Fields.Nested2PartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartySubIDType val) { return IsSetNested2PartySubIDType(); }

        public bool IsSetNested2PartySubIDType() { return IsSetField(Tags.Nested2PartySubIDType); }


        }
        }
        }
        public class NoSideTrdRegTSGroup : Group
        {
            public static int[] fieldOrder = {Tags.SideTrdRegTimestamp, Tags.SideTrdRegTimestampType, Tags.SideTrdRegTimestampSrc, 0};

            public NoSideTrdRegTSGroup() : base(Tags.NoSideTrdRegTS, Tags.SideTrdRegTimestamp, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSideTrdRegTSGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SideTrdRegTimestamp SideTrdRegTimestamp
        {
            get
            {
                var val = new QuickFix.Fields.SideTrdRegTimestamp();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideTrdRegTimestamp val) { this.SideTrdRegTimestamp = val; }

        public QuickFix.Fields.SideTrdRegTimestamp Get(QuickFix.Fields.SideTrdRegTimestamp val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideTrdRegTimestamp val) { return IsSetSideTrdRegTimestamp(); }

        public bool IsSetSideTrdRegTimestamp() { return IsSetField(Tags.SideTrdRegTimestamp); }

        public QuickFix.Fields.SideTrdRegTimestampType SideTrdRegTimestampType
        {
            get
            {
                var val = new QuickFix.Fields.SideTrdRegTimestampType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideTrdRegTimestampType val) { this.SideTrdRegTimestampType = val; }

        public QuickFix.Fields.SideTrdRegTimestampType Get(QuickFix.Fields.SideTrdRegTimestampType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideTrdRegTimestampType val) { return IsSetSideTrdRegTimestampType(); }

        public bool IsSetSideTrdRegTimestampType() { return IsSetField(Tags.SideTrdRegTimestampType); }

        public QuickFix.Fields.SideTrdRegTimestampSrc SideTrdRegTimestampSrc
        {
            get
            {
                var val = new QuickFix.Fields.SideTrdRegTimestampSrc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideTrdRegTimestampSrc val) { this.SideTrdRegTimestampSrc = val; }

        public QuickFix.Fields.SideTrdRegTimestampSrc Get(QuickFix.Fields.SideTrdRegTimestampSrc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideTrdRegTimestampSrc val) { return IsSetSideTrdRegTimestampSrc(); }

        public bool IsSetSideTrdRegTimestampSrc() { return IsSetField(Tags.SideTrdRegTimestampSrc); }


        }
        }


        public class NoRootPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RootPartyID, Tags.RootPartyIDSource, Tags.RootPartyRole, Tags.NoRootPartySubIDs, 0};

            public NoRootPartyIDsGroup() : base(Tags.NoRootPartyIDs, Tags.RootPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRootPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RootPartyID RootPartyID
        {
            get
            {
                var val = new QuickFix.Fields.RootPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RootPartyID val) { this.RootPartyID = val; }

        public QuickFix.Fields.RootPartyID Get(QuickFix.Fields.RootPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RootPartyID val) { return IsSetRootPartyID(); }

        public bool IsSetRootPartyID() { return IsSetField(Tags.RootPartyID); }

        public QuickFix.Fields.RootPartyIDSource RootPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RootPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RootPartyIDSource val) { this.RootPartyIDSource = val; }

        public QuickFix.Fields.RootPartyIDSource Get(QuickFix.Fields.RootPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RootPartyIDSource val) { return IsSetRootPartyIDSource(); }

        public bool IsSetRootPartyIDSource() { return IsSetField(Tags.RootPartyIDSource); }

        public QuickFix.Fields.RootPartyRole RootPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.RootPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RootPartyRole val) { this.RootPartyRole = val; }

        public QuickFix.Fields.RootPartyRole Get(QuickFix.Fields.RootPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RootPartyRole val) { return IsSetRootPartyRole(); }

        public bool IsSetRootPartyRole() { return IsSetField(Tags.RootPartyRole); }

        public QuickFix.Fields.NoRootPartySubIDs NoRootPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRootPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRootPartySubIDs val) { this.NoRootPartySubIDs = val; }

        public QuickFix.Fields.NoRootPartySubIDs Get(QuickFix.Fields.NoRootPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRootPartySubIDs val) { return IsSetNoRootPartySubIDs(); }

        public bool IsSetNoRootPartySubIDs() { return IsSetField(Tags.NoRootPartySubIDs); }


        public class NoRootPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RootPartySubID, Tags.RootPartySubIDType, 0};

            public NoRootPartySubIDsGroup() : base(Tags.NoRootPartySubIDs, Tags.RootPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRootPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RootPartySubID RootPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.RootPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RootPartySubID val) { this.RootPartySubID = val; }

        public QuickFix.Fields.RootPartySubID Get(QuickFix.Fields.RootPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RootPartySubID val) { return IsSetRootPartySubID(); }

        public bool IsSetRootPartySubID() { return IsSetField(Tags.RootPartySubID); }

        public QuickFix.Fields.RootPartySubIDType RootPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.RootPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RootPartySubIDType val) { this.RootPartySubIDType = val; }

        public QuickFix.Fields.RootPartySubIDType Get(QuickFix.Fields.RootPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RootPartySubIDType val) { return IsSetRootPartySubIDType(); }

        public bool IsSetRootPartySubIDType() { return IsSetField(Tags.RootPartySubIDType); }


        }
        }


        public class NoUnderlyingsGroup : Group
        {
            public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, 0};

            public NoUnderlyingsGroup() : base(Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSymbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSymbol val) { this.UnderlyingSymbol = val; }

        public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) { return IsSetUnderlyingSymbol(); }

        public bool IsSetUnderlyingSymbol() { return IsSetField(Tags.UnderlyingSymbol); }

        public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) { this.UnderlyingSymbolSfx = val; }

        public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) { return IsSetUnderlyingSymbolSfx(); }

        public bool IsSetUnderlyingSymbolSfx() { return IsSetField(Tags.UnderlyingSymbolSfx); }

        public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityID val) { this.UnderlyingSecurityID = val; }

        public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) { return IsSetUnderlyingSecurityID(); }

        public bool IsSetUnderlyingSecurityID() { return IsSetField(Tags.UnderlyingSecurityID); }

        public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) { this.UnderlyingSecurityIDSource = val; }

        public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) { return IsSetUnderlyingSecurityIDSource(); }

        public bool IsSetUnderlyingSecurityIDSource() { return IsSetField(Tags.UnderlyingSecurityIDSource); }

        public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) { this.NoUnderlyingSecurityAltID = val; }

        public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) { return IsSetNoUnderlyingSecurityAltID(); }

        public bool IsSetNoUnderlyingSecurityAltID() { return IsSetField(Tags.NoUnderlyingSecurityAltID); }

        public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingProduct();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingProduct val) { this.UnderlyingProduct = val; }

        public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingProduct val) { return IsSetUnderlyingProduct(); }

        public bool IsSetUnderlyingProduct() { return IsSetField(Tags.UnderlyingProduct); }

        public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCFICode val) { this.UnderlyingCFICode = val; }

        public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) { return IsSetUnderlyingCFICode(); }

        public bool IsSetUnderlyingCFICode() { return IsSetField(Tags.UnderlyingCFICode); }

        public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityType val) { this.UnderlyingSecurityType = val; }

        public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) { return IsSetUnderlyingSecurityType(); }

        public bool IsSetUnderlyingSecurityType() { return IsSetField(Tags.UnderlyingSecurityType); }

        public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) { this.UnderlyingSecuritySubType = val; }

        public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) { return IsSetUnderlyingSecuritySubType(); }

        public bool IsSetUnderlyingSecuritySubType() { return IsSetField(Tags.UnderlyingSecuritySubType); }

        public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) { this.UnderlyingMaturityMonthYear = val; }

        public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) { return IsSetUnderlyingMaturityMonthYear(); }

        public bool IsSetUnderlyingMaturityMonthYear() { return IsSetField(Tags.UnderlyingMaturityMonthYear); }

        public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingMaturityDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingMaturityDate val) { this.UnderlyingMaturityDate = val; }

        public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) { return IsSetUnderlyingMaturityDate(); }

        public bool IsSetUnderlyingMaturityDate() { return IsSetField(Tags.UnderlyingMaturityDate); }

        public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) { this.UnderlyingCouponPaymentDate = val; }

        public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) { return IsSetUnderlyingCouponPaymentDate(); }

        public bool IsSetUnderlyingCouponPaymentDate() { return IsSetField(Tags.UnderlyingCouponPaymentDate); }

        public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingIssueDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingIssueDate val) { this.UnderlyingIssueDate = val; }

        public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) { return IsSetUnderlyingIssueDate(); }

        public bool IsSetUnderlyingIssueDate() { return IsSetField(Tags.UnderlyingIssueDate); }

        public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) { this.UnderlyingRepoCollateralSecurityType = val; }

        public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) { return IsSetUnderlyingRepoCollateralSecurityType(); }

        public bool IsSetUnderlyingRepoCollateralSecurityType() { return IsSetField(Tags.UnderlyingRepoCollateralSecurityType); }

        public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) { this.UnderlyingRepurchaseTerm = val; }

        public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) { return IsSetUnderlyingRepurchaseTerm(); }

        public bool IsSetUnderlyingRepurchaseTerm() { return IsSetField(Tags.UnderlyingRepurchaseTerm); }

        public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) { this.UnderlyingRepurchaseRate = val; }

        public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) { return IsSetUnderlyingRepurchaseRate(); }

        public bool IsSetUnderlyingRepurchaseRate() { return IsSetField(Tags.UnderlyingRepurchaseRate); }

        public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingFactor();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingFactor val) { this.UnderlyingFactor = val; }

        public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingFactor val) { return IsSetUnderlyingFactor(); }

        public bool IsSetUnderlyingFactor() { return IsSetField(Tags.UnderlyingFactor); }

        public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCreditRating();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCreditRating val) { this.UnderlyingCreditRating = val; }

        public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) { return IsSetUnderlyingCreditRating(); }

        public bool IsSetUnderlyingCreditRating() { return IsSetField(Tags.UnderlyingCreditRating); }

        public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingInstrRegistry();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) { this.UnderlyingInstrRegistry = val; }

        public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) { return IsSetUnderlyingInstrRegistry(); }

        public bool IsSetUnderlyingInstrRegistry() { return IsSetField(Tags.UnderlyingInstrRegistry); }

        public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) { this.UnderlyingCountryOfIssue = val; }

        public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) { return IsSetUnderlyingCountryOfIssue(); }

        public bool IsSetUnderlyingCountryOfIssue() { return IsSetField(Tags.UnderlyingCountryOfIssue); }

        public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) { this.UnderlyingStateOrProvinceOfIssue = val; }

        public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) { return IsSetUnderlyingStateOrProvinceOfIssue(); }

        public bool IsSetUnderlyingStateOrProvinceOfIssue() { return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue); }

        public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) { this.UnderlyingLocaleOfIssue = val; }

        public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) { return IsSetUnderlyingLocaleOfIssue(); }

        public bool IsSetUnderlyingLocaleOfIssue() { return IsSetField(Tags.UnderlyingLocaleOfIssue); }

        public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRedemptionDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) { this.UnderlyingRedemptionDate = val; }

        public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) { return IsSetUnderlyingRedemptionDate(); }

        public bool IsSetUnderlyingRedemptionDate() { return IsSetField(Tags.UnderlyingRedemptionDate); }

        public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStrikePrice val) { this.UnderlyingStrikePrice = val; }

        public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) { return IsSetUnderlyingStrikePrice(); }

        public bool IsSetUnderlyingStrikePrice() { return IsSetField(Tags.UnderlyingStrikePrice); }

        public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) { this.UnderlyingStrikeCurrency = val; }

        public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) { return IsSetUnderlyingStrikeCurrency(); }

        public bool IsSetUnderlyingStrikeCurrency() { return IsSetField(Tags.UnderlyingStrikeCurrency); }

        public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingOptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingOptAttribute val) { this.UnderlyingOptAttribute = val; }

        public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) { return IsSetUnderlyingOptAttribute(); }

        public bool IsSetUnderlyingOptAttribute() { return IsSetField(Tags.UnderlyingOptAttribute); }

        public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingContractMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) { this.UnderlyingContractMultiplier = val; }

        public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) { return IsSetUnderlyingContractMultiplier(); }

        public bool IsSetUnderlyingContractMultiplier() { return IsSetField(Tags.UnderlyingContractMultiplier); }

        public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCouponRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCouponRate val) { this.UnderlyingCouponRate = val; }

        public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) { return IsSetUnderlyingCouponRate(); }

        public bool IsSetUnderlyingCouponRate() { return IsSetField(Tags.UnderlyingCouponRate); }

        public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) { this.UnderlyingSecurityExchange = val; }

        public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) { return IsSetUnderlyingSecurityExchange(); }

        public bool IsSetUnderlyingSecurityExchange() { return IsSetField(Tags.UnderlyingSecurityExchange); }

        public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingIssuer val) { this.UnderlyingIssuer = val; }

        public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) { return IsSetUnderlyingIssuer(); }

        public bool IsSetUnderlyingIssuer() { return IsSetField(Tags.UnderlyingIssuer); }

        public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) { this.EncodedUnderlyingIssuerLen = val; }

        public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) { return IsSetEncodedUnderlyingIssuerLen(); }

        public bool IsSetEncodedUnderlyingIssuerLen() { return IsSetField(Tags.EncodedUnderlyingIssuerLen); }

        public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
        {
            get
            {
                var val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) { this.EncodedUnderlyingIssuer = val; }

        public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) { return IsSetEncodedUnderlyingIssuer(); }

        public bool IsSetEncodedUnderlyingIssuer() { return IsSetField(Tags.EncodedUnderlyingIssuer); }

        public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) { this.UnderlyingSecurityDesc = val; }

        public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) { return IsSetUnderlyingSecurityDesc(); }

        public bool IsSetUnderlyingSecurityDesc() { return IsSetField(Tags.UnderlyingSecurityDesc); }

        public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) { this.EncodedUnderlyingSecurityDescLen = val; }

        public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) { return IsSetEncodedUnderlyingSecurityDescLen(); }

        public bool IsSetEncodedUnderlyingSecurityDescLen() { return IsSetField(Tags.EncodedUnderlyingSecurityDescLen); }

        public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) { this.EncodedUnderlyingSecurityDesc = val; }

        public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) { return IsSetEncodedUnderlyingSecurityDesc(); }

        public bool IsSetEncodedUnderlyingSecurityDesc() { return IsSetField(Tags.EncodedUnderlyingSecurityDesc); }

        public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCPProgram();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCPProgram val) { this.UnderlyingCPProgram = val; }

        public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) { return IsSetUnderlyingCPProgram(); }

        public bool IsSetUnderlyingCPProgram() { return IsSetField(Tags.UnderlyingCPProgram); }

        public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCPRegType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCPRegType val) { this.UnderlyingCPRegType = val; }

        public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) { return IsSetUnderlyingCPRegType(); }

        public bool IsSetUnderlyingCPRegType() { return IsSetField(Tags.UnderlyingCPRegType); }

        public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCurrency val) { this.UnderlyingCurrency = val; }

        public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) { return IsSetUnderlyingCurrency(); }

        public bool IsSetUnderlyingCurrency() { return IsSetField(Tags.UnderlyingCurrency); }

        public QuickFix.Fields.UnderlyingQty UnderlyingQty
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingQty val) { this.UnderlyingQty = val; }

        public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingQty val) { return IsSetUnderlyingQty(); }

        public bool IsSetUnderlyingQty() { return IsSetField(Tags.UnderlyingQty); }

        public QuickFix.Fields.UnderlyingPx UnderlyingPx
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPx val) { this.UnderlyingPx = val; }

        public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPx val) { return IsSetUnderlyingPx(); }

        public bool IsSetUnderlyingPx() { return IsSetField(Tags.UnderlyingPx); }

        public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingDirtyPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) { this.UnderlyingDirtyPrice = val; }

        public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) { return IsSetUnderlyingDirtyPrice(); }

        public bool IsSetUnderlyingDirtyPrice() { return IsSetField(Tags.UnderlyingDirtyPrice); }

        public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingEndPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingEndPrice val) { this.UnderlyingEndPrice = val; }

        public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) { return IsSetUnderlyingEndPrice(); }

        public bool IsSetUnderlyingEndPrice() { return IsSetField(Tags.UnderlyingEndPrice); }

        public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStartValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStartValue val) { this.UnderlyingStartValue = val; }

        public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) { return IsSetUnderlyingStartValue(); }

        public bool IsSetUnderlyingStartValue() { return IsSetField(Tags.UnderlyingStartValue); }

        public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCurrentValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCurrentValue val) { this.UnderlyingCurrentValue = val; }

        public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) { return IsSetUnderlyingCurrentValue(); }

        public bool IsSetUnderlyingCurrentValue() { return IsSetField(Tags.UnderlyingCurrentValue); }

        public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingEndValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingEndValue val) { this.UnderlyingEndValue = val; }

        public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) { return IsSetUnderlyingEndValue(); }

        public bool IsSetUnderlyingEndValue() { return IsSetField(Tags.UnderlyingEndValue); }

        public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
        {
            get
            {
                var val = new QuickFix.Fields.NoUnderlyingStips();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUnderlyingStips val) { this.NoUnderlyingStips = val; }

        public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) { return IsSetNoUnderlyingStips(); }

        public bool IsSetNoUnderlyingStips() { return IsSetField(Tags.NoUnderlyingStips); }

        public QuickFix.Fields.UnderlyingAllocationPercent UnderlyingAllocationPercent
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingAllocationPercent();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingAllocationPercent val) { this.UnderlyingAllocationPercent = val; }

        public QuickFix.Fields.UnderlyingAllocationPercent Get(QuickFix.Fields.UnderlyingAllocationPercent val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingAllocationPercent val) { return IsSetUnderlyingAllocationPercent(); }

        public bool IsSetUnderlyingAllocationPercent() { return IsSetField(Tags.UnderlyingAllocationPercent); }

        public QuickFix.Fields.UnderlyingSettlementType UnderlyingSettlementType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSettlementType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSettlementType val) { this.UnderlyingSettlementType = val; }

        public QuickFix.Fields.UnderlyingSettlementType Get(QuickFix.Fields.UnderlyingSettlementType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSettlementType val) { return IsSetUnderlyingSettlementType(); }

        public bool IsSetUnderlyingSettlementType() { return IsSetField(Tags.UnderlyingSettlementType); }

        public QuickFix.Fields.UnderlyingCashAmount UnderlyingCashAmount
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCashAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCashAmount val) { this.UnderlyingCashAmount = val; }

        public QuickFix.Fields.UnderlyingCashAmount Get(QuickFix.Fields.UnderlyingCashAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCashAmount val) { return IsSetUnderlyingCashAmount(); }

        public bool IsSetUnderlyingCashAmount() { return IsSetField(Tags.UnderlyingCashAmount); }

        public QuickFix.Fields.UnderlyingCashType UnderlyingCashType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCashType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCashType val) { this.UnderlyingCashType = val; }

        public QuickFix.Fields.UnderlyingCashType Get(QuickFix.Fields.UnderlyingCashType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCashType val) { return IsSetUnderlyingCashType(); }

        public bool IsSetUnderlyingCashType() { return IsSetField(Tags.UnderlyingCashType); }

        public QuickFix.Fields.UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val) { this.UnderlyingUnitOfMeasure = val; }

        public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) { return IsSetUnderlyingUnitOfMeasure(); }

        public bool IsSetUnderlyingUnitOfMeasure() { return IsSetField(Tags.UnderlyingUnitOfMeasure); }

        public QuickFix.Fields.UnderlyingTimeUnit UnderlyingTimeUnit
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingTimeUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingTimeUnit val) { this.UnderlyingTimeUnit = val; }

        public QuickFix.Fields.UnderlyingTimeUnit Get(QuickFix.Fields.UnderlyingTimeUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingTimeUnit val) { return IsSetUnderlyingTimeUnit(); }

        public bool IsSetUnderlyingTimeUnit() { return IsSetField(Tags.UnderlyingTimeUnit); }

        public QuickFix.Fields.UnderlyingCapValue UnderlyingCapValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCapValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCapValue val) { this.UnderlyingCapValue = val; }

        public QuickFix.Fields.UnderlyingCapValue Get(QuickFix.Fields.UnderlyingCapValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCapValue val) { return IsSetUnderlyingCapValue(); }

        public bool IsSetUnderlyingCapValue() { return IsSetField(Tags.UnderlyingCapValue); }

        public QuickFix.Fields.NoUndlyInstrumentParties NoUndlyInstrumentParties
        {
            get
            {
                var val = new QuickFix.Fields.NoUndlyInstrumentParties();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUndlyInstrumentParties val) { this.NoUndlyInstrumentParties = val; }

        public QuickFix.Fields.NoUndlyInstrumentParties Get(QuickFix.Fields.NoUndlyInstrumentParties val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUndlyInstrumentParties val) { return IsSetNoUndlyInstrumentParties(); }

        public bool IsSetNoUndlyInstrumentParties() { return IsSetField(Tags.NoUndlyInstrumentParties); }

        public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSettlMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSettlMethod val) { this.UnderlyingSettlMethod = val; }

        public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) { return IsSetUnderlyingSettlMethod(); }

        public bool IsSetUnderlyingSettlMethod() { return IsSetField(Tags.UnderlyingSettlMethod); }

        public QuickFix.Fields.UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingAdjustedQuantity val) { this.UnderlyingAdjustedQuantity = val; }

        public QuickFix.Fields.UnderlyingAdjustedQuantity Get(QuickFix.Fields.UnderlyingAdjustedQuantity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) { return IsSetUnderlyingAdjustedQuantity(); }

        public bool IsSetUnderlyingAdjustedQuantity() { return IsSetField(Tags.UnderlyingAdjustedQuantity); }

        public QuickFix.Fields.UnderlyingFXRate UnderlyingFXRate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingFXRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingFXRate val) { this.UnderlyingFXRate = val; }

        public QuickFix.Fields.UnderlyingFXRate Get(QuickFix.Fields.UnderlyingFXRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingFXRate val) { return IsSetUnderlyingFXRate(); }

        public bool IsSetUnderlyingFXRate() { return IsSetField(Tags.UnderlyingFXRate); }

        public QuickFix.Fields.UnderlyingFXRateCalc UnderlyingFXRateCalc
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingFXRateCalc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingFXRateCalc val) { this.UnderlyingFXRateCalc = val; }

        public QuickFix.Fields.UnderlyingFXRateCalc Get(QuickFix.Fields.UnderlyingFXRateCalc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingFXRateCalc val) { return IsSetUnderlyingFXRateCalc(); }

        public bool IsSetUnderlyingFXRateCalc() { return IsSetField(Tags.UnderlyingFXRateCalc); }


        public class NoUnderlyingSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};

            public NoUnderlyingSecurityAltIDGroup() : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) { this.UnderlyingSecurityAltID = val; }

        public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) { return IsSetUnderlyingSecurityAltID(); }

        public bool IsSetUnderlyingSecurityAltID() { return IsSetField(Tags.UnderlyingSecurityAltID); }

        public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) { this.UnderlyingSecurityAltIDSource = val; }

        public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) { return IsSetUnderlyingSecurityAltIDSource(); }

        public bool IsSetUnderlyingSecurityAltIDSource() { return IsSetField(Tags.UnderlyingSecurityAltIDSource); }


        }
        public class NoUnderlyingStipsGroup : Group
        {
            public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};

            public NoUnderlyingStipsGroup() : base(Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingStipsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingStipType UnderlyingStipType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStipType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStipType val) { this.UnderlyingStipType = val; }

        public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStipType val) { return IsSetUnderlyingStipType(); }

        public bool IsSetUnderlyingStipType() { return IsSetField(Tags.UnderlyingStipType); }

        public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStipValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStipValue val) { this.UnderlyingStipValue = val; }

        public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) { return IsSetUnderlyingStipValue(); }

        public bool IsSetUnderlyingStipValue() { return IsSetField(Tags.UnderlyingStipValue); }


        }
        public class NoUndlyInstrumentPartiesGroup : Group
        {
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

            public NoUndlyInstrumentPartiesGroup() : base(Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UndlyInstrumentPartyID UndlyInstrumentPartyID
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyID val) { this.UndlyInstrumentPartyID = val; }

        public QuickFix.Fields.UndlyInstrumentPartyID Get(QuickFix.Fields.UndlyInstrumentPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyID val) { return IsSetUndlyInstrumentPartyID(); }

        public bool IsSetUndlyInstrumentPartyID() { return IsSetField(Tags.UndlyInstrumentPartyID); }

        public QuickFix.Fields.UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyIDSource val) { this.UndlyInstrumentPartyIDSource = val; }

        public QuickFix.Fields.UndlyInstrumentPartyIDSource Get(QuickFix.Fields.UndlyInstrumentPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val) { return IsSetUndlyInstrumentPartyIDSource(); }

        public bool IsSetUndlyInstrumentPartyIDSource() { return IsSetField(Tags.UndlyInstrumentPartyIDSource); }

        public QuickFix.Fields.UndlyInstrumentPartyRole UndlyInstrumentPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyRole val) { this.UndlyInstrumentPartyRole = val; }

        public QuickFix.Fields.UndlyInstrumentPartyRole Get(QuickFix.Fields.UndlyInstrumentPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyRole val) { return IsSetUndlyInstrumentPartyRole(); }

        public bool IsSetUndlyInstrumentPartyRole() { return IsSetField(Tags.UndlyInstrumentPartyRole); }

        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) { this.NoUndlyInstrumentPartySubIDs = val; }

        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs Get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) { return IsSetNoUndlyInstrumentPartySubIDs(); }

        public bool IsSetNoUndlyInstrumentPartySubIDs() { return IsSetField(Tags.NoUndlyInstrumentPartySubIDs); }


        public class NoUndlyInstrumentPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};

            public NoUndlyInstrumentPartySubIDsGroup() : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UndlyInstrumentPartySubID UndlyInstrumentPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartySubID val) { this.UndlyInstrumentPartySubID = val; }

        public QuickFix.Fields.UndlyInstrumentPartySubID Get(QuickFix.Fields.UndlyInstrumentPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubID val) { return IsSetUndlyInstrumentPartySubID(); }

        public bool IsSetUndlyInstrumentPartySubID() { return IsSetField(Tags.UndlyInstrumentPartySubID); }

        public QuickFix.Fields.UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartySubIDType val) { this.UndlyInstrumentPartySubIDType = val; }

        public QuickFix.Fields.UndlyInstrumentPartySubIDType Get(QuickFix.Fields.UndlyInstrumentPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val) { return IsSetUndlyInstrumentPartySubIDType(); }

        public bool IsSetUndlyInstrumentPartySubIDType() { return IsSetField(Tags.UndlyInstrumentPartySubIDType); }


        }
        }
        }


    }
}
