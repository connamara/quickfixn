using System;

namespace QuickFix.DataDictionary
{
    public interface IGroupSpec : IFieldMapSpec
    {
        /// <summary>
        /// The tag of the delimiter field, i.e. the first field of each group member
        /// </summary>
        int Delim { get; set; }
    }
}
