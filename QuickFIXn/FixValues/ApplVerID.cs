namespace QuickFix.FixValues;

public static class ApplVerID
{
    public const string FIX40 = "2";
    public const string FIX41 = "3";
    public const string FIX42 = "4";
    public const string FIX43 = "5";
    public const string FIX44 = "6";
    public const string FIX50 = "7";
    public const string FIX50SP1 = "8";
    public const string FIX50SP2 = "9";

    public static string FromBeginString(string beginString)
    {
        return beginString switch
        {
            BeginString.FIX40 => FIX40,
            BeginString.FIX41 => FIX41,
            BeginString.FIX42 => FIX42,
            BeginString.FIX43 => FIX43,
            BeginString.FIX44 => FIX44,
            BeginString.FIX50 => FIX50,
            BeginString.FIX50SP1 => FIX50SP1,
            BeginString.FIX50SP2 => FIX50SP2,
            _ => beginString
        };
    }

    public static string ToBeginString(string applVerId) {
        return applVerId switch
        {
            FIX40 => BeginString.FIX40,
            FIX41 => BeginString.FIX41,
            FIX42 => BeginString.FIX42,
            FIX43 => BeginString.FIX43,
            FIX44 => BeginString.FIX44,
            FIX50 => BeginString.FIX50,
            FIX50SP1 => BeginString.FIX50SP1,
            FIX50SP2 => BeginString.FIX50SP2,
            _ => throw new System.ArgumentException(
                $"ApplVerId parameter '{applVerId}' does not map to a known BeginString")
        };
    }
}
