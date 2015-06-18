using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class IndicationofInterest : Message
    {
        public const string MsgType = "6";

        public IndicationofInterest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public IndicationofInterest(QuickFix.Fields.IOIid aIOIid,
				QuickFix.Fields.IOITransType aIOITransType,
				QuickFix.Fields.Symbol aSymbol,
				QuickFix.Fields.Side aSide,
				QuickFix.Fields.IOIShares aIOIShares)
               : this()
        {
            this.IOIid = aIOIid;
			this.IOITransType = aIOITransType;
			this.Symbol = aSymbol;
			this.Side = aSide;
			this.IOIShares = aIOIShares;
        }

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

        public QuickFix.Fields.IOITransType IOITransType
        {
            get
            {
                var val = new QuickFix.Fields.IOITransType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IOITransType val) { this.IOITransType = val; }

        public QuickFix.Fields.IOITransType Get(QuickFix.Fields.IOITransType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IOITransType val) { return IsSetIOITransType(); }

        public bool IsSetIOITransType() { return IsSetField(Tags.IOITransType); }

        public QuickFix.Fields.IOIRefID IOIRefID
        {
            get
            {
                var val = new QuickFix.Fields.IOIRefID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IOIRefID val) { this.IOIRefID = val; }

        public QuickFix.Fields.IOIRefID Get(QuickFix.Fields.IOIRefID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IOIRefID val) { return IsSetIOIRefID(); }

        public bool IsSetIOIRefID() { return IsSetField(Tags.IOIRefID); }

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

        public QuickFix.Fields.IDSource IDSource
        {
            get
            {
                var val = new QuickFix.Fields.IDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IDSource val) { this.IDSource = val; }

        public QuickFix.Fields.IDSource Get(QuickFix.Fields.IDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IDSource val) { return IsSetIDSource(); }

        public bool IsSetIDSource() { return IsSetField(Tags.IDSource); }

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

        public QuickFix.Fields.MaturityDay MaturityDay
        {
            get
            {
                var val = new QuickFix.Fields.MaturityDay();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaturityDay val) { this.MaturityDay = val; }

        public QuickFix.Fields.MaturityDay Get(QuickFix.Fields.MaturityDay val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaturityDay val) { return IsSetMaturityDay(); }

        public bool IsSetMaturityDay() { return IsSetField(Tags.MaturityDay); }

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

        public QuickFix.Fields.IOIShares IOIShares
        {
            get
            {
                var val = new QuickFix.Fields.IOIShares();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IOIShares val) { this.IOIShares = val; }

        public QuickFix.Fields.IOIShares Get(QuickFix.Fields.IOIShares val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IOIShares val) { return IsSetIOIShares(); }

        public bool IsSetIOIShares() { return IsSetField(Tags.IOIShares); }

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

        public QuickFix.Fields.IOIQltyInd IOIQltyInd
        {
            get
            {
                var val = new QuickFix.Fields.IOIQltyInd();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IOIQltyInd val) { this.IOIQltyInd = val; }

        public QuickFix.Fields.IOIQltyInd Get(QuickFix.Fields.IOIQltyInd val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IOIQltyInd val) { return IsSetIOIQltyInd(); }

        public bool IsSetIOIQltyInd() { return IsSetField(Tags.IOIQltyInd); }

        public QuickFix.Fields.IOINaturalFlag IOINaturalFlag
        {
            get
            {
                var val = new QuickFix.Fields.IOINaturalFlag();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IOINaturalFlag val) { this.IOINaturalFlag = val; }

        public QuickFix.Fields.IOINaturalFlag Get(QuickFix.Fields.IOINaturalFlag val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IOINaturalFlag val) { return IsSetIOINaturalFlag(); }

        public bool IsSetIOINaturalFlag() { return IsSetField(Tags.IOINaturalFlag); }

        public QuickFix.Fields.NoIOIQualifiers NoIOIQualifiers
        {
            get
            {
                var val = new QuickFix.Fields.NoIOIQualifiers();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoIOIQualifiers val) { this.NoIOIQualifiers = val; }

        public QuickFix.Fields.NoIOIQualifiers Get(QuickFix.Fields.NoIOIQualifiers val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoIOIQualifiers val) { return IsSetNoIOIQualifiers(); }

        public bool IsSetNoIOIQualifiers() { return IsSetField(Tags.NoIOIQualifiers); }

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

        public QuickFix.Fields.URLLink URLLink
        {
            get
            {
                var val = new QuickFix.Fields.URLLink();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.URLLink val) { this.URLLink = val; }

        public QuickFix.Fields.URLLink Get(QuickFix.Fields.URLLink val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.URLLink val) { return IsSetURLLink(); }

        public bool IsSetURLLink() { return IsSetField(Tags.URLLink); }

        public QuickFix.Fields.NoRoutingIDs NoRoutingIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRoutingIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRoutingIDs val) { this.NoRoutingIDs = val; }

        public QuickFix.Fields.NoRoutingIDs Get(QuickFix.Fields.NoRoutingIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRoutingIDs val) { return IsSetNoRoutingIDs(); }

        public bool IsSetNoRoutingIDs() { return IsSetField(Tags.NoRoutingIDs); }

        public QuickFix.Fields.SpreadToBenchmark SpreadToBenchmark
        {
            get
            {
                var val = new QuickFix.Fields.SpreadToBenchmark();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SpreadToBenchmark val) { this.SpreadToBenchmark = val; }

        public QuickFix.Fields.SpreadToBenchmark Get(QuickFix.Fields.SpreadToBenchmark val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SpreadToBenchmark val) { return IsSetSpreadToBenchmark(); }

        public bool IsSetSpreadToBenchmark() { return IsSetField(Tags.SpreadToBenchmark); }

        public QuickFix.Fields.Benchmark Benchmark
        {
            get
            {
                var val = new QuickFix.Fields.Benchmark();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Benchmark val) { this.Benchmark = val; }

        public QuickFix.Fields.Benchmark Get(QuickFix.Fields.Benchmark val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Benchmark val) { return IsSetBenchmark(); }

        public bool IsSetBenchmark() { return IsSetField(Tags.Benchmark); }


        public class NoIOIQualifiersGroup : Group
        {
            public static int[] fieldOrder = {Tags.IOIQualifier, 0};

            public NoIOIQualifiersGroup() : base(Tags.NoIOIQualifiers, Tags.IOIQualifier, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoIOIQualifiersGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.IOIQualifier IOIQualifier
        {
            get
            {
                var val = new QuickFix.Fields.IOIQualifier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IOIQualifier val) { this.IOIQualifier = val; }

        public QuickFix.Fields.IOIQualifier Get(QuickFix.Fields.IOIQualifier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IOIQualifier val) { return IsSetIOIQualifier(); }

        public bool IsSetIOIQualifier() { return IsSetField(Tags.IOIQualifier); }


        }


        public class NoRoutingIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RoutingType, Tags.RoutingID, 0};

            public NoRoutingIDsGroup() : base(Tags.NoRoutingIDs, Tags.RoutingType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRoutingIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RoutingType RoutingType
        {
            get
            {
                var val = new QuickFix.Fields.RoutingType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RoutingType val) { this.RoutingType = val; }

        public QuickFix.Fields.RoutingType Get(QuickFix.Fields.RoutingType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RoutingType val) { return IsSetRoutingType(); }

        public bool IsSetRoutingType() { return IsSetField(Tags.RoutingType); }

        public QuickFix.Fields.RoutingID RoutingID
        {
            get
            {
                var val = new QuickFix.Fields.RoutingID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RoutingID val) { this.RoutingID = val; }

        public QuickFix.Fields.RoutingID Get(QuickFix.Fields.RoutingID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RoutingID val) { return IsSetRoutingID(); }

        public bool IsSetRoutingID() { return IsSetField(Tags.RoutingID); }


        }


    }
}
