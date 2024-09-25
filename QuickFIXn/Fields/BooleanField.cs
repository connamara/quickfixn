namespace QuickFix.Fields;

/// <summary>
/// FIX Boolean field
/// </summary>
public class BooleanField : FieldBase<bool> {
    public BooleanField(int tag)
        : base(tag, false) {
    }

    public BooleanField(int tag, bool b)
        : base(tag, b) {
    }

    protected override string MakeString() {
        return Converters.BoolConverter.Convert(Value);
    }
}

