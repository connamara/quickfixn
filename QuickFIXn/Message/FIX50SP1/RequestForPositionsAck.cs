using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class RequestForPositionsAck : Message
    {
        public const string MsgType = "AO";

        public RequestForPositionsAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
