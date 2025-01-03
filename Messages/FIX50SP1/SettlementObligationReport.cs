// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class SettlementObligationReport : Message
{
    public const string MsgType = "BQ";

    public SettlementObligationReport() : base()
    {
        Header.SetField(new MsgType("BQ"));
    }

    public SettlementObligationReport(
            SettlObligMsgID aSettlObligMsgID,
            SettlObligMode aSettlObligMode
        ) : this()
    {
        SettlObligMsgID = aSettlObligMsgID;
        SettlObligMode = aSettlObligMode;
    }

    public ClearingBusinessDate ClearingBusinessDate
    {
        get
        {
            ClearingBusinessDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClearingBusinessDate val) { ClearingBusinessDate = val; }
    public ClearingBusinessDate Get(ClearingBusinessDate val) { GetField(val); return val; }
    public bool IsSet(ClearingBusinessDate val) { return IsSetClearingBusinessDate(); }
    public bool IsSetClearingBusinessDate() { return IsSetField(Tags.ClearingBusinessDate); }

    public SettlementCycleNo SettlementCycleNo
    {
        get
        {
            SettlementCycleNo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlementCycleNo val) { SettlementCycleNo = val; }
    public SettlementCycleNo Get(SettlementCycleNo val) { GetField(val); return val; }
    public bool IsSet(SettlementCycleNo val) { return IsSetSettlementCycleNo(); }
    public bool IsSetSettlementCycleNo() { return IsSetField(Tags.SettlementCycleNo); }

    public SettlObligMsgID SettlObligMsgID
    {
        get
        {
            SettlObligMsgID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlObligMsgID val) { SettlObligMsgID = val; }
    public SettlObligMsgID Get(SettlObligMsgID val) { GetField(val); return val; }
    public bool IsSet(SettlObligMsgID val) { return IsSetSettlObligMsgID(); }
    public bool IsSetSettlObligMsgID() { return IsSetField(Tags.SettlObligMsgID); }

    public SettlObligMode SettlObligMode
    {
        get
        {
            SettlObligMode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlObligMode val) { SettlObligMode = val; }
    public SettlObligMode Get(SettlObligMode val) { GetField(val); return val; }
    public bool IsSet(SettlObligMode val) { return IsSetSettlObligMode(); }
    public bool IsSetSettlObligMode() { return IsSetField(Tags.SettlObligMode); }

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

    public NoSettlOblig NoSettlOblig
    {
        get
        {
            NoSettlOblig val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSettlOblig val) { NoSettlOblig = val; }
    public NoSettlOblig Get(NoSettlOblig val) { GetField(val); return val; }
    public bool IsSet(NoSettlOblig val) { return IsSetNoSettlOblig(); }
    public bool IsSetNoSettlOblig() { return IsSetField(Tags.NoSettlOblig); }

    public ApplID ApplID
    {
        get
        {
            ApplID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplID val) { ApplID = val; }
    public ApplID Get(ApplID val) { GetField(val); return val; }
    public bool IsSet(ApplID val) { return IsSetApplID(); }
    public bool IsSetApplID() { return IsSetField(Tags.ApplID); }

    public ApplSeqNum ApplSeqNum
    {
        get
        {
            ApplSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplSeqNum val) { ApplSeqNum = val; }
    public ApplSeqNum Get(ApplSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplSeqNum val) { return IsSetApplSeqNum(); }
    public bool IsSetApplSeqNum() { return IsSetField(Tags.ApplSeqNum); }

    public ApplLastSeqNum ApplLastSeqNum
    {
        get
        {
            ApplLastSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplLastSeqNum val) { ApplLastSeqNum = val; }
    public ApplLastSeqNum Get(ApplLastSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplLastSeqNum val) { return IsSetApplLastSeqNum(); }
    public bool IsSetApplLastSeqNum() { return IsSetField(Tags.ApplLastSeqNum); }

    public ApplResendFlag ApplResendFlag
    {
        get
        {
            ApplResendFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResendFlag val) { ApplResendFlag = val; }
    public ApplResendFlag Get(ApplResendFlag val) { GetField(val); return val; }
    public bool IsSet(ApplResendFlag val) { return IsSetApplResendFlag(); }
    public bool IsSetApplResendFlag() { return IsSetField(Tags.ApplResendFlag); }

    public class NoSettlObligGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.NetGrossInd, Tags.SettlObligID, Tags.SettlObligTransType, Tags.SettlObligRefID, Tags.CcyAmt, Tags.SettlCurrAmt, Tags.Currency, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlDate, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.NoPartyIDs, Tags.EffectiveTime, Tags.ExpireTime, Tags.LastUpdateTime, Tags.NoSettlDetails, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.NetGrossInd, Tags.SettlObligID, Tags.SettlObligTransType, Tags.SettlObligRefID, Tags.CcyAmt, Tags.SettlCurrAmt, Tags.Currency, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlDate, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.NoPartyIDs, Tags.EffectiveTime, Tags.ExpireTime, Tags.LastUpdateTime, Tags.NoSettlDetails, 0};

        public NoSettlObligGroup()
          : base(Tags.NoSettlOblig, Tags.NetGrossInd, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSettlObligGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public NetGrossInd NetGrossInd
        {
            get
            {
                NetGrossInd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NetGrossInd val) { NetGrossInd = val; }
        public NetGrossInd Get(NetGrossInd val) { GetField(val); return val; }
        public bool IsSet(NetGrossInd val) { return IsSetNetGrossInd(); }
        public bool IsSetNetGrossInd() { return IsSetField(Tags.NetGrossInd); }

        public SettlObligID SettlObligID
        {
            get
            {
                SettlObligID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlObligID val) { SettlObligID = val; }
        public SettlObligID Get(SettlObligID val) { GetField(val); return val; }
        public bool IsSet(SettlObligID val) { return IsSetSettlObligID(); }
        public bool IsSetSettlObligID() { return IsSetField(Tags.SettlObligID); }

        public SettlObligTransType SettlObligTransType
        {
            get
            {
                SettlObligTransType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlObligTransType val) { SettlObligTransType = val; }
        public SettlObligTransType Get(SettlObligTransType val) { GetField(val); return val; }
        public bool IsSet(SettlObligTransType val) { return IsSetSettlObligTransType(); }
        public bool IsSetSettlObligTransType() { return IsSetField(Tags.SettlObligTransType); }

        public SettlObligRefID SettlObligRefID
        {
            get
            {
                SettlObligRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlObligRefID val) { SettlObligRefID = val; }
        public SettlObligRefID Get(SettlObligRefID val) { GetField(val); return val; }
        public bool IsSet(SettlObligRefID val) { return IsSetSettlObligRefID(); }
        public bool IsSetSettlObligRefID() { return IsSetField(Tags.SettlObligRefID); }

        public CcyAmt CcyAmt
        {
            get
            {
                CcyAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CcyAmt val) { CcyAmt = val; }
        public CcyAmt Get(CcyAmt val) { GetField(val); return val; }
        public bool IsSet(CcyAmt val) { return IsSetCcyAmt(); }
        public bool IsSetCcyAmt() { return IsSetField(Tags.CcyAmt); }

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

        public SecurityGroup SecurityGroup
        {
            get
            {
                SecurityGroup val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityGroup val) { SecurityGroup = val; }
        public SecurityGroup Get(SecurityGroup val) { GetField(val); return val; }
        public bool IsSet(SecurityGroup val) { return IsSetSecurityGroup(); }
        public bool IsSetSecurityGroup() { return IsSetField(Tags.SecurityGroup); }

        public MinPriceIncrementAmount MinPriceIncrementAmount
        {
            get
            {
                MinPriceIncrementAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MinPriceIncrementAmount val) { MinPriceIncrementAmount = val; }
        public MinPriceIncrementAmount Get(MinPriceIncrementAmount val) { GetField(val); return val; }
        public bool IsSet(MinPriceIncrementAmount val) { return IsSetMinPriceIncrementAmount(); }
        public bool IsSetMinPriceIncrementAmount() { return IsSetField(Tags.MinPriceIncrementAmount); }

        public UnitOfMeasureQty UnitOfMeasureQty
        {
            get
            {
                UnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnitOfMeasureQty val) { UnitOfMeasureQty = val; }
        public UnitOfMeasureQty Get(UnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(UnitOfMeasureQty val) { return IsSetUnitOfMeasureQty(); }
        public bool IsSetUnitOfMeasureQty() { return IsSetField(Tags.UnitOfMeasureQty); }

        public SecurityXMLLen SecurityXMLLen
        {
            get
            {
                SecurityXMLLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityXMLLen val) { SecurityXMLLen = val; }
        public SecurityXMLLen Get(SecurityXMLLen val) { GetField(val); return val; }
        public bool IsSet(SecurityXMLLen val) { return IsSetSecurityXMLLen(); }
        public bool IsSetSecurityXMLLen() { return IsSetField(Tags.SecurityXMLLen); }

        public SecurityXML SecurityXML
        {
            get
            {
                SecurityXML val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityXML val) { SecurityXML = val; }
        public SecurityXML Get(SecurityXML val) { GetField(val); return val; }
        public bool IsSet(SecurityXML val) { return IsSetSecurityXML(); }
        public bool IsSetSecurityXML() { return IsSetField(Tags.SecurityXML); }

        public SecurityXMLSchema SecurityXMLSchema
        {
            get
            {
                SecurityXMLSchema val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityXMLSchema val) { SecurityXMLSchema = val; }
        public SecurityXMLSchema Get(SecurityXMLSchema val) { GetField(val); return val; }
        public bool IsSet(SecurityXMLSchema val) { return IsSetSecurityXMLSchema(); }
        public bool IsSetSecurityXMLSchema() { return IsSetField(Tags.SecurityXMLSchema); }

        public ProductComplex ProductComplex
        {
            get
            {
                ProductComplex val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ProductComplex val) { ProductComplex = val; }
        public ProductComplex Get(ProductComplex val) { GetField(val); return val; }
        public bool IsSet(ProductComplex val) { return IsSetProductComplex(); }
        public bool IsSetProductComplex() { return IsSetField(Tags.ProductComplex); }

        public PriceUnitOfMeasure PriceUnitOfMeasure
        {
            get
            {
                PriceUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceUnitOfMeasure val) { PriceUnitOfMeasure = val; }
        public PriceUnitOfMeasure Get(PriceUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(PriceUnitOfMeasure val) { return IsSetPriceUnitOfMeasure(); }
        public bool IsSetPriceUnitOfMeasure() { return IsSetField(Tags.PriceUnitOfMeasure); }

        public PriceUnitOfMeasureQty PriceUnitOfMeasureQty
        {
            get
            {
                PriceUnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceUnitOfMeasureQty val) { PriceUnitOfMeasureQty = val; }
        public PriceUnitOfMeasureQty Get(PriceUnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(PriceUnitOfMeasureQty val) { return IsSetPriceUnitOfMeasureQty(); }
        public bool IsSetPriceUnitOfMeasureQty() { return IsSetField(Tags.PriceUnitOfMeasureQty); }

        public SettlMethod SettlMethod
        {
            get
            {
                SettlMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlMethod val) { SettlMethod = val; }
        public SettlMethod Get(SettlMethod val) { GetField(val); return val; }
        public bool IsSet(SettlMethod val) { return IsSetSettlMethod(); }
        public bool IsSetSettlMethod() { return IsSetField(Tags.SettlMethod); }

        public ExerciseStyle ExerciseStyle
        {
            get
            {
                ExerciseStyle val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExerciseStyle val) { ExerciseStyle = val; }
        public ExerciseStyle Get(ExerciseStyle val) { GetField(val); return val; }
        public bool IsSet(ExerciseStyle val) { return IsSetExerciseStyle(); }
        public bool IsSetExerciseStyle() { return IsSetField(Tags.ExerciseStyle); }

        public OptPayAmount OptPayAmount
        {
            get
            {
                OptPayAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptPayAmount val) { OptPayAmount = val; }
        public OptPayAmount Get(OptPayAmount val) { GetField(val); return val; }
        public bool IsSet(OptPayAmount val) { return IsSetOptPayAmount(); }
        public bool IsSetOptPayAmount() { return IsSetField(Tags.OptPayAmount); }

        public PriceQuoteMethod PriceQuoteMethod
        {
            get
            {
                PriceQuoteMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceQuoteMethod val) { PriceQuoteMethod = val; }
        public PriceQuoteMethod Get(PriceQuoteMethod val) { GetField(val); return val; }
        public bool IsSet(PriceQuoteMethod val) { return IsSetPriceQuoteMethod(); }
        public bool IsSetPriceQuoteMethod() { return IsSetField(Tags.PriceQuoteMethod); }

        public ListMethod ListMethod
        {
            get
            {
                ListMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ListMethod val) { ListMethod = val; }
        public ListMethod Get(ListMethod val) { GetField(val); return val; }
        public bool IsSet(ListMethod val) { return IsSetListMethod(); }
        public bool IsSetListMethod() { return IsSetField(Tags.ListMethod); }

        public CapPrice CapPrice
        {
            get
            {
                CapPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CapPrice val) { CapPrice = val; }
        public CapPrice Get(CapPrice val) { GetField(val); return val; }
        public bool IsSet(CapPrice val) { return IsSetCapPrice(); }
        public bool IsSetCapPrice() { return IsSetField(Tags.CapPrice); }

        public FloorPrice FloorPrice
        {
            get
            {
                FloorPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FloorPrice val) { FloorPrice = val; }
        public FloorPrice Get(FloorPrice val) { GetField(val); return val; }
        public bool IsSet(FloorPrice val) { return IsSetFloorPrice(); }
        public bool IsSetFloorPrice() { return IsSetField(Tags.FloorPrice); }

        public PutOrCall PutOrCall
        {
            get
            {
                PutOrCall val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PutOrCall val) { PutOrCall = val; }
        public PutOrCall Get(PutOrCall val) { GetField(val); return val; }
        public bool IsSet(PutOrCall val) { return IsSetPutOrCall(); }
        public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }

        public FlexibleIndicator FlexibleIndicator
        {
            get
            {
                FlexibleIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FlexibleIndicator val) { FlexibleIndicator = val; }
        public FlexibleIndicator Get(FlexibleIndicator val) { GetField(val); return val; }
        public bool IsSet(FlexibleIndicator val) { return IsSetFlexibleIndicator(); }
        public bool IsSetFlexibleIndicator() { return IsSetField(Tags.FlexibleIndicator); }

        public FlexProductEligibilityIndicator FlexProductEligibilityIndicator
        {
            get
            {
                FlexProductEligibilityIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FlexProductEligibilityIndicator val) { FlexProductEligibilityIndicator = val; }
        public FlexProductEligibilityIndicator Get(FlexProductEligibilityIndicator val) { GetField(val); return val; }
        public bool IsSet(FlexProductEligibilityIndicator val) { return IsSetFlexProductEligibilityIndicator(); }
        public bool IsSetFlexProductEligibilityIndicator() { return IsSetField(Tags.FlexProductEligibilityIndicator); }

        public FuturesValuationMethod FuturesValuationMethod
        {
            get
            {
                FuturesValuationMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FuturesValuationMethod val) { FuturesValuationMethod = val; }
        public FuturesValuationMethod Get(FuturesValuationMethod val) { GetField(val); return val; }
        public bool IsSet(FuturesValuationMethod val) { return IsSetFuturesValuationMethod(); }
        public bool IsSetFuturesValuationMethod() { return IsSetField(Tags.FuturesValuationMethod); }

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

        public LastUpdateTime LastUpdateTime
        {
            get
            {
                LastUpdateTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LastUpdateTime val) { LastUpdateTime = val; }
        public LastUpdateTime Get(LastUpdateTime val) { GetField(val); return val; }
        public bool IsSet(LastUpdateTime val) { return IsSetLastUpdateTime(); }
        public bool IsSetLastUpdateTime() { return IsSetField(Tags.LastUpdateTime); }

        public NoSettlDetails NoSettlDetails
        {
            get
            {
                NoSettlDetails val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoSettlDetails val) { NoSettlDetails = val; }
        public NoSettlDetails Get(NoSettlDetails val) { GetField(val); return val; }
        public bool IsSet(NoSettlDetails val) { return IsSetNoSettlDetails(); }
        public bool IsSetNoSettlDetails() { return IsSetField(Tags.NoSettlDetails); }

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
            public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};

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

            public EventTime EventTime
            {
                get
                {
                    EventTime val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EventTime val) { EventTime = val; }
            public EventTime Get(EventTime val) { GetField(val); return val; }
            public bool IsSet(EventTime val) { return IsSetEventTime(); }
            public bool IsSetEventTime() { return IsSetField(Tags.EventTime); }
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

        public class NoSettlDetailsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.SettlObligSource, Tags.NoSettlPartyIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.SettlObligSource, Tags.NoSettlPartyIDs, 0};

            public NoSettlDetailsGroup()
              : base(Tags.NoSettlDetails, Tags.SettlObligSource, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSettlDetailsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public SettlObligSource SettlObligSource
            {
                get
                {
                    SettlObligSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SettlObligSource val) { SettlObligSource = val; }
            public SettlObligSource Get(SettlObligSource val) { GetField(val); return val; }
            public bool IsSet(SettlObligSource val) { return IsSetSettlObligSource(); }
            public bool IsSetSettlObligSource() { return IsSetField(Tags.SettlObligSource); }

            public NoSettlPartyIDs NoSettlPartyIDs
            {
                get
                {
                    NoSettlPartyIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoSettlPartyIDs val) { NoSettlPartyIDs = val; }
            public NoSettlPartyIDs Get(NoSettlPartyIDs val) { GetField(val); return val; }
            public bool IsSet(NoSettlPartyIDs val) { return IsSetNoSettlPartyIDs(); }
            public bool IsSetNoSettlPartyIDs() { return IsSetField(Tags.NoSettlPartyIDs); }

            public class NoSettlPartyIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};

                public NoSettlPartyIDsGroup()
                  : base(Tags.NoSettlPartyIDs, Tags.SettlPartyID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoSettlPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public SettlPartyID SettlPartyID
                {
                    get
                    {
                        SettlPartyID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyID val) { SettlPartyID = val; }
                public SettlPartyID Get(SettlPartyID val) { GetField(val); return val; }
                public bool IsSet(SettlPartyID val) { return IsSetSettlPartyID(); }
                public bool IsSetSettlPartyID() { return IsSetField(Tags.SettlPartyID); }

                public SettlPartyIDSource SettlPartyIDSource
                {
                    get
                    {
                        SettlPartyIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyIDSource val) { SettlPartyIDSource = val; }
                public SettlPartyIDSource Get(SettlPartyIDSource val) { GetField(val); return val; }
                public bool IsSet(SettlPartyIDSource val) { return IsSetSettlPartyIDSource(); }
                public bool IsSetSettlPartyIDSource() { return IsSetField(Tags.SettlPartyIDSource); }

                public SettlPartyRole SettlPartyRole
                {
                    get
                    {
                        SettlPartyRole val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyRole val) { SettlPartyRole = val; }
                public SettlPartyRole Get(SettlPartyRole val) { GetField(val); return val; }
                public bool IsSet(SettlPartyRole val) { return IsSetSettlPartyRole(); }
                public bool IsSetSettlPartyRole() { return IsSetField(Tags.SettlPartyRole); }

                public NoSettlPartySubIDs NoSettlPartySubIDs
                {
                    get
                    {
                        NoSettlPartySubIDs val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoSettlPartySubIDs val) { NoSettlPartySubIDs = val; }
                public NoSettlPartySubIDs Get(NoSettlPartySubIDs val) { GetField(val); return val; }
                public bool IsSet(NoSettlPartySubIDs val) { return IsSetNoSettlPartySubIDs(); }
                public bool IsSetNoSettlPartySubIDs() { return IsSetField(Tags.NoSettlPartySubIDs); }

                public class NoSettlPartySubIDsGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};

                    public NoSettlPartySubIDsGroup()
                      : base(Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoSettlPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public SettlPartySubID SettlPartySubID
                    {
                        get
                        {
                            SettlPartySubID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(SettlPartySubID val) { SettlPartySubID = val; }
                    public SettlPartySubID Get(SettlPartySubID val) { GetField(val); return val; }
                    public bool IsSet(SettlPartySubID val) { return IsSetSettlPartySubID(); }
                    public bool IsSetSettlPartySubID() { return IsSetField(Tags.SettlPartySubID); }

                    public SettlPartySubIDType SettlPartySubIDType
                    {
                        get
                        {
                            SettlPartySubIDType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(SettlPartySubIDType val) { SettlPartySubIDType = val; }
                    public SettlPartySubIDType Get(SettlPartySubIDType val) { GetField(val); return val; }
                    public bool IsSet(SettlPartySubIDType val) { return IsSetSettlPartySubIDType(); }
                    public bool IsSetSettlPartySubIDType() { return IsSetField(Tags.SettlPartySubIDType); }
                }
            }
        }
    }
}
