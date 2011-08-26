using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;


namespace UnitTests
{
    [TestFixture]
    public class MessageCrackerTests
    {
        private readonly SessionID _DummySessionID = new SessionID("a","b","c");

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Teardown()
        {
        }


        public class TestCracker : MessageCracker
        {
            public bool CrackedNews42 { get; set; }
            public bool CrackedNews44 { get; set; }

            public void OnMessage(QuickFix.FIX42.News msg) { CrackedNews42 = true; }
            public void OnMessage(QuickFix.FIX44.News msg) { CrackedNews44 = true; }
        }

        [Test]
        [Ignore("not passing yet")]
        public void GoldenPath()
        {
            MessageCracker mc = new TestCracker();
            TestCracker tc = mc as TestCracker;

            mc.Crack(new QuickFix.FIX42.News(), _DummySessionID);
            Assert.IsTrue(tc.CrackedNews42);
            Assert.IsFalse(tc.CrackedNews44);

            // reset and do the opposite
            tc.CrackedNews42 = false;

            mc.Crack(new QuickFix.FIX44.News(), _DummySessionID);
            Assert.IsFalse(tc.CrackedNews42);
            Assert.IsTrue(tc.CrackedNews44);
        }
    }
}
