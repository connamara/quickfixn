// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
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
                    QuickFix.Fields.SettlInstMode aSettlInstMode,
                    QuickFix.Fields.SettlInstSource aSettlInstSource,
                    QuickFix.Fields.AllocAccount aAllocAccount,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.settlInstID = aSettlInstID;
                this.settlInstTransType = aSettlInstTransType;
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
            public QuickFix.Fields.SettlLocation settlLocation
            { 
                get 
                {
                    QuickFix.Fields.SettlLocation val = new QuickFix.Fields.SettlLocation();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlLocation val) 
            { 
                this.settlLocation = val;
            }
            
            public QuickFix.Fields.SettlLocation get(QuickFix.Fields.SettlLocation val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlLocation val) 
            { 
                return isSetSettlLocation();
            }
            
            public bool isSetSettlLocation() 
            { 
                return isSetField(Tags.SettlLocation);
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
            public QuickFix.Fields.ClientID clientID
            { 
                get 
                {
                    QuickFix.Fields.ClientID val = new QuickFix.Fields.ClientID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ClientID val) 
            { 
                this.clientID = val;
            }
            
            public QuickFix.Fields.ClientID get(QuickFix.Fields.ClientID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ClientID val) 
            { 
                return isSetClientID();
            }
            
            public bool isSetClientID() 
            { 
                return isSetField(Tags.ClientID);
            }
            public QuickFix.Fields.ExecBroker execBroker
            { 
                get 
                {
                    QuickFix.Fields.ExecBroker val = new QuickFix.Fields.ExecBroker();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecBroker val) 
            { 
                this.execBroker = val;
            }
            
            public QuickFix.Fields.ExecBroker get(QuickFix.Fields.ExecBroker val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecBroker val) 
            { 
                return isSetExecBroker();
            }
            
            public bool isSetExecBroker() 
            { 
                return isSetField(Tags.ExecBroker);
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

        }
    }
}
