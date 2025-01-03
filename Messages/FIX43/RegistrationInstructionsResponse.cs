// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class RegistrationInstructionsResponse : Message
{
    public const string MsgType = "p";

    public RegistrationInstructionsResponse() : base()
    {
        Header.SetField(new MsgType("p"));
    }

    public RegistrationInstructionsResponse(
            RegistID aRegistID,
            RegistTransType aRegistTransType,
            RegistRefID aRegistRefID,
            RegistStatus aRegistStatus
        ) : this()
    {
        RegistID = aRegistID;
        RegistTransType = aRegistTransType;
        RegistRefID = aRegistRefID;
        RegistStatus = aRegistStatus;
    }

    public RegistID RegistID
    {
        get
        {
            RegistID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistID val) { RegistID = val; }
    public RegistID Get(RegistID val) { GetField(val); return val; }
    public bool IsSet(RegistID val) { return IsSetRegistID(); }
    public bool IsSetRegistID() { return IsSetField(Tags.RegistID); }

    public RegistTransType RegistTransType
    {
        get
        {
            RegistTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistTransType val) { RegistTransType = val; }
    public RegistTransType Get(RegistTransType val) { GetField(val); return val; }
    public bool IsSet(RegistTransType val) { return IsSetRegistTransType(); }
    public bool IsSetRegistTransType() { return IsSetField(Tags.RegistTransType); }

    public RegistRefID RegistRefID
    {
        get
        {
            RegistRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistRefID val) { RegistRefID = val; }
    public RegistRefID Get(RegistRefID val) { GetField(val); return val; }
    public bool IsSet(RegistRefID val) { return IsSetRegistRefID(); }
    public bool IsSetRegistRefID() { return IsSetField(Tags.RegistRefID); }

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

    public NoPartyIDs NoPartyIDs
    {
        get
        {
            NoPartyIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyIDs val) { NoPartyIDs = val; }
    public NoPartyIDs Get(NoPartyIDs val) { GetField(val); return val; }
    public bool IsSet(NoPartyIDs val) { return IsSetNoPartyIDs(); }
    public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

    public Account Account
    {
        get
        {
            Account val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Account val) { Account = val; }
    public Account Get(Account val) { GetField(val); return val; }
    public bool IsSet(Account val) { return IsSetAccount(); }
    public bool IsSetAccount() { return IsSetField(Tags.Account); }

    public RegistStatus RegistStatus
    {
        get
        {
            RegistStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistStatus val) { RegistStatus = val; }
    public RegistStatus Get(RegistStatus val) { GetField(val); return val; }
    public bool IsSet(RegistStatus val) { return IsSetRegistStatus(); }
    public bool IsSetRegistStatus() { return IsSetField(Tags.RegistStatus); }

    public RegistRejReasonCode RegistRejReasonCode
    {
        get
        {
            RegistRejReasonCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistRejReasonCode val) { RegistRejReasonCode = val; }
    public RegistRejReasonCode Get(RegistRejReasonCode val) { GetField(val); return val; }
    public bool IsSet(RegistRejReasonCode val) { return IsSetRegistRejReasonCode(); }
    public bool IsSetRegistRejReasonCode() { return IsSetField(Tags.RegistRejReasonCode); }

    public RegistRejReasonText RegistRejReasonText
    {
        get
        {
            RegistRejReasonText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistRejReasonText val) { RegistRejReasonText = val; }
    public RegistRejReasonText Get(RegistRejReasonText val) { GetField(val); return val; }
    public bool IsSet(RegistRejReasonText val) { return IsSetRegistRejReasonText(); }
    public bool IsSetRegistRejReasonText() { return IsSetField(Tags.RegistRejReasonText); }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};

        public NoPartyIDsGroup()
          : base(Tags.NoPartyIDs, Tags.PartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyID PartyID
        {
            get
            {
                PartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyID val) { PartyID = val; }
        public PartyID Get(PartyID val) { GetField(val); return val; }
        public bool IsSet(PartyID val) { return IsSetPartyID(); }
        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public PartyIDSource PartyIDSource
        {
            get
            {
                PartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyIDSource val) { PartyIDSource = val; }
        public PartyIDSource Get(PartyIDSource val) { GetField(val); return val; }
        public bool IsSet(PartyIDSource val) { return IsSetPartyIDSource(); }
        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public PartyRole PartyRole
        {
            get
            {
                PartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRole val) { PartyRole = val; }
        public PartyRole Get(PartyRole val) { GetField(val); return val; }
        public bool IsSet(PartyRole val) { return IsSetPartyRole(); }
        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public PartySubID PartySubID
        {
            get
            {
                PartySubID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartySubID val) { PartySubID = val; }
        public PartySubID Get(PartySubID val) { GetField(val); return val; }
        public bool IsSet(PartySubID val) { return IsSetPartySubID(); }
        public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }
    }
}
