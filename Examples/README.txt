Example Applications
====================

These example applications demonstrate how to use the QuickFIX/n library to 
build your own FIX applications. There are 3 QuickFIX/N example applications:

1. The SimpleAcceptor demonstrates a barebones acceptor application.
2. The Executor takes orders over a FIX session and executes them.
3. The TradeClient is a command line client that sends orders.
   (NOT FOR USE WITH COMMERCIAL FIX INTERFACES!  It won't work!)

TradeClient and Executor can be configured to send and execute
orders with each other.

TradeClient can also be configured to connect to SimpleAcceptor,
though TradeClient will not hear any application-level responses from
SimpleAcceptor.

Each app is meant to be run from its target dir, e.g. Examples\Executor\bin\Debug\.


SimpleAcceptor
==============

The SimpleAcceptor example shows you how to create a simple acceptor server.
It will let initiators connect to it, and logs all admin and application 
level messages to the screen. It does not process these messages.

Program.cs demonstrates how to setup and start a new acceptor object 
from the Session settings file. SimpleAcceptorApp.cs implements
the Application interface and is where you would handle all your application
level logic.

Configure the SimpleAcceptor by modifying SimpleAcceptor/simpleacc.cfg
This configuration file defines the FIX Sessions the acceptor will
handle. For more information - http://quickfixn.org/tutorial/configuration

Build QuickFIX/n first by running build.bat
Then start the SimpleAcceptor by opening a command prompt at 
quickfixn/Examples/SimpleAcceptor/bin/Release and running:
Examples.SimpleAcceptor.exe simpleacc.cfg

Executor
========

The Executor example takes incoming orders and executes them. Executor demonstrates 
how to create an acceptor to crack messages and execute orders. 
The Executor class inherits MessageCracker and implements Application. 
For more information on how message cracking works - 
http://quickfixn.org/tutorial/receiving-messages

The OnMessage callbacks show you how to get field values from the NewOrderSingle 
FIX message and create an ExecutionReport response back to the initiator. Every
FIX version has its own namespace and Messages. When responding to a NewOrderSingle,
you must create a Message based on the initiator's FIX version. If you do not,
the counterparty will reject your message.

The Executor is configured with the executor.cfg file.

Build QuickFIX/n by running build.bat, then start the Executor by opening a command
prompt at quickfixn/Examples/Executor/bin/Release and running:
Executor.exe executor.cfg

TradeClient
===========

The TradeClient is a command line example that shows how to create different FIX 
message types and versions. You can create new order singles, cancel order requests, 
cancel replace requests, and market data requests. 

DO NOT ATTEMPT TO CONNECT TRADECLIENT WITH A COMMERCIAL FIX INTERFACE!  It's a
terrible idea and it will not work.  TradeClient is just an example, to give you a
demonstration of how to complete certain tasks in your own application.

TradeClient is configured with the tradeclient.cfg file.

Build QuickFIX/n by running build.bat, then start TradeClient by opening a command
prompt at quickfixn/Examples/TradeClient/bin/Release and running
TradeClient.exe tradeclient.cfg
