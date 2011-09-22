using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.DataDictionary
{
    public class DDMap
    {
        public Dictionary<int, DDField> Fields = new Dictionary<int, DDField>();
        public Dictionary<int, DDGrp> Groups = new Dictionary<int, DDGrp>();
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

        public Boolean IsField(int tag)
        {
            return Fields.ContainsKey(tag);
        }

        public DDGrp GetGroup(int tag)
        {
            return Groups[tag];
        }
    }

    public class DDGrp : DDMap
    {
        public DDField NumFld = null;
        public DDField Delim = null;
        public Boolean Required = false;
    }
}
