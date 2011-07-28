using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class TradingSessionList : Message
        {
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
            public class NoTradingSessions : Group
            {
                public NoTradingSessions() 
                  :base( Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SecurityExchange, Tags.TradSesMethod, Tags.TradSesMode, Tags.UnsolicitedIndicator, Tags.TradSesStatus, Tags.TradSesStatusRejReason, Tags.TradSesStartTime, Tags.TradSesOpenTime, Tags.TradSesPreCloseTime, Tags.TradSesCloseTime, Tags.TradSesEndTime, Tags.TotalVolumeTraded, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};
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
            
            }
        }
    }
}
