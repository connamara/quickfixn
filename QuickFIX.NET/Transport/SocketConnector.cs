using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFIX.NET.Config;

namespace QuickFIX.NET.Transport
{
    public class SocketConnector
    {
        public SocketConnector(Application app, Settings settings)
        {
            _app = app;
            _settings = settings;
        }

        public void Start()
        {

        }

        private void ServerLoop()
        {

        }

        #region Private Members
        private Application _app;
        private Settings _settings;
        #endregion

    }
}
