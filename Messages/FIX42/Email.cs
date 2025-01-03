// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class Email : Message
{
    public const string MsgType = "C";

    public Email() : base()
    {
        Header.SetField(new MsgType("C"));
    }

    public Email(
            EmailThreadID aEmailThreadID,
            EmailType aEmailType,
            Subject aSubject
        ) : this()
    {
        EmailThreadID = aEmailThreadID;
        EmailType = aEmailType;
        Subject = aSubject;
    }

    public EmailThreadID EmailThreadID
    {
        get
        {
            EmailThreadID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EmailThreadID val) { EmailThreadID = val; }
    public EmailThreadID Get(EmailThreadID val) { GetField(val); return val; }
    public bool IsSet(EmailThreadID val) { return IsSetEmailThreadID(); }
    public bool IsSetEmailThreadID() { return IsSetField(Tags.EmailThreadID); }

    public EmailType EmailType
    {
        get
        {
            EmailType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EmailType val) { EmailType = val; }
    public EmailType Get(EmailType val) { GetField(val); return val; }
    public bool IsSet(EmailType val) { return IsSetEmailType(); }
    public bool IsSetEmailType() { return IsSetField(Tags.EmailType); }

    public OrigTime OrigTime
    {
        get
        {
            OrigTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigTime val) { OrigTime = val; }
    public OrigTime Get(OrigTime val) { GetField(val); return val; }
    public bool IsSet(OrigTime val) { return IsSetOrigTime(); }
    public bool IsSetOrigTime() { return IsSetField(Tags.OrigTime); }

    public Subject Subject
    {
        get
        {
            Subject val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Subject val) { Subject = val; }
    public Subject Get(Subject val) { GetField(val); return val; }
    public bool IsSet(Subject val) { return IsSetSubject(); }
    public bool IsSetSubject() { return IsSetField(Tags.Subject); }

    public EncodedSubjectLen EncodedSubjectLen
    {
        get
        {
            EncodedSubjectLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedSubjectLen val) { EncodedSubjectLen = val; }
    public EncodedSubjectLen Get(EncodedSubjectLen val) { GetField(val); return val; }
    public bool IsSet(EncodedSubjectLen val) { return IsSetEncodedSubjectLen(); }
    public bool IsSetEncodedSubjectLen() { return IsSetField(Tags.EncodedSubjectLen); }

    public EncodedSubject EncodedSubject
    {
        get
        {
            EncodedSubject val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedSubject val) { EncodedSubject = val; }
    public EncodedSubject Get(EncodedSubject val) { GetField(val); return val; }
    public bool IsSet(EncodedSubject val) { return IsSetEncodedSubject(); }
    public bool IsSetEncodedSubject() { return IsSetField(Tags.EncodedSubject); }

    public NoRoutingIDs NoRoutingIDs
    {
        get
        {
            NoRoutingIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRoutingIDs val) { NoRoutingIDs = val; }
    public NoRoutingIDs Get(NoRoutingIDs val) { GetField(val); return val; }
    public bool IsSet(NoRoutingIDs val) { return IsSetNoRoutingIDs(); }
    public bool IsSetNoRoutingIDs() { return IsSetField(Tags.NoRoutingIDs); }

    public NoRelatedSym NoRelatedSym
    {
        get
        {
            NoRelatedSym val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRelatedSym val) { NoRelatedSym = val; }
    public NoRelatedSym Get(NoRelatedSym val) { GetField(val); return val; }
    public bool IsSet(NoRelatedSym val) { return IsSetNoRelatedSym(); }
    public bool IsSetNoRelatedSym() { return IsSetField(Tags.NoRelatedSym); }

    public OrderID OrderID
    {
        get
        {
            OrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderID val) { OrderID = val; }
    public OrderID Get(OrderID val) { GetField(val); return val; }
    public bool IsSet(OrderID val) { return IsSetOrderID(); }
    public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

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

    public LinesOfText LinesOfText
    {
        get
        {
            LinesOfText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LinesOfText val) { LinesOfText = val; }
    public LinesOfText Get(LinesOfText val) { GetField(val); return val; }
    public bool IsSet(LinesOfText val) { return IsSetLinesOfText(); }
    public bool IsSetLinesOfText() { return IsSetField(Tags.LinesOfText); }

    public RawDataLength RawDataLength
    {
        get
        {
            RawDataLength val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RawDataLength val) { RawDataLength = val; }
    public RawDataLength Get(RawDataLength val) { GetField(val); return val; }
    public bool IsSet(RawDataLength val) { return IsSetRawDataLength(); }
    public bool IsSetRawDataLength() { return IsSetField(Tags.RawDataLength); }

    public RawData RawData
    {
        get
        {
            RawData val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RawData val) { RawData = val; }
    public RawData Get(RawData val) { GetField(val); return val; }
    public bool IsSet(RawData val) { return IsSetRawData(); }
    public bool IsSetRawData() { return IsSetField(Tags.RawData); }

    public class NoRoutingIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RoutingType, Tags.RoutingID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RoutingType, Tags.RoutingID, 0};

        public NoRoutingIDsGroup()
          : base(Tags.NoRoutingIDs, Tags.RoutingType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRoutingIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RoutingType RoutingType
        {
            get
            {
                RoutingType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RoutingType val) { RoutingType = val; }
        public RoutingType Get(RoutingType val) { GetField(val); return val; }
        public bool IsSet(RoutingType val) { return IsSetRoutingType(); }
        public bool IsSetRoutingType() { return IsSetField(Tags.RoutingType); }

        public RoutingID RoutingID
        {
            get
            {
                RoutingID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RoutingID val) { RoutingID = val; }
        public RoutingID Get(RoutingID val) { GetField(val); return val; }
        public bool IsSet(RoutingID val) { return IsSetRoutingID(); }
        public bool IsSetRoutingID() { return IsSetField(Tags.RoutingID); }
    }

    public class NoRelatedSymGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RelatdSym, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RelatdSym, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, 0};

        public NoRelatedSymGroup()
          : base(Tags.NoRelatedSym, Tags.RelatdSym, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRelatedSymGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RelatdSym RelatdSym
        {
            get
            {
                RelatdSym val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelatdSym val) { RelatdSym = val; }
        public RelatdSym Get(RelatdSym val) { GetField(val); return val; }
        public bool IsSet(RelatdSym val) { return IsSetRelatdSym(); }
        public bool IsSetRelatdSym() { return IsSetField(Tags.RelatdSym); }

        public SymbolSfx SymbolSfx
        {
            get
            {
                SymbolSfx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SymbolSfx val) { SymbolSfx = val; }
        public SymbolSfx Get(SymbolSfx val) { GetField(val); return val; }
        public bool IsSet(SymbolSfx val) { return IsSetSymbolSfx(); }
        public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

        public SecurityID SecurityID
        {
            get
            {
                SecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityID val) { SecurityID = val; }
        public SecurityID Get(SecurityID val) { GetField(val); return val; }
        public bool IsSet(SecurityID val) { return IsSetSecurityID(); }
        public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

        public IDSource IDSource
        {
            get
            {
                IDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IDSource val) { IDSource = val; }
        public IDSource Get(IDSource val) { GetField(val); return val; }
        public bool IsSet(IDSource val) { return IsSetIDSource(); }
        public bool IsSetIDSource() { return IsSetField(Tags.IDSource); }

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

        public MaturityMonthYear MaturityMonthYear
        {
            get
            {
                MaturityMonthYear val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaturityMonthYear val) { MaturityMonthYear = val; }
        public MaturityMonthYear Get(MaturityMonthYear val) { GetField(val); return val; }
        public bool IsSet(MaturityMonthYear val) { return IsSetMaturityMonthYear(); }
        public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

        public MaturityDay MaturityDay
        {
            get
            {
                MaturityDay val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaturityDay val) { MaturityDay = val; }
        public MaturityDay Get(MaturityDay val) { GetField(val); return val; }
        public bool IsSet(MaturityDay val) { return IsSetMaturityDay(); }
        public bool IsSetMaturityDay() { return IsSetField(Tags.MaturityDay); }

        public PutOrCall PutOrCall
        {
            get
            {
                PutOrCall val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PutOrCall val) { PutOrCall = val; }
        public PutOrCall Get(PutOrCall val) { GetField(val); return val; }
        public bool IsSet(PutOrCall val) { return IsSetPutOrCall(); }
        public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }

        public StrikePrice StrikePrice
        {
            get
            {
                StrikePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikePrice val) { StrikePrice = val; }
        public StrikePrice Get(StrikePrice val) { GetField(val); return val; }
        public bool IsSet(StrikePrice val) { return IsSetStrikePrice(); }
        public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

        public OptAttribute OptAttribute
        {
            get
            {
                OptAttribute val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptAttribute val) { OptAttribute = val; }
        public OptAttribute Get(OptAttribute val) { GetField(val); return val; }
        public bool IsSet(OptAttribute val) { return IsSetOptAttribute(); }
        public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

        public ContractMultiplier ContractMultiplier
        {
            get
            {
                ContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractMultiplier val) { ContractMultiplier = val; }
        public ContractMultiplier Get(ContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(ContractMultiplier val) { return IsSetContractMultiplier(); }
        public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }

        public CouponRate CouponRate
        {
            get
            {
                CouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CouponRate val) { CouponRate = val; }
        public CouponRate Get(CouponRate val) { GetField(val); return val; }
        public bool IsSet(CouponRate val) { return IsSetCouponRate(); }
        public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }

        public SecurityExchange SecurityExchange
        {
            get
            {
                SecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityExchange val) { SecurityExchange = val; }
        public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
        public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
        public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

        public Issuer Issuer
        {
            get
            {
                Issuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Issuer val) { Issuer = val; }
        public Issuer Get(Issuer val) { GetField(val); return val; }
        public bool IsSet(Issuer val) { return IsSetIssuer(); }
        public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

        public EncodedIssuerLen EncodedIssuerLen
        {
            get
            {
                EncodedIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedIssuerLen val) { EncodedIssuerLen = val; }
        public EncodedIssuerLen Get(EncodedIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }
        public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }

        public EncodedIssuer EncodedIssuer
        {
            get
            {
                EncodedIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedIssuer val) { EncodedIssuer = val; }
        public EncodedIssuer Get(EncodedIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedIssuer val) { return IsSetEncodedIssuer(); }
        public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }

        public SecurityDesc SecurityDesc
        {
            get
            {
                SecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityDesc val) { SecurityDesc = val; }
        public SecurityDesc Get(SecurityDesc val) { GetField(val); return val; }
        public bool IsSet(SecurityDesc val) { return IsSetSecurityDesc(); }
        public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

        public EncodedSecurityDescLen EncodedSecurityDescLen
        {
            get
            {
                EncodedSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedSecurityDescLen val) { EncodedSecurityDescLen = val; }
        public EncodedSecurityDescLen Get(EncodedSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }
        public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }

        public EncodedSecurityDesc EncodedSecurityDesc
        {
            get
            {
                EncodedSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedSecurityDesc val) { EncodedSecurityDesc = val; }
        public EncodedSecurityDesc Get(EncodedSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }
        public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }
    }

    public class LinesOfTextGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};

        public LinesOfTextGroup()
          : base(Tags.LinesOfText, Tags.Text, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new LinesOfTextGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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
    }
}
