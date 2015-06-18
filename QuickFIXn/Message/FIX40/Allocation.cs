using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class Allocation : Message
    {
        public const string MsgType = "J";

        public Allocation():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public Allocation(QuickFix.Fields.AllocID aAllocID,
				QuickFix.Fields.AllocTransType aAllocTransType,
				QuickFix.Fields.Side aSide,
				QuickFix.Fields.Symbol aSymbol,
				QuickFix.Fields.Shares aShares,
				QuickFix.Fields.AvgPx aAvgPx,
				QuickFix.Fields.TradeDate aTradeDate)
               : this()
        {
            this.AllocID = aAllocID;
			this.AllocTransType = aAllocTransType;
			this.Side = aSide;
			this.Symbol = aSymbol;
			this.Shares = aShares;
			this.AvgPx = aAvgPx;
			this.TradeDate = aTradeDate;
        }

        public QuickFix.Fields.AllocID AllocID
        {
            get
            {
                var val = new QuickFix.Fields.AllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocID val) { this.AllocID = val; }

        public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocID val) { return IsSetAllocID(); }

        public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

        public QuickFix.Fields.AllocTransType AllocTransType
        {
            get
            {
                var val = new QuickFix.Fields.AllocTransType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocTransType val) { this.AllocTransType = val; }

        public QuickFix.Fields.AllocTransType Get(QuickFix.Fields.AllocTransType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocTransType val) { return IsSetAllocTransType(); }

        public bool IsSetAllocTransType() { return IsSetField(Tags.AllocTransType); }

        public QuickFix.Fields.RefAllocID RefAllocID
        {
            get
            {
                var val = new QuickFix.Fields.RefAllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefAllocID val) { this.RefAllocID = val; }

        public QuickFix.Fields.RefAllocID Get(QuickFix.Fields.RefAllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefAllocID val) { return IsSetRefAllocID(); }

        public bool IsSetRefAllocID() { return IsSetField(Tags.RefAllocID); }

        public QuickFix.Fields.NoOrders NoOrders
        {
            get
            {
                var val = new QuickFix.Fields.NoOrders();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoOrders val) { this.NoOrders = val; }

        public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoOrders val) { return IsSetNoOrders(); }

        public bool IsSetNoOrders() { return IsSetField(Tags.NoOrders); }

        public QuickFix.Fields.NoExecs NoExecs
        {
            get
            {
                var val = new QuickFix.Fields.NoExecs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoExecs val) { this.NoExecs = val; }

        public QuickFix.Fields.NoExecs Get(QuickFix.Fields.NoExecs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoExecs val) { return IsSetNoExecs(); }

        public bool IsSetNoExecs() { return IsSetField(Tags.NoExecs); }

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

        public QuickFix.Fields.AvgPx AvgPx
        {
            get
            {
                var val = new QuickFix.Fields.AvgPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AvgPx val) { this.AvgPx = val; }

        public QuickFix.Fields.AvgPx Get(QuickFix.Fields.AvgPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AvgPx val) { return IsSetAvgPx(); }

        public bool IsSetAvgPx() { return IsSetField(Tags.AvgPx); }

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

        public QuickFix.Fields.AvgPrxPrecision AvgPrxPrecision
        {
            get
            {
                var val = new QuickFix.Fields.AvgPrxPrecision();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AvgPrxPrecision val) { this.AvgPrxPrecision = val; }

        public QuickFix.Fields.AvgPrxPrecision Get(QuickFix.Fields.AvgPrxPrecision val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AvgPrxPrecision val) { return IsSetAvgPrxPrecision(); }

        public bool IsSetAvgPrxPrecision() { return IsSetField(Tags.AvgPrxPrecision); }

        public QuickFix.Fields.TradeDate TradeDate
        {
            get
            {
                var val = new QuickFix.Fields.TradeDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeDate val) { this.TradeDate = val; }

        public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeDate val) { return IsSetTradeDate(); }

        public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

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

        public QuickFix.Fields.SettlmntTyp SettlmntTyp
        {
            get
            {
                var val = new QuickFix.Fields.SettlmntTyp();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlmntTyp val) { this.SettlmntTyp = val; }

        public QuickFix.Fields.SettlmntTyp Get(QuickFix.Fields.SettlmntTyp val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlmntTyp val) { return IsSetSettlmntTyp(); }

        public bool IsSetSettlmntTyp() { return IsSetField(Tags.SettlmntTyp); }

        public QuickFix.Fields.FutSettDate FutSettDate
        {
            get
            {
                var val = new QuickFix.Fields.FutSettDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FutSettDate val) { this.FutSettDate = val; }

        public QuickFix.Fields.FutSettDate Get(QuickFix.Fields.FutSettDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FutSettDate val) { return IsSetFutSettDate(); }

        public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

        public QuickFix.Fields.NetMoney NetMoney
        {
            get
            {
                var val = new QuickFix.Fields.NetMoney();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NetMoney val) { this.NetMoney = val; }

        public QuickFix.Fields.NetMoney Get(QuickFix.Fields.NetMoney val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NetMoney val) { return IsSetNetMoney(); }

        public bool IsSetNetMoney() { return IsSetField(Tags.NetMoney); }

        public QuickFix.Fields.NoMiscFees NoMiscFees
        {
            get
            {
                var val = new QuickFix.Fields.NoMiscFees();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoMiscFees val) { this.NoMiscFees = val; }

        public QuickFix.Fields.NoMiscFees Get(QuickFix.Fields.NoMiscFees val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoMiscFees val) { return IsSetNoMiscFees(); }

        public bool IsSetNoMiscFees() { return IsSetField(Tags.NoMiscFees); }

        public QuickFix.Fields.SettlCurrAmt SettlCurrAmt
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrAmt val) { this.SettlCurrAmt = val; }

        public QuickFix.Fields.SettlCurrAmt Get(QuickFix.Fields.SettlCurrAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrAmt val) { return IsSetSettlCurrAmt(); }

        public bool IsSetSettlCurrAmt() { return IsSetField(Tags.SettlCurrAmt); }

        public QuickFix.Fields.SettlCurrency SettlCurrency
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrency val) { this.SettlCurrency = val; }

        public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrency val) { return IsSetSettlCurrency(); }

        public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }

        public QuickFix.Fields.OpenClose OpenClose
        {
            get
            {
                var val = new QuickFix.Fields.OpenClose();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OpenClose val) { this.OpenClose = val; }

        public QuickFix.Fields.OpenClose Get(QuickFix.Fields.OpenClose val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OpenClose val) { return IsSetOpenClose(); }

        public bool IsSetOpenClose() { return IsSetField(Tags.OpenClose); }

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

        public QuickFix.Fields.NoAllocs NoAllocs
        {
            get
            {
                var val = new QuickFix.Fields.NoAllocs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoAllocs val) { this.NoAllocs = val; }

        public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoAllocs val) { return IsSetNoAllocs(); }

        public bool IsSetNoAllocs() { return IsSetField(Tags.NoAllocs); }


        public class NoOrdersGroup : Group
        {
            public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.ListID, Tags.WaveNo, 0};

            public NoOrdersGroup() : base(Tags.NoOrders, Tags.ClOrdID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoOrdersGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ClOrdID ClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.ClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClOrdID val) { this.ClOrdID = val; }

        public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClOrdID val) { return IsSetClOrdID(); }

        public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

        public QuickFix.Fields.OrderID OrderID
        {
            get
            {
                var val = new QuickFix.Fields.OrderID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderID val) { this.OrderID = val; }

        public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderID val) { return IsSetOrderID(); }

        public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

        public QuickFix.Fields.ListID ListID
        {
            get
            {
                var val = new QuickFix.Fields.ListID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ListID val) { this.ListID = val; }

        public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ListID val) { return IsSetListID(); }

        public bool IsSetListID() { return IsSetField(Tags.ListID); }

        public QuickFix.Fields.WaveNo WaveNo
        {
            get
            {
                var val = new QuickFix.Fields.WaveNo();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.WaveNo val) { this.WaveNo = val; }

        public QuickFix.Fields.WaveNo Get(QuickFix.Fields.WaveNo val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.WaveNo val) { return IsSetWaveNo(); }

        public bool IsSetWaveNo() { return IsSetField(Tags.WaveNo); }


        }


        public class NoExecsGroup : Group
        {
            public static int[] fieldOrder = {Tags.ExecID, Tags.LastShares, Tags.LastPx, Tags.LastMkt, 0};

            public NoExecsGroup() : base(Tags.NoExecs, Tags.ExecID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoExecsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ExecID ExecID
        {
            get
            {
                var val = new QuickFix.Fields.ExecID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExecID val) { this.ExecID = val; }

        public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExecID val) { return IsSetExecID(); }

        public bool IsSetExecID() { return IsSetField(Tags.ExecID); }

        public QuickFix.Fields.LastShares LastShares
        {
            get
            {
                var val = new QuickFix.Fields.LastShares();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastShares val) { this.LastShares = val; }

        public QuickFix.Fields.LastShares Get(QuickFix.Fields.LastShares val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastShares val) { return IsSetLastShares(); }

        public bool IsSetLastShares() { return IsSetField(Tags.LastShares); }

        public QuickFix.Fields.LastPx LastPx
        {
            get
            {
                var val = new QuickFix.Fields.LastPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastPx val) { this.LastPx = val; }

        public QuickFix.Fields.LastPx Get(QuickFix.Fields.LastPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastPx val) { return IsSetLastPx(); }

        public bool IsSetLastPx() { return IsSetField(Tags.LastPx); }

        public QuickFix.Fields.LastMkt LastMkt
        {
            get
            {
                var val = new QuickFix.Fields.LastMkt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastMkt val) { this.LastMkt = val; }

        public QuickFix.Fields.LastMkt Get(QuickFix.Fields.LastMkt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastMkt val) { return IsSetLastMkt(); }

        public bool IsSetLastMkt() { return IsSetField(Tags.LastMkt); }


        }


        public class NoMiscFeesGroup : Group
        {
            public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, 0};

            public NoMiscFeesGroup() : base(Tags.NoMiscFees, Tags.MiscFeeAmt, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoMiscFeesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.MiscFeeAmt MiscFeeAmt
        {
            get
            {
                var val = new QuickFix.Fields.MiscFeeAmt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MiscFeeAmt val) { this.MiscFeeAmt = val; }

        public QuickFix.Fields.MiscFeeAmt Get(QuickFix.Fields.MiscFeeAmt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MiscFeeAmt val) { return IsSetMiscFeeAmt(); }

        public bool IsSetMiscFeeAmt() { return IsSetField(Tags.MiscFeeAmt); }

        public QuickFix.Fields.MiscFeeCurr MiscFeeCurr
        {
            get
            {
                var val = new QuickFix.Fields.MiscFeeCurr();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MiscFeeCurr val) { this.MiscFeeCurr = val; }

        public QuickFix.Fields.MiscFeeCurr Get(QuickFix.Fields.MiscFeeCurr val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MiscFeeCurr val) { return IsSetMiscFeeCurr(); }

        public bool IsSetMiscFeeCurr() { return IsSetField(Tags.MiscFeeCurr); }

        public QuickFix.Fields.MiscFeeType MiscFeeType
        {
            get
            {
                var val = new QuickFix.Fields.MiscFeeType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MiscFeeType val) { this.MiscFeeType = val; }

        public QuickFix.Fields.MiscFeeType Get(QuickFix.Fields.MiscFeeType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MiscFeeType val) { return IsSetMiscFeeType(); }

        public bool IsSetMiscFeeType() { return IsSetField(Tags.MiscFeeType); }


        }


        public class NoAllocsGroup : Group
        {
            public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocShares, Tags.ProcessCode, Tags.ExecBroker, Tags.ClientID, Tags.Commission, Tags.CommType, Tags.NoDlvyInst, 0};

            public NoAllocsGroup() : base(Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoAllocsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.AllocAccount AllocAccount
        {
            get
            {
                var val = new QuickFix.Fields.AllocAccount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocAccount val) { this.AllocAccount = val; }

        public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocAccount val) { return IsSetAllocAccount(); }

        public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }

        public QuickFix.Fields.AllocShares AllocShares
        {
            get
            {
                var val = new QuickFix.Fields.AllocShares();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocShares val) { this.AllocShares = val; }

        public QuickFix.Fields.AllocShares Get(QuickFix.Fields.AllocShares val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocShares val) { return IsSetAllocShares(); }

        public bool IsSetAllocShares() { return IsSetField(Tags.AllocShares); }

        public QuickFix.Fields.ProcessCode ProcessCode
        {
            get
            {
                var val = new QuickFix.Fields.ProcessCode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ProcessCode val) { this.ProcessCode = val; }

        public QuickFix.Fields.ProcessCode Get(QuickFix.Fields.ProcessCode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ProcessCode val) { return IsSetProcessCode(); }

        public bool IsSetProcessCode() { return IsSetField(Tags.ProcessCode); }

        public QuickFix.Fields.ExecBroker ExecBroker
        {
            get
            {
                var val = new QuickFix.Fields.ExecBroker();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExecBroker val) { this.ExecBroker = val; }

        public QuickFix.Fields.ExecBroker Get(QuickFix.Fields.ExecBroker val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExecBroker val) { return IsSetExecBroker(); }

        public bool IsSetExecBroker() { return IsSetField(Tags.ExecBroker); }

        public QuickFix.Fields.ClientID ClientID
        {
            get
            {
                var val = new QuickFix.Fields.ClientID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClientID val) { this.ClientID = val; }

        public QuickFix.Fields.ClientID Get(QuickFix.Fields.ClientID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClientID val) { return IsSetClientID(); }

        public bool IsSetClientID() { return IsSetField(Tags.ClientID); }

        public QuickFix.Fields.Commission Commission
        {
            get
            {
                var val = new QuickFix.Fields.Commission();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Commission val) { this.Commission = val; }

        public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Commission val) { return IsSetCommission(); }

        public bool IsSetCommission() { return IsSetField(Tags.Commission); }

        public QuickFix.Fields.CommType CommType
        {
            get
            {
                var val = new QuickFix.Fields.CommType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CommType val) { this.CommType = val; }

        public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CommType val) { return IsSetCommType(); }

        public bool IsSetCommType() { return IsSetField(Tags.CommType); }

        public QuickFix.Fields.NoDlvyInst NoDlvyInst
        {
            get
            {
                var val = new QuickFix.Fields.NoDlvyInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoDlvyInst val) { this.NoDlvyInst = val; }

        public QuickFix.Fields.NoDlvyInst Get(QuickFix.Fields.NoDlvyInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoDlvyInst val) { return IsSetNoDlvyInst(); }

        public bool IsSetNoDlvyInst() { return IsSetField(Tags.NoDlvyInst); }


        public class NoDlvyInstGroup : Group
        {
            public static int[] fieldOrder = {Tags.BrokerOfCredit, Tags.DlvyInst, 0};

            public NoDlvyInstGroup() : base(Tags.NoDlvyInst, Tags.BrokerOfCredit, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDlvyInstGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.BrokerOfCredit BrokerOfCredit
        {
            get
            {
                var val = new QuickFix.Fields.BrokerOfCredit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BrokerOfCredit val) { this.BrokerOfCredit = val; }

        public QuickFix.Fields.BrokerOfCredit Get(QuickFix.Fields.BrokerOfCredit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BrokerOfCredit val) { return IsSetBrokerOfCredit(); }

        public bool IsSetBrokerOfCredit() { return IsSetField(Tags.BrokerOfCredit); }

        public QuickFix.Fields.DlvyInst DlvyInst
        {
            get
            {
                var val = new QuickFix.Fields.DlvyInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DlvyInst val) { this.DlvyInst = val; }

        public QuickFix.Fields.DlvyInst Get(QuickFix.Fields.DlvyInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DlvyInst val) { return IsSetDlvyInst(); }

        public bool IsSetDlvyInst() { return IsSetField(Tags.DlvyInst); }


        }
        }


    }
}
