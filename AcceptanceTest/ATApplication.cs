using QuickFix;

namespace AcceptanceTest
{
    public class ATApplication : Application
    {
        public override void OnMessage(Message message)
        {
            System.Console.WriteLine("FIXME - ATApplication.OnMessage not implemented! [" + message + "]");
        }
    }
}
