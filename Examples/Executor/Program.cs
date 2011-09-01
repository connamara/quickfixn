using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix;

namespace Executor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("usage: Executor CONFIG_FILENAME");
                System.Environment.Exit(2);
            }

            try
            {
                SessionSettings settings = new SessionSettings(args[0]);
                Application executorApp = new Executor();
                MessageStoreFactory storeFactory = new FileStoreFactory(settings);
                LogFactory logFactory = new ScreenLogFactory(settings);
                ThreadedSocketAcceptor acceptor = new ThreadedSocketAcceptor(executorApp, storeFactory, settings, logFactory);

                acceptor.Start();
                Console.WriteLine("press <enter> to quit");
                Console.Read();
                acceptor.Stop();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("FATAL ERROR: " + e.Message);
                Console.WriteLine(e.ToString());
            }
        }
    }
}
