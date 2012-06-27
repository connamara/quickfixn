using System;

namespace QuickFix.DataDictionary
{
    public interface IGroupSpec : IFieldMapSpec
    {
        int Delim { get; set; }
    }
}
