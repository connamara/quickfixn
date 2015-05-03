using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class NetworkCounterpartySystemStatusRequest : Message
    {
        public const string MsgType = "BC";

        public NetworkCounterpartySystemStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
