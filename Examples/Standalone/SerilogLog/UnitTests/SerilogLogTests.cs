using System.Diagnostics;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace UnitTests
{
    public class SerilogLogTests
    {
        SerilogLog.SerilogLog log;
        string logPath;

        [SetUp]
        public void Setup()
        {
            logPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");
            if (Directory.Exists(logPath)) Directory.Delete(logPath, true);
        }

        [TearDown]
        public void Teardown()
        {
            log?.Dispose();
            log = null;
            if (Directory.Exists(logPath)) Directory.Delete(logPath, true);
        }

        [Test]
        public void TestEventsLogSizeLimit()
        {
            const string TextTestMessage = "Test message.";

            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            long fileSizeLimitBytes = 1024;
            int filesLimit = 2;
            log = new SerilogLog.SerilogLog(logPath, sessionID, fileSizeLimitBytes, filesLimit, fileSizeLimitBytes, filesLimit);
            string testMessage = TextTestMessage;
            int testMessageSize = Encoding.UTF8.GetByteCount($"2020-11-11 21:45:47.153 +02:00 : 00000: {TextTestMessage}\n");
            testMessage = TextTestMessage;
            long writtenBytes = 0;
            long line = 0;
            long limitBytes = fileSizeLimitBytes * filesLimit;
            while (writtenBytes < limitBytes)
            {
                log.OnEvent($"{++line:D5}: {testMessage}");
                writtenBytes += testMessageSize;
                Debug.Print($"Written bytes: {writtenBytes}");
            }
            Debug.Print($"Limit passed, writing over the limit");
            for (int i = 0; i < 2; ++i)
            {
                log.OnEvent("Over size limit text!");
            }
            long dirSize = DirectorySize(logPath);
            Debug.Print($"Calculated {dirSize} bytes for {logPath}");
            Assert.IsTrue(dirSize <= limitBytes, $"Size {dirSize} unexpectedly exceeds limit {limitBytes}");
        }


        [Test]
        public void TestMessagesLogSizeLimit()
        {
            const string TextTestMessage = "Test message.";

            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            long fileSizeLimitBytes = 1024;
            int filesLimit = 2;
            log = new SerilogLog.SerilogLog(logPath, sessionID, fileSizeLimitBytes, filesLimit, fileSizeLimitBytes, filesLimit);
            string testMessage = TextTestMessage;
            int testMessageSize = Encoding.UTF8.GetByteCount($"2020-11-11 21:45:47.153 +02:00 : 00000: {TextTestMessage}\n");
            testMessage = TextTestMessage;
            long writtenBytes = 0;
            long line = 0;
            long limitBytes = fileSizeLimitBytes * filesLimit;
            while (writtenBytes < limitBytes)
            {
                log.OnIncoming($"{++line:D5}: {testMessage}");
                writtenBytes += testMessageSize;
                Debug.Print($"Written bytes: {writtenBytes}");
            }
            Debug.Print($"Limit passed, writing over the limit");
            for (int i = 0; i < 2; ++i)
            {
                log.OnOutgoing("Over size limit text!");
            }
            long dirSize = DirectorySize(logPath);
            Debug.Print($"Calculated {dirSize} bytes for {logPath}");
            Assert.IsTrue(dirSize <= limitBytes, $"Size {dirSize} unexpectedly exceeds limit {limitBytes}");
        }


        [Test]
        public void TestMessagesNoLimit()
        {
            const string TextTestMessage = "Test message.";

            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            log = new SerilogLog.SerilogLog(logPath, sessionID, null, null, null, null);
            string testMessage = TextTestMessage;
            int testMessageSize = Encoding.UTF8.GetByteCount($"2020-11-11 21:45:47.153 +02:00 : 00000: {TextTestMessage}\n");
            testMessage = TextTestMessage;
            long writtenBytes = 0;
            long line = 0;
            long limitBytes = testMessageSize * 100;
            while (writtenBytes < limitBytes)
            {
                log.OnIncoming($"{++line:D5}: {testMessage}");
                writtenBytes += testMessageSize;
                Debug.Print($"Total written bytes: {writtenBytes}");
            }
            Debug.Print($"Limit passed, writing over the limit");
            for (int i = 0; i < 2; ++i)
            {
                log.OnOutgoing($"{++line:D5}: {testMessage}");
                writtenBytes += testMessageSize;
                Debug.Print($"Total written bytes: {writtenBytes}");
            }
            long dirSize = DirectorySize(logPath);
            Debug.Print($"Calculated {dirSize} bytes for {logPath}");
            Assert.IsTrue(dirSize >= limitBytes, $"Size {dirSize} is unexpectedly less then written {limitBytes}");
        }

        private static long DirectorySize(string directoryPath)
        {
            long size = 0;
            // Add file sizes.
            foreach(string fileName in Directory.EnumerateFiles(directoryPath))
            {
                string filePath = Path.Combine(directoryPath, fileName);
                FileInfo fi = new FileInfo(filePath);
                size += fi.Length;
            }
            return size;
        }
    }
}