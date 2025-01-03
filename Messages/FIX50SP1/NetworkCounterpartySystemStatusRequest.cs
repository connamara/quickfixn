// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class NetworkCounterpartySystemStatusRequest : Message
{
    public const string MsgType = "BC";

    public NetworkCounterpartySystemStatusRequest() : base()
    {
        Header.SetField(new MsgType("BC"));
    }

    public NetworkCounterpartySystemStatusRequest(
            NetworkRequestType aNetworkRequestType,
            NetworkRequestID aNetworkRequestID
        ) : this()
    {
        NetworkRequestType = aNetworkRequestType;
        NetworkRequestID = aNetworkRequestID;
    }

    public NetworkRequestType NetworkRequestType
    {
        get
        {
            NetworkRequestType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NetworkRequestType val) { NetworkRequestType = val; }
    public NetworkRequestType Get(NetworkRequestType val) { GetField(val); return val; }
    public bool IsSet(NetworkRequestType val) { return IsSetNetworkRequestType(); }
    public bool IsSetNetworkRequestType() { return IsSetField(Tags.NetworkRequestType); }

    public NetworkRequestID NetworkRequestID
    {
        get
        {
            NetworkRequestID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NetworkRequestID val) { NetworkRequestID = val; }
    public NetworkRequestID Get(NetworkRequestID val) { GetField(val); return val; }
    public bool IsSet(NetworkRequestID val) { return IsSetNetworkRequestID(); }
    public bool IsSetNetworkRequestID() { return IsSetField(Tags.NetworkRequestID); }

    public NoCompIDs NoCompIDs
    {
        get
        {
            NoCompIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoCompIDs val) { NoCompIDs = val; }
    public NoCompIDs Get(NoCompIDs val) { GetField(val); return val; }
    public bool IsSet(NoCompIDs val) { return IsSetNoCompIDs(); }
    public bool IsSetNoCompIDs() { return IsSetField(Tags.NoCompIDs); }

    public class NoCompIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, 0};

        public NoCompIDsGroup()
          : base(Tags.NoCompIDs, Tags.RefCompID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoCompIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RefCompID RefCompID
        {
            get
            {
                RefCompID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefCompID val) { RefCompID = val; }
        public RefCompID Get(RefCompID val) { GetField(val); return val; }
        public bool IsSet(RefCompID val) { return IsSetRefCompID(); }
        public bool IsSetRefCompID() { return IsSetField(Tags.RefCompID); }

        public RefSubID RefSubID
        {
            get
            {
                RefSubID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefSubID val) { RefSubID = val; }
        public RefSubID Get(RefSubID val) { GetField(val); return val; }
        public bool IsSet(RefSubID val) { return IsSetRefSubID(); }
        public bool IsSetRefSubID() { return IsSetField(Tags.RefSubID); }

        public LocationID LocationID
        {
            get
            {
                LocationID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LocationID val) { LocationID = val; }
        public LocationID Get(LocationID val) { GetField(val); return val; }
        public bool IsSet(LocationID val) { return IsSetLocationID(); }
        public bool IsSetLocationID() { return IsSetField(Tags.LocationID); }

        public DeskID DeskID
        {
            get
            {
                DeskID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskID val) { DeskID = val; }
        public DeskID Get(DeskID val) { GetField(val); return val; }
        public bool IsSet(DeskID val) { return IsSetDeskID(); }
        public bool IsSetDeskID() { return IsSetField(Tags.DeskID); }
    }
}
