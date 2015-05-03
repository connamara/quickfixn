using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class NetworkStatusRequest : Message
    {
        public const string MsgType = "BC";

        public NetworkStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
