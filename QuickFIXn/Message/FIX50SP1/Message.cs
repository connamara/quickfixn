namespace QuickFix.FIX50SP1
{
    public abstract class Message : QuickFix.Message
    {
        public Message() : base()
        {
            this.Header.SetField(new QuickFix.Fields.BeginString(QuickFix.FixValues.BeginString.FIXT11));
        }
    }
}

     