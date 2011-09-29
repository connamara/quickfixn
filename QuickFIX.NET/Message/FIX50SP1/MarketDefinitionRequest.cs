// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class MarketDefinitionRequest : Message
        {
            public const string MsgType = "BT";

            public MarketDefinitionRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BT"));
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
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketReqID val) 
            { 
                this.marketReqID = val;
            }
            
            public QuickFix.Fields.MarketReqID Get(QuickFix.Fields.MarketReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketReqID val) 
            { 
                return IsSetMarketReqID();
            }
            
            public bool IsSetMarketReqID() 
            { 
                return IsSetField(Tags.MarketReqID);
            }
            public QuickFix.Fields.SubscriptionRequestType subscriptionRequestType
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
                this.subscriptionRequestType = val;
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
            public QuickFix.Fields.MarketID marketID
            { 
                get 
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketID val) 
            { 
                this.marketID = val;
            }
            
            public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketID val) 
            { 
                return IsSetMarketID();
            }
            
            public bool IsSetMarketID() 
            { 
                return IsSetField(Tags.MarketID);
            }
            public QuickFix.Fields.MarketSegmentID marketSegmentID
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketSegmentID val) 
            { 
                this.marketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return IsSetMarketSegmentID();
            }
            
            public bool IsSetMarketSegmentID() 
            { 
                return IsSetField(Tags.MarketSegmentID);
            }
            public QuickFix.Fields.ParentMktSegmID parentMktSegmID
            { 
                get 
                {
                    QuickFix.Fields.ParentMktSegmID val = new QuickFix.Fields.ParentMktSegmID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ParentMktSegmID val) 
            { 
                this.parentMktSegmID = val;
            }
            
            public QuickFix.Fields.ParentMktSegmID Get(QuickFix.Fields.ParentMktSegmID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ParentMktSegmID val) 
            { 
                return IsSetParentMktSegmID();
            }
            
            public bool IsSetParentMktSegmID() 
            { 
                return IsSetField(Tags.ParentMktSegmID);
            }

        }
    }
}
