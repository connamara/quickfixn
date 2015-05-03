using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class UserResponse : Message
    {
        public const string MsgType = "BF";

        public UserResponse():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
