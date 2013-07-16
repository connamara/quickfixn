using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickFix.Fields;
using System.Reflection;
using System.Linq.Expressions;

namespace QuickFix
{
    /// <summary>
    /// Helper class for delegating message types for various FIX versions to
    /// type-safe OnMessage methods.
    /// </summary>
    public class MessageCracker
    {
        private readonly Dictionary<Type, Action<Message, SessionID>> _callCache = new Dictionary<Type, Action<Message, SessionID>>();

        /// <summary>
        /// When false messagess without proper OnMessage will throw UnsupportedException
        /// When true they are ignored
        /// </summary>
        public bool IgnoreUnhandledMessages { get; set; }

        /// <summary>
        /// Used when inheriting MessageCracker
        /// </summary>
        /// <param name="ignoreUnhandledMessages"></param>
        protected MessageCracker(bool ignoreUnhandledMessages = false)
        {
            IgnoreUnhandledMessages = ignoreUnhandledMessages;
            Initialize(this);
        }

        /// <summary>
        /// Used when using MessageCracker as a helper class
        /// </summary>
        /// <param name="messageHandler"></param>
        /// <param name="ignoreUnhandledMessages"></param>
        public MessageCracker(object messageHandler, bool ignoreUnhandledMessages = false)
        {
            if (messageHandler == null)
                throw new ArgumentNullException(nameof(messageHandler), nameof(messageHandler) + " cannot be null");

            IgnoreUnhandledMessages = ignoreUnhandledMessages;
            Initialize(messageHandler);
        }

        private void Initialize(object messageHandler)
        {
            Type handlerType = messageHandler.GetType();

            // Include private and protected methods
            // The MessageCracker shouldn't force the message handler (OnMessage methods) to be public
            var bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;

            MethodInfo[] methods = handlerType.GetMethods(bindingFlags);

            foreach (MethodInfo m in methods)
            {
                TryBuildCallCache(m, messageHandler);
            }
        }

        /// <summary>
        /// build  a complied expression tree - much faster than calling MethodInfo.Invoke
        /// </summary>
        /// <param name="m"></param>
        private void TryBuildCallCache(MethodInfo m, object messageHandler)
        {
            if (IsHandlerMethod(m))
            {
                var parameters = m.GetParameters();

                var expParamMessage = parameters[0];

                var expParamSessionId = parameters[1];

                var messageParam = Expression.Parameter(typeof(Message), "message");

                var sessionParam = Expression.Parameter(typeof(SessionID), "sessionID");

                var instance = Expression.Constant(messageHandler);

                var methodCall = Expression.Call(instance, m, Expression.Convert(messageParam, expParamMessage.ParameterType), Expression.Convert(sessionParam, expParamSessionId.ParameterType));

                var action = Expression.Lambda<Action<Message, SessionID>>(methodCall, messageParam, sessionParam).Compile();

                _callCache[expParamMessage.ParameterType] = action;

            }
        }

        public static bool IsHandlerMethod(MethodInfo m)
        {
            return (
                m.Name.Equals("OnMessage")
                && m.GetParameters().Length == 2
                && m.GetParameters()[0].ParameterType.IsSubclassOf(typeof(QuickFix.Message))
                && typeof(QuickFix.SessionID).IsAssignableFrom(m.GetParameters()[1].ParameterType)
                && m.ReturnType == typeof(void));
        }

        /// <summary>
        /// Process ("crack") a FIX message and call the registered handlers for that type, if any
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionID"></param>
        public void Crack(Message message, SessionID sessionID)
        {
            Type messageType = message.GetType();

            Action<Message, SessionID> onMessage = null;

            if (_callCache.TryGetValue(messageType, out onMessage))
            {
                onMessage(message, sessionID);
            }
            else
            {
                if (!IgnoreUnhandledMessages)
                {
                    throw new UnsupportedMessageType();
                }
            }
        }
    }
}
