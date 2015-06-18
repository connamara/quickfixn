using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class MassQuoteAcknowledgement : Message
    {
        public const string MsgType = "b";

        public MassQuoteAcknowledgement():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public MassQuoteAcknowledgement(QuickFix.Fields.QuoteStatus aQuoteStatus)
               : this()
        {
            this.QuoteStatus = aQuoteStatus;
        }

        public QuickFix.Fields.QuoteReqID QuoteReqID
        {
            get
            {
                var val = new QuickFix.Fields.QuoteReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteReqID val) { this.QuoteReqID = val; }

        public QuickFix.Fields.QuoteReqID Get(QuickFix.Fields.QuoteReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteReqID val) { return IsSetQuoteReqID(); }

        public bool IsSetQuoteReqID() { return IsSetField(Tags.QuoteReqID); }

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

        public QuickFix.Fields.QuoteStatus QuoteStatus
        {
            get
            {
                var val = new QuickFix.Fields.QuoteStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteStatus val) { this.QuoteStatus = val; }

        public QuickFix.Fields.QuoteStatus Get(QuickFix.Fields.QuoteStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteStatus val) { return IsSetQuoteStatus(); }

        public bool IsSetQuoteStatus() { return IsSetField(Tags.QuoteStatus); }

        public QuickFix.Fields.QuoteRejectReason QuoteRejectReason
        {
            get
            {
                var val = new QuickFix.Fields.QuoteRejectReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteRejectReason val) { this.QuoteRejectReason = val; }

        public QuickFix.Fields.QuoteRejectReason Get(QuickFix.Fields.QuoteRejectReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteRejectReason val) { return IsSetQuoteRejectReason(); }

        public bool IsSetQuoteRejectReason() { return IsSetField(Tags.QuoteRejectReason); }

        public QuickFix.Fields.QuoteResponseLevel QuoteResponseLevel
        {
            get
            {
                var val = new QuickFix.Fields.QuoteResponseLevel();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteResponseLevel val) { this.QuoteResponseLevel = val; }

        public QuickFix.Fields.QuoteResponseLevel Get(QuickFix.Fields.QuoteResponseLevel val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteResponseLevel val) { return IsSetQuoteResponseLevel(); }

        public bool IsSetQuoteResponseLevel() { return IsSetField(Tags.QuoteResponseLevel); }

        public QuickFix.Fields.QuoteType QuoteType
        {
            get
            {
                var val = new QuickFix.Fields.QuoteType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteType val) { this.QuoteType = val; }

        public QuickFix.Fields.QuoteType Get(QuickFix.Fields.QuoteType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteType val) { return IsSetQuoteType(); }

        public bool IsSetQuoteType() { return IsSetField(Tags.QuoteType); }

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

        public QuickFix.Fields.NoQuoteSets NoQuoteSets
        {
            get
            {
                var val = new QuickFix.Fields.NoQuoteSets();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoQuoteSets val) { this.NoQuoteSets = val; }

        public QuickFix.Fields.NoQuoteSets Get(QuickFix.Fields.NoQuoteSets val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoQuoteSets val) { return IsSetNoQuoteSets(); }

        public bool IsSetNoQuoteSets() { return IsSetField(Tags.NoQuoteSets); }

        public QuickFix.Fields.QuoteCancelType QuoteCancelType
        {
            get
            {
                var val = new QuickFix.Fields.QuoteCancelType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteCancelType val) { this.QuoteCancelType = val; }

        public QuickFix.Fields.QuoteCancelType Get(QuickFix.Fields.QuoteCancelType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteCancelType val) { return IsSetQuoteCancelType(); }

        public bool IsSetQuoteCancelType() { return IsSetField(Tags.QuoteCancelType); }


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


        public class NoQuoteSetsGroup : Group
        {
            public static int[] fieldOrder = {Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.TotNoQuoteEntries, Tags.LastFragment, Tags.NoQuoteEntries, Tags.TotNoCxldQuotes, Tags.TotNoAccQuotes, Tags.TotNoRejQuotes, 0};

            public NoQuoteSetsGroup() : base(Tags.NoQuoteSets, Tags.QuoteSetID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoQuoteSetsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.QuoteSetID QuoteSetID
        {
            get
            {
                var val = new QuickFix.Fields.QuoteSetID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteSetID val) { this.QuoteSetID = val; }

        public QuickFix.Fields.QuoteSetID Get(QuickFix.Fields.QuoteSetID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteSetID val) { return IsSetQuoteSetID(); }

        public bool IsSetQuoteSetID() { return IsSetField(Tags.QuoteSetID); }

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

        public QuickFix.Fields.TotNoQuoteEntries TotNoQuoteEntries
        {
            get
            {
                var val = new QuickFix.Fields.TotNoQuoteEntries();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotNoQuoteEntries val) { this.TotNoQuoteEntries = val; }

        public QuickFix.Fields.TotNoQuoteEntries Get(QuickFix.Fields.TotNoQuoteEntries val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotNoQuoteEntries val) { return IsSetTotNoQuoteEntries(); }

        public bool IsSetTotNoQuoteEntries() { return IsSetField(Tags.TotNoQuoteEntries); }

        public QuickFix.Fields.LastFragment LastFragment
        {
            get
            {
                var val = new QuickFix.Fields.LastFragment();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastFragment val) { this.LastFragment = val; }

        public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastFragment val) { return IsSetLastFragment(); }

        public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }

        public QuickFix.Fields.NoQuoteEntries NoQuoteEntries
        {
            get
            {
                var val = new QuickFix.Fields.NoQuoteEntries();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoQuoteEntries val) { this.NoQuoteEntries = val; }

        public QuickFix.Fields.NoQuoteEntries Get(QuickFix.Fields.NoQuoteEntries val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoQuoteEntries val) { return IsSetNoQuoteEntries(); }

        public bool IsSetNoQuoteEntries() { return IsSetField(Tags.NoQuoteEntries); }

        public QuickFix.Fields.TotNoCxldQuotes TotNoCxldQuotes
        {
            get
            {
                var val = new QuickFix.Fields.TotNoCxldQuotes();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotNoCxldQuotes val) { this.TotNoCxldQuotes = val; }

        public QuickFix.Fields.TotNoCxldQuotes Get(QuickFix.Fields.TotNoCxldQuotes val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotNoCxldQuotes val) { return IsSetTotNoCxldQuotes(); }

        public bool IsSetTotNoCxldQuotes() { return IsSetField(Tags.TotNoCxldQuotes); }

        public QuickFix.Fields.TotNoAccQuotes TotNoAccQuotes
        {
            get
            {
                var val = new QuickFix.Fields.TotNoAccQuotes();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotNoAccQuotes val) { this.TotNoAccQuotes = val; }

        public QuickFix.Fields.TotNoAccQuotes Get(QuickFix.Fields.TotNoAccQuotes val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotNoAccQuotes val) { return IsSetTotNoAccQuotes(); }

        public bool IsSetTotNoAccQuotes() { return IsSetField(Tags.TotNoAccQuotes); }

        public QuickFix.Fields.TotNoRejQuotes TotNoRejQuotes
        {
            get
            {
                var val = new QuickFix.Fields.TotNoRejQuotes();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotNoRejQuotes val) { this.TotNoRejQuotes = val; }

        public QuickFix.Fields.TotNoRejQuotes Get(QuickFix.Fields.TotNoRejQuotes val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotNoRejQuotes val) { return IsSetTotNoRejQuotes(); }

        public bool IsSetTotNoRejQuotes() { return IsSetField(Tags.TotNoRejQuotes); }


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
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

            public NoUndlyInstrumentPartiesGroup() : base(Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UndlyInstrumentPartyID UndlyInstrumentPartyID
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyID val) { this.UndlyInstrumentPartyID = val; }

        public QuickFix.Fields.UndlyInstrumentPartyID Get(QuickFix.Fields.UndlyInstrumentPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyID val) { return IsSetUndlyInstrumentPartyID(); }

        public bool IsSetUndlyInstrumentPartyID() { return IsSetField(Tags.UndlyInstrumentPartyID); }

        public QuickFix.Fields.UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyIDSource val) { this.UndlyInstrumentPartyIDSource = val; }

        public QuickFix.Fields.UndlyInstrumentPartyIDSource Get(QuickFix.Fields.UndlyInstrumentPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val) { return IsSetUndlyInstrumentPartyIDSource(); }

        public bool IsSetUndlyInstrumentPartyIDSource() { return IsSetField(Tags.UndlyInstrumentPartyIDSource); }

        public QuickFix.Fields.UndlyInstrumentPartyRole UndlyInstrumentPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyRole val) { this.UndlyInstrumentPartyRole = val; }

        public QuickFix.Fields.UndlyInstrumentPartyRole Get(QuickFix.Fields.UndlyInstrumentPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyRole val) { return IsSetUndlyInstrumentPartyRole(); }

        public bool IsSetUndlyInstrumentPartyRole() { return IsSetField(Tags.UndlyInstrumentPartyRole); }

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
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};

            public NoUndlyInstrumentPartySubIDsGroup() : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UndlyInstrumentPartySubID UndlyInstrumentPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartySubID val) { this.UndlyInstrumentPartySubID = val; }

        public QuickFix.Fields.UndlyInstrumentPartySubID Get(QuickFix.Fields.UndlyInstrumentPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubID val) { return IsSetUndlyInstrumentPartySubID(); }

        public bool IsSetUndlyInstrumentPartySubID() { return IsSetField(Tags.UndlyInstrumentPartySubID); }

        public QuickFix.Fields.UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartySubIDType val) { this.UndlyInstrumentPartySubIDType = val; }

        public QuickFix.Fields.UndlyInstrumentPartySubIDType Get(QuickFix.Fields.UndlyInstrumentPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val) { return IsSetUndlyInstrumentPartySubIDType(); }

        public bool IsSetUndlyInstrumentPartySubIDType() { return IsSetField(Tags.UndlyInstrumentPartySubIDType); }


        }
        }
        public class NoQuoteEntriesGroup : Group
        {
            public static int[] fieldOrder = {Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.NoLegs, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.MidPx, Tags.BidYield, Tags.MidYield, Tags.OfferYield, Tags.TransactTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SettlDate, Tags.OrdType, Tags.SettlDate2, Tags.OrderQty2, Tags.BidForwardPoints2, Tags.OfferForwardPoints2, Tags.Currency, Tags.QuoteEntryRejectReason, Tags.QuoteEntryStatus, 0};

            public NoQuoteEntriesGroup() : base(Tags.NoQuoteEntries, Tags.QuoteEntryID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoQuoteEntriesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.QuoteEntryID QuoteEntryID
        {
            get
            {
                var val = new QuickFix.Fields.QuoteEntryID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteEntryID val) { this.QuoteEntryID = val; }

        public QuickFix.Fields.QuoteEntryID Get(QuickFix.Fields.QuoteEntryID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteEntryID val) { return IsSetQuoteEntryID(); }

        public bool IsSetQuoteEntryID() { return IsSetField(Tags.QuoteEntryID); }

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

        public QuickFix.Fields.OptPayAmount OptPayAmount
        {
            get
            {
                var val = new QuickFix.Fields.OptPayAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OptPayAmount val) { this.OptPayAmount = val; }

        public QuickFix.Fields.OptPayAmount Get(QuickFix.Fields.OptPayAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OptPayAmount val) { return IsSetOptPayAmount(); }

        public bool IsSetOptPayAmount() { return IsSetField(Tags.OptPayAmount); }

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

        public QuickFix.Fields.FuturesValuationMethod FuturesValuationMethod
        {
            get
            {
                var val = new QuickFix.Fields.FuturesValuationMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FuturesValuationMethod val) { this.FuturesValuationMethod = val; }

        public QuickFix.Fields.FuturesValuationMethod Get(QuickFix.Fields.FuturesValuationMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FuturesValuationMethod val) { return IsSetFuturesValuationMethod(); }

        public bool IsSetFuturesValuationMethod() { return IsSetField(Tags.FuturesValuationMethod); }

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

        public QuickFix.Fields.BidPx BidPx
        {
            get
            {
                var val = new QuickFix.Fields.BidPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidPx val) { this.BidPx = val; }

        public QuickFix.Fields.BidPx Get(QuickFix.Fields.BidPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidPx val) { return IsSetBidPx(); }

        public bool IsSetBidPx() { return IsSetField(Tags.BidPx); }

        public QuickFix.Fields.OfferPx OfferPx
        {
            get
            {
                var val = new QuickFix.Fields.OfferPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferPx val) { this.OfferPx = val; }

        public QuickFix.Fields.OfferPx Get(QuickFix.Fields.OfferPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferPx val) { return IsSetOfferPx(); }

        public bool IsSetOfferPx() { return IsSetField(Tags.OfferPx); }

        public QuickFix.Fields.BidSize BidSize
        {
            get
            {
                var val = new QuickFix.Fields.BidSize();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidSize val) { this.BidSize = val; }

        public QuickFix.Fields.BidSize Get(QuickFix.Fields.BidSize val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidSize val) { return IsSetBidSize(); }

        public bool IsSetBidSize() { return IsSetField(Tags.BidSize); }

        public QuickFix.Fields.OfferSize OfferSize
        {
            get
            {
                var val = new QuickFix.Fields.OfferSize();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferSize val) { this.OfferSize = val; }

        public QuickFix.Fields.OfferSize Get(QuickFix.Fields.OfferSize val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferSize val) { return IsSetOfferSize(); }

        public bool IsSetOfferSize() { return IsSetField(Tags.OfferSize); }

        public QuickFix.Fields.ValidUntilTime ValidUntilTime
        {
            get
            {
                var val = new QuickFix.Fields.ValidUntilTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ValidUntilTime val) { this.ValidUntilTime = val; }

        public QuickFix.Fields.ValidUntilTime Get(QuickFix.Fields.ValidUntilTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ValidUntilTime val) { return IsSetValidUntilTime(); }

        public bool IsSetValidUntilTime() { return IsSetField(Tags.ValidUntilTime); }

        public QuickFix.Fields.BidSpotRate BidSpotRate
        {
            get
            {
                var val = new QuickFix.Fields.BidSpotRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidSpotRate val) { this.BidSpotRate = val; }

        public QuickFix.Fields.BidSpotRate Get(QuickFix.Fields.BidSpotRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidSpotRate val) { return IsSetBidSpotRate(); }

        public bool IsSetBidSpotRate() { return IsSetField(Tags.BidSpotRate); }

        public QuickFix.Fields.OfferSpotRate OfferSpotRate
        {
            get
            {
                var val = new QuickFix.Fields.OfferSpotRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferSpotRate val) { this.OfferSpotRate = val; }

        public QuickFix.Fields.OfferSpotRate Get(QuickFix.Fields.OfferSpotRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferSpotRate val) { return IsSetOfferSpotRate(); }

        public bool IsSetOfferSpotRate() { return IsSetField(Tags.OfferSpotRate); }

        public QuickFix.Fields.BidForwardPoints BidForwardPoints
        {
            get
            {
                var val = new QuickFix.Fields.BidForwardPoints();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidForwardPoints val) { this.BidForwardPoints = val; }

        public QuickFix.Fields.BidForwardPoints Get(QuickFix.Fields.BidForwardPoints val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidForwardPoints val) { return IsSetBidForwardPoints(); }

        public bool IsSetBidForwardPoints() { return IsSetField(Tags.BidForwardPoints); }

        public QuickFix.Fields.OfferForwardPoints OfferForwardPoints
        {
            get
            {
                var val = new QuickFix.Fields.OfferForwardPoints();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferForwardPoints val) { this.OfferForwardPoints = val; }

        public QuickFix.Fields.OfferForwardPoints Get(QuickFix.Fields.OfferForwardPoints val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferForwardPoints val) { return IsSetOfferForwardPoints(); }

        public bool IsSetOfferForwardPoints() { return IsSetField(Tags.OfferForwardPoints); }

        public QuickFix.Fields.MidPx MidPx
        {
            get
            {
                var val = new QuickFix.Fields.MidPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MidPx val) { this.MidPx = val; }

        public QuickFix.Fields.MidPx Get(QuickFix.Fields.MidPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MidPx val) { return IsSetMidPx(); }

        public bool IsSetMidPx() { return IsSetField(Tags.MidPx); }

        public QuickFix.Fields.BidYield BidYield
        {
            get
            {
                var val = new QuickFix.Fields.BidYield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidYield val) { this.BidYield = val; }

        public QuickFix.Fields.BidYield Get(QuickFix.Fields.BidYield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidYield val) { return IsSetBidYield(); }

        public bool IsSetBidYield() { return IsSetField(Tags.BidYield); }

        public QuickFix.Fields.MidYield MidYield
        {
            get
            {
                var val = new QuickFix.Fields.MidYield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MidYield val) { this.MidYield = val; }

        public QuickFix.Fields.MidYield Get(QuickFix.Fields.MidYield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MidYield val) { return IsSetMidYield(); }

        public bool IsSetMidYield() { return IsSetField(Tags.MidYield); }

        public QuickFix.Fields.OfferYield OfferYield
        {
            get
            {
                var val = new QuickFix.Fields.OfferYield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferYield val) { this.OfferYield = val; }

        public QuickFix.Fields.OfferYield Get(QuickFix.Fields.OfferYield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferYield val) { return IsSetOfferYield(); }

        public bool IsSetOfferYield() { return IsSetField(Tags.OfferYield); }

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

        public QuickFix.Fields.SettlDate2 SettlDate2
        {
            get
            {
                var val = new QuickFix.Fields.SettlDate2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlDate2 val) { this.SettlDate2 = val; }

        public QuickFix.Fields.SettlDate2 Get(QuickFix.Fields.SettlDate2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlDate2 val) { return IsSetSettlDate2(); }

        public bool IsSetSettlDate2() { return IsSetField(Tags.SettlDate2); }

        public QuickFix.Fields.OrderQty2 OrderQty2
        {
            get
            {
                var val = new QuickFix.Fields.OrderQty2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderQty2 val) { this.OrderQty2 = val; }

        public QuickFix.Fields.OrderQty2 Get(QuickFix.Fields.OrderQty2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderQty2 val) { return IsSetOrderQty2(); }

        public bool IsSetOrderQty2() { return IsSetField(Tags.OrderQty2); }

        public QuickFix.Fields.BidForwardPoints2 BidForwardPoints2
        {
            get
            {
                var val = new QuickFix.Fields.BidForwardPoints2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidForwardPoints2 val) { this.BidForwardPoints2 = val; }

        public QuickFix.Fields.BidForwardPoints2 Get(QuickFix.Fields.BidForwardPoints2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidForwardPoints2 val) { return IsSetBidForwardPoints2(); }

        public bool IsSetBidForwardPoints2() { return IsSetField(Tags.BidForwardPoints2); }

        public QuickFix.Fields.OfferForwardPoints2 OfferForwardPoints2
        {
            get
            {
                var val = new QuickFix.Fields.OfferForwardPoints2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferForwardPoints2 val) { this.OfferForwardPoints2 = val; }

        public QuickFix.Fields.OfferForwardPoints2 Get(QuickFix.Fields.OfferForwardPoints2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferForwardPoints2 val) { return IsSetOfferForwardPoints2(); }

        public bool IsSetOfferForwardPoints2() { return IsSetField(Tags.OfferForwardPoints2); }

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

        public QuickFix.Fields.QuoteEntryRejectReason QuoteEntryRejectReason
        {
            get
            {
                var val = new QuickFix.Fields.QuoteEntryRejectReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteEntryRejectReason val) { this.QuoteEntryRejectReason = val; }

        public QuickFix.Fields.QuoteEntryRejectReason Get(QuickFix.Fields.QuoteEntryRejectReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteEntryRejectReason val) { return IsSetQuoteEntryRejectReason(); }

        public bool IsSetQuoteEntryRejectReason() { return IsSetField(Tags.QuoteEntryRejectReason); }

        public QuickFix.Fields.QuoteEntryStatus QuoteEntryStatus
        {
            get
            {
                var val = new QuickFix.Fields.QuoteEntryStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteEntryStatus val) { this.QuoteEntryStatus = val; }

        public QuickFix.Fields.QuoteEntryStatus Get(QuickFix.Fields.QuoteEntryStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteEntryStatus val) { return IsSetQuoteEntryStatus(); }

        public bool IsSetQuoteEntryStatus() { return IsSetField(Tags.QuoteEntryStatus); }


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
        public class NoLegsGroup : Group
        {
            public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, 0};

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
        }
        }
        }


    }
}
