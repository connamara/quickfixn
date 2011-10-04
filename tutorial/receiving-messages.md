Receiving Messages
==================

Receiving messages in QuickFIX/N is type safe and simple:

```c#
public void OnMessage(
    FIX44.NewOrderSingle order, 
    SessionID sessionID)
{
    ProcessOrder(order.Price, order.OrderQty, order.Account);
}
```

To get this functionality,  we will mixin `MessageCracker` to our application.

Type Safe Messages
------------------

QuickFIX/N is flexible - it gives you access to the generic base class `Message` as well as specific message classes.

The best way to write an app is with the strongly typed specific Message 
classes, and we use the `MessageCracker` for this.  We will import the `MessageCracker` class, inherit from it, then call `Crack` in the `FromApp` callback for our application:

```c#
using QuickFix;

public class MyApplication : MessageCracker, Application
{
    public void FromApp(Message msg, SessionID sessionID)
    {
        Crack(msg, sessionID);
    }
    //...
}
```

`Crack` will then call the appropriate overloaded `OnMessage` callback.
These callbacks would receive orders and security definitions
respectively:

```c#
public void OnMessage(
    FIX44.NewOrderSingle ord, 
    SessionID sessionID)
{
    ProcessOrder(ord.Price, ord.OrderQty, ord.Account);
}

public void OnMessage(
    FIX44.SecurityDefinition secDef, 
    SessionID sessionID)
{
    GotSecDef(secDef);
}

```

Putting it all together, a full application with type safe orders
looks like this:

```c#

public class MyApplication : MessageCracker, Application
{
    public void OnMessage(
        FIX42.NewOrderSingle ord,
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
