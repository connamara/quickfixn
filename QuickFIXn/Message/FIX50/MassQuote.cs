using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class MassQuote : Message
    {
        public const string MsgType = "i";

        public MassQuote():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
