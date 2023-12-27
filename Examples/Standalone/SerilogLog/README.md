Sample QuickFix.ILog Implementation
===================================

This is an example of enriching QuickFIX/N logging using a 3rd party NuGet
(Serilog.Sinks.File in this case). Features added are rolling log files 
and limited total log size.

The solution contains 2 projects:

1. The SerilogLog is a sample implementation of ILog and ILogFactory.  
     _NOTE: this is a sample, **NOT** a finished ready-to-use product.
     Follow comments in the source code to adjust the example to
     your actual requirements._

2. The UnitTests are proof that limits for log size are working.

The projects are dependent on QuickFix.dll (ILog and ILogFactory interfaces).
Assuming the standard directory structure, the reference path is:

    <project-root>\QuickFIXn\bin\Debug\net6.0\QuickFix.dll

You need to build QuickFIXn release configuration to have the DLL available.
Alternatively, you can change the reference in the both projects.

If you copy/paste the source code in your project, you need to have
references to QuickFix.dll and NuGet Serilog.Sinks.File installed.

Usage example:

    ILogFactory logFactory = new SerilogLogFactory(settings);
    ThreadedSocketAcceptor _acceptor = new ThreadedSocketAcceptor(executorApp,
        storeFactory, settings, logFactory);

All sessions created by this `_acceptor` will be using SerilogLog
for messages and events logging.
