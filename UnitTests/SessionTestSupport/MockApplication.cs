using System;

namespace UnitTests.SessionTestSupport;

internal class MockApplication : QuickFix.IApplication
{
    public Exception? FromAppException { get; set; }
    public Exception? FromAdminException { get; set; }
    public QuickFix.DoNotSend? DoNotSendException { get; set; }

    public void ToAdmin(QuickFix.Message message, QuickFix.SessionID sessionId) { }

    public void FromAdmin(QuickFix.Message message, QuickFix.SessionID sessionId)
    {
        if (FromAdminException is not null)
            throw FromAdminException;
    }

    public void ToApp(QuickFix.Message message, QuickFix.SessionID sessionId)
    {
        if (DoNotSendException is not null)
            throw DoNotSendException;
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
