using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class DontKnowTrade : Message
    {
        public const string MsgType = "Q";

        public DontKnowTrade():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
