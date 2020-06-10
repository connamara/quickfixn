using System;
using NUnit.Framework;
using QuickFix;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

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

        [Test]
        public void ThreadSafeSetAndGet() {
            //Set up store
            var storeDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "store");

            if (System.IO.Directory.Exists(storeDirectory))
                System.IO.Directory.Delete(storeDirectory, true);

            SessionID sessionId = new SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");

            Dictionary config = new Dictionary();
            config.SetString(SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(SessionSettings.FILE_STORE_PATH, storeDirectory);

            SessionSettings settings = new SessionSettings();
            settings.Set(sessionId, config);
            FileStoreFactory factory = new FileStoreFactory(settings);

            FileStore store = (FileStore)factory.Create(sessionId);

            NullLog log = new NullLog();

            //Set up sessionstate
            SessionState state = new SessionState(true, log, 1) {MessageStore = store};

            Hashtable errorsTable = Hashtable.Synchronized(new Hashtable());//used in more than 1 thread at a time
            Hashtable setTable = new Hashtable(1000);//only used in 1 thread at a time
            Hashtable getTable = new Hashtable(1000);//only used in 1 thread at a time

            //Synchronously populate 1000 messages
            for (int i = 1; i < 1000; i++) {
                string msg = "msg" + i;
                state.Set(i, msg);
                setTable[i] = msg;
            }

            //Simulate background sending of messages that populate into the store
            AutoResetEvent setEvent = new AutoResetEvent(false);
            ThreadPool.QueueUserWorkItem(delegate(object stateObject) {
                AutoResetEvent internalSetEvent = (AutoResetEvent)((object[])stateObject)[0];
                SessionState internalState = (SessionState)((object[])stateObject)[1];
                for (int i = 1001; i < 2000; i++) {
                    try {
                        internalState.Set(i, "msg" + i);
                    }
                    catch (System.IO.IOException ex) {
                        errorsTable[ex.Message] = ex;
                    }
                }

                internalSetEvent.Set();
            }
            , new object[] { setEvent, state });

            //Simulate background reading of messages from the store - like is done in a resend request answer
            AutoResetEvent getEvent = new AutoResetEvent(false);
            ThreadPool.QueueUserWorkItem(delegate(object stateObject){
                AutoResetEvent internalGetEvent = (AutoResetEvent)((object[])stateObject)[0];
                SessionState internalState = (SessionState)((object[])stateObject)[1];
                for (int i = 1; i < 1000; i++) {
                    try {
                        List<string> lst = new List<string>(1);
                        internalState.Get(i, i, lst);
                        if (lst.Count == 0) {
                            getTable[i] = "nothing read";
                        }
                        else {
                            getTable[i] = lst[0];
                        }
                    }
                    catch (System.IO.IOException ex) {
                        errorsTable[ex.Message] = ex;
                    }
                }

                internalGetEvent.Set();
            }
            , new object[]{getEvent, state});

            //wait till done and assert results
            Assert.True(setEvent.WaitOne(10000), "Get or Set hung/timed out during concurrent usage");
            Assert.True(getEvent.WaitOne(10000), "Get or Set hung/timed out during concurrent usage");
            Assert.AreEqual(setTable, getTable, "Garbled data read in concurrent set and get (like between resendrequest and send)");
            Assert.AreEqual(errorsTable.Count, 0, "IOException occured in concurrent set and get (like between resendrequest and send)");

            //Tear down filestore
            state.Dispose();
            store.Dispose();

            Directory.Delete(storeDirectory, true);
        }
    }
}
