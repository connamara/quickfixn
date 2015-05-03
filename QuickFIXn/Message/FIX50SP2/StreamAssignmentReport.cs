using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class StreamAssignmentReport : Message
    {
        public const string MsgType = "CD";

        public StreamAssignmentReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
