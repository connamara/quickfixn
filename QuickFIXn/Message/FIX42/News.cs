using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class News : Message
    {
        public const string MsgType = "B";

        public News():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
