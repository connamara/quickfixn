using System;

namespace QuickFIX.NET.Fields
{
    /// <summary>
    /// Base class for all field types
    /// </summary>
    /// <typeparam name="T">Internal storage type</typeparam>
    public abstract class FieldBase<T>
    {
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

        public int Tag
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
        /// returns full fix string: tag=val
        /// </summary>
        public string toStringField()
        {
            if( _changed.Equals( true ))
                makeStringField();
            return _stringField;
        }

        /// <summary>
        /// returns formatted string for fix
        /// </summary>
        public override string ToString()
        {
            return makeString();
        }

        /// <summary>
        /// length of formatted field (including tag=val\001)
        /// </summary>
        public int getLength()
        {
            return _stringField.Length + 1; // +1 for SOH
        }

        /// <summary>
        /// checksum
        /// </summary>
        public int getTotal()
        {
            if( _changed.Equals(true) )
              makeStringField();

            int sum = 0;
            foreach (char c in _stringField)
            {
                sum += (int)c;
            }
            return( sum + 1 ); // +1 for SOH
        }

        protected abstract string makeString();

        /// <summary>
        /// returns tag=val
        /// </summary>
        private void makeStringField()
        {
            _stringField = Tag + "=" + ToString();
            _changed = false;
        }

        #region Private members
        private string _stringField;
        private bool _changed;
        private T _obj;
        private int _tag;
        #endregion
    }
}