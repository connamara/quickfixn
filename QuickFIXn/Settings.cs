using System.Collections.Generic;

namespace QuickFix
{
    public class Settings
    {
        private LinkedList<QuickFix.Dictionary> sections_ = new LinkedList<QuickFix.Dictionary>();

        public Settings(System.IO.TextReader conf)
        {
            QuickFix.Dictionary currentSection = null;

            string line = null;
            while ((line = conf.ReadLine()) != null)
            {
                line = line.Trim();
                if (IsComment(line))
                {
                    continue;
                }
                else if (IsSection(line))
                {
                    currentSection = Add(new Dictionary(SplitSection(line)));
                }
                else if (IsKeyValue(line) && currentSection != null)
                {
                    string[] kv = line.Split(new char[]{'='}, 2);
                    currentSection.SetString(kv[0].Trim(), kv[1].Trim());

                    // the following checks should be removed for v2
                    if (kv[0] == SessionSettings.DEBUG_FILE_LOG_PATH)
                    {
                        System.Console.WriteLine("WARNING: The config setting '" + SessionSettings.DEBUG_FILE_LOG_PATH + "' is deprecated.");
                        System.Console.WriteLine("         Please use '" + SessionSettings.EXTRA_DEBUG_LOGGING + "' instead.  See the docs.");
                    }
                }
            }
        }

        /// <summary>
        /// Strip the outer '[' and ']' from the section name, e.g. '[DEFAULT]' becomes 'DEFAULT'
        /// </summary>
        /// <param name="s">the section name</param>
        /// <returns></returns>
        public static string SplitSection(string s)
        {
            return s.Trim('[', ']').Trim();
        }

        public static bool IsComment(string s)
        {
            if (s.Length < 1)
                return false;
            return '#' == s[0];
        }

        public static bool IsKeyValue(string s)
        {
            return s.IndexOf('=') != -1;
        }

        public static bool IsSection(string s)
        {
            if (s.Length < 2)
                return false;
            return s[0] == '[' && s[s.Length - 1] == ']';
        }

        public QuickFix.Dictionary Add(QuickFix.Dictionary section)
        {
            sections_.AddLast(section);
            return section;
        }

        public LinkedList<QuickFix.Dictionary> Get(string sectionName)
        {
            LinkedList<QuickFix.Dictionary> result = new LinkedList<Dictionary>();
            foreach (QuickFix.Dictionary dict in sections_)
                if (sectionName == dict.Name)
                    result.AddLast(dict);
            return result;
        }
    }
}
