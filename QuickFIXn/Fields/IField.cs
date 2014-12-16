using System;
using System.IO;
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
        public abstract void AppendField(MemoryStream ms);
       
        /// <summary>
        /// returns field value formatted for fix
        /// </summary>
        public abstract string ValueToString();

        /// <summary>
        /// returns formatted string for debug output
        /// </summary>
        public abstract override string ToString();

    }
}