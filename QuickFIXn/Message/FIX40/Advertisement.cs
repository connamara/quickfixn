using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class Advertisement : Message
    {
        public const string MsgType = "7";

        public Advertisement():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public Advertisement(QuickFix.Fields.AdvId aAdvId,
				QuickFix.Fields.AdvTransType aAdvTransType,
				QuickFix.Fields.Symbol aSymbol,
				QuickFix.Fields.AdvSide aAdvSide,
				QuickFix.Fields.Shares aShares)
               : this()
        {
            this.AdvId = aAdvId;
			this.AdvTransType = aAdvTransType;
			this.Symbol = aSymbol;
			this.AdvSide = aAdvSide;
			this.Shares = aShares;
        }

        public QuickFix.Fields.AdvId AdvId
        {
            get
            {
                var val = new QuickFix.Fields.AdvId();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AdvId val) { this.AdvId = val; }

        public QuickFix.Fields.AdvId Get(QuickFix.Fields.AdvId val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AdvId val) { return IsSetAdvId(); }

        public bool IsSetAdvId() { return IsSetField(Tags.AdvId); }

        public QuickFix.Fields.AdvTransType AdvTransType
        {
            get
            {
                var val = new QuickFix.Fields.AdvTransType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AdvTransType val) { this.AdvTransType = val; }

        public QuickFix.Fields.AdvTransType Get(QuickFix.Fields.AdvTransType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AdvTransType val) { return IsSetAdvTransType(); }

        public bool IsSetAdvTransType() { return IsSetField(Tags.AdvTransType); }

        public QuickFix.Fields.AdvRefID AdvRefID
        {
            get
            {
                var val = new QuickFix.Fields.AdvRefID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AdvRefID val) { this.AdvRefID = val; }

        public QuickFix.Fields.AdvRefID Get(QuickFix.Fields.AdvRefID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AdvRefID val) { return IsSetAdvRefID(); }

        public bool IsSetAdvRefID() { return IsSetField(Tags.AdvRefID); }

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

        public QuickFix.Fields.AdvSide AdvSide
        {
            get
            {
                var val = new QuickFix.Fields.AdvSide();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AdvSide val) { this.AdvSide = val; }

        public QuickFix.Fields.AdvSide Get(QuickFix.Fields.AdvSide val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AdvSide val) { return IsSetAdvSide(); }

        public bool IsSetAdvSide() { return IsSetField(Tags.AdvSide); }

        public QuickFix.Fields.Shares Shares
        {
            get
            {
                var val = new QuickFix.Fields.Shares();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Shares val) { this.Shares = val; }

        public QuickFix.Fields.Shares Get(QuickFix.Fields.Shares val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Shares val) { return IsSetShares(); }

        public bool IsSetShares() { return IsSetField(Tags.Shares); }

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


    }
}
