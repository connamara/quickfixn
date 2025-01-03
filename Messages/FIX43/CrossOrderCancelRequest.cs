// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class CrossOrderCancelRequest : Message
{
    public const string MsgType = "u";

    public CrossOrderCancelRequest() : base()
    {
        Header.SetField(new MsgType("u"));
    }

    public CrossOrderCancelRequest(
            CrossID aCrossID,
            OrigCrossID aOrigCrossID,
            CrossType aCrossType,
            CrossPrioritization aCrossPrioritization,
            Symbol aSymbol,
            TransactTime aTransactTime
        ) : this()
    {
        CrossID = aCrossID;
        OrigCrossID = aOrigCrossID;
        CrossType = aCrossType;
        CrossPrioritization = aCrossPrioritization;
        Symbol = aSymbol;
        TransactTime = aTransactTime;
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

    public CrossPrioritization CrossPrioritization
    {
        get
        {
            CrossPrioritization val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CrossPrioritization val) { CrossPrioritization = val; }
    public CrossPrioritization Get(CrossPrioritization val) { GetField(val); return val; }
    public bool IsSet(CrossPrioritization val) { return IsSetCrossPrioritization(); }
    public bool IsSetCrossPrioritization() { return IsSetField(Tags.CrossPrioritization); }

    public NoSides NoSides
    {
        get
        {
            NoSides val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSides val) { NoSides = val; }
    public NoSides Get(NoSides val) { GetField(val); return val; }
    public bool IsSet(NoSides val) { return IsSetNoSides(); }
    public bool IsSetNoSides() { return IsSetField(Tags.NoSides); }

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

    public class NoSidesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Side, Tags.OrigClOrdID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ClOrdLinkID, Tags.OrigOrdModTime, Tags.NoPartyIDs, Tags.TradeOriginationDate, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.ComplianceID, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Side, Tags.OrigClOrdID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ClOrdLinkID, Tags.OrigOrdModTime, Tags.NoPartyIDs, Tags.TradeOriginationDate, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.ComplianceID, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};

        public NoSidesGroup()
          : base(Tags.NoSides, Tags.Side, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSidesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public OrigOrdModTime OrigOrdModTime
        {
            get
            {
                OrigOrdModTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrigOrdModTime val) { OrigOrdModTime = val; }
        public OrigOrdModTime Get(OrigOrdModTime val) { GetField(val); return val; }
        public bool IsSet(OrigOrdModTime val) { return IsSetOrigOrdModTime(); }
        public bool IsSetOrigOrdModTime() { return IsSetField(Tags.OrigOrdModTime); }

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

        public class NoPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};

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
        }
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
}
