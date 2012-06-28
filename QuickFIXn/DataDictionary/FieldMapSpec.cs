using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.DataDictionary
{
    public interface IFieldMapSpec
    {
        Boolean IsGroup(int tag);
        Boolean IsField(int tag);
        IGroupSpec GetGroupSpec(int tag);
    }
}
