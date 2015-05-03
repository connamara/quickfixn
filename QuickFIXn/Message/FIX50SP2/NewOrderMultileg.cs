using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class NewOrderMultileg : Message
    {
        public const string MsgType = "AB";

        public NewOrderMultileg():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
