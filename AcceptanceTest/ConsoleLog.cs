using System;
using QuickFix;

namespace AcceptanceTest
{
    class ConsoleLog : ILog
    {
        public void OnIncoming(string msg) { }

        public void OnOutgoing(string msg) { }

        public void OnEvent(string s)
        {
            Console.WriteLine(s);
        }

        public void Clear() { }
        public void Dispose() { }
    }
}