﻿using System;
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
        /// True iff the value if of length 0.
        /// </summary>
        public override bool Empty
        {
            get
            {
                if (_changed)
                    makeStringFields();
                return _stringVal.Length == 0;
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
        /// Appends the full fix string (i.e., "tag=val") to the given StringBuilder.
        /// </summary>
        public override void AppendField(StringBuilder sb)
        {
            if (_changed.Equals(true))
                makeStringFields();
            sb.Append(_stringField);
        }

        /// <summary>
        /// returns field value formatted for fix 
        /// (separate from ToString, to facilitate finding non-debug references and also make it easier to change the signature later)
        /// </summary>
        public override string ValueToString()
        {
            if (_changed)
                makeStringFields();
            return _stringVal;
        }

        /// <summary>
        /// returns formatted string for debug output
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
        public override int getLength()
        {
            if (_changed)
                makeStringFields();
            return System.Text.Encoding.UTF8.GetByteCount(_stringField) + 1; // +1 for SOH
        }

        /// <summary>
        /// checksum
        /// </summary>
        public override int getTotal()
        {
            if (_changed)
                makeStringFields();

            int sum = 0;
            byte[] array = System.Text.Encoding.UTF8.GetBytes(_stringField);
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