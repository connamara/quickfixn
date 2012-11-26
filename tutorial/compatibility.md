QuickFIX .NET wrapper compatibility
===================================

QuickFIX/n is not compatible with the [QuickFIX C++ .NET wrapper][0]. This means
you cannot simply replace the .NET wrapper DLLs with the QuickFIX/n DLL, and
expect your existing code to compile.

The QuickFIX programming style is unchanged, so the top level interfaces 
you wrote code against are still the same. Creating an application is still the 
same as before. Your application needs to implement the standard application 
callbacks (FromApp, ToApp, etc...). MessageCracker is still the recommended way 
to receive messages, and you write your code in the OnMessage callbacks. Sending
a message to a counterparty is the same method call.

Most of the changes you need to make to an existing application are minor, such 
as changing a method or namespace name. Below is a list of known compatibility 
issues:

*  Method names are now upper camel case.

     For example: `Session.logout()` is now
     `Session.Logout()` and `Application.fromApp()` is now `Application.FromApp()`

*  Getter and setter methods no longer exist and have been (or will eventually be)
   replaced with .NET properties. 
   
     Previously, you would call `order.getClOrdID()` to get the
     ClOrdID value from a NewOrderSingle message. Now, just use `order.ClOrdID`

     For a setter: `exec.setField(order.getClOrdID());` is now
     `exec.ClOrdID = order.ClOrdID;`

*  Interface classes now start with *I*, per .NET convention.  For instance,
   where you'd implement an `Application` in QuickFIX/C++, you'll now implement an
   `IApplication`.

*  FIX Message classes used to be part of the QuickFix## namespace, where ## is the
   FIX version. Now they are part of the QuickFix.FIX## namespace. 
   
     For example: `QuickFix42.NewOrderSingle` is now `QuickFix.FIX42.NewOrderSingle`

*  Socket acceptor and initiator classes are different.

     QuickFIX/n's default initiator is `QuickFix.Transport.SocketInitiator` and the
     default acceptor is `QuickFix.ThreadedSocketAcceptor`

*  There may be new or different QuickFIX settings. Please look at the [configuration page][2]
   to determine if you need to update your configuration files.

If we missed anything, [let us know][1]

[0]: http://www.quickfixengine.org/quickfix/doc/html/building.html#Windows%20(.NET)
[1]: /help
[2]: http://quickfixn.org/tutorial/configuration
