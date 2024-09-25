using System;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// Represents a repeating field group within a message
    /// </summary>
    public class Group : FieldMap
    {
        /// <summary>
        /// Create a group with the specified count and delimiter fields.
        /// </summary>
        /// <param name="counterField">tag of the counter field</param>
        /// <param name="delim">delimiter field's tag (first field in the group)</param>
        public Group(int counterField, int delim)
            :base(fieldOrd: new[] { delim })
        {
            CounterField = counterField;
            Delim = delim;
        }

        /// <summary>
        /// Create a group with the specified count and delimiter fields and field ordering.
        /// </summary>
        /// <param name="counterField">tag of the counter field</param>
        /// <param name="delim">delimiter field's tag (first field in the group)</param>
        /// <param name="fieldOrd">the group's member tags in order</param>
        public Group(int counterField, int delim, int[] fieldOrd)
            :base(fieldOrd)
        {
            CounterField = counterField;
            Delim = delim;
        }

        /// <summary>
        /// returns a copy of src (it's only as deep as FieldMap implemented)
        /// </summary>
        /// <param name="src">the Group to copy</param>
        public Group(Group src)
            :base(src)
        {
            CounterField = src.CounterField;
            Delim = src.Delim;
        }

        public virtual Group Clone()
        {
            return new Group(this);
        }

        /// <summary>
        /// Tag of the group's counter field
        /// </summary>
        public int CounterField { get; }

        [Obsolete("Use CounterField instead")]
        public int Field => CounterField;

        /// <summary>
        /// Tag of the group's delimiter field (first field in the group)
        /// </summary>
        public int Delim { get; }

        /// <summary>
        /// Creates a FIX (ish) string representation of this FieldMap (does not change the object state)
        /// </summary>
        /// <returns></returns>
        public override string CalculateString() {
            return base.CalculateString(new StringBuilder(), FieldOrder ?? new[] { Delim });
        }

        public override string ToString()
        {
            return CalculateString();
        }
    }
}
