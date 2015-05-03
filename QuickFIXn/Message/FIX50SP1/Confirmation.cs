using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class Confirmation : Message
    {
        public const string MsgType = "AK";

        public Confirmation():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
