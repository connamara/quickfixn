// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX41;

public class SettlementInstructions : Message
{
    public const string MsgType = "T";

    public SettlementInstructions() : base()
    {
        Header.SetField(new MsgType("T"));
    }

    public SettlementInstructions(
            SettlInstID aSettlInstID,
            SettlInstTransType aSettlInstTransType,
            SettlInstMode aSettlInstMode,
            SettlInstSource aSettlInstSource,
            AllocAccount aAllocAccount,
            TransactTime aTransactTime
        ) : this()
    {
        SettlInstID = aSettlInstID;
        SettlInstTransType = aSettlInstTransType;
        SettlInstMode = aSettlInstMode;
        SettlInstSource = aSettlInstSource;
        AllocAccount = aAllocAccount;
        TransactTime = aTransactTime;
    }

    public SettlInstID SettlInstID
    {
        get
        {
            SettlInstID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstID val) { SettlInstID = val; }
    public SettlInstID Get(SettlInstID val) { GetField(val); return val; }
    public bool IsSet(SettlInstID val) { return IsSetSettlInstID(); }
    public bool IsSetSettlInstID() { return IsSetField(Tags.SettlInstID); }

    public SettlInstTransType SettlInstTransType
    {
        get
        {
            SettlInstTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstTransType val) { SettlInstTransType = val; }
    public SettlInstTransType Get(SettlInstTransType val) { GetField(val); return val; }
    public bool IsSet(SettlInstTransType val) { return IsSetSettlInstTransType(); }
    public bool IsSetSettlInstTransType() { return IsSetField(Tags.SettlInstTransType); }

    public SettlInstMode SettlInstMode
    {
        get
        {
            SettlInstMode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstMode val) { SettlInstMode = val; }
    public SettlInstMode Get(SettlInstMode val) { GetField(val); return val; }
    public bool IsSet(SettlInstMode val) { return IsSetSettlInstMode(); }
    public bool IsSetSettlInstMode() { return IsSetField(Tags.SettlInstMode); }

    public SettlInstSource SettlInstSource
    {
        get
        {
            SettlInstSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstSource val) { SettlInstSource = val; }
    public SettlInstSource Get(SettlInstSource val) { GetField(val); return val; }
    public bool IsSet(SettlInstSource val) { return IsSetSettlInstSource(); }
    public bool IsSetSettlInstSource() { return IsSetField(Tags.SettlInstSource); }

    public AllocAccount AllocAccount
    {
        get
        {
            AllocAccount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocAccount val) { AllocAccount = val; }
    public AllocAccount Get(AllocAccount val) { GetField(val); return val; }
    public bool IsSet(AllocAccount val) { return IsSetAllocAccount(); }
    public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }

    public SettlLocation SettlLocation
    {
        get
        {
            SettlLocation val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlLocation val) { SettlLocation = val; }
    public SettlLocation Get(SettlLocation val) { GetField(val); return val; }
    public bool IsSet(SettlLocation val) { return IsSetSettlLocation(); }
    public bool IsSetSettlLocation() { return IsSetField(Tags.SettlLocation); }

    public TradeDate TradeDate
    {
        get
        {
            TradeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeDate val) { TradeDate = val; }
    public TradeDate Get(TradeDate val) { GetField(val); return val; }
    public bool IsSet(TradeDate val) { return IsSetTradeDate(); }
    public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

    public AllocID AllocID
    {
        get
        {
            AllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocID val) { AllocID = val; }
    public AllocID Get(AllocID val) { GetField(val); return val; }
    public bool IsSet(AllocID val) { return IsSetAllocID(); }
    public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

    public LastMkt LastMkt
    {
        get
        {
            LastMkt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastMkt val) { LastMkt = val; }
    public LastMkt Get(LastMkt val) { GetField(val); return val; }
    public bool IsSet(LastMkt val) { return IsSetLastMkt(); }
    public bool IsSetLastMkt() { return IsSetField(Tags.LastMkt); }

    public Side Side
    {
        get
        {
            Side val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Side val) { Side = val; }
    public Side Get(Side val) { GetField(val); return val; }
    public bool IsSet(Side val) { return IsSetSide(); }
    public bool IsSetSide() { return IsSetField(Tags.Side); }

    public SecurityType SecurityType
    {
        get
        {
            SecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityType val) { SecurityType = val; }
    public SecurityType Get(SecurityType val) { GetField(val); return val; }
    public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
    public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

    public EffectiveTime EffectiveTime
    {
        get
        {
            EffectiveTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EffectiveTime val) { EffectiveTime = val; }
    public EffectiveTime Get(EffectiveTime val) { GetField(val); return val; }
    public bool IsSet(EffectiveTime val) { return IsSetEffectiveTime(); }
    public bool IsSetEffectiveTime() { return IsSetField(Tags.EffectiveTime); }

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

    public ClientID ClientID
    {
        get
        {
            ClientID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientID val) { ClientID = val; }
    public ClientID Get(ClientID val) { GetField(val); return val; }
    public bool IsSet(ClientID val) { return IsSetClientID(); }
    public bool IsSetClientID() { return IsSetField(Tags.ClientID); }

    public ExecBroker ExecBroker
    {
        get
        {
            ExecBroker val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecBroker val) { ExecBroker = val; }
    public ExecBroker Get(ExecBroker val) { GetField(val); return val; }
    public bool IsSet(ExecBroker val) { return IsSetExecBroker(); }
    public bool IsSetExecBroker() { return IsSetField(Tags.ExecBroker); }

    public StandInstDbType StandInstDbType
    {
        get
        {
            StandInstDbType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StandInstDbType val) { StandInstDbType = val; }
    public StandInstDbType Get(StandInstDbType val) { GetField(val); return val; }
    public bool IsSet(StandInstDbType val) { return IsSetStandInstDbType(); }
    public bool IsSetStandInstDbType() { return IsSetField(Tags.StandInstDbType); }

    public StandInstDbName StandInstDbName
    {
        get
        {
            StandInstDbName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StandInstDbName val) { StandInstDbName = val; }
    public StandInstDbName Get(StandInstDbName val) { GetField(val); return val; }
    public bool IsSet(StandInstDbName val) { return IsSetStandInstDbName(); }
    public bool IsSetStandInstDbName() { return IsSetField(Tags.StandInstDbName); }

    public StandInstDbID StandInstDbID
    {
        get
        {
            StandInstDbID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StandInstDbID val) { StandInstDbID = val; }
    public StandInstDbID Get(StandInstDbID val) { GetField(val); return val; }
    public bool IsSet(StandInstDbID val) { return IsSetStandInstDbID(); }
    public bool IsSetStandInstDbID() { return IsSetField(Tags.StandInstDbID); }

    public SettlDeliveryType SettlDeliveryType
    {
        get
        {
            SettlDeliveryType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlDeliveryType val) { SettlDeliveryType = val; }
    public SettlDeliveryType Get(SettlDeliveryType val) { GetField(val); return val; }
    public bool IsSet(SettlDeliveryType val) { return IsSetSettlDeliveryType(); }
    public bool IsSetSettlDeliveryType() { return IsSetField(Tags.SettlDeliveryType); }

    public SettlDepositoryCode SettlDepositoryCode
    {
        get
        {
            SettlDepositoryCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlDepositoryCode val) { SettlDepositoryCode = val; }
    public SettlDepositoryCode Get(SettlDepositoryCode val) { GetField(val); return val; }
    public bool IsSet(SettlDepositoryCode val) { return IsSetSettlDepositoryCode(); }
    public bool IsSetSettlDepositoryCode() { return IsSetField(Tags.SettlDepositoryCode); }

    public SettlBrkrCode SettlBrkrCode
    {
        get
        {
            SettlBrkrCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlBrkrCode val) { SettlBrkrCode = val; }
    public SettlBrkrCode Get(SettlBrkrCode val) { GetField(val); return val; }
    public bool IsSet(SettlBrkrCode val) { return IsSetSettlBrkrCode(); }
    public bool IsSetSettlBrkrCode() { return IsSetField(Tags.SettlBrkrCode); }

    public SettlInstCode SettlInstCode
    {
        get
        {
            SettlInstCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstCode val) { SettlInstCode = val; }
    public SettlInstCode Get(SettlInstCode val) { GetField(val); return val; }
    public bool IsSet(SettlInstCode val) { return IsSetSettlInstCode(); }
    public bool IsSetSettlInstCode() { return IsSetField(Tags.SettlInstCode); }

    public SecuritySettlAgentName SecuritySettlAgentName
    {
        get
        {
            SecuritySettlAgentName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySettlAgentName val) { SecuritySettlAgentName = val; }
    public SecuritySettlAgentName Get(SecuritySettlAgentName val) { GetField(val); return val; }
    public bool IsSet(SecuritySettlAgentName val) { return IsSetSecuritySettlAgentName(); }
    public bool IsSetSecuritySettlAgentName() { return IsSetField(Tags.SecuritySettlAgentName); }

    public SecuritySettlAgentCode SecuritySettlAgentCode
    {
        get
        {
            SecuritySettlAgentCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySettlAgentCode val) { SecuritySettlAgentCode = val; }
    public SecuritySettlAgentCode Get(SecuritySettlAgentCode val) { GetField(val); return val; }
    public bool IsSet(SecuritySettlAgentCode val) { return IsSetSecuritySettlAgentCode(); }
    public bool IsSetSecuritySettlAgentCode() { return IsSetField(Tags.SecuritySettlAgentCode); }

    public SecuritySettlAgentAcctNum SecuritySettlAgentAcctNum
    {
        get
        {
            SecuritySettlAgentAcctNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySettlAgentAcctNum val) { SecuritySettlAgentAcctNum = val; }
    public SecuritySettlAgentAcctNum Get(SecuritySettlAgentAcctNum val) { GetField(val); return val; }
    public bool IsSet(SecuritySettlAgentAcctNum val) { return IsSetSecuritySettlAgentAcctNum(); }
    public bool IsSetSecuritySettlAgentAcctNum() { return IsSetField(Tags.SecuritySettlAgentAcctNum); }

    public SecuritySettlAgentAcctName SecuritySettlAgentAcctName
    {
        get
        {
            SecuritySettlAgentAcctName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySettlAgentAcctName val) { SecuritySettlAgentAcctName = val; }
    public SecuritySettlAgentAcctName Get(SecuritySettlAgentAcctName val) { GetField(val); return val; }
    public bool IsSet(SecuritySettlAgentAcctName val) { return IsSetSecuritySettlAgentAcctName(); }
    public bool IsSetSecuritySettlAgentAcctName() { return IsSetField(Tags.SecuritySettlAgentAcctName); }

    public SecuritySettlAgentContactName SecuritySettlAgentContactName
    {
        get
        {
            SecuritySettlAgentContactName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySettlAgentContactName val) { SecuritySettlAgentContactName = val; }
    public SecuritySettlAgentContactName Get(SecuritySettlAgentContactName val) { GetField(val); return val; }
    public bool IsSet(SecuritySettlAgentContactName val) { return IsSetSecuritySettlAgentContactName(); }
    public bool IsSetSecuritySettlAgentContactName() { return IsSetField(Tags.SecuritySettlAgentContactName); }

    public SecuritySettlAgentContactPhone SecuritySettlAgentContactPhone
    {
        get
        {
            SecuritySettlAgentContactPhone val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySettlAgentContactPhone val) { SecuritySettlAgentContactPhone = val; }
    public SecuritySettlAgentContactPhone Get(SecuritySettlAgentContactPhone val) { GetField(val); return val; }
    public bool IsSet(SecuritySettlAgentContactPhone val) { return IsSetSecuritySettlAgentContactPhone(); }
    public bool IsSetSecuritySettlAgentContactPhone() { return IsSetField(Tags.SecuritySettlAgentContactPhone); }

    public CashSettlAgentName CashSettlAgentName
    {
        get
        {
            CashSettlAgentName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashSettlAgentName val) { CashSettlAgentName = val; }
    public CashSettlAgentName Get(CashSettlAgentName val) { GetField(val); return val; }
    public bool IsSet(CashSettlAgentName val) { return IsSetCashSettlAgentName(); }
    public bool IsSetCashSettlAgentName() { return IsSetField(Tags.CashSettlAgentName); }

    public CashSettlAgentCode CashSettlAgentCode
    {
        get
        {
            CashSettlAgentCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashSettlAgentCode val) { CashSettlAgentCode = val; }
    public CashSettlAgentCode Get(CashSettlAgentCode val) { GetField(val); return val; }
    public bool IsSet(CashSettlAgentCode val) { return IsSetCashSettlAgentCode(); }
    public bool IsSetCashSettlAgentCode() { return IsSetField(Tags.CashSettlAgentCode); }

    public CashSettlAgentAcctNum CashSettlAgentAcctNum
    {
        get
        {
            CashSettlAgentAcctNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashSettlAgentAcctNum val) { CashSettlAgentAcctNum = val; }
    public CashSettlAgentAcctNum Get(CashSettlAgentAcctNum val) { GetField(val); return val; }
    public bool IsSet(CashSettlAgentAcctNum val) { return IsSetCashSettlAgentAcctNum(); }
    public bool IsSetCashSettlAgentAcctNum() { return IsSetField(Tags.CashSettlAgentAcctNum); }

    public CashSettlAgentAcctName CashSettlAgentAcctName
    {
        get
        {
            CashSettlAgentAcctName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashSettlAgentAcctName val) { CashSettlAgentAcctName = val; }
    public CashSettlAgentAcctName Get(CashSettlAgentAcctName val) { GetField(val); return val; }
    public bool IsSet(CashSettlAgentAcctName val) { return IsSetCashSettlAgentAcctName(); }
    public bool IsSetCashSettlAgentAcctName() { return IsSetField(Tags.CashSettlAgentAcctName); }

    public CashSettlAgentContactName CashSettlAgentContactName
    {
        get
        {
            CashSettlAgentContactName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashSettlAgentContactName val) { CashSettlAgentContactName = val; }
    public CashSettlAgentContactName Get(CashSettlAgentContactName val) { GetField(val); return val; }
    public bool IsSet(CashSettlAgentContactName val) { return IsSetCashSettlAgentContactName(); }
    public bool IsSetCashSettlAgentContactName() { return IsSetField(Tags.CashSettlAgentContactName); }

    public CashSettlAgentContactPhone CashSettlAgentContactPhone
    {
        get
        {
            CashSettlAgentContactPhone val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashSettlAgentContactPhone val) { CashSettlAgentContactPhone = val; }
    public CashSettlAgentContactPhone Get(CashSettlAgentContactPhone val) { GetField(val); return val; }
    public bool IsSet(CashSettlAgentContactPhone val) { return IsSetCashSettlAgentContactPhone(); }
    public bool IsSetCashSettlAgentContactPhone() { return IsSetField(Tags.CashSettlAgentContactPhone); }
}
