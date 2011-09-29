// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class PartyDetailsListRequest : Message
        {
            public const string MsgType = "CF";

            public PartyDetailsListRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CF"));
            }

            public PartyDetailsListRequest(
                    QuickFix.Fields.PartyDetailsListRequestID aPartyDetailsListRequestID
                ) : this()
            {
                this.partyDetailsListRequestID = aPartyDetailsListRequestID;
            }

            public QuickFix.Fields.PartyDetailsListRequestID partyDetailsListRequestID
            { 
                get 
                {
                    QuickFix.Fields.PartyDetailsListRequestID val = new QuickFix.Fields.PartyDetailsListRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                this.partyDetailsListRequestID = val;
            }
            
            public QuickFix.Fields.PartyDetailsListRequestID Get(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                return IsSetPartyDetailsListRequestID();
            }
            
            public bool IsSetPartyDetailsListRequestID() 
            { 
                return IsSetField(Tags.PartyDetailsListRequestID);
            }
            public QuickFix.Fields.NoPartyListResponseTypes noPartyListResponseTypes
            { 
                get 
                {
                    QuickFix.Fields.NoPartyListResponseTypes val = new QuickFix.Fields.NoPartyListResponseTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyListResponseTypes val) 
            { 
                this.noPartyListResponseTypes = val;
            }
            
            public QuickFix.Fields.NoPartyListResponseTypes Get(QuickFix.Fields.NoPartyListResponseTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyListResponseTypes val) 
            { 
                return IsSetNoPartyListResponseTypes();
            }
            
            public bool IsSetNoPartyListResponseTypes() 
            { 
                return IsSetField(Tags.NoPartyListResponseTypes);
            }
            public QuickFix.Fields.NoPartyIDs noPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyIDs val) 
            { 
                this.noPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.NoRequestedPartyRoles noRequestedPartyRoles
            { 
                get 
                {
                    QuickFix.Fields.NoRequestedPartyRoles val = new QuickFix.Fields.NoRequestedPartyRoles();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRequestedPartyRoles val) 
            { 
                this.noRequestedPartyRoles = val;
            }
            
            public QuickFix.Fields.NoRequestedPartyRoles Get(QuickFix.Fields.NoRequestedPartyRoles val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRequestedPartyRoles val) 
            { 
                return IsSetNoRequestedPartyRoles();
            }
            
            public bool IsSetNoRequestedPartyRoles() 
            { 
                return IsSetField(Tags.NoRequestedPartyRoles);
            }
            public QuickFix.Fields.NoPartyRelationships noPartyRelationships
            { 
                get 
                {
                    QuickFix.Fields.NoPartyRelationships val = new QuickFix.Fields.NoPartyRelationships();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyRelationships val) 
            { 
                this.noPartyRelationships = val;
            }
            
            public QuickFix.Fields.NoPartyRelationships Get(QuickFix.Fields.NoPartyRelationships val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyRelationships val) 
            { 
                return IsSetNoPartyRelationships();
            }
            
            public bool IsSetNoPartyRelationships() 
            { 
                return IsSetField(Tags.NoPartyRelationships);
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
            public QuickFix.Fields.Text text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Text val) 
            { 
                this.text = val;
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(Tags.EncodedText);
            }
            public class NoPartyListResponseTypes : Group
            {
                public NoPartyListResponseTypes() 
                  :base( Tags.NoPartyListResponseTypes, Tags.PartyListResponseType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyListResponseType, 0};
                            public QuickFix.Fields.PartyListResponseType partyListResponseType
                { 
                    get 
                    {
                        QuickFix.Fields.PartyListResponseType val = new QuickFix.Fields.PartyListResponseType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyListResponseType val) 
                { 
                    this.partyListResponseType = val;
                }
                
                public QuickFix.Fields.PartyListResponseType Get(QuickFix.Fields.PartyListResponseType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyListResponseType val) 
                { 
                    return IsSetPartyListResponseType();
                }
                
                public bool IsSetPartyListResponseType() 
                { 
                    return IsSetField(Tags.PartyListResponseType);
                }
            
            }
            public class NoPartyIDs : Group
            {
                public NoPartyIDs() 
                  :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
                            public QuickFix.Fields.PartyID partyID
                { 
                    get 
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyID val) 
                { 
                    this.partyID = val;
                }
                
                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource partyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyIDSource val) 
                { 
                    this.partyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole partyRole
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyRole val) 
                { 
                    this.partyRole = val;
                }
                
                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.NoPartySubIDs noPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    this.noPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    return IsSetNoPartySubIDs();
                }
                
                public bool IsSetNoPartySubIDs() 
                { 
                    return IsSetField(Tags.NoPartySubIDs);
                }
                            public class NoPartySubIDs : Group
                {
                    public NoPartySubIDs() 
                      :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                                    public QuickFix.Fields.PartySubID partySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubID val) 
                    { 
                        this.partySubID = val;
                    }
                    
                    public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartySubID val) 
                    { 
                        return IsSetPartySubID();
                    }
                    
                    public bool IsSetPartySubID() 
                    { 
                        return IsSetField(Tags.PartySubID);
                    }
                    public QuickFix.Fields.PartySubIDType partySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubIDType val) 
                    { 
                        this.partySubIDType = val;
                    }
                    
                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartySubIDType val) 
                    { 
                        return IsSetPartySubIDType();
                    }
                    
                    public bool IsSetPartySubIDType() 
                    { 
                        return IsSetField(Tags.PartySubIDType);
                    }
                
                }
            }
            public class NoRequestedPartyRoles : Group
            {
                public NoRequestedPartyRoles() 
                  :base( Tags.NoRequestedPartyRoles, Tags.RequestedPartyRole, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RequestedPartyRole, 0};
                            public QuickFix.Fields.RequestedPartyRole requestedPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.RequestedPartyRole val = new QuickFix.Fields.RequestedPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RequestedPartyRole val) 
                { 
                    this.requestedPartyRole = val;
                }
                
                public QuickFix.Fields.RequestedPartyRole Get(QuickFix.Fields.RequestedPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RequestedPartyRole val) 
                { 
                    return IsSetRequestedPartyRole();
                }
                
                public bool IsSetRequestedPartyRole() 
                { 
                    return IsSetField(Tags.RequestedPartyRole);
                }
            
            }
            public class NoPartyRelationships : Group
            {
                public NoPartyRelationships() 
                  :base( Tags.NoPartyRelationships, Tags.PartyRelationship, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyRelationship, 0};
                            public QuickFix.Fields.PartyRelationship partyRelationship
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRelationship val = new QuickFix.Fields.PartyRelationship();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyRelationship val) 
                { 
                    this.partyRelationship = val;
                }
                
                public QuickFix.Fields.PartyRelationship Get(QuickFix.Fields.PartyRelationship val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyRelationship val) 
                { 
                    return IsSetPartyRelationship();
                }
                
                public bool IsSetPartyRelationship() 
                { 
                    return IsSetField(Tags.PartyRelationship);
                }
            
            }
        }
    }
}
