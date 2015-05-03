using QuickFix.Fields;
namespace QuickFix.FIX41
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
