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
        private Thread _connectionThread;
        private Boolean _running, _disposed;
        private readonly SessionSettings _sessionSettings;
        private StringBuilder _sbHtmlHeader;


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
        }

        public void Start()
        {
            if (!_httpListener.IsListening)
            {
                _httpListener.Start();
                _running = true;
                // Use a thread to listen to the Http requests
                _connectionThread = new Thread(ConnectionThreadStart);
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
                    string responseString;

                    _sbHtmlHeader = new StringBuilder(@"<HEAD><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>");
                    _sbHtmlHeader.AppendFormat(@"<CENTER>[<A HREF='/'>HOME</A>]&nbsp;[<A HREF='{0}'>RELOAD</A>]</CENTER><HR/></HEADER><BODY>", request.Url.OriginalString);

                    switch (request.Url.AbsolutePath)
                    {
                        case "/":
                            responseString = ProcessRoot(request);
                            break;
                        case "/session":
                            responseString = SessionDetails(request);
                            break;
                        case "/resetSession":
                            responseString = ResetSession(request);
                            break;
                        case "/resetSessions":
                            responseString = ResetSessions(request);
                            break;
                        case "/refreshSession":
                            responseString = RefreshSession(request);
                            break;
                        case "/refreshSessions":
                            responseString = RefreshSessions(request);
                            break;
                        case "/enableSessions":
                            responseString = EnableSessions(request);
                            break;
                        case "/disableSessions":
                            responseString = DisableSessions(request);
                            break;
                        default:
                            responseString = ProcessRoot(request);
                            break;
                    }

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

        private string DisableSessions(HttpListenerRequest request)
        {
            bool confirm = false;
            StringBuilder sbHtmlPageBody = _sbHtmlHeader;

            if (request.QueryString["confirm"] != null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    foreach (SessionID session in _sessionSettings.GetSessions())
                    {
                        Session sessionDetails = Session.LookupSession(session);
                        sessionDetails.Logout();
                    }
                }
            }

            if (confirm)
            {
                sbHtmlPageBody = new StringBuilder();
                sbHtmlPageBody.AppendFormat(@"<HEAD><META http-equiv='refresh' content=2;URL={0} /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>", "/");
                sbHtmlPageBody.AppendFormat("<CENTER><h2><A HREF='{0}'>Sessions</A> have been disabled</h2></CENTER>", "/");
            }
            else
            {
                sbHtmlPageBody.Append("<CENTER><h2>Are you sure you want to disable all sessions ?</h2></CENTER>");
                sbHtmlPageBody.AppendFormat("<CENTER>[<A HREF='{0}?confirm=1'>YES, disable sessions</A>]&nbsp;[<A HREF='/'>NO, do not disable sessions</A>]</CENTER>", request.Url.OriginalString);
            }
            return sbHtmlPageBody.ToString();
        }

        private string EnableSessions(HttpListenerRequest request)
        {
            bool confirm = false;
            string urlOriginalString = request.Url.OriginalString;
            StringBuilder sbHtmlPageBody = _sbHtmlHeader;
            
            if (request.QueryString["confirm"] != null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    foreach (SessionID session in _sessionSettings.GetSessions())
                    {
                        Session sessionDetails = Session.LookupSession(session);
                        sessionDetails.Logon();
                    }
                }
            }

            if (confirm)
            {
                sbHtmlPageBody = new StringBuilder();
                sbHtmlPageBody.AppendFormat(@"<HEAD><META http-equiv='refresh' content=2;URL={0} /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>", "/");
                sbHtmlPageBody.AppendFormat("<CENTER><h2><A HREF='{0}'>Sessions</A> have been enabled</h2></CENTER>", "/");
            }
            else
            {
                sbHtmlPageBody.Append("<CENTER><h2>Are you sure you want to enable all sessions ?</h2></CENTER>");
                sbHtmlPageBody.AppendFormat("<CENTER>[<A HREF='{0}?confirm=1'>YES, enable sessions</A>]&nbsp;[<A HREF='/'>NO, do not enable sessions</A>]</CENTER>", urlOriginalString);
            }
            return sbHtmlPageBody.ToString();
        }

        private string RefreshSession(HttpListenerRequest request)
        {
            SessionID sessionId = new SessionID(request.QueryString["beginstring"], request.QueryString["sendercompid"], request.QueryString["targetcompid"]);
            Session sessionDetails = Session.LookupSession(sessionId);
            if (sessionDetails == null) throw new Exception("Session not found");
            StringBuilder sbHtmlPageBody = _sbHtmlHeader;
            bool confirm = false;
            string urlOriginalString = request.Url.OriginalString;

            string url = "/session?" + GetParameterList(urlOriginalString);

            if (request.QueryString["confirm"] != null)
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
                sbHtmlPageBody = new StringBuilder();
                sbHtmlPageBody.AppendFormat(@"<HEAD><META http-equiv='refresh' content=2;URL=/session?{0} /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>", GetParameterList(urlOriginalString));
                sbHtmlPageBody.AppendFormat(@"<CENTER>[<A HREF='/'>HOME</A>]&nbsp;[<A HREF='{0}'>RELOAD</A>]</CENTER><HR/></HEAD><BODY>", urlOriginalString);
                sbHtmlPageBody.AppendFormat("<CENTER><h2><A HREF='/session?{0}'>{1}</A> has been refreshed</h2></CENTER>", GetParameterList(url), sessionId);
            }
            else
            {
                sbHtmlPageBody.AppendFormat("<CENTER><h2>Are you sure you want to refresh session <A HREF='{0}'>{1}</A>?</h2></CENTER>", url, sessionId);
                sbHtmlPageBody.AppendFormat("<CENTER>[<A HREF='{0}&confirm=1'>YES, refresh session</A>]&nbsp;[<A HREF='{0}'>NO, do not refresh session</A>]</CENTER>", url);
            }
            return sbHtmlPageBody.ToString();
        }

        private string RefreshSessions(HttpListenerRequest request)
        {
            bool confirm = false;
            string urlOriginalString = request.Url.OriginalString;
            StringBuilder sbHtmlPageBody = _sbHtmlHeader;

            if (request.QueryString["confirm"] != null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    foreach (SessionID session in _sessionSettings.GetSessions())
                    {
                        Session sessionDetails = Session.LookupSession(session);
                        sessionDetails.Refresh();
                    }
                }
            }

            if (confirm)
            {
                sbHtmlPageBody = new StringBuilder();
                sbHtmlPageBody.AppendFormat(@"<HEAD><META http-equiv='refresh' content=2;URL={0} /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>", "/");
                sbHtmlPageBody.AppendFormat("<CENTER><h2><A HREF='{0}'>Sessions</A> have been refreshed</h2></CENTER>", "/");
            }
            else
            {
                sbHtmlPageBody.Append("<CENTER><h2>Are you sure you want to refresh all sessions ?</h2></CENTER>");
                sbHtmlPageBody.AppendFormat("<CENTER>[<A HREF='{0}?confirm=1'>YES, refresh sessions</A>]&nbsp;[<A HREF='/'>NO, do not refresh sessions</A>]</CENTER>", urlOriginalString);
            }
            return sbHtmlPageBody.ToString();
        }

        private string ResetSessions(HttpListenerRequest request)
        {
            bool confirm = false;
            string urlOriginalString = request.Url.OriginalString;
            StringBuilder sbHtmlPageBody = _sbHtmlHeader;

            if (request.QueryString["confirm"] != null)
            {
                if (Convert.ToInt16(request.QueryString["confirm"]) != 0)
                {
                    confirm = true;
                    foreach (SessionID session in _sessionSettings.GetSessions())
                    {
                        Session sessionDetails = Session.LookupSession(session);
                        sessionDetails.Reset("Reset from WebInterface");
                    }
                }
            }

            if (confirm)
            {
                sbHtmlPageBody = new StringBuilder();
                sbHtmlPageBody.AppendFormat(@"<HEAD><META http-equiv='refresh' content=2;URL={0} /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>", "/");
                sbHtmlPageBody.AppendFormat("<CENTER><h2><A HREF='{0}'>Sessions</A> have been reset</h2></CENTER>", "/");
            }
            else
            {
                sbHtmlPageBody.Append("<CENTER><h2>Are you sure you want to reset all sessions ?</h2></CENTER>");
                sbHtmlPageBody.AppendFormat("<CENTER>[<A HREF='{0}?confirm=1'>YES, reset sessions</A>]&nbsp;[<A HREF='/'>NO, do not reset sessions</A>]</CENTER>", urlOriginalString);
            }
            return sbHtmlPageBody.ToString();
        }

        private string ResetSession(HttpListenerRequest request)
        {
            SessionID sessionId = new SessionID(request.QueryString["beginstring"], request.QueryString["sendercompid"], request.QueryString["targetcompid"]);
            Session sessionDetails = Session.LookupSession(sessionId);
            if (sessionDetails == null) throw new Exception("Session not found");
            StringBuilder sbHtmlPageBody = _sbHtmlHeader;

            bool confirm = false;
            string urlOriginalString = request.Url.OriginalString;

            string url = "/session?" + GetParameterList(urlOriginalString);

            if (request.QueryString["confirm"] != null)
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
                sbHtmlPageBody = new StringBuilder();
                sbHtmlPageBody.AppendFormat(@"<HEAD><META http-equiv='refresh' content=2;URL=/session?{0} /><CENTER><TITLE>QuickFIX Engine Web Interface</TITLE><H1>QuickFIX Engine Web Interface</H1></CENTER>", GetParameterList(urlOriginalString));
                sbHtmlPageBody.AppendFormat(@"<CENTER>[<A HREF='/'>HOME</A>]&nbsp;[<A HREF='{0}'>RELOAD</A>]</CENTER><HR/></HEAD><BODY>", urlOriginalString);
                sbHtmlPageBody.AppendFormat("<CENTER><h2><A HREF='/session?{0}'>{1}</A> has been reset</h2></CENTER>",GetParameterList(url), sessionId);
            }
            else
            {
                sbHtmlPageBody.AppendFormat("<CENTER><h2>Are you sure you want to reset session <A HREF='{0}'>{1}</A>?</h2></CENTER>", url, sessionId);
                sbHtmlPageBody.AppendFormat("<CENTER>[<A HREF='{0}&confirm=1'>YES, reset session</A>]&nbsp;[<A HREF='{0}'>NO, do not reset session</A>]</CENTER>", url);
            }
            return sbHtmlPageBody.ToString();
        }


        private string ProcessRoot( HttpListenerRequest request)
        {
            StringBuilder sbHtmlPageBody = _sbHtmlHeader;

            //Session count
            sbHtmlPageBody.AppendFormat("<CENTER><b><i>{0} Sessions managed by QuickFIX</b></i></CENTER><HR/>", _sessionSettings.GetSessions().Count);

            //session management links
            sbHtmlPageBody.AppendFormat(@"<CENTER><A HREF='/resetSessions{0}'>RESET</A>&nbsp;<A HREF='/refreshSessions'>REFRESH</A>&nbsp;<A HREF='/enableSessions'>ENABLE</A>&nbsp;<A HREF='/disableSessions'>DISABLE</A></CENTER><HR/></HEADER><BODY>", GetParameterList(request.Url.OriginalString));
            
            //Start the table generation
            sbHtmlPageBody.Append("<table id=\"sessionlist\" style=\"border-width:1; padding:2; width:100%\">");
            
            sbHtmlPageBody.Append("<tr>");
            sbHtmlPageBody.Append(AddCell("Session", true));
            sbHtmlPageBody.Append(AddCell("Type", true));
            sbHtmlPageBody.Append(AddCell("Enabled", true));
            sbHtmlPageBody.Append(AddCell("Session Time", true));
            sbHtmlPageBody.Append(AddCell("Logged On", true));
            sbHtmlPageBody.Append(AddCell("Next Incoming", true));
            sbHtmlPageBody.Append(AddCell("Next Outgoing", true));
            sbHtmlPageBody.Append("</tr>");

            foreach (SessionID session in _sessionSettings.GetSessions())
            {
                Session sessionDetails = Session.LookupSession(session);
                sbHtmlPageBody.Append("<tr>");
                sbHtmlPageBody.Append(AddCell(String.Format(
                    "<a href=\"session?BeginString={0}&SenderCompID={1}&TargetCompID={2}\">{0}:{1}->{2}</a>",
                    session.BeginString, session.SenderCompID, session.TargetCompID)));
                sbHtmlPageBody.Append(AddCell(sessionDetails.IsInitiator ? "initiator" : "acceptor"));
                sbHtmlPageBody.Append(AddCell(sessionDetails.IsEnabled ? "yes" : "no"));
                sbHtmlPageBody.Append(AddCell(sessionDetails.IsSessionTime ? "yes" : "no"));
                sbHtmlPageBody.Append(AddCell(sessionDetails.IsLoggedOn ? "yes" : "no"));
                sbHtmlPageBody.Append(AddCell(sessionDetails.NextTargetMsgSeqNum.ToString()));
                sbHtmlPageBody.Append(AddCell(sessionDetails.NextSenderMsgSeqNum.ToString()));
                sbHtmlPageBody.Append("</tr>");
            }

            sbHtmlPageBody.Append("</table>");
            return sbHtmlPageBody.ToString();
        }

        public string SessionDetails(HttpListenerRequest request)
        {
            SessionID sessionId = new SessionID(request.QueryString["beginstring"], request.QueryString["sendercompid"], request.QueryString["targetcompid"]);
            Session sessionDetails = Session.LookupSession(sessionId);
            if (sessionDetails == null) throw new Exception("Session not found");
            StringBuilder sbHtmlPageBody = _sbHtmlHeader;

            string url = request.Url.OriginalString;
            string urlOriginalString = request.Url.OriginalString;

            if (request.QueryString["enabled"] != null)
            {
                if (!Convert.ToBoolean(request.QueryString["enabled"]))
                    sessionDetails.Logout();
                else
                    sessionDetails.Logon();

                url = RemoveQueryStringByKey(urlOriginalString, "Enabled");
            }

            if (request.QueryString["next incoming"] != null)
            {
                int value = Convert.ToInt16(request.QueryString["next incoming"]);
                sessionDetails.NextTargetMsgSeqNum = value <= 0 ? 1 : value;
                url = RemoveQueryStringByKey(urlOriginalString, "next incoming");
            }

            if (request.QueryString["Next Outgoing"] != null)
            {
                int value = Convert.ToInt16(request.QueryString["Next Outgoing"]);
                sessionDetails.NextSenderMsgSeqNum = value <= 0 ? 1 : value;
                url = RemoveQueryStringByKey(urlOriginalString, "Next Outgoing");
            }

            if (request.QueryString["SendRedundantResendRequests"] != null)
            {
                sessionDetails.SendRedundantResendRequests = Convert.ToBoolean(request.QueryString["SendRedundantResendRequests"]);
                url = RemoveQueryStringByKey(urlOriginalString, "SendRedundantResendRequests");
            }

            if (request.QueryString["CheckCompId"] != null)
            {
                sessionDetails.CheckCompID = Convert.ToBoolean(request.QueryString["CheckCompId"]);
                url = RemoveQueryStringByKey(urlOriginalString, "CheckCompId");
            }

            if (request.QueryString["CheckLatency"] != null)
            {
                sessionDetails.CheckLatency = Convert.ToBoolean(request.QueryString["CheckLatency"]);
                url = RemoveQueryStringByKey(urlOriginalString, "CheckLatency");
            }

            if (request.QueryString["MaxLatency"] != null)
            {
                int value = Convert.ToInt16(request.QueryString["MaxLatency"]);
                sessionDetails.MaxLatency = value <= 0 ? 1 : value;
                url = RemoveQueryStringByKey(urlOriginalString, "MaxLatency");
            }

            if (request.QueryString["LogonTimeout"] != null)
            {
                int value = Convert.ToInt16(request.QueryString["LogonTimeout"]);
                sessionDetails.LogonTimeout = value <= 0 ? 1 : value;
                url = RemoveQueryStringByKey(urlOriginalString, "LogonTimeout");
            }

            if (request.QueryString["LogoutTimeout"] != null)
            {
                int value = Convert.ToInt16(request.QueryString["LogoutTimeout"]);
                sessionDetails.LogoutTimeout = value <= 0 ? 1 : value;
                url = RemoveQueryStringByKey(urlOriginalString, "LogoutTimeout");
            }

            if (request.QueryString["ResetOnLogon"] != null)
            {
                sessionDetails.ResetOnLogon = Convert.ToBoolean(request.QueryString["ResetOnLogon"]);
                url = RemoveQueryStringByKey(urlOriginalString, "ResetOnLogon");
            }

            if (request.QueryString["ResetOnLogout"] != null)
            {
                sessionDetails.ResetOnLogout = Convert.ToBoolean(request.QueryString["ResetOnLogout"]);
                url = RemoveQueryStringByKey(urlOriginalString, "ResetOnLogout");
            }

            if (request.QueryString["ResetOnDisconnect"] != null)
            {
                sessionDetails.ResetOnDisconnect = Convert.ToBoolean(request.QueryString["ResetOnDisconnect"]);
                url = RemoveQueryStringByKey(urlOriginalString, "ResetOnDisconnect");
            }

            if (request.QueryString["RefreshOnLogon"] != null)
            {
                sessionDetails.RefreshOnLogon = Convert.ToBoolean(request.QueryString["RefreshOnLogon"]);
                url = RemoveQueryStringByKey(urlOriginalString, "RefreshOnLogon");
            }

            if (request.QueryString["MillisecondsInTimestamp"] != null)
            {
                sessionDetails.MillisecondsInTimeStamp = Convert.ToBoolean(request.QueryString["MillisecondsInTimestamp"]);
                url = RemoveQueryStringByKey(urlOriginalString, "MillisecondsInTimestamp");
            }

            if (request.QueryString["PersistMessages"] != null)
            {
                sessionDetails.PersistMessages = Convert.ToBoolean(request.QueryString["PersistMessages"]);
                url = RemoveQueryStringByKey(urlOriginalString, "PersistMessages");
            }

            
            sbHtmlPageBody.AppendFormat(@"<CENTER>{0}</CENTER><HR/>", sessionId);
            sbHtmlPageBody.AppendFormat(@"<CENTER>[<A HREF='/resetSession?{0}'>RESET</A>]&nbsp;[<A HREF='/refreshSession?{0}'>REFRESH</A>]</CENTER><HR/></HEADER><BODY>", GetParameterList(urlOriginalString));

            sbHtmlPageBody.Append("<table id=\"session_details\" style=\"border-width:1; padding:2; width:100%\">");
            
            sbHtmlPageBody.Append(AddRow("Enabled", sessionDetails.IsEnabled, url));
            sbHtmlPageBody.Append(AddRow("ConnectionType", sessionDetails.IsInitiator?"initiator": "acceptor"));
            sbHtmlPageBody.Append(AddRow("SessionTime", sessionDetails.IsSessionTime));
            sbHtmlPageBody.Append(AddRow("LoggedOn", sessionDetails.IsLoggedOn));
            sbHtmlPageBody.Append(AddRow("Next Incoming", sessionDetails.NextTargetMsgSeqNum, url));
            sbHtmlPageBody.Append(AddRow("Next Outgoing", sessionDetails.NextSenderMsgSeqNum, url));
            sbHtmlPageBody.Append(AddRow("SendRedundantResendRequests", sessionDetails.SendRedundantResendRequests, url));
            sbHtmlPageBody.Append(AddRow("CheckCompId", sessionDetails.CheckCompID, url));
            sbHtmlPageBody.Append(AddRow("CheckLatency", sessionDetails.CheckLatency, url));
            sbHtmlPageBody.Append(AddRow("MaxLatency", sessionDetails.MaxLatency, url));
            sbHtmlPageBody.Append(AddRow("LogonTimeout", sessionDetails.LogonTimeout, url));
            sbHtmlPageBody.Append(AddRow("LogoutTimeout", sessionDetails.LogoutTimeout, url));
            sbHtmlPageBody.Append(AddRow("ResetOnLogon", sessionDetails.ResetOnLogon, url));
            sbHtmlPageBody.Append(AddRow("ResetOnLogout", sessionDetails.ResetOnLogout, url));
            sbHtmlPageBody.Append(AddRow("ResetOnDisconnect", sessionDetails.ResetOnDisconnect, url));
            sbHtmlPageBody.Append(AddRow("RefreshOnLogon", sessionDetails.RefreshOnLogon, url));
            sbHtmlPageBody.Append(AddRow("MillisecondsInTimestamp", sessionDetails.MillisecondsInTimeStamp, url));
            sbHtmlPageBody.Append(AddRow("PersistMessages", sessionDetails.PersistMessages, url));

            sbHtmlPageBody.Append("</table>");
            return sbHtmlPageBody.ToString();
        }

        public static string RemoveQueryStringByKey(string url, string key)
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

        public static string GetParameterList(string url)
        {
            return HttpUtility.ParseQueryString((new Uri(url).Query)).ToString();
        }

        private static string AddRow(string colName, bool value, string url="")
        {
            string valueAsStr = value ? "yes" : "no";
            string innerHtml = url.Length > 0
                ? $"<a href=\" {url}&{colName}={!value} \">toggle</a>"
                : "";
            return AddRow(colName, valueAsStr, innerHtml);
        }

        private static string AddRow(string colName, int value, string url = "")
        {
            string innerHtml = $"<a href=\" {url}&{colName}={value - 10} \"> << </a>" +
                               $"<a href=\" {url}&{colName}={value - 1} \"> < </a>" +
                               " | " +
                               $"<a href=\" {url}&{colName}={value + 1} \"> > </a>" +
                               $"<a href=\" {url}&{colName}={value + 10} \"> >> </a>";
            return AddRow(colName, value.ToString(), innerHtml);
        }
        private static string AddRow(string colName, string value, string innerHtml = "")
        {
            StringBuilder row = new StringBuilder();
            row.Append("<tr>");
            row.Append(AddCell(colName));
            row.Append(AddCell(value));
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
                if (_connectionThread != null)
                {
                    _connectionThread.Abort();
                    _connectionThread = null;
                }
            }
            _disposed = true;
        }
    }
}
