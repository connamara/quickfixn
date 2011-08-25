// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class SettlementInstructions : Message
        {
            public SettlementInstructions() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("T"));
            }

            public SettlementInstructions(
                    QuickFix.Fields.SettlInstMsgID aSettlInstMsgID,
                    QuickFix.Fields.SettlInstMode aSettlInstMode,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.settlInstMsgID = aSettlInstMsgID;
                this.settlInstMode = aSettlInstMode;
                this.transactTime = aTransactTime;
            }

            public QuickFix.Fields.SettlInstMsgID settlInstMsgID
            { 
                get 
                {
                    QuickFix.Fields.SettlInstMsgID val = new QuickFix.Fields.SettlInstMsgID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstMsgID val) 
            { 
                this.settlInstMsgID = val;
            }
            
            public QuickFix.Fields.SettlInstMsgID get(QuickFix.Fields.SettlInstMsgID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstMsgID val) 
            { 
                return isSetSettlInstMsgID();
            }
            
            public bool isSetSettlInstMsgID() 
            { 
                return isSetField(Tags.SettlInstMsgID);
            }
            public QuickFix.Fields.SettlInstReqID settlInstReqID
            { 
                get 
                {
                    QuickFix.Fields.SettlInstReqID val = new QuickFix.Fields.SettlInstReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstReqID val) 
            { 
                this.settlInstReqID = val;
            }
            
            public QuickFix.Fields.SettlInstReqID get(QuickFix.Fields.SettlInstReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstReqID val) 
            { 
                return isSetSettlInstReqID();
            }
            
            public bool isSetSettlInstReqID() 
            { 
                return isSetField(Tags.SettlInstReqID);
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
            public QuickFix.Fields.SettlInstReqRejCode settlInstReqRejCode
            { 
                get 
                {
                    QuickFix.Fields.SettlInstReqRejCode val = new QuickFix.Fields.SettlInstReqRejCode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstReqRejCode val) 
            { 
                this.settlInstReqRejCode = val;
            }
            
            public QuickFix.Fields.SettlInstReqRejCode get(QuickFix.Fields.SettlInstReqRejCode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstReqRejCode val) 
            { 
                return isSetSettlInstReqRejCode();
            }
            
            public bool isSetSettlInstReqRejCode() 
            { 
                return isSetField(Tags.SettlInstReqRejCode);
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
            public QuickFix.Fields.NoSettlInst noSettlInst
            { 
                get 
                {
                    QuickFix.Fields.NoSettlInst val = new QuickFix.Fields.NoSettlInst();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoSettlInst val) 
            { 
                this.noSettlInst = val;
            }
            
            public QuickFix.Fields.NoSettlInst get(QuickFix.Fields.NoSettlInst val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoSettlInst val) 
            { 
                return isSetNoSettlInst();
            }
            
            public bool isSetNoSettlInst() 
            { 
                return isSetField(Tags.NoSettlInst);
            }
            public class NoSettlInst : Group
            {
                public NoSettlInst() 
                  :base( Tags.NoSettlInst, Tags.SettlInstID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.SettlInstID, Tags.SettlInstTransType, Tags.SettlInstRefID, Tags.NoPartyIDs, Tags.Side, Tags.Product, Tags.SecurityType, Tags.CFICode, Tags.EffectiveTime, Tags.ExpireTime, Tags.LastUpdateTime, Tags.SettlDeliveryType, Tags.StandInstDbType, Tags.StandInstDbName, Tags.StandInstDbID, Tags.NoDlvyInst, Tags.PaymentMethod, Tags.PaymentRef, Tags.CardHolderName, Tags.CardNumber, Tags.CardStartDate, Tags.CardExpDate, Tags.CardIssNum, Tags.PaymentDate, Tags.PaymentRemitterID, 0};
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
                public QuickFix.Fields.Product product
                { 
                    get 
                    {
                        QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Product val) 
                { 
                    this.product = val;
                }
                
                public QuickFix.Fields.Product get(QuickFix.Fields.Product val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Product val) 
                { 
                    return isSetProduct();
                }
                
                public bool isSetProduct() 
                { 
                    return isSetField(Tags.Product);
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
                public QuickFix.Fields.CFICode cFICode
                { 
                    get 
                    {
                        QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CFICode val) 
                { 
                    this.cFICode = val;
                }
                
                public QuickFix.Fields.CFICode get(QuickFix.Fields.CFICode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CFICode val) 
                { 
                    return isSetCFICode();
                }
                
                public bool isSetCFICode() 
                { 
                    return isSetField(Tags.CFICode);
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
                public QuickFix.Fields.ExpireTime expireTime
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExpireTime val) 
                { 
                    this.expireTime = val;
                }
                
                public QuickFix.Fields.ExpireTime get(QuickFix.Fields.ExpireTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExpireTime val) 
                { 
                    return isSetExpireTime();
                }
                
                public bool isSetExpireTime() 
                { 
                    return isSetField(Tags.ExpireTime);
                }
                public QuickFix.Fields.LastUpdateTime lastUpdateTime
                { 
                    get 
                    {
                        QuickFix.Fields.LastUpdateTime val = new QuickFix.Fields.LastUpdateTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LastUpdateTime val) 
                { 
                    this.lastUpdateTime = val;
                }
                
                public QuickFix.Fields.LastUpdateTime get(QuickFix.Fields.LastUpdateTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LastUpdateTime val) 
                { 
                    return isSetLastUpdateTime();
                }
                
                public bool isSetLastUpdateTime() 
                { 
                    return isSetField(Tags.LastUpdateTime);
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
                public QuickFix.Fields.NoDlvyInst noDlvyInst
                { 
                    get 
                    {
                        QuickFix.Fields.NoDlvyInst val = new QuickFix.Fields.NoDlvyInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoDlvyInst val) 
                { 
                    this.noDlvyInst = val;
                }
                
                public QuickFix.Fields.NoDlvyInst get(QuickFix.Fields.NoDlvyInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoDlvyInst val) 
                { 
                    return isSetNoDlvyInst();
                }
                
                public bool isSetNoDlvyInst() 
                { 
                    return isSetField(Tags.NoDlvyInst);
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
                public QuickFix.Fields.CardIssNum cardIssNum
                { 
                    get 
                    {
                        QuickFix.Fields.CardIssNum val = new QuickFix.Fields.CardIssNum();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CardIssNum val) 
                { 
                    this.cardIssNum = val;
                }
                
                public QuickFix.Fields.CardIssNum get(QuickFix.Fields.CardIssNum val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CardIssNum val) 
                { 
                    return isSetCardIssNum();
                }
                
                public bool isSetCardIssNum() 
                { 
                    return isSetField(Tags.CardIssNum);
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
                    public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
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
                    public QuickFix.Fields.NoPartySubIDs noPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        this.noPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoPartySubIDs get(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        return isSetNoPartySubIDs();
                    }
                    
                    public bool isSetNoPartySubIDs() 
                    { 
                        return isSetField(Tags.NoPartySubIDs);
                    }
                                    public class NoPartySubIDs : Group
                    {
                        public NoPartySubIDs() 
                          :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
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
                        public QuickFix.Fields.PartySubIDType partySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.PartySubIDType val) 
                        { 
                            this.partySubIDType = val;
                        }
                        
                        public QuickFix.Fields.PartySubIDType get(QuickFix.Fields.PartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.PartySubIDType val) 
                        { 
                            return isSetPartySubIDType();
                        }
                        
                        public bool isSetPartySubIDType() 
                        { 
                            return isSetField(Tags.PartySubIDType);
                        }
                    
                    }
                }
                public class NoDlvyInst : Group
                {
                    public NoDlvyInst() 
                      :base( Tags.NoDlvyInst, Tags.SettlInstSource, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.SettlInstSource, Tags.DlvyInstType, Tags.NoSettlPartyIDs, 0};
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
                    public QuickFix.Fields.DlvyInstType dlvyInstType
                    { 
                        get 
                        {
                            QuickFix.Fields.DlvyInstType val = new QuickFix.Fields.DlvyInstType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.DlvyInstType val) 
                    { 
                        this.dlvyInstType = val;
                    }
                    
                    public QuickFix.Fields.DlvyInstType get(QuickFix.Fields.DlvyInstType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.DlvyInstType val) 
                    { 
                        return isSetDlvyInstType();
                    }
                    
                    public bool isSetDlvyInstType() 
                    { 
                        return isSetField(Tags.DlvyInstType);
                    }
                    public QuickFix.Fields.NoSettlPartyIDs noSettlPartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoSettlPartyIDs val = new QuickFix.Fields.NoSettlPartyIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        this.noSettlPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoSettlPartyIDs get(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        return isSetNoSettlPartyIDs();
                    }
                    
                    public bool isSetNoSettlPartyIDs() 
                    { 
                        return isSetField(Tags.NoSettlPartyIDs);
                    }
                                    public class NoSettlPartyIDs : Group
                    {
                        public NoSettlPartyIDs() 
                          :base( Tags.NoSettlPartyIDs, Tags.SettlPartyID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};
                                            public QuickFix.Fields.SettlPartyID settlPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyID val = new QuickFix.Fields.SettlPartyID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.SettlPartyID val) 
                        { 
                            this.settlPartyID = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyID get(QuickFix.Fields.SettlPartyID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.SettlPartyID val) 
                        { 
                            return isSetSettlPartyID();
                        }
                        
                        public bool isSetSettlPartyID() 
                        { 
                            return isSetField(Tags.SettlPartyID);
                        }
                        public QuickFix.Fields.SettlPartyIDSource settlPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyIDSource val = new QuickFix.Fields.SettlPartyIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            this.settlPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyIDSource get(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            return isSetSettlPartyIDSource();
                        }
                        
                        public bool isSetSettlPartyIDSource() 
                        { 
                            return isSetField(Tags.SettlPartyIDSource);
                        }
                        public QuickFix.Fields.SettlPartyRole settlPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyRole val = new QuickFix.Fields.SettlPartyRole();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            this.settlPartyRole = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyRole get(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            return isSetSettlPartyRole();
                        }
                        
                        public bool isSetSettlPartyRole() 
                        { 
                            return isSetField(Tags.SettlPartyRole);
                        }
                        public QuickFix.Fields.NoSettlPartySubIDs noSettlPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoSettlPartySubIDs val = new QuickFix.Fields.NoSettlPartySubIDs();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            this.noSettlPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoSettlPartySubIDs get(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            return isSetNoSettlPartySubIDs();
                        }
                        
                        public bool isSetNoSettlPartySubIDs() 
                        { 
                            return isSetField(Tags.NoSettlPartySubIDs);
                        }
                                            public class NoSettlPartySubIDs : Group
                        {
                            public NoSettlPartySubIDs() 
                              :base( Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};
                                                    public QuickFix.Fields.SettlPartySubID settlPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.SettlPartySubID val = new QuickFix.Fields.SettlPartySubID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                this.settlPartySubID = val;
                            }
                            
                            public QuickFix.Fields.SettlPartySubID get(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                return isSetSettlPartySubID();
                            }
                            
                            public bool isSetSettlPartySubID() 
                            { 
                                return isSetField(Tags.SettlPartySubID);
                            }
                            public QuickFix.Fields.SettlPartySubIDType settlPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.SettlPartySubIDType val = new QuickFix.Fields.SettlPartySubIDType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                this.settlPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.SettlPartySubIDType get(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                return isSetSettlPartySubIDType();
                            }
                            
                            public bool isSetSettlPartySubIDType() 
                            { 
                                return isSetField(Tags.SettlPartySubIDType);
                            }
                        
                        }
                    }
                }
            }
        }
    }
}
