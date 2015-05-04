using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class TradeCaptureReport : Message
    {
        public const string MsgType = "AE";

        public TradeCaptureReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public TradeCaptureReport(QuickFix.Fields.LastQty aLastQty,
				QuickFix.Fields.LastPx aLastPx)
               : this()
        {
            this.LastQty = aLastQty;
			this.LastPx = aLastPx;
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

        public QuickFix.Fields.TradeRequestID TradeRequestID
        {
            get
            {
                var val = new QuickFix.Fields.TradeRequestID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeRequestID val) { this.TradeRequestID = val; }

        public QuickFix.Fields.TradeRequestID Get(QuickFix.Fields.TradeRequestID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeRequestID val) { return IsSetTradeRequestID(); }

        public bool IsSetTradeRequestID() { return IsSetField(Tags.TradeRequestID); }

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

        public QuickFix.Fields.TotNumTradeReports TotNumTradeReports
        {
            get
            {
                var val = new QuickFix.Fields.TotNumTradeReports();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotNumTradeReports val) { this.TotNumTradeReports = val; }

        public QuickFix.Fields.TotNumTradeReports Get(QuickFix.Fields.TotNumTradeReports val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotNumTradeReports val) { return IsSetTotNumTradeReports(); }

        public bool IsSetTotNumTradeReports() { return IsSetField(Tags.TotNumTradeReports); }

        public QuickFix.Fields.LastRptRequested LastRptRequested
        {
            get
            {
                var val = new QuickFix.Fields.LastRptRequested();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastRptRequested val) { this.LastRptRequested = val; }

        public QuickFix.Fields.LastRptRequested Get(QuickFix.Fields.LastRptRequested val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastRptRequested val) { return IsSetLastRptRequested(); }

        public bool IsSetLastRptRequested() { return IsSetField(Tags.LastRptRequested); }

        public QuickFix.Fields.UnsolicitedIndicator UnsolicitedIndicator
        {
            get
            {
                var val = new QuickFix.Fields.UnsolicitedIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnsolicitedIndicator val) { this.UnsolicitedIndicator = val; }

        public QuickFix.Fields.UnsolicitedIndicator Get(QuickFix.Fields.UnsolicitedIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnsolicitedIndicator val) { return IsSetUnsolicitedIndicator(); }

        public bool IsSetUnsolicitedIndicator() { return IsSetField(Tags.UnsolicitedIndicator); }

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

        public QuickFix.Fields.SecurityStatus SecurityStatus
        {
            get
            {
                var val = new QuickFix.Fields.SecurityStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityStatus val) { this.SecurityStatus = val; }

        public QuickFix.Fields.SecurityStatus Get(QuickFix.Fields.SecurityStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityStatus val) { return IsSetSecurityStatus(); }

        public bool IsSetSecurityStatus() { return IsSetField(Tags.SecurityStatus); }

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

        public QuickFix.Fields.SecurityGroup SecurityGroup
        {
            get
            {
                var val = new QuickFix.Fields.SecurityGroup();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityGroup val) { this.SecurityGroup = val; }

        public QuickFix.Fields.SecurityGroup Get(QuickFix.Fields.SecurityGroup val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityGroup val) { return IsSetSecurityGroup(); }

        public bool IsSetSecurityGroup() { return IsSetField(Tags.SecurityGroup); }

        public QuickFix.Fields.MinPriceIncrementAmount MinPriceIncrementAmount
        {
            get
            {
                var val = new QuickFix.Fields.MinPriceIncrementAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MinPriceIncrementAmount val) { this.MinPriceIncrementAmount = val; }

        public QuickFix.Fields.MinPriceIncrementAmount Get(QuickFix.Fields.MinPriceIncrementAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MinPriceIncrementAmount val) { return IsSetMinPriceIncrementAmount(); }

        public bool IsSetMinPriceIncrementAmount() { return IsSetField(Tags.MinPriceIncrementAmount); }

        public QuickFix.Fields.UnitOfMeasureQty UnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.UnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnitOfMeasureQty val) { this.UnitOfMeasureQty = val; }

        public QuickFix.Fields.UnitOfMeasureQty Get(QuickFix.Fields.UnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnitOfMeasureQty val) { return IsSetUnitOfMeasureQty(); }

        public bool IsSetUnitOfMeasureQty() { return IsSetField(Tags.UnitOfMeasureQty); }

        public QuickFix.Fields.SecurityXMLLen SecurityXMLLen
        {
            get
            {
                var val = new QuickFix.Fields.SecurityXMLLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityXMLLen val) { this.SecurityXMLLen = val; }

        public QuickFix.Fields.SecurityXMLLen Get(QuickFix.Fields.SecurityXMLLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityXMLLen val) { return IsSetSecurityXMLLen(); }

        public bool IsSetSecurityXMLLen() { return IsSetField(Tags.SecurityXMLLen); }

        public QuickFix.Fields.SecurityXML SecurityXML
        {
            get
            {
                var val = new QuickFix.Fields.SecurityXML();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityXML val) { this.SecurityXML = val; }

        public QuickFix.Fields.SecurityXML Get(QuickFix.Fields.SecurityXML val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityXML val) { return IsSetSecurityXML(); }

        public bool IsSetSecurityXML() { return IsSetField(Tags.SecurityXML); }

        public QuickFix.Fields.SecurityXMLSchema SecurityXMLSchema
        {
            get
            {
                var val = new QuickFix.Fields.SecurityXMLSchema();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityXMLSchema val) { this.SecurityXMLSchema = val; }

        public QuickFix.Fields.SecurityXMLSchema Get(QuickFix.Fields.SecurityXMLSchema val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityXMLSchema val) { return IsSetSecurityXMLSchema(); }

        public bool IsSetSecurityXMLSchema() { return IsSetField(Tags.SecurityXMLSchema); }

        public QuickFix.Fields.ProductComplex ProductComplex
        {
            get
            {
                var val = new QuickFix.Fields.ProductComplex();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ProductComplex val) { this.ProductComplex = val; }

        public QuickFix.Fields.ProductComplex Get(QuickFix.Fields.ProductComplex val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ProductComplex val) { return IsSetProductComplex(); }

        public bool IsSetProductComplex() { return IsSetField(Tags.ProductComplex); }

        public QuickFix.Fields.PriceUnitOfMeasure PriceUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.PriceUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PriceUnitOfMeasure val) { this.PriceUnitOfMeasure = val; }

        public QuickFix.Fields.PriceUnitOfMeasure Get(QuickFix.Fields.PriceUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PriceUnitOfMeasure val) { return IsSetPriceUnitOfMeasure(); }

        public bool IsSetPriceUnitOfMeasure() { return IsSetField(Tags.PriceUnitOfMeasure); }

        public QuickFix.Fields.PriceUnitOfMeasureQty PriceUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PriceUnitOfMeasureQty val) { this.PriceUnitOfMeasureQty = val; }

        public QuickFix.Fields.PriceUnitOfMeasureQty Get(QuickFix.Fields.PriceUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PriceUnitOfMeasureQty val) { return IsSetPriceUnitOfMeasureQty(); }

        public bool IsSetPriceUnitOfMeasureQty() { return IsSetField(Tags.PriceUnitOfMeasureQty); }

        public QuickFix.Fields.SettlMethod SettlMethod
        {
            get
            {
                var val = new QuickFix.Fields.SettlMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlMethod val) { this.SettlMethod = val; }

        public QuickFix.Fields.SettlMethod Get(QuickFix.Fields.SettlMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlMethod val) { return IsSetSettlMethod(); }

        public bool IsSetSettlMethod() { return IsSetField(Tags.SettlMethod); }

        public QuickFix.Fields.ExerciseStyle ExerciseStyle
        {
            get
            {
                var val = new QuickFix.Fields.ExerciseStyle();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExerciseStyle val) { this.ExerciseStyle = val; }

        public QuickFix.Fields.ExerciseStyle Get(QuickFix.Fields.ExerciseStyle val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExerciseStyle val) { return IsSetExerciseStyle(); }

        public bool IsSetExerciseStyle() { return IsSetField(Tags.ExerciseStyle); }

        public QuickFix.Fields.OptPayoutAmount OptPayoutAmount
        {
            get
            {
                var val = new QuickFix.Fields.OptPayoutAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OptPayoutAmount val) { this.OptPayoutAmount = val; }

        public QuickFix.Fields.OptPayoutAmount Get(QuickFix.Fields.OptPayoutAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OptPayoutAmount val) { return IsSetOptPayoutAmount(); }

        public bool IsSetOptPayoutAmount() { return IsSetField(Tags.OptPayoutAmount); }

        public QuickFix.Fields.PriceQuoteMethod PriceQuoteMethod
        {
            get
            {
                var val = new QuickFix.Fields.PriceQuoteMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PriceQuoteMethod val) { this.PriceQuoteMethod = val; }

        public QuickFix.Fields.PriceQuoteMethod Get(QuickFix.Fields.PriceQuoteMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PriceQuoteMethod val) { return IsSetPriceQuoteMethod(); }

        public bool IsSetPriceQuoteMethod() { return IsSetField(Tags.PriceQuoteMethod); }

        public QuickFix.Fields.ListMethod ListMethod
        {
            get
            {
                var val = new QuickFix.Fields.ListMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ListMethod val) { this.ListMethod = val; }

        public QuickFix.Fields.ListMethod Get(QuickFix.Fields.ListMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ListMethod val) { return IsSetListMethod(); }

        public bool IsSetListMethod() { return IsSetField(Tags.ListMethod); }

        public QuickFix.Fields.CapPrice CapPrice
        {
            get
            {
                var val = new QuickFix.Fields.CapPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CapPrice val) { this.CapPrice = val; }

        public QuickFix.Fields.CapPrice Get(QuickFix.Fields.CapPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CapPrice val) { return IsSetCapPrice(); }

        public bool IsSetCapPrice() { return IsSetField(Tags.CapPrice); }

        public QuickFix.Fields.FloorPrice FloorPrice
        {
            get
            {
                var val = new QuickFix.Fields.FloorPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FloorPrice val) { this.FloorPrice = val; }

        public QuickFix.Fields.FloorPrice Get(QuickFix.Fields.FloorPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FloorPrice val) { return IsSetFloorPrice(); }

        public bool IsSetFloorPrice() { return IsSetField(Tags.FloorPrice); }

        public QuickFix.Fields.PutOrCall PutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.PutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PutOrCall val) { this.PutOrCall = val; }

        public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PutOrCall val) { return IsSetPutOrCall(); }

        public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }

        public QuickFix.Fields.FlexibleIndicator FlexibleIndicator
        {
            get
            {
                var val = new QuickFix.Fields.FlexibleIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FlexibleIndicator val) { this.FlexibleIndicator = val; }

        public QuickFix.Fields.FlexibleIndicator Get(QuickFix.Fields.FlexibleIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FlexibleIndicator val) { return IsSetFlexibleIndicator(); }

        public bool IsSetFlexibleIndicator() { return IsSetField(Tags.FlexibleIndicator); }

        public QuickFix.Fields.FlexProductEligibilityIndicator FlexProductEligibilityIndicator
        {
            get
            {
                var val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FlexProductEligibilityIndicator val) { this.FlexProductEligibilityIndicator = val; }

        public QuickFix.Fields.FlexProductEligibilityIndicator Get(QuickFix.Fields.FlexProductEligibilityIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FlexProductEligibilityIndicator val) { return IsSetFlexProductEligibilityIndicator(); }

        public bool IsSetFlexProductEligibilityIndicator() { return IsSetField(Tags.FlexProductEligibilityIndicator); }

        public QuickFix.Fields.ValuationMethod ValuationMethod
        {
            get
            {
                var val = new QuickFix.Fields.ValuationMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ValuationMethod val) { this.ValuationMethod = val; }

        public QuickFix.Fields.ValuationMethod Get(QuickFix.Fields.ValuationMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ValuationMethod val) { return IsSetValuationMethod(); }

        public bool IsSetValuationMethod() { return IsSetField(Tags.ValuationMethod); }

        public QuickFix.Fields.ContractMultiplierUnit ContractMultiplierUnit
        {
            get
            {
                var val = new QuickFix.Fields.ContractMultiplierUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContractMultiplierUnit val) { this.ContractMultiplierUnit = val; }

        public QuickFix.Fields.ContractMultiplierUnit Get(QuickFix.Fields.ContractMultiplierUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContractMultiplierUnit val) { return IsSetContractMultiplierUnit(); }

        public bool IsSetContractMultiplierUnit() { return IsSetField(Tags.ContractMultiplierUnit); }

        public QuickFix.Fields.FlowScheduleType FlowScheduleType
        {
            get
            {
                var val = new QuickFix.Fields.FlowScheduleType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FlowScheduleType val) { this.FlowScheduleType = val; }

        public QuickFix.Fields.FlowScheduleType Get(QuickFix.Fields.FlowScheduleType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FlowScheduleType val) { return IsSetFlowScheduleType(); }

        public bool IsSetFlowScheduleType() { return IsSetField(Tags.FlowScheduleType); }

        public QuickFix.Fields.RestructuringType RestructuringType
        {
            get
            {
                var val = new QuickFix.Fields.RestructuringType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RestructuringType val) { this.RestructuringType = val; }

        public QuickFix.Fields.RestructuringType Get(QuickFix.Fields.RestructuringType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RestructuringType val) { return IsSetRestructuringType(); }

        public bool IsSetRestructuringType() { return IsSetField(Tags.RestructuringType); }

        public QuickFix.Fields.Seniority Seniority
        {
            get
            {
                var val = new QuickFix.Fields.Seniority();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Seniority val) { this.Seniority = val; }

        public QuickFix.Fields.Seniority Get(QuickFix.Fields.Seniority val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Seniority val) { return IsSetSeniority(); }

        public bool IsSetSeniority() { return IsSetField(Tags.Seniority); }

        public QuickFix.Fields.NotionalPercentageOutstanding NotionalPercentageOutstanding
        {
            get
            {
                var val = new QuickFix.Fields.NotionalPercentageOutstanding();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NotionalPercentageOutstanding val) { this.NotionalPercentageOutstanding = val; }

        public QuickFix.Fields.NotionalPercentageOutstanding Get(QuickFix.Fields.NotionalPercentageOutstanding val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NotionalPercentageOutstanding val) { return IsSetNotionalPercentageOutstanding(); }

        public bool IsSetNotionalPercentageOutstanding() { return IsSetField(Tags.NotionalPercentageOutstanding); }

        public QuickFix.Fields.OriginalNotionalPercentageOutstanding OriginalNotionalPercentageOutstanding
        {
            get
            {
                var val = new QuickFix.Fields.OriginalNotionalPercentageOutstanding();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) { this.OriginalNotionalPercentageOutstanding = val; }

        public QuickFix.Fields.OriginalNotionalPercentageOutstanding Get(QuickFix.Fields.OriginalNotionalPercentageOutstanding val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) { return IsSetOriginalNotionalPercentageOutstanding(); }

        public bool IsSetOriginalNotionalPercentageOutstanding() { return IsSetField(Tags.OriginalNotionalPercentageOutstanding); }

        public QuickFix.Fields.AttachmentPoint AttachmentPoint
        {
            get
            {
                var val = new QuickFix.Fields.AttachmentPoint();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AttachmentPoint val) { this.AttachmentPoint = val; }

        public QuickFix.Fields.AttachmentPoint Get(QuickFix.Fields.AttachmentPoint val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AttachmentPoint val) { return IsSetAttachmentPoint(); }

        public bool IsSetAttachmentPoint() { return IsSetField(Tags.AttachmentPoint); }

        public QuickFix.Fields.DetachmentPoint DetachmentPoint
        {
            get
            {
                var val = new QuickFix.Fields.DetachmentPoint();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DetachmentPoint val) { this.DetachmentPoint = val; }

        public QuickFix.Fields.DetachmentPoint Get(QuickFix.Fields.DetachmentPoint val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DetachmentPoint val) { return IsSetDetachmentPoint(); }

        public bool IsSetDetachmentPoint() { return IsSetField(Tags.DetachmentPoint); }

        public QuickFix.Fields.StrikePriceDeterminationMethod StrikePriceDeterminationMethod
        {
            get
            {
                var val = new QuickFix.Fields.StrikePriceDeterminationMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikePriceDeterminationMethod val) { this.StrikePriceDeterminationMethod = val; }

        public QuickFix.Fields.StrikePriceDeterminationMethod Get(QuickFix.Fields.StrikePriceDeterminationMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikePriceDeterminationMethod val) { return IsSetStrikePriceDeterminationMethod(); }

        public bool IsSetStrikePriceDeterminationMethod() { return IsSetField(Tags.StrikePriceDeterminationMethod); }

        public QuickFix.Fields.StrikePriceBoundaryMethod StrikePriceBoundaryMethod
        {
            get
            {
                var val = new QuickFix.Fields.StrikePriceBoundaryMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikePriceBoundaryMethod val) { this.StrikePriceBoundaryMethod = val; }

        public QuickFix.Fields.StrikePriceBoundaryMethod Get(QuickFix.Fields.StrikePriceBoundaryMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikePriceBoundaryMethod val) { return IsSetStrikePriceBoundaryMethod(); }

        public bool IsSetStrikePriceBoundaryMethod() { return IsSetField(Tags.StrikePriceBoundaryMethod); }

        public QuickFix.Fields.StrikePriceBoundaryPrecision StrikePriceBoundaryPrecision
        {
            get
            {
                var val = new QuickFix.Fields.StrikePriceBoundaryPrecision();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikePriceBoundaryPrecision val) { this.StrikePriceBoundaryPrecision = val; }

        public QuickFix.Fields.StrikePriceBoundaryPrecision Get(QuickFix.Fields.StrikePriceBoundaryPrecision val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikePriceBoundaryPrecision val) { return IsSetStrikePriceBoundaryPrecision(); }

        public bool IsSetStrikePriceBoundaryPrecision() { return IsSetField(Tags.StrikePriceBoundaryPrecision); }

        public QuickFix.Fields.UnderlyingPriceDeterminationMethod UnderlyingPriceDeterminationMethod
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPriceDeterminationMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) { this.UnderlyingPriceDeterminationMethod = val; }

        public QuickFix.Fields.UnderlyingPriceDeterminationMethod Get(QuickFix.Fields.UnderlyingPriceDeterminationMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) { return IsSetUnderlyingPriceDeterminationMethod(); }

        public bool IsSetUnderlyingPriceDeterminationMethod() { return IsSetField(Tags.UnderlyingPriceDeterminationMethod); }

        public QuickFix.Fields.OptPayoutType OptPayoutType
        {
            get
            {
                var val = new QuickFix.Fields.OptPayoutType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OptPayoutType val) { this.OptPayoutType = val; }

        public QuickFix.Fields.OptPayoutType Get(QuickFix.Fields.OptPayoutType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OptPayoutType val) { return IsSetOptPayoutType(); }

        public bool IsSetOptPayoutType() { return IsSetField(Tags.OptPayoutType); }

        public QuickFix.Fields.NoComplexEvents NoComplexEvents
        {
            get
            {
                var val = new QuickFix.Fields.NoComplexEvents();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoComplexEvents val) { this.NoComplexEvents = val; }

        public QuickFix.Fields.NoComplexEvents Get(QuickFix.Fields.NoComplexEvents val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoComplexEvents val) { return IsSetNoComplexEvents(); }

        public bool IsSetNoComplexEvents() { return IsSetField(Tags.NoComplexEvents); }

        public QuickFix.Fields.AgreementDesc AgreementDesc
        {
            get
            {
                var val = new QuickFix.Fields.AgreementDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AgreementDesc val) { this.AgreementDesc = val; }

        public QuickFix.Fields.AgreementDesc Get(QuickFix.Fields.AgreementDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AgreementDesc val) { return IsSetAgreementDesc(); }

        public bool IsSetAgreementDesc() { return IsSetField(Tags.AgreementDesc); }

        public QuickFix.Fields.AgreementID AgreementID
        {
            get
            {
                var val = new QuickFix.Fields.AgreementID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AgreementID val) { this.AgreementID = val; }

        public QuickFix.Fields.AgreementID Get(QuickFix.Fields.AgreementID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AgreementID val) { return IsSetAgreementID(); }

        public bool IsSetAgreementID() { return IsSetField(Tags.AgreementID); }

        public QuickFix.Fields.AgreementDate AgreementDate
        {
            get
            {
                var val = new QuickFix.Fields.AgreementDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AgreementDate val) { this.AgreementDate = val; }

        public QuickFix.Fields.AgreementDate Get(QuickFix.Fields.AgreementDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AgreementDate val) { return IsSetAgreementDate(); }

        public bool IsSetAgreementDate() { return IsSetField(Tags.AgreementDate); }

        public QuickFix.Fields.AgreementCurrency AgreementCurrency
        {
            get
            {
                var val = new QuickFix.Fields.AgreementCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AgreementCurrency val) { this.AgreementCurrency = val; }

        public QuickFix.Fields.AgreementCurrency Get(QuickFix.Fields.AgreementCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AgreementCurrency val) { return IsSetAgreementCurrency(); }

        public bool IsSetAgreementCurrency() { return IsSetField(Tags.AgreementCurrency); }

        public QuickFix.Fields.TerminationType TerminationType
        {
            get
            {
                var val = new QuickFix.Fields.TerminationType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TerminationType val) { this.TerminationType = val; }

        public QuickFix.Fields.TerminationType Get(QuickFix.Fields.TerminationType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TerminationType val) { return IsSetTerminationType(); }

        public bool IsSetTerminationType() { return IsSetField(Tags.TerminationType); }

        public QuickFix.Fields.StartDate StartDate
        {
            get
            {
                var val = new QuickFix.Fields.StartDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StartDate val) { this.StartDate = val; }

        public QuickFix.Fields.StartDate Get(QuickFix.Fields.StartDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StartDate val) { return IsSetStartDate(); }

        public bool IsSetStartDate() { return IsSetField(Tags.StartDate); }

        public QuickFix.Fields.EndDate EndDate
        {
            get
            {
                var val = new QuickFix.Fields.EndDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EndDate val) { this.EndDate = val; }

        public QuickFix.Fields.EndDate Get(QuickFix.Fields.EndDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EndDate val) { return IsSetEndDate(); }

        public bool IsSetEndDate() { return IsSetField(Tags.EndDate); }

        public QuickFix.Fields.DeliveryType DeliveryType
        {
            get
            {
                var val = new QuickFix.Fields.DeliveryType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DeliveryType val) { this.DeliveryType = val; }

        public QuickFix.Fields.DeliveryType Get(QuickFix.Fields.DeliveryType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DeliveryType val) { return IsSetDeliveryType(); }

        public bool IsSetDeliveryType() { return IsSetField(Tags.DeliveryType); }

        public QuickFix.Fields.MarginRatio MarginRatio
        {
            get
            {
                var val = new QuickFix.Fields.MarginRatio();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MarginRatio val) { this.MarginRatio = val; }

        public QuickFix.Fields.MarginRatio Get(QuickFix.Fields.MarginRatio val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MarginRatio val) { return IsSetMarginRatio(); }

        public bool IsSetMarginRatio() { return IsSetField(Tags.MarginRatio); }

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

        public QuickFix.Fields.YieldType YieldType
        {
            get
            {
                var val = new QuickFix.Fields.YieldType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.YieldType val) { this.YieldType = val; }

        public QuickFix.Fields.YieldType Get(QuickFix.Fields.YieldType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.YieldType val) { return IsSetYieldType(); }

        public bool IsSetYieldType() { return IsSetField(Tags.YieldType); }

        public QuickFix.Fields.Yield Yield
        {
            get
            {
                var val = new QuickFix.Fields.Yield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Yield val) { this.Yield = val; }

        public QuickFix.Fields.Yield Get(QuickFix.Fields.Yield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Yield val) { return IsSetYield(); }

        public bool IsSetYield() { return IsSetField(Tags.Yield); }

        public QuickFix.Fields.YieldCalcDate YieldCalcDate
        {
            get
            {
                var val = new QuickFix.Fields.YieldCalcDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.YieldCalcDate val) { this.YieldCalcDate = val; }

        public QuickFix.Fields.YieldCalcDate Get(QuickFix.Fields.YieldCalcDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.YieldCalcDate val) { return IsSetYieldCalcDate(); }

        public bool IsSetYieldCalcDate() { return IsSetField(Tags.YieldCalcDate); }

        public QuickFix.Fields.YieldRedemptionDate YieldRedemptionDate
        {
            get
            {
                var val = new QuickFix.Fields.YieldRedemptionDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.YieldRedemptionDate val) { this.YieldRedemptionDate = val; }

        public QuickFix.Fields.YieldRedemptionDate Get(QuickFix.Fields.YieldRedemptionDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.YieldRedemptionDate val) { return IsSetYieldRedemptionDate(); }

        public bool IsSetYieldRedemptionDate() { return IsSetField(Tags.YieldRedemptionDate); }

        public QuickFix.Fields.YieldRedemptionPrice YieldRedemptionPrice
        {
            get
            {
                var val = new QuickFix.Fields.YieldRedemptionPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.YieldRedemptionPrice val) { this.YieldRedemptionPrice = val; }

        public QuickFix.Fields.YieldRedemptionPrice Get(QuickFix.Fields.YieldRedemptionPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.YieldRedemptionPrice val) { return IsSetYieldRedemptionPrice(); }

        public bool IsSetYieldRedemptionPrice() { return IsSetField(Tags.YieldRedemptionPrice); }

        public QuickFix.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
        {
            get
            {
                var val = new QuickFix.Fields.YieldRedemptionPriceType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.YieldRedemptionPriceType val) { this.YieldRedemptionPriceType = val; }

        public QuickFix.Fields.YieldRedemptionPriceType Get(QuickFix.Fields.YieldRedemptionPriceType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.YieldRedemptionPriceType val) { return IsSetYieldRedemptionPriceType(); }

        public bool IsSetYieldRedemptionPriceType() { return IsSetField(Tags.YieldRedemptionPriceType); }

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

        public QuickFix.Fields.Spread Spread
        {
            get
            {
                var val = new QuickFix.Fields.Spread();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Spread val) { this.Spread = val; }

        public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Spread val) { return IsSetSpread(); }

        public bool IsSetSpread() { return IsSetField(Tags.Spread); }

        public QuickFix.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkCurveCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkCurveCurrency val) { this.BenchmarkCurveCurrency = val; }

        public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val) { return IsSetBenchmarkCurveCurrency(); }

        public bool IsSetBenchmarkCurveCurrency() { return IsSetField(Tags.BenchmarkCurveCurrency); }

        public QuickFix.Fields.BenchmarkCurveName BenchmarkCurveName
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkCurveName();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkCurveName val) { this.BenchmarkCurveName = val; }

        public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkCurveName val) { return IsSetBenchmarkCurveName(); }

        public bool IsSetBenchmarkCurveName() { return IsSetField(Tags.BenchmarkCurveName); }

        public QuickFix.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkCurvePoint();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkCurvePoint val) { this.BenchmarkCurvePoint = val; }

        public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val) { return IsSetBenchmarkCurvePoint(); }

        public bool IsSetBenchmarkCurvePoint() { return IsSetField(Tags.BenchmarkCurvePoint); }

        public QuickFix.Fields.BenchmarkPrice BenchmarkPrice
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkPrice val) { this.BenchmarkPrice = val; }

        public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkPrice val) { return IsSetBenchmarkPrice(); }

        public bool IsSetBenchmarkPrice() { return IsSetField(Tags.BenchmarkPrice); }

        public QuickFix.Fields.BenchmarkPriceType BenchmarkPriceType
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkPriceType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkPriceType val) { this.BenchmarkPriceType = val; }

        public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkPriceType val) { return IsSetBenchmarkPriceType(); }

        public bool IsSetBenchmarkPriceType() { return IsSetField(Tags.BenchmarkPriceType); }

        public QuickFix.Fields.BenchmarkSecurityID BenchmarkSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkSecurityID val) { this.BenchmarkSecurityID = val; }

        public QuickFix.Fields.BenchmarkSecurityID Get(QuickFix.Fields.BenchmarkSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkSecurityID val) { return IsSetBenchmarkSecurityID(); }

        public bool IsSetBenchmarkSecurityID() { return IsSetField(Tags.BenchmarkSecurityID); }

        public QuickFix.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkSecurityIDSource val) { this.BenchmarkSecurityIDSource = val; }

        public QuickFix.Fields.BenchmarkSecurityIDSource Get(QuickFix.Fields.BenchmarkSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkSecurityIDSource val) { return IsSetBenchmarkSecurityIDSource(); }

        public bool IsSetBenchmarkSecurityIDSource() { return IsSetField(Tags.BenchmarkSecurityIDSource); }

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

        public QuickFix.Fields.UnderlyingSettlementDate UnderlyingSettlementDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSettlementDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSettlementDate val) { this.UnderlyingSettlementDate = val; }

        public QuickFix.Fields.UnderlyingSettlementDate Get(QuickFix.Fields.UnderlyingSettlementDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSettlementDate val) { return IsSetUnderlyingSettlementDate(); }

        public bool IsSetUnderlyingSettlementDate() { return IsSetField(Tags.UnderlyingSettlementDate); }

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

        public QuickFix.Fields.TZTransactTime TZTransactTime
        {
            get
            {
                var val = new QuickFix.Fields.TZTransactTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TZTransactTime val) { this.TZTransactTime = val; }

        public QuickFix.Fields.TZTransactTime Get(QuickFix.Fields.TZTransactTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TZTransactTime val) { return IsSetTZTransactTime(); }

        public bool IsSetTZTransactTime() { return IsSetField(Tags.TZTransactTime); }

        public QuickFix.Fields.ReportedPxDiff ReportedPxDiff
        {
            get
            {
                var val = new QuickFix.Fields.ReportedPxDiff();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ReportedPxDiff val) { this.ReportedPxDiff = val; }

        public QuickFix.Fields.ReportedPxDiff Get(QuickFix.Fields.ReportedPxDiff val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ReportedPxDiff val) { return IsSetReportedPxDiff(); }

        public bool IsSetReportedPxDiff() { return IsSetField(Tags.ReportedPxDiff); }

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

        public QuickFix.Fields.RejectText RejectText
        {
            get
            {
                var val = new QuickFix.Fields.RejectText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RejectText val) { this.RejectText = val; }

        public QuickFix.Fields.RejectText Get(QuickFix.Fields.RejectText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RejectText val) { return IsSetRejectText(); }

        public bool IsSetRejectText() { return IsSetField(Tags.RejectText); }

        public QuickFix.Fields.FeeMultiplier FeeMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.FeeMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FeeMultiplier val) { this.FeeMultiplier = val; }

        public QuickFix.Fields.FeeMultiplier Get(QuickFix.Fields.FeeMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FeeMultiplier val) { return IsSetFeeMultiplier(); }

        public bool IsSetFeeMultiplier() { return IsSetField(Tags.FeeMultiplier); }

        public QuickFix.Fields.Volatility Volatility
        {
            get
            {
                var val = new QuickFix.Fields.Volatility();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Volatility val) { this.Volatility = val; }

        public QuickFix.Fields.Volatility Get(QuickFix.Fields.Volatility val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Volatility val) { return IsSetVolatility(); }

        public bool IsSetVolatility() { return IsSetField(Tags.Volatility); }

        public QuickFix.Fields.DividendYield DividendYield
        {
            get
            {
                var val = new QuickFix.Fields.DividendYield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DividendYield val) { this.DividendYield = val; }

        public QuickFix.Fields.DividendYield Get(QuickFix.Fields.DividendYield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DividendYield val) { return IsSetDividendYield(); }

        public bool IsSetDividendYield() { return IsSetField(Tags.DividendYield); }

        public QuickFix.Fields.RiskFreeRate RiskFreeRate
        {
            get
            {
                var val = new QuickFix.Fields.RiskFreeRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskFreeRate val) { this.RiskFreeRate = val; }

        public QuickFix.Fields.RiskFreeRate Get(QuickFix.Fields.RiskFreeRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskFreeRate val) { return IsSetRiskFreeRate(); }

        public bool IsSetRiskFreeRate() { return IsSetField(Tags.RiskFreeRate); }

        public QuickFix.Fields.CurrencyRatio CurrencyRatio
        {
            get
            {
                var val = new QuickFix.Fields.CurrencyRatio();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CurrencyRatio val) { this.CurrencyRatio = val; }

        public QuickFix.Fields.CurrencyRatio Get(QuickFix.Fields.CurrencyRatio val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CurrencyRatio val) { return IsSetCurrencyRatio(); }

        public bool IsSetCurrencyRatio() { return IsSetField(Tags.CurrencyRatio); }

        public QuickFix.Fields.NoTrdRepIndicators NoTrdRepIndicators
        {
            get
            {
                var val = new QuickFix.Fields.NoTrdRepIndicators();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoTrdRepIndicators val) { this.NoTrdRepIndicators = val; }

        public QuickFix.Fields.NoTrdRepIndicators Get(QuickFix.Fields.NoTrdRepIndicators val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoTrdRepIndicators val) { return IsSetNoTrdRepIndicators(); }

        public bool IsSetNoTrdRepIndicators() { return IsSetField(Tags.NoTrdRepIndicators); }

        public QuickFix.Fields.TradePublishIndicator TradePublishIndicator
        {
            get
            {
                var val = new QuickFix.Fields.TradePublishIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradePublishIndicator val) { this.TradePublishIndicator = val; }

        public QuickFix.Fields.TradePublishIndicator Get(QuickFix.Fields.TradePublishIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradePublishIndicator val) { return IsSetTradePublishIndicator(); }

        public bool IsSetTradePublishIndicator() { return IsSetField(Tags.TradePublishIndicator); }

        public QuickFix.Fields.ApplID ApplID
        {
            get
            {
                var val = new QuickFix.Fields.ApplID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ApplID val) { this.ApplID = val; }

        public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ApplID val) { return IsSetApplID(); }

        public bool IsSetApplID() { return IsSetField(Tags.ApplID); }

        public QuickFix.Fields.ApplSeqNum ApplSeqNum
        {
            get
            {
                var val = new QuickFix.Fields.ApplSeqNum();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ApplSeqNum val) { this.ApplSeqNum = val; }

        public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ApplSeqNum val) { return IsSetApplSeqNum(); }

        public bool IsSetApplSeqNum() { return IsSetField(Tags.ApplSeqNum); }

        public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
        {
            get
            {
                var val = new QuickFix.Fields.ApplLastSeqNum();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ApplLastSeqNum val) { this.ApplLastSeqNum = val; }

        public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) { return IsSetApplLastSeqNum(); }

        public bool IsSetApplLastSeqNum() { return IsSetField(Tags.ApplLastSeqNum); }

        public QuickFix.Fields.ApplResendFlag ApplResendFlag
        {
            get
            {
                var val = new QuickFix.Fields.ApplResendFlag();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ApplResendFlag val) { this.ApplResendFlag = val; }

        public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ApplResendFlag val) { return IsSetApplResendFlag(); }

        public bool IsSetApplResendFlag() { return IsSetField(Tags.ApplResendFlag); }

        public QuickFix.Fields.VenueType VenueType
        {
            get
            {
                var val = new QuickFix.Fields.VenueType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.VenueType val) { this.VenueType = val; }

        public QuickFix.Fields.VenueType Get(QuickFix.Fields.VenueType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.VenueType val) { return IsSetVenueType(); }

        public bool IsSetVenueType() { return IsSetField(Tags.VenueType); }

        public QuickFix.Fields.MarketSegmentID MarketSegmentID
        {
            get
            {
                var val = new QuickFix.Fields.MarketSegmentID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MarketSegmentID val) { this.MarketSegmentID = val; }

        public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MarketSegmentID val) { return IsSetMarketSegmentID(); }

        public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

        public QuickFix.Fields.MarketID MarketID
        {
            get
            {
                var val = new QuickFix.Fields.MarketID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MarketID val) { this.MarketID = val; }

        public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MarketID val) { return IsSetMarketID(); }

        public bool IsSetMarketID() { return IsSetField(Tags.MarketID); }


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
            public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};

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

        public QuickFix.Fields.EventTime EventTime
        {
            get
            {
                var val = new QuickFix.Fields.EventTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EventTime val) { this.EventTime = val; }

        public QuickFix.Fields.EventTime Get(QuickFix.Fields.EventTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EventTime val) { return IsSetEventTime(); }

        public bool IsSetEventTime() { return IsSetField(Tags.EventTime); }


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


        public class NoComplexEventsGroup : Group
        {
            public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};

            public NoComplexEventsGroup() : base(Tags.NoComplexEvents, Tags.ComplexEventType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoComplexEventsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ComplexEventType ComplexEventType
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventType val) { this.ComplexEventType = val; }

        public QuickFix.Fields.ComplexEventType Get(QuickFix.Fields.ComplexEventType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventType val) { return IsSetComplexEventType(); }

        public bool IsSetComplexEventType() { return IsSetField(Tags.ComplexEventType); }

        public QuickFix.Fields.ComplexOptPayoutAmount ComplexOptPayoutAmount
        {
            get
            {
                var val = new QuickFix.Fields.ComplexOptPayoutAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexOptPayoutAmount val) { this.ComplexOptPayoutAmount = val; }

        public QuickFix.Fields.ComplexOptPayoutAmount Get(QuickFix.Fields.ComplexOptPayoutAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexOptPayoutAmount val) { return IsSetComplexOptPayoutAmount(); }

        public bool IsSetComplexOptPayoutAmount() { return IsSetField(Tags.ComplexOptPayoutAmount); }

        public QuickFix.Fields.ComplexEventPrice ComplexEventPrice
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventPrice val) { this.ComplexEventPrice = val; }

        public QuickFix.Fields.ComplexEventPrice Get(QuickFix.Fields.ComplexEventPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventPrice val) { return IsSetComplexEventPrice(); }

        public bool IsSetComplexEventPrice() { return IsSetField(Tags.ComplexEventPrice); }

        public QuickFix.Fields.ComplexEventPriceBoundaryMethod ComplexEventPriceBoundaryMethod
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventPriceBoundaryMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) { this.ComplexEventPriceBoundaryMethod = val; }

        public QuickFix.Fields.ComplexEventPriceBoundaryMethod Get(QuickFix.Fields.ComplexEventPriceBoundaryMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) { return IsSetComplexEventPriceBoundaryMethod(); }

        public bool IsSetComplexEventPriceBoundaryMethod() { return IsSetField(Tags.ComplexEventPriceBoundaryMethod); }

        public QuickFix.Fields.ComplexEventPriceBoundaryPrecision ComplexEventPriceBoundaryPrecision
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventPriceBoundaryPrecision();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) { this.ComplexEventPriceBoundaryPrecision = val; }

        public QuickFix.Fields.ComplexEventPriceBoundaryPrecision Get(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) { return IsSetComplexEventPriceBoundaryPrecision(); }

        public bool IsSetComplexEventPriceBoundaryPrecision() { return IsSetField(Tags.ComplexEventPriceBoundaryPrecision); }

        public QuickFix.Fields.ComplexEventPriceTimeType ComplexEventPriceTimeType
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventPriceTimeType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventPriceTimeType val) { this.ComplexEventPriceTimeType = val; }

        public QuickFix.Fields.ComplexEventPriceTimeType Get(QuickFix.Fields.ComplexEventPriceTimeType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventPriceTimeType val) { return IsSetComplexEventPriceTimeType(); }

        public bool IsSetComplexEventPriceTimeType() { return IsSetField(Tags.ComplexEventPriceTimeType); }

        public QuickFix.Fields.ComplexEventCondition ComplexEventCondition
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventCondition();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventCondition val) { this.ComplexEventCondition = val; }

        public QuickFix.Fields.ComplexEventCondition Get(QuickFix.Fields.ComplexEventCondition val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventCondition val) { return IsSetComplexEventCondition(); }

        public bool IsSetComplexEventCondition() { return IsSetField(Tags.ComplexEventCondition); }

        public QuickFix.Fields.NoComplexEventDates NoComplexEventDates
        {
            get
            {
                var val = new QuickFix.Fields.NoComplexEventDates();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoComplexEventDates val) { this.NoComplexEventDates = val; }

        public QuickFix.Fields.NoComplexEventDates Get(QuickFix.Fields.NoComplexEventDates val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoComplexEventDates val) { return IsSetNoComplexEventDates(); }

        public bool IsSetNoComplexEventDates() { return IsSetField(Tags.NoComplexEventDates); }


        public class NoComplexEventDatesGroup : Group
        {
            public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};

            public NoComplexEventDatesGroup() : base(Tags.NoComplexEventDates, Tags.ComplexEventStartDate, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoComplexEventDatesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ComplexEventStartDate ComplexEventStartDate
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventStartDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventStartDate val) { this.ComplexEventStartDate = val; }

        public QuickFix.Fields.ComplexEventStartDate Get(QuickFix.Fields.ComplexEventStartDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventStartDate val) { return IsSetComplexEventStartDate(); }

        public bool IsSetComplexEventStartDate() { return IsSetField(Tags.ComplexEventStartDate); }

        public QuickFix.Fields.ComplexEventEndDate ComplexEventEndDate
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventEndDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventEndDate val) { this.ComplexEventEndDate = val; }

        public QuickFix.Fields.ComplexEventEndDate Get(QuickFix.Fields.ComplexEventEndDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventEndDate val) { return IsSetComplexEventEndDate(); }

        public bool IsSetComplexEventEndDate() { return IsSetField(Tags.ComplexEventEndDate); }

        public QuickFix.Fields.NoComplexEventTimes NoComplexEventTimes
        {
            get
            {
                var val = new QuickFix.Fields.NoComplexEventTimes();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoComplexEventTimes val) { this.NoComplexEventTimes = val; }

        public QuickFix.Fields.NoComplexEventTimes Get(QuickFix.Fields.NoComplexEventTimes val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoComplexEventTimes val) { return IsSetNoComplexEventTimes(); }

        public bool IsSetNoComplexEventTimes() { return IsSetField(Tags.NoComplexEventTimes); }


        public class NoComplexEventTimesGroup : Group
        {
            public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};

            public NoComplexEventTimesGroup() : base(Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoComplexEventTimesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ComplexEventStartTime ComplexEventStartTime
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventStartTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventStartTime val) { this.ComplexEventStartTime = val; }

        public QuickFix.Fields.ComplexEventStartTime Get(QuickFix.Fields.ComplexEventStartTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventStartTime val) { return IsSetComplexEventStartTime(); }

        public bool IsSetComplexEventStartTime() { return IsSetField(Tags.ComplexEventStartTime); }

        public QuickFix.Fields.ComplexEventEndTime ComplexEventEndTime
        {
            get
            {
                var val = new QuickFix.Fields.ComplexEventEndTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ComplexEventEndTime val) { this.ComplexEventEndTime = val; }

        public QuickFix.Fields.ComplexEventEndTime Get(QuickFix.Fields.ComplexEventEndTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ComplexEventEndTime val) { return IsSetComplexEventEndTime(); }

        public bool IsSetComplexEventEndTime() { return IsSetField(Tags.ComplexEventEndTime); }


        }
        }
        }


        public class NoUnderlyingsGroup : Group
        {
            public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.UnderlyingContractMultiplierUnit, Tags.UnderlyingFlowScheduleType, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingNotionalPercentageOutstanding, Tags.UnderlyingOriginalNotionalPercentageOutstanding, Tags.UnderlyingAttachmentPoint, Tags.UnderlyingDetachmentPoint, 0};

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

        public QuickFix.Fields.UnderlyingMaturityTime UnderlyingMaturityTime
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingMaturityTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingMaturityTime val) { this.UnderlyingMaturityTime = val; }

        public QuickFix.Fields.UnderlyingMaturityTime Get(QuickFix.Fields.UnderlyingMaturityTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingMaturityTime val) { return IsSetUnderlyingMaturityTime(); }

        public bool IsSetUnderlyingMaturityTime() { return IsSetField(Tags.UnderlyingMaturityTime); }

        public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPutOrCall val) { this.UnderlyingPutOrCall = val; }

        public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) { return IsSetUnderlyingPutOrCall(); }

        public bool IsSetUnderlyingPutOrCall() { return IsSetField(Tags.UnderlyingPutOrCall); }

        public QuickFix.Fields.UnderlyingExerciseStyle UnderlyingExerciseStyle
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingExerciseStyle();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingExerciseStyle val) { this.UnderlyingExerciseStyle = val; }

        public QuickFix.Fields.UnderlyingExerciseStyle Get(QuickFix.Fields.UnderlyingExerciseStyle val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingExerciseStyle val) { return IsSetUnderlyingExerciseStyle(); }

        public bool IsSetUnderlyingExerciseStyle() { return IsSetField(Tags.UnderlyingExerciseStyle); }

        public QuickFix.Fields.UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) { this.UnderlyingUnitOfMeasureQty = val; }

        public QuickFix.Fields.UnderlyingUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) { return IsSetUnderlyingUnitOfMeasureQty(); }

        public bool IsSetUnderlyingUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingUnitOfMeasureQty); }

        public QuickFix.Fields.UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) { this.UnderlyingPriceUnitOfMeasure = val; }

        public QuickFix.Fields.UnderlyingPriceUnitOfMeasure Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) { return IsSetUnderlyingPriceUnitOfMeasure(); }

        public bool IsSetUnderlyingPriceUnitOfMeasure() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasure); }

        public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) { this.UnderlyingPriceUnitOfMeasureQty = val; }

        public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) { return IsSetUnderlyingPriceUnitOfMeasureQty(); }

        public bool IsSetUnderlyingPriceUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasureQty); }

        public QuickFix.Fields.UnderlyingContractMultiplierUnit UnderlyingContractMultiplierUnit
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingContractMultiplierUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingContractMultiplierUnit val) { this.UnderlyingContractMultiplierUnit = val; }

        public QuickFix.Fields.UnderlyingContractMultiplierUnit Get(QuickFix.Fields.UnderlyingContractMultiplierUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplierUnit val) { return IsSetUnderlyingContractMultiplierUnit(); }

        public bool IsSetUnderlyingContractMultiplierUnit() { return IsSetField(Tags.UnderlyingContractMultiplierUnit); }

        public QuickFix.Fields.UnderlyingFlowScheduleType UnderlyingFlowScheduleType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingFlowScheduleType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingFlowScheduleType val) { this.UnderlyingFlowScheduleType = val; }

        public QuickFix.Fields.UnderlyingFlowScheduleType Get(QuickFix.Fields.UnderlyingFlowScheduleType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingFlowScheduleType val) { return IsSetUnderlyingFlowScheduleType(); }

        public bool IsSetUnderlyingFlowScheduleType() { return IsSetField(Tags.UnderlyingFlowScheduleType); }

        public QuickFix.Fields.UnderlyingRestructuringType UnderlyingRestructuringType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRestructuringType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRestructuringType val) { this.UnderlyingRestructuringType = val; }

        public QuickFix.Fields.UnderlyingRestructuringType Get(QuickFix.Fields.UnderlyingRestructuringType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRestructuringType val) { return IsSetUnderlyingRestructuringType(); }

        public bool IsSetUnderlyingRestructuringType() { return IsSetField(Tags.UnderlyingRestructuringType); }

        public QuickFix.Fields.UnderlyingSeniority UnderlyingSeniority
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSeniority();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSeniority val) { this.UnderlyingSeniority = val; }

        public QuickFix.Fields.UnderlyingSeniority Get(QuickFix.Fields.UnderlyingSeniority val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSeniority val) { return IsSetUnderlyingSeniority(); }

        public bool IsSetUnderlyingSeniority() { return IsSetField(Tags.UnderlyingSeniority); }

        public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding UnderlyingNotionalPercentageOutstanding
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingNotionalPercentageOutstanding();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) { this.UnderlyingNotionalPercentageOutstanding = val; }

        public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding Get(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) { return IsSetUnderlyingNotionalPercentageOutstanding(); }

        public bool IsSetUnderlyingNotionalPercentageOutstanding() { return IsSetField(Tags.UnderlyingNotionalPercentageOutstanding); }

        public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding UnderlyingOriginalNotionalPercentageOutstanding
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) { this.UnderlyingOriginalNotionalPercentageOutstanding = val; }

        public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding Get(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) { return IsSetUnderlyingOriginalNotionalPercentageOutstanding(); }

        public bool IsSetUnderlyingOriginalNotionalPercentageOutstanding() { return IsSetField(Tags.UnderlyingOriginalNotionalPercentageOutstanding); }

        public QuickFix.Fields.UnderlyingAttachmentPoint UnderlyingAttachmentPoint
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingAttachmentPoint();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingAttachmentPoint val) { this.UnderlyingAttachmentPoint = val; }

        public QuickFix.Fields.UnderlyingAttachmentPoint Get(QuickFix.Fields.UnderlyingAttachmentPoint val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingAttachmentPoint val) { return IsSetUnderlyingAttachmentPoint(); }

        public bool IsSetUnderlyingAttachmentPoint() { return IsSetField(Tags.UnderlyingAttachmentPoint); }

        public QuickFix.Fields.UnderlyingDetachmentPoint UnderlyingDetachmentPoint
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingDetachmentPoint();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingDetachmentPoint val) { this.UnderlyingDetachmentPoint = val; }

        public QuickFix.Fields.UnderlyingDetachmentPoint Get(QuickFix.Fields.UnderlyingDetachmentPoint val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingDetachmentPoint val) { return IsSetUnderlyingDetachmentPoint(); }

        public bool IsSetUnderlyingDetachmentPoint() { return IsSetField(Tags.UnderlyingDetachmentPoint); }


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
            public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

            public NoUndlyInstrumentPartiesGroup() : base(Tags.NoUndlyInstrumentParties, Tags.UnderlyingInstrumentPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingInstrumentPartyID UnderlyingInstrumentPartyID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingInstrumentPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyID val) { this.UnderlyingInstrumentPartyID = val; }

        public QuickFix.Fields.UnderlyingInstrumentPartyID Get(QuickFix.Fields.UnderlyingInstrumentPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyID val) { return IsSetUnderlyingInstrumentPartyID(); }

        public bool IsSetUnderlyingInstrumentPartyID() { return IsSetField(Tags.UnderlyingInstrumentPartyID); }

        public QuickFix.Fields.UnderlyingInstrumentPartyIDSource UnderlyingInstrumentPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingInstrumentPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) { this.UnderlyingInstrumentPartyIDSource = val; }

        public QuickFix.Fields.UnderlyingInstrumentPartyIDSource Get(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) { return IsSetUnderlyingInstrumentPartyIDSource(); }

        public bool IsSetUnderlyingInstrumentPartyIDSource() { return IsSetField(Tags.UnderlyingInstrumentPartyIDSource); }

        public QuickFix.Fields.UnderlyingInstrumentPartyRole UnderlyingInstrumentPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingInstrumentPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyRole val) { this.UnderlyingInstrumentPartyRole = val; }

        public QuickFix.Fields.UnderlyingInstrumentPartyRole Get(QuickFix.Fields.UnderlyingInstrumentPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyRole val) { return IsSetUnderlyingInstrumentPartyRole(); }

        public bool IsSetUnderlyingInstrumentPartyRole() { return IsSetField(Tags.UnderlyingInstrumentPartyRole); }

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
            public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0};

            public NoUndlyInstrumentPartySubIDsGroup() : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UnderlyingInstrumentPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingInstrumentPartySubID UnderlyingInstrumentPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingInstrumentPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingInstrumentPartySubID val) { this.UnderlyingInstrumentPartySubID = val; }

        public QuickFix.Fields.UnderlyingInstrumentPartySubID Get(QuickFix.Fields.UnderlyingInstrumentPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartySubID val) { return IsSetUnderlyingInstrumentPartySubID(); }

        public bool IsSetUnderlyingInstrumentPartySubID() { return IsSetField(Tags.UnderlyingInstrumentPartySubID); }

        public QuickFix.Fields.UnderlyingInstrumentPartySubIDType UnderlyingInstrumentPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingInstrumentPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) { this.UnderlyingInstrumentPartySubIDType = val; }

        public QuickFix.Fields.UnderlyingInstrumentPartySubIDType Get(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) { return IsSetUnderlyingInstrumentPartySubIDType(); }

        public bool IsSetUnderlyingInstrumentPartySubIDType() { return IsSetField(Tags.UnderlyingInstrumentPartySubIDType); }


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


        public class NoLegsGroup : Group
        {
            public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, Tags.LegContractMultiplierUnit, Tags.LegFlowScheduleType, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegReportID, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, Tags.LegNumber, Tags.NoOfLegUnderlyings, Tags.LegVolatility, Tags.LegDividendYield, Tags.LegCurrencyRatio, Tags.LegExecInst, Tags.LegLastQty, 0};

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

        public QuickFix.Fields.LegOptionRatio LegOptionRatio
        {
            get
            {
                var val = new QuickFix.Fields.LegOptionRatio();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegOptionRatio val) { this.LegOptionRatio = val; }

        public QuickFix.Fields.LegOptionRatio Get(QuickFix.Fields.LegOptionRatio val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegOptionRatio val) { return IsSetLegOptionRatio(); }

        public bool IsSetLegOptionRatio() { return IsSetField(Tags.LegOptionRatio); }

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

        public QuickFix.Fields.LegMaturityTime LegMaturityTime
        {
            get
            {
                var val = new QuickFix.Fields.LegMaturityTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegMaturityTime val) { this.LegMaturityTime = val; }

        public QuickFix.Fields.LegMaturityTime Get(QuickFix.Fields.LegMaturityTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegMaturityTime val) { return IsSetLegMaturityTime(); }

        public bool IsSetLegMaturityTime() { return IsSetField(Tags.LegMaturityTime); }

        public QuickFix.Fields.LegPutOrCall LegPutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.LegPutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegPutOrCall val) { this.LegPutOrCall = val; }

        public QuickFix.Fields.LegPutOrCall Get(QuickFix.Fields.LegPutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegPutOrCall val) { return IsSetLegPutOrCall(); }

        public bool IsSetLegPutOrCall() { return IsSetField(Tags.LegPutOrCall); }

        public QuickFix.Fields.LegExerciseStyle LegExerciseStyle
        {
            get
            {
                var val = new QuickFix.Fields.LegExerciseStyle();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegExerciseStyle val) { this.LegExerciseStyle = val; }

        public QuickFix.Fields.LegExerciseStyle Get(QuickFix.Fields.LegExerciseStyle val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegExerciseStyle val) { return IsSetLegExerciseStyle(); }

        public bool IsSetLegExerciseStyle() { return IsSetField(Tags.LegExerciseStyle); }

        public QuickFix.Fields.LegUnitOfMeasureQty LegUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.LegUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegUnitOfMeasureQty val) { this.LegUnitOfMeasureQty = val; }

        public QuickFix.Fields.LegUnitOfMeasureQty Get(QuickFix.Fields.LegUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegUnitOfMeasureQty val) { return IsSetLegUnitOfMeasureQty(); }

        public bool IsSetLegUnitOfMeasureQty() { return IsSetField(Tags.LegUnitOfMeasureQty); }

        public QuickFix.Fields.LegPriceUnitOfMeasure LegPriceUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegPriceUnitOfMeasure val) { this.LegPriceUnitOfMeasure = val; }

        public QuickFix.Fields.LegPriceUnitOfMeasure Get(QuickFix.Fields.LegPriceUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasure val) { return IsSetLegPriceUnitOfMeasure(); }

        public bool IsSetLegPriceUnitOfMeasure() { return IsSetField(Tags.LegPriceUnitOfMeasure); }

        public QuickFix.Fields.LegPriceUnitOfMeasureQty LegPriceUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) { this.LegPriceUnitOfMeasureQty = val; }

        public QuickFix.Fields.LegPriceUnitOfMeasureQty Get(QuickFix.Fields.LegPriceUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) { return IsSetLegPriceUnitOfMeasureQty(); }

        public bool IsSetLegPriceUnitOfMeasureQty() { return IsSetField(Tags.LegPriceUnitOfMeasureQty); }

        public QuickFix.Fields.LegContractMultiplierUnit LegContractMultiplierUnit
        {
            get
            {
                var val = new QuickFix.Fields.LegContractMultiplierUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegContractMultiplierUnit val) { this.LegContractMultiplierUnit = val; }

        public QuickFix.Fields.LegContractMultiplierUnit Get(QuickFix.Fields.LegContractMultiplierUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegContractMultiplierUnit val) { return IsSetLegContractMultiplierUnit(); }

        public bool IsSetLegContractMultiplierUnit() { return IsSetField(Tags.LegContractMultiplierUnit); }

        public QuickFix.Fields.LegFlowScheduleType LegFlowScheduleType
        {
            get
            {
                var val = new QuickFix.Fields.LegFlowScheduleType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegFlowScheduleType val) { this.LegFlowScheduleType = val; }

        public QuickFix.Fields.LegFlowScheduleType Get(QuickFix.Fields.LegFlowScheduleType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegFlowScheduleType val) { return IsSetLegFlowScheduleType(); }

        public bool IsSetLegFlowScheduleType() { return IsSetField(Tags.LegFlowScheduleType); }

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

        public QuickFix.Fields.LegNumber LegNumber
        {
            get
            {
                var val = new QuickFix.Fields.LegNumber();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegNumber val) { this.LegNumber = val; }

        public QuickFix.Fields.LegNumber Get(QuickFix.Fields.LegNumber val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegNumber val) { return IsSetLegNumber(); }

        public bool IsSetLegNumber() { return IsSetField(Tags.LegNumber); }

        public QuickFix.Fields.NoOfLegUnderlyings NoOfLegUnderlyings
        {
            get
            {
                var val = new QuickFix.Fields.NoOfLegUnderlyings();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoOfLegUnderlyings val) { this.NoOfLegUnderlyings = val; }

        public QuickFix.Fields.NoOfLegUnderlyings Get(QuickFix.Fields.NoOfLegUnderlyings val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoOfLegUnderlyings val) { return IsSetNoOfLegUnderlyings(); }

        public bool IsSetNoOfLegUnderlyings() { return IsSetField(Tags.NoOfLegUnderlyings); }

        public QuickFix.Fields.LegVolatility LegVolatility
        {
            get
            {
                var val = new QuickFix.Fields.LegVolatility();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegVolatility val) { this.LegVolatility = val; }

        public QuickFix.Fields.LegVolatility Get(QuickFix.Fields.LegVolatility val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegVolatility val) { return IsSetLegVolatility(); }

        public bool IsSetLegVolatility() { return IsSetField(Tags.LegVolatility); }

        public QuickFix.Fields.LegDividendYield LegDividendYield
        {
            get
            {
                var val = new QuickFix.Fields.LegDividendYield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegDividendYield val) { this.LegDividendYield = val; }

        public QuickFix.Fields.LegDividendYield Get(QuickFix.Fields.LegDividendYield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegDividendYield val) { return IsSetLegDividendYield(); }

        public bool IsSetLegDividendYield() { return IsSetField(Tags.LegDividendYield); }

        public QuickFix.Fields.LegCurrencyRatio LegCurrencyRatio
        {
            get
            {
                var val = new QuickFix.Fields.LegCurrencyRatio();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCurrencyRatio val) { this.LegCurrencyRatio = val; }

        public QuickFix.Fields.LegCurrencyRatio Get(QuickFix.Fields.LegCurrencyRatio val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCurrencyRatio val) { return IsSetLegCurrencyRatio(); }

        public bool IsSetLegCurrencyRatio() { return IsSetField(Tags.LegCurrencyRatio); }

        public QuickFix.Fields.LegExecInst LegExecInst
        {
            get
            {
                var val = new QuickFix.Fields.LegExecInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegExecInst val) { this.LegExecInst = val; }

        public QuickFix.Fields.LegExecInst Get(QuickFix.Fields.LegExecInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegExecInst val) { return IsSetLegExecInst(); }

        public bool IsSetLegExecInst() { return IsSetField(Tags.LegExecInst); }

        public QuickFix.Fields.LegLastQty LegLastQty
        {
            get
            {
                var val = new QuickFix.Fields.LegLastQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegLastQty val) { this.LegLastQty = val; }

        public QuickFix.Fields.LegLastQty Get(QuickFix.Fields.LegLastQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegLastQty val) { return IsSetLegLastQty(); }

        public bool IsSetLegLastQty() { return IsSetField(Tags.LegLastQty); }


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
        public class NoOfLegUnderlyingsGroup : Group
        {
            public static int[] fieldOrder = {Tags.UnderlyingLegSymbol, Tags.UnderlyingLegSymbolSfx, Tags.UnderlyingLegSecurityID, Tags.UnderlyingLegSecurityIDSource, Tags.NoUnderlyingLegSecurityAltID, Tags.UnderlyingLegCFICode, Tags.UnderlyingLegSecurityType, Tags.UnderlyingLegSecuritySubType, Tags.UnderlyingLegMaturityMonthYear, Tags.UnderlyingLegMaturityDate, Tags.UnderlyingLegMaturityTime, Tags.UnderlyingLegStrikePrice, Tags.UnderlyingLegOptAttribute, Tags.UnderlyingLegPutOrCall, Tags.UnderlyingLegSecurityExchange, Tags.UnderlyingLegSecurityDesc, 0};

            public NoOfLegUnderlyingsGroup() : base(Tags.NoOfLegUnderlyings, Tags.UnderlyingLegSymbol, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoOfLegUnderlyingsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingLegSymbol UnderlyingLegSymbol
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSymbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSymbol val) { this.UnderlyingLegSymbol = val; }

        public QuickFix.Fields.UnderlyingLegSymbol Get(QuickFix.Fields.UnderlyingLegSymbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSymbol val) { return IsSetUnderlyingLegSymbol(); }

        public bool IsSetUnderlyingLegSymbol() { return IsSetField(Tags.UnderlyingLegSymbol); }

        public QuickFix.Fields.UnderlyingLegSymbolSfx UnderlyingLegSymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSymbolSfx val) { this.UnderlyingLegSymbolSfx = val; }

        public QuickFix.Fields.UnderlyingLegSymbolSfx Get(QuickFix.Fields.UnderlyingLegSymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSymbolSfx val) { return IsSetUnderlyingLegSymbolSfx(); }

        public bool IsSetUnderlyingLegSymbolSfx() { return IsSetField(Tags.UnderlyingLegSymbolSfx); }

        public QuickFix.Fields.UnderlyingLegSecurityID UnderlyingLegSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSecurityID val) { this.UnderlyingLegSecurityID = val; }

        public QuickFix.Fields.UnderlyingLegSecurityID Get(QuickFix.Fields.UnderlyingLegSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSecurityID val) { return IsSetUnderlyingLegSecurityID(); }

        public bool IsSetUnderlyingLegSecurityID() { return IsSetField(Tags.UnderlyingLegSecurityID); }

        public QuickFix.Fields.UnderlyingLegSecurityIDSource UnderlyingLegSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSecurityIDSource val) { this.UnderlyingLegSecurityIDSource = val; }

        public QuickFix.Fields.UnderlyingLegSecurityIDSource Get(QuickFix.Fields.UnderlyingLegSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSecurityIDSource val) { return IsSetUnderlyingLegSecurityIDSource(); }

        public bool IsSetUnderlyingLegSecurityIDSource() { return IsSetField(Tags.UnderlyingLegSecurityIDSource); }

        public QuickFix.Fields.NoUnderlyingLegSecurityAltID NoUnderlyingLegSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoUnderlyingLegSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUnderlyingLegSecurityAltID val) { this.NoUnderlyingLegSecurityAltID = val; }

        public QuickFix.Fields.NoUnderlyingLegSecurityAltID Get(QuickFix.Fields.NoUnderlyingLegSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUnderlyingLegSecurityAltID val) { return IsSetNoUnderlyingLegSecurityAltID(); }

        public bool IsSetNoUnderlyingLegSecurityAltID() { return IsSetField(Tags.NoUnderlyingLegSecurityAltID); }

        public QuickFix.Fields.UnderlyingLegCFICode UnderlyingLegCFICode
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegCFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegCFICode val) { this.UnderlyingLegCFICode = val; }

        public QuickFix.Fields.UnderlyingLegCFICode Get(QuickFix.Fields.UnderlyingLegCFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegCFICode val) { return IsSetUnderlyingLegCFICode(); }

        public bool IsSetUnderlyingLegCFICode() { return IsSetField(Tags.UnderlyingLegCFICode); }

        public QuickFix.Fields.UnderlyingLegSecurityType UnderlyingLegSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSecurityType val) { this.UnderlyingLegSecurityType = val; }

        public QuickFix.Fields.UnderlyingLegSecurityType Get(QuickFix.Fields.UnderlyingLegSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSecurityType val) { return IsSetUnderlyingLegSecurityType(); }

        public bool IsSetUnderlyingLegSecurityType() { return IsSetField(Tags.UnderlyingLegSecurityType); }

        public QuickFix.Fields.UnderlyingLegSecuritySubType UnderlyingLegSecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSecuritySubType val) { this.UnderlyingLegSecuritySubType = val; }

        public QuickFix.Fields.UnderlyingLegSecuritySubType Get(QuickFix.Fields.UnderlyingLegSecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSecuritySubType val) { return IsSetUnderlyingLegSecuritySubType(); }

        public bool IsSetUnderlyingLegSecuritySubType() { return IsSetField(Tags.UnderlyingLegSecuritySubType); }

        public QuickFix.Fields.UnderlyingLegMaturityMonthYear UnderlyingLegMaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegMaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegMaturityMonthYear val) { this.UnderlyingLegMaturityMonthYear = val; }

        public QuickFix.Fields.UnderlyingLegMaturityMonthYear Get(QuickFix.Fields.UnderlyingLegMaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegMaturityMonthYear val) { return IsSetUnderlyingLegMaturityMonthYear(); }

        public bool IsSetUnderlyingLegMaturityMonthYear() { return IsSetField(Tags.UnderlyingLegMaturityMonthYear); }

        public QuickFix.Fields.UnderlyingLegMaturityDate UnderlyingLegMaturityDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegMaturityDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegMaturityDate val) { this.UnderlyingLegMaturityDate = val; }

        public QuickFix.Fields.UnderlyingLegMaturityDate Get(QuickFix.Fields.UnderlyingLegMaturityDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegMaturityDate val) { return IsSetUnderlyingLegMaturityDate(); }

        public bool IsSetUnderlyingLegMaturityDate() { return IsSetField(Tags.UnderlyingLegMaturityDate); }

        public QuickFix.Fields.UnderlyingLegMaturityTime UnderlyingLegMaturityTime
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegMaturityTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegMaturityTime val) { this.UnderlyingLegMaturityTime = val; }

        public QuickFix.Fields.UnderlyingLegMaturityTime Get(QuickFix.Fields.UnderlyingLegMaturityTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegMaturityTime val) { return IsSetUnderlyingLegMaturityTime(); }

        public bool IsSetUnderlyingLegMaturityTime() { return IsSetField(Tags.UnderlyingLegMaturityTime); }

        public QuickFix.Fields.UnderlyingLegStrikePrice UnderlyingLegStrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegStrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegStrikePrice val) { this.UnderlyingLegStrikePrice = val; }

        public QuickFix.Fields.UnderlyingLegStrikePrice Get(QuickFix.Fields.UnderlyingLegStrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegStrikePrice val) { return IsSetUnderlyingLegStrikePrice(); }

        public bool IsSetUnderlyingLegStrikePrice() { return IsSetField(Tags.UnderlyingLegStrikePrice); }

        public QuickFix.Fields.UnderlyingLegOptAttribute UnderlyingLegOptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegOptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegOptAttribute val) { this.UnderlyingLegOptAttribute = val; }

        public QuickFix.Fields.UnderlyingLegOptAttribute Get(QuickFix.Fields.UnderlyingLegOptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegOptAttribute val) { return IsSetUnderlyingLegOptAttribute(); }

        public bool IsSetUnderlyingLegOptAttribute() { return IsSetField(Tags.UnderlyingLegOptAttribute); }

        public QuickFix.Fields.UnderlyingLegPutOrCall UnderlyingLegPutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegPutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegPutOrCall val) { this.UnderlyingLegPutOrCall = val; }

        public QuickFix.Fields.UnderlyingLegPutOrCall Get(QuickFix.Fields.UnderlyingLegPutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegPutOrCall val) { return IsSetUnderlyingLegPutOrCall(); }

        public bool IsSetUnderlyingLegPutOrCall() { return IsSetField(Tags.UnderlyingLegPutOrCall); }

        public QuickFix.Fields.UnderlyingLegSecurityExchange UnderlyingLegSecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSecurityExchange val) { this.UnderlyingLegSecurityExchange = val; }

        public QuickFix.Fields.UnderlyingLegSecurityExchange Get(QuickFix.Fields.UnderlyingLegSecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSecurityExchange val) { return IsSetUnderlyingLegSecurityExchange(); }

        public bool IsSetUnderlyingLegSecurityExchange() { return IsSetField(Tags.UnderlyingLegSecurityExchange); }

        public QuickFix.Fields.UnderlyingLegSecurityDesc UnderlyingLegSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSecurityDesc val) { this.UnderlyingLegSecurityDesc = val; }

        public QuickFix.Fields.UnderlyingLegSecurityDesc Get(QuickFix.Fields.UnderlyingLegSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSecurityDesc val) { return IsSetUnderlyingLegSecurityDesc(); }

        public bool IsSetUnderlyingLegSecurityDesc() { return IsSetField(Tags.UnderlyingLegSecurityDesc); }


        public class NoUnderlyingLegSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.UnderlyingLegSecurityAltID, Tags.UnderlyingLegSecurityAltIDSource, 0};

            public NoUnderlyingLegSecurityAltIDGroup() : base(Tags.NoUnderlyingLegSecurityAltID, Tags.UnderlyingLegSecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingLegSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingLegSecurityAltID UnderlyingLegSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSecurityAltID val) { this.UnderlyingLegSecurityAltID = val; }

        public QuickFix.Fields.UnderlyingLegSecurityAltID Get(QuickFix.Fields.UnderlyingLegSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSecurityAltID val) { return IsSetUnderlyingLegSecurityAltID(); }

        public bool IsSetUnderlyingLegSecurityAltID() { return IsSetField(Tags.UnderlyingLegSecurityAltID); }

        public QuickFix.Fields.UnderlyingLegSecurityAltIDSource UnderlyingLegSecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLegSecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLegSecurityAltIDSource val) { this.UnderlyingLegSecurityAltIDSource = val; }

        public QuickFix.Fields.UnderlyingLegSecurityAltIDSource Get(QuickFix.Fields.UnderlyingLegSecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLegSecurityAltIDSource val) { return IsSetUnderlyingLegSecurityAltIDSource(); }

        public bool IsSetUnderlyingLegSecurityAltIDSource() { return IsSetField(Tags.UnderlyingLegSecurityAltIDSource); }


        }
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


        public class NoSidesGroup : Group
        {
            public static int[] fieldOrder = {Tags.Side, Tags.NoPartyIDs, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.ComplianceID, Tags.SolicitedFlag, Tags.CustOrderCapacity, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TimeBracket, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.InterestAtMaturity, Tags.EndAccruedInterestAmt, Tags.StartCash, Tags.EndCash, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SideMultiLegReportingType, Tags.NoContAmts, Tags.NoStipulations, Tags.NoMiscFees, Tags.ExchangeRule, Tags.TradeAllocIndicator, Tags.PreallocMethod, Tags.AllocID, Tags.NoAllocs, Tags.SideLastQty, Tags.SideTradeReportID, Tags.SideFillStationCd, Tags.SideReasonCd, Tags.RptSeq, Tags.SideTrdSubTyp, Tags.NoSideTrdRegTS, Tags.SideGrossTradeAmt, Tags.AggressorIndicator, Tags.ExchangeSpecialInstructions, Tags.NetGrossInd, Tags.SideCurrency, Tags.SideSettlCurrency, Tags.NoSettlDetails, Tags.OrderCategory, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListID, Tags.RefOrderID, Tags.RefOrderIDSource, Tags.RefOrdIDReason, Tags.OrdType, Tags.Price, Tags.StopPx, Tags.ExecInst, Tags.OrdStatus, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.LeavesQty, Tags.CumQty, Tags.TimeInForce, Tags.ExpireTime, Tags.SecondaryDisplayQty, Tags.DisplayWhen, Tags.DisplayMethod, Tags.DisplayLowQty, Tags.DisplayHighQty, Tags.DisplayMinIncr, Tags.RefreshQty, Tags.DisplayQty, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.OrigCustOrderCapacity, Tags.OrderInputDevice, Tags.LotType, Tags.TransBkdTime, Tags.OrigOrdModTime, Tags.BookingType, Tags.SideExecID, Tags.OrderDelay, Tags.OrderDelayUnit, Tags.SideLiquidityInd, 0};

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

        public QuickFix.Fields.SideLastQty SideLastQty
        {
            get
            {
                var val = new QuickFix.Fields.SideLastQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideLastQty val) { this.SideLastQty = val; }

        public QuickFix.Fields.SideLastQty Get(QuickFix.Fields.SideLastQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideLastQty val) { return IsSetSideLastQty(); }

        public bool IsSetSideLastQty() { return IsSetField(Tags.SideLastQty); }

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

        public QuickFix.Fields.ExchangeSpecialInstructions ExchangeSpecialInstructions
        {
            get
            {
                var val = new QuickFix.Fields.ExchangeSpecialInstructions();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExchangeSpecialInstructions val) { this.ExchangeSpecialInstructions = val; }

        public QuickFix.Fields.ExchangeSpecialInstructions Get(QuickFix.Fields.ExchangeSpecialInstructions val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExchangeSpecialInstructions val) { return IsSetExchangeSpecialInstructions(); }

        public bool IsSetExchangeSpecialInstructions() { return IsSetField(Tags.ExchangeSpecialInstructions); }

        public QuickFix.Fields.NetGrossInd NetGrossInd
        {
            get
            {
                var val = new QuickFix.Fields.NetGrossInd();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NetGrossInd val) { this.NetGrossInd = val; }

        public QuickFix.Fields.NetGrossInd Get(QuickFix.Fields.NetGrossInd val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NetGrossInd val) { return IsSetNetGrossInd(); }

        public bool IsSetNetGrossInd() { return IsSetField(Tags.NetGrossInd); }

        public QuickFix.Fields.SideCurrency SideCurrency
        {
            get
            {
                var val = new QuickFix.Fields.SideCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideCurrency val) { this.SideCurrency = val; }

        public QuickFix.Fields.SideCurrency Get(QuickFix.Fields.SideCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideCurrency val) { return IsSetSideCurrency(); }

        public bool IsSetSideCurrency() { return IsSetField(Tags.SideCurrency); }

        public QuickFix.Fields.SideSettlCurrency SideSettlCurrency
        {
            get
            {
                var val = new QuickFix.Fields.SideSettlCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideSettlCurrency val) { this.SideSettlCurrency = val; }

        public QuickFix.Fields.SideSettlCurrency Get(QuickFix.Fields.SideSettlCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideSettlCurrency val) { return IsSetSideSettlCurrency(); }

        public bool IsSetSideSettlCurrency() { return IsSetField(Tags.SideSettlCurrency); }

        public QuickFix.Fields.NoSettlDetails NoSettlDetails
        {
            get
            {
                var val = new QuickFix.Fields.NoSettlDetails();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSettlDetails val) { this.NoSettlDetails = val; }

        public QuickFix.Fields.NoSettlDetails Get(QuickFix.Fields.NoSettlDetails val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSettlDetails val) { return IsSetNoSettlDetails(); }

        public bool IsSetNoSettlDetails() { return IsSetField(Tags.NoSettlDetails); }

        public QuickFix.Fields.OrderCategory OrderCategory
        {
            get
            {
                var val = new QuickFix.Fields.OrderCategory();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderCategory val) { this.OrderCategory = val; }

        public QuickFix.Fields.OrderCategory Get(QuickFix.Fields.OrderCategory val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderCategory val) { return IsSetOrderCategory(); }

        public bool IsSetOrderCategory() { return IsSetField(Tags.OrderCategory); }

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

        public QuickFix.Fields.RefOrderID RefOrderID
        {
            get
            {
                var val = new QuickFix.Fields.RefOrderID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefOrderID val) { this.RefOrderID = val; }

        public QuickFix.Fields.RefOrderID Get(QuickFix.Fields.RefOrderID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefOrderID val) { return IsSetRefOrderID(); }

        public bool IsSetRefOrderID() { return IsSetField(Tags.RefOrderID); }

        public QuickFix.Fields.RefOrderIDSource RefOrderIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RefOrderIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefOrderIDSource val) { this.RefOrderIDSource = val; }

        public QuickFix.Fields.RefOrderIDSource Get(QuickFix.Fields.RefOrderIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefOrderIDSource val) { return IsSetRefOrderIDSource(); }

        public bool IsSetRefOrderIDSource() { return IsSetField(Tags.RefOrderIDSource); }

        public QuickFix.Fields.RefOrdIDReason RefOrdIDReason
        {
            get
            {
                var val = new QuickFix.Fields.RefOrdIDReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefOrdIDReason val) { this.RefOrdIDReason = val; }

        public QuickFix.Fields.RefOrdIDReason Get(QuickFix.Fields.RefOrdIDReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefOrdIDReason val) { return IsSetRefOrdIDReason(); }

        public bool IsSetRefOrdIDReason() { return IsSetField(Tags.RefOrdIDReason); }

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

        public QuickFix.Fields.Price Price
        {
            get
            {
                var val = new QuickFix.Fields.Price();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Price val) { this.Price = val; }

        public QuickFix.Fields.Price Get(QuickFix.Fields.Price val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Price val) { return IsSetPrice(); }

        public bool IsSetPrice() { return IsSetField(Tags.Price); }

        public QuickFix.Fields.StopPx StopPx
        {
            get
            {
                var val = new QuickFix.Fields.StopPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StopPx val) { this.StopPx = val; }

        public QuickFix.Fields.StopPx Get(QuickFix.Fields.StopPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StopPx val) { return IsSetStopPx(); }

        public bool IsSetStopPx() { return IsSetField(Tags.StopPx); }

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

        public QuickFix.Fields.OrderQty OrderQty
        {
            get
            {
                var val = new QuickFix.Fields.OrderQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderQty val) { this.OrderQty = val; }

        public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderQty val) { return IsSetOrderQty(); }

        public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }

        public QuickFix.Fields.CashOrderQty CashOrderQty
        {
            get
            {
                var val = new QuickFix.Fields.CashOrderQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CashOrderQty val) { this.CashOrderQty = val; }

        public QuickFix.Fields.CashOrderQty Get(QuickFix.Fields.CashOrderQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CashOrderQty val) { return IsSetCashOrderQty(); }

        public bool IsSetCashOrderQty() { return IsSetField(Tags.CashOrderQty); }

        public QuickFix.Fields.OrderPercent OrderPercent
        {
            get
            {
                var val = new QuickFix.Fields.OrderPercent();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderPercent val) { this.OrderPercent = val; }

        public QuickFix.Fields.OrderPercent Get(QuickFix.Fields.OrderPercent val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderPercent val) { return IsSetOrderPercent(); }

        public bool IsSetOrderPercent() { return IsSetField(Tags.OrderPercent); }

        public QuickFix.Fields.RoundingDirection RoundingDirection
        {
            get
            {
                var val = new QuickFix.Fields.RoundingDirection();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RoundingDirection val) { this.RoundingDirection = val; }

        public QuickFix.Fields.RoundingDirection Get(QuickFix.Fields.RoundingDirection val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RoundingDirection val) { return IsSetRoundingDirection(); }

        public bool IsSetRoundingDirection() { return IsSetField(Tags.RoundingDirection); }

        public QuickFix.Fields.RoundingModulus RoundingModulus
        {
            get
            {
                var val = new QuickFix.Fields.RoundingModulus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RoundingModulus val) { this.RoundingModulus = val; }

        public QuickFix.Fields.RoundingModulus Get(QuickFix.Fields.RoundingModulus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RoundingModulus val) { return IsSetRoundingModulus(); }

        public bool IsSetRoundingModulus() { return IsSetField(Tags.RoundingModulus); }

        public QuickFix.Fields.LeavesQty LeavesQty
        {
            get
            {
                var val = new QuickFix.Fields.LeavesQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LeavesQty val) { this.LeavesQty = val; }

        public QuickFix.Fields.LeavesQty Get(QuickFix.Fields.LeavesQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LeavesQty val) { return IsSetLeavesQty(); }

        public bool IsSetLeavesQty() { return IsSetField(Tags.LeavesQty); }

        public QuickFix.Fields.CumQty CumQty
        {
            get
            {
                var val = new QuickFix.Fields.CumQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CumQty val) { this.CumQty = val; }

        public QuickFix.Fields.CumQty Get(QuickFix.Fields.CumQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CumQty val) { return IsSetCumQty(); }

        public bool IsSetCumQty() { return IsSetField(Tags.CumQty); }

        public QuickFix.Fields.TimeInForce TimeInForce
        {
            get
            {
                var val = new QuickFix.Fields.TimeInForce();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TimeInForce val) { this.TimeInForce = val; }

        public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TimeInForce val) { return IsSetTimeInForce(); }

        public bool IsSetTimeInForce() { return IsSetField(Tags.TimeInForce); }

        public QuickFix.Fields.ExpireTime ExpireTime
        {
            get
            {
                var val = new QuickFix.Fields.ExpireTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExpireTime val) { this.ExpireTime = val; }

        public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExpireTime val) { return IsSetExpireTime(); }

        public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

        public QuickFix.Fields.SecondaryDisplayQty SecondaryDisplayQty
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryDisplayQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryDisplayQty val) { this.SecondaryDisplayQty = val; }

        public QuickFix.Fields.SecondaryDisplayQty Get(QuickFix.Fields.SecondaryDisplayQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryDisplayQty val) { return IsSetSecondaryDisplayQty(); }

        public bool IsSetSecondaryDisplayQty() { return IsSetField(Tags.SecondaryDisplayQty); }

        public QuickFix.Fields.DisplayWhen DisplayWhen
        {
            get
            {
                var val = new QuickFix.Fields.DisplayWhen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DisplayWhen val) { this.DisplayWhen = val; }

        public QuickFix.Fields.DisplayWhen Get(QuickFix.Fields.DisplayWhen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DisplayWhen val) { return IsSetDisplayWhen(); }

        public bool IsSetDisplayWhen() { return IsSetField(Tags.DisplayWhen); }

        public QuickFix.Fields.DisplayMethod DisplayMethod
        {
            get
            {
                var val = new QuickFix.Fields.DisplayMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DisplayMethod val) { this.DisplayMethod = val; }

        public QuickFix.Fields.DisplayMethod Get(QuickFix.Fields.DisplayMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DisplayMethod val) { return IsSetDisplayMethod(); }

        public bool IsSetDisplayMethod() { return IsSetField(Tags.DisplayMethod); }

        public QuickFix.Fields.DisplayLowQty DisplayLowQty
        {
            get
            {
                var val = new QuickFix.Fields.DisplayLowQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DisplayLowQty val) { this.DisplayLowQty = val; }

        public QuickFix.Fields.DisplayLowQty Get(QuickFix.Fields.DisplayLowQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DisplayLowQty val) { return IsSetDisplayLowQty(); }

        public bool IsSetDisplayLowQty() { return IsSetField(Tags.DisplayLowQty); }

        public QuickFix.Fields.DisplayHighQty DisplayHighQty
        {
            get
            {
                var val = new QuickFix.Fields.DisplayHighQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DisplayHighQty val) { this.DisplayHighQty = val; }

        public QuickFix.Fields.DisplayHighQty Get(QuickFix.Fields.DisplayHighQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DisplayHighQty val) { return IsSetDisplayHighQty(); }

        public bool IsSetDisplayHighQty() { return IsSetField(Tags.DisplayHighQty); }

        public QuickFix.Fields.DisplayMinIncr DisplayMinIncr
        {
            get
            {
                var val = new QuickFix.Fields.DisplayMinIncr();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DisplayMinIncr val) { this.DisplayMinIncr = val; }

        public QuickFix.Fields.DisplayMinIncr Get(QuickFix.Fields.DisplayMinIncr val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DisplayMinIncr val) { return IsSetDisplayMinIncr(); }

        public bool IsSetDisplayMinIncr() { return IsSetField(Tags.DisplayMinIncr); }

        public QuickFix.Fields.RefreshQty RefreshQty
        {
            get
            {
                var val = new QuickFix.Fields.RefreshQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefreshQty val) { this.RefreshQty = val; }

        public QuickFix.Fields.RefreshQty Get(QuickFix.Fields.RefreshQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefreshQty val) { return IsSetRefreshQty(); }

        public bool IsSetRefreshQty() { return IsSetField(Tags.RefreshQty); }

        public QuickFix.Fields.DisplayQty DisplayQty
        {
            get
            {
                var val = new QuickFix.Fields.DisplayQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DisplayQty val) { this.DisplayQty = val; }

        public QuickFix.Fields.DisplayQty Get(QuickFix.Fields.DisplayQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DisplayQty val) { return IsSetDisplayQty(); }

        public bool IsSetDisplayQty() { return IsSetField(Tags.DisplayQty); }

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

        public QuickFix.Fields.OrigCustOrderCapacity OrigCustOrderCapacity
        {
            get
            {
                var val = new QuickFix.Fields.OrigCustOrderCapacity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigCustOrderCapacity val) { this.OrigCustOrderCapacity = val; }

        public QuickFix.Fields.OrigCustOrderCapacity Get(QuickFix.Fields.OrigCustOrderCapacity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigCustOrderCapacity val) { return IsSetOrigCustOrderCapacity(); }

        public bool IsSetOrigCustOrderCapacity() { return IsSetField(Tags.OrigCustOrderCapacity); }

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

        public QuickFix.Fields.OrigOrdModTime OrigOrdModTime
        {
            get
            {
                var val = new QuickFix.Fields.OrigOrdModTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigOrdModTime val) { this.OrigOrdModTime = val; }

        public QuickFix.Fields.OrigOrdModTime Get(QuickFix.Fields.OrigOrdModTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigOrdModTime val) { return IsSetOrigOrdModTime(); }

        public bool IsSetOrigOrdModTime() { return IsSetField(Tags.OrigOrdModTime); }

        public QuickFix.Fields.BookingType BookingType
        {
            get
            {
                var val = new QuickFix.Fields.BookingType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BookingType val) { this.BookingType = val; }

        public QuickFix.Fields.BookingType Get(QuickFix.Fields.BookingType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BookingType val) { return IsSetBookingType(); }

        public bool IsSetBookingType() { return IsSetField(Tags.BookingType); }

        public QuickFix.Fields.SideExecID SideExecID
        {
            get
            {
                var val = new QuickFix.Fields.SideExecID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideExecID val) { this.SideExecID = val; }

        public QuickFix.Fields.SideExecID Get(QuickFix.Fields.SideExecID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideExecID val) { return IsSetSideExecID(); }

        public bool IsSetSideExecID() { return IsSetField(Tags.SideExecID); }

        public QuickFix.Fields.OrderDelay OrderDelay
        {
            get
            {
                var val = new QuickFix.Fields.OrderDelay();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderDelay val) { this.OrderDelay = val; }

        public QuickFix.Fields.OrderDelay Get(QuickFix.Fields.OrderDelay val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderDelay val) { return IsSetOrderDelay(); }

        public bool IsSetOrderDelay() { return IsSetField(Tags.OrderDelay); }

        public QuickFix.Fields.OrderDelayUnit OrderDelayUnit
        {
            get
            {
                var val = new QuickFix.Fields.OrderDelayUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderDelayUnit val) { this.OrderDelayUnit = val; }

        public QuickFix.Fields.OrderDelayUnit Get(QuickFix.Fields.OrderDelayUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderDelayUnit val) { return IsSetOrderDelayUnit(); }

        public bool IsSetOrderDelayUnit() { return IsSetField(Tags.OrderDelayUnit); }

        public QuickFix.Fields.SideLiquidityInd SideLiquidityInd
        {
            get
            {
                var val = new QuickFix.Fields.SideLiquidityInd();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SideLiquidityInd val) { this.SideLiquidityInd = val; }

        public QuickFix.Fields.SideLiquidityInd Get(QuickFix.Fields.SideLiquidityInd val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SideLiquidityInd val) { return IsSetSideLiquidityInd(); }

        public bool IsSetSideLiquidityInd() { return IsSetField(Tags.SideLiquidityInd); }


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
        public class NoSettlDetailsGroup : Group
        {
            public static int[] fieldOrder = {Tags.SettlObligSource, Tags.NoSettlPartyIDs, 0};

            public NoSettlDetailsGroup() : base(Tags.NoSettlDetails, Tags.SettlObligSource, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSettlDetailsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SettlObligSource SettlObligSource
        {
            get
            {
                var val = new QuickFix.Fields.SettlObligSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlObligSource val) { this.SettlObligSource = val; }

        public QuickFix.Fields.SettlObligSource Get(QuickFix.Fields.SettlObligSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlObligSource val) { return IsSetSettlObligSource(); }

        public bool IsSetSettlObligSource() { return IsSetField(Tags.SettlObligSource); }

        public QuickFix.Fields.NoSettlPartyIDs NoSettlPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoSettlPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSettlPartyIDs val) { this.NoSettlPartyIDs = val; }

        public QuickFix.Fields.NoSettlPartyIDs Get(QuickFix.Fields.NoSettlPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSettlPartyIDs val) { return IsSetNoSettlPartyIDs(); }

        public bool IsSetNoSettlPartyIDs() { return IsSetField(Tags.NoSettlPartyIDs); }


        public class NoSettlPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};

            public NoSettlPartyIDsGroup() : base(Tags.NoSettlPartyIDs, Tags.SettlPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSettlPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SettlPartyID SettlPartyID
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartyID val) { this.SettlPartyID = val; }

        public QuickFix.Fields.SettlPartyID Get(QuickFix.Fields.SettlPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartyID val) { return IsSetSettlPartyID(); }

        public bool IsSetSettlPartyID() { return IsSetField(Tags.SettlPartyID); }

        public QuickFix.Fields.SettlPartyIDSource SettlPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartyIDSource val) { this.SettlPartyIDSource = val; }

        public QuickFix.Fields.SettlPartyIDSource Get(QuickFix.Fields.SettlPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartyIDSource val) { return IsSetSettlPartyIDSource(); }

        public bool IsSetSettlPartyIDSource() { return IsSetField(Tags.SettlPartyIDSource); }

        public QuickFix.Fields.SettlPartyRole SettlPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartyRole val) { this.SettlPartyRole = val; }

        public QuickFix.Fields.SettlPartyRole Get(QuickFix.Fields.SettlPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartyRole val) { return IsSetSettlPartyRole(); }

        public bool IsSetSettlPartyRole() { return IsSetField(Tags.SettlPartyRole); }

        public QuickFix.Fields.NoSettlPartySubIDs NoSettlPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoSettlPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSettlPartySubIDs val) { this.NoSettlPartySubIDs = val; }

        public QuickFix.Fields.NoSettlPartySubIDs Get(QuickFix.Fields.NoSettlPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSettlPartySubIDs val) { return IsSetNoSettlPartySubIDs(); }

        public bool IsSetNoSettlPartySubIDs() { return IsSetField(Tags.NoSettlPartySubIDs); }


        public class NoSettlPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};

            public NoSettlPartySubIDsGroup() : base(Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSettlPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SettlPartySubID SettlPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartySubID val) { this.SettlPartySubID = val; }

        public QuickFix.Fields.SettlPartySubID Get(QuickFix.Fields.SettlPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartySubID val) { return IsSetSettlPartySubID(); }

        public bool IsSetSettlPartySubID() { return IsSetField(Tags.SettlPartySubID); }

        public QuickFix.Fields.SettlPartySubIDType SettlPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartySubIDType val) { this.SettlPartySubIDType = val; }

        public QuickFix.Fields.SettlPartySubIDType Get(QuickFix.Fields.SettlPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartySubIDType val) { return IsSetSettlPartySubIDType(); }

        public bool IsSetSettlPartySubIDType() { return IsSetField(Tags.SettlPartySubIDType); }


        }
        }
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


        public class NoTrdRepIndicatorsGroup : Group
        {
            public static int[] fieldOrder = {Tags.TrdRepPartyRole, Tags.TrdRepIndicator, 0};

            public NoTrdRepIndicatorsGroup() : base(Tags.NoTrdRepIndicators, Tags.TrdRepPartyRole, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoTrdRepIndicatorsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.TrdRepPartyRole TrdRepPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.TrdRepPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdRepPartyRole val) { this.TrdRepPartyRole = val; }

        public QuickFix.Fields.TrdRepPartyRole Get(QuickFix.Fields.TrdRepPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdRepPartyRole val) { return IsSetTrdRepPartyRole(); }

        public bool IsSetTrdRepPartyRole() { return IsSetField(Tags.TrdRepPartyRole); }

        public QuickFix.Fields.TrdRepIndicator TrdRepIndicator
        {
            get
            {
                var val = new QuickFix.Fields.TrdRepIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TrdRepIndicator val) { this.TrdRepIndicator = val; }

        public QuickFix.Fields.TrdRepIndicator Get(QuickFix.Fields.TrdRepIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TrdRepIndicator val) { return IsSetTrdRepIndicator(); }

        public bool IsSetTrdRepIndicator() { return IsSetField(Tags.TrdRepIndicator); }


        }


    }
}
