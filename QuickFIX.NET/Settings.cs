using System.Collections.Generic;

namespace QuickFix
{
    public class Settings
    {
        private LinkedList<QuickFix.Dictionary> sections_ = new LinkedList<QuickFix.Dictionary>();

        public QuickFix.Dictionary Add(QuickFix.Dictionary section)
        {
            sections_.AddLast(section);
            return section;
        }

        public LinkedList<QuickFix.Dictionary> Get(string sectionName)
        {
            LinkedList<QuickFix.Dictionary> result = new LinkedList<Dictionary>();
            foreach(QuickFix.Dictionary dict in sections_)
                if(sectionName == dict.Name)
                    result.AddLast(dict);
            return result;
        }
    }
}
