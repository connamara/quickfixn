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
    }
}
