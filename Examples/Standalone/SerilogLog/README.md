Sample QuickFix.ILog Implementation
===================================

This is an example of using the third-party Serilog ILogger implementation
in your QuickFIX/n program.

This example shows how to configure a Serilog ILogger that:

* Logs to files
* Rolls message log files on the hour
* Rolls event log files on the minute
* Creates separate log file sets for each session

This config is meant to demonstrate some features for educational purposes,
but is probably not something you'd actually *want* to use on a real app
(for instance, you wouldn't want to roll logs on the minute...).

This application's configuration will allow it to connect with the Executor example.

Run it with:

`Examples/Standalone/SerilogLog$ dotnet run`

(config file is specified via appsettings.json)
