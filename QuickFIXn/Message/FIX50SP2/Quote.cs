using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class Quote : Message
    {
        public const string MsgType = "S";

        public Quote():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
