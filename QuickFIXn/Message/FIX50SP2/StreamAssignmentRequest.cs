using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class StreamAssignmentRequest : Message
    {
        public const string MsgType = "CC";

        public StreamAssignmentRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
