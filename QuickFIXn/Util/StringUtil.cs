using System;
using System.Runtime.InteropServices;
using QuickFix.Fields;

namespace QuickFix.Util
{
    public static class StringUtil
    {
        static public string FixSlashes(string s)
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return s.Replace('/', '\\');
            return s.Replace('\\', '/');
        }
    }
}
