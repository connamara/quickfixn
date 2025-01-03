// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50;

public class SettlementInstructionRequest : Message
{
    public const string MsgType = "AV";

    public SettlementInstructionRequest() : base()
    {
        Header.SetField(new MsgType("AV"));
    }

    public SettlementInstructionRequest(
            SettlInstReqID aSettlInstReqID,
            TransactTime aTransactTime
        ) : this()
    {
        SettlInstReqID = aSettlInstReqID;
        TransactTime = aTransactTime;
    }

    public SettlInstReqID SettlInstReqID
    {
        get
        {
            SettlInstReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstReqID val) { SettlInstReqID = val; }
    public SettlInstReqID Get(SettlInstReqID val) { GetField(val); return val; }
    public bool IsSet(SettlInstReqID val) { return IsSetSettlInstReqID(); }
    public bool IsSetSettlInstReqID() { return IsSetField(Tags.SettlInstReqID); }

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

    public Side Side
    {
        get
        {
            Side val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Side val) { Side = val; }
    public Side Get(Side val) { GetField(val); return val; }
    public bool IsSet(Side val) { return IsSetSide(); }
    public bool IsSetSide() { return IsSetField(Tags.Side); }

    public Product Product
    {
        get
        {
            Product val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Product val) { Product = val; }
    public Product Get(Product val) { GetField(val); return val; }
    public bool IsSet(Product val) { return IsSetProduct(); }
    public bool IsSetProduct() { return IsSetField(Tags.Product); }

    public SecurityType SecurityType
    {
        get
        {
            SecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityType val) { SecurityType = val; }
    public SecurityType Get(SecurityType val) { GetField(val); return val; }
    public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
    public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

    public CFICode CFICode
    {
        get
        {
            CFICode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CFICode val) { CFICode = val; }
    public CFICode Get(CFICode val) { GetField(val); return val; }
    public bool IsSet(CFICode val) { return IsSetCFICode(); }
    public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

    public EffectiveTime EffectiveTime
    {
        get
        {
            EffectiveTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EffectiveTime val) { EffectiveTime = val; }
    public EffectiveTime Get(EffectiveTime val) { GetField(val); return val; }
    public bool IsSet(EffectiveTime val) { return IsSetEffectiveTime(); }
    public bool IsSetEffectiveTime() { return IsSetField(Tags.EffectiveTime); }

    public ExpireTime ExpireTime
    {
        get
        {
            ExpireTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExpireTime val) { ExpireTime = val; }
    public ExpireTime Get(ExpireTime val) { GetField(val); return val; }
    public bool IsSet(ExpireTime val) { return IsSetExpireTime(); }
    public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

    public LastUpdateTime LastUpdateTime
    {
        get
        {
            LastUpdateTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastUpdateTime val) { LastUpdateTime = val; }
    public LastUpdateTime Get(LastUpdateTime val) { GetField(val); return val; }
    public bool IsSet(LastUpdateTime val) { return IsSetLastUpdateTime(); }
    public bool IsSetLastUpdateTime() { return IsSetField(Tags.LastUpdateTime); }

    public StandInstDbType StandInstDbType
    {
        get
        {
            StandInstDbType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StandInstDbType val) { StandInstDbType = val; }
    public StandInstDbType Get(StandInstDbType val) { GetField(val); return val; }
    public bool IsSet(StandInstDbType val) { return IsSetStandInstDbType(); }
    public bool IsSetStandInstDbType() { return IsSetField(Tags.StandInstDbType); }

    public StandInstDbName StandInstDbName
    {
        get
        {
            StandInstDbName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StandInstDbName val) { StandInstDbName = val; }
    public StandInstDbName Get(StandInstDbName val) { GetField(val); return val; }
    public bool IsSet(StandInstDbName val) { return IsSetStandInstDbName(); }
    public bool IsSetStandInstDbName() { return IsSetField(Tags.StandInstDbName); }

    public StandInstDbID StandInstDbID
    {
        get
        {
            StandInstDbID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StandInstDbID val) { StandInstDbID = val; }
    public StandInstDbID Get(StandInstDbID val) { GetField(val); return val; }
    public bool IsSet(StandInstDbID val) { return IsSetStandInstDbID(); }
    public bool IsSetStandInstDbID() { return IsSetField(Tags.StandInstDbID); }

    public SettlCurrency SettlCurrency
    {
        get
        {
            SettlCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrency val) { SettlCurrency = val; }
    public SettlCurrency Get(SettlCurrency val) { GetField(val); return val; }
    public bool IsSet(SettlCurrency val) { return IsSetSettlCurrency(); }
    public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

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

        public NoPartySubIDs NoPartySubIDs
        {
            get
            {
                NoPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoPartySubIDs val) { NoPartySubIDs = val; }
        public NoPartySubIDs Get(NoPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoPartySubIDs val) { return IsSetNoPartySubIDs(); }
        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }

        public class NoPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartySubID, Tags.PartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup()
              : base(Tags.NoPartySubIDs, Tags.PartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

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

            public PartySubIDType PartySubIDType
            {
                get
                {
                    PartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubIDType val) { PartySubIDType = val; }
            public PartySubIDType Get(PartySubIDType val) { GetField(val); return val; }
            public bool IsSet(PartySubIDType val) { return IsSetPartySubIDType(); }
            public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }
        }
    }
}
