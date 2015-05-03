using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class RFQRequest : Message
    {
        public const string MsgType = "AH";

        public RFQRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
