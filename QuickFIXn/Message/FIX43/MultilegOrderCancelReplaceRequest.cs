using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class MultilegOrderCancelReplaceRequest : Message
    {
        public const string MsgType = "AC";

        public MultilegOrderCancelReplaceRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public MultilegOrderCancelReplaceRequest(QuickFix.Fields.OrigClOrdID aOrigClOrdID,
				QuickFix.Fields.ClOrdID aClOrdID,
				QuickFix.Fields.HandlInst aHandlInst,
				QuickFix.Fields.Side aSide,
				QuickFix.Fields.Symbol aSymbol,
				QuickFix.Fields.TransactTime aTransactTime,
				QuickFix.Fields.OrdType aOrdType)
               : this()
        {
            this.OrigClOrdID = aOrigClOrdID;
			this.ClOrdID = aClOrdID;
			this.HandlInst = aHandlInst;
			this.Side = aSide;
			this.Symbol = aSymbol;
			this.TransactTime = aTransactTime;
			this.OrdType = aOrdType;
        }

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

        public QuickFix.Fields.OrigClOrdID OrigClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.OrigClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigClOrdID val) { this.OrigClOrdID = val; }

        public QuickFix.Fields.OrigClOrdID Get(QuickFix.Fields.OrigClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigClOrdID val) { return IsSetOrigClOrdID(); }

        public bool IsSetOrigClOrdID() { return IsSetField(Tags.OrigClOrdID); }

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

        public QuickFix.Fields.ClOrdLinkID ClOrdLinkID
        {
            get
            {
                var val = new QuickFix.Fields.ClOrdLinkID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClOrdLinkID val) { this.ClOrdLinkID = val; }

        public QuickFix.Fields.ClOrdLinkID Get(QuickFix.Fields.ClOrdLinkID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClOrdLinkID val) { return IsSetClOrdLinkID(); }

        public bool IsSetClOrdLinkID() { return IsSetField(Tags.ClOrdLinkID); }

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

        public QuickFix.Fields.DayBookingInst DayBookingInst
        {
            get
            {
                var val = new QuickFix.Fields.DayBookingInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DayBookingInst val) { this.DayBookingInst = val; }

        public QuickFix.Fields.DayBookingInst Get(QuickFix.Fields.DayBookingInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DayBookingInst val) { return IsSetDayBookingInst(); }

        public bool IsSetDayBookingInst() { return IsSetField(Tags.DayBookingInst); }

        public QuickFix.Fields.BookingUnit BookingUnit
        {
            get
            {
                var val = new QuickFix.Fields.BookingUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BookingUnit val) { this.BookingUnit = val; }

        public QuickFix.Fields.BookingUnit Get(QuickFix.Fields.BookingUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BookingUnit val) { return IsSetBookingUnit(); }

        public bool IsSetBookingUnit() { return IsSetField(Tags.BookingUnit); }

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

        public QuickFix.Fields.SettlmntTyp SettlmntTyp
        {
            get
            {
                var val = new QuickFix.Fields.SettlmntTyp();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlmntTyp val) { this.SettlmntTyp = val; }

        public QuickFix.Fields.SettlmntTyp Get(QuickFix.Fields.SettlmntTyp val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlmntTyp val) { return IsSetSettlmntTyp(); }

        public bool IsSetSettlmntTyp() { return IsSetField(Tags.SettlmntTyp); }

        public QuickFix.Fields.FutSettDate FutSettDate
        {
            get
            {
                var val = new QuickFix.Fields.FutSettDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FutSettDate val) { this.FutSettDate = val; }

        public QuickFix.Fields.FutSettDate Get(QuickFix.Fields.FutSettDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FutSettDate val) { return IsSetFutSettDate(); }

        public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

        public QuickFix.Fields.CashMargin CashMargin
        {
            get
            {
                var val = new QuickFix.Fields.CashMargin();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CashMargin val) { this.CashMargin = val; }

        public QuickFix.Fields.CashMargin Get(QuickFix.Fields.CashMargin val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CashMargin val) { return IsSetCashMargin(); }

        public bool IsSetCashMargin() { return IsSetField(Tags.CashMargin); }

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

        public QuickFix.Fields.HandlInst HandlInst
        {
            get
            {
                var val = new QuickFix.Fields.HandlInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.HandlInst val) { this.HandlInst = val; }

        public QuickFix.Fields.HandlInst Get(QuickFix.Fields.HandlInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.HandlInst val) { return IsSetHandlInst(); }

        public bool IsSetHandlInst() { return IsSetField(Tags.HandlInst); }

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

        public QuickFix.Fields.MinQty MinQty
        {
            get
            {
                var val = new QuickFix.Fields.MinQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MinQty val) { this.MinQty = val; }

        public QuickFix.Fields.MinQty Get(QuickFix.Fields.MinQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MinQty val) { return IsSetMinQty(); }

        public bool IsSetMinQty() { return IsSetField(Tags.MinQty); }

        public QuickFix.Fields.MaxFloor MaxFloor
        {
            get
            {
                var val = new QuickFix.Fields.MaxFloor();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaxFloor val) { this.MaxFloor = val; }

        public QuickFix.Fields.MaxFloor Get(QuickFix.Fields.MaxFloor val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaxFloor val) { return IsSetMaxFloor(); }

        public bool IsSetMaxFloor() { return IsSetField(Tags.MaxFloor); }

        public QuickFix.Fields.ExDestination ExDestination
        {
            get
            {
                var val = new QuickFix.Fields.ExDestination();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExDestination val) { this.ExDestination = val; }

        public QuickFix.Fields.ExDestination Get(QuickFix.Fields.ExDestination val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExDestination val) { return IsSetExDestination(); }

        public bool IsSetExDestination() { return IsSetField(Tags.ExDestination); }

        public QuickFix.Fields.NoTradingSessions NoTradingSessions
        {
            get
            {
                var val = new QuickFix.Fields.NoTradingSessions();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoTradingSessions val) { this.NoTradingSessions = val; }

        public QuickFix.Fields.NoTradingSessions Get(QuickFix.Fields.NoTradingSessions val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoTradingSessions val) { return IsSetNoTradingSessions(); }

        public bool IsSetNoTradingSessions() { return IsSetField(Tags.NoTradingSessions); }

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

        public QuickFix.Fields.PrevClosePx PrevClosePx
        {
            get
            {
                var val = new QuickFix.Fields.PrevClosePx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PrevClosePx val) { this.PrevClosePx = val; }

        public QuickFix.Fields.PrevClosePx Get(QuickFix.Fields.PrevClosePx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PrevClosePx val) { return IsSetPrevClosePx(); }

        public bool IsSetPrevClosePx() { return IsSetField(Tags.PrevClosePx); }

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

        public QuickFix.Fields.LocateReqd LocateReqd
        {
            get
            {
                var val = new QuickFix.Fields.LocateReqd();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LocateReqd val) { this.LocateReqd = val; }

        public QuickFix.Fields.LocateReqd Get(QuickFix.Fields.LocateReqd val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LocateReqd val) { return IsSetLocateReqd(); }

        public bool IsSetLocateReqd() { return IsSetField(Tags.LocateReqd); }

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

        public QuickFix.Fields.QuantityType QuantityType
        {
            get
            {
                var val = new QuickFix.Fields.QuantityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuantityType val) { this.QuantityType = val; }

        public QuickFix.Fields.QuantityType Get(QuickFix.Fields.QuantityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuantityType val) { return IsSetQuantityType(); }

        public bool IsSetQuantityType() { return IsSetField(Tags.QuantityType); }

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

        public QuickFix.Fields.IOIid IOIid
        {
            get
            {
                var val = new QuickFix.Fields.IOIid();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IOIid val) { this.IOIid = val; }

        public QuickFix.Fields.IOIid Get(QuickFix.Fields.IOIid val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IOIid val) { return IsSetIOIid(); }

        public bool IsSetIOIid() { return IsSetField(Tags.IOIid); }

        public QuickFix.Fields.QuoteID QuoteID
        {
            get
            {
                var val = new QuickFix.Fields.QuoteID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteID val) { this.QuoteID = val; }

        public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteID val) { return IsSetQuoteID(); }

        public bool IsSetQuoteID() { return IsSetField(Tags.QuoteID); }

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

        public QuickFix.Fields.EffectiveTime EffectiveTime
        {
            get
            {
                var val = new QuickFix.Fields.EffectiveTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EffectiveTime val) { this.EffectiveTime = val; }

        public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EffectiveTime val) { return IsSetEffectiveTime(); }

        public bool IsSetEffectiveTime() { return IsSetField(Tags.EffectiveTime); }

        public QuickFix.Fields.ExpireDate ExpireDate
        {
            get
            {
                var val = new QuickFix.Fields.ExpireDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExpireDate val) { this.ExpireDate = val; }

        public QuickFix.Fields.ExpireDate Get(QuickFix.Fields.ExpireDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExpireDate val) { return IsSetExpireDate(); }

        public bool IsSetExpireDate() { return IsSetField(Tags.ExpireDate); }

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

        public QuickFix.Fields.GTBookingInst GTBookingInst
        {
            get
            {
                var val = new QuickFix.Fields.GTBookingInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.GTBookingInst val) { this.GTBookingInst = val; }

        public QuickFix.Fields.GTBookingInst Get(QuickFix.Fields.GTBookingInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.GTBookingInst val) { return IsSetGTBookingInst(); }

        public bool IsSetGTBookingInst() { return IsSetField(Tags.GTBookingInst); }

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

        public QuickFix.Fields.ForexReq ForexReq
        {
            get
            {
                var val = new QuickFix.Fields.ForexReq();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ForexReq val) { this.ForexReq = val; }

        public QuickFix.Fields.ForexReq Get(QuickFix.Fields.ForexReq val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ForexReq val) { return IsSetForexReq(); }

        public bool IsSetForexReq() { return IsSetField(Tags.ForexReq); }

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

        public QuickFix.Fields.CoveredOrUncovered CoveredOrUncovered
        {
            get
            {
                var val = new QuickFix.Fields.CoveredOrUncovered();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CoveredOrUncovered val) { this.CoveredOrUncovered = val; }

        public QuickFix.Fields.CoveredOrUncovered Get(QuickFix.Fields.CoveredOrUncovered val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CoveredOrUncovered val) { return IsSetCoveredOrUncovered(); }

        public bool IsSetCoveredOrUncovered() { return IsSetField(Tags.CoveredOrUncovered); }

        public QuickFix.Fields.MaxShow MaxShow
        {
            get
            {
                var val = new QuickFix.Fields.MaxShow();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaxShow val) { this.MaxShow = val; }

        public QuickFix.Fields.MaxShow Get(QuickFix.Fields.MaxShow val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaxShow val) { return IsSetMaxShow(); }

        public bool IsSetMaxShow() { return IsSetField(Tags.MaxShow); }

        public QuickFix.Fields.PegDifference PegDifference
        {
            get
            {
                var val = new QuickFix.Fields.PegDifference();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PegDifference val) { this.PegDifference = val; }

        public QuickFix.Fields.PegDifference Get(QuickFix.Fields.PegDifference val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PegDifference val) { return IsSetPegDifference(); }

        public bool IsSetPegDifference() { return IsSetField(Tags.PegDifference); }

        public QuickFix.Fields.DiscretionInst DiscretionInst
        {
            get
            {
                var val = new QuickFix.Fields.DiscretionInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DiscretionInst val) { this.DiscretionInst = val; }

        public QuickFix.Fields.DiscretionInst Get(QuickFix.Fields.DiscretionInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DiscretionInst val) { return IsSetDiscretionInst(); }

        public bool IsSetDiscretionInst() { return IsSetField(Tags.DiscretionInst); }

        public QuickFix.Fields.DiscretionOffset DiscretionOffset
        {
            get
            {
                var val = new QuickFix.Fields.DiscretionOffset();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DiscretionOffset val) { this.DiscretionOffset = val; }

        public QuickFix.Fields.DiscretionOffset Get(QuickFix.Fields.DiscretionOffset val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DiscretionOffset val) { return IsSetDiscretionOffset(); }

        public bool IsSetDiscretionOffset() { return IsSetField(Tags.DiscretionOffset); }

        public QuickFix.Fields.CancellationRights CancellationRights
        {
            get
            {
                var val = new QuickFix.Fields.CancellationRights();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CancellationRights val) { this.CancellationRights = val; }

        public QuickFix.Fields.CancellationRights Get(QuickFix.Fields.CancellationRights val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CancellationRights val) { return IsSetCancellationRights(); }

        public bool IsSetCancellationRights() { return IsSetField(Tags.CancellationRights); }

        public QuickFix.Fields.MoneyLaunderingStatus MoneyLaunderingStatus
        {
            get
            {
                var val = new QuickFix.Fields.MoneyLaunderingStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MoneyLaunderingStatus val) { this.MoneyLaunderingStatus = val; }

        public QuickFix.Fields.MoneyLaunderingStatus Get(QuickFix.Fields.MoneyLaunderingStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MoneyLaunderingStatus val) { return IsSetMoneyLaunderingStatus(); }

        public bool IsSetMoneyLaunderingStatus() { return IsSetField(Tags.MoneyLaunderingStatus); }

        public QuickFix.Fields.RegistID RegistID
        {
            get
            {
                var val = new QuickFix.Fields.RegistID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RegistID val) { this.RegistID = val; }

        public QuickFix.Fields.RegistID Get(QuickFix.Fields.RegistID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RegistID val) { return IsSetRegistID(); }

        public bool IsSetRegistID() { return IsSetField(Tags.RegistID); }

        public QuickFix.Fields.Designation Designation
        {
            get
            {
                var val = new QuickFix.Fields.Designation();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Designation val) { this.Designation = val; }

        public QuickFix.Fields.Designation Get(QuickFix.Fields.Designation val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Designation val) { return IsSetDesignation(); }

        public bool IsSetDesignation() { return IsSetField(Tags.Designation); }

        public QuickFix.Fields.MultiLegRptTypeReq MultiLegRptTypeReq
        {
            get
            {
                var val = new QuickFix.Fields.MultiLegRptTypeReq();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MultiLegRptTypeReq val) { this.MultiLegRptTypeReq = val; }

        public QuickFix.Fields.MultiLegRptTypeReq Get(QuickFix.Fields.MultiLegRptTypeReq val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MultiLegRptTypeReq val) { return IsSetMultiLegRptTypeReq(); }

        public bool IsSetMultiLegRptTypeReq() { return IsSetField(Tags.MultiLegRptTypeReq); }

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


        public class NoPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};

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


        }


        public class NoAllocsGroup : Group
        {
            public static int[] fieldOrder = {Tags.AllocAccount, Tags.IndividualAllocID, Tags.AllocQty, 0};

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


        }


        public class NoTradingSessionsGroup : Group
        {
            public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, 0};

            public NoTradingSessionsGroup() : base(Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
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


        }


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


        public class NoLegsGroup : Group
        {
            public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegPrice, Tags.LegSettlmntTyp, Tags.LegFutSettDate, 0};

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

        public QuickFix.Fields.LegSettlmntTyp LegSettlmntTyp
        {
            get
            {
                var val = new QuickFix.Fields.LegSettlmntTyp();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSettlmntTyp val) { this.LegSettlmntTyp = val; }

        public QuickFix.Fields.LegSettlmntTyp Get(QuickFix.Fields.LegSettlmntTyp val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSettlmntTyp val) { return IsSetLegSettlmntTyp(); }

        public bool IsSetLegSettlmntTyp() { return IsSetField(Tags.LegSettlmntTyp); }

        public QuickFix.Fields.LegFutSettDate LegFutSettDate
        {
            get
            {
                var val = new QuickFix.Fields.LegFutSettDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegFutSettDate val) { this.LegFutSettDate = val; }

        public QuickFix.Fields.LegFutSettDate Get(QuickFix.Fields.LegFutSettDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegFutSettDate val) { return IsSetLegFutSettDate(); }

        public bool IsSetLegFutSettDate() { return IsSetField(Tags.LegFutSettDate); }


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
        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NestedPartySubID, 0};

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


        }
        }


    }
}
