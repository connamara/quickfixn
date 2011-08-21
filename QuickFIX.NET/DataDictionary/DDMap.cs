using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.DataDictionary
{
    public class DDMap
    {
        public Dictionary<int, DDField> Fields = new Dictionary<int, DDField>();
        public Dictionary<int, DDMap> Groups = new Dictionary<int, DDMap>();
        public HashSet<int> ReqFields = new HashSet<int>();

        public void AddField(DDField fld)
        {
            Fields.Add(fld.Tag, fld);
        }

        public void AddGroup(DDGrp grp)
        {
            Groups.Add(grp.Delim.Tag, grp);
        }

        public Boolean IsGroup(int tag)
        {
            return Groups.ContainsKey(tag);
        }
    }

    public class DDGrp : DDMap
    {
        public DDField Delim;
        public Boolean Required = false;
    }
}
