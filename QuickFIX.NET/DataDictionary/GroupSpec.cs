using System;

namespace QuickFix.DataDictionary
{
    public interface IGroupSpec
    {
        Boolean IsGroup(int tag);
        Boolean IsField(int tag);
        int Delim { get; set; }
    }
}
