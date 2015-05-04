using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class Quote : Message
    {
        public const string MsgType = "S";

        public Quote():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public Quote(QuickFix.Fields.QuoteID aQuoteID,
				QuickFix.Fields.Symbol aSymbol,
				QuickFix.Fields.BidPx aBidPx)
               : this()
        {
            this.QuoteID = aQuoteID;
			this.Symbol = aSymbol;
			this.BidPx = aBidPx;
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


    }
}
