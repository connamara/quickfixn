using System.Net.Sockets;

namespace QuickFix
{
    public class SocketReader
    {
        public const int BUF_SIZE = 4096;
        private byte[] buf_ = new byte[BUF_SIZE];
        private TcpClient tcpClient_;
        private NetworkStream tcpClientStream_;

        public SocketReader(TcpClient tcpClient)
        {
            tcpClient_ = tcpClient;
            tcpClientStream_ = tcpClient_.GetStream();
        }

        /// <summary>
        /// FIXME
        /// </summary>
        public void Read()
        {
            int bytesRead = tcpClientStream_.Read(buf_, 0, BUF_SIZE);
            System.Console.WriteLine("SocketReader.Read: bytesRead=" + bytesRead);
            if (0 == bytesRead)
                throw new ConnectionResetByPeerException();
        }
    }
}