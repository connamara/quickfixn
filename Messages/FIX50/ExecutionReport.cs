// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50;

public class ExecutionReport : Message
{
    public const string MsgType = "8";

    public ExecutionReport() : base()
    {
        Header.SetField(new MsgType("8"));
    }

    public ExecutionReport(
            OrderID aOrderID,
            ExecID aExecID,
            ExecType aExecType,
            OrdStatus aOrdStatus,
            Side aSide,
            LeavesQty aLeavesQty,
            CumQty aCumQty
        ) : this()
    {
        OrderID = aOrderID;
        ExecID = aExecID;
        ExecType = aExecType;
        OrdStatus = aOrdStatus;
        Side = aSide;
        LeavesQty = aLeavesQty;
        CumQty = aCumQty;
    }

    public OrderID OrderID
    {
        get
        {
            OrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderID val) { OrderID = val; }
    public OrderID Get(OrderID val) { GetField(val); return val; }
    public bool IsSet(OrderID val) { return IsSetOrderID(); }
    public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

    public SecondaryOrderID SecondaryOrderID
    {
        get
        {
            SecondaryOrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryOrderID val) { SecondaryOrderID = val; }
    public SecondaryOrderID Get(SecondaryOrderID val) { GetField(val); return val; }
    public bool IsSet(SecondaryOrderID val) { return IsSetSecondaryOrderID(); }
    public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }

    public SecondaryClOrdID SecondaryClOrdID
    {
        get
        {
            SecondaryClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryClOrdID val) { SecondaryClOrdID = val; }
    public SecondaryClOrdID Get(SecondaryClOrdID val) { GetField(val); return val; }
    public bool IsSet(SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }
    public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

    public SecondaryExecID SecondaryExecID
    {
        get
        {
            SecondaryExecID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryExecID val) { SecondaryExecID = val; }
    public SecondaryExecID Get(SecondaryExecID val) { GetField(val); return val; }
    public bool IsSet(SecondaryExecID val) { return IsSetSecondaryExecID(); }
    public bool IsSetSecondaryExecID() { return IsSetField(Tags.SecondaryExecID); }

    public ClOrdID ClOrdID
    {
        get
        {
            ClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdID val) { ClOrdID = val; }
    public ClOrdID Get(ClOrdID val) { GetField(val); return val; }
    public bool IsSet(ClOrdID val) { return IsSetClOrdID(); }
    public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

    public OrigClOrdID OrigClOrdID
    {
        get
        {
            OrigClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigClOrdID val) { OrigClOrdID = val; }
    public OrigClOrdID Get(OrigClOrdID val) { GetField(val); return val; }
    public bool IsSet(OrigClOrdID val) { return IsSetOrigClOrdID(); }
    public bool IsSetOrigClOrdID() { return IsSetField(Tags.OrigClOrdID); }

    public ClOrdLinkID ClOrdLinkID
    {
        get
        {
            ClOrdLinkID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdLinkID val) { ClOrdLinkID = val; }
    public ClOrdLinkID Get(ClOrdLinkID val) { GetField(val); return val; }
    public bool IsSet(ClOrdLinkID val) { return IsSetClOrdLinkID(); }
    public bool IsSetClOrdLinkID() { return IsSetField(Tags.ClOrdLinkID); }

    public QuoteRespID QuoteRespID
    {
        get
        {
            QuoteRespID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteRespID val) { QuoteRespID = val; }
    public QuoteRespID Get(QuoteRespID val) { GetField(val); return val; }
    public bool IsSet(QuoteRespID val) { return IsSetQuoteRespID(); }
    public bool IsSetQuoteRespID() { return IsSetField(Tags.QuoteRespID); }

    public OrdStatusReqID OrdStatusReqID
    {
        get
        {
            OrdStatusReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdStatusReqID val) { OrdStatusReqID = val; }
    public OrdStatusReqID Get(OrdStatusReqID val) { GetField(val); return val; }
    public bool IsSet(OrdStatusReqID val) { return IsSetOrdStatusReqID(); }
    public bool IsSetOrdStatusReqID() { return IsSetField(Tags.OrdStatusReqID); }

    public MassStatusReqID MassStatusReqID
    {
        get
        {
            MassStatusReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MassStatusReqID val) { MassStatusReqID = val; }
    public MassStatusReqID Get(MassStatusReqID val) { GetField(val); return val; }
    public bool IsSet(MassStatusReqID val) { return IsSetMassStatusReqID(); }
    public bool IsSetMassStatusReqID() { return IsSetField(Tags.MassStatusReqID); }

    public TotNumReports TotNumReports
    {
        get
        {
            TotNumReports val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNumReports val) { TotNumReports = val; }
    public TotNumReports Get(TotNumReports val) { GetField(val); return val; }
    public bool IsSet(TotNumReports val) { return IsSetTotNumReports(); }
    public bool IsSetTotNumReports() { return IsSetField(Tags.TotNumReports); }

    public LastRptRequested LastRptRequested
    {
        get
        {
            LastRptRequested val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastRptRequested val) { LastRptRequested = val; }
    public LastRptRequested Get(LastRptRequested val) { GetField(val); return val; }
    public bool IsSet(LastRptRequested val) { return IsSetLastRptRequested(); }
    public bool IsSetLastRptRequested() { return IsSetField(Tags.LastRptRequested); }

    public NoPartyIDs NoPartyIDs
    {
        get
        {
            NoPartyIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyIDs val) { NoPartyIDs = val; }
    public NoPartyIDs Get(NoPartyIDs val) { GetField(val); return val; }
    public bool IsSet(NoPartyIDs val) { return IsSetNoPartyIDs(); }
    public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

    public TradeOriginationDate TradeOriginationDate
    {
        get
        {
            TradeOriginationDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeOriginationDate val) { TradeOriginationDate = val; }
    public TradeOriginationDate Get(TradeOriginationDate val) { GetField(val); return val; }
    public bool IsSet(TradeOriginationDate val) { return IsSetTradeOriginationDate(); }
    public bool IsSetTradeOriginationDate() { return IsSetField(Tags.TradeOriginationDate); }

    public NoContraBrokers NoContraBrokers
    {
        get
        {
            NoContraBrokers val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoContraBrokers val) { NoContraBrokers = val; }
    public NoContraBrokers Get(NoContraBrokers val) { GetField(val); return val; }
    public bool IsSet(NoContraBrokers val) { return IsSetNoContraBrokers(); }
    public bool IsSetNoContraBrokers() { return IsSetField(Tags.NoContraBrokers); }

    public ListID ListID
    {
        get
        {
            ListID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListID val) { ListID = val; }
    public ListID Get(ListID val) { GetField(val); return val; }
    public bool IsSet(ListID val) { return IsSetListID(); }
    public bool IsSetListID() { return IsSetField(Tags.ListID); }

    public CrossID CrossID
    {
        get
        {
            CrossID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CrossID val) { CrossID = val; }
    public CrossID Get(CrossID val) { GetField(val); return val; }
    public bool IsSet(CrossID val) { return IsSetCrossID(); }
    public bool IsSetCrossID() { return IsSetField(Tags.CrossID); }

    public OrigCrossID OrigCrossID
    {
        get
        {
            OrigCrossID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigCrossID val) { OrigCrossID = val; }
    public OrigCrossID Get(OrigCrossID val) { GetField(val); return val; }
    public bool IsSet(OrigCrossID val) { return IsSetOrigCrossID(); }
    public bool IsSetOrigCrossID() { return IsSetField(Tags.OrigCrossID); }

    public CrossType CrossType
    {
        get
        {
            CrossType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CrossType val) { CrossType = val; }
    public CrossType Get(CrossType val) { GetField(val); return val; }
    public bool IsSet(CrossType val) { return IsSetCrossType(); }
    public bool IsSetCrossType() { return IsSetField(Tags.CrossType); }

    public ExecID ExecID
    {
        get
        {
            ExecID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecID val) { ExecID = val; }
    public ExecID Get(ExecID val) { GetField(val); return val; }
    public bool IsSet(ExecID val) { return IsSetExecID(); }
    public bool IsSetExecID() { return IsSetField(Tags.ExecID); }

    public ExecRefID ExecRefID
    {
        get
        {
            ExecRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecRefID val) { ExecRefID = val; }
    public ExecRefID Get(ExecRefID val) { GetField(val); return val; }
    public bool IsSet(ExecRefID val) { return IsSetExecRefID(); }
    public bool IsSetExecRefID() { return IsSetField(Tags.ExecRefID); }

    public ExecType ExecType
    {
        get
        {
            ExecType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecType val) { ExecType = val; }
    public ExecType Get(ExecType val) { GetField(val); return val; }
    public bool IsSet(ExecType val) { return IsSetExecType(); }
    public bool IsSetExecType() { return IsSetField(Tags.ExecType); }

    public OrdStatus OrdStatus
    {
        get
        {
            OrdStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdStatus val) { OrdStatus = val; }
    public OrdStatus Get(OrdStatus val) { GetField(val); return val; }
    public bool IsSet(OrdStatus val) { return IsSetOrdStatus(); }
    public bool IsSetOrdStatus() { return IsSetField(Tags.OrdStatus); }

    public WorkingIndicator WorkingIndicator
    {
        get
        {
            WorkingIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(WorkingIndicator val) { WorkingIndicator = val; }
    public WorkingIndicator Get(WorkingIndicator val) { GetField(val); return val; }
    public bool IsSet(WorkingIndicator val) { return IsSetWorkingIndicator(); }
    public bool IsSetWorkingIndicator() { return IsSetField(Tags.WorkingIndicator); }

    public OrdRejReason OrdRejReason
    {
        get
        {
            OrdRejReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdRejReason val) { OrdRejReason = val; }
    public OrdRejReason Get(OrdRejReason val) { GetField(val); return val; }
    public bool IsSet(OrdRejReason val) { return IsSetOrdRejReason(); }
    public bool IsSetOrdRejReason() { return IsSetField(Tags.OrdRejReason); }

    public ExecRestatementReason ExecRestatementReason
    {
        get
        {
            ExecRestatementReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecRestatementReason val) { ExecRestatementReason = val; }
    public ExecRestatementReason Get(ExecRestatementReason val) { GetField(val); return val; }
    public bool IsSet(ExecRestatementReason val) { return IsSetExecRestatementReason(); }
    public bool IsSetExecRestatementReason() { return IsSetField(Tags.ExecRestatementReason); }

    public Account Account
    {
        get
        {
            Account val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Account val) { Account = val; }
    public Account Get(Account val) { GetField(val); return val; }
    public bool IsSet(Account val) { return IsSetAccount(); }
    public bool IsSetAccount() { return IsSetField(Tags.Account); }

    public AcctIDSource AcctIDSource
    {
        get
        {
            AcctIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AcctIDSource val) { AcctIDSource = val; }
    public AcctIDSource Get(AcctIDSource val) { GetField(val); return val; }
    public bool IsSet(AcctIDSource val) { return IsSetAcctIDSource(); }
    public bool IsSetAcctIDSource() { return IsSetField(Tags.AcctIDSource); }

    public AccountType AccountType
    {
        get
        {
            AccountType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AccountType val) { AccountType = val; }
    public AccountType Get(AccountType val) { GetField(val); return val; }
    public bool IsSet(AccountType val) { return IsSetAccountType(); }
    public bool IsSetAccountType() { return IsSetField(Tags.AccountType); }

    public DayBookingInst DayBookingInst
    {
        get
        {
            DayBookingInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayBookingInst val) { DayBookingInst = val; }
    public DayBookingInst Get(DayBookingInst val) { GetField(val); return val; }
    public bool IsSet(DayBookingInst val) { return IsSetDayBookingInst(); }
    public bool IsSetDayBookingInst() { return IsSetField(Tags.DayBookingInst); }

    public BookingUnit BookingUnit
    {
        get
        {
            BookingUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BookingUnit val) { BookingUnit = val; }
    public BookingUnit Get(BookingUnit val) { GetField(val); return val; }
    public bool IsSet(BookingUnit val) { return IsSetBookingUnit(); }
    public bool IsSetBookingUnit() { return IsSetField(Tags.BookingUnit); }

    public PreallocMethod PreallocMethod
    {
        get
        {
            PreallocMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PreallocMethod val) { PreallocMethod = val; }
    public PreallocMethod Get(PreallocMethod val) { GetField(val); return val; }
    public bool IsSet(PreallocMethod val) { return IsSetPreallocMethod(); }
    public bool IsSetPreallocMethod() { return IsSetField(Tags.PreallocMethod); }

    public SettlType SettlType
    {
        get
        {
            SettlType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlType val) { SettlType = val; }
    public SettlType Get(SettlType val) { GetField(val); return val; }
    public bool IsSet(SettlType val) { return IsSetSettlType(); }
    public bool IsSetSettlType() { return IsSetField(Tags.SettlType); }

    public SettlDate SettlDate
    {
        get
        {
            SettlDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlDate val) { SettlDate = val; }
    public SettlDate Get(SettlDate val) { GetField(val); return val; }
    public bool IsSet(SettlDate val) { return IsSetSettlDate(); }
    public bool IsSetSettlDate() { return IsSetField(Tags.SettlDate); }

    public CashMargin CashMargin
    {
        get
        {
            CashMargin val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashMargin val) { CashMargin = val; }
    public CashMargin Get(CashMargin val) { GetField(val); return val; }
    public bool IsSet(CashMargin val) { return IsSetCashMargin(); }
    public bool IsSetCashMargin() { return IsSetField(Tags.CashMargin); }

    public ClearingFeeIndicator ClearingFeeIndicator
    {
        get
        {
            ClearingFeeIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClearingFeeIndicator val) { ClearingFeeIndicator = val; }
    public ClearingFeeIndicator Get(ClearingFeeIndicator val) { GetField(val); return val; }
    public bool IsSet(ClearingFeeIndicator val) { return IsSetClearingFeeIndicator(); }
    public bool IsSetClearingFeeIndicator() { return IsSetField(Tags.ClearingFeeIndicator); }

    public Symbol Symbol
    {
        get
        {
            Symbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Symbol val) { Symbol = val; }
    public Symbol Get(Symbol val) { GetField(val); return val; }
    public bool IsSet(Symbol val) { return IsSetSymbol(); }
    public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

    public SymbolSfx SymbolSfx
    {
        get
        {
            SymbolSfx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SymbolSfx val) { SymbolSfx = val; }
    public SymbolSfx Get(SymbolSfx val) { GetField(val); return val; }
    public bool IsSet(SymbolSfx val) { return IsSetSymbolSfx(); }
    public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

    public SecurityID SecurityID
    {
        get
        {
            SecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityID val) { SecurityID = val; }
    public SecurityID Get(SecurityID val) { GetField(val); return val; }
    public bool IsSet(SecurityID val) { return IsSetSecurityID(); }
    public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

    public SecurityIDSource SecurityIDSource
    {
        get
        {
            SecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityIDSource val) { SecurityIDSource = val; }
    public SecurityIDSource Get(SecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(SecurityIDSource val) { return IsSetSecurityIDSource(); }
    public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }

    public NoSecurityAltID NoSecurityAltID
    {
        get
        {
            NoSecurityAltID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSecurityAltID val) { NoSecurityAltID = val; }
    public NoSecurityAltID Get(NoSecurityAltID val) { GetField(val); return val; }
    public bool IsSet(NoSecurityAltID val) { return IsSetNoSecurityAltID(); }
    public bool IsSetNoSecurityAltID() { return IsSetField(Tags.NoSecurityAltID); }

    public Product Product
    {
        get
        {
            Product val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Product val) { Product = val; }
    public Product Get(Product val) { GetField(val); return val; }
    public bool IsSet(Product val) { return IsSetProduct(); }
    public bool IsSetProduct() { return IsSetField(Tags.Product); }

    public CFICode CFICode
    {
        get
        {
            CFICode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CFICode val) { CFICode = val; }
    public CFICode Get(CFICode val) { GetField(val); return val; }
    public bool IsSet(CFICode val) { return IsSetCFICode(); }
    public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

    public SecurityType SecurityType
    {
        get
        {
            SecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityType val) { SecurityType = val; }
    public SecurityType Get(SecurityType val) { GetField(val); return val; }
    public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
    public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

    public SecuritySubType SecuritySubType
    {
        get
        {
            SecuritySubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySubType val) { SecuritySubType = val; }
    public SecuritySubType Get(SecuritySubType val) { GetField(val); return val; }
    public bool IsSet(SecuritySubType val) { return IsSetSecuritySubType(); }
    public bool IsSetSecuritySubType() { return IsSetField(Tags.SecuritySubType); }

    public MaturityMonthYear MaturityMonthYear
    {
        get
        {
            MaturityMonthYear val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityMonthYear val) { MaturityMonthYear = val; }
    public MaturityMonthYear Get(MaturityMonthYear val) { GetField(val); return val; }
    public bool IsSet(MaturityMonthYear val) { return IsSetMaturityMonthYear(); }
    public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

    public MaturityDate MaturityDate
    {
        get
        {
            MaturityDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityDate val) { MaturityDate = val; }
    public MaturityDate Get(MaturityDate val) { GetField(val); return val; }
    public bool IsSet(MaturityDate val) { return IsSetMaturityDate(); }
    public bool IsSetMaturityDate() { return IsSetField(Tags.MaturityDate); }

    public CouponPaymentDate CouponPaymentDate
    {
        get
        {
            CouponPaymentDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponPaymentDate val) { CouponPaymentDate = val; }
    public CouponPaymentDate Get(CouponPaymentDate val) { GetField(val); return val; }
    public bool IsSet(CouponPaymentDate val) { return IsSetCouponPaymentDate(); }
    public bool IsSetCouponPaymentDate() { return IsSetField(Tags.CouponPaymentDate); }

    public IssueDate IssueDate
    {
        get
        {
            IssueDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IssueDate val) { IssueDate = val; }
    public IssueDate Get(IssueDate val) { GetField(val); return val; }
    public bool IsSet(IssueDate val) { return IsSetIssueDate(); }
    public bool IsSetIssueDate() { return IsSetField(Tags.IssueDate); }

    public RepoCollateralSecurityType RepoCollateralSecurityType
    {
        get
        {
            RepoCollateralSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepoCollateralSecurityType val) { RepoCollateralSecurityType = val; }
    public RepoCollateralSecurityType Get(RepoCollateralSecurityType val) { GetField(val); return val; }
    public bool IsSet(RepoCollateralSecurityType val) { return IsSetRepoCollateralSecurityType(); }
    public bool IsSetRepoCollateralSecurityType() { return IsSetField(Tags.RepoCollateralSecurityType); }

    public RepurchaseTerm RepurchaseTerm
    {
        get
        {
            RepurchaseTerm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepurchaseTerm val) { RepurchaseTerm = val; }
    public RepurchaseTerm Get(RepurchaseTerm val) { GetField(val); return val; }
    public bool IsSet(RepurchaseTerm val) { return IsSetRepurchaseTerm(); }
    public bool IsSetRepurchaseTerm() { return IsSetField(Tags.RepurchaseTerm); }

    public RepurchaseRate RepurchaseRate
    {
        get
        {
            RepurchaseRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepurchaseRate val) { RepurchaseRate = val; }
    public RepurchaseRate Get(RepurchaseRate val) { GetField(val); return val; }
    public bool IsSet(RepurchaseRate val) { return IsSetRepurchaseRate(); }
    public bool IsSetRepurchaseRate() { return IsSetField(Tags.RepurchaseRate); }

    public Factor Factor
    {
        get
        {
            Factor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Factor val) { Factor = val; }
    public Factor Get(Factor val) { GetField(val); return val; }
    public bool IsSet(Factor val) { return IsSetFactor(); }
    public bool IsSetFactor() { return IsSetField(Tags.Factor); }

    public CreditRating CreditRating
    {
        get
        {
            CreditRating val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CreditRating val) { CreditRating = val; }
    public CreditRating Get(CreditRating val) { GetField(val); return val; }
    public bool IsSet(CreditRating val) { return IsSetCreditRating(); }
    public bool IsSetCreditRating() { return IsSetField(Tags.CreditRating); }

    public InstrRegistry InstrRegistry
    {
        get
        {
            InstrRegistry val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InstrRegistry val) { InstrRegistry = val; }
    public InstrRegistry Get(InstrRegistry val) { GetField(val); return val; }
    public bool IsSet(InstrRegistry val) { return IsSetInstrRegistry(); }
    public bool IsSetInstrRegistry() { return IsSetField(Tags.InstrRegistry); }

    public CountryOfIssue CountryOfIssue
    {
        get
        {
            CountryOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CountryOfIssue val) { CountryOfIssue = val; }
    public CountryOfIssue Get(CountryOfIssue val) { GetField(val); return val; }
    public bool IsSet(CountryOfIssue val) { return IsSetCountryOfIssue(); }
    public bool IsSetCountryOfIssue() { return IsSetField(Tags.CountryOfIssue); }

    public StateOrProvinceOfIssue StateOrProvinceOfIssue
    {
        get
        {
            StateOrProvinceOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StateOrProvinceOfIssue val) { StateOrProvinceOfIssue = val; }
    public StateOrProvinceOfIssue Get(StateOrProvinceOfIssue val) { GetField(val); return val; }
    public bool IsSet(StateOrProvinceOfIssue val) { return IsSetStateOrProvinceOfIssue(); }
    public bool IsSetStateOrProvinceOfIssue() { return IsSetField(Tags.StateOrProvinceOfIssue); }

    public LocaleOfIssue LocaleOfIssue
    {
        get
        {
            LocaleOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LocaleOfIssue val) { LocaleOfIssue = val; }
    public LocaleOfIssue Get(LocaleOfIssue val) { GetField(val); return val; }
    public bool IsSet(LocaleOfIssue val) { return IsSetLocaleOfIssue(); }
    public bool IsSetLocaleOfIssue() { return IsSetField(Tags.LocaleOfIssue); }

    public RedemptionDate RedemptionDate
    {
        get
        {
            RedemptionDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RedemptionDate val) { RedemptionDate = val; }
    public RedemptionDate Get(RedemptionDate val) { GetField(val); return val; }
    public bool IsSet(RedemptionDate val) { return IsSetRedemptionDate(); }
    public bool IsSetRedemptionDate() { return IsSetField(Tags.RedemptionDate); }

    public StrikePrice StrikePrice
    {
        get
        {
            StrikePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePrice val) { StrikePrice = val; }
    public StrikePrice Get(StrikePrice val) { GetField(val); return val; }
    public bool IsSet(StrikePrice val) { return IsSetStrikePrice(); }
    public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

    public StrikeCurrency StrikeCurrency
    {
        get
        {
            StrikeCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeCurrency val) { StrikeCurrency = val; }
    public StrikeCurrency Get(StrikeCurrency val) { GetField(val); return val; }
    public bool IsSet(StrikeCurrency val) { return IsSetStrikeCurrency(); }
    public bool IsSetStrikeCurrency() { return IsSetField(Tags.StrikeCurrency); }

    public OptAttribute OptAttribute
    {
        get
        {
            OptAttribute val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptAttribute val) { OptAttribute = val; }
    public OptAttribute Get(OptAttribute val) { GetField(val); return val; }
    public bool IsSet(OptAttribute val) { return IsSetOptAttribute(); }
    public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

    public ContractMultiplier ContractMultiplier
    {
        get
        {
            ContractMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ContractMultiplier val) { ContractMultiplier = val; }
    public ContractMultiplier Get(ContractMultiplier val) { GetField(val); return val; }
    public bool IsSet(ContractMultiplier val) { return IsSetContractMultiplier(); }
    public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }

    public CouponRate CouponRate
    {
        get
        {
            CouponRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponRate val) { CouponRate = val; }
    public CouponRate Get(CouponRate val) { GetField(val); return val; }
    public bool IsSet(CouponRate val) { return IsSetCouponRate(); }
    public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }

    public SecurityExchange SecurityExchange
    {
        get
        {
            SecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityExchange val) { SecurityExchange = val; }
    public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
    public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
    public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

    public Issuer Issuer
    {
        get
        {
            Issuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Issuer val) { Issuer = val; }
    public Issuer Get(Issuer val) { GetField(val); return val; }
    public bool IsSet(Issuer val) { return IsSetIssuer(); }
    public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

    public EncodedIssuerLen EncodedIssuerLen
    {
        get
        {
            EncodedIssuerLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedIssuerLen val) { EncodedIssuerLen = val; }
    public EncodedIssuerLen Get(EncodedIssuerLen val) { GetField(val); return val; }
    public bool IsSet(EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }
    public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }

    public EncodedIssuer EncodedIssuer
    {
        get
        {
            EncodedIssuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedIssuer val) { EncodedIssuer = val; }
    public EncodedIssuer Get(EncodedIssuer val) { GetField(val); return val; }
    public bool IsSet(EncodedIssuer val) { return IsSetEncodedIssuer(); }
    public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }

    public SecurityDesc SecurityDesc
    {
        get
        {
            SecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityDesc val) { SecurityDesc = val; }
    public SecurityDesc Get(SecurityDesc val) { GetField(val); return val; }
    public bool IsSet(SecurityDesc val) { return IsSetSecurityDesc(); }
    public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

    public EncodedSecurityDescLen EncodedSecurityDescLen
    {
        get
        {
            EncodedSecurityDescLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedSecurityDescLen val) { EncodedSecurityDescLen = val; }
    public EncodedSecurityDescLen Get(EncodedSecurityDescLen val) { GetField(val); return val; }
    public bool IsSet(EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }
    public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }

    public EncodedSecurityDesc EncodedSecurityDesc
    {
        get
        {
            EncodedSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedSecurityDesc val) { EncodedSecurityDesc = val; }
    public EncodedSecurityDesc Get(EncodedSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }
    public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }

    public Pool Pool
    {
        get
        {
            Pool val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Pool val) { Pool = val; }
    public Pool Get(Pool val) { GetField(val); return val; }
    public bool IsSet(Pool val) { return IsSetPool(); }
    public bool IsSetPool() { return IsSetField(Tags.Pool); }

    public ContractSettlMonth ContractSettlMonth
    {
        get
        {
            ContractSettlMonth val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ContractSettlMonth val) { ContractSettlMonth = val; }
    public ContractSettlMonth Get(ContractSettlMonth val) { GetField(val); return val; }
    public bool IsSet(ContractSettlMonth val) { return IsSetContractSettlMonth(); }
    public bool IsSetContractSettlMonth() { return IsSetField(Tags.ContractSettlMonth); }

    public CPProgram CPProgram
    {
        get
        {
            CPProgram val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CPProgram val) { CPProgram = val; }
    public CPProgram Get(CPProgram val) { GetField(val); return val; }
    public bool IsSet(CPProgram val) { return IsSetCPProgram(); }
    public bool IsSetCPProgram() { return IsSetField(Tags.CPProgram); }

    public CPRegType CPRegType
    {
        get
        {
            CPRegType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CPRegType val) { CPRegType = val; }
    public CPRegType Get(CPRegType val) { GetField(val); return val; }
    public bool IsSet(CPRegType val) { return IsSetCPRegType(); }
    public bool IsSetCPRegType() { return IsSetField(Tags.CPRegType); }

    public NoEvents NoEvents
    {
        get
        {
            NoEvents val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoEvents val) { NoEvents = val; }
    public NoEvents Get(NoEvents val) { GetField(val); return val; }
    public bool IsSet(NoEvents val) { return IsSetNoEvents(); }
    public bool IsSetNoEvents() { return IsSetField(Tags.NoEvents); }

    public DatedDate DatedDate
    {
        get
        {
            DatedDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DatedDate val) { DatedDate = val; }
    public DatedDate Get(DatedDate val) { GetField(val); return val; }
    public bool IsSet(DatedDate val) { return IsSetDatedDate(); }
    public bool IsSetDatedDate() { return IsSetField(Tags.DatedDate); }

    public InterestAccrualDate InterestAccrualDate
    {
        get
        {
            InterestAccrualDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterestAccrualDate val) { InterestAccrualDate = val; }
    public InterestAccrualDate Get(InterestAccrualDate val) { GetField(val); return val; }
    public bool IsSet(InterestAccrualDate val) { return IsSetInterestAccrualDate(); }
    public bool IsSetInterestAccrualDate() { return IsSetField(Tags.InterestAccrualDate); }

    public Fields.SecurityStatus SecurityStatus
    {
        get
        {
            Fields.SecurityStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Fields.SecurityStatus val) { SecurityStatus = val; }
    public Fields.SecurityStatus Get(Fields.SecurityStatus val) { GetField(val); return val; }
    public bool IsSet(Fields.SecurityStatus val) { return IsSetSecurityStatus(); }
    public bool IsSetSecurityStatus() { return IsSetField(Tags.SecurityStatus); }

    public SettleOnOpenFlag SettleOnOpenFlag
    {
        get
        {
            SettleOnOpenFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettleOnOpenFlag val) { SettleOnOpenFlag = val; }
    public SettleOnOpenFlag Get(SettleOnOpenFlag val) { GetField(val); return val; }
    public bool IsSet(SettleOnOpenFlag val) { return IsSetSettleOnOpenFlag(); }
    public bool IsSetSettleOnOpenFlag() { return IsSetField(Tags.SettleOnOpenFlag); }

    public InstrmtAssignmentMethod InstrmtAssignmentMethod
    {
        get
        {
            InstrmtAssignmentMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InstrmtAssignmentMethod val) { InstrmtAssignmentMethod = val; }
    public InstrmtAssignmentMethod Get(InstrmtAssignmentMethod val) { GetField(val); return val; }
    public bool IsSet(InstrmtAssignmentMethod val) { return IsSetInstrmtAssignmentMethod(); }
    public bool IsSetInstrmtAssignmentMethod() { return IsSetField(Tags.InstrmtAssignmentMethod); }

    public StrikeMultiplier StrikeMultiplier
    {
        get
        {
            StrikeMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeMultiplier val) { StrikeMultiplier = val; }
    public StrikeMultiplier Get(StrikeMultiplier val) { GetField(val); return val; }
    public bool IsSet(StrikeMultiplier val) { return IsSetStrikeMultiplier(); }
    public bool IsSetStrikeMultiplier() { return IsSetField(Tags.StrikeMultiplier); }

    public StrikeValue StrikeValue
    {
        get
        {
            StrikeValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeValue val) { StrikeValue = val; }
    public StrikeValue Get(StrikeValue val) { GetField(val); return val; }
    public bool IsSet(StrikeValue val) { return IsSetStrikeValue(); }
    public bool IsSetStrikeValue() { return IsSetField(Tags.StrikeValue); }

    public MinPriceIncrement MinPriceIncrement
    {
        get
        {
            MinPriceIncrement val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinPriceIncrement val) { MinPriceIncrement = val; }
    public MinPriceIncrement Get(MinPriceIncrement val) { GetField(val); return val; }
    public bool IsSet(MinPriceIncrement val) { return IsSetMinPriceIncrement(); }
    public bool IsSetMinPriceIncrement() { return IsSetField(Tags.MinPriceIncrement); }

    public PositionLimit PositionLimit
    {
        get
        {
            PositionLimit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PositionLimit val) { PositionLimit = val; }
    public PositionLimit Get(PositionLimit val) { GetField(val); return val; }
    public bool IsSet(PositionLimit val) { return IsSetPositionLimit(); }
    public bool IsSetPositionLimit() { return IsSetField(Tags.PositionLimit); }

    public NTPositionLimit NTPositionLimit
    {
        get
        {
            NTPositionLimit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NTPositionLimit val) { NTPositionLimit = val; }
    public NTPositionLimit Get(NTPositionLimit val) { GetField(val); return val; }
    public bool IsSet(NTPositionLimit val) { return IsSetNTPositionLimit(); }
    public bool IsSetNTPositionLimit() { return IsSetField(Tags.NTPositionLimit); }

    public NoInstrumentParties NoInstrumentParties
    {
        get
        {
            NoInstrumentParties val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoInstrumentParties val) { NoInstrumentParties = val; }
    public NoInstrumentParties Get(NoInstrumentParties val) { GetField(val); return val; }
    public bool IsSet(NoInstrumentParties val) { return IsSetNoInstrumentParties(); }
    public bool IsSetNoInstrumentParties() { return IsSetField(Tags.NoInstrumentParties); }

    public UnitOfMeasure UnitOfMeasure
    {
        get
        {
            UnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnitOfMeasure val) { UnitOfMeasure = val; }
    public UnitOfMeasure Get(UnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(UnitOfMeasure val) { return IsSetUnitOfMeasure(); }
    public bool IsSetUnitOfMeasure() { return IsSetField(Tags.UnitOfMeasure); }

    public TimeUnit TimeUnit
    {
        get
        {
            TimeUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TimeUnit val) { TimeUnit = val; }
    public TimeUnit Get(TimeUnit val) { GetField(val); return val; }
    public bool IsSet(TimeUnit val) { return IsSetTimeUnit(); }
    public bool IsSetTimeUnit() { return IsSetField(Tags.TimeUnit); }

    public MaturityTime MaturityTime
    {
        get
        {
            MaturityTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityTime val) { MaturityTime = val; }
    public MaturityTime Get(MaturityTime val) { GetField(val); return val; }
    public bool IsSet(MaturityTime val) { return IsSetMaturityTime(); }
    public bool IsSetMaturityTime() { return IsSetField(Tags.MaturityTime); }

    public AgreementDesc AgreementDesc
    {
        get
        {
            AgreementDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementDesc val) { AgreementDesc = val; }
    public AgreementDesc Get(AgreementDesc val) { GetField(val); return val; }
    public bool IsSet(AgreementDesc val) { return IsSetAgreementDesc(); }
    public bool IsSetAgreementDesc() { return IsSetField(Tags.AgreementDesc); }

    public AgreementID AgreementID
    {
        get
        {
            AgreementID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementID val) { AgreementID = val; }
    public AgreementID Get(AgreementID val) { GetField(val); return val; }
    public bool IsSet(AgreementID val) { return IsSetAgreementID(); }
    public bool IsSetAgreementID() { return IsSetField(Tags.AgreementID); }

    public AgreementDate AgreementDate
    {
        get
        {
            AgreementDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementDate val) { AgreementDate = val; }
    public AgreementDate Get(AgreementDate val) { GetField(val); return val; }
    public bool IsSet(AgreementDate val) { return IsSetAgreementDate(); }
    public bool IsSetAgreementDate() { return IsSetField(Tags.AgreementDate); }

    public AgreementCurrency AgreementCurrency
    {
        get
        {
            AgreementCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementCurrency val) { AgreementCurrency = val; }
    public AgreementCurrency Get(AgreementCurrency val) { GetField(val); return val; }
    public bool IsSet(AgreementCurrency val) { return IsSetAgreementCurrency(); }
    public bool IsSetAgreementCurrency() { return IsSetField(Tags.AgreementCurrency); }

    public TerminationType TerminationType
    {
        get
        {
            TerminationType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TerminationType val) { TerminationType = val; }
    public TerminationType Get(TerminationType val) { GetField(val); return val; }
    public bool IsSet(TerminationType val) { return IsSetTerminationType(); }
    public bool IsSetTerminationType() { return IsSetField(Tags.TerminationType); }

    public StartDate StartDate
    {
        get
        {
            StartDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StartDate val) { StartDate = val; }
    public StartDate Get(StartDate val) { GetField(val); return val; }
    public bool IsSet(StartDate val) { return IsSetStartDate(); }
    public bool IsSetStartDate() { return IsSetField(Tags.StartDate); }

    public EndDate EndDate
    {
        get
        {
            EndDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndDate val) { EndDate = val; }
    public EndDate Get(EndDate val) { GetField(val); return val; }
    public bool IsSet(EndDate val) { return IsSetEndDate(); }
    public bool IsSetEndDate() { return IsSetField(Tags.EndDate); }

    public DeliveryType DeliveryType
    {
        get
        {
            DeliveryType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DeliveryType val) { DeliveryType = val; }
    public DeliveryType Get(DeliveryType val) { GetField(val); return val; }
    public bool IsSet(DeliveryType val) { return IsSetDeliveryType(); }
    public bool IsSetDeliveryType() { return IsSetField(Tags.DeliveryType); }

    public MarginRatio MarginRatio
    {
        get
        {
            MarginRatio val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarginRatio val) { MarginRatio = val; }
    public MarginRatio Get(MarginRatio val) { GetField(val); return val; }
    public bool IsSet(MarginRatio val) { return IsSetMarginRatio(); }
    public bool IsSetMarginRatio() { return IsSetField(Tags.MarginRatio); }

    public NoUnderlyings NoUnderlyings
    {
        get
        {
            NoUnderlyings val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUnderlyings val) { NoUnderlyings = val; }
    public NoUnderlyings Get(NoUnderlyings val) { GetField(val); return val; }
    public bool IsSet(NoUnderlyings val) { return IsSetNoUnderlyings(); }
    public bool IsSetNoUnderlyings() { return IsSetField(Tags.NoUnderlyings); }

    public Side Side
    {
        get
        {
            Side val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Side val) { Side = val; }
    public Side Get(Side val) { GetField(val); return val; }
    public bool IsSet(Side val) { return IsSetSide(); }
    public bool IsSetSide() { return IsSetField(Tags.Side); }

    public NoStipulations NoStipulations
    {
        get
        {
            NoStipulations val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoStipulations val) { NoStipulations = val; }
    public NoStipulations Get(NoStipulations val) { GetField(val); return val; }
    public bool IsSet(NoStipulations val) { return IsSetNoStipulations(); }
    public bool IsSetNoStipulations() { return IsSetField(Tags.NoStipulations); }

    public QtyType QtyType
    {
        get
        {
            QtyType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QtyType val) { QtyType = val; }
    public QtyType Get(QtyType val) { GetField(val); return val; }
    public bool IsSet(QtyType val) { return IsSetQtyType(); }
    public bool IsSetQtyType() { return IsSetField(Tags.QtyType); }

    public OrderQty OrderQty
    {
        get
        {
            OrderQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderQty val) { OrderQty = val; }
    public OrderQty Get(OrderQty val) { GetField(val); return val; }
    public bool IsSet(OrderQty val) { return IsSetOrderQty(); }
    public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }

    public CashOrderQty CashOrderQty
    {
        get
        {
            CashOrderQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashOrderQty val) { CashOrderQty = val; }
    public CashOrderQty Get(CashOrderQty val) { GetField(val); return val; }
    public bool IsSet(CashOrderQty val) { return IsSetCashOrderQty(); }
    public bool IsSetCashOrderQty() { return IsSetField(Tags.CashOrderQty); }

    public OrderPercent OrderPercent
    {
        get
        {
            OrderPercent val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderPercent val) { OrderPercent = val; }
    public OrderPercent Get(OrderPercent val) { GetField(val); return val; }
    public bool IsSet(OrderPercent val) { return IsSetOrderPercent(); }
    public bool IsSetOrderPercent() { return IsSetField(Tags.OrderPercent); }

    public RoundingDirection RoundingDirection
    {
        get
        {
            RoundingDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RoundingDirection val) { RoundingDirection = val; }
    public RoundingDirection Get(RoundingDirection val) { GetField(val); return val; }
    public bool IsSet(RoundingDirection val) { return IsSetRoundingDirection(); }
    public bool IsSetRoundingDirection() { return IsSetField(Tags.RoundingDirection); }

    public RoundingModulus RoundingModulus
    {
        get
        {
            RoundingModulus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RoundingModulus val) { RoundingModulus = val; }
    public RoundingModulus Get(RoundingModulus val) { GetField(val); return val; }
    public bool IsSet(RoundingModulus val) { return IsSetRoundingModulus(); }
    public bool IsSetRoundingModulus() { return IsSetField(Tags.RoundingModulus); }

    public OrdType OrdType
    {
        get
        {
            OrdType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdType val) { OrdType = val; }
    public OrdType Get(OrdType val) { GetField(val); return val; }
    public bool IsSet(OrdType val) { return IsSetOrdType(); }
    public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }

    public PriceType PriceType
    {
        get
        {
            PriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceType val) { PriceType = val; }
    public PriceType Get(PriceType val) { GetField(val); return val; }
    public bool IsSet(PriceType val) { return IsSetPriceType(); }
    public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

    public Price Price
    {
        get
        {
            Price val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Price val) { Price = val; }
    public Price Get(Price val) { GetField(val); return val; }
    public bool IsSet(Price val) { return IsSetPrice(); }
    public bool IsSetPrice() { return IsSetField(Tags.Price); }

    public StopPx StopPx
    {
        get
        {
            StopPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StopPx val) { StopPx = val; }
    public StopPx Get(StopPx val) { GetField(val); return val; }
    public bool IsSet(StopPx val) { return IsSetStopPx(); }
    public bool IsSetStopPx() { return IsSetField(Tags.StopPx); }

    public PegOffsetValue PegOffsetValue
    {
        get
        {
            PegOffsetValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegOffsetValue val) { PegOffsetValue = val; }
    public PegOffsetValue Get(PegOffsetValue val) { GetField(val); return val; }
    public bool IsSet(PegOffsetValue val) { return IsSetPegOffsetValue(); }
    public bool IsSetPegOffsetValue() { return IsSetField(Tags.PegOffsetValue); }

    public PegMoveType PegMoveType
    {
        get
        {
            PegMoveType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegMoveType val) { PegMoveType = val; }
    public PegMoveType Get(PegMoveType val) { GetField(val); return val; }
    public bool IsSet(PegMoveType val) { return IsSetPegMoveType(); }
    public bool IsSetPegMoveType() { return IsSetField(Tags.PegMoveType); }

    public PegOffsetType PegOffsetType
    {
        get
        {
            PegOffsetType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegOffsetType val) { PegOffsetType = val; }
    public PegOffsetType Get(PegOffsetType val) { GetField(val); return val; }
    public bool IsSet(PegOffsetType val) { return IsSetPegOffsetType(); }
    public bool IsSetPegOffsetType() { return IsSetField(Tags.PegOffsetType); }

    public PegLimitType PegLimitType
    {
        get
        {
            PegLimitType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegLimitType val) { PegLimitType = val; }
    public PegLimitType Get(PegLimitType val) { GetField(val); return val; }
    public bool IsSet(PegLimitType val) { return IsSetPegLimitType(); }
    public bool IsSetPegLimitType() { return IsSetField(Tags.PegLimitType); }

    public PegRoundDirection PegRoundDirection
    {
        get
        {
            PegRoundDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegRoundDirection val) { PegRoundDirection = val; }
    public PegRoundDirection Get(PegRoundDirection val) { GetField(val); return val; }
    public bool IsSet(PegRoundDirection val) { return IsSetPegRoundDirection(); }
    public bool IsSetPegRoundDirection() { return IsSetField(Tags.PegRoundDirection); }

    public PegScope PegScope
    {
        get
        {
            PegScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegScope val) { PegScope = val; }
    public PegScope Get(PegScope val) { GetField(val); return val; }
    public bool IsSet(PegScope val) { return IsSetPegScope(); }
    public bool IsSetPegScope() { return IsSetField(Tags.PegScope); }

    public PegPriceType PegPriceType
    {
        get
        {
            PegPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegPriceType val) { PegPriceType = val; }
    public PegPriceType Get(PegPriceType val) { GetField(val); return val; }
    public bool IsSet(PegPriceType val) { return IsSetPegPriceType(); }
    public bool IsSetPegPriceType() { return IsSetField(Tags.PegPriceType); }

    public PegSecurityIDSource PegSecurityIDSource
    {
        get
        {
            PegSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegSecurityIDSource val) { PegSecurityIDSource = val; }
    public PegSecurityIDSource Get(PegSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(PegSecurityIDSource val) { return IsSetPegSecurityIDSource(); }
    public bool IsSetPegSecurityIDSource() { return IsSetField(Tags.PegSecurityIDSource); }

    public PegSecurityID PegSecurityID
    {
        get
        {
            PegSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegSecurityID val) { PegSecurityID = val; }
    public PegSecurityID Get(PegSecurityID val) { GetField(val); return val; }
    public bool IsSet(PegSecurityID val) { return IsSetPegSecurityID(); }
    public bool IsSetPegSecurityID() { return IsSetField(Tags.PegSecurityID); }

    public PegSymbol PegSymbol
    {
        get
        {
            PegSymbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegSymbol val) { PegSymbol = val; }
    public PegSymbol Get(PegSymbol val) { GetField(val); return val; }
    public bool IsSet(PegSymbol val) { return IsSetPegSymbol(); }
    public bool IsSetPegSymbol() { return IsSetField(Tags.PegSymbol); }

    public PegSecurityDesc PegSecurityDesc
    {
        get
        {
            PegSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegSecurityDesc val) { PegSecurityDesc = val; }
    public PegSecurityDesc Get(PegSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(PegSecurityDesc val) { return IsSetPegSecurityDesc(); }
    public bool IsSetPegSecurityDesc() { return IsSetField(Tags.PegSecurityDesc); }

    public DiscretionInst DiscretionInst
    {
        get
        {
            DiscretionInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionInst val) { DiscretionInst = val; }
    public DiscretionInst Get(DiscretionInst val) { GetField(val); return val; }
    public bool IsSet(DiscretionInst val) { return IsSetDiscretionInst(); }
    public bool IsSetDiscretionInst() { return IsSetField(Tags.DiscretionInst); }

    public DiscretionOffsetValue DiscretionOffsetValue
    {
        get
        {
            DiscretionOffsetValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionOffsetValue val) { DiscretionOffsetValue = val; }
    public DiscretionOffsetValue Get(DiscretionOffsetValue val) { GetField(val); return val; }
    public bool IsSet(DiscretionOffsetValue val) { return IsSetDiscretionOffsetValue(); }
    public bool IsSetDiscretionOffsetValue() { return IsSetField(Tags.DiscretionOffsetValue); }

    public DiscretionMoveType DiscretionMoveType
    {
        get
        {
            DiscretionMoveType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionMoveType val) { DiscretionMoveType = val; }
    public DiscretionMoveType Get(DiscretionMoveType val) { GetField(val); return val; }
    public bool IsSet(DiscretionMoveType val) { return IsSetDiscretionMoveType(); }
    public bool IsSetDiscretionMoveType() { return IsSetField(Tags.DiscretionMoveType); }

    public DiscretionOffsetType DiscretionOffsetType
    {
        get
        {
            DiscretionOffsetType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionOffsetType val) { DiscretionOffsetType = val; }
    public DiscretionOffsetType Get(DiscretionOffsetType val) { GetField(val); return val; }
    public bool IsSet(DiscretionOffsetType val) { return IsSetDiscretionOffsetType(); }
    public bool IsSetDiscretionOffsetType() { return IsSetField(Tags.DiscretionOffsetType); }

    public DiscretionLimitType DiscretionLimitType
    {
        get
        {
            DiscretionLimitType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionLimitType val) { DiscretionLimitType = val; }
    public DiscretionLimitType Get(DiscretionLimitType val) { GetField(val); return val; }
    public bool IsSet(DiscretionLimitType val) { return IsSetDiscretionLimitType(); }
    public bool IsSetDiscretionLimitType() { return IsSetField(Tags.DiscretionLimitType); }

    public DiscretionRoundDirection DiscretionRoundDirection
    {
        get
        {
            DiscretionRoundDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionRoundDirection val) { DiscretionRoundDirection = val; }
    public DiscretionRoundDirection Get(DiscretionRoundDirection val) { GetField(val); return val; }
    public bool IsSet(DiscretionRoundDirection val) { return IsSetDiscretionRoundDirection(); }
    public bool IsSetDiscretionRoundDirection() { return IsSetField(Tags.DiscretionRoundDirection); }

    public DiscretionScope DiscretionScope
    {
        get
        {
            DiscretionScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionScope val) { DiscretionScope = val; }
    public DiscretionScope Get(DiscretionScope val) { GetField(val); return val; }
    public bool IsSet(DiscretionScope val) { return IsSetDiscretionScope(); }
    public bool IsSetDiscretionScope() { return IsSetField(Tags.DiscretionScope); }

    public PeggedPrice PeggedPrice
    {
        get
        {
            PeggedPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PeggedPrice val) { PeggedPrice = val; }
    public PeggedPrice Get(PeggedPrice val) { GetField(val); return val; }
    public bool IsSet(PeggedPrice val) { return IsSetPeggedPrice(); }
    public bool IsSetPeggedPrice() { return IsSetField(Tags.PeggedPrice); }

    public DiscretionPrice DiscretionPrice
    {
        get
        {
            DiscretionPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionPrice val) { DiscretionPrice = val; }
    public DiscretionPrice Get(DiscretionPrice val) { GetField(val); return val; }
    public bool IsSet(DiscretionPrice val) { return IsSetDiscretionPrice(); }
    public bool IsSetDiscretionPrice() { return IsSetField(Tags.DiscretionPrice); }

    public TargetStrategy TargetStrategy
    {
        get
        {
            TargetStrategy val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TargetStrategy val) { TargetStrategy = val; }
    public TargetStrategy Get(TargetStrategy val) { GetField(val); return val; }
    public bool IsSet(TargetStrategy val) { return IsSetTargetStrategy(); }
    public bool IsSetTargetStrategy() { return IsSetField(Tags.TargetStrategy); }

    public TargetStrategyParameters TargetStrategyParameters
    {
        get
        {
            TargetStrategyParameters val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TargetStrategyParameters val) { TargetStrategyParameters = val; }
    public TargetStrategyParameters Get(TargetStrategyParameters val) { GetField(val); return val; }
    public bool IsSet(TargetStrategyParameters val) { return IsSetTargetStrategyParameters(); }
    public bool IsSetTargetStrategyParameters() { return IsSetField(Tags.TargetStrategyParameters); }

    public ParticipationRate ParticipationRate
    {
        get
        {
            ParticipationRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ParticipationRate val) { ParticipationRate = val; }
    public ParticipationRate Get(ParticipationRate val) { GetField(val); return val; }
    public bool IsSet(ParticipationRate val) { return IsSetParticipationRate(); }
    public bool IsSetParticipationRate() { return IsSetField(Tags.ParticipationRate); }

    public TargetStrategyPerformance TargetStrategyPerformance
    {
        get
        {
            TargetStrategyPerformance val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TargetStrategyPerformance val) { TargetStrategyPerformance = val; }
    public TargetStrategyPerformance Get(TargetStrategyPerformance val) { GetField(val); return val; }
    public bool IsSet(TargetStrategyPerformance val) { return IsSetTargetStrategyPerformance(); }
    public bool IsSetTargetStrategyPerformance() { return IsSetField(Tags.TargetStrategyPerformance); }

    public Currency Currency
    {
        get
        {
            Currency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Currency val) { Currency = val; }
    public Currency Get(Currency val) { GetField(val); return val; }
    public bool IsSet(Currency val) { return IsSetCurrency(); }
    public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

    public ComplianceID ComplianceID
    {
        get
        {
            ComplianceID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ComplianceID val) { ComplianceID = val; }
    public ComplianceID Get(ComplianceID val) { GetField(val); return val; }
    public bool IsSet(ComplianceID val) { return IsSetComplianceID(); }
    public bool IsSetComplianceID() { return IsSetField(Tags.ComplianceID); }

    public SolicitedFlag SolicitedFlag
    {
        get
        {
            SolicitedFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SolicitedFlag val) { SolicitedFlag = val; }
    public SolicitedFlag Get(SolicitedFlag val) { GetField(val); return val; }
    public bool IsSet(SolicitedFlag val) { return IsSetSolicitedFlag(); }
    public bool IsSetSolicitedFlag() { return IsSetField(Tags.SolicitedFlag); }

    public TimeInForce TimeInForce
    {
        get
        {
            TimeInForce val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TimeInForce val) { TimeInForce = val; }
    public TimeInForce Get(TimeInForce val) { GetField(val); return val; }
    public bool IsSet(TimeInForce val) { return IsSetTimeInForce(); }
    public bool IsSetTimeInForce() { return IsSetField(Tags.TimeInForce); }

    public EffectiveTime EffectiveTime
    {
        get
        {
            EffectiveTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EffectiveTime val) { EffectiveTime = val; }
    public EffectiveTime Get(EffectiveTime val) { GetField(val); return val; }
    public bool IsSet(EffectiveTime val) { return IsSetEffectiveTime(); }
    public bool IsSetEffectiveTime() { return IsSetField(Tags.EffectiveTime); }

    public ExpireDate ExpireDate
    {
        get
        {
            ExpireDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExpireDate val) { ExpireDate = val; }
    public ExpireDate Get(ExpireDate val) { GetField(val); return val; }
    public bool IsSet(ExpireDate val) { return IsSetExpireDate(); }
    public bool IsSetExpireDate() { return IsSetField(Tags.ExpireDate); }

    public ExpireTime ExpireTime
    {
        get
        {
            ExpireTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExpireTime val) { ExpireTime = val; }
    public ExpireTime Get(ExpireTime val) { GetField(val); return val; }
    public bool IsSet(ExpireTime val) { return IsSetExpireTime(); }
    public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

    public ExecInst ExecInst
    {
        get
        {
            ExecInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecInst val) { ExecInst = val; }
    public ExecInst Get(ExecInst val) { GetField(val); return val; }
    public bool IsSet(ExecInst val) { return IsSetExecInst(); }
    public bool IsSetExecInst() { return IsSetField(Tags.ExecInst); }

    public OrderCapacity OrderCapacity
    {
        get
        {
            OrderCapacity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderCapacity val) { OrderCapacity = val; }
    public OrderCapacity Get(OrderCapacity val) { GetField(val); return val; }
    public bool IsSet(OrderCapacity val) { return IsSetOrderCapacity(); }
    public bool IsSetOrderCapacity() { return IsSetField(Tags.OrderCapacity); }

    public OrderRestrictions OrderRestrictions
    {
        get
        {
            OrderRestrictions val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderRestrictions val) { OrderRestrictions = val; }
    public OrderRestrictions Get(OrderRestrictions val) { GetField(val); return val; }
    public bool IsSet(OrderRestrictions val) { return IsSetOrderRestrictions(); }
    public bool IsSetOrderRestrictions() { return IsSetField(Tags.OrderRestrictions); }

    public CustOrderCapacity CustOrderCapacity
    {
        get
        {
            CustOrderCapacity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustOrderCapacity val) { CustOrderCapacity = val; }
    public CustOrderCapacity Get(CustOrderCapacity val) { GetField(val); return val; }
    public bool IsSet(CustOrderCapacity val) { return IsSetCustOrderCapacity(); }
    public bool IsSetCustOrderCapacity() { return IsSetField(Tags.CustOrderCapacity); }

    public LastQty LastQty
    {
        get
        {
            LastQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastQty val) { LastQty = val; }
    public LastQty Get(LastQty val) { GetField(val); return val; }
    public bool IsSet(LastQty val) { return IsSetLastQty(); }
    public bool IsSetLastQty() { return IsSetField(Tags.LastQty); }

    public UnderlyingLastQty UnderlyingLastQty
    {
        get
        {
            UnderlyingLastQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingLastQty val) { UnderlyingLastQty = val; }
    public UnderlyingLastQty Get(UnderlyingLastQty val) { GetField(val); return val; }
    public bool IsSet(UnderlyingLastQty val) { return IsSetUnderlyingLastQty(); }
    public bool IsSetUnderlyingLastQty() { return IsSetField(Tags.UnderlyingLastQty); }

    public LastPx LastPx
    {
        get
        {
            LastPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastPx val) { LastPx = val; }
    public LastPx Get(LastPx val) { GetField(val); return val; }
    public bool IsSet(LastPx val) { return IsSetLastPx(); }
    public bool IsSetLastPx() { return IsSetField(Tags.LastPx); }

    public UnderlyingLastPx UnderlyingLastPx
    {
        get
        {
            UnderlyingLastPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingLastPx val) { UnderlyingLastPx = val; }
    public UnderlyingLastPx Get(UnderlyingLastPx val) { GetField(val); return val; }
    public bool IsSet(UnderlyingLastPx val) { return IsSetUnderlyingLastPx(); }
    public bool IsSetUnderlyingLastPx() { return IsSetField(Tags.UnderlyingLastPx); }

    public LastParPx LastParPx
    {
        get
        {
            LastParPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastParPx val) { LastParPx = val; }
    public LastParPx Get(LastParPx val) { GetField(val); return val; }
    public bool IsSet(LastParPx val) { return IsSetLastParPx(); }
    public bool IsSetLastParPx() { return IsSetField(Tags.LastParPx); }

    public LastSpotRate LastSpotRate
    {
        get
        {
            LastSpotRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastSpotRate val) { LastSpotRate = val; }
    public LastSpotRate Get(LastSpotRate val) { GetField(val); return val; }
    public bool IsSet(LastSpotRate val) { return IsSetLastSpotRate(); }
    public bool IsSetLastSpotRate() { return IsSetField(Tags.LastSpotRate); }

    public LastForwardPoints LastForwardPoints
    {
        get
        {
            LastForwardPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastForwardPoints val) { LastForwardPoints = val; }
    public LastForwardPoints Get(LastForwardPoints val) { GetField(val); return val; }
    public bool IsSet(LastForwardPoints val) { return IsSetLastForwardPoints(); }
    public bool IsSetLastForwardPoints() { return IsSetField(Tags.LastForwardPoints); }

    public LastMkt LastMkt
    {
        get
        {
            LastMkt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastMkt val) { LastMkt = val; }
    public LastMkt Get(LastMkt val) { GetField(val); return val; }
    public bool IsSet(LastMkt val) { return IsSetLastMkt(); }
    public bool IsSetLastMkt() { return IsSetField(Tags.LastMkt); }

    public TradingSessionID TradingSessionID
    {
        get
        {
            TradingSessionID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSessionID val) { TradingSessionID = val; }
    public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
    public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
    public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

    public TradingSessionSubID TradingSessionSubID
    {
        get
        {
            TradingSessionSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSessionSubID val) { TradingSessionSubID = val; }
    public TradingSessionSubID Get(TradingSessionSubID val) { GetField(val); return val; }
    public bool IsSet(TradingSessionSubID val) { return IsSetTradingSessionSubID(); }
    public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

    public TimeBracket TimeBracket
    {
        get
        {
            TimeBracket val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TimeBracket val) { TimeBracket = val; }
    public TimeBracket Get(TimeBracket val) { GetField(val); return val; }
    public bool IsSet(TimeBracket val) { return IsSetTimeBracket(); }
    public bool IsSetTimeBracket() { return IsSetField(Tags.TimeBracket); }

    public LastCapacity LastCapacity
    {
        get
        {
            LastCapacity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastCapacity val) { LastCapacity = val; }
    public LastCapacity Get(LastCapacity val) { GetField(val); return val; }
    public bool IsSet(LastCapacity val) { return IsSetLastCapacity(); }
    public bool IsSetLastCapacity() { return IsSetField(Tags.LastCapacity); }

    public LeavesQty LeavesQty
    {
        get
        {
            LeavesQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LeavesQty val) { LeavesQty = val; }
    public LeavesQty Get(LeavesQty val) { GetField(val); return val; }
    public bool IsSet(LeavesQty val) { return IsSetLeavesQty(); }
    public bool IsSetLeavesQty() { return IsSetField(Tags.LeavesQty); }

    public CumQty CumQty
    {
        get
        {
            CumQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CumQty val) { CumQty = val; }
    public CumQty Get(CumQty val) { GetField(val); return val; }
    public bool IsSet(CumQty val) { return IsSetCumQty(); }
    public bool IsSetCumQty() { return IsSetField(Tags.CumQty); }

    public AvgPx AvgPx
    {
        get
        {
            AvgPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgPx val) { AvgPx = val; }
    public AvgPx Get(AvgPx val) { GetField(val); return val; }
    public bool IsSet(AvgPx val) { return IsSetAvgPx(); }
    public bool IsSetAvgPx() { return IsSetField(Tags.AvgPx); }

    public DayOrderQty DayOrderQty
    {
        get
        {
            DayOrderQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayOrderQty val) { DayOrderQty = val; }
    public DayOrderQty Get(DayOrderQty val) { GetField(val); return val; }
    public bool IsSet(DayOrderQty val) { return IsSetDayOrderQty(); }
    public bool IsSetDayOrderQty() { return IsSetField(Tags.DayOrderQty); }

    public DayCumQty DayCumQty
    {
        get
        {
            DayCumQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayCumQty val) { DayCumQty = val; }
    public DayCumQty Get(DayCumQty val) { GetField(val); return val; }
    public bool IsSet(DayCumQty val) { return IsSetDayCumQty(); }
    public bool IsSetDayCumQty() { return IsSetField(Tags.DayCumQty); }

    public DayAvgPx DayAvgPx
    {
        get
        {
            DayAvgPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayAvgPx val) { DayAvgPx = val; }
    public DayAvgPx Get(DayAvgPx val) { GetField(val); return val; }
    public bool IsSet(DayAvgPx val) { return IsSetDayAvgPx(); }
    public bool IsSetDayAvgPx() { return IsSetField(Tags.DayAvgPx); }

    public GTBookingInst GTBookingInst
    {
        get
        {
            GTBookingInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(GTBookingInst val) { GTBookingInst = val; }
    public GTBookingInst Get(GTBookingInst val) { GetField(val); return val; }
    public bool IsSet(GTBookingInst val) { return IsSetGTBookingInst(); }
    public bool IsSetGTBookingInst() { return IsSetField(Tags.GTBookingInst); }

    public TradeDate TradeDate
    {
        get
        {
            TradeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeDate val) { TradeDate = val; }
    public TradeDate Get(TradeDate val) { GetField(val); return val; }
    public bool IsSet(TradeDate val) { return IsSetTradeDate(); }
    public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public ReportToExch ReportToExch
    {
        get
        {
            ReportToExch val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ReportToExch val) { ReportToExch = val; }
    public ReportToExch Get(ReportToExch val) { GetField(val); return val; }
    public bool IsSet(ReportToExch val) { return IsSetReportToExch(); }
    public bool IsSetReportToExch() { return IsSetField(Tags.ReportToExch); }

    public Commission Commission
    {
        get
        {
            Commission val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Commission val) { Commission = val; }
    public Commission Get(Commission val) { GetField(val); return val; }
    public bool IsSet(Commission val) { return IsSetCommission(); }
    public bool IsSetCommission() { return IsSetField(Tags.Commission); }

    public CommType CommType
    {
        get
        {
            CommType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CommType val) { CommType = val; }
    public CommType Get(CommType val) { GetField(val); return val; }
    public bool IsSet(CommType val) { return IsSetCommType(); }
    public bool IsSetCommType() { return IsSetField(Tags.CommType); }

    public CommCurrency CommCurrency
    {
        get
        {
            CommCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CommCurrency val) { CommCurrency = val; }
    public CommCurrency Get(CommCurrency val) { GetField(val); return val; }
    public bool IsSet(CommCurrency val) { return IsSetCommCurrency(); }
    public bool IsSetCommCurrency() { return IsSetField(Tags.CommCurrency); }

    public FundRenewWaiv FundRenewWaiv
    {
        get
        {
            FundRenewWaiv val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FundRenewWaiv val) { FundRenewWaiv = val; }
    public FundRenewWaiv Get(FundRenewWaiv val) { GetField(val); return val; }
    public bool IsSet(FundRenewWaiv val) { return IsSetFundRenewWaiv(); }
    public bool IsSetFundRenewWaiv() { return IsSetField(Tags.FundRenewWaiv); }

    public Spread Spread
    {
        get
        {
            Spread val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Spread val) { Spread = val; }
    public Spread Get(Spread val) { GetField(val); return val; }
    public bool IsSet(Spread val) { return IsSetSpread(); }
    public bool IsSetSpread() { return IsSetField(Tags.Spread); }

    public BenchmarkCurveCurrency BenchmarkCurveCurrency
    {
        get
        {
            BenchmarkCurveCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurveCurrency val) { BenchmarkCurveCurrency = val; }
    public BenchmarkCurveCurrency Get(BenchmarkCurveCurrency val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurveCurrency val) { return IsSetBenchmarkCurveCurrency(); }
    public bool IsSetBenchmarkCurveCurrency() { return IsSetField(Tags.BenchmarkCurveCurrency); }

    public BenchmarkCurveName BenchmarkCurveName
    {
        get
        {
            BenchmarkCurveName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurveName val) { BenchmarkCurveName = val; }
    public BenchmarkCurveName Get(BenchmarkCurveName val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurveName val) { return IsSetBenchmarkCurveName(); }
    public bool IsSetBenchmarkCurveName() { return IsSetField(Tags.BenchmarkCurveName); }

    public BenchmarkCurvePoint BenchmarkCurvePoint
    {
        get
        {
            BenchmarkCurvePoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurvePoint val) { BenchmarkCurvePoint = val; }
    public BenchmarkCurvePoint Get(BenchmarkCurvePoint val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurvePoint val) { return IsSetBenchmarkCurvePoint(); }
    public bool IsSetBenchmarkCurvePoint() { return IsSetField(Tags.BenchmarkCurvePoint); }

    public BenchmarkPrice BenchmarkPrice
    {
        get
        {
            BenchmarkPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkPrice val) { BenchmarkPrice = val; }
    public BenchmarkPrice Get(BenchmarkPrice val) { GetField(val); return val; }
    public bool IsSet(BenchmarkPrice val) { return IsSetBenchmarkPrice(); }
    public bool IsSetBenchmarkPrice() { return IsSetField(Tags.BenchmarkPrice); }

    public BenchmarkPriceType BenchmarkPriceType
    {
        get
        {
            BenchmarkPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkPriceType val) { BenchmarkPriceType = val; }
    public BenchmarkPriceType Get(BenchmarkPriceType val) { GetField(val); return val; }
    public bool IsSet(BenchmarkPriceType val) { return IsSetBenchmarkPriceType(); }
    public bool IsSetBenchmarkPriceType() { return IsSetField(Tags.BenchmarkPriceType); }

    public BenchmarkSecurityID BenchmarkSecurityID
    {
        get
        {
            BenchmarkSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkSecurityID val) { BenchmarkSecurityID = val; }
    public BenchmarkSecurityID Get(BenchmarkSecurityID val) { GetField(val); return val; }
    public bool IsSet(BenchmarkSecurityID val) { return IsSetBenchmarkSecurityID(); }
    public bool IsSetBenchmarkSecurityID() { return IsSetField(Tags.BenchmarkSecurityID); }

    public BenchmarkSecurityIDSource BenchmarkSecurityIDSource
    {
        get
        {
            BenchmarkSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkSecurityIDSource val) { BenchmarkSecurityIDSource = val; }
    public BenchmarkSecurityIDSource Get(BenchmarkSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(BenchmarkSecurityIDSource val) { return IsSetBenchmarkSecurityIDSource(); }
    public bool IsSetBenchmarkSecurityIDSource() { return IsSetField(Tags.BenchmarkSecurityIDSource); }

    public YieldType YieldType
    {
        get
        {
            YieldType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldType val) { YieldType = val; }
    public YieldType Get(YieldType val) { GetField(val); return val; }
    public bool IsSet(YieldType val) { return IsSetYieldType(); }
    public bool IsSetYieldType() { return IsSetField(Tags.YieldType); }

    public Yield Yield
    {
        get
        {
            Yield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Yield val) { Yield = val; }
    public Yield Get(Yield val) { GetField(val); return val; }
    public bool IsSet(Yield val) { return IsSetYield(); }
    public bool IsSetYield() { return IsSetField(Tags.Yield); }

    public YieldCalcDate YieldCalcDate
    {
        get
        {
            YieldCalcDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldCalcDate val) { YieldCalcDate = val; }
    public YieldCalcDate Get(YieldCalcDate val) { GetField(val); return val; }
    public bool IsSet(YieldCalcDate val) { return IsSetYieldCalcDate(); }
    public bool IsSetYieldCalcDate() { return IsSetField(Tags.YieldCalcDate); }

    public YieldRedemptionDate YieldRedemptionDate
    {
        get
        {
            YieldRedemptionDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionDate val) { YieldRedemptionDate = val; }
    public YieldRedemptionDate Get(YieldRedemptionDate val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionDate val) { return IsSetYieldRedemptionDate(); }
    public bool IsSetYieldRedemptionDate() { return IsSetField(Tags.YieldRedemptionDate); }

    public YieldRedemptionPrice YieldRedemptionPrice
    {
        get
        {
            YieldRedemptionPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionPrice val) { YieldRedemptionPrice = val; }
    public YieldRedemptionPrice Get(YieldRedemptionPrice val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionPrice val) { return IsSetYieldRedemptionPrice(); }
    public bool IsSetYieldRedemptionPrice() { return IsSetField(Tags.YieldRedemptionPrice); }

    public YieldRedemptionPriceType YieldRedemptionPriceType
    {
        get
        {
            YieldRedemptionPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionPriceType val) { YieldRedemptionPriceType = val; }
    public YieldRedemptionPriceType Get(YieldRedemptionPriceType val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionPriceType val) { return IsSetYieldRedemptionPriceType(); }
    public bool IsSetYieldRedemptionPriceType() { return IsSetField(Tags.YieldRedemptionPriceType); }

    public GrossTradeAmt GrossTradeAmt
    {
        get
        {
            GrossTradeAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(GrossTradeAmt val) { GrossTradeAmt = val; }
    public GrossTradeAmt Get(GrossTradeAmt val) { GetField(val); return val; }
    public bool IsSet(GrossTradeAmt val) { return IsSetGrossTradeAmt(); }
    public bool IsSetGrossTradeAmt() { return IsSetField(Tags.GrossTradeAmt); }

    public NumDaysInterest NumDaysInterest
    {
        get
        {
            NumDaysInterest val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NumDaysInterest val) { NumDaysInterest = val; }
    public NumDaysInterest Get(NumDaysInterest val) { GetField(val); return val; }
    public bool IsSet(NumDaysInterest val) { return IsSetNumDaysInterest(); }
    public bool IsSetNumDaysInterest() { return IsSetField(Tags.NumDaysInterest); }

    public ExDate ExDate
    {
        get
        {
            ExDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExDate val) { ExDate = val; }
    public ExDate Get(ExDate val) { GetField(val); return val; }
    public bool IsSet(ExDate val) { return IsSetExDate(); }
    public bool IsSetExDate() { return IsSetField(Tags.ExDate); }

    public AccruedInterestRate AccruedInterestRate
    {
        get
        {
            AccruedInterestRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AccruedInterestRate val) { AccruedInterestRate = val; }
    public AccruedInterestRate Get(AccruedInterestRate val) { GetField(val); return val; }
    public bool IsSet(AccruedInterestRate val) { return IsSetAccruedInterestRate(); }
    public bool IsSetAccruedInterestRate() { return IsSetField(Tags.AccruedInterestRate); }

    public AccruedInterestAmt AccruedInterestAmt
    {
        get
        {
            AccruedInterestAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AccruedInterestAmt val) { AccruedInterestAmt = val; }
    public AccruedInterestAmt Get(AccruedInterestAmt val) { GetField(val); return val; }
    public bool IsSet(AccruedInterestAmt val) { return IsSetAccruedInterestAmt(); }
    public bool IsSetAccruedInterestAmt() { return IsSetField(Tags.AccruedInterestAmt); }

    public InterestAtMaturity InterestAtMaturity
    {
        get
        {
            InterestAtMaturity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterestAtMaturity val) { InterestAtMaturity = val; }
    public InterestAtMaturity Get(InterestAtMaturity val) { GetField(val); return val; }
    public bool IsSet(InterestAtMaturity val) { return IsSetInterestAtMaturity(); }
    public bool IsSetInterestAtMaturity() { return IsSetField(Tags.InterestAtMaturity); }

    public EndAccruedInterestAmt EndAccruedInterestAmt
    {
        get
        {
            EndAccruedInterestAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndAccruedInterestAmt val) { EndAccruedInterestAmt = val; }
    public EndAccruedInterestAmt Get(EndAccruedInterestAmt val) { GetField(val); return val; }
    public bool IsSet(EndAccruedInterestAmt val) { return IsSetEndAccruedInterestAmt(); }
    public bool IsSetEndAccruedInterestAmt() { return IsSetField(Tags.EndAccruedInterestAmt); }

    public StartCash StartCash
    {
        get
        {
            StartCash val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StartCash val) { StartCash = val; }
    public StartCash Get(StartCash val) { GetField(val); return val; }
    public bool IsSet(StartCash val) { return IsSetStartCash(); }
    public bool IsSetStartCash() { return IsSetField(Tags.StartCash); }

    public EndCash EndCash
    {
        get
        {
            EndCash val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndCash val) { EndCash = val; }
    public EndCash Get(EndCash val) { GetField(val); return val; }
    public bool IsSet(EndCash val) { return IsSetEndCash(); }
    public bool IsSetEndCash() { return IsSetField(Tags.EndCash); }

    public TradedFlatSwitch TradedFlatSwitch
    {
        get
        {
            TradedFlatSwitch val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradedFlatSwitch val) { TradedFlatSwitch = val; }
    public TradedFlatSwitch Get(TradedFlatSwitch val) { GetField(val); return val; }
    public bool IsSet(TradedFlatSwitch val) { return IsSetTradedFlatSwitch(); }
    public bool IsSetTradedFlatSwitch() { return IsSetField(Tags.TradedFlatSwitch); }

    public BasisFeatureDate BasisFeatureDate
    {
        get
        {
            BasisFeatureDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BasisFeatureDate val) { BasisFeatureDate = val; }
    public BasisFeatureDate Get(BasisFeatureDate val) { GetField(val); return val; }
    public bool IsSet(BasisFeatureDate val) { return IsSetBasisFeatureDate(); }
    public bool IsSetBasisFeatureDate() { return IsSetField(Tags.BasisFeatureDate); }

    public BasisFeaturePrice BasisFeaturePrice
    {
        get
        {
            BasisFeaturePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BasisFeaturePrice val) { BasisFeaturePrice = val; }
    public BasisFeaturePrice Get(BasisFeaturePrice val) { GetField(val); return val; }
    public bool IsSet(BasisFeaturePrice val) { return IsSetBasisFeaturePrice(); }
    public bool IsSetBasisFeaturePrice() { return IsSetField(Tags.BasisFeaturePrice); }

    public Concession Concession
    {
        get
        {
            Concession val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Concession val) { Concession = val; }
    public Concession Get(Concession val) { GetField(val); return val; }
    public bool IsSet(Concession val) { return IsSetConcession(); }
    public bool IsSetConcession() { return IsSetField(Tags.Concession); }

    public TotalTakedown TotalTakedown
    {
        get
        {
            TotalTakedown val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotalTakedown val) { TotalTakedown = val; }
    public TotalTakedown Get(TotalTakedown val) { GetField(val); return val; }
    public bool IsSet(TotalTakedown val) { return IsSetTotalTakedown(); }
    public bool IsSetTotalTakedown() { return IsSetField(Tags.TotalTakedown); }

    public NetMoney NetMoney
    {
        get
        {
            NetMoney val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NetMoney val) { NetMoney = val; }
    public NetMoney Get(NetMoney val) { GetField(val); return val; }
    public bool IsSet(NetMoney val) { return IsSetNetMoney(); }
    public bool IsSetNetMoney() { return IsSetField(Tags.NetMoney); }

    public SettlCurrAmt SettlCurrAmt
    {
        get
        {
            SettlCurrAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrAmt val) { SettlCurrAmt = val; }
    public SettlCurrAmt Get(SettlCurrAmt val) { GetField(val); return val; }
    public bool IsSet(SettlCurrAmt val) { return IsSetSettlCurrAmt(); }
    public bool IsSetSettlCurrAmt() { return IsSetField(Tags.SettlCurrAmt); }

    public SettlCurrency SettlCurrency
    {
        get
        {
            SettlCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrency val) { SettlCurrency = val; }
    public SettlCurrency Get(SettlCurrency val) { GetField(val); return val; }
    public bool IsSet(SettlCurrency val) { return IsSetSettlCurrency(); }
    public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }

    public SettlCurrFxRate SettlCurrFxRate
    {
        get
        {
            SettlCurrFxRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrFxRate val) { SettlCurrFxRate = val; }
    public SettlCurrFxRate Get(SettlCurrFxRate val) { GetField(val); return val; }
    public bool IsSet(SettlCurrFxRate val) { return IsSetSettlCurrFxRate(); }
    public bool IsSetSettlCurrFxRate() { return IsSetField(Tags.SettlCurrFxRate); }

    public SettlCurrFxRateCalc SettlCurrFxRateCalc
    {
        get
        {
            SettlCurrFxRateCalc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrFxRateCalc val) { SettlCurrFxRateCalc = val; }
    public SettlCurrFxRateCalc Get(SettlCurrFxRateCalc val) { GetField(val); return val; }
    public bool IsSet(SettlCurrFxRateCalc val) { return IsSetSettlCurrFxRateCalc(); }
    public bool IsSetSettlCurrFxRateCalc() { return IsSetField(Tags.SettlCurrFxRateCalc); }

    public HandlInst HandlInst
    {
        get
        {
            HandlInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HandlInst val) { HandlInst = val; }
    public HandlInst Get(HandlInst val) { GetField(val); return val; }
    public bool IsSet(HandlInst val) { return IsSetHandlInst(); }
    public bool IsSetHandlInst() { return IsSetField(Tags.HandlInst); }

    public MinQty MinQty
    {
        get
        {
            MinQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinQty val) { MinQty = val; }
    public MinQty Get(MinQty val) { GetField(val); return val; }
    public bool IsSet(MinQty val) { return IsSetMinQty(); }
    public bool IsSetMinQty() { return IsSetField(Tags.MinQty); }

    public MaxFloor MaxFloor
    {
        get
        {
            MaxFloor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxFloor val) { MaxFloor = val; }
    public MaxFloor Get(MaxFloor val) { GetField(val); return val; }
    public bool IsSet(MaxFloor val) { return IsSetMaxFloor(); }
    public bool IsSetMaxFloor() { return IsSetField(Tags.MaxFloor); }

    public PositionEffect PositionEffect
    {
        get
        {
            PositionEffect val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PositionEffect val) { PositionEffect = val; }
    public PositionEffect Get(PositionEffect val) { GetField(val); return val; }
    public bool IsSet(PositionEffect val) { return IsSetPositionEffect(); }
    public bool IsSetPositionEffect() { return IsSetField(Tags.PositionEffect); }

    public MaxShow MaxShow
    {
        get
        {
            MaxShow val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxShow val) { MaxShow = val; }
    public MaxShow Get(MaxShow val) { GetField(val); return val; }
    public bool IsSet(MaxShow val) { return IsSetMaxShow(); }
    public bool IsSetMaxShow() { return IsSetField(Tags.MaxShow); }

    public BookingType BookingType
    {
        get
        {
            BookingType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BookingType val) { BookingType = val; }
    public BookingType Get(BookingType val) { GetField(val); return val; }
    public bool IsSet(BookingType val) { return IsSetBookingType(); }
    public bool IsSetBookingType() { return IsSetField(Tags.BookingType); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

    public SettlDate2 SettlDate2
    {
        get
        {
            SettlDate2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlDate2 val) { SettlDate2 = val; }
    public SettlDate2 Get(SettlDate2 val) { GetField(val); return val; }
    public bool IsSet(SettlDate2 val) { return IsSetSettlDate2(); }
    public bool IsSetSettlDate2() { return IsSetField(Tags.SettlDate2); }

    public OrderQty2 OrderQty2
    {
        get
        {
            OrderQty2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderQty2 val) { OrderQty2 = val; }
    public OrderQty2 Get(OrderQty2 val) { GetField(val); return val; }
    public bool IsSet(OrderQty2 val) { return IsSetOrderQty2(); }
    public bool IsSetOrderQty2() { return IsSetField(Tags.OrderQty2); }

    public LastForwardPoints2 LastForwardPoints2
    {
        get
        {
            LastForwardPoints2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastForwardPoints2 val) { LastForwardPoints2 = val; }
    public LastForwardPoints2 Get(LastForwardPoints2 val) { GetField(val); return val; }
    public bool IsSet(LastForwardPoints2 val) { return IsSetLastForwardPoints2(); }
    public bool IsSetLastForwardPoints2() { return IsSetField(Tags.LastForwardPoints2); }

    public MultiLegReportingType MultiLegReportingType
    {
        get
        {
            MultiLegReportingType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MultiLegReportingType val) { MultiLegReportingType = val; }
    public MultiLegReportingType Get(MultiLegReportingType val) { GetField(val); return val; }
    public bool IsSet(MultiLegReportingType val) { return IsSetMultiLegReportingType(); }
    public bool IsSetMultiLegReportingType() { return IsSetField(Tags.MultiLegReportingType); }

    public CancellationRights CancellationRights
    {
        get
        {
            CancellationRights val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CancellationRights val) { CancellationRights = val; }
    public CancellationRights Get(CancellationRights val) { GetField(val); return val; }
    public bool IsSet(CancellationRights val) { return IsSetCancellationRights(); }
    public bool IsSetCancellationRights() { return IsSetField(Tags.CancellationRights); }

    public MoneyLaunderingStatus MoneyLaunderingStatus
    {
        get
        {
            MoneyLaunderingStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MoneyLaunderingStatus val) { MoneyLaunderingStatus = val; }
    public MoneyLaunderingStatus Get(MoneyLaunderingStatus val) { GetField(val); return val; }
    public bool IsSet(MoneyLaunderingStatus val) { return IsSetMoneyLaunderingStatus(); }
    public bool IsSetMoneyLaunderingStatus() { return IsSetField(Tags.MoneyLaunderingStatus); }

    public RegistID RegistID
    {
        get
        {
            RegistID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistID val) { RegistID = val; }
    public RegistID Get(RegistID val) { GetField(val); return val; }
    public bool IsSet(RegistID val) { return IsSetRegistID(); }
    public bool IsSetRegistID() { return IsSetField(Tags.RegistID); }

    public Designation Designation
    {
        get
        {
            Designation val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Designation val) { Designation = val; }
    public Designation Get(Designation val) { GetField(val); return val; }
    public bool IsSet(Designation val) { return IsSetDesignation(); }
    public bool IsSetDesignation() { return IsSetField(Tags.Designation); }

    public TransBkdTime TransBkdTime
    {
        get
        {
            TransBkdTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransBkdTime val) { TransBkdTime = val; }
    public TransBkdTime Get(TransBkdTime val) { GetField(val); return val; }
    public bool IsSet(TransBkdTime val) { return IsSetTransBkdTime(); }
    public bool IsSetTransBkdTime() { return IsSetField(Tags.TransBkdTime); }

    public ExecValuationPoint ExecValuationPoint
    {
        get
        {
            ExecValuationPoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecValuationPoint val) { ExecValuationPoint = val; }
    public ExecValuationPoint Get(ExecValuationPoint val) { GetField(val); return val; }
    public bool IsSet(ExecValuationPoint val) { return IsSetExecValuationPoint(); }
    public bool IsSetExecValuationPoint() { return IsSetField(Tags.ExecValuationPoint); }

    public ExecPriceType ExecPriceType
    {
        get
        {
            ExecPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecPriceType val) { ExecPriceType = val; }
    public ExecPriceType Get(ExecPriceType val) { GetField(val); return val; }
    public bool IsSet(ExecPriceType val) { return IsSetExecPriceType(); }
    public bool IsSetExecPriceType() { return IsSetField(Tags.ExecPriceType); }

    public ExecPriceAdjustment ExecPriceAdjustment
    {
        get
        {
            ExecPriceAdjustment val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecPriceAdjustment val) { ExecPriceAdjustment = val; }
    public ExecPriceAdjustment Get(ExecPriceAdjustment val) { GetField(val); return val; }
    public bool IsSet(ExecPriceAdjustment val) { return IsSetExecPriceAdjustment(); }
    public bool IsSetExecPriceAdjustment() { return IsSetField(Tags.ExecPriceAdjustment); }

    public PriorityIndicator PriorityIndicator
    {
        get
        {
            PriorityIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriorityIndicator val) { PriorityIndicator = val; }
    public PriorityIndicator Get(PriorityIndicator val) { GetField(val); return val; }
    public bool IsSet(PriorityIndicator val) { return IsSetPriorityIndicator(); }
    public bool IsSetPriorityIndicator() { return IsSetField(Tags.PriorityIndicator); }

    public PriceImprovement PriceImprovement
    {
        get
        {
            PriceImprovement val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceImprovement val) { PriceImprovement = val; }
    public PriceImprovement Get(PriceImprovement val) { GetField(val); return val; }
    public bool IsSet(PriceImprovement val) { return IsSetPriceImprovement(); }
    public bool IsSetPriceImprovement() { return IsSetField(Tags.PriceImprovement); }

    public LastLiquidityInd LastLiquidityInd
    {
        get
        {
            LastLiquidityInd val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastLiquidityInd val) { LastLiquidityInd = val; }
    public LastLiquidityInd Get(LastLiquidityInd val) { GetField(val); return val; }
    public bool IsSet(LastLiquidityInd val) { return IsSetLastLiquidityInd(); }
    public bool IsSetLastLiquidityInd() { return IsSetField(Tags.LastLiquidityInd); }

    public NoContAmts NoContAmts
    {
        get
        {
            NoContAmts val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoContAmts val) { NoContAmts = val; }
    public NoContAmts Get(NoContAmts val) { GetField(val); return val; }
    public bool IsSet(NoContAmts val) { return IsSetNoContAmts(); }
    public bool IsSetNoContAmts() { return IsSetField(Tags.NoContAmts); }

    public NoLegs NoLegs
    {
        get
        {
            NoLegs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoLegs val) { NoLegs = val; }
    public NoLegs Get(NoLegs val) { GetField(val); return val; }
    public bool IsSet(NoLegs val) { return IsSetNoLegs(); }
    public bool IsSetNoLegs() { return IsSetField(Tags.NoLegs); }

    public CopyMsgIndicator CopyMsgIndicator
    {
        get
        {
            CopyMsgIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CopyMsgIndicator val) { CopyMsgIndicator = val; }
    public CopyMsgIndicator Get(CopyMsgIndicator val) { GetField(val); return val; }
    public bool IsSet(CopyMsgIndicator val) { return IsSetCopyMsgIndicator(); }
    public bool IsSetCopyMsgIndicator() { return IsSetField(Tags.CopyMsgIndicator); }

    public NoMiscFees NoMiscFees
    {
        get
        {
            NoMiscFees val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoMiscFees val) { NoMiscFees = val; }
    public NoMiscFees Get(NoMiscFees val) { GetField(val); return val; }
    public bool IsSet(NoMiscFees val) { return IsSetNoMiscFees(); }
    public bool IsSetNoMiscFees() { return IsSetField(Tags.NoMiscFees); }

    public NoStrategyParameters NoStrategyParameters
    {
        get
        {
            NoStrategyParameters val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoStrategyParameters val) { NoStrategyParameters = val; }
    public NoStrategyParameters Get(NoStrategyParameters val) { GetField(val); return val; }
    public bool IsSet(NoStrategyParameters val) { return IsSetNoStrategyParameters(); }
    public bool IsSetNoStrategyParameters() { return IsSetField(Tags.NoStrategyParameters); }

    public HostCrossID HostCrossID
    {
        get
        {
            HostCrossID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HostCrossID val) { HostCrossID = val; }
    public HostCrossID Get(HostCrossID val) { GetField(val); return val; }
    public bool IsSet(HostCrossID val) { return IsSetHostCrossID(); }
    public bool IsSetHostCrossID() { return IsSetField(Tags.HostCrossID); }

    public ManualOrderIndicator ManualOrderIndicator
    {
        get
        {
            ManualOrderIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ManualOrderIndicator val) { ManualOrderIndicator = val; }
    public ManualOrderIndicator Get(ManualOrderIndicator val) { GetField(val); return val; }
    public bool IsSet(ManualOrderIndicator val) { return IsSetManualOrderIndicator(); }
    public bool IsSetManualOrderIndicator() { return IsSetField(Tags.ManualOrderIndicator); }

    public CustDirectedOrder CustDirectedOrder
    {
        get
        {
            CustDirectedOrder val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustDirectedOrder val) { CustDirectedOrder = val; }
    public CustDirectedOrder Get(CustDirectedOrder val) { GetField(val); return val; }
    public bool IsSet(CustDirectedOrder val) { return IsSetCustDirectedOrder(); }
    public bool IsSetCustDirectedOrder() { return IsSetField(Tags.CustDirectedOrder); }

    public ReceivedDeptID ReceivedDeptID
    {
        get
        {
            ReceivedDeptID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ReceivedDeptID val) { ReceivedDeptID = val; }
    public ReceivedDeptID Get(ReceivedDeptID val) { GetField(val); return val; }
    public bool IsSet(ReceivedDeptID val) { return IsSetReceivedDeptID(); }
    public bool IsSetReceivedDeptID() { return IsSetField(Tags.ReceivedDeptID); }

    public CustOrderHandlingInst CustOrderHandlingInst
    {
        get
        {
            CustOrderHandlingInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustOrderHandlingInst val) { CustOrderHandlingInst = val; }
    public CustOrderHandlingInst Get(CustOrderHandlingInst val) { GetField(val); return val; }
    public bool IsSet(CustOrderHandlingInst val) { return IsSetCustOrderHandlingInst(); }
    public bool IsSetCustOrderHandlingInst() { return IsSetField(Tags.CustOrderHandlingInst); }

    public OrderHandlingInstSource OrderHandlingInstSource
    {
        get
        {
            OrderHandlingInstSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderHandlingInstSource val) { OrderHandlingInstSource = val; }
    public OrderHandlingInstSource Get(OrderHandlingInstSource val) { GetField(val); return val; }
    public bool IsSet(OrderHandlingInstSource val) { return IsSetOrderHandlingInstSource(); }
    public bool IsSetOrderHandlingInstSource() { return IsSetField(Tags.OrderHandlingInstSource); }

    public NoTrdRegTimestamps NoTrdRegTimestamps
    {
        get
        {
            NoTrdRegTimestamps val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTrdRegTimestamps val) { NoTrdRegTimestamps = val; }
    public NoTrdRegTimestamps Get(NoTrdRegTimestamps val) { GetField(val); return val; }
    public bool IsSet(NoTrdRegTimestamps val) { return IsSetNoTrdRegTimestamps(); }
    public bool IsSetNoTrdRegTimestamps() { return IsSetField(Tags.NoTrdRegTimestamps); }

    public AggressorIndicator AggressorIndicator
    {
        get
        {
            AggressorIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AggressorIndicator val) { AggressorIndicator = val; }
    public AggressorIndicator Get(AggressorIndicator val) { GetField(val); return val; }
    public bool IsSet(AggressorIndicator val) { return IsSetAggressorIndicator(); }
    public bool IsSetAggressorIndicator() { return IsSetField(Tags.AggressorIndicator); }

    public CalculatedCcyLastQty CalculatedCcyLastQty
    {
        get
        {
            CalculatedCcyLastQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CalculatedCcyLastQty val) { CalculatedCcyLastQty = val; }
    public CalculatedCcyLastQty Get(CalculatedCcyLastQty val) { GetField(val); return val; }
    public bool IsSet(CalculatedCcyLastQty val) { return IsSetCalculatedCcyLastQty(); }
    public bool IsSetCalculatedCcyLastQty() { return IsSetField(Tags.CalculatedCcyLastQty); }

    public LastSwapPoints LastSwapPoints
    {
        get
        {
            LastSwapPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastSwapPoints val) { LastSwapPoints = val; }
    public LastSwapPoints Get(LastSwapPoints val) { GetField(val); return val; }
    public bool IsSet(LastSwapPoints val) { return IsSetLastSwapPoints(); }
    public bool IsSetLastSwapPoints() { return IsSetField(Tags.LastSwapPoints); }

    public MatchType MatchType
    {
        get
        {
            MatchType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MatchType val) { MatchType = val; }
    public MatchType Get(MatchType val) { GetField(val); return val; }
    public bool IsSet(MatchType val) { return IsSetMatchType(); }
    public bool IsSetMatchType() { return IsSetField(Tags.MatchType); }

    public OrderCategory OrderCategory
    {
        get
        {
            OrderCategory val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderCategory val) { OrderCategory = val; }
    public OrderCategory Get(OrderCategory val) { GetField(val); return val; }
    public bool IsSet(OrderCategory val) { return IsSetOrderCategory(); }
    public bool IsSetOrderCategory() { return IsSetField(Tags.OrderCategory); }

    public LotType LotType
    {
        get
        {
            LotType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LotType val) { LotType = val; }
    public LotType Get(LotType val) { GetField(val); return val; }
    public bool IsSet(LotType val) { return IsSetLotType(); }
    public bool IsSetLotType() { return IsSetField(Tags.LotType); }

    public PriceProtectionScope PriceProtectionScope
    {
        get
        {
            PriceProtectionScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceProtectionScope val) { PriceProtectionScope = val; }
    public PriceProtectionScope Get(PriceProtectionScope val) { GetField(val); return val; }
    public bool IsSet(PriceProtectionScope val) { return IsSetPriceProtectionScope(); }
    public bool IsSetPriceProtectionScope() { return IsSetField(Tags.PriceProtectionScope); }

    public TriggerType TriggerType
    {
        get
        {
            TriggerType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerType val) { TriggerType = val; }
    public TriggerType Get(TriggerType val) { GetField(val); return val; }
    public bool IsSet(TriggerType val) { return IsSetTriggerType(); }
    public bool IsSetTriggerType() { return IsSetField(Tags.TriggerType); }

    public TriggerAction TriggerAction
    {
        get
        {
            TriggerAction val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerAction val) { TriggerAction = val; }
    public TriggerAction Get(TriggerAction val) { GetField(val); return val; }
    public bool IsSet(TriggerAction val) { return IsSetTriggerAction(); }
    public bool IsSetTriggerAction() { return IsSetField(Tags.TriggerAction); }

    public TriggerPrice TriggerPrice
    {
        get
        {
            TriggerPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerPrice val) { TriggerPrice = val; }
    public TriggerPrice Get(TriggerPrice val) { GetField(val); return val; }
    public bool IsSet(TriggerPrice val) { return IsSetTriggerPrice(); }
    public bool IsSetTriggerPrice() { return IsSetField(Tags.TriggerPrice); }

    public TriggerSymbol TriggerSymbol
    {
        get
        {
            TriggerSymbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerSymbol val) { TriggerSymbol = val; }
    public TriggerSymbol Get(TriggerSymbol val) { GetField(val); return val; }
    public bool IsSet(TriggerSymbol val) { return IsSetTriggerSymbol(); }
    public bool IsSetTriggerSymbol() { return IsSetField(Tags.TriggerSymbol); }

    public TriggerSecurityID TriggerSecurityID
    {
        get
        {
            TriggerSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerSecurityID val) { TriggerSecurityID = val; }
    public TriggerSecurityID Get(TriggerSecurityID val) { GetField(val); return val; }
    public bool IsSet(TriggerSecurityID val) { return IsSetTriggerSecurityID(); }
    public bool IsSetTriggerSecurityID() { return IsSetField(Tags.TriggerSecurityID); }

    public TriggerSecurityIDSource TriggerSecurityIDSource
    {
        get
        {
            TriggerSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerSecurityIDSource val) { TriggerSecurityIDSource = val; }
    public TriggerSecurityIDSource Get(TriggerSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(TriggerSecurityIDSource val) { return IsSetTriggerSecurityIDSource(); }
    public bool IsSetTriggerSecurityIDSource() { return IsSetField(Tags.TriggerSecurityIDSource); }

    public TriggerSecurityDesc TriggerSecurityDesc
    {
        get
        {
            TriggerSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerSecurityDesc val) { TriggerSecurityDesc = val; }
    public TriggerSecurityDesc Get(TriggerSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(TriggerSecurityDesc val) { return IsSetTriggerSecurityDesc(); }
    public bool IsSetTriggerSecurityDesc() { return IsSetField(Tags.TriggerSecurityDesc); }

    public TriggerPriceType TriggerPriceType
    {
        get
        {
            TriggerPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerPriceType val) { TriggerPriceType = val; }
    public TriggerPriceType Get(TriggerPriceType val) { GetField(val); return val; }
    public bool IsSet(TriggerPriceType val) { return IsSetTriggerPriceType(); }
    public bool IsSetTriggerPriceType() { return IsSetField(Tags.TriggerPriceType); }

    public TriggerPriceTypeScope TriggerPriceTypeScope
    {
        get
        {
            TriggerPriceTypeScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerPriceTypeScope val) { TriggerPriceTypeScope = val; }
    public TriggerPriceTypeScope Get(TriggerPriceTypeScope val) { GetField(val); return val; }
    public bool IsSet(TriggerPriceTypeScope val) { return IsSetTriggerPriceTypeScope(); }
    public bool IsSetTriggerPriceTypeScope() { return IsSetField(Tags.TriggerPriceTypeScope); }

    public TriggerPriceDirection TriggerPriceDirection
    {
        get
        {
            TriggerPriceDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerPriceDirection val) { TriggerPriceDirection = val; }
    public TriggerPriceDirection Get(TriggerPriceDirection val) { GetField(val); return val; }
    public bool IsSet(TriggerPriceDirection val) { return IsSetTriggerPriceDirection(); }
    public bool IsSetTriggerPriceDirection() { return IsSetField(Tags.TriggerPriceDirection); }

    public TriggerNewPrice TriggerNewPrice
    {
        get
        {
            TriggerNewPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerNewPrice val) { TriggerNewPrice = val; }
    public TriggerNewPrice Get(TriggerNewPrice val) { GetField(val); return val; }
    public bool IsSet(TriggerNewPrice val) { return IsSetTriggerNewPrice(); }
    public bool IsSetTriggerNewPrice() { return IsSetField(Tags.TriggerNewPrice); }

    public TriggerOrderType TriggerOrderType
    {
        get
        {
            TriggerOrderType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerOrderType val) { TriggerOrderType = val; }
    public TriggerOrderType Get(TriggerOrderType val) { GetField(val); return val; }
    public bool IsSet(TriggerOrderType val) { return IsSetTriggerOrderType(); }
    public bool IsSetTriggerOrderType() { return IsSetField(Tags.TriggerOrderType); }

    public TriggerNewQty TriggerNewQty
    {
        get
        {
            TriggerNewQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerNewQty val) { TriggerNewQty = val; }
    public TriggerNewQty Get(TriggerNewQty val) { GetField(val); return val; }
    public bool IsSet(TriggerNewQty val) { return IsSetTriggerNewQty(); }
    public bool IsSetTriggerNewQty() { return IsSetField(Tags.TriggerNewQty); }

    public TriggerTradingSessionID TriggerTradingSessionID
    {
        get
        {
            TriggerTradingSessionID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerTradingSessionID val) { TriggerTradingSessionID = val; }
    public TriggerTradingSessionID Get(TriggerTradingSessionID val) { GetField(val); return val; }
    public bool IsSet(TriggerTradingSessionID val) { return IsSetTriggerTradingSessionID(); }
    public bool IsSetTriggerTradingSessionID() { return IsSetField(Tags.TriggerTradingSessionID); }

    public TriggerTradingSessionSubID TriggerTradingSessionSubID
    {
        get
        {
            TriggerTradingSessionSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerTradingSessionSubID val) { TriggerTradingSessionSubID = val; }
    public TriggerTradingSessionSubID Get(TriggerTradingSessionSubID val) { GetField(val); return val; }
    public bool IsSet(TriggerTradingSessionSubID val) { return IsSetTriggerTradingSessionSubID(); }
    public bool IsSetTriggerTradingSessionSubID() { return IsSetField(Tags.TriggerTradingSessionSubID); }

    public PeggedRefPrice PeggedRefPrice
    {
        get
        {
            PeggedRefPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PeggedRefPrice val) { PeggedRefPrice = val; }
    public PeggedRefPrice Get(PeggedRefPrice val) { GetField(val); return val; }
    public bool IsSet(PeggedRefPrice val) { return IsSetPeggedRefPrice(); }
    public bool IsSetPeggedRefPrice() { return IsSetField(Tags.PeggedRefPrice); }

    public PreTradeAnonymity PreTradeAnonymity
    {
        get
        {
            PreTradeAnonymity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PreTradeAnonymity val) { PreTradeAnonymity = val; }
    public PreTradeAnonymity Get(PreTradeAnonymity val) { GetField(val); return val; }
    public bool IsSet(PreTradeAnonymity val) { return IsSetPreTradeAnonymity(); }
    public bool IsSetPreTradeAnonymity() { return IsSetField(Tags.PreTradeAnonymity); }

    public MatchIncrement MatchIncrement
    {
        get
        {
            MatchIncrement val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MatchIncrement val) { MatchIncrement = val; }
    public MatchIncrement Get(MatchIncrement val) { GetField(val); return val; }
    public bool IsSet(MatchIncrement val) { return IsSetMatchIncrement(); }
    public bool IsSetMatchIncrement() { return IsSetField(Tags.MatchIncrement); }

    public MaxPriceLevels MaxPriceLevels
    {
        get
        {
            MaxPriceLevels val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxPriceLevels val) { MaxPriceLevels = val; }
    public MaxPriceLevels Get(MaxPriceLevels val) { GetField(val); return val; }
    public bool IsSet(MaxPriceLevels val) { return IsSetMaxPriceLevels(); }
    public bool IsSetMaxPriceLevels() { return IsSetField(Tags.MaxPriceLevels); }

    public SecondaryDisplayQty SecondaryDisplayQty
    {
        get
        {
            SecondaryDisplayQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryDisplayQty val) { SecondaryDisplayQty = val; }
    public SecondaryDisplayQty Get(SecondaryDisplayQty val) { GetField(val); return val; }
    public bool IsSet(SecondaryDisplayQty val) { return IsSetSecondaryDisplayQty(); }
    public bool IsSetSecondaryDisplayQty() { return IsSetField(Tags.SecondaryDisplayQty); }

    public DisplayWhen DisplayWhen
    {
        get
        {
            DisplayWhen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayWhen val) { DisplayWhen = val; }
    public DisplayWhen Get(DisplayWhen val) { GetField(val); return val; }
    public bool IsSet(DisplayWhen val) { return IsSetDisplayWhen(); }
    public bool IsSetDisplayWhen() { return IsSetField(Tags.DisplayWhen); }

    public DisplayMethod DisplayMethod
    {
        get
        {
            DisplayMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayMethod val) { DisplayMethod = val; }
    public DisplayMethod Get(DisplayMethod val) { GetField(val); return val; }
    public bool IsSet(DisplayMethod val) { return IsSetDisplayMethod(); }
    public bool IsSetDisplayMethod() { return IsSetField(Tags.DisplayMethod); }

    public DisplayLowQty DisplayLowQty
    {
        get
        {
            DisplayLowQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayLowQty val) { DisplayLowQty = val; }
    public DisplayLowQty Get(DisplayLowQty val) { GetField(val); return val; }
    public bool IsSet(DisplayLowQty val) { return IsSetDisplayLowQty(); }
    public bool IsSetDisplayLowQty() { return IsSetField(Tags.DisplayLowQty); }

    public DisplayHighQty DisplayHighQty
    {
        get
        {
            DisplayHighQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayHighQty val) { DisplayHighQty = val; }
    public DisplayHighQty Get(DisplayHighQty val) { GetField(val); return val; }
    public bool IsSet(DisplayHighQty val) { return IsSetDisplayHighQty(); }
    public bool IsSetDisplayHighQty() { return IsSetField(Tags.DisplayHighQty); }

    public DisplayMinIncr DisplayMinIncr
    {
        get
        {
            DisplayMinIncr val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayMinIncr val) { DisplayMinIncr = val; }
    public DisplayMinIncr Get(DisplayMinIncr val) { GetField(val); return val; }
    public bool IsSet(DisplayMinIncr val) { return IsSetDisplayMinIncr(); }
    public bool IsSetDisplayMinIncr() { return IsSetField(Tags.DisplayMinIncr); }

    public RefreshQty RefreshQty
    {
        get
        {
            RefreshQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefreshQty val) { RefreshQty = val; }
    public RefreshQty Get(RefreshQty val) { GetField(val); return val; }
    public bool IsSet(RefreshQty val) { return IsSetRefreshQty(); }
    public bool IsSetRefreshQty() { return IsSetField(Tags.RefreshQty); }

    public DisplayQty DisplayQty
    {
        get
        {
            DisplayQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayQty val) { DisplayQty = val; }
    public DisplayQty Get(DisplayQty val) { GetField(val); return val; }
    public bool IsSet(DisplayQty val) { return IsSetDisplayQty(); }
    public bool IsSetDisplayQty() { return IsSetField(Tags.DisplayQty); }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

        public NoPartyIDsGroup()
          : base(Tags.NoPartyIDs, Tags.PartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyID PartyID
        {
            get
            {
                PartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyID val) { PartyID = val; }
        public PartyID Get(PartyID val) { GetField(val); return val; }
        public bool IsSet(PartyID val) { return IsSetPartyID(); }
        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public PartyIDSource PartyIDSource
        {
            get
            {
                PartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyIDSource val) { PartyIDSource = val; }
        public PartyIDSource Get(PartyIDSource val) { GetField(val); return val; }
        public bool IsSet(PartyIDSource val) { return IsSetPartyIDSource(); }
        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public PartyRole PartyRole
        {
            get
            {
                PartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRole val) { PartyRole = val; }
        public PartyRole Get(PartyRole val) { GetField(val); return val; }
        public bool IsSet(PartyRole val) { return IsSetPartyRole(); }
        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public NoPartySubIDs NoPartySubIDs
        {
            get
            {
                NoPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoPartySubIDs val) { NoPartySubIDs = val; }
        public NoPartySubIDs Get(NoPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoPartySubIDs val) { return IsSetNoPartySubIDs(); }
        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }

        public class NoPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartySubID, Tags.PartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup()
              : base(Tags.NoPartySubIDs, Tags.PartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public PartySubID PartySubID
            {
                get
                {
                    PartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubID val) { PartySubID = val; }
            public PartySubID Get(PartySubID val) { GetField(val); return val; }
            public bool IsSet(PartySubID val) { return IsSetPartySubID(); }
            public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }

            public PartySubIDType PartySubIDType
            {
                get
                {
                    PartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubIDType val) { PartySubIDType = val; }
            public PartySubIDType Get(PartySubIDType val) { GetField(val); return val; }
            public bool IsSet(PartySubIDType val) { return IsSetPartySubIDType(); }
            public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }
        }
    }

    public class NoContraBrokersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ContraBroker, Tags.ContraTrader, Tags.ContraTradeQty, Tags.ContraTradeTime, Tags.ContraLegRefID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ContraBroker, Tags.ContraTrader, Tags.ContraTradeQty, Tags.ContraTradeTime, Tags.ContraLegRefID, 0};

        public NoContraBrokersGroup()
          : base(Tags.NoContraBrokers, Tags.ContraBroker, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoContraBrokersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ContraBroker ContraBroker
        {
            get
            {
                ContraBroker val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraBroker val) { ContraBroker = val; }
        public ContraBroker Get(ContraBroker val) { GetField(val); return val; }
        public bool IsSet(ContraBroker val) { return IsSetContraBroker(); }
        public bool IsSetContraBroker() { return IsSetField(Tags.ContraBroker); }

        public ContraTrader ContraTrader
        {
            get
            {
                ContraTrader val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraTrader val) { ContraTrader = val; }
        public ContraTrader Get(ContraTrader val) { GetField(val); return val; }
        public bool IsSet(ContraTrader val) { return IsSetContraTrader(); }
        public bool IsSetContraTrader() { return IsSetField(Tags.ContraTrader); }

        public ContraTradeQty ContraTradeQty
        {
            get
            {
                ContraTradeQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraTradeQty val) { ContraTradeQty = val; }
        public ContraTradeQty Get(ContraTradeQty val) { GetField(val); return val; }
        public bool IsSet(ContraTradeQty val) { return IsSetContraTradeQty(); }
        public bool IsSetContraTradeQty() { return IsSetField(Tags.ContraTradeQty); }

        public ContraTradeTime ContraTradeTime
        {
            get
            {
                ContraTradeTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraTradeTime val) { ContraTradeTime = val; }
        public ContraTradeTime Get(ContraTradeTime val) { GetField(val); return val; }
        public bool IsSet(ContraTradeTime val) { return IsSetContraTradeTime(); }
        public bool IsSetContraTradeTime() { return IsSetField(Tags.ContraTradeTime); }

        public ContraLegRefID ContraLegRefID
        {
            get
            {
                ContraLegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraLegRefID val) { ContraLegRefID = val; }
        public ContraLegRefID Get(ContraLegRefID val) { GetField(val); return val; }
        public bool IsSet(ContraLegRefID val) { return IsSetContraLegRefID(); }
        public bool IsSetContraLegRefID() { return IsSetField(Tags.ContraLegRefID); }
    }

    public class NoSecurityAltIDGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.SecurityAltID, Tags.SecurityAltIDSource, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

        public NoSecurityAltIDGroup()
          : base(Tags.NoSecurityAltID, Tags.SecurityAltID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSecurityAltIDGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public SecurityAltID SecurityAltID
        {
            get
            {
                SecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityAltID val) { SecurityAltID = val; }
        public SecurityAltID Get(SecurityAltID val) { GetField(val); return val; }
        public bool IsSet(SecurityAltID val) { return IsSetSecurityAltID(); }
        public bool IsSetSecurityAltID() { return IsSetField(Tags.SecurityAltID); }

        public SecurityAltIDSource SecurityAltIDSource
        {
            get
            {
                SecurityAltIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityAltIDSource val) { SecurityAltIDSource = val; }
        public SecurityAltIDSource Get(SecurityAltIDSource val) { GetField(val); return val; }
        public bool IsSet(SecurityAltIDSource val) { return IsSetSecurityAltIDSource(); }
        public bool IsSetSecurityAltIDSource() { return IsSetField(Tags.SecurityAltIDSource); }
    }

    public class NoEventsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0};

        public NoEventsGroup()
          : base(Tags.NoEvents, Tags.EventType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoEventsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public EventType EventType
        {
            get
            {
                EventType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventType val) { EventType = val; }
        public EventType Get(EventType val) { GetField(val); return val; }
        public bool IsSet(EventType val) { return IsSetEventType(); }
        public bool IsSetEventType() { return IsSetField(Tags.EventType); }

        public EventDate EventDate
        {
            get
            {
                EventDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventDate val) { EventDate = val; }
        public EventDate Get(EventDate val) { GetField(val); return val; }
        public bool IsSet(EventDate val) { return IsSetEventDate(); }
        public bool IsSetEventDate() { return IsSetField(Tags.EventDate); }

        public EventPx EventPx
        {
            get
            {
                EventPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventPx val) { EventPx = val; }
        public EventPx Get(EventPx val) { GetField(val); return val; }
        public bool IsSet(EventPx val) { return IsSetEventPx(); }
        public bool IsSetEventPx() { return IsSetField(Tags.EventPx); }

        public EventText EventText
        {
            get
            {
                EventText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventText val) { EventText = val; }
        public EventText Get(EventText val) { GetField(val); return val; }
        public bool IsSet(EventText val) { return IsSetEventText(); }
        public bool IsSetEventText() { return IsSetField(Tags.EventText); }
    }

    public class NoInstrumentPartiesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};

        public NoInstrumentPartiesGroup()
          : base(Tags.NoInstrumentParties, Tags.InstrumentPartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoInstrumentPartiesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public InstrumentPartyID InstrumentPartyID
        {
            get
            {
                InstrumentPartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyID val) { InstrumentPartyID = val; }
        public InstrumentPartyID Get(InstrumentPartyID val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyID val) { return IsSetInstrumentPartyID(); }
        public bool IsSetInstrumentPartyID() { return IsSetField(Tags.InstrumentPartyID); }

        public InstrumentPartyIDSource InstrumentPartyIDSource
        {
            get
            {
                InstrumentPartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyIDSource val) { InstrumentPartyIDSource = val; }
        public InstrumentPartyIDSource Get(InstrumentPartyIDSource val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyIDSource val) { return IsSetInstrumentPartyIDSource(); }
        public bool IsSetInstrumentPartyIDSource() { return IsSetField(Tags.InstrumentPartyIDSource); }

        public InstrumentPartyRole InstrumentPartyRole
        {
            get
            {
                InstrumentPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyRole val) { InstrumentPartyRole = val; }
        public InstrumentPartyRole Get(InstrumentPartyRole val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyRole val) { return IsSetInstrumentPartyRole(); }
        public bool IsSetInstrumentPartyRole() { return IsSetField(Tags.InstrumentPartyRole); }

        public NoInstrumentPartySubIDs NoInstrumentPartySubIDs
        {
            get
            {
                NoInstrumentPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoInstrumentPartySubIDs val) { NoInstrumentPartySubIDs = val; }
        public NoInstrumentPartySubIDs Get(NoInstrumentPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoInstrumentPartySubIDs val) { return IsSetNoInstrumentPartySubIDs(); }
        public bool IsSetNoInstrumentPartySubIDs() { return IsSetField(Tags.NoInstrumentPartySubIDs); }

        public class NoInstrumentPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};

            public NoInstrumentPartySubIDsGroup()
              : base(Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public InstrumentPartySubID InstrumentPartySubID
            {
                get
                {
                    InstrumentPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartySubID val) { InstrumentPartySubID = val; }
            public InstrumentPartySubID Get(InstrumentPartySubID val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartySubID val) { return IsSetInstrumentPartySubID(); }
            public bool IsSetInstrumentPartySubID() { return IsSetField(Tags.InstrumentPartySubID); }

            public InstrumentPartySubIDType InstrumentPartySubIDType
            {
                get
                {
                    InstrumentPartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartySubIDType val) { InstrumentPartySubIDType = val; }
            public InstrumentPartySubIDType Get(InstrumentPartySubIDType val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartySubIDType val) { return IsSetInstrumentPartySubIDType(); }
            public bool IsSetInstrumentPartySubIDType() { return IsSetField(Tags.InstrumentPartySubIDType); }
        }
    }

    public class NoUnderlyingsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, 0};

        public NoUnderlyingsGroup()
          : base(Tags.NoUnderlyings, Tags.UnderlyingSymbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUnderlyingsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public UnderlyingSymbol UnderlyingSymbol
        {
            get
            {
                UnderlyingSymbol val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSymbol val) { UnderlyingSymbol = val; }
        public UnderlyingSymbol Get(UnderlyingSymbol val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSymbol val) { return IsSetUnderlyingSymbol(); }
        public bool IsSetUnderlyingSymbol() { return IsSetField(Tags.UnderlyingSymbol); }

        public UnderlyingSymbolSfx UnderlyingSymbolSfx
        {
            get
            {
                UnderlyingSymbolSfx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSymbolSfx val) { UnderlyingSymbolSfx = val; }
        public UnderlyingSymbolSfx Get(UnderlyingSymbolSfx val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSymbolSfx val) { return IsSetUnderlyingSymbolSfx(); }
        public bool IsSetUnderlyingSymbolSfx() { return IsSetField(Tags.UnderlyingSymbolSfx); }

        public UnderlyingSecurityID UnderlyingSecurityID
        {
            get
            {
                UnderlyingSecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityID val) { UnderlyingSecurityID = val; }
        public UnderlyingSecurityID Get(UnderlyingSecurityID val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityID val) { return IsSetUnderlyingSecurityID(); }
        public bool IsSetUnderlyingSecurityID() { return IsSetField(Tags.UnderlyingSecurityID); }

        public UnderlyingSecurityIDSource UnderlyingSecurityIDSource
        {
            get
            {
                UnderlyingSecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityIDSource val) { UnderlyingSecurityIDSource = val; }
        public UnderlyingSecurityIDSource Get(UnderlyingSecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityIDSource val) { return IsSetUnderlyingSecurityIDSource(); }
        public bool IsSetUnderlyingSecurityIDSource() { return IsSetField(Tags.UnderlyingSecurityIDSource); }

        public NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
        {
            get
            {
                NoUnderlyingSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUnderlyingSecurityAltID val) { NoUnderlyingSecurityAltID = val; }
        public NoUnderlyingSecurityAltID Get(NoUnderlyingSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(NoUnderlyingSecurityAltID val) { return IsSetNoUnderlyingSecurityAltID(); }
        public bool IsSetNoUnderlyingSecurityAltID() { return IsSetField(Tags.NoUnderlyingSecurityAltID); }

        public UnderlyingProduct UnderlyingProduct
        {
            get
            {
                UnderlyingProduct val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingProduct val) { UnderlyingProduct = val; }
        public UnderlyingProduct Get(UnderlyingProduct val) { GetField(val); return val; }
        public bool IsSet(UnderlyingProduct val) { return IsSetUnderlyingProduct(); }
        public bool IsSetUnderlyingProduct() { return IsSetField(Tags.UnderlyingProduct); }

        public UnderlyingCFICode UnderlyingCFICode
        {
            get
            {
                UnderlyingCFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCFICode val) { UnderlyingCFICode = val; }
        public UnderlyingCFICode Get(UnderlyingCFICode val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCFICode val) { return IsSetUnderlyingCFICode(); }
        public bool IsSetUnderlyingCFICode() { return IsSetField(Tags.UnderlyingCFICode); }

        public UnderlyingSecurityType UnderlyingSecurityType
        {
            get
            {
                UnderlyingSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityType val) { UnderlyingSecurityType = val; }
        public UnderlyingSecurityType Get(UnderlyingSecurityType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityType val) { return IsSetUnderlyingSecurityType(); }
        public bool IsSetUnderlyingSecurityType() { return IsSetField(Tags.UnderlyingSecurityType); }

        public UnderlyingSecuritySubType UnderlyingSecuritySubType
        {
            get
            {
                UnderlyingSecuritySubType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecuritySubType val) { UnderlyingSecuritySubType = val; }
        public UnderlyingSecuritySubType Get(UnderlyingSecuritySubType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecuritySubType val) { return IsSetUnderlyingSecuritySubType(); }
        public bool IsSetUnderlyingSecuritySubType() { return IsSetField(Tags.UnderlyingSecuritySubType); }

        public UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
        {
            get
            {
                UnderlyingMaturityMonthYear val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingMaturityMonthYear val) { UnderlyingMaturityMonthYear = val; }
        public UnderlyingMaturityMonthYear Get(UnderlyingMaturityMonthYear val) { GetField(val); return val; }
        public bool IsSet(UnderlyingMaturityMonthYear val) { return IsSetUnderlyingMaturityMonthYear(); }
        public bool IsSetUnderlyingMaturityMonthYear() { return IsSetField(Tags.UnderlyingMaturityMonthYear); }

        public UnderlyingMaturityDate UnderlyingMaturityDate
        {
            get
            {
                UnderlyingMaturityDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingMaturityDate val) { UnderlyingMaturityDate = val; }
        public UnderlyingMaturityDate Get(UnderlyingMaturityDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingMaturityDate val) { return IsSetUnderlyingMaturityDate(); }
        public bool IsSetUnderlyingMaturityDate() { return IsSetField(Tags.UnderlyingMaturityDate); }

        public UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
        {
            get
            {
                UnderlyingCouponPaymentDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCouponPaymentDate val) { UnderlyingCouponPaymentDate = val; }
        public UnderlyingCouponPaymentDate Get(UnderlyingCouponPaymentDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCouponPaymentDate val) { return IsSetUnderlyingCouponPaymentDate(); }
        public bool IsSetUnderlyingCouponPaymentDate() { return IsSetField(Tags.UnderlyingCouponPaymentDate); }

        public UnderlyingIssueDate UnderlyingIssueDate
        {
            get
            {
                UnderlyingIssueDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIssueDate val) { UnderlyingIssueDate = val; }
        public UnderlyingIssueDate Get(UnderlyingIssueDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIssueDate val) { return IsSetUnderlyingIssueDate(); }
        public bool IsSetUnderlyingIssueDate() { return IsSetField(Tags.UnderlyingIssueDate); }

        public UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
        {
            get
            {
                UnderlyingRepoCollateralSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRepoCollateralSecurityType val) { UnderlyingRepoCollateralSecurityType = val; }
        public UnderlyingRepoCollateralSecurityType Get(UnderlyingRepoCollateralSecurityType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRepoCollateralSecurityType val) { return IsSetUnderlyingRepoCollateralSecurityType(); }
        public bool IsSetUnderlyingRepoCollateralSecurityType() { return IsSetField(Tags.UnderlyingRepoCollateralSecurityType); }

        public UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
        {
            get
            {
                UnderlyingRepurchaseTerm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRepurchaseTerm val) { UnderlyingRepurchaseTerm = val; }
        public UnderlyingRepurchaseTerm Get(UnderlyingRepurchaseTerm val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRepurchaseTerm val) { return IsSetUnderlyingRepurchaseTerm(); }
        public bool IsSetUnderlyingRepurchaseTerm() { return IsSetField(Tags.UnderlyingRepurchaseTerm); }

        public UnderlyingRepurchaseRate UnderlyingRepurchaseRate
        {
            get
            {
                UnderlyingRepurchaseRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRepurchaseRate val) { UnderlyingRepurchaseRate = val; }
        public UnderlyingRepurchaseRate Get(UnderlyingRepurchaseRate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRepurchaseRate val) { return IsSetUnderlyingRepurchaseRate(); }
        public bool IsSetUnderlyingRepurchaseRate() { return IsSetField(Tags.UnderlyingRepurchaseRate); }

        public UnderlyingFactor UnderlyingFactor
        {
            get
            {
                UnderlyingFactor val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingFactor val) { UnderlyingFactor = val; }
        public UnderlyingFactor Get(UnderlyingFactor val) { GetField(val); return val; }
        public bool IsSet(UnderlyingFactor val) { return IsSetUnderlyingFactor(); }
        public bool IsSetUnderlyingFactor() { return IsSetField(Tags.UnderlyingFactor); }

        public UnderlyingCreditRating UnderlyingCreditRating
        {
            get
            {
                UnderlyingCreditRating val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCreditRating val) { UnderlyingCreditRating = val; }
        public UnderlyingCreditRating Get(UnderlyingCreditRating val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCreditRating val) { return IsSetUnderlyingCreditRating(); }
        public bool IsSetUnderlyingCreditRating() { return IsSetField(Tags.UnderlyingCreditRating); }

        public UnderlyingInstrRegistry UnderlyingInstrRegistry
        {
            get
            {
                UnderlyingInstrRegistry val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingInstrRegistry val) { UnderlyingInstrRegistry = val; }
        public UnderlyingInstrRegistry Get(UnderlyingInstrRegistry val) { GetField(val); return val; }
        public bool IsSet(UnderlyingInstrRegistry val) { return IsSetUnderlyingInstrRegistry(); }
        public bool IsSetUnderlyingInstrRegistry() { return IsSetField(Tags.UnderlyingInstrRegistry); }

        public UnderlyingCountryOfIssue UnderlyingCountryOfIssue
        {
            get
            {
                UnderlyingCountryOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCountryOfIssue val) { UnderlyingCountryOfIssue = val; }
        public UnderlyingCountryOfIssue Get(UnderlyingCountryOfIssue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCountryOfIssue val) { return IsSetUnderlyingCountryOfIssue(); }
        public bool IsSetUnderlyingCountryOfIssue() { return IsSetField(Tags.UnderlyingCountryOfIssue); }

        public UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
        {
            get
            {
                UnderlyingStateOrProvinceOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStateOrProvinceOfIssue val) { UnderlyingStateOrProvinceOfIssue = val; }
        public UnderlyingStateOrProvinceOfIssue Get(UnderlyingStateOrProvinceOfIssue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStateOrProvinceOfIssue val) { return IsSetUnderlyingStateOrProvinceOfIssue(); }
        public bool IsSetUnderlyingStateOrProvinceOfIssue() { return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue); }

        public UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
        {
            get
            {
                UnderlyingLocaleOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingLocaleOfIssue val) { UnderlyingLocaleOfIssue = val; }
        public UnderlyingLocaleOfIssue Get(UnderlyingLocaleOfIssue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingLocaleOfIssue val) { return IsSetUnderlyingLocaleOfIssue(); }
        public bool IsSetUnderlyingLocaleOfIssue() { return IsSetField(Tags.UnderlyingLocaleOfIssue); }

        public UnderlyingRedemptionDate UnderlyingRedemptionDate
        {
            get
            {
                UnderlyingRedemptionDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRedemptionDate val) { UnderlyingRedemptionDate = val; }
        public UnderlyingRedemptionDate Get(UnderlyingRedemptionDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRedemptionDate val) { return IsSetUnderlyingRedemptionDate(); }
        public bool IsSetUnderlyingRedemptionDate() { return IsSetField(Tags.UnderlyingRedemptionDate); }

        public UnderlyingStrikePrice UnderlyingStrikePrice
        {
            get
            {
                UnderlyingStrikePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStrikePrice val) { UnderlyingStrikePrice = val; }
        public UnderlyingStrikePrice Get(UnderlyingStrikePrice val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStrikePrice val) { return IsSetUnderlyingStrikePrice(); }
        public bool IsSetUnderlyingStrikePrice() { return IsSetField(Tags.UnderlyingStrikePrice); }

        public UnderlyingStrikeCurrency UnderlyingStrikeCurrency
        {
            get
            {
                UnderlyingStrikeCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStrikeCurrency val) { UnderlyingStrikeCurrency = val; }
        public UnderlyingStrikeCurrency Get(UnderlyingStrikeCurrency val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStrikeCurrency val) { return IsSetUnderlyingStrikeCurrency(); }
        public bool IsSetUnderlyingStrikeCurrency() { return IsSetField(Tags.UnderlyingStrikeCurrency); }

        public UnderlyingOptAttribute UnderlyingOptAttribute
        {
            get
            {
                UnderlyingOptAttribute val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingOptAttribute val) { UnderlyingOptAttribute = val; }
        public UnderlyingOptAttribute Get(UnderlyingOptAttribute val) { GetField(val); return val; }
        public bool IsSet(UnderlyingOptAttribute val) { return IsSetUnderlyingOptAttribute(); }
        public bool IsSetUnderlyingOptAttribute() { return IsSetField(Tags.UnderlyingOptAttribute); }

        public UnderlyingContractMultiplier UnderlyingContractMultiplier
        {
            get
            {
                UnderlyingContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingContractMultiplier val) { UnderlyingContractMultiplier = val; }
        public UnderlyingContractMultiplier Get(UnderlyingContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(UnderlyingContractMultiplier val) { return IsSetUnderlyingContractMultiplier(); }
        public bool IsSetUnderlyingContractMultiplier() { return IsSetField(Tags.UnderlyingContractMultiplier); }

        public UnderlyingCouponRate UnderlyingCouponRate
        {
            get
            {
                UnderlyingCouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCouponRate val) { UnderlyingCouponRate = val; }
        public UnderlyingCouponRate Get(UnderlyingCouponRate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCouponRate val) { return IsSetUnderlyingCouponRate(); }
        public bool IsSetUnderlyingCouponRate() { return IsSetField(Tags.UnderlyingCouponRate); }

        public UnderlyingSecurityExchange UnderlyingSecurityExchange
        {
            get
            {
                UnderlyingSecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityExchange val) { UnderlyingSecurityExchange = val; }
        public UnderlyingSecurityExchange Get(UnderlyingSecurityExchange val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityExchange val) { return IsSetUnderlyingSecurityExchange(); }
        public bool IsSetUnderlyingSecurityExchange() { return IsSetField(Tags.UnderlyingSecurityExchange); }

        public UnderlyingIssuer UnderlyingIssuer
        {
            get
            {
                UnderlyingIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIssuer val) { UnderlyingIssuer = val; }
        public UnderlyingIssuer Get(UnderlyingIssuer val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIssuer val) { return IsSetUnderlyingIssuer(); }
        public bool IsSetUnderlyingIssuer() { return IsSetField(Tags.UnderlyingIssuer); }

        public EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
        {
            get
            {
                EncodedUnderlyingIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedUnderlyingIssuerLen val) { EncodedUnderlyingIssuerLen = val; }
        public EncodedUnderlyingIssuerLen Get(EncodedUnderlyingIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedUnderlyingIssuerLen val) { return IsSetEncodedUnderlyingIssuerLen(); }
        public bool IsSetEncodedUnderlyingIssuerLen() { return IsSetField(Tags.EncodedUnderlyingIssuerLen); }

        public EncodedUnderlyingIssuer EncodedUnderlyingIssuer
        {
            get
            {
                EncodedUnderlyingIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedUnderlyingIssuer val) { EncodedUnderlyingIssuer = val; }
        public EncodedUnderlyingIssuer Get(EncodedUnderlyingIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedUnderlyingIssuer val) { return IsSetEncodedUnderlyingIssuer(); }
        public bool IsSetEncodedUnderlyingIssuer() { return IsSetField(Tags.EncodedUnderlyingIssuer); }

        public UnderlyingSecurityDesc UnderlyingSecurityDesc
        {
            get
            {
                UnderlyingSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityDesc val) { UnderlyingSecurityDesc = val; }
        public UnderlyingSecurityDesc Get(UnderlyingSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityDesc val) { return IsSetUnderlyingSecurityDesc(); }
        public bool IsSetUnderlyingSecurityDesc() { return IsSetField(Tags.UnderlyingSecurityDesc); }

        public EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
        {
            get
            {
                EncodedUnderlyingSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedUnderlyingSecurityDescLen val) { EncodedUnderlyingSecurityDescLen = val; }
        public EncodedUnderlyingSecurityDescLen Get(EncodedUnderlyingSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedUnderlyingSecurityDescLen val) { return IsSetEncodedUnderlyingSecurityDescLen(); }
        public bool IsSetEncodedUnderlyingSecurityDescLen() { return IsSetField(Tags.EncodedUnderlyingSecurityDescLen); }

        public EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
        {
            get
            {
                EncodedUnderlyingSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedUnderlyingSecurityDesc val) { EncodedUnderlyingSecurityDesc = val; }
        public EncodedUnderlyingSecurityDesc Get(EncodedUnderlyingSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedUnderlyingSecurityDesc val) { return IsSetEncodedUnderlyingSecurityDesc(); }
        public bool IsSetEncodedUnderlyingSecurityDesc() { return IsSetField(Tags.EncodedUnderlyingSecurityDesc); }

        public UnderlyingCPProgram UnderlyingCPProgram
        {
            get
            {
                UnderlyingCPProgram val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCPProgram val) { UnderlyingCPProgram = val; }
        public UnderlyingCPProgram Get(UnderlyingCPProgram val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCPProgram val) { return IsSetUnderlyingCPProgram(); }
        public bool IsSetUnderlyingCPProgram() { return IsSetField(Tags.UnderlyingCPProgram); }

        public UnderlyingCPRegType UnderlyingCPRegType
        {
            get
            {
                UnderlyingCPRegType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCPRegType val) { UnderlyingCPRegType = val; }
        public UnderlyingCPRegType Get(UnderlyingCPRegType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCPRegType val) { return IsSetUnderlyingCPRegType(); }
        public bool IsSetUnderlyingCPRegType() { return IsSetField(Tags.UnderlyingCPRegType); }

        public UnderlyingCurrency UnderlyingCurrency
        {
            get
            {
                UnderlyingCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCurrency val) { UnderlyingCurrency = val; }
        public UnderlyingCurrency Get(UnderlyingCurrency val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCurrency val) { return IsSetUnderlyingCurrency(); }
        public bool IsSetUnderlyingCurrency() { return IsSetField(Tags.UnderlyingCurrency); }

        public UnderlyingQty UnderlyingQty
        {
            get
            {
                UnderlyingQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingQty val) { UnderlyingQty = val; }
        public UnderlyingQty Get(UnderlyingQty val) { GetField(val); return val; }
        public bool IsSet(UnderlyingQty val) { return IsSetUnderlyingQty(); }
        public bool IsSetUnderlyingQty() { return IsSetField(Tags.UnderlyingQty); }

        public UnderlyingPx UnderlyingPx
        {
            get
            {
                UnderlyingPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingPx val) { UnderlyingPx = val; }
        public UnderlyingPx Get(UnderlyingPx val) { GetField(val); return val; }
        public bool IsSet(UnderlyingPx val) { return IsSetUnderlyingPx(); }
        public bool IsSetUnderlyingPx() { return IsSetField(Tags.UnderlyingPx); }

        public UnderlyingDirtyPrice UnderlyingDirtyPrice
        {
            get
            {
                UnderlyingDirtyPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingDirtyPrice val) { UnderlyingDirtyPrice = val; }
        public UnderlyingDirtyPrice Get(UnderlyingDirtyPrice val) { GetField(val); return val; }
        public bool IsSet(UnderlyingDirtyPrice val) { return IsSetUnderlyingDirtyPrice(); }
        public bool IsSetUnderlyingDirtyPrice() { return IsSetField(Tags.UnderlyingDirtyPrice); }

        public UnderlyingEndPrice UnderlyingEndPrice
        {
            get
            {
                UnderlyingEndPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingEndPrice val) { UnderlyingEndPrice = val; }
        public UnderlyingEndPrice Get(UnderlyingEndPrice val) { GetField(val); return val; }
        public bool IsSet(UnderlyingEndPrice val) { return IsSetUnderlyingEndPrice(); }
        public bool IsSetUnderlyingEndPrice() { return IsSetField(Tags.UnderlyingEndPrice); }

        public UnderlyingStartValue UnderlyingStartValue
        {
            get
            {
                UnderlyingStartValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStartValue val) { UnderlyingStartValue = val; }
        public UnderlyingStartValue Get(UnderlyingStartValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStartValue val) { return IsSetUnderlyingStartValue(); }
        public bool IsSetUnderlyingStartValue() { return IsSetField(Tags.UnderlyingStartValue); }

        public UnderlyingCurrentValue UnderlyingCurrentValue
        {
            get
            {
                UnderlyingCurrentValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCurrentValue val) { UnderlyingCurrentValue = val; }
        public UnderlyingCurrentValue Get(UnderlyingCurrentValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCurrentValue val) { return IsSetUnderlyingCurrentValue(); }
        public bool IsSetUnderlyingCurrentValue() { return IsSetField(Tags.UnderlyingCurrentValue); }

        public UnderlyingEndValue UnderlyingEndValue
        {
            get
            {
                UnderlyingEndValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingEndValue val) { UnderlyingEndValue = val; }
        public UnderlyingEndValue Get(UnderlyingEndValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingEndValue val) { return IsSetUnderlyingEndValue(); }
        public bool IsSetUnderlyingEndValue() { return IsSetField(Tags.UnderlyingEndValue); }

        public NoUnderlyingStips NoUnderlyingStips
        {
            get
            {
                NoUnderlyingStips val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUnderlyingStips val) { NoUnderlyingStips = val; }
        public NoUnderlyingStips Get(NoUnderlyingStips val) { GetField(val); return val; }
        public bool IsSet(NoUnderlyingStips val) { return IsSetNoUnderlyingStips(); }
        public bool IsSetNoUnderlyingStips() { return IsSetField(Tags.NoUnderlyingStips); }

        public UnderlyingAllocationPercent UnderlyingAllocationPercent
        {
            get
            {
                UnderlyingAllocationPercent val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingAllocationPercent val) { UnderlyingAllocationPercent = val; }
        public UnderlyingAllocationPercent Get(UnderlyingAllocationPercent val) { GetField(val); return val; }
        public bool IsSet(UnderlyingAllocationPercent val) { return IsSetUnderlyingAllocationPercent(); }
        public bool IsSetUnderlyingAllocationPercent() { return IsSetField(Tags.UnderlyingAllocationPercent); }

        public UnderlyingSettlementType UnderlyingSettlementType
        {
            get
            {
                UnderlyingSettlementType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSettlementType val) { UnderlyingSettlementType = val; }
        public UnderlyingSettlementType Get(UnderlyingSettlementType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSettlementType val) { return IsSetUnderlyingSettlementType(); }
        public bool IsSetUnderlyingSettlementType() { return IsSetField(Tags.UnderlyingSettlementType); }

        public UnderlyingCashAmount UnderlyingCashAmount
        {
            get
            {
                UnderlyingCashAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCashAmount val) { UnderlyingCashAmount = val; }
        public UnderlyingCashAmount Get(UnderlyingCashAmount val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCashAmount val) { return IsSetUnderlyingCashAmount(); }
        public bool IsSetUnderlyingCashAmount() { return IsSetField(Tags.UnderlyingCashAmount); }

        public UnderlyingCashType UnderlyingCashType
        {
            get
            {
                UnderlyingCashType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCashType val) { UnderlyingCashType = val; }
        public UnderlyingCashType Get(UnderlyingCashType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCashType val) { return IsSetUnderlyingCashType(); }
        public bool IsSetUnderlyingCashType() { return IsSetField(Tags.UnderlyingCashType); }

        public UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
        {
            get
            {
                UnderlyingUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingUnitOfMeasure val) { UnderlyingUnitOfMeasure = val; }
        public UnderlyingUnitOfMeasure Get(UnderlyingUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(UnderlyingUnitOfMeasure val) { return IsSetUnderlyingUnitOfMeasure(); }
        public bool IsSetUnderlyingUnitOfMeasure() { return IsSetField(Tags.UnderlyingUnitOfMeasure); }

        public UnderlyingTimeUnit UnderlyingTimeUnit
        {
            get
            {
                UnderlyingTimeUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingTimeUnit val) { UnderlyingTimeUnit = val; }
        public UnderlyingTimeUnit Get(UnderlyingTimeUnit val) { GetField(val); return val; }
        public bool IsSet(UnderlyingTimeUnit val) { return IsSetUnderlyingTimeUnit(); }
        public bool IsSetUnderlyingTimeUnit() { return IsSetField(Tags.UnderlyingTimeUnit); }

        public UnderlyingCapValue UnderlyingCapValue
        {
            get
            {
                UnderlyingCapValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCapValue val) { UnderlyingCapValue = val; }
        public UnderlyingCapValue Get(UnderlyingCapValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCapValue val) { return IsSetUnderlyingCapValue(); }
        public bool IsSetUnderlyingCapValue() { return IsSetField(Tags.UnderlyingCapValue); }

        public NoUndlyInstrumentParties NoUndlyInstrumentParties
        {
            get
            {
                NoUndlyInstrumentParties val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUndlyInstrumentParties val) { NoUndlyInstrumentParties = val; }
        public NoUndlyInstrumentParties Get(NoUndlyInstrumentParties val) { GetField(val); return val; }
        public bool IsSet(NoUndlyInstrumentParties val) { return IsSetNoUndlyInstrumentParties(); }
        public bool IsSetNoUndlyInstrumentParties() { return IsSetField(Tags.NoUndlyInstrumentParties); }

        public UnderlyingSettlMethod UnderlyingSettlMethod
        {
            get
            {
                UnderlyingSettlMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSettlMethod val) { UnderlyingSettlMethod = val; }
        public UnderlyingSettlMethod Get(UnderlyingSettlMethod val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSettlMethod val) { return IsSetUnderlyingSettlMethod(); }
        public bool IsSetUnderlyingSettlMethod() { return IsSetField(Tags.UnderlyingSettlMethod); }

        public UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
        {
            get
            {
                UnderlyingAdjustedQuantity val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingAdjustedQuantity val) { UnderlyingAdjustedQuantity = val; }
        public UnderlyingAdjustedQuantity Get(UnderlyingAdjustedQuantity val) { GetField(val); return val; }
        public bool IsSet(UnderlyingAdjustedQuantity val) { return IsSetUnderlyingAdjustedQuantity(); }
        public bool IsSetUnderlyingAdjustedQuantity() { return IsSetField(Tags.UnderlyingAdjustedQuantity); }

        public UnderlyingFXRate UnderlyingFXRate
        {
            get
            {
                UnderlyingFXRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingFXRate val) { UnderlyingFXRate = val; }
        public UnderlyingFXRate Get(UnderlyingFXRate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingFXRate val) { return IsSetUnderlyingFXRate(); }
        public bool IsSetUnderlyingFXRate() { return IsSetField(Tags.UnderlyingFXRate); }

        public UnderlyingFXRateCalc UnderlyingFXRateCalc
        {
            get
            {
                UnderlyingFXRateCalc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingFXRateCalc val) { UnderlyingFXRateCalc = val; }
        public UnderlyingFXRateCalc Get(UnderlyingFXRateCalc val) { GetField(val); return val; }
        public bool IsSet(UnderlyingFXRateCalc val) { return IsSetUnderlyingFXRateCalc(); }
        public bool IsSetUnderlyingFXRateCalc() { return IsSetField(Tags.UnderlyingFXRateCalc); }

        public class NoUnderlyingSecurityAltIDGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};

            public NoUnderlyingSecurityAltIDGroup()
              : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingSecurityAltID UnderlyingSecurityAltID
            {
                get
                {
                    UnderlyingSecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingSecurityAltID val) { UnderlyingSecurityAltID = val; }
            public UnderlyingSecurityAltID Get(UnderlyingSecurityAltID val) { GetField(val); return val; }
            public bool IsSet(UnderlyingSecurityAltID val) { return IsSetUnderlyingSecurityAltID(); }
            public bool IsSetUnderlyingSecurityAltID() { return IsSetField(Tags.UnderlyingSecurityAltID); }

            public UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
            {
                get
                {
                    UnderlyingSecurityAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingSecurityAltIDSource val) { UnderlyingSecurityAltIDSource = val; }
            public UnderlyingSecurityAltIDSource Get(UnderlyingSecurityAltIDSource val) { GetField(val); return val; }
            public bool IsSet(UnderlyingSecurityAltIDSource val) { return IsSetUnderlyingSecurityAltIDSource(); }
            public bool IsSetUnderlyingSecurityAltIDSource() { return IsSetField(Tags.UnderlyingSecurityAltIDSource); }
        }

        public class NoUnderlyingStipsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};

            public NoUnderlyingStipsGroup()
              : base(Tags.NoUnderlyingStips, Tags.UnderlyingStipType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingStipsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingStipType UnderlyingStipType
            {
                get
                {
                    UnderlyingStipType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingStipType val) { UnderlyingStipType = val; }
            public UnderlyingStipType Get(UnderlyingStipType val) { GetField(val); return val; }
            public bool IsSet(UnderlyingStipType val) { return IsSetUnderlyingStipType(); }
            public bool IsSetUnderlyingStipType() { return IsSetField(Tags.UnderlyingStipType); }

            public UnderlyingStipValue UnderlyingStipValue
            {
                get
                {
                    UnderlyingStipValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingStipValue val) { UnderlyingStipValue = val; }
            public UnderlyingStipValue Get(UnderlyingStipValue val) { GetField(val); return val; }
            public bool IsSet(UnderlyingStipValue val) { return IsSetUnderlyingStipValue(); }
            public bool IsSetUnderlyingStipValue() { return IsSetField(Tags.UnderlyingStipValue); }
        }

        public class NoUndlyInstrumentPartiesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

            public NoUndlyInstrumentPartiesGroup()
              : base(Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UndlyInstrumentPartyID UndlyInstrumentPartyID
            {
                get
                {
                    UndlyInstrumentPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UndlyInstrumentPartyID val) { UndlyInstrumentPartyID = val; }
            public UndlyInstrumentPartyID Get(UndlyInstrumentPartyID val) { GetField(val); return val; }
            public bool IsSet(UndlyInstrumentPartyID val) { return IsSetUndlyInstrumentPartyID(); }
            public bool IsSetUndlyInstrumentPartyID() { return IsSetField(Tags.UndlyInstrumentPartyID); }

            public UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
            {
                get
                {
                    UndlyInstrumentPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UndlyInstrumentPartyIDSource val) { UndlyInstrumentPartyIDSource = val; }
            public UndlyInstrumentPartyIDSource Get(UndlyInstrumentPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(UndlyInstrumentPartyIDSource val) { return IsSetUndlyInstrumentPartyIDSource(); }
            public bool IsSetUndlyInstrumentPartyIDSource() { return IsSetField(Tags.UndlyInstrumentPartyIDSource); }

            public UndlyInstrumentPartyRole UndlyInstrumentPartyRole
            {
                get
                {
                    UndlyInstrumentPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UndlyInstrumentPartyRole val) { UndlyInstrumentPartyRole = val; }
            public UndlyInstrumentPartyRole Get(UndlyInstrumentPartyRole val) { GetField(val); return val; }
            public bool IsSet(UndlyInstrumentPartyRole val) { return IsSetUndlyInstrumentPartyRole(); }
            public bool IsSetUndlyInstrumentPartyRole() { return IsSetField(Tags.UndlyInstrumentPartyRole); }

            public NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
            {
                get
                {
                    NoUndlyInstrumentPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoUndlyInstrumentPartySubIDs val) { NoUndlyInstrumentPartySubIDs = val; }
            public NoUndlyInstrumentPartySubIDs Get(NoUndlyInstrumentPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoUndlyInstrumentPartySubIDs val) { return IsSetNoUndlyInstrumentPartySubIDs(); }
            public bool IsSetNoUndlyInstrumentPartySubIDs() { return IsSetField(Tags.NoUndlyInstrumentPartySubIDs); }

            public class NoUndlyInstrumentPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};

                public NoUndlyInstrumentPartySubIDsGroup()
                  : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoUndlyInstrumentPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public UndlyInstrumentPartySubID UndlyInstrumentPartySubID
                {
                    get
                    {
                        UndlyInstrumentPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(UndlyInstrumentPartySubID val) { UndlyInstrumentPartySubID = val; }
                public UndlyInstrumentPartySubID Get(UndlyInstrumentPartySubID val) { GetField(val); return val; }
                public bool IsSet(UndlyInstrumentPartySubID val) { return IsSetUndlyInstrumentPartySubID(); }
                public bool IsSetUndlyInstrumentPartySubID() { return IsSetField(Tags.UndlyInstrumentPartySubID); }

                public UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
                {
                    get
                    {
                        UndlyInstrumentPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(UndlyInstrumentPartySubIDType val) { UndlyInstrumentPartySubIDType = val; }
                public UndlyInstrumentPartySubIDType Get(UndlyInstrumentPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(UndlyInstrumentPartySubIDType val) { return IsSetUndlyInstrumentPartySubIDType(); }
                public bool IsSetUndlyInstrumentPartySubIDType() { return IsSetField(Tags.UndlyInstrumentPartySubIDType); }
            }
        }
    }

    public class NoStipulationsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StipulationType, Tags.StipulationValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};

        public NoStipulationsGroup()
          : base(Tags.NoStipulations, Tags.StipulationType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoStipulationsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public StipulationType StipulationType
        {
            get
            {
                StipulationType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StipulationType val) { StipulationType = val; }
        public StipulationType Get(StipulationType val) { GetField(val); return val; }
        public bool IsSet(StipulationType val) { return IsSetStipulationType(); }
        public bool IsSetStipulationType() { return IsSetField(Tags.StipulationType); }

        public StipulationValue StipulationValue
        {
            get
            {
                StipulationValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StipulationValue val) { StipulationValue = val; }
        public StipulationValue Get(StipulationValue val) { GetField(val); return val; }
        public bool IsSet(StipulationValue val) { return IsSetStipulationValue(); }
        public bool IsSetStipulationValue() { return IsSetField(Tags.StipulationValue); }
    }

    public class NoContAmtsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0};

        public NoContAmtsGroup()
          : base(Tags.NoContAmts, Tags.ContAmtType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoContAmtsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ContAmtType ContAmtType
        {
            get
            {
                ContAmtType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContAmtType val) { ContAmtType = val; }
        public ContAmtType Get(ContAmtType val) { GetField(val); return val; }
        public bool IsSet(ContAmtType val) { return IsSetContAmtType(); }
        public bool IsSetContAmtType() { return IsSetField(Tags.ContAmtType); }

        public ContAmtValue ContAmtValue
        {
            get
            {
                ContAmtValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContAmtValue val) { ContAmtValue = val; }
        public ContAmtValue Get(ContAmtValue val) { GetField(val); return val; }
        public bool IsSet(ContAmtValue val) { return IsSetContAmtValue(); }
        public bool IsSetContAmtValue() { return IsSetField(Tags.ContAmtValue); }

        public ContAmtCurr ContAmtCurr
        {
            get
            {
                ContAmtCurr val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContAmtCurr val) { ContAmtCurr = val; }
        public ContAmtCurr Get(ContAmtCurr val) { GetField(val); return val; }
        public bool IsSet(ContAmtCurr val) { return IsSetContAmtCurr(); }
        public bool IsSetContAmtCurr() { return IsSetField(Tags.ContAmtCurr); }
    }

    public class NoLegsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegPrice, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegOrderQty, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegPrice, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegOrderQty, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, 0};

        public NoLegsGroup()
          : base(Tags.NoLegs, Tags.LegSymbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoLegsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public LegSymbol LegSymbol
        {
            get
            {
                LegSymbol val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSymbol val) { LegSymbol = val; }
        public LegSymbol Get(LegSymbol val) { GetField(val); return val; }
        public bool IsSet(LegSymbol val) { return IsSetLegSymbol(); }
        public bool IsSetLegSymbol() { return IsSetField(Tags.LegSymbol); }

        public LegSymbolSfx LegSymbolSfx
        {
            get
            {
                LegSymbolSfx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSymbolSfx val) { LegSymbolSfx = val; }
        public LegSymbolSfx Get(LegSymbolSfx val) { GetField(val); return val; }
        public bool IsSet(LegSymbolSfx val) { return IsSetLegSymbolSfx(); }
        public bool IsSetLegSymbolSfx() { return IsSetField(Tags.LegSymbolSfx); }

        public LegSecurityID LegSecurityID
        {
            get
            {
                LegSecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityID val) { LegSecurityID = val; }
        public LegSecurityID Get(LegSecurityID val) { GetField(val); return val; }
        public bool IsSet(LegSecurityID val) { return IsSetLegSecurityID(); }
        public bool IsSetLegSecurityID() { return IsSetField(Tags.LegSecurityID); }

        public LegSecurityIDSource LegSecurityIDSource
        {
            get
            {
                LegSecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityIDSource val) { LegSecurityIDSource = val; }
        public LegSecurityIDSource Get(LegSecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(LegSecurityIDSource val) { return IsSetLegSecurityIDSource(); }
        public bool IsSetLegSecurityIDSource() { return IsSetField(Tags.LegSecurityIDSource); }

        public NoLegSecurityAltID NoLegSecurityAltID
        {
            get
            {
                NoLegSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegSecurityAltID val) { NoLegSecurityAltID = val; }
        public NoLegSecurityAltID Get(NoLegSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(NoLegSecurityAltID val) { return IsSetNoLegSecurityAltID(); }
        public bool IsSetNoLegSecurityAltID() { return IsSetField(Tags.NoLegSecurityAltID); }

        public LegProduct LegProduct
        {
            get
            {
                LegProduct val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegProduct val) { LegProduct = val; }
        public LegProduct Get(LegProduct val) { GetField(val); return val; }
        public bool IsSet(LegProduct val) { return IsSetLegProduct(); }
        public bool IsSetLegProduct() { return IsSetField(Tags.LegProduct); }

        public LegCFICode LegCFICode
        {
            get
            {
                LegCFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCFICode val) { LegCFICode = val; }
        public LegCFICode Get(LegCFICode val) { GetField(val); return val; }
        public bool IsSet(LegCFICode val) { return IsSetLegCFICode(); }
        public bool IsSetLegCFICode() { return IsSetField(Tags.LegCFICode); }

        public LegSecurityType LegSecurityType
        {
            get
            {
                LegSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityType val) { LegSecurityType = val; }
        public LegSecurityType Get(LegSecurityType val) { GetField(val); return val; }
        public bool IsSet(LegSecurityType val) { return IsSetLegSecurityType(); }
        public bool IsSetLegSecurityType() { return IsSetField(Tags.LegSecurityType); }

        public LegSecuritySubType LegSecuritySubType
        {
            get
            {
                LegSecuritySubType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecuritySubType val) { LegSecuritySubType = val; }
        public LegSecuritySubType Get(LegSecuritySubType val) { GetField(val); return val; }
        public bool IsSet(LegSecuritySubType val) { return IsSetLegSecuritySubType(); }
        public bool IsSetLegSecuritySubType() { return IsSetField(Tags.LegSecuritySubType); }

        public LegMaturityMonthYear LegMaturityMonthYear
        {
            get
            {
                LegMaturityMonthYear val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegMaturityMonthYear val) { LegMaturityMonthYear = val; }
        public LegMaturityMonthYear Get(LegMaturityMonthYear val) { GetField(val); return val; }
        public bool IsSet(LegMaturityMonthYear val) { return IsSetLegMaturityMonthYear(); }
        public bool IsSetLegMaturityMonthYear() { return IsSetField(Tags.LegMaturityMonthYear); }

        public LegMaturityDate LegMaturityDate
        {
            get
            {
                LegMaturityDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegMaturityDate val) { LegMaturityDate = val; }
        public LegMaturityDate Get(LegMaturityDate val) { GetField(val); return val; }
        public bool IsSet(LegMaturityDate val) { return IsSetLegMaturityDate(); }
        public bool IsSetLegMaturityDate() { return IsSetField(Tags.LegMaturityDate); }

        public LegCouponPaymentDate LegCouponPaymentDate
        {
            get
            {
                LegCouponPaymentDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponPaymentDate val) { LegCouponPaymentDate = val; }
        public LegCouponPaymentDate Get(LegCouponPaymentDate val) { GetField(val); return val; }
        public bool IsSet(LegCouponPaymentDate val) { return IsSetLegCouponPaymentDate(); }
        public bool IsSetLegCouponPaymentDate() { return IsSetField(Tags.LegCouponPaymentDate); }

        public LegIssueDate LegIssueDate
        {
            get
            {
                LegIssueDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIssueDate val) { LegIssueDate = val; }
        public LegIssueDate Get(LegIssueDate val) { GetField(val); return val; }
        public bool IsSet(LegIssueDate val) { return IsSetLegIssueDate(); }
        public bool IsSetLegIssueDate() { return IsSetField(Tags.LegIssueDate); }

        public LegRepoCollateralSecurityType LegRepoCollateralSecurityType
        {
            get
            {
                LegRepoCollateralSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepoCollateralSecurityType val) { LegRepoCollateralSecurityType = val; }
        public LegRepoCollateralSecurityType Get(LegRepoCollateralSecurityType val) { GetField(val); return val; }
        public bool IsSet(LegRepoCollateralSecurityType val) { return IsSetLegRepoCollateralSecurityType(); }
        public bool IsSetLegRepoCollateralSecurityType() { return IsSetField(Tags.LegRepoCollateralSecurityType); }

        public LegRepurchaseTerm LegRepurchaseTerm
        {
            get
            {
                LegRepurchaseTerm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepurchaseTerm val) { LegRepurchaseTerm = val; }
        public LegRepurchaseTerm Get(LegRepurchaseTerm val) { GetField(val); return val; }
        public bool IsSet(LegRepurchaseTerm val) { return IsSetLegRepurchaseTerm(); }
        public bool IsSetLegRepurchaseTerm() { return IsSetField(Tags.LegRepurchaseTerm); }

        public LegRepurchaseRate LegRepurchaseRate
        {
            get
            {
                LegRepurchaseRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepurchaseRate val) { LegRepurchaseRate = val; }
        public LegRepurchaseRate Get(LegRepurchaseRate val) { GetField(val); return val; }
        public bool IsSet(LegRepurchaseRate val) { return IsSetLegRepurchaseRate(); }
        public bool IsSetLegRepurchaseRate() { return IsSetField(Tags.LegRepurchaseRate); }

        public LegFactor LegFactor
        {
            get
            {
                LegFactor val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegFactor val) { LegFactor = val; }
        public LegFactor Get(LegFactor val) { GetField(val); return val; }
        public bool IsSet(LegFactor val) { return IsSetLegFactor(); }
        public bool IsSetLegFactor() { return IsSetField(Tags.LegFactor); }

        public LegCreditRating LegCreditRating
        {
            get
            {
                LegCreditRating val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCreditRating val) { LegCreditRating = val; }
        public LegCreditRating Get(LegCreditRating val) { GetField(val); return val; }
        public bool IsSet(LegCreditRating val) { return IsSetLegCreditRating(); }
        public bool IsSetLegCreditRating() { return IsSetField(Tags.LegCreditRating); }

        public LegInstrRegistry LegInstrRegistry
        {
            get
            {
                LegInstrRegistry val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegInstrRegistry val) { LegInstrRegistry = val; }
        public LegInstrRegistry Get(LegInstrRegistry val) { GetField(val); return val; }
        public bool IsSet(LegInstrRegistry val) { return IsSetLegInstrRegistry(); }
        public bool IsSetLegInstrRegistry() { return IsSetField(Tags.LegInstrRegistry); }

        public LegCountryOfIssue LegCountryOfIssue
        {
            get
            {
                LegCountryOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCountryOfIssue val) { LegCountryOfIssue = val; }
        public LegCountryOfIssue Get(LegCountryOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegCountryOfIssue val) { return IsSetLegCountryOfIssue(); }
        public bool IsSetLegCountryOfIssue() { return IsSetField(Tags.LegCountryOfIssue); }

        public LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
        {
            get
            {
                LegStateOrProvinceOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStateOrProvinceOfIssue val) { LegStateOrProvinceOfIssue = val; }
        public LegStateOrProvinceOfIssue Get(LegStateOrProvinceOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegStateOrProvinceOfIssue val) { return IsSetLegStateOrProvinceOfIssue(); }
        public bool IsSetLegStateOrProvinceOfIssue() { return IsSetField(Tags.LegStateOrProvinceOfIssue); }

        public LegLocaleOfIssue LegLocaleOfIssue
        {
            get
            {
                LegLocaleOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLocaleOfIssue val) { LegLocaleOfIssue = val; }
        public LegLocaleOfIssue Get(LegLocaleOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegLocaleOfIssue val) { return IsSetLegLocaleOfIssue(); }
        public bool IsSetLegLocaleOfIssue() { return IsSetField(Tags.LegLocaleOfIssue); }

        public LegRedemptionDate LegRedemptionDate
        {
            get
            {
                LegRedemptionDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRedemptionDate val) { LegRedemptionDate = val; }
        public LegRedemptionDate Get(LegRedemptionDate val) { GetField(val); return val; }
        public bool IsSet(LegRedemptionDate val) { return IsSetLegRedemptionDate(); }
        public bool IsSetLegRedemptionDate() { return IsSetField(Tags.LegRedemptionDate); }

        public LegStrikePrice LegStrikePrice
        {
            get
            {
                LegStrikePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStrikePrice val) { LegStrikePrice = val; }
        public LegStrikePrice Get(LegStrikePrice val) { GetField(val); return val; }
        public bool IsSet(LegStrikePrice val) { return IsSetLegStrikePrice(); }
        public bool IsSetLegStrikePrice() { return IsSetField(Tags.LegStrikePrice); }

        public LegStrikeCurrency LegStrikeCurrency
        {
            get
            {
                LegStrikeCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStrikeCurrency val) { LegStrikeCurrency = val; }
        public LegStrikeCurrency Get(LegStrikeCurrency val) { GetField(val); return val; }
        public bool IsSet(LegStrikeCurrency val) { return IsSetLegStrikeCurrency(); }
        public bool IsSetLegStrikeCurrency() { return IsSetField(Tags.LegStrikeCurrency); }

        public LegOptAttribute LegOptAttribute
        {
            get
            {
                LegOptAttribute val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOptAttribute val) { LegOptAttribute = val; }
        public LegOptAttribute Get(LegOptAttribute val) { GetField(val); return val; }
        public bool IsSet(LegOptAttribute val) { return IsSetLegOptAttribute(); }
        public bool IsSetLegOptAttribute() { return IsSetField(Tags.LegOptAttribute); }

        public LegContractMultiplier LegContractMultiplier
        {
            get
            {
                LegContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegContractMultiplier val) { LegContractMultiplier = val; }
        public LegContractMultiplier Get(LegContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(LegContractMultiplier val) { return IsSetLegContractMultiplier(); }
        public bool IsSetLegContractMultiplier() { return IsSetField(Tags.LegContractMultiplier); }

        public LegCouponRate LegCouponRate
        {
            get
            {
                LegCouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponRate val) { LegCouponRate = val; }
        public LegCouponRate Get(LegCouponRate val) { GetField(val); return val; }
        public bool IsSet(LegCouponRate val) { return IsSetLegCouponRate(); }
        public bool IsSetLegCouponRate() { return IsSetField(Tags.LegCouponRate); }

        public LegSecurityExchange LegSecurityExchange
        {
            get
            {
                LegSecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityExchange val) { LegSecurityExchange = val; }
        public LegSecurityExchange Get(LegSecurityExchange val) { GetField(val); return val; }
        public bool IsSet(LegSecurityExchange val) { return IsSetLegSecurityExchange(); }
        public bool IsSetLegSecurityExchange() { return IsSetField(Tags.LegSecurityExchange); }

        public LegIssuer LegIssuer
        {
            get
            {
                LegIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIssuer val) { LegIssuer = val; }
        public LegIssuer Get(LegIssuer val) { GetField(val); return val; }
        public bool IsSet(LegIssuer val) { return IsSetLegIssuer(); }
        public bool IsSetLegIssuer() { return IsSetField(Tags.LegIssuer); }

        public EncodedLegIssuerLen EncodedLegIssuerLen
        {
            get
            {
                EncodedLegIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegIssuerLen val) { EncodedLegIssuerLen = val; }
        public EncodedLegIssuerLen Get(EncodedLegIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedLegIssuerLen val) { return IsSetEncodedLegIssuerLen(); }
        public bool IsSetEncodedLegIssuerLen() { return IsSetField(Tags.EncodedLegIssuerLen); }

        public EncodedLegIssuer EncodedLegIssuer
        {
            get
            {
                EncodedLegIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegIssuer val) { EncodedLegIssuer = val; }
        public EncodedLegIssuer Get(EncodedLegIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedLegIssuer val) { return IsSetEncodedLegIssuer(); }
        public bool IsSetEncodedLegIssuer() { return IsSetField(Tags.EncodedLegIssuer); }

        public LegSecurityDesc LegSecurityDesc
        {
            get
            {
                LegSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityDesc val) { LegSecurityDesc = val; }
        public LegSecurityDesc Get(LegSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(LegSecurityDesc val) { return IsSetLegSecurityDesc(); }
        public bool IsSetLegSecurityDesc() { return IsSetField(Tags.LegSecurityDesc); }

        public EncodedLegSecurityDescLen EncodedLegSecurityDescLen
        {
            get
            {
                EncodedLegSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegSecurityDescLen val) { EncodedLegSecurityDescLen = val; }
        public EncodedLegSecurityDescLen Get(EncodedLegSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedLegSecurityDescLen val) { return IsSetEncodedLegSecurityDescLen(); }
        public bool IsSetEncodedLegSecurityDescLen() { return IsSetField(Tags.EncodedLegSecurityDescLen); }

        public EncodedLegSecurityDesc EncodedLegSecurityDesc
        {
            get
            {
                EncodedLegSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegSecurityDesc val) { EncodedLegSecurityDesc = val; }
        public EncodedLegSecurityDesc Get(EncodedLegSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedLegSecurityDesc val) { return IsSetEncodedLegSecurityDesc(); }
        public bool IsSetEncodedLegSecurityDesc() { return IsSetField(Tags.EncodedLegSecurityDesc); }

        public LegRatioQty LegRatioQty
        {
            get
            {
                LegRatioQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRatioQty val) { LegRatioQty = val; }
        public LegRatioQty Get(LegRatioQty val) { GetField(val); return val; }
        public bool IsSet(LegRatioQty val) { return IsSetLegRatioQty(); }
        public bool IsSetLegRatioQty() { return IsSetField(Tags.LegRatioQty); }

        public LegSide LegSide
        {
            get
            {
                LegSide val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSide val) { LegSide = val; }
        public LegSide Get(LegSide val) { GetField(val); return val; }
        public bool IsSet(LegSide val) { return IsSetLegSide(); }
        public bool IsSetLegSide() { return IsSetField(Tags.LegSide); }

        public LegCurrency LegCurrency
        {
            get
            {
                LegCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCurrency val) { LegCurrency = val; }
        public LegCurrency Get(LegCurrency val) { GetField(val); return val; }
        public bool IsSet(LegCurrency val) { return IsSetLegCurrency(); }
        public bool IsSetLegCurrency() { return IsSetField(Tags.LegCurrency); }

        public LegPool LegPool
        {
            get
            {
                LegPool val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPool val) { LegPool = val; }
        public LegPool Get(LegPool val) { GetField(val); return val; }
        public bool IsSet(LegPool val) { return IsSetLegPool(); }
        public bool IsSetLegPool() { return IsSetField(Tags.LegPool); }

        public LegDatedDate LegDatedDate
        {
            get
            {
                LegDatedDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegDatedDate val) { LegDatedDate = val; }
        public LegDatedDate Get(LegDatedDate val) { GetField(val); return val; }
        public bool IsSet(LegDatedDate val) { return IsSetLegDatedDate(); }
        public bool IsSetLegDatedDate() { return IsSetField(Tags.LegDatedDate); }

        public LegContractSettlMonth LegContractSettlMonth
        {
            get
            {
                LegContractSettlMonth val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegContractSettlMonth val) { LegContractSettlMonth = val; }
        public LegContractSettlMonth Get(LegContractSettlMonth val) { GetField(val); return val; }
        public bool IsSet(LegContractSettlMonth val) { return IsSetLegContractSettlMonth(); }
        public bool IsSetLegContractSettlMonth() { return IsSetField(Tags.LegContractSettlMonth); }

        public LegInterestAccrualDate LegInterestAccrualDate
        {
            get
            {
                LegInterestAccrualDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegInterestAccrualDate val) { LegInterestAccrualDate = val; }
        public LegInterestAccrualDate Get(LegInterestAccrualDate val) { GetField(val); return val; }
        public bool IsSet(LegInterestAccrualDate val) { return IsSetLegInterestAccrualDate(); }
        public bool IsSetLegInterestAccrualDate() { return IsSetField(Tags.LegInterestAccrualDate); }

        public LegUnitOfMeasure LegUnitOfMeasure
        {
            get
            {
                LegUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegUnitOfMeasure val) { LegUnitOfMeasure = val; }
        public LegUnitOfMeasure Get(LegUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(LegUnitOfMeasure val) { return IsSetLegUnitOfMeasure(); }
        public bool IsSetLegUnitOfMeasure() { return IsSetField(Tags.LegUnitOfMeasure); }

        public LegTimeUnit LegTimeUnit
        {
            get
            {
                LegTimeUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegTimeUnit val) { LegTimeUnit = val; }
        public LegTimeUnit Get(LegTimeUnit val) { GetField(val); return val; }
        public bool IsSet(LegTimeUnit val) { return IsSetLegTimeUnit(); }
        public bool IsSetLegTimeUnit() { return IsSetField(Tags.LegTimeUnit); }

        public LegQty LegQty
        {
            get
            {
                LegQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegQty val) { LegQty = val; }
        public LegQty Get(LegQty val) { GetField(val); return val; }
        public bool IsSet(LegQty val) { return IsSetLegQty(); }
        public bool IsSetLegQty() { return IsSetField(Tags.LegQty); }

        public LegSwapType LegSwapType
        {
            get
            {
                LegSwapType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSwapType val) { LegSwapType = val; }
        public LegSwapType Get(LegSwapType val) { GetField(val); return val; }
        public bool IsSet(LegSwapType val) { return IsSetLegSwapType(); }
        public bool IsSetLegSwapType() { return IsSetField(Tags.LegSwapType); }

        public NoLegStipulations NoLegStipulations
        {
            get
            {
                NoLegStipulations val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegStipulations val) { NoLegStipulations = val; }
        public NoLegStipulations Get(NoLegStipulations val) { GetField(val); return val; }
        public bool IsSet(NoLegStipulations val) { return IsSetNoLegStipulations(); }
        public bool IsSetNoLegStipulations() { return IsSetField(Tags.NoLegStipulations); }

        public LegPositionEffect LegPositionEffect
        {
            get
            {
                LegPositionEffect val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPositionEffect val) { LegPositionEffect = val; }
        public LegPositionEffect Get(LegPositionEffect val) { GetField(val); return val; }
        public bool IsSet(LegPositionEffect val) { return IsSetLegPositionEffect(); }
        public bool IsSetLegPositionEffect() { return IsSetField(Tags.LegPositionEffect); }

        public LegCoveredOrUncovered LegCoveredOrUncovered
        {
            get
            {
                LegCoveredOrUncovered val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCoveredOrUncovered val) { LegCoveredOrUncovered = val; }
        public LegCoveredOrUncovered Get(LegCoveredOrUncovered val) { GetField(val); return val; }
        public bool IsSet(LegCoveredOrUncovered val) { return IsSetLegCoveredOrUncovered(); }
        public bool IsSetLegCoveredOrUncovered() { return IsSetField(Tags.LegCoveredOrUncovered); }

        public NoNestedPartyIDs NoNestedPartyIDs
        {
            get
            {
                NoNestedPartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNestedPartyIDs val) { NoNestedPartyIDs = val; }
        public NoNestedPartyIDs Get(NoNestedPartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNestedPartyIDs val) { return IsSetNoNestedPartyIDs(); }
        public bool IsSetNoNestedPartyIDs() { return IsSetField(Tags.NoNestedPartyIDs); }

        public LegRefID LegRefID
        {
            get
            {
                LegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRefID val) { LegRefID = val; }
        public LegRefID Get(LegRefID val) { GetField(val); return val; }
        public bool IsSet(LegRefID val) { return IsSetLegRefID(); }
        public bool IsSetLegRefID() { return IsSetField(Tags.LegRefID); }

        public LegPrice LegPrice
        {
            get
            {
                LegPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPrice val) { LegPrice = val; }
        public LegPrice Get(LegPrice val) { GetField(val); return val; }
        public bool IsSet(LegPrice val) { return IsSetLegPrice(); }
        public bool IsSetLegPrice() { return IsSetField(Tags.LegPrice); }

        public LegSettlType LegSettlType
        {
            get
            {
                LegSettlType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlType val) { LegSettlType = val; }
        public LegSettlType Get(LegSettlType val) { GetField(val); return val; }
        public bool IsSet(LegSettlType val) { return IsSetLegSettlType(); }
        public bool IsSetLegSettlType() { return IsSetField(Tags.LegSettlType); }

        public LegSettlDate LegSettlDate
        {
            get
            {
                LegSettlDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlDate val) { LegSettlDate = val; }
        public LegSettlDate Get(LegSettlDate val) { GetField(val); return val; }
        public bool IsSet(LegSettlDate val) { return IsSetLegSettlDate(); }
        public bool IsSetLegSettlDate() { return IsSetField(Tags.LegSettlDate); }

        public LegLastPx LegLastPx
        {
            get
            {
                LegLastPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLastPx val) { LegLastPx = val; }
        public LegLastPx Get(LegLastPx val) { GetField(val); return val; }
        public bool IsSet(LegLastPx val) { return IsSetLegLastPx(); }
        public bool IsSetLegLastPx() { return IsSetField(Tags.LegLastPx); }

        public LegOrderQty LegOrderQty
        {
            get
            {
                LegOrderQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOrderQty val) { LegOrderQty = val; }
        public LegOrderQty Get(LegOrderQty val) { GetField(val); return val; }
        public bool IsSet(LegOrderQty val) { return IsSetLegOrderQty(); }
        public bool IsSetLegOrderQty() { return IsSetField(Tags.LegOrderQty); }

        public LegSettlCurrency LegSettlCurrency
        {
            get
            {
                LegSettlCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlCurrency val) { LegSettlCurrency = val; }
        public LegSettlCurrency Get(LegSettlCurrency val) { GetField(val); return val; }
        public bool IsSet(LegSettlCurrency val) { return IsSetLegSettlCurrency(); }
        public bool IsSetLegSettlCurrency() { return IsSetField(Tags.LegSettlCurrency); }

        public LegLastForwardPoints LegLastForwardPoints
        {
            get
            {
                LegLastForwardPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLastForwardPoints val) { LegLastForwardPoints = val; }
        public LegLastForwardPoints Get(LegLastForwardPoints val) { GetField(val); return val; }
        public bool IsSet(LegLastForwardPoints val) { return IsSetLegLastForwardPoints(); }
        public bool IsSetLegLastForwardPoints() { return IsSetField(Tags.LegLastForwardPoints); }

        public LegCalculatedCcyLastQty LegCalculatedCcyLastQty
        {
            get
            {
                LegCalculatedCcyLastQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCalculatedCcyLastQty val) { LegCalculatedCcyLastQty = val; }
        public LegCalculatedCcyLastQty Get(LegCalculatedCcyLastQty val) { GetField(val); return val; }
        public bool IsSet(LegCalculatedCcyLastQty val) { return IsSetLegCalculatedCcyLastQty(); }
        public bool IsSetLegCalculatedCcyLastQty() { return IsSetField(Tags.LegCalculatedCcyLastQty); }

        public LegGrossTradeAmt LegGrossTradeAmt
        {
            get
            {
                LegGrossTradeAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegGrossTradeAmt val) { LegGrossTradeAmt = val; }
        public LegGrossTradeAmt Get(LegGrossTradeAmt val) { GetField(val); return val; }
        public bool IsSet(LegGrossTradeAmt val) { return IsSetLegGrossTradeAmt(); }
        public bool IsSetLegGrossTradeAmt() { return IsSetField(Tags.LegGrossTradeAmt); }

        public class NoLegSecurityAltIDGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};

            public NoLegSecurityAltIDGroup()
              : base(Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegSecurityAltID LegSecurityAltID
            {
                get
                {
                    LegSecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityAltID val) { LegSecurityAltID = val; }
            public LegSecurityAltID Get(LegSecurityAltID val) { GetField(val); return val; }
            public bool IsSet(LegSecurityAltID val) { return IsSetLegSecurityAltID(); }
            public bool IsSetLegSecurityAltID() { return IsSetField(Tags.LegSecurityAltID); }

            public LegSecurityAltIDSource LegSecurityAltIDSource
            {
                get
                {
                    LegSecurityAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityAltIDSource val) { LegSecurityAltIDSource = val; }
            public LegSecurityAltIDSource Get(LegSecurityAltIDSource val) { GetField(val); return val; }
            public bool IsSet(LegSecurityAltIDSource val) { return IsSetLegSecurityAltIDSource(); }
            public bool IsSetLegSecurityAltIDSource() { return IsSetField(Tags.LegSecurityAltIDSource); }
        }

        public class NoLegStipulationsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegStipulationType, Tags.LegStipulationValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.LegStipulationType, Tags.LegStipulationValue, 0};

            public NoLegStipulationsGroup()
              : base(Tags.NoLegStipulations, Tags.LegStipulationType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegStipulationsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegStipulationType LegStipulationType
            {
                get
                {
                    LegStipulationType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStipulationType val) { LegStipulationType = val; }
            public LegStipulationType Get(LegStipulationType val) { GetField(val); return val; }
            public bool IsSet(LegStipulationType val) { return IsSetLegStipulationType(); }
            public bool IsSetLegStipulationType() { return IsSetField(Tags.LegStipulationType); }

            public LegStipulationValue LegStipulationValue
            {
                get
                {
                    LegStipulationValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStipulationValue val) { LegStipulationValue = val; }
            public LegStipulationValue Get(LegStipulationValue val) { GetField(val); return val; }
            public bool IsSet(LegStipulationValue val) { return IsSetLegStipulationValue(); }
            public bool IsSetLegStipulationValue() { return IsSetField(Tags.LegStipulationValue); }
        }

        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};

            public NoNestedPartyIDsGroup()
              : base(Tags.NoNestedPartyIDs, Tags.NestedPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public NestedPartyID NestedPartyID
            {
                get
                {
                    NestedPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyID val) { NestedPartyID = val; }
            public NestedPartyID Get(NestedPartyID val) { GetField(val); return val; }
            public bool IsSet(NestedPartyID val) { return IsSetNestedPartyID(); }
            public bool IsSetNestedPartyID() { return IsSetField(Tags.NestedPartyID); }

            public NestedPartyIDSource NestedPartyIDSource
            {
                get
                {
                    NestedPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyIDSource val) { NestedPartyIDSource = val; }
            public NestedPartyIDSource Get(NestedPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(NestedPartyIDSource val) { return IsSetNestedPartyIDSource(); }
            public bool IsSetNestedPartyIDSource() { return IsSetField(Tags.NestedPartyIDSource); }

            public NestedPartyRole NestedPartyRole
            {
                get
                {
                    NestedPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyRole val) { NestedPartyRole = val; }
            public NestedPartyRole Get(NestedPartyRole val) { GetField(val); return val; }
            public bool IsSet(NestedPartyRole val) { return IsSetNestedPartyRole(); }
            public bool IsSetNestedPartyRole() { return IsSetField(Tags.NestedPartyRole); }

            public NoNestedPartySubIDs NoNestedPartySubIDs
            {
                get
                {
                    NoNestedPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNestedPartySubIDs val) { NoNestedPartySubIDs = val; }
            public NoNestedPartySubIDs Get(NoNestedPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNestedPartySubIDs val) { return IsSetNoNestedPartySubIDs(); }
            public bool IsSetNoNestedPartySubIDs() { return IsSetField(Tags.NoNestedPartySubIDs); }

            public class NoNestedPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};

                public NoNestedPartySubIDsGroup()
                  : base(Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNestedPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public NestedPartySubID NestedPartySubID
                {
                    get
                    {
                        NestedPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubID val) { NestedPartySubID = val; }
                public NestedPartySubID Get(NestedPartySubID val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubID val) { return IsSetNestedPartySubID(); }
                public bool IsSetNestedPartySubID() { return IsSetField(Tags.NestedPartySubID); }

                public NestedPartySubIDType NestedPartySubIDType
                {
                    get
                    {
                        NestedPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubIDType val) { NestedPartySubIDType = val; }
                public NestedPartySubIDType Get(NestedPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubIDType val) { return IsSetNestedPartySubIDType(); }
                public bool IsSetNestedPartySubIDType() { return IsSetField(Tags.NestedPartySubIDType); }
            }
        }
    }

    public class NoMiscFeesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0};

        public NoMiscFeesGroup()
          : base(Tags.NoMiscFees, Tags.MiscFeeAmt, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoMiscFeesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public MiscFeeAmt MiscFeeAmt
        {
            get
            {
                MiscFeeAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MiscFeeAmt val) { MiscFeeAmt = val; }
        public MiscFeeAmt Get(MiscFeeAmt val) { GetField(val); return val; }
        public bool IsSet(MiscFeeAmt val) { return IsSetMiscFeeAmt(); }
        public bool IsSetMiscFeeAmt() { return IsSetField(Tags.MiscFeeAmt); }

        public MiscFeeCurr MiscFeeCurr
        {
            get
            {
                MiscFeeCurr val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MiscFeeCurr val) { MiscFeeCurr = val; }
        public MiscFeeCurr Get(MiscFeeCurr val) { GetField(val); return val; }
        public bool IsSet(MiscFeeCurr val) { return IsSetMiscFeeCurr(); }
        public bool IsSetMiscFeeCurr() { return IsSetField(Tags.MiscFeeCurr); }

        public MiscFeeType MiscFeeType
        {
            get
            {
                MiscFeeType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MiscFeeType val) { MiscFeeType = val; }
        public MiscFeeType Get(MiscFeeType val) { GetField(val); return val; }
        public bool IsSet(MiscFeeType val) { return IsSetMiscFeeType(); }
        public bool IsSetMiscFeeType() { return IsSetField(Tags.MiscFeeType); }

        public MiscFeeBasis MiscFeeBasis
        {
            get
            {
                MiscFeeBasis val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MiscFeeBasis val) { MiscFeeBasis = val; }
        public MiscFeeBasis Get(MiscFeeBasis val) { GetField(val); return val; }
        public bool IsSet(MiscFeeBasis val) { return IsSetMiscFeeBasis(); }
        public bool IsSetMiscFeeBasis() { return IsSetField(Tags.MiscFeeBasis); }
    }

    public class NoStrategyParametersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StrategyParameterName, Tags.StrategyParameterType, Tags.StrategyParameterValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.StrategyParameterName, Tags.StrategyParameterType, Tags.StrategyParameterValue, 0};

        public NoStrategyParametersGroup()
          : base(Tags.NoStrategyParameters, Tags.StrategyParameterName, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoStrategyParametersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public StrategyParameterName StrategyParameterName
        {
            get
            {
                StrategyParameterName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrategyParameterName val) { StrategyParameterName = val; }
        public StrategyParameterName Get(StrategyParameterName val) { GetField(val); return val; }
        public bool IsSet(StrategyParameterName val) { return IsSetStrategyParameterName(); }
        public bool IsSetStrategyParameterName() { return IsSetField(Tags.StrategyParameterName); }

        public StrategyParameterType StrategyParameterType
        {
            get
            {
                StrategyParameterType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrategyParameterType val) { StrategyParameterType = val; }
        public StrategyParameterType Get(StrategyParameterType val) { GetField(val); return val; }
        public bool IsSet(StrategyParameterType val) { return IsSetStrategyParameterType(); }
        public bool IsSetStrategyParameterType() { return IsSetField(Tags.StrategyParameterType); }

        public StrategyParameterValue StrategyParameterValue
        {
            get
            {
                StrategyParameterValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrategyParameterValue val) { StrategyParameterValue = val; }
        public StrategyParameterValue Get(StrategyParameterValue val) { GetField(val); return val; }
        public bool IsSet(StrategyParameterValue val) { return IsSetStrategyParameterValue(); }
        public bool IsSetStrategyParameterValue() { return IsSetField(Tags.StrategyParameterValue); }
    }

    public class NoTrdRegTimestampsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0};

        public NoTrdRegTimestampsGroup()
          : base(Tags.NoTrdRegTimestamps, Tags.TrdRegTimestamp, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTrdRegTimestampsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public TrdRegTimestamp TrdRegTimestamp
        {
            get
            {
                TrdRegTimestamp val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestamp val) { TrdRegTimestamp = val; }
        public TrdRegTimestamp Get(TrdRegTimestamp val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestamp val) { return IsSetTrdRegTimestamp(); }
        public bool IsSetTrdRegTimestamp() { return IsSetField(Tags.TrdRegTimestamp); }

        public TrdRegTimestampType TrdRegTimestampType
        {
            get
            {
                TrdRegTimestampType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestampType val) { TrdRegTimestampType = val; }
        public TrdRegTimestampType Get(TrdRegTimestampType val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestampType val) { return IsSetTrdRegTimestampType(); }
        public bool IsSetTrdRegTimestampType() { return IsSetField(Tags.TrdRegTimestampType); }

        public TrdRegTimestampOrigin TrdRegTimestampOrigin
        {
            get
            {
                TrdRegTimestampOrigin val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestampOrigin val) { TrdRegTimestampOrigin = val; }
        public TrdRegTimestampOrigin Get(TrdRegTimestampOrigin val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestampOrigin val) { return IsSetTrdRegTimestampOrigin(); }
        public bool IsSetTrdRegTimestampOrigin() { return IsSetField(Tags.TrdRegTimestampOrigin); }

        public DeskType DeskType
        {
            get
            {
                DeskType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskType val) { DeskType = val; }
        public DeskType Get(DeskType val) { GetField(val); return val; }
        public bool IsSet(DeskType val) { return IsSetDeskType(); }
        public bool IsSetDeskType() { return IsSetField(Tags.DeskType); }

        public DeskTypeSource DeskTypeSource
        {
            get
            {
                DeskTypeSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskTypeSource val) { DeskTypeSource = val; }
        public DeskTypeSource Get(DeskTypeSource val) { GetField(val); return val; }
        public bool IsSet(DeskTypeSource val) { return IsSetDeskTypeSource(); }
        public bool IsSetDeskTypeSource() { return IsSetField(Tags.DeskTypeSource); }

        public DeskOrderHandlingInst DeskOrderHandlingInst
        {
            get
            {
                DeskOrderHandlingInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskOrderHandlingInst val) { DeskOrderHandlingInst = val; }
        public DeskOrderHandlingInst Get(DeskOrderHandlingInst val) { GetField(val); return val; }
        public bool IsSet(DeskOrderHandlingInst val) { return IsSetDeskOrderHandlingInst(); }
        public bool IsSetDeskOrderHandlingInst() { return IsSetField(Tags.DeskOrderHandlingInst); }
    }
}
