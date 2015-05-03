using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class MultilegOrderCancelReplaceRequest : Message
    {
        public const string MsgType = "AC";

        public MultilegOrderCancelReplaceRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
