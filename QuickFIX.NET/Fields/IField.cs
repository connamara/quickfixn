using System;

namespace QuickFIX.NET.Fields
{
    /// <summary>
    /// Interface for all field classes
    /// </summary>
    public interface IField
    {

        #region Properties
        int Tag { get; set; }
        #endregion

        string toStringField();
        string ToString();
        int getLength();
        int getTotal();
    }
}