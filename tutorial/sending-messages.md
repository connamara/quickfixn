Sending Messages
================

Sending FIX messages in QuickFIX/N is simple:

```c#
FIX44.NewOrderSingle order = new FIX44.NewOrderSingle(
    new ClOrdID("1234"),
    new Symbol("AAPL"),
    new Side(Side.BUY),
    new TransactTime(DateTime.Now),
    new OrdType(OrdType.MARKET));

Session.SendToTaget(order, sessionID);
```

First, we need to learn how to direct messages with Sessions.


QuickFIX Sessions
-----------------

When sending a message, we must tell QuickFIX which Session to send it
to.

All QuickFIX Sessions are identified by fields in the header of a
message, usually `SenderCompID`, `TargetCompID`, and `BeginString`.
These are specified in the config file.

```
SenderCompID=CONNAMARA
TargetCompID=CBOE
BeginString=FIX.4.4
```

There are a few patterns to gather the session.  We can grab the `SessionID` when it is created and cache it:

```c#
private SessionID MySessionID { get; set; }
public void OnCreate(SessionID sessionID)
{
    MySessionID = sessionID;
}
```

We can get the `SessionID` when responding to an incoming message:

```c#
public void OnMessage(FIX42.ExecutionReport execution, SessionID sessionID) 
{
    ProcessExecution(execution, sessionID);
}
```

Or, we can construct a `SessionID` by matching the values from
our config file:

```c#
var mySessionID = new SessionID("FIX4.4", "CONNAMARA", "CBOE");
```

Creating and Sending a Message
------------------------------

The preferred constructor to use includes the specific FIX version
and message type.  We also pass in the required fields:

```c#
import QuickFix;
import QuickFix.Fields;

var order = new QuickFix.FIX44.NewOrderSingle(
    new ClOrdID("1234"),
    new Symbol("AAPL"),
    new Side(Side.BUY),
    new TransactTime(DateTime.Now),
    new OrdType(OrdType.LIMIT));
```

To set fields, use the message's field properties:

```c#
order.Price = new Price(new decimal(22.4));
order.Account = new Account("18861112");
```

Putting it all together - creating the message, setting its required
fields, setting two additional fields, using `SessionID` from the
section above, we send the message on its way:

```c#
var order = new QuickFix.FIX44.NewOrderSingle(
    new ClOrdID("1234"),
    new Symbol("AAPL"),
    new Side(Side.BUY),
    new TransactTime(DateTime.Now),
    new OrdType(OrdType.LIMIT));

order.Price = new Price(new decimal(22.4));
order.Account = new Account("18861112");

Session.SendToTarget(order, sessionID);
```

--

Alternative Constructors and Field Setters
------------------------------------------

The type safe way -- the best way -- was demonstrated above, but there
are a few other ways to create messages and set fields.

Each message type has a default constructor:

```c#
var order = new QuickFix.FIX44.NewOrderSingle();
order.ClOrdID =  new ClOrdID("1234");
order.Symbol = new Symbol("AAPL");
order.Side = new Side(Side.BUY);
```

We have the QuickFIX C++ and QuickFIX/J style get/set methods available,
which are also type safe:

```c#
order.Set(new TransactTime(DateTime.Now));
order.Set(new OrdType(OrdType.LIMIT));
```

For setting a field that isn't a property of a message, use `setField`:

```c#
order.SetField(new Account("18861112"));
```

Here we create base `Message` class;  it has no properties so `SetField`
must be used everywhere.  *This style is not recommended*:

```c#
var order = new QuickFix.Message();
order.Header.SetField(new MsgType("D"));
order.SetField(new ClOrdID("1234"));
order.SetField(new Symbol("AAPL"));
order.SetField(new Side(Side.BUY));
order.SetField(new TransactTime(DateTime.Now));
order.SetField(new OrdType(OrdType.LIMIT));
```
