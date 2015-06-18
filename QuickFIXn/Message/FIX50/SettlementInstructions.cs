using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class SettlementInstructions : Message
    {
        public const string MsgType = "T";

        public SettlementInstructions():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public SettlementInstructions(QuickFix.Fields.SettlInstMsgID aSettlInstMsgID,
				QuickFix.Fields.SettlInstMode aSettlInstMode,
				QuickFix.Fields.TransactTime aTransactTime)
               : this()
        {
            this.SettlInstMsgID = aSettlInstMsgID;
			this.SettlInstMode = aSettlInstMode;
			this.TransactTime = aTransactTime;
        }

        public QuickFix.Fields.SettlInstMsgID SettlInstMsgID
        {
            get
            {
                var val = new QuickFix.Fields.SettlInstMsgID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlInstMsgID val) { this.SettlInstMsgID = val; }

        public QuickFix.Fields.SettlInstMsgID Get(QuickFix.Fields.SettlInstMsgID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlInstMsgID val) { return IsSetSettlInstMsgID(); }

        public bool IsSetSettlInstMsgID() { return IsSetField(Tags.SettlInstMsgID); }

        public QuickFix.Fields.SettlInstReqID SettlInstReqID
        {
            get
            {
                var val = new QuickFix.Fields.SettlInstReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlInstReqID val) { this.SettlInstReqID = val; }

        public QuickFix.Fields.SettlInstReqID Get(QuickFix.Fields.SettlInstReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlInstReqID val) { return IsSetSettlInstReqID(); }

        public bool IsSetSettlInstReqID() { return IsSetField(Tags.SettlInstReqID); }

        public QuickFix.Fields.SettlInstMode SettlInstMode
        {
            get
            {
                var val = new QuickFix.Fields.SettlInstMode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlInstMode val) { this.SettlInstMode = val; }

        public QuickFix.Fields.SettlInstMode Get(QuickFix.Fields.SettlInstMode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlInstMode val) { return IsSetSettlInstMode(); }

        public bool IsSetSettlInstMode() { return IsSetField(Tags.SettlInstMode); }

        public QuickFix.Fields.SettlInstReqRejCode SettlInstReqRejCode
        {
            get
            {
                var val = new QuickFix.Fields.SettlInstReqRejCode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlInstReqRejCode val) { this.SettlInstReqRejCode = val; }

        public QuickFix.Fields.SettlInstReqRejCode Get(QuickFix.Fields.SettlInstReqRejCode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlInstReqRejCode val) { return IsSetSettlInstReqRejCode(); }

        public bool IsSetSettlInstReqRejCode() { return IsSetField(Tags.SettlInstReqRejCode); }

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

        public QuickFix.Fields.ClOrdID ClOrdID
        {
            get
            {
                var val = new QuickFix.Fields.ClOrdID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ClOrdID val) { this.ClOrdID = val; }

        public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ClOrdID val) { return IsSetClOrdID(); }

        public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

        public QuickFix.Fields.TransactTime TransactTime
        {
            get
            {
                var val = new QuickFix.Fields.TransactTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TransactTime val) { this.TransactTime = val; }

        public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TransactTime val) { return IsSetTransactTime(); }

        public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

        public QuickFix.Fields.NoSettlInst NoSettlInst
        {
            get
            {
                var val = new QuickFix.Fields.NoSettlInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSettlInst val) { this.NoSettlInst = val; }

        public QuickFix.Fields.NoSettlInst Get(QuickFix.Fields.NoSettlInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSettlInst val) { return IsSetNoSettlInst(); }

        public bool IsSetNoSettlInst() { return IsSetField(Tags.NoSettlInst); }


        public class NoSettlInstGroup : Group
        {
            public static int[] fieldOrder = {Tags.SettlInstID, Tags.SettlInstTransType, Tags.SettlInstRefID, Tags.NoPartyIDs, Tags.Side, Tags.Product, Tags.SecurityType, Tags.CFICode, Tags.EffectiveTime, Tags.ExpireTime, Tags.LastUpdateTime, Tags.SettlDeliveryType, Tags.StandInstDbType, Tags.StandInstDbName, Tags.StandInstDbID, Tags.NoDlvyInst, Tags.PaymentMethod, Tags.PaymentRef, Tags.CardHolderName, Tags.CardNumber, Tags.CardStartDate, Tags.CardExpDate, Tags.CardIssNum, Tags.PaymentDate, Tags.PaymentRemitterID, Tags.SettlCurrency, 0};

            public NoSettlInstGroup() : base(Tags.NoSettlInst, Tags.SettlInstID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSettlInstGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SettlInstID SettlInstID
        {
            get
            {
                var val = new QuickFix.Fields.SettlInstID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlInstID val) { this.SettlInstID = val; }

        public QuickFix.Fields.SettlInstID Get(QuickFix.Fields.SettlInstID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlInstID val) { return IsSetSettlInstID(); }

        public bool IsSetSettlInstID() { return IsSetField(Tags.SettlInstID); }

        public QuickFix.Fields.SettlInstTransType SettlInstTransType
        {
            get
            {
                var val = new QuickFix.Fields.SettlInstTransType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlInstTransType val) { this.SettlInstTransType = val; }

        public QuickFix.Fields.SettlInstTransType Get(QuickFix.Fields.SettlInstTransType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlInstTransType val) { return IsSetSettlInstTransType(); }

        public bool IsSetSettlInstTransType() { return IsSetField(Tags.SettlInstTransType); }

        public QuickFix.Fields.SettlInstRefID SettlInstRefID
        {
            get
            {
                var val = new QuickFix.Fields.SettlInstRefID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlInstRefID val) { this.SettlInstRefID = val; }

        public QuickFix.Fields.SettlInstRefID Get(QuickFix.Fields.SettlInstRefID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlInstRefID val) { return IsSetSettlInstRefID(); }

        public bool IsSetSettlInstRefID() { return IsSetField(Tags.SettlInstRefID); }

        public QuickFix.Fields.NoPartyIDs NoPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyIDs val) { this.NoPartyIDs = val; }

        public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyIDs val) { return IsSetNoPartyIDs(); }

        public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

        public QuickFix.Fields.Side Side
        {
            get
            {
                var val = new QuickFix.Fields.Side();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Side val) { this.Side = val; }

        public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Side val) { return IsSetSide(); }

        public bool IsSetSide() { return IsSetField(Tags.Side); }

        public QuickFix.Fields.Product Product
        {
            get
            {
                var val = new QuickFix.Fields.Product();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Product val) { this.Product = val; }

        public QuickFix.Fields.Product Get(QuickFix.Fields.Product val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Product val) { return IsSetProduct(); }

        public bool IsSetProduct() { return IsSetField(Tags.Product); }

        public QuickFix.Fields.SecurityType SecurityType
        {
            get
            {
                var val = new QuickFix.Fields.SecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityType val) { this.SecurityType = val; }

        public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityType val) { return IsSetSecurityType(); }

        public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

        public QuickFix.Fields.CFICode CFICode
        {
            get
            {
                var val = new QuickFix.Fields.CFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CFICode val) { this.CFICode = val; }

        public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CFICode val) { return IsSetCFICode(); }

        public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

        public QuickFix.Fields.EffectiveTime EffectiveTime
        {
            get
            {
                var val = new QuickFix.Fields.EffectiveTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EffectiveTime val) { this.EffectiveTime = val; }

        public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EffectiveTime val) { return IsSetEffectiveTime(); }

        public bool IsSetEffectiveTime() { return IsSetField(Tags.EffectiveTime); }

        public QuickFix.Fields.ExpireTime ExpireTime
        {
            get
            {
                var val = new QuickFix.Fields.ExpireTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExpireTime val) { this.ExpireTime = val; }

        public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExpireTime val) { return IsSetExpireTime(); }

        public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

        public QuickFix.Fields.LastUpdateTime LastUpdateTime
        {
            get
            {
                var val = new QuickFix.Fields.LastUpdateTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastUpdateTime val) { this.LastUpdateTime = val; }

        public QuickFix.Fields.LastUpdateTime Get(QuickFix.Fields.LastUpdateTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastUpdateTime val) { return IsSetLastUpdateTime(); }

        public bool IsSetLastUpdateTime() { return IsSetField(Tags.LastUpdateTime); }

        public QuickFix.Fields.SettlDeliveryType SettlDeliveryType
        {
            get
            {
                var val = new QuickFix.Fields.SettlDeliveryType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlDeliveryType val) { this.SettlDeliveryType = val; }

        public QuickFix.Fields.SettlDeliveryType Get(QuickFix.Fields.SettlDeliveryType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlDeliveryType val) { return IsSetSettlDeliveryType(); }

        public bool IsSetSettlDeliveryType() { return IsSetField(Tags.SettlDeliveryType); }

        public QuickFix.Fields.StandInstDbType StandInstDbType
        {
            get
            {
                var val = new QuickFix.Fields.StandInstDbType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StandInstDbType val) { this.StandInstDbType = val; }

        public QuickFix.Fields.StandInstDbType Get(QuickFix.Fields.StandInstDbType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StandInstDbType val) { return IsSetStandInstDbType(); }

        public bool IsSetStandInstDbType() { return IsSetField(Tags.StandInstDbType); }

        public QuickFix.Fields.StandInstDbName StandInstDbName
        {
            get
            {
                var val = new QuickFix.Fields.StandInstDbName();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StandInstDbName val) { this.StandInstDbName = val; }

        public QuickFix.Fields.StandInstDbName Get(QuickFix.Fields.StandInstDbName val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StandInstDbName val) { return IsSetStandInstDbName(); }

        public bool IsSetStandInstDbName() { return IsSetField(Tags.StandInstDbName); }

        public QuickFix.Fields.StandInstDbID StandInstDbID
        {
            get
            {
                var val = new QuickFix.Fields.StandInstDbID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StandInstDbID val) { this.StandInstDbID = val; }

        public QuickFix.Fields.StandInstDbID Get(QuickFix.Fields.StandInstDbID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StandInstDbID val) { return IsSetStandInstDbID(); }

        public bool IsSetStandInstDbID() { return IsSetField(Tags.StandInstDbID); }

        public QuickFix.Fields.NoDlvyInst NoDlvyInst
        {
            get
            {
                var val = new QuickFix.Fields.NoDlvyInst();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoDlvyInst val) { this.NoDlvyInst = val; }

        public QuickFix.Fields.NoDlvyInst Get(QuickFix.Fields.NoDlvyInst val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoDlvyInst val) { return IsSetNoDlvyInst(); }

        public bool IsSetNoDlvyInst() { return IsSetField(Tags.NoDlvyInst); }

        public QuickFix.Fields.PaymentMethod PaymentMethod
        {
            get
            {
                var val = new QuickFix.Fields.PaymentMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PaymentMethod val) { this.PaymentMethod = val; }

        public QuickFix.Fields.PaymentMethod Get(QuickFix.Fields.PaymentMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PaymentMethod val) { return IsSetPaymentMethod(); }

        public bool IsSetPaymentMethod() { return IsSetField(Tags.PaymentMethod); }

        public QuickFix.Fields.PaymentRef PaymentRef
        {
            get
            {
                var val = new QuickFix.Fields.PaymentRef();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PaymentRef val) { this.PaymentRef = val; }

        public QuickFix.Fields.PaymentRef Get(QuickFix.Fields.PaymentRef val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PaymentRef val) { return IsSetPaymentRef(); }

        public bool IsSetPaymentRef() { return IsSetField(Tags.PaymentRef); }

        public QuickFix.Fields.CardHolderName CardHolderName
        {
            get
            {
                var val = new QuickFix.Fields.CardHolderName();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CardHolderName val) { this.CardHolderName = val; }

        public QuickFix.Fields.CardHolderName Get(QuickFix.Fields.CardHolderName val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CardHolderName val) { return IsSetCardHolderName(); }

        public bool IsSetCardHolderName() { return IsSetField(Tags.CardHolderName); }

        public QuickFix.Fields.CardNumber CardNumber
        {
            get
            {
                var val = new QuickFix.Fields.CardNumber();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CardNumber val) { this.CardNumber = val; }

        public QuickFix.Fields.CardNumber Get(QuickFix.Fields.CardNumber val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CardNumber val) { return IsSetCardNumber(); }

        public bool IsSetCardNumber() { return IsSetField(Tags.CardNumber); }

        public QuickFix.Fields.CardStartDate CardStartDate
        {
            get
            {
                var val = new QuickFix.Fields.CardStartDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CardStartDate val) { this.CardStartDate = val; }

        public QuickFix.Fields.CardStartDate Get(QuickFix.Fields.CardStartDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CardStartDate val) { return IsSetCardStartDate(); }

        public bool IsSetCardStartDate() { return IsSetField(Tags.CardStartDate); }

        public QuickFix.Fields.CardExpDate CardExpDate
        {
            get
            {
                var val = new QuickFix.Fields.CardExpDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CardExpDate val) { this.CardExpDate = val; }

        public QuickFix.Fields.CardExpDate Get(QuickFix.Fields.CardExpDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CardExpDate val) { return IsSetCardExpDate(); }

        public bool IsSetCardExpDate() { return IsSetField(Tags.CardExpDate); }

        public QuickFix.Fields.CardIssNum CardIssNum
        {
            get
            {
                var val = new QuickFix.Fields.CardIssNum();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CardIssNum val) { this.CardIssNum = val; }

        public QuickFix.Fields.CardIssNum Get(QuickFix.Fields.CardIssNum val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CardIssNum val) { return IsSetCardIssNum(); }

        public bool IsSetCardIssNum() { return IsSetField(Tags.CardIssNum); }

        public QuickFix.Fields.PaymentDate PaymentDate
        {
            get
            {
                var val = new QuickFix.Fields.PaymentDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PaymentDate val) { this.PaymentDate = val; }

        public QuickFix.Fields.PaymentDate Get(QuickFix.Fields.PaymentDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PaymentDate val) { return IsSetPaymentDate(); }

        public bool IsSetPaymentDate() { return IsSetField(Tags.PaymentDate); }

        public QuickFix.Fields.PaymentRemitterID PaymentRemitterID
        {
            get
            {
                var val = new QuickFix.Fields.PaymentRemitterID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PaymentRemitterID val) { this.PaymentRemitterID = val; }

        public QuickFix.Fields.PaymentRemitterID Get(QuickFix.Fields.PaymentRemitterID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PaymentRemitterID val) { return IsSetPaymentRemitterID(); }

        public bool IsSetPaymentRemitterID() { return IsSetField(Tags.PaymentRemitterID); }

        public QuickFix.Fields.SettlCurrency SettlCurrency
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrency val) { this.SettlCurrency = val; }

        public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrency val) { return IsSetSettlCurrency(); }

        public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }


        public class NoPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

            public NoPartyIDsGroup() : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyID PartyID
        {
            get
            {
                var val = new QuickFix.Fields.PartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyID val) { this.PartyID = val; }

        public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyID val) { return IsSetPartyID(); }

        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public QuickFix.Fields.PartyIDSource PartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.PartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyIDSource val) { this.PartyIDSource = val; }

        public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyIDSource val) { return IsSetPartyIDSource(); }

        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public QuickFix.Fields.PartyRole PartyRole
        {
            get
            {
                var val = new QuickFix.Fields.PartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyRole val) { this.PartyRole = val; }

        public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyRole val) { return IsSetPartyRole(); }

        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartySubIDs val) { this.NoPartySubIDs = val; }

        public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartySubIDs val) { return IsSetNoPartySubIDs(); }

        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }


        public class NoPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup() : base(Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartySubID PartySubID
        {
            get
            {
                var val = new QuickFix.Fields.PartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartySubID val) { this.PartySubID = val; }

        public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartySubID val) { return IsSetPartySubID(); }

        public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }

        public QuickFix.Fields.PartySubIDType PartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.PartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartySubIDType val) { this.PartySubIDType = val; }

        public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartySubIDType val) { return IsSetPartySubIDType(); }

        public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }


        }
        }
        public class NoDlvyInstGroup : Group
        {
            public static int[] fieldOrder = {Tags.SettlInstSource, Tags.DlvyInstType, Tags.NoSettlPartyIDs, 0};

            public NoDlvyInstGroup() : base(Tags.NoDlvyInst, Tags.SettlInstSource, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDlvyInstGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SettlInstSource SettlInstSource
        {
            get
            {
                var val = new QuickFix.Fields.SettlInstSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlInstSource val) { this.SettlInstSource = val; }

        public QuickFix.Fields.SettlInstSource Get(QuickFix.Fields.SettlInstSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlInstSource val) { return IsSetSettlInstSource(); }

        public bool IsSetSettlInstSource() { return IsSetField(Tags.SettlInstSource); }

        public QuickFix.Fields.DlvyInstType DlvyInstType
        {
            get
            {
                var val = new QuickFix.Fields.DlvyInstType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DlvyInstType val) { this.DlvyInstType = val; }

        public QuickFix.Fields.DlvyInstType Get(QuickFix.Fields.DlvyInstType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DlvyInstType val) { return IsSetDlvyInstType(); }

        public bool IsSetDlvyInstType() { return IsSetField(Tags.DlvyInstType); }

        public QuickFix.Fields.NoSettlPartyIDs NoSettlPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoSettlPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSettlPartyIDs val) { this.NoSettlPartyIDs = val; }

        public QuickFix.Fields.NoSettlPartyIDs Get(QuickFix.Fields.NoSettlPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSettlPartyIDs val) { return IsSetNoSettlPartyIDs(); }

        public bool IsSetNoSettlPartyIDs() { return IsSetField(Tags.NoSettlPartyIDs); }


        public class NoSettlPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};

            public NoSettlPartyIDsGroup() : base(Tags.NoSettlPartyIDs, Tags.SettlPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSettlPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SettlPartyID SettlPartyID
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartyID val) { this.SettlPartyID = val; }

        public QuickFix.Fields.SettlPartyID Get(QuickFix.Fields.SettlPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartyID val) { return IsSetSettlPartyID(); }

        public bool IsSetSettlPartyID() { return IsSetField(Tags.SettlPartyID); }

        public QuickFix.Fields.SettlPartyIDSource SettlPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartyIDSource val) { this.SettlPartyIDSource = val; }

        public QuickFix.Fields.SettlPartyIDSource Get(QuickFix.Fields.SettlPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartyIDSource val) { return IsSetSettlPartyIDSource(); }

        public bool IsSetSettlPartyIDSource() { return IsSetField(Tags.SettlPartyIDSource); }

        public QuickFix.Fields.SettlPartyRole SettlPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartyRole val) { this.SettlPartyRole = val; }

        public QuickFix.Fields.SettlPartyRole Get(QuickFix.Fields.SettlPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartyRole val) { return IsSetSettlPartyRole(); }

        public bool IsSetSettlPartyRole() { return IsSetField(Tags.SettlPartyRole); }

        public QuickFix.Fields.NoSettlPartySubIDs NoSettlPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoSettlPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSettlPartySubIDs val) { this.NoSettlPartySubIDs = val; }

        public QuickFix.Fields.NoSettlPartySubIDs Get(QuickFix.Fields.NoSettlPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSettlPartySubIDs val) { return IsSetNoSettlPartySubIDs(); }

        public bool IsSetNoSettlPartySubIDs() { return IsSetField(Tags.NoSettlPartySubIDs); }


        public class NoSettlPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};

            public NoSettlPartySubIDsGroup() : base(Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSettlPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SettlPartySubID SettlPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartySubID val) { this.SettlPartySubID = val; }

        public QuickFix.Fields.SettlPartySubID Get(QuickFix.Fields.SettlPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartySubID val) { return IsSetSettlPartySubID(); }

        public bool IsSetSettlPartySubID() { return IsSetField(Tags.SettlPartySubID); }

        public QuickFix.Fields.SettlPartySubIDType SettlPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.SettlPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlPartySubIDType val) { this.SettlPartySubIDType = val; }

        public QuickFix.Fields.SettlPartySubIDType Get(QuickFix.Fields.SettlPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlPartySubIDType val) { return IsSetSettlPartySubIDType(); }

        public bool IsSetSettlPartySubIDType() { return IsSetField(Tags.SettlPartySubIDType); }


        }
        }
        }
        }


    }
}
