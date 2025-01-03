// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX40;

public class News : Message
{
    public const string MsgType = "B";

    public News() : base()
    {
        Header.SetField(new MsgType("B"));
    }

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

    public Urgency Urgency
    {
        get
        {
            Urgency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Urgency val) { Urgency = val; }
    public Urgency Get(Urgency val) { GetField(val); return val; }
    public bool IsSet(Urgency val) { return IsSetUrgency(); }
    public bool IsSetUrgency() { return IsSetField(Tags.Urgency); }

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

    public class LinesOfTextGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Text, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Text, 0};

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
    }
}
