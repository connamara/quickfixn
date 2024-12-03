using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;
using System.Reflection;

namespace UnitTests
{
    [TestFixture]
    public class MessageCrackerTests
    {
        private readonly SessionID _dummySessionId = new ("a","b","c");

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Teardown()
        {
        }


        class TheseMightBeHandlerMethods
        {
            // These are handlers.
            public void OnMessage(QuickFix.FIX42.News m, SessionID s) { }
            public void OnMessage(QuickFix.FIXT11.Logon m, SessionID s) { }

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

        [Test]
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

            Assert.That(handlers.Count, Is.EqualTo(2));
            Assert.That(typeof(QuickFix.FIX42.News), Is.EqualTo(handlers[0].GetParameters()[0].ParameterType));
            Assert.That(typeof(QuickFix.FIXT11.Logon), Is.EqualTo(handlers[1].GetParameters()[0].ParameterType));
        }



        public class TestCracker : MessageCracker
        {
            public bool CrackedNews42 { get; set; }
            public bool CrackedNews44 { get; set; }
            public bool CrackedLogonFIXT11 { get; set; }

            public void OnMessage(QuickFix.FIX42.News msg, SessionID s) { CrackedNews42 = true; }
            public void OnMessage(QuickFix.FIX44.News msg, SessionID s) { CrackedNews44 = true; }
            public void OnMessage(QuickFix.FIXT11.Logon msg, SessionID s) { CrackedLogonFIXT11 = true; }
        }

        [Test]
        public void GoldenPath()
        {
            MessageCracker mc = new TestCracker();
            TestCracker tc = (mc as TestCracker)!;

            mc.Crack(new QuickFix.FIX42.News(), _dummySessionId);
            Assert.That(tc.CrackedNews42, Is.True);
            Assert.That(tc.CrackedNews44, Is.False);

            // reset and do the opposite
            tc.CrackedNews42 = false;

            mc.Crack(new QuickFix.FIX44.News(), _dummySessionId);
            Assert.That(tc.CrackedNews42, Is.False);
            Assert.That(tc.CrackedNews44, Is.True);

            Assert.That(tc.CrackedLogonFIXT11, Is.False);
            mc.Crack(new QuickFix.FIXT11.Logon(), _dummySessionId);
            Assert.That(tc.CrackedLogonFIXT11, Is.True);
        }

        [Test]
        public void UnsupportedMessage()
        {
            MessageCracker mc = new TestCracker();
            Assert.Throws<UnsupportedMessageType>(delegate { mc.Crack(new QuickFix.FIX42.Email(), _dummySessionId); });
            Assert.Throws<UnsupportedMessageType>(delegate { mc.Crack(new QuickFix.FIX43.News(), _dummySessionId); });
        }
    }
}
