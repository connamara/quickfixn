// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44
    {
        public class XMLnonFIX : Message
        {
            public const string MsgType = "n";

            public XMLnonFIX() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("n"));
            }


        }
    }
}
