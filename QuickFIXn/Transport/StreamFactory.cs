#nullable enable
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using QuickFix.Logger;

namespace QuickFix.Transport
{
    /// <summary>
    /// StreamFactory is responsible for initiating <see cref="T:System.IO.Stream"/> for communication.
    /// If any SSL setup is required it is performed here
    /// </summary>
    internal static class StreamFactory
    {
        private static Socket? CreateTunnelThruProxy(string destIp, int destPort)
        {
            string destUriWithPort = $"{destIp}:{destPort}";
            UriBuilder uriBuilder = new UriBuilder(destUriWithPort);
            Uri destUri = uriBuilder.Uri;
            IWebProxy webProxy = WebRequest.GetSystemWebProxy();

            try
            {
                if (webProxy.IsBypassed(destUri))
                    return null;
            }
            catch (PlatformNotSupportedException)
            {
                // .NET Core doesn't support IWebProxy.IsBypassed
                // (because .NET Core doesn't have access to Windows-specific services, of course)
                return null;
            }

            Uri? proxyUri = webProxy.GetProxy(destUri);
            if (proxyUri is null)
                return null;

            IPAddress[] proxyEntry = Dns.GetHostAddresses(proxyUri.Host);
            int iPort = proxyUri.Port;
            IPAddress address = proxyEntry.First(a => a.AddressFamily == AddressFamily.InterNetwork);
            IPEndPoint proxyEndPoint = new IPEndPoint(address, iPort);
            Socket socketThruProxy = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketThruProxy.Connect(proxyEndPoint);

            string proxyMsg = $"CONNECT {destIp}:{destPort} HTTP/1.1 \n\n";
            byte[] buffer = Encoding.ASCII.GetBytes(proxyMsg);
            byte[] buffer12 = new byte[500];
            socketThruProxy.Send(buffer, buffer.Length, 0);
            socketThruProxy.Receive(buffer12, 500, 0);
            string data = Encoding.ASCII.GetString(buffer12);
            int index = data.IndexOf("200", StringComparison.Ordinal);

            if (index < 0)
                throw new ApplicationException(
                    $"Connection failed to {destUriWithPort} through proxy server {proxyUri}.");

            return socketThruProxy;
        }

        /// <summary>
        /// Connect to the specified endpoint and return a stream that can be used to communicate with it. (for initiator)
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="settings">The socket settings.</param>
        /// <param name="nonSessionLog">Logger that is not tied to a particular session</param>
        /// <returns>an opened and initiated stream which can be read and written to</returns>
        internal static Stream CreateClientStream(IPEndPoint endpoint, SocketSettings settings, NonSessionLog nonSessionLog)
        {
            Socket? socket = null;

            if (!settings.SocketIgnoreProxy)
            {
                // If system has configured a proxy for this config, use it.
                socket = CreateTunnelThruProxy(endpoint.Address.ToString(), endpoint.Port);
            }

            // No proxy.  Set up a regular socket.
            if (socket is null)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.NoDelay = settings.SocketNodelay;
                if (settings.SocketReceiveBufferSize.HasValue)
                {
                    socket.ReceiveBufferSize = settings.SocketReceiveBufferSize.Value;
                }
                if (settings.SocketSendBufferSize.HasValue)
                {
                    socket.SendBufferSize = settings.SocketSendBufferSize.Value;
                }
                socket.Connect(endpoint);
            }
            if (settings.SocketReceiveTimeout.HasValue)
            {
                socket.ReceiveTimeout = settings.SocketReceiveTimeout.Value;
            }
            if (settings.SocketSendTimeout.HasValue)
            {
                socket.SendTimeout = settings.SocketSendTimeout.Value;
            }

            Stream stream = new NetworkStream(socket, true);

            if (settings.UseSSL)
                stream = new SslStreamFactory(settings, nonSessionLog).CreateClientStreamAndAuthenticate(stream);

            return stream;
        }

        /// <summary>
        /// Initiate communication to the remote client and return a stream that can be used to communicate with it. (for acceptor)
        /// </summary>
        /// <param name="tcpClient">The TCP client.</param>
        /// <param name="settings">The socket settings.</param>
        /// <param name="nonSessionLog">Logger that is not tied to a particular session</param>
        /// <returns>an opened and initiated stream which can be read and written to</returns>
        /// <exception cref="System.ArgumentException">tcp client must be connected in order to get stream;tcpClient</exception>
        internal static Stream CreateServerStream(TcpClient tcpClient, SocketSettings settings, NonSessionLog nonSessionLog)
        {
            if (tcpClient.Connected == false)
                throw new ArgumentException("tcp client must be connected in order to get stream", nameof(tcpClient));

            Stream stream = tcpClient.GetStream();
            if (settings.UseSSL)
            {
                stream = new SslStreamFactory(settings, nonSessionLog).CreateServerStreamAndAuthenticate(stream);
            }

            return stream;
        }
    }
}
