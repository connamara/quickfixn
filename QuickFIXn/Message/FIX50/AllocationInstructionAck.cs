using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class AllocationInstructionAck : Message
    {
        public const string MsgType = "P";

        public AllocationInstructionAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public AllocationInstructionAck(QuickFix.Fields.AllocID aAllocID,
				QuickFix.Fields.AllocStatus aAllocStatus)
               : this()
        {
            this.AllocID = aAllocID;
			this.AllocStatus = aAllocStatus;
        }

        public QuickFix.Fields.AllocID AllocID
        {
            get
            {
                var val = new QuickFix.Fields.AllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocID val) { this.AllocID = val; }

        public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocID val) { return IsSetAllocID(); }

        public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

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

        public QuickFix.Fields.SecondaryAllocID SecondaryAllocID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryAllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryAllocID val) { this.SecondaryAllocID = val; }

        public QuickFix.Fields.SecondaryAllocID Get(QuickFix.Fields.SecondaryAllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryAllocID val) { return IsSetSecondaryAllocID(); }

        public bool IsSetSecondaryAllocID() { return IsSetField(Tags.SecondaryAllocID); }

        public QuickFix.Fields.TradeDate TradeDate
        {
            get
            {
                var val = new QuickFix.Fields.TradeDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeDate val) { this.TradeDate = val; }

        public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeDate val) { return IsSetTradeDate(); }

        public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

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

        public QuickFix.Fields.AllocStatus AllocStatus
        {
            get
            {
                var val = new QuickFix.Fields.AllocStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocStatus val) { this.AllocStatus = val; }

        public QuickFix.Fields.AllocStatus Get(QuickFix.Fields.AllocStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocStatus val) { return IsSetAllocStatus(); }

        public bool IsSetAllocStatus() { return IsSetField(Tags.AllocStatus); }

        public QuickFix.Fields.AllocRejCode AllocRejCode
        {
            get
            {
                var val = new QuickFix.Fields.AllocRejCode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocRejCode val) { this.AllocRejCode = val; }

        public QuickFix.Fields.AllocRejCode Get(QuickFix.Fields.AllocRejCode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocRejCode val) { return IsSetAllocRejCode(); }

        public bool IsSetAllocRejCode() { return IsSetField(Tags.AllocRejCode); }

        public QuickFix.Fields.AllocType AllocType
        {
            get
            {
                var val = new QuickFix.Fields.AllocType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocType val) { this.AllocType = val; }

        public QuickFix.Fields.AllocType Get(QuickFix.Fields.AllocType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocType val) { return IsSetAllocType(); }

        public bool IsSetAllocType() { return IsSetField(Tags.AllocType); }

        public QuickFix.Fields.AllocIntermedReqType AllocIntermedReqType
        {
            get
            {
                var val = new QuickFix.Fields.AllocIntermedReqType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocIntermedReqType val) { this.AllocIntermedReqType = val; }

        public QuickFix.Fields.AllocIntermedReqType Get(QuickFix.Fields.AllocIntermedReqType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocIntermedReqType val) { return IsSetAllocIntermedReqType(); }

        public bool IsSetAllocIntermedReqType() { return IsSetField(Tags.AllocIntermedReqType); }

        public QuickFix.Fields.MatchStatus MatchStatus
        {
            get
            {
                var val = new QuickFix.Fields.MatchStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MatchStatus val) { this.MatchStatus = val; }

        public QuickFix.Fields.MatchStatus Get(QuickFix.Fields.MatchStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MatchStatus val) { return IsSetMatchStatus(); }

        public bool IsSetMatchStatus() { return IsSetField(Tags.MatchStatus); }

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

        public QuickFix.Fields.NoAllocs NoAllocs
        {
            get
            {
                var val = new QuickFix.Fields.NoAllocs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoAllocs val) { this.NoAllocs = val; }

        public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoAllocs val) { return IsSetNoAllocs(); }

        public bool IsSetNoAllocs() { return IsSetField(Tags.NoAllocs); }


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


        public class NoAllocsGroup : Group
        {
            public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocPrice, Tags.IndividualAllocID, Tags.IndividualAllocRejCode, Tags.AllocText, Tags.EncodedAllocTextLen, Tags.EncodedAllocText, Tags.SecondaryIndividualAllocID, Tags.AllocCustomerCapacity, Tags.IndividualAllocType, Tags.AllocQty, Tags.NoNestedPartyIDs, Tags.AllocPositionEffect, 0};

            public NoAllocsGroup() : base(Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoAllocsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.AllocAccount AllocAccount
        {
            get
            {
                var val = new QuickFix.Fields.AllocAccount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocAccount val) { this.AllocAccount = val; }

        public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocAccount val) { return IsSetAllocAccount(); }

        public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }

        public QuickFix.Fields.AllocAcctIDSource AllocAcctIDSource
        {
            get
            {
                var val = new QuickFix.Fields.AllocAcctIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocAcctIDSource val) { this.AllocAcctIDSource = val; }

        public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) { return IsSetAllocAcctIDSource(); }

        public bool IsSetAllocAcctIDSource() { return IsSetField(Tags.AllocAcctIDSource); }

        public QuickFix.Fields.AllocPrice AllocPrice
        {
            get
            {
                var val = new QuickFix.Fields.AllocPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocPrice val) { this.AllocPrice = val; }

        public QuickFix.Fields.AllocPrice Get(QuickFix.Fields.AllocPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocPrice val) { return IsSetAllocPrice(); }

        public bool IsSetAllocPrice() { return IsSetField(Tags.AllocPrice); }

        public QuickFix.Fields.IndividualAllocID IndividualAllocID
        {
            get
            {
                var val = new QuickFix.Fields.IndividualAllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IndividualAllocID val) { this.IndividualAllocID = val; }

        public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IndividualAllocID val) { return IsSetIndividualAllocID(); }

        public bool IsSetIndividualAllocID() { return IsSetField(Tags.IndividualAllocID); }

        public QuickFix.Fields.IndividualAllocRejCode IndividualAllocRejCode
        {
            get
            {
                var val = new QuickFix.Fields.IndividualAllocRejCode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IndividualAllocRejCode val) { this.IndividualAllocRejCode = val; }

        public QuickFix.Fields.IndividualAllocRejCode Get(QuickFix.Fields.IndividualAllocRejCode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IndividualAllocRejCode val) { return IsSetIndividualAllocRejCode(); }

        public bool IsSetIndividualAllocRejCode() { return IsSetField(Tags.IndividualAllocRejCode); }

        public QuickFix.Fields.AllocText AllocText
        {
            get
            {
                var val = new QuickFix.Fields.AllocText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocText val) { this.AllocText = val; }

        public QuickFix.Fields.AllocText Get(QuickFix.Fields.AllocText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocText val) { return IsSetAllocText(); }

        public bool IsSetAllocText() { return IsSetField(Tags.AllocText); }

        public QuickFix.Fields.EncodedAllocTextLen EncodedAllocTextLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedAllocTextLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedAllocTextLen val) { this.EncodedAllocTextLen = val; }

        public QuickFix.Fields.EncodedAllocTextLen Get(QuickFix.Fields.EncodedAllocTextLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedAllocTextLen val) { return IsSetEncodedAllocTextLen(); }

        public bool IsSetEncodedAllocTextLen() { return IsSetField(Tags.EncodedAllocTextLen); }

        public QuickFix.Fields.EncodedAllocText EncodedAllocText
        {
            get
            {
                var val = new QuickFix.Fields.EncodedAllocText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedAllocText val) { this.EncodedAllocText = val; }

        public QuickFix.Fields.EncodedAllocText Get(QuickFix.Fields.EncodedAllocText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedAllocText val) { return IsSetEncodedAllocText(); }

        public bool IsSetEncodedAllocText() { return IsSetField(Tags.EncodedAllocText); }

        public QuickFix.Fields.SecondaryIndividualAllocID SecondaryIndividualAllocID
        {
            get
            {
                var val = new QuickFix.Fields.SecondaryIndividualAllocID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecondaryIndividualAllocID val) { this.SecondaryIndividualAllocID = val; }

        public QuickFix.Fields.SecondaryIndividualAllocID Get(QuickFix.Fields.SecondaryIndividualAllocID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecondaryIndividualAllocID val) { return IsSetSecondaryIndividualAllocID(); }

        public bool IsSetSecondaryIndividualAllocID() { return IsSetField(Tags.SecondaryIndividualAllocID); }

        public QuickFix.Fields.AllocCustomerCapacity AllocCustomerCapacity
        {
            get
            {
                var val = new QuickFix.Fields.AllocCustomerCapacity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocCustomerCapacity val) { this.AllocCustomerCapacity = val; }

        public QuickFix.Fields.AllocCustomerCapacity Get(QuickFix.Fields.AllocCustomerCapacity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocCustomerCapacity val) { return IsSetAllocCustomerCapacity(); }

        public bool IsSetAllocCustomerCapacity() { return IsSetField(Tags.AllocCustomerCapacity); }

        public QuickFix.Fields.IndividualAllocType IndividualAllocType
        {
            get
            {
                var val = new QuickFix.Fields.IndividualAllocType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IndividualAllocType val) { this.IndividualAllocType = val; }

        public QuickFix.Fields.IndividualAllocType Get(QuickFix.Fields.IndividualAllocType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IndividualAllocType val) { return IsSetIndividualAllocType(); }

        public bool IsSetIndividualAllocType() { return IsSetField(Tags.IndividualAllocType); }

        public QuickFix.Fields.AllocQty AllocQty
        {
            get
            {
                var val = new QuickFix.Fields.AllocQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocQty val) { this.AllocQty = val; }

        public QuickFix.Fields.AllocQty Get(QuickFix.Fields.AllocQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocQty val) { return IsSetAllocQty(); }

        public bool IsSetAllocQty() { return IsSetField(Tags.AllocQty); }

        public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoNestedPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoNestedPartyIDs val) { this.NoNestedPartyIDs = val; }

        public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) { return IsSetNoNestedPartyIDs(); }

        public bool IsSetNoNestedPartyIDs() { return IsSetField(Tags.NoNestedPartyIDs); }

        public QuickFix.Fields.AllocPositionEffect AllocPositionEffect
        {
            get
            {
                var val = new QuickFix.Fields.AllocPositionEffect();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AllocPositionEffect val) { this.AllocPositionEffect = val; }

        public QuickFix.Fields.AllocPositionEffect Get(QuickFix.Fields.AllocPositionEffect val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AllocPositionEffect val) { return IsSetAllocPositionEffect(); }

        public bool IsSetAllocPositionEffect() { return IsSetField(Tags.AllocPositionEffect); }


        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};

            public NoNestedPartyIDsGroup() : base(Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.NestedPartyID NestedPartyID
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartyID val) { this.NestedPartyID = val; }

        public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartyID val) { return IsSetNestedPartyID(); }

        public bool IsSetNestedPartyID() { return IsSetField(Tags.NestedPartyID); }

        public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartyIDSource val) { this.NestedPartyIDSource = val; }

        public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) { return IsSetNestedPartyIDSource(); }

        public bool IsSetNestedPartyIDSource() { return IsSetField(Tags.NestedPartyIDSource); }

        public QuickFix.Fields.NestedPartyRole NestedPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartyRole val) { this.NestedPartyRole = val; }

        public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartyRole val) { return IsSetNestedPartyRole(); }

        public bool IsSetNestedPartyRole() { return IsSetField(Tags.NestedPartyRole); }

        public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoNestedPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoNestedPartySubIDs val) { this.NoNestedPartySubIDs = val; }

        public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) { return IsSetNoNestedPartySubIDs(); }

        public bool IsSetNoNestedPartySubIDs() { return IsSetField(Tags.NoNestedPartySubIDs); }


        public class NoNestedPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};

            public NoNestedPartySubIDsGroup() : base(Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.NestedPartySubID NestedPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartySubID val) { this.NestedPartySubID = val; }

        public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartySubID val) { return IsSetNestedPartySubID(); }

        public bool IsSetNestedPartySubID() { return IsSetField(Tags.NestedPartySubID); }

        public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.NestedPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NestedPartySubIDType val) { this.NestedPartySubIDType = val; }

        public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) { return IsSetNestedPartySubIDType(); }

        public bool IsSetNestedPartySubIDType() { return IsSetField(Tags.NestedPartySubIDType); }


        }
        }
        }


    }
}
