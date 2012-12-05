Receiving Messages
==================

Receiving messages in QuickFIX/N is type safe and simple:

```c#
public void OnMessage(
    QuickFix.FIX44.NewOrderSingle order, 
    SessionID sessionID)
{
    ProcessOrder(order.Price, order.OrderQty, order.Account);
}
```

Receiving Type Safe Messages
----------------------------

The best way to write an app is with the specific, strongly typed Message
and Field classes, which we'll mixin with `MessageCracker`. We
import the `MessageCracker` class, inherit from it, then call `Crack`
inside `FromApp`:

```c#
using QuickFix;

public class MyApplication : MessageCracker, IApplication
{
    public void FromApp(Message msg, SessionID sessionID)
    {
        Crack(msg, sessionID);
    }
    //...
}
```

`Crack` will then call the appropriate overloaded `OnMessage` callback.
This example receives orders and security definitions:

```c#
public void OnMessage(
    QuickFix.FIX44.NewOrderSingle ord, 
    SessionID sessionID)
{
    ProcessOrder(ord.Price, ord.OrderQty, ord.Account);
}

public void OnMessage(
    QuickFix.FIX44.SecurityDefinition secDef, 
    SessionID sessionID)
{
    GotSecDef(secDef);
}
```

Example Message Cracker
-----------------------

Putting it all together, a full application with type safe orders
looks like this:

```c#
public class MyApplication : MessageCracker, IApplication
{
    public void OnMessage(
        QuickFix.FIX42.NewOrderSingle ord,
        SessionID sessionID)
    {
        ProcessOrder(ord.Price, ord.OrderQty, ord.Account);
    }

    protected void ProcessOrder(
        Price price,
        OrderQty quantity,
        Account account)
    {
        //...
    }

    #region Application Methods

    public void FromApp(Message msg, SessionID sessionID)
    {
        Crack(msg, sessionID);
    }
    public void OnCreate(SessionID sessionID) { }
    public void OnLogout(SessionID sessionID) { }
    public void OnLogon(SessionID sessionID) { }
    public void FromAdmin(Message msg, SessionID sessionID)
    { }
    public void ToAdmin(Message msg, SessionID sessionID)
    { }
    public void ToApp(Message msg, SessionID sessionID)
    { }

    #endregion
}
```

Less Type Safe
--------------

It is possible to receive message callbacks with only the base class
`Message`.

**This is not recommended** - we lose the typesafe `Group` and `Field`
properties and extra boilerplate logic is required:

```c#
// NOT RECOMMENDED
public class MyApplication : IApplication
{
    public void FromApp(Message msg, SessionID sessionID)
    {
        string msgType = msg.Header.GetString(Tags.MsgType);
        if (msgType.Equals(MsgType.EXECUTION_REPORT))
        {
          string account = msg.GetString(Tags.Account);
          decimal price = msg.GetDecimal(Tags.Price);
        }
    }
    // ...same Application callbacks as above
}
```
