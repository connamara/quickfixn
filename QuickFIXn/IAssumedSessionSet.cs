using System.Collections;
using System.Collections.Generic;

namespace QuickFix
{
    internal interface IAssumedSessionSet
    {
        IEnumerable<SessionID> GetSessionIds();
    }
}