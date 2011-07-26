using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
    {
        public class TestRequest : Message
        {
            public TestRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("1"));
            }

            public TestRequest(
                    QuickFix.Fields.TestReqID aTestReqID
                ) : this()
            {
                this.testReqID = aTestReqID;
            }

            public QuickFix.Fields.TestReqID testReqID
            { 
                get 
                {
                    QuickFix.Fields.TestReqID val = new QuickFix.Fields.TestReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TestReqID val) 
            { 
                this.testReqID = val;
            }
            
            public QuickFix.Fields.TestReqID get(QuickFix.Fields.TestReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TestReqID val) 
            { 
                return isSetTestReqID();
            }
            
            public bool isSetTestReqID() 
            { 
                return isSetField(Tags.TestReqID);
            }

        }
    }
}
