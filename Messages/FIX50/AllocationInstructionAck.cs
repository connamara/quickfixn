// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50;

public class AllocationInstructionAck : Message
{
    public const string MsgType = "P";

    public AllocationInstructionAck() : base()
    {
        Header.SetField(new MsgType("P"));
    }

    public AllocationInstructionAck(
            AllocID aAllocID,
            AllocStatus aAllocStatus
        ) : this()
    {
        AllocID = aAllocID;
        AllocStatus = aAllocStatus;
    }

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

    public TradeDate TradeDate
    {
        get
        {
            TradeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeDate val) { TradeDate = val; }
    public TradeDate Get(TradeDate val) { GetField(val); return val; }
    public bool IsSet(TradeDate val) { return IsSetTradeDate(); }
    public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

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

    public AllocStatus AllocStatus
    {
        get
        {
            AllocStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocStatus val) { AllocStatus = val; }
    public AllocStatus Get(AllocStatus val) { GetField(val); return val; }
    public bool IsSet(AllocStatus val) { return IsSetAllocStatus(); }
    public bool IsSetAllocStatus() { return IsSetField(Tags.AllocStatus); }

    public AllocRejCode AllocRejCode
    {
        get
        {
            AllocRejCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocRejCode val) { AllocRejCode = val; }
    public AllocRejCode Get(AllocRejCode val) { GetField(val); return val; }
    public bool IsSet(AllocRejCode val) { return IsSetAllocRejCode(); }
    public bool IsSetAllocRejCode() { return IsSetField(Tags.AllocRejCode); }

    public AllocType AllocType
    {
        get
        {
            AllocType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocType val) { AllocType = val; }
    public AllocType Get(AllocType val) { GetField(val); return val; }
    public bool IsSet(AllocType val) { return IsSetAllocType(); }
    public bool IsSetAllocType() { return IsSetField(Tags.AllocType); }

    public AllocIntermedReqType AllocIntermedReqType
    {
        get
        {
            AllocIntermedReqType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocIntermedReqType val) { AllocIntermedReqType = val; }
    public AllocIntermedReqType Get(AllocIntermedReqType val) { GetField(val); return val; }
    public bool IsSet(AllocIntermedReqType val) { return IsSetAllocIntermedReqType(); }
    public bool IsSetAllocIntermedReqType() { return IsSetField(Tags.AllocIntermedReqType); }

    public MatchStatus MatchStatus
    {
        get
        {
            MatchStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MatchStatus val) { MatchStatus = val; }
    public MatchStatus Get(MatchStatus val) { GetField(val); return val; }
    public bool IsSet(MatchStatus val) { return IsSetMatchStatus(); }
    public bool IsSetMatchStatus() { return IsSetField(Tags.MatchStatus); }

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

    public NoAllocs NoAllocs
    {
        get
        {
            NoAllocs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoAllocs val) { NoAllocs = val; }
    public NoAllocs Get(NoAllocs val) { GetField(val); return val; }
    public bool IsSet(NoAllocs val) { return IsSetNoAllocs(); }
    public bool IsSetNoAllocs() { return IsSetField(Tags.NoAllocs); }

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

    public class NoAllocsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocPrice, Tags.IndividualAllocID, Tags.IndividualAllocRejCode, Tags.AllocText, Tags.EncodedAllocTextLen, Tags.EncodedAllocText, Tags.SecondaryIndividualAllocID, Tags.AllocCustomerCapacity, Tags.IndividualAllocType, Tags.AllocQty, Tags.NoNestedPartyIDs, Tags.AllocPositionEffect, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocPrice, Tags.IndividualAllocID, Tags.IndividualAllocRejCode, Tags.AllocText, Tags.EncodedAllocTextLen, Tags.EncodedAllocText, Tags.SecondaryIndividualAllocID, Tags.AllocCustomerCapacity, Tags.IndividualAllocType, Tags.AllocQty, Tags.NoNestedPartyIDs, Tags.AllocPositionEffect, 0};

        public NoAllocsGroup()
          : base(Tags.NoAllocs, Tags.AllocAccount, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoAllocsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public AllocPrice AllocPrice
        {
            get
            {
                AllocPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocPrice val) { AllocPrice = val; }
        public AllocPrice Get(AllocPrice val) { GetField(val); return val; }
        public bool IsSet(AllocPrice val) { return IsSetAllocPrice(); }
        public bool IsSetAllocPrice() { return IsSetField(Tags.AllocPrice); }

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

        public IndividualAllocRejCode IndividualAllocRejCode
        {
            get
            {
                IndividualAllocRejCode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IndividualAllocRejCode val) { IndividualAllocRejCode = val; }
        public IndividualAllocRejCode Get(IndividualAllocRejCode val) { GetField(val); return val; }
        public bool IsSet(IndividualAllocRejCode val) { return IsSetIndividualAllocRejCode(); }
        public bool IsSetIndividualAllocRejCode() { return IsSetField(Tags.IndividualAllocRejCode); }

        public AllocText AllocText
        {
            get
            {
                AllocText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocText val) { AllocText = val; }
        public AllocText Get(AllocText val) { GetField(val); return val; }
        public bool IsSet(AllocText val) { return IsSetAllocText(); }
        public bool IsSetAllocText() { return IsSetField(Tags.AllocText); }

        public EncodedAllocTextLen EncodedAllocTextLen
        {
            get
            {
                EncodedAllocTextLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedAllocTextLen val) { EncodedAllocTextLen = val; }
        public EncodedAllocTextLen Get(EncodedAllocTextLen val) { GetField(val); return val; }
        public bool IsSet(EncodedAllocTextLen val) { return IsSetEncodedAllocTextLen(); }
        public bool IsSetEncodedAllocTextLen() { return IsSetField(Tags.EncodedAllocTextLen); }

        public EncodedAllocText EncodedAllocText
        {
            get
            {
                EncodedAllocText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedAllocText val) { EncodedAllocText = val; }
        public EncodedAllocText Get(EncodedAllocText val) { GetField(val); return val; }
        public bool IsSet(EncodedAllocText val) { return IsSetEncodedAllocText(); }
        public bool IsSetEncodedAllocText() { return IsSetField(Tags.EncodedAllocText); }

        public SecondaryIndividualAllocID SecondaryIndividualAllocID
        {
            get
            {
                SecondaryIndividualAllocID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryIndividualAllocID val) { SecondaryIndividualAllocID = val; }
        public SecondaryIndividualAllocID Get(SecondaryIndividualAllocID val) { GetField(val); return val; }
        public bool IsSet(SecondaryIndividualAllocID val) { return IsSetSecondaryIndividualAllocID(); }
        public bool IsSetSecondaryIndividualAllocID() { return IsSetField(Tags.SecondaryIndividualAllocID); }

        public AllocCustomerCapacity AllocCustomerCapacity
        {
            get
            {
                AllocCustomerCapacity val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocCustomerCapacity val) { AllocCustomerCapacity = val; }
        public AllocCustomerCapacity Get(AllocCustomerCapacity val) { GetField(val); return val; }
        public bool IsSet(AllocCustomerCapacity val) { return IsSetAllocCustomerCapacity(); }
        public bool IsSetAllocCustomerCapacity() { return IsSetField(Tags.AllocCustomerCapacity); }

        public IndividualAllocType IndividualAllocType
        {
            get
            {
                IndividualAllocType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IndividualAllocType val) { IndividualAllocType = val; }
        public IndividualAllocType Get(IndividualAllocType val) { GetField(val); return val; }
        public bool IsSet(IndividualAllocType val) { return IsSetIndividualAllocType(); }
        public bool IsSetIndividualAllocType() { return IsSetField(Tags.IndividualAllocType); }

        public AllocQty AllocQty
        {
            get
            {
                AllocQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocQty val) { AllocQty = val; }
        public AllocQty Get(AllocQty val) { GetField(val); return val; }
        public bool IsSet(AllocQty val) { return IsSetAllocQty(); }
        public bool IsSetAllocQty() { return IsSetField(Tags.AllocQty); }

        public NoNestedPartyIDs NoNestedPartyIDs
        {
            get
            {
                NoNestedPartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNestedPartyIDs val) { NoNestedPartyIDs = val; }
        public NoNestedPartyIDs Get(NoNestedPartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNestedPartyIDs val) { return IsSetNoNestedPartyIDs(); }
        public bool IsSetNoNestedPartyIDs() { return IsSetField(Tags.NoNestedPartyIDs); }

        public AllocPositionEffect AllocPositionEffect
        {
            get
            {
                AllocPositionEffect val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocPositionEffect val) { AllocPositionEffect = val; }
        public AllocPositionEffect Get(AllocPositionEffect val) { GetField(val); return val; }
        public bool IsSet(AllocPositionEffect val) { return IsSetAllocPositionEffect(); }
        public bool IsSetAllocPositionEffect() { return IsSetField(Tags.AllocPositionEffect); }

        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};

            public NoNestedPartyIDsGroup()
              : base(Tags.NoNestedPartyIDs, Tags.NestedPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public NestedPartyID NestedPartyID
            {
                get
                {
                    NestedPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyID val) { NestedPartyID = val; }
            public NestedPartyID Get(NestedPartyID val) { GetField(val); return val; }
            public bool IsSet(NestedPartyID val) { return IsSetNestedPartyID(); }
            public bool IsSetNestedPartyID() { return IsSetField(Tags.NestedPartyID); }

            public NestedPartyIDSource NestedPartyIDSource
            {
                get
                {
                    NestedPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyIDSource val) { NestedPartyIDSource = val; }
            public NestedPartyIDSource Get(NestedPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(NestedPartyIDSource val) { return IsSetNestedPartyIDSource(); }
            public bool IsSetNestedPartyIDSource() { return IsSetField(Tags.NestedPartyIDSource); }

            public NestedPartyRole NestedPartyRole
            {
                get
                {
                    NestedPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyRole val) { NestedPartyRole = val; }
            public NestedPartyRole Get(NestedPartyRole val) { GetField(val); return val; }
            public bool IsSet(NestedPartyRole val) { return IsSetNestedPartyRole(); }
            public bool IsSetNestedPartyRole() { return IsSetField(Tags.NestedPartyRole); }

            public NoNestedPartySubIDs NoNestedPartySubIDs
            {
                get
                {
                    NoNestedPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNestedPartySubIDs val) { NoNestedPartySubIDs = val; }
            public NoNestedPartySubIDs Get(NoNestedPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNestedPartySubIDs val) { return IsSetNoNestedPartySubIDs(); }
            public bool IsSetNoNestedPartySubIDs() { return IsSetField(Tags.NoNestedPartySubIDs); }

            public class NoNestedPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};

                public NoNestedPartySubIDsGroup()
                  : base(Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNestedPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public NestedPartySubID NestedPartySubID
                {
                    get
                    {
                        NestedPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubID val) { NestedPartySubID = val; }
                public NestedPartySubID Get(NestedPartySubID val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubID val) { return IsSetNestedPartySubID(); }
                public bool IsSetNestedPartySubID() { return IsSetField(Tags.NestedPartySubID); }

                public NestedPartySubIDType NestedPartySubIDType
                {
                    get
                    {
                        NestedPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubIDType val) { NestedPartySubIDType = val; }
                public NestedPartySubIDType Get(NestedPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubIDType val) { return IsSetNestedPartySubIDType(); }
                public bool IsSetNestedPartySubIDType() { return IsSetField(Tags.NestedPartySubIDType); }
            }
        }
    }
}
