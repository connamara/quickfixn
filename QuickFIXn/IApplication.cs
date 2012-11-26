
namespace QuickFix
{
    /// <summary>
    /// (Renamed per naming convention.)
    /// </summary>
    [System.Obsolete("Use IApplication instead.")]
    public interface Application : IApplication { }

    /// <summary>
    /// This is the primary interface for processing session messages.
    /// </summary>
    public interface IApplication
    {
        /// <summary>
        /// This callback provides you with a peek at the administrative messages
        /// that are being sent from your FIX engine to the counter party. This is
        /// normally not useful for an application however it is provided for any
        /// logging you may wish to do. You may add fields in an adminstrative
        /// message before it is sent.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionID"></param>
        void ToAdmin(Message message, SessionID sessionID);

        /// <summary>
        /// This callback notifies you when an administrative message is sent from a
        /// counterparty to your FIX engine. This can be usefull for doing extra
        /// validation on logon messages such as for checking passwords. Throwing a
        /// RejectLogon exception will disconnect the counterparty.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionID"></param>
        /// <exception cref="RejectLogon">throw this to reject a login</exception>
        void FromAdmin(Message message, SessionID sessionID);

        /// <summary>
        /// This is a callback for application messages that you are sending to a
        /// counterparty. If you throw a DoNotSend exception in this function, the
        /// application will not send the message. This is mostly useful if the
        /// application has been asked to resend a message such as an order that is
        /// no longer relevant for the current market. Messages that are being resent
        /// are marked with the PossDupFlag in the header set to true; If a DoNotSend
        /// exception is thrown and the flag is set to true, a sequence reset will be
        /// sent in place of the message. If it is set to false, the message will
        /// simply not be sent. You may add fields before an application message
        /// before it is sent out.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionId"></param>
        /// <exception cref="DoNotSend">throw this to abort sending the message</exception>
        void ToApp(Message message, SessionID sessionId);

        /// <summary>
        /// This callback receives messages for the application. This is one of the
        /// core entry points for your FIX application. Every application level
        /// request will come through here. If, for example, your application is a
        /// sell-side OMS, this is where you will get your new order requests. If you
        /// were a buy side, you would get your execution reports here. If a
        /// FieldNotFound exception is thrown, the counterparty will receive a reject
        /// indicating a conditionally required field is missing. The Message class
        /// will throw this exception when trying to retrieve a missing field, so you
        /// will rarely need the throw this explicitly. You can also throw an
        /// UnsupportedMessageType exception. This will result in the counterparty
        /// getting a business reject informing them your application cannot process
        /// those types of messages. An IncorrectTagValue can also be thrown if a
        /// field contains a value that is out of range or you do not support.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionID"></param>
        /// <exception cref="FieldNotFoundException">throw this to notify counterparty is missing a required field</exception>
        /// <exception cref="UnsupportedMessageType">throw this to notify counterparty we can't process this message</exception>
        /// <exception cref="IncorrectTagValue">throw this to notify counterparty that a field contains an incorrect value</exception>
        void FromApp(Message message, SessionID sessionID);

        /// <summary>
        /// This method is called when quickfix creates a new session. A session
        /// comes into and remains in existence for the life of the application.
        /// Sessions exist whether or not a counter party is connected to it. As soon
        /// as a session is created, you can begin sending messages to it. If no one
        /// is logged on, the messages will be sent at the time a connection is
        /// established with the counterparty.
        /// </summary>
        /// <param name="sessionID"></param>
        void OnCreate(SessionID sessionID);

        /// <summary>
        /// This callback notifies you when an FIX session is no longer online. This
        /// could happen during a normal logout exchange or because of a forced
        /// termination or a loss of network connection.
        /// </summary>
        /// <param name="sessionID"></param>
        void OnLogout(SessionID sessionID);

        /// <summary>
        /// This callback notifies you when a valid logon has been established with a
        /// counter party. This is called when a connection has been established and
        /// the FIX logon process has completed with both parties exchanging valid
        /// logon messages.
        /// </summary>
        /// <param name="sessionID"></param>
        void OnLogon(SessionID sessionID);
    }
}
