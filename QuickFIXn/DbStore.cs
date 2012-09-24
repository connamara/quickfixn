using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;

namespace QuickFix
{
    /*

Table structure:

CREATE TABLE [dbo].[sessions](
	[beginstring] [char](8) NOT NULL,
	[sendercompid] [varchar](64) NOT NULL,
	[targetcompid] [varchar](64) NOT NULL,
	[session_qualifier] [varchar](64) NULL,
	[creation_time] [datetime] NOT NULL,
	[sender_seqnum] [int] NOT NULL,
	[target_seqnum] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[beginstring] ASC,
	[sendercompid] ASC,
	[targetcompid] ASC,
	[session_qualifier] ASC
)
)

CREATE TABLE [dbo].[messages](
	[beginstring] [char](8) NOT NULL,
	[sendercompid] [varchar](64) NOT NULL,
	[targetcompid] [varchar](64) NOT NULL,
	[session_qualifier] [varchar](64) NULL,
	[msgseqnum] [int] NOT NULL,
	[message] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[beginstring] ASC,
	[sendercompid] ASC,
	[targetcompid] ASC,
	[session_qualifier] ASC,
	[msgseqnum] ASC
)
)

*/

    public class DbStore : MessageStore
    {
        object messagesLock = new object();
        object sessionsLock = new object();

        SessionID sessionID = null;
        ConnectionStringSettings connectionStringSetting = null;
        string getMessageCommandText = null;
        string setMessageCommandText = null;
        string clearMessagesCommandText = null;
        string createSessionCommandText = null;
        string getSessionCommandText = null;
        string updateSessionCommandText = null;

        public DbStore(SessionID sessionID, string connectionName, string getMessageCommandText, string setMessageCommandText, string clearMessagesCommandText, string createSessionCommandText, string getSessionCommandText, string updateSessionCommandText)
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

            this.getMessageCommandText =
                string.IsNullOrEmpty(getMessageCommandText) ?
                    @"
SELECT  message
FROM    messages
WHERE   beginstring = @beginstring
        AND sendercompid = @sendercompid
        AND targetcompid = @targetcompid
        AND ( ( NULLIF(session_qualifier,'') IS NULL AND NULLIF(@session_qualifier,'') IS NULL ) OR session_qualifier = @session_qualifier )
        AND msgseqnum >= @startSeqNum AND msgseqnum <= @endSeqNum
ORDER BY msgseqnum ASC"
                    : getMessageCommandText;

            this.setMessageCommandText =
                string.IsNullOrEmpty(setMessageCommandText) ?
                    @"
INSERT INTO messages (beginstring, sendercompid, targetcompid, session_qualifier, msgseqnum, message)
VALUES              (@beginstring, @sendercompid, @targetcompid, @session_qualifier, @msgseqnum, @message)"
                    : setMessageCommandText;

            this.clearMessagesCommandText =
                string.IsNullOrEmpty(clearMessagesCommandText) ?
                    @"
DELETE FROM messages
WHERE   beginstring = @beginstring
        AND sendercompid = @sendercompid
        AND targetcompid = @targetcompid
        AND ( ( NULLIF(session_qualifier,'') IS NULL AND NULLIF(@session_qualifier,'') IS NULL ) OR session_qualifier = @session_qualifier )"
                    : clearMessagesCommandText;

            this.createSessionCommandText =
                string.IsNullOrEmpty(createSessionCommandText) ?
                    @"
INSERT INTO sessions (beginstring, sendercompid, targetcompid, session_qualifier, creation_time, sender_seqnum, target_seqnum)
VALUES              (@beginstring, @sendercompid, @targetcompid, @session_qualifier, @creation_time, 1, 1)"
                    : createSessionCommandText;

            this.getSessionCommandText =
                string.IsNullOrEmpty(getSessionCommandText) ?
                    @"
SELECT  creation_time, sender_seqnum, target_seqnum
FROM    sessions
WHERE   beginstring = @beginstring
        AND sendercompid = @sendercompid
        AND targetcompid = @targetcompid
        AND ( ( NULLIF(session_qualifier,'') IS NULL AND NULLIF(@session_qualifier,'') IS NULL ) OR session_qualifier = @session_qualifier )"
                    : getSessionCommandText;

            this.updateSessionCommandText =
                string.IsNullOrEmpty(updateSessionCommandText) ?
                    @"
UPDATE  sessions
SET     creation_time = @creation_time,
        sender_seqnum = @sender_seqnum,
        target_seqnum = @target_seqnum
WHERE   beginstring = @beginstring
        AND sendercompid = @sendercompid
        AND targetcompid = @targetcompid
        AND ( ( NULLIF(session_qualifier,'') IS NULL AND NULLIF(@session_qualifier,'') IS NULL ) OR session_qualifier = @session_qualifier )"
                    : updateSessionCommandText;
        }

        public void Get(int startSeqNum, int endSeqNum, List<string> messages)
        {
            lock (this.messagesLock)
            {
                using (var connection = this.getConnection())
                {
                    var command = connection.CreateCommand();
                    command.CommandText = this.getMessageCommandText;

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

                    var pStartSeqNum = command.CreateParameter();
                    pStartSeqNum.ParameterName = "@startSeqNum";
                    pStartSeqNum.DbType = System.Data.DbType.Int32;
                    pStartSeqNum.Value = startSeqNum;
                    command.Parameters.Add(pStartSeqNum);

                    var pEndSeqNum = command.CreateParameter();
                    pEndSeqNum.ParameterName = "@endSeqNum";
                    pEndSeqNum.DbType = System.Data.DbType.Int32;
                    pEndSeqNum.Value = endSeqNum;
                    command.Parameters.Add(pEndSeqNum);

                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        messages.Add(dataReader.GetString(0));
                    }
                }
            }
        }

        public bool Set(int msgSeqNum, string msg)
        {
            lock (this.messagesLock)
            {
                using (var connection = this.getConnection())
                {
                    var command = connection.CreateCommand();
                    command.CommandText = this.setMessageCommandText;

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

                    var pStartSeqNum = command.CreateParameter();
                    pStartSeqNum.ParameterName = "@msgSeqNum";
                    pStartSeqNum.DbType = System.Data.DbType.Int32;
                    pStartSeqNum.Value = msgSeqNum;
                    command.Parameters.Add(pStartSeqNum);

                    var pMessage = command.CreateParameter();
                    pMessage.ParameterName = "@message";
                    pMessage.DbType = System.Data.DbType.String;
                    pMessage.Value = msg;
                    command.Parameters.Add(pMessage);

                    var result = command.ExecuteNonQuery();

                    return result == 1;
                }
            }
        }

        private void clearMessages()
        {
            using (var connection = this.getConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = this.clearMessagesCommandText;

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

                var rowCount = command.ExecuteNonQuery();
            }
        }

        public int GetNextSenderMsgSeqNum()
        {
            lock (this.sessionsLock)
            {
                DateTime? creation_time;
                int? sender_seqnum;
                int? target_seqnum;
                this.getSession(out creation_time, out sender_seqnum, out target_seqnum);

                return sender_seqnum.Value;
            }
        }

        public int GetNextTargetMsgSeqNum()
        {
            lock (this.sessionsLock)
            {
                DateTime? creation_time;
                int? sender_seqnum;
                int? target_seqnum;
                this.getSession(out creation_time, out sender_seqnum, out target_seqnum);

                return target_seqnum.Value;
            }
        }

        public void SetNextSenderMsgSeqNum(int value)
        {
            lock (this.sessionsLock)
            {
                DateTime? creation_time;
                int? sender_seqnum;
                int? target_seqnum;
                this.getSession(out creation_time, out sender_seqnum, out target_seqnum);

                this.updateSession(creation_time.Value, value, target_seqnum.Value);
            }
        }

        public void SetNextTargetMsgSeqNum(int value)
        {
            lock (this.sessionsLock)
            {
                DateTime? creation_time;
                int? sender_seqnum;
                int? target_seqnum;
                this.getSession(out creation_time, out sender_seqnum, out target_seqnum);

                this.updateSession(creation_time.Value, sender_seqnum.Value, value);
            }
        }

        public void IncrNextSenderMsgSeqNum()
        {
            lock (this.sessionsLock)
            {
                DateTime? creation_time;
                int? sender_seqnum;
                int? target_seqnum;
                this.getSession(out creation_time, out sender_seqnum, out target_seqnum);

                this.updateSession(creation_time.Value, sender_seqnum.Value + 1, target_seqnum.Value);
            }
        }

        public void IncrNextTargetMsgSeqNum()
        {
            lock (this.sessionsLock)
            {
                DateTime? creation_time;
                int? sender_seqnum;
                int? target_seqnum;
                this.getSession(out creation_time, out sender_seqnum, out target_seqnum);

                this.updateSession(creation_time.Value, sender_seqnum.Value, target_seqnum.Value + 1);
            }
        }

        public DateTime GetCreationTime()
        {
            lock (this.sessionsLock)
            {
                DateTime? creation_time;
                int? sender_seqnum;
                int? target_seqnum;
                this.getSession(out creation_time, out sender_seqnum, out target_seqnum);

                return creation_time.Value;
            }
        }

        public void Reset()
        {
            lock (this.sessionsLock)
            {
                this.clearMessages();

                DateTime? creation_time;
                int? sender_seqnum;
                int? target_seqnum;

                if (this.getSession(out creation_time, out sender_seqnum, out target_seqnum))
                    this.updateSession(DateTime.UtcNow, 1, 1);
                else
                    this.createSession();
            }
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        private bool getSession(out DateTime? creation_time, out int? sender_seqnum, out int? target_seqnum)
        {
            creation_time = null;
            sender_seqnum = null;
            target_seqnum = null;

            using (var connection = this.getConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = this.getSessionCommandText;

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

                var dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    creation_time = new DateTime(dataReader.GetDateTime(0).Ticks, DateTimeKind.Utc);
                    sender_seqnum = dataReader.GetInt32(1);
                    target_seqnum = dataReader.GetInt32(2);

                    return true;
                }
                else
                    return false;
            }
        }

        private void createSession()
        {
            using (var connection = this.getConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = this.createSessionCommandText;

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

                var pCreation_time = command.CreateParameter();
                pCreation_time.ParameterName = "@creation_time";
                pCreation_time.DbType = System.Data.DbType.DateTime;
                pCreation_time.Value = DateTime.UtcNow;
                command.Parameters.Add(pCreation_time);

                var rowCount = command.ExecuteNonQuery();
                if (rowCount != 1)
                    throw new InvalidOperationException("createSession failed");
            }
        }

        private void updateSession(DateTime creation_time, int sender_seqnum, int target_seqnum)
        {
            if (creation_time.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", "creation_time");

            using (var connection = this.getConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = this.updateSessionCommandText;

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

                var pCreation_time = command.CreateParameter();
                pCreation_time.ParameterName = "@creation_time";
                pCreation_time.DbType = System.Data.DbType.DateTime;
                pCreation_time.Value = creation_time;
                command.Parameters.Add(pCreation_time);

                var pSender_seqnum = command.CreateParameter();
                pSender_seqnum.ParameterName = "@sender_seqnum";
                pSender_seqnum.DbType = System.Data.DbType.Int32;
                pSender_seqnum.Value = sender_seqnum;
                command.Parameters.Add(pSender_seqnum);

                var pTarget_seqnum = command.CreateParameter();
                pTarget_seqnum.ParameterName = "@target_seqnum";
                pTarget_seqnum.DbType = System.Data.DbType.Int32;
                pTarget_seqnum.Value = target_seqnum;
                command.Parameters.Add(pTarget_seqnum);

                var rowCount = command.ExecuteNonQuery();
                if (rowCount != 1)
                    throw new InvalidOperationException("updateSession failed");
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
