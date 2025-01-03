// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class MarketDataIncrementalRefresh : Message
{
    public const string MsgType = "X";

    public MarketDataIncrementalRefresh() : base()
    {
        Header.SetField(new MsgType("X"));
    }

    public MDReqID MDReqID
    {
        get
        {
            MDReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MDReqID val) { MDReqID = val; }
    public MDReqID Get(MDReqID val) { GetField(val); return val; }
    public bool IsSet(MDReqID val) { return IsSetMDReqID(); }
    public bool IsSetMDReqID() { return IsSetField(Tags.MDReqID); }

    public NoMDEntries NoMDEntries
    {
        get
        {
            NoMDEntries val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoMDEntries val) { NoMDEntries = val; }
    public NoMDEntries Get(NoMDEntries val) { GetField(val); return val; }
    public bool IsSet(NoMDEntries val) { return IsSetNoMDEntries(); }
    public bool IsSetNoMDEntries() { return IsSetField(Tags.NoMDEntries); }

    public class NoMDEntriesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.MDUpdateAction, Tags.DeleteReason, Tags.MDEntryType, Tags.MDEntryID, Tags.MDEntryRefID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.FinancialStatus, Tags.CorporateAction, Tags.MDEntryPx, Tags.Currency, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.TickDirection, Tags.MDMkt, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.QuoteCondition, Tags.TradeCondition, Tags.MDEntryOriginator, Tags.LocationID, Tags.DeskID, Tags.OpenCloseSettleFlag, Tags.TimeInForce, Tags.ExpireDate, Tags.ExpireTime, Tags.MinQty, Tags.ExecInst, Tags.SellerDays, Tags.OrderID, Tags.QuoteEntryID, Tags.MDEntryBuyer, Tags.MDEntrySeller, Tags.NumberOfOrders, Tags.MDEntryPositionNo, Tags.Scope, Tags.TotalVolumeTraded, Tags.TotalVolumeTradedDate, Tags.TotalVolumeTradedTime, Tags.NetChgPrevDay, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.MDUpdateAction, Tags.DeleteReason, Tags.MDEntryType, Tags.MDEntryID, Tags.MDEntryRefID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.FinancialStatus, Tags.CorporateAction, Tags.MDEntryPx, Tags.Currency, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.TickDirection, Tags.MDMkt, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.QuoteCondition, Tags.TradeCondition, Tags.MDEntryOriginator, Tags.LocationID, Tags.DeskID, Tags.OpenCloseSettleFlag, Tags.TimeInForce, Tags.ExpireDate, Tags.ExpireTime, Tags.MinQty, Tags.ExecInst, Tags.SellerDays, Tags.OrderID, Tags.QuoteEntryID, Tags.MDEntryBuyer, Tags.MDEntrySeller, Tags.NumberOfOrders, Tags.MDEntryPositionNo, Tags.Scope, Tags.TotalVolumeTraded, Tags.TotalVolumeTradedDate, Tags.TotalVolumeTradedTime, Tags.NetChgPrevDay, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};

        public NoMDEntriesGroup()
          : base(Tags.NoMDEntries, Tags.MDUpdateAction, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoMDEntriesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public MDUpdateAction MDUpdateAction
        {
            get
            {
                MDUpdateAction val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDUpdateAction val) { MDUpdateAction = val; }
        public MDUpdateAction Get(MDUpdateAction val) { GetField(val); return val; }
        public bool IsSet(MDUpdateAction val) { return IsSetMDUpdateAction(); }
        public bool IsSetMDUpdateAction() { return IsSetField(Tags.MDUpdateAction); }

        public DeleteReason DeleteReason
        {
            get
            {
                DeleteReason val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeleteReason val) { DeleteReason = val; }
        public DeleteReason Get(DeleteReason val) { GetField(val); return val; }
        public bool IsSet(DeleteReason val) { return IsSetDeleteReason(); }
        public bool IsSetDeleteReason() { return IsSetField(Tags.DeleteReason); }

        public MDEntryType MDEntryType
        {
            get
            {
                MDEntryType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryType val) { MDEntryType = val; }
        public MDEntryType Get(MDEntryType val) { GetField(val); return val; }
        public bool IsSet(MDEntryType val) { return IsSetMDEntryType(); }
        public bool IsSetMDEntryType() { return IsSetField(Tags.MDEntryType); }

        public MDEntryID MDEntryID
        {
            get
            {
                MDEntryID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryID val) { MDEntryID = val; }
        public MDEntryID Get(MDEntryID val) { GetField(val); return val; }
        public bool IsSet(MDEntryID val) { return IsSetMDEntryID(); }
        public bool IsSetMDEntryID() { return IsSetField(Tags.MDEntryID); }

        public MDEntryRefID MDEntryRefID
        {
            get
            {
                MDEntryRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryRefID val) { MDEntryRefID = val; }
        public MDEntryRefID Get(MDEntryRefID val) { GetField(val); return val; }
        public bool IsSet(MDEntryRefID val) { return IsSetMDEntryRefID(); }
        public bool IsSetMDEntryRefID() { return IsSetField(Tags.MDEntryRefID); }

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

        public FinancialStatus FinancialStatus
        {
            get
            {
                FinancialStatus val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FinancialStatus val) { FinancialStatus = val; }
        public FinancialStatus Get(FinancialStatus val) { GetField(val); return val; }
        public bool IsSet(FinancialStatus val) { return IsSetFinancialStatus(); }
        public bool IsSetFinancialStatus() { return IsSetField(Tags.FinancialStatus); }

        public CorporateAction CorporateAction
        {
            get
            {
                CorporateAction val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CorporateAction val) { CorporateAction = val; }
        public CorporateAction Get(CorporateAction val) { GetField(val); return val; }
        public bool IsSet(CorporateAction val) { return IsSetCorporateAction(); }
        public bool IsSetCorporateAction() { return IsSetField(Tags.CorporateAction); }

        public MDEntryPx MDEntryPx
        {
            get
            {
                MDEntryPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryPx val) { MDEntryPx = val; }
        public MDEntryPx Get(MDEntryPx val) { GetField(val); return val; }
        public bool IsSet(MDEntryPx val) { return IsSetMDEntryPx(); }
        public bool IsSetMDEntryPx() { return IsSetField(Tags.MDEntryPx); }

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

        public MDEntrySize MDEntrySize
        {
            get
            {
                MDEntrySize val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntrySize val) { MDEntrySize = val; }
        public MDEntrySize Get(MDEntrySize val) { GetField(val); return val; }
        public bool IsSet(MDEntrySize val) { return IsSetMDEntrySize(); }
        public bool IsSetMDEntrySize() { return IsSetField(Tags.MDEntrySize); }

        public MDEntryDate MDEntryDate
        {
            get
            {
                MDEntryDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryDate val) { MDEntryDate = val; }
        public MDEntryDate Get(MDEntryDate val) { GetField(val); return val; }
        public bool IsSet(MDEntryDate val) { return IsSetMDEntryDate(); }
        public bool IsSetMDEntryDate() { return IsSetField(Tags.MDEntryDate); }

        public MDEntryTime MDEntryTime
        {
            get
            {
                MDEntryTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryTime val) { MDEntryTime = val; }
        public MDEntryTime Get(MDEntryTime val) { GetField(val); return val; }
        public bool IsSet(MDEntryTime val) { return IsSetMDEntryTime(); }
        public bool IsSetMDEntryTime() { return IsSetField(Tags.MDEntryTime); }

        public TickDirection TickDirection
        {
            get
            {
                TickDirection val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TickDirection val) { TickDirection = val; }
        public TickDirection Get(TickDirection val) { GetField(val); return val; }
        public bool IsSet(TickDirection val) { return IsSetTickDirection(); }
        public bool IsSetTickDirection() { return IsSetField(Tags.TickDirection); }

        public MDMkt MDMkt
        {
            get
            {
                MDMkt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDMkt val) { MDMkt = val; }
        public MDMkt Get(MDMkt val) { GetField(val); return val; }
        public bool IsSet(MDMkt val) { return IsSetMDMkt(); }
        public bool IsSetMDMkt() { return IsSetField(Tags.MDMkt); }

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

        public QuoteCondition QuoteCondition
        {
            get
            {
                QuoteCondition val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteCondition val) { QuoteCondition = val; }
        public QuoteCondition Get(QuoteCondition val) { GetField(val); return val; }
        public bool IsSet(QuoteCondition val) { return IsSetQuoteCondition(); }
        public bool IsSetQuoteCondition() { return IsSetField(Tags.QuoteCondition); }

        public TradeCondition TradeCondition
        {
            get
            {
                TradeCondition val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeCondition val) { TradeCondition = val; }
        public TradeCondition Get(TradeCondition val) { GetField(val); return val; }
        public bool IsSet(TradeCondition val) { return IsSetTradeCondition(); }
        public bool IsSetTradeCondition() { return IsSetField(Tags.TradeCondition); }

        public MDEntryOriginator MDEntryOriginator
        {
            get
            {
                MDEntryOriginator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryOriginator val) { MDEntryOriginator = val; }
        public MDEntryOriginator Get(MDEntryOriginator val) { GetField(val); return val; }
        public bool IsSet(MDEntryOriginator val) { return IsSetMDEntryOriginator(); }
        public bool IsSetMDEntryOriginator() { return IsSetField(Tags.MDEntryOriginator); }

        public LocationID LocationID
        {
            get
            {
                LocationID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LocationID val) { LocationID = val; }
        public LocationID Get(LocationID val) { GetField(val); return val; }
        public bool IsSet(LocationID val) { return IsSetLocationID(); }
        public bool IsSetLocationID() { return IsSetField(Tags.LocationID); }

        public DeskID DeskID
        {
            get
            {
                DeskID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskID val) { DeskID = val; }
        public DeskID Get(DeskID val) { GetField(val); return val; }
        public bool IsSet(DeskID val) { return IsSetDeskID(); }
        public bool IsSetDeskID() { return IsSetField(Tags.DeskID); }

        public OpenCloseSettleFlag OpenCloseSettleFlag
        {
            get
            {
                OpenCloseSettleFlag val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OpenCloseSettleFlag val) { OpenCloseSettleFlag = val; }
        public OpenCloseSettleFlag Get(OpenCloseSettleFlag val) { GetField(val); return val; }
        public bool IsSet(OpenCloseSettleFlag val) { return IsSetOpenCloseSettleFlag(); }
        public bool IsSetOpenCloseSettleFlag() { return IsSetField(Tags.OpenCloseSettleFlag); }

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

        public SellerDays SellerDays
        {
            get
            {
                SellerDays val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SellerDays val) { SellerDays = val; }
        public SellerDays Get(SellerDays val) { GetField(val); return val; }
        public bool IsSet(SellerDays val) { return IsSetSellerDays(); }
        public bool IsSetSellerDays() { return IsSetField(Tags.SellerDays); }

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

        public QuoteEntryID QuoteEntryID
        {
            get
            {
                QuoteEntryID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteEntryID val) { QuoteEntryID = val; }
        public QuoteEntryID Get(QuoteEntryID val) { GetField(val); return val; }
        public bool IsSet(QuoteEntryID val) { return IsSetQuoteEntryID(); }
        public bool IsSetQuoteEntryID() { return IsSetField(Tags.QuoteEntryID); }

        public MDEntryBuyer MDEntryBuyer
        {
            get
            {
                MDEntryBuyer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryBuyer val) { MDEntryBuyer = val; }
        public MDEntryBuyer Get(MDEntryBuyer val) { GetField(val); return val; }
        public bool IsSet(MDEntryBuyer val) { return IsSetMDEntryBuyer(); }
        public bool IsSetMDEntryBuyer() { return IsSetField(Tags.MDEntryBuyer); }

        public MDEntrySeller MDEntrySeller
        {
            get
            {
                MDEntrySeller val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntrySeller val) { MDEntrySeller = val; }
        public MDEntrySeller Get(MDEntrySeller val) { GetField(val); return val; }
        public bool IsSet(MDEntrySeller val) { return IsSetMDEntrySeller(); }
        public bool IsSetMDEntrySeller() { return IsSetField(Tags.MDEntrySeller); }

        public NumberOfOrders NumberOfOrders
        {
            get
            {
                NumberOfOrders val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NumberOfOrders val) { NumberOfOrders = val; }
        public NumberOfOrders Get(NumberOfOrders val) { GetField(val); return val; }
        public bool IsSet(NumberOfOrders val) { return IsSetNumberOfOrders(); }
        public bool IsSetNumberOfOrders() { return IsSetField(Tags.NumberOfOrders); }

        public MDEntryPositionNo MDEntryPositionNo
        {
            get
            {
                MDEntryPositionNo val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryPositionNo val) { MDEntryPositionNo = val; }
        public MDEntryPositionNo Get(MDEntryPositionNo val) { GetField(val); return val; }
        public bool IsSet(MDEntryPositionNo val) { return IsSetMDEntryPositionNo(); }
        public bool IsSetMDEntryPositionNo() { return IsSetField(Tags.MDEntryPositionNo); }

        public Scope Scope
        {
            get
            {
                Scope val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Scope val) { Scope = val; }
        public Scope Get(Scope val) { GetField(val); return val; }
        public bool IsSet(Scope val) { return IsSetScope(); }
        public bool IsSetScope() { return IsSetField(Tags.Scope); }

        public TotalVolumeTraded TotalVolumeTraded
        {
            get
            {
                TotalVolumeTraded val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TotalVolumeTraded val) { TotalVolumeTraded = val; }
        public TotalVolumeTraded Get(TotalVolumeTraded val) { GetField(val); return val; }
        public bool IsSet(TotalVolumeTraded val) { return IsSetTotalVolumeTraded(); }
        public bool IsSetTotalVolumeTraded() { return IsSetField(Tags.TotalVolumeTraded); }

        public TotalVolumeTradedDate TotalVolumeTradedDate
        {
            get
            {
                TotalVolumeTradedDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TotalVolumeTradedDate val) { TotalVolumeTradedDate = val; }
        public TotalVolumeTradedDate Get(TotalVolumeTradedDate val) { GetField(val); return val; }
        public bool IsSet(TotalVolumeTradedDate val) { return IsSetTotalVolumeTradedDate(); }
        public bool IsSetTotalVolumeTradedDate() { return IsSetField(Tags.TotalVolumeTradedDate); }

        public TotalVolumeTradedTime TotalVolumeTradedTime
        {
            get
            {
                TotalVolumeTradedTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TotalVolumeTradedTime val) { TotalVolumeTradedTime = val; }
        public TotalVolumeTradedTime Get(TotalVolumeTradedTime val) { GetField(val); return val; }
        public bool IsSet(TotalVolumeTradedTime val) { return IsSetTotalVolumeTradedTime(); }
        public bool IsSetTotalVolumeTradedTime() { return IsSetField(Tags.TotalVolumeTradedTime); }

        public NetChgPrevDay NetChgPrevDay
        {
            get
            {
                NetChgPrevDay val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NetChgPrevDay val) { NetChgPrevDay = val; }
        public NetChgPrevDay Get(NetChgPrevDay val) { GetField(val); return val; }
        public bool IsSet(NetChgPrevDay val) { return IsSetNetChgPrevDay(); }
        public bool IsSetNetChgPrevDay() { return IsSetField(Tags.NetChgPrevDay); }

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
    }
}
