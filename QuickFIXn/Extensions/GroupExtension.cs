using System;
using System.Collections.Generic;

namespace QuickFix.Extensions
{
    public static class GroupExtension
    {
        /// <summary>
        /// Gets an instance of enumerable groups 
        /// </summary>
        /// <typeparam name="TGroup">A repeating field group within a message</typeparam>
        /// <param name="message">Field container used by messages, groups, and composites</param>
        /// <param name="noGroupTag">The FIX group tag</param>
        /// <returns>retrieved enumerable groups</returns>
        /// <exception cref="FieldNotFoundException"/>
        public static IEnumerable<TGroup> ReadGroups<TGroup>(this FieldMap message, int noGroupTag) where TGroup : Group //, new()
        {
            if (message.IsSetField(noGroupTag) && message.GetGroupTags().Contains(noGroupTag))
            {
                int grpCount = message.GetInt(noGroupTag);

                for (int grpIndex = 1; grpIndex <= grpCount; grpIndex += 1)
                {
                    Group group = message.GetGroup(grpIndex, noGroupTag);
                    if(group is not TGroup tgroup)
                        throw new InvalidCastException($"Can't cast {group.GetType()} to {typeof(TGroup)}");
                    yield return tgroup;
                }
            }
        }
    }
}
