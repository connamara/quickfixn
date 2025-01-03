// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class MassQuote : Message
{
    public const string MsgType = "i";

    public MassQuote() : base()
    {
        Header.SetField(new MsgType("i"));
    }

    public MassQuote(
            QuoteID aQuoteID
        ) : this()
    {
        QuoteID = aQuoteID;
    }

    public QuoteReqID QuoteReqID
    {
        get
        {
            QuoteReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteReqID val) { QuoteReqID = val; }
    public QuoteReqID Get(QuoteReqID val) { GetField(val); return val; }
    public bool IsSet(QuoteReqID val) { return IsSetQuoteReqID(); }
    public bool IsSetQuoteReqID() { return IsSetField(Tags.QuoteReqID); }

    public QuoteID QuoteID
    {
        get
        {
            QuoteID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteID val) { QuoteID = val; }
    public QuoteID Get(QuoteID val) { GetField(val); return val; }
    public bool IsSet(QuoteID val) { return IsSetQuoteID(); }
    public bool IsSetQuoteID() { return IsSetField(Tags.QuoteID); }

    public QuoteResponseLevel QuoteResponseLevel
    {
        get
        {
            QuoteResponseLevel val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteResponseLevel val) { QuoteResponseLevel = val; }
    public QuoteResponseLevel Get(QuoteResponseLevel val) { GetField(val); return val; }
    public bool IsSet(QuoteResponseLevel val) { return IsSetQuoteResponseLevel(); }
    public bool IsSetQuoteResponseLevel() { return IsSetField(Tags.QuoteResponseLevel); }

    public DefBidSize DefBidSize
    {
        get
        {
            DefBidSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DefBidSize val) { DefBidSize = val; }
    public DefBidSize Get(DefBidSize val) { GetField(val); return val; }
    public bool IsSet(DefBidSize val) { return IsSetDefBidSize(); }
    public bool IsSetDefBidSize() { return IsSetField(Tags.DefBidSize); }

    public DefOfferSize DefOfferSize
    {
        get
        {
            DefOfferSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DefOfferSize val) { DefOfferSize = val; }
    public DefOfferSize Get(DefOfferSize val) { GetField(val); return val; }
    public bool IsSet(DefOfferSize val) { return IsSetDefOfferSize(); }
    public bool IsSetDefOfferSize() { return IsSetField(Tags.DefOfferSize); }

    public NoQuoteSets NoQuoteSets
    {
        get
        {
            NoQuoteSets val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoQuoteSets val) { NoQuoteSets = val; }
    public NoQuoteSets Get(NoQuoteSets val) { GetField(val); return val; }
    public bool IsSet(NoQuoteSets val) { return IsSetNoQuoteSets(); }
    public bool IsSetNoQuoteSets() { return IsSetField(Tags.NoQuoteSets); }

    public class NoQuoteSetsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingIDSource, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDay, Tags.UnderlyingPutOrCall, Tags.UnderlyingStrikePrice, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.QuoteSetValidUntilTime, Tags.TotQuoteEntries, Tags.NoQuoteEntries, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingIDSource, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDay, Tags.UnderlyingPutOrCall, Tags.UnderlyingStrikePrice, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.QuoteSetValidUntilTime, Tags.TotQuoteEntries, Tags.NoQuoteEntries, 0};

        public NoQuoteSetsGroup()
          : base(Tags.NoQuoteSets, Tags.QuoteSetID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoQuoteSetsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public QuoteSetID QuoteSetID
        {
            get
            {
                QuoteSetID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteSetID val) { QuoteSetID = val; }
        public QuoteSetID Get(QuoteSetID val) { GetField(val); return val; }
        public bool IsSet(QuoteSetID val) { return IsSetQuoteSetID(); }
        public bool IsSetQuoteSetID() { return IsSetField(Tags.QuoteSetID); }

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

        public UnderlyingIDSource UnderlyingIDSource
        {
            get
            {
                UnderlyingIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIDSource val) { UnderlyingIDSource = val; }
        public UnderlyingIDSource Get(UnderlyingIDSource val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIDSource val) { return IsSetUnderlyingIDSource(); }
        public bool IsSetUnderlyingIDSource() { return IsSetField(Tags.UnderlyingIDSource); }

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

        public UnderlyingMaturityDay UnderlyingMaturityDay
        {
            get
            {
                UnderlyingMaturityDay val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingMaturityDay val) { UnderlyingMaturityDay = val; }
        public UnderlyingMaturityDay Get(UnderlyingMaturityDay val) { GetField(val); return val; }
        public bool IsSet(UnderlyingMaturityDay val) { return IsSetUnderlyingMaturityDay(); }
        public bool IsSetUnderlyingMaturityDay() { return IsSetField(Tags.UnderlyingMaturityDay); }

        public UnderlyingPutOrCall UnderlyingPutOrCall
        {
            get
            {
                UnderlyingPutOrCall val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingPutOrCall val) { UnderlyingPutOrCall = val; }
        public UnderlyingPutOrCall Get(UnderlyingPutOrCall val) { GetField(val); return val; }
        public bool IsSet(UnderlyingPutOrCall val) { return IsSetUnderlyingPutOrCall(); }
        public bool IsSetUnderlyingPutOrCall() { return IsSetField(Tags.UnderlyingPutOrCall); }

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

        public QuoteSetValidUntilTime QuoteSetValidUntilTime
        {
            get
            {
                QuoteSetValidUntilTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteSetValidUntilTime val) { QuoteSetValidUntilTime = val; }
        public QuoteSetValidUntilTime Get(QuoteSetValidUntilTime val) { GetField(val); return val; }
        public bool IsSet(QuoteSetValidUntilTime val) { return IsSetQuoteSetValidUntilTime(); }
        public bool IsSetQuoteSetValidUntilTime() { return IsSetField(Tags.QuoteSetValidUntilTime); }

        public TotQuoteEntries TotQuoteEntries
        {
            get
            {
                TotQuoteEntries val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TotQuoteEntries val) { TotQuoteEntries = val; }
        public TotQuoteEntries Get(TotQuoteEntries val) { GetField(val); return val; }
        public bool IsSet(TotQuoteEntries val) { return IsSetTotQuoteEntries(); }
        public bool IsSetTotQuoteEntries() { return IsSetField(Tags.TotQuoteEntries); }

        public NoQuoteEntries NoQuoteEntries
        {
            get
            {
                NoQuoteEntries val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoQuoteEntries val) { NoQuoteEntries = val; }
        public NoQuoteEntries Get(NoQuoteEntries val) { GetField(val); return val; }
        public bool IsSet(NoQuoteEntries val) { return IsSetNoQuoteEntries(); }
        public bool IsSetNoQuoteEntries() { return IsSetField(Tags.NoQuoteEntries); }

        public class NoQuoteEntriesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.TransactTime, Tags.TradingSessionID, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.Currency, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.TransactTime, Tags.TradingSessionID, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.Currency, 0};

            public NoQuoteEntriesGroup()
              : base(Tags.NoQuoteEntries, Tags.QuoteEntryID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoQuoteEntriesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

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

            public IDSource IDSource
            {
                get
                {
                    IDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(IDSource val) { IDSource = val; }
            public IDSource Get(IDSource val) { GetField(val); return val; }
            public bool IsSet(IDSource val) { return IsSetIDSource(); }
            public bool IsSetIDSource() { return IsSetField(Tags.IDSource); }

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

            public MaturityDay MaturityDay
            {
                get
                {
                    MaturityDay val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MaturityDay val) { MaturityDay = val; }
            public MaturityDay Get(MaturityDay val) { GetField(val); return val; }
            public bool IsSet(MaturityDay val) { return IsSetMaturityDay(); }
            public bool IsSetMaturityDay() { return IsSetField(Tags.MaturityDay); }

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

            public BidPx BidPx
            {
                get
                {
                    BidPx val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(BidPx val) { BidPx = val; }
            public BidPx Get(BidPx val) { GetField(val); return val; }
            public bool IsSet(BidPx val) { return IsSetBidPx(); }
            public bool IsSetBidPx() { return IsSetField(Tags.BidPx); }

            public OfferPx OfferPx
            {
                get
                {
                    OfferPx val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(OfferPx val) { OfferPx = val; }
            public OfferPx Get(OfferPx val) { GetField(val); return val; }
            public bool IsSet(OfferPx val) { return IsSetOfferPx(); }
            public bool IsSetOfferPx() { return IsSetField(Tags.OfferPx); }

            public BidSize BidSize
            {
                get
                {
                    BidSize val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(BidSize val) { BidSize = val; }
            public BidSize Get(BidSize val) { GetField(val); return val; }
            public bool IsSet(BidSize val) { return IsSetBidSize(); }
            public bool IsSetBidSize() { return IsSetField(Tags.BidSize); }

            public OfferSize OfferSize
            {
                get
                {
                    OfferSize val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(OfferSize val) { OfferSize = val; }
            public OfferSize Get(OfferSize val) { GetField(val); return val; }
            public bool IsSet(OfferSize val) { return IsSetOfferSize(); }
            public bool IsSetOfferSize() { return IsSetField(Tags.OfferSize); }

            public ValidUntilTime ValidUntilTime
            {
                get
                {
                    ValidUntilTime val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ValidUntilTime val) { ValidUntilTime = val; }
            public ValidUntilTime Get(ValidUntilTime val) { GetField(val); return val; }
            public bool IsSet(ValidUntilTime val) { return IsSetValidUntilTime(); }
            public bool IsSetValidUntilTime() { return IsSetField(Tags.ValidUntilTime); }

            public BidSpotRate BidSpotRate
            {
                get
                {
                    BidSpotRate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(BidSpotRate val) { BidSpotRate = val; }
            public BidSpotRate Get(BidSpotRate val) { GetField(val); return val; }
            public bool IsSet(BidSpotRate val) { return IsSetBidSpotRate(); }
            public bool IsSetBidSpotRate() { return IsSetField(Tags.BidSpotRate); }

            public OfferSpotRate OfferSpotRate
            {
                get
                {
                    OfferSpotRate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(OfferSpotRate val) { OfferSpotRate = val; }
            public OfferSpotRate Get(OfferSpotRate val) { GetField(val); return val; }
            public bool IsSet(OfferSpotRate val) { return IsSetOfferSpotRate(); }
            public bool IsSetOfferSpotRate() { return IsSetField(Tags.OfferSpotRate); }

            public BidForwardPoints BidForwardPoints
            {
                get
                {
                    BidForwardPoints val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(BidForwardPoints val) { BidForwardPoints = val; }
            public BidForwardPoints Get(BidForwardPoints val) { GetField(val); return val; }
            public bool IsSet(BidForwardPoints val) { return IsSetBidForwardPoints(); }
            public bool IsSetBidForwardPoints() { return IsSetField(Tags.BidForwardPoints); }

            public OfferForwardPoints OfferForwardPoints
            {
                get
                {
                    OfferForwardPoints val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(OfferForwardPoints val) { OfferForwardPoints = val; }
            public OfferForwardPoints Get(OfferForwardPoints val) { GetField(val); return val; }
            public bool IsSet(OfferForwardPoints val) { return IsSetOfferForwardPoints(); }
            public bool IsSetOfferForwardPoints() { return IsSetField(Tags.OfferForwardPoints); }

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

            public FutSettDate FutSettDate
            {
                get
                {
                    FutSettDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(FutSettDate val) { FutSettDate = val; }
            public FutSettDate Get(FutSettDate val) { GetField(val); return val; }
            public bool IsSet(FutSettDate val) { return IsSetFutSettDate(); }
            public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

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

            public FutSettDate2 FutSettDate2
            {
                get
                {
                    FutSettDate2 val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(FutSettDate2 val) { FutSettDate2 = val; }
            public FutSettDate2 Get(FutSettDate2 val) { GetField(val); return val; }
            public bool IsSet(FutSettDate2 val) { return IsSetFutSettDate2(); }
            public bool IsSetFutSettDate2() { return IsSetField(Tags.FutSettDate2); }

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
        }
    }
}
