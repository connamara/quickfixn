using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFIX.NET.Transport;
using QuickFIX.NET;
using QuickFIX.NET.Config;

namespace UnitTests
{
    [TestFixture]
    public class SocketInitiatorTests
    {
        [Test]
        public void TestConnect()
        {
            _fixApp = new Application();
            _settings = new Settings();
            SocketInitiator i = new SocketInitiator(_fixApp, _settings);
            i.Start();

            // Create a socket listener and expect connection.

            i.Close();
        }

        private Application _fixApp;
        private Settings _settings;
    }
}
