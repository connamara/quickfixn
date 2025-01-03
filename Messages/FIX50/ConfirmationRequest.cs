// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50;

public class ConfirmationRequest : Message
{
    public const string MsgType = "BH";

    public ConfirmationRequest() : base()
    {
        Header.SetField(new MsgType("BH"));
    }

    public ConfirmationRequest(
            ConfirmReqID aConfirmReqID,
            ConfirmType aConfirmType,
            TransactTime aTransactTime
        ) : this()
    {
        ConfirmReqID = aConfirmReqID;
        ConfirmType = aConfirmType;
        TransactTime = aTransactTime;
    }

    public ConfirmReqID ConfirmReqID
    {
        get
        {
            ConfirmReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConfirmReqID val) { ConfirmReqID = val; }
    public ConfirmReqID Get(ConfirmReqID val) { GetField(val); return val; }
    public bool IsSet(ConfirmReqID val) { return IsSetConfirmReqID(); }
    public bool IsSetConfirmReqID() { return IsSetField(Tags.ConfirmReqID); }

    public ConfirmType ConfirmType
    {
        get
        {
            ConfirmType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConfirmType val) { ConfirmType = val; }
    public ConfirmType Get(ConfirmType val) { GetField(val); return val; }
    public bool IsSet(ConfirmType val) { return IsSetConfirmType(); }
    public bool IsSetConfirmType() { return IsSetField(Tags.ConfirmType); }

    public NoOrders NoOrders
    {
        get
        {
            NoOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoOrders val) { NoOrders = val; }
    public NoOrders Get(NoOrders val) { GetField(val); return val; }
    public bool IsSet(NoOrders val) { return IsSetNoOrders(); }
    public bool IsSetNoOrders() { return IsSetField(Tags.NoOrders); }

    public AllocID AllocID
    {
        get
        {
            AllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocID val) { AllocID = val; }
    public AllocID Get(AllocID val) { GetField(val); return val; }
    public bool IsSet(AllocID val) { return IsSetAllocID(); }
    public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

    public SecondaryAllocID SecondaryAllocID
    {
        get
        {
            SecondaryAllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryAllocID val) { SecondaryAllocID = val; }
    public SecondaryAllocID Get(SecondaryAllocID val) { GetField(val); return val; }
    public bool IsSet(SecondaryAllocID val) { return IsSetSecondaryAllocID(); }
    public bool IsSetSecondaryAllocID() { return IsSetField(Tags.SecondaryAllocID); }

    public IndividualAllocID IndividualAllocID
    {
        get
        {
            IndividualAllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IndividualAllocID val) { IndividualAllocID = val; }
    public IndividualAllocID Get(IndividualAllocID val) { GetField(val); return val; }
    public bool IsSet(IndividualAllocID val) { return IsSetIndividualAllocID(); }
    public bool IsSetIndividualAllocID() { return IsSetField(Tags.IndividualAllocID); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public AllocAccount AllocAccount
    {
        get
        {
            AllocAccount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocAccount val) { AllocAccount = val; }
    public AllocAccount Get(AllocAccount val) { GetField(val); return val; }
    public bool IsSet(AllocAccount val) { return IsSetAllocAccount(); }
    public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }

    public AllocAcctIDSource AllocAcctIDSource
    {
        get
        {
            AllocAcctIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocAcctIDSource val) { AllocAcctIDSource = val; }
    public AllocAcctIDSource Get(AllocAcctIDSource val) { GetField(val); return val; }
    public bool IsSet(AllocAcctIDSource val) { return IsSetAllocAcctIDSource(); }
    public bool IsSetAllocAcctIDSource() { return IsSetField(Tags.AllocAcctIDSource); }

    public AllocAccountType AllocAccountType
    {
        get
        {
            AllocAccountType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocAccountType val) { AllocAccountType = val; }
    public AllocAccountType Get(AllocAccountType val) { GetField(val); return val; }
    public bool IsSet(AllocAccountType val) { return IsSetAllocAccountType(); }
    public bool IsSetAllocAccountType() { return IsSetField(Tags.AllocAccountType); }

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

    public class NoOrdersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoNested2PartyIDs, Tags.OrderQty, Tags.OrderAvgPx, Tags.OrderBookingQty, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoNested2PartyIDs, Tags.OrderQty, Tags.OrderAvgPx, Tags.OrderBookingQty, 0};

        public NoOrdersGroup()
          : base(Tags.NoOrders, Tags.ClOrdID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoOrdersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ClOrdID ClOrdID
        {
            get
            {
                ClOrdID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClOrdID val) { ClOrdID = val; }
        public ClOrdID Get(ClOrdID val) { GetField(val); return val; }
        public bool IsSet(ClOrdID val) { return IsSetClOrdID(); }
        public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

        public OrderID OrderID
        {
            get
            {
                OrderID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderID val) { OrderID = val; }
        public OrderID Get(OrderID val) { GetField(val); return val; }
        public bool IsSet(OrderID val) { return IsSetOrderID(); }
        public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

        public SecondaryOrderID SecondaryOrderID
        {
            get
            {
                SecondaryOrderID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryOrderID val) { SecondaryOrderID = val; }
        public SecondaryOrderID Get(SecondaryOrderID val) { GetField(val); return val; }
        public bool IsSet(SecondaryOrderID val) { return IsSetSecondaryOrderID(); }
        public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }

        public SecondaryClOrdID SecondaryClOrdID
        {
            get
            {
                SecondaryClOrdID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryClOrdID val) { SecondaryClOrdID = val; }
        public SecondaryClOrdID Get(SecondaryClOrdID val) { GetField(val); return val; }
        public bool IsSet(SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }
        public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

        public ListID ListID
        {
            get
            {
                ListID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ListID val) { ListID = val; }
        public ListID Get(ListID val) { GetField(val); return val; }
        public bool IsSet(ListID val) { return IsSetListID(); }
        public bool IsSetListID() { return IsSetField(Tags.ListID); }

        public NoNested2PartyIDs NoNested2PartyIDs
        {
            get
            {
                NoNested2PartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNested2PartyIDs val) { NoNested2PartyIDs = val; }
        public NoNested2PartyIDs Get(NoNested2PartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNested2PartyIDs val) { return IsSetNoNested2PartyIDs(); }
        public bool IsSetNoNested2PartyIDs() { return IsSetField(Tags.NoNested2PartyIDs); }

        public OrderQty OrderQty
        {
            get
            {
                OrderQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderQty val) { OrderQty = val; }
        public OrderQty Get(OrderQty val) { GetField(val); return val; }
        public bool IsSet(OrderQty val) { return IsSetOrderQty(); }
        public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }

        public OrderAvgPx OrderAvgPx
        {
            get
            {
                OrderAvgPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderAvgPx val) { OrderAvgPx = val; }
        public OrderAvgPx Get(OrderAvgPx val) { GetField(val); return val; }
        public bool IsSet(OrderAvgPx val) { return IsSetOrderAvgPx(); }
        public bool IsSetOrderAvgPx() { return IsSetField(Tags.OrderAvgPx); }

        public OrderBookingQty OrderBookingQty
        {
            get
            {
                OrderBookingQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderBookingQty val) { OrderBookingQty = val; }
        public OrderBookingQty Get(OrderBookingQty val) { GetField(val); return val; }
        public bool IsSet(OrderBookingQty val) { return IsSetOrderBookingQty(); }
        public bool IsSetOrderBookingQty() { return IsSetField(Tags.OrderBookingQty); }

        public class NoNested2PartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};

            public NoNested2PartyIDsGroup()
              : base(Tags.NoNested2PartyIDs, Tags.Nested2PartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNested2PartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public Nested2PartyID Nested2PartyID
            {
                get
                {
                    Nested2PartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested2PartyID val) { Nested2PartyID = val; }
            public Nested2PartyID Get(Nested2PartyID val) { GetField(val); return val; }
            public bool IsSet(Nested2PartyID val) { return IsSetNested2PartyID(); }
            public bool IsSetNested2PartyID() { return IsSetField(Tags.Nested2PartyID); }

            public Nested2PartyIDSource Nested2PartyIDSource
            {
                get
                {
                    Nested2PartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested2PartyIDSource val) { Nested2PartyIDSource = val; }
            public Nested2PartyIDSource Get(Nested2PartyIDSource val) { GetField(val); return val; }
            public bool IsSet(Nested2PartyIDSource val) { return IsSetNested2PartyIDSource(); }
            public bool IsSetNested2PartyIDSource() { return IsSetField(Tags.Nested2PartyIDSource); }

            public Nested2PartyRole Nested2PartyRole
            {
                get
                {
                    Nested2PartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested2PartyRole val) { Nested2PartyRole = val; }
            public Nested2PartyRole Get(Nested2PartyRole val) { GetField(val); return val; }
            public bool IsSet(Nested2PartyRole val) { return IsSetNested2PartyRole(); }
            public bool IsSetNested2PartyRole() { return IsSetField(Tags.Nested2PartyRole); }

            public NoNested2PartySubIDs NoNested2PartySubIDs
            {
                get
                {
                    NoNested2PartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNested2PartySubIDs val) { NoNested2PartySubIDs = val; }
            public NoNested2PartySubIDs Get(NoNested2PartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNested2PartySubIDs val) { return IsSetNoNested2PartySubIDs(); }
            public bool IsSetNoNested2PartySubIDs() { return IsSetField(Tags.NoNested2PartySubIDs); }

            public class NoNested2PartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};

                public NoNested2PartySubIDsGroup()
                  : base(Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNested2PartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public Nested2PartySubID Nested2PartySubID
                {
                    get
                    {
                        Nested2PartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested2PartySubID val) { Nested2PartySubID = val; }
                public Nested2PartySubID Get(Nested2PartySubID val) { GetField(val); return val; }
                public bool IsSet(Nested2PartySubID val) { return IsSetNested2PartySubID(); }
                public bool IsSetNested2PartySubID() { return IsSetField(Tags.Nested2PartySubID); }

                public Nested2PartySubIDType Nested2PartySubIDType
                {
                    get
                    {
                        Nested2PartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested2PartySubIDType val) { Nested2PartySubIDType = val; }
                public Nested2PartySubIDType Get(Nested2PartySubIDType val) { GetField(val); return val; }
                public bool IsSet(Nested2PartySubIDType val) { return IsSetNested2PartySubIDType(); }
                public bool IsSetNested2PartySubIDType() { return IsSetField(Tags.Nested2PartySubIDType); }
            }
        }
    }
}
