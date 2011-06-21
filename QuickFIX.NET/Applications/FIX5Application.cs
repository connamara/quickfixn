using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace QuickFix.Applications
{
    public class FIX5Application : Application
    {
        public override void OnMessage(Message message)
        {
            Debug.WriteLine("Received FIX message: " + message.ToString());
        }
    }
}
