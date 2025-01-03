// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50;

public class TradingSessionStatusRequest : Message
{
    public const string MsgType = "g";

    public TradingSessionStatusRequest() : base()
    {
        Header.SetField(new MsgType("g"));
    }

    public TradingSessionStatusRequest(
            TradSesReqID aTradSesReqID,
            SubscriptionRequestType aSubscriptionRequestType
        ) : this()
    {
        TradSesReqID = aTradSesReqID;
        SubscriptionRequestType = aSubscriptionRequestType;
    }

    public TradSesReqID TradSesReqID
    {
        get
        {
            TradSesReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradSesReqID val) { TradSesReqID = val; }
    public TradSesReqID Get(TradSesReqID val) { GetField(val); return val; }
    public bool IsSet(TradSesReqID val) { return IsSetTradSesReqID(); }
    public bool IsSetTradSesReqID() { return IsSetField(Tags.TradSesReqID); }

    public TradingSessionID TradingSessionID
    {
        get
        {
            TradingSessionID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSessionID val) { TradingSessionID = val; }
    public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
    public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
    public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

    public TradingSessionSubID TradingSessionSubID
    {
        get
        {
            TradingSessionSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSessionSubID val) { TradingSessionSubID = val; }
    public TradingSessionSubID Get(TradingSessionSubID val) { GetField(val); return val; }
    public bool IsSet(TradingSessionSubID val) { return IsSetTradingSessionSubID(); }
    public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

    public TradSesMethod TradSesMethod
    {
        get
        {
            TradSesMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradSesMethod val) { TradSesMethod = val; }
    public TradSesMethod Get(TradSesMethod val) { GetField(val); return val; }
    public bool IsSet(TradSesMethod val) { return IsSetTradSesMethod(); }
    public bool IsSetTradSesMethod() { return IsSetField(Tags.TradSesMethod); }

    public TradSesMode TradSesMode
    {
        get
        {
            TradSesMode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradSesMode val) { TradSesMode = val; }
    public TradSesMode Get(TradSesMode val) { GetField(val); return val; }
    public bool IsSet(TradSesMode val) { return IsSetTradSesMode(); }
    public bool IsSetTradSesMode() { return IsSetField(Tags.TradSesMode); }

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

    public SecurityExchange SecurityExchange
    {
        get
        {
            SecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityExchange val) { SecurityExchange = val; }
    public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
    public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
    public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }
}
