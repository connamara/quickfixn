using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class SessionSettingsTest
    {
        [Test]
        public void LoadSettings()
        {
            string configuration = new System.Text.StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=initiator")
                .AppendLine("BeginString=FIX.4.0")
                .AppendLine("Value=4")
                .AppendLine("Empty=")
                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIX.4.2")
                .AppendLine("SenderCompID=ISLD")
                .AppendLine("TargetCompID=TW")
                .AppendLine("Value=1")
                .AppendLine("# this is a comment")
                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIX.4.1")
                .AppendLine("SenderCompID=ISLD")
                .AppendLine("TargetCompID=WT")
                .AppendLine("Value=2")
                .AppendLine("[SESSION]")
                .AppendLine("SenderCompID=ARCA")
                .AppendLine("TargetCompID=TW")
                .AppendLine("Value=3")
                .AppendLine("[SESSION]")
                .AppendLine("SenderCompID=ARCA")
                .AppendLine("TargetCompID=WT")
                .AppendLine("[SESSION]")
                .AppendLine("SenderCompID=NYSE")
                .AppendLine("TargetCompID=TW")
                .AppendLine("SessionQualifier=QUAL1")
                .AppendLine("Value=5")
                .AppendLine("[SESSION]")
                .AppendLine("SenderCompID=NYSE")
                .AppendLine("TargetCompID=TW")
                .AppendLine("SessionQualifier=QUAL2")
                .AppendLine("Value=6")
                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIXT.1.1")
                .AppendLine("SenderCompID=NYSE")
                .AppendLine("TargetCompID=TW")
                .ToString();
            SessionSettings settings = new SessionSettings(new System.IO.StringReader(configuration));
            
            SessionID session1 = new SessionID("FIX.4.2", "ISLD", "TW");
            SessionID session2 = new SessionID("FIX.4.1", "ISLD", "WT");
            SessionID session3 = new SessionID("FIX.4.0", "ARCA", "TW");
            SessionID session4 = new SessionID("FIX.4.0", "ARCA", "WT");
            SessionID session5 = new SessionID("FIX.4.0", "NYSE", "TW", "QUAL1");
            SessionID session6 = new SessionID("FIX.4.0", "NYSE", "TW", "QUAL2");
            
            Assert.That(settings.Get().GetString( "Empty" ), Is.EqualTo("") );
            
            Assert.That(settings.Get().GetLong( "Value" ), Is.EqualTo(4) );
            Assert.That(settings.Get(session1).GetLong("Value"), Is.EqualTo(1));
            Assert.That(settings.Get(session2).GetLong("Value"), Is.EqualTo(2));
            Assert.That(settings.Get(session3).GetLong("Value"), Is.EqualTo(3));
            Assert.That(settings.Get(session4).GetLong("Value"), Is.EqualTo(4));
            Assert.That(settings.Get(session5).GetLong("Value"), Is.EqualTo(5));
            Assert.That(settings.Get(session6).GetLong("Value"), Is.EqualTo(6));

            // case insensitivity
            Assert.That(settings.Get().GetLong("value"), Is.EqualTo(4));
            Assert.That(settings.Get(session1).GetLong("value"), Is.EqualTo(1));
            Assert.That(settings.Get(session2).GetLong("value"), Is.EqualTo(2));
            Assert.That(settings.Get(session3).GetLong("value"), Is.EqualTo(3));
            Assert.That(settings.Get(session4).GetLong("value"), Is.EqualTo(4));
            Assert.That(settings.Get(session5).GetLong("value"), Is.EqualTo(5));
            Assert.That(settings.Get(session6).GetLong("value"), Is.EqualTo(6));

            Assert.That(settings.Get().GetLong("VALUE"), Is.EqualTo(4));
            Assert.That(settings.Get(session1).GetLong("VALUE"), Is.EqualTo(1));
            Assert.That(settings.Get(session2).GetLong("VALUE"), Is.EqualTo(2));
            Assert.That(settings.Get(session3).GetLong("VALUE"), Is.EqualTo(3));
            Assert.That(settings.Get(session4).GetLong("VALUE"), Is.EqualTo(4));
            Assert.That(settings.Get(session5).GetLong("VALUE"), Is.EqualTo(5));
            Assert.That(settings.Get(session6).GetLong("VALUE"), Is.EqualTo(6));
        }
    }
}
