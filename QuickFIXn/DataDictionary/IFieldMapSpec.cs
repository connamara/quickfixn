using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.DataDictionary
{
    public interface IFieldMapSpec
    {
        /// <summary>
        /// Returns true if this tag is for a group-counter field defined for this IFieldMapSpec
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        Boolean IsGroup(int tag);

        /// <summary>
        /// Returns true if this tag is for a field defined for this IFieldMapSpec
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        Boolean IsField(int tag);
        
        /// <summary>
        /// Get the IGroupSpec that corresponds to this group-counter tag
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        IGroupSpec GetGroupSpec(int tag);
    }
}
