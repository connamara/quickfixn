using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// Interface for all field classes
    /// </summary>
    public abstract class IField
    {
        #region Properties
        public abstract int Tag { get; set; }
        #endregion

        /// <summary>
        /// returns full fix string: tag=val
        /// </summary>
        public abstract string toStringField();

        /// <summary>
        /// returns formatted string for fix
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