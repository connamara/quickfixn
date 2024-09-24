namespace QuickFix;

public class FixValue<T> where T : notnull
{
    private T _value;

    public T Value => _value;
    public string Description { get; }

    public FixValue(T value, string description)
    {
        _value = value;
        Description = description;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || (this.GetType() != obj.GetType()))
            return false;
        FixValue<T> rhs = (FixValue<T>)obj;
        return this.Value.Equals(rhs.Value);
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    public override string ToString()
    {
        return Description;
    }
}
