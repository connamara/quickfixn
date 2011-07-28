using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class SettlementInstructions : Message
        {
            public SettlementInstructions() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("T"));
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
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstID val) 
            { 
                this.settlInstID = val;
            }
            
            public QuickFix.Fields.SettlInstID get(QuickFix.Fields.SettlInstID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstID val) 
            { 
                return isSetSettlInstID();
            }
            
            public bool isSetSettlInstID() 
            { 
                return isSetField(Tags.SettlInstID);
            }
            public QuickFix.Fields.SettlInstTransType settlInstTransType
            { 
                get 
                {
                    QuickFix.Fields.SettlInstTransType val = new QuickFix.Fields.SettlInstTransType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstTransType val) 
            { 
                this.settlInstTransType = val;
            }
            
            public QuickFix.Fields.SettlInstTransType get(QuickFix.Fields.SettlInstTransType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstTransType val) 
            { 
                return isSetSettlInstTransType();
            }
            
            public bool isSetSettlInstTransType() 
            { 
                return isSetField(Tags.SettlInstTransType);
            }
            public QuickFix.Fields.SettlInstRefID settlInstRefID
            { 
                get 
                {
                    QuickFix.Fields.SettlInstRefID val = new QuickFix.Fields.SettlInstRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstRefID val) 
            { 
                this.settlInstRefID = val;
            }
            
            public QuickFix.Fields.SettlInstRefID get(QuickFix.Fields.SettlInstRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstRefID val) 
            { 
                return isSetSettlInstRefID();
            }
            
            public bool isSetSettlInstRefID() 
            { 
                return isSetField(Tags.SettlInstRefID);
            }
            public QuickFix.Fields.SettlInstMode settlInstMode
            { 
                get 
                {
                    QuickFix.Fields.SettlInstMode val = new QuickFix.Fields.SettlInstMode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstMode val) 
            { 
                this.settlInstMode = val;
            }
            
            public QuickFix.Fields.SettlInstMode get(QuickFix.Fields.SettlInstMode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstMode val) 
            { 
                return isSetSettlInstMode();
            }
            
            public bool isSetSettlInstMode() 
            { 
                return isSetField(Tags.SettlInstMode);
            }
            public QuickFix.Fields.SettlInstSource settlInstSource
            { 
                get 
                {
                    QuickFix.Fields.SettlInstSource val = new QuickFix.Fields.SettlInstSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstSource val) 
            { 
                this.settlInstSource = val;
            }
            
            public QuickFix.Fields.SettlInstSource get(QuickFix.Fields.SettlInstSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstSource val) 
            { 
                return isSetSettlInstSource();
            }
            
            public bool isSetSettlInstSource() 
            { 
                return isSetField(Tags.SettlInstSource);
            }
            public QuickFix.Fields.AllocAccount allocAccount
            { 
                get 
                {
                    QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocAccount val) 
            { 
                this.allocAccount = val;
            }
            
            public QuickFix.Fields.AllocAccount get(QuickFix.Fields.AllocAccount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocAccount val) 
            { 
                return isSetAllocAccount();
            }
            
            public bool isSetAllocAccount() 
            { 
                return isSetField(Tags.AllocAccount);
            }
            public QuickFix.Fields.IndividualAllocID individualAllocID
            { 
                get 
                {
                    QuickFix.Fields.IndividualAllocID val = new QuickFix.Fields.IndividualAllocID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IndividualAllocID val) 
            { 
                this.individualAllocID = val;
            }
            
            public QuickFix.Fields.IndividualAllocID get(QuickFix.Fields.IndividualAllocID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IndividualAllocID val) 
            { 
                return isSetIndividualAllocID();
            }
            
            public bool isSetIndividualAllocID() 
            { 
                return isSetField(Tags.IndividualAllocID);
            }
            public QuickFix.Fields.ClOrdID clOrdID
            { 
                get 
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ClOrdID val) 
            { 
                this.clOrdID = val;
            }
            
            public QuickFix.Fields.ClOrdID get(QuickFix.Fields.ClOrdID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ClOrdID val) 
            { 
                return isSetClOrdID();
            }
            
            public bool isSetClOrdID() 
            { 
                return isSetField(Tags.ClOrdID);
            }
            public QuickFix.Fields.TradeDate tradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeDate val) 
            { 
                this.tradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate get(QuickFix.Fields.TradeDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeDate val) 
            { 
                return isSetTradeDate();
            }
            
            public bool isSetTradeDate() 
            { 
                return isSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.AllocID allocID
            { 
                get 
                {
                    QuickFix.Fields.AllocID val = new QuickFix.Fields.AllocID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocID val) 
            { 
                this.allocID = val;
            }
            
            public QuickFix.Fields.AllocID get(QuickFix.Fields.AllocID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocID val) 
            { 
                return isSetAllocID();
            }
            
            public bool isSetAllocID() 
            { 
                return isSetField(Tags.AllocID);
            }
            public QuickFix.Fields.LastMkt lastMkt
            { 
                get 
                {
                    QuickFix.Fields.LastMkt val = new QuickFix.Fields.LastMkt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastMkt val) 
            { 
                this.lastMkt = val;
            }
            
            public QuickFix.Fields.LastMkt get(QuickFix.Fields.LastMkt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastMkt val) 
            { 
                return isSetLastMkt();
            }
            
            public bool isSetLastMkt() 
            { 
                return isSetField(Tags.LastMkt);
            }
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
            public QuickFix.Fields.Side side
            { 
                get 
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Side val) 
            { 
                this.side = val;
            }
            
            public QuickFix.Fields.Side get(QuickFix.Fields.Side val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Side val) 
            { 
                return isSetSide();
            }
            
            public bool isSetSide() 
            { 
                return isSetField(Tags.Side);
            }
            public QuickFix.Fields.SecurityType securityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityType val) 
            { 
                this.securityType = val;
            }
            
            public QuickFix.Fields.SecurityType get(QuickFix.Fields.SecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityType val) 
            { 
                return isSetSecurityType();
            }
            
            public bool isSetSecurityType() 
            { 
                return isSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.EffectiveTime effectiveTime
            { 
                get 
                {
                    QuickFix.Fields.EffectiveTime val = new QuickFix.Fields.EffectiveTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EffectiveTime val) 
            { 
                this.effectiveTime = val;
            }
            
            public QuickFix.Fields.EffectiveTime get(QuickFix.Fields.EffectiveTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EffectiveTime val) 
            { 
                return isSetEffectiveTime();
            }
            
            public bool isSetEffectiveTime() 
            { 
                return isSetField(Tags.EffectiveTime);
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
            public QuickFix.Fields.NoPartyIDs noPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoPartyIDs val) 
            { 
                this.noPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs get(QuickFix.Fields.NoPartyIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return isSetNoPartyIDs();
            }
            
            public bool isSetNoPartyIDs() 
            { 
                return isSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.StandInstDbType standInstDbType
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbType val = new QuickFix.Fields.StandInstDbType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StandInstDbType val) 
            { 
                this.standInstDbType = val;
            }
            
            public QuickFix.Fields.StandInstDbType get(QuickFix.Fields.StandInstDbType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StandInstDbType val) 
            { 
                return isSetStandInstDbType();
            }
            
            public bool isSetStandInstDbType() 
            { 
                return isSetField(Tags.StandInstDbType);
            }
            public QuickFix.Fields.StandInstDbName standInstDbName
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbName val = new QuickFix.Fields.StandInstDbName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StandInstDbName val) 
            { 
                this.standInstDbName = val;
            }
            
            public QuickFix.Fields.StandInstDbName get(QuickFix.Fields.StandInstDbName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StandInstDbName val) 
            { 
                return isSetStandInstDbName();
            }
            
            public bool isSetStandInstDbName() 
            { 
                return isSetField(Tags.StandInstDbName);
            }
            public QuickFix.Fields.StandInstDbID standInstDbID
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbID val = new QuickFix.Fields.StandInstDbID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StandInstDbID val) 
            { 
                this.standInstDbID = val;
            }
            
            public QuickFix.Fields.StandInstDbID get(QuickFix.Fields.StandInstDbID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StandInstDbID val) 
            { 
                return isSetStandInstDbID();
            }
            
            public bool isSetStandInstDbID() 
            { 
                return isSetField(Tags.StandInstDbID);
            }
            public QuickFix.Fields.SettlDeliveryType settlDeliveryType
            { 
                get 
                {
                    QuickFix.Fields.SettlDeliveryType val = new QuickFix.Fields.SettlDeliveryType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlDeliveryType val) 
            { 
                this.settlDeliveryType = val;
            }
            
            public QuickFix.Fields.SettlDeliveryType get(QuickFix.Fields.SettlDeliveryType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlDeliveryType val) 
            { 
                return isSetSettlDeliveryType();
            }
            
            public bool isSetSettlDeliveryType() 
            { 
                return isSetField(Tags.SettlDeliveryType);
            }
            public QuickFix.Fields.SettlDepositoryCode settlDepositoryCode
            { 
                get 
                {
                    QuickFix.Fields.SettlDepositoryCode val = new QuickFix.Fields.SettlDepositoryCode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                this.settlDepositoryCode = val;
            }
            
            public QuickFix.Fields.SettlDepositoryCode get(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                return isSetSettlDepositoryCode();
            }
            
            public bool isSetSettlDepositoryCode() 
            { 
                return isSetField(Tags.SettlDepositoryCode);
            }
            public QuickFix.Fields.SettlBrkrCode settlBrkrCode
            { 
                get 
                {
                    QuickFix.Fields.SettlBrkrCode val = new QuickFix.Fields.SettlBrkrCode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlBrkrCode val) 
            { 
                this.settlBrkrCode = val;
            }
            
            public QuickFix.Fields.SettlBrkrCode get(QuickFix.Fields.SettlBrkrCode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlBrkrCode val) 
            { 
                return isSetSettlBrkrCode();
            }
            
            public bool isSetSettlBrkrCode() 
            { 
                return isSetField(Tags.SettlBrkrCode);
            }
            public QuickFix.Fields.SettlInstCode settlInstCode
            { 
                get 
                {
                    QuickFix.Fields.SettlInstCode val = new QuickFix.Fields.SettlInstCode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstCode val) 
            { 
                this.settlInstCode = val;
            }
            
            public QuickFix.Fields.SettlInstCode get(QuickFix.Fields.SettlInstCode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstCode val) 
            { 
                return isSetSettlInstCode();
            }
            
            public bool isSetSettlInstCode() 
            { 
                return isSetField(Tags.SettlInstCode);
            }
            public QuickFix.Fields.SecuritySettlAgentName securitySettlAgentName
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentName val = new QuickFix.Fields.SecuritySettlAgentName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                this.securitySettlAgentName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentName get(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                return isSetSecuritySettlAgentName();
            }
            
            public bool isSetSecuritySettlAgentName() 
            { 
                return isSetField(Tags.SecuritySettlAgentName);
            }
            public QuickFix.Fields.SecuritySettlAgentCode securitySettlAgentCode
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentCode val = new QuickFix.Fields.SecuritySettlAgentCode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                this.securitySettlAgentCode = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentCode get(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                return isSetSecuritySettlAgentCode();
            }
            
            public bool isSetSecuritySettlAgentCode() 
            { 
                return isSetField(Tags.SecuritySettlAgentCode);
            }
            public QuickFix.Fields.SecuritySettlAgentAcctNum securitySettlAgentAcctNum
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentAcctNum val = new QuickFix.Fields.SecuritySettlAgentAcctNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                this.securitySettlAgentAcctNum = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentAcctNum get(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                return isSetSecuritySettlAgentAcctNum();
            }
            
            public bool isSetSecuritySettlAgentAcctNum() 
            { 
                return isSetField(Tags.SecuritySettlAgentAcctNum);
            }
            public QuickFix.Fields.SecuritySettlAgentAcctName securitySettlAgentAcctName
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentAcctName val = new QuickFix.Fields.SecuritySettlAgentAcctName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                this.securitySettlAgentAcctName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentAcctName get(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                return isSetSecuritySettlAgentAcctName();
            }
            
            public bool isSetSecuritySettlAgentAcctName() 
            { 
                return isSetField(Tags.SecuritySettlAgentAcctName);
            }
            public QuickFix.Fields.SecuritySettlAgentContactName securitySettlAgentContactName
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentContactName val = new QuickFix.Fields.SecuritySettlAgentContactName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                this.securitySettlAgentContactName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentContactName get(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                return isSetSecuritySettlAgentContactName();
            }
            
            public bool isSetSecuritySettlAgentContactName() 
            { 
                return isSetField(Tags.SecuritySettlAgentContactName);
            }
            public QuickFix.Fields.SecuritySettlAgentContactPhone securitySettlAgentContactPhone
            { 
                get 
                {
                    QuickFix.Fields.SecuritySettlAgentContactPhone val = new QuickFix.Fields.SecuritySettlAgentContactPhone();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                this.securitySettlAgentContactPhone = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentContactPhone get(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                return isSetSecuritySettlAgentContactPhone();
            }
            
            public bool isSetSecuritySettlAgentContactPhone() 
            { 
                return isSetField(Tags.SecuritySettlAgentContactPhone);
            }
            public QuickFix.Fields.CashSettlAgentName cashSettlAgentName
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentName val = new QuickFix.Fields.CashSettlAgentName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CashSettlAgentName val) 
            { 
                this.cashSettlAgentName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentName get(QuickFix.Fields.CashSettlAgentName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CashSettlAgentName val) 
            { 
                return isSetCashSettlAgentName();
            }
            
            public bool isSetCashSettlAgentName() 
            { 
                return isSetField(Tags.CashSettlAgentName);
            }
            public QuickFix.Fields.CashSettlAgentCode cashSettlAgentCode
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentCode val = new QuickFix.Fields.CashSettlAgentCode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                this.cashSettlAgentCode = val;
            }
            
            public QuickFix.Fields.CashSettlAgentCode get(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                return isSetCashSettlAgentCode();
            }
            
            public bool isSetCashSettlAgentCode() 
            { 
                return isSetField(Tags.CashSettlAgentCode);
            }
            public QuickFix.Fields.CashSettlAgentAcctNum cashSettlAgentAcctNum
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentAcctNum val = new QuickFix.Fields.CashSettlAgentAcctNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                this.cashSettlAgentAcctNum = val;
            }
            
            public QuickFix.Fields.CashSettlAgentAcctNum get(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                return isSetCashSettlAgentAcctNum();
            }
            
            public bool isSetCashSettlAgentAcctNum() 
            { 
                return isSetField(Tags.CashSettlAgentAcctNum);
            }
            public QuickFix.Fields.CashSettlAgentAcctName cashSettlAgentAcctName
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentAcctName val = new QuickFix.Fields.CashSettlAgentAcctName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                this.cashSettlAgentAcctName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentAcctName get(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                return isSetCashSettlAgentAcctName();
            }
            
            public bool isSetCashSettlAgentAcctName() 
            { 
                return isSetField(Tags.CashSettlAgentAcctName);
            }
            public QuickFix.Fields.CashSettlAgentContactName cashSettlAgentContactName
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentContactName val = new QuickFix.Fields.CashSettlAgentContactName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                this.cashSettlAgentContactName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentContactName get(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                return isSetCashSettlAgentContactName();
            }
            
            public bool isSetCashSettlAgentContactName() 
            { 
                return isSetField(Tags.CashSettlAgentContactName);
            }
            public QuickFix.Fields.CashSettlAgentContactPhone cashSettlAgentContactPhone
            { 
                get 
                {
                    QuickFix.Fields.CashSettlAgentContactPhone val = new QuickFix.Fields.CashSettlAgentContactPhone();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                this.cashSettlAgentContactPhone = val;
            }
            
            public QuickFix.Fields.CashSettlAgentContactPhone get(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                return isSetCashSettlAgentContactPhone();
            }
            
            public bool isSetCashSettlAgentContactPhone() 
            { 
                return isSetField(Tags.CashSettlAgentContactPhone);
            }
            public QuickFix.Fields.PaymentMethod paymentMethod
            { 
                get 
                {
                    QuickFix.Fields.PaymentMethod val = new QuickFix.Fields.PaymentMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PaymentMethod val) 
            { 
                this.paymentMethod = val;
            }
            
            public QuickFix.Fields.PaymentMethod get(QuickFix.Fields.PaymentMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PaymentMethod val) 
            { 
                return isSetPaymentMethod();
            }
            
            public bool isSetPaymentMethod() 
            { 
                return isSetField(Tags.PaymentMethod);
            }
            public QuickFix.Fields.PaymentRef paymentRef
            { 
                get 
                {
                    QuickFix.Fields.PaymentRef val = new QuickFix.Fields.PaymentRef();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PaymentRef val) 
            { 
                this.paymentRef = val;
            }
            
            public QuickFix.Fields.PaymentRef get(QuickFix.Fields.PaymentRef val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PaymentRef val) 
            { 
                return isSetPaymentRef();
            }
            
            public bool isSetPaymentRef() 
            { 
                return isSetField(Tags.PaymentRef);
            }
            public QuickFix.Fields.CardHolderName cardHolderName
            { 
                get 
                {
                    QuickFix.Fields.CardHolderName val = new QuickFix.Fields.CardHolderName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CardHolderName val) 
            { 
                this.cardHolderName = val;
            }
            
            public QuickFix.Fields.CardHolderName get(QuickFix.Fields.CardHolderName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CardHolderName val) 
            { 
                return isSetCardHolderName();
            }
            
            public bool isSetCardHolderName() 
            { 
                return isSetField(Tags.CardHolderName);
            }
            public QuickFix.Fields.CardNumber cardNumber
            { 
                get 
                {
                    QuickFix.Fields.CardNumber val = new QuickFix.Fields.CardNumber();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CardNumber val) 
            { 
                this.cardNumber = val;
            }
            
            public QuickFix.Fields.CardNumber get(QuickFix.Fields.CardNumber val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CardNumber val) 
            { 
                return isSetCardNumber();
            }
            
            public bool isSetCardNumber() 
            { 
                return isSetField(Tags.CardNumber);
            }
            public QuickFix.Fields.CardStartDate cardStartDate
            { 
                get 
                {
                    QuickFix.Fields.CardStartDate val = new QuickFix.Fields.CardStartDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CardStartDate val) 
            { 
                this.cardStartDate = val;
            }
            
            public QuickFix.Fields.CardStartDate get(QuickFix.Fields.CardStartDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CardStartDate val) 
            { 
                return isSetCardStartDate();
            }
            
            public bool isSetCardStartDate() 
            { 
                return isSetField(Tags.CardStartDate);
            }
            public QuickFix.Fields.CardExpDate cardExpDate
            { 
                get 
                {
                    QuickFix.Fields.CardExpDate val = new QuickFix.Fields.CardExpDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CardExpDate val) 
            { 
                this.cardExpDate = val;
            }
            
            public QuickFix.Fields.CardExpDate get(QuickFix.Fields.CardExpDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CardExpDate val) 
            { 
                return isSetCardExpDate();
            }
            
            public bool isSetCardExpDate() 
            { 
                return isSetField(Tags.CardExpDate);
            }
            public QuickFix.Fields.CardIssNo cardIssNo
            { 
                get 
                {
                    QuickFix.Fields.CardIssNo val = new QuickFix.Fields.CardIssNo();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CardIssNo val) 
            { 
                this.cardIssNo = val;
            }
            
            public QuickFix.Fields.CardIssNo get(QuickFix.Fields.CardIssNo val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CardIssNo val) 
            { 
                return isSetCardIssNo();
            }
            
            public bool isSetCardIssNo() 
            { 
                return isSetField(Tags.CardIssNo);
            }
            public QuickFix.Fields.PaymentDate paymentDate
            { 
                get 
                {
                    QuickFix.Fields.PaymentDate val = new QuickFix.Fields.PaymentDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PaymentDate val) 
            { 
                this.paymentDate = val;
            }
            
            public QuickFix.Fields.PaymentDate get(QuickFix.Fields.PaymentDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PaymentDate val) 
            { 
                return isSetPaymentDate();
            }
            
            public bool isSetPaymentDate() 
            { 
                return isSetField(Tags.PaymentDate);
            }
            public QuickFix.Fields.PaymentRemitterID paymentRemitterID
            { 
                get 
                {
                    QuickFix.Fields.PaymentRemitterID val = new QuickFix.Fields.PaymentRemitterID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PaymentRemitterID val) 
            { 
                this.paymentRemitterID = val;
            }
            
            public QuickFix.Fields.PaymentRemitterID get(QuickFix.Fields.PaymentRemitterID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PaymentRemitterID val) 
            { 
                return isSetPaymentRemitterID();
            }
            
            public bool isSetPaymentRemitterID() 
            { 
                return isSetField(Tags.PaymentRemitterID);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyID val) 
                { 
                    this.partyID = val;
                }
                
                public QuickFix.Fields.PartyID get(QuickFix.Fields.PartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyID val) 
                { 
                    return isSetPartyID();
                }
                
                public bool isSetPartyID() 
                { 
                    return isSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource partyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyIDSource val) 
                { 
                    this.partyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource get(QuickFix.Fields.PartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return isSetPartyIDSource();
                }
                
                public bool isSetPartyIDSource() 
                { 
                    return isSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole partyRole
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyRole val) 
                { 
                    this.partyRole = val;
                }
                
                public QuickFix.Fields.PartyRole get(QuickFix.Fields.PartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyRole val) 
                { 
                    return isSetPartyRole();
                }
                
                public bool isSetPartyRole() 
                { 
                    return isSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.PartySubID partySubID
                { 
                    get 
                    {
                        QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartySubID val) 
                { 
                    this.partySubID = val;
                }
                
                public QuickFix.Fields.PartySubID get(QuickFix.Fields.PartySubID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartySubID val) 
                { 
                    return isSetPartySubID();
                }
                
                public bool isSetPartySubID() 
                { 
                    return isSetField(Tags.PartySubID);
                }
            
            }
        }
    }
}
