// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class TradingSessionList : Message
        {
            public const string MsgType = "BJ";

            public TradingSessionList() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BJ"));
            }


            public QuickFix.Fields.TradSesReqID tradSesReqID
            { 
                get 
                {
                    QuickFix.Fields.TradSesReqID val = new QuickFix.Fields.TradSesReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesReqID val) 
            { 
                this.tradSesReqID = val;
            }
            
            public QuickFix.Fields.TradSesReqID get(QuickFix.Fields.TradSesReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesReqID val) 
            { 
                return isSetTradSesReqID();
            }
            
            public bool isSetTradSesReqID() 
            { 
                return isSetField(Tags.TradSesReqID);
            }
            public QuickFix.Fields.NoTradingSessions noTradingSessions
            { 
                get 
                {
                    QuickFix.Fields.NoTradingSessions val = new QuickFix.Fields.NoTradingSessions();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoTradingSessions val) 
            { 
                this.noTradingSessions = val;
            }
            
            public QuickFix.Fields.NoTradingSessions get(QuickFix.Fields.NoTradingSessions val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoTradingSessions val) 
            { 
                return isSetNoTradingSessions();
            }
            
            public bool isSetNoTradingSessions() 
            { 
                return isSetField(Tags.NoTradingSessions);
            }
            public QuickFix.Fields.ApplID applID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID get(QuickFix.Fields.ApplID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplID val) 
            { 
                return isSetApplID();
            }
            
            public bool isSetApplID() 
            { 
                return isSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum get(QuickFix.Fields.ApplSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return isSetApplSeqNum();
            }
            
            public bool isSetApplSeqNum() 
            { 
                return isSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return isSetApplLastSeqNum();
            }
            
            public bool isSetApplLastSeqNum() 
            { 
                return isSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag get(QuickFix.Fields.ApplResendFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return isSetApplResendFlag();
            }
            
            public bool isSetApplResendFlag() 
            { 
                return isSetField(Tags.ApplResendFlag);
            }
            public class NoTradingSessions : Group
            {
                public NoTradingSessions() 
                  :base( Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SecurityExchange, Tags.TradSesMethod, Tags.TradSesMode, Tags.UnsolicitedIndicator, Tags.TradSesStatus, Tags.TradSesStatusRejReason, Tags.TradSesStartTime, Tags.TradSesOpenTime, Tags.TradSesPreCloseTime, Tags.TradSesCloseTime, Tags.TradSesEndTime, Tags.TotalVolumeTraded, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.MarketID, Tags.MarketSegmentID, Tags.TradingSessionDesc, Tags.NoOrdTypeRules, Tags.NoTimeInForceRules, Tags.NoExecInstRules, Tags.NoMatchRules, Tags.NoMDFeedTypes, Tags.TransactTime, Tags.TradSesUpdateAction, 0};
                            public QuickFix.Fields.TradingSessionID tradingSessionID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradingSessionID val) 
                { 
                    this.tradingSessionID = val;
                }
                
                public QuickFix.Fields.TradingSessionID get(QuickFix.Fields.TradingSessionID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradingSessionID val) 
                { 
                    return isSetTradingSessionID();
                }
                
                public bool isSetTradingSessionID() 
                { 
                    return isSetField(Tags.TradingSessionID);
                }
                public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    this.tradingSessionSubID = val;
                }
                
                public QuickFix.Fields.TradingSessionSubID get(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    return isSetTradingSessionSubID();
                }
                
                public bool isSetTradingSessionSubID() 
                { 
                    return isSetField(Tags.TradingSessionSubID);
                }
                public QuickFix.Fields.SecurityExchange securityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityExchange val) 
                { 
                    this.securityExchange = val;
                }
                
                public QuickFix.Fields.SecurityExchange get(QuickFix.Fields.SecurityExchange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityExchange val) 
                { 
                    return isSetSecurityExchange();
                }
                
                public bool isSetSecurityExchange() 
                { 
                    return isSetField(Tags.SecurityExchange);
                }
                public QuickFix.Fields.TradSesMethod tradSesMethod
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesMethod val = new QuickFix.Fields.TradSesMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesMethod val) 
                { 
                    this.tradSesMethod = val;
                }
                
                public QuickFix.Fields.TradSesMethod get(QuickFix.Fields.TradSesMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesMethod val) 
                { 
                    return isSetTradSesMethod();
                }
                
                public bool isSetTradSesMethod() 
                { 
                    return isSetField(Tags.TradSesMethod);
                }
                public QuickFix.Fields.TradSesMode tradSesMode
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesMode val = new QuickFix.Fields.TradSesMode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesMode val) 
                { 
                    this.tradSesMode = val;
                }
                
                public QuickFix.Fields.TradSesMode get(QuickFix.Fields.TradSesMode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesMode val) 
                { 
                    return isSetTradSesMode();
                }
                
                public bool isSetTradSesMode() 
                { 
                    return isSetField(Tags.TradSesMode);
                }
                public QuickFix.Fields.UnsolicitedIndicator unsolicitedIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.UnsolicitedIndicator val = new QuickFix.Fields.UnsolicitedIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnsolicitedIndicator val) 
                { 
                    this.unsolicitedIndicator = val;
                }
                
                public QuickFix.Fields.UnsolicitedIndicator get(QuickFix.Fields.UnsolicitedIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnsolicitedIndicator val) 
                { 
                    return isSetUnsolicitedIndicator();
                }
                
                public bool isSetUnsolicitedIndicator() 
                { 
                    return isSetField(Tags.UnsolicitedIndicator);
                }
                public QuickFix.Fields.TradSesStatus tradSesStatus
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesStatus val = new QuickFix.Fields.TradSesStatus();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesStatus val) 
                { 
                    this.tradSesStatus = val;
                }
                
                public QuickFix.Fields.TradSesStatus get(QuickFix.Fields.TradSesStatus val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesStatus val) 
                { 
                    return isSetTradSesStatus();
                }
                
                public bool isSetTradSesStatus() 
                { 
                    return isSetField(Tags.TradSesStatus);
                }
                public QuickFix.Fields.TradSesStatusRejReason tradSesStatusRejReason
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesStatusRejReason val = new QuickFix.Fields.TradSesStatusRejReason();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    this.tradSesStatusRejReason = val;
                }
                
                public QuickFix.Fields.TradSesStatusRejReason get(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    return isSetTradSesStatusRejReason();
                }
                
                public bool isSetTradSesStatusRejReason() 
                { 
                    return isSetField(Tags.TradSesStatusRejReason);
                }
                public QuickFix.Fields.TradSesStartTime tradSesStartTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesStartTime val = new QuickFix.Fields.TradSesStartTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesStartTime val) 
                { 
                    this.tradSesStartTime = val;
                }
                
                public QuickFix.Fields.TradSesStartTime get(QuickFix.Fields.TradSesStartTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesStartTime val) 
                { 
                    return isSetTradSesStartTime();
                }
                
                public bool isSetTradSesStartTime() 
                { 
                    return isSetField(Tags.TradSesStartTime);
                }
                public QuickFix.Fields.TradSesOpenTime tradSesOpenTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesOpenTime val = new QuickFix.Fields.TradSesOpenTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesOpenTime val) 
                { 
                    this.tradSesOpenTime = val;
                }
                
                public QuickFix.Fields.TradSesOpenTime get(QuickFix.Fields.TradSesOpenTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesOpenTime val) 
                { 
                    return isSetTradSesOpenTime();
                }
                
                public bool isSetTradSesOpenTime() 
                { 
                    return isSetField(Tags.TradSesOpenTime);
                }
                public QuickFix.Fields.TradSesPreCloseTime tradSesPreCloseTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesPreCloseTime val = new QuickFix.Fields.TradSesPreCloseTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesPreCloseTime val) 
                { 
                    this.tradSesPreCloseTime = val;
                }
                
                public QuickFix.Fields.TradSesPreCloseTime get(QuickFix.Fields.TradSesPreCloseTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesPreCloseTime val) 
                { 
                    return isSetTradSesPreCloseTime();
                }
                
                public bool isSetTradSesPreCloseTime() 
                { 
                    return isSetField(Tags.TradSesPreCloseTime);
                }
                public QuickFix.Fields.TradSesCloseTime tradSesCloseTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesCloseTime val = new QuickFix.Fields.TradSesCloseTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesCloseTime val) 
                { 
                    this.tradSesCloseTime = val;
                }
                
                public QuickFix.Fields.TradSesCloseTime get(QuickFix.Fields.TradSesCloseTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesCloseTime val) 
                { 
                    return isSetTradSesCloseTime();
                }
                
                public bool isSetTradSesCloseTime() 
                { 
                    return isSetField(Tags.TradSesCloseTime);
                }
                public QuickFix.Fields.TradSesEndTime tradSesEndTime
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesEndTime val = new QuickFix.Fields.TradSesEndTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesEndTime val) 
                { 
                    this.tradSesEndTime = val;
                }
                
                public QuickFix.Fields.TradSesEndTime get(QuickFix.Fields.TradSesEndTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesEndTime val) 
                { 
                    return isSetTradSesEndTime();
                }
                
                public bool isSetTradSesEndTime() 
                { 
                    return isSetField(Tags.TradSesEndTime);
                }
                public QuickFix.Fields.TotalVolumeTraded totalVolumeTraded
                { 
                    get 
                    {
                        QuickFix.Fields.TotalVolumeTraded val = new QuickFix.Fields.TotalVolumeTraded();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    this.totalVolumeTraded = val;
                }
                
                public QuickFix.Fields.TotalVolumeTraded get(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    return isSetTotalVolumeTraded();
                }
                
                public bool isSetTotalVolumeTraded() 
                { 
                    return isSetField(Tags.TotalVolumeTraded);
                }
                public QuickFix.Fields.Text text
                { 
                    get 
                    {
                        QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Text val) 
                { 
                    this.text = val;
                }
                
                public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Text val) 
                { 
                    return isSetText();
                }
                
                public bool isSetText() 
                { 
                    return isSetField(Tags.Text);
                }
                public QuickFix.Fields.EncodedTextLen encodedTextLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedTextLen val) 
                { 
                    this.encodedTextLen = val;
                }
                
                public QuickFix.Fields.EncodedTextLen get(QuickFix.Fields.EncodedTextLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedTextLen val) 
                { 
                    return isSetEncodedTextLen();
                }
                
                public bool isSetEncodedTextLen() 
                { 
                    return isSetField(Tags.EncodedTextLen);
                }
                public QuickFix.Fields.EncodedText encodedText
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedText val) 
                { 
                    this.encodedText = val;
                }
                
                public QuickFix.Fields.EncodedText get(QuickFix.Fields.EncodedText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedText val) 
                { 
                    return isSetEncodedText();
                }
                
                public bool isSetEncodedText() 
                { 
                    return isSetField(Tags.EncodedText);
                }
                public QuickFix.Fields.MarketID marketID
                { 
                    get 
                    {
                        QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MarketID val) 
                { 
                    this.marketID = val;
                }
                
                public QuickFix.Fields.MarketID get(QuickFix.Fields.MarketID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MarketID val) 
                { 
                    return isSetMarketID();
                }
                
                public bool isSetMarketID() 
                { 
                    return isSetField(Tags.MarketID);
                }
                public QuickFix.Fields.MarketSegmentID marketSegmentID
                { 
                    get 
                    {
                        QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MarketSegmentID val) 
                { 
                    this.marketSegmentID = val;
                }
                
                public QuickFix.Fields.MarketSegmentID get(QuickFix.Fields.MarketSegmentID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MarketSegmentID val) 
                { 
                    return isSetMarketSegmentID();
                }
                
                public bool isSetMarketSegmentID() 
                { 
                    return isSetField(Tags.MarketSegmentID);
                }
                public QuickFix.Fields.TradingSessionDesc tradingSessionDesc
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionDesc val = new QuickFix.Fields.TradingSessionDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    this.tradingSessionDesc = val;
                }
                
                public QuickFix.Fields.TradingSessionDesc get(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    return isSetTradingSessionDesc();
                }
                
                public bool isSetTradingSessionDesc() 
                { 
                    return isSetField(Tags.TradingSessionDesc);
                }
                public QuickFix.Fields.NoOrdTypeRules noOrdTypeRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoOrdTypeRules val = new QuickFix.Fields.NoOrdTypeRules();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    this.noOrdTypeRules = val;
                }
                
                public QuickFix.Fields.NoOrdTypeRules get(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    return isSetNoOrdTypeRules();
                }
                
                public bool isSetNoOrdTypeRules() 
                { 
                    return isSetField(Tags.NoOrdTypeRules);
                }
                public QuickFix.Fields.NoTimeInForceRules noTimeInForceRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoTimeInForceRules val = new QuickFix.Fields.NoTimeInForceRules();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    this.noTimeInForceRules = val;
                }
                
                public QuickFix.Fields.NoTimeInForceRules get(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    return isSetNoTimeInForceRules();
                }
                
                public bool isSetNoTimeInForceRules() 
                { 
                    return isSetField(Tags.NoTimeInForceRules);
                }
                public QuickFix.Fields.NoExecInstRules noExecInstRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoExecInstRules val = new QuickFix.Fields.NoExecInstRules();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoExecInstRules val) 
                { 
                    this.noExecInstRules = val;
                }
                
                public QuickFix.Fields.NoExecInstRules get(QuickFix.Fields.NoExecInstRules val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoExecInstRules val) 
                { 
                    return isSetNoExecInstRules();
                }
                
                public bool isSetNoExecInstRules() 
                { 
                    return isSetField(Tags.NoExecInstRules);
                }
                public QuickFix.Fields.NoMatchRules noMatchRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoMatchRules val = new QuickFix.Fields.NoMatchRules();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoMatchRules val) 
                { 
                    this.noMatchRules = val;
                }
                
                public QuickFix.Fields.NoMatchRules get(QuickFix.Fields.NoMatchRules val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoMatchRules val) 
                { 
                    return isSetNoMatchRules();
                }
                
                public bool isSetNoMatchRules() 
                { 
                    return isSetField(Tags.NoMatchRules);
                }
                public QuickFix.Fields.NoMDFeedTypes noMDFeedTypes
                { 
                    get 
                    {
                        QuickFix.Fields.NoMDFeedTypes val = new QuickFix.Fields.NoMDFeedTypes();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    this.noMDFeedTypes = val;
                }
                
                public QuickFix.Fields.NoMDFeedTypes get(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    return isSetNoMDFeedTypes();
                }
                
                public bool isSetNoMDFeedTypes() 
                { 
                    return isSetField(Tags.NoMDFeedTypes);
                }
                public QuickFix.Fields.TransactTime transactTime
                { 
                    get 
                    {
                        QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TransactTime val) 
                { 
                    this.transactTime = val;
                }
                
                public QuickFix.Fields.TransactTime get(QuickFix.Fields.TransactTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TransactTime val) 
                { 
                    return isSetTransactTime();
                }
                
                public bool isSetTransactTime() 
                { 
                    return isSetField(Tags.TransactTime);
                }
                public QuickFix.Fields.TradSesUpdateAction tradSesUpdateAction
                { 
                    get 
                    {
                        QuickFix.Fields.TradSesUpdateAction val = new QuickFix.Fields.TradSesUpdateAction();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradSesUpdateAction val) 
                { 
                    this.tradSesUpdateAction = val;
                }
                
                public QuickFix.Fields.TradSesUpdateAction get(QuickFix.Fields.TradSesUpdateAction val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradSesUpdateAction val) 
                { 
                    return isSetTradSesUpdateAction();
                }
                
                public bool isSetTradSesUpdateAction() 
                { 
                    return isSetField(Tags.TradSesUpdateAction);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OrdType val) 
                    { 
                        this.ordType = val;
                    }
                    
                    public QuickFix.Fields.OrdType get(QuickFix.Fields.OrdType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OrdType val) 
                    { 
                        return isSetOrdType();
                    }
                    
                    public bool isSetOrdType() 
                    { 
                        return isSetField(Tags.OrdType);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.TimeInForce val) 
                    { 
                        this.timeInForce = val;
                    }
                    
                    public QuickFix.Fields.TimeInForce get(QuickFix.Fields.TimeInForce val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.TimeInForce val) 
                    { 
                        return isSetTimeInForce();
                    }
                    
                    public bool isSetTimeInForce() 
                    { 
                        return isSetField(Tags.TimeInForce);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ExecInstValue val) 
                    { 
                        this.execInstValue = val;
                    }
                    
                    public QuickFix.Fields.ExecInstValue get(QuickFix.Fields.ExecInstValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ExecInstValue val) 
                    { 
                        return isSetExecInstValue();
                    }
                    
                    public bool isSetExecInstValue() 
                    { 
                        return isSetField(Tags.ExecInstValue);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        this.matchAlgorithm = val;
                    }
                    
                    public QuickFix.Fields.MatchAlgorithm get(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        return isSetMatchAlgorithm();
                    }
                    
                    public bool isSetMatchAlgorithm() 
                    { 
                        return isSetField(Tags.MatchAlgorithm);
                    }
                    public QuickFix.Fields.MatchType matchType
                    { 
                        get 
                        {
                            QuickFix.Fields.MatchType val = new QuickFix.Fields.MatchType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MatchType val) 
                    { 
                        this.matchType = val;
                    }
                    
                    public QuickFix.Fields.MatchType get(QuickFix.Fields.MatchType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MatchType val) 
                    { 
                        return isSetMatchType();
                    }
                    
                    public bool isSetMatchType() 
                    { 
                        return isSetField(Tags.MatchType);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MDFeedType val) 
                    { 
                        this.mDFeedType = val;
                    }
                    
                    public QuickFix.Fields.MDFeedType get(QuickFix.Fields.MDFeedType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MDFeedType val) 
                    { 
                        return isSetMDFeedType();
                    }
                    
                    public bool isSetMDFeedType() 
                    { 
                        return isSetField(Tags.MDFeedType);
                    }
                    public QuickFix.Fields.MarketDepth marketDepth
                    { 
                        get 
                        {
                            QuickFix.Fields.MarketDepth val = new QuickFix.Fields.MarketDepth();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MarketDepth val) 
                    { 
                        this.marketDepth = val;
                    }
                    
                    public QuickFix.Fields.MarketDepth get(QuickFix.Fields.MarketDepth val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MarketDepth val) 
                    { 
                        return isSetMarketDepth();
                    }
                    
                    public bool isSetMarketDepth() 
                    { 
                        return isSetField(Tags.MarketDepth);
                    }
                    public QuickFix.Fields.MDBookType mDBookType
                    { 
                        get 
                        {
                            QuickFix.Fields.MDBookType val = new QuickFix.Fields.MDBookType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MDBookType val) 
                    { 
                        this.mDBookType = val;
                    }
                    
                    public QuickFix.Fields.MDBookType get(QuickFix.Fields.MDBookType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MDBookType val) 
                    { 
                        return isSetMDBookType();
                    }
                    
                    public bool isSetMDBookType() 
                    { 
                        return isSetField(Tags.MDBookType);
                    }
                
                }
            }
        }
    }
}
