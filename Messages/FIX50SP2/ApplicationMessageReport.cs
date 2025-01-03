// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class ApplicationMessageReport : Message
{
    public const string MsgType = "BY";

    public ApplicationMessageReport() : base()
    {
        Header.SetField(new MsgType("BY"));
    }

    public ApplicationMessageReport(
            ApplReportID aApplReportID,
            ApplReportType aApplReportType
        ) : this()
    {
        ApplReportID = aApplReportID;
        ApplReportType = aApplReportType;
    }

    public ApplReportID ApplReportID
    {
        get
        {
            ApplReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplReportID val) { ApplReportID = val; }
    public ApplReportID Get(ApplReportID val) { GetField(val); return val; }
    public bool IsSet(ApplReportID val) { return IsSetApplReportID(); }
    public bool IsSetApplReportID() { return IsSetField(Tags.ApplReportID); }

    public ApplReportType ApplReportType
    {
        get
        {
            ApplReportType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplReportType val) { ApplReportType = val; }
    public ApplReportType Get(ApplReportType val) { GetField(val); return val; }
    public bool IsSet(ApplReportType val) { return IsSetApplReportType(); }
    public bool IsSetApplReportType() { return IsSetField(Tags.ApplReportType); }

    public NoApplIDs NoApplIDs
    {
        get
        {
            NoApplIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoApplIDs val) { NoApplIDs = val; }
    public NoApplIDs Get(NoApplIDs val) { GetField(val); return val; }
    public bool IsSet(NoApplIDs val) { return IsSetNoApplIDs(); }
    public bool IsSetNoApplIDs() { return IsSetField(Tags.NoApplIDs); }

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

    public ApplReqID ApplReqID
    {
        get
        {
            ApplReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplReqID val) { ApplReqID = val; }
    public ApplReqID Get(ApplReqID val) { GetField(val); return val; }
    public bool IsSet(ApplReqID val) { return IsSetApplReqID(); }
    public bool IsSetApplReqID() { return IsSetField(Tags.ApplReqID); }

    public class NoApplIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RefApplID, Tags.ApplNewSeqNum, Tags.RefApplLastSeqNum, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RefApplID, Tags.ApplNewSeqNum, Tags.RefApplLastSeqNum, 0};

        public NoApplIDsGroup()
          : base(Tags.NoApplIDs, Tags.RefApplID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoApplIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RefApplID RefApplID
        {
            get
            {
                RefApplID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefApplID val) { RefApplID = val; }
        public RefApplID Get(RefApplID val) { GetField(val); return val; }
        public bool IsSet(RefApplID val) { return IsSetRefApplID(); }
        public bool IsSetRefApplID() { return IsSetField(Tags.RefApplID); }

        public ApplNewSeqNum ApplNewSeqNum
        {
            get
            {
                ApplNewSeqNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ApplNewSeqNum val) { ApplNewSeqNum = val; }
        public ApplNewSeqNum Get(ApplNewSeqNum val) { GetField(val); return val; }
        public bool IsSet(ApplNewSeqNum val) { return IsSetApplNewSeqNum(); }
        public bool IsSetApplNewSeqNum() { return IsSetField(Tags.ApplNewSeqNum); }

        public RefApplLastSeqNum RefApplLastSeqNum
        {
            get
            {
                RefApplLastSeqNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefApplLastSeqNum val) { RefApplLastSeqNum = val; }
        public RefApplLastSeqNum Get(RefApplLastSeqNum val) { GetField(val); return val; }
        public bool IsSet(RefApplLastSeqNum val) { return IsSetRefApplLastSeqNum(); }
        public bool IsSetRefApplLastSeqNum() { return IsSetField(Tags.RefApplLastSeqNum); }
    }
}
