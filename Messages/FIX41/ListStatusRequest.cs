// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX41;

public class ListStatusRequest : Message
{
    public const string MsgType = "M";

    public ListStatusRequest() : base()
    {
        Header.SetField(new MsgType("M"));
    }

    public ListStatusRequest(
            ListID aListID
        ) : this()
    {
        ListID = aListID;
    }

    public ListID ListID
    {
        get
        {
            ListID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListID val) { ListID = val; }
    public ListID Get(ListID val) { GetField(val); return val; }
    public bool IsSet(ListID val) { return IsSetListID(); }
    public bool IsSetListID() { return IsSetField(Tags.ListID); }

    public WaveNo WaveNo
    {
        get
        {
            WaveNo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(WaveNo val) { WaveNo = val; }
    public WaveNo Get(WaveNo val) { GetField(val); return val; }
    public bool IsSet(WaveNo val) { return IsSetWaveNo(); }
    public bool IsSetWaveNo() { return IsSetField(Tags.WaveNo); }

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
