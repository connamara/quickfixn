using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuickFix;

namespace Examples.FixHub
{
    public class FixHub : IApplication
    {
        public void ToAdmin(Message message, SessionID sessionID)
        {
            
        }

        public void FromAdmin(Message message, SessionID sessionID)
        {
            
        }

        public void ToApp(Message message, SessionID sessionId)
        {
            
        }

        public void FromApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("Message: " + message.ToString());

            string deliverTo = message.Header.GetString(128);
            SessionID dSession = new SessionID("FIX.4.2", "LSEHUB", deliverTo);
            Session.SendToTarget(message, dSession);
        }

        public void OnCreate(SessionID sessionID)
        {
            Console.WriteLine("Created:" + sessionID.ToString());
        }

        public void OnLogout(SessionID sessionID)
        {
            Console.WriteLine("OnLogout:" + sessionID.ToString());
        }

        public void OnLogon(SessionID sessionID)
        {
            Console.WriteLine("OnLogon:" + sessionID.ToString());
        }
    }
}
