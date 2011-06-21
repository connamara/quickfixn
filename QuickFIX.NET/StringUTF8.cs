using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class ByteSizeString
    {
        public ByteSizeString(byte[] buf, int sz)
        {
            this._str = new byte[sz];
            for (int i = 0; i < sz; i++)
                _str[i] = buf[i];
        }

        public ByteSizeString(byte[] buf, int pos, int sz)
        {
            this._str = new byte[sz];
            for (int i = 0; i < sz; i++)
                _str[i] = buf[i+pos];
        }

        public override string ToString()
        {
            return Encoding.UTF8.GetString(_str);
        }

        public int IndexOf( byte nextchar, int pos )
        {
            if (pos > _str.Length)
                throw new OverflowException("pos is greater than string length!");

            int retpos;
            for (retpos = pos; retpos < _str.Length; ++retpos)
            {
                if (_str[retpos] == nextchar )
                    return retpos;
            }
            throw new OverflowException("= not found!");
        }

        public int GetNextTag(ref int pos)
        {
            int start = pos;
            pos = IndexOf(EQ, start);
            int ret = 0;
            int factor = 1;
            for( int i =(pos-1); i >= start; i--)
            {
                ret += (_str[i]-48) * factor;
                factor *= 10;
            }
            pos += 1;
            return ret;
        }

        public ByteSizeString GetNextValue(ref int pos)
        {
            int start = pos;
            pos = IndexOf(SOH, start);
            ByteSizeString ret = new ByteSizeString(_str, start, pos - start);
            pos += 1;
            return ret;
        }

        #region Properties
        public byte[] ByteArray
        {
            get { return _str; }
            private set { _str = value; }
        }
        #endregion

        #region PrivateMembers
        private byte[] _str;
        private const byte EQ = 61;
        private const byte SOH = 1;
        #endregion
    }
}
