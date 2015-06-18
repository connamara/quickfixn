using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class QuoteRequest : Message
    {
        public const string MsgType = "R";

        public QuoteRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public QuoteRequest(QuickFix.Fields.QuoteReqID aQuoteReqID,
				QuickFix.Fields.Symbol aSymbol)
               : this()
        {
            this.QuoteReqID = aQuoteReqID;
			this.Symbol = aSymbol;
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

        public QuickFix.Fields.PrevClosePx PrevClosePx
        {
            get
            {
                var val = new QuickFix.Fields.PrevClosePx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PrevClosePx val) { this.PrevClosePx = val; }

        public QuickFix.Fields.PrevClosePx Get(QuickFix.Fields.PrevClosePx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PrevClosePx val) { return IsSetPrevClosePx(); }

        public bool IsSetPrevClosePx() { return IsSetField(Tags.PrevClosePx); }

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

        public QuickFix.Fields.OrderQty OrderQty
        {
            get
            {
                var val = new QuickFix.Fields.OrderQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderQty val) { this.OrderQty = val; }

        public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderQty val) { return IsSetOrderQty(); }

        public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }


    }
}
