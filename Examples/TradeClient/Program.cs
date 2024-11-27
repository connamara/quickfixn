using System;
using Microsoft.Extensions.Logging;
using QuickFix.Logger;
using QuickFix.Store;

namespace TradeClient
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Console.WriteLine("This is only an example program, meant to run against the Executor or SimpleAcceptor example programs.");
            Console.WriteLine();
            Console.WriteLine("                                                    ! ! !");
            Console.WriteLine("              DO NOT USE THIS ON A COMMERCIAL FIX INTERFACE!  It won't work and it's a bad idea!");
            Console.WriteLine("                                                    ! ! !");
            Console.WriteLine();
            Console.WriteLine("=============");

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
                IMessageStoreFactory storeFactory = new FileStoreFactory(settings);
                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddProvider(new ScreenLoggerProvider(settings));
                    // builder.AddProvider(new FileLogProvider(settings));
                });
                QuickFix.Transport.SocketInitiator initiator = new QuickFix.Transport.SocketInitiator(application, storeFactory, settings, loggerFactory);

                // this is a developer-test kludge.  do not emulate.
                application.MyInitiator = initiator;

                initiator.Start();
                application.Run();
                initiator.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Environment.Exit(1);
        }
    }
}
