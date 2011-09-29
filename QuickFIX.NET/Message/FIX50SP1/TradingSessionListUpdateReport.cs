// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class TradingSessionListUpdateReport : Message
        {
            public const string MsgType = "BS";

            public TradingSessionListUpdateReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BS"));
            }


            public QuickFix.Fields.TradSesReqID tradSesReqID
            { 
                get 
                {
                    QuickFix.Fields.TradSesReqID val = new QuickFix.Fields.TradSesReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesReqID val) 
            { 
                this.tradSesReqID = val;
            }
            
            public QuickFix.Fields.TradSesReqID Get(QuickFix.Fields.TradSesReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesReqID val) 
            { 
                return IsSetTradSesReqID();
            }
            
            public bool IsSetTradSesReqID() 
            { 
                return IsSetField(Tags.TradSesReqID);
            }
            public QuickFix.Fields.TradSesUpdateAction tradSesUpdateAction
            { 
                get 
                {
                    QuickFix.Fields.TradSesUpdateAction val = new QuickFix.Fields.TradSesUpdateAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesUpdateAction val) 
            { 
                this.tradSesUpdateAction = val;
            }
            
            public QuickFix.Fields.TradSesUpdateAction Get(QuickFix.Fields.TradSesUpdateAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesUpdateAction val) 
            { 
                return IsSetTradSesUpdateAction();
            }
            
            public bool IsSetTradSesUpdateAction() 
            { 
                return IsSetField(Tags.TradSesUpdateAction);
            }
            public QuickFix.Fields.NoTradingSessions noTradingSessions
            { 
                get 
                {
                    QuickFix.Fields.NoTradingSessions val = new QuickFix.Fields.NoTradingSessions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoTradingSessions val) 
            { 
                this.noTradingSessions = val;
            }
            
            public QuickFix.Fields.NoTradingSessions Get(QuickFix.Fields.NoTradingSessions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoTradingSessions val) 
            { 
                return IsSetNoTradingSessions();
            }
            
            public bool IsSetNoTradingSessions() 
            { 
                return IsSetField(Tags.NoTradingSessions);
            }
            public QuickFix.Fields.ApplID applID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplID val) 
            { 
                return IsSetApplID();
            }
            
            public bool IsSetApplID() 
            { 
                return IsSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return IsSetApplSeqNum();
            }
            
            public bool IsSetApplSeqNum() 
            { 
                return IsSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return IsSetApplLastSeqNum();
            }
            
            public bool IsSetApplLastSeqNum() 
            { 
                return IsSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return IsSetApplResendFlag();
            }
            
            public bool IsSetApplResendFlag() 
            { 
                return IsSetField(Tags.ApplResendFlag);
            }
            public class NoTradingSessions : Group
            {
                public NoTradingSessions() 
                  :base( Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SecurityExchange, Tags.TradSesMethod, Tags.TradSesMode, Tags.UnsolicitedIndicator, Tags.TradSesStatus, Tags.TradSesStatusRejReason, Tags.TradSesStartTime, Tags.TradSesOpenTime, Tags.TradSesPreCloseTime, Tags.TradSesCloseTime, Tags.TradSesEndTime, Tags.TotalVolumeTraded, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.MarketID, Tags.MarketSegmentID, Tags.TradingSessionDesc, Tags.NoOrdTypeRules, Tags.NoTimeInForceRules, Tags.NoExecInstRules, Tags.NoMatchRules, Tags.NoMDFeedTypes, 0};
                            public QuickFix.Fields.TradingSessionID tradingSessionID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionID val) 
                { 
                    this.tradingSessionID = val;
                }
                
                public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionID val) 
                { 
                    return IsSetTradingSessionID();
                }
                
                public bool IsSetTradingSessionID() 
                { 
                    return IsSetField(Tags.TradingSessionID);
                }
                public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    this.tradingSessionSubID = val;
                }
                
                public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    return IsSetTradingSessionSubID();
                }
                
                public bool IsSetTradingSessionSubID() 
                { 
                    return IsSetField(Tags.TradingSessionSubID);
                }
                public QuickFix.Fields.SecurityExchange securityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityExchange val) 
                { 
                    this.securityExchange = val;
                }
                
                public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityExchange val) 
                { 
                    return IsSetSecurityExchange();
                }
                
                public bool IsSetSecurityExchange() 
                { 
                    return IsSetField(Tags.SecurityExchange);
                }
                public QuickFix.Fields.TradSesMethod tradSesMethod
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesMethod val = new QuickFix.Fields.TradSesMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesMethod val) 
                { 
                    this.tradSesMethod = val;
                }
                
                public QuickFix.Fields.TradSesMethod Get(QuickFix.Fields.TradSesMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesMethod val) 
                { 
                    return IsSetTradSesMethod();
                }
                
                public bool IsSetTradSesMethod() 
                { 
                    return IsSetField(Tags.TradSesMethod);
                }
                public QuickFix.Fields.TradSesMode tradSesMode
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesMode val = new QuickFix.Fields.TradSesMode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesMode val) 
                { 
                    this.tradSesMode = val;
                }
                
                public QuickFix.Fields.TradSesMode Get(QuickFix.Fields.TradSesMode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesMode val) 
                { 
                    return IsSetTradSesMode();
                }
                
                public bool IsSetTradSesMode() 
                { 
                    return IsSetField(Tags.TradSesMode);
                }
                public QuickFix.Fields.UnsolicitedIndicator unsolicitedIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.UnsolicitedIndicator val = new QuickFix.Fields.UnsolicitedIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnsolicitedIndicator val) 
                { 
                    this.unsolicitedIndicator = val;
                }
                
                public QuickFix.Fields.UnsolicitedIndicator Get(QuickFix.Fields.UnsolicitedIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnsolicitedIndicator val) 
                { 
                    return IsSetUnsolicitedIndicator();
                }
                
                public bool IsSetUnsolicitedIndicator() 
                { 
                    return IsSetField(Tags.UnsolicitedIndicator);
                }
                public QuickFix.Fields.TradSesStatus tradSesStatus
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesStatus val = new QuickFix.Fields.TradSesStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesStatus val) 
                { 
                    this.tradSesStatus = val;
                }
                
                public QuickFix.Fields.TradSesStatus Get(QuickFix.Fields.TradSesStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesStatus val) 
                { 
                    return IsSetTradSesStatus();
                }
                
                public bool IsSetTradSesStatus() 
                { 
                    return IsSetField(Tags.TradSesStatus);
                }
                public QuickFix.Fields.TradSesStatusRejReason tradSesStatusRejReason
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesStatusRejReason val = new QuickFix.Fields.TradSesStatusRejReason();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    this.tradSesStatusRejReason = val;
                }
                
                public QuickFix.Fields.TradSesStatusRejReason Get(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    return IsSetTradSesStatusRejReason();
                }
                
                public bool IsSetTradSesStatusRejReason() 
                { 
                    return IsSetField(Tags.TradSesStatusRejReason);
                }
                public QuickFix.Fields.TradSesStartTime tradSesStartTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesStartTime val = new QuickFix.Fields.TradSesStartTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesStartTime val) 
                { 
                    this.tradSesStartTime = val;
                }
                
                public QuickFix.Fields.TradSesStartTime Get(QuickFix.Fields.TradSesStartTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesStartTime val) 
                { 
                    return IsSetTradSesStartTime();
                }
                
                public bool IsSetTradSesStartTime() 
                { 
                    return IsSetField(Tags.TradSesStartTime);
                }
                public QuickFix.Fields.TradSesOpenTime tradSesOpenTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesOpenTime val = new QuickFix.Fields.TradSesOpenTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesOpenTime val) 
                { 
                    this.tradSesOpenTime = val;
                }
                
                public QuickFix.Fields.TradSesOpenTime Get(QuickFix.Fields.TradSesOpenTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesOpenTime val) 
                { 
                    return IsSetTradSesOpenTime();
                }
                
                public bool IsSetTradSesOpenTime() 
                { 
                    return IsSetField(Tags.TradSesOpenTime);
                }
                public QuickFix.Fields.TradSesPreCloseTime tradSesPreCloseTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesPreCloseTime val = new QuickFix.Fields.TradSesPreCloseTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesPreCloseTime val) 
                { 
                    this.tradSesPreCloseTime = val;
                }
                
                public QuickFix.Fields.TradSesPreCloseTime Get(QuickFix.Fields.TradSesPreCloseTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesPreCloseTime val) 
                { 
                    return IsSetTradSesPreCloseTime();
                }
                
                public bool IsSetTradSesPreCloseTime() 
                { 
                    return IsSetField(Tags.TradSesPreCloseTime);
                }
                public QuickFix.Fields.TradSesCloseTime tradSesCloseTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesCloseTime val = new QuickFix.Fields.TradSesCloseTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesCloseTime val) 
                { 
                    this.tradSesCloseTime = val;
                }
                
                public QuickFix.Fields.TradSesCloseTime Get(QuickFix.Fields.TradSesCloseTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesCloseTime val) 
                { 
                    return IsSetTradSesCloseTime();
                }
                
                public bool IsSetTradSesCloseTime() 
                { 
                    return IsSetField(Tags.TradSesCloseTime);
                }
                public QuickFix.Fields.TradSesEndTime tradSesEndTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesEndTime val = new QuickFix.Fields.TradSesEndTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesEndTime val) 
                { 
                    this.tradSesEndTime = val;
                }
                
                public QuickFix.Fields.TradSesEndTime Get(QuickFix.Fields.TradSesEndTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesEndTime val) 
                { 
                    return IsSetTradSesEndTime();
                }
                
                public bool IsSetTradSesEndTime() 
                { 
                    return IsSetField(Tags.TradSesEndTime);
                }
                public QuickFix.Fields.TotalVolumeTraded totalVolumeTraded
                { 
                    get 
                    {
                        QuickFix.Fields.TotalVolumeTraded val = new QuickFix.Fields.TotalVolumeTraded();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    this.totalVolumeTraded = val;
                }
                
                public QuickFix.Fields.TotalVolumeTraded Get(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    return IsSetTotalVolumeTraded();
                }
                
                public bool IsSetTotalVolumeTraded() 
                { 
                    return IsSetField(Tags.TotalVolumeTraded);
                }
                public QuickFix.Fields.Text text
                { 
                    get 
                    {
                        QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Text val) 
                { 
                    this.text = val;
                }
                
                public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Text val) 
                { 
                    return IsSetText();
                }
                
                public bool IsSetText() 
                { 
                    return IsSetField(Tags.Text);
                }
                public QuickFix.Fields.EncodedTextLen encodedTextLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedTextLen val) 
                { 
                    this.encodedTextLen = val;
                }
                
                public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
                { 
                    return IsSetEncodedTextLen();
                }
                
                public bool IsSetEncodedTextLen() 
                { 
                    return IsSetField(Tags.EncodedTextLen);
                }
                public QuickFix.Fields.EncodedText encodedText
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedText val) 
                { 
                    this.encodedText = val;
                }
                
                public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedText val) 
                { 
                    return IsSetEncodedText();
                }
                
                public bool IsSetEncodedText() 
                { 
                    return IsSetField(Tags.EncodedText);
                }
                public QuickFix.Fields.MarketID marketID
                { 
                    get 
                    {
                        QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MarketID val) 
                { 
                    this.marketID = val;
                }
                
                public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MarketID val) 
                { 
                    return IsSetMarketID();
                }
                
                public bool IsSetMarketID() 
                { 
                    return IsSetField(Tags.MarketID);
                }
                public QuickFix.Fields.MarketSegmentID marketSegmentID
                { 
                    get 
                    {
                        QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MarketSegmentID val) 
                { 
                    this.marketSegmentID = val;
                }
                
                public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MarketSegmentID val) 
                { 
                    return IsSetMarketSegmentID();
                }
                
                public bool IsSetMarketSegmentID() 
                { 
                    return IsSetField(Tags.MarketSegmentID);
                }
                public QuickFix.Fields.TradingSessionDesc tradingSessionDesc
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionDesc val = new QuickFix.Fields.TradingSessionDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    this.tradingSessionDesc = val;
                }
                
                public QuickFix.Fields.TradingSessionDesc Get(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    return IsSetTradingSessionDesc();
                }
                
                public bool IsSetTradingSessionDesc() 
                { 
                    return IsSetField(Tags.TradingSessionDesc);
                }
                public QuickFix.Fields.NoOrdTypeRules noOrdTypeRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoOrdTypeRules val = new QuickFix.Fields.NoOrdTypeRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    this.noOrdTypeRules = val;
                }
                
                public QuickFix.Fields.NoOrdTypeRules Get(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    return IsSetNoOrdTypeRules();
                }
                
                public bool IsSetNoOrdTypeRules() 
                { 
                    return IsSetField(Tags.NoOrdTypeRules);
                }
                public QuickFix.Fields.NoTimeInForceRules noTimeInForceRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoTimeInForceRules val = new QuickFix.Fields.NoTimeInForceRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    this.noTimeInForceRules = val;
                }
                
                public QuickFix.Fields.NoTimeInForceRules Get(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    return IsSetNoTimeInForceRules();
                }
                
                public bool IsSetNoTimeInForceRules() 
                { 
                    return IsSetField(Tags.NoTimeInForceRules);
                }
                public QuickFix.Fields.NoExecInstRules noExecInstRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoExecInstRules val = new QuickFix.Fields.NoExecInstRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoExecInstRules val) 
                { 
                    this.noExecInstRules = val;
                }
                
                public QuickFix.Fields.NoExecInstRules Get(QuickFix.Fields.NoExecInstRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoExecInstRules val) 
                { 
                    return IsSetNoExecInstRules();
                }
                
                public bool IsSetNoExecInstRules() 
                { 
                    return IsSetField(Tags.NoExecInstRules);
                }
                public QuickFix.Fields.NoMatchRules noMatchRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoMatchRules val = new QuickFix.Fields.NoMatchRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoMatchRules val) 
                { 
                    this.noMatchRules = val;
                }
                
                public QuickFix.Fields.NoMatchRules Get(QuickFix.Fields.NoMatchRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoMatchRules val) 
                { 
                    return IsSetNoMatchRules();
                }
                
                public bool IsSetNoMatchRules() 
                { 
                    return IsSetField(Tags.NoMatchRules);
                }
                public QuickFix.Fields.NoMDFeedTypes noMDFeedTypes
                { 
                    get 
                    {
                        QuickFix.Fields.NoMDFeedTypes val = new QuickFix.Fields.NoMDFeedTypes();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    this.noMDFeedTypes = val;
                }
                
                public QuickFix.Fields.NoMDFeedTypes Get(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    return IsSetNoMDFeedTypes();
                }
                
                public bool IsSetNoMDFeedTypes() 
                { 
                    return IsSetField(Tags.NoMDFeedTypes);
                }
                            public class NoOrdTypeRules : Group
                {
                    public NoOrdTypeRules() 
                      :base( Tags.NoOrdTypeRules, Tags.OrdType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.OrdType, 0};
                                    public QuickFix.Fields.OrdType ordType
                    { 
                        get 
                        {
                            QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OrdType val) 
                    { 
                        this.ordType = val;
                    }
                    
                    public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OrdType val) 
                    { 
                        return IsSetOrdType();
                    }
                    
                    public bool IsSetOrdType() 
                    { 
                        return IsSetField(Tags.OrdType);
                    }
                
                }
                public class NoTimeInForceRules : Group
                {
                    public NoTimeInForceRules() 
                      :base( Tags.NoTimeInForceRules, Tags.TimeInForce, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.TimeInForce, 0};
                                    public QuickFix.Fields.TimeInForce timeInForce
                    { 
                        get 
                        {
                            QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TimeInForce val) 
                    { 
                        this.timeInForce = val;
                    }
                    
                    public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TimeInForce val) 
                    { 
                        return IsSetTimeInForce();
                    }
                    
                    public bool IsSetTimeInForce() 
                    { 
                        return IsSetField(Tags.TimeInForce);
                    }
                
                }
                public class NoExecInstRules : Group
                {
                    public NoExecInstRules() 
                      :base( Tags.NoExecInstRules, Tags.ExecInstValue, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.ExecInstValue, 0};
                                    public QuickFix.Fields.ExecInstValue execInstValue
                    { 
                        get 
                        {
                            QuickFix.Fields.ExecInstValue val = new QuickFix.Fields.ExecInstValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ExecInstValue val) 
                    { 
                        this.execInstValue = val;
                    }
                    
                    public QuickFix.Fields.ExecInstValue Get(QuickFix.Fields.ExecInstValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ExecInstValue val) 
                    { 
                        return IsSetExecInstValue();
                    }
                    
                    public bool IsSetExecInstValue() 
                    { 
                        return IsSetField(Tags.ExecInstValue);
                    }
                
                }
                public class NoMatchRules : Group
                {
                    public NoMatchRules() 
                      :base( Tags.NoMatchRules, Tags.MatchAlgorithm, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.MatchAlgorithm, Tags.MatchType, 0};
                                    public QuickFix.Fields.MatchAlgorithm matchAlgorithm
                    { 
                        get 
                        {
                            QuickFix.Fields.MatchAlgorithm val = new QuickFix.Fields.MatchAlgorithm();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        this.matchAlgorithm = val;
                    }
                    
                    public QuickFix.Fields.MatchAlgorithm Get(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        return IsSetMatchAlgorithm();
                    }
                    
                    public bool IsSetMatchAlgorithm() 
                    { 
                        return IsSetField(Tags.MatchAlgorithm);
                    }
                    public QuickFix.Fields.MatchType matchType
                    { 
                        get 
                        {
                            QuickFix.Fields.MatchType val = new QuickFix.Fields.MatchType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MatchType val) 
                    { 
                        this.matchType = val;
                    }
                    
                    public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MatchType val) 
                    { 
                        return IsSetMatchType();
                    }
                    
                    public bool IsSetMatchType() 
                    { 
                        return IsSetField(Tags.MatchType);
                    }
                
                }
                public class NoMDFeedTypes : Group
                {
                    public NoMDFeedTypes() 
                      :base( Tags.NoMDFeedTypes, Tags.MDFeedType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.MDFeedType, Tags.MarketDepth, Tags.MDBookType, 0};
                                    public QuickFix.Fields.MDFeedType mDFeedType
                    { 
                        get 
                        {
                            QuickFix.Fields.MDFeedType val = new QuickFix.Fields.MDFeedType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MDFeedType val) 
                    { 
                        this.mDFeedType = val;
                    }
                    
                    public QuickFix.Fields.MDFeedType Get(QuickFix.Fields.MDFeedType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MDFeedType val) 
                    { 
                        return IsSetMDFeedType();
                    }
                    
                    public bool IsSetMDFeedType() 
                    { 
                        return IsSetField(Tags.MDFeedType);
                    }
                    public QuickFix.Fields.MarketDepth marketDepth
                    { 
                        get 
                        {
                            QuickFix.Fields.MarketDepth val = new QuickFix.Fields.MarketDepth();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MarketDepth val) 
                    { 
                        this.marketDepth = val;
                    }
                    
                    public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MarketDepth val) 
                    { 
                        return IsSetMarketDepth();
                    }
                    
                    public bool IsSetMarketDepth() 
                    { 
                        return IsSetField(Tags.MarketDepth);
                    }
                    public QuickFix.Fields.MDBookType mDBookType
                    { 
                        get 
                        {
                            QuickFix.Fields.MDBookType val = new QuickFix.Fields.MDBookType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MDBookType val) 
                    { 
                        this.mDBookType = val;
                    }
                    
                    public QuickFix.Fields.MDBookType Get(QuickFix.Fields.MDBookType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MDBookType val) 
                    { 
                        return IsSetMDBookType();
                    }
                    
                    public bool IsSetMDBookType() 
                    { 
                        return IsSetField(Tags.MDBookType);
                    }
                
                }
            }
        }
    }
}
