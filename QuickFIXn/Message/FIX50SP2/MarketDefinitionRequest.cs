using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class MarketDefinitionRequest : Message
    {
        public const string MsgType = "BT";

        public MarketDefinitionRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public MarketDefinitionRequest(QuickFix.Fields.MarketReqID aMarketReqID,
				QuickFix.Fields.SubscriptionRequestType aSubscriptionRequestType)
               : this()
        {
            this.MarketReqID = aMarketReqID;
			this.SubscriptionRequestType = aSubscriptionRequestType;
        }

        public QuickFix.Fields.MarketReqID MarketReqID
        {
            get
            {
                var val = new QuickFix.Fields.MarketReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MarketReqID val) { this.MarketReqID = val; }

        public QuickFix.Fields.MarketReqID Get(QuickFix.Fields.MarketReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MarketReqID val) { return IsSetMarketReqID(); }

        public bool IsSetMarketReqID() { return IsSetField(Tags.MarketReqID); }

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

        public QuickFix.Fields.MarketID MarketID
        {
            get
            {
                var val = new QuickFix.Fields.MarketID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MarketID val) { this.MarketID = val; }

        public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MarketID val) { return IsSetMarketID(); }

        public bool IsSetMarketID() { return IsSetField(Tags.MarketID); }

        public QuickFix.Fields.MarketSegmentID MarketSegmentID
        {
            get
            {
                var val = new QuickFix.Fields.MarketSegmentID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MarketSegmentID val) { this.MarketSegmentID = val; }

        public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MarketSegmentID val) { return IsSetMarketSegmentID(); }

        public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

        public QuickFix.Fields.ParentMktSegmID ParentMktSegmID
        {
            get
            {
                var val = new QuickFix.Fields.ParentMktSegmID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ParentMktSegmID val) { this.ParentMktSegmID = val; }

        public QuickFix.Fields.ParentMktSegmID Get(QuickFix.Fields.ParentMktSegmID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ParentMktSegmID val) { return IsSetParentMktSegmID(); }

        public bool IsSetParentMktSegmID() { return IsSetField(Tags.ParentMktSegmID); }


    }
}
