using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class ApplicationMessageReport : Message
    {
        public const string MsgType = "BY";

        public ApplicationMessageReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
