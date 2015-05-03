using QuickFix.Fields;
namespace QuickFix.FIX42
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
