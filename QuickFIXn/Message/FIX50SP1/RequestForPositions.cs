using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class RequestForPositions : Message
    {
        public const string MsgType = "AN";

        public RequestForPositions():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
