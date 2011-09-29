// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class TradingSessionStatus : Message
        {
            public const string MsgType = "h";

            public TradingSessionStatus() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("h"));
            }

            public TradingSessionStatus(
                    QuickFix.Fields.TradingSessionID aTradingSessionID,
                    QuickFix.Fields.TradSesStatus aTradSesStatus
                ) : this()
            {
                this.tradingSessionID = aTradingSessionID;
                this.tradSesStatus = aTradSesStatus;
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
            public QuickFix.Fields.Symbol symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            { 
                this.symbol = val;
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Tags.Symbol);
            }
            public QuickFix.Fields.SymbolSfx symbolSfx
            { 
                get 
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SymbolSfx val) 
            { 
                this.symbolSfx = val;
            }
            
            public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SymbolSfx val) 
            { 
                return IsSetSymbolSfx();
            }
            
            public bool IsSetSymbolSfx() 
            { 
                return IsSetField(Tags.SymbolSfx);
            }
            public QuickFix.Fields.SecurityID securityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityID val) 
            { 
                this.securityID = val;
            }
            
            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.SecurityIDSource securityIDSource
            { 
                get 
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityIDSource val) 
            { 
                this.securityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(Tags.SecurityIDSource);
            }
            public QuickFix.Fields.NoSecurityAltID noSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                this.noSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(Tags.NoSecurityAltID);
            }
            public QuickFix.Fields.Product product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Product val) 
            { 
                this.product = val;
            }
            
            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(Tags.Product);
            }
            public QuickFix.Fields.CFICode cFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CFICode val) 
            { 
                this.cFICode = val;
            }
            
            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(Tags.CFICode);
            }
            public QuickFix.Fields.SecurityType securityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                this.securityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.SecuritySubType securitySubType
            { 
                get 
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySubType val) 
            { 
                this.securitySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(Tags.SecuritySubType);
            }
            public QuickFix.Fields.MaturityMonthYear maturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityMonthYear val) 
            { 
                this.maturityMonthYear = val;
            }
            
            public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(Tags.MaturityMonthYear);
            }
            public QuickFix.Fields.MaturityDate maturityDate
            { 
                get 
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityDate val) 
            { 
                this.maturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.CouponPaymentDate couponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                this.couponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(Tags.CouponPaymentDate);
            }
            public QuickFix.Fields.IssueDate issueDate
            { 
                get 
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IssueDate val) 
            { 
                this.issueDate = val;
            }
            
            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(Tags.IssueDate);
            }
            public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                this.repoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(Tags.RepoCollateralSecurityType);
            }
            public QuickFix.Fields.RepurchaseTerm repurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                this.repurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(Tags.RepurchaseTerm);
            }
            public QuickFix.Fields.RepurchaseRate repurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseRate val) 
            { 
                this.repurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(Tags.RepurchaseRate);
            }
            public QuickFix.Fields.Factor factor
            { 
                get 
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Factor val) 
            { 
                this.factor = val;
            }
            
            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(Tags.Factor);
            }
            public QuickFix.Fields.CreditRating creditRating
            { 
                get 
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CreditRating val) 
            { 
                this.creditRating = val;
            }
            
            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(Tags.CreditRating);
            }
            public QuickFix.Fields.InstrRegistry instrRegistry
            { 
                get 
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrRegistry val) 
            { 
                this.instrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(Tags.InstrRegistry);
            }
            public QuickFix.Fields.CountryOfIssue countryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CountryOfIssue val) 
            { 
                this.countryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(Tags.CountryOfIssue);
            }
            public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                this.stateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(Tags.StateOrProvinceOfIssue);
            }
            public QuickFix.Fields.LocaleOfIssue localeOfIssue
            { 
                get 
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                this.localeOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(Tags.LocaleOfIssue);
            }
            public QuickFix.Fields.RedemptionDate redemptionDate
            { 
                get 
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RedemptionDate val) 
            { 
                this.redemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(Tags.RedemptionDate);
            }
            public QuickFix.Fields.StrikePrice strikePrice
            { 
                get 
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePrice val) 
            { 
                this.strikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.StrikeCurrency strikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeCurrency val) 
            { 
                this.strikeCurrency = val;
            }
            
            public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(Tags.StrikeCurrency);
            }
            public QuickFix.Fields.OptAttribute optAttribute
            { 
                get 
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptAttribute val) 
            { 
                this.optAttribute = val;
            }
            
            public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(Tags.OptAttribute);
            }
            public QuickFix.Fields.ContractMultiplier contractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractMultiplier val) 
            { 
                this.contractMultiplier = val;
            }
            
            public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractMultiplier val) 
            { 
                return IsSetContractMultiplier();
            }
            
            public bool IsSetContractMultiplier() 
            { 
                return IsSetField(Tags.ContractMultiplier);
            }
            public QuickFix.Fields.CouponRate couponRate
            { 
                get 
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponRate val) 
            { 
                this.couponRate = val;
            }
            
            public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponRate val) 
            { 
                return IsSetCouponRate();
            }
            
            public bool IsSetCouponRate() 
            { 
                return IsSetField(Tags.CouponRate);
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
            public QuickFix.Fields.Issuer issuer
            { 
                get 
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Issuer val) 
            { 
                this.issuer = val;
            }
            
            public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Issuer val) 
            { 
                return IsSetIssuer();
            }
            
            public bool IsSetIssuer() 
            { 
                return IsSetField(Tags.Issuer);
            }
            public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                this.encodedIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                return IsSetEncodedIssuerLen();
            }
            
            public bool IsSetEncodedIssuerLen() 
            { 
                return IsSetField(Tags.EncodedIssuerLen);
            }
            public QuickFix.Fields.EncodedIssuer encodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuer val) 
            { 
                this.encodedIssuer = val;
            }
            
            public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuer val) 
            { 
                return IsSetEncodedIssuer();
            }
            
            public bool IsSetEncodedIssuer() 
            { 
                return IsSetField(Tags.EncodedIssuer);
            }
            public QuickFix.Fields.SecurityDesc securityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.securityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                this.encodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                return IsSetEncodedSecurityDescLen();
            }
            
            public bool IsSetEncodedSecurityDescLen() 
            { 
                return IsSetField(Tags.EncodedSecurityDescLen);
            }
            public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                this.encodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                return IsSetEncodedSecurityDesc();
            }
            
            public bool IsSetEncodedSecurityDesc() 
            { 
                return IsSetField(Tags.EncodedSecurityDesc);
            }
            public QuickFix.Fields.Pool pool
            { 
                get 
                {
                    QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Pool val) 
            { 
                this.pool = val;
            }
            
            public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(Tags.Pool);
            }
            public QuickFix.Fields.ContractSettlMonth contractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractSettlMonth val) 
            { 
                this.contractSettlMonth = val;
            }
            
            public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(Tags.ContractSettlMonth);
            }
            public QuickFix.Fields.CPProgram cPProgram
            { 
                get 
                {
                    QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPProgram val) 
            { 
                this.cPProgram = val;
            }
            
            public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(Tags.CPProgram);
            }
            public QuickFix.Fields.CPRegType cPRegType
            { 
                get 
                {
                    QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPRegType val) 
            { 
                this.cPRegType = val;
            }
            
            public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(Tags.CPRegType);
            }
            public QuickFix.Fields.NoEvents noEvents
            { 
                get 
                {
                    QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoEvents val) 
            { 
                this.noEvents = val;
            }
            
            public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(Tags.NoEvents);
            }
            public QuickFix.Fields.DatedDate datedDate
            { 
                get 
                {
                    QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DatedDate val) 
            { 
                this.datedDate = val;
            }
            
            public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(Tags.DatedDate);
            }
            public QuickFix.Fields.InterestAccrualDate interestAccrualDate
            { 
                get 
                {
                    QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InterestAccrualDate val) 
            { 
                this.interestAccrualDate = val;
            }
            
            public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(Tags.InterestAccrualDate);
            }
            public QuickFix.Fields.SecurityStatus securityStatus
            { 
                get 
                {
                    QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityStatus val) 
            { 
                this.securityStatus = val;
            }
            
            public QuickFix.Fields.SecurityStatus Get(QuickFix.Fields.SecurityStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityStatus val) 
            { 
                return IsSetSecurityStatus();
            }
            
            public bool IsSetSecurityStatus() 
            { 
                return IsSetField(Tags.SecurityStatus);
            }
            public QuickFix.Fields.SettleOnOpenFlag settleOnOpenFlag
            { 
                get 
                {
                    QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                this.settleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.SettleOnOpenFlag Get(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                return IsSetSettleOnOpenFlag();
            }
            
            public bool IsSetSettleOnOpenFlag() 
            { 
                return IsSetField(Tags.SettleOnOpenFlag);
            }
            public QuickFix.Fields.InstrmtAssignmentMethod instrmtAssignmentMethod
            { 
                get 
                {
                    QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                this.instrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.InstrmtAssignmentMethod Get(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                return IsSetInstrmtAssignmentMethod();
            }
            
            public bool IsSetInstrmtAssignmentMethod() 
            { 
                return IsSetField(Tags.InstrmtAssignmentMethod);
            }
            public QuickFix.Fields.StrikeMultiplier strikeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeMultiplier val) 
            { 
                this.strikeMultiplier = val;
            }
            
            public QuickFix.Fields.StrikeMultiplier Get(QuickFix.Fields.StrikeMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeMultiplier val) 
            { 
                return IsSetStrikeMultiplier();
            }
            
            public bool IsSetStrikeMultiplier() 
            { 
                return IsSetField(Tags.StrikeMultiplier);
            }
            public QuickFix.Fields.StrikeValue strikeValue
            { 
                get 
                {
                    QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeValue val) 
            { 
                this.strikeValue = val;
            }
            
            public QuickFix.Fields.StrikeValue Get(QuickFix.Fields.StrikeValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeValue val) 
            { 
                return IsSetStrikeValue();
            }
            
            public bool IsSetStrikeValue() 
            { 
                return IsSetField(Tags.StrikeValue);
            }
            public QuickFix.Fields.MinPriceIncrement minPriceIncrement
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPriceIncrement val) 
            { 
                this.minPriceIncrement = val;
            }
            
            public QuickFix.Fields.MinPriceIncrement Get(QuickFix.Fields.MinPriceIncrement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPriceIncrement val) 
            { 
                return IsSetMinPriceIncrement();
            }
            
            public bool IsSetMinPriceIncrement() 
            { 
                return IsSetField(Tags.MinPriceIncrement);
            }
            public QuickFix.Fields.PositionLimit positionLimit
            { 
                get 
                {
                    QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PositionLimit val) 
            { 
                this.positionLimit = val;
            }
            
            public QuickFix.Fields.PositionLimit Get(QuickFix.Fields.PositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PositionLimit val) 
            { 
                return IsSetPositionLimit();
            }
            
            public bool IsSetPositionLimit() 
            { 
                return IsSetField(Tags.PositionLimit);
            }
            public QuickFix.Fields.NTPositionLimit nTPositionLimit
            { 
                get 
                {
                    QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NTPositionLimit val) 
            { 
                this.nTPositionLimit = val;
            }
            
            public QuickFix.Fields.NTPositionLimit Get(QuickFix.Fields.NTPositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NTPositionLimit val) 
            { 
                return IsSetNTPositionLimit();
            }
            
            public bool IsSetNTPositionLimit() 
            { 
                return IsSetField(Tags.NTPositionLimit);
            }
            public QuickFix.Fields.NoInstrumentParties noInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoInstrumentParties val) 
            { 
                this.noInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoInstrumentParties Get(QuickFix.Fields.NoInstrumentParties val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoInstrumentParties val) 
            { 
                return IsSetNoInstrumentParties();
            }
            
            public bool IsSetNoInstrumentParties() 
            { 
                return IsSetField(Tags.NoInstrumentParties);
            }
            public QuickFix.Fields.UnitOfMeasure unitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasure val) 
            { 
                this.unitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasure val) 
            { 
                return IsSetUnitOfMeasure();
            }
            
            public bool IsSetUnitOfMeasure() 
            { 
                return IsSetField(Tags.UnitOfMeasure);
            }
            public QuickFix.Fields.TimeUnit timeUnit
            { 
                get 
                {
                    QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TimeUnit val) 
            { 
                this.timeUnit = val;
            }
            
            public QuickFix.Fields.TimeUnit Get(QuickFix.Fields.TimeUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TimeUnit val) 
            { 
                return IsSetTimeUnit();
            }
            
            public bool IsSetTimeUnit() 
            { 
                return IsSetField(Tags.TimeUnit);
            }
            public QuickFix.Fields.MaturityTime maturityTime
            { 
                get 
                {
                    QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityTime val) 
            { 
                this.maturityTime = val;
            }
            
            public QuickFix.Fields.MaturityTime Get(QuickFix.Fields.MaturityTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityTime val) 
            { 
                return IsSetMaturityTime();
            }
            
            public bool IsSetMaturityTime() 
            { 
                return IsSetField(Tags.MaturityTime);
            }
            public QuickFix.Fields.SecurityGroup securityGroup
            { 
                get 
                {
                    QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityGroup val) 
            { 
                this.securityGroup = val;
            }
            
            public QuickFix.Fields.SecurityGroup Get(QuickFix.Fields.SecurityGroup val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityGroup val) 
            { 
                return IsSetSecurityGroup();
            }
            
            public bool IsSetSecurityGroup() 
            { 
                return IsSetField(Tags.SecurityGroup);
            }
            public QuickFix.Fields.MinPriceIncrementAmount minPriceIncrementAmount
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                this.minPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.MinPriceIncrementAmount Get(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                return IsSetMinPriceIncrementAmount();
            }
            
            public bool IsSetMinPriceIncrementAmount() 
            { 
                return IsSetField(Tags.MinPriceIncrementAmount);
            }
            public QuickFix.Fields.UnitOfMeasureQty unitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                this.unitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnitOfMeasureQty Get(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                return IsSetUnitOfMeasureQty();
            }
            
            public bool IsSetUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.UnitOfMeasureQty);
            }
            public QuickFix.Fields.SecurityXMLLen securityXMLLen
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXMLLen val) 
            { 
                this.securityXMLLen = val;
            }
            
            public QuickFix.Fields.SecurityXMLLen Get(QuickFix.Fields.SecurityXMLLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXMLLen val) 
            { 
                return IsSetSecurityXMLLen();
            }
            
            public bool IsSetSecurityXMLLen() 
            { 
                return IsSetField(Tags.SecurityXMLLen);
            }
            public QuickFix.Fields.SecurityXML securityXML
            { 
                get 
                {
                    QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXML val) 
            { 
                this.securityXML = val;
            }
            
            public QuickFix.Fields.SecurityXML Get(QuickFix.Fields.SecurityXML val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXML val) 
            { 
                return IsSetSecurityXML();
            }
            
            public bool IsSetSecurityXML() 
            { 
                return IsSetField(Tags.SecurityXML);
            }
            public QuickFix.Fields.SecurityXMLSchema securityXMLSchema
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                this.securityXMLSchema = val;
            }
            
            public QuickFix.Fields.SecurityXMLSchema Get(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                return IsSetSecurityXMLSchema();
            }
            
            public bool IsSetSecurityXMLSchema() 
            { 
                return IsSetField(Tags.SecurityXMLSchema);
            }
            public QuickFix.Fields.ProductComplex productComplex
            { 
                get 
                {
                    QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProductComplex val) 
            { 
                this.productComplex = val;
            }
            
            public QuickFix.Fields.ProductComplex Get(QuickFix.Fields.ProductComplex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProductComplex val) 
            { 
                return IsSetProductComplex();
            }
            
            public bool IsSetProductComplex() 
            { 
                return IsSetField(Tags.ProductComplex);
            }
            public QuickFix.Fields.PriceUnitOfMeasure priceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                this.priceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasure Get(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                return IsSetPriceUnitOfMeasure();
            }
            
            public bool IsSetPriceUnitOfMeasure() 
            { 
                return IsSetField(Tags.PriceUnitOfMeasure);
            }
            public QuickFix.Fields.PriceUnitOfMeasureQty priceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                this.priceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasureQty Get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                return IsSetPriceUnitOfMeasureQty();
            }
            
            public bool IsSetPriceUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.PriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.SettlMethod settlMethod
            { 
                get 
                {
                    QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlMethod val) 
            { 
                this.settlMethod = val;
            }
            
            public QuickFix.Fields.SettlMethod Get(QuickFix.Fields.SettlMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlMethod val) 
            { 
                return IsSetSettlMethod();
            }
            
            public bool IsSetSettlMethod() 
            { 
                return IsSetField(Tags.SettlMethod);
            }
            public QuickFix.Fields.ExerciseStyle exerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExerciseStyle val) 
            { 
                this.exerciseStyle = val;
            }
            
            public QuickFix.Fields.ExerciseStyle Get(QuickFix.Fields.ExerciseStyle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExerciseStyle val) 
            { 
                return IsSetExerciseStyle();
            }
            
            public bool IsSetExerciseStyle() 
            { 
                return IsSetField(Tags.ExerciseStyle);
            }
            public QuickFix.Fields.OptPayoutAmount optPayoutAmount
            { 
                get 
                {
                    QuickFix.Fields.OptPayoutAmount val = new QuickFix.Fields.OptPayoutAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptPayoutAmount val) 
            { 
                this.optPayoutAmount = val;
            }
            
            public QuickFix.Fields.OptPayoutAmount Get(QuickFix.Fields.OptPayoutAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptPayoutAmount val) 
            { 
                return IsSetOptPayoutAmount();
            }
            
            public bool IsSetOptPayoutAmount() 
            { 
                return IsSetField(Tags.OptPayoutAmount);
            }
            public QuickFix.Fields.PriceQuoteMethod priceQuoteMethod
            { 
                get 
                {
                    QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                this.priceQuoteMethod = val;
            }
            
            public QuickFix.Fields.PriceQuoteMethod Get(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                return IsSetPriceQuoteMethod();
            }
            
            public bool IsSetPriceQuoteMethod() 
            { 
                return IsSetField(Tags.PriceQuoteMethod);
            }
            public QuickFix.Fields.ListMethod listMethod
            { 
                get 
                {
                    QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListMethod val) 
            { 
                this.listMethod = val;
            }
            
            public QuickFix.Fields.ListMethod Get(QuickFix.Fields.ListMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListMethod val) 
            { 
                return IsSetListMethod();
            }
            
            public bool IsSetListMethod() 
            { 
                return IsSetField(Tags.ListMethod);
            }
            public QuickFix.Fields.CapPrice capPrice
            { 
                get 
                {
                    QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CapPrice val) 
            { 
                this.capPrice = val;
            }
            
            public QuickFix.Fields.CapPrice Get(QuickFix.Fields.CapPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CapPrice val) 
            { 
                return IsSetCapPrice();
            }
            
            public bool IsSetCapPrice() 
            { 
                return IsSetField(Tags.CapPrice);
            }
            public QuickFix.Fields.FloorPrice floorPrice
            { 
                get 
                {
                    QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FloorPrice val) 
            { 
                this.floorPrice = val;
            }
            
            public QuickFix.Fields.FloorPrice Get(QuickFix.Fields.FloorPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FloorPrice val) 
            { 
                return IsSetFloorPrice();
            }
            
            public bool IsSetFloorPrice() 
            { 
                return IsSetField(Tags.FloorPrice);
            }
            public QuickFix.Fields.PutOrCall putOrCall
            { 
                get 
                {
                    QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PutOrCall val) 
            { 
                this.putOrCall = val;
            }
            
            public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PutOrCall val) 
            { 
                return IsSetPutOrCall();
            }
            
            public bool IsSetPutOrCall() 
            { 
                return IsSetField(Tags.PutOrCall);
            }
            public QuickFix.Fields.FlexibleIndicator flexibleIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexibleIndicator val) 
            { 
                this.flexibleIndicator = val;
            }
            
            public QuickFix.Fields.FlexibleIndicator Get(QuickFix.Fields.FlexibleIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexibleIndicator val) 
            { 
                return IsSetFlexibleIndicator();
            }
            
            public bool IsSetFlexibleIndicator() 
            { 
                return IsSetField(Tags.FlexibleIndicator);
            }
            public QuickFix.Fields.FlexProductEligibilityIndicator flexProductEligibilityIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                this.flexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.FlexProductEligibilityIndicator Get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                return IsSetFlexProductEligibilityIndicator();
            }
            
            public bool IsSetFlexProductEligibilityIndicator() 
            { 
                return IsSetField(Tags.FlexProductEligibilityIndicator);
            }
            public QuickFix.Fields.ValuationMethod valuationMethod
            { 
                get 
                {
                    QuickFix.Fields.ValuationMethod val = new QuickFix.Fields.ValuationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ValuationMethod val) 
            { 
                this.valuationMethod = val;
            }
            
            public QuickFix.Fields.ValuationMethod Get(QuickFix.Fields.ValuationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ValuationMethod val) 
            { 
                return IsSetValuationMethod();
            }
            
            public bool IsSetValuationMethod() 
            { 
                return IsSetField(Tags.ValuationMethod);
            }
            public QuickFix.Fields.ContractMultiplierUnit contractMultiplierUnit
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplierUnit val = new QuickFix.Fields.ContractMultiplierUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractMultiplierUnit val) 
            { 
                this.contractMultiplierUnit = val;
            }
            
            public QuickFix.Fields.ContractMultiplierUnit Get(QuickFix.Fields.ContractMultiplierUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractMultiplierUnit val) 
            { 
                return IsSetContractMultiplierUnit();
            }
            
            public bool IsSetContractMultiplierUnit() 
            { 
                return IsSetField(Tags.ContractMultiplierUnit);
            }
            public QuickFix.Fields.FlowScheduleType flowScheduleType
            { 
                get 
                {
                    QuickFix.Fields.FlowScheduleType val = new QuickFix.Fields.FlowScheduleType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlowScheduleType val) 
            { 
                this.flowScheduleType = val;
            }
            
            public QuickFix.Fields.FlowScheduleType Get(QuickFix.Fields.FlowScheduleType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlowScheduleType val) 
            { 
                return IsSetFlowScheduleType();
            }
            
            public bool IsSetFlowScheduleType() 
            { 
                return IsSetField(Tags.FlowScheduleType);
            }
            public QuickFix.Fields.RestructuringType restructuringType
            { 
                get 
                {
                    QuickFix.Fields.RestructuringType val = new QuickFix.Fields.RestructuringType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RestructuringType val) 
            { 
                this.restructuringType = val;
            }
            
            public QuickFix.Fields.RestructuringType Get(QuickFix.Fields.RestructuringType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RestructuringType val) 
            { 
                return IsSetRestructuringType();
            }
            
            public bool IsSetRestructuringType() 
            { 
                return IsSetField(Tags.RestructuringType);
            }
            public QuickFix.Fields.Seniority seniority
            { 
                get 
                {
                    QuickFix.Fields.Seniority val = new QuickFix.Fields.Seniority();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Seniority val) 
            { 
                this.seniority = val;
            }
            
            public QuickFix.Fields.Seniority Get(QuickFix.Fields.Seniority val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Seniority val) 
            { 
                return IsSetSeniority();
            }
            
            public bool IsSetSeniority() 
            { 
                return IsSetField(Tags.Seniority);
            }
            public QuickFix.Fields.NotionalPercentageOutstanding notionalPercentageOutstanding
            { 
                get 
                {
                    QuickFix.Fields.NotionalPercentageOutstanding val = new QuickFix.Fields.NotionalPercentageOutstanding();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NotionalPercentageOutstanding val) 
            { 
                this.notionalPercentageOutstanding = val;
            }
            
            public QuickFix.Fields.NotionalPercentageOutstanding Get(QuickFix.Fields.NotionalPercentageOutstanding val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NotionalPercentageOutstanding val) 
            { 
                return IsSetNotionalPercentageOutstanding();
            }
            
            public bool IsSetNotionalPercentageOutstanding() 
            { 
                return IsSetField(Tags.NotionalPercentageOutstanding);
            }
            public QuickFix.Fields.OriginalNotionalPercentageOutstanding originalNotionalPercentageOutstanding
            { 
                get 
                {
                    QuickFix.Fields.OriginalNotionalPercentageOutstanding val = new QuickFix.Fields.OriginalNotionalPercentageOutstanding();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
            { 
                this.originalNotionalPercentageOutstanding = val;
            }
            
            public QuickFix.Fields.OriginalNotionalPercentageOutstanding Get(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
            { 
                return IsSetOriginalNotionalPercentageOutstanding();
            }
            
            public bool IsSetOriginalNotionalPercentageOutstanding() 
            { 
                return IsSetField(Tags.OriginalNotionalPercentageOutstanding);
            }
            public QuickFix.Fields.AttachmentPoint attachmentPoint
            { 
                get 
                {
                    QuickFix.Fields.AttachmentPoint val = new QuickFix.Fields.AttachmentPoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AttachmentPoint val) 
            { 
                this.attachmentPoint = val;
            }
            
            public QuickFix.Fields.AttachmentPoint Get(QuickFix.Fields.AttachmentPoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AttachmentPoint val) 
            { 
                return IsSetAttachmentPoint();
            }
            
            public bool IsSetAttachmentPoint() 
            { 
                return IsSetField(Tags.AttachmentPoint);
            }
            public QuickFix.Fields.DetachmentPoint detachmentPoint
            { 
                get 
                {
                    QuickFix.Fields.DetachmentPoint val = new QuickFix.Fields.DetachmentPoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DetachmentPoint val) 
            { 
                this.detachmentPoint = val;
            }
            
            public QuickFix.Fields.DetachmentPoint Get(QuickFix.Fields.DetachmentPoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DetachmentPoint val) 
            { 
                return IsSetDetachmentPoint();
            }
            
            public bool IsSetDetachmentPoint() 
            { 
                return IsSetField(Tags.DetachmentPoint);
            }
            public QuickFix.Fields.StrikePriceDeterminationMethod strikePriceDeterminationMethod
            { 
                get 
                {
                    QuickFix.Fields.StrikePriceDeterminationMethod val = new QuickFix.Fields.StrikePriceDeterminationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePriceDeterminationMethod val) 
            { 
                this.strikePriceDeterminationMethod = val;
            }
            
            public QuickFix.Fields.StrikePriceDeterminationMethod Get(QuickFix.Fields.StrikePriceDeterminationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePriceDeterminationMethod val) 
            { 
                return IsSetStrikePriceDeterminationMethod();
            }
            
            public bool IsSetStrikePriceDeterminationMethod() 
            { 
                return IsSetField(Tags.StrikePriceDeterminationMethod);
            }
            public QuickFix.Fields.StrikePriceBoundaryMethod strikePriceBoundaryMethod
            { 
                get 
                {
                    QuickFix.Fields.StrikePriceBoundaryMethod val = new QuickFix.Fields.StrikePriceBoundaryMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePriceBoundaryMethod val) 
            { 
                this.strikePriceBoundaryMethod = val;
            }
            
            public QuickFix.Fields.StrikePriceBoundaryMethod Get(QuickFix.Fields.StrikePriceBoundaryMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePriceBoundaryMethod val) 
            { 
                return IsSetStrikePriceBoundaryMethod();
            }
            
            public bool IsSetStrikePriceBoundaryMethod() 
            { 
                return IsSetField(Tags.StrikePriceBoundaryMethod);
            }
            public QuickFix.Fields.StrikePriceBoundaryPrecision strikePriceBoundaryPrecision
            { 
                get 
                {
                    QuickFix.Fields.StrikePriceBoundaryPrecision val = new QuickFix.Fields.StrikePriceBoundaryPrecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
            { 
                this.strikePriceBoundaryPrecision = val;
            }
            
            public QuickFix.Fields.StrikePriceBoundaryPrecision Get(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
            { 
                return IsSetStrikePriceBoundaryPrecision();
            }
            
            public bool IsSetStrikePriceBoundaryPrecision() 
            { 
                return IsSetField(Tags.StrikePriceBoundaryPrecision);
            }
            public QuickFix.Fields.UnderlyingPriceDeterminationMethod underlyingPriceDeterminationMethod
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPriceDeterminationMethod val = new QuickFix.Fields.UnderlyingPriceDeterminationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
            { 
                this.underlyingPriceDeterminationMethod = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceDeterminationMethod Get(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
            { 
                return IsSetUnderlyingPriceDeterminationMethod();
            }
            
            public bool IsSetUnderlyingPriceDeterminationMethod() 
            { 
                return IsSetField(Tags.UnderlyingPriceDeterminationMethod);
            }
            public QuickFix.Fields.OptPayoutType optPayoutType
            { 
                get 
                {
                    QuickFix.Fields.OptPayoutType val = new QuickFix.Fields.OptPayoutType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptPayoutType val) 
            { 
                this.optPayoutType = val;
            }
            
            public QuickFix.Fields.OptPayoutType Get(QuickFix.Fields.OptPayoutType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptPayoutType val) 
            { 
                return IsSetOptPayoutType();
            }
            
            public bool IsSetOptPayoutType() 
            { 
                return IsSetField(Tags.OptPayoutType);
            }
            public QuickFix.Fields.NoComplexEvents noComplexEvents
            { 
                get 
                {
                    QuickFix.Fields.NoComplexEvents val = new QuickFix.Fields.NoComplexEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoComplexEvents val) 
            { 
                this.noComplexEvents = val;
            }
            
            public QuickFix.Fields.NoComplexEvents Get(QuickFix.Fields.NoComplexEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoComplexEvents val) 
            { 
                return IsSetNoComplexEvents();
            }
            
            public bool IsSetNoComplexEvents() 
            { 
                return IsSetField(Tags.NoComplexEvents);
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
            public QuickFix.Fields.TradSesEvent tradSesEvent
            { 
                get 
                {
                    QuickFix.Fields.TradSesEvent val = new QuickFix.Fields.TradSesEvent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesEvent val) 
            { 
                this.tradSesEvent = val;
            }
            
            public QuickFix.Fields.TradSesEvent Get(QuickFix.Fields.TradSesEvent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesEvent val) 
            { 
                return IsSetTradSesEvent();
            }
            
            public bool IsSetTradSesEvent() 
            { 
                return IsSetField(Tags.TradSesEvent);
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
            public class NoSecurityAltID : Group
            {
                public NoSecurityAltID() 
                  :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                            public QuickFix.Fields.SecurityAltID securityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltID val) 
                { 
                    this.securityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(Tags.SecurityAltID);
                }
                public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    this.securityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(Tags.SecurityAltIDSource);
                }
            
            }
            public class NoEvents : Group
            {
                public NoEvents() 
                  :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                            public QuickFix.Fields.EventType eventType
                { 
                    get 
                    {
                        QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventType val) 
                { 
                    this.eventType = val;
                }
                
                public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(Tags.EventType);
                }
                public QuickFix.Fields.EventDate eventDate
                { 
                    get 
                    {
                        QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventDate val) 
                { 
                    this.eventDate = val;
                }
                
                public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(Tags.EventDate);
                }
                public QuickFix.Fields.EventPx eventPx
                { 
                    get 
                    {
                        QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventPx val) 
                { 
                    this.eventPx = val;
                }
                
                public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(Tags.EventPx);
                }
                public QuickFix.Fields.EventText eventText
                { 
                    get 
                    {
                        QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventText val) 
                { 
                    this.eventText = val;
                }
                
                public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(Tags.EventText);
                }
                public QuickFix.Fields.EventTime eventTime
                { 
                    get 
                    {
                        QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventTime val) 
                { 
                    this.eventTime = val;
                }
                
                public QuickFix.Fields.EventTime Get(QuickFix.Fields.EventTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventTime val) 
                { 
                    return IsSetEventTime();
                }
                
                public bool IsSetEventTime() 
                { 
                    return IsSetField(Tags.EventTime);
                }
            
            }
            public class NoInstrumentParties : Group
            {
                public NoInstrumentParties() 
                  :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.InstrumentPartyID instrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    this.instrumentPartyID = val;
                }
                
                public QuickFix.Fields.InstrumentPartyID Get(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    return IsSetInstrumentPartyID();
                }
                
                public bool IsSetInstrumentPartyID() 
                { 
                    return IsSetField(Tags.InstrumentPartyID);
                }
                public QuickFix.Fields.InstrumentPartyIDSource instrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    this.instrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.InstrumentPartyIDSource Get(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    return IsSetInstrumentPartyIDSource();
                }
                
                public bool IsSetInstrumentPartyIDSource() 
                { 
                    return IsSetField(Tags.InstrumentPartyIDSource);
                }
                public QuickFix.Fields.InstrumentPartyRole instrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    this.instrumentPartyRole = val;
                }
                
                public QuickFix.Fields.InstrumentPartyRole Get(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    return IsSetInstrumentPartyRole();
                }
                
                public bool IsSetInstrumentPartyRole() 
                { 
                    return IsSetField(Tags.InstrumentPartyRole);
                }
                public QuickFix.Fields.NoInstrumentPartySubIDs noInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    this.noInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoInstrumentPartySubIDs Get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    return IsSetNoInstrumentPartySubIDs();
                }
                
                public bool IsSetNoInstrumentPartySubIDs() 
                { 
                    return IsSetField(Tags.NoInstrumentPartySubIDs);
                }
                            public class NoInstrumentPartySubIDs : Group
                {
                    public NoInstrumentPartySubIDs() 
                      :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.InstrumentPartySubID instrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        this.instrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubID Get(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        return IsSetInstrumentPartySubID();
                    }
                    
                    public bool IsSetInstrumentPartySubID() 
                    { 
                        return IsSetField(Tags.InstrumentPartySubID);
                    }
                    public QuickFix.Fields.InstrumentPartySubIDType instrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        this.instrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubIDType Get(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        return IsSetInstrumentPartySubIDType();
                    }
                    
                    public bool IsSetInstrumentPartySubIDType() 
                    { 
                        return IsSetField(Tags.InstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoComplexEvents : Group
            {
                public NoComplexEvents() 
                  :base( Tags.NoComplexEvents, Tags.ComplexEventType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};
                            public QuickFix.Fields.ComplexEventType complexEventType
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventType val = new QuickFix.Fields.ComplexEventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventType val) 
                { 
                    this.complexEventType = val;
                }
                
                public QuickFix.Fields.ComplexEventType Get(QuickFix.Fields.ComplexEventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventType val) 
                { 
                    return IsSetComplexEventType();
                }
                
                public bool IsSetComplexEventType() 
                { 
                    return IsSetField(Tags.ComplexEventType);
                }
                public QuickFix.Fields.ComplexOptPayoutAmount complexOptPayoutAmount
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexOptPayoutAmount val = new QuickFix.Fields.ComplexOptPayoutAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexOptPayoutAmount val) 
                { 
                    this.complexOptPayoutAmount = val;
                }
                
                public QuickFix.Fields.ComplexOptPayoutAmount Get(QuickFix.Fields.ComplexOptPayoutAmount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexOptPayoutAmount val) 
                { 
                    return IsSetComplexOptPayoutAmount();
                }
                
                public bool IsSetComplexOptPayoutAmount() 
                { 
                    return IsSetField(Tags.ComplexOptPayoutAmount);
                }
                public QuickFix.Fields.ComplexEventPrice complexEventPrice
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventPrice val = new QuickFix.Fields.ComplexEventPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventPrice val) 
                { 
                    this.complexEventPrice = val;
                }
                
                public QuickFix.Fields.ComplexEventPrice Get(QuickFix.Fields.ComplexEventPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventPrice val) 
                { 
                    return IsSetComplexEventPrice();
                }
                
                public bool IsSetComplexEventPrice() 
                { 
                    return IsSetField(Tags.ComplexEventPrice);
                }
                public QuickFix.Fields.ComplexEventPriceBoundaryMethod complexEventPriceBoundaryMethod
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventPriceBoundaryMethod val = new QuickFix.Fields.ComplexEventPriceBoundaryMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                { 
                    this.complexEventPriceBoundaryMethod = val;
                }
                
                public QuickFix.Fields.ComplexEventPriceBoundaryMethod Get(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                { 
                    return IsSetComplexEventPriceBoundaryMethod();
                }
                
                public bool IsSetComplexEventPriceBoundaryMethod() 
                { 
                    return IsSetField(Tags.ComplexEventPriceBoundaryMethod);
                }
                public QuickFix.Fields.ComplexEventPriceBoundaryPrecision complexEventPriceBoundaryPrecision
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventPriceBoundaryPrecision val = new QuickFix.Fields.ComplexEventPriceBoundaryPrecision();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                { 
                    this.complexEventPriceBoundaryPrecision = val;
                }
                
                public QuickFix.Fields.ComplexEventPriceBoundaryPrecision Get(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                { 
                    return IsSetComplexEventPriceBoundaryPrecision();
                }
                
                public bool IsSetComplexEventPriceBoundaryPrecision() 
                { 
                    return IsSetField(Tags.ComplexEventPriceBoundaryPrecision);
                }
                public QuickFix.Fields.ComplexEventPriceTimeType complexEventPriceTimeType
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventPriceTimeType val = new QuickFix.Fields.ComplexEventPriceTimeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventPriceTimeType val) 
                { 
                    this.complexEventPriceTimeType = val;
                }
                
                public QuickFix.Fields.ComplexEventPriceTimeType Get(QuickFix.Fields.ComplexEventPriceTimeType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventPriceTimeType val) 
                { 
                    return IsSetComplexEventPriceTimeType();
                }
                
                public bool IsSetComplexEventPriceTimeType() 
                { 
                    return IsSetField(Tags.ComplexEventPriceTimeType);
                }
                public QuickFix.Fields.ComplexEventCondition complexEventCondition
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventCondition val = new QuickFix.Fields.ComplexEventCondition();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventCondition val) 
                { 
                    this.complexEventCondition = val;
                }
                
                public QuickFix.Fields.ComplexEventCondition Get(QuickFix.Fields.ComplexEventCondition val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventCondition val) 
                { 
                    return IsSetComplexEventCondition();
                }
                
                public bool IsSetComplexEventCondition() 
                { 
                    return IsSetField(Tags.ComplexEventCondition);
                }
                public QuickFix.Fields.NoComplexEventDates noComplexEventDates
                { 
                    get 
                    {
                        QuickFix.Fields.NoComplexEventDates val = new QuickFix.Fields.NoComplexEventDates();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoComplexEventDates val) 
                { 
                    this.noComplexEventDates = val;
                }
                
                public QuickFix.Fields.NoComplexEventDates Get(QuickFix.Fields.NoComplexEventDates val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoComplexEventDates val) 
                { 
                    return IsSetNoComplexEventDates();
                }
                
                public bool IsSetNoComplexEventDates() 
                { 
                    return IsSetField(Tags.NoComplexEventDates);
                }
                            public class NoComplexEventDates : Group
                {
                    public NoComplexEventDates() 
                      :base( Tags.NoComplexEventDates, Tags.ComplexEventStartDate, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};
                                    public QuickFix.Fields.ComplexEventStartDate complexEventStartDate
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventStartDate val = new QuickFix.Fields.ComplexEventStartDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventStartDate val) 
                    { 
                        this.complexEventStartDate = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventStartDate Get(QuickFix.Fields.ComplexEventStartDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventStartDate val) 
                    { 
                        return IsSetComplexEventStartDate();
                    }
                    
                    public bool IsSetComplexEventStartDate() 
                    { 
                        return IsSetField(Tags.ComplexEventStartDate);
                    }
                    public QuickFix.Fields.ComplexEventEndDate complexEventEndDate
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventEndDate val = new QuickFix.Fields.ComplexEventEndDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventEndDate val) 
                    { 
                        this.complexEventEndDate = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventEndDate Get(QuickFix.Fields.ComplexEventEndDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventEndDate val) 
                    { 
                        return IsSetComplexEventEndDate();
                    }
                    
                    public bool IsSetComplexEventEndDate() 
                    { 
                        return IsSetField(Tags.ComplexEventEndDate);
                    }
                    public QuickFix.Fields.NoComplexEventTimes noComplexEventTimes
                    { 
                        get 
                        {
                            QuickFix.Fields.NoComplexEventTimes val = new QuickFix.Fields.NoComplexEventTimes();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoComplexEventTimes val) 
                    { 
                        this.noComplexEventTimes = val;
                    }
                    
                    public QuickFix.Fields.NoComplexEventTimes Get(QuickFix.Fields.NoComplexEventTimes val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoComplexEventTimes val) 
                    { 
                        return IsSetNoComplexEventTimes();
                    }
                    
                    public bool IsSetNoComplexEventTimes() 
                    { 
                        return IsSetField(Tags.NoComplexEventTimes);
                    }
                                    public class NoComplexEventTimes : Group
                    {
                        public NoComplexEventTimes() 
                          :base( Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};
                                            public QuickFix.Fields.ComplexEventStartTime complexEventStartTime
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventStartTime val = new QuickFix.Fields.ComplexEventStartTime();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventStartTime val) 
                        { 
                            this.complexEventStartTime = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventStartTime Get(QuickFix.Fields.ComplexEventStartTime val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventStartTime val) 
                        { 
                            return IsSetComplexEventStartTime();
                        }
                        
                        public bool IsSetComplexEventStartTime() 
                        { 
                            return IsSetField(Tags.ComplexEventStartTime);
                        }
                        public QuickFix.Fields.ComplexEventEndTime complexEventEndTime
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventEndTime val = new QuickFix.Fields.ComplexEventEndTime();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventEndTime val) 
                        { 
                            this.complexEventEndTime = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventEndTime Get(QuickFix.Fields.ComplexEventEndTime val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventEndTime val) 
                        { 
                            return IsSetComplexEventEndTime();
                        }
                        
                        public bool IsSetComplexEventEndTime() 
                        { 
                            return IsSetField(Tags.ComplexEventEndTime);
                        }
                    
                    }
                }
            }
        }
    }
}
