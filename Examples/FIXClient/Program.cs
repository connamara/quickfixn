using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickFix;

namespace FIXClient {
    class Program {
        static void Main(string[] args) {
            string file = "client.cfg";

            try {
                QuickFix.SessionSettings settings = new QuickFix.SessionSettings(file);
                Client application = new Client();
                QuickFix.IMessageStoreFactory storeFactory = new QuickFix.FileStoreFactory(settings);
                //QuickFix.ILogFactory logFactory = new QuickFix.ScreenLogFactory(settings);
                QuickFix.Transport.SocketInitiator initiator = new QuickFix.Transport.SocketInitiator(application, storeFactory, settings);

                // this is a developer-test kludge.  do not emulate.
                application.MyInitiator = initiator;

                initiator.Start();
                application.Run();
                initiator.Stop();
            } catch (System.Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Environment.Exit(1);
        }
    }
}
