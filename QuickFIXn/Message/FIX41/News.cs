using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class News : Message
    {
        public const string MsgType = "B";

        public News():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public News(QuickFix.Fields.Headline aHeadline)
               : this()
        {
            this.Headline = aHeadline;
        }

        public QuickFix.Fields.OrigTime OrigTime
        {
            get
            {
                var val = new QuickFix.Fields.OrigTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigTime val) { this.OrigTime = val; }

        public QuickFix.Fields.OrigTime Get(QuickFix.Fields.OrigTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigTime val) { return IsSetOrigTime(); }

        public bool IsSetOrigTime() { return IsSetField(Tags.OrigTime); }

        public QuickFix.Fields.Urgency Urgency
        {
            get
            {
                var val = new QuickFix.Fields.Urgency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Urgency val) { this.Urgency = val; }

        public QuickFix.Fields.Urgency Get(QuickFix.Fields.Urgency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Urgency val) { return IsSetUrgency(); }

        public bool IsSetUrgency() { return IsSetField(Tags.Urgency); }

        public QuickFix.Fields.Headline Headline
        {
            get
            {
                var val = new QuickFix.Fields.Headline();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Headline val) { this.Headline = val; }

        public QuickFix.Fields.Headline Get(QuickFix.Fields.Headline val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Headline val) { return IsSetHeadline(); }

        public bool IsSetHeadline() { return IsSetField(Tags.Headline); }

        public QuickFix.Fields.NoRelatedSym NoRelatedSym
        {
            get
            {
                var val = new QuickFix.Fields.NoRelatedSym();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelatedSym val) { this.NoRelatedSym = val; }

        public QuickFix.Fields.NoRelatedSym Get(QuickFix.Fields.NoRelatedSym val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelatedSym val) { return IsSetNoRelatedSym(); }

        public bool IsSetNoRelatedSym() { return IsSetField(Tags.NoRelatedSym); }

        public QuickFix.Fields.LinesOfText LinesOfText
        {
            get
            {
                var val = new QuickFix.Fields.LinesOfText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LinesOfText val) { this.LinesOfText = val; }

        public QuickFix.Fields.LinesOfText Get(QuickFix.Fields.LinesOfText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LinesOfText val) { return IsSetLinesOfText(); }

        public bool IsSetLinesOfText() { return IsSetField(Tags.LinesOfText); }

        public QuickFix.Fields.URLLink URLLink
        {
            get
            {
                var val = new QuickFix.Fields.URLLink();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.URLLink val) { this.URLLink = val; }

        public QuickFix.Fields.URLLink Get(QuickFix.Fields.URLLink val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.URLLink val) { return IsSetURLLink(); }

        public bool IsSetURLLink() { return IsSetField(Tags.URLLink); }

        public QuickFix.Fields.RawDataLength RawDataLength
        {
            get
            {
                var val = new QuickFix.Fields.RawDataLength();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RawDataLength val) { this.RawDataLength = val; }

        public QuickFix.Fields.RawDataLength Get(QuickFix.Fields.RawDataLength val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RawDataLength val) { return IsSetRawDataLength(); }

        public bool IsSetRawDataLength() { return IsSetField(Tags.RawDataLength); }

        public QuickFix.Fields.RawData RawData
        {
            get
            {
                var val = new QuickFix.Fields.RawData();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RawData val) { this.RawData = val; }

        public QuickFix.Fields.RawData Get(QuickFix.Fields.RawData val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RawData val) { return IsSetRawData(); }

        public bool IsSetRawData() { return IsSetField(Tags.RawData); }


        public class NoRelatedSymGroup : Group
        {
            public static int[] fieldOrder = {Tags.RelatdSym, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.SecurityExchange, Tags.Issuer, Tags.SecurityDesc, 0};

            public NoRelatedSymGroup() : base(Tags.NoRelatedSym, Tags.RelatdSym, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedSymGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RelatdSym RelatdSym
        {
            get
            {
                var val = new QuickFix.Fields.RelatdSym();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatdSym val) { this.RelatdSym = val; }

        public QuickFix.Fields.RelatdSym Get(QuickFix.Fields.RelatdSym val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatdSym val) { return IsSetRelatdSym(); }

        public bool IsSetRelatdSym() { return IsSetField(Tags.RelatdSym); }

        public QuickFix.Fields.SymbolSfx SymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.SymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SymbolSfx val) { this.SymbolSfx = val; }

        public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SymbolSfx val) { return IsSetSymbolSfx(); }

        public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

        public QuickFix.Fields.SecurityID SecurityID
        {
            get
            {
                var val = new QuickFix.Fields.SecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityID val) { this.SecurityID = val; }

        public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityID val) { return IsSetSecurityID(); }

        public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

        public QuickFix.Fields.IDSource IDSource
        {
            get
            {
                var val = new QuickFix.Fields.IDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IDSource val) { this.IDSource = val; }

        public QuickFix.Fields.IDSource Get(QuickFix.Fields.IDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IDSource val) { return IsSetIDSource(); }

        public bool IsSetIDSource() { return IsSetField(Tags.IDSource); }

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

        public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.MaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaturityMonthYear val) { this.MaturityMonthYear = val; }

        public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaturityMonthYear val) { return IsSetMaturityMonthYear(); }

        public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

        public QuickFix.Fields.MaturityDay MaturityDay
        {
            get
            {
                var val = new QuickFix.Fields.MaturityDay();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaturityDay val) { this.MaturityDay = val; }

        public QuickFix.Fields.MaturityDay Get(QuickFix.Fields.MaturityDay val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaturityDay val) { return IsSetMaturityDay(); }

        public bool IsSetMaturityDay() { return IsSetField(Tags.MaturityDay); }

        public QuickFix.Fields.PutOrCall PutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.PutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PutOrCall val) { this.PutOrCall = val; }

        public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PutOrCall val) { return IsSetPutOrCall(); }

        public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }

        public QuickFix.Fields.StrikePrice StrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.StrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikePrice val) { this.StrikePrice = val; }

        public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikePrice val) { return IsSetStrikePrice(); }

        public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

        public QuickFix.Fields.OptAttribute OptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.OptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OptAttribute val) { this.OptAttribute = val; }

        public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OptAttribute val) { return IsSetOptAttribute(); }

        public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

        public QuickFix.Fields.SecurityExchange SecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.SecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityExchange val) { this.SecurityExchange = val; }

        public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityExchange val) { return IsSetSecurityExchange(); }

        public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

        public QuickFix.Fields.Issuer Issuer
        {
            get
            {
                var val = new QuickFix.Fields.Issuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Issuer val) { this.Issuer = val; }

        public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Issuer val) { return IsSetIssuer(); }

        public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

        public QuickFix.Fields.SecurityDesc SecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.SecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityDesc val) { this.SecurityDesc = val; }

        public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityDesc val) { return IsSetSecurityDesc(); }

        public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }


        }


        public class LinesOfTextGroup : Group
        {
            public static int[] fieldOrder = {Tags.Text, 0};

            public LinesOfTextGroup() : base(Tags.LinesOfText, Tags.Text, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new LinesOfTextGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
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


        }


    }
}
