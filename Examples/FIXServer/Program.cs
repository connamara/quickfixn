using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickFix;

namespace FIXServer {
    class Program {
        static void Main(string[] args) {
            string file = "server.cfg";

            SessionSettings settings = new SessionSettings(file);
            IApplication executorApp = new Server();
            IMessageStoreFactory storeFactory = new FileStoreFactory(settings);
            ThreadedSocketAcceptor acceptor = new ThreadedSocketAcceptor(executorApp, storeFactory, settings);

            acceptor.Start();
            Console.WriteLine("press <enter> to quit");
            Console.Read();
            acceptor.Stop();
        }
    }
}
