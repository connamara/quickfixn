// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class TradingSessionList : Message
{
    public const string MsgType = "BJ";

    public TradingSessionList() : base()
    {
        Header.SetField(new MsgType("BJ"));
    }

    public TradSesReqID TradSesReqID
    {
        get
        {
            TradSesReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradSesReqID val) { TradSesReqID = val; }
    public TradSesReqID Get(TradSesReqID val) { GetField(val); return val; }
    public bool IsSet(TradSesReqID val) { return IsSetTradSesReqID(); }
    public bool IsSetTradSesReqID() { return IsSetField(Tags.TradSesReqID); }

    public NoTradingSessions NoTradingSessions
    {
        get
        {
            NoTradingSessions val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTradingSessions val) { NoTradingSessions = val; }
    public NoTradingSessions Get(NoTradingSessions val) { GetField(val); return val; }
    public bool IsSet(NoTradingSessions val) { return IsSetNoTradingSessions(); }
    public bool IsSetNoTradingSessions() { return IsSetField(Tags.NoTradingSessions); }

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

    public class NoTradingSessionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SecurityExchange, Tags.TradSesMethod, Tags.TradSesMode, Tags.UnsolicitedIndicator, Tags.TradSesStatus, Tags.TradSesStatusRejReason, Tags.TradSesStartTime, Tags.TradSesOpenTime, Tags.TradSesPreCloseTime, Tags.TradSesCloseTime, Tags.TradSesEndTime, Tags.TotalVolumeTraded, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.MarketID, Tags.MarketSegmentID, Tags.TradingSessionDesc, Tags.NoOrdTypeRules, Tags.NoTimeInForceRules, Tags.NoExecInstRules, Tags.NoMatchRules, Tags.NoMDFeedTypes, Tags.TransactTime, Tags.TradSesUpdateAction, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SecurityExchange, Tags.TradSesMethod, Tags.TradSesMode, Tags.UnsolicitedIndicator, Tags.TradSesStatus, Tags.TradSesStatusRejReason, Tags.TradSesStartTime, Tags.TradSesOpenTime, Tags.TradSesPreCloseTime, Tags.TradSesCloseTime, Tags.TradSesEndTime, Tags.TotalVolumeTraded, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.MarketID, Tags.MarketSegmentID, Tags.TradingSessionDesc, Tags.NoOrdTypeRules, Tags.NoTimeInForceRules, Tags.NoExecInstRules, Tags.NoMatchRules, Tags.NoMDFeedTypes, Tags.TransactTime, Tags.TradSesUpdateAction, 0};

        public NoTradingSessionsGroup()
          : base(Tags.NoTradingSessions, Tags.TradingSessionID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTradingSessionsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public TradingSessionID TradingSessionID
        {
            get
            {
                TradingSessionID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionID val) { TradingSessionID = val; }
        public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
        public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
        public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

        public TradingSessionSubID TradingSessionSubID
        {
            get
            {
                TradingSessionSubID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionSubID val) { TradingSessionSubID = val; }
        public TradingSessionSubID Get(TradingSessionSubID val) { GetField(val); return val; }
        public bool IsSet(TradingSessionSubID val) { return IsSetTradingSessionSubID(); }
        public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

        public SecurityExchange SecurityExchange
        {
            get
            {
                SecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityExchange val) { SecurityExchange = val; }
        public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
        public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
        public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

        public TradSesMethod TradSesMethod
        {
            get
            {
                TradSesMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesMethod val) { TradSesMethod = val; }
        public TradSesMethod Get(TradSesMethod val) { GetField(val); return val; }
        public bool IsSet(TradSesMethod val) { return IsSetTradSesMethod(); }
        public bool IsSetTradSesMethod() { return IsSetField(Tags.TradSesMethod); }

        public TradSesMode TradSesMode
        {
            get
            {
                TradSesMode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesMode val) { TradSesMode = val; }
        public TradSesMode Get(TradSesMode val) { GetField(val); return val; }
        public bool IsSet(TradSesMode val) { return IsSetTradSesMode(); }
        public bool IsSetTradSesMode() { return IsSetField(Tags.TradSesMode); }

        public UnsolicitedIndicator UnsolicitedIndicator
        {
            get
            {
                UnsolicitedIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnsolicitedIndicator val) { UnsolicitedIndicator = val; }
        public UnsolicitedIndicator Get(UnsolicitedIndicator val) { GetField(val); return val; }
        public bool IsSet(UnsolicitedIndicator val) { return IsSetUnsolicitedIndicator(); }
        public bool IsSetUnsolicitedIndicator() { return IsSetField(Tags.UnsolicitedIndicator); }

        public TradSesStatus TradSesStatus
        {
            get
            {
                TradSesStatus val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesStatus val) { TradSesStatus = val; }
        public TradSesStatus Get(TradSesStatus val) { GetField(val); return val; }
        public bool IsSet(TradSesStatus val) { return IsSetTradSesStatus(); }
        public bool IsSetTradSesStatus() { return IsSetField(Tags.TradSesStatus); }

        public TradSesStatusRejReason TradSesStatusRejReason
        {
            get
            {
                TradSesStatusRejReason val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesStatusRejReason val) { TradSesStatusRejReason = val; }
        public TradSesStatusRejReason Get(TradSesStatusRejReason val) { GetField(val); return val; }
        public bool IsSet(TradSesStatusRejReason val) { return IsSetTradSesStatusRejReason(); }
        public bool IsSetTradSesStatusRejReason() { return IsSetField(Tags.TradSesStatusRejReason); }

        public TradSesStartTime TradSesStartTime
        {
            get
            {
                TradSesStartTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesStartTime val) { TradSesStartTime = val; }
        public TradSesStartTime Get(TradSesStartTime val) { GetField(val); return val; }
        public bool IsSet(TradSesStartTime val) { return IsSetTradSesStartTime(); }
        public bool IsSetTradSesStartTime() { return IsSetField(Tags.TradSesStartTime); }

        public TradSesOpenTime TradSesOpenTime
        {
            get
            {
                TradSesOpenTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesOpenTime val) { TradSesOpenTime = val; }
        public TradSesOpenTime Get(TradSesOpenTime val) { GetField(val); return val; }
        public bool IsSet(TradSesOpenTime val) { return IsSetTradSesOpenTime(); }
        public bool IsSetTradSesOpenTime() { return IsSetField(Tags.TradSesOpenTime); }

        public TradSesPreCloseTime TradSesPreCloseTime
        {
            get
            {
                TradSesPreCloseTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesPreCloseTime val) { TradSesPreCloseTime = val; }
        public TradSesPreCloseTime Get(TradSesPreCloseTime val) { GetField(val); return val; }
        public bool IsSet(TradSesPreCloseTime val) { return IsSetTradSesPreCloseTime(); }
        public bool IsSetTradSesPreCloseTime() { return IsSetField(Tags.TradSesPreCloseTime); }

        public TradSesCloseTime TradSesCloseTime
        {
            get
            {
                TradSesCloseTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesCloseTime val) { TradSesCloseTime = val; }
        public TradSesCloseTime Get(TradSesCloseTime val) { GetField(val); return val; }
        public bool IsSet(TradSesCloseTime val) { return IsSetTradSesCloseTime(); }
        public bool IsSetTradSesCloseTime() { return IsSetField(Tags.TradSesCloseTime); }

        public TradSesEndTime TradSesEndTime
        {
            get
            {
                TradSesEndTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesEndTime val) { TradSesEndTime = val; }
        public TradSesEndTime Get(TradSesEndTime val) { GetField(val); return val; }
        public bool IsSet(TradSesEndTime val) { return IsSetTradSesEndTime(); }
        public bool IsSetTradSesEndTime() { return IsSetField(Tags.TradSesEndTime); }

        public TotalVolumeTraded TotalVolumeTraded
        {
            get
            {
                TotalVolumeTraded val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TotalVolumeTraded val) { TotalVolumeTraded = val; }
        public TotalVolumeTraded Get(TotalVolumeTraded val) { GetField(val); return val; }
        public bool IsSet(TotalVolumeTraded val) { return IsSetTotalVolumeTraded(); }
        public bool IsSetTotalVolumeTraded() { return IsSetField(Tags.TotalVolumeTraded); }

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

        public MarketID MarketID
        {
            get
            {
                MarketID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MarketID val) { MarketID = val; }
        public MarketID Get(MarketID val) { GetField(val); return val; }
        public bool IsSet(MarketID val) { return IsSetMarketID(); }
        public bool IsSetMarketID() { return IsSetField(Tags.MarketID); }

        public MarketSegmentID MarketSegmentID
        {
            get
            {
                MarketSegmentID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MarketSegmentID val) { MarketSegmentID = val; }
        public MarketSegmentID Get(MarketSegmentID val) { GetField(val); return val; }
        public bool IsSet(MarketSegmentID val) { return IsSetMarketSegmentID(); }
        public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

        public TradingSessionDesc TradingSessionDesc
        {
            get
            {
                TradingSessionDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionDesc val) { TradingSessionDesc = val; }
        public TradingSessionDesc Get(TradingSessionDesc val) { GetField(val); return val; }
        public bool IsSet(TradingSessionDesc val) { return IsSetTradingSessionDesc(); }
        public bool IsSetTradingSessionDesc() { return IsSetField(Tags.TradingSessionDesc); }

        public NoOrdTypeRules NoOrdTypeRules
        {
            get
            {
                NoOrdTypeRules val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoOrdTypeRules val) { NoOrdTypeRules = val; }
        public NoOrdTypeRules Get(NoOrdTypeRules val) { GetField(val); return val; }
        public bool IsSet(NoOrdTypeRules val) { return IsSetNoOrdTypeRules(); }
        public bool IsSetNoOrdTypeRules() { return IsSetField(Tags.NoOrdTypeRules); }

        public NoTimeInForceRules NoTimeInForceRules
        {
            get
            {
                NoTimeInForceRules val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoTimeInForceRules val) { NoTimeInForceRules = val; }
        public NoTimeInForceRules Get(NoTimeInForceRules val) { GetField(val); return val; }
        public bool IsSet(NoTimeInForceRules val) { return IsSetNoTimeInForceRules(); }
        public bool IsSetNoTimeInForceRules() { return IsSetField(Tags.NoTimeInForceRules); }

        public NoExecInstRules NoExecInstRules
        {
            get
            {
                NoExecInstRules val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoExecInstRules val) { NoExecInstRules = val; }
        public NoExecInstRules Get(NoExecInstRules val) { GetField(val); return val; }
        public bool IsSet(NoExecInstRules val) { return IsSetNoExecInstRules(); }
        public bool IsSetNoExecInstRules() { return IsSetField(Tags.NoExecInstRules); }

        public NoMatchRules NoMatchRules
        {
            get
            {
                NoMatchRules val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoMatchRules val) { NoMatchRules = val; }
        public NoMatchRules Get(NoMatchRules val) { GetField(val); return val; }
        public bool IsSet(NoMatchRules val) { return IsSetNoMatchRules(); }
        public bool IsSetNoMatchRules() { return IsSetField(Tags.NoMatchRules); }

        public NoMDFeedTypes NoMDFeedTypes
        {
            get
            {
                NoMDFeedTypes val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoMDFeedTypes val) { NoMDFeedTypes = val; }
        public NoMDFeedTypes Get(NoMDFeedTypes val) { GetField(val); return val; }
        public bool IsSet(NoMDFeedTypes val) { return IsSetNoMDFeedTypes(); }
        public bool IsSetNoMDFeedTypes() { return IsSetField(Tags.NoMDFeedTypes); }

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

        public TradSesUpdateAction TradSesUpdateAction
        {
            get
            {
                TradSesUpdateAction val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradSesUpdateAction val) { TradSesUpdateAction = val; }
        public TradSesUpdateAction Get(TradSesUpdateAction val) { GetField(val); return val; }
        public bool IsSet(TradSesUpdateAction val) { return IsSetTradSesUpdateAction(); }
        public bool IsSetTradSesUpdateAction() { return IsSetField(Tags.TradSesUpdateAction); }

        public class NoOrdTypeRulesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.OrdType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.OrdType, 0};

            public NoOrdTypeRulesGroup()
              : base(Tags.NoOrdTypeRules, Tags.OrdType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoOrdTypeRulesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public OrdType OrdType
            {
                get
                {
                    OrdType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(OrdType val) { OrdType = val; }
            public OrdType Get(OrdType val) { GetField(val); return val; }
            public bool IsSet(OrdType val) { return IsSetOrdType(); }
            public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }
        }

        public class NoTimeInForceRulesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.TimeInForce, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.TimeInForce, 0};

            public NoTimeInForceRulesGroup()
              : base(Tags.NoTimeInForceRules, Tags.TimeInForce, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoTimeInForceRulesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public TimeInForce TimeInForce
            {
                get
                {
                    TimeInForce val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(TimeInForce val) { TimeInForce = val; }
            public TimeInForce Get(TimeInForce val) { GetField(val); return val; }
            public bool IsSet(TimeInForce val) { return IsSetTimeInForce(); }
            public bool IsSetTimeInForce() { return IsSetField(Tags.TimeInForce); }
        }

        public class NoExecInstRulesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ExecInstValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.ExecInstValue, 0};

            public NoExecInstRulesGroup()
              : base(Tags.NoExecInstRules, Tags.ExecInstValue, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoExecInstRulesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ExecInstValue ExecInstValue
            {
                get
                {
                    ExecInstValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ExecInstValue val) { ExecInstValue = val; }
            public ExecInstValue Get(ExecInstValue val) { GetField(val); return val; }
            public bool IsSet(ExecInstValue val) { return IsSetExecInstValue(); }
            public bool IsSetExecInstValue() { return IsSetField(Tags.ExecInstValue); }
        }

        public class NoMatchRulesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.MatchAlgorithm, Tags.MatchType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.MatchAlgorithm, Tags.MatchType, 0};

            public NoMatchRulesGroup()
              : base(Tags.NoMatchRules, Tags.MatchAlgorithm, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoMatchRulesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public MatchAlgorithm MatchAlgorithm
            {
                get
                {
                    MatchAlgorithm val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MatchAlgorithm val) { MatchAlgorithm = val; }
            public MatchAlgorithm Get(MatchAlgorithm val) { GetField(val); return val; }
            public bool IsSet(MatchAlgorithm val) { return IsSetMatchAlgorithm(); }
            public bool IsSetMatchAlgorithm() { return IsSetField(Tags.MatchAlgorithm); }

            public MatchType MatchType
            {
                get
                {
                    MatchType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MatchType val) { MatchType = val; }
            public MatchType Get(MatchType val) { GetField(val); return val; }
            public bool IsSet(MatchType val) { return IsSetMatchType(); }
            public bool IsSetMatchType() { return IsSetField(Tags.MatchType); }
        }

        public class NoMDFeedTypesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.MDFeedType, Tags.MarketDepth, Tags.MDBookType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.MDFeedType, Tags.MarketDepth, Tags.MDBookType, 0};

            public NoMDFeedTypesGroup()
              : base(Tags.NoMDFeedTypes, Tags.MDFeedType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoMDFeedTypesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public MDFeedType MDFeedType
            {
                get
                {
                    MDFeedType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MDFeedType val) { MDFeedType = val; }
            public MDFeedType Get(MDFeedType val) { GetField(val); return val; }
            public bool IsSet(MDFeedType val) { return IsSetMDFeedType(); }
            public bool IsSetMDFeedType() { return IsSetField(Tags.MDFeedType); }

            public MarketDepth MarketDepth
            {
                get
                {
                    MarketDepth val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MarketDepth val) { MarketDepth = val; }
            public MarketDepth Get(MarketDepth val) { GetField(val); return val; }
            public bool IsSet(MarketDepth val) { return IsSetMarketDepth(); }
            public bool IsSetMarketDepth() { return IsSetField(Tags.MarketDepth); }

            public MDBookType MDBookType
            {
                get
                {
                    MDBookType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MDBookType val) { MDBookType = val; }
            public MDBookType Get(MDBookType val) { GetField(val); return val; }
            public bool IsSet(MDBookType val) { return IsSetMDBookType(); }
            public bool IsSetMDBookType() { return IsSetField(Tags.MDBookType); }
        }
    }
}
