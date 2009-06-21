using System;

namespace QuickFIX.NET.Fields
{
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

        // tag=val
        public string toStringField()
        {
            if( _changed.Equals( true ))
                makeStringField();
            return _stringField;
        }

        public string toString()
        {
            return Obj.ToString();
        }

        public int getLength()
        {
            return _stringField.Length + 1; // +1 for SOH
        }

        public int getTotal()
        {
            int sum = 0;
            foreach (char c in _stringField)
            {
                sum += (int)c;
            }
            return( sum + 1 ); // +1 for SOH
        }

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