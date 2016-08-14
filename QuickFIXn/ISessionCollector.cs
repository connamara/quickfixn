using System.Collections;
using System.Collections.Generic;

namespace QuickFix
{
    internal interface ISessionCollector
    {
        IEnumerable<SessionID> GetSessionIds();
    }
}