using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("usage: TradeClient.exe CONFIG_FILENAME");
                System.Environment.Exit(2);
            }

            string file = args[0];

            try
            {
                QuickFix.SessionSettings settings = new QuickFix.SessionSettings(file);
                TradeClientApp application = new TradeClientApp();
                QuickFix.MessageStoreFactory storeFactory = new QuickFix.FileStoreFactory(settings);
                QuickFix.LogFactory logFactory = new QuickFix.ScreenLogFactory(settings);
                QuickFix.Transport.SocketInitiator initiator = new QuickFix.Transport.SocketInitiator(application, storeFactory, settings, logFactory);
                initiator.Start();
                application.Run();
                initiator.Stop();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Environment.Exit(1);
            }
        }
    }
}
