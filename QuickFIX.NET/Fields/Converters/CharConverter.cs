using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Fields.Converters
{
    public static class CharConverter
    {
        public static char Convert(string c)
        {
            if (c.Length != 1)
                throw new BadConversionException("could not convert string to char, str=" + c);
            return c[0];
        }

        public static string Convert(char c)
        {
            return c.ToString();
        }
    }
}
