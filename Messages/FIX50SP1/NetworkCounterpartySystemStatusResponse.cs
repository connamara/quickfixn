// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class NetworkCounterpartySystemStatusResponse : Message
{
    public const string MsgType = "BD";

    public NetworkCounterpartySystemStatusResponse() : base()
    {
        Header.SetField(new MsgType("BD"));
    }

    public NetworkCounterpartySystemStatusResponse(
            NetworkStatusResponseType aNetworkStatusResponseType,
            NetworkResponseID aNetworkResponseID
        ) : this()
    {
        NetworkStatusResponseType = aNetworkStatusResponseType;
        NetworkResponseID = aNetworkResponseID;
    }

    public NetworkStatusResponseType NetworkStatusResponseType
    {
        get
        {
            NetworkStatusResponseType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NetworkStatusResponseType val) { NetworkStatusResponseType = val; }
    public NetworkStatusResponseType Get(NetworkStatusResponseType val) { GetField(val); return val; }
    public bool IsSet(NetworkStatusResponseType val) { return IsSetNetworkStatusResponseType(); }
    public bool IsSetNetworkStatusResponseType() { return IsSetField(Tags.NetworkStatusResponseType); }

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

    public NetworkResponseID NetworkResponseID
    {
        get
        {
            NetworkResponseID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NetworkResponseID val) { NetworkResponseID = val; }
    public NetworkResponseID Get(NetworkResponseID val) { GetField(val); return val; }
    public bool IsSet(NetworkResponseID val) { return IsSetNetworkResponseID(); }
    public bool IsSetNetworkResponseID() { return IsSetField(Tags.NetworkResponseID); }

    public LastNetworkResponseID LastNetworkResponseID
    {
        get
        {
            LastNetworkResponseID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastNetworkResponseID val) { LastNetworkResponseID = val; }
    public LastNetworkResponseID Get(LastNetworkResponseID val) { GetField(val); return val; }
    public bool IsSet(LastNetworkResponseID val) { return IsSetLastNetworkResponseID(); }
    public bool IsSetLastNetworkResponseID() { return IsSetField(Tags.LastNetworkResponseID); }

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
        public static int[] DefaultFieldOrder = [Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, Tags.StatusValue, Tags.StatusText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, Tags.StatusValue, Tags.StatusText, 0};

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

        public StatusValue StatusValue
        {
            get
            {
                StatusValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StatusValue val) { StatusValue = val; }
        public StatusValue Get(StatusValue val) { GetField(val); return val; }
        public bool IsSet(StatusValue val) { return IsSetStatusValue(); }
        public bool IsSetStatusValue() { return IsSetField(Tags.StatusValue); }

        public StatusText StatusText
        {
            get
            {
                StatusText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StatusText val) { StatusText = val; }
        public StatusText Get(StatusText val) { GetField(val); return val; }
        public bool IsSet(StatusText val) { return IsSetStatusText(); }
        public bool IsSetStatusText() { return IsSetField(Tags.StatusText); }
    }
}
