using System.Collections.Generic;

namespace QuickFix
{
    public class SessionFactory
    {
        protected Application application_;
        protected MessageStoreFactory messageStoreFactory_;
        protected LogFactory logFactory_;

        public SessionFactory(Application app, MessageStoreFactory storeFactory)
            : this(app, storeFactory, null)
        { }

        public SessionFactory(Application app, MessageStoreFactory storeFactory, LogFactory logFactory)
        {
            application_ = app;
            messageStoreFactory_ = storeFactory;
            logFactory_ = logFactory;
        }

        public Session Create(SessionID sessionID, QuickFix.Dictionary settings)
        {
            string connectionType = settings.GetString(SessionSettings.CONNECTION_TYPE);
            if (!"acceptor".Equals(connectionType) && !"initiator".Equals(connectionType))
                throw new ConfigError("Invalid ConnectionType");

            if ("acceptor".Equals(connectionType) && settings.Has(SessionSettings.SESSION_QUALIFIER))
                throw new ConfigError("SessionQualifier cannot be used with acceptor.");

            bool useDataDictionary = true;
            if (settings.Has(SessionSettings.USE_DATA_DICTIONARY))
                useDataDictionary = settings.GetBool(SessionSettings.USE_DATA_DICTIONARY);

            string defaultApplVerID = "";
            if (sessionID.IsFIXT)
            {
                throw new System.NotImplementedException("FIXME - SessionFactory cannot handle FIXT Sessions!");
                /*
                if (!settings.Has(SessionSettings.DEFAULT_APPLVERID))
                {
                    throw new ConfigError("ApplVerID is required for FIXT transport");
                }
                defaultApplVerID = Message.ToApplVerID(settings.GetString(SessionSettings.DEFAULT_APPLVERID));
                */
            }

            DataDictionaryProvider dataDictionaryProvider = new DataDictionaryProvider();
            if (useDataDictionary)
            {
                throw new System.NotImplementedException("FIXME - SessionFactory cannot handle UseDataDictionary=Y!");
                /*
                if (sessionID.IsFIXT)
                {
                    ProcessFixtDataDictionaries(sessionID, settings, dataDictionaryProvider);
                }
                else
                {
                    ProcessFixDataDictionary(sessionID, settings, dataDictionaryProvider);
                }
                */
            }

            int heartBtInt = 0;
            if ( connectionType == "initiator" )
            {
                heartBtInt = System.Convert.ToInt32(settings.GetLong( SessionSettings.HEARTBTINT ));
                if ( heartBtInt <= 0 )
                    throw new ConfigError( "Heartbeat must be greater than zero" );
            }
            
            Session session = new Session( application_, messageStoreFactory_, sessionID, dataDictionaryProvider, new SessionSchedule(settings, sessionID), heartBtInt, logFactory_ );
            session.SetSenderDefaultApplVerID(defaultApplVerID);

            /** FIXME - implement optional settings
            if (settings.Has(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS))
                session.SetSendRedundantResendRequests(settings.GetBool(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS));
            if (settings.Has(SessionSettings.CHECK_COMPID))
                session.SetCheckCompId(settings.GetBool(SessionSettings.CHECK_COMPID));
            if (settings.Has(SessionSettings.CHECK_LATENCY))
                session.SetCheckLatency(settings.GetBool(SessionSettings.CHECK_LATENCY));
            if (settings.Has(SessionSettings.MAX_LATENCY))
                session.SetMaxLatency(settings.GetLong(SessionSettings.MAX_LATENCY));
            if (settings.Has(SessionSettings.LOGON_TIMEOUT))
                session.SetLogonTimeout(settings.GetLong(SessionSettings.LOGON_TIMEOUT));
            if (settings.Has(SessionSettings.LOGOUT_TIMEOUT))
                session.SetLogoutTimeout(settings.GetLong(SessionSettings.LOGOUT_TIMEOUT));
            */
            if (settings.Has(SessionSettings.RESET_ON_LOGON))
                session.ResetOnLogon = settings.GetBool(SessionSettings.RESET_ON_LOGON);
            if (settings.Has(SessionSettings.RESET_ON_LOGOUT))
                session.ResetOnLogout = settings.GetBool(SessionSettings.RESET_ON_LOGOUT);
            if (settings.Has(SessionSettings.RESET_ON_DISCONNECT))
                session.ResetOnDisconnect = settings.GetBool(SessionSettings.RESET_ON_DISCONNECT);
            if (settings.Has(SessionSettings.REFRESH_ON_LOGON))
                session.RefreshOnLogon = settings.GetBool(SessionSettings.REFRESH_ON_LOGON);
            /** FIXME - implement optional settings
            if (settings.Has(SessionSettings.MILLISECONDS_IN_TIMESTAMP))
                session.SetMillisecondsInTimeStamp(settings.GetBool(SessionSettings.MILLISECONDS_IN_TIMESTAMP));
            if (settings.Has(SessionSettings.PERSIST_MESSAGES))
                session.SetPersistMessages(settings.GetBool(SessionSettings.PERSIST_MESSAGES));
            if (settings.Has(SessionSettings.VALIDATE_LENGTH_AND_CHECKSUM))
                session.SetValidateLengthAndChecksum(settings.GetBool(SessionSettings.VALIDATE_LENGTH_AND_CHECKSUM));
            */

            return session;
        }

        private void XXXSessionTimeStuff()
        {
            /*
            bool useLocalTime = false;
            if (settings.Has(SessionSettings.USE_LOCAL_TIME))
                useLocalTime = settings.GetBool(SessionSettings.USE_LOCAL_TIME);

            int startDay = -1;
            int endDay = -1;
            try
            {
                startDay = settings.GetDay(SessionSettings.START_DAY);
                endDay = settings.GetDay(SessionSettings.END_DAY);
            }
            catch (ConfigError)
            { }
            catch (FieldConvertError e)
            {
                throw new ConfigError(e.Message);
            }
            */

            /* FIXME need to implement Session time stuff
            UtcTimeOnly startTime = new UtcTimeOnly();
            UtcTimeOnly endTime = new UtcTimeOnly();
            try
            {
                startTime = UtcTimeOnlyConvertor.Convert( settings.GetString( SessionSettings.START_TIME ) );
                endTime = UtcTimeOnlyConvertor.Convert( settings.GetString( SessionSettings.END_TIME ) );
            }
            catch (FieldConvertError e)
            {
                throw new ConfigError(e.Message);
            }
            
            
            TimeRange utcSessionTime( startTime, endTime, startDay, endDay );
            TimeRange localSessionTime(
                LocalTimeOnly(startTime.getHour(), startTime.getMinute(), startTime.getSecond()),
                LocalTimeOnly(endTime.getHour(), endTime.getMinute(), endTime.getSecond()), 
                startDay, endDay );
            TimeRange sessionTimeRange = useLocalTime ? localSessionTime : utcSessionTime;

            if( startDay >= 0 && endDay < 0 )
                throw new ConfigError( "StartDay used without EndDay" );
            if( endDay >= 0 && startDay < 0 )
                throw new ConfigError( "EndDay used without StartDay" );
            */

            /*
            int logonDay = startDay;
            int logoutDay = endDay;
            try
            {
            logonDay = settings.GetDay( SessionSettings.LOGON_DAY );
            logoutDay = settings.GetDay( SessionSettings.LOGOUT_DAY );
            }
            catch( ConfigError ) 
            { }
            catch( FieldConvertError e ) 
            { 
              throw new ConfigError( e.Message ); 
            }

            UtcTimeOnly logonTime( startTime );
            UtcTimeOnly logoutTime( endTime );
            try
            {
            logonTime = UtcTimeOnlyConvertor.convert( settings.GetString( SessionSettings.LOGON_TIME ) );
            }
            catch( ConfigError)
            { }
            catch( FieldConvertError e ) 
            {
              throw new ConfigError( e.Message);
            }

            try
            {
            logoutTime = UtcTimeOnlyConvertor.Convert( settings.GetString( SessionSettings.LOGOUT_TIME ) );
            }
            catch( ConfigError )
            { }
            catch( FieldConvertError e )
            {
              throw new ConfigError( e.Message);
            }

            TimeRange utcLogonTime( logonTime, logoutTime, logonDay, logoutDay );
            TimeRange localLogonTime(
              LocalTimeOnly(logonTime.GetHour, logonTime.GetMinute, logonTime.GetSecond),
              LocalTimeOnly(logoutTime.GetHour, logoutTime.GetMinute, logoutTime.GetSecond),
              logonDay, logoutDay );
            TimeRange logonTimeRange = useLocalTime ? localLogonTime : utcLogonTime;

            if( !sessionTimeRange.IsInRange(logonTime, logonDay) )
            throw new ConfigError( "LogonTime must be between StartTime and EndTime" );
            if( !sessionTimeRange.IsInRange(logoutTime, logoutDay) )
            throw new ConfigError( "LogoutTime must be between StartTime and EndTime" );
            pSession->setLogonTime( logonTimeRange );
            */
        }
    }
}
