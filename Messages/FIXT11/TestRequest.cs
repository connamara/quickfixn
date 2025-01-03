// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIXT11;

public class TestRequest : Message
{
    public const string MsgType = "1";

    public TestRequest() : base()
    {
        Header.SetField(new MsgType("1"));
    }

    public TestRequest(
            TestReqID aTestReqID
        ) : this()
    {
        TestReqID = aTestReqID;
    }

    public TestReqID TestReqID
    {
        get
        {
            TestReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TestReqID val) { TestReqID = val; }
    public TestReqID Get(TestReqID val) { GetField(val); return val; }
    public bool IsSet(TestReqID val) { return IsSetTestReqID(); }
    public bool IsSetTestReqID() { return IsSetField(Tags.TestReqID); }
}
