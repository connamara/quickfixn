// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class PartyDetailsListReport : Message
{
    public const string MsgType = "CG";

    public PartyDetailsListReport() : base()
    {
        Header.SetField(new MsgType("CG"));
    }

    public PartyDetailsListReport(
            PartyDetailsListReportID aPartyDetailsListReportID
        ) : this()
    {
        PartyDetailsListReportID = aPartyDetailsListReportID;
    }

    public ApplID ApplID
    {
        get
        {
            ApplID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplID val) { ApplID = val; }
    public ApplID Get(ApplID val) { GetField(val); return val; }
    public bool IsSet(ApplID val) { return IsSetApplID(); }
    public bool IsSetApplID() { return IsSetField(Tags.ApplID); }

    public ApplSeqNum ApplSeqNum
    {
        get
        {
            ApplSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplSeqNum val) { ApplSeqNum = val; }
    public ApplSeqNum Get(ApplSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplSeqNum val) { return IsSetApplSeqNum(); }
    public bool IsSetApplSeqNum() { return IsSetField(Tags.ApplSeqNum); }

    public ApplLastSeqNum ApplLastSeqNum
    {
        get
        {
            ApplLastSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplLastSeqNum val) { ApplLastSeqNum = val; }
    public ApplLastSeqNum Get(ApplLastSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplLastSeqNum val) { return IsSetApplLastSeqNum(); }
    public bool IsSetApplLastSeqNum() { return IsSetField(Tags.ApplLastSeqNum); }

    public ApplResendFlag ApplResendFlag
    {
        get
        {
            ApplResendFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResendFlag val) { ApplResendFlag = val; }
    public ApplResendFlag Get(ApplResendFlag val) { GetField(val); return val; }
    public bool IsSet(ApplResendFlag val) { return IsSetApplResendFlag(); }
    public bool IsSetApplResendFlag() { return IsSetField(Tags.ApplResendFlag); }

    public PartyDetailsListReportID PartyDetailsListReportID
    {
        get
        {
            PartyDetailsListReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PartyDetailsListReportID val) { PartyDetailsListReportID = val; }
    public PartyDetailsListReportID Get(PartyDetailsListReportID val) { GetField(val); return val; }
    public bool IsSet(PartyDetailsListReportID val) { return IsSetPartyDetailsListReportID(); }
    public bool IsSetPartyDetailsListReportID() { return IsSetField(Tags.PartyDetailsListReportID); }

    public PartyDetailsListRequestID PartyDetailsListRequestID
    {
        get
        {
            PartyDetailsListRequestID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PartyDetailsListRequestID val) { PartyDetailsListRequestID = val; }
    public PartyDetailsListRequestID Get(PartyDetailsListRequestID val) { GetField(val); return val; }
    public bool IsSet(PartyDetailsListRequestID val) { return IsSetPartyDetailsListRequestID(); }
    public bool IsSetPartyDetailsListRequestID() { return IsSetField(Tags.PartyDetailsListRequestID); }

    public PartyDetailsRequestResult PartyDetailsRequestResult
    {
        get
        {
            PartyDetailsRequestResult val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PartyDetailsRequestResult val) { PartyDetailsRequestResult = val; }
    public PartyDetailsRequestResult Get(PartyDetailsRequestResult val) { GetField(val); return val; }
    public bool IsSet(PartyDetailsRequestResult val) { return IsSetPartyDetailsRequestResult(); }
    public bool IsSetPartyDetailsRequestResult() { return IsSetField(Tags.PartyDetailsRequestResult); }

    public TotNoPartyList TotNoPartyList
    {
        get
        {
            TotNoPartyList val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNoPartyList val) { TotNoPartyList = val; }
    public TotNoPartyList Get(TotNoPartyList val) { GetField(val); return val; }
    public bool IsSet(TotNoPartyList val) { return IsSetTotNoPartyList(); }
    public bool IsSetTotNoPartyList() { return IsSetField(Tags.TotNoPartyList); }

    public LastFragment LastFragment
    {
        get
        {
            LastFragment val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastFragment val) { LastFragment = val; }
    public LastFragment Get(LastFragment val) { GetField(val); return val; }
    public bool IsSet(LastFragment val) { return IsSetLastFragment(); }
    public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }

    public NoPartyList NoPartyList
    {
        get
        {
            NoPartyList val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyList val) { NoPartyList = val; }
    public NoPartyList Get(NoPartyList val) { GetField(val); return val; }
    public bool IsSet(NoPartyList val) { return IsSetNoPartyList(); }
    public bool IsSetNoPartyList() { return IsSetField(Tags.NoPartyList); }

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

    public class NoPartyListGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, Tags.NoPartyAltIDs, Tags.NoContextPartyIDs, Tags.NoRiskLimits, Tags.NoRelatedPartyIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, Tags.NoPartyAltIDs, Tags.NoContextPartyIDs, Tags.NoRiskLimits, Tags.NoRelatedPartyIDs, 0};

        public NoPartyListGroup()
          : base(Tags.NoPartyList, Tags.PartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyListGroup();
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

        public NoPartyAltIDs NoPartyAltIDs
        {
            get
            {
                NoPartyAltIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoPartyAltIDs val) { NoPartyAltIDs = val; }
        public NoPartyAltIDs Get(NoPartyAltIDs val) { GetField(val); return val; }
        public bool IsSet(NoPartyAltIDs val) { return IsSetNoPartyAltIDs(); }
        public bool IsSetNoPartyAltIDs() { return IsSetField(Tags.NoPartyAltIDs); }

        public NoContextPartyIDs NoContextPartyIDs
        {
            get
            {
                NoContextPartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoContextPartyIDs val) { NoContextPartyIDs = val; }
        public NoContextPartyIDs Get(NoContextPartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoContextPartyIDs val) { return IsSetNoContextPartyIDs(); }
        public bool IsSetNoContextPartyIDs() { return IsSetField(Tags.NoContextPartyIDs); }

        public NoRiskLimits NoRiskLimits
        {
            get
            {
                NoRiskLimits val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoRiskLimits val) { NoRiskLimits = val; }
        public NoRiskLimits Get(NoRiskLimits val) { GetField(val); return val; }
        public bool IsSet(NoRiskLimits val) { return IsSetNoRiskLimits(); }
        public bool IsSetNoRiskLimits() { return IsSetField(Tags.NoRiskLimits); }

        public NoRelatedPartyIDs NoRelatedPartyIDs
        {
            get
            {
                NoRelatedPartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoRelatedPartyIDs val) { NoRelatedPartyIDs = val; }
        public NoRelatedPartyIDs Get(NoRelatedPartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoRelatedPartyIDs val) { return IsSetNoRelatedPartyIDs(); }
        public bool IsSetNoRelatedPartyIDs() { return IsSetField(Tags.NoRelatedPartyIDs); }

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

        public class NoPartyAltIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartyAltID, Tags.PartyAltIDSource, Tags.NoPartyAltSubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartyAltID, Tags.PartyAltIDSource, Tags.NoPartyAltSubIDs, 0};

            public NoPartyAltIDsGroup()
              : base(Tags.NoPartyAltIDs, Tags.PartyAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyAltIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public PartyAltID PartyAltID
            {
                get
                {
                    PartyAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartyAltID val) { PartyAltID = val; }
            public PartyAltID Get(PartyAltID val) { GetField(val); return val; }
            public bool IsSet(PartyAltID val) { return IsSetPartyAltID(); }
            public bool IsSetPartyAltID() { return IsSetField(Tags.PartyAltID); }

            public PartyAltIDSource PartyAltIDSource
            {
                get
                {
                    PartyAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartyAltIDSource val) { PartyAltIDSource = val; }
            public PartyAltIDSource Get(PartyAltIDSource val) { GetField(val); return val; }
            public bool IsSet(PartyAltIDSource val) { return IsSetPartyAltIDSource(); }
            public bool IsSetPartyAltIDSource() { return IsSetField(Tags.PartyAltIDSource); }

            public NoPartyAltSubIDs NoPartyAltSubIDs
            {
                get
                {
                    NoPartyAltSubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoPartyAltSubIDs val) { NoPartyAltSubIDs = val; }
            public NoPartyAltSubIDs Get(NoPartyAltSubIDs val) { GetField(val); return val; }
            public bool IsSet(NoPartyAltSubIDs val) { return IsSetNoPartyAltSubIDs(); }
            public bool IsSetNoPartyAltSubIDs() { return IsSetField(Tags.NoPartyAltSubIDs); }

            public class NoPartyAltSubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.PartyAltSubID, Tags.PartyAltSubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.PartyAltSubID, Tags.PartyAltSubIDType, 0};

                public NoPartyAltSubIDsGroup()
                  : base(Tags.NoPartyAltSubIDs, Tags.PartyAltSubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyAltSubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public PartyAltSubID PartyAltSubID
                {
                    get
                    {
                        PartyAltSubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(PartyAltSubID val) { PartyAltSubID = val; }
                public PartyAltSubID Get(PartyAltSubID val) { GetField(val); return val; }
                public bool IsSet(PartyAltSubID val) { return IsSetPartyAltSubID(); }
                public bool IsSetPartyAltSubID() { return IsSetField(Tags.PartyAltSubID); }

                public PartyAltSubIDType PartyAltSubIDType
                {
                    get
                    {
                        PartyAltSubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(PartyAltSubIDType val) { PartyAltSubIDType = val; }
                public PartyAltSubIDType Get(PartyAltSubIDType val) { GetField(val); return val; }
                public bool IsSet(PartyAltSubIDType val) { return IsSetPartyAltSubIDType(); }
                public bool IsSetPartyAltSubIDType() { return IsSetField(Tags.PartyAltSubIDType); }
            }
        }

        public class NoContextPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ContextPartyID, Tags.ContextPartyIDSource, Tags.ContextPartyRole, Tags.NoContextPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.ContextPartyID, Tags.ContextPartyIDSource, Tags.ContextPartyRole, Tags.NoContextPartySubIDs, 0};

            public NoContextPartyIDsGroup()
              : base(Tags.NoContextPartyIDs, Tags.ContextPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoContextPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ContextPartyID ContextPartyID
            {
                get
                {
                    ContextPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContextPartyID val) { ContextPartyID = val; }
            public ContextPartyID Get(ContextPartyID val) { GetField(val); return val; }
            public bool IsSet(ContextPartyID val) { return IsSetContextPartyID(); }
            public bool IsSetContextPartyID() { return IsSetField(Tags.ContextPartyID); }

            public ContextPartyIDSource ContextPartyIDSource
            {
                get
                {
                    ContextPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContextPartyIDSource val) { ContextPartyIDSource = val; }
            public ContextPartyIDSource Get(ContextPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(ContextPartyIDSource val) { return IsSetContextPartyIDSource(); }
            public bool IsSetContextPartyIDSource() { return IsSetField(Tags.ContextPartyIDSource); }

            public ContextPartyRole ContextPartyRole
            {
                get
                {
                    ContextPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContextPartyRole val) { ContextPartyRole = val; }
            public ContextPartyRole Get(ContextPartyRole val) { GetField(val); return val; }
            public bool IsSet(ContextPartyRole val) { return IsSetContextPartyRole(); }
            public bool IsSetContextPartyRole() { return IsSetField(Tags.ContextPartyRole); }

            public NoContextPartySubIDs NoContextPartySubIDs
            {
                get
                {
                    NoContextPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoContextPartySubIDs val) { NoContextPartySubIDs = val; }
            public NoContextPartySubIDs Get(NoContextPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoContextPartySubIDs val) { return IsSetNoContextPartySubIDs(); }
            public bool IsSetNoContextPartySubIDs() { return IsSetField(Tags.NoContextPartySubIDs); }

            public class NoContextPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.ContextPartySubID, Tags.ContextPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.ContextPartySubID, Tags.ContextPartySubIDType, 0};

                public NoContextPartySubIDsGroup()
                  : base(Tags.NoContextPartySubIDs, Tags.ContextPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoContextPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public ContextPartySubID ContextPartySubID
                {
                    get
                    {
                        ContextPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ContextPartySubID val) { ContextPartySubID = val; }
                public ContextPartySubID Get(ContextPartySubID val) { GetField(val); return val; }
                public bool IsSet(ContextPartySubID val) { return IsSetContextPartySubID(); }
                public bool IsSetContextPartySubID() { return IsSetField(Tags.ContextPartySubID); }

                public ContextPartySubIDType ContextPartySubIDType
                {
                    get
                    {
                        ContextPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ContextPartySubIDType val) { ContextPartySubIDType = val; }
                public ContextPartySubIDType Get(ContextPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(ContextPartySubIDType val) { return IsSetContextPartySubIDType(); }
                public bool IsSetContextPartySubIDType() { return IsSetField(Tags.ContextPartySubIDType); }
            }
        }

        public class NoRiskLimitsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.RiskLimitType, Tags.RiskLimitAmount, Tags.RiskLimitCurrency, Tags.RiskLimitPlatform, Tags.NoRiskInstruments, Tags.NoRiskWarningLevels, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.RiskLimitType, Tags.RiskLimitAmount, Tags.RiskLimitCurrency, Tags.RiskLimitPlatform, Tags.NoRiskInstruments, Tags.NoRiskWarningLevels, 0};

            public NoRiskLimitsGroup()
              : base(Tags.NoRiskLimits, Tags.RiskLimitType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRiskLimitsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public RiskLimitType RiskLimitType
            {
                get
                {
                    RiskLimitType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RiskLimitType val) { RiskLimitType = val; }
            public RiskLimitType Get(RiskLimitType val) { GetField(val); return val; }
            public bool IsSet(RiskLimitType val) { return IsSetRiskLimitType(); }
            public bool IsSetRiskLimitType() { return IsSetField(Tags.RiskLimitType); }

            public RiskLimitAmount RiskLimitAmount
            {
                get
                {
                    RiskLimitAmount val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RiskLimitAmount val) { RiskLimitAmount = val; }
            public RiskLimitAmount Get(RiskLimitAmount val) { GetField(val); return val; }
            public bool IsSet(RiskLimitAmount val) { return IsSetRiskLimitAmount(); }
            public bool IsSetRiskLimitAmount() { return IsSetField(Tags.RiskLimitAmount); }

            public RiskLimitCurrency RiskLimitCurrency
            {
                get
                {
                    RiskLimitCurrency val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RiskLimitCurrency val) { RiskLimitCurrency = val; }
            public RiskLimitCurrency Get(RiskLimitCurrency val) { GetField(val); return val; }
            public bool IsSet(RiskLimitCurrency val) { return IsSetRiskLimitCurrency(); }
            public bool IsSetRiskLimitCurrency() { return IsSetField(Tags.RiskLimitCurrency); }

            public RiskLimitPlatform RiskLimitPlatform
            {
                get
                {
                    RiskLimitPlatform val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RiskLimitPlatform val) { RiskLimitPlatform = val; }
            public RiskLimitPlatform Get(RiskLimitPlatform val) { GetField(val); return val; }
            public bool IsSet(RiskLimitPlatform val) { return IsSetRiskLimitPlatform(); }
            public bool IsSetRiskLimitPlatform() { return IsSetField(Tags.RiskLimitPlatform); }

            public NoRiskInstruments NoRiskInstruments
            {
                get
                {
                    NoRiskInstruments val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoRiskInstruments val) { NoRiskInstruments = val; }
            public NoRiskInstruments Get(NoRiskInstruments val) { GetField(val); return val; }
            public bool IsSet(NoRiskInstruments val) { return IsSetNoRiskInstruments(); }
            public bool IsSetNoRiskInstruments() { return IsSetField(Tags.NoRiskInstruments); }

            public NoRiskWarningLevels NoRiskWarningLevels
            {
                get
                {
                    NoRiskWarningLevels val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoRiskWarningLevels val) { NoRiskWarningLevels = val; }
            public NoRiskWarningLevels Get(NoRiskWarningLevels val) { GetField(val); return val; }
            public bool IsSet(NoRiskWarningLevels val) { return IsSetNoRiskWarningLevels(); }
            public bool IsSetNoRiskWarningLevels() { return IsSetField(Tags.NoRiskWarningLevels); }

            public class NoRiskInstrumentsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.RiskInstrumentOperator, Tags.RiskSymbol, Tags.RiskSymbolSfx, Tags.RiskSecurityID, Tags.RiskSecurityIDSource, Tags.NoRiskSecurityAltID, Tags.RiskProduct, Tags.RiskProductComplex, Tags.RiskSecurityGroup, Tags.RiskCFICode, Tags.RiskSecurityType, Tags.RiskSecuritySubType, Tags.RiskMaturityMonthYear, Tags.RiskMaturityTime, Tags.RiskRestructuringType, Tags.RiskSeniority, Tags.RiskPutOrCall, Tags.RiskFlexibleIndicator, Tags.RiskCouponRate, Tags.RiskSecurityExchange, Tags.RiskSecurityDesc, Tags.RiskEncodedSecurityDescLen, Tags.RiskEncodedSecurityDesc, Tags.RiskInstrumentSettlType, Tags.RiskInstrumentMultiplier, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.RiskInstrumentOperator, Tags.RiskSymbol, Tags.RiskSymbolSfx, Tags.RiskSecurityID, Tags.RiskSecurityIDSource, Tags.NoRiskSecurityAltID, Tags.RiskProduct, Tags.RiskProductComplex, Tags.RiskSecurityGroup, Tags.RiskCFICode, Tags.RiskSecurityType, Tags.RiskSecuritySubType, Tags.RiskMaturityMonthYear, Tags.RiskMaturityTime, Tags.RiskRestructuringType, Tags.RiskSeniority, Tags.RiskPutOrCall, Tags.RiskFlexibleIndicator, Tags.RiskCouponRate, Tags.RiskSecurityExchange, Tags.RiskSecurityDesc, Tags.RiskEncodedSecurityDescLen, Tags.RiskEncodedSecurityDesc, Tags.RiskInstrumentSettlType, Tags.RiskInstrumentMultiplier, 0};

                public NoRiskInstrumentsGroup()
                  : base(Tags.NoRiskInstruments, Tags.RiskInstrumentOperator, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRiskInstrumentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public RiskInstrumentOperator RiskInstrumentOperator
                {
                    get
                    {
                        RiskInstrumentOperator val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskInstrumentOperator val) { RiskInstrumentOperator = val; }
                public RiskInstrumentOperator Get(RiskInstrumentOperator val) { GetField(val); return val; }
                public bool IsSet(RiskInstrumentOperator val) { return IsSetRiskInstrumentOperator(); }
                public bool IsSetRiskInstrumentOperator() { return IsSetField(Tags.RiskInstrumentOperator); }

                public RiskSymbol RiskSymbol
                {
                    get
                    {
                        RiskSymbol val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSymbol val) { RiskSymbol = val; }
                public RiskSymbol Get(RiskSymbol val) { GetField(val); return val; }
                public bool IsSet(RiskSymbol val) { return IsSetRiskSymbol(); }
                public bool IsSetRiskSymbol() { return IsSetField(Tags.RiskSymbol); }

                public RiskSymbolSfx RiskSymbolSfx
                {
                    get
                    {
                        RiskSymbolSfx val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSymbolSfx val) { RiskSymbolSfx = val; }
                public RiskSymbolSfx Get(RiskSymbolSfx val) { GetField(val); return val; }
                public bool IsSet(RiskSymbolSfx val) { return IsSetRiskSymbolSfx(); }
                public bool IsSetRiskSymbolSfx() { return IsSetField(Tags.RiskSymbolSfx); }

                public RiskSecurityID RiskSecurityID
                {
                    get
                    {
                        RiskSecurityID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSecurityID val) { RiskSecurityID = val; }
                public RiskSecurityID Get(RiskSecurityID val) { GetField(val); return val; }
                public bool IsSet(RiskSecurityID val) { return IsSetRiskSecurityID(); }
                public bool IsSetRiskSecurityID() { return IsSetField(Tags.RiskSecurityID); }

                public RiskSecurityIDSource RiskSecurityIDSource
                {
                    get
                    {
                        RiskSecurityIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSecurityIDSource val) { RiskSecurityIDSource = val; }
                public RiskSecurityIDSource Get(RiskSecurityIDSource val) { GetField(val); return val; }
                public bool IsSet(RiskSecurityIDSource val) { return IsSetRiskSecurityIDSource(); }
                public bool IsSetRiskSecurityIDSource() { return IsSetField(Tags.RiskSecurityIDSource); }

                public NoRiskSecurityAltID NoRiskSecurityAltID
                {
                    get
                    {
                        NoRiskSecurityAltID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoRiskSecurityAltID val) { NoRiskSecurityAltID = val; }
                public NoRiskSecurityAltID Get(NoRiskSecurityAltID val) { GetField(val); return val; }
                public bool IsSet(NoRiskSecurityAltID val) { return IsSetNoRiskSecurityAltID(); }
                public bool IsSetNoRiskSecurityAltID() { return IsSetField(Tags.NoRiskSecurityAltID); }

                public RiskProduct RiskProduct
                {
                    get
                    {
                        RiskProduct val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskProduct val) { RiskProduct = val; }
                public RiskProduct Get(RiskProduct val) { GetField(val); return val; }
                public bool IsSet(RiskProduct val) { return IsSetRiskProduct(); }
                public bool IsSetRiskProduct() { return IsSetField(Tags.RiskProduct); }

                public RiskProductComplex RiskProductComplex
                {
                    get
                    {
                        RiskProductComplex val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskProductComplex val) { RiskProductComplex = val; }
                public RiskProductComplex Get(RiskProductComplex val) { GetField(val); return val; }
                public bool IsSet(RiskProductComplex val) { return IsSetRiskProductComplex(); }
                public bool IsSetRiskProductComplex() { return IsSetField(Tags.RiskProductComplex); }

                public RiskSecurityGroup RiskSecurityGroup
                {
                    get
                    {
                        RiskSecurityGroup val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSecurityGroup val) { RiskSecurityGroup = val; }
                public RiskSecurityGroup Get(RiskSecurityGroup val) { GetField(val); return val; }
                public bool IsSet(RiskSecurityGroup val) { return IsSetRiskSecurityGroup(); }
                public bool IsSetRiskSecurityGroup() { return IsSetField(Tags.RiskSecurityGroup); }

                public RiskCFICode RiskCFICode
                {
                    get
                    {
                        RiskCFICode val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskCFICode val) { RiskCFICode = val; }
                public RiskCFICode Get(RiskCFICode val) { GetField(val); return val; }
                public bool IsSet(RiskCFICode val) { return IsSetRiskCFICode(); }
                public bool IsSetRiskCFICode() { return IsSetField(Tags.RiskCFICode); }

                public RiskSecurityType RiskSecurityType
                {
                    get
                    {
                        RiskSecurityType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSecurityType val) { RiskSecurityType = val; }
                public RiskSecurityType Get(RiskSecurityType val) { GetField(val); return val; }
                public bool IsSet(RiskSecurityType val) { return IsSetRiskSecurityType(); }
                public bool IsSetRiskSecurityType() { return IsSetField(Tags.RiskSecurityType); }

                public RiskSecuritySubType RiskSecuritySubType
                {
                    get
                    {
                        RiskSecuritySubType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSecuritySubType val) { RiskSecuritySubType = val; }
                public RiskSecuritySubType Get(RiskSecuritySubType val) { GetField(val); return val; }
                public bool IsSet(RiskSecuritySubType val) { return IsSetRiskSecuritySubType(); }
                public bool IsSetRiskSecuritySubType() { return IsSetField(Tags.RiskSecuritySubType); }

                public RiskMaturityMonthYear RiskMaturityMonthYear
                {
                    get
                    {
                        RiskMaturityMonthYear val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskMaturityMonthYear val) { RiskMaturityMonthYear = val; }
                public RiskMaturityMonthYear Get(RiskMaturityMonthYear val) { GetField(val); return val; }
                public bool IsSet(RiskMaturityMonthYear val) { return IsSetRiskMaturityMonthYear(); }
                public bool IsSetRiskMaturityMonthYear() { return IsSetField(Tags.RiskMaturityMonthYear); }

                public RiskMaturityTime RiskMaturityTime
                {
                    get
                    {
                        RiskMaturityTime val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskMaturityTime val) { RiskMaturityTime = val; }
                public RiskMaturityTime Get(RiskMaturityTime val) { GetField(val); return val; }
                public bool IsSet(RiskMaturityTime val) { return IsSetRiskMaturityTime(); }
                public bool IsSetRiskMaturityTime() { return IsSetField(Tags.RiskMaturityTime); }

                public RiskRestructuringType RiskRestructuringType
                {
                    get
                    {
                        RiskRestructuringType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskRestructuringType val) { RiskRestructuringType = val; }
                public RiskRestructuringType Get(RiskRestructuringType val) { GetField(val); return val; }
                public bool IsSet(RiskRestructuringType val) { return IsSetRiskRestructuringType(); }
                public bool IsSetRiskRestructuringType() { return IsSetField(Tags.RiskRestructuringType); }

                public RiskSeniority RiskSeniority
                {
                    get
                    {
                        RiskSeniority val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSeniority val) { RiskSeniority = val; }
                public RiskSeniority Get(RiskSeniority val) { GetField(val); return val; }
                public bool IsSet(RiskSeniority val) { return IsSetRiskSeniority(); }
                public bool IsSetRiskSeniority() { return IsSetField(Tags.RiskSeniority); }

                public RiskPutOrCall RiskPutOrCall
                {
                    get
                    {
                        RiskPutOrCall val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskPutOrCall val) { RiskPutOrCall = val; }
                public RiskPutOrCall Get(RiskPutOrCall val) { GetField(val); return val; }
                public bool IsSet(RiskPutOrCall val) { return IsSetRiskPutOrCall(); }
                public bool IsSetRiskPutOrCall() { return IsSetField(Tags.RiskPutOrCall); }

                public RiskFlexibleIndicator RiskFlexibleIndicator
                {
                    get
                    {
                        RiskFlexibleIndicator val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskFlexibleIndicator val) { RiskFlexibleIndicator = val; }
                public RiskFlexibleIndicator Get(RiskFlexibleIndicator val) { GetField(val); return val; }
                public bool IsSet(RiskFlexibleIndicator val) { return IsSetRiskFlexibleIndicator(); }
                public bool IsSetRiskFlexibleIndicator() { return IsSetField(Tags.RiskFlexibleIndicator); }

                public RiskCouponRate RiskCouponRate
                {
                    get
                    {
                        RiskCouponRate val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskCouponRate val) { RiskCouponRate = val; }
                public RiskCouponRate Get(RiskCouponRate val) { GetField(val); return val; }
                public bool IsSet(RiskCouponRate val) { return IsSetRiskCouponRate(); }
                public bool IsSetRiskCouponRate() { return IsSetField(Tags.RiskCouponRate); }

                public RiskSecurityExchange RiskSecurityExchange
                {
                    get
                    {
                        RiskSecurityExchange val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSecurityExchange val) { RiskSecurityExchange = val; }
                public RiskSecurityExchange Get(RiskSecurityExchange val) { GetField(val); return val; }
                public bool IsSet(RiskSecurityExchange val) { return IsSetRiskSecurityExchange(); }
                public bool IsSetRiskSecurityExchange() { return IsSetField(Tags.RiskSecurityExchange); }

                public RiskSecurityDesc RiskSecurityDesc
                {
                    get
                    {
                        RiskSecurityDesc val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskSecurityDesc val) { RiskSecurityDesc = val; }
                public RiskSecurityDesc Get(RiskSecurityDesc val) { GetField(val); return val; }
                public bool IsSet(RiskSecurityDesc val) { return IsSetRiskSecurityDesc(); }
                public bool IsSetRiskSecurityDesc() { return IsSetField(Tags.RiskSecurityDesc); }

                public RiskEncodedSecurityDescLen RiskEncodedSecurityDescLen
                {
                    get
                    {
                        RiskEncodedSecurityDescLen val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskEncodedSecurityDescLen val) { RiskEncodedSecurityDescLen = val; }
                public RiskEncodedSecurityDescLen Get(RiskEncodedSecurityDescLen val) { GetField(val); return val; }
                public bool IsSet(RiskEncodedSecurityDescLen val) { return IsSetRiskEncodedSecurityDescLen(); }
                public bool IsSetRiskEncodedSecurityDescLen() { return IsSetField(Tags.RiskEncodedSecurityDescLen); }

                public RiskEncodedSecurityDesc RiskEncodedSecurityDesc
                {
                    get
                    {
                        RiskEncodedSecurityDesc val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskEncodedSecurityDesc val) { RiskEncodedSecurityDesc = val; }
                public RiskEncodedSecurityDesc Get(RiskEncodedSecurityDesc val) { GetField(val); return val; }
                public bool IsSet(RiskEncodedSecurityDesc val) { return IsSetRiskEncodedSecurityDesc(); }
                public bool IsSetRiskEncodedSecurityDesc() { return IsSetField(Tags.RiskEncodedSecurityDesc); }

                public RiskInstrumentSettlType RiskInstrumentSettlType
                {
                    get
                    {
                        RiskInstrumentSettlType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskInstrumentSettlType val) { RiskInstrumentSettlType = val; }
                public RiskInstrumentSettlType Get(RiskInstrumentSettlType val) { GetField(val); return val; }
                public bool IsSet(RiskInstrumentSettlType val) { return IsSetRiskInstrumentSettlType(); }
                public bool IsSetRiskInstrumentSettlType() { return IsSetField(Tags.RiskInstrumentSettlType); }

                public RiskInstrumentMultiplier RiskInstrumentMultiplier
                {
                    get
                    {
                        RiskInstrumentMultiplier val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskInstrumentMultiplier val) { RiskInstrumentMultiplier = val; }
                public RiskInstrumentMultiplier Get(RiskInstrumentMultiplier val) { GetField(val); return val; }
                public bool IsSet(RiskInstrumentMultiplier val) { return IsSetRiskInstrumentMultiplier(); }
                public bool IsSetRiskInstrumentMultiplier() { return IsSetField(Tags.RiskInstrumentMultiplier); }

                public class NoRiskSecurityAltIDGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.RiskSecurityAltID, Tags.RiskSecurityAltIDSource, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.RiskSecurityAltID, Tags.RiskSecurityAltIDSource, 0};

                    public NoRiskSecurityAltIDGroup()
                      : base(Tags.NoRiskSecurityAltID, Tags.RiskSecurityAltID, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRiskSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public RiskSecurityAltID RiskSecurityAltID
                    {
                        get
                        {
                            RiskSecurityAltID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RiskSecurityAltID val) { RiskSecurityAltID = val; }
                    public RiskSecurityAltID Get(RiskSecurityAltID val) { GetField(val); return val; }
                    public bool IsSet(RiskSecurityAltID val) { return IsSetRiskSecurityAltID(); }
                    public bool IsSetRiskSecurityAltID() { return IsSetField(Tags.RiskSecurityAltID); }

                    public RiskSecurityAltIDSource RiskSecurityAltIDSource
                    {
                        get
                        {
                            RiskSecurityAltIDSource val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RiskSecurityAltIDSource val) { RiskSecurityAltIDSource = val; }
                    public RiskSecurityAltIDSource Get(RiskSecurityAltIDSource val) { GetField(val); return val; }
                    public bool IsSet(RiskSecurityAltIDSource val) { return IsSetRiskSecurityAltIDSource(); }
                    public bool IsSetRiskSecurityAltIDSource() { return IsSetField(Tags.RiskSecurityAltIDSource); }
                }
            }

            public class NoRiskWarningLevelsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.RiskWarningLevelPercent, Tags.RiskWarningLevelName, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.RiskWarningLevelPercent, Tags.RiskWarningLevelName, 0};

                public NoRiskWarningLevelsGroup()
                  : base(Tags.NoRiskWarningLevels, Tags.RiskWarningLevelPercent, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRiskWarningLevelsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public RiskWarningLevelPercent RiskWarningLevelPercent
                {
                    get
                    {
                        RiskWarningLevelPercent val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskWarningLevelPercent val) { RiskWarningLevelPercent = val; }
                public RiskWarningLevelPercent Get(RiskWarningLevelPercent val) { GetField(val); return val; }
                public bool IsSet(RiskWarningLevelPercent val) { return IsSetRiskWarningLevelPercent(); }
                public bool IsSetRiskWarningLevelPercent() { return IsSetField(Tags.RiskWarningLevelPercent); }

                public RiskWarningLevelName RiskWarningLevelName
                {
                    get
                    {
                        RiskWarningLevelName val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RiskWarningLevelName val) { RiskWarningLevelName = val; }
                public RiskWarningLevelName Get(RiskWarningLevelName val) { GetField(val); return val; }
                public bool IsSet(RiskWarningLevelName val) { return IsSetRiskWarningLevelName(); }
                public bool IsSetRiskWarningLevelName() { return IsSetField(Tags.RiskWarningLevelName); }
            }
        }

        public class NoRelatedPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.RelatedPartyID, Tags.RelatedPartyIDSource, Tags.RelatedPartyRole, Tags.NoRelatedPartySubIDs, Tags.NoRelatedPartyAltIDs, Tags.NoRelatedContextPartyIDs, Tags.NoRelationshipRiskLimits, Tags.NoPartyRelationships, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.RelatedPartyID, Tags.RelatedPartyIDSource, Tags.RelatedPartyRole, Tags.NoRelatedPartySubIDs, Tags.NoRelatedPartyAltIDs, Tags.NoRelatedContextPartyIDs, Tags.NoRelationshipRiskLimits, Tags.NoPartyRelationships, 0};

            public NoRelatedPartyIDsGroup()
              : base(Tags.NoRelatedPartyIDs, Tags.RelatedPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public RelatedPartyID RelatedPartyID
            {
                get
                {
                    RelatedPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RelatedPartyID val) { RelatedPartyID = val; }
            public RelatedPartyID Get(RelatedPartyID val) { GetField(val); return val; }
            public bool IsSet(RelatedPartyID val) { return IsSetRelatedPartyID(); }
            public bool IsSetRelatedPartyID() { return IsSetField(Tags.RelatedPartyID); }

            public RelatedPartyIDSource RelatedPartyIDSource
            {
                get
                {
                    RelatedPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RelatedPartyIDSource val) { RelatedPartyIDSource = val; }
            public RelatedPartyIDSource Get(RelatedPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(RelatedPartyIDSource val) { return IsSetRelatedPartyIDSource(); }
            public bool IsSetRelatedPartyIDSource() { return IsSetField(Tags.RelatedPartyIDSource); }

            public RelatedPartyRole RelatedPartyRole
            {
                get
                {
                    RelatedPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RelatedPartyRole val) { RelatedPartyRole = val; }
            public RelatedPartyRole Get(RelatedPartyRole val) { GetField(val); return val; }
            public bool IsSet(RelatedPartyRole val) { return IsSetRelatedPartyRole(); }
            public bool IsSetRelatedPartyRole() { return IsSetField(Tags.RelatedPartyRole); }

            public NoRelatedPartySubIDs NoRelatedPartySubIDs
            {
                get
                {
                    NoRelatedPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoRelatedPartySubIDs val) { NoRelatedPartySubIDs = val; }
            public NoRelatedPartySubIDs Get(NoRelatedPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoRelatedPartySubIDs val) { return IsSetNoRelatedPartySubIDs(); }
            public bool IsSetNoRelatedPartySubIDs() { return IsSetField(Tags.NoRelatedPartySubIDs); }

            public NoRelatedPartyAltIDs NoRelatedPartyAltIDs
            {
                get
                {
                    NoRelatedPartyAltIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoRelatedPartyAltIDs val) { NoRelatedPartyAltIDs = val; }
            public NoRelatedPartyAltIDs Get(NoRelatedPartyAltIDs val) { GetField(val); return val; }
            public bool IsSet(NoRelatedPartyAltIDs val) { return IsSetNoRelatedPartyAltIDs(); }
            public bool IsSetNoRelatedPartyAltIDs() { return IsSetField(Tags.NoRelatedPartyAltIDs); }

            public NoRelatedContextPartyIDs NoRelatedContextPartyIDs
            {
                get
                {
                    NoRelatedContextPartyIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoRelatedContextPartyIDs val) { NoRelatedContextPartyIDs = val; }
            public NoRelatedContextPartyIDs Get(NoRelatedContextPartyIDs val) { GetField(val); return val; }
            public bool IsSet(NoRelatedContextPartyIDs val) { return IsSetNoRelatedContextPartyIDs(); }
            public bool IsSetNoRelatedContextPartyIDs() { return IsSetField(Tags.NoRelatedContextPartyIDs); }

            public NoRelationshipRiskLimits NoRelationshipRiskLimits
            {
                get
                {
                    NoRelationshipRiskLimits val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoRelationshipRiskLimits val) { NoRelationshipRiskLimits = val; }
            public NoRelationshipRiskLimits Get(NoRelationshipRiskLimits val) { GetField(val); return val; }
            public bool IsSet(NoRelationshipRiskLimits val) { return IsSetNoRelationshipRiskLimits(); }
            public bool IsSetNoRelationshipRiskLimits() { return IsSetField(Tags.NoRelationshipRiskLimits); }

            public NoPartyRelationships NoPartyRelationships
            {
                get
                {
                    NoPartyRelationships val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoPartyRelationships val) { NoPartyRelationships = val; }
            public NoPartyRelationships Get(NoPartyRelationships val) { GetField(val); return val; }
            public bool IsSet(NoPartyRelationships val) { return IsSetNoPartyRelationships(); }
            public bool IsSetNoPartyRelationships() { return IsSetField(Tags.NoPartyRelationships); }

            public class NoRelatedPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.RelatedPartySubID, Tags.RelatedPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.RelatedPartySubID, Tags.RelatedPartySubIDType, 0};

                public NoRelatedPartySubIDsGroup()
                  : base(Tags.NoRelatedPartySubIDs, Tags.RelatedPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRelatedPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public RelatedPartySubID RelatedPartySubID
                {
                    get
                    {
                        RelatedPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelatedPartySubID val) { RelatedPartySubID = val; }
                public RelatedPartySubID Get(RelatedPartySubID val) { GetField(val); return val; }
                public bool IsSet(RelatedPartySubID val) { return IsSetRelatedPartySubID(); }
                public bool IsSetRelatedPartySubID() { return IsSetField(Tags.RelatedPartySubID); }

                public RelatedPartySubIDType RelatedPartySubIDType
                {
                    get
                    {
                        RelatedPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelatedPartySubIDType val) { RelatedPartySubIDType = val; }
                public RelatedPartySubIDType Get(RelatedPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(RelatedPartySubIDType val) { return IsSetRelatedPartySubIDType(); }
                public bool IsSetRelatedPartySubIDType() { return IsSetField(Tags.RelatedPartySubIDType); }
            }

            public class NoRelatedPartyAltIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.RelatedPartyAltID, Tags.RelatedPartyAltIDSource, Tags.NoRelatedPartyAltSubIDs, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.RelatedPartyAltID, Tags.RelatedPartyAltIDSource, Tags.NoRelatedPartyAltSubIDs, 0};

                public NoRelatedPartyAltIDsGroup()
                  : base(Tags.NoRelatedPartyAltIDs, Tags.RelatedPartyAltID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRelatedPartyAltIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public RelatedPartyAltID RelatedPartyAltID
                {
                    get
                    {
                        RelatedPartyAltID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelatedPartyAltID val) { RelatedPartyAltID = val; }
                public RelatedPartyAltID Get(RelatedPartyAltID val) { GetField(val); return val; }
                public bool IsSet(RelatedPartyAltID val) { return IsSetRelatedPartyAltID(); }
                public bool IsSetRelatedPartyAltID() { return IsSetField(Tags.RelatedPartyAltID); }

                public RelatedPartyAltIDSource RelatedPartyAltIDSource
                {
                    get
                    {
                        RelatedPartyAltIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelatedPartyAltIDSource val) { RelatedPartyAltIDSource = val; }
                public RelatedPartyAltIDSource Get(RelatedPartyAltIDSource val) { GetField(val); return val; }
                public bool IsSet(RelatedPartyAltIDSource val) { return IsSetRelatedPartyAltIDSource(); }
                public bool IsSetRelatedPartyAltIDSource() { return IsSetField(Tags.RelatedPartyAltIDSource); }

                public NoRelatedPartyAltSubIDs NoRelatedPartyAltSubIDs
                {
                    get
                    {
                        NoRelatedPartyAltSubIDs val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoRelatedPartyAltSubIDs val) { NoRelatedPartyAltSubIDs = val; }
                public NoRelatedPartyAltSubIDs Get(NoRelatedPartyAltSubIDs val) { GetField(val); return val; }
                public bool IsSet(NoRelatedPartyAltSubIDs val) { return IsSetNoRelatedPartyAltSubIDs(); }
                public bool IsSetNoRelatedPartyAltSubIDs() { return IsSetField(Tags.NoRelatedPartyAltSubIDs); }

                public class NoRelatedPartyAltSubIDsGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.RelatedPartyAltSubID, Tags.RelatedPartyAltSubIDType, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.RelatedPartyAltSubID, Tags.RelatedPartyAltSubIDType, 0};

                    public NoRelatedPartyAltSubIDsGroup()
                      : base(Tags.NoRelatedPartyAltSubIDs, Tags.RelatedPartyAltSubID, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRelatedPartyAltSubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public RelatedPartyAltSubID RelatedPartyAltSubID
                    {
                        get
                        {
                            RelatedPartyAltSubID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelatedPartyAltSubID val) { RelatedPartyAltSubID = val; }
                    public RelatedPartyAltSubID Get(RelatedPartyAltSubID val) { GetField(val); return val; }
                    public bool IsSet(RelatedPartyAltSubID val) { return IsSetRelatedPartyAltSubID(); }
                    public bool IsSetRelatedPartyAltSubID() { return IsSetField(Tags.RelatedPartyAltSubID); }

                    public RelatedPartyAltSubIDType RelatedPartyAltSubIDType
                    {
                        get
                        {
                            RelatedPartyAltSubIDType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelatedPartyAltSubIDType val) { RelatedPartyAltSubIDType = val; }
                    public RelatedPartyAltSubIDType Get(RelatedPartyAltSubIDType val) { GetField(val); return val; }
                    public bool IsSet(RelatedPartyAltSubIDType val) { return IsSetRelatedPartyAltSubIDType(); }
                    public bool IsSetRelatedPartyAltSubIDType() { return IsSetField(Tags.RelatedPartyAltSubIDType); }
                }
            }

            public class NoRelatedContextPartyIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.RelatedContextPartyID, Tags.RelatedContextPartyIDSource, Tags.RelatedContextPartyRole, Tags.NoRelatedContextPartySubIDs, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.RelatedContextPartyID, Tags.RelatedContextPartyIDSource, Tags.RelatedContextPartyRole, Tags.NoRelatedContextPartySubIDs, 0};

                public NoRelatedContextPartyIDsGroup()
                  : base(Tags.NoRelatedContextPartyIDs, Tags.RelatedContextPartyID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRelatedContextPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public RelatedContextPartyID RelatedContextPartyID
                {
                    get
                    {
                        RelatedContextPartyID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelatedContextPartyID val) { RelatedContextPartyID = val; }
                public RelatedContextPartyID Get(RelatedContextPartyID val) { GetField(val); return val; }
                public bool IsSet(RelatedContextPartyID val) { return IsSetRelatedContextPartyID(); }
                public bool IsSetRelatedContextPartyID() { return IsSetField(Tags.RelatedContextPartyID); }

                public RelatedContextPartyIDSource RelatedContextPartyIDSource
                {
                    get
                    {
                        RelatedContextPartyIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelatedContextPartyIDSource val) { RelatedContextPartyIDSource = val; }
                public RelatedContextPartyIDSource Get(RelatedContextPartyIDSource val) { GetField(val); return val; }
                public bool IsSet(RelatedContextPartyIDSource val) { return IsSetRelatedContextPartyIDSource(); }
                public bool IsSetRelatedContextPartyIDSource() { return IsSetField(Tags.RelatedContextPartyIDSource); }

                public RelatedContextPartyRole RelatedContextPartyRole
                {
                    get
                    {
                        RelatedContextPartyRole val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelatedContextPartyRole val) { RelatedContextPartyRole = val; }
                public RelatedContextPartyRole Get(RelatedContextPartyRole val) { GetField(val); return val; }
                public bool IsSet(RelatedContextPartyRole val) { return IsSetRelatedContextPartyRole(); }
                public bool IsSetRelatedContextPartyRole() { return IsSetField(Tags.RelatedContextPartyRole); }

                public NoRelatedContextPartySubIDs NoRelatedContextPartySubIDs
                {
                    get
                    {
                        NoRelatedContextPartySubIDs val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoRelatedContextPartySubIDs val) { NoRelatedContextPartySubIDs = val; }
                public NoRelatedContextPartySubIDs Get(NoRelatedContextPartySubIDs val) { GetField(val); return val; }
                public bool IsSet(NoRelatedContextPartySubIDs val) { return IsSetNoRelatedContextPartySubIDs(); }
                public bool IsSetNoRelatedContextPartySubIDs() { return IsSetField(Tags.NoRelatedContextPartySubIDs); }

                public class NoRelatedContextPartySubIDsGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.RelatedContextPartySubID, Tags.RelatedContextPartySubIDType, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.RelatedContextPartySubID, Tags.RelatedContextPartySubIDType, 0};

                    public NoRelatedContextPartySubIDsGroup()
                      : base(Tags.NoRelatedContextPartySubIDs, Tags.RelatedContextPartySubID, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRelatedContextPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public RelatedContextPartySubID RelatedContextPartySubID
                    {
                        get
                        {
                            RelatedContextPartySubID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelatedContextPartySubID val) { RelatedContextPartySubID = val; }
                    public RelatedContextPartySubID Get(RelatedContextPartySubID val) { GetField(val); return val; }
                    public bool IsSet(RelatedContextPartySubID val) { return IsSetRelatedContextPartySubID(); }
                    public bool IsSetRelatedContextPartySubID() { return IsSetField(Tags.RelatedContextPartySubID); }

                    public RelatedContextPartySubIDType RelatedContextPartySubIDType
                    {
                        get
                        {
                            RelatedContextPartySubIDType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelatedContextPartySubIDType val) { RelatedContextPartySubIDType = val; }
                    public RelatedContextPartySubIDType Get(RelatedContextPartySubIDType val) { GetField(val); return val; }
                    public bool IsSet(RelatedContextPartySubIDType val) { return IsSetRelatedContextPartySubIDType(); }
                    public bool IsSetRelatedContextPartySubIDType() { return IsSetField(Tags.RelatedContextPartySubIDType); }
                }
            }

            public class NoRelationshipRiskLimitsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.RelationshipRiskLimitType, Tags.RelationshipRiskLimitAmount, Tags.RelationshipRiskLimitCurrency, Tags.RelationshipRiskLimitPlatform, Tags.NoRelationshipRiskInstruments, Tags.NoRelationshipRiskWarningLevels, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.RelationshipRiskLimitType, Tags.RelationshipRiskLimitAmount, Tags.RelationshipRiskLimitCurrency, Tags.RelationshipRiskLimitPlatform, Tags.NoRelationshipRiskInstruments, Tags.NoRelationshipRiskWarningLevels, 0};

                public NoRelationshipRiskLimitsGroup()
                  : base(Tags.NoRelationshipRiskLimits, Tags.RelationshipRiskLimitType, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRelationshipRiskLimitsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public RelationshipRiskLimitType RelationshipRiskLimitType
                {
                    get
                    {
                        RelationshipRiskLimitType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelationshipRiskLimitType val) { RelationshipRiskLimitType = val; }
                public RelationshipRiskLimitType Get(RelationshipRiskLimitType val) { GetField(val); return val; }
                public bool IsSet(RelationshipRiskLimitType val) { return IsSetRelationshipRiskLimitType(); }
                public bool IsSetRelationshipRiskLimitType() { return IsSetField(Tags.RelationshipRiskLimitType); }

                public RelationshipRiskLimitAmount RelationshipRiskLimitAmount
                {
                    get
                    {
                        RelationshipRiskLimitAmount val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelationshipRiskLimitAmount val) { RelationshipRiskLimitAmount = val; }
                public RelationshipRiskLimitAmount Get(RelationshipRiskLimitAmount val) { GetField(val); return val; }
                public bool IsSet(RelationshipRiskLimitAmount val) { return IsSetRelationshipRiskLimitAmount(); }
                public bool IsSetRelationshipRiskLimitAmount() { return IsSetField(Tags.RelationshipRiskLimitAmount); }

                public RelationshipRiskLimitCurrency RelationshipRiskLimitCurrency
                {
                    get
                    {
                        RelationshipRiskLimitCurrency val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelationshipRiskLimitCurrency val) { RelationshipRiskLimitCurrency = val; }
                public RelationshipRiskLimitCurrency Get(RelationshipRiskLimitCurrency val) { GetField(val); return val; }
                public bool IsSet(RelationshipRiskLimitCurrency val) { return IsSetRelationshipRiskLimitCurrency(); }
                public bool IsSetRelationshipRiskLimitCurrency() { return IsSetField(Tags.RelationshipRiskLimitCurrency); }

                public RelationshipRiskLimitPlatform RelationshipRiskLimitPlatform
                {
                    get
                    {
                        RelationshipRiskLimitPlatform val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(RelationshipRiskLimitPlatform val) { RelationshipRiskLimitPlatform = val; }
                public RelationshipRiskLimitPlatform Get(RelationshipRiskLimitPlatform val) { GetField(val); return val; }
                public bool IsSet(RelationshipRiskLimitPlatform val) { return IsSetRelationshipRiskLimitPlatform(); }
                public bool IsSetRelationshipRiskLimitPlatform() { return IsSetField(Tags.RelationshipRiskLimitPlatform); }

                public NoRelationshipRiskInstruments NoRelationshipRiskInstruments
                {
                    get
                    {
                        NoRelationshipRiskInstruments val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoRelationshipRiskInstruments val) { NoRelationshipRiskInstruments = val; }
                public NoRelationshipRiskInstruments Get(NoRelationshipRiskInstruments val) { GetField(val); return val; }
                public bool IsSet(NoRelationshipRiskInstruments val) { return IsSetNoRelationshipRiskInstruments(); }
                public bool IsSetNoRelationshipRiskInstruments() { return IsSetField(Tags.NoRelationshipRiskInstruments); }

                public NoRelationshipRiskWarningLevels NoRelationshipRiskWarningLevels
                {
                    get
                    {
                        NoRelationshipRiskWarningLevels val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoRelationshipRiskWarningLevels val) { NoRelationshipRiskWarningLevels = val; }
                public NoRelationshipRiskWarningLevels Get(NoRelationshipRiskWarningLevels val) { GetField(val); return val; }
                public bool IsSet(NoRelationshipRiskWarningLevels val) { return IsSetNoRelationshipRiskWarningLevels(); }
                public bool IsSetNoRelationshipRiskWarningLevels() { return IsSetField(Tags.NoRelationshipRiskWarningLevels); }

                public class NoRelationshipRiskInstrumentsGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.RelationshipRiskInstrumentOperator, Tags.RelationshipRiskSymbol, Tags.RelationshipRiskSymbolSfx, Tags.RelationshipRiskSecurityID, Tags.RelationshipRiskSecurityIDSource, Tags.NoRelationshipRiskSecurityAltID, Tags.RelationshipRiskProduct, Tags.RelationshipRiskProductComplex, Tags.RelationshipRiskSecurityGroup, Tags.RelationshipRiskCFICode, Tags.RelationshipRiskSecurityType, Tags.RelationshipRiskSecuritySubType, Tags.RelationshipRiskMaturityMonthYear, Tags.RelationshipRiskMaturityTime, Tags.RelationshipRiskRestructuringType, Tags.RelationshipRiskSeniority, Tags.RelationshipRiskPutOrCall, Tags.RelationshipRiskFlexibleIndicator, Tags.RelationshipRiskCouponRate, Tags.RelationshipRiskSecurityExchange, Tags.RelationshipRiskSecurityDesc, Tags.RelationshipRiskEncodedSecurityDescLen, Tags.RelationshipRiskEncodedSecurityDesc, Tags.RelationshipRiskInstrumentSettlType, Tags.RelationshipRiskInstrumentMultiplier, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.RelationshipRiskInstrumentOperator, Tags.RelationshipRiskSymbol, Tags.RelationshipRiskSymbolSfx, Tags.RelationshipRiskSecurityID, Tags.RelationshipRiskSecurityIDSource, Tags.NoRelationshipRiskSecurityAltID, Tags.RelationshipRiskProduct, Tags.RelationshipRiskProductComplex, Tags.RelationshipRiskSecurityGroup, Tags.RelationshipRiskCFICode, Tags.RelationshipRiskSecurityType, Tags.RelationshipRiskSecuritySubType, Tags.RelationshipRiskMaturityMonthYear, Tags.RelationshipRiskMaturityTime, Tags.RelationshipRiskRestructuringType, Tags.RelationshipRiskSeniority, Tags.RelationshipRiskPutOrCall, Tags.RelationshipRiskFlexibleIndicator, Tags.RelationshipRiskCouponRate, Tags.RelationshipRiskSecurityExchange, Tags.RelationshipRiskSecurityDesc, Tags.RelationshipRiskEncodedSecurityDescLen, Tags.RelationshipRiskEncodedSecurityDesc, Tags.RelationshipRiskInstrumentSettlType, Tags.RelationshipRiskInstrumentMultiplier, 0};

                    public NoRelationshipRiskInstrumentsGroup()
                      : base(Tags.NoRelationshipRiskInstruments, Tags.RelationshipRiskInstrumentOperator, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRelationshipRiskInstrumentsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public RelationshipRiskInstrumentOperator RelationshipRiskInstrumentOperator
                    {
                        get
                        {
                            RelationshipRiskInstrumentOperator val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskInstrumentOperator val) { RelationshipRiskInstrumentOperator = val; }
                    public RelationshipRiskInstrumentOperator Get(RelationshipRiskInstrumentOperator val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskInstrumentOperator val) { return IsSetRelationshipRiskInstrumentOperator(); }
                    public bool IsSetRelationshipRiskInstrumentOperator() { return IsSetField(Tags.RelationshipRiskInstrumentOperator); }

                    public RelationshipRiskSymbol RelationshipRiskSymbol
                    {
                        get
                        {
                            RelationshipRiskSymbol val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSymbol val) { RelationshipRiskSymbol = val; }
                    public RelationshipRiskSymbol Get(RelationshipRiskSymbol val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSymbol val) { return IsSetRelationshipRiskSymbol(); }
                    public bool IsSetRelationshipRiskSymbol() { return IsSetField(Tags.RelationshipRiskSymbol); }

                    public RelationshipRiskSymbolSfx RelationshipRiskSymbolSfx
                    {
                        get
                        {
                            RelationshipRiskSymbolSfx val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSymbolSfx val) { RelationshipRiskSymbolSfx = val; }
                    public RelationshipRiskSymbolSfx Get(RelationshipRiskSymbolSfx val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSymbolSfx val) { return IsSetRelationshipRiskSymbolSfx(); }
                    public bool IsSetRelationshipRiskSymbolSfx() { return IsSetField(Tags.RelationshipRiskSymbolSfx); }

                    public RelationshipRiskSecurityID RelationshipRiskSecurityID
                    {
                        get
                        {
                            RelationshipRiskSecurityID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSecurityID val) { RelationshipRiskSecurityID = val; }
                    public RelationshipRiskSecurityID Get(RelationshipRiskSecurityID val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSecurityID val) { return IsSetRelationshipRiskSecurityID(); }
                    public bool IsSetRelationshipRiskSecurityID() { return IsSetField(Tags.RelationshipRiskSecurityID); }

                    public RelationshipRiskSecurityIDSource RelationshipRiskSecurityIDSource
                    {
                        get
                        {
                            RelationshipRiskSecurityIDSource val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSecurityIDSource val) { RelationshipRiskSecurityIDSource = val; }
                    public RelationshipRiskSecurityIDSource Get(RelationshipRiskSecurityIDSource val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSecurityIDSource val) { return IsSetRelationshipRiskSecurityIDSource(); }
                    public bool IsSetRelationshipRiskSecurityIDSource() { return IsSetField(Tags.RelationshipRiskSecurityIDSource); }

                    public NoRelationshipRiskSecurityAltID NoRelationshipRiskSecurityAltID
                    {
                        get
                        {
                            NoRelationshipRiskSecurityAltID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(NoRelationshipRiskSecurityAltID val) { NoRelationshipRiskSecurityAltID = val; }
                    public NoRelationshipRiskSecurityAltID Get(NoRelationshipRiskSecurityAltID val) { GetField(val); return val; }
                    public bool IsSet(NoRelationshipRiskSecurityAltID val) { return IsSetNoRelationshipRiskSecurityAltID(); }
                    public bool IsSetNoRelationshipRiskSecurityAltID() { return IsSetField(Tags.NoRelationshipRiskSecurityAltID); }

                    public RelationshipRiskProduct RelationshipRiskProduct
                    {
                        get
                        {
                            RelationshipRiskProduct val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskProduct val) { RelationshipRiskProduct = val; }
                    public RelationshipRiskProduct Get(RelationshipRiskProduct val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskProduct val) { return IsSetRelationshipRiskProduct(); }
                    public bool IsSetRelationshipRiskProduct() { return IsSetField(Tags.RelationshipRiskProduct); }

                    public RelationshipRiskProductComplex RelationshipRiskProductComplex
                    {
                        get
                        {
                            RelationshipRiskProductComplex val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskProductComplex val) { RelationshipRiskProductComplex = val; }
                    public RelationshipRiskProductComplex Get(RelationshipRiskProductComplex val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskProductComplex val) { return IsSetRelationshipRiskProductComplex(); }
                    public bool IsSetRelationshipRiskProductComplex() { return IsSetField(Tags.RelationshipRiskProductComplex); }

                    public RelationshipRiskSecurityGroup RelationshipRiskSecurityGroup
                    {
                        get
                        {
                            RelationshipRiskSecurityGroup val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSecurityGroup val) { RelationshipRiskSecurityGroup = val; }
                    public RelationshipRiskSecurityGroup Get(RelationshipRiskSecurityGroup val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSecurityGroup val) { return IsSetRelationshipRiskSecurityGroup(); }
                    public bool IsSetRelationshipRiskSecurityGroup() { return IsSetField(Tags.RelationshipRiskSecurityGroup); }

                    public RelationshipRiskCFICode RelationshipRiskCFICode
                    {
                        get
                        {
                            RelationshipRiskCFICode val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskCFICode val) { RelationshipRiskCFICode = val; }
                    public RelationshipRiskCFICode Get(RelationshipRiskCFICode val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskCFICode val) { return IsSetRelationshipRiskCFICode(); }
                    public bool IsSetRelationshipRiskCFICode() { return IsSetField(Tags.RelationshipRiskCFICode); }

                    public RelationshipRiskSecurityType RelationshipRiskSecurityType
                    {
                        get
                        {
                            RelationshipRiskSecurityType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSecurityType val) { RelationshipRiskSecurityType = val; }
                    public RelationshipRiskSecurityType Get(RelationshipRiskSecurityType val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSecurityType val) { return IsSetRelationshipRiskSecurityType(); }
                    public bool IsSetRelationshipRiskSecurityType() { return IsSetField(Tags.RelationshipRiskSecurityType); }

                    public RelationshipRiskSecuritySubType RelationshipRiskSecuritySubType
                    {
                        get
                        {
                            RelationshipRiskSecuritySubType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSecuritySubType val) { RelationshipRiskSecuritySubType = val; }
                    public RelationshipRiskSecuritySubType Get(RelationshipRiskSecuritySubType val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSecuritySubType val) { return IsSetRelationshipRiskSecuritySubType(); }
                    public bool IsSetRelationshipRiskSecuritySubType() { return IsSetField(Tags.RelationshipRiskSecuritySubType); }

                    public RelationshipRiskMaturityMonthYear RelationshipRiskMaturityMonthYear
                    {
                        get
                        {
                            RelationshipRiskMaturityMonthYear val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskMaturityMonthYear val) { RelationshipRiskMaturityMonthYear = val; }
                    public RelationshipRiskMaturityMonthYear Get(RelationshipRiskMaturityMonthYear val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskMaturityMonthYear val) { return IsSetRelationshipRiskMaturityMonthYear(); }
                    public bool IsSetRelationshipRiskMaturityMonthYear() { return IsSetField(Tags.RelationshipRiskMaturityMonthYear); }

                    public RelationshipRiskMaturityTime RelationshipRiskMaturityTime
                    {
                        get
                        {
                            RelationshipRiskMaturityTime val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskMaturityTime val) { RelationshipRiskMaturityTime = val; }
                    public RelationshipRiskMaturityTime Get(RelationshipRiskMaturityTime val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskMaturityTime val) { return IsSetRelationshipRiskMaturityTime(); }
                    public bool IsSetRelationshipRiskMaturityTime() { return IsSetField(Tags.RelationshipRiskMaturityTime); }

                    public RelationshipRiskRestructuringType RelationshipRiskRestructuringType
                    {
                        get
                        {
                            RelationshipRiskRestructuringType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskRestructuringType val) { RelationshipRiskRestructuringType = val; }
                    public RelationshipRiskRestructuringType Get(RelationshipRiskRestructuringType val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskRestructuringType val) { return IsSetRelationshipRiskRestructuringType(); }
                    public bool IsSetRelationshipRiskRestructuringType() { return IsSetField(Tags.RelationshipRiskRestructuringType); }

                    public RelationshipRiskSeniority RelationshipRiskSeniority
                    {
                        get
                        {
                            RelationshipRiskSeniority val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSeniority val) { RelationshipRiskSeniority = val; }
                    public RelationshipRiskSeniority Get(RelationshipRiskSeniority val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSeniority val) { return IsSetRelationshipRiskSeniority(); }
                    public bool IsSetRelationshipRiskSeniority() { return IsSetField(Tags.RelationshipRiskSeniority); }

                    public RelationshipRiskPutOrCall RelationshipRiskPutOrCall
                    {
                        get
                        {
                            RelationshipRiskPutOrCall val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskPutOrCall val) { RelationshipRiskPutOrCall = val; }
                    public RelationshipRiskPutOrCall Get(RelationshipRiskPutOrCall val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskPutOrCall val) { return IsSetRelationshipRiskPutOrCall(); }
                    public bool IsSetRelationshipRiskPutOrCall() { return IsSetField(Tags.RelationshipRiskPutOrCall); }

                    public RelationshipRiskFlexibleIndicator RelationshipRiskFlexibleIndicator
                    {
                        get
                        {
                            RelationshipRiskFlexibleIndicator val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskFlexibleIndicator val) { RelationshipRiskFlexibleIndicator = val; }
                    public RelationshipRiskFlexibleIndicator Get(RelationshipRiskFlexibleIndicator val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskFlexibleIndicator val) { return IsSetRelationshipRiskFlexibleIndicator(); }
                    public bool IsSetRelationshipRiskFlexibleIndicator() { return IsSetField(Tags.RelationshipRiskFlexibleIndicator); }

                    public RelationshipRiskCouponRate RelationshipRiskCouponRate
                    {
                        get
                        {
                            RelationshipRiskCouponRate val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskCouponRate val) { RelationshipRiskCouponRate = val; }
                    public RelationshipRiskCouponRate Get(RelationshipRiskCouponRate val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskCouponRate val) { return IsSetRelationshipRiskCouponRate(); }
                    public bool IsSetRelationshipRiskCouponRate() { return IsSetField(Tags.RelationshipRiskCouponRate); }

                    public RelationshipRiskSecurityExchange RelationshipRiskSecurityExchange
                    {
                        get
                        {
                            RelationshipRiskSecurityExchange val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSecurityExchange val) { RelationshipRiskSecurityExchange = val; }
                    public RelationshipRiskSecurityExchange Get(RelationshipRiskSecurityExchange val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSecurityExchange val) { return IsSetRelationshipRiskSecurityExchange(); }
                    public bool IsSetRelationshipRiskSecurityExchange() { return IsSetField(Tags.RelationshipRiskSecurityExchange); }

                    public RelationshipRiskSecurityDesc RelationshipRiskSecurityDesc
                    {
                        get
                        {
                            RelationshipRiskSecurityDesc val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskSecurityDesc val) { RelationshipRiskSecurityDesc = val; }
                    public RelationshipRiskSecurityDesc Get(RelationshipRiskSecurityDesc val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskSecurityDesc val) { return IsSetRelationshipRiskSecurityDesc(); }
                    public bool IsSetRelationshipRiskSecurityDesc() { return IsSetField(Tags.RelationshipRiskSecurityDesc); }

                    public RelationshipRiskEncodedSecurityDescLen RelationshipRiskEncodedSecurityDescLen
                    {
                        get
                        {
                            RelationshipRiskEncodedSecurityDescLen val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskEncodedSecurityDescLen val) { RelationshipRiskEncodedSecurityDescLen = val; }
                    public RelationshipRiskEncodedSecurityDescLen Get(RelationshipRiskEncodedSecurityDescLen val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskEncodedSecurityDescLen val) { return IsSetRelationshipRiskEncodedSecurityDescLen(); }
                    public bool IsSetRelationshipRiskEncodedSecurityDescLen() { return IsSetField(Tags.RelationshipRiskEncodedSecurityDescLen); }

                    public RelationshipRiskEncodedSecurityDesc RelationshipRiskEncodedSecurityDesc
                    {
                        get
                        {
                            RelationshipRiskEncodedSecurityDesc val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskEncodedSecurityDesc val) { RelationshipRiskEncodedSecurityDesc = val; }
                    public RelationshipRiskEncodedSecurityDesc Get(RelationshipRiskEncodedSecurityDesc val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskEncodedSecurityDesc val) { return IsSetRelationshipRiskEncodedSecurityDesc(); }
                    public bool IsSetRelationshipRiskEncodedSecurityDesc() { return IsSetField(Tags.RelationshipRiskEncodedSecurityDesc); }

                    public RelationshipRiskInstrumentSettlType RelationshipRiskInstrumentSettlType
                    {
                        get
                        {
                            RelationshipRiskInstrumentSettlType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskInstrumentSettlType val) { RelationshipRiskInstrumentSettlType = val; }
                    public RelationshipRiskInstrumentSettlType Get(RelationshipRiskInstrumentSettlType val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskInstrumentSettlType val) { return IsSetRelationshipRiskInstrumentSettlType(); }
                    public bool IsSetRelationshipRiskInstrumentSettlType() { return IsSetField(Tags.RelationshipRiskInstrumentSettlType); }

                    public RelationshipRiskInstrumentMultiplier RelationshipRiskInstrumentMultiplier
                    {
                        get
                        {
                            RelationshipRiskInstrumentMultiplier val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskInstrumentMultiplier val) { RelationshipRiskInstrumentMultiplier = val; }
                    public RelationshipRiskInstrumentMultiplier Get(RelationshipRiskInstrumentMultiplier val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskInstrumentMultiplier val) { return IsSetRelationshipRiskInstrumentMultiplier(); }
                    public bool IsSetRelationshipRiskInstrumentMultiplier() { return IsSetField(Tags.RelationshipRiskInstrumentMultiplier); }

                    public class NoRelationshipRiskSecurityAltIDGroup : Group
                    {
                        public static int[] DefaultFieldOrder = [Tags.RelationshipRiskSecurityAltID, Tags.RelationshipRiskSecurityAltIDSource, 0];

                        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                        public static int[] fieldOrder = {Tags.RelationshipRiskSecurityAltID, Tags.RelationshipRiskSecurityAltIDSource, 0};

                        public NoRelationshipRiskSecurityAltIDGroup()
                          : base(Tags.NoRelationshipRiskSecurityAltID, Tags.RelationshipRiskSecurityAltID, DefaultFieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoRelationshipRiskSecurityAltIDGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public RelationshipRiskSecurityAltID RelationshipRiskSecurityAltID
                        {
                            get
                            {
                                RelationshipRiskSecurityAltID val = new();
                                GetField(val);
                                return val;
                            }
                            set  => SetField(value);
                        }

                        public void Set(RelationshipRiskSecurityAltID val) { RelationshipRiskSecurityAltID = val; }
                        public RelationshipRiskSecurityAltID Get(RelationshipRiskSecurityAltID val) { GetField(val); return val; }
                        public bool IsSet(RelationshipRiskSecurityAltID val) { return IsSetRelationshipRiskSecurityAltID(); }
                        public bool IsSetRelationshipRiskSecurityAltID() { return IsSetField(Tags.RelationshipRiskSecurityAltID); }

                        public RelationshipRiskSecurityAltIDSource RelationshipRiskSecurityAltIDSource
                        {
                            get
                            {
                                RelationshipRiskSecurityAltIDSource val = new();
                                GetField(val);
                                return val;
                            }
                            set  => SetField(value);
                        }

                        public void Set(RelationshipRiskSecurityAltIDSource val) { RelationshipRiskSecurityAltIDSource = val; }
                        public RelationshipRiskSecurityAltIDSource Get(RelationshipRiskSecurityAltIDSource val) { GetField(val); return val; }
                        public bool IsSet(RelationshipRiskSecurityAltIDSource val) { return IsSetRelationshipRiskSecurityAltIDSource(); }
                        public bool IsSetRelationshipRiskSecurityAltIDSource() { return IsSetField(Tags.RelationshipRiskSecurityAltIDSource); }
                    }
                }

                public class NoRelationshipRiskWarningLevelsGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.RelationshipRiskWarningLevelPercent, Tags.RelationshipRiskWarningLevelName, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.RelationshipRiskWarningLevelPercent, Tags.RelationshipRiskWarningLevelName, 0};

                    public NoRelationshipRiskWarningLevelsGroup()
                      : base(Tags.NoRelationshipRiskWarningLevels, Tags.RelationshipRiskWarningLevelPercent, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRelationshipRiskWarningLevelsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public RelationshipRiskWarningLevelPercent RelationshipRiskWarningLevelPercent
                    {
                        get
                        {
                            RelationshipRiskWarningLevelPercent val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskWarningLevelPercent val) { RelationshipRiskWarningLevelPercent = val; }
                    public RelationshipRiskWarningLevelPercent Get(RelationshipRiskWarningLevelPercent val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskWarningLevelPercent val) { return IsSetRelationshipRiskWarningLevelPercent(); }
                    public bool IsSetRelationshipRiskWarningLevelPercent() { return IsSetField(Tags.RelationshipRiskWarningLevelPercent); }

                    public RelationshipRiskWarningLevelName RelationshipRiskWarningLevelName
                    {
                        get
                        {
                            RelationshipRiskWarningLevelName val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(RelationshipRiskWarningLevelName val) { RelationshipRiskWarningLevelName = val; }
                    public RelationshipRiskWarningLevelName Get(RelationshipRiskWarningLevelName val) { GetField(val); return val; }
                    public bool IsSet(RelationshipRiskWarningLevelName val) { return IsSetRelationshipRiskWarningLevelName(); }
                    public bool IsSetRelationshipRiskWarningLevelName() { return IsSetField(Tags.RelationshipRiskWarningLevelName); }
                }
            }

            public class NoPartyRelationshipsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.PartyRelationship, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.PartyRelationship, 0};

                public NoPartyRelationshipsGroup()
                  : base(Tags.NoPartyRelationships, Tags.PartyRelationship, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyRelationshipsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public PartyRelationship PartyRelationship
                {
                    get
                    {
                        PartyRelationship val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(PartyRelationship val) { PartyRelationship = val; }
                public PartyRelationship Get(PartyRelationship val) { GetField(val); return val; }
                public bool IsSet(PartyRelationship val) { return IsSetPartyRelationship(); }
                public bool IsSetPartyRelationship() { return IsSetField(Tags.PartyRelationship); }
            }
        }
    }
}
