using System.Runtime.InteropServices;

namespace QuickFix.Util
{
    public static class StringUtil
    {
        /// <summary>
        /// Convert forward-slashes to backslashes (windows) or backslashes to forward-slashes (not windows)
        /// and return the result
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string FixSlashes(string s) {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? s.Replace('/', '\\')
                : s.Replace('\\', '/');
        }
    }
}

