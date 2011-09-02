// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class NetworkCounterpartySystemStatusRequest : Message
        {
            public const string MsgType = "BC";

            public NetworkCounterpartySystemStatusRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BC"));
            }

            public NetworkCounterpartySystemStatusRequest(
                    QuickFix.Fields.NetworkRequestType aNetworkRequestType,
                    QuickFix.Fields.NetworkRequestID aNetworkRequestID
                ) : this()
            {
                this.networkRequestType = aNetworkRequestType;
                this.networkRequestID = aNetworkRequestID;
            }

            public QuickFix.Fields.NetworkRequestType networkRequestType
            { 
                get 
                {
                    QuickFix.Fields.NetworkRequestType val = new QuickFix.Fields.NetworkRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NetworkRequestType val) 
            { 
                this.networkRequestType = val;
            }
            
            public QuickFix.Fields.NetworkRequestType get(QuickFix.Fields.NetworkRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NetworkRequestType val) 
            { 
                return isSetNetworkRequestType();
            }
            
            public bool isSetNetworkRequestType() 
            { 
                return isSetField(Tags.NetworkRequestType);
            }
            public QuickFix.Fields.NetworkRequestID networkRequestID
            { 
                get 
                {
                    QuickFix.Fields.NetworkRequestID val = new QuickFix.Fields.NetworkRequestID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NetworkRequestID val) 
            { 
                this.networkRequestID = val;
            }
            
            public QuickFix.Fields.NetworkRequestID get(QuickFix.Fields.NetworkRequestID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NetworkRequestID val) 
            { 
                return isSetNetworkRequestID();
            }
            
            public bool isSetNetworkRequestID() 
            { 
                return isSetField(Tags.NetworkRequestID);
            }
            public QuickFix.Fields.NoCompIDs noCompIDs
            { 
                get 
                {
                    QuickFix.Fields.NoCompIDs val = new QuickFix.Fields.NoCompIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoCompIDs val) 
            { 
                this.noCompIDs = val;
            }
            
            public QuickFix.Fields.NoCompIDs get(QuickFix.Fields.NoCompIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoCompIDs val) 
            { 
                return isSetNoCompIDs();
            }
            
            public bool isSetNoCompIDs() 
            { 
                return isSetField(Tags.NoCompIDs);
            }
            public class NoCompIDs : Group
            {
                public NoCompIDs() 
                  :base( Tags.NoCompIDs, Tags.RefCompID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, 0};
                            public QuickFix.Fields.RefCompID refCompID
                { 
                    get 
                    {
                        QuickFix.Fields.RefCompID val = new QuickFix.Fields.RefCompID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RefCompID val) 
                { 
                    this.refCompID = val;
                }
                
                public QuickFix.Fields.RefCompID get(QuickFix.Fields.RefCompID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RefCompID val) 
                { 
                    return isSetRefCompID();
                }
                
                public bool isSetRefCompID() 
                { 
                    return isSetField(Tags.RefCompID);
                }
                public QuickFix.Fields.RefSubID refSubID
                { 
                    get 
                    {
                        QuickFix.Fields.RefSubID val = new QuickFix.Fields.RefSubID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RefSubID val) 
                { 
                    this.refSubID = val;
                }
                
                public QuickFix.Fields.RefSubID get(QuickFix.Fields.RefSubID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RefSubID val) 
                { 
                    return isSetRefSubID();
                }
                
                public bool isSetRefSubID() 
                { 
                    return isSetField(Tags.RefSubID);
                }
                public QuickFix.Fields.LocationID locationID
                { 
                    get 
                    {
                        QuickFix.Fields.LocationID val = new QuickFix.Fields.LocationID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LocationID val) 
                { 
                    this.locationID = val;
                }
                
                public QuickFix.Fields.LocationID get(QuickFix.Fields.LocationID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LocationID val) 
                { 
                    return isSetLocationID();
                }
                
                public bool isSetLocationID() 
                { 
                    return isSetField(Tags.LocationID);
                }
                public QuickFix.Fields.DeskID deskID
                { 
                    get 
                    {
                        QuickFix.Fields.DeskID val = new QuickFix.Fields.DeskID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DeskID val) 
                { 
                    this.deskID = val;
                }
                
                public QuickFix.Fields.DeskID get(QuickFix.Fields.DeskID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DeskID val) 
                { 
                    return isSetDeskID();
                }
                
                public bool isSetDeskID() 
                { 
                    return isSetField(Tags.DeskID);
                }
            
            }
        }
    }
}
