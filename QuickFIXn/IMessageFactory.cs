using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// Used by Session to create a Message of the appropriate type.
    /// </summary>
    public interface IMessageFactory
    {
        /// <summary>
        /// Creates a message for a specified type and FIX version
        /// </summary>
        /// <param name="beginString">the FIX version (e.g. "FIX.4.2")</param>
        /// <param name="msgType">the FIX message type (e.g. "D" for a NewOrderSingle)</param>
        /// <returns>a message instance of proper derived type</returns>
        Message Create(string beginString, string msgType);

        /// <summary>
        /// Creates a group for the specified parent message type and
        /// for the fields with the corresponding field ID
        /// </summary>
        /// <param name="beginString">the FIX version (e.g. "FIX.4.2")</param>
        /// <param name="msgType">message type of the enclosing message (e.g. "D" for a NewOrderSingle</param>
        /// <param name="groupCounterTag">the tag of the group's counter field</param>
        /// <returns>group, or null if the group can't be created</returns>
        Group Create(string beginString, string msgType, int groupCounterTag);


        /// <summary>
        /// Returns the default dictionary that generated the concrete MessageFactory.
        /// Or null if doesn't exist.
        /// </summary>
        DataDictionary.DataDictionary DataDictionary { get; }

        /// <summary>
        /// An array of FIX versions suported by this message factory (e.g. "FIX.4.2", "FIX.4.4", etc.)
        /// </summary>
        FIXVersion[] SupportedFIXVersions { get; }
    }

    public class FIXVersion
    {
        public static readonly FIXVersion FIX40 = new FIXVersion(FixValues.BeginString.FIX40, null);
        public static readonly FIXVersion FIX41 = new FIXVersion(FixValues.BeginString.FIX41, null);
        public static readonly FIXVersion FIX42 = new FIXVersion(FixValues.BeginString.FIX42, null);
        public static readonly FIXVersion FIX43 = new FIXVersion(FixValues.BeginString.FIX43, null);
        public static readonly FIXVersion FIX44 = new FIXVersion(FixValues.BeginString.FIX44, null);
        public static readonly FIXVersion FIX50 = new FIXVersion(FixValues.BeginString.FIXT11, FixValues.ApplVerID.FIX50);
        public static readonly FIXVersion FIX50SP1 = new FIXVersion(FixValues.BeginString.FIXT11, FixValues.ApplVerID.FIX50SP1);
        public static readonly FIXVersion FIX50SP2 = new FIXVersion(FixValues.BeginString.FIXT11, FixValues.ApplVerID.FIX50SP2);

        private FIXVersion(string beginString, string appVerID)
        {
            BeginString = beginString;
            AppVerID = appVerID;
        }

        public string BeginString { get; private set; }
        public string AppVerID { get; private set; }
        public bool IsFIXT { get { return AppVerID != null; } } 
    }
}
