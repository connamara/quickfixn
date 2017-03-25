using System;
using System.Text;

namespace QuickFix.Fields
{
    /// <summary>
    /// Base class for all field types
    /// </summary>
    /// <typeparam name="T">Internal storage type</typeparam>
    public abstract class FieldBase<T> : IField
    {
        /// <summary>
        /// Constructs a new field with the specified tag and value
        /// </summary>
        /// <param name="tag">the FIX tag number</param>
        /// <param name="obj">the value of the field</param>
        public FieldBase(int tag, T obj)
        {
            _tag = tag;
            _obj = obj;
            _changed = true;
        }

        #region Properties
        public T Obj
        {
            get { return _obj; }
            set
            {
                _obj = value;
                _changed = true;
            }
        }

        /// <summary>
        /// the FIX tag number
        /// </summary>
        public override int Tag
        {
            get { return _tag; }
            set
            {
                _tag = value;
                _changed = true;
            }
        }
        #endregion

        /// <summary>
        /// returns full fix string (e.g. "tag=val")
        /// </summary>
        public override string toStringField()
        {
            if (_changed.Equals(true))
                makeStringFields();
            return _stringField;
        }

        /// <summary>
        /// returns field value formatted for fix
        /// </summary>
        public override string ToString()
        {
            if (_changed)
                makeStringFields();
            return _stringVal;
        }

        /// <summary>
        /// Value equality test
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            FieldBase<T> f = (FieldBase<T>)obj;
            return this.Tag == f.Tag && this.Obj.Equals(f.Obj);
        }

        public override int GetHashCode()
        {
            return Tag ^ Obj.GetHashCode();
        }

        /// <summary>
        /// length of formatted field (including tag=val\001)
        /// </summary>
        public override int getLength(Encoding encoding)
        {
            if (_changed)
                makeStringFields();
            return encoding.GetByteCount(_stringField) + 1; // +1 for SOH
        }

        /// <summary>
        /// checksum
        /// </summary>
        public override int getTotal(Encoding encoding)
        {
            if (_changed)
                makeStringFields();

            int sum = 0;
            byte[] array = encoding.GetBytes(_stringField);
            foreach (byte b in array)
            {
                sum += b;
            }
            return (sum + 1); // +1 for SOH
        }

        protected abstract string makeString();

        /// <summary>
        /// returns tag=val
        /// </summary>
        private void makeStringFields()
        {
            _stringVal = makeString();
            _stringField = Tag + "=" + _stringVal;
            _changed = false;
        }

        #region Private members
        private string _stringField;
        private bool _changed;
        private T _obj;
        private int _tag;
        private string _stringVal;
        #endregion
    }
}