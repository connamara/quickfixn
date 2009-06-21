using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFIX.NET
{
    class CharField : FieldBase<Char>
    {
        public CharField(int tag, char c)
            : base(tag, c) { }

        // quickfix compat
        public char getValue()
        { return Obj; }

        public void setValue(char c)
        { Obj = c; }
    }
}
