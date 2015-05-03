using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class AssignmentReport : Message
    {
        public const string MsgType = "AW";

        public AssignmentReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
