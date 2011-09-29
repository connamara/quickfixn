// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class SettlementInstructions : Message
        {
            public const string MsgType = "T";

            public SettlementInstructions() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("T"));
            }

            public SettlementInstructions(
                    QuickFix.Fields.SettlInstID aSettlInstID,
                    QuickFix.Fields.SettlInstTransType aSettlInstTransType,
                    QuickFix.Fields.SettlInstRefID aSettlInstRefID,
                    QuickFix.Fields.SettlInstMode aSettlInstMode,
                    QuickFix.Fields.SettlInstSource aSettlInstSource,
                    QuickFix.Fields.AllocAccount aAllocAccount,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.settlInstID = aSettlInstID;
                this.settlInstTransType = aSettlInstTransType;
                this.settlInstRefID = aSettlInstRefID;
                this.settlInstMode = aSettlInstMode;
                this.settlInstSource = aSettlInstSource;
                this.allocAccount = aAllocAccount;
                this.transactTime = aTransactTime;
            }

            public QuickFix.Fields.SettlInstID settlInstID
            { 
                get 
                {
                    QuickFix.Fields.SettlInstID val = new QuickFix.Fields.SettlInstID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstID val) 
            { 
                this.settlInstID = val;
            }
            
            public QuickFix.Fields.SettlInstID Get(QuickFix.Fields.SettlInstID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstID val) 
            { 
                return IsSetSettlInstID();
            }
            
            public bool IsSetSettlInstID() 
            { 
                return IsSetField(Tags.SettlInstID);
            }
            public QuickFix.Fields.SettlInstTransType settlInstTransType
            { 
                get 
                {
                    QuickFix.Fields.SettlInstTransType val = new QuickFix.Fields.SettlInstTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstTransType val) 
            { 
                this.settlInstTransType = val;
            }
            
            public QuickFix.Fields.SettlInstTransType Get(QuickFix.Fields.SettlInstTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstTransType val) 
            { 
                return IsSetSettlInstTransType();
            }
            
            public bool IsSetSettlInstTransType() 
            { 
                return IsSetField(Tags.SettlInstTransType);
            }
            public QuickFix.Fields.SettlInstRefID settlInstRefID
            { 
                get 
                {
                    QuickFix.Fields.SettlInstRefID val = new QuickFix.Fields.SettlInstRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstRefID val) 
            { 
                this.settlInstRefID = val;
            }
            
            public QuickFix.Fields.SettlInstRefID Get(QuickFix.Fields.SettlInstRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstRefID val) 
            { 
                return IsSetSettlInstRefID();
            }
            
            public bool IsSetSettlInstRefID() 
            { 
                return IsSetField(Tags.SettlInstRefID);
            }
            public QuickFix.Fields.SettlInstMode settlInstMode
            { 
                get 
                {
                    QuickFix.Fields.SettlInstMode val = new QuickFix.Fields.SettlInstMode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstMode val) 
            { 
                this.settlInstMode = val;
            }
            
            public QuickFix.Fields.SettlInstMode Get(QuickFix.Fields.SettlInstMode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstMode val) 
            { 
                return IsSetSettlInstMode();
            }
            
            public bool IsSetSettlInstMode() 
            { 
                return IsSetField(Tags.SettlInstMode);
            }
            public QuickFix.Fields.SettlInstSource settlInstSource
            { 
                get 
                {
                    QuickFix.Fields.SettlInstSource val = new QuickFix.Fields.SettlInstSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstSource val) 
            { 
                this.settlInstSource = val;
            }
            
            public QuickFix.Fields.SettlInstSource Get(QuickFix.Fields.SettlInstSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstSource val) 
            { 
                return IsSetSettlInstSource();
            }
            
            public bool IsSetSettlInstSource() 
            { 
                return IsSetField(Tags.SettlInstSource);
            }
            public QuickFix.Fields.AllocAccount allocAccount
            { 
                get 
                {
                    QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocAccount val) 
            { 
                this.allocAccount = val;
            }
            
            public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocAccount val) 
            { 
                return IsSetAllocAccount();
            }
            
            public bool IsSetAllocAccount() 
            { 
                return IsSetField(Tags.AllocAccount);
            }
            public QuickFix.Fields.IndividualAllocID individualAllocID
            { 
                get 
                {
                    QuickFix.Fields.IndividualAllocID val = new QuickFix.Fields.IndividualAllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IndividualAllocID val) 
            { 
                this.individualAllocID = val;
            }
            
            public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IndividualAllocID val) 
            { 
                return IsSetIndividualAllocID();
            }
            
            public bool IsSetIndividualAllocID() 
            { 
                return IsSetField(Tags.IndividualAllocID);
            }
            public QuickFix.Fields.ClOrdID clOrdID
            { 
                get 
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClOrdID val) 
            { 
                this.clOrdID = val;
            }
            
            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(Tags.ClOrdID);
            }
            public QuickFix.Fields.TradeDate tradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeDate val) 
            { 
                this.tradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.AllocID allocID
            { 
                get 
                {
                    QuickFix.Fields.AllocID val = new QuickFix.Fields.AllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocID val) 
            { 
                this.allocID = val;
            }
            
            public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocID val) 
            { 
                return IsSetAllocID();
            }
            
            public bool IsSetAllocID() 
            { 
                return IsSetField(Tags.AllocID);
            }
            public QuickFix.Fields.LastMkt lastMkt
            { 
                get 
                {
                    QuickFix.Fields.LastMkt val = new QuickFix.Fields.LastMkt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastMkt val) 
            { 
                this.lastMkt = val;
            }
            
            public QuickFix.Fields.LastMkt Get(QuickFix.Fields.LastMkt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastMkt val) 
            { 
                return IsSetLastMkt();
            }
            
            public bool IsSetLastMkt() 
            { 
                return IsSetField(Tags.LastMkt);
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
            public QuickFix.Fields.Side side
            { 
                get 
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Side val) 
            { 
                this.side = val;
            }
            
            public QuickFix.Fields.Side Get(QuickFix.Fields.Side val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Side val) 
            { 
                return IsSetSide();
            }
            
            public bool IsSetSide() 
            { 
                return IsSetField(Tags.Side);
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
            public QuickFix.Fields.EffectiveTime effectiveTime
            { 
                get 
                {
                    QuickFix.Fields.EffectiveTime val = new QuickFix.Fields.EffectiveTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EffectiveTime val) 
            { 
                this.effectiveTime = val;
            }
            
            public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EffectiveTime val) 
            { 
                return IsSetEffectiveTime();
            }
            
            public bool IsSetEffectiveTime() 
            { 
                return IsSetField(Tags.EffectiveTime);
            }
            public QuickFix.Fields.TransactTime transactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                this.transactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.NoPartyIDs noPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyIDs val) 
            { 
                this.noPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.StandInstDbType standInstDbType
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbType val = new QuickFix.Fields.StandInstDbType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StandInstDbType val) 
            { 
                this.standInstDbType = val;
            }
            
            public QuickFix.Fields.StandInstDbType Get(QuickFix.Fields.StandInstDbType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StandInstDbType val) 
            { 
                return IsSetStandInstDbType();
            }
            
            public bool IsSetStandInstDbType() 
            { 
                return IsSetField(Tags.StandInstDbType);
            }
            public QuickFix.Fields.StandInstDbName standInstDbName
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbName val = new QuickFix.Fields.StandInstDbName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StandInstDbName val) 
            { 
                this.standInstDbName = val;
            }
            
            public QuickFix.Fields.StandInstDbName Get(QuickFix.Fields.StandInstDbName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StandInstDbName val) 
            { 
                return IsSetStandInstDbName();
            }
            
            public bool IsSetStandInstDbName() 
            { 
                return IsSetField(Tags.StandInstDbName);
            }
            public QuickFix.Fields.StandInstDbID standInstDbID
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbID val = new QuickFix.Fields.StandInstDbID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StandInstDbID val) 
            { 
                this.standInstDbID = val;
            }
            
            public QuickFix.Fields.StandInstDbID Get(QuickFix.Fields.StandInstDbID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StandInstDbID val) 
            { 
                return IsSetStandInstDbID();
            }
            
            public bool IsSetStandInstDbID() 
            { 
                return IsSetField(Tags.StandInstDbID);
            }
            public QuickFix.Fields.SettlDeliveryType settlDeliveryType
            { 
                get 
                {
                    QuickFix.Fields.SettlDeliveryType val = new QuickFix.Fields.SettlDeliveryType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDeliveryType val) 
            { 
                this.settlDeliveryType = val;
            }
            
            public QuickFix.Fields.SettlDeliveryType Get(QuickFix.Fields.SettlDeliveryType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlDeliveryType val) 
            { 
                return IsSetSettlDeliveryType();
            }
            
            public bool IsSetSettlDeliveryType() 
            { 
                return IsSetField(Tags.SettlDeliveryType);
            }
            public QuickFix.Fields.SettlDepositoryCode settlDepositoryCode
            { 
                get 
                {
                    QuickFix.Fields.SettlDepositoryCode val = new QuickFix.Fields.SettlDepositoryCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                this.settlDepositoryCode = val;
            }
            
            public QuickFix.Fields.SettlDepositoryCode Get(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                return IsSetSettlDepositoryCode();
            }
            
            public bool IsSetSettlDepositoryCode() 
            { 
                return IsSetField(Tags.SettlDepositoryCode);
            }
            public QuickFix.Fields.SettlBrkrCode settlBrkrCode
            { 
                get 
                {
                    QuickFix.Fields.SettlBrkrCode val = new QuickFix.Fields.SettlBrkrCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlBrkrCode val) 
            { 
                this.settlBrkrCode = val;
            }
            
            public QuickFix.Fields.SettlBrkrCode Get(QuickFix.Fields.SettlBrkrCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlBrkrCode val) 
            { 
                return IsSetSettlBrkrCode();
            }
            
            public bool IsSetSettlBrkrCode() 
            { 
                return IsSetField(Tags.SettlBrkrCode);
            }
            public QuickFix.Fields.SettlInstCode settlInstCode
            { 
                get 
                {
                    QuickFix.Fields.SettlInstCode val = new QuickFix.Fields.SettlInstCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstCode val) 
            { 
                this.settlInstCode = val;
            }
            
            public QuickFix.Fields.SettlInstCode Get(QuickFix.Fields.SettlInstCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstCode val) 
            { 
                return IsSetSettlInstCode();
            }
            
            public bool IsSetSettlInstCode() 
            { 
                return IsSetField(Tags.SettlInstCode);
            }
            public QuickFix.Fields.SecuritySettlAgentName securitySettlAgentName
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentName val = new QuickFix.Fields.SecuritySettlAgentName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                this.securitySettlAgentName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentName Get(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                return IsSetSecuritySettlAgentName();
            }
            
            public bool IsSetSecuritySettlAgentName() 
            { 
                return IsSetField(Tags.SecuritySettlAgentName);
            }
            public QuickFix.Fields.SecuritySettlAgentCode securitySettlAgentCode
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentCode val = new QuickFix.Fields.SecuritySettlAgentCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                this.securitySettlAgentCode = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentCode Get(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                return IsSetSecuritySettlAgentCode();
            }
            
            public bool IsSetSecuritySettlAgentCode() 
            { 
                return IsSetField(Tags.SecuritySettlAgentCode);
            }
            public QuickFix.Fields.SecuritySettlAgentAcctNum securitySettlAgentAcctNum
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentAcctNum val = new QuickFix.Fields.SecuritySettlAgentAcctNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                this.securitySettlAgentAcctNum = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentAcctNum Get(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                return IsSetSecuritySettlAgentAcctNum();
            }
            
            public bool IsSetSecuritySettlAgentAcctNum() 
            { 
                return IsSetField(Tags.SecuritySettlAgentAcctNum);
            }
            public QuickFix.Fields.SecuritySettlAgentAcctName securitySettlAgentAcctName
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentAcctName val = new QuickFix.Fields.SecuritySettlAgentAcctName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                this.securitySettlAgentAcctName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentAcctName Get(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                return IsSetSecuritySettlAgentAcctName();
            }
            
            public bool IsSetSecuritySettlAgentAcctName() 
            { 
                return IsSetField(Tags.SecuritySettlAgentAcctName);
            }
            public QuickFix.Fields.SecuritySettlAgentContactName securitySettlAgentContactName
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentContactName val = new QuickFix.Fields.SecuritySettlAgentContactName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                this.securitySettlAgentContactName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentContactName Get(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                return IsSetSecuritySettlAgentContactName();
            }
            
            public bool IsSetSecuritySettlAgentContactName() 
            { 
                return IsSetField(Tags.SecuritySettlAgentContactName);
            }
            public QuickFix.Fields.SecuritySettlAgentContactPhone securitySettlAgentContactPhone
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentContactPhone val = new QuickFix.Fields.SecuritySettlAgentContactPhone();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                this.securitySettlAgentContactPhone = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentContactPhone Get(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                return IsSetSecuritySettlAgentContactPhone();
            }
            
            public bool IsSetSecuritySettlAgentContactPhone() 
            { 
                return IsSetField(Tags.SecuritySettlAgentContactPhone);
            }
            public QuickFix.Fields.CashSettlAgentName cashSettlAgentName
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentName val = new QuickFix.Fields.CashSettlAgentName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentName val) 
            { 
                this.cashSettlAgentName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentName Get(QuickFix.Fields.CashSettlAgentName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentName val) 
            { 
                return IsSetCashSettlAgentName();
            }
            
            public bool IsSetCashSettlAgentName() 
            { 
                return IsSetField(Tags.CashSettlAgentName);
            }
            public QuickFix.Fields.CashSettlAgentCode cashSettlAgentCode
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentCode val = new QuickFix.Fields.CashSettlAgentCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                this.cashSettlAgentCode = val;
            }
            
            public QuickFix.Fields.CashSettlAgentCode Get(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                return IsSetCashSettlAgentCode();
            }
            
            public bool IsSetCashSettlAgentCode() 
            { 
                return IsSetField(Tags.CashSettlAgentCode);
            }
            public QuickFix.Fields.CashSettlAgentAcctNum cashSettlAgentAcctNum
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentAcctNum val = new QuickFix.Fields.CashSettlAgentAcctNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                this.cashSettlAgentAcctNum = val;
            }
            
            public QuickFix.Fields.CashSettlAgentAcctNum Get(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                return IsSetCashSettlAgentAcctNum();
            }
            
            public bool IsSetCashSettlAgentAcctNum() 
            { 
                return IsSetField(Tags.CashSettlAgentAcctNum);
            }
            public QuickFix.Fields.CashSettlAgentAcctName cashSettlAgentAcctName
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentAcctName val = new QuickFix.Fields.CashSettlAgentAcctName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                this.cashSettlAgentAcctName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentAcctName Get(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                return IsSetCashSettlAgentAcctName();
            }
            
            public bool IsSetCashSettlAgentAcctName() 
            { 
                return IsSetField(Tags.CashSettlAgentAcctName);
            }
            public QuickFix.Fields.CashSettlAgentContactName cashSettlAgentContactName
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentContactName val = new QuickFix.Fields.CashSettlAgentContactName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                this.cashSettlAgentContactName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentContactName Get(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                return IsSetCashSettlAgentContactName();
            }
            
            public bool IsSetCashSettlAgentContactName() 
            { 
                return IsSetField(Tags.CashSettlAgentContactName);
            }
            public QuickFix.Fields.CashSettlAgentContactPhone cashSettlAgentContactPhone
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentContactPhone val = new QuickFix.Fields.CashSettlAgentContactPhone();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                this.cashSettlAgentContactPhone = val;
            }
            
            public QuickFix.Fields.CashSettlAgentContactPhone Get(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                return IsSetCashSettlAgentContactPhone();
            }
            
            public bool IsSetCashSettlAgentContactPhone() 
            { 
                return IsSetField(Tags.CashSettlAgentContactPhone);
            }
            public QuickFix.Fields.PaymentMethod paymentMethod
            { 
                get 
                {
                    QuickFix.Fields.PaymentMethod val = new QuickFix.Fields.PaymentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PaymentMethod val) 
            { 
                this.paymentMethod = val;
            }
            
            public QuickFix.Fields.PaymentMethod Get(QuickFix.Fields.PaymentMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PaymentMethod val) 
            { 
                return IsSetPaymentMethod();
            }
            
            public bool IsSetPaymentMethod() 
            { 
                return IsSetField(Tags.PaymentMethod);
            }
            public QuickFix.Fields.PaymentRef paymentRef
            { 
                get 
                {
                    QuickFix.Fields.PaymentRef val = new QuickFix.Fields.PaymentRef();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PaymentRef val) 
            { 
                this.paymentRef = val;
            }
            
            public QuickFix.Fields.PaymentRef Get(QuickFix.Fields.PaymentRef val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PaymentRef val) 
            { 
                return IsSetPaymentRef();
            }
            
            public bool IsSetPaymentRef() 
            { 
                return IsSetField(Tags.PaymentRef);
            }
            public QuickFix.Fields.CardHolderName cardHolderName
            { 
                get 
                {
                    QuickFix.Fields.CardHolderName val = new QuickFix.Fields.CardHolderName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CardHolderName val) 
            { 
                this.cardHolderName = val;
            }
            
            public QuickFix.Fields.CardHolderName Get(QuickFix.Fields.CardHolderName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CardHolderName val) 
            { 
                return IsSetCardHolderName();
            }
            
            public bool IsSetCardHolderName() 
            { 
                return IsSetField(Tags.CardHolderName);
            }
            public QuickFix.Fields.CardNumber cardNumber
            { 
                get 
                {
                    QuickFix.Fields.CardNumber val = new QuickFix.Fields.CardNumber();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CardNumber val) 
            { 
                this.cardNumber = val;
            }
            
            public QuickFix.Fields.CardNumber Get(QuickFix.Fields.CardNumber val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CardNumber val) 
            { 
                return IsSetCardNumber();
            }
            
            public bool IsSetCardNumber() 
            { 
                return IsSetField(Tags.CardNumber);
            }
            public QuickFix.Fields.CardStartDate cardStartDate
            { 
                get 
                {
                    QuickFix.Fields.CardStartDate val = new QuickFix.Fields.CardStartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CardStartDate val) 
            { 
                this.cardStartDate = val;
            }
            
            public QuickFix.Fields.CardStartDate Get(QuickFix.Fields.CardStartDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CardStartDate val) 
            { 
                return IsSetCardStartDate();
            }
            
            public bool IsSetCardStartDate() 
            { 
                return IsSetField(Tags.CardStartDate);
            }
            public QuickFix.Fields.CardExpDate cardExpDate
            { 
                get 
                {
                    QuickFix.Fields.CardExpDate val = new QuickFix.Fields.CardExpDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CardExpDate val) 
            { 
                this.cardExpDate = val;
            }
            
            public QuickFix.Fields.CardExpDate Get(QuickFix.Fields.CardExpDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CardExpDate val) 
            { 
                return IsSetCardExpDate();
            }
            
            public bool IsSetCardExpDate() 
            { 
                return IsSetField(Tags.CardExpDate);
            }
            public QuickFix.Fields.CardIssNo cardIssNo
            { 
                get 
                {
                    QuickFix.Fields.CardIssNo val = new QuickFix.Fields.CardIssNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CardIssNo val) 
            { 
                this.cardIssNo = val;
            }
            
            public QuickFix.Fields.CardIssNo Get(QuickFix.Fields.CardIssNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CardIssNo val) 
            { 
                return IsSetCardIssNo();
            }
            
            public bool IsSetCardIssNo() 
            { 
                return IsSetField(Tags.CardIssNo);
            }
            public QuickFix.Fields.PaymentDate paymentDate
            { 
                get 
                {
                    QuickFix.Fields.PaymentDate val = new QuickFix.Fields.PaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PaymentDate val) 
            { 
                this.paymentDate = val;
            }
            
            public QuickFix.Fields.PaymentDate Get(QuickFix.Fields.PaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PaymentDate val) 
            { 
                return IsSetPaymentDate();
            }
            
            public bool IsSetPaymentDate() 
            { 
                return IsSetField(Tags.PaymentDate);
            }
            public QuickFix.Fields.PaymentRemitterID paymentRemitterID
            { 
                get 
                {
                    QuickFix.Fields.PaymentRemitterID val = new QuickFix.Fields.PaymentRemitterID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PaymentRemitterID val) 
            { 
                this.paymentRemitterID = val;
            }
            
            public QuickFix.Fields.PaymentRemitterID Get(QuickFix.Fields.PaymentRemitterID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PaymentRemitterID val) 
            { 
                return IsSetPaymentRemitterID();
            }
            
            public bool IsSetPaymentRemitterID() 
            { 
                return IsSetField(Tags.PaymentRemitterID);
            }
            public class NoPartyIDs : Group
            {
                public NoPartyIDs() 
                  :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};
                            public QuickFix.Fields.PartyID partyID
                { 
                    get 
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyID val) 
                { 
                    this.partyID = val;
                }
                
                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource partyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyIDSource val) 
                { 
                    this.partyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole partyRole
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyRole val) 
                { 
                    this.partyRole = val;
                }
                
                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.PartySubID partySubID
                { 
                    get 
                    {
                        QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartySubID val) 
                { 
                    this.partySubID = val;
                }
                
                public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartySubID val) 
                { 
                    return IsSetPartySubID();
                }
                
                public bool IsSetPartySubID() 
                { 
                    return IsSetField(Tags.PartySubID);
                }
            
            }
        }
    }
}
