// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX44
    {
        public abstract class Message : QuickFix.Message
        {
            public Message()
                : base()
            {
                this.Header.setField(new QuickFix.Fields.BeginString(QuickFix.FixValues.BeginString.FIX44));
            }
        }
    }
}
