---
layout: default
title: Sending Messages
---

Sending Messages
================

We are going to send some FIX messages in this tutorial:

{% highlight csharp %}

    var order = new FIX44.NewOrderSingle(
        new ClOrdID("1234"),
        new Symbol("AAPL"),
        new Side(Side.BUY),
        new TransactTime(DateTime.Now),
        new OrdType(OrdType.MARKET));

    Session.SendToTaget(order, sessionID);

{% endhighlight%}

First, we need to learn how to direct messages with Sessions.


QuickFIX Sessions
-----------------

All QuickFIX Sessions are identified by fields in the header of a
message, usually `SenderCompID`, `TargetCompID`, and `BeginString`.
These are specified in the config file.

    SenderCompID=CONNAMARA
    TargetCompID=CBOE
    BeginString=FIX4.4

When sending a message, we must tell QuickFIX which Session to send it
to.  There are a few patterns to gather the session.

We can grab the `SessionID` after a successful logon and cache it:

{% highlight csharp %}

    private SessionID MySessionID { get; set; }
    public void OnLogon(SessionID sessionID)
    {
        MySessionID = sessionID;
    }

{% endhighlight %}

We can get the `SessionID` when responding to an incoming message:

{% highlight csharp %}

    public void OnMessage(FIX42.ExecutionReport execution, SessionID sessionID) 
    {
        ProcessExecution(execution, sessionID);
    }

{% endhighlight %}

Or, we can construct a `SessionID` by matching the values from
our config file:

{% highlight csharp %}

    var mySessionID = new SessionID("FIX4.4", "CONNAMARA", "CBOE");

{% endhighlight %}

Creating and Sending a Message
------------------------------

The preferred constructor to use includes the specific FIX version
and message type.  We also pass in the required fields:

{% highlight csharp %}

    import QuickFix;
    import QuickFix.Fields;

    var order = new QuickFix.FIX44.NewOrderSingle(
        new ClOrdID("1234"),
        new Symbol("AAPL"),
        new Side(Side.BUY),
        new TransactTime(DateTime.Now),
        new OrdType(OrdType.LIMIT));

{% endhighlight %}

To set fields, use the message's field properties:
{% highlight csharp %}

    order.Price = new Price(new decimal(22.4));
    order.Account = new Account("18861112");

{% endhighlight %}

Putting it all together - creating the message, setting its required
fields, setting two additional fields, using `SessionID` from the
section above, we send the message on its way:

{% highlight csharp %}

    var order = new QuickFix.FIX44.NewOrderSingle(
        new ClOrdID("1234"),
        new Symbol("AAPL"),
        new Side(Side.BUY),
        new TransactTime(DateTime.Now),
        new OrdType(OrdType.LIMIT));

    order.Price = new Price(new decimal(22.4));
    order.Account = new Account("18861112");

    Session.SendToTarget(order, sessionID);

{% endhighlight %}


Alternative Constructors and Field Setters
------------------------------------------

The type safe way -- the best way -- was demonstrated above, but there
are a few other ways to create messages and set fields.

Each message type has a default constructor:

{% highlight csharp %}

    var order = new QuickFix.FIX44.NewOrderSingle();
    order.ClOrdID =  new ClOrdID("1234");
    order.Symbol = new Symbol("AAPL");
    order.Side = new Side(Side.BUY);

{% endhighlight %}

We have the QuickFIX C++ and QuickFIX/J style get/set methods available,
which are also type safe:

{% highlight csharp %}

    order.Set(new TransactTime(DateTime.Now));
    order.Set(new OrdType(OrdType.LIMIT));

{% endhighlight %}

For setting a field that isn't a property of a message, use `setField`:

{% highlight csharp %}

    order.SetField(new Account("18861112"));

{% endhighlight %}

Here we create base `Message` class;  it has no properties so `SetField`
must be used everywhere.  *This style is not recommended*:

{% highlight csharp %}

    var order = new QuickFix.Message();
    order.Header.SetField(new MsgType("D"));
    order.SetField(new ClOrdID("1234"));
    order.SetField(new Symbol("AAPL"));
    order.SetField(new Side(Side.BUY));
    order.SetField(new TransactTime(DateTime.Now));
    order.SetField(new OrdType(OrdType.LIMIT));

{% endhighlight %}
