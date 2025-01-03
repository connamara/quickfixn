// This is a generated file.  Don't edit it directly!

namespace QuickFix.FIX44;

public abstract class Message : QuickFix.Message
{
    protected Message() : base()
    {
        Header.SetField(new QuickFix.Fields.BeginString(QuickFix.FixValues.BeginString.FIX44));
    }
}
