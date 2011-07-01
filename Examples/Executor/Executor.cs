using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Examples
{
    public class Executor : QuickFix.Application
    {
        #region QuickFix.Application Methods

        public override void OnMessage(Message message)
        {
            Console.WriteLine("OnMessage: " + message);
        }

        #endregion

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
                Console.WriteLine(e.Message);
            }
        }
    }
}