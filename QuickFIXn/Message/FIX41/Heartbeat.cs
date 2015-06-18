using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class Heartbeat : Message
    {
        public const string MsgType = "0";

        public Heartbeat():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }

        public QuickFix.Fields.TestReqID TestReqID
        {
            get
            {
                var val = new QuickFix.Fields.TestReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TestReqID val) { this.TestReqID = val; }

        public QuickFix.Fields.TestReqID Get(QuickFix.Fields.TestReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TestReqID val) { return IsSetTestReqID(); }

        public bool IsSetTestReqID() { return IsSetField(Tags.TestReqID); }


    }
}
