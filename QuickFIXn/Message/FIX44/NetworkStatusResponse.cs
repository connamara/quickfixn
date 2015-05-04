using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class NetworkStatusResponse : Message
    {
        public const string MsgType = "BD";

        public NetworkStatusResponse():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public NetworkStatusResponse(QuickFix.Fields.NetworkStatusResponseType aNetworkStatusResponseType)
               : this()
        {
            this.NetworkStatusResponseType = aNetworkStatusResponseType;
        }

        public QuickFix.Fields.NetworkStatusResponseType NetworkStatusResponseType
        {
            get
            {
                var val = new QuickFix.Fields.NetworkStatusResponseType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NetworkStatusResponseType val) { this.NetworkStatusResponseType = val; }

        public QuickFix.Fields.NetworkStatusResponseType Get(QuickFix.Fields.NetworkStatusResponseType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NetworkStatusResponseType val) { return IsSetNetworkStatusResponseType(); }

        public bool IsSetNetworkStatusResponseType() { return IsSetField(Tags.NetworkStatusResponseType); }

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

        public QuickFix.Fields.NetworkResponseID NetworkResponseID
        {
            get
            {
                var val = new QuickFix.Fields.NetworkResponseID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NetworkResponseID val) { this.NetworkResponseID = val; }

        public QuickFix.Fields.NetworkResponseID Get(QuickFix.Fields.NetworkResponseID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NetworkResponseID val) { return IsSetNetworkResponseID(); }

        public bool IsSetNetworkResponseID() { return IsSetField(Tags.NetworkResponseID); }

        public QuickFix.Fields.LastNetworkResponseID LastNetworkResponseID
        {
            get
            {
                var val = new QuickFix.Fields.LastNetworkResponseID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastNetworkResponseID val) { this.LastNetworkResponseID = val; }

        public QuickFix.Fields.LastNetworkResponseID Get(QuickFix.Fields.LastNetworkResponseID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastNetworkResponseID val) { return IsSetLastNetworkResponseID(); }

        public bool IsSetLastNetworkResponseID() { return IsSetField(Tags.LastNetworkResponseID); }

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
            public static int[] fieldOrder = {Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, Tags.StatusValue, Tags.StatusText, 0};

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

        public QuickFix.Fields.StatusValue StatusValue
        {
            get
            {
                var val = new QuickFix.Fields.StatusValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StatusValue val) { this.StatusValue = val; }

        public QuickFix.Fields.StatusValue Get(QuickFix.Fields.StatusValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StatusValue val) { return IsSetStatusValue(); }

        public bool IsSetStatusValue() { return IsSetField(Tags.StatusValue); }

        public QuickFix.Fields.StatusText StatusText
        {
            get
            {
                var val = new QuickFix.Fields.StatusText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StatusText val) { this.StatusText = val; }

        public QuickFix.Fields.StatusText Get(QuickFix.Fields.StatusText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StatusText val) { return IsSetStatusText(); }

        public bool IsSetStatusText() { return IsSetField(Tags.StatusText); }


        }


    }
}
