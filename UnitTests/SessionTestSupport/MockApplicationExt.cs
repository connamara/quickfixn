using System.Collections.Generic;

namespace UnitTests.SessionTestSupport;

class MockApplicationExt : QuickFix.IApplicationExt
{
    public HashSet<string> InterceptedMessageTypes = new();

    public void ToAdmin(QuickFix.Message message, QuickFix.SessionID sessionId) { }

    public void FromAdmin(QuickFix.Message message, QuickFix.SessionID sessionId) { }

    public void ToApp(QuickFix.Message message, QuickFix.SessionID sessionId) { }

    public void FromApp(QuickFix.Message message, QuickFix.SessionID sessionId) { }

    public void OnCreate(QuickFix.SessionID sessionId) { }

    public void OnLogout(QuickFix.SessionID sessionId) { }

    public void OnLogon(QuickFix.SessionID sessionId) { }

    public void FromEarlyIntercept(QuickFix.Message message, QuickFix.SessionID sessionId)
    {
        InterceptedMessageTypes.Add(message.Header.GetString(QuickFix.Fields.Tags.MsgType));
    }
}
