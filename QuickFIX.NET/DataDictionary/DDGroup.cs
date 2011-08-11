using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace QuickFix
{
    partial class DataDictionaryParser
    {
        private class DDFieldMap
        {
            public DDFieldMap()
            {
                Fields = new HashSet<int>();
                ReqFields = new HashSet<int>();
                FieldOrder = new List<int>();
                Groups = new Dictionary<int, DDFieldMap>();
            }

            public DDFieldMap(DDFieldMap src)
            {
                Fields = new HashSet<int>(src.Fields);
                ReqFields = new HashSet<int>(src.ReqFields);
                FieldOrder = new List<int>(src.FieldOrder);
                Groups = new Dictionary<int, DDFieldMap>(src.Groups);
            }

            public List<int> FieldOrder { get; set; }
            public HashSet<int> Fields { get; set; }
            public HashSet<int> ReqFields { get; set; }
            public Dictionary<int, DDFieldMap> Groups { get; set; }
        }

        private class DDGroup : DDFieldMap
        {
            public DDGroup()
                : base()
            { }

            public DDGroup(DDGroup src)
                : base(src)
            {
                this.Field = src.Field;
                this.Delim = src.Delim;
            }

            public int Field { get; set; }
            public int Delim { get; set; }
        }
    }
}
