// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX41;

public class Reject : Message
{
    public const string MsgType = "3";

    public Reject() : base()
    {
        Header.SetField(new MsgType("3"));
    }

    public Reject(
            RefSeqNum aRefSeqNum
        ) : this()
    {
        RefSeqNum = aRefSeqNum;
    }

    public RefSeqNum RefSeqNum
    {
        get
        {
            RefSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefSeqNum val) { RefSeqNum = val; }
    public RefSeqNum Get(RefSeqNum val) { GetField(val); return val; }
    public bool IsSet(RefSeqNum val) { return IsSetRefSeqNum(); }
    public bool IsSetRefSeqNum() { return IsSetField(Tags.RefSeqNum); }

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
