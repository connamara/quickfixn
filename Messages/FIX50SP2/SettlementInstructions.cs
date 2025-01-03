// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class SettlementInstructions : Message
{
    public const string MsgType = "T";

    public SettlementInstructions() : base()
    {
        Header.SetField(new MsgType("T"));
    }

    public SettlementInstructions(
            SettlInstMsgID aSettlInstMsgID,
            SettlInstMode aSettlInstMode,
            TransactTime aTransactTime
        ) : this()
    {
        SettlInstMsgID = aSettlInstMsgID;
        SettlInstMode = aSettlInstMode;
        TransactTime = aTransactTime;
    }

    public SettlInstMsgID SettlInstMsgID
    {
        get
        {
            SettlInstMsgID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstMsgID val) { SettlInstMsgID = val; }
    public SettlInstMsgID Get(SettlInstMsgID val) { GetField(val); return val; }
    public bool IsSet(SettlInstMsgID val) { return IsSetSettlInstMsgID(); }
    public bool IsSetSettlInstMsgID() { return IsSetField(Tags.SettlInstMsgID); }

    public SettlInstReqID SettlInstReqID
    {
        get
        {
            SettlInstReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstReqID val) { SettlInstReqID = val; }
    public SettlInstReqID Get(SettlInstReqID val) { GetField(val); return val; }
    public bool IsSet(SettlInstReqID val) { return IsSetSettlInstReqID(); }
    public bool IsSetSettlInstReqID() { return IsSetField(Tags.SettlInstReqID); }

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

    public SettlInstReqRejCode SettlInstReqRejCode
    {
        get
        {
            SettlInstReqRejCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlInstReqRejCode val) { SettlInstReqRejCode = val; }
    public SettlInstReqRejCode Get(SettlInstReqRejCode val) { GetField(val); return val; }
    public bool IsSet(SettlInstReqRejCode val) { return IsSetSettlInstReqRejCode(); }
    public bool IsSetSettlInstReqRejCode() { return IsSetField(Tags.SettlInstReqRejCode); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

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

    public NoSettlInst NoSettlInst
    {
        get
        {
            NoSettlInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSettlInst val) { NoSettlInst = val; }
    public NoSettlInst Get(NoSettlInst val) { GetField(val); return val; }
    public bool IsSet(NoSettlInst val) { return IsSetNoSettlInst(); }
    public bool IsSetNoSettlInst() { return IsSetField(Tags.NoSettlInst); }

    public class NoSettlInstGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.SettlInstID, Tags.SettlInstTransType, Tags.SettlInstRefID, Tags.NoPartyIDs, Tags.Side, Tags.Product, Tags.SecurityType, Tags.CFICode, Tags.EffectiveTime, Tags.ExpireTime, Tags.LastUpdateTime, Tags.SettlDeliveryType, Tags.StandInstDbType, Tags.StandInstDbName, Tags.StandInstDbID, Tags.NoDlvyInst, Tags.PaymentMethod, Tags.PaymentRef, Tags.CardHolderName, Tags.CardNumber, Tags.CardStartDate, Tags.CardExpDate, Tags.CardIssNum, Tags.PaymentDate, Tags.PaymentRemitterID, Tags.SettlCurrency, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.SettlInstID, Tags.SettlInstTransType, Tags.SettlInstRefID, Tags.NoPartyIDs, Tags.Side, Tags.Product, Tags.SecurityType, Tags.CFICode, Tags.EffectiveTime, Tags.ExpireTime, Tags.LastUpdateTime, Tags.SettlDeliveryType, Tags.StandInstDbType, Tags.StandInstDbName, Tags.StandInstDbID, Tags.NoDlvyInst, Tags.PaymentMethod, Tags.PaymentRef, Tags.CardHolderName, Tags.CardNumber, Tags.CardStartDate, Tags.CardExpDate, Tags.CardIssNum, Tags.PaymentDate, Tags.PaymentRemitterID, Tags.SettlCurrency, 0};

        public NoSettlInstGroup()
          : base(Tags.NoSettlInst, Tags.SettlInstID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSettlInstGroup();
            clone.CopyStateFrom(this);
            return clone;
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

        public Product Product
        {
            get
            {
                Product val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Product val) { Product = val; }
        public Product Get(Product val) { GetField(val); return val; }
        public bool IsSet(Product val) { return IsSetProduct(); }
        public bool IsSetProduct() { return IsSetField(Tags.Product); }

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

        public CFICode CFICode
        {
            get
            {
                CFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CFICode val) { CFICode = val; }
        public CFICode Get(CFICode val) { GetField(val); return val; }
        public bool IsSet(CFICode val) { return IsSetCFICode(); }
        public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

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

        public ExpireTime ExpireTime
        {
            get
            {
                ExpireTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExpireTime val) { ExpireTime = val; }
        public ExpireTime Get(ExpireTime val) { GetField(val); return val; }
        public bool IsSet(ExpireTime val) { return IsSetExpireTime(); }
        public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

        public LastUpdateTime LastUpdateTime
        {
            get
            {
                LastUpdateTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LastUpdateTime val) { LastUpdateTime = val; }
        public LastUpdateTime Get(LastUpdateTime val) { GetField(val); return val; }
        public bool IsSet(LastUpdateTime val) { return IsSetLastUpdateTime(); }
        public bool IsSetLastUpdateTime() { return IsSetField(Tags.LastUpdateTime); }

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

        public NoDlvyInst NoDlvyInst
        {
            get
            {
                NoDlvyInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoDlvyInst val) { NoDlvyInst = val; }
        public NoDlvyInst Get(NoDlvyInst val) { GetField(val); return val; }
        public bool IsSet(NoDlvyInst val) { return IsSetNoDlvyInst(); }
        public bool IsSetNoDlvyInst() { return IsSetField(Tags.NoDlvyInst); }

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

        public CardIssNum CardIssNum
        {
            get
            {
                CardIssNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CardIssNum val) { CardIssNum = val; }
        public CardIssNum Get(CardIssNum val) { GetField(val); return val; }
        public bool IsSet(CardIssNum val) { return IsSetCardIssNum(); }
        public bool IsSetCardIssNum() { return IsSetField(Tags.CardIssNum); }

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

        public SettlCurrency SettlCurrency
        {
            get
            {
                SettlCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlCurrency val) { SettlCurrency = val; }
        public SettlCurrency Get(SettlCurrency val) { GetField(val); return val; }
        public bool IsSet(SettlCurrency val) { return IsSetSettlCurrency(); }
        public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }

        public class NoPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

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

            public NoPartySubIDs NoPartySubIDs
            {
                get
                {
                    NoPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoPartySubIDs val) { NoPartySubIDs = val; }
            public NoPartySubIDs Get(NoPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoPartySubIDs val) { return IsSetNoPartySubIDs(); }
            public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }

            public class NoPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.PartySubID, Tags.PartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

                public NoPartySubIDsGroup()
                  : base(Tags.NoPartySubIDs, Tags.PartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

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

                public PartySubIDType PartySubIDType
                {
                    get
                    {
                        PartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(PartySubIDType val) { PartySubIDType = val; }
                public PartySubIDType Get(PartySubIDType val) { GetField(val); return val; }
                public bool IsSet(PartySubIDType val) { return IsSetPartySubIDType(); }
                public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }
            }
        }

        public class NoDlvyInstGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.SettlInstSource, Tags.DlvyInstType, Tags.NoSettlPartyIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.SettlInstSource, Tags.DlvyInstType, Tags.NoSettlPartyIDs, 0};

            public NoDlvyInstGroup()
              : base(Tags.NoDlvyInst, Tags.SettlInstSource, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDlvyInstGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

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

            public DlvyInstType DlvyInstType
            {
                get
                {
                    DlvyInstType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(DlvyInstType val) { DlvyInstType = val; }
            public DlvyInstType Get(DlvyInstType val) { GetField(val); return val; }
            public bool IsSet(DlvyInstType val) { return IsSetDlvyInstType(); }
            public bool IsSetDlvyInstType() { return IsSetField(Tags.DlvyInstType); }

            public NoSettlPartyIDs NoSettlPartyIDs
            {
                get
                {
                    NoSettlPartyIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoSettlPartyIDs val) { NoSettlPartyIDs = val; }
            public NoSettlPartyIDs Get(NoSettlPartyIDs val) { GetField(val); return val; }
            public bool IsSet(NoSettlPartyIDs val) { return IsSetNoSettlPartyIDs(); }
            public bool IsSetNoSettlPartyIDs() { return IsSetField(Tags.NoSettlPartyIDs); }

            public class NoSettlPartyIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};

                public NoSettlPartyIDsGroup()
                  : base(Tags.NoSettlPartyIDs, Tags.SettlPartyID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoSettlPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public SettlPartyID SettlPartyID
                {
                    get
                    {
                        SettlPartyID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyID val) { SettlPartyID = val; }
                public SettlPartyID Get(SettlPartyID val) { GetField(val); return val; }
                public bool IsSet(SettlPartyID val) { return IsSetSettlPartyID(); }
                public bool IsSetSettlPartyID() { return IsSetField(Tags.SettlPartyID); }

                public SettlPartyIDSource SettlPartyIDSource
                {
                    get
                    {
                        SettlPartyIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyIDSource val) { SettlPartyIDSource = val; }
                public SettlPartyIDSource Get(SettlPartyIDSource val) { GetField(val); return val; }
                public bool IsSet(SettlPartyIDSource val) { return IsSetSettlPartyIDSource(); }
                public bool IsSetSettlPartyIDSource() { return IsSetField(Tags.SettlPartyIDSource); }

                public SettlPartyRole SettlPartyRole
                {
                    get
                    {
                        SettlPartyRole val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyRole val) { SettlPartyRole = val; }
                public SettlPartyRole Get(SettlPartyRole val) { GetField(val); return val; }
                public bool IsSet(SettlPartyRole val) { return IsSetSettlPartyRole(); }
                public bool IsSetSettlPartyRole() { return IsSetField(Tags.SettlPartyRole); }

                public NoSettlPartySubIDs NoSettlPartySubIDs
                {
                    get
                    {
                        NoSettlPartySubIDs val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoSettlPartySubIDs val) { NoSettlPartySubIDs = val; }
                public NoSettlPartySubIDs Get(NoSettlPartySubIDs val) { GetField(val); return val; }
                public bool IsSet(NoSettlPartySubIDs val) { return IsSetNoSettlPartySubIDs(); }
                public bool IsSetNoSettlPartySubIDs() { return IsSetField(Tags.NoSettlPartySubIDs); }

                public class NoSettlPartySubIDsGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};

                    public NoSettlPartySubIDsGroup()
                      : base(Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoSettlPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public SettlPartySubID SettlPartySubID
                    {
                        get
                        {
                            SettlPartySubID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(SettlPartySubID val) { SettlPartySubID = val; }
                    public SettlPartySubID Get(SettlPartySubID val) { GetField(val); return val; }
                    public bool IsSet(SettlPartySubID val) { return IsSetSettlPartySubID(); }
                    public bool IsSetSettlPartySubID() { return IsSetField(Tags.SettlPartySubID); }

                    public SettlPartySubIDType SettlPartySubIDType
                    {
                        get
                        {
                            SettlPartySubIDType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(SettlPartySubIDType val) { SettlPartySubIDType = val; }
                    public SettlPartySubIDType Get(SettlPartySubIDType val) { GetField(val); return val; }
                    public bool IsSet(SettlPartySubIDType val) { return IsSetSettlPartySubIDType(); }
                    public bool IsSetSettlPartySubIDType() { return IsSetField(Tags.SettlPartySubIDType); }
                }
            }
        }
    }
}
