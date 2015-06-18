using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class NetworkStatusRequest : Message
    {
        public const string MsgType = "BC";

        public NetworkStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public NetworkStatusRequest(QuickFix.Fields.NetworkRequestType aNetworkRequestType,
				QuickFix.Fields.NetworkRequestID aNetworkRequestID)
               : this()
        {
            this.NetworkRequestType = aNetworkRequestType;
			this.NetworkRequestID = aNetworkRequestID;
        }

        public QuickFix.Fields.NetworkRequestType NetworkRequestType
        {
            get
            {
                var val = new QuickFix.Fields.NetworkRequestType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NetworkRequestType val) { this.NetworkRequestType = val; }

        public QuickFix.Fields.NetworkRequestType Get(QuickFix.Fields.NetworkRequestType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NetworkRequestType val) { return IsSetNetworkRequestType(); }

        public bool IsSetNetworkRequestType() { return IsSetField(Tags.NetworkRequestType); }

        public QuickFix.Fields.NetworkRequestID NetworkRequestID
        {
            get
            {
                var val = new QuickFix.Fields.NetworkRequestID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NetworkRequestID val) { this.NetworkRequestID = val; }

        public QuickFix.Fields.NetworkRequestID Get(QuickFix.Fields.NetworkRequestID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NetworkRequestID val) { return IsSetNetworkRequestID(); }

        public bool IsSetNetworkRequestID() { return IsSetField(Tags.NetworkRequestID); }

        public QuickFix.Fields.NoCompIDs NoCompIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoCompIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoCompIDs val) { this.NoCompIDs = val; }

        public QuickFix.Fields.NoCompIDs Get(QuickFix.Fields.NoCompIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoCompIDs val) { return IsSetNoCompIDs(); }

        public bool IsSetNoCompIDs() { return IsSetField(Tags.NoCompIDs); }


        public class NoCompIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, 0};

            public NoCompIDsGroup() : base(Tags.NoCompIDs, Tags.RefCompID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoCompIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RefCompID RefCompID
        {
            get
            {
                var val = new QuickFix.Fields.RefCompID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefCompID val) { this.RefCompID = val; }

        public QuickFix.Fields.RefCompID Get(QuickFix.Fields.RefCompID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefCompID val) { return IsSetRefCompID(); }

        public bool IsSetRefCompID() { return IsSetField(Tags.RefCompID); }

        public QuickFix.Fields.RefSubID RefSubID
        {
            get
            {
                var val = new QuickFix.Fields.RefSubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefSubID val) { this.RefSubID = val; }

        public QuickFix.Fields.RefSubID Get(QuickFix.Fields.RefSubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefSubID val) { return IsSetRefSubID(); }

        public bool IsSetRefSubID() { return IsSetField(Tags.RefSubID); }

        public QuickFix.Fields.LocationID LocationID
        {
            get
            {
                var val = new QuickFix.Fields.LocationID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LocationID val) { this.LocationID = val; }

        public QuickFix.Fields.LocationID Get(QuickFix.Fields.LocationID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LocationID val) { return IsSetLocationID(); }

        public bool IsSetLocationID() { return IsSetField(Tags.LocationID); }

        public QuickFix.Fields.DeskID DeskID
        {
            get
            {
                var val = new QuickFix.Fields.DeskID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DeskID val) { this.DeskID = val; }

        public QuickFix.Fields.DeskID Get(QuickFix.Fields.DeskID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DeskID val) { return IsSetDeskID(); }

        public bool IsSetDeskID() { return IsSetField(Tags.DeskID); }


        }


    }
}
