using QuickFix;
using Xunit;

namespace UnitTests
{
    public class SessionIDTest
    {
        [Fact]
        public void TestNoLocationSubOrQualifierConstructor()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Assert.Equal("FIX.4.2", sessionID.BeginString);
            Assert.Equal("SENDER", sessionID.SenderCompID);
            Assert.Equal("", sessionID.SenderSubID);
            Assert.Equal("", sessionID.SenderLocationID);
            Assert.Equal("TARGET", sessionID.TargetCompID);
            Assert.Equal("", sessionID.TargetSubID);
            Assert.Equal("", sessionID.TargetLocationID);
            Assert.Equal("", sessionID.SessionQualifier);
        }

        [Fact]
        public void TestNoLocationConstructor()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "TARGET", "TARGETSUB");
            Assert.Equal("FIX.4.2", sessionID.BeginString);
            Assert.Equal("SENDER", sessionID.SenderCompID);
            Assert.Equal("SENDERSUB", sessionID.SenderSubID);
            Assert.Equal("", sessionID.SenderLocationID);
            Assert.Equal("TARGET", sessionID.TargetCompID);
            Assert.Equal("TARGETSUB", sessionID.TargetSubID);
            Assert.Equal("", sessionID.TargetLocationID);
            Assert.Equal("", sessionID.SessionQualifier);
        }

        [Fact]
        public void TestNoLocationOrSubConstructor()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET", "QUALIFIER");
            Assert.Equal("FIX.4.2", sessionID.BeginString);
            Assert.Equal("SENDER", sessionID.SenderCompID);
            Assert.Equal("", sessionID.SenderSubID);
            Assert.Equal("", sessionID.SenderLocationID);
            Assert.Equal("TARGET", sessionID.TargetCompID);
            Assert.Equal("", sessionID.TargetSubID);
            Assert.Equal("", sessionID.TargetLocationID);
            Assert.Equal("QUALIFIER", sessionID.SessionQualifier);
        }

        [Fact]
        public void TestAllFieldsConstructor()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC", "QUALIFIER");
            Assert.Equal("FIX.4.2", sessionID.BeginString);
            Assert.Equal("SENDER", sessionID.SenderCompID);
            Assert.Equal("SENDERSUB", sessionID.SenderSubID);
            Assert.Equal("SENDERLOC", sessionID.SenderLocationID);
            Assert.Equal("TARGET", sessionID.TargetCompID);
            Assert.Equal("TARGETSUB", sessionID.TargetSubID);
            Assert.Equal("TARGETLOC", sessionID.TargetLocationID);
            Assert.Equal("QUALIFIER", sessionID.SessionQualifier);
        }

        [Fact]
        public void TestToString()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Assert.Equal("FIX.4.2:SENDER->TARGET", sessionID.ToString());

            sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET", "QUALIFIER");
            Assert.Equal("FIX.4.2:SENDER->TARGET:QUALIFIER", sessionID.ToString());

            sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "TARGET", "TARGETSUB");
            Assert.Equal("FIX.4.2:SENDER/SENDERSUB->TARGET/TARGETSUB", sessionID.ToString());

            sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC");
            Assert.Equal("FIX.4.2:SENDER/SENDERSUB/SENDERLOC->TARGET/TARGETSUB/TARGETLOC", sessionID.ToString());

            sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC", "QUALIFIER");
            Assert.Equal("FIX.4.2:SENDER/SENDERSUB/SENDERLOC->TARGET/TARGETSUB/TARGETLOC:QUALIFIER", sessionID.ToString());
        }
    }
}
