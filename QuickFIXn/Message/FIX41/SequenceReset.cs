using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class SequenceReset : Message
    {
        public const string MsgType = "4";

        public SequenceReset():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
