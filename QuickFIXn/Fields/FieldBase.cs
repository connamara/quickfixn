using System;

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
        protected FieldBase(int tag, T obj)
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
            if (_changed)
                applyChange();
            return _stringField;
        }

        /// <summary>
        /// returns field value formatted for fix
        /// </summary>
        public override string ToString()
        {
            if (_changed)
                applyChange();
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
        public override int getLength()
        {
            if (_changed)
                applyChange();
            return _length;
        }

        /// <summary>
        /// checksum
        /// </summary>
        public override int getTotal()
        {
            if (_changed)
                applyChange();
            return _checksum;
        }

        protected abstract string makeString();

        /// <summary>
        /// returns tag=val
        /// calculates checksum and length
        /// </summary>
        private void applyChange()
        {
            _stringVal = makeString();
            _stringField = Tag + "=" + _stringVal;

            _checksum = 1;
            byte[] array = System.Text.Encoding.UTF8.GetBytes(_stringField);
            foreach (byte b in array)
            {
                _checksum += b;
            }

            _length = array.Length + 1; // +1 for SOH

            _changed = false;
        }

        #region Private members
        private string _stringField;
        private bool _changed;
        private T _obj;
        private int _tag;
        private int _checksum;
        private int _length;
        private string _stringVal;
        #endregion
    }
}