using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class NetworkStatusResponse : Message
    {
        public const string MsgType = "BD";

        public NetworkStatusResponse():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
