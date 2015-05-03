using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class BusinessMessageReject : Message
    {
        public const string MsgType = "j";

        public BusinessMessageReject():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
