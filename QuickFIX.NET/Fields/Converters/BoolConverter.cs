using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Fields.Converters
{
    public static class BoolConverter
    {
        public static string Convert(Boolean b)
        {
            return b ? "Y" : "N";
        }

        public static Boolean Convert(string boolstr)
        {
            switch (boolstr)
            {
                case "Y": return true;
                case "N": return false;
                default: throw new BadConversionException("Cannot convert string to boolean");
            }
        }
    }
}
