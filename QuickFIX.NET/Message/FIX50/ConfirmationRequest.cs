using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class ConfirmationRequest : Message
        {
            public ConfirmationRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BH"));
            }

            public ConfirmationRequest(
                    QuickFix.Fields.ConfirmReqID aConfirmReqID,
                    QuickFix.Fields.ConfirmType aConfirmType,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.confirmReqID = aConfirmReqID;
                this.confirmType = aConfirmType;
                this.transactTime = aTransactTime;
            }

            public QuickFix.Fields.ConfirmReqID confirmReqID
            { 
                get 
                {
                    QuickFix.Fields.ConfirmReqID val = new QuickFix.Fields.ConfirmReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ConfirmReqID val) 
            { 
                this.confirmReqID = val;
            }
            
            public QuickFix.Fields.ConfirmReqID get(QuickFix.Fields.ConfirmReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ConfirmReqID val) 
            { 
                return isSetConfirmReqID();
            }
            
            public bool isSetConfirmReqID() 
            { 
                return isSetField(Tags.ConfirmReqID);
            }
            public QuickFix.Fields.ConfirmType confirmType
            { 
                get 
                {
                    QuickFix.Fields.ConfirmType val = new QuickFix.Fields.ConfirmType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ConfirmType val) 
            { 
                this.confirmType = val;
            }
            
            public QuickFix.Fields.ConfirmType get(QuickFix.Fields.ConfirmType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ConfirmType val) 
            { 
                return isSetConfirmType();
            }
            
            public bool isSetConfirmType() 
            { 
                return isSetField(Tags.ConfirmType);
            }
            public QuickFix.Fields.NoOrders noOrders
            { 
                get 
                {
                    QuickFix.Fields.NoOrders val = new QuickFix.Fields.NoOrders();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoOrders val) 
            { 
                this.noOrders = val;
            }
            
            public QuickFix.Fields.NoOrders get(QuickFix.Fields.NoOrders val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoOrders val) 
            { 
                return isSetNoOrders();
            }
            
            public bool isSetNoOrders() 
            { 
                return isSetField(Tags.NoOrders);
            }
            public QuickFix.Fields.AllocID allocID
            { 
                get 
                {
                    QuickFix.Fields.AllocID val = new QuickFix.Fields.AllocID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocID val) 
            { 
                this.allocID = val;
            }
            
            public QuickFix.Fields.AllocID get(QuickFix.Fields.AllocID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocID val) 
            { 
                return isSetAllocID();
            }
            
            public bool isSetAllocID() 
            { 
                return isSetField(Tags.AllocID);
            }
            public QuickFix.Fields.SecondaryAllocID secondaryAllocID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryAllocID val = new QuickFix.Fields.SecondaryAllocID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryAllocID val) 
            { 
                this.secondaryAllocID = val;
            }
            
            public QuickFix.Fields.SecondaryAllocID get(QuickFix.Fields.SecondaryAllocID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryAllocID val) 
            { 
                return isSetSecondaryAllocID();
            }
            
            public bool isSetSecondaryAllocID() 
            { 
                return isSetField(Tags.SecondaryAllocID);
            }
            public QuickFix.Fields.IndividualAllocID individualAllocID
            { 
                get 
                {
                    QuickFix.Fields.IndividualAllocID val = new QuickFix.Fields.IndividualAllocID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IndividualAllocID val) 
            { 
                this.individualAllocID = val;
            }
            
            public QuickFix.Fields.IndividualAllocID get(QuickFix.Fields.IndividualAllocID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IndividualAllocID val) 
            { 
                return isSetIndividualAllocID();
            }
            
            public bool isSetIndividualAllocID() 
            { 
                return isSetField(Tags.IndividualAllocID);
            }
            public QuickFix.Fields.TransactTime transactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TransactTime val) 
            { 
                this.transactTime = val;
            }
            
            public QuickFix.Fields.TransactTime get(QuickFix.Fields.TransactTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TransactTime val) 
            { 
                return isSetTransactTime();
            }
            
            public bool isSetTransactTime() 
            { 
                return isSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.AllocAccount allocAccount
            { 
                get 
                {
                    QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocAccount val) 
            { 
                this.allocAccount = val;
            }
            
            public QuickFix.Fields.AllocAccount get(QuickFix.Fields.AllocAccount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocAccount val) 
            { 
                return isSetAllocAccount();
            }
            
            public bool isSetAllocAccount() 
            { 
                return isSetField(Tags.AllocAccount);
            }
            public QuickFix.Fields.AllocAcctIDSource allocAcctIDSource
            { 
                get 
                {
                    QuickFix.Fields.AllocAcctIDSource val = new QuickFix.Fields.AllocAcctIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                this.allocAcctIDSource = val;
            }
            
            public QuickFix.Fields.AllocAcctIDSource get(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                return isSetAllocAcctIDSource();
            }
            
            public bool isSetAllocAcctIDSource() 
            { 
                return isSetField(Tags.AllocAcctIDSource);
            }
            public QuickFix.Fields.AllocAccountType allocAccountType
            { 
                get 
                {
                    QuickFix.Fields.AllocAccountType val = new QuickFix.Fields.AllocAccountType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocAccountType val) 
            { 
                this.allocAccountType = val;
            }
            
            public QuickFix.Fields.AllocAccountType get(QuickFix.Fields.AllocAccountType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocAccountType val) 
            { 
                return isSetAllocAccountType();
            }
            
            public bool isSetAllocAccountType() 
            { 
                return isSetField(Tags.AllocAccountType);
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
            public class NoOrders : Group
            {
                public NoOrders() 
                  :base( Tags.NoOrders, Tags.ClOrdID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoNested2PartyIDs, Tags.OrderQty, Tags.OrderAvgPx, Tags.OrderBookingQty, 0};
                            public QuickFix.Fields.ClOrdID clOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ClOrdID val) 
                { 
                    this.clOrdID = val;
                }
                
                public QuickFix.Fields.ClOrdID get(QuickFix.Fields.ClOrdID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ClOrdID val) 
                { 
                    return isSetClOrdID();
                }
                
                public bool isSetClOrdID() 
                { 
                    return isSetField(Tags.ClOrdID);
                }
                public QuickFix.Fields.OrderID orderID
                { 
                    get 
                    {
                        QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderID val) 
                { 
                    this.orderID = val;
                }
                
                public QuickFix.Fields.OrderID get(QuickFix.Fields.OrderID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderID val) 
                { 
                    return isSetOrderID();
                }
                
                public bool isSetOrderID() 
                { 
                    return isSetField(Tags.OrderID);
                }
                public QuickFix.Fields.SecondaryOrderID secondaryOrderID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryOrderID val = new QuickFix.Fields.SecondaryOrderID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    this.secondaryOrderID = val;
                }
                
                public QuickFix.Fields.SecondaryOrderID get(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    return isSetSecondaryOrderID();
                }
                
                public bool isSetSecondaryOrderID() 
                { 
                    return isSetField(Tags.SecondaryOrderID);
                }
                public QuickFix.Fields.SecondaryClOrdID secondaryClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    this.secondaryClOrdID = val;
                }
                
                public QuickFix.Fields.SecondaryClOrdID get(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    return isSetSecondaryClOrdID();
                }
                
                public bool isSetSecondaryClOrdID() 
                { 
                    return isSetField(Tags.SecondaryClOrdID);
                }
                public QuickFix.Fields.ListID listID
                { 
                    get 
                    {
                        QuickFix.Fields.ListID val = new QuickFix.Fields.ListID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ListID val) 
                { 
                    this.listID = val;
                }
                
                public QuickFix.Fields.ListID get(QuickFix.Fields.ListID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ListID val) 
                { 
                    return isSetListID();
                }
                
                public bool isSetListID() 
                { 
                    return isSetField(Tags.ListID);
                }
                public QuickFix.Fields.NoNested2PartyIDs noNested2PartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNested2PartyIDs val = new QuickFix.Fields.NoNested2PartyIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    this.noNested2PartyIDs = val;
                }
                
                public QuickFix.Fields.NoNested2PartyIDs get(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    return isSetNoNested2PartyIDs();
                }
                
                public bool isSetNoNested2PartyIDs() 
                { 
                    return isSetField(Tags.NoNested2PartyIDs);
                }
                public QuickFix.Fields.OrderQty orderQty
                { 
                    get 
                    {
                        QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderQty val) 
                { 
                    this.orderQty = val;
                }
                
                public QuickFix.Fields.OrderQty get(QuickFix.Fields.OrderQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderQty val) 
                { 
                    return isSetOrderQty();
                }
                
                public bool isSetOrderQty() 
                { 
                    return isSetField(Tags.OrderQty);
                }
                public QuickFix.Fields.OrderAvgPx orderAvgPx
                { 
                    get 
                    {
                        QuickFix.Fields.OrderAvgPx val = new QuickFix.Fields.OrderAvgPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderAvgPx val) 
                { 
                    this.orderAvgPx = val;
                }
                
                public QuickFix.Fields.OrderAvgPx get(QuickFix.Fields.OrderAvgPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderAvgPx val) 
                { 
                    return isSetOrderAvgPx();
                }
                
                public bool isSetOrderAvgPx() 
                { 
                    return isSetField(Tags.OrderAvgPx);
                }
                public QuickFix.Fields.OrderBookingQty orderBookingQty
                { 
                    get 
                    {
                        QuickFix.Fields.OrderBookingQty val = new QuickFix.Fields.OrderBookingQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderBookingQty val) 
                { 
                    this.orderBookingQty = val;
                }
                
                public QuickFix.Fields.OrderBookingQty get(QuickFix.Fields.OrderBookingQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderBookingQty val) 
                { 
                    return isSetOrderBookingQty();
                }
                
                public bool isSetOrderBookingQty() 
                { 
                    return isSetField(Tags.OrderBookingQty);
                }
                            public class NoNested2PartyIDs : Group
                {
                    public NoNested2PartyIDs() 
                      :base( Tags.NoNested2PartyIDs, Tags.Nested2PartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};
                                    public QuickFix.Fields.Nested2PartyID nested2PartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested2PartyID val = new QuickFix.Fields.Nested2PartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        this.nested2PartyID = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyID get(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        return isSetNested2PartyID();
                    }
                    
                    public bool isSetNested2PartyID() 
                    { 
                        return isSetField(Tags.Nested2PartyID);
                    }
                    public QuickFix.Fields.Nested2PartyIDSource nested2PartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested2PartyIDSource val = new QuickFix.Fields.Nested2PartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        this.nested2PartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyIDSource get(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        return isSetNested2PartyIDSource();
                    }
                    
                    public bool isSetNested2PartyIDSource() 
                    { 
                        return isSetField(Tags.Nested2PartyIDSource);
                    }
                    public QuickFix.Fields.Nested2PartyRole nested2PartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested2PartyRole val = new QuickFix.Fields.Nested2PartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        this.nested2PartyRole = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyRole get(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        return isSetNested2PartyRole();
                    }
                    
                    public bool isSetNested2PartyRole() 
                    { 
                        return isSetField(Tags.Nested2PartyRole);
                    }
                    public QuickFix.Fields.NoNested2PartySubIDs noNested2PartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNested2PartySubIDs val = new QuickFix.Fields.NoNested2PartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        this.noNested2PartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNested2PartySubIDs get(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        return isSetNoNested2PartySubIDs();
                    }
                    
                    public bool isSetNoNested2PartySubIDs() 
                    { 
                        return isSetField(Tags.NoNested2PartySubIDs);
                    }
                                    public class NoNested2PartySubIDs : Group
                    {
                        public NoNested2PartySubIDs() 
                          :base( Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};
                                            public QuickFix.Fields.Nested2PartySubID nested2PartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartySubID val = new QuickFix.Fields.Nested2PartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            this.nested2PartySubID = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartySubID get(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            return isSetNested2PartySubID();
                        }
                        
                        public bool isSetNested2PartySubID() 
                        { 
                            return isSetField(Tags.Nested2PartySubID);
                        }
                        public QuickFix.Fields.Nested2PartySubIDType nested2PartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartySubIDType val = new QuickFix.Fields.Nested2PartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            this.nested2PartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartySubIDType get(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            return isSetNested2PartySubIDType();
                        }
                        
                        public bool isSetNested2PartySubIDType() 
                        { 
                            return isSetField(Tags.Nested2PartySubIDType);
                        }
                    
                    }
                }
            }
        }
    }
}
