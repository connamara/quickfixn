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

        public abstract string toStringField();
        public abstract override string ToString();
        public abstract int getLength();
        public abstract int getTotal();
    }
}