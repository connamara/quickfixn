using System;
using System.Runtime.InteropServices;
using QuickFix.Fields;

namespace QuickFix.Util
{
    public static class StringUtil
    {
        public static string FixSlashes(string s) {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? s.Replace('/', '\\')
                : s.Replace('\\', '/');
        }

        public static int InvariantCompareTo(string strA, string strB) {
            return string.Compare(strA, strB, StringComparison.InvariantCulture);
        }
    }
}
