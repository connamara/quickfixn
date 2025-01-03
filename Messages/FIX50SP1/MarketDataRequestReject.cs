// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

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

    public NoPartyIDs NoPartyIDs
    {
        get
        {
            NoPartyIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyIDs val) { NoPartyIDs = val; }
    public NoPartyIDs Get(NoPartyIDs val) { GetField(val); return val; }
    public bool IsSet(NoPartyIDs val) { return IsSetNoPartyIDs(); }
    public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

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

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

        public NoPartyIDsGroup()
          : base(Tags.NoPartyIDs, Tags.PartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyID PartyID
        {
            get
            {
                PartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyID val) { PartyID = val; }
        public PartyID Get(PartyID val) { GetField(val); return val; }
        public bool IsSet(PartyID val) { return IsSetPartyID(); }
        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public PartyIDSource PartyIDSource
        {
            get
            {
                PartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyIDSource val) { PartyIDSource = val; }
        public PartyIDSource Get(PartyIDSource val) { GetField(val); return val; }
        public bool IsSet(PartyIDSource val) { return IsSetPartyIDSource(); }
        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public PartyRole PartyRole
        {
            get
            {
                PartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRole val) { PartyRole = val; }
        public PartyRole Get(PartyRole val) { GetField(val); return val; }
        public bool IsSet(PartyRole val) { return IsSetPartyRole(); }
        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public NoPartySubIDs NoPartySubIDs
        {
            get
            {
                NoPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoPartySubIDs val) { NoPartySubIDs = val; }
        public NoPartySubIDs Get(NoPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoPartySubIDs val) { return IsSetNoPartySubIDs(); }
        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }

        public class NoPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartySubID, Tags.PartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup()
              : base(Tags.NoPartySubIDs, Tags.PartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public PartySubID PartySubID
            {
                get
                {
                    PartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubID val) { PartySubID = val; }
            public PartySubID Get(PartySubID val) { GetField(val); return val; }
            public bool IsSet(PartySubID val) { return IsSetPartySubID(); }
            public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }

            public PartySubIDType PartySubIDType
            {
                get
                {
                    PartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubIDType val) { PartySubIDType = val; }
            public PartySubIDType Get(PartySubIDType val) { GetField(val); return val; }
            public bool IsSet(PartySubIDType val) { return IsSetPartySubIDType(); }
            public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }
        }
    }
}
