// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class SecurityTypes : Message
{
    public const string MsgType = "w";

    public SecurityTypes() : base()
    {
        Header.SetField(new MsgType("w"));
    }

    public SecurityTypes(
            SecurityReqID aSecurityReqID,
            SecurityResponseID aSecurityResponseID,
            SecurityResponseType aSecurityResponseType
        ) : this()
    {
        SecurityReqID = aSecurityReqID;
        SecurityResponseID = aSecurityResponseID;
        SecurityResponseType = aSecurityResponseType;
    }

    public SecurityReqID SecurityReqID
    {
        get
        {
            SecurityReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityReqID val) { SecurityReqID = val; }
    public SecurityReqID Get(SecurityReqID val) { GetField(val); return val; }
    public bool IsSet(SecurityReqID val) { return IsSetSecurityReqID(); }
    public bool IsSetSecurityReqID() { return IsSetField(Tags.SecurityReqID); }

    public SecurityResponseID SecurityResponseID
    {
        get
        {
            SecurityResponseID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityResponseID val) { SecurityResponseID = val; }
    public SecurityResponseID Get(SecurityResponseID val) { GetField(val); return val; }
    public bool IsSet(SecurityResponseID val) { return IsSetSecurityResponseID(); }
    public bool IsSetSecurityResponseID() { return IsSetField(Tags.SecurityResponseID); }

    public SecurityResponseType SecurityResponseType
    {
        get
        {
            SecurityResponseType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityResponseType val) { SecurityResponseType = val; }
    public SecurityResponseType Get(SecurityResponseType val) { GetField(val); return val; }
    public bool IsSet(SecurityResponseType val) { return IsSetSecurityResponseType(); }
    public bool IsSetSecurityResponseType() { return IsSetField(Tags.SecurityResponseType); }

    public TotalNumSecurityTypes TotalNumSecurityTypes
    {
        get
        {
            TotalNumSecurityTypes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotalNumSecurityTypes val) { TotalNumSecurityTypes = val; }
    public TotalNumSecurityTypes Get(TotalNumSecurityTypes val) { GetField(val); return val; }
    public bool IsSet(TotalNumSecurityTypes val) { return IsSetTotalNumSecurityTypes(); }
    public bool IsSetTotalNumSecurityTypes() { return IsSetField(Tags.TotalNumSecurityTypes); }

    public NoSecurityTypes NoSecurityTypes
    {
        get
        {
            NoSecurityTypes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSecurityTypes val) { NoSecurityTypes = val; }
    public NoSecurityTypes Get(NoSecurityTypes val) { GetField(val); return val; }
    public bool IsSet(NoSecurityTypes val) { return IsSetNoSecurityTypes(); }
    public bool IsSetNoSecurityTypes() { return IsSetField(Tags.NoSecurityTypes); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

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

    public class NoSecurityTypesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.SecurityType, Tags.Product, Tags.CFICode, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.SecurityType, Tags.Product, Tags.CFICode, 0};

        public NoSecurityTypesGroup()
          : base(Tags.NoSecurityTypes, Tags.SecurityType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSecurityTypesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public SecurityType SecurityType
        {
            get
            {
                SecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityType val) { SecurityType = val; }
        public SecurityType Get(SecurityType val) { GetField(val); return val; }
        public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
        public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

        public Product Product
        {
            get
            {
                Product val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Product val) { Product = val; }
        public Product Get(Product val) { GetField(val); return val; }
        public bool IsSet(Product val) { return IsSetProduct(); }
        public bool IsSetProduct() { return IsSetField(Tags.Product); }

        public CFICode CFICode
        {
            get
            {
                CFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CFICode val) { CFICode = val; }
        public CFICode Get(CFICode val) { GetField(val); return val; }
        public bool IsSet(CFICode val) { return IsSetCFICode(); }
        public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }
    }
}
