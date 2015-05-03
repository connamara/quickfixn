using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class ListStatus : Message
    {
        public const string MsgType = "N";

        public ListStatus():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
