using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class PartyDetailsListReport : Message
    {
        public const string MsgType = "CG";

        public PartyDetailsListReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public PartyDetailsListReport(QuickFix.Fields.PartyDetailsListReportID aPartyDetailsListReportID)
               : this()
        {
            this.PartyDetailsListReportID = aPartyDetailsListReportID;
        }

        public QuickFix.Fields.ApplID ApplID
        {
            get
            {
                var val = new QuickFix.Fields.ApplID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ApplID val) { this.ApplID = val; }

        public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ApplID val) { return IsSetApplID(); }

        public bool IsSetApplID() { return IsSetField(Tags.ApplID); }

        public QuickFix.Fields.ApplSeqNum ApplSeqNum
        {
            get
            {
                var val = new QuickFix.Fields.ApplSeqNum();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ApplSeqNum val) { this.ApplSeqNum = val; }

        public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ApplSeqNum val) { return IsSetApplSeqNum(); }

        public bool IsSetApplSeqNum() { return IsSetField(Tags.ApplSeqNum); }

        public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
        {
            get
            {
                var val = new QuickFix.Fields.ApplLastSeqNum();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ApplLastSeqNum val) { this.ApplLastSeqNum = val; }

        public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) { return IsSetApplLastSeqNum(); }

        public bool IsSetApplLastSeqNum() { return IsSetField(Tags.ApplLastSeqNum); }

        public QuickFix.Fields.ApplResendFlag ApplResendFlag
        {
            get
            {
                var val = new QuickFix.Fields.ApplResendFlag();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ApplResendFlag val) { this.ApplResendFlag = val; }

        public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ApplResendFlag val) { return IsSetApplResendFlag(); }

        public bool IsSetApplResendFlag() { return IsSetField(Tags.ApplResendFlag); }

        public QuickFix.Fields.PartyDetailsListReportID PartyDetailsListReportID
        {
            get
            {
                var val = new QuickFix.Fields.PartyDetailsListReportID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyDetailsListReportID val) { this.PartyDetailsListReportID = val; }

        public QuickFix.Fields.PartyDetailsListReportID Get(QuickFix.Fields.PartyDetailsListReportID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyDetailsListReportID val) { return IsSetPartyDetailsListReportID(); }

        public bool IsSetPartyDetailsListReportID() { return IsSetField(Tags.PartyDetailsListReportID); }

        public QuickFix.Fields.PartyDetailsListRequestID PartyDetailsListRequestID
        {
            get
            {
                var val = new QuickFix.Fields.PartyDetailsListRequestID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyDetailsListRequestID val) { this.PartyDetailsListRequestID = val; }

        public QuickFix.Fields.PartyDetailsListRequestID Get(QuickFix.Fields.PartyDetailsListRequestID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyDetailsListRequestID val) { return IsSetPartyDetailsListRequestID(); }

        public bool IsSetPartyDetailsListRequestID() { return IsSetField(Tags.PartyDetailsListRequestID); }

        public QuickFix.Fields.PartyDetailsRequestResult PartyDetailsRequestResult
        {
            get
            {
                var val = new QuickFix.Fields.PartyDetailsRequestResult();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyDetailsRequestResult val) { this.PartyDetailsRequestResult = val; }

        public QuickFix.Fields.PartyDetailsRequestResult Get(QuickFix.Fields.PartyDetailsRequestResult val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyDetailsRequestResult val) { return IsSetPartyDetailsRequestResult(); }

        public bool IsSetPartyDetailsRequestResult() { return IsSetField(Tags.PartyDetailsRequestResult); }

        public QuickFix.Fields.TotNoPartyList TotNoPartyList
        {
            get
            {
                var val = new QuickFix.Fields.TotNoPartyList();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TotNoPartyList val) { this.TotNoPartyList = val; }

        public QuickFix.Fields.TotNoPartyList Get(QuickFix.Fields.TotNoPartyList val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TotNoPartyList val) { return IsSetTotNoPartyList(); }

        public bool IsSetTotNoPartyList() { return IsSetField(Tags.TotNoPartyList); }

        public QuickFix.Fields.LastFragment LastFragment
        {
            get
            {
                var val = new QuickFix.Fields.LastFragment();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LastFragment val) { this.LastFragment = val; }

        public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LastFragment val) { return IsSetLastFragment(); }

        public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }

        public QuickFix.Fields.NoPartyList NoPartyList
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyList();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyList val) { this.NoPartyList = val; }

        public QuickFix.Fields.NoPartyList Get(QuickFix.Fields.NoPartyList val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyList val) { return IsSetNoPartyList(); }

        public bool IsSetNoPartyList() { return IsSetField(Tags.NoPartyList); }

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


        public class NoPartyListGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, Tags.NoPartyAltIDs, Tags.NoContextPartyIDs, Tags.NoRiskLimits, Tags.NoRelatedPartyIDs, 0};

            public NoPartyListGroup() : base(Tags.NoPartyList, Tags.PartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyListGroup();
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

        public QuickFix.Fields.NoPartyAltIDs NoPartyAltIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyAltIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyAltIDs val) { this.NoPartyAltIDs = val; }

        public QuickFix.Fields.NoPartyAltIDs Get(QuickFix.Fields.NoPartyAltIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyAltIDs val) { return IsSetNoPartyAltIDs(); }

        public bool IsSetNoPartyAltIDs() { return IsSetField(Tags.NoPartyAltIDs); }

        public QuickFix.Fields.NoContextPartyIDs NoContextPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoContextPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoContextPartyIDs val) { this.NoContextPartyIDs = val; }

        public QuickFix.Fields.NoContextPartyIDs Get(QuickFix.Fields.NoContextPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoContextPartyIDs val) { return IsSetNoContextPartyIDs(); }

        public bool IsSetNoContextPartyIDs() { return IsSetField(Tags.NoContextPartyIDs); }

        public QuickFix.Fields.NoRiskLimits NoRiskLimits
        {
            get
            {
                var val = new QuickFix.Fields.NoRiskLimits();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRiskLimits val) { this.NoRiskLimits = val; }

        public QuickFix.Fields.NoRiskLimits Get(QuickFix.Fields.NoRiskLimits val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRiskLimits val) { return IsSetNoRiskLimits(); }

        public bool IsSetNoRiskLimits() { return IsSetField(Tags.NoRiskLimits); }

        public QuickFix.Fields.NoRelatedPartyIDs NoRelatedPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRelatedPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelatedPartyIDs val) { this.NoRelatedPartyIDs = val; }

        public QuickFix.Fields.NoRelatedPartyIDs Get(QuickFix.Fields.NoRelatedPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelatedPartyIDs val) { return IsSetNoRelatedPartyIDs(); }

        public bool IsSetNoRelatedPartyIDs() { return IsSetField(Tags.NoRelatedPartyIDs); }


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
        public class NoPartyAltIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyAltID, Tags.PartyAltIDSource, Tags.NoPartyAltSubIDs, 0};

            public NoPartyAltIDsGroup() : base(Tags.NoPartyAltIDs, Tags.PartyAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyAltIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyAltID PartyAltID
        {
            get
            {
                var val = new QuickFix.Fields.PartyAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyAltID val) { this.PartyAltID = val; }

        public QuickFix.Fields.PartyAltID Get(QuickFix.Fields.PartyAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyAltID val) { return IsSetPartyAltID(); }

        public bool IsSetPartyAltID() { return IsSetField(Tags.PartyAltID); }

        public QuickFix.Fields.PartyAltIDSource PartyAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.PartyAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyAltIDSource val) { this.PartyAltIDSource = val; }

        public QuickFix.Fields.PartyAltIDSource Get(QuickFix.Fields.PartyAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyAltIDSource val) { return IsSetPartyAltIDSource(); }

        public bool IsSetPartyAltIDSource() { return IsSetField(Tags.PartyAltIDSource); }

        public QuickFix.Fields.NoPartyAltSubIDs NoPartyAltSubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyAltSubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyAltSubIDs val) { this.NoPartyAltSubIDs = val; }

        public QuickFix.Fields.NoPartyAltSubIDs Get(QuickFix.Fields.NoPartyAltSubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyAltSubIDs val) { return IsSetNoPartyAltSubIDs(); }

        public bool IsSetNoPartyAltSubIDs() { return IsSetField(Tags.NoPartyAltSubIDs); }


        public class NoPartyAltSubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyAltSubID, Tags.PartyAltSubIDType, 0};

            public NoPartyAltSubIDsGroup() : base(Tags.NoPartyAltSubIDs, Tags.PartyAltSubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyAltSubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyAltSubID PartyAltSubID
        {
            get
            {
                var val = new QuickFix.Fields.PartyAltSubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyAltSubID val) { this.PartyAltSubID = val; }

        public QuickFix.Fields.PartyAltSubID Get(QuickFix.Fields.PartyAltSubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyAltSubID val) { return IsSetPartyAltSubID(); }

        public bool IsSetPartyAltSubID() { return IsSetField(Tags.PartyAltSubID); }

        public QuickFix.Fields.PartyAltSubIDType PartyAltSubIDType
        {
            get
            {
                var val = new QuickFix.Fields.PartyAltSubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyAltSubIDType val) { this.PartyAltSubIDType = val; }

        public QuickFix.Fields.PartyAltSubIDType Get(QuickFix.Fields.PartyAltSubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyAltSubIDType val) { return IsSetPartyAltSubIDType(); }

        public bool IsSetPartyAltSubIDType() { return IsSetField(Tags.PartyAltSubIDType); }


        }
        }
        public class NoContextPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.ContextPartyID, Tags.ContextPartyIDSource, Tags.ContextPartyRole, Tags.NoContextPartySubIDs, 0};

            public NoContextPartyIDsGroup() : base(Tags.NoContextPartyIDs, Tags.ContextPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoContextPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ContextPartyID ContextPartyID
        {
            get
            {
                var val = new QuickFix.Fields.ContextPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContextPartyID val) { this.ContextPartyID = val; }

        public QuickFix.Fields.ContextPartyID Get(QuickFix.Fields.ContextPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContextPartyID val) { return IsSetContextPartyID(); }

        public bool IsSetContextPartyID() { return IsSetField(Tags.ContextPartyID); }

        public QuickFix.Fields.ContextPartyIDSource ContextPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.ContextPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContextPartyIDSource val) { this.ContextPartyIDSource = val; }

        public QuickFix.Fields.ContextPartyIDSource Get(QuickFix.Fields.ContextPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContextPartyIDSource val) { return IsSetContextPartyIDSource(); }

        public bool IsSetContextPartyIDSource() { return IsSetField(Tags.ContextPartyIDSource); }

        public QuickFix.Fields.ContextPartyRole ContextPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.ContextPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContextPartyRole val) { this.ContextPartyRole = val; }

        public QuickFix.Fields.ContextPartyRole Get(QuickFix.Fields.ContextPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContextPartyRole val) { return IsSetContextPartyRole(); }

        public bool IsSetContextPartyRole() { return IsSetField(Tags.ContextPartyRole); }

        public QuickFix.Fields.NoContextPartySubIDs NoContextPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoContextPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoContextPartySubIDs val) { this.NoContextPartySubIDs = val; }

        public QuickFix.Fields.NoContextPartySubIDs Get(QuickFix.Fields.NoContextPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoContextPartySubIDs val) { return IsSetNoContextPartySubIDs(); }

        public bool IsSetNoContextPartySubIDs() { return IsSetField(Tags.NoContextPartySubIDs); }


        public class NoContextPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.ContextPartySubID, Tags.ContextPartySubIDType, 0};

            public NoContextPartySubIDsGroup() : base(Tags.NoContextPartySubIDs, Tags.ContextPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoContextPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.ContextPartySubID ContextPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.ContextPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContextPartySubID val) { this.ContextPartySubID = val; }

        public QuickFix.Fields.ContextPartySubID Get(QuickFix.Fields.ContextPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContextPartySubID val) { return IsSetContextPartySubID(); }

        public bool IsSetContextPartySubID() { return IsSetField(Tags.ContextPartySubID); }

        public QuickFix.Fields.ContextPartySubIDType ContextPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.ContextPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContextPartySubIDType val) { this.ContextPartySubIDType = val; }

        public QuickFix.Fields.ContextPartySubIDType Get(QuickFix.Fields.ContextPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContextPartySubIDType val) { return IsSetContextPartySubIDType(); }

        public bool IsSetContextPartySubIDType() { return IsSetField(Tags.ContextPartySubIDType); }


        }
        }
        public class NoRiskLimitsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RiskLimitType, Tags.RiskLimitAmount, Tags.RiskLimitCurrency, Tags.RiskLimitPlatform, Tags.NoRiskInstruments, Tags.NoRiskWarningLevels, 0};

            public NoRiskLimitsGroup() : base(Tags.NoRiskLimits, Tags.RiskLimitType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRiskLimitsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RiskLimitType RiskLimitType
        {
            get
            {
                var val = new QuickFix.Fields.RiskLimitType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskLimitType val) { this.RiskLimitType = val; }

        public QuickFix.Fields.RiskLimitType Get(QuickFix.Fields.RiskLimitType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskLimitType val) { return IsSetRiskLimitType(); }

        public bool IsSetRiskLimitType() { return IsSetField(Tags.RiskLimitType); }

        public QuickFix.Fields.RiskLimitAmount RiskLimitAmount
        {
            get
            {
                var val = new QuickFix.Fields.RiskLimitAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskLimitAmount val) { this.RiskLimitAmount = val; }

        public QuickFix.Fields.RiskLimitAmount Get(QuickFix.Fields.RiskLimitAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskLimitAmount val) { return IsSetRiskLimitAmount(); }

        public bool IsSetRiskLimitAmount() { return IsSetField(Tags.RiskLimitAmount); }

        public QuickFix.Fields.RiskLimitCurrency RiskLimitCurrency
        {
            get
            {
                var val = new QuickFix.Fields.RiskLimitCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskLimitCurrency val) { this.RiskLimitCurrency = val; }

        public QuickFix.Fields.RiskLimitCurrency Get(QuickFix.Fields.RiskLimitCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskLimitCurrency val) { return IsSetRiskLimitCurrency(); }

        public bool IsSetRiskLimitCurrency() { return IsSetField(Tags.RiskLimitCurrency); }

        public QuickFix.Fields.RiskLimitPlatform RiskLimitPlatform
        {
            get
            {
                var val = new QuickFix.Fields.RiskLimitPlatform();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskLimitPlatform val) { this.RiskLimitPlatform = val; }

        public QuickFix.Fields.RiskLimitPlatform Get(QuickFix.Fields.RiskLimitPlatform val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskLimitPlatform val) { return IsSetRiskLimitPlatform(); }

        public bool IsSetRiskLimitPlatform() { return IsSetField(Tags.RiskLimitPlatform); }

        public QuickFix.Fields.NoRiskInstruments NoRiskInstruments
        {
            get
            {
                var val = new QuickFix.Fields.NoRiskInstruments();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRiskInstruments val) { this.NoRiskInstruments = val; }

        public QuickFix.Fields.NoRiskInstruments Get(QuickFix.Fields.NoRiskInstruments val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRiskInstruments val) { return IsSetNoRiskInstruments(); }

        public bool IsSetNoRiskInstruments() { return IsSetField(Tags.NoRiskInstruments); }

        public QuickFix.Fields.NoRiskWarningLevels NoRiskWarningLevels
        {
            get
            {
                var val = new QuickFix.Fields.NoRiskWarningLevels();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRiskWarningLevels val) { this.NoRiskWarningLevels = val; }

        public QuickFix.Fields.NoRiskWarningLevels Get(QuickFix.Fields.NoRiskWarningLevels val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRiskWarningLevels val) { return IsSetNoRiskWarningLevels(); }

        public bool IsSetNoRiskWarningLevels() { return IsSetField(Tags.NoRiskWarningLevels); }


        public class NoRiskInstrumentsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RiskInstrumentOperator, Tags.RiskSymbol, Tags.RiskSymbolSfx, Tags.RiskSecurityID, Tags.RiskSecurityIDSource, Tags.NoRiskSecurityAltID, Tags.RiskProduct, Tags.RiskProductComplex, Tags.RiskSecurityGroup, Tags.RiskCFICode, Tags.RiskSecurityType, Tags.RiskSecuritySubType, Tags.RiskMaturityMonthYear, Tags.RiskMaturityTime, Tags.RiskRestructuringType, Tags.RiskSeniority, Tags.RiskPutOrCall, Tags.RiskFlexibleIndicator, Tags.RiskCouponRate, Tags.RiskSecurityExchange, Tags.RiskSecurityDesc, Tags.RiskEncodedSecurityDescLen, Tags.RiskEncodedSecurityDesc, Tags.RiskInstrumentSettlType, Tags.RiskInstrumentMultiplier, 0};

            public NoRiskInstrumentsGroup() : base(Tags.NoRiskInstruments, Tags.RiskInstrumentOperator, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRiskInstrumentsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RiskInstrumentOperator RiskInstrumentOperator
        {
            get
            {
                var val = new QuickFix.Fields.RiskInstrumentOperator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskInstrumentOperator val) { this.RiskInstrumentOperator = val; }

        public QuickFix.Fields.RiskInstrumentOperator Get(QuickFix.Fields.RiskInstrumentOperator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskInstrumentOperator val) { return IsSetRiskInstrumentOperator(); }

        public bool IsSetRiskInstrumentOperator() { return IsSetField(Tags.RiskInstrumentOperator); }

        public QuickFix.Fields.RiskSymbol RiskSymbol
        {
            get
            {
                var val = new QuickFix.Fields.RiskSymbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSymbol val) { this.RiskSymbol = val; }

        public QuickFix.Fields.RiskSymbol Get(QuickFix.Fields.RiskSymbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSymbol val) { return IsSetRiskSymbol(); }

        public bool IsSetRiskSymbol() { return IsSetField(Tags.RiskSymbol); }

        public QuickFix.Fields.RiskSymbolSfx RiskSymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.RiskSymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSymbolSfx val) { this.RiskSymbolSfx = val; }

        public QuickFix.Fields.RiskSymbolSfx Get(QuickFix.Fields.RiskSymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSymbolSfx val) { return IsSetRiskSymbolSfx(); }

        public bool IsSetRiskSymbolSfx() { return IsSetField(Tags.RiskSymbolSfx); }

        public QuickFix.Fields.RiskSecurityID RiskSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecurityID val) { this.RiskSecurityID = val; }

        public QuickFix.Fields.RiskSecurityID Get(QuickFix.Fields.RiskSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecurityID val) { return IsSetRiskSecurityID(); }

        public bool IsSetRiskSecurityID() { return IsSetField(Tags.RiskSecurityID); }

        public QuickFix.Fields.RiskSecurityIDSource RiskSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecurityIDSource val) { this.RiskSecurityIDSource = val; }

        public QuickFix.Fields.RiskSecurityIDSource Get(QuickFix.Fields.RiskSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecurityIDSource val) { return IsSetRiskSecurityIDSource(); }

        public bool IsSetRiskSecurityIDSource() { return IsSetField(Tags.RiskSecurityIDSource); }

        public QuickFix.Fields.NoRiskSecurityAltID NoRiskSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoRiskSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRiskSecurityAltID val) { this.NoRiskSecurityAltID = val; }

        public QuickFix.Fields.NoRiskSecurityAltID Get(QuickFix.Fields.NoRiskSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRiskSecurityAltID val) { return IsSetNoRiskSecurityAltID(); }

        public bool IsSetNoRiskSecurityAltID() { return IsSetField(Tags.NoRiskSecurityAltID); }

        public QuickFix.Fields.RiskProduct RiskProduct
        {
            get
            {
                var val = new QuickFix.Fields.RiskProduct();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskProduct val) { this.RiskProduct = val; }

        public QuickFix.Fields.RiskProduct Get(QuickFix.Fields.RiskProduct val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskProduct val) { return IsSetRiskProduct(); }

        public bool IsSetRiskProduct() { return IsSetField(Tags.RiskProduct); }

        public QuickFix.Fields.RiskProductComplex RiskProductComplex
        {
            get
            {
                var val = new QuickFix.Fields.RiskProductComplex();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskProductComplex val) { this.RiskProductComplex = val; }

        public QuickFix.Fields.RiskProductComplex Get(QuickFix.Fields.RiskProductComplex val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskProductComplex val) { return IsSetRiskProductComplex(); }

        public bool IsSetRiskProductComplex() { return IsSetField(Tags.RiskProductComplex); }

        public QuickFix.Fields.RiskSecurityGroup RiskSecurityGroup
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecurityGroup();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecurityGroup val) { this.RiskSecurityGroup = val; }

        public QuickFix.Fields.RiskSecurityGroup Get(QuickFix.Fields.RiskSecurityGroup val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecurityGroup val) { return IsSetRiskSecurityGroup(); }

        public bool IsSetRiskSecurityGroup() { return IsSetField(Tags.RiskSecurityGroup); }

        public QuickFix.Fields.RiskCFICode RiskCFICode
        {
            get
            {
                var val = new QuickFix.Fields.RiskCFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskCFICode val) { this.RiskCFICode = val; }

        public QuickFix.Fields.RiskCFICode Get(QuickFix.Fields.RiskCFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskCFICode val) { return IsSetRiskCFICode(); }

        public bool IsSetRiskCFICode() { return IsSetField(Tags.RiskCFICode); }

        public QuickFix.Fields.RiskSecurityType RiskSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecurityType val) { this.RiskSecurityType = val; }

        public QuickFix.Fields.RiskSecurityType Get(QuickFix.Fields.RiskSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecurityType val) { return IsSetRiskSecurityType(); }

        public bool IsSetRiskSecurityType() { return IsSetField(Tags.RiskSecurityType); }

        public QuickFix.Fields.RiskSecuritySubType RiskSecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecuritySubType val) { this.RiskSecuritySubType = val; }

        public QuickFix.Fields.RiskSecuritySubType Get(QuickFix.Fields.RiskSecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecuritySubType val) { return IsSetRiskSecuritySubType(); }

        public bool IsSetRiskSecuritySubType() { return IsSetField(Tags.RiskSecuritySubType); }

        public QuickFix.Fields.RiskMaturityMonthYear RiskMaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.RiskMaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskMaturityMonthYear val) { this.RiskMaturityMonthYear = val; }

        public QuickFix.Fields.RiskMaturityMonthYear Get(QuickFix.Fields.RiskMaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskMaturityMonthYear val) { return IsSetRiskMaturityMonthYear(); }

        public bool IsSetRiskMaturityMonthYear() { return IsSetField(Tags.RiskMaturityMonthYear); }

        public QuickFix.Fields.RiskMaturityTime RiskMaturityTime
        {
            get
            {
                var val = new QuickFix.Fields.RiskMaturityTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskMaturityTime val) { this.RiskMaturityTime = val; }

        public QuickFix.Fields.RiskMaturityTime Get(QuickFix.Fields.RiskMaturityTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskMaturityTime val) { return IsSetRiskMaturityTime(); }

        public bool IsSetRiskMaturityTime() { return IsSetField(Tags.RiskMaturityTime); }

        public QuickFix.Fields.RiskRestructuringType RiskRestructuringType
        {
            get
            {
                var val = new QuickFix.Fields.RiskRestructuringType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskRestructuringType val) { this.RiskRestructuringType = val; }

        public QuickFix.Fields.RiskRestructuringType Get(QuickFix.Fields.RiskRestructuringType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskRestructuringType val) { return IsSetRiskRestructuringType(); }

        public bool IsSetRiskRestructuringType() { return IsSetField(Tags.RiskRestructuringType); }

        public QuickFix.Fields.RiskSeniority RiskSeniority
        {
            get
            {
                var val = new QuickFix.Fields.RiskSeniority();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSeniority val) { this.RiskSeniority = val; }

        public QuickFix.Fields.RiskSeniority Get(QuickFix.Fields.RiskSeniority val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSeniority val) { return IsSetRiskSeniority(); }

        public bool IsSetRiskSeniority() { return IsSetField(Tags.RiskSeniority); }

        public QuickFix.Fields.RiskPutOrCall RiskPutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.RiskPutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskPutOrCall val) { this.RiskPutOrCall = val; }

        public QuickFix.Fields.RiskPutOrCall Get(QuickFix.Fields.RiskPutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskPutOrCall val) { return IsSetRiskPutOrCall(); }

        public bool IsSetRiskPutOrCall() { return IsSetField(Tags.RiskPutOrCall); }

        public QuickFix.Fields.RiskFlexibleIndicator RiskFlexibleIndicator
        {
            get
            {
                var val = new QuickFix.Fields.RiskFlexibleIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskFlexibleIndicator val) { this.RiskFlexibleIndicator = val; }

        public QuickFix.Fields.RiskFlexibleIndicator Get(QuickFix.Fields.RiskFlexibleIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskFlexibleIndicator val) { return IsSetRiskFlexibleIndicator(); }

        public bool IsSetRiskFlexibleIndicator() { return IsSetField(Tags.RiskFlexibleIndicator); }

        public QuickFix.Fields.RiskCouponRate RiskCouponRate
        {
            get
            {
                var val = new QuickFix.Fields.RiskCouponRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskCouponRate val) { this.RiskCouponRate = val; }

        public QuickFix.Fields.RiskCouponRate Get(QuickFix.Fields.RiskCouponRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskCouponRate val) { return IsSetRiskCouponRate(); }

        public bool IsSetRiskCouponRate() { return IsSetField(Tags.RiskCouponRate); }

        public QuickFix.Fields.RiskSecurityExchange RiskSecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecurityExchange val) { this.RiskSecurityExchange = val; }

        public QuickFix.Fields.RiskSecurityExchange Get(QuickFix.Fields.RiskSecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecurityExchange val) { return IsSetRiskSecurityExchange(); }

        public bool IsSetRiskSecurityExchange() { return IsSetField(Tags.RiskSecurityExchange); }

        public QuickFix.Fields.RiskSecurityDesc RiskSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecurityDesc val) { this.RiskSecurityDesc = val; }

        public QuickFix.Fields.RiskSecurityDesc Get(QuickFix.Fields.RiskSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecurityDesc val) { return IsSetRiskSecurityDesc(); }

        public bool IsSetRiskSecurityDesc() { return IsSetField(Tags.RiskSecurityDesc); }

        public QuickFix.Fields.RiskEncodedSecurityDescLen RiskEncodedSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.RiskEncodedSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskEncodedSecurityDescLen val) { this.RiskEncodedSecurityDescLen = val; }

        public QuickFix.Fields.RiskEncodedSecurityDescLen Get(QuickFix.Fields.RiskEncodedSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskEncodedSecurityDescLen val) { return IsSetRiskEncodedSecurityDescLen(); }

        public bool IsSetRiskEncodedSecurityDescLen() { return IsSetField(Tags.RiskEncodedSecurityDescLen); }

        public QuickFix.Fields.RiskEncodedSecurityDesc RiskEncodedSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.RiskEncodedSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskEncodedSecurityDesc val) { this.RiskEncodedSecurityDesc = val; }

        public QuickFix.Fields.RiskEncodedSecurityDesc Get(QuickFix.Fields.RiskEncodedSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskEncodedSecurityDesc val) { return IsSetRiskEncodedSecurityDesc(); }

        public bool IsSetRiskEncodedSecurityDesc() { return IsSetField(Tags.RiskEncodedSecurityDesc); }

        public QuickFix.Fields.RiskInstrumentSettlType RiskInstrumentSettlType
        {
            get
            {
                var val = new QuickFix.Fields.RiskInstrumentSettlType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskInstrumentSettlType val) { this.RiskInstrumentSettlType = val; }

        public QuickFix.Fields.RiskInstrumentSettlType Get(QuickFix.Fields.RiskInstrumentSettlType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskInstrumentSettlType val) { return IsSetRiskInstrumentSettlType(); }

        public bool IsSetRiskInstrumentSettlType() { return IsSetField(Tags.RiskInstrumentSettlType); }

        public QuickFix.Fields.RiskInstrumentMultiplier RiskInstrumentMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.RiskInstrumentMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskInstrumentMultiplier val) { this.RiskInstrumentMultiplier = val; }

        public QuickFix.Fields.RiskInstrumentMultiplier Get(QuickFix.Fields.RiskInstrumentMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskInstrumentMultiplier val) { return IsSetRiskInstrumentMultiplier(); }

        public bool IsSetRiskInstrumentMultiplier() { return IsSetField(Tags.RiskInstrumentMultiplier); }


        public class NoRiskSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.RiskSecurityAltID, Tags.RiskSecurityAltIDSource, 0};

            public NoRiskSecurityAltIDGroup() : base(Tags.NoRiskSecurityAltID, Tags.RiskSecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRiskSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RiskSecurityAltID RiskSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecurityAltID val) { this.RiskSecurityAltID = val; }

        public QuickFix.Fields.RiskSecurityAltID Get(QuickFix.Fields.RiskSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecurityAltID val) { return IsSetRiskSecurityAltID(); }

        public bool IsSetRiskSecurityAltID() { return IsSetField(Tags.RiskSecurityAltID); }

        public QuickFix.Fields.RiskSecurityAltIDSource RiskSecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RiskSecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskSecurityAltIDSource val) { this.RiskSecurityAltIDSource = val; }

        public QuickFix.Fields.RiskSecurityAltIDSource Get(QuickFix.Fields.RiskSecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskSecurityAltIDSource val) { return IsSetRiskSecurityAltIDSource(); }

        public bool IsSetRiskSecurityAltIDSource() { return IsSetField(Tags.RiskSecurityAltIDSource); }


        }
        }
        public class NoRiskWarningLevelsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RiskWarningLevelPercent, Tags.RiskWarningLevelName, 0};

            public NoRiskWarningLevelsGroup() : base(Tags.NoRiskWarningLevels, Tags.RiskWarningLevelPercent, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRiskWarningLevelsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RiskWarningLevelPercent RiskWarningLevelPercent
        {
            get
            {
                var val = new QuickFix.Fields.RiskWarningLevelPercent();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskWarningLevelPercent val) { this.RiskWarningLevelPercent = val; }

        public QuickFix.Fields.RiskWarningLevelPercent Get(QuickFix.Fields.RiskWarningLevelPercent val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskWarningLevelPercent val) { return IsSetRiskWarningLevelPercent(); }

        public bool IsSetRiskWarningLevelPercent() { return IsSetField(Tags.RiskWarningLevelPercent); }

        public QuickFix.Fields.RiskWarningLevelName RiskWarningLevelName
        {
            get
            {
                var val = new QuickFix.Fields.RiskWarningLevelName();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RiskWarningLevelName val) { this.RiskWarningLevelName = val; }

        public QuickFix.Fields.RiskWarningLevelName Get(QuickFix.Fields.RiskWarningLevelName val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RiskWarningLevelName val) { return IsSetRiskWarningLevelName(); }

        public bool IsSetRiskWarningLevelName() { return IsSetField(Tags.RiskWarningLevelName); }


        }
        }
        public class NoRelatedPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelatedPartyID, Tags.RelatedPartyIDSource, Tags.RelatedPartyRole, Tags.NoRelatedPartySubIDs, Tags.NoRelatedPartyAltIDs, Tags.NoRelatedContextPartyIDs, Tags.NoRelationshipRiskLimits, Tags.NoPartyRelationships, 0};

            public NoRelatedPartyIDsGroup() : base(Tags.NoRelatedPartyIDs, Tags.RelatedPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelatedPartyID RelatedPartyID
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartyID val) { this.RelatedPartyID = val; }

        public QuickFix.Fields.RelatedPartyID Get(QuickFix.Fields.RelatedPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartyID val) { return IsSetRelatedPartyID(); }

        public bool IsSetRelatedPartyID() { return IsSetField(Tags.RelatedPartyID); }

        public QuickFix.Fields.RelatedPartyIDSource RelatedPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartyIDSource val) { this.RelatedPartyIDSource = val; }

        public QuickFix.Fields.RelatedPartyIDSource Get(QuickFix.Fields.RelatedPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartyIDSource val) { return IsSetRelatedPartyIDSource(); }

        public bool IsSetRelatedPartyIDSource() { return IsSetField(Tags.RelatedPartyIDSource); }

        public QuickFix.Fields.RelatedPartyRole RelatedPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartyRole val) { this.RelatedPartyRole = val; }

        public QuickFix.Fields.RelatedPartyRole Get(QuickFix.Fields.RelatedPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartyRole val) { return IsSetRelatedPartyRole(); }

        public bool IsSetRelatedPartyRole() { return IsSetField(Tags.RelatedPartyRole); }

        public QuickFix.Fields.NoRelatedPartySubIDs NoRelatedPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRelatedPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelatedPartySubIDs val) { this.NoRelatedPartySubIDs = val; }

        public QuickFix.Fields.NoRelatedPartySubIDs Get(QuickFix.Fields.NoRelatedPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelatedPartySubIDs val) { return IsSetNoRelatedPartySubIDs(); }

        public bool IsSetNoRelatedPartySubIDs() { return IsSetField(Tags.NoRelatedPartySubIDs); }

        public QuickFix.Fields.NoRelatedPartyAltIDs NoRelatedPartyAltIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRelatedPartyAltIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelatedPartyAltIDs val) { this.NoRelatedPartyAltIDs = val; }

        public QuickFix.Fields.NoRelatedPartyAltIDs Get(QuickFix.Fields.NoRelatedPartyAltIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelatedPartyAltIDs val) { return IsSetNoRelatedPartyAltIDs(); }

        public bool IsSetNoRelatedPartyAltIDs() { return IsSetField(Tags.NoRelatedPartyAltIDs); }

        public QuickFix.Fields.NoRelatedContextPartyIDs NoRelatedContextPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRelatedContextPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelatedContextPartyIDs val) { this.NoRelatedContextPartyIDs = val; }

        public QuickFix.Fields.NoRelatedContextPartyIDs Get(QuickFix.Fields.NoRelatedContextPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelatedContextPartyIDs val) { return IsSetNoRelatedContextPartyIDs(); }

        public bool IsSetNoRelatedContextPartyIDs() { return IsSetField(Tags.NoRelatedContextPartyIDs); }

        public QuickFix.Fields.NoRelationshipRiskLimits NoRelationshipRiskLimits
        {
            get
            {
                var val = new QuickFix.Fields.NoRelationshipRiskLimits();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelationshipRiskLimits val) { this.NoRelationshipRiskLimits = val; }

        public QuickFix.Fields.NoRelationshipRiskLimits Get(QuickFix.Fields.NoRelationshipRiskLimits val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelationshipRiskLimits val) { return IsSetNoRelationshipRiskLimits(); }

        public bool IsSetNoRelationshipRiskLimits() { return IsSetField(Tags.NoRelationshipRiskLimits); }

        public QuickFix.Fields.NoPartyRelationships NoPartyRelationships
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyRelationships();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyRelationships val) { this.NoPartyRelationships = val; }

        public QuickFix.Fields.NoPartyRelationships Get(QuickFix.Fields.NoPartyRelationships val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyRelationships val) { return IsSetNoPartyRelationships(); }

        public bool IsSetNoPartyRelationships() { return IsSetField(Tags.NoPartyRelationships); }


        public class NoRelatedPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelatedPartySubID, Tags.RelatedPartySubIDType, 0};

            public NoRelatedPartySubIDsGroup() : base(Tags.NoRelatedPartySubIDs, Tags.RelatedPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelatedPartySubID RelatedPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartySubID val) { this.RelatedPartySubID = val; }

        public QuickFix.Fields.RelatedPartySubID Get(QuickFix.Fields.RelatedPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartySubID val) { return IsSetRelatedPartySubID(); }

        public bool IsSetRelatedPartySubID() { return IsSetField(Tags.RelatedPartySubID); }

        public QuickFix.Fields.RelatedPartySubIDType RelatedPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartySubIDType val) { this.RelatedPartySubIDType = val; }

        public QuickFix.Fields.RelatedPartySubIDType Get(QuickFix.Fields.RelatedPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartySubIDType val) { return IsSetRelatedPartySubIDType(); }

        public bool IsSetRelatedPartySubIDType() { return IsSetField(Tags.RelatedPartySubIDType); }


        }
        public class NoRelatedPartyAltIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelatedPartyAltID, Tags.RelatedPartyAltIDSource, Tags.NoRelatedPartyAltSubIDs, 0};

            public NoRelatedPartyAltIDsGroup() : base(Tags.NoRelatedPartyAltIDs, Tags.RelatedPartyAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedPartyAltIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelatedPartyAltID RelatedPartyAltID
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartyAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartyAltID val) { this.RelatedPartyAltID = val; }

        public QuickFix.Fields.RelatedPartyAltID Get(QuickFix.Fields.RelatedPartyAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartyAltID val) { return IsSetRelatedPartyAltID(); }

        public bool IsSetRelatedPartyAltID() { return IsSetField(Tags.RelatedPartyAltID); }

        public QuickFix.Fields.RelatedPartyAltIDSource RelatedPartyAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartyAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartyAltIDSource val) { this.RelatedPartyAltIDSource = val; }

        public QuickFix.Fields.RelatedPartyAltIDSource Get(QuickFix.Fields.RelatedPartyAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartyAltIDSource val) { return IsSetRelatedPartyAltIDSource(); }

        public bool IsSetRelatedPartyAltIDSource() { return IsSetField(Tags.RelatedPartyAltIDSource); }

        public QuickFix.Fields.NoRelatedPartyAltSubIDs NoRelatedPartyAltSubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRelatedPartyAltSubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelatedPartyAltSubIDs val) { this.NoRelatedPartyAltSubIDs = val; }

        public QuickFix.Fields.NoRelatedPartyAltSubIDs Get(QuickFix.Fields.NoRelatedPartyAltSubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelatedPartyAltSubIDs val) { return IsSetNoRelatedPartyAltSubIDs(); }

        public bool IsSetNoRelatedPartyAltSubIDs() { return IsSetField(Tags.NoRelatedPartyAltSubIDs); }


        public class NoRelatedPartyAltSubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelatedPartyAltSubID, Tags.RelatedPartyAltSubIDType, 0};

            public NoRelatedPartyAltSubIDsGroup() : base(Tags.NoRelatedPartyAltSubIDs, Tags.RelatedPartyAltSubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedPartyAltSubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelatedPartyAltSubID RelatedPartyAltSubID
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartyAltSubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartyAltSubID val) { this.RelatedPartyAltSubID = val; }

        public QuickFix.Fields.RelatedPartyAltSubID Get(QuickFix.Fields.RelatedPartyAltSubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartyAltSubID val) { return IsSetRelatedPartyAltSubID(); }

        public bool IsSetRelatedPartyAltSubID() { return IsSetField(Tags.RelatedPartyAltSubID); }

        public QuickFix.Fields.RelatedPartyAltSubIDType RelatedPartyAltSubIDType
        {
            get
            {
                var val = new QuickFix.Fields.RelatedPartyAltSubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedPartyAltSubIDType val) { this.RelatedPartyAltSubIDType = val; }

        public QuickFix.Fields.RelatedPartyAltSubIDType Get(QuickFix.Fields.RelatedPartyAltSubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedPartyAltSubIDType val) { return IsSetRelatedPartyAltSubIDType(); }

        public bool IsSetRelatedPartyAltSubIDType() { return IsSetField(Tags.RelatedPartyAltSubIDType); }


        }
        }
        public class NoRelatedContextPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelatedContextPartyID, Tags.RelatedContextPartyIDSource, Tags.RelatedContextPartyRole, Tags.NoRelatedContextPartySubIDs, 0};

            public NoRelatedContextPartyIDsGroup() : base(Tags.NoRelatedContextPartyIDs, Tags.RelatedContextPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedContextPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelatedContextPartyID RelatedContextPartyID
        {
            get
            {
                var val = new QuickFix.Fields.RelatedContextPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedContextPartyID val) { this.RelatedContextPartyID = val; }

        public QuickFix.Fields.RelatedContextPartyID Get(QuickFix.Fields.RelatedContextPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedContextPartyID val) { return IsSetRelatedContextPartyID(); }

        public bool IsSetRelatedContextPartyID() { return IsSetField(Tags.RelatedContextPartyID); }

        public QuickFix.Fields.RelatedContextPartyIDSource RelatedContextPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RelatedContextPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedContextPartyIDSource val) { this.RelatedContextPartyIDSource = val; }

        public QuickFix.Fields.RelatedContextPartyIDSource Get(QuickFix.Fields.RelatedContextPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedContextPartyIDSource val) { return IsSetRelatedContextPartyIDSource(); }

        public bool IsSetRelatedContextPartyIDSource() { return IsSetField(Tags.RelatedContextPartyIDSource); }

        public QuickFix.Fields.RelatedContextPartyRole RelatedContextPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.RelatedContextPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedContextPartyRole val) { this.RelatedContextPartyRole = val; }

        public QuickFix.Fields.RelatedContextPartyRole Get(QuickFix.Fields.RelatedContextPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedContextPartyRole val) { return IsSetRelatedContextPartyRole(); }

        public bool IsSetRelatedContextPartyRole() { return IsSetField(Tags.RelatedContextPartyRole); }

        public QuickFix.Fields.NoRelatedContextPartySubIDs NoRelatedContextPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoRelatedContextPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelatedContextPartySubIDs val) { this.NoRelatedContextPartySubIDs = val; }

        public QuickFix.Fields.NoRelatedContextPartySubIDs Get(QuickFix.Fields.NoRelatedContextPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelatedContextPartySubIDs val) { return IsSetNoRelatedContextPartySubIDs(); }

        public bool IsSetNoRelatedContextPartySubIDs() { return IsSetField(Tags.NoRelatedContextPartySubIDs); }


        public class NoRelatedContextPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelatedContextPartySubID, Tags.RelatedContextPartySubIDType, 0};

            public NoRelatedContextPartySubIDsGroup() : base(Tags.NoRelatedContextPartySubIDs, Tags.RelatedContextPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedContextPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelatedContextPartySubID RelatedContextPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.RelatedContextPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedContextPartySubID val) { this.RelatedContextPartySubID = val; }

        public QuickFix.Fields.RelatedContextPartySubID Get(QuickFix.Fields.RelatedContextPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedContextPartySubID val) { return IsSetRelatedContextPartySubID(); }

        public bool IsSetRelatedContextPartySubID() { return IsSetField(Tags.RelatedContextPartySubID); }

        public QuickFix.Fields.RelatedContextPartySubIDType RelatedContextPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.RelatedContextPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatedContextPartySubIDType val) { this.RelatedContextPartySubIDType = val; }

        public QuickFix.Fields.RelatedContextPartySubIDType Get(QuickFix.Fields.RelatedContextPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatedContextPartySubIDType val) { return IsSetRelatedContextPartySubIDType(); }

        public bool IsSetRelatedContextPartySubIDType() { return IsSetField(Tags.RelatedContextPartySubIDType); }


        }
        }
        public class NoRelationshipRiskLimitsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelationshipRiskLimitType, Tags.RelationshipRiskLimitAmount, Tags.RelationshipRiskLimitCurrency, Tags.RelationshipRiskLimitPlatform, Tags.NoRelationshipRiskInstruments, Tags.NoRelationshipRiskWarningLevels, 0};

            public NoRelationshipRiskLimitsGroup() : base(Tags.NoRelationshipRiskLimits, Tags.RelationshipRiskLimitType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelationshipRiskLimitsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelationshipRiskLimitType RelationshipRiskLimitType
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskLimitType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskLimitType val) { this.RelationshipRiskLimitType = val; }

        public QuickFix.Fields.RelationshipRiskLimitType Get(QuickFix.Fields.RelationshipRiskLimitType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitType val) { return IsSetRelationshipRiskLimitType(); }

        public bool IsSetRelationshipRiskLimitType() { return IsSetField(Tags.RelationshipRiskLimitType); }

        public QuickFix.Fields.RelationshipRiskLimitAmount RelationshipRiskLimitAmount
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskLimitAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskLimitAmount val) { this.RelationshipRiskLimitAmount = val; }

        public QuickFix.Fields.RelationshipRiskLimitAmount Get(QuickFix.Fields.RelationshipRiskLimitAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitAmount val) { return IsSetRelationshipRiskLimitAmount(); }

        public bool IsSetRelationshipRiskLimitAmount() { return IsSetField(Tags.RelationshipRiskLimitAmount); }

        public QuickFix.Fields.RelationshipRiskLimitCurrency RelationshipRiskLimitCurrency
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskLimitCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskLimitCurrency val) { this.RelationshipRiskLimitCurrency = val; }

        public QuickFix.Fields.RelationshipRiskLimitCurrency Get(QuickFix.Fields.RelationshipRiskLimitCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitCurrency val) { return IsSetRelationshipRiskLimitCurrency(); }

        public bool IsSetRelationshipRiskLimitCurrency() { return IsSetField(Tags.RelationshipRiskLimitCurrency); }

        public QuickFix.Fields.RelationshipRiskLimitPlatform RelationshipRiskLimitPlatform
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskLimitPlatform();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskLimitPlatform val) { this.RelationshipRiskLimitPlatform = val; }

        public QuickFix.Fields.RelationshipRiskLimitPlatform Get(QuickFix.Fields.RelationshipRiskLimitPlatform val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitPlatform val) { return IsSetRelationshipRiskLimitPlatform(); }

        public bool IsSetRelationshipRiskLimitPlatform() { return IsSetField(Tags.RelationshipRiskLimitPlatform); }

        public QuickFix.Fields.NoRelationshipRiskInstruments NoRelationshipRiskInstruments
        {
            get
            {
                var val = new QuickFix.Fields.NoRelationshipRiskInstruments();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelationshipRiskInstruments val) { this.NoRelationshipRiskInstruments = val; }

        public QuickFix.Fields.NoRelationshipRiskInstruments Get(QuickFix.Fields.NoRelationshipRiskInstruments val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelationshipRiskInstruments val) { return IsSetNoRelationshipRiskInstruments(); }

        public bool IsSetNoRelationshipRiskInstruments() { return IsSetField(Tags.NoRelationshipRiskInstruments); }

        public QuickFix.Fields.NoRelationshipRiskWarningLevels NoRelationshipRiskWarningLevels
        {
            get
            {
                var val = new QuickFix.Fields.NoRelationshipRiskWarningLevels();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelationshipRiskWarningLevels val) { this.NoRelationshipRiskWarningLevels = val; }

        public QuickFix.Fields.NoRelationshipRiskWarningLevels Get(QuickFix.Fields.NoRelationshipRiskWarningLevels val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelationshipRiskWarningLevels val) { return IsSetNoRelationshipRiskWarningLevels(); }

        public bool IsSetNoRelationshipRiskWarningLevels() { return IsSetField(Tags.NoRelationshipRiskWarningLevels); }


        public class NoRelationshipRiskInstrumentsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelationshipRiskInstrumentOperator, Tags.RelationshipRiskSymbol, Tags.RelationshipRiskSymbolSfx, Tags.RelationshipRiskSecurityID, Tags.RelationshipRiskSecurityIDSource, Tags.NoRelationshipRiskSecurityAltID, Tags.RelationshipRiskProduct, Tags.RelationshipRiskProductComplex, Tags.RelationshipRiskSecurityGroup, Tags.RelationshipRiskCFICode, Tags.RelationshipRiskSecurityType, Tags.RelationshipRiskSecuritySubType, Tags.RelationshipRiskMaturityMonthYear, Tags.RelationshipRiskMaturityTime, Tags.RelationshipRiskRestructuringType, Tags.RelationshipRiskSeniority, Tags.RelationshipRiskPutOrCall, Tags.RelationshipRiskFlexibleIndicator, Tags.RelationshipRiskCouponRate, Tags.RelationshipRiskSecurityExchange, Tags.RelationshipRiskSecurityDesc, Tags.RelationshipRiskEncodedSecurityDescLen, Tags.RelationshipRiskEncodedSecurityDesc, Tags.RelationshipRiskInstrumentSettlType, Tags.RelationshipRiskInstrumentMultiplier, 0};

            public NoRelationshipRiskInstrumentsGroup() : base(Tags.NoRelationshipRiskInstruments, Tags.RelationshipRiskInstrumentOperator, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelationshipRiskInstrumentsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelationshipRiskInstrumentOperator RelationshipRiskInstrumentOperator
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskInstrumentOperator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskInstrumentOperator val) { this.RelationshipRiskInstrumentOperator = val; }

        public QuickFix.Fields.RelationshipRiskInstrumentOperator Get(QuickFix.Fields.RelationshipRiskInstrumentOperator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentOperator val) { return IsSetRelationshipRiskInstrumentOperator(); }

        public bool IsSetRelationshipRiskInstrumentOperator() { return IsSetField(Tags.RelationshipRiskInstrumentOperator); }

        public QuickFix.Fields.RelationshipRiskSymbol RelationshipRiskSymbol
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSymbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSymbol val) { this.RelationshipRiskSymbol = val; }

        public QuickFix.Fields.RelationshipRiskSymbol Get(QuickFix.Fields.RelationshipRiskSymbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSymbol val) { return IsSetRelationshipRiskSymbol(); }

        public bool IsSetRelationshipRiskSymbol() { return IsSetField(Tags.RelationshipRiskSymbol); }

        public QuickFix.Fields.RelationshipRiskSymbolSfx RelationshipRiskSymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSymbolSfx val) { this.RelationshipRiskSymbolSfx = val; }

        public QuickFix.Fields.RelationshipRiskSymbolSfx Get(QuickFix.Fields.RelationshipRiskSymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSymbolSfx val) { return IsSetRelationshipRiskSymbolSfx(); }

        public bool IsSetRelationshipRiskSymbolSfx() { return IsSetField(Tags.RelationshipRiskSymbolSfx); }

        public QuickFix.Fields.RelationshipRiskSecurityID RelationshipRiskSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecurityID val) { this.RelationshipRiskSecurityID = val; }

        public QuickFix.Fields.RelationshipRiskSecurityID Get(QuickFix.Fields.RelationshipRiskSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityID val) { return IsSetRelationshipRiskSecurityID(); }

        public bool IsSetRelationshipRiskSecurityID() { return IsSetField(Tags.RelationshipRiskSecurityID); }

        public QuickFix.Fields.RelationshipRiskSecurityIDSource RelationshipRiskSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecurityIDSource val) { this.RelationshipRiskSecurityIDSource = val; }

        public QuickFix.Fields.RelationshipRiskSecurityIDSource Get(QuickFix.Fields.RelationshipRiskSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityIDSource val) { return IsSetRelationshipRiskSecurityIDSource(); }

        public bool IsSetRelationshipRiskSecurityIDSource() { return IsSetField(Tags.RelationshipRiskSecurityIDSource); }

        public QuickFix.Fields.NoRelationshipRiskSecurityAltID NoRelationshipRiskSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoRelationshipRiskSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) { this.NoRelationshipRiskSecurityAltID = val; }

        public QuickFix.Fields.NoRelationshipRiskSecurityAltID Get(QuickFix.Fields.NoRelationshipRiskSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) { return IsSetNoRelationshipRiskSecurityAltID(); }

        public bool IsSetNoRelationshipRiskSecurityAltID() { return IsSetField(Tags.NoRelationshipRiskSecurityAltID); }

        public QuickFix.Fields.RelationshipRiskProduct RelationshipRiskProduct
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskProduct();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskProduct val) { this.RelationshipRiskProduct = val; }

        public QuickFix.Fields.RelationshipRiskProduct Get(QuickFix.Fields.RelationshipRiskProduct val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskProduct val) { return IsSetRelationshipRiskProduct(); }

        public bool IsSetRelationshipRiskProduct() { return IsSetField(Tags.RelationshipRiskProduct); }

        public QuickFix.Fields.RelationshipRiskProductComplex RelationshipRiskProductComplex
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskProductComplex();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskProductComplex val) { this.RelationshipRiskProductComplex = val; }

        public QuickFix.Fields.RelationshipRiskProductComplex Get(QuickFix.Fields.RelationshipRiskProductComplex val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskProductComplex val) { return IsSetRelationshipRiskProductComplex(); }

        public bool IsSetRelationshipRiskProductComplex() { return IsSetField(Tags.RelationshipRiskProductComplex); }

        public QuickFix.Fields.RelationshipRiskSecurityGroup RelationshipRiskSecurityGroup
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecurityGroup();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecurityGroup val) { this.RelationshipRiskSecurityGroup = val; }

        public QuickFix.Fields.RelationshipRiskSecurityGroup Get(QuickFix.Fields.RelationshipRiskSecurityGroup val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityGroup val) { return IsSetRelationshipRiskSecurityGroup(); }

        public bool IsSetRelationshipRiskSecurityGroup() { return IsSetField(Tags.RelationshipRiskSecurityGroup); }

        public QuickFix.Fields.RelationshipRiskCFICode RelationshipRiskCFICode
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskCFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskCFICode val) { this.RelationshipRiskCFICode = val; }

        public QuickFix.Fields.RelationshipRiskCFICode Get(QuickFix.Fields.RelationshipRiskCFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskCFICode val) { return IsSetRelationshipRiskCFICode(); }

        public bool IsSetRelationshipRiskCFICode() { return IsSetField(Tags.RelationshipRiskCFICode); }

        public QuickFix.Fields.RelationshipRiskSecurityType RelationshipRiskSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecurityType val) { this.RelationshipRiskSecurityType = val; }

        public QuickFix.Fields.RelationshipRiskSecurityType Get(QuickFix.Fields.RelationshipRiskSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityType val) { return IsSetRelationshipRiskSecurityType(); }

        public bool IsSetRelationshipRiskSecurityType() { return IsSetField(Tags.RelationshipRiskSecurityType); }

        public QuickFix.Fields.RelationshipRiskSecuritySubType RelationshipRiskSecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecuritySubType val) { this.RelationshipRiskSecuritySubType = val; }

        public QuickFix.Fields.RelationshipRiskSecuritySubType Get(QuickFix.Fields.RelationshipRiskSecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecuritySubType val) { return IsSetRelationshipRiskSecuritySubType(); }

        public bool IsSetRelationshipRiskSecuritySubType() { return IsSetField(Tags.RelationshipRiskSecuritySubType); }

        public QuickFix.Fields.RelationshipRiskMaturityMonthYear RelationshipRiskMaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskMaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) { this.RelationshipRiskMaturityMonthYear = val; }

        public QuickFix.Fields.RelationshipRiskMaturityMonthYear Get(QuickFix.Fields.RelationshipRiskMaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) { return IsSetRelationshipRiskMaturityMonthYear(); }

        public bool IsSetRelationshipRiskMaturityMonthYear() { return IsSetField(Tags.RelationshipRiskMaturityMonthYear); }

        public QuickFix.Fields.RelationshipRiskMaturityTime RelationshipRiskMaturityTime
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskMaturityTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskMaturityTime val) { this.RelationshipRiskMaturityTime = val; }

        public QuickFix.Fields.RelationshipRiskMaturityTime Get(QuickFix.Fields.RelationshipRiskMaturityTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskMaturityTime val) { return IsSetRelationshipRiskMaturityTime(); }

        public bool IsSetRelationshipRiskMaturityTime() { return IsSetField(Tags.RelationshipRiskMaturityTime); }

        public QuickFix.Fields.RelationshipRiskRestructuringType RelationshipRiskRestructuringType
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskRestructuringType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskRestructuringType val) { this.RelationshipRiskRestructuringType = val; }

        public QuickFix.Fields.RelationshipRiskRestructuringType Get(QuickFix.Fields.RelationshipRiskRestructuringType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskRestructuringType val) { return IsSetRelationshipRiskRestructuringType(); }

        public bool IsSetRelationshipRiskRestructuringType() { return IsSetField(Tags.RelationshipRiskRestructuringType); }

        public QuickFix.Fields.RelationshipRiskSeniority RelationshipRiskSeniority
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSeniority();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSeniority val) { this.RelationshipRiskSeniority = val; }

        public QuickFix.Fields.RelationshipRiskSeniority Get(QuickFix.Fields.RelationshipRiskSeniority val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSeniority val) { return IsSetRelationshipRiskSeniority(); }

        public bool IsSetRelationshipRiskSeniority() { return IsSetField(Tags.RelationshipRiskSeniority); }

        public QuickFix.Fields.RelationshipRiskPutOrCall RelationshipRiskPutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskPutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskPutOrCall val) { this.RelationshipRiskPutOrCall = val; }

        public QuickFix.Fields.RelationshipRiskPutOrCall Get(QuickFix.Fields.RelationshipRiskPutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskPutOrCall val) { return IsSetRelationshipRiskPutOrCall(); }

        public bool IsSetRelationshipRiskPutOrCall() { return IsSetField(Tags.RelationshipRiskPutOrCall); }

        public QuickFix.Fields.RelationshipRiskFlexibleIndicator RelationshipRiskFlexibleIndicator
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskFlexibleIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) { this.RelationshipRiskFlexibleIndicator = val; }

        public QuickFix.Fields.RelationshipRiskFlexibleIndicator Get(QuickFix.Fields.RelationshipRiskFlexibleIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) { return IsSetRelationshipRiskFlexibleIndicator(); }

        public bool IsSetRelationshipRiskFlexibleIndicator() { return IsSetField(Tags.RelationshipRiskFlexibleIndicator); }

        public QuickFix.Fields.RelationshipRiskCouponRate RelationshipRiskCouponRate
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskCouponRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskCouponRate val) { this.RelationshipRiskCouponRate = val; }

        public QuickFix.Fields.RelationshipRiskCouponRate Get(QuickFix.Fields.RelationshipRiskCouponRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskCouponRate val) { return IsSetRelationshipRiskCouponRate(); }

        public bool IsSetRelationshipRiskCouponRate() { return IsSetField(Tags.RelationshipRiskCouponRate); }

        public QuickFix.Fields.RelationshipRiskSecurityExchange RelationshipRiskSecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecurityExchange val) { this.RelationshipRiskSecurityExchange = val; }

        public QuickFix.Fields.RelationshipRiskSecurityExchange Get(QuickFix.Fields.RelationshipRiskSecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityExchange val) { return IsSetRelationshipRiskSecurityExchange(); }

        public bool IsSetRelationshipRiskSecurityExchange() { return IsSetField(Tags.RelationshipRiskSecurityExchange); }

        public QuickFix.Fields.RelationshipRiskSecurityDesc RelationshipRiskSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecurityDesc val) { this.RelationshipRiskSecurityDesc = val; }

        public QuickFix.Fields.RelationshipRiskSecurityDesc Get(QuickFix.Fields.RelationshipRiskSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityDesc val) { return IsSetRelationshipRiskSecurityDesc(); }

        public bool IsSetRelationshipRiskSecurityDesc() { return IsSetField(Tags.RelationshipRiskSecurityDesc); }

        public QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen RelationshipRiskEncodedSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) { this.RelationshipRiskEncodedSecurityDescLen = val; }

        public QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen Get(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) { return IsSetRelationshipRiskEncodedSecurityDescLen(); }

        public bool IsSetRelationshipRiskEncodedSecurityDescLen() { return IsSetField(Tags.RelationshipRiskEncodedSecurityDescLen); }

        public QuickFix.Fields.RelationshipRiskEncodedSecurityDesc RelationshipRiskEncodedSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskEncodedSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) { this.RelationshipRiskEncodedSecurityDesc = val; }

        public QuickFix.Fields.RelationshipRiskEncodedSecurityDesc Get(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) { return IsSetRelationshipRiskEncodedSecurityDesc(); }

        public bool IsSetRelationshipRiskEncodedSecurityDesc() { return IsSetField(Tags.RelationshipRiskEncodedSecurityDesc); }

        public QuickFix.Fields.RelationshipRiskInstrumentSettlType RelationshipRiskInstrumentSettlType
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskInstrumentSettlType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) { this.RelationshipRiskInstrumentSettlType = val; }

        public QuickFix.Fields.RelationshipRiskInstrumentSettlType Get(QuickFix.Fields.RelationshipRiskInstrumentSettlType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) { return IsSetRelationshipRiskInstrumentSettlType(); }

        public bool IsSetRelationshipRiskInstrumentSettlType() { return IsSetField(Tags.RelationshipRiskInstrumentSettlType); }

        public QuickFix.Fields.RelationshipRiskInstrumentMultiplier RelationshipRiskInstrumentMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskInstrumentMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) { this.RelationshipRiskInstrumentMultiplier = val; }

        public QuickFix.Fields.RelationshipRiskInstrumentMultiplier Get(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) { return IsSetRelationshipRiskInstrumentMultiplier(); }

        public bool IsSetRelationshipRiskInstrumentMultiplier() { return IsSetField(Tags.RelationshipRiskInstrumentMultiplier); }


        public class NoRelationshipRiskSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelationshipRiskSecurityAltID, Tags.RelationshipRiskSecurityAltIDSource, 0};

            public NoRelationshipRiskSecurityAltIDGroup() : base(Tags.NoRelationshipRiskSecurityAltID, Tags.RelationshipRiskSecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelationshipRiskSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelationshipRiskSecurityAltID RelationshipRiskSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecurityAltID val) { this.RelationshipRiskSecurityAltID = val; }

        public QuickFix.Fields.RelationshipRiskSecurityAltID Get(QuickFix.Fields.RelationshipRiskSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityAltID val) { return IsSetRelationshipRiskSecurityAltID(); }

        public bool IsSetRelationshipRiskSecurityAltID() { return IsSetField(Tags.RelationshipRiskSecurityAltID); }

        public QuickFix.Fields.RelationshipRiskSecurityAltIDSource RelationshipRiskSecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskSecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) { this.RelationshipRiskSecurityAltIDSource = val; }

        public QuickFix.Fields.RelationshipRiskSecurityAltIDSource Get(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) { return IsSetRelationshipRiskSecurityAltIDSource(); }

        public bool IsSetRelationshipRiskSecurityAltIDSource() { return IsSetField(Tags.RelationshipRiskSecurityAltIDSource); }


        }
        }
        public class NoRelationshipRiskWarningLevelsGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelationshipRiskWarningLevelPercent, Tags.RelationshipRiskWarningLevelName, 0};

            public NoRelationshipRiskWarningLevelsGroup() : base(Tags.NoRelationshipRiskWarningLevels, Tags.RelationshipRiskWarningLevelPercent, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelationshipRiskWarningLevelsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelationshipRiskWarningLevelPercent RelationshipRiskWarningLevelPercent
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskWarningLevelPercent();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) { this.RelationshipRiskWarningLevelPercent = val; }

        public QuickFix.Fields.RelationshipRiskWarningLevelPercent Get(QuickFix.Fields.RelationshipRiskWarningLevelPercent val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) { return IsSetRelationshipRiskWarningLevelPercent(); }

        public bool IsSetRelationshipRiskWarningLevelPercent() { return IsSetField(Tags.RelationshipRiskWarningLevelPercent); }

        public QuickFix.Fields.RelationshipRiskWarningLevelName RelationshipRiskWarningLevelName
        {
            get
            {
                var val = new QuickFix.Fields.RelationshipRiskWarningLevelName();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelationshipRiskWarningLevelName val) { this.RelationshipRiskWarningLevelName = val; }

        public QuickFix.Fields.RelationshipRiskWarningLevelName Get(QuickFix.Fields.RelationshipRiskWarningLevelName val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelationshipRiskWarningLevelName val) { return IsSetRelationshipRiskWarningLevelName(); }

        public bool IsSetRelationshipRiskWarningLevelName() { return IsSetField(Tags.RelationshipRiskWarningLevelName); }


        }
        }
        public class NoPartyRelationshipsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyRelationship, 0};

            public NoPartyRelationshipsGroup() : base(Tags.NoPartyRelationships, Tags.PartyRelationship, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyRelationshipsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyRelationship PartyRelationship
        {
            get
            {
                var val = new QuickFix.Fields.PartyRelationship();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyRelationship val) { this.PartyRelationship = val; }

        public QuickFix.Fields.PartyRelationship Get(QuickFix.Fields.PartyRelationship val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyRelationship val) { return IsSetPartyRelationship(); }

        public bool IsSetPartyRelationship() { return IsSetField(Tags.PartyRelationship); }


        }
        }
        }


    }
}


