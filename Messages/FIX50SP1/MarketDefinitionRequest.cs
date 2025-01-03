// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class MarketDefinitionRequest : Message
{
    public const string MsgType = "BT";

    public MarketDefinitionRequest() : base()
    {
        Header.SetField(new MsgType("BT"));
    }

    public MarketDefinitionRequest(
            MarketReqID aMarketReqID,
            SubscriptionRequestType aSubscriptionRequestType
        ) : this()
    {
        MarketReqID = aMarketReqID;
        SubscriptionRequestType = aSubscriptionRequestType;
    }

    public MarketReqID MarketReqID
    {
        get
        {
            MarketReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketReqID val) { MarketReqID = val; }
    public MarketReqID Get(MarketReqID val) { GetField(val); return val; }
    public bool IsSet(MarketReqID val) { return IsSetMarketReqID(); }
    public bool IsSetMarketReqID() { return IsSetField(Tags.MarketReqID); }

    public SubscriptionRequestType SubscriptionRequestType
    {
        get
        {
            SubscriptionRequestType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SubscriptionRequestType val) { SubscriptionRequestType = val; }
    public SubscriptionRequestType Get(SubscriptionRequestType val) { GetField(val); return val; }
    public bool IsSet(SubscriptionRequestType val) { return IsSetSubscriptionRequestType(); }
    public bool IsSetSubscriptionRequestType() { return IsSetField(Tags.SubscriptionRequestType); }

    public MarketID MarketID
    {
        get
        {
            MarketID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketID val) { MarketID = val; }
    public MarketID Get(MarketID val) { GetField(val); return val; }
    public bool IsSet(MarketID val) { return IsSetMarketID(); }
    public bool IsSetMarketID() { return IsSetField(Tags.MarketID); }

    public MarketSegmentID MarketSegmentID
    {
        get
        {
            MarketSegmentID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketSegmentID val) { MarketSegmentID = val; }
    public MarketSegmentID Get(MarketSegmentID val) { GetField(val); return val; }
    public bool IsSet(MarketSegmentID val) { return IsSetMarketSegmentID(); }
    public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

    public ParentMktSegmID ParentMktSegmID
    {
        get
        {
            ParentMktSegmID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ParentMktSegmID val) { ParentMktSegmID = val; }
    public ParentMktSegmID Get(ParentMktSegmID val) { GetField(val); return val; }
    public bool IsSet(ParentMktSegmID val) { return IsSetParentMktSegmID(); }
    public bool IsSetParentMktSegmID() { return IsSetField(Tags.ParentMktSegmID); }
}
