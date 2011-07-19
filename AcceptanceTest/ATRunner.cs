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
                //LogFactory logFactory = new ScreenLogFactory(settings);
                ThreadedSocketAcceptor acceptor = new ThreadedSocketAcceptor(testApp, storeFactory, settings);

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
