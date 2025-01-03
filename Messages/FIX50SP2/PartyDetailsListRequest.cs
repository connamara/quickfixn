// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class PartyDetailsListRequest : Message
{
    public const string MsgType = "CF";

    public PartyDetailsListRequest() : base()
    {
        Header.SetField(new MsgType("CF"));
    }

    public PartyDetailsListRequest(
            PartyDetailsListRequestID aPartyDetailsListRequestID
        ) : this()
    {
        PartyDetailsListRequestID = aPartyDetailsListRequestID;
    }

    public PartyDetailsListRequestID PartyDetailsListRequestID
    {
        get
        {
            PartyDetailsListRequestID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PartyDetailsListRequestID val) { PartyDetailsListRequestID = val; }
    public PartyDetailsListRequestID Get(PartyDetailsListRequestID val) { GetField(val); return val; }
    public bool IsSet(PartyDetailsListRequestID val) { return IsSetPartyDetailsListRequestID(); }
    public bool IsSetPartyDetailsListRequestID() { return IsSetField(Tags.PartyDetailsListRequestID); }

    public NoPartyListResponseTypes NoPartyListResponseTypes
    {
        get
        {
            NoPartyListResponseTypes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyListResponseTypes val) { NoPartyListResponseTypes = val; }
    public NoPartyListResponseTypes Get(NoPartyListResponseTypes val) { GetField(val); return val; }
    public bool IsSet(NoPartyListResponseTypes val) { return IsSetNoPartyListResponseTypes(); }
    public bool IsSetNoPartyListResponseTypes() { return IsSetField(Tags.NoPartyListResponseTypes); }

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

    public NoRequestedPartyRoles NoRequestedPartyRoles
    {
        get
        {
            NoRequestedPartyRoles val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRequestedPartyRoles val) { NoRequestedPartyRoles = val; }
    public NoRequestedPartyRoles Get(NoRequestedPartyRoles val) { GetField(val); return val; }
    public bool IsSet(NoRequestedPartyRoles val) { return IsSetNoRequestedPartyRoles(); }
    public bool IsSetNoRequestedPartyRoles() { return IsSetField(Tags.NoRequestedPartyRoles); }

    public NoPartyRelationships NoPartyRelationships
    {
        get
        {
            NoPartyRelationships val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyRelationships val) { NoPartyRelationships = val; }
    public NoPartyRelationships Get(NoPartyRelationships val) { GetField(val); return val; }
    public bool IsSet(NoPartyRelationships val) { return IsSetNoPartyRelationships(); }
    public bool IsSetNoPartyRelationships() { return IsSetField(Tags.NoPartyRelationships); }

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

    public class NoPartyListResponseTypesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyListResponseType, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyListResponseType, 0};

        public NoPartyListResponseTypesGroup()
          : base(Tags.NoPartyListResponseTypes, Tags.PartyListResponseType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyListResponseTypesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyListResponseType PartyListResponseType
        {
            get
            {
                PartyListResponseType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyListResponseType val) { PartyListResponseType = val; }
        public PartyListResponseType Get(PartyListResponseType val) { GetField(val); return val; }
        public bool IsSet(PartyListResponseType val) { return IsSetPartyListResponseType(); }
        public bool IsSetPartyListResponseType() { return IsSetField(Tags.PartyListResponseType); }
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

    public class NoRequestedPartyRolesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RequestedPartyRole, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RequestedPartyRole, 0};

        public NoRequestedPartyRolesGroup()
          : base(Tags.NoRequestedPartyRoles, Tags.RequestedPartyRole, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRequestedPartyRolesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RequestedPartyRole RequestedPartyRole
        {
            get
            {
                RequestedPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RequestedPartyRole val) { RequestedPartyRole = val; }
        public RequestedPartyRole Get(RequestedPartyRole val) { GetField(val); return val; }
        public bool IsSet(RequestedPartyRole val) { return IsSetRequestedPartyRole(); }
        public bool IsSetRequestedPartyRole() { return IsSetField(Tags.RequestedPartyRole); }
    }

    public class NoPartyRelationshipsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyRelationship, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyRelationship, 0};

        public NoPartyRelationshipsGroup()
          : base(Tags.NoPartyRelationships, Tags.PartyRelationship, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyRelationshipsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyRelationship PartyRelationship
        {
            get
            {
                PartyRelationship val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRelationship val) { PartyRelationship = val; }
        public PartyRelationship Get(PartyRelationship val) { GetField(val); return val; }
        public bool IsSet(PartyRelationship val) { return IsSetPartyRelationship(); }
        public bool IsSetPartyRelationship() { return IsSetField(Tags.PartyRelationship); }
    }
}
