using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix;
using QuickFix.Transport;

namespace SimpleAcceptor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("usage: SimpleAcceptor CONFIG_FILENAME");
                System.Environment.Exit(2);
            }

            try
            {
                SessionSettings settings = new SessionSettings(args[0]);
                Application app = new SimpleAcceptorApp();
                MessageStoreFactory storeFactory = new FileStoreFactory(settings);
                LogFactory logFactory = new FileLogFactory(settings);
                Acceptor acceptor = new ThreadedSocketAcceptor(app, storeFactory, settings, logFactory);

                acceptor.Start();
                Console.WriteLine("press <enter> to quit");
                Console.Read();
                acceptor.Stop();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("==FATAL ERROR==");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
