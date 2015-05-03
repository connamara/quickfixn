using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class ListExecute : Message
    {
        public const string MsgType = "L";

        public ListExecute():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
