using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using QuickFix;
using QuickFix.Fields;
using System.Reflection;


namespace UnitTests
{
    public class MessageCrackerTests
    {
        private readonly SessionID _DummySessionID = new SessionID("a","b","c");
        
        class TheseMightBeHandlerMethods
        {
            // This is a handler.
            public void OnMessage(QuickFix.FIX42.News m, SessionID s) { }

            // These are NOT handlers because...

            // it's private
            private void OnMessage(QuickFix.FIX42.ListCancelRequest m, SessionID s) { }

            // name doesn't match convention
            public void NameIsWrong(QuickFix.FIX42.ListExecute m, SessionID s) { }

            // params count != 2
            public void OnMessage(QuickFix.FIX42.ListStatus m) { }
            public void OnMessage(QuickFix.FIX42.ListStatusRequest m, SessionID s, object o) { }

            // param types aren't correct
            public void OnMessage(object o, SessionID s) { }
            public void OnMessage(QuickFix.FIX42.ListStrikePrice m, object o) { }

            // return value isn't void
            public int OnMessage(QuickFix.FIX42.MassQuote m, SessionID s) { return 0; }
        }

        [Fact]
        public void IsHandlerMethod()
        {
            MethodInfo[] methods = typeof(TheseMightBeHandlerMethods).GetMethods();
            List<MethodInfo> handlers = new List<MethodInfo>();

            foreach (MethodInfo m in methods)
            {
                if (MessageCracker.IsHandlerMethod(m))
                {
                    handlers.Add(m);
                }
            }

            Assert.Single(handlers);
            Assert.Equal(typeof(QuickFix.FIX42.News), handlers[0].GetParameters()[0].ParameterType);
        }
        
        public class TestCracker : MessageCracker
        {
            public bool CrackedNews42 { get; set; }
            public bool CrackedNews44 { get; set; }

            public void OnMessage(QuickFix.FIX42.News msg, SessionID s) { CrackedNews42 = true; }
            public void OnMessage(QuickFix.FIX44.News msg, SessionID s) { CrackedNews44 = true; }
        }

        [Fact]
        public void GoldenPath()
        {
            MessageCracker mc = new TestCracker();
            TestCracker tc = mc as TestCracker;

            mc.Crack(new QuickFix.FIX42.News(), _DummySessionID);
            Assert.True(tc.CrackedNews42);
            Assert.False(tc.CrackedNews44);

            // reset and do the opposite
            tc.CrackedNews42 = false;

            mc.Crack(new QuickFix.FIX44.News(), _DummySessionID);
            Assert.False(tc.CrackedNews42);
            Assert.True(tc.CrackedNews44);
        }

        [Fact]
        public void UnsupportedMessage()
        {
            MessageCracker mc = new TestCracker();
            Assert.Throws<UnsupportedMessageType>(delegate { mc.Crack(new QuickFix.FIX42.Email(), _DummySessionID); });
            Assert.Throws<UnsupportedMessageType>(delegate { mc.Crack(new QuickFix.FIX43.News(), _DummySessionID); });
        }
    }
}
