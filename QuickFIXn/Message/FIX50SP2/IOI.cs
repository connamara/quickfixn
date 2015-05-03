using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class IOI : Message
    {
        public const string MsgType = "6";

        public IOI():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
