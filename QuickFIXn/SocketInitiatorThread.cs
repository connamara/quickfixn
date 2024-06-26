#nullable enable
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using QuickFix.Logger;

namespace QuickFix
{
    /// <summary>
    /// Handles a connection with an acceptor.
    /// </summary>
    public class SocketInitiatorThread : IResponder
    {
        public Session Session { get; }
        public Transport.SocketInitiator Initiator { get; }
        public NonSessionLog NonSessionLog { get; }

        public const int BUF_SIZE = 512;

        private Thread? _thread;
        private readonly byte[] _readBuffer = new byte[BUF_SIZE];
        private readonly Parser _parser = new();
        private Stream? _stream;
        private readonly CancellationTokenSource _readCancellationTokenSource = new();
        private readonly IPEndPoint _socketEndPoint;
        private readonly SocketSettings _socketSettings;
        private bool _isDisconnectRequested = false;

        /// <summary>
        /// Keep a task for handling async read
        /// </summary>
        private Task<int>? _currentReadTask;

        public SocketInitiatorThread(
            Transport.SocketInitiator initiator,
            Session session,
            IPEndPoint socketEndPoint,
            SocketSettings socketSettings,
            NonSessionLog nonSessionLog)
        {
            Initiator = initiator;
            Session = session;
            NonSessionLog = nonSessionLog;
            _socketEndPoint = socketEndPoint;
            _socketSettings = socketSettings;
        }

        public void Start()
        {
            _isDisconnectRequested = false;
            _thread = new Thread(Transport.SocketInitiator.SocketInitiatorThreadStart);
            _thread.Start(this);
        }

        public void Join()
        {
            if (_thread is null)
                return;
            Disconnect();
            // Make sure session's socket reader thread doesn't try to do a Join on itself!
            if (Environment.CurrentManagedThreadId != _thread.ManagedThreadId)
                _thread.Join(2000);
            _thread = null;
        }

        public void Connect()
        {
            Debug.Assert(_stream == null);

            _stream = SetupStream();
            Session.SetResponder(this);
        }

        /// <summary>
        /// Setup/Connect to the other party.
        /// Override this in order to setup other types of streams with other settings
        /// </summary>
        /// <returns>Stream representing the (network)connection to the other party</returns>
        protected virtual Stream SetupStream()
        {
            return Transport.StreamFactory.CreateClientStream(_socketEndPoint, _socketSettings, NonSessionLog);
        }

        public bool Read()
        {
            try
            {
                int bytesRead = ReadSome(_readBuffer, 1000);
                if (bytesRead > 0)
                    _parser.AddToStream(_readBuffer, bytesRead);
                else
                    Session.Next();

                ProcessStream();
                return true;
            }
            catch (ObjectDisposedException)
            {
                // this exception means _socket is already closed when poll() is called
                if (_isDisconnectRequested == false)
                    Disconnect();
            }
            catch (Exception e)
            {
                Session.Log.OnEvent(e.ToString());
                Disconnect();
            }
            return false;
        }

        /// <summary>
        /// Reads data from the network into the specified buffer.
        /// It will wait up to the specified number of milliseconds for data to arrive,
        /// if no data has arrived after the specified number of milliseconds then the function returns 0
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="timeoutMilliseconds">The timeout milliseconds.</param>
        /// <returns>The number of bytes read into the buffer</returns>
        /// <exception cref="System.Net.Sockets.SocketException">On connection reset</exception>
        protected virtual int ReadSome(byte[] buffer, int timeoutMilliseconds)
        {
            if (_stream is null) {
                throw new ApplicationException("Initiator is not connected (uninitialized stream)");
            }

            // NOTE: FROM HERE, THIS FUNCTION IS EXACTLY THE SAME AS THE ONE IN SocketReader.
            // Any changes made here should also be performed there.
            try
            {
                // Begin read if it is not already started
                _currentReadTask ??= _stream.ReadAsync(buffer, 0, buffer.Length, _readCancellationTokenSource.Token);

                if (_currentReadTask.Wait(timeoutMilliseconds)) {
                    // Dispose/nullify currentReadTask *before* retrieving .Result.
                    //   Accessing .Result can throw an exception, so we need to reset currentReadTask
                    //   first, to set us up for the next read even if an exception is thrown.
                    Task<int>? request = _currentReadTask;
                    _currentReadTask = null;

                    int bytesRead = request.Result; // (As mentioned above, this can throw an exception!)
                    if (0 == bytesRead)
                        throw new SocketException(Convert.ToInt32(SocketError.Shutdown));

                    return bytesRead;
                }

                return 0;
            }
            catch (AggregateException ex) // Timeout
            {
                _currentReadTask = null;
                var ioException = ex.InnerException as IOException;
                var inner = ioException?.InnerException as SocketException;
                if (inner is not null && inner.SocketErrorCode == SocketError.TimedOut) {
                    // Nothing read 
                    return 0;
                }

                if (inner is not null) {
                    throw inner; //rethrow SocketException part (which we have exception logic for)
                }

                throw; //rethrow original exception
            }
        }

        private void ProcessStream()
        {
            while (_parser.ReadFixMessage(out var msg))
            {
                Session.Next(msg);
            }
        }

        #region Responder Members

        public bool Send(string data)
        {
            if (_stream is null) {
                throw new ApplicationException("Initiator is not connected (uninitialized stream)");
            }

            byte[] rawData = CharEncoding.DefaultEncoding.GetBytes(data);
            _stream.Write(rawData, 0, rawData.Length);
            return true;
        }

        public void Disconnect()
        {
            _isDisconnectRequested = true;
            _readCancellationTokenSource.Cancel();
            _readCancellationTokenSource.Dispose();

            // just wait when read task will be cancelled
            _currentReadTask?.ContinueWith(_ => { }).Wait(1000);
            _currentReadTask?.Dispose();
            _currentReadTask = null;
            _stream?.Close();
        }

        #endregion
    }
}
