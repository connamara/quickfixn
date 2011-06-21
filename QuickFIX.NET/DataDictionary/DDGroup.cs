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
            public List<int> FieldOrder { get; set; }
            public HashSet<int> Fields { get; set; }
            public HashSet<int> ReqFields { get; set; }
            public Dictionary<int, DDFieldMap> Groups { get; set; }
        }

        private class DDGroup : DDFieldMap
        {
            public DDGroup()
                : base()
            {
            }
            public int Field { get; set; }
            public int Delim { get; set; }
        }
    }
}
