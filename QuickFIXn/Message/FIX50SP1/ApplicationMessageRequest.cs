using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class ApplicationMessageRequest : Message
    {
        public const string MsgType = "BW";

        public ApplicationMessageRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
