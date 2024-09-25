using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// Base class for all field types
    /// </summary>
    /// <typeparam name="T">Internal storage type</typeparam>
    public abstract class FieldBase<T> : IField
        where T : notnull
    {
        /// Set _stringVal (val only) and _stringField (tag=val)

        private T _value;
        private int _tag;
        private bool _changed;
        private string _stringVal; // field value (not tag) formatted for fix
        private string _stringField; // field string e.g. tag=val (no SOH)

        /// <summary>
        /// Constructs a new field with the specified tag and value
        /// </summary>
        /// <param name="tag">the FIX tag number</param>
        /// <param name="value">the value of the field</param>
        public FieldBase(int tag, T value)
        {
            _tag = tag;
            _value = value;
            _changed = true;

            // We can't set these properly here because makeString() is abstract.
            // See https://stackoverflow.com/a/119543/650475
            _stringVal = "";
            _stringField = "";
        }

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                _changed = true;
            }
        }

        //-----------------------------------
        // IField implementations

        /// <summary>
        /// the FIX tag number
        /// </summary>
        public int Tag
        {
            get => _tag;
            set
            {
                _tag = value;
                _changed = true;
            }
        }

        /// <summary>
        /// returns full fix string (e.g. "tag=val")
        /// </summary>
        public string ToStringField()
        {
            if (_changed)
                MakeStringFields();
            return _stringField;
        }

        /// <summary>
        /// returns field value (not tag) formatted for fix
        /// </summary>
        public override string ToString()
        {
            if (_changed)
                MakeStringFields();
            return _stringVal;
        }

        /// <summary>
        /// length of formatted field (including the trailing SOH) e.g. tag=val\001
        /// </summary>
        public int GetLength()
        {
            if (_changed)
                MakeStringFields();
            return CharEncoding.DefaultEncoding.GetByteCount(_stringField) + 1; // +1 for SOH
        }

        /// <summary>
        /// Sum of bytes; used in calculating checksum
        /// </summary>
        public int GetTotal()
        {
            if (_changed)
                MakeStringFields();

            int sum = 0;
            byte[] array = CharEncoding.DefaultEncoding.GetBytes(_stringField);
            foreach (byte b in array)
            {
                sum += b;
            }
            return sum + 1; // +1 for SOH
        }

        //-----------------------------------
        // C# Equals/HashCode overrides

        /// <summary>
        /// Value equality test
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is null || GetType() != obj.GetType())
                return false;

            FieldBase<T> f = (FieldBase<T>)obj;
            return this.Tag == f.Tag && this.Value.Equals(f.Value);
        }

        public override int GetHashCode()
        {
            return Tag ^ Value.GetHashCode();
        }

        /// <summary>
        /// Convert underlying field value to fix-ready string
        /// </summary>
        /// <returns></returns>
        protected abstract string MakeString();

        /// <summary>
        /// Set _stringVal (val only) and _stringField (tag=val)
        /// </summary>
        private void MakeStringFields()
        {
            _stringVal = MakeString();
            _stringField = Tag + "=" + _stringVal;
            _changed = false;
        }

        [Obsolete("Use capitalized ToStringField() instead")]
        public string toStringField() { return ToStringField(); }
        [Obsolete("Use capitalized GetLength() instead")]
        public int getLength() { return GetLength(); }
        [Obsolete("Use capitalized GetTotal() instead")]
        public int getTotal() { return GetTotal(); }
        [Obsolete("Renamed to 'Value'")]
        public T Obj
        {
            get => _value;
            set
            {
                _value = value;
                _changed = true;
            }
        }
        [Obsolete("Use Value getter property")]
        public T getValue() { return Value; }
        [Obsolete("Use Value setter property")]
        public void setValue(T v) { Value = v; }
    }
}
