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
                this.Header.SetField(new QuickFix.Fields.MsgType("BC"));
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
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetworkRequestType val) 
            { 
                this.networkRequestType = val;
            }
            
            public QuickFix.Fields.NetworkRequestType Get(QuickFix.Fields.NetworkRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetworkRequestType val) 
            { 
                return IsSetNetworkRequestType();
            }
            
            public bool IsSetNetworkRequestType() 
            { 
                return IsSetField(Tags.NetworkRequestType);
            }
            public QuickFix.Fields.NetworkRequestID networkRequestID
            { 
                get 
                {
                    QuickFix.Fields.NetworkRequestID val = new QuickFix.Fields.NetworkRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetworkRequestID val) 
            { 
                this.networkRequestID = val;
            }
            
            public QuickFix.Fields.NetworkRequestID Get(QuickFix.Fields.NetworkRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetworkRequestID val) 
            { 
                return IsSetNetworkRequestID();
            }
            
            public bool IsSetNetworkRequestID() 
            { 
                return IsSetField(Tags.NetworkRequestID);
            }
            public QuickFix.Fields.NoCompIDs noCompIDs
            { 
                get 
                {
                    QuickFix.Fields.NoCompIDs val = new QuickFix.Fields.NoCompIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoCompIDs val) 
            { 
                this.noCompIDs = val;
            }
            
            public QuickFix.Fields.NoCompIDs Get(QuickFix.Fields.NoCompIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoCompIDs val) 
            { 
                return IsSetNoCompIDs();
            }
            
            public bool IsSetNoCompIDs() 
            { 
                return IsSetField(Tags.NoCompIDs);
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
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefCompID val) 
                { 
                    this.refCompID = val;
                }
                
                public QuickFix.Fields.RefCompID Get(QuickFix.Fields.RefCompID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefCompID val) 
                { 
                    return IsSetRefCompID();
                }
                
                public bool IsSetRefCompID() 
                { 
                    return IsSetField(Tags.RefCompID);
                }
                public QuickFix.Fields.RefSubID refSubID
                { 
                    get 
                    {
                        QuickFix.Fields.RefSubID val = new QuickFix.Fields.RefSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefSubID val) 
                { 
                    this.refSubID = val;
                }
                
                public QuickFix.Fields.RefSubID Get(QuickFix.Fields.RefSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefSubID val) 
                { 
                    return IsSetRefSubID();
                }
                
                public bool IsSetRefSubID() 
                { 
                    return IsSetField(Tags.RefSubID);
                }
                public QuickFix.Fields.LocationID locationID
                { 
                    get 
                    {
                        QuickFix.Fields.LocationID val = new QuickFix.Fields.LocationID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LocationID val) 
                { 
                    this.locationID = val;
                }
                
                public QuickFix.Fields.LocationID Get(QuickFix.Fields.LocationID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LocationID val) 
                { 
                    return IsSetLocationID();
                }
                
                public bool IsSetLocationID() 
                { 
                    return IsSetField(Tags.LocationID);
                }
                public QuickFix.Fields.DeskID deskID
                { 
                    get 
                    {
                        QuickFix.Fields.DeskID val = new QuickFix.Fields.DeskID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeskID val) 
                { 
                    this.deskID = val;
                }
                
                public QuickFix.Fields.DeskID Get(QuickFix.Fields.DeskID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeskID val) 
                { 
                    return IsSetDeskID();
                }
                
                public bool IsSetDeskID() 
                { 
                    return IsSetField(Tags.DeskID);
                }
            
            }
        }
    }
}
