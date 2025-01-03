// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class ApplicationMessageRequestAck : Message
{
    public const string MsgType = "BX";

    public ApplicationMessageRequestAck() : base()
    {
        Header.SetField(new MsgType("BX"));
    }

    public ApplicationMessageRequestAck(
            ApplResponseID aApplResponseID
        ) : this()
    {
        ApplResponseID = aApplResponseID;
    }

    public ApplResponseID ApplResponseID
    {
        get
        {
            ApplResponseID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResponseID val) { ApplResponseID = val; }
    public ApplResponseID Get(ApplResponseID val) { GetField(val); return val; }
    public bool IsSet(ApplResponseID val) { return IsSetApplResponseID(); }
    public bool IsSetApplResponseID() { return IsSetField(Tags.ApplResponseID); }

    public ApplReqID ApplReqID
    {
        get
        {
            ApplReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplReqID val) { ApplReqID = val; }
    public ApplReqID Get(ApplReqID val) { GetField(val); return val; }
    public bool IsSet(ApplReqID val) { return IsSetApplReqID(); }
    public bool IsSetApplReqID() { return IsSetField(Tags.ApplReqID); }

    public ApplReqType ApplReqType
    {
        get
        {
            ApplReqType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplReqType val) { ApplReqType = val; }
    public ApplReqType Get(ApplReqType val) { GetField(val); return val; }
    public bool IsSet(ApplReqType val) { return IsSetApplReqType(); }
    public bool IsSetApplReqType() { return IsSetField(Tags.ApplReqType); }

    public ApplResponseType ApplResponseType
    {
        get
        {
            ApplResponseType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResponseType val) { ApplResponseType = val; }
    public ApplResponseType Get(ApplResponseType val) { GetField(val); return val; }
    public bool IsSet(ApplResponseType val) { return IsSetApplResponseType(); }
    public bool IsSetApplResponseType() { return IsSetField(Tags.ApplResponseType); }

    public ApplTotalMessageCount ApplTotalMessageCount
    {
        get
        {
            ApplTotalMessageCount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplTotalMessageCount val) { ApplTotalMessageCount = val; }
    public ApplTotalMessageCount Get(ApplTotalMessageCount val) { GetField(val); return val; }
    public bool IsSet(ApplTotalMessageCount val) { return IsSetApplTotalMessageCount(); }
    public bool IsSetApplTotalMessageCount() { return IsSetField(Tags.ApplTotalMessageCount); }

    public NoApplIDs NoApplIDs
    {
        get
        {
            NoApplIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoApplIDs val) { NoApplIDs = val; }
    public NoApplIDs Get(NoApplIDs val) { GetField(val); return val; }
    public bool IsSet(NoApplIDs val) { return IsSetNoApplIDs(); }
    public bool IsSetNoApplIDs() { return IsSetField(Tags.NoApplIDs); }

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

    public class NoApplIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RefApplID, Tags.ApplBegSeqNum, Tags.ApplEndSeqNum, Tags.RefApplLastSeqNum, Tags.ApplResponseError, Tags.NoNestedPartyIDs, Tags.RefApplReqID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RefApplID, Tags.ApplBegSeqNum, Tags.ApplEndSeqNum, Tags.RefApplLastSeqNum, Tags.ApplResponseError, Tags.NoNestedPartyIDs, Tags.RefApplReqID, 0};

        public NoApplIDsGroup()
          : base(Tags.NoApplIDs, Tags.RefApplID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoApplIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RefApplID RefApplID
        {
            get
            {
                RefApplID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefApplID val) { RefApplID = val; }
        public RefApplID Get(RefApplID val) { GetField(val); return val; }
        public bool IsSet(RefApplID val) { return IsSetRefApplID(); }
        public bool IsSetRefApplID() { return IsSetField(Tags.RefApplID); }

        public ApplBegSeqNum ApplBegSeqNum
        {
            get
            {
                ApplBegSeqNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ApplBegSeqNum val) { ApplBegSeqNum = val; }
        public ApplBegSeqNum Get(ApplBegSeqNum val) { GetField(val); return val; }
        public bool IsSet(ApplBegSeqNum val) { return IsSetApplBegSeqNum(); }
        public bool IsSetApplBegSeqNum() { return IsSetField(Tags.ApplBegSeqNum); }

        public ApplEndSeqNum ApplEndSeqNum
        {
            get
            {
                ApplEndSeqNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ApplEndSeqNum val) { ApplEndSeqNum = val; }
        public ApplEndSeqNum Get(ApplEndSeqNum val) { GetField(val); return val; }
        public bool IsSet(ApplEndSeqNum val) { return IsSetApplEndSeqNum(); }
        public bool IsSetApplEndSeqNum() { return IsSetField(Tags.ApplEndSeqNum); }

        public RefApplLastSeqNum RefApplLastSeqNum
        {
            get
            {
                RefApplLastSeqNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefApplLastSeqNum val) { RefApplLastSeqNum = val; }
        public RefApplLastSeqNum Get(RefApplLastSeqNum val) { GetField(val); return val; }
        public bool IsSet(RefApplLastSeqNum val) { return IsSetRefApplLastSeqNum(); }
        public bool IsSetRefApplLastSeqNum() { return IsSetField(Tags.RefApplLastSeqNum); }

        public ApplResponseError ApplResponseError
        {
            get
            {
                ApplResponseError val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ApplResponseError val) { ApplResponseError = val; }
        public ApplResponseError Get(ApplResponseError val) { GetField(val); return val; }
        public bool IsSet(ApplResponseError val) { return IsSetApplResponseError(); }
        public bool IsSetApplResponseError() { return IsSetField(Tags.ApplResponseError); }

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

        public RefApplReqID RefApplReqID
        {
            get
            {
                RefApplReqID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefApplReqID val) { RefApplReqID = val; }
        public RefApplReqID Get(RefApplReqID val) { GetField(val); return val; }
        public bool IsSet(RefApplReqID val) { return IsSetRefApplReqID(); }
        public bool IsSetRefApplReqID() { return IsSetField(Tags.RefApplReqID); }

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
