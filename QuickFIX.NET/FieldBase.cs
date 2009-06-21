using System;

namespace QuickFIX
{
    public class FieldBase<T>
    {
        public FieldBase(int tag, T obj)
        {
            this.Tag = tag;
            this.Obj = obj;
            this.changed = true;
        }

        public T Obj
        {
            get;
            set
            {
                Obj = value;
                changed = true;
            }
        }

        public int Tag
        {
            get;
            set
            {
                Tag = value;
                changed = true;
            }
        }

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

        private string stringField;
        private bool changed;

        private void makeStringField()
        {
            stringField = Tag + "=" + ToString();
            changed = false;
        }
    }
}