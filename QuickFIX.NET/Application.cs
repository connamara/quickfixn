
namespace QuickFix
{
    public interface Application
    {
        /// <summary>
        /// Notification of admin message being sent to target
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionID"></param>
        void ToAdmin(Message message, SessionID sessionID);

        /// <summary>
        /// Notification of admin message being received from target
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionID"></param>
        void FromAdmin(Message message, SessionID sessionID);

        /// <summary>
        /// Notification of app message being sent to target
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionId"></param>
        /// <exception cref="DoNotSend">throw this to abort sending the message</exception>
        void ToApp(Message message, SessionID sessionId);

        /// <summary>
        /// Notification of app message being received from target
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionID"></param>
        void FromApp(Message message, SessionID sessionID);

        /// <summary>
        /// Notification of a session being created
        /// </summary>
        /// <param name="sessionID"></param>
        void OnCreate(SessionID sessionID);

        /// <summary>
        /// Notification of a session logging off or disconnecting
        /// </summary>
        /// <param name="sessionID"></param>
        void OnLogout(SessionID sessionID);

        /// <summary>
        /// Notification of a session logging successfully logging on
        /// </summary>
        /// <param name="sessionID"></param>
        void OnLogon(SessionID sessionID);
    }
}
