using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class SessionStateTest
    {
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void TimedOut()
        {
            int now = 1;
            int lastReceivedTime = now;
            int heartBtIntMillis = 60 * 1000;

            now += heartBtIntMillis;
            Assert.False(SessionState.TimedOut(now, heartBtIntMillis, lastReceivedTime));
            now += heartBtIntMillis;
            Assert.False(SessionState.TimedOut(now, heartBtIntMillis, lastReceivedTime));
            now += heartBtIntMillis;
            Assert.True(SessionState.TimedOut(now, heartBtIntMillis, lastReceivedTime));
        }

        [Test]
        public void LogoutTimedOut()
        {
            int now = 1;
            bool sentLogout = true;
            int logoutTimeout = 2 * 1000;
            int lastSentTime = now;

            now += 1000;
            Assert.False(SessionState.LogoutTimedOut(now, sentLogout, logoutTimeout, lastSentTime));
            now += 1000;
            Assert.True(SessionState.LogoutTimedOut(now, sentLogout, logoutTimeout, lastSentTime));
           
            sentLogout = false; 
            Assert.False(SessionState.LogoutTimedOut(now, sentLogout, logoutTimeout, lastSentTime));
        }

        [Test]
        public void NeedTestRequest()
        {
            int now = 1;
            int lastReceivedTime = now;
            int heartBtIntMillis = 30 * 1000;
            int testRequestCounter = 0;

            //elapsedTickCount >= (1.2 * ((testRequestCounter + 1) * heartBtIntMillis))

            now += heartBtIntMillis;
            Assert.False(SessionState.NeedTestRequest(now, heartBtIntMillis, lastReceivedTime, testRequestCounter));
            now += heartBtIntMillis;
            Assert.True(SessionState.NeedTestRequest(now, heartBtIntMillis, lastReceivedTime, testRequestCounter));

            testRequestCounter += 1;
            Assert.False(SessionState.NeedTestRequest(now, heartBtIntMillis, lastReceivedTime, testRequestCounter));
            now += heartBtIntMillis;
            Assert.True(SessionState.NeedTestRequest(now, heartBtIntMillis, lastReceivedTime, testRequestCounter));

        }

        [Test]
        public void NeedHeartbeat()
        {
            int now = 1;
            int lastSentTime = now;
            int heartBtIntMillis = 60 * 1000;
            int testRequestCounter = 0;

            now += (heartBtIntMillis / 3);
            Assert.False(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
            now += (heartBtIntMillis / 3);
            Assert.False(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
            now += (heartBtIntMillis / 2);
            Assert.True(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));

            testRequestCounter = 1;
            Assert.False(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
            now += (2 * heartBtIntMillis);
            Assert.False(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
            testRequestCounter = 0;
            Assert.True(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
        }

        [Test]
        public void WithinHeartbeat()
        {
            int now = 1;
            int lastSentTime = now;
            int lastReceivedTime = now;
            int heartBtIntMillis = 60 * 1000;

            now += (heartBtIntMillis - 1);
            Assert.True(SessionState.WithinHeartbeat(now, heartBtIntMillis, lastSentTime, lastReceivedTime));
            now += 1;
            Assert.False(SessionState.WithinHeartbeat(now, heartBtIntMillis, lastSentTime, lastReceivedTime));

            lastSentTime += 1;
            lastReceivedTime += 1;
            Assert.True(SessionState.WithinHeartbeat(now, heartBtIntMillis, lastSentTime, lastReceivedTime));
        }
    }
}