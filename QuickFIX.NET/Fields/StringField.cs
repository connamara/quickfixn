using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix.Fields
{
    public class StringField : FieldBase<string>
    {
        public StringField(int tag)
            : base(tag, "") { }

        public StringField(int tag, string str)
            : base(tag, str) { }

        // quickfix compat
        public string getValue()
        { return Obj; }

        public void setValue(string val)
        { Obj = val; }

        protected override string makeString()
        {
            return Obj;
        }
    }
}
