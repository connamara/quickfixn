using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class PartyDetailsListRequest : Message
    {
        public const string MsgType = "CF";

        public PartyDetailsListRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public PartyDetailsListRequest(QuickFix.Fields.PartyDetailsListRequestID aPartyDetailsListRequestID)
               : this()
        {
            this.PartyDetailsListRequestID = aPartyDetailsListRequestID;
        }

        public QuickFix.Fields.PartyDetailsListRequestID PartyDetailsListRequestID
        {
            get
            {
                var val = new QuickFix.Fields.PartyDetailsListRequestID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyDetailsListRequestID val) { this.PartyDetailsListRequestID = val; }

        public QuickFix.Fields.PartyDetailsListRequestID Get(QuickFix.Fields.PartyDetailsListRequestID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyDetailsListRequestID val) { return IsSetPartyDetailsListRequestID(); }

        public bool IsSetPartyDetailsListRequestID() { return IsSetField(Tags.PartyDetailsListRequestID); }

        public QuickFix.Fields.NoPartyListResponseTypes NoPartyListResponseTypes
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyListResponseTypes();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyListResponseTypes val) { this.NoPartyListResponseTypes = val; }

        public QuickFix.Fields.NoPartyListResponseTypes Get(QuickFix.Fields.NoPartyListResponseTypes val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyListResponseTypes val) { return IsSetNoPartyListResponseTypes(); }

        public bool IsSetNoPartyListResponseTypes() { return IsSetField(Tags.NoPartyListResponseTypes); }

        public QuickFix.Fields.NoPartyIDs NoPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyIDs val) { this.NoPartyIDs = val; }

        public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyIDs val) { return IsSetNoPartyIDs(); }

        public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

        public QuickFix.Fields.NoRequestedPartyRoles NoRequestedPartyRoles
        {
            get
            {
                var val = new QuickFix.Fields.NoRequestedPartyRoles();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRequestedPartyRoles val) { this.NoRequestedPartyRoles = val; }

        public QuickFix.Fields.NoRequestedPartyRoles Get(QuickFix.Fields.NoRequestedPartyRoles val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRequestedPartyRoles val) { return IsSetNoRequestedPartyRoles(); }

        public bool IsSetNoRequestedPartyRoles() { return IsSetField(Tags.NoRequestedPartyRoles); }

        public QuickFix.Fields.NoPartyRelationships NoPartyRelationships
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyRelationships();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyRelationships val) { this.NoPartyRelationships = val; }

        public QuickFix.Fields.NoPartyRelationships Get(QuickFix.Fields.NoPartyRelationships val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyRelationships val) { return IsSetNoPartyRelationships(); }

        public bool IsSetNoPartyRelationships() { return IsSetField(Tags.NoPartyRelationships); }

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

        public QuickFix.Fields.Text Text
        {
            get
            {
                var val = new QuickFix.Fields.Text();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Text val) { this.Text = val; }

        public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Text val) { return IsSetText(); }

        public bool IsSetText() { return IsSetField(Tags.Text); }

        public QuickFix.Fields.EncodedTextLen EncodedTextLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedTextLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedTextLen val) { this.EncodedTextLen = val; }

        public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedTextLen val) { return IsSetEncodedTextLen(); }

        public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

        public QuickFix.Fields.EncodedText EncodedText
        {
            get
            {
                var val = new QuickFix.Fields.EncodedText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedText val) { this.EncodedText = val; }

        public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedText val) { return IsSetEncodedText(); }

        public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }


        public class NoPartyListResponseTypesGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyListResponseType, 0};

            public NoPartyListResponseTypesGroup() : base(Tags.NoPartyListResponseTypes, Tags.PartyListResponseType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyListResponseTypesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyListResponseType PartyListResponseType
        {
            get
            {
                var val = new QuickFix.Fields.PartyListResponseType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyListResponseType val) { this.PartyListResponseType = val; }

        public QuickFix.Fields.PartyListResponseType Get(QuickFix.Fields.PartyListResponseType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyListResponseType val) { return IsSetPartyListResponseType(); }

        public bool IsSetPartyListResponseType() { return IsSetField(Tags.PartyListResponseType); }


        }


        public class NoPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

            public NoPartyIDsGroup() : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyID PartyID
        {
            get
            {
                var val = new QuickFix.Fields.PartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyID val) { this.PartyID = val; }

        public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyID val) { return IsSetPartyID(); }

        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public QuickFix.Fields.PartyIDSource PartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.PartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyIDSource val) { this.PartyIDSource = val; }

        public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyIDSource val) { return IsSetPartyIDSource(); }

        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public QuickFix.Fields.PartyRole PartyRole
        {
            get
            {
                var val = new QuickFix.Fields.PartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyRole val) { this.PartyRole = val; }

        public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyRole val) { return IsSetPartyRole(); }

        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartySubIDs val) { this.NoPartySubIDs = val; }

        public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartySubIDs val) { return IsSetNoPartySubIDs(); }

        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }


        public class NoPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup() : base(Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartySubID PartySubID
        {
            get
            {
                var val = new QuickFix.Fields.PartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartySubID val) { this.PartySubID = val; }

        public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartySubID val) { return IsSetPartySubID(); }

        public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }

        public QuickFix.Fields.PartySubIDType PartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.PartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartySubIDType val) { this.PartySubIDType = val; }

        public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartySubIDType val) { return IsSetPartySubIDType(); }

        public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }


        }
        }


        public class NoRequestedPartyRolesGroup : Group
        {
            public static int[] fieldOrder = {Tags.RequestedPartyRole, 0};

            public NoRequestedPartyRolesGroup() : base(Tags.NoRequestedPartyRoles, Tags.RequestedPartyRole, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRequestedPartyRolesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RequestedPartyRole RequestedPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.RequestedPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RequestedPartyRole val) { this.RequestedPartyRole = val; }

        public QuickFix.Fields.RequestedPartyRole Get(QuickFix.Fields.RequestedPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RequestedPartyRole val) { return IsSetRequestedPartyRole(); }

        public bool IsSetRequestedPartyRole() { return IsSetField(Tags.RequestedPartyRole); }


        }


        public class NoPartyRelationshipsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyRelationship, 0};

            public NoPartyRelationshipsGroup() : base(Tags.NoPartyRelationships, Tags.PartyRelationship, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyRelationshipsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyRelationship PartyRelationship
        {
            get
            {
                var val = new QuickFix.Fields.PartyRelationship();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyRelationship val) { this.PartyRelationship = val; }

        public QuickFix.Fields.PartyRelationship Get(QuickFix.Fields.PartyRelationship val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyRelationship val) { return IsSetPartyRelationship(); }

        public bool IsSetPartyRelationship() { return IsSetField(Tags.PartyRelationship); }


        }


    }
}
