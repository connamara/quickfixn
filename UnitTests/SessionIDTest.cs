using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class SessionIDTest
    {
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void TestNoLocationSubOrQualifierConstructor()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Assert.That(sessionID.BeginString, Is.EqualTo("FIX.4.2"));
            Assert.That(sessionID.SenderCompID, Is.EqualTo("SENDER"));
            Assert.That(sessionID.SenderSubID, Is.EqualTo(""));
            Assert.That(sessionID.SenderLocationID, Is.EqualTo(""));
            Assert.That(sessionID.TargetCompID, Is.EqualTo("TARGET"));
            Assert.That(sessionID.TargetSubID, Is.EqualTo(""));
            Assert.That(sessionID.TargetLocationID, Is.EqualTo(""));
            Assert.That(sessionID.SessionQualifier, Is.EqualTo(""));
        }

        [Test]
        public void TestNoLocationConstructor()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "TARGET", "TARGETSUB");
            Assert.That(sessionID.BeginString, Is.EqualTo("FIX.4.2"));
            Assert.That(sessionID.SenderCompID, Is.EqualTo("SENDER"));
            Assert.That(sessionID.SenderSubID, Is.EqualTo("SENDERSUB"));
            Assert.That(sessionID.SenderLocationID, Is.EqualTo(""));
            Assert.That(sessionID.TargetCompID, Is.EqualTo("TARGET"));
            Assert.That(sessionID.TargetSubID, Is.EqualTo("TARGETSUB"));
            Assert.That(sessionID.TargetLocationID, Is.EqualTo(""));
            Assert.That(sessionID.SessionQualifier, Is.EqualTo(""));
        }

        [Test]
        public void TestNoLocationOrSubConstructor()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET", "QUALIFIER");
            Assert.That(sessionID.BeginString, Is.EqualTo("FIX.4.2"));
            Assert.That(sessionID.SenderCompID, Is.EqualTo("SENDER"));
            Assert.That(sessionID.SenderSubID, Is.EqualTo(""));
            Assert.That(sessionID.SenderLocationID, Is.EqualTo(""));
            Assert.That(sessionID.TargetCompID, Is.EqualTo("TARGET"));
            Assert.That(sessionID.TargetSubID, Is.EqualTo(""));
            Assert.That(sessionID.TargetLocationID, Is.EqualTo(""));
            Assert.That(sessionID.SessionQualifier, Is.EqualTo("QUALIFIER"));
        }

        [Test]
        public void TestAllFieldsConstructor()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC", "QUALIFIER");
            Assert.That(sessionID.BeginString, Is.EqualTo("FIX.4.2"));
            Assert.That(sessionID.SenderCompID, Is.EqualTo("SENDER"));
            Assert.That(sessionID.SenderSubID, Is.EqualTo("SENDERSUB"));
            Assert.That(sessionID.SenderLocationID, Is.EqualTo("SENDERLOC"));
            Assert.That(sessionID.TargetCompID, Is.EqualTo("TARGET"));
            Assert.That(sessionID.TargetSubID, Is.EqualTo("TARGETSUB"));
            Assert.That(sessionID.TargetLocationID, Is.EqualTo("TARGETLOC"));
            Assert.That(sessionID.SessionQualifier, Is.EqualTo("QUALIFIER"));
        }

        [Test]
        public void TestToString()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Assert.That(sessionID.ToString(), Is.EqualTo("FIX.4.2:SENDER->TARGET"));

            sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET", "QUALIFIER");
            Assert.That(sessionID.ToString(), Is.EqualTo("FIX.4.2:SENDER->TARGET:QUALIFIER"));

            sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "TARGET", "TARGETSUB");
            Assert.That(sessionID.ToString(), Is.EqualTo("FIX.4.2:SENDER/SENDERSUB->TARGET/TARGETSUB"));

            sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC");
            Assert.That(sessionID.ToString(), Is.EqualTo("FIX.4.2:SENDER/SENDERSUB/SENDERLOC->TARGET/TARGETSUB/TARGETLOC"));

            sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC", "QUALIFIER");
            Assert.That(sessionID.ToString(), Is.EqualTo("FIX.4.2:SENDER/SENDERSUB/SENDERLOC->TARGET/TARGETSUB/TARGETLOC:QUALIFIER"));
        }
    }
}
