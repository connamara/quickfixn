namespace QuickFix.FIX41
{
    public abstract class Message : QuickFix.Message
    {
        public Message() : base()
        {
            this.Header.SetField(new QuickFix.Fields.BeginString(QuickFix.FixValues.BeginString.FIX41));
        }
    }
}

     