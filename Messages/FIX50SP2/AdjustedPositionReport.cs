// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class AdjustedPositionReport : Message
{
    public const string MsgType = "BL";

    public AdjustedPositionReport() : base()
    {
        Header.SetField(new MsgType("BL"));
    }

    public AdjustedPositionReport(
            PosMaintRptID aPosMaintRptID,
            ClearingBusinessDate aClearingBusinessDate
        ) : this()
    {
        PosMaintRptID = aPosMaintRptID;
        ClearingBusinessDate = aClearingBusinessDate;
    }

    public PosMaintRptID PosMaintRptID
    {
        get
        {
            PosMaintRptID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PosMaintRptID val) { PosMaintRptID = val; }
    public PosMaintRptID Get(PosMaintRptID val) { GetField(val); return val; }
    public bool IsSet(PosMaintRptID val) { return IsSetPosMaintRptID(); }
    public bool IsSetPosMaintRptID() { return IsSetField(Tags.PosMaintRptID); }

    public PosReqType PosReqType
    {
        get
        {
            PosReqType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PosReqType val) { PosReqType = val; }
    public PosReqType Get(PosReqType val) { GetField(val); return val; }
    public bool IsSet(PosReqType val) { return IsSetPosReqType(); }
    public bool IsSetPosReqType() { return IsSetField(Tags.PosReqType); }

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

    public SettlSessID SettlSessID
    {
        get
        {
            SettlSessID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlSessID val) { SettlSessID = val; }
    public SettlSessID Get(SettlSessID val) { GetField(val); return val; }
    public bool IsSet(SettlSessID val) { return IsSetSettlSessID(); }
    public bool IsSetSettlSessID() { return IsSetField(Tags.SettlSessID); }

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

    public NoPositions NoPositions
    {
        get
        {
            NoPositions val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPositions val) { NoPositions = val; }
    public NoPositions Get(NoPositions val) { GetField(val); return val; }
    public bool IsSet(NoPositions val) { return IsSetNoPositions(); }
    public bool IsSetNoPositions() { return IsSetField(Tags.NoPositions); }

    public NoRelatedSym NoRelatedSym
    {
        get
        {
            NoRelatedSym val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRelatedSym val) { NoRelatedSym = val; }
    public NoRelatedSym Get(NoRelatedSym val) { GetField(val); return val; }
    public bool IsSet(NoRelatedSym val) { return IsSetNoRelatedSym(); }
    public bool IsSetNoRelatedSym() { return IsSetField(Tags.NoRelatedSym); }

    public SettlPrice SettlPrice
    {
        get
        {
            SettlPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlPrice val) { SettlPrice = val; }
    public SettlPrice Get(SettlPrice val) { GetField(val); return val; }
    public bool IsSet(SettlPrice val) { return IsSetSettlPrice(); }
    public bool IsSetSettlPrice() { return IsSetField(Tags.SettlPrice); }

    public PriorSettlPrice PriorSettlPrice
    {
        get
        {
            PriorSettlPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriorSettlPrice val) { PriorSettlPrice = val; }
    public PriorSettlPrice Get(PriorSettlPrice val) { GetField(val); return val; }
    public bool IsSet(PriorSettlPrice val) { return IsSetPriorSettlPrice(); }
    public bool IsSetPriorSettlPrice() { return IsSetField(Tags.PriorSettlPrice); }

    public PosMaintRptRefID PosMaintRptRefID
    {
        get
        {
            PosMaintRptRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PosMaintRptRefID val) { PosMaintRptRefID = val; }
    public PosMaintRptRefID Get(PosMaintRptRefID val) { GetField(val); return val; }
    public bool IsSet(PosMaintRptRefID val) { return IsSetPosMaintRptRefID(); }
    public bool IsSetPosMaintRptRefID() { return IsSetField(Tags.PosMaintRptRefID); }

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

    public class NoPositionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PosType, Tags.LongQty, Tags.ShortQty, Tags.PosQtyStatus, Tags.NoNestedPartyIDs, Tags.QuantityDate, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PosType, Tags.LongQty, Tags.ShortQty, Tags.PosQtyStatus, Tags.NoNestedPartyIDs, Tags.QuantityDate, 0};

        public NoPositionsGroup()
          : base(Tags.NoPositions, Tags.PosType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPositionsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PosType PosType
        {
            get
            {
                PosType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PosType val) { PosType = val; }
        public PosType Get(PosType val) { GetField(val); return val; }
        public bool IsSet(PosType val) { return IsSetPosType(); }
        public bool IsSetPosType() { return IsSetField(Tags.PosType); }

        public LongQty LongQty
        {
            get
            {
                LongQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LongQty val) { LongQty = val; }
        public LongQty Get(LongQty val) { GetField(val); return val; }
        public bool IsSet(LongQty val) { return IsSetLongQty(); }
        public bool IsSetLongQty() { return IsSetField(Tags.LongQty); }

        public ShortQty ShortQty
        {
            get
            {
                ShortQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ShortQty val) { ShortQty = val; }
        public ShortQty Get(ShortQty val) { GetField(val); return val; }
        public bool IsSet(ShortQty val) { return IsSetShortQty(); }
        public bool IsSetShortQty() { return IsSetField(Tags.ShortQty); }

        public PosQtyStatus PosQtyStatus
        {
            get
            {
                PosQtyStatus val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PosQtyStatus val) { PosQtyStatus = val; }
        public PosQtyStatus Get(PosQtyStatus val) { GetField(val); return val; }
        public bool IsSet(PosQtyStatus val) { return IsSetPosQtyStatus(); }
        public bool IsSetPosQtyStatus() { return IsSetField(Tags.PosQtyStatus); }

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

        public QuantityDate QuantityDate
        {
            get
            {
                QuantityDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuantityDate val) { QuantityDate = val; }
        public QuantityDate Get(QuantityDate val) { GetField(val); return val; }
        public bool IsSet(QuantityDate val) { return IsSetQuantityDate(); }
        public bool IsSetQuantityDate() { return IsSetField(Tags.QuantityDate); }

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

    public class NoRelatedSymGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayoutAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.ValuationMethod, Tags.ContractMultiplierUnit, Tags.FlowScheduleType, Tags.RestructuringType, Tags.Seniority, Tags.NotionalPercentageOutstanding, Tags.OriginalNotionalPercentageOutstanding, Tags.AttachmentPoint, Tags.DetachmentPoint, Tags.StrikePriceDeterminationMethod, Tags.StrikePriceBoundaryMethod, Tags.StrikePriceBoundaryPrecision, Tags.UnderlyingPriceDeterminationMethod, Tags.OptPayoutType, Tags.NoComplexEvents, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayoutAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.ValuationMethod, Tags.ContractMultiplierUnit, Tags.FlowScheduleType, Tags.RestructuringType, Tags.Seniority, Tags.NotionalPercentageOutstanding, Tags.OriginalNotionalPercentageOutstanding, Tags.AttachmentPoint, Tags.DetachmentPoint, Tags.StrikePriceDeterminationMethod, Tags.StrikePriceBoundaryMethod, Tags.StrikePriceBoundaryPrecision, Tags.UnderlyingPriceDeterminationMethod, Tags.OptPayoutType, Tags.NoComplexEvents, 0};

        public NoRelatedSymGroup()
          : base(Tags.NoRelatedSym, Tags.Symbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRelatedSymGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public OptPayoutAmount OptPayoutAmount
        {
            get
            {
                OptPayoutAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptPayoutAmount val) { OptPayoutAmount = val; }
        public OptPayoutAmount Get(OptPayoutAmount val) { GetField(val); return val; }
        public bool IsSet(OptPayoutAmount val) { return IsSetOptPayoutAmount(); }
        public bool IsSetOptPayoutAmount() { return IsSetField(Tags.OptPayoutAmount); }

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

        public ValuationMethod ValuationMethod
        {
            get
            {
                ValuationMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ValuationMethod val) { ValuationMethod = val; }
        public ValuationMethod Get(ValuationMethod val) { GetField(val); return val; }
        public bool IsSet(ValuationMethod val) { return IsSetValuationMethod(); }
        public bool IsSetValuationMethod() { return IsSetField(Tags.ValuationMethod); }

        public ContractMultiplierUnit ContractMultiplierUnit
        {
            get
            {
                ContractMultiplierUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractMultiplierUnit val) { ContractMultiplierUnit = val; }
        public ContractMultiplierUnit Get(ContractMultiplierUnit val) { GetField(val); return val; }
        public bool IsSet(ContractMultiplierUnit val) { return IsSetContractMultiplierUnit(); }
        public bool IsSetContractMultiplierUnit() { return IsSetField(Tags.ContractMultiplierUnit); }

        public FlowScheduleType FlowScheduleType
        {
            get
            {
                FlowScheduleType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FlowScheduleType val) { FlowScheduleType = val; }
        public FlowScheduleType Get(FlowScheduleType val) { GetField(val); return val; }
        public bool IsSet(FlowScheduleType val) { return IsSetFlowScheduleType(); }
        public bool IsSetFlowScheduleType() { return IsSetField(Tags.FlowScheduleType); }

        public RestructuringType RestructuringType
        {
            get
            {
                RestructuringType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RestructuringType val) { RestructuringType = val; }
        public RestructuringType Get(RestructuringType val) { GetField(val); return val; }
        public bool IsSet(RestructuringType val) { return IsSetRestructuringType(); }
        public bool IsSetRestructuringType() { return IsSetField(Tags.RestructuringType); }

        public Seniority Seniority
        {
            get
            {
                Seniority val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Seniority val) { Seniority = val; }
        public Seniority Get(Seniority val) { GetField(val); return val; }
        public bool IsSet(Seniority val) { return IsSetSeniority(); }
        public bool IsSetSeniority() { return IsSetField(Tags.Seniority); }

        public NotionalPercentageOutstanding NotionalPercentageOutstanding
        {
            get
            {
                NotionalPercentageOutstanding val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NotionalPercentageOutstanding val) { NotionalPercentageOutstanding = val; }
        public NotionalPercentageOutstanding Get(NotionalPercentageOutstanding val) { GetField(val); return val; }
        public bool IsSet(NotionalPercentageOutstanding val) { return IsSetNotionalPercentageOutstanding(); }
        public bool IsSetNotionalPercentageOutstanding() { return IsSetField(Tags.NotionalPercentageOutstanding); }

        public OriginalNotionalPercentageOutstanding OriginalNotionalPercentageOutstanding
        {
            get
            {
                OriginalNotionalPercentageOutstanding val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OriginalNotionalPercentageOutstanding val) { OriginalNotionalPercentageOutstanding = val; }
        public OriginalNotionalPercentageOutstanding Get(OriginalNotionalPercentageOutstanding val) { GetField(val); return val; }
        public bool IsSet(OriginalNotionalPercentageOutstanding val) { return IsSetOriginalNotionalPercentageOutstanding(); }
        public bool IsSetOriginalNotionalPercentageOutstanding() { return IsSetField(Tags.OriginalNotionalPercentageOutstanding); }

        public AttachmentPoint AttachmentPoint
        {
            get
            {
                AttachmentPoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AttachmentPoint val) { AttachmentPoint = val; }
        public AttachmentPoint Get(AttachmentPoint val) { GetField(val); return val; }
        public bool IsSet(AttachmentPoint val) { return IsSetAttachmentPoint(); }
        public bool IsSetAttachmentPoint() { return IsSetField(Tags.AttachmentPoint); }

        public DetachmentPoint DetachmentPoint
        {
            get
            {
                DetachmentPoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DetachmentPoint val) { DetachmentPoint = val; }
        public DetachmentPoint Get(DetachmentPoint val) { GetField(val); return val; }
        public bool IsSet(DetachmentPoint val) { return IsSetDetachmentPoint(); }
        public bool IsSetDetachmentPoint() { return IsSetField(Tags.DetachmentPoint); }

        public StrikePriceDeterminationMethod StrikePriceDeterminationMethod
        {
            get
            {
                StrikePriceDeterminationMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikePriceDeterminationMethod val) { StrikePriceDeterminationMethod = val; }
        public StrikePriceDeterminationMethod Get(StrikePriceDeterminationMethod val) { GetField(val); return val; }
        public bool IsSet(StrikePriceDeterminationMethod val) { return IsSetStrikePriceDeterminationMethod(); }
        public bool IsSetStrikePriceDeterminationMethod() { return IsSetField(Tags.StrikePriceDeterminationMethod); }

        public StrikePriceBoundaryMethod StrikePriceBoundaryMethod
        {
            get
            {
                StrikePriceBoundaryMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikePriceBoundaryMethod val) { StrikePriceBoundaryMethod = val; }
        public StrikePriceBoundaryMethod Get(StrikePriceBoundaryMethod val) { GetField(val); return val; }
        public bool IsSet(StrikePriceBoundaryMethod val) { return IsSetStrikePriceBoundaryMethod(); }
        public bool IsSetStrikePriceBoundaryMethod() { return IsSetField(Tags.StrikePriceBoundaryMethod); }

        public StrikePriceBoundaryPrecision StrikePriceBoundaryPrecision
        {
            get
            {
                StrikePriceBoundaryPrecision val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikePriceBoundaryPrecision val) { StrikePriceBoundaryPrecision = val; }
        public StrikePriceBoundaryPrecision Get(StrikePriceBoundaryPrecision val) { GetField(val); return val; }
        public bool IsSet(StrikePriceBoundaryPrecision val) { return IsSetStrikePriceBoundaryPrecision(); }
        public bool IsSetStrikePriceBoundaryPrecision() { return IsSetField(Tags.StrikePriceBoundaryPrecision); }

        public UnderlyingPriceDeterminationMethod UnderlyingPriceDeterminationMethod
        {
            get
            {
                UnderlyingPriceDeterminationMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingPriceDeterminationMethod val) { UnderlyingPriceDeterminationMethod = val; }
        public UnderlyingPriceDeterminationMethod Get(UnderlyingPriceDeterminationMethod val) { GetField(val); return val; }
        public bool IsSet(UnderlyingPriceDeterminationMethod val) { return IsSetUnderlyingPriceDeterminationMethod(); }
        public bool IsSetUnderlyingPriceDeterminationMethod() { return IsSetField(Tags.UnderlyingPriceDeterminationMethod); }

        public OptPayoutType OptPayoutType
        {
            get
            {
                OptPayoutType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptPayoutType val) { OptPayoutType = val; }
        public OptPayoutType Get(OptPayoutType val) { GetField(val); return val; }
        public bool IsSet(OptPayoutType val) { return IsSetOptPayoutType(); }
        public bool IsSetOptPayoutType() { return IsSetField(Tags.OptPayoutType); }

        public NoComplexEvents NoComplexEvents
        {
            get
            {
                NoComplexEvents val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoComplexEvents val) { NoComplexEvents = val; }
        public NoComplexEvents Get(NoComplexEvents val) { GetField(val); return val; }
        public bool IsSet(NoComplexEvents val) { return IsSetNoComplexEvents(); }
        public bool IsSetNoComplexEvents() { return IsSetField(Tags.NoComplexEvents); }

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

        public class NoComplexEventsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};

            public NoComplexEventsGroup()
              : base(Tags.NoComplexEvents, Tags.ComplexEventType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoComplexEventsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ComplexEventType ComplexEventType
            {
                get
                {
                    ComplexEventType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventType val) { ComplexEventType = val; }
            public ComplexEventType Get(ComplexEventType val) { GetField(val); return val; }
            public bool IsSet(ComplexEventType val) { return IsSetComplexEventType(); }
            public bool IsSetComplexEventType() { return IsSetField(Tags.ComplexEventType); }

            public ComplexOptPayoutAmount ComplexOptPayoutAmount
            {
                get
                {
                    ComplexOptPayoutAmount val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexOptPayoutAmount val) { ComplexOptPayoutAmount = val; }
            public ComplexOptPayoutAmount Get(ComplexOptPayoutAmount val) { GetField(val); return val; }
            public bool IsSet(ComplexOptPayoutAmount val) { return IsSetComplexOptPayoutAmount(); }
            public bool IsSetComplexOptPayoutAmount() { return IsSetField(Tags.ComplexOptPayoutAmount); }

            public ComplexEventPrice ComplexEventPrice
            {
                get
                {
                    ComplexEventPrice val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventPrice val) { ComplexEventPrice = val; }
            public ComplexEventPrice Get(ComplexEventPrice val) { GetField(val); return val; }
            public bool IsSet(ComplexEventPrice val) { return IsSetComplexEventPrice(); }
            public bool IsSetComplexEventPrice() { return IsSetField(Tags.ComplexEventPrice); }

            public ComplexEventPriceBoundaryMethod ComplexEventPriceBoundaryMethod
            {
                get
                {
                    ComplexEventPriceBoundaryMethod val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventPriceBoundaryMethod val) { ComplexEventPriceBoundaryMethod = val; }
            public ComplexEventPriceBoundaryMethod Get(ComplexEventPriceBoundaryMethod val) { GetField(val); return val; }
            public bool IsSet(ComplexEventPriceBoundaryMethod val) { return IsSetComplexEventPriceBoundaryMethod(); }
            public bool IsSetComplexEventPriceBoundaryMethod() { return IsSetField(Tags.ComplexEventPriceBoundaryMethod); }

            public ComplexEventPriceBoundaryPrecision ComplexEventPriceBoundaryPrecision
            {
                get
                {
                    ComplexEventPriceBoundaryPrecision val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventPriceBoundaryPrecision val) { ComplexEventPriceBoundaryPrecision = val; }
            public ComplexEventPriceBoundaryPrecision Get(ComplexEventPriceBoundaryPrecision val) { GetField(val); return val; }
            public bool IsSet(ComplexEventPriceBoundaryPrecision val) { return IsSetComplexEventPriceBoundaryPrecision(); }
            public bool IsSetComplexEventPriceBoundaryPrecision() { return IsSetField(Tags.ComplexEventPriceBoundaryPrecision); }

            public ComplexEventPriceTimeType ComplexEventPriceTimeType
            {
                get
                {
                    ComplexEventPriceTimeType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventPriceTimeType val) { ComplexEventPriceTimeType = val; }
            public ComplexEventPriceTimeType Get(ComplexEventPriceTimeType val) { GetField(val); return val; }
            public bool IsSet(ComplexEventPriceTimeType val) { return IsSetComplexEventPriceTimeType(); }
            public bool IsSetComplexEventPriceTimeType() { return IsSetField(Tags.ComplexEventPriceTimeType); }

            public ComplexEventCondition ComplexEventCondition
            {
                get
                {
                    ComplexEventCondition val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventCondition val) { ComplexEventCondition = val; }
            public ComplexEventCondition Get(ComplexEventCondition val) { GetField(val); return val; }
            public bool IsSet(ComplexEventCondition val) { return IsSetComplexEventCondition(); }
            public bool IsSetComplexEventCondition() { return IsSetField(Tags.ComplexEventCondition); }

            public NoComplexEventDates NoComplexEventDates
            {
                get
                {
                    NoComplexEventDates val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoComplexEventDates val) { NoComplexEventDates = val; }
            public NoComplexEventDates Get(NoComplexEventDates val) { GetField(val); return val; }
            public bool IsSet(NoComplexEventDates val) { return IsSetNoComplexEventDates(); }
            public bool IsSetNoComplexEventDates() { return IsSetField(Tags.NoComplexEventDates); }

            public class NoComplexEventDatesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};

                public NoComplexEventDatesGroup()
                  : base(Tags.NoComplexEventDates, Tags.ComplexEventStartDate, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoComplexEventDatesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public ComplexEventStartDate ComplexEventStartDate
                {
                    get
                    {
                        ComplexEventStartDate val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ComplexEventStartDate val) { ComplexEventStartDate = val; }
                public ComplexEventStartDate Get(ComplexEventStartDate val) { GetField(val); return val; }
                public bool IsSet(ComplexEventStartDate val) { return IsSetComplexEventStartDate(); }
                public bool IsSetComplexEventStartDate() { return IsSetField(Tags.ComplexEventStartDate); }

                public ComplexEventEndDate ComplexEventEndDate
                {
                    get
                    {
                        ComplexEventEndDate val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ComplexEventEndDate val) { ComplexEventEndDate = val; }
                public ComplexEventEndDate Get(ComplexEventEndDate val) { GetField(val); return val; }
                public bool IsSet(ComplexEventEndDate val) { return IsSetComplexEventEndDate(); }
                public bool IsSetComplexEventEndDate() { return IsSetField(Tags.ComplexEventEndDate); }

                public NoComplexEventTimes NoComplexEventTimes
                {
                    get
                    {
                        NoComplexEventTimes val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoComplexEventTimes val) { NoComplexEventTimes = val; }
                public NoComplexEventTimes Get(NoComplexEventTimes val) { GetField(val); return val; }
                public bool IsSet(NoComplexEventTimes val) { return IsSetNoComplexEventTimes(); }
                public bool IsSetNoComplexEventTimes() { return IsSetField(Tags.NoComplexEventTimes); }

                public class NoComplexEventTimesGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};

                    public NoComplexEventTimesGroup()
                      : base(Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoComplexEventTimesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public ComplexEventStartTime ComplexEventStartTime
                    {
                        get
                        {
                            ComplexEventStartTime val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(ComplexEventStartTime val) { ComplexEventStartTime = val; }
                    public ComplexEventStartTime Get(ComplexEventStartTime val) { GetField(val); return val; }
                    public bool IsSet(ComplexEventStartTime val) { return IsSetComplexEventStartTime(); }
                    public bool IsSetComplexEventStartTime() { return IsSetField(Tags.ComplexEventStartTime); }

                    public ComplexEventEndTime ComplexEventEndTime
                    {
                        get
                        {
                            ComplexEventEndTime val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(ComplexEventEndTime val) { ComplexEventEndTime = val; }
                    public ComplexEventEndTime Get(ComplexEventEndTime val) { GetField(val); return val; }
                    public bool IsSet(ComplexEventEndTime val) { return IsSetComplexEventEndTime(); }
                    public bool IsSetComplexEventEndTime() { return IsSetField(Tags.ComplexEventEndTime); }
                }
            }
        }
    }
}
