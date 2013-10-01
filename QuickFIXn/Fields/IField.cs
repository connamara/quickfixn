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
		/// <remarks>
		/// Uses the default UTF-8 encoding.
		/// </remarks>
		[Obsolete("Use the version that takes an encoding as well.")]
		public abstract int getLength();

        /// <summary>
        /// length of formatted field (including tag=val\001)
        /// </summary>
		/// <param name="encoding">The encoding to use for calculating the length of the formatted field.</param>
        public abstract int getLength(Encoding encoding);

		/// <summary>
		/// checksum
		/// </summary>
		/// <remarks>
		/// Uses the default UTF-8 encoding.
		/// </remarks>
		[Obsolete("Use the version that takes an encoding as well.")]
		public abstract int getTotal();

        /// <summary>
        /// checksum
		/// </summary>
		/// <param name="encoding">The encoding to use for calculating the checksum.</param>
		public abstract int getTotal(Encoding encoding);
    }
}