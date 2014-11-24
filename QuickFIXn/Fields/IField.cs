using System;
using System.Text;

namespace QuickFix.Fields
{
    /// <summary>
    /// Interface for all field classes
    /// </summary>
    public abstract class IField
    {
        #region Properties
        public abstract int Tag { get; set; }

        /// <summary>
        /// True iff the value if of length 0.
        /// </summary>
        public abstract bool Empty { get; }
        #endregion

        /// <summary>
        /// returns full fix string: tag=val
        /// </summary>
        public abstract void AppendField(StringBuilder sb);
       
        /// <summary>
        /// returns field value formatted for fix
        /// </summary>
        public abstract string ValueToString();

        /// <summary>
        /// returns formatted string for debug output
        /// </summary>
        public abstract override string ToString();

        /// <summary>
        /// length of formatted field (including tag=val\001)
        /// </summary>
        public abstract int getLength();

        /// <summary>
        /// checksum
        /// </summary>
        public abstract int getTotal();
    }
}