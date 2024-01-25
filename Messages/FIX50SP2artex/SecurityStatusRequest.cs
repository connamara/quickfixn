// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class SecurityStatusRequest : Message
        {
            public const string MsgType = "e";

            public SecurityStatusRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("e"));
            }

            public SecurityStatusRequest(
                    QuickFix.Fields.SecurityStatusReqID aSecurityStatusReqID,
                    QuickFix.Fields.SubscriptionRequestType aSubscriptionRequestType
                ) : this()
            {
                this.SecurityStatusReqID = aSecurityStatusReqID;
                this.SubscriptionRequestType = aSubscriptionRequestType;
            }

            public QuickFix.Fields.SecurityStatusReqID SecurityStatusReqID
            {
                get
                {
                    QuickFix.Fields.SecurityStatusReqID val = new QuickFix.Fields.SecurityStatusReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityStatusReqID val)
            {
                this.SecurityStatusReqID = val;
            }

            public QuickFix.Fields.SecurityStatusReqID Get(QuickFix.Fields.SecurityStatusReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityStatusReqID val)
            {
                return IsSetSecurityStatusReqID();
            }

            public bool IsSetSecurityStatusReqID()
            {
                return IsSetField(Tags.SecurityStatusReqID);
            }

            public QuickFix.Fields.Symbol Symbol
            {
                get
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Symbol val)
            {
                this.Symbol = val;
            }

            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Symbol val)
            {
                return IsSetSymbol();
            }

            public bool IsSetSymbol()
            {
                return IsSetField(Tags.Symbol);
            }

            public QuickFix.Fields.SecurityID SecurityID
            {
                get
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityID val)
            {
                this.SecurityID = val;
            }

            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityID val)
            {
                return IsSetSecurityID();
            }

            public bool IsSetSecurityID()
            {
                return IsSetField(Tags.SecurityID);
            }

            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            {
                get
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityIDSource val)
            {
                this.SecurityIDSource = val;
            }

            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityIDSource val)
            {
                return IsSetSecurityIDSource();
            }

            public bool IsSetSecurityIDSource()
            {
                return IsSetField(Tags.SecurityIDSource);
            }

            public QuickFix.Fields.Currency Currency
            {
                get
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Currency val)
            {
                this.Currency = val;
            }

            public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Currency val)
            {
                return IsSetCurrency();
            }

            public bool IsSetCurrency()
            {
                return IsSetField(Tags.Currency);
            }

            public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
            {
                get
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SubscriptionRequestType val)
            {
                this.SubscriptionRequestType = val;
            }

            public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SubscriptionRequestType val)
            {
                return IsSetSubscriptionRequestType();
            }

            public bool IsSetSubscriptionRequestType()
            {
                return IsSetField(Tags.SubscriptionRequestType);
            }

            public QuickFix.Fields.TradingSessionID TradingSessionID
            {
                get
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradingSessionID val)
            {
                this.TradingSessionID = val;
            }

            public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradingSessionID val)
            {
                return IsSetTradingSessionID();
            }

            public bool IsSetTradingSessionID()
            {
                return IsSetField(Tags.TradingSessionID);
            }

        }
    }
}
