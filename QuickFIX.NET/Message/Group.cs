using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class Group : FieldMap
    {
        public Group(int field, int delim)
        {
            Field = field;
            Delim = delim;
        }

        public Group(int field, int delim, int[] fieldOrd)
            :base(fieldOrd)
        {
            Field = field;
            Delim = delim;
        }

        public int Field
        {
            get { return _field; }
            private set { _field = value; }
        }

        public int Delim
        {
            get { return _delim; }
            private set { _delim = value; }
        }

        #region Private Members
        private int _field;
        private int _delim;
        #endregion
    }
}
