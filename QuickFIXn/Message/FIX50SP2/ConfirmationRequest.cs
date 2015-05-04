using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class ConfirmationRequest : Message
    {
        public const string MsgType = "BH";

        public ConfirmationRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public ConfirmationRequest(QuickFix.Fields.ConfirmReqID aConfirmReqID,
				QuickFix.Fields.ConfirmType aConfirmType,
				QuickFix.Fields.TransactTime aTransactTime)
               : this()
        {
            this.ConfirmReqID = aConfirmReqID;
			this.ConfirmType = aConfirmType;
			this.TransactTime = aTransactTime;
        }

        public QuickFix.Fields.ConfirmReqID ConfirmReqID
        {
            get
            {
                var val = new QuickFix.Fields.ConfirmReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ConfirmReqID val) { this.ConfirmReqID = val; }

        public QuickFix.Fields.ConfirmReqID Get(QuickFix.Fields.ConfirmReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ConfirmReqID val) { return IsSetConfirmReqID(); }

        public bool IsSetConfirmReqID() { return IsSetField(Tags.ConfirmReqID); }

        public QuickFix.Fields.ConfirmType ConfirmType
        {
            get
            {
                var val = new QuickFix.Fields.ConfirmType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ConfirmType val) { this.ConfirmType = val; }

        public QuickFix.Fields.ConfirmType Get(QuickFix.Fields.ConfirmType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ConfirmType val) { return IsSetConfirmType(); }

        public bool IsSetConfirmType() { return IsSetField(Tags.ConfirmType); }

        public QuickFix.Fields.NoOrders NoOrders
        {
            get
            {
                var val = new QuickFix.Fields.NoOrders();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoOrders val) { this.NoOrders = val; }

        public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoOrders val) { return IsSetNoOrders(); }

        public bool IsSetNoOrders() { return IsSetField(Tags.NoOrders); }

        public QuickFix.Fields.AllocID AllocID
        {
            get
            {
                var val = new QuickFix.Fields.AllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocID val) { this.AllocID = val; }

        public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocID val) { return IsSetAllocID(); }

        public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

        public QuickFix.Fields.SecondaryAllocID SecondaryAllocID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryAllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryAllocID val) { this.SecondaryAllocID = val; }

        public QuickFix.Fields.SecondaryAllocID Get(QuickFix.Fields.SecondaryAllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryAllocID val) { return IsSetSecondaryAllocID(); }

        public bool IsSetSecondaryAllocID() { return IsSetField(Tags.SecondaryAllocID); }

        public QuickFix.Fields.IndividualAllocID IndividualAllocID
        {
            get
            {
                var val = new QuickFix.Fields.IndividualAllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IndividualAllocID val) { this.IndividualAllocID = val; }

        public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IndividualAllocID val) { return IsSetIndividualAllocID(); }

        public bool IsSetIndividualAllocID() { return IsSetField(Tags.IndividualAllocID); }

        public QuickFix.Fields.TransactTime TransactTime
        {
            get
            {
                var val = new QuickFix.Fields.TransactTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TransactTime val) { this.TransactTime = val; }

        public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TransactTime val) { return IsSetTransactTime(); }

        public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

        public QuickFix.Fields.AllocAccount AllocAccount
        {
            get
            {
                var val = new QuickFix.Fields.AllocAccount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocAccount val) { this.AllocAccount = val; }

        public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocAccount val) { return IsSetAllocAccount(); }

        public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }

        public QuickFix.Fields.AllocAcctIDSource AllocAcctIDSource
        {
            get
            {
                var val = new QuickFix.Fields.AllocAcctIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocAcctIDSource val) { this.AllocAcctIDSource = val; }

        public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) { return IsSetAllocAcctIDSource(); }

        public bool IsSetAllocAcctIDSource() { return IsSetField(Tags.AllocAcctIDSource); }

        public QuickFix.Fields.AllocAccountType AllocAccountType
        {
            get
            {
                var val = new QuickFix.Fields.AllocAccountType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocAccountType val) { this.AllocAccountType = val; }

        public QuickFix.Fields.AllocAccountType Get(QuickFix.Fields.AllocAccountType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocAccountType val) { return IsSetAllocAccountType(); }

        public bool IsSetAllocAccountType() { return IsSetField(Tags.AllocAccountType); }

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


        public class NoOrdersGroup : Group
        {
            public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoNested2PartyIDs, Tags.OrderQty, Tags.OrderAvgPx, Tags.OrderBookingQty, 0};

            public NoOrdersGroup() : base(Tags.NoOrders, Tags.ClOrdID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoOrdersGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ClOrdID ClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.ClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClOrdID val) { this.ClOrdID = val; }

        public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClOrdID val) { return IsSetClOrdID(); }

        public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

        public QuickFix.Fields.OrderID OrderID
        {
            get
            {
                var val = new QuickFix.Fields.OrderID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderID val) { this.OrderID = val; }

        public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderID val) { return IsSetOrderID(); }

        public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

        public QuickFix.Fields.SecondaryOrderID SecondaryOrderID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryOrderID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryOrderID val) { this.SecondaryOrderID = val; }

        public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryOrderID val) { return IsSetSecondaryOrderID(); }

        public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }

        public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryClOrdID val) { this.SecondaryClOrdID = val; }

        public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }

        public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

        public QuickFix.Fields.ListID ListID
        {
            get
            {
                var val = new QuickFix.Fields.ListID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ListID val) { this.ListID = val; }

        public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ListID val) { return IsSetListID(); }

        public bool IsSetListID() { return IsSetField(Tags.ListID); }

        public QuickFix.Fields.NoNested2PartyIDs NoNested2PartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoNested2PartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoNested2PartyIDs val) { this.NoNested2PartyIDs = val; }

        public QuickFix.Fields.NoNested2PartyIDs Get(QuickFix.Fields.NoNested2PartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoNested2PartyIDs val) { return IsSetNoNested2PartyIDs(); }

        public bool IsSetNoNested2PartyIDs() { return IsSetField(Tags.NoNested2PartyIDs); }

        public QuickFix.Fields.OrderQty OrderQty
        {
            get
            {
                var val = new QuickFix.Fields.OrderQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderQty val) { this.OrderQty = val; }

        public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderQty val) { return IsSetOrderQty(); }

        public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }

        public QuickFix.Fields.OrderAvgPx OrderAvgPx
        {
            get
            {
                var val = new QuickFix.Fields.OrderAvgPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderAvgPx val) { this.OrderAvgPx = val; }

        public QuickFix.Fields.OrderAvgPx Get(QuickFix.Fields.OrderAvgPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderAvgPx val) { return IsSetOrderAvgPx(); }

        public bool IsSetOrderAvgPx() { return IsSetField(Tags.OrderAvgPx); }

        public QuickFix.Fields.OrderBookingQty OrderBookingQty
        {
            get
            {
                var val = new QuickFix.Fields.OrderBookingQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderBookingQty val) { this.OrderBookingQty = val; }

        public QuickFix.Fields.OrderBookingQty Get(QuickFix.Fields.OrderBookingQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderBookingQty val) { return IsSetOrderBookingQty(); }

        public bool IsSetOrderBookingQty() { return IsSetField(Tags.OrderBookingQty); }


        public class NoNested2PartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};

            public NoNested2PartyIDsGroup() : base(Tags.NoNested2PartyIDs, Tags.Nested2PartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNested2PartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.Nested2PartyID Nested2PartyID
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartyID val) { this.Nested2PartyID = val; }

        public QuickFix.Fields.Nested2PartyID Get(QuickFix.Fields.Nested2PartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartyID val) { return IsSetNested2PartyID(); }

        public bool IsSetNested2PartyID() { return IsSetField(Tags.Nested2PartyID); }

        public QuickFix.Fields.Nested2PartyIDSource Nested2PartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartyIDSource val) { this.Nested2PartyIDSource = val; }

        public QuickFix.Fields.Nested2PartyIDSource Get(QuickFix.Fields.Nested2PartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartyIDSource val) { return IsSetNested2PartyIDSource(); }

        public bool IsSetNested2PartyIDSource() { return IsSetField(Tags.Nested2PartyIDSource); }

        public QuickFix.Fields.Nested2PartyRole Nested2PartyRole
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartyRole val) { this.Nested2PartyRole = val; }

        public QuickFix.Fields.Nested2PartyRole Get(QuickFix.Fields.Nested2PartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartyRole val) { return IsSetNested2PartyRole(); }

        public bool IsSetNested2PartyRole() { return IsSetField(Tags.Nested2PartyRole); }

        public QuickFix.Fields.NoNested2PartySubIDs NoNested2PartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoNested2PartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoNested2PartySubIDs val) { this.NoNested2PartySubIDs = val; }

        public QuickFix.Fields.NoNested2PartySubIDs Get(QuickFix.Fields.NoNested2PartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoNested2PartySubIDs val) { return IsSetNoNested2PartySubIDs(); }

        public bool IsSetNoNested2PartySubIDs() { return IsSetField(Tags.NoNested2PartySubIDs); }


        public class NoNested2PartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};

            public NoNested2PartySubIDsGroup() : base(Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNested2PartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.Nested2PartySubID Nested2PartySubID
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartySubID val) { this.Nested2PartySubID = val; }

        public QuickFix.Fields.Nested2PartySubID Get(QuickFix.Fields.Nested2PartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartySubID val) { return IsSetNested2PartySubID(); }

        public bool IsSetNested2PartySubID() { return IsSetField(Tags.Nested2PartySubID); }

        public QuickFix.Fields.Nested2PartySubIDType Nested2PartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.Nested2PartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Nested2PartySubIDType val) { this.Nested2PartySubIDType = val; }

        public QuickFix.Fields.Nested2PartySubIDType Get(QuickFix.Fields.Nested2PartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Nested2PartySubIDType val) { return IsSetNested2PartySubIDType(); }

        public bool IsSetNested2PartySubIDType() { return IsSetField(Tags.Nested2PartySubIDType); }


        }
        }
        }


    }
}
