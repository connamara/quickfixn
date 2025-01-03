// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

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

    public class NoQuoteSetsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingPutOrCall, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.TotNoQuoteEntries, Tags.LastFragment, Tags.NoQuoteEntries, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingPutOrCall, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.TotNoQuoteEntries, Tags.LastFragment, Tags.NoQuoteEntries, 0};

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

        public TotNoQuoteEntries TotNoQuoteEntries
        {
            get
            {
                TotNoQuoteEntries val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TotNoQuoteEntries val) { TotNoQuoteEntries = val; }
        public TotNoQuoteEntries Get(TotNoQuoteEntries val) { GetField(val); return val; }
        public bool IsSet(TotNoQuoteEntries val) { return IsSetTotNoQuoteEntries(); }
        public bool IsSetTotNoQuoteEntries() { return IsSetField(Tags.TotNoQuoteEntries); }

        public LastFragment LastFragment
        {
            get
            {
                LastFragment val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LastFragment val) { LastFragment = val; }
        public LastFragment Get(LastFragment val) { GetField(val); return val; }
        public bool IsSet(LastFragment val) { return IsSetLastFragment(); }
        public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }

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

        public class NoQuoteEntriesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.PutOrCall, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.NoLegs, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.MidPx, Tags.BidYield, Tags.MidYield, Tags.OfferYield, Tags.TransactTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SettlDate, Tags.OrdType, Tags.SettlDate2, Tags.OrderQty2, Tags.BidForwardPoints2, Tags.OfferForwardPoints2, Tags.Currency, Tags.QuoteEntryRejectReason, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.PutOrCall, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.NoLegs, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.MidPx, Tags.BidYield, Tags.MidYield, Tags.OfferYield, Tags.TransactTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SettlDate, Tags.OrdType, Tags.SettlDate2, Tags.OrderQty2, Tags.BidForwardPoints2, Tags.OfferForwardPoints2, Tags.Currency, Tags.QuoteEntryRejectReason, 0};

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

            public class NoLegsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, 0};

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
            }
        }
    }
}
