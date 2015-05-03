using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class TestRequest : Message
    {
        public const string MsgType = "1";

        public TestRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
