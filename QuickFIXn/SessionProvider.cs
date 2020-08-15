using System;
using System.Collections.Generic;

namespace QuickFix
{
    /// <summary>
    /// Supporting wildcards in acceptor's session names (for session templates)
    /// to create a new Session upon connect, if its SessionID matches a template
    /// </summary>
    internal class SessionProvider
    {
        const string WildcardValue = "*";
        internal static bool IsSessionTemplate(SessionID sessionID)
        {
            return sessionID.SenderCompID.Equals(WildcardValue)
                || sessionID.SenderSubID.Equals(WildcardValue)
                || sessionID.SenderLocationID.Equals(WildcardValue)
                || sessionID.TargetCompID.Equals(WildcardValue)
                || sessionID.TargetSubID.Equals(WildcardValue)
                || sessionID.TargetLocationID.Equals(WildcardValue);
        }

        private Dictionary<SessionID, TemplateParams> _templates = new Dictionary<SessionID, TemplateParams>();
        internal void AddTemplate(SessionID sessionID, Dictionary dict, ThreadedSocketAcceptor acceptor, AcceptorSocketDescriptor descriptor)
        {
            lock (_templates)
            {
                if (_templates.ContainsKey(sessionID)) throw new ConfigError($"Duplicate session template {sessionID}");
                _templates.Add(sessionID, new TemplateParams(dict, acceptor, descriptor));
            }
        }
        /// <summary>
        /// Looks up an earlier created session, or creates a new one,
        /// if the SessionID matches a session's template
        /// </summary>
        internal Session GetSession(SessionID sessionID)
        {
            Session session = Session.LookupSession(sessionID);
            if (null == session) session = CreateFromTemplate(sessionID);
            return session;
        }
        /// <summary>
        /// If the given SessionID matches any of the templates,
        /// creates and returns the new session from the first matching template
        /// </summary>
        /// <param name="sessionID">Session name without wildcards</param>
        private Session CreateFromTemplate(SessionID sessionID)
        {
            lock (_templates)
            {
                foreach (KeyValuePair<SessionID, TemplateParams> kv in _templates)
                {
                    if (IsMatching(sessionID, kv.Key))
                    {
                        Dictionary dict = ReplaceWildcardsInSettins(sessionID, kv.Key, kv.Value.Dict);
                        kv.Value.Acceptor.SetSessionSettings(sessionID, dict);
                        return kv.Value.Acceptor.CreateAcceptorSession(sessionID, dict, kv.Value.Descriptor);
                    }
                }
                return null;
            }
        }

        private static bool IsMatching(SessionID sessionID, SessionID templateID)
        {
            // Matching if for all parts (templateID is "*" AND sessionID is set) OR (templateID == sessionID)
            return templateID.BeginString.Equals(sessionID.BeginString) // do not allow a wildcard for BeginString, as would have to implement logic to switch data dictionary to match FIX version, which does not seem to worth it...
                && ((templateID.SenderCompID.Equals(WildcardValue) && !sessionID.SenderCompID.Equals(SessionID.NOT_SET)) || templateID.SenderCompID.Equals(sessionID.SenderCompID))
                && ((templateID.SenderSubID.Equals(WildcardValue) && !sessionID.SenderSubID.Equals(SessionID.NOT_SET)) || templateID.SenderSubID.Equals(sessionID.SenderSubID))
                && ((templateID.SenderLocationID.Equals(WildcardValue) && !sessionID.SenderLocationID.Equals(SessionID.NOT_SET)) || templateID.SenderLocationID.Equals(sessionID.SenderLocationID))
                && ((templateID.TargetCompID.Equals(WildcardValue) && !sessionID.TargetCompID.Equals(SessionID.NOT_SET)) || templateID.TargetCompID.Equals(sessionID.TargetCompID))
                && ((templateID.TargetSubID.Equals(WildcardValue) && !sessionID.TargetSubID.Equals(SessionID.NOT_SET)) || templateID.TargetSubID.Equals(sessionID.TargetSubID))
                && ((templateID.TargetLocationID.Equals(WildcardValue) && !sessionID.TargetLocationID.Equals(SessionID.NOT_SET)) || templateID.TargetLocationID.Equals(sessionID.TargetLocationID));
        }

        private static Dictionary ReplaceWildcardsInSettins(SessionID sessionID, SessionID templateID, Dictionary dict)
        {
            QuickFix.Dictionary actualSettings = new QuickFix.Dictionary(dict);
            if (WildcardValue.Equals(templateID.SenderCompID)) actualSettings.SetString(SessionSettings.SENDERCOMPID, sessionID.SenderCompID);
            if (WildcardValue.Equals(templateID.SenderSubID)) actualSettings.SetString(SessionSettings.SENDERSUBID, sessionID.SenderSubID);
            if (WildcardValue.Equals(templateID.SenderLocationID)) actualSettings.SetString(SessionSettings.SENDERLOCID, sessionID.SenderLocationID);
            if (WildcardValue.Equals(templateID.TargetCompID)) actualSettings.SetString(SessionSettings.TARGETCOMPID, sessionID.TargetCompID);
            if (WildcardValue.Equals(templateID.TargetSubID)) actualSettings.SetString(SessionSettings.TARGETSUBID, sessionID.TargetSubID);
            if (WildcardValue.Equals(templateID.TargetLocationID)) actualSettings.SetString(SessionSettings.TARGETLOCID, sessionID.TargetLocationID);
            return actualSettings;
        }
    }

    internal class TemplateParams
    {
        internal Dictionary Dict { get; }
        internal ThreadedSocketAcceptor Acceptor { get; }
        internal AcceptorSocketDescriptor Descriptor { get; }
        internal TemplateParams(Dictionary dict, ThreadedSocketAcceptor acceptor, AcceptorSocketDescriptor descriptor)
        {
            Dict = dict;
            Acceptor = acceptor;
            Descriptor = descriptor;
        }
    }
}
