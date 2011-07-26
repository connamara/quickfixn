using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Heartbeat : Message
        {
            public Heartbeat() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("0"));
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
