using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class TradingSessionStatusRequest : Message
    {
        public const string MsgType = "g";

        public TradingSessionStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public TradingSessionStatusRequest(QuickFix.Fields.TradSesReqID aTradSesReqID,
				QuickFix.Fields.SubscriptionRequestType aSubscriptionRequestType)
               : this()
        {
            this.TradSesReqID = aTradSesReqID;
			this.SubscriptionRequestType = aSubscriptionRequestType;
        }

        public QuickFix.Fields.TradSesReqID TradSesReqID
        {
            get
            {
                var val = new QuickFix.Fields.TradSesReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesReqID val) { this.TradSesReqID = val; }

        public QuickFix.Fields.TradSesReqID Get(QuickFix.Fields.TradSesReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesReqID val) { return IsSetTradSesReqID(); }

        public bool IsSetTradSesReqID() { return IsSetField(Tags.TradSesReqID); }

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

        public QuickFix.Fields.TradSesMethod TradSesMethod
        {
            get
            {
                var val = new QuickFix.Fields.TradSesMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesMethod val) { this.TradSesMethod = val; }

        public QuickFix.Fields.TradSesMethod Get(QuickFix.Fields.TradSesMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesMethod val) { return IsSetTradSesMethod(); }

        public bool IsSetTradSesMethod() { return IsSetField(Tags.TradSesMethod); }

        public QuickFix.Fields.TradSesMode TradSesMode
        {
            get
            {
                var val = new QuickFix.Fields.TradSesMode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesMode val) { this.TradSesMode = val; }

        public QuickFix.Fields.TradSesMode Get(QuickFix.Fields.TradSesMode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesMode val) { return IsSetTradSesMode(); }

        public bool IsSetTradSesMode() { return IsSetField(Tags.TradSesMode); }

        public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
        {
            get
            {
                var val = new QuickFix.Fields.SubscriptionRequestType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SubscriptionRequestType val) { this.SubscriptionRequestType = val; }

        public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SubscriptionRequestType val) { return IsSetSubscriptionRequestType(); }

        public bool IsSetSubscriptionRequestType() { return IsSetField(Tags.SubscriptionRequestType); }

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


    }
}
