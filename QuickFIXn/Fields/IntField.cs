namespace QuickFix.Fields;

/// <summary>
/// FIX Integer field
/// </summary>
public class IntField : FieldBase<int> {
    public IntField(int tag)
        : base(tag, 0) {
    }

    public IntField(int tag, int val)
        : base(tag, val) {
    }

    protected override string MakeString() {
        return Converters.IntConverter.Convert(Value);
    }
}
