#nullable enable
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using QuickFix;

namespace Acceptor
{
    public class HttpServer : IDisposable
    {
        private readonly HttpListener _httpListener;
        private readonly Thread _connectionThread;
        private bool _running, _disposed;
        private readonly SessionSettings _sessionSettings;

        public HttpServer(string prefix, SessionSettings settings)
        {
            if (!HttpListener.IsSupported)
            {
                // Requires at least a Windows XP with Service Pack 2
                throw new NotSupportedException(
                    "The Http Server cannot run on this operating system.");
            }

            _httpListener = new HttpListener();
            _httpListener.Prefixes.Add(prefix);
            _sessionSettings = settings;
            _connectionThread = new Thread(ConnectionThreadStart);
        }

        public void Start()
        {
            if (!_httpListener.IsListening)
            {
                _httpListener.Start();
                _running = true;
                // Use a thread to listen to the Http requests
                _connectionThread.Start();
            }
        }

        public void Stop()
        {
            if (_httpListener.IsListening)
            {
                _running = false;
                _httpListener.Stop();
            }
        }

        private void ConnectionThreadStart()
        {
            try
            {
                while (_running)
                {
                    // Grab the context and pass it to the processor methods to handle it
                    HttpListenerContext context = _httpListener.GetContext();
                    HttpListenerRequest request = context.Request;
                    HttpListenerResponse response = context.Response;

                    StringBuilder pageBuilder = new StringBuilder("<HEAD><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>");
                    pageBuilder.Append($"<CENTER>[<A HREF='/'>HOME</A>]&nbsp;[<A HREF='{request.Url?.OriginalString}'>RELOAD</A>]</CENTER><HR/></HEADER><BODY>");

                    var responseString = request.Url?.AbsolutePath switch
                    {
                        "/" => ProcessRoot(request, pageBuilder),
                        "/session" => SessionDetails(request, pageBuilder),
                        "/resetSession" => ResetSession(request, pageBuilder),
                        "/resetSessions" => ResetSessions(request, pageBuilder),
                        "/refreshSession" => RefreshSession(request, pageBuilder),
                        "/refreshSessions" => RefreshSessions(request, pageBuilder),
                        "/enableSessions" => EnableSessions(request, pageBuilder),
                        "/disableSessions" => DisableSessions(request, pageBuilder),
                        _ => ProcessRoot(request, pageBuilder)
                    };

                    byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                    response.ContentLength64 = buffer.Length;
                    Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                    output.Close();
                }
            }
            catch (HttpListenerException)
            {
                Console.WriteLine("HTTP server was shut down.");
            }
        }

        private string DisableSessions(HttpListenerRequest request, StringBuilder pageBuilder)
        {
            bool confirm = false;

            if (request.QueryString["confirm"] is not null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    foreach (SessionID session in _sessionSettings.GetSessions())
                    {
                        Session.LookupSession(session)?.Logout();
                    }
                }
            }

            if (confirm)
            {
                pageBuilder = new StringBuilder();
                pageBuilder.Append("<HEAD><META http-equiv='refresh' content='2; url=/' /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>");
                pageBuilder.Append("<CENTER><h2><A HREF='/'>Sessions</A> have been disabled</h2></CENTER>");
            }
            else
            {
                pageBuilder.Append("<CENTER><h2>Are you sure you want to disable all sessions ?</h2></CENTER>");
                pageBuilder.Append($"<CENTER>[<A HREF='{request.Url?.OriginalString}?confirm=1'>YES, disable sessions</A>]&nbsp;[<A HREF='/'>NO, do not disable sessions</A>]</CENTER>");
            }
            return pageBuilder.ToString();
        }

        private string EnableSessions(HttpListenerRequest request, StringBuilder pageBuilder)
        {
            bool confirm = false;

            if (request.QueryString["confirm"] is not null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    foreach (SessionID session in _sessionSettings.GetSessions())
                    {
                        Session.LookupSession(session)?.SetLogonState();
                    }
                }
            }

            if (confirm)
            {
                pageBuilder = new StringBuilder();
                pageBuilder.Append("<HEAD><META http-equiv='refresh' content='2; url=/' /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>");
                pageBuilder.Append("<CENTER><h2><A HREF='/'>Sessions</A> have been enabled</h2></CENTER>");
            }
            else
            {
                pageBuilder.Append("<CENTER><h2>Are you sure you want to enable all sessions ?</h2></CENTER>");
                pageBuilder.Append($"<CENTER>[<A HREF='{request.Url?.OriginalString}?confirm=1'>YES, enable sessions</A>]&nbsp;[<A HREF='/'>NO, do not enable sessions</A>]</CENTER>");
            }
            return pageBuilder.ToString();
        }

        private string RefreshSession(HttpListenerRequest request, StringBuilder pageBuilder)
        {
            SessionID sessionId = new SessionID(request.QueryString["beginstring"], request.QueryString["sendercompid"], request.QueryString["targetcompid"]);
            Session? sessionDetails = Session.LookupSession(sessionId);
            if (sessionDetails == null) throw new Exception("Session not found");
            bool confirm = false;
            string urlOriginalString = request.Url!.OriginalString;

            string url = "/session?" + GetParameterList(urlOriginalString);

            if (request.QueryString["confirm"] is not null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    sessionDetails.Refresh();
                    url = RemoveQueryStringByKey(urlOriginalString, "confirm");
                }
            }

            if (confirm)
            {
                pageBuilder = new StringBuilder();
                pageBuilder.Append($"<HEAD><META http-equiv='refresh' content='2; url=/session?{GetParameterList(urlOriginalString)}' /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>");
                pageBuilder.Append($"<CENTER>[<A HREF='/'>HOME</A>]&nbsp;[<A HREF='{urlOriginalString}'>RELOAD</A>]</CENTER><HR/></HEAD><BODY>");
                pageBuilder.Append($"<CENTER><h2><A HREF='/session?{GetParameterList(url)}'>{sessionId}</A> has been refreshed</h2></CENTER>");
            }
            else
            {
                pageBuilder.Append($"<CENTER><h2>Are you sure you want to refresh session <A HREF='{url}'>{sessionId}</A>?</h2></CENTER>");
                pageBuilder.Append($"<CENTER>[<A HREF='{url}&confirm=1'>YES, refresh session</A>]&nbsp;[<A HREF='{url}'>NO, do not refresh session</A>]</CENTER>");
            }
            return pageBuilder.ToString();
        }

        private string RefreshSessions(HttpListenerRequest request, StringBuilder pageBuilder)
        {
            bool confirm = false;

            if (request.QueryString["confirm"] is not null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    foreach (SessionID session in _sessionSettings.GetSessions())
                    {
                        Session.LookupSession(session)?.Refresh();
                    }
                }
            }

            if (confirm)
            {
                pageBuilder = new StringBuilder();
                pageBuilder.Append("<HEAD><META http-equiv='refresh' content='2; url=/' /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>");
                pageBuilder.Append("<CENTER><h2><A HREF='/'>Sessions</A> have been refreshed</h2></CENTER>");
            }
            else
            {
                pageBuilder.Append("<CENTER><h2>Are you sure you want to refresh all sessions ?</h2></CENTER>");
                pageBuilder.Append($"<CENTER>[<A HREF='{request.Url?.OriginalString}?confirm=1'>YES, refresh sessions</A>]&nbsp;[<A HREF='/'>NO, do not refresh sessions</A>]</CENTER>");
            }
            return pageBuilder.ToString();
        }

        private string ResetSessions(HttpListenerRequest request, StringBuilder pageBuilder)
        {
            bool confirm = false;

            if (request.QueryString["confirm"] is not null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    foreach (SessionID session in _sessionSettings.GetSessions())
                    {
                        Session.LookupSession(session)?.Reset("Reset from WebInterface");
                    }
                }
            }

            if (confirm)
            {
                pageBuilder = new StringBuilder();
                pageBuilder.Append("<HEAD><META http-equiv='refresh' content='2; url=/' /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>");
                pageBuilder.Append("<CENTER><h2><A HREF='/'>Sessions</A> have been reset</h2></CENTER>");
            }
            else
            {
                pageBuilder.Append("<CENTER><h2>Are you sure you want to reset all sessions ?</h2></CENTER>");
                pageBuilder.Append($"<CENTER>[<A HREF='{request.Url?.OriginalString}?confirm=1'>YES, reset sessions</A>]&nbsp;[<A HREF='/'>NO, do not reset sessions</A>]</CENTER>");
            }
            return pageBuilder.ToString();
        }

        private string ResetSession(HttpListenerRequest request, StringBuilder pageBuilder)
        {
            SessionID sessionId = new SessionID(request.QueryString["beginstring"], request.QueryString["sendercompid"], request.QueryString["targetcompid"]);
            Session? sessionDetails = Session.LookupSession(sessionId);
            if (sessionDetails == null) throw new Exception("Session not found");

            bool confirm = false;
            string urlOriginalString = request.Url!.OriginalString;

            string url = "/session?" + GetParameterList(urlOriginalString);

            if (request.QueryString["confirm"] is not null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"])!=0)
                {
                    confirm = true;
                    sessionDetails.Reset("Reset from WebInterface");
                    url = RemoveQueryStringByKey(urlOriginalString, "confirm");
                }
            }

            if (confirm)
            {
                pageBuilder = new StringBuilder();
                pageBuilder.Append($"<HEAD><META http-equiv='refresh' content=2;URL=/session?{GetParameterList(urlOriginalString)} /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>");
                pageBuilder.Append($"<CENTER>[<A HREF='/'>HOME</A>]&nbsp;[<A HREF='{urlOriginalString}'>RELOAD</A>]</CENTER><HR/></HEAD><BODY>");
                pageBuilder.Append($"<CENTER><h2><A HREF='/session?{GetParameterList(url)}'>{sessionId}</A> has been reset</h2></CENTER>");
            }
            else
            {
                pageBuilder.Append($"<CENTER><h2>Are you sure you want to reset session <A HREF='{url}'>{sessionId}</A>?</h2></CENTER>");
                pageBuilder.Append($"<CENTER>[<A HREF='{url}&confirm=1'>YES, reset session</A>]&nbsp;[<A HREF='{url}'>NO, do not reset session</A>]</CENTER>");
            }
            return pageBuilder.ToString();
        }


        private string ProcessRoot(HttpListenerRequest request, StringBuilder pageBuilder)
        {
            //Session count
            pageBuilder.Append($"<CENTER><b><i>{_sessionSettings.GetSessions().Count} Sessions managed by QuickFIX</b></i></CENTER><HR/>");

            //session management links
            pageBuilder.Append($"<CENTER><A HREF='/resetSessions{GetParameterList(request.Url?.OriginalString)}'>RESET</A>&nbsp;<A HREF='/refreshSessions'>REFRESH</A>&nbsp;<A HREF='/enableSessions'>ENABLE</A>&nbsp;<A HREF='/disableSessions'>DISABLE</A></CENTER><HR/></HEADER><BODY>");
            
            //Start the table generation
            pageBuilder.Append("<table id=\"sessionlist\" style=\"border-width:1; padding:2; width:100%\">");
            
            pageBuilder.Append("<tr>");
            pageBuilder.Append(AddCell("Session", true));
            pageBuilder.Append(AddCell("Type", true));
            pageBuilder.Append(AddCell("Enabled", true));
            pageBuilder.Append(AddCell("Session Time", true));
            pageBuilder.Append(AddCell("Logged On", true));
            pageBuilder.Append(AddCell("Next Incoming", true));
            pageBuilder.Append(AddCell("Next Outgoing", true));
            pageBuilder.Append("</tr>");

            foreach (SessionID session in _sessionSettings.GetSessions())
            {
                Session sessionDetails = Session.LookupSession(session)!;
                pageBuilder.Append("<tr>");
                pageBuilder.Append(AddCell(String.Format(
                    "<a href=\"session?BeginString={0}&SenderCompID={1}&TargetCompID={2}\">{0}:{1}->{2}</a>",
                    session.BeginString, session.SenderCompID, session.TargetCompID)));
                pageBuilder.Append(AddCell(sessionDetails.IsInitiator ? "initiator" : "acceptor"));
                pageBuilder.Append(AddCell(sessionDetails.IsEnabled ? "yes" : "no"));
                pageBuilder.Append(AddCell(sessionDetails.IsSessionTime ? "yes" : "no"));
                pageBuilder.Append(AddCell(sessionDetails.IsLoggedOn ? "yes" : "no"));
                pageBuilder.Append(AddCell(sessionDetails.NextTargetMsgSeqNum.ToString()));
                pageBuilder.Append(AddCell(sessionDetails.NextSenderMsgSeqNum.ToString()));
                pageBuilder.Append("</tr>");
            }

            pageBuilder.Append("</table>");
            return pageBuilder.ToString();
        }

        private string SessionDetails(HttpListenerRequest request, StringBuilder pageBuilder)
        {
            SessionID sessionId = new SessionID(request.QueryString["beginstring"], request.QueryString["sendercompid"], request.QueryString["targetcompid"]);
            Session? sessionDetails = Session.LookupSession(sessionId);
            if (sessionDetails == null) throw new Exception("Session not found");

            string url = request.Url?.OriginalString ?? "(null)";
            string urlOriginalString = url;

            if (request.QueryString["enabled"] is not null)
            {
                if (!Convert.ToBoolean(request.QueryString["enabled"]))
                    sessionDetails.Logout();
                else
                    sessionDetails.SetLogonState();

                url = RemoveQueryStringByKey(urlOriginalString, "Enabled");
            }

            if (request.QueryString["next incoming"] is not null)
            {
                SeqNumType val = Convert.ToUInt64(request.QueryString["next incoming"]);
                sessionDetails.NextTargetMsgSeqNum = (val == 0 || val == SeqNumType.MaxValue) ? 1 : val;
                url = RemoveQueryStringByKey(urlOriginalString, "next incoming");
            }

            if (request.QueryString["Next Outgoing"] is not null)
            {
                SeqNumType val = Convert.ToUInt64(request.QueryString["Next Outgoing"]);
                sessionDetails.NextSenderMsgSeqNum = (val == 0 || val == SeqNumType.MaxValue) ? 1 : val;
                url = RemoveQueryStringByKey(urlOriginalString, "Next Outgoing");
            }

            if (request.QueryString["SendRedundantResendRequests"] is not null)
            {
                sessionDetails.SendRedundantResendRequests = Convert.ToBoolean(request.QueryString["SendRedundantResendRequests"]);
                url = RemoveQueryStringByKey(urlOriginalString, "SendRedundantResendRequests");
            }

            if (request.QueryString["CheckCompId"] is not null)
            {
                sessionDetails.CheckCompID = Convert.ToBoolean(request.QueryString["CheckCompId"]);
                url = RemoveQueryStringByKey(urlOriginalString, "CheckCompId");
            }

            if (request.QueryString["CheckLatency"] is not null)
            {
                sessionDetails.CheckLatency = Convert.ToBoolean(request.QueryString["CheckLatency"]);
                url = RemoveQueryStringByKey(urlOriginalString, "CheckLatency");
            }

            if (request.QueryString["MaxLatency"] is not null)
            {
                int val = Convert.ToInt16(request.QueryString["MaxLatency"]);
                sessionDetails.MaxLatency = val <= 0 ? 1 : val;
                url = RemoveQueryStringByKey(urlOriginalString, "MaxLatency");
            }

            if (request.QueryString["LogonTimeout"] is not null)
            {
                int val = Convert.ToInt16(request.QueryString["LogonTimeout"]);
                sessionDetails.LogonTimeout = val <= 0 ? 1 : val;
                url = RemoveQueryStringByKey(urlOriginalString, "LogonTimeout");
            }

            if (request.QueryString["LogoutTimeout"] is not null)
            {
                int val = Convert.ToInt16(request.QueryString["LogoutTimeout"]);
                sessionDetails.LogoutTimeout = val <= 0 ? 1 : val;
                url = RemoveQueryStringByKey(urlOriginalString, "LogoutTimeout");
            }

            if (request.QueryString["ResetOnLogon"] is not null)
            {
                sessionDetails.ResetOnLogon = Convert.ToBoolean(request.QueryString["ResetOnLogon"]);
                url = RemoveQueryStringByKey(urlOriginalString, "ResetOnLogon");
            }

            if (request.QueryString["ResetOnLogout"] is not null)
            {
                sessionDetails.ResetOnLogout = Convert.ToBoolean(request.QueryString["ResetOnLogout"]);
                url = RemoveQueryStringByKey(urlOriginalString, "ResetOnLogout");
            }

            if (request.QueryString["ResetOnDisconnect"] is not null)
            {
                sessionDetails.ResetOnDisconnect = Convert.ToBoolean(request.QueryString["ResetOnDisconnect"]);
                url = RemoveQueryStringByKey(urlOriginalString, "ResetOnDisconnect");
            }

            if (request.QueryString["RefreshOnLogon"] is not null)
            {
                sessionDetails.RefreshOnLogon = Convert.ToBoolean(request.QueryString["RefreshOnLogon"]);
                url = RemoveQueryStringByKey(urlOriginalString, "RefreshOnLogon");
            }

            if (request.QueryString["MillisecondsInTimestamp"] is not null)
            {
                sessionDetails.MillisecondsInTimeStamp = Convert.ToBoolean(request.QueryString["MillisecondsInTimestamp"]);
                url = RemoveQueryStringByKey(urlOriginalString, "MillisecondsInTimestamp");
            }

            if (request.QueryString["PersistMessages"] is not null)
            {
                sessionDetails.PersistMessages = Convert.ToBoolean(request.QueryString["PersistMessages"]);
                url = RemoveQueryStringByKey(urlOriginalString, "PersistMessages");
            }

            
            pageBuilder.Append($"<CENTER>{sessionId}</CENTER><HR/>");
            pageBuilder.Append($"<CENTER>[<A HREF='/resetSession?{GetParameterList(urlOriginalString)}'>RESET</A>]&nbsp;[<A HREF='/refreshSession?{0}'>REFRESH</A>]</CENTER><HR/></HEADER><BODY>");

            pageBuilder.Append("<table id=\"session_details\" style=\"border-width:1; padding:2; width:100%\">");
            
            pageBuilder.Append(AddRow("Enabled", sessionDetails.IsEnabled, url));
            pageBuilder.Append(AddRow("ConnectionType", sessionDetails.IsInitiator?"initiator": "acceptor"));
            pageBuilder.Append(AddRow("SessionTime", sessionDetails.IsSessionTime));
            pageBuilder.Append(AddRow("LoggedOn", sessionDetails.IsLoggedOn));
            pageBuilder.Append(AddRow("Next Incoming", sessionDetails.NextTargetMsgSeqNum, url));
            pageBuilder.Append(AddRow("Next Outgoing", sessionDetails.NextSenderMsgSeqNum, url));
            pageBuilder.Append(AddRow("SendRedundantResendRequests", sessionDetails.SendRedundantResendRequests, url));
            pageBuilder.Append(AddRow("CheckCompId", sessionDetails.CheckCompID, url));
            pageBuilder.Append(AddRow("CheckLatency", sessionDetails.CheckLatency, url));
            pageBuilder.Append(AddRow("MaxLatency", sessionDetails.MaxLatency, url));
            pageBuilder.Append(AddRow("LogonTimeout", sessionDetails.LogonTimeout, url));
            pageBuilder.Append(AddRow("LogoutTimeout", sessionDetails.LogoutTimeout, url));
            pageBuilder.Append(AddRow("ResetOnLogon", sessionDetails.ResetOnLogon, url));
            pageBuilder.Append(AddRow("ResetOnLogout", sessionDetails.ResetOnLogout, url));
            pageBuilder.Append(AddRow("ResetOnDisconnect", sessionDetails.ResetOnDisconnect, url));
            pageBuilder.Append(AddRow("RefreshOnLogon", sessionDetails.RefreshOnLogon, url));
            pageBuilder.Append(AddRow("MillisecondsInTimestamp", sessionDetails.MillisecondsInTimeStamp, url));
            pageBuilder.Append(AddRow("PersistMessages", sessionDetails.PersistMessages, url));

            pageBuilder.Append("</table>");
            return pageBuilder.ToString();
        }

        private static string RemoveQueryStringByKey(string url, string key)
        {
            var uri = new Uri(url);

            // this gets all the query string key value pairs as a collection
            var newQueryString = HttpUtility.ParseQueryString(uri.Query);

            // this removes the key if exists
            newQueryString.Remove(key);

            // this gets the page path from root without QueryString
            string pagePathWithoutQueryString = uri.GetLeftPart(UriPartial.Path);

            return newQueryString.Count > 0
                ? $"{pagePathWithoutQueryString}?{newQueryString}"
                : pagePathWithoutQueryString;
        }

        /// <summary>
        /// Returns the http parameter string from a url
        /// </summary>
        /// <param name="url">e.g. <![CDATA[ http://www.example.com/foo?one=uno&two=dos ]]></param>
        /// <returns>e.g. <![CDATA[ "one=uno&two=dos" ]]> (or empty string if <paramref name="url"/> is null)</returns>
        private static string GetParameterList(string? url) {
            return string.IsNullOrWhiteSpace(url) ? "" : $"{HttpUtility.ParseQueryString(new Uri(url).Query)}";
        }

        private static string AddRow(string colName, bool val, string url="")
        {
            string valueAsStr = val ? "yes" : "no";
            string innerHtml = url.Length > 0
                ? $"<a href=\" {url}&{colName}={!val} \">toggle</a>"
                : "";
            return AddRow(colName, valueAsStr, innerHtml);
        }

        private static string AddRow(string colName, int val, string url = "")
        {
            string innerHtml = $"<a href=\" {url}&{colName}={val - 10} \"> << </a>" +
                               $"<a href=\" {url}&{colName}={val - 1} \"> < </a>" +
                               " | " +
                               $"<a href=\" {url}&{colName}={val + 1} \"> > </a>" +
                               $"<a href=\" {url}&{colName}={val + 10} \"> >> </a>";
            return AddRow(colName, val.ToString(), innerHtml);
        }

        private static string AddRow(string colName, SeqNumType val, string url = "")
        {
            string innerHtml = $"<a href=\" {url}&{colName}={val - 10} \"> << </a>" +
                               $"<a href=\" {url}&{colName}={val - 1} \"> < </a>" +
                               " | " +
                               $"<a href=\" {url}&{colName}={val + 1} \"> > </a>" +
                               $"<a href=\" {url}&{colName}={val + 10} \"> >> </a>";
            return AddRow(colName, val.ToString(), innerHtml);
        }

        private static string AddRow(string colName, string val, string innerHtml = "")
        {
            StringBuilder row = new StringBuilder();
            row.Append("<tr>");
            row.Append(AddCell(colName));
            row.Append(AddCell(val));
            row.Append(AddCell(innerHtml));
            row.Append("</tr>");
            return row.ToString();
        }

        private static string AddCell(string cellContent, bool header = false)
        {
            string entryType = header ? "th" : "td";
            return "<"+entryType+" align=\"left\">" + cellContent + "</"+entryType+">";
        }

        ~HttpServer() => Dispose(false);
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                if (_running)
                {
                    Stop();
                }
#pragma warning disable SYSLIB0006
                _connectionThread.Abort();
#pragma warning restore SYSLIB0006
            }
            _disposed = true;
        }
    }
}
