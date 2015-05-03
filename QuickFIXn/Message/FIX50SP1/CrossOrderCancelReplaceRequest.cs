using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class CrossOrderCancelReplaceRequest : Message
    {
        public const string MsgType = "t";

        public CrossOrderCancelReplaceRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
