using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class UserRequest : Message
    {
        public const string MsgType = "BE";

        public UserRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
