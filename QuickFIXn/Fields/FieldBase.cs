using System;
using System.IO;
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
        /// Appends the full fix string (i.e., "tag=val") to the given MemoryStream.
        /// </summary>
        public override void AppendField(MemoryStream ms)
        {
            if (_changed.Equals(true))
                makeStringFields();

            byte[] tagBytes = Encoding.ASCII.GetBytes(Tag.ToString());
            ms.Write(tagBytes, 0, tagBytes.Length);

            ms.WriteByte(Message.EqualsSignByteValue);

            byte[] valueBytes = Encoding.UTF8.GetBytes(_stringVal);
            ms.Write(valueBytes, 0, valueBytes.Length);
        }

        /// <summary>
        /// returns field value formatted for fix 
        /// (separate from ToString, to facilitate finding non-debug references and also make it easier to change the signature later if required)
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

        protected abstract string makeString();

        /// <summary>
        /// returns tag=val
        /// </summary>
        private void makeStringFields()
        {
            _stringVal = makeString();
            _changed = false;
        }

        #region Private members
        private bool _changed;
        private T _obj;
        private int _tag;
        private string _stringVal;
        #endregion
    }
}