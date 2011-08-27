using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickFix.Fields;
using System.Reflection;

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
            Type handlerType = messageHandler.GetType();

            MethodInfo[] methods = handlerType.GetMethods();
            foreach (MethodInfo m in methods)
            {
                if (IsHandlerMethod(m))
                {
                    // store it
                }
            }
        }

        //handler test:
        //    must be:
        //    * public
        //    * matches convention
        //    * 2 params
        //    * param 0 derives from message
        //    * param 1 is SessionID
        //    * returns void
        static public bool IsHandlerMethod(MethodInfo m)
        {
            return (m.IsPublic == true
                && m.Name.Equals("OnMessage")
                && m.GetParameters().Length == 2
                && m.GetParameters()[0].ParameterType.IsSubclassOf(typeof(QuickFix.Message))
                && typeof(QuickFix.SessionID).IsAssignableFrom(m.GetParameters()[1].ParameterType)
                && m.ReturnType == typeof(void));
        }



        public void Crack(Message message, SessionID sessionID)
        {
            // nothing
        }

    }
}
