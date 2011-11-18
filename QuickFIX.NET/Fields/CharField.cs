using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix.Fields
{
    /// <summary>
    /// A character message field
    /// </summary>
    public class CharField : FieldBase<Char>
    {
        public CharField(int tag)
            :base(tag, '\0') {}

        public CharField(int tag, char c)
            : base(tag, c) { }

        // quickfix compat
        public char getValue()
        { return Obj; }

        public void setValue(char c)
        { Obj = c; }

        protected override string makeString()
        {
            return Converters.CharConverter.Convert(Obj);
        }
    }
}
