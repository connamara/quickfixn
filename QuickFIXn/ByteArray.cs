using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public static class ByteArray
    {
        public static int IndexOf(byte[] arrayToSearchThrough, byte[] patternToFind, int offset)
        {
            if (arrayToSearchThrough.Length < patternToFind.Length)
            {
                return -1;
            }

            for (int i = offset; i <= arrayToSearchThrough.Length - patternToFind.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < patternToFind.Length; j++)
                {
                    if (arrayToSearchThrough[i + j] != patternToFind[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int IndexOf(byte[] arrayToSearchThrough, byte valueToFind, int offset)
        {
            for (int i = offset; i < arrayToSearchThrough.Length; i++)
            {
                if (arrayToSearchThrough[i] == valueToFind)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
