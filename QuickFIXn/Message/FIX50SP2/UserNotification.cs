using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class UserNotification : Message
    {
        public const string MsgType = "CB";

        public UserNotification():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
