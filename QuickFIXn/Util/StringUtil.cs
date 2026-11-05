using System;

namespace QuickFix.Util;

public static class StringUtil
{
    /// <summary>
    /// Convert forward-slashes to backslashes (windows) or backslashes to forward-slashes (not windows)
    /// and return the result
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string FixSlashes(string s) {
        return OperatingSystem.IsWindows()
            ? s.Replace('/', '\\')
            : s.Replace('\\', '/');
    }
}
