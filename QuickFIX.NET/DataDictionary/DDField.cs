using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.DataDictionary
{
    public class DDField
    {
        public DDField(int tag, String name, HashSet<String> enums, String fldType)
        {
            this.Tag = tag;
            this.Name = name;
            this.Enums = enums;
            this.FldType = fldType;
        }

        public int Tag;
        public String Name;
        public HashSet<String> Enums;
        public String FldType;
    }
}
