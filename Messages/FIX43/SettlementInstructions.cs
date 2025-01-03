// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

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
            SettlInstRefID aSettlInstRefID,
            SettlInstMode aSettlInstMode,
            SettlInstSource aSettlInstSource,
            AllocAccount aAllocAccount,
            TransactTime aTransactTime
        ) : this()
    {
        SettlInstID = aSettlInstID;
        SettlInstTransType = aSettlInstTransType;
        SettlInstRefID = aSettlInstRefID;
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

    public SettlInstRefID SettlInstRefID
    {
        get
        {
            SettlInstRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstRefID val) { SettlInstRefID = val; }
    public SettlInstRefID Get(SettlInstRefID val) { GetField(val); return val; }
    public bool IsSet(SettlInstRefID val) { return IsSetSettlInstRefID(); }
    public bool IsSetSettlInstRefID() { return IsSetField(Tags.SettlInstRefID); }

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

    public IndividualAllocID IndividualAllocID
    {
        get
        {
            IndividualAllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IndividualAllocID val) { IndividualAllocID = val; }
    public IndividualAllocID Get(IndividualAllocID val) { GetField(val); return val; }
    public bool IsSet(IndividualAllocID val) { return IsSetIndividualAllocID(); }
    public bool IsSetIndividualAllocID() { return IsSetField(Tags.IndividualAllocID); }

    public ClOrdID ClOrdID
    {
        get
        {
            ClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdID val) { ClOrdID = val; }
    public ClOrdID Get(ClOrdID val) { GetField(val); return val; }
    public bool IsSet(ClOrdID val) { return IsSetClOrdID(); }
    public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

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

    public NoPartyIDs NoPartyIDs
    {
        get
        {
            NoPartyIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyIDs val) { NoPartyIDs = val; }
    public NoPartyIDs Get(NoPartyIDs val) { GetField(val); return val; }
    public bool IsSet(NoPartyIDs val) { return IsSetNoPartyIDs(); }
    public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

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

    public PaymentMethod PaymentMethod
    {
        get
        {
            PaymentMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PaymentMethod val) { PaymentMethod = val; }
    public PaymentMethod Get(PaymentMethod val) { GetField(val); return val; }
    public bool IsSet(PaymentMethod val) { return IsSetPaymentMethod(); }
    public bool IsSetPaymentMethod() { return IsSetField(Tags.PaymentMethod); }

    public PaymentRef PaymentRef
    {
        get
        {
            PaymentRef val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PaymentRef val) { PaymentRef = val; }
    public PaymentRef Get(PaymentRef val) { GetField(val); return val; }
    public bool IsSet(PaymentRef val) { return IsSetPaymentRef(); }
    public bool IsSetPaymentRef() { return IsSetField(Tags.PaymentRef); }

    public CardHolderName CardHolderName
    {
        get
        {
            CardHolderName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CardHolderName val) { CardHolderName = val; }
    public CardHolderName Get(CardHolderName val) { GetField(val); return val; }
    public bool IsSet(CardHolderName val) { return IsSetCardHolderName(); }
    public bool IsSetCardHolderName() { return IsSetField(Tags.CardHolderName); }

    public CardNumber CardNumber
    {
        get
        {
            CardNumber val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CardNumber val) { CardNumber = val; }
    public CardNumber Get(CardNumber val) { GetField(val); return val; }
    public bool IsSet(CardNumber val) { return IsSetCardNumber(); }
    public bool IsSetCardNumber() { return IsSetField(Tags.CardNumber); }

    public CardStartDate CardStartDate
    {
        get
        {
            CardStartDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CardStartDate val) { CardStartDate = val; }
    public CardStartDate Get(CardStartDate val) { GetField(val); return val; }
    public bool IsSet(CardStartDate val) { return IsSetCardStartDate(); }
    public bool IsSetCardStartDate() { return IsSetField(Tags.CardStartDate); }

    public CardExpDate CardExpDate
    {
        get
        {
            CardExpDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CardExpDate val) { CardExpDate = val; }
    public CardExpDate Get(CardExpDate val) { GetField(val); return val; }
    public bool IsSet(CardExpDate val) { return IsSetCardExpDate(); }
    public bool IsSetCardExpDate() { return IsSetField(Tags.CardExpDate); }

    public CardIssNo CardIssNo
    {
        get
        {
            CardIssNo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CardIssNo val) { CardIssNo = val; }
    public CardIssNo Get(CardIssNo val) { GetField(val); return val; }
    public bool IsSet(CardIssNo val) { return IsSetCardIssNo(); }
    public bool IsSetCardIssNo() { return IsSetField(Tags.CardIssNo); }

    public PaymentDate PaymentDate
    {
        get
        {
            PaymentDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PaymentDate val) { PaymentDate = val; }
    public PaymentDate Get(PaymentDate val) { GetField(val); return val; }
    public bool IsSet(PaymentDate val) { return IsSetPaymentDate(); }
    public bool IsSetPaymentDate() { return IsSetField(Tags.PaymentDate); }

    public PaymentRemitterID PaymentRemitterID
    {
        get
        {
            PaymentRemitterID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PaymentRemitterID val) { PaymentRemitterID = val; }
    public PaymentRemitterID Get(PaymentRemitterID val) { GetField(val); return val; }
    public bool IsSet(PaymentRemitterID val) { return IsSetPaymentRemitterID(); }
    public bool IsSetPaymentRemitterID() { return IsSetField(Tags.PaymentRemitterID); }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};

        public NoPartyIDsGroup()
          : base(Tags.NoPartyIDs, Tags.PartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyID PartyID
        {
            get
            {
                PartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyID val) { PartyID = val; }
        public PartyID Get(PartyID val) { GetField(val); return val; }
        public bool IsSet(PartyID val) { return IsSetPartyID(); }
        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public PartyIDSource PartyIDSource
        {
            get
            {
                PartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyIDSource val) { PartyIDSource = val; }
        public PartyIDSource Get(PartyIDSource val) { GetField(val); return val; }
        public bool IsSet(PartyIDSource val) { return IsSetPartyIDSource(); }
        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public PartyRole PartyRole
        {
            get
            {
                PartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRole val) { PartyRole = val; }
        public PartyRole Get(PartyRole val) { GetField(val); return val; }
        public bool IsSet(PartyRole val) { return IsSetPartyRole(); }
        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public PartySubID PartySubID
        {
            get
            {
                PartySubID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartySubID val) { PartySubID = val; }
        public PartySubID Get(PartySubID val) { GetField(val); return val; }
        public bool IsSet(PartySubID val) { return IsSetPartySubID(); }
        public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }
    }
}
