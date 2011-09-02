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
                this.Header.setField(new QuickFix.Fields.MsgType("CF"));
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
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                this.partyDetailsListRequestID = val;
            }
            
            public QuickFix.Fields.PartyDetailsListRequestID get(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                return isSetPartyDetailsListRequestID();
            }
            
            public bool isSetPartyDetailsListRequestID() 
            { 
                return isSetField(Tags.PartyDetailsListRequestID);
            }
            public QuickFix.Fields.NoPartyListResponseTypes noPartyListResponseTypes
            { 
                get 
                {
                    QuickFix.Fields.NoPartyListResponseTypes val = new QuickFix.Fields.NoPartyListResponseTypes();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoPartyListResponseTypes val) 
            { 
                this.noPartyListResponseTypes = val;
            }
            
            public QuickFix.Fields.NoPartyListResponseTypes get(QuickFix.Fields.NoPartyListResponseTypes val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoPartyListResponseTypes val) 
            { 
                return isSetNoPartyListResponseTypes();
            }
            
            public bool isSetNoPartyListResponseTypes() 
            { 
                return isSetField(Tags.NoPartyListResponseTypes);
            }
            public QuickFix.Fields.NoPartyIDs noPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoPartyIDs val) 
            { 
                this.noPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs get(QuickFix.Fields.NoPartyIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return isSetNoPartyIDs();
            }
            
            public bool isSetNoPartyIDs() 
            { 
                return isSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.NoRequestedPartyRoles noRequestedPartyRoles
            { 
                get 
                {
                    QuickFix.Fields.NoRequestedPartyRoles val = new QuickFix.Fields.NoRequestedPartyRoles();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRequestedPartyRoles val) 
            { 
                this.noRequestedPartyRoles = val;
            }
            
            public QuickFix.Fields.NoRequestedPartyRoles get(QuickFix.Fields.NoRequestedPartyRoles val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRequestedPartyRoles val) 
            { 
                return isSetNoRequestedPartyRoles();
            }
            
            public bool isSetNoRequestedPartyRoles() 
            { 
                return isSetField(Tags.NoRequestedPartyRoles);
            }
            public QuickFix.Fields.NoPartyRelationships noPartyRelationships
            { 
                get 
                {
                    QuickFix.Fields.NoPartyRelationships val = new QuickFix.Fields.NoPartyRelationships();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoPartyRelationships val) 
            { 
                this.noPartyRelationships = val;
            }
            
            public QuickFix.Fields.NoPartyRelationships get(QuickFix.Fields.NoPartyRelationships val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoPartyRelationships val) 
            { 
                return isSetNoPartyRelationships();
            }
            
            public bool isSetNoPartyRelationships() 
            { 
                return isSetField(Tags.NoPartyRelationships);
            }
            public QuickFix.Fields.SubscriptionRequestType subscriptionRequestType
            { 
                get 
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                this.subscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return isSetSubscriptionRequestType();
            }
            
            public bool isSetSubscriptionRequestType() 
            { 
                return isSetField(Tags.SubscriptionRequestType);
            }
            public QuickFix.Fields.Text text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Text val) 
            { 
                this.text = val;
            }
            
            public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Text val) 
            { 
                return isSetText();
            }
            
            public bool isSetText() 
            { 
                return isSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen get(QuickFix.Fields.EncodedTextLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return isSetEncodedTextLen();
            }
            
            public bool isSetEncodedTextLen() 
            { 
                return isSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText get(QuickFix.Fields.EncodedText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedText val) 
            { 
                return isSetEncodedText();
            }
            
            public bool isSetEncodedText() 
            { 
                return isSetField(Tags.EncodedText);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyListResponseType val) 
                { 
                    this.partyListResponseType = val;
                }
                
                public QuickFix.Fields.PartyListResponseType get(QuickFix.Fields.PartyListResponseType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyListResponseType val) 
                { 
                    return isSetPartyListResponseType();
                }
                
                public bool isSetPartyListResponseType() 
                { 
                    return isSetField(Tags.PartyListResponseType);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyID val) 
                { 
                    this.partyID = val;
                }
                
                public QuickFix.Fields.PartyID get(QuickFix.Fields.PartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyID val) 
                { 
                    return isSetPartyID();
                }
                
                public bool isSetPartyID() 
                { 
                    return isSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource partyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyIDSource val) 
                { 
                    this.partyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource get(QuickFix.Fields.PartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return isSetPartyIDSource();
                }
                
                public bool isSetPartyIDSource() 
                { 
                    return isSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole partyRole
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyRole val) 
                { 
                    this.partyRole = val;
                }
                
                public QuickFix.Fields.PartyRole get(QuickFix.Fields.PartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyRole val) 
                { 
                    return isSetPartyRole();
                }
                
                public bool isSetPartyRole() 
                { 
                    return isSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.NoPartySubIDs noPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    this.noPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoPartySubIDs get(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    return isSetNoPartySubIDs();
                }
                
                public bool isSetNoPartySubIDs() 
                { 
                    return isSetField(Tags.NoPartySubIDs);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartySubID val) 
                    { 
                        this.partySubID = val;
                    }
                    
                    public QuickFix.Fields.PartySubID get(QuickFix.Fields.PartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartySubID val) 
                    { 
                        return isSetPartySubID();
                    }
                    
                    public bool isSetPartySubID() 
                    { 
                        return isSetField(Tags.PartySubID);
                    }
                    public QuickFix.Fields.PartySubIDType partySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartySubIDType val) 
                    { 
                        this.partySubIDType = val;
                    }
                    
                    public QuickFix.Fields.PartySubIDType get(QuickFix.Fields.PartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartySubIDType val) 
                    { 
                        return isSetPartySubIDType();
                    }
                    
                    public bool isSetPartySubIDType() 
                    { 
                        return isSetField(Tags.PartySubIDType);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RequestedPartyRole val) 
                { 
                    this.requestedPartyRole = val;
                }
                
                public QuickFix.Fields.RequestedPartyRole get(QuickFix.Fields.RequestedPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RequestedPartyRole val) 
                { 
                    return isSetRequestedPartyRole();
                }
                
                public bool isSetRequestedPartyRole() 
                { 
                    return isSetField(Tags.RequestedPartyRole);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyRelationship val) 
                { 
                    this.partyRelationship = val;
                }
                
                public QuickFix.Fields.PartyRelationship get(QuickFix.Fields.PartyRelationship val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyRelationship val) 
                { 
                    return isSetPartyRelationship();
                }
                
                public bool isSetPartyRelationship() 
                { 
                    return isSetField(Tags.PartyRelationship);
                }
            
            }
        }
    }
}
