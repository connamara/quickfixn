using System;
using System.Text;
using System.Threading;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using QuickFix.FIX42;
using QuickFix.Transport;
using Message = QuickFix.Message;

namespace UnitTests
{
    [TestFixture]
    public class EncodingTests
    {
        private News GenerateNewMessage(Encoding encoding)
        {
            // The special char is from the extended ASCII codes according to ISO 8859-1, also called ISO Latin-1. see http://www.ascii-code.com/
            // And yes I got this field from my FIX Adapter and QuickFix/n killed the socket on it.
            const string headline = "SFE SPI 200® Index Futures went up";
            //const string msgBody ="35=B\x01" +  "148="+headline+"\x01";

            News news = new News(new Headline(headline));
            if (encoding != null)
            {
                news.Encoding = encoding;
            }

            // Generates the header and trailer of the message
            news.ToString();

            return news;
        }

        [Test]
        public void testLengthAndSumCalcLatin1()
        {
            News news = GenerateNewMessage(Encoding.GetEncoding("latin1"));

            Assert.That(news.Header.GetInt(Tags.BodyLength), Is.EqualTo(44));
            Assert.That(news.Trailer.GetInt(Tags.CheckSum), Is.EqualTo(20));
        }

        [Test]
        public void testLengthAndSumCalcUTF8()
        {
            News news = GenerateNewMessage(Encoding.UTF8);

            Assert.That(news.Header.GetInt(Tags.BodyLength), Is.EqualTo(45));
            Assert.That(news.Trailer.GetInt(Tags.CheckSum), Is.EqualTo(215));
        }

        [Test]
        public void testSessionSettingsLatin1()
        {
            string configuration = new StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=initiator")
                .AppendLine("StartTime=00:00:00")
                .AppendLine("EndTime=00:00:00")
                .AppendLine("UseDataDictionary=N")
                .AppendLine("ReconnectInterval=30")
                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIX.4.2")
                .AppendLine("SenderCompID=Simor")
                .AppendLine("TargetCompID=Tom")
                .AppendLine("HeartBtInt=30")
                .AppendLine("Encoding=latin1")
                .ToString();

            SessionID sessionID = new SessionID("FIX.4.2", "Simor", "Tom");

            SessionSettings settings = new SessionSettings(new System.IO.StringReader(configuration));

            Assert.That(settings.Get(sessionID).GetString(SessionSettings.ENCODING), Is.EqualTo("latin1"));

            SocketInitiator si = new SocketInitiator(new NullApplication(), new MemoryStoreFactory(), settings);
            si.Start();
            var session = Session.LookupSession(sessionID);

            Assert.That(session.Encoding, Is.EqualTo(Encoding.GetEncoding("latin1")));

            si.Stop();
        }

        [Test]
        public void testSessionSettingsUTF8()
        {
          string configuration = new StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=initiator")
                .AppendLine("StartTime=00:00:00")
                .AppendLine("EndTime=00:00:00")
                .AppendLine("UseDataDictionary=N")
                .AppendLine("ReconnectInterval=30")
                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIX.4.2")
                .AppendLine("SenderCompID=Simor")
                .AppendLine("TargetCompID=Tom")
                .AppendLine("HeartBtInt=30")
                .ToString();

            SessionID sessionID = new SessionID("FIX.4.2", "Simor", "Tom");

            SessionSettings settings = new SessionSettings(new System.IO.StringReader(configuration));

            Assert.That(settings.Get(sessionID).Has(SessionSettings.ENCODING), Is.False);

            SocketInitiator si = new SocketInitiator(new NullApplication(), new MemoryStoreFactory(), settings);
            si.Start();
            var session = Session.LookupSession(sessionID);

            Assert.That(session.Encoding, Is.EqualTo(Encoding.GetEncoding("utf-8")));

            si.Stop();
        }

        private class TestApp : IApplication
        {
            public event Action<Message> OnReceivedMessage;
            public event Action<Message> OnSentMessage;

            public void OnCreate(SessionID sessionID) { }
            public void OnLogout(SessionID sessionID) { }
            public void OnLogon(SessionID sessionID) { }

            public void FromAdmin(Message message, SessionID sessionID) { OnReceivedMessage?.Invoke(message); }
            public void FromApp(Message message, SessionID sessionID) { OnReceivedMessage?.Invoke(message); }

            public void ToAdmin(Message message, SessionID sessionID) { OnSentMessage?.Invoke(message); }
            public void ToApp(Message message, SessionID sessionId) { OnSentMessage?.Invoke(message); }
        }

        [Test]
        public void testMessagePassingDefaultToDefault()
        {
            testMessagePassing(null, null, true);
        }

        [Test]
        public void testMessagePassingUTF8To2Default()
        {
            testMessagePassing("utf-8", null, true);
        }

        [Test]
        public void testMessagePassingDefaultToUTF8()
        {
            testMessagePassing(null, "utf-8", true);
        }

        [Test]
        public void testMessagePassingUTF8ToUTF8()
        {
            testMessagePassing("utf-8", "utf-8", true);
        }

        [Test]
        public void testMessagePassingLatin1ToLatin1()
        {
            testMessagePassing("latin1", "latin1", true);
        }

        [Test]
        public void testMessagePassingLatin1ToUTF8()
        {
            testMessagePassing("latin1", "utf-8", false);
        }

        public void testMessagePassing(string acceptorEncoding, string initiatorEncoding, bool shouldGetNews)
        {
            ManualResetEvent logon = new ManualResetEvent(false);
            bool gotNews = false;;

            TestApp clientApp = new TestApp();
            TestApp serverApp = new TestApp();

            clientApp.OnReceivedMessage += m =>
                {
                    //Console.WriteLine("Initiator.Received: " + m.ToString());
                    if (m.Header.GetString(Tags.MsgType) == Logon.MsgType)
                    {
                        logon.Set();
                    }
                    else if (m.Header.GetString(Tags.MsgType) == News.MsgType)
                    {
                        gotNews = true;
                    }
                };
            //clientApp.OnSentMessage += m => Console.WriteLine("Initiator.Sent: " + m.ToString());
            //serverApp.OnReceivedMessage += m => Console.WriteLine("Acceptor.Received: " + m.ToString());
            //serverApp.OnSentMessage += m => Console.WriteLine("Acceptor.Sent: " + m.ToString());

            var initiator = createInitiator(clientApp, initiatorEncoding);
            var acceptor = createAcceptor(serverApp, acceptorEncoding);

            acceptor.Start();
            initiator.Start();
       
            //SessionID initiatorSessionID = new SessionID("FIX.4.2", "Simor", "Tom");
            SessionID acceptorSessionID = new SessionID("FIX.4.2", "Tom", "Simor");

            //Session initiatorSession = Session.LookupSession(initiatorSessionID);
            Session acceptorSession = Session.LookupSession(acceptorSessionID);

            bool timeout = !logon.WaitOne(1000);
            Assert.That(timeout, Is.False);

            News sentNews = GenerateNewMessage(null);
            acceptorSession.Send(sentNews);

            Thread.Sleep(100);

            initiator.Stop();
            acceptor.Stop();

            Assert.That(gotNews, Is.EqualTo(shouldGetNews));
        }

        private SocketInitiator createInitiator(IApplication app, string encoding)
        {
            string initiatorConfiguration = new StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=initiator")
                .AppendLine("StartTime=00:00:00")
                .AppendLine("EndTime=00:00:00")
                .AppendLine("UseDataDictionary=N")
                .AppendLine("ReconnectInterval=30")

                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIX.4.2")
                .AppendLine("SenderCompID=Simor")
                .AppendLine("TargetCompID=Tom")
                .AppendLine("HeartBtInt=30")
                .AppendLine("SocketConnectHost=127.0.0.1")
                .AppendLine("SocketConnectPort=10000")
                .AppendLine(encoding != null ? "Encoding="+encoding : "")
                .ToString();

            SessionSettings settings = new SessionSettings(new System.IO.StringReader(initiatorConfiguration));
            SocketInitiator si = new SocketInitiator(app, new MemoryStoreFactory(), settings, null /*new ScreenLogFactory(true, true,true)*/);

            return si;
        }

        private ThreadedSocketAcceptor createAcceptor(IApplication app, string encoding)
        {
            string accetorConfiguration = new StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=acceptor")
                .AppendLine("StartTime=00:00:00")
                .AppendLine("EndTime=00:00:00")
                .AppendLine("UseDataDictionary=N")
                .AppendLine("SocketAcceptHost=127.0.0.1")
                .AppendLine("SocketAcceptPort=10000")
                .AppendLine("HeartBtInt=30")

                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIX.4.2")
                .AppendLine("SenderCompID=Tom")
                .AppendLine("TargetCompID=Simor")
                .AppendLine(encoding != null ? "Encoding="+encoding : "")
                .ToString();

            SessionSettings settings = new SessionSettings(new System.IO.StringReader(accetorConfiguration));
            ThreadedSocketAcceptor tsa = new ThreadedSocketAcceptor(app, new MemoryStoreFactory(), settings, null /* new ScreenLogFactory(true, true,true)*/);

            return tsa;          
        }
    }
}