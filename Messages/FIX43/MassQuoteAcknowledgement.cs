// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class MassQuoteAcknowledgement : Message
{
    public const string MsgType = "b";

    public MassQuoteAcknowledgement() : base()
    {
        Header.SetField(new MsgType("b"));
    }

    public MassQuoteAcknowledgement(
            QuoteStatus aQuoteStatus
        ) : this()
    {
        QuoteStatus = aQuoteStatus;
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

    public QuoteStatus QuoteStatus
    {
        get
        {
            QuoteStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteStatus val) { QuoteStatus = val; }
    public QuoteStatus Get(QuoteStatus val) { GetField(val); return val; }
    public bool IsSet(QuoteStatus val) { return IsSetQuoteStatus(); }
    public bool IsSetQuoteStatus() { return IsSetField(Tags.QuoteStatus); }

    public QuoteRejectReason QuoteRejectReason
    {
        get
        {
            QuoteRejectReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteRejectReason val) { QuoteRejectReason = val; }
    public QuoteRejectReason Get(QuoteRejectReason val) { GetField(val); return val; }
    public bool IsSet(QuoteRejectReason val) { return IsSetQuoteRejectReason(); }
    public bool IsSetQuoteRejectReason() { return IsSetField(Tags.QuoteRejectReason); }

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

    public QuoteType QuoteType
    {
        get
        {
            QuoteType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteType val) { QuoteType = val; }
    public QuoteType Get(QuoteType val) { GetField(val); return val; }
    public bool IsSet(QuoteType val) { return IsSetQuoteType(); }
    public bool IsSetQuoteType() { return IsSetField(Tags.QuoteType); }

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

    public class NoQuoteSetsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingPutOrCall, Tags.UnderlyingStrikePrice, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.TotQuoteEntries, Tags.NoQuoteEntries, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingPutOrCall, Tags.UnderlyingStrikePrice, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.TotQuoteEntries, Tags.NoQuoteEntries, 0};

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

        public class NoQuoteEntriesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.MidPx, Tags.BidYield, Tags.MidYield, Tags.OfferYield, Tags.TransactTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.BidForwardPoints2, Tags.OfferForwardPoints2, Tags.Currency, Tags.QuoteEntryRejectReason, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.MidPx, Tags.BidYield, Tags.MidYield, Tags.OfferYield, Tags.TransactTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.BidForwardPoints2, Tags.OfferForwardPoints2, Tags.Currency, Tags.QuoteEntryRejectReason, 0};

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

            public MidPx MidPx
            {
                get
                {
                    MidPx val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MidPx val) { MidPx = val; }
            public MidPx Get(MidPx val) { GetField(val); return val; }
            public bool IsSet(MidPx val) { return IsSetMidPx(); }
            public bool IsSetMidPx() { return IsSetField(Tags.MidPx); }

            public BidYield BidYield
            {
                get
                {
                    BidYield val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(BidYield val) { BidYield = val; }
            public BidYield Get(BidYield val) { GetField(val); return val; }
            public bool IsSet(BidYield val) { return IsSetBidYield(); }
            public bool IsSetBidYield() { return IsSetField(Tags.BidYield); }

            public MidYield MidYield
            {
                get
                {
                    MidYield val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MidYield val) { MidYield = val; }
            public MidYield Get(MidYield val) { GetField(val); return val; }
            public bool IsSet(MidYield val) { return IsSetMidYield(); }
            public bool IsSetMidYield() { return IsSetField(Tags.MidYield); }

            public OfferYield OfferYield
            {
                get
                {
                    OfferYield val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(OfferYield val) { OfferYield = val; }
            public OfferYield Get(OfferYield val) { GetField(val); return val; }
            public bool IsSet(OfferYield val) { return IsSetOfferYield(); }
            public bool IsSetOfferYield() { return IsSetField(Tags.OfferYield); }

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

            public BidForwardPoints2 BidForwardPoints2
            {
                get
                {
                    BidForwardPoints2 val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(BidForwardPoints2 val) { BidForwardPoints2 = val; }
            public BidForwardPoints2 Get(BidForwardPoints2 val) { GetField(val); return val; }
            public bool IsSet(BidForwardPoints2 val) { return IsSetBidForwardPoints2(); }
            public bool IsSetBidForwardPoints2() { return IsSetField(Tags.BidForwardPoints2); }

            public OfferForwardPoints2 OfferForwardPoints2
            {
                get
                {
                    OfferForwardPoints2 val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(OfferForwardPoints2 val) { OfferForwardPoints2 = val; }
            public OfferForwardPoints2 Get(OfferForwardPoints2 val) { GetField(val); return val; }
            public bool IsSet(OfferForwardPoints2 val) { return IsSetOfferForwardPoints2(); }
            public bool IsSetOfferForwardPoints2() { return IsSetField(Tags.OfferForwardPoints2); }

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

            public QuoteEntryRejectReason QuoteEntryRejectReason
            {
                get
                {
                    QuoteEntryRejectReason val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(QuoteEntryRejectReason val) { QuoteEntryRejectReason = val; }
            public QuoteEntryRejectReason Get(QuoteEntryRejectReason val) { GetField(val); return val; }
            public bool IsSet(QuoteEntryRejectReason val) { return IsSetQuoteEntryRejectReason(); }
            public bool IsSetQuoteEntryRejectReason() { return IsSetField(Tags.QuoteEntryRejectReason); }

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
}
