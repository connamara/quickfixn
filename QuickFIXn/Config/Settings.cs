using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Config
{
    public class Settings
    {
        #region Properties
        public string SocketConnectHost 
        {
            get { return _socketConnectHost; }
            set { _socketConnectHost = value; }
        }
        public int SocketConnectPort 
        {
            get { return _socketConnectPort; }
            set { _socketConnectPort = value; }
        }
        public int HeartBtInt 
        {
            get { return _heartBtInt; }
            set { _heartBtInt = value; }
        }
        public int ReconnectInterval 
        {
            get { return _reconnectInterval; }
            set { _reconnectInterval = value; }
        }
        public string SocketAcceptHost
        {
            get { return _socketAcceptHost; }
            set { _socketAcceptHost = value; }
        }
        public int SocketAcceptPort
        {
            get { return _socketAcceptPort; }
            set { _socketAcceptPort = value; }
        }
        #endregion

        public Settings()
        { }

        #region Private Members
        private int _socketConnectPort = 0;
        private string _socketConnectHost = "localhost";
        private int _heartBtInt = 30;
        private int _reconnectInterval = 30;
        private string _socketAcceptHost = "localhost";
        private int _socketAcceptPort = 0;
        #endregion Private Members
    }
}
