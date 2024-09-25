using System;
using QuickFix;

namespace SimpleAcceptor
{
    /// <summary>
    /// Just a simple server that will let you connect to it and ignore any
    /// application-level messages you send to it.
    /// Note that this app is *NOT* a message cracker.
    /// </summary>

    public class SimpleAcceptorApp : /*QuickFix.MessageCracker,*/ QuickFix.IApplication
    {
        public void FromApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("IN:  " + message);
            //Crack(message, sessionID);
        }

        public void ToApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("OUT: " + message);
        }

        public void FromAdmin(Message message, SessionID sessionID) 
        {
            Console.WriteLine("IN:  " + message);
        }

        public void ToAdmin(Message message, SessionID sessionID)
        {
            Console.WriteLine("OUT:  " + message);
        }

        public void OnCreate(SessionID sessionID) { }
        public void OnLogout(SessionID sessionID) { }
        public void OnLogon(SessionID sessionID) { }
    }
}
