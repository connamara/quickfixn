// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class MarketDefinitionRequest : Message
        {
            public const string MsgType = "BT";

            public MarketDefinitionRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BT"));
            }

            public MarketDefinitionRequest(
                    QuickFix.Fields.MarketReqID aMarketReqID,
                    QuickFix.Fields.SubscriptionRequestType aSubscriptionRequestType
                ) : this()
            {
                this.marketReqID = aMarketReqID;
                this.subscriptionRequestType = aSubscriptionRequestType;
            }

            public QuickFix.Fields.MarketReqID marketReqID
            { 
                get 
                {
                    QuickFix.Fields.MarketReqID val = new QuickFix.Fields.MarketReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketReqID val) 
            { 
                this.marketReqID = val;
            }
            
            public QuickFix.Fields.MarketReqID get(QuickFix.Fields.MarketReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketReqID val) 
            { 
                return isSetMarketReqID();
            }
            
            public bool isSetMarketReqID() 
            { 
                return isSetField(Tags.MarketReqID);
            }
            public QuickFix.Fields.SubscriptionRequestType subscriptionRequestType
            { 
                get 
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                this.subscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return isSetSubscriptionRequestType();
            }
            
            public bool isSetSubscriptionRequestType() 
            { 
                return isSetField(Tags.SubscriptionRequestType);
            }
            public QuickFix.Fields.MarketID marketID
            { 
                get 
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketID val) 
            { 
                this.marketID = val;
            }
            
            public QuickFix.Fields.MarketID get(QuickFix.Fields.MarketID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketID val) 
            { 
                return isSetMarketID();
            }
            
            public bool isSetMarketID() 
            { 
                return isSetField(Tags.MarketID);
            }
            public QuickFix.Fields.MarketSegmentID marketSegmentID
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketSegmentID val) 
            { 
                this.marketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID get(QuickFix.Fields.MarketSegmentID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return isSetMarketSegmentID();
            }
            
            public bool isSetMarketSegmentID() 
            { 
                return isSetField(Tags.MarketSegmentID);
            }
            public QuickFix.Fields.ParentMktSegmID parentMktSegmID
            { 
                get 
                {
                    QuickFix.Fields.ParentMktSegmID val = new QuickFix.Fields.ParentMktSegmID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ParentMktSegmID val) 
            { 
                this.parentMktSegmID = val;
            }
            
            public QuickFix.Fields.ParentMktSegmID get(QuickFix.Fields.ParentMktSegmID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ParentMktSegmID val) 
            { 
                return isSetParentMktSegmID();
            }
            
            public bool isSetParentMktSegmID() 
            { 
                return isSetField(Tags.ParentMktSegmID);
            }

        }
    }
}
