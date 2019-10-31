---
layout: page
title: Creating An Application
nav_title: Docs
menu_title: Creating An Application
type: tutorial
weight: 2
---

Get your DLLs
-------------

Starting with v1.9.0, your project will need at least 2 QuickFIX/n dlls:

* the core: QuickFix.dll
* the message definitions for the FIX version(s) you're using, which will be one or more of:
  * QuickFix.FIX40.dll
  * QuickFix.FIX41.dll
  * QuickFix.FIX42.dll
  * QuickFix.FIX43.dll
  * QuickFix.FIX44.dll
  * QuickFix.FIX50.dll
  * QuickFix.FIX50SP1.dll
  * QuickFix.FIX50SP2.dll

All of these are in the release zip.

(If you built QF/n from source, then you'll find these dlls in `Messages\FIX<n>\bin\`)

Most applications only need to support one FIX version.


Creating Your Application
-------------------------

Creating a FIX application is easy; simply implement an `IApplication`:

```csharp
public class MyQuickFixApp : IApplication
{
    public void FromApp(Message msg, SessionID sessionID) { }
    public void OnCreate(SessionID sessionID) { }
    public void OnLogout(SessionID sessionID) { }
    public void OnLogon(SessionID sessionID) { }
    public void FromAdmin(Message msg, SessionID sessionID) { }
    public void ToAdmin(Message msg, SessionID sessionID) { }
    public void ToApp(Message msg, SessionID sessionID) { }
}
```

These methods will be called on QuickFIX/N events.  We'll explain what each 
callback does next.

Application Callbacks
---------------------

The callbacks in a QuickFIX/N application notify us of events - when
a counterparty logs on, when admin messages are sent, and most
importantly, when application messages are received.

**FromApp** - every inbound application level message will pass through this
method, such as orders, executions, security definitions, and market
data.  

**FromAdmin** - every inbound admin level message will pass through this
method, such as heartbeats, logons, and logouts.

**OnCreate** - this method is called whenever a new session is created.

**OnLogon** - notifies when a successful logon has completed.

**OnLogout** - notifies when a session is offline - either from an
exchange of logout messages or network connectivity loss.

**ToApp** - all outbound application level messages pass through this callback 
before they are sent.  If a tag needs to be added to every outgoing message, 
this is a good place to do that.

**ToAdmin** - all outbound admin level messages pass through this
callback.  

Better Type Safety
------------------

We **highly recommend** implementing the [Receiving Messages](/tutorial/receiving-messages) tutorial to receive more type safe messages, 


Initiators and Acceptors
------------------------

QuickFIX/N implements both the initiator and acceptor pattern in FIX.

*Initiator* is the FIX term for client - we use an `Initiator` when we are
connecting to another party.

*Acceptor* is the FIX term for server - we use an `Acceptor` when
other parties are connecting to us.

Creating Our Application
------------------------

Putting it all together, we implement the `Application` interface then
instantiate an `Acceptor`:

```csharp
using QuickFix;

public class MyQuickFixApp : IApplication
{
    public void FromApp(Message msg, SessionID sessionID) { }
    public void OnCreate(SessionID sessionID) { }
    public void OnLogout(SessionID sessionID) { }
    public void OnLogon(SessionID sessionID) { }
    public void FromAdmin(Message msg, SessionID sessionID) { }
    public void ToAdmin(Message msg, SessionID sessionID) { }
    public void ToApp(Message msg, SessionID sessionID) { }
}

public class MyApp
{
    static void Main(string[] args)
    {
        SessionSettings settings = new SessionSettings(args[0]);
        IApplication myApp = new MyQuickFixApp();
        IMessageStoreFactory storeFactory = new FileStoreFactory(settings);
        ILogFactory logFactory = new FileLogFactory(settings);
        ThreadedSocketAcceptor acceptor = new ThreadedSocketAcceptor(
            myApp,
            storeFactory,
            settings,
            logFactory);

        acceptor.Start();
        while (true)
        {
            System.Console.WriteLine("o hai");
            System.Threading.Thread.Sleep(1000);
        }
        acceptor.Stop();
    }
}
```

Please view the [Receiving Messages](/tutorial/receiving-messages)
tutorial to see how to implement type safe message callbacks. **This is
highly recommended.**

Switching this to an `Initiator` is as simple as swapping out the
`ThreadedSocketAcceptor` class for the `SocketInitiator` class.

The `IMessageStore` keeps a record of all outgoing messages for FIX
session level messaging.  We could implement our own store by
implementing the `MessageStoreFactory` interface.

There are a few options for logging, with file logger probably being the
most useful.  We could also implement our own logger by implementing the
`ILogFactory` interface.


