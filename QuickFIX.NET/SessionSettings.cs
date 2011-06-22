using System.IO;
using System.Collections.Generic;

namespace QuickFix
{
    public class SessionSettings
    {
        #region Public Constants
        
        public const string BEGINSTRING  = "BeginString";
        public const string SENDERCOMPID = "SenderCompID";
        public const string TARGETCOMPID = "TargetCompID";
        public const string SESSION_QUALIFIER = "SessionQualifier";
        public const string DEFAULT_APPLVERID = "DefaultApplVerID";
        public const string CONNECTION_TYPE = "ConnectionType";

        #endregion

        #region Private Members
        
        private QuickFix.Dictionary defaults_ = new QuickFix.Dictionary();
        private System.Collections.Generic.Dictionary<SessionID, QuickFix.Dictionary> settings_ = new Dictionary<SessionID, Dictionary>();
        
        #endregion

        public SessionSettings(string file)
        {
            try
            {
                FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read);
                Load(new StreamReader(fs));
            }
            catch(System.Exception e)
            {
                throw new ConfigError("File " + file + " not found (" + e.Message + ")");
            }
        }

        public SessionSettings(TextReader conf)
        {
            Load(conf);
        }

        public static bool IsComment(string s)
        {
            if (s.Length < 1)
                return false;
            return '#' == s[0];
        }

        public static bool IsKeyValue(string s)
        {
            return s.IndexOf('=') != -1;
        }

        public static bool IsSection(string s)
        {
            if (s.Length < 2)
                return false;
            return s[0] == '[' && s[s.Length - 1] == ']';
        }

        /// <summary>
        /// Strip the outer '[' and ']' from the section name, e.g. '[DEFAULT]' becomes 'DEFAULT'
        /// </summary>
        /// <param name="s">the section name</param>
        /// <returns></returns>
        public static string SplitSection(string s)
        {
            return s.Trim('[', ']').Trim();
        }

        protected void Load(TextReader conf)
        {
            Settings settings = new Settings();
            QuickFix.Dictionary currentSection = null;

            string line = null;
            while ((line = conf.ReadLine()) != null)
            {
                line = line.Trim();
                if (IsComment(line))
                {
                    continue;
                }
                else if (IsSection(line))
                {
                    currentSection = settings.Add(new Dictionary(SplitSection(line)));
                }
                else if (IsKeyValue(line))
                {
                    string[] kv = line.Split('=');
                    if (currentSection != null)
                        currentSection.SetString(kv[0].Trim(), kv[1].Trim());
                }
            }

            //---- load the DEFAULT section
            LinkedList<QuickFix.Dictionary> section = settings.Get("DEFAULT");
            QuickFix.Dictionary def = new QuickFix.Dictionary();
            if (section.Count > 0)
                def = section.First.Value;
            Set(def);

            //---- load each SESSION section
            section = settings.Get("SESSION");
            foreach (QuickFix.Dictionary dict in section)
            {
                dict.Merge(def);

                string sessionQualifier = "";
                if (dict.Has(SESSION_QUALIFIER))
                    sessionQualifier = dict.GetString(SESSION_QUALIFIER);
                SessionID sessionID = new SessionID(dict.GetString(BEGINSTRING), dict.GetString(SENDERCOMPID), dict.GetString(TARGETCOMPID), sessionQualifier);
                Set(sessionID, dict);
            }
        }

        public bool Has(SessionID sessionID)
        {
            return settings_.ContainsKey(sessionID);
        }

        /// <summary>
        /// Get global default settings
        /// </summary>
        /// <returns>Dictionary of settings from the [DEFAULT] section</returns>
        public QuickFix.Dictionary Get()
        {
            return defaults_;
        }

        /// <summary>
        /// Get a dictionary for a session
        /// </summary>
        /// <param name="sessionID">the ID of the session</param>
        /// <returns>Dictionary of settings from the [SESSION] section for the given SessionID</returns>
        public Dictionary Get(SessionID sessionID)
        {
            Dictionary dict;
            if (!settings_.TryGetValue(sessionID, out dict))
                throw new ConfigError("Session '" + sessionID + "' not found");
            return dict;
        }

        public void Set(QuickFix.Dictionary defaults)
        {
            defaults_ = defaults;
            foreach (KeyValuePair<SessionID, QuickFix.Dictionary> entry in settings_)
                entry.Value.Merge(defaults_);
        }
        
        public void Set(SessionID sessionID, QuickFix.Dictionary settings)
        {
            if (Has(sessionID))
                throw new ConfigError("Duplicate Session " + sessionID.ToString());
            settings.SetString(BEGINSTRING, sessionID.BeginString);
            settings.SetString(SENDERCOMPID, sessionID.SenderCompID);
            settings.SetString(TARGETCOMPID, sessionID.TargetCompID);
            settings.Merge(defaults_);
            Validate(settings);
            settings_[sessionID] = settings;
        }

        protected void Validate(QuickFix.Dictionary dictionary)
        {
            string beginString = dictionary.GetString(BEGINSTRING);
            if (beginString != Values.BeginString_FIX40 &&
                beginString != Values.BeginString_FIX42 &&
                beginString != Values.BeginString_FIX43 &&
                beginString != Values.BeginString_FIX44 &&
                beginString != Values.BeginString_FIXT11)
            {
                throw new ConfigError(BEGINSTRING + " must be FIX.4.0 to FIX.4.4 or FIXT.1.1");
            }

            string connectionType = dictionary.GetString(CONNECTION_TYPE);
            if (connectionType != "initiator" &&
               connectionType != "acceptor")
            {
                throw new ConfigError(CONNECTION_TYPE + " must be 'initiator' or 'acceptor'");
            }
        }
    }
             
            /*
std::ostream& operator<<( std::ostream& stream, const SessionSettings& s )
{
  const Dictionary& defaults = s.m_defaults;
  if( defaults.size() )
  {
    stream << "[DEFAULT]" << std::endl;
    Dictionary::iterator i;
    for( i = defaults.begin(); i != defaults.end(); ++i )
      stream << i->first << "=" << i->second << std::endl;
    stream << std::endl;
  }

  std::set<SessionID> sessions = s.getSessions();
  std::set<SessionID>::iterator i;
  for( i = sessions.begin(); i != sessions.end(); ++i )
  {
    stream << "[SESSION]" << std::endl;
    const Dictionary& section = s.get( *i );
    if( !section.size() ) continue;

    Dictionary::iterator i;
    for( i = section.begin(); i != section.end(); ++i )
    {
      if( defaults.has(i->first) && defaults.getString(i->first) == i->second )
        continue;
      stream << i->first << "=" << i->second << std::endl;
    }
    stream << std::endl;
  }

  return stream;
}

const bool SessionSettings::has( const SessionID& sessionID ) const
{ QF_STACK_PUSH(SessionSettings::has)
  return m_settings.find( sessionID ) != m_settings.end();
  QF_STACK_POP
}

const Dictionary& SessionSettings::get( const SessionID& sessionID ) const
throw( ConfigError )
{ QF_STACK_PUSH(SessionSettings::get)

  Dictionaries::const_iterator i;
  i = m_settings.find( sessionID );
  if ( i == m_settings.end() ) throw ConfigError( "Session not found" );
  return i->second;

  QF_STACK_POP
}





std::set < SessionID > SessionSettings::getSessions() const
{ QF_STACK_PUSH(SessionSettings::getSessions)

  std::set < SessionID > result;
  Dictionaries::const_iterator i;
  for ( i = m_settings.begin(); i != m_settings.end(); ++i )
    result.insert( i->first );
  return result;

  QF_STACK_POP
}



}
         * */

}
