using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuickFix;

namespace Examples.FixHub
{
    class Program
    {
        static void Main(string[] args)
        {
            SessionSettings settings = new SessionSettings("ini.cfg");
            IApplication fixHub = new FixHub();
            IMessageStoreFactory storeFactory = new FileStoreFactory(settings);
            ILogFactory logFactory = new FileLogFactory(settings);
            ThreadedSocketAcceptor acceptor = new ThreadedSocketAcceptor(fixHub, storeFactory, settings, logFactory);
            
            acceptor.Start();
            Console.ReadKey();
            acceptor.Stop();

            
        }
    }
}
