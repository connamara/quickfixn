using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class StreamAssignmentReportACK : Message
    {
        public const string MsgType = "CE";

        public StreamAssignmentReportACK():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
