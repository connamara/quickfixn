using System;

namespace UnitTests.SessionTestSupport;

internal class MockApplication : QuickFix.IApplication
{
    public Exception? FromAppException { get; set; }
    public Exception? FromAdminException { get; set; }
    public Exception? ToAppException { get; set; }
    public Exception? ToAdminException { get; set; }

    public void ToAdmin(QuickFix.Message message, QuickFix.SessionID sessionId)
    {
        if (ToAdminException is not null)
            throw ToAdminException;
    }

    public void FromAdmin(QuickFix.Message message, QuickFix.SessionID sessionId)
    {
        if (FromAdminException is not null)
            throw FromAdminException;
    }

    public void ToApp(QuickFix.Message message, QuickFix.SessionID sessionId)
    {
        if (ToAppException is not null)
            throw ToAppException;
    }

    public void FromApp(QuickFix.Message message, QuickFix.SessionID sessionId)
    {
        if (FromAppException is not null)
            throw FromAppException;
    }

    public void OnCreate(QuickFix.SessionID sessionId) { }

    public void OnLogout(QuickFix.SessionID sessionId)
    {
        throw new NotImplementedException();
    }

    public void OnLogon(QuickFix.SessionID sessionId) { }
}
