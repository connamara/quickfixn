using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFIX.NET
{
    public class StringField : FieldBase<string>
    {
        public StringField(int field, string str)
            : base(field, str) { }

        // quickfix compat
        public string getValue()
        { return Obj; }

        public void setValue(string val)
        { Obj = val; }
    }
}
