using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.DataDictionary
{
    /// <summary>
    /// Represents the DD definition for a message type
    /// </summary>
    public class DDMap : IFieldMapSpec
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
            Groups.Add(grp.Delim, grp);
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

        /// <summary>
        /// Same as GetGroup, just a more-general return type.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public IGroupSpec GetGroupSpec(int tag)
        {
            return Groups[tag];
        }
    }

    /// <summary>
    /// Represents the DD definition for a group type
    /// </summary>
    public class DDGrp : DDMap, IGroupSpec
    {
        public int NumFld { get; set; }
        public int Delim { get; set; }
        public Boolean Required = false;
        public DDGrp() : base()
        {
            Delim = 0;
            NumFld = 0;
            Required = false;
        }
    }
}
