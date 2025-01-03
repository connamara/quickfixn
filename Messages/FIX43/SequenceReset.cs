// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class SequenceReset : Message
{
    public const string MsgType = "4";

    public SequenceReset() : base()
    {
        Header.SetField(new MsgType("4"));
    }

    public SequenceReset(
            NewSeqNo aNewSeqNo
        ) : this()
    {
        NewSeqNo = aNewSeqNo;
    }

    public GapFillFlag GapFillFlag
    {
        get
        {
            GapFillFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(GapFillFlag val) { GapFillFlag = val; }
    public GapFillFlag Get(GapFillFlag val) { GetField(val); return val; }
    public bool IsSet(GapFillFlag val) { return IsSetGapFillFlag(); }
    public bool IsSetGapFillFlag() { return IsSetField(Tags.GapFillFlag); }

    public NewSeqNo NewSeqNo
    {
        get
        {
            NewSeqNo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NewSeqNo val) { NewSeqNo = val; }
    public NewSeqNo Get(NewSeqNo val) { GetField(val); return val; }
    public bool IsSet(NewSeqNo val) { return IsSetNewSeqNo(); }
    public bool IsSetNewSeqNo() { return IsSetField(Tags.NewSeqNo); }
}
