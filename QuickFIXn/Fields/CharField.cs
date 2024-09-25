namespace QuickFix.Fields;

/// <summary>
/// FIX character field
/// </summary>
public class CharField : FieldBase<char> {
    public CharField(int tag)
        : base(tag, '\0') {
    }

    public CharField(int tag, char c)
        : base(tag, c) {
    }

    protected override string MakeString() {
        return Converters.CharConverter.Convert(Value);
    }
}
