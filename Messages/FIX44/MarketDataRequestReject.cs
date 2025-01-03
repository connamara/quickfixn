// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class MarketDataRequestReject : Message
{
    public const string MsgType = "Y";

    public MarketDataRequestReject() : base()
    {
        Header.SetField(new MsgType("Y"));
    }

    public MarketDataRequestReject(
            MDReqID aMDReqID
        ) : this()
    {
        MDReqID = aMDReqID;
    }

    public MDReqID MDReqID
    {
        get
        {
            MDReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MDReqID val) { MDReqID = val; }
    public MDReqID Get(MDReqID val) { GetField(val); return val; }
    public bool IsSet(MDReqID val) { return IsSetMDReqID(); }
    public bool IsSetMDReqID() { return IsSetField(Tags.MDReqID); }

    public MDReqRejReason MDReqRejReason
    {
        get
        {
            MDReqRejReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MDReqRejReason val) { MDReqRejReason = val; }
    public MDReqRejReason Get(MDReqRejReason val) { GetField(val); return val; }
    public bool IsSet(MDReqRejReason val) { return IsSetMDReqRejReason(); }
    public bool IsSetMDReqRejReason() { return IsSetField(Tags.MDReqRejReason); }

    public NoAltMDSource NoAltMDSource
    {
        get
        {
            NoAltMDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoAltMDSource val) { NoAltMDSource = val; }
    public NoAltMDSource Get(NoAltMDSource val) { GetField(val); return val; }
    public bool IsSet(NoAltMDSource val) { return IsSetNoAltMDSource(); }
    public bool IsSetNoAltMDSource() { return IsSetField(Tags.NoAltMDSource); }

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

    public class NoAltMDSourceGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.AltMDSourceID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.AltMDSourceID, 0};

        public NoAltMDSourceGroup()
          : base(Tags.NoAltMDSource, Tags.AltMDSourceID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoAltMDSourceGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public AltMDSourceID AltMDSourceID
        {
            get
            {
                AltMDSourceID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AltMDSourceID val) { AltMDSourceID = val; }
        public AltMDSourceID Get(AltMDSourceID val) { GetField(val); return val; }
        public bool IsSet(AltMDSourceID val) { return IsSetAltMDSourceID(); }
        public bool IsSetAltMDSourceID() { return IsSetField(Tags.AltMDSourceID); }
    }
}
