using System;
using System.Configuration;
using System.Data.Common;

namespace QuickFix
{
    /*
Table structure:

CREATE TABLE [dbo].[messages_log](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[time] [datetime] NOT NULL,
	[beginstring] [char](8) NOT NULL,
	[sendercompid] [varchar](64) NOT NULL,
	[targetcompid] [varchar](64) NOT NULL,
	[session_qualifier] [varchar](64) NULL,
	[text] [text] NOT NULL,
	[own_timestamp] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)
)

ALTER TABLE [dbo].[messages_log] ADD  CONSTRAINT [DF_messages_log_own_timestamp]  DEFAULT (getdate()) FOR [own_timestamp]


CREATE TABLE [dbo].[event_log](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[time] [datetime] NOT NULL,
	[beginstring] [char](8) NOT NULL,
	[sendercompid] [varchar](64) NOT NULL,
	[targetcompid] [varchar](64) NOT NULL,
	[session_qualifier] [varchar](64) NULL,
	[text] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)
)
*/

    public class DbLog : Log, IDisposable
    {
        SessionID sessionID = null;
        ConnectionStringSettings connectionStringSetting = null;
        string messageLogCommandText = null;
        string eventLogCommandText = null;

        public DbLog(SessionID sessionID, string connectionName, string messageLogCommandText, string eventLogCommandText)
        {
            this.sessionID = sessionID;

            foreach (ConnectionStringSettings css in ConfigurationManager.ConnectionStrings)
            {
                if (css.Name == connectionName)
                {
                    this.connectionStringSetting = css;
                    break;
                }
            }

            this.messageLogCommandText =
                string.IsNullOrEmpty(messageLogCommandText) ?
                    "INSERT INTO messages_log (time, beginstring, sendercompid, targetcompid, session_qualifier, text) VALUES (@time, @beginstring, @sendercompid, @targetcompid, @session_qualifier, @text)"
                    : messageLogCommandText;

            this.eventLogCommandText =
                string.IsNullOrEmpty(eventLogCommandText) ?
                    "INSERT INTO event_log (time, beginstring, sendercompid, targetcompid, session_qualifier, text) VALUES (@time, @beginstring, @sendercompid, @targetcompid, @session_qualifier, @text)"
                    : eventLogCommandText;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void OnIncoming(string msg)
        {
            this.writeMessageLog(msg);
        }

        public void OnOutgoing(string msg)
        {
            this.writeMessageLog(msg);
        }

        public void OnEvent(string s)
        {
            this.writeEventLog(s);
        }

        public void Dispose()
        {
            this.connectionStringSetting = null;
            this.messageLogCommandText = null;
            this.eventLogCommandText = null;
            this.sessionID = null;
        }

        private void writeMessageLog(string msg)
        {
            this.writeLog(this.messageLogCommandText, msg);
        }

        private void writeEventLog(string msg)
        {
            this.writeLog(this.eventLogCommandText, msg);
        }

        private void writeLog(string commandText, string msg)
        {
            using (var connection = this.getConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = commandText;

                var pTime = command.CreateParameter();
                pTime.ParameterName = "@time";
                pTime.DbType = System.Data.DbType.DateTime;
                pTime.Value = DateTime.UtcNow;
                command.Parameters.Add(pTime);

                var pBeginstring = command.CreateParameter();
                pBeginstring.ParameterName = "@beginstring";
                pBeginstring.DbType = System.Data.DbType.AnsiStringFixedLength;
                pBeginstring.Size = 8;
                pBeginstring.Value = this.sessionID.BeginString;
                command.Parameters.Add(pBeginstring);

                var pSendercompid = command.CreateParameter();
                pSendercompid.ParameterName = "@sendercompid";
                pSendercompid.DbType = System.Data.DbType.AnsiString;
                pSendercompid.Size = 64;
                pSendercompid.Value = this.sessionID.SenderCompID;
                command.Parameters.Add(pSendercompid);

                var pTargetcompid = command.CreateParameter();
                pTargetcompid.ParameterName = "@targetcompid";
                pTargetcompid.DbType = System.Data.DbType.AnsiString;
                pTargetcompid.Size = 64;
                pTargetcompid.Value = this.sessionID.TargetCompID;
                command.Parameters.Add(pTargetcompid);

                var pSession_qualifier = command.CreateParameter();
                pSession_qualifier.ParameterName = "@session_qualifier";
                pSession_qualifier.DbType = System.Data.DbType.AnsiString;
                pSession_qualifier.Size = 64;
                pSession_qualifier.Value = this.sessionID.SessionQualifier;
                command.Parameters.Add(pSession_qualifier);

                var pText = command.CreateParameter();
                pText.ParameterName = "@text";
                pText.DbType = System.Data.DbType.AnsiString;
                pText.Value = msg;
                command.Parameters.Add(pText);

                command.ExecuteNonQuery();
            }
        }

        private DbConnection getConnection()
        {
            var dbFactory = DbProviderFactories.GetFactory(this.connectionStringSetting.ProviderName);

            var connection = dbFactory.CreateConnection();
            connection.ConnectionString = this.connectionStringSetting.ConnectionString;
            connection.Open();

            return connection;
        }
    }
}
