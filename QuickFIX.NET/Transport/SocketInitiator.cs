using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace QuickFIX.NET.Transport
{
    public class SocketInitiator
    {
        public SocketInitiator(Application application)
        {
            _application = application;
        }

        public void Start()
        {
            // TODO: Instantiate socket/connect/heartbeat loop.
        }

        private Socket _socket;
        private Application _application;
    }
}
