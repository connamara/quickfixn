using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class NetworkCounterpartySystemStatusResponse : Message
    {
        public const string MsgType = "BD";

        public NetworkCounterpartySystemStatusResponse():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
