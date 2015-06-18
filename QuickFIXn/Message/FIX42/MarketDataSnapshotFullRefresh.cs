using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class MarketDataSnapshotFullRefresh : Message
    {
        public const string MsgType = "W";

        public MarketDataSnapshotFullRefresh():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public MarketDataSnapshotFullRefresh(QuickFix.Fields.Symbol aSymbol)
               : this()
        {
            this.Symbol = aSymbol;
        }

        public QuickFix.Fields.MDReqID MDReqID
        {
            get
            {
                var val = new QuickFix.Fields.MDReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDReqID val) { this.MDReqID = val; }

        public QuickFix.Fields.MDReqID Get(QuickFix.Fields.MDReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDReqID val) { return IsSetMDReqID(); }

        public bool IsSetMDReqID() { return IsSetField(Tags.MDReqID); }

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

        public QuickFix.Fields.FinancialStatus FinancialStatus
        {
            get
            {
                var val = new QuickFix.Fields.FinancialStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FinancialStatus val) { this.FinancialStatus = val; }

        public QuickFix.Fields.FinancialStatus Get(QuickFix.Fields.FinancialStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FinancialStatus val) { return IsSetFinancialStatus(); }

        public bool IsSetFinancialStatus() { return IsSetField(Tags.FinancialStatus); }

        public QuickFix.Fields.CorporateAction CorporateAction
        {
            get
            {
                var val = new QuickFix.Fields.CorporateAction();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CorporateAction val) { this.CorporateAction = val; }

        public QuickFix.Fields.CorporateAction Get(QuickFix.Fields.CorporateAction val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CorporateAction val) { return IsSetCorporateAction(); }

        public bool IsSetCorporateAction() { return IsSetField(Tags.CorporateAction); }

        public QuickFix.Fields.TotalVolumeTraded TotalVolumeTraded
        {
            get
            {
                var val = new QuickFix.Fields.TotalVolumeTraded();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotalVolumeTraded val) { this.TotalVolumeTraded = val; }

        public QuickFix.Fields.TotalVolumeTraded Get(QuickFix.Fields.TotalVolumeTraded val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotalVolumeTraded val) { return IsSetTotalVolumeTraded(); }

        public bool IsSetTotalVolumeTraded() { return IsSetField(Tags.TotalVolumeTraded); }

        public QuickFix.Fields.NoMDEntries NoMDEntries
        {
            get
            {
                var val = new QuickFix.Fields.NoMDEntries();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoMDEntries val) { this.NoMDEntries = val; }

        public QuickFix.Fields.NoMDEntries Get(QuickFix.Fields.NoMDEntries val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoMDEntries val) { return IsSetNoMDEntries(); }

        public bool IsSetNoMDEntries() { return IsSetField(Tags.NoMDEntries); }


        public class NoMDEntriesGroup : Group
        {
            public static int[] fieldOrder = {Tags.MDEntryType, Tags.MDEntryPx, Tags.Currency, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.TickDirection, Tags.MDMkt, Tags.TradingSessionID, Tags.QuoteCondition, Tags.TradeCondition, Tags.MDEntryOriginator, Tags.LocationID, Tags.DeskID, Tags.OpenCloseSettleFlag, Tags.TimeInForce, Tags.ExpireDate, Tags.ExpireTime, Tags.MinQty, Tags.ExecInst, Tags.SellerDays, Tags.OrderID, Tags.QuoteEntryID, Tags.MDEntryBuyer, Tags.MDEntrySeller, Tags.NumberOfOrders, Tags.MDEntryPositionNo, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};

            public NoMDEntriesGroup() : base(Tags.NoMDEntries, Tags.MDEntryType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoMDEntriesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.MDEntryType MDEntryType
        {
            get
            {
                var val = new QuickFix.Fields.MDEntryType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntryType val) { this.MDEntryType = val; }

        public QuickFix.Fields.MDEntryType Get(QuickFix.Fields.MDEntryType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntryType val) { return IsSetMDEntryType(); }

        public bool IsSetMDEntryType() { return IsSetField(Tags.MDEntryType); }

        public QuickFix.Fields.MDEntryPx MDEntryPx
        {
            get
            {
                var val = new QuickFix.Fields.MDEntryPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntryPx val) { this.MDEntryPx = val; }

        public QuickFix.Fields.MDEntryPx Get(QuickFix.Fields.MDEntryPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntryPx val) { return IsSetMDEntryPx(); }

        public bool IsSetMDEntryPx() { return IsSetField(Tags.MDEntryPx); }

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

        public QuickFix.Fields.MDEntrySize MDEntrySize
        {
            get
            {
                var val = new QuickFix.Fields.MDEntrySize();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntrySize val) { this.MDEntrySize = val; }

        public QuickFix.Fields.MDEntrySize Get(QuickFix.Fields.MDEntrySize val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntrySize val) { return IsSetMDEntrySize(); }

        public bool IsSetMDEntrySize() { return IsSetField(Tags.MDEntrySize); }

        public QuickFix.Fields.MDEntryDate MDEntryDate
        {
            get
            {
                var val = new QuickFix.Fields.MDEntryDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntryDate val) { this.MDEntryDate = val; }

        public QuickFix.Fields.MDEntryDate Get(QuickFix.Fields.MDEntryDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntryDate val) { return IsSetMDEntryDate(); }

        public bool IsSetMDEntryDate() { return IsSetField(Tags.MDEntryDate); }

        public QuickFix.Fields.MDEntryTime MDEntryTime
        {
            get
            {
                var val = new QuickFix.Fields.MDEntryTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntryTime val) { this.MDEntryTime = val; }

        public QuickFix.Fields.MDEntryTime Get(QuickFix.Fields.MDEntryTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntryTime val) { return IsSetMDEntryTime(); }

        public bool IsSetMDEntryTime() { return IsSetField(Tags.MDEntryTime); }

        public QuickFix.Fields.TickDirection TickDirection
        {
            get
            {
                var val = new QuickFix.Fields.TickDirection();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TickDirection val) { this.TickDirection = val; }

        public QuickFix.Fields.TickDirection Get(QuickFix.Fields.TickDirection val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TickDirection val) { return IsSetTickDirection(); }

        public bool IsSetTickDirection() { return IsSetField(Tags.TickDirection); }

        public QuickFix.Fields.MDMkt MDMkt
        {
            get
            {
                var val = new QuickFix.Fields.MDMkt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDMkt val) { this.MDMkt = val; }

        public QuickFix.Fields.MDMkt Get(QuickFix.Fields.MDMkt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDMkt val) { return IsSetMDMkt(); }

        public bool IsSetMDMkt() { return IsSetField(Tags.MDMkt); }

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

        public QuickFix.Fields.QuoteCondition QuoteCondition
        {
            get
            {
                var val = new QuickFix.Fields.QuoteCondition();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteCondition val) { this.QuoteCondition = val; }

        public QuickFix.Fields.QuoteCondition Get(QuickFix.Fields.QuoteCondition val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteCondition val) { return IsSetQuoteCondition(); }

        public bool IsSetQuoteCondition() { return IsSetField(Tags.QuoteCondition); }

        public QuickFix.Fields.TradeCondition TradeCondition
        {
            get
            {
                var val = new QuickFix.Fields.TradeCondition();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeCondition val) { this.TradeCondition = val; }

        public QuickFix.Fields.TradeCondition Get(QuickFix.Fields.TradeCondition val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeCondition val) { return IsSetTradeCondition(); }

        public bool IsSetTradeCondition() { return IsSetField(Tags.TradeCondition); }

        public QuickFix.Fields.MDEntryOriginator MDEntryOriginator
        {
            get
            {
                var val = new QuickFix.Fields.MDEntryOriginator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntryOriginator val) { this.MDEntryOriginator = val; }

        public QuickFix.Fields.MDEntryOriginator Get(QuickFix.Fields.MDEntryOriginator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntryOriginator val) { return IsSetMDEntryOriginator(); }

        public bool IsSetMDEntryOriginator() { return IsSetField(Tags.MDEntryOriginator); }

        public QuickFix.Fields.LocationID LocationID
        {
            get
            {
                var val = new QuickFix.Fields.LocationID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LocationID val) { this.LocationID = val; }

        public QuickFix.Fields.LocationID Get(QuickFix.Fields.LocationID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LocationID val) { return IsSetLocationID(); }

        public bool IsSetLocationID() { return IsSetField(Tags.LocationID); }

        public QuickFix.Fields.DeskID DeskID
        {
            get
            {
                var val = new QuickFix.Fields.DeskID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DeskID val) { this.DeskID = val; }

        public QuickFix.Fields.DeskID Get(QuickFix.Fields.DeskID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DeskID val) { return IsSetDeskID(); }

        public bool IsSetDeskID() { return IsSetField(Tags.DeskID); }

        public QuickFix.Fields.OpenCloseSettleFlag OpenCloseSettleFlag
        {
            get
            {
                var val = new QuickFix.Fields.OpenCloseSettleFlag();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OpenCloseSettleFlag val) { this.OpenCloseSettleFlag = val; }

        public QuickFix.Fields.OpenCloseSettleFlag Get(QuickFix.Fields.OpenCloseSettleFlag val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OpenCloseSettleFlag val) { return IsSetOpenCloseSettleFlag(); }

        public bool IsSetOpenCloseSettleFlag() { return IsSetField(Tags.OpenCloseSettleFlag); }

        public QuickFix.Fields.TimeInForce TimeInForce
        {
            get
            {
                var val = new QuickFix.Fields.TimeInForce();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TimeInForce val) { this.TimeInForce = val; }

        public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TimeInForce val) { return IsSetTimeInForce(); }

        public bool IsSetTimeInForce() { return IsSetField(Tags.TimeInForce); }

        public QuickFix.Fields.ExpireDate ExpireDate
        {
            get
            {
                var val = new QuickFix.Fields.ExpireDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExpireDate val) { this.ExpireDate = val; }

        public QuickFix.Fields.ExpireDate Get(QuickFix.Fields.ExpireDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExpireDate val) { return IsSetExpireDate(); }

        public bool IsSetExpireDate() { return IsSetField(Tags.ExpireDate); }

        public QuickFix.Fields.ExpireTime ExpireTime
        {
            get
            {
                var val = new QuickFix.Fields.ExpireTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExpireTime val) { this.ExpireTime = val; }

        public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExpireTime val) { return IsSetExpireTime(); }

        public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

        public QuickFix.Fields.MinQty MinQty
        {
            get
            {
                var val = new QuickFix.Fields.MinQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MinQty val) { this.MinQty = val; }

        public QuickFix.Fields.MinQty Get(QuickFix.Fields.MinQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MinQty val) { return IsSetMinQty(); }

        public bool IsSetMinQty() { return IsSetField(Tags.MinQty); }

        public QuickFix.Fields.ExecInst ExecInst
        {
            get
            {
                var val = new QuickFix.Fields.ExecInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExecInst val) { this.ExecInst = val; }

        public QuickFix.Fields.ExecInst Get(QuickFix.Fields.ExecInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExecInst val) { return IsSetExecInst(); }

        public bool IsSetExecInst() { return IsSetField(Tags.ExecInst); }

        public QuickFix.Fields.SellerDays SellerDays
        {
            get
            {
                var val = new QuickFix.Fields.SellerDays();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SellerDays val) { this.SellerDays = val; }

        public QuickFix.Fields.SellerDays Get(QuickFix.Fields.SellerDays val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SellerDays val) { return IsSetSellerDays(); }

        public bool IsSetSellerDays() { return IsSetField(Tags.SellerDays); }

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

        public QuickFix.Fields.MDEntryBuyer MDEntryBuyer
        {
            get
            {
                var val = new QuickFix.Fields.MDEntryBuyer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntryBuyer val) { this.MDEntryBuyer = val; }

        public QuickFix.Fields.MDEntryBuyer Get(QuickFix.Fields.MDEntryBuyer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntryBuyer val) { return IsSetMDEntryBuyer(); }

        public bool IsSetMDEntryBuyer() { return IsSetField(Tags.MDEntryBuyer); }

        public QuickFix.Fields.MDEntrySeller MDEntrySeller
        {
            get
            {
                var val = new QuickFix.Fields.MDEntrySeller();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntrySeller val) { this.MDEntrySeller = val; }

        public QuickFix.Fields.MDEntrySeller Get(QuickFix.Fields.MDEntrySeller val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntrySeller val) { return IsSetMDEntrySeller(); }

        public bool IsSetMDEntrySeller() { return IsSetField(Tags.MDEntrySeller); }

        public QuickFix.Fields.NumberOfOrders NumberOfOrders
        {
            get
            {
                var val = new QuickFix.Fields.NumberOfOrders();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NumberOfOrders val) { this.NumberOfOrders = val; }

        public QuickFix.Fields.NumberOfOrders Get(QuickFix.Fields.NumberOfOrders val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NumberOfOrders val) { return IsSetNumberOfOrders(); }

        public bool IsSetNumberOfOrders() { return IsSetField(Tags.NumberOfOrders); }

        public QuickFix.Fields.MDEntryPositionNo MDEntryPositionNo
        {
            get
            {
                var val = new QuickFix.Fields.MDEntryPositionNo();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MDEntryPositionNo val) { this.MDEntryPositionNo = val; }

        public QuickFix.Fields.MDEntryPositionNo Get(QuickFix.Fields.MDEntryPositionNo val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MDEntryPositionNo val) { return IsSetMDEntryPositionNo(); }

        public bool IsSetMDEntryPositionNo() { return IsSetField(Tags.MDEntryPositionNo); }

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


        }


    }
}
