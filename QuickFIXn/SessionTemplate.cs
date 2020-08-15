using System;
using System.Collections.Generic;

namespace QuickFix
{
    /// <summary>
    /// Support for wildcards in session names, i.e for session templates,
    /// to create a session upon connect, if its SessionID matches a template
    /// </summary>
    internal static class SessionTemplate
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
        /// <summary>
        /// Settings, Acceptor and Socket Descriptor for each "template" SessionID 
        /// </summary>
        private static Dictionary<SessionID, TemplateParams> _templates =
            new Dictionary<SessionID, TemplateParams>();
        internal static void AddTemplate(SessionID sessionID, Dictionary dict, ThreadedSocketAcceptor acceptor, AcceptorSocketDescriptor descriptor)
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
        internal static Session GetSession(SessionID sessionID)
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
        private static Session CreateFromTemplate(SessionID sessionID)
        {
            lock (_templates)
            {
                foreach (KeyValuePair<SessionID, TemplateParams> kv in _templates)
                {
                    if (IsMatching(sessionID, kv.Key))
                    {
                        Dictionary dict = ReplaceWildcardsInSettins(sessionID, kv.Value.Dict);
                        return kv.Value.Acceptor.CreateAcceptorSession(sessionID, dict, kv.Value.Descriptor);
                    }
                }
                return null;
            }
        }

        private static bool IsMatching(SessionID sessionID, SessionID templateID)
        {
            // matching if for all parts (templateID is "*" AND sessionID is set) OR (templateID == sessionID)
            return templateID.BeginString.Equals(sessionID.BeginString) // do not allow a wildcard for BeginString, as would have to implement logic to switch data dictionary to match FIX version, which does not seem to worth it...
                && ((templateID.SenderCompID.Equals(WildcardValue) && !sessionID.SenderCompID.Equals(SessionID.NOT_SET)) || templateID.SenderCompID.Equals(sessionID.SenderCompID))
                && ((templateID.SenderSubID.Equals(WildcardValue) && !sessionID.SenderSubID.Equals(SessionID.NOT_SET)) || templateID.SenderSubID.Equals(sessionID.SenderSubID))
                && ((templateID.SenderLocationID.Equals(WildcardValue) && !sessionID.SenderLocationID.Equals(SessionID.NOT_SET)) || templateID.SenderLocationID.Equals(sessionID.SenderLocationID))
                && ((templateID.TargetCompID.Equals(WildcardValue) && !sessionID.TargetCompID.Equals(SessionID.NOT_SET)) || templateID.TargetCompID.Equals(sessionID.TargetCompID))
                && ((templateID.TargetSubID.Equals(WildcardValue) && !sessionID.TargetSubID.Equals(SessionID.NOT_SET)) || templateID.TargetSubID.Equals(sessionID.TargetSubID))
                && ((templateID.TargetLocationID.Equals(WildcardValue) && !sessionID.TargetLocationID.Equals(SessionID.NOT_SET)) || templateID.TargetLocationID.Equals(sessionID.TargetLocationID));
        }

        private static Dictionary ReplaceWildcardsInSettins(SessionID sessionID, Dictionary dict)
        {
            QuickFix.Dictionary actualSettings = new QuickFix.Dictionary(dict);
            if (WildcardValue.Equals(sessionID.BeginString)) actualSettings.SetString(SessionSettings.BEGINSTRING, sessionID.BeginString);
            if (WildcardValue.Equals(sessionID.SenderCompID)) actualSettings.SetString(SessionSettings.SENDERCOMPID, sessionID.SenderCompID);
            if (WildcardValue.Equals(sessionID.SenderSubID)) actualSettings.SetString(SessionSettings.SENDERSUBID, sessionID.SenderSubID);
            if (WildcardValue.Equals(sessionID.SenderLocationID)) actualSettings.SetString(SessionSettings.SENDERLOCID, sessionID.SenderLocationID);
            if (WildcardValue.Equals(sessionID.TargetCompID)) actualSettings.SetString(SessionSettings.TARGETCOMPID, sessionID.TargetCompID);
            if (WildcardValue.Equals(sessionID.TargetSubID)) actualSettings.SetString(SessionSettings.TARGETSUBID, sessionID.TargetSubID);
            if (WildcardValue.Equals(sessionID.TargetLocationID)) actualSettings.SetString(SessionSettings.TARGETLOCID, sessionID.TargetLocationID);
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
