using System;

namespace QuickFIX.NET
{
    public abstract class FieldBase<T>
    {
        public FieldBase(int tag, T obj)
        {
            this.Tag = tag;
            this.Obj = obj;
            this.changed = true;
        }

        #region Properties
        public T Obj
        {
            get { return Obj; }
            set
            {
                Obj = value;
                changed = true;
            }
        }

        public int Tag
        {
            get { return Tag; }
            set
            {
                Tag = value;
                changed = true;
            }
        }
        #endregion

        // tag=val
        public string toStringField()
        {
            if( changed.Equals( true ))
                makeStringField();
            return stringField;
        }

        public string toString()
        {
            return Obj.ToString();
        }

        public int getLength()
        {
            return stringField.Length + 1; // +1 for SOH
        }

        public int getTotal()
        {
            int sum = 0;
            foreach (char c in stringField)
            {
                sum += (int)c;
            }
            return( sum + 1 ); // +1 for SOH
        }

        private void makeStringField()
        {
            stringField = Tag + "=" + ToString();
            changed = false;
        }

        #region Private members
        private string stringField;
        private bool changed;
        #endregion
    }
}