// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class ResendRequest : Message
{
    public const string MsgType = "2";

    public ResendRequest() : base()
    {
        Header.SetField(new MsgType("2"));
    }

    public ResendRequest(
            BeginSeqNo aBeginSeqNo,
            EndSeqNo aEndSeqNo
        ) : this()
    {
        BeginSeqNo = aBeginSeqNo;
        EndSeqNo = aEndSeqNo;
    }

    public BeginSeqNo BeginSeqNo
    {
        get
        {
            BeginSeqNo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BeginSeqNo val) { BeginSeqNo = val; }
    public BeginSeqNo Get(BeginSeqNo val) { GetField(val); return val; }
    public bool IsSet(BeginSeqNo val) { return IsSetBeginSeqNo(); }
    public bool IsSetBeginSeqNo() { return IsSetField(Tags.BeginSeqNo); }

    public EndSeqNo EndSeqNo
    {
        get
        {
            EndSeqNo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndSeqNo val) { EndSeqNo = val; }
    public EndSeqNo Get(EndSeqNo val) { GetField(val); return val; }
    public bool IsSet(EndSeqNo val) { return IsSetEndSeqNo(); }
    public bool IsSetEndSeqNo() { return IsSetField(Tags.EndSeqNo); }
}
