using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq.Expressions;

namespace QuickFix
{
    /// <summary>
    /// Helper class for delegating message types for various FIX versions to
    /// type-safe OnMessage methods.
    /// </summary>
    public abstract class MessageCracker
    {
        private readonly Dictionary<Type, Action<Message, SessionID>> _callCache = new ();

        protected MessageCracker()
        {
            Initialize(this);
        }

        private void Initialize(object messageHandler)
        {
            Type handlerType = messageHandler.GetType();

            MethodInfo[] methods = handlerType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo m in methods)
            {
                TryBuildCallCache(m);
            }
        }

        /// <summary>
        /// build  a complied expression tree - much faster than calling MethodInfo.Invoke
        /// </summary>
        /// <param name="m"></param>
        private void TryBuildCallCache(MethodInfo m)
        {
            if (IsHandlerMethod(m))
            {
                var parameters = m.GetParameters();
                var expParamMessage = parameters[0];
                var expParamSessionId = parameters[1];
                var messageParam = Expression.Parameter(typeof(Message), "message");
                var sessionParam = Expression.Parameter(typeof(SessionID), "sessionID");
                var instance = Expression.Constant(this);
                var methodCall = Expression.Call(instance, m, Expression.Convert(messageParam, expParamMessage.ParameterType), Expression.Convert(sessionParam, expParamSessionId.ParameterType));
                var action = Expression.Lambda<Action<Message, SessionID>>(methodCall, messageParam, sessionParam).Compile();
                _callCache[expParamMessage.ParameterType] = action;
            }
        }


        public static bool IsHandlerMethod(MethodInfo m)
        {
            return m.IsPublic
                   && m.Name.Equals("OnMessage")
                   && m.GetParameters().Length == 2
                   && m.GetParameters()[0].ParameterType.IsSubclassOf(typeof(Message))
                   && typeof(SessionID).IsAssignableFrom(m.GetParameters()[1].ParameterType)
                   && m.ReturnType == typeof(void);
        }


        /// <summary>
        /// Process ("crack") a FIX message and call the registered handlers for that type, if any
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionId"></param>
        public void Crack(Message message, SessionID sessionId)
        {
            Type messageType = message.GetType();

            if (_callCache.TryGetValue(messageType, out Action<Message, SessionID>? onMessage))
            {
                onMessage(message, sessionId);
            }
            else
            {
                throw new UnsupportedMessageType();
            }
        }
    }
}
