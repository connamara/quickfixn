using QuickFix;

namespace AcceptanceTest
{
    public class ATRunner
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("usage: AcceptanceTest CONFIG_FILENAME");
                System.Environment.Exit(2);
            }

            try
            {
                SessionSettings settings = new SessionSettings(args[0]); 
                Application testApp = new ATApplication();
                MessageStoreFactory storeFactory = new FileStoreFactory(settings);
                LogFactory logFactory = null;
                if (settings.Get().Has("Verbose") && settings.Get().GetBool("Verbose"))
                    logFactory = new FileLogFactory(settings); //ScreenLogFactory(true, true, true);
                ThreadedSocketAcceptor acceptor = new ThreadedSocketAcceptor(testApp, storeFactory, settings, logFactory);

                acceptor.Start();
                while (true)
                {
                    System.Console.WriteLine("o hai");
                    System.Threading.Thread.Sleep(1000);
                }
                //acceptor.Stop();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
