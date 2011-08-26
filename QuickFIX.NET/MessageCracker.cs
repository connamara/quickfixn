using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickFix.Fields;

namespace QuickFix
{
    public abstract class MessageCracker
    {
        public MessageCracker()
        {
            initialize(this);
        }

        private void initialize(Object messageHandler)
        {
            Type handerType = messageHandler.GetType();
        }

        public void Crack(Message message, SessionID sessionID)
        {
            // nothing
        }

    }
}
