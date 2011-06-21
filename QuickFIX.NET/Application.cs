using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public abstract class Application
    {
        public Application()
        { }

        public abstract void OnMessage(Message message);
    }
}
