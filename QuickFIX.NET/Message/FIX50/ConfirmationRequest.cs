// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class ConfirmationRequest : Message
        {
            public const string MsgType = "BH";

            public ConfirmationRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BH"));
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
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ConfirmReqID val) 
            { 
                this.confirmReqID = val;
            }
            
            public QuickFix.Fields.ConfirmReqID Get(QuickFix.Fields.ConfirmReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ConfirmReqID val) 
            { 
                return IsSetConfirmReqID();
            }
            
            public bool IsSetConfirmReqID() 
            { 
                return IsSetField(Tags.ConfirmReqID);
            }
            public QuickFix.Fields.ConfirmType confirmType
            { 
                get 
                {
                    QuickFix.Fields.ConfirmType val = new QuickFix.Fields.ConfirmType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ConfirmType val) 
            { 
                this.confirmType = val;
            }
            
            public QuickFix.Fields.ConfirmType Get(QuickFix.Fields.ConfirmType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ConfirmType val) 
            { 
                return IsSetConfirmType();
            }
            
            public bool IsSetConfirmType() 
            { 
                return IsSetField(Tags.ConfirmType);
            }
            public QuickFix.Fields.NoOrders noOrders
            { 
                get 
                {
                    QuickFix.Fields.NoOrders val = new QuickFix.Fields.NoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoOrders val) 
            { 
                this.noOrders = val;
            }
            
            public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoOrders val) 
            { 
                return IsSetNoOrders();
            }
            
            public bool IsSetNoOrders() 
            { 
                return IsSetField(Tags.NoOrders);
            }
            public QuickFix.Fields.AllocID allocID
            { 
                get 
                {
                    QuickFix.Fields.AllocID val = new QuickFix.Fields.AllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocID val) 
            { 
                this.allocID = val;
            }
            
            public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocID val) 
            { 
                return IsSetAllocID();
            }
            
            public bool IsSetAllocID() 
            { 
                return IsSetField(Tags.AllocID);
            }
            public QuickFix.Fields.SecondaryAllocID secondaryAllocID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryAllocID val = new QuickFix.Fields.SecondaryAllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryAllocID val) 
            { 
                this.secondaryAllocID = val;
            }
            
            public QuickFix.Fields.SecondaryAllocID Get(QuickFix.Fields.SecondaryAllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryAllocID val) 
            { 
                return IsSetSecondaryAllocID();
            }
            
            public bool IsSetSecondaryAllocID() 
            { 
                return IsSetField(Tags.SecondaryAllocID);
            }
            public QuickFix.Fields.IndividualAllocID individualAllocID
            { 
                get 
                {
                    QuickFix.Fields.IndividualAllocID val = new QuickFix.Fields.IndividualAllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IndividualAllocID val) 
            { 
                this.individualAllocID = val;
            }
            
            public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IndividualAllocID val) 
            { 
                return IsSetIndividualAllocID();
            }
            
            public bool IsSetIndividualAllocID() 
            { 
                return IsSetField(Tags.IndividualAllocID);
            }
            public QuickFix.Fields.TransactTime transactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                this.transactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.AllocAccount allocAccount
            { 
                get 
                {
                    QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocAccount val) 
            { 
                this.allocAccount = val;
            }
            
            public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocAccount val) 
            { 
                return IsSetAllocAccount();
            }
            
            public bool IsSetAllocAccount() 
            { 
                return IsSetField(Tags.AllocAccount);
            }
            public QuickFix.Fields.AllocAcctIDSource allocAcctIDSource
            { 
                get 
                {
                    QuickFix.Fields.AllocAcctIDSource val = new QuickFix.Fields.AllocAcctIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                this.allocAcctIDSource = val;
            }
            
            public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                return IsSetAllocAcctIDSource();
            }
            
            public bool IsSetAllocAcctIDSource() 
            { 
                return IsSetField(Tags.AllocAcctIDSource);
            }
            public QuickFix.Fields.AllocAccountType allocAccountType
            { 
                get 
                {
                    QuickFix.Fields.AllocAccountType val = new QuickFix.Fields.AllocAccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocAccountType val) 
            { 
                this.allocAccountType = val;
            }
            
            public QuickFix.Fields.AllocAccountType Get(QuickFix.Fields.AllocAccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocAccountType val) 
            { 
                return IsSetAllocAccountType();
            }
            
            public bool IsSetAllocAccountType() 
            { 
                return IsSetField(Tags.AllocAccountType);
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
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClOrdID val) 
                { 
                    this.clOrdID = val;
                }
                
                public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClOrdID val) 
                { 
                    return IsSetClOrdID();
                }
                
                public bool IsSetClOrdID() 
                { 
                    return IsSetField(Tags.ClOrdID);
                }
                public QuickFix.Fields.OrderID orderID
                { 
                    get 
                    {
                        QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderID val) 
                { 
                    this.orderID = val;
                }
                
                public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderID val) 
                { 
                    return IsSetOrderID();
                }
                
                public bool IsSetOrderID() 
                { 
                    return IsSetField(Tags.OrderID);
                }
                public QuickFix.Fields.SecondaryOrderID secondaryOrderID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryOrderID val = new QuickFix.Fields.SecondaryOrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    this.secondaryOrderID = val;
                }
                
                public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    return IsSetSecondaryOrderID();
                }
                
                public bool IsSetSecondaryOrderID() 
                { 
                    return IsSetField(Tags.SecondaryOrderID);
                }
                public QuickFix.Fields.SecondaryClOrdID secondaryClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    this.secondaryClOrdID = val;
                }
                
                public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    return IsSetSecondaryClOrdID();
                }
                
                public bool IsSetSecondaryClOrdID() 
                { 
                    return IsSetField(Tags.SecondaryClOrdID);
                }
                public QuickFix.Fields.ListID listID
                { 
                    get 
                    {
                        QuickFix.Fields.ListID val = new QuickFix.Fields.ListID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ListID val) 
                { 
                    this.listID = val;
                }
                
                public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ListID val) 
                { 
                    return IsSetListID();
                }
                
                public bool IsSetListID() 
                { 
                    return IsSetField(Tags.ListID);
                }
                public QuickFix.Fields.NoNested2PartyIDs noNested2PartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNested2PartyIDs val = new QuickFix.Fields.NoNested2PartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    this.noNested2PartyIDs = val;
                }
                
                public QuickFix.Fields.NoNested2PartyIDs Get(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    return IsSetNoNested2PartyIDs();
                }
                
                public bool IsSetNoNested2PartyIDs() 
                { 
                    return IsSetField(Tags.NoNested2PartyIDs);
                }
                public QuickFix.Fields.OrderQty orderQty
                { 
                    get 
                    {
                        QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderQty val) 
                { 
                    this.orderQty = val;
                }
                
                public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderQty val) 
                { 
                    return IsSetOrderQty();
                }
                
                public bool IsSetOrderQty() 
                { 
                    return IsSetField(Tags.OrderQty);
                }
                public QuickFix.Fields.OrderAvgPx orderAvgPx
                { 
                    get 
                    {
                        QuickFix.Fields.OrderAvgPx val = new QuickFix.Fields.OrderAvgPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderAvgPx val) 
                { 
                    this.orderAvgPx = val;
                }
                
                public QuickFix.Fields.OrderAvgPx Get(QuickFix.Fields.OrderAvgPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderAvgPx val) 
                { 
                    return IsSetOrderAvgPx();
                }
                
                public bool IsSetOrderAvgPx() 
                { 
                    return IsSetField(Tags.OrderAvgPx);
                }
                public QuickFix.Fields.OrderBookingQty orderBookingQty
                { 
                    get 
                    {
                        QuickFix.Fields.OrderBookingQty val = new QuickFix.Fields.OrderBookingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderBookingQty val) 
                { 
                    this.orderBookingQty = val;
                }
                
                public QuickFix.Fields.OrderBookingQty Get(QuickFix.Fields.OrderBookingQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderBookingQty val) 
                { 
                    return IsSetOrderBookingQty();
                }
                
                public bool IsSetOrderBookingQty() 
                { 
                    return IsSetField(Tags.OrderBookingQty);
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
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        this.nested2PartyID = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyID Get(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        return IsSetNested2PartyID();
                    }
                    
                    public bool IsSetNested2PartyID() 
                    { 
                        return IsSetField(Tags.Nested2PartyID);
                    }
                    public QuickFix.Fields.Nested2PartyIDSource nested2PartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested2PartyIDSource val = new QuickFix.Fields.Nested2PartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        this.nested2PartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyIDSource Get(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        return IsSetNested2PartyIDSource();
                    }
                    
                    public bool IsSetNested2PartyIDSource() 
                    { 
                        return IsSetField(Tags.Nested2PartyIDSource);
                    }
                    public QuickFix.Fields.Nested2PartyRole nested2PartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested2PartyRole val = new QuickFix.Fields.Nested2PartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        this.nested2PartyRole = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyRole Get(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        return IsSetNested2PartyRole();
                    }
                    
                    public bool IsSetNested2PartyRole() 
                    { 
                        return IsSetField(Tags.Nested2PartyRole);
                    }
                    public QuickFix.Fields.NoNested2PartySubIDs noNested2PartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNested2PartySubIDs val = new QuickFix.Fields.NoNested2PartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        this.noNested2PartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNested2PartySubIDs Get(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        return IsSetNoNested2PartySubIDs();
                    }
                    
                    public bool IsSetNoNested2PartySubIDs() 
                    { 
                        return IsSetField(Tags.NoNested2PartySubIDs);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            this.nested2PartySubID = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartySubID Get(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            return IsSetNested2PartySubID();
                        }
                        
                        public bool IsSetNested2PartySubID() 
                        { 
                            return IsSetField(Tags.Nested2PartySubID);
                        }
                        public QuickFix.Fields.Nested2PartySubIDType nested2PartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartySubIDType val = new QuickFix.Fields.Nested2PartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            this.nested2PartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartySubIDType Get(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            return IsSetNested2PartySubIDType();
                        }
                        
                        public bool IsSetNested2PartySubIDType() 
                        { 
                            return IsSetField(Tags.Nested2PartySubIDType);
                        }
                    
                    }
                }
            }
        }
    }
}
