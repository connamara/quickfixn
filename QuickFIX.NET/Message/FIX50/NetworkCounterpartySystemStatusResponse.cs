using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class NetworkCounterpartySystemStatusResponse : Message
        {
            public NetworkCounterpartySystemStatusResponse() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BD"));
            }

            public NetworkCounterpartySystemStatusResponse(
                    QuickFix.Fields.NetworkStatusResponseType aNetworkStatusResponseType,
                    QuickFix.Fields.NetworkResponseID aNetworkResponseID
                ) : this()
            {
                this.networkStatusResponseType = aNetworkStatusResponseType;
                this.networkResponseID = aNetworkResponseID;
            }

            public QuickFix.Fields.NetworkStatusResponseType networkStatusResponseType
            { 
                get 
                {
                    QuickFix.Fields.NetworkStatusResponseType val = new QuickFix.Fields.NetworkStatusResponseType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                this.networkStatusResponseType = val;
            }
            
            public QuickFix.Fields.NetworkStatusResponseType get(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                return isSetNetworkStatusResponseType();
            }
            
            public bool isSetNetworkStatusResponseType() 
            { 
                return isSetField(Tags.NetworkStatusResponseType);
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
            public QuickFix.Fields.NetworkResponseID networkResponseID
            { 
                get 
                {
                    QuickFix.Fields.NetworkResponseID val = new QuickFix.Fields.NetworkResponseID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NetworkResponseID val) 
            { 
                this.networkResponseID = val;
            }
            
            public QuickFix.Fields.NetworkResponseID get(QuickFix.Fields.NetworkResponseID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NetworkResponseID val) 
            { 
                return isSetNetworkResponseID();
            }
            
            public bool isSetNetworkResponseID() 
            { 
                return isSetField(Tags.NetworkResponseID);
            }
            public QuickFix.Fields.LastNetworkResponseID lastNetworkResponseID
            { 
                get 
                {
                    QuickFix.Fields.LastNetworkResponseID val = new QuickFix.Fields.LastNetworkResponseID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                this.lastNetworkResponseID = val;
            }
            
            public QuickFix.Fields.LastNetworkResponseID get(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                return isSetLastNetworkResponseID();
            }
            
            public bool isSetLastNetworkResponseID() 
            { 
                return isSetField(Tags.LastNetworkResponseID);
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
                public static int[] fieldOrder = {Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, Tags.StatusValue, Tags.StatusText, 0};
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
                public QuickFix.Fields.StatusValue statusValue
                { 
                    get 
                    {
                        QuickFix.Fields.StatusValue val = new QuickFix.Fields.StatusValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StatusValue val) 
                { 
                    this.statusValue = val;
                }
                
                public QuickFix.Fields.StatusValue get(QuickFix.Fields.StatusValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StatusValue val) 
                { 
                    return isSetStatusValue();
                }
                
                public bool isSetStatusValue() 
                { 
                    return isSetField(Tags.StatusValue);
                }
                public QuickFix.Fields.StatusText statusText
                { 
                    get 
                    {
                        QuickFix.Fields.StatusText val = new QuickFix.Fields.StatusText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StatusText val) 
                { 
                    this.statusText = val;
                }
                
                public QuickFix.Fields.StatusText get(QuickFix.Fields.StatusText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StatusText val) 
                { 
                    return isSetStatusText();
                }
                
                public bool isSetStatusText() 
                { 
                    return isSetField(Tags.StatusText);
                }
            
            }
        }
    }
}
