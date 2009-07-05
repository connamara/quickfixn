using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET
{
    partial class DataDictionary
    {
        private sealed class MessageFieldEntry
        {
            public MessageFieldEntry(string name, bool req)
            {
                Name = name;
                Required = req;
            }
            public string Name { get; set; }
            public bool Required { get; set; }
        }
    }
}
