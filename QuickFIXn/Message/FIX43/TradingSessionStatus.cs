using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class TradingSessionStatus : Message
    {
        public const string MsgType = "h";

        public TradingSessionStatus():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public TradingSessionStatus(QuickFix.Fields.TradingSessionID aTradingSessionID,
				QuickFix.Fields.TradSesStatus aTradSesStatus)
               : this()
        {
            this.TradingSessionID = aTradingSessionID;
			this.TradSesStatus = aTradSesStatus;
        }

        public QuickFix.Fields.TradSesReqID TradSesReqID
        {
            get
            {
                var val = new QuickFix.Fields.TradSesReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesReqID val) { this.TradSesReqID = val; }

        public QuickFix.Fields.TradSesReqID Get(QuickFix.Fields.TradSesReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesReqID val) { return IsSetTradSesReqID(); }

        public bool IsSetTradSesReqID() { return IsSetField(Tags.TradSesReqID); }

        public QuickFix.Fields.TradingSessionID TradingSessionID
        {
            get
            {
                var val = new QuickFix.Fields.TradingSessionID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradingSessionID val) { this.TradingSessionID = val; }

        public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradingSessionID val) { return IsSetTradingSessionID(); }

        public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

        public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
        {
            get
            {
                var val = new QuickFix.Fields.TradingSessionSubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradingSessionSubID val) { this.TradingSessionSubID = val; }

        public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradingSessionSubID val) { return IsSetTradingSessionSubID(); }

        public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

        public QuickFix.Fields.TradSesMethod TradSesMethod
        {
            get
            {
                var val = new QuickFix.Fields.TradSesMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesMethod val) { this.TradSesMethod = val; }

        public QuickFix.Fields.TradSesMethod Get(QuickFix.Fields.TradSesMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesMethod val) { return IsSetTradSesMethod(); }

        public bool IsSetTradSesMethod() { return IsSetField(Tags.TradSesMethod); }

        public QuickFix.Fields.TradSesMode TradSesMode
        {
            get
            {
                var val = new QuickFix.Fields.TradSesMode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesMode val) { this.TradSesMode = val; }

        public QuickFix.Fields.TradSesMode Get(QuickFix.Fields.TradSesMode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesMode val) { return IsSetTradSesMode(); }

        public bool IsSetTradSesMode() { return IsSetField(Tags.TradSesMode); }

        public QuickFix.Fields.UnsolicitedIndicator UnsolicitedIndicator
        {
            get
            {
                var val = new QuickFix.Fields.UnsolicitedIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnsolicitedIndicator val) { this.UnsolicitedIndicator = val; }

        public QuickFix.Fields.UnsolicitedIndicator Get(QuickFix.Fields.UnsolicitedIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnsolicitedIndicator val) { return IsSetUnsolicitedIndicator(); }

        public bool IsSetUnsolicitedIndicator() { return IsSetField(Tags.UnsolicitedIndicator); }

        public QuickFix.Fields.TradSesStatus TradSesStatus
        {
            get
            {
                var val = new QuickFix.Fields.TradSesStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesStatus val) { this.TradSesStatus = val; }

        public QuickFix.Fields.TradSesStatus Get(QuickFix.Fields.TradSesStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesStatus val) { return IsSetTradSesStatus(); }

        public bool IsSetTradSesStatus() { return IsSetField(Tags.TradSesStatus); }

        public QuickFix.Fields.TradSesStatusRejReason TradSesStatusRejReason
        {
            get
            {
                var val = new QuickFix.Fields.TradSesStatusRejReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesStatusRejReason val) { this.TradSesStatusRejReason = val; }

        public QuickFix.Fields.TradSesStatusRejReason Get(QuickFix.Fields.TradSesStatusRejReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesStatusRejReason val) { return IsSetTradSesStatusRejReason(); }

        public bool IsSetTradSesStatusRejReason() { return IsSetField(Tags.TradSesStatusRejReason); }

        public QuickFix.Fields.TradSesStartTime TradSesStartTime
        {
            get
            {
                var val = new QuickFix.Fields.TradSesStartTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesStartTime val) { this.TradSesStartTime = val; }

        public QuickFix.Fields.TradSesStartTime Get(QuickFix.Fields.TradSesStartTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesStartTime val) { return IsSetTradSesStartTime(); }

        public bool IsSetTradSesStartTime() { return IsSetField(Tags.TradSesStartTime); }

        public QuickFix.Fields.TradSesOpenTime TradSesOpenTime
        {
            get
            {
                var val = new QuickFix.Fields.TradSesOpenTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesOpenTime val) { this.TradSesOpenTime = val; }

        public QuickFix.Fields.TradSesOpenTime Get(QuickFix.Fields.TradSesOpenTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesOpenTime val) { return IsSetTradSesOpenTime(); }

        public bool IsSetTradSesOpenTime() { return IsSetField(Tags.TradSesOpenTime); }

        public QuickFix.Fields.TradSesPreCloseTime TradSesPreCloseTime
        {
            get
            {
                var val = new QuickFix.Fields.TradSesPreCloseTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesPreCloseTime val) { this.TradSesPreCloseTime = val; }

        public QuickFix.Fields.TradSesPreCloseTime Get(QuickFix.Fields.TradSesPreCloseTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesPreCloseTime val) { return IsSetTradSesPreCloseTime(); }

        public bool IsSetTradSesPreCloseTime() { return IsSetField(Tags.TradSesPreCloseTime); }

        public QuickFix.Fields.TradSesCloseTime TradSesCloseTime
        {
            get
            {
                var val = new QuickFix.Fields.TradSesCloseTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesCloseTime val) { this.TradSesCloseTime = val; }

        public QuickFix.Fields.TradSesCloseTime Get(QuickFix.Fields.TradSesCloseTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesCloseTime val) { return IsSetTradSesCloseTime(); }

        public bool IsSetTradSesCloseTime() { return IsSetField(Tags.TradSesCloseTime); }

        public QuickFix.Fields.TradSesEndTime TradSesEndTime
        {
            get
            {
                var val = new QuickFix.Fields.TradSesEndTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradSesEndTime val) { this.TradSesEndTime = val; }

        public QuickFix.Fields.TradSesEndTime Get(QuickFix.Fields.TradSesEndTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradSesEndTime val) { return IsSetTradSesEndTime(); }

        public bool IsSetTradSesEndTime() { return IsSetField(Tags.TradSesEndTime); }

        public QuickFix.Fields.TotalVolumeTraded TotalVolumeTraded
        {
            get
            {
                var val = new QuickFix.Fields.TotalVolumeTraded();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotalVolumeTraded val) { this.TotalVolumeTraded = val; }

        public QuickFix.Fields.TotalVolumeTraded Get(QuickFix.Fields.TotalVolumeTraded val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotalVolumeTraded val) { return IsSetTotalVolumeTraded(); }

        public bool IsSetTotalVolumeTraded() { return IsSetField(Tags.TotalVolumeTraded); }

        public QuickFix.Fields.Text Text
        {
            get
            {
                var val = new QuickFix.Fields.Text();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Text val) { this.Text = val; }

        public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Text val) { return IsSetText(); }

        public bool IsSetText() { return IsSetField(Tags.Text); }

        public QuickFix.Fields.EncodedTextLen EncodedTextLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedTextLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedTextLen val) { this.EncodedTextLen = val; }

        public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedTextLen val) { return IsSetEncodedTextLen(); }

        public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

        public QuickFix.Fields.EncodedText EncodedText
        {
            get
            {
                var val = new QuickFix.Fields.EncodedText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedText val) { this.EncodedText = val; }

        public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedText val) { return IsSetEncodedText(); }

        public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }


    }
}
