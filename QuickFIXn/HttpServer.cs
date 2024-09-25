using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using QuickFix.Fields.Converters;

namespace QuickFix;

public class HttpServer : IDisposable {
    private readonly HttpListener _httpListener;
    private readonly Thread _connectionThread;
    private bool _running, _disposed;
    private readonly SessionSettings _sessionSettings;

    private readonly IReadOnlyList<Session> _sessions;

    private static class ToggleParam {
        public const string Enabled = "enabled";
        public const string SendRedundantResendRequests = "sendRedundantResendRequests";
        public const string CheckCompId = "checkCompId";
        public const string CheckLatency = "checkLatency";
        public const string ResetOnLogon = "resetOnLogon";
        public const string ResetOnLogout = "resetOnLogout";
        public const string ResetOnDisconnect = "resetOnDisconnect";
        public const string RefreshOnLogon = "refreshOnLogon";
        public const string MsInTimestamp = "msInTimestamp";
        public const string PersistMessages = "persistMessages";
    }

    private static class AdjustParam {
        public const string MaxLatency = "maxLatency";
        public const string LogonTimeout = "logonTimeout";
        public const string LogoutTimeout = "logoutTimeout";

        public const string Minus10 = "minus10";
        public const string Minus1 = "minus1";
        public const string Plus1 = "plus1";
        public const string Plus10 = "plus10";

        public static int ToInt(string adjustmentSymbol) {
            return adjustmentSymbol switch
            {
                Minus10 => -10,
                Minus1 => -1,
                Plus1 => 1,
                Plus10 => 10,
                _ => throw new ApplicationException($"I don't recognize adjustment symbol {adjustmentSymbol}")
            };
        }
    }

    public HttpServer(string prefix, SessionSettings sessionSettings) {
        if (!HttpListener.IsSupported) {
            // Requires at least a Windows XP with Service Pack 2
            throw new NotSupportedException(
                "The Http Server cannot run on this operating system.");
        }

        _httpListener = new HttpListener();
        _httpListener.Prefixes.Add(prefix);
        _sessionSettings = sessionSettings;

        List<Session> sessionsList = new();
        foreach (SessionID sessionId in sessionSettings.GetSessions().OrderBy(x => x.ToString())) {
            Session session = Session.LookupSession(sessionId)!; // cast away the nullable status
            sessionsList.Add(session);
        }

        _sessions = sessionsList.AsReadOnly();

        _connectionThread = new Thread(ConnectionThreadStart);
    }

    public void Start() {
        if (!_httpListener.IsListening) {
            _httpListener.Start();
            _running = true;
            // Use a thread to listen to the Http requests
            _connectionThread.Start();
        }
    }

    public void Stop() {
        if (_httpListener.IsListening) {
            _running = false;
            _httpListener.Stop();
        }
    }

    private void ConnectionThreadStart() {
        try {
            while (_running) {
                HttpListenerContext context = _httpListener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<html>");
                sb.AppendLine("  <head>");
                sb.AppendLine("    <title>QuickFIX/n Engine Simple Web Interface</title>");
                sb.AppendLine();
                sb.AppendLine("    <style type=\"text/css\">");
                sb.AppendLine("      a { display: inline-block; color: #0000EE; padding: 5px 10px; text-align: center; }");
                sb.AppendLine("      a:hover { background-color: #ccbeff; }");
                sb.AppendLine("      a:visited { background-color: #ccbeff; color: #0000EE; }");
                sb.AppendLine("      h1 { text-align: center; }");
                sb.AppendLine("      h1 a, h1 a:visited { text-decoration: none; color: black; }");
                sb.AppendLine("      div.header-line { text-align: center; }");
                sb.AppendLine("      div.header-line a { margin-left: 10px; margin-right: 10px; }");
                sb.AppendLine("      div.sessions-count { font-weight: bold; font-style: italic; }");
                sb.AppendLine("      table { border-width: 1px, padding: 2px; width: 100%; }");
                sb.AppendLine("      table#details-table tr th { font-weight: normal; }");
                sb.AppendLine("      table#details-table tr.head th { font-weight: bold; }");
                sb.AppendLine("      table#details-table th,td { padding: 2px 0; }");
                sb.AppendLine("      th { text-align: left }");
                sb.AppendLine("      td.adjusters a { margin-left: 7px; margin-right: 7px; min-width: 20px;}");
                sb.AppendLine("      [data-tooltip]:hover::after {");
                sb.AppendLine("        display: block;");
                sb.AppendLine("        position: absolute;");
                sb.AppendLine("        content: attr(data-tooltip);");
                sb.AppendLine("        color: black;");
                sb.AppendLine("        border: 1px solid black;");
                sb.AppendLine("        border-radius: 6px;");
                sb.AppendLine("        background: #ffffc2;");
                sb.AppendLine("        padding: 2px 5px;");
                sb.AppendLine("        margin-top:-45px;");
                sb.AppendLine("        margin-left: -20px;");
                sb.AppendLine("        font-size: 20px;");
                sb.AppendLine("      }");
                sb.AppendLine("      .error-message { color: red; font-weight: bold; text-align: center;}");
                sb.AppendLine("    </style>");
                sb.AppendLine();
                sb.AppendLine("  <body>");
                sb.AppendLine("    <h1><a href=\"/\">QuickFIX/n Engine Simple Web Interface</a></h1>");
                sb.AppendLine("    <hr/>");
                sb.AppendLine();

                try {
                    switch (request.Url?.AbsolutePath) {
                        case "/":
                            RenderRoot(sb);
                            break;
                        case "/session":
                            RenderSession(request, sb);
                            break;
                        case "/resetAll":
                            foreach (Session sess in _sessions)
                                sess.Reset("Reset all sessions from web interface");
                            response.Redirect("/");
                            response.Close();
                            continue;
                        case "/refreshAll":
                            foreach (Session sess in _sessions)
                                sess.Refresh();
                            response.Redirect("/");
                            response.Close();
                            continue;
                        case "/enableAll":
                            foreach (Session sess in _sessions)
                                sess.Logon();
                            response.Redirect("/");
                            response.Close();
                            continue;
                        case "/disableAll":
                            foreach (Session sess in _sessions)
                                sess.Logout();
                            response.Redirect("/");
                            response.Close();
                            continue;
                        case "/resetSession":
                            ResetSessionAndRedirect(request, response);
                            continue;
                        case "/refreshSession":
                            RefreshSessionAndRedirect(request, response);
                            continue;

                        default:
                            throw new ApplicationException("unrecognized url");
                    }
                } catch (Exception ex) {
                    sb.AppendLine("    <h2 class=\"error-message\">An error occurred:</h2>");
                    sb.AppendLine($"    <h2 class=\"error-message\">{ex.Message}</h2>");
                    sb.AppendLine("    <div>Full exception info:</div>");
                    sb.AppendLine($"    <pre>{ex}</pre>");
                }

                sb.AppendLine("  </body>");
                sb.AppendLine("</html>");
                sb.AppendLine("");

                byte[] buffer = Encoding.UTF8.GetBytes(sb.ToString());
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }
        } catch (HttpListenerException) {
            Console.WriteLine("HTTP server was shut down.");
        }
    }

    private void RenderRoot(StringBuilder sb) {
        sb.AppendLine($"    <div class=\"header-line sessions-count\">{_sessionSettings.GetSessions().Count} Sessions managed by QuickFIX/n</div>");
        sb.AppendLine("    <hr/>");
        sb.AppendLine();

        sb.AppendLine("    <div class=\"header-line\">");
        sb.AppendLine("      <a href=\"/resetAll\" onclick=\"return confirm('Reset ALL sessions?')\">RESET ALL</a>");
        sb.AppendLine("      <a href=\"/refreshAll\" onclick=\"return confirm('Refresh ALL sessions?')\">REFRESH ALL</a>");
        sb.AppendLine("      <a href=\"/enableAll\" onclick=\"return confirm('Enable ALL sessions?')\">ENABLE ALL</a>");
        sb.AppendLine("      <a href=\"/disableAll\" onclick=\"return confirm('Disable ALL sessions?')\">DISABLE ALL</a>");
        sb.AppendLine("    </div>");
        sb.AppendLine("    <hr/>");

        sb.AppendLine("    <table id=\"sessions-table\">");

        sb.AppendLine("      <tr>");
        var headers = new[] { "Session", "Type", "Enabled", "Session Time", "Logged On", "Next Incoming", "Next Outgoing" };
        foreach (string str in headers) {
            sb.AppendLine($"        <th>{str}</th>");
        }

        sb.AppendLine("      </tr>");

        for (int idx = 0; idx < _sessions.Count; idx++) {
            Session session = _sessions[idx];

            sb.AppendLine("      <tr>");
            sb.AppendLine($"        <td><a href=\"session?idx={idx}\">{session.SessionID}</a>");
            sb.AppendLine($"        <td>{(session.IsInitiator ? "initiator" : "acceptor")}");
            sb.AppendLine($"        <td>{(session.IsEnabled ? "yes" : "no")}");
            sb.AppendLine($"        <td>{(session.IsSessionTime ? "yes" : "no")}");
            sb.AppendLine($"        <td>{(session.IsLoggedOn ? "yes" : "no")}");
            sb.AppendLine($"        <td>{session.NextTargetMsgSeqNum.ToString()}");
            sb.AppendLine($"        <td>{session.NextSenderMsgSeqNum.ToString()}");
            sb.AppendLine("      </tr>");
        }

        sb.Append("    </table>");
    }

    private void RenderSession(HttpListenerRequest request, StringBuilder sb) {
        (int sessionIdx, Session session) = GetSessionFromRequest(request);

        if (bool.TryParse(request.QueryString[ToggleParam.Enabled], out var toEnabled)) {
            if (toEnabled)
                session.Logon();
            else
                session.Logout();
        }

        if (bool.TryParse(request.QueryString[ToggleParam.SendRedundantResendRequests], out var toSendRrr))
            session.SendRedundantResendRequests = toSendRrr;
        if (bool.TryParse(request.QueryString[ToggleParam.CheckCompId], out var toCheckCompId))
            session.CheckCompID = toCheckCompId;
        if (bool.TryParse(request.QueryString[ToggleParam.CheckLatency], out var toCheckLatency))
            session.CheckLatency = toCheckLatency;

        if (request.QueryString[AdjustParam.MaxLatency] is not null) {
            string adjustmentSymbol = request.QueryString[AdjustParam.MaxLatency]!;
            int newVal = session.MaxLatency + AdjustParam.ToInt(adjustmentSymbol);
            session.MaxLatency = newVal < 0 ? 0 : newVal;
        }
        if (request.QueryString[AdjustParam.LogonTimeout] is not null) {
            string adjustmentSymbol = request.QueryString[AdjustParam.LogonTimeout]!;
            int newVal = session.LogonTimeout + AdjustParam.ToInt(adjustmentSymbol);
            session.LogonTimeout = newVal < 0 ? 0 : newVal;
        }
        if (request.QueryString[AdjustParam.LogoutTimeout] is not null) {
            var adjustmentSymbol = request.QueryString[AdjustParam.LogoutTimeout]!;
            int newVal = session.LogoutTimeout + AdjustParam.ToInt(adjustmentSymbol);
            session.LogoutTimeout = newVal < 0 ? 0 : newVal;
        }

        if (bool.TryParse(request.QueryString[ToggleParam.ResetOnLogon], out var toResetOnLogon))
            session.ResetOnLogon = toResetOnLogon;
        if (bool.TryParse(request.QueryString[ToggleParam.ResetOnLogout], out var toResetOnLogout))
            session.ResetOnLogout = toResetOnLogout;
        if (bool.TryParse(request.QueryString[ToggleParam.ResetOnDisconnect], out var toResetOnDisconnect))
            session.ResetOnDisconnect = toResetOnDisconnect;
        if (bool.TryParse(request.QueryString[ToggleParam.RefreshOnLogon], out var toRefreshOnLogon))
            session.RefreshOnLogon = toRefreshOnLogon;
        if (bool.TryParse(request.QueryString[ToggleParam.MsInTimestamp], out var toMsInTimestamp))
            session.TimeStampPrecision = toMsInTimestamp ? TimeStampPrecision.Millisecond : TimeStampPrecision.Second;
        if (bool.TryParse(request.QueryString[ToggleParam.PersistMessages], out var toPersistMessages))
            session.PersistMessages = toPersistMessages;

        sb.AppendLine($"    <div class=\"header-line\">{session.SessionID}</div>");
        sb.AppendLine("    <hr/>");

        sb.AppendLine("    <div class=\"header-line\">");
        sb.AppendLine($"      <a href=\"resetSession?idx={sessionIdx}\" onclick=\"return confirm('Really RESET this session &quot;{session.SessionID}&quot;?')\">RESET this session</a>");
        sb.AppendLine($"      <a href=\"refreshSession?idx={sessionIdx}\" onclick=\"return confirm('Really REFRESH this session &quot;{session.SessionID}&quot;?')\">REFRESH this session</a>");
        sb.AppendLine("    </div>");
        sb.AppendLine("    <hr/>");

        sb.AppendLine("    <table id=\"details-table\">");
        sb.AppendLine("      <tr class=\"head\">");
        sb.AppendLine("        <th>Attribute</th>");
        sb.AppendLine("        <th>Current Value</th>");
        sb.AppendLine("        <th>Action</th>");
        sb.AppendLine("      </tr>");
        RenderDetailToggleRow(sb, sessionIdx, "Enabled", session.IsEnabled, ToggleParam.Enabled);
        RenderDetailPlainRow(sb, "ConnectionType", session.IsInitiator ? "initiator" : "acceptor");
        RenderDetailPlainRow(sb, "IsSessionTime", session.IsSessionTime ? "yes" : "no");
        RenderDetailPlainRow(sb, "LoggedOn", session.IsLoggedOn ? "yes" : "no");
        RenderDetailPlainRow(sb, "NextIncoming", session.NextTargetMsgSeqNum.ToString());
        RenderDetailPlainRow(sb, "NextIncoming", session.NextSenderMsgSeqNum.ToString());
        RenderDetailToggleRow(sb, sessionIdx, "SendRedundantResendRequests", session.SendRedundantResendRequests, ToggleParam.SendRedundantResendRequests);
        RenderDetailToggleRow(sb, sessionIdx, "CheckCompId", session.CheckCompID, ToggleParam.CheckCompId);
        RenderDetailToggleRow(sb, sessionIdx, "CheckLatency", session.CheckLatency, ToggleParam.CheckLatency);
        RenderDetailAdjustableIntRow(sb, sessionIdx, "MaxLatency (seconds)", session.MaxLatency, AdjustParam.MaxLatency);
        RenderDetailAdjustableIntRow(sb, sessionIdx, "LogonTimeout (seconds)", session.LogonTimeout, AdjustParam.LogonTimeout);
        RenderDetailAdjustableIntRow(sb, sessionIdx, "LogoutTimeout (seconds)", session.LogoutTimeout, AdjustParam.LogoutTimeout);
        RenderDetailToggleRow(sb, sessionIdx, "ResetOnLogon", session.ResetOnLogon, ToggleParam.ResetOnLogon);
        RenderDetailToggleRow(sb, sessionIdx, "ResetOnLogout", session.ResetOnLogout, ToggleParam.ResetOnLogout);
        RenderDetailToggleRow(sb, sessionIdx, "ResetOnDisconnect", session.ResetOnDisconnect, ToggleParam.ResetOnDisconnect);
        RenderDetailToggleRow(sb, sessionIdx, "RefreshOnLogon", session.RefreshOnLogon, ToggleParam.RefreshOnLogon);
        RenderDetailToggleRow(sb, sessionIdx, "MillisecondsInTimestamp", session.TimeStampPrecision==TimeStampPrecision.Millisecond, ToggleParam.MsInTimestamp);
        RenderDetailToggleRow(sb, sessionIdx, "PersistMessages", session.PersistMessages, ToggleParam.PersistMessages);
        sb.AppendLine("    </table>");
    }

    private (int, Session) GetSessionFromRequest(HttpListenerRequest request) {
        if (!int.TryParse(request.QueryString["idx"], out var sessionIdx))
            throw new ApplicationException("Missing or erroneous `idx` (session index) parameter");

        if (sessionIdx >= _sessions.Count)
            throw new ApplicationException("Invalid session index (too high)");

        return (sessionIdx, _sessions[sessionIdx]);
    }

    private static void RenderDetailToggleRow(StringBuilder sb, int sessionIdx, string label, bool val, string toggleParam) {
        sb.AppendLine("      <tr>");
        sb.AppendLine($"        <th>{label}</th>");
        sb.AppendLine($"        <td>{(val ? "yes" : "no")}</td>");
        sb.AppendLine($"        <td><a href=\"?idx={sessionIdx}&{toggleParam}={!val}\">toggle</a></td>");
        sb.AppendLine("      </tr>");
    }

    private static void RenderDetailPlainRow(StringBuilder sb, string label, string val) {
        sb.AppendLine("      <tr>");
        sb.AppendLine($"        <th>{label}</th>");
        sb.AppendLine($"        <td>{val}</td>");
        sb.AppendLine("        <td/>");
        sb.AppendLine("      </tr>");
    }

    private static void RenderDetailAdjustableIntRow(StringBuilder sb, int sessionIdx, string label, int val, string adjustParam) {
        sb.AppendLine("      <tr>");
        sb.AppendLine($"        <th>{label}</th>");
        sb.AppendLine($"        <td>{val}</td>");
        sb.AppendLine("        <td class=\"adjusters\">");
        sb.AppendLine($"         <a href=\"?idx={sessionIdx}&{adjustParam}={AdjustParam.Minus10}\" data-tooltip=\"-10\">&lt;&lt;</a>");
        sb.AppendLine($"         <a href=\"?idx={sessionIdx}&{adjustParam}={AdjustParam.Minus1}\" data-tooltip=\"-1\">&lt;</a>");
        sb.AppendLine($"         <a href=\"?idx={sessionIdx}&{adjustParam}={AdjustParam.Plus1}\" data-tooltip=\"+1\">&gt;</a>");
        sb.AppendLine($"         <a href=\"?idx={sessionIdx}&{adjustParam}={AdjustParam.Plus10}\" data-tooltip=\"+10\">&gt;&gt;</a>");
        sb.AppendLine("        </td>");
        sb.AppendLine("      </tr>");
    }

    private void ResetSessionAndRedirect(HttpListenerRequest request, HttpListenerResponse response) {
        (int sessionIdx, Session session) = GetSessionFromRequest(request);
        session.Reset("Reset single session from web interface");
        response.Redirect($"/session?idx={sessionIdx}");
        response.Close();
    }

    private void RefreshSessionAndRedirect(HttpListenerRequest request, HttpListenerResponse response) {
        (int sessionIdx, Session session) = GetSessionFromRequest(request);
        session.Refresh();
        response.Redirect($"/session?idx={sessionIdx}");
        response.Close();
    }

    ~HttpServer() => Dispose(false);

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing) {
        if (_disposed)
            return;

        if (disposing) {
            if (_running)
                Stop();

#pragma warning disable SYSLIB0006
            _connectionThread.Abort();
#pragma warning restore SYSLIB0006
        }

        _disposed = true;
    }
}
