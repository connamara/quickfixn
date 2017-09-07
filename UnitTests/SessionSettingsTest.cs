using QuickFix;
using Xunit;

namespace UnitTests
{
    public class SessionSettingsTest
    {
        protected System.Text.StringBuilder partialConfiguration;

        public SessionSettingsTest()
        {
            partialConfiguration = new System.Text.StringBuilder()
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
                .AppendLine("TargetCompID=TW");
        }

        [Fact]
        public void Load()
        {
            string configuration = new System.Text.StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=initiator")
                .AppendLine("BeginString=FIX.4.0")
                .AppendLine("Value=4")
                .AppendLine("Empty=")
                .AppendLine(partialConfiguration.ToString())
                .ToString();
            SessionSettings settings = new SessionSettings(new System.IO.StringReader(configuration));

            SessionID session1 = new SessionID("FIX.4.2", "ISLD", "TW");
            SessionID session2 = new SessionID("FIX.4.1", "ISLD", "WT");
            SessionID session3 = new SessionID("FIX.4.0", "ARCA", "TW");
            SessionID session4 = new SessionID("FIX.4.0", "ARCA", "WT");
            SessionID session5 = new SessionID("FIX.4.0", "NYSE", "TW", "QUAL1");
            SessionID session6 = new SessionID("FIX.4.0", "NYSE", "TW", "QUAL2");

            Assert.Equal("", settings.Get().GetString("Empty"));

            Assert.Equal(4, settings.Get().GetLong("Value"));
            Assert.Equal(1, settings.Get(session1).GetLong("Value"));
            Assert.Equal(2, settings.Get(session2).GetLong("Value"));
            Assert.Equal(3, settings.Get(session3).GetLong("Value"));
            Assert.Equal(4, settings.Get(session4).GetLong("Value"));
            Assert.Equal(5, settings.Get(session5).GetLong("Value"));
            Assert.Equal(6, settings.Get(session6).GetLong("Value"));

            // case insensitivity
            Assert.Equal(4, settings.Get().GetLong("value"));
            Assert.Equal(1, settings.Get(session1).GetLong("value"));
            Assert.Equal(2, settings.Get(session2).GetLong("value"));
            Assert.Equal(3, settings.Get(session3).GetLong("value"));
            Assert.Equal(4, settings.Get(session4).GetLong("value"));
            Assert.Equal(5, settings.Get(session5).GetLong("value"));
            Assert.Equal(6, settings.Get(session6).GetLong("value"));

            Assert.Equal(4, settings.Get().GetLong("VALUE"));
            Assert.Equal(1, settings.Get(session1).GetLong("VALUE"));
            Assert.Equal(2, settings.Get(session2).GetLong("VALUE"));
            Assert.Equal(3, settings.Get(session3).GetLong("VALUE"));
            Assert.Equal(4, settings.Get(session4).GetLong("VALUE"));
            Assert.Equal(5, settings.Get(session5).GetLong("VALUE"));
            Assert.Equal(6, settings.Get(session6).GetLong("VALUE"));
        }

        [Fact]
        public void LoadSettingsWithDefaultSectionLast()
        {
            string configuration = new System.Text.StringBuilder()
                .AppendLine(partialConfiguration.ToString())
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=initiator")
                .AppendLine("BeginString=FIX.4.0")
                .AppendLine("Value=4")
                .AppendLine("Empty=")
                .ToString();
            SessionSettings settings = new SessionSettings(new System.IO.StringReader(configuration));

            SessionID session1 = new SessionID("FIX.4.2", "ISLD", "TW");
            SessionID session2 = new SessionID("FIX.4.1", "ISLD", "WT");
            SessionID session3 = new SessionID("FIX.4.0", "ARCA", "TW");
            SessionID session4 = new SessionID("FIX.4.0", "ARCA", "WT");
            SessionID session5 = new SessionID("FIX.4.0", "NYSE", "TW", "QUAL1");
            SessionID session6 = new SessionID("FIX.4.0", "NYSE", "TW", "QUAL2");

            Assert.Equal("", settings.Get().GetString("Empty"));

            Assert.Equal(4, settings.Get().GetLong("Value"));
            Assert.Equal(1, settings.Get(session1).GetLong("Value"));
            Assert.Equal(2, settings.Get(session2).GetLong("Value"));
            Assert.Equal(3, settings.Get(session3).GetLong("Value"));
            Assert.Equal(4, settings.Get(session4).GetLong("Value"));
            Assert.Equal(5, settings.Get(session5).GetLong("Value"));
            Assert.Equal(6, settings.Get(session6).GetLong("Value"));

            // case insensitivity
            Assert.Equal(4, settings.Get().GetLong("value"));
            Assert.Equal(1, settings.Get(session1).GetLong("value"));
            Assert.Equal(2, settings.Get(session2).GetLong("value"));
            Assert.Equal(3, settings.Get(session3).GetLong("value"));
            Assert.Equal(4, settings.Get(session4).GetLong("value"));
            Assert.Equal(5, settings.Get(session5).GetLong("value"));
            Assert.Equal(6, settings.Get(session6).GetLong("value"));

            Assert.Equal(4, settings.Get().GetLong("VALUE"));
            Assert.Equal(1, settings.Get(session1).GetLong("VALUE"));
            Assert.Equal(2, settings.Get(session2).GetLong("VALUE"));
            Assert.Equal(3, settings.Get(session3).GetLong("VALUE"));
            Assert.Equal(4, settings.Get(session4).GetLong("VALUE"));
            Assert.Equal(5, settings.Get(session5).GetLong("VALUE"));
            Assert.Equal(6, settings.Get(session6).GetLong("VALUE"));
        }

        [Fact]
        public void DuplicateSession()
        {
            string configuration = new System.Text.StringBuilder()
                    .AppendLine("[DEFAULT]")
                    .AppendLine("ConnectionType=initiator")
                    .AppendLine("[SESSION]")
                    .AppendLine("BeginString=FIX.4.2")
                    .AppendLine("SenderCompID=ISLD")
                    .AppendLine("TargetCompID=TW")
                    .AppendLine("[SESSION]")
                    .AppendLine("BeginString=FIX.4.2")
                    .AppendLine("SenderCompID=ISLD")
                    .AppendLine("TargetCompID=TW")
                    .ToString();
            Assert.Throws<ConfigError>(delegate { new SessionSettings(new System.IO.StringReader(configuration)); });
        }

        [Fact]
        public void StripSpaces()
        {
            string configuration = new System.Text.StringBuilder()
                    .AppendLine("[ DEFAULT ]")
                    .AppendLine(" ConnectionType = initiator")
                    .AppendLine("  [  SESSION  ]  ")
                    .AppendLine("BeginString=FIX.4.2 ")
                    .AppendLine(" SenderCompID =ISLD")
                    .AppendLine("  TargetCompID  =  TW  ")
                    .AppendLine("  Long  =  123  ")
                    .AppendLine("  Double  =  1.23  ")
                    .AppendLine("  Bool  =  N  ")
                    .ToString();
            SessionSettings settings = new SessionSettings(new System.IO.StringReader(configuration));

            Assert.Equal("initiator", settings.Get().GetString("ConnectionType"));

            SessionID session = new SessionID("FIX.4.2", "ISLD", "TW");
            Assert.Equal("initiator", settings.Get(session).GetString("ConnectionType"));
            Assert.Equal("FIX.4.2", settings.Get(session).GetString("BeginString"));
            Assert.Equal("ISLD", settings.Get(session).GetString("SenderCompID"));
            Assert.Equal("TW", settings.Get(session).GetString("TargetCompID"));
            Assert.Equal(123, settings.Get(session).GetLong("Long"));
            Assert.Equal(1.23, settings.Get(session).GetDouble("Double"));
            Assert.False(settings.Get(session).GetBool("Bool"));
        }

        [Fact]
        public void Validate()
        {
            SessionSettings settings = new SessionSettings();
            SessionID sessionID = new SessionID("FIX.4.2", "SenderCompID", "TargetCompID");

            // ConnectionType not set
            QuickFix.Dictionary dictionary = new QuickFix.Dictionary();
            Assert.Throws<ConfigError>(delegate { settings.Set(sessionID, dictionary); });

            // ConnectionType set to invalid value
            dictionary.SetString(SessionSettings.CONNECTION_TYPE, "badvalue");
            Assert.Throws<ConfigError>(delegate { settings.Set(sessionID, dictionary); });

            // ConnectionType set to valid value
            dictionary.SetString(SessionSettings.CONNECTION_TYPE, "initiator");
            settings.Set(sessionID, dictionary);

            // Invalid BeginString
            sessionID = new SessionID("FIX4.2", "SenderCompID", "TargetCompID");
            Assert.Throws<ConfigError>(delegate { settings.Set(sessionID, dictionary); });
        }

        [Fact]
        public void SettingsToString()
        {
            string configuration = new System.Text.StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("CONNECTIONTYPE=initiator")
                .AppendLine("BEGINSTRING=FIX.4.0")
                .AppendLine()
                .AppendLine("[SESSION]")
                .AppendLine("BEGINSTRING=FIX.4.2")
                .AppendLine("SENDERCOMPID=ISLD")
                .AppendLine("TARGETCOMPID=TW")
                .AppendLine("VALUE=1")
                .AppendLine()
                .AppendLine("[SESSION]")
                .AppendLine("BEGINSTRING=FIX.4.1")
                .AppendLine("SENDERCOMPID=ISLD")
                .AppendLine("TARGETCOMPID=WT")
                .AppendLine("VALUE=2")
                .ToString();
            SessionSettings settings = new SessionSettings(new System.IO.StringReader(configuration));

            Assert.Equal(settings.ToString(), configuration);
        }

        [Fact]
        public void testExtendedSettings()
        {
            string settingsString = new System.Text.StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=initiator")
                .AppendLine("HeartBtInt=60")
                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIX.4.2")
                .AppendLine("SenderCompID=Company")
                .AppendLine("SenderSubID=FixedIncome")
                .AppendLine("SenderLocationID=HongKong")
                .AppendLine("TargetCompID=CLIENT1")
                .AppendLine("TargetSubID=HedgeFund")
                .AppendLine("TargetLocationID=NYC")
                .AppendLine("SendRedundantResendRequests=Y")
                .AppendLine("MillisecondsInTimeStamp=Y")
                .AppendLine("EnableLastMsgSeqNumProcessed=Y")
                .AppendLine("MaxMessagesInResendRequest=2500")
                .AppendLine("StartTime=06:00:00")
                .AppendLine("EndTime=05:59:00")
                .ToString();

            SessionSettings settings = new SessionSettings(new System.IO.StringReader(settingsString));

            SessionID id = new SessionID("FIX.4.2", "Company", "FixedIncome", "HongKong", "CLIENT1", "HedgeFund", "NYC");
            Assert.Equal("60", settings.Get(id).GetString("HeartBtInt"));
            Assert.Equal("FIX.4.2", settings.Get(id).GetString("BeginString"));
            Assert.Equal("Company", settings.Get(id).GetString("SenderCompID"));
            Assert.Equal("FixedIncome", settings.Get(id).GetString("SenderSubID"));
            Assert.Equal("HongKong", settings.Get(id).GetString("SenderLocationID"));
            Assert.Equal("CLIENT1", settings.Get(id).GetString("TargetCompID"));
            Assert.Equal("HedgeFund", settings.Get(id).GetString("TargetSubID"));
            Assert.Equal("NYC", settings.Get(id).GetString("TargetLocationID"));
            Assert.Equal("Y", settings.Get(id).GetString("SendRedundantResendRequests"));
            Assert.Equal("Y", settings.Get(id).GetString("MillisecondsInTimeStamp"));
            Assert.Equal("Y", settings.Get(id).GetString("EnableLastMsgSeqNumProcessed"));
            Assert.Equal("2500", settings.Get(id).GetString("MaxMessagesInResendRequest"));
            Assert.Equal("06:00:00", settings.Get(id).GetString("StartTime"));
            Assert.Equal("05:59:00", settings.Get(id).GetString("EndTime"));
            id = null;
            foreach (SessionID sid in settings.GetSessions())
            {
                id = sid;
                break;
            }
            Assert.NotNull(id);
            Assert.Equal("FIX.4.2", id.BeginString);
            Assert.Equal("Company", id.SenderCompID);
            Assert.Equal("FixedIncome", id.SenderSubID);
            Assert.Equal("HongKong", id.SenderLocationID);
            Assert.Equal("CLIENT1", id.TargetCompID);
            Assert.Equal("HedgeFund", id.TargetSubID);
            Assert.Equal("NYC", id.TargetLocationID);
        }

        [Fact]
        public void SettingsFileRelease()
        {
            string f = "../../../foo_config.cfg";
            new SessionSettings(f);

            // if the file is still locked, this will throw an exception
            new SessionSettings(f);
        }

        [Fact]
        public void CaseInsensitiveSectionName()
        {
            string configuration = @"[dEfAuLt]
ConnectionType=initiator
[sEsSiOn]
BeginString=FIX.4.2
SenderCompID=ISLD
TargetCompID=TW";
            SessionSettings settings = new SessionSettings(new System.IO.StringReader(configuration));

            Assert.Equal("initiator", settings.Get().GetString("ConnectionType"));

            SessionID session = new SessionID("FIX.4.2", "ISLD", "TW");
            Assert.Equal("initiator", settings.Get(session).GetString("ConnectionType"));
            Assert.Equal("FIX.4.2", settings.Get(session).GetString("BeginString"));
        }
    }
}
