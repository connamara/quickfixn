using System;
using Microsoft.Extensions.Logging;
using QuickFix;
using QuickFix.Logger;
using QuickFix.Store;

namespace Executor
{
    class Program
    {
        private const string HttpServerPrefix = "http://127.0.0.1:5080/";
        
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Console.WriteLine("This is only an example program, meant to be used with the TradeClient example.");
            Console.WriteLine("=============");

            if (args.Length != 1)
            {
                Console.WriteLine("usage: Executor CONFIG_FILENAME");
                System.Environment.Exit(2);
            }

            try
            {
                SessionSettings settings = new SessionSettings(args[0]);
                IApplication executorApp = new Executor();
                IMessageStoreFactory storeFactory = new FileStoreFactory(settings);
                using var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.SetMinimumLevel(LogLevel.Trace);
                    builder.AddProvider(new ScreenLoggerProvider(settings));
                    builder.AddProvider(new FileLoggerProvider(settings));
                });
                ThreadedSocketAcceptor acceptor =
                    new ThreadedSocketAcceptor(executorApp, storeFactory, settings, loggerFactory);
                HttpServer srv = new HttpServer(HttpServerPrefix, settings);
                
                acceptor.Start();
                srv.Start();
                
                Console.WriteLine("View Executor status: "+HttpServerPrefix);
                Console.WriteLine("press <enter> to quit");
                Console.Read();
                
                srv.Stop();
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
