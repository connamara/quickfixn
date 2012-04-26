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
            int heartBtIntMillis = 60 * 1000;
            System.DateTime now = System.DateTime.UtcNow;
            System.DateTime lastReceivedTime = now;



            now = now.AddMilliseconds(heartBtIntMillis);
            Assert.False(SessionState.TimedOut(now, heartBtIntMillis, lastReceivedTime));
            now = now.AddMilliseconds(heartBtIntMillis);
            Assert.False(SessionState.TimedOut(now, heartBtIntMillis, lastReceivedTime));
            now = now.AddMilliseconds(heartBtIntMillis);
            Assert.True(SessionState.TimedOut(now, heartBtIntMillis, lastReceivedTime));
        }
        
        [Test]
        public void LogonTimedOut()
        {
            int logonTimeout = 5 * 1000;

            System.DateTime now = System.DateTime.UtcNow;
            System.DateTime lastRecvTime = now;

            now = now.AddMilliseconds(4000);
            Assert.False(SessionState.LogonTimedOut(now, logonTimeout, lastRecvTime));
            now = now.AddMilliseconds(1000);
            Assert.True(SessionState.LogonTimedOut(now, logonTimeout, lastRecvTime));
            now = now.AddMilliseconds(1);
            Assert.True(SessionState.LogonTimedOut(now, logonTimeout, lastRecvTime));
        }

        [Test]
        public void LogoutTimedOut()
        {
            bool sentLogout = true;
            int logoutTimeout = 2 * 1000;

            System.DateTime now = System.DateTime.UtcNow;
            System.DateTime lastSentTime = now;

            now = now.AddMilliseconds(1000);
            Assert.False(SessionState.LogoutTimedOut(now, sentLogout, logoutTimeout, lastSentTime));
            now = now.AddMilliseconds(1000);
            Assert.True(SessionState.LogoutTimedOut(now, sentLogout, logoutTimeout, lastSentTime));
           
            sentLogout = false; 
            Assert.False(SessionState.LogoutTimedOut(now, sentLogout, logoutTimeout, lastSentTime));
        }

        [Test]
        public void NeedTestRequest()
        {
            int heartBtIntMillis = 30 * 1000;
            int testRequestCounter = 0;

            System.DateTime now = System.DateTime.UtcNow;
            System.DateTime lastReceivedTime = now;

            now = now.AddMilliseconds(heartBtIntMillis);
            Assert.False(SessionState.NeedTestRequest(now, heartBtIntMillis, lastReceivedTime, testRequestCounter));
            now = now.AddMilliseconds(heartBtIntMillis);
            Assert.True(SessionState.NeedTestRequest(now, heartBtIntMillis, lastReceivedTime, testRequestCounter));

            testRequestCounter += 1;
            Assert.False(SessionState.NeedTestRequest(now, heartBtIntMillis, lastReceivedTime, testRequestCounter));
            now = now.AddMilliseconds(heartBtIntMillis);
            Assert.True(SessionState.NeedTestRequest(now, heartBtIntMillis, lastReceivedTime, testRequestCounter));

        }

        [Test]
        public void NeedHeartbeat()
        {
            int heartBtIntMillis = 60 * 1000;
            int testRequestCounter = 0;

            System.DateTime now = System.DateTime.UtcNow;
            System.DateTime lastSentTime = now;

            now = now.AddMilliseconds(heartBtIntMillis / 3);
            Assert.False(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
            now = now.AddMilliseconds(heartBtIntMillis / 3);
            Assert.False(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
            now = now.AddMilliseconds(heartBtIntMillis / 2);
            Assert.True(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));

            testRequestCounter = 1;
            Assert.False(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
            now = now.AddMilliseconds(2 * heartBtIntMillis);
            Assert.False(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
            testRequestCounter = 0;
            Assert.True(SessionState.NeedHeartbeat(now, heartBtIntMillis, lastSentTime, testRequestCounter));
        }

        [Test]
        public void WithinHeartbeat()
        {
            int heartBtIntMillis = 60 * 1000;

            System.DateTime now = System.DateTime.UtcNow;
            System.DateTime lastSentTime = now;
            System.DateTime lastReceivedTime = now;

            now = now.AddMilliseconds(heartBtIntMillis - 1);
            Assert.True(SessionState.WithinHeartbeat(now, heartBtIntMillis, lastSentTime, lastReceivedTime));
            now = now.AddMilliseconds(1);
            Assert.False(SessionState.WithinHeartbeat(now, heartBtIntMillis, lastSentTime, lastReceivedTime));

            lastSentTime = lastSentTime.AddMilliseconds(1);
            lastReceivedTime = lastReceivedTime.AddMilliseconds(1);
            Assert.True(SessionState.WithinHeartbeat(now, heartBtIntMillis, lastSentTime, lastReceivedTime));
        }
    }
}
