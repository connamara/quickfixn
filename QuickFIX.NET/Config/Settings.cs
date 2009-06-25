using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Config
{
    public class Settings
    {
        #region Properties
        public String SocketConnectHost { get { return _socketConnectHost; } }
        public int SocketConnectPort { get { return _socketConnectPort; } }
        public int HeartBtInt { get { return _heartBtInt; } }
        public int ReconnectInterval 
        { 
            get { return _reconnectInterval; }
            set { _reconnectInterval = value; }
        }
        #endregion

        public Settings()
        { }

        #region Private Members
        private int _socketConnectPort = 0;
        private String _socketConnectHost = "localhost";
        private int _heartBtInt = 30;
        private int _reconnectInterval = 30;
        #endregion Private Members
    }
}
