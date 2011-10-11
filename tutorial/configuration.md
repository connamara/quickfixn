Configuring QuickFIX/N
========================

An acceptor or initiator can maintain as many FIX sessions as you would like.  A FIX session is defined in QuickFix/N as a unique combination of a **BeginString** (the FIX version number), a **SenderCompID** (your ID), and a **TargetCompID** (the ID of your counterparty). A **SessionQualifier** can also be used to disambiguate otherwise identical sessions.

Each session can have several settings associated with them.  Some of these settings may not be known at compile time and are therefore passed via a class called `SessionSettings`.  `SessionSettings` behaves as a data dictionary that can be set and queried.

The `SessionSettings` class has the ability to parse settings out of any `System.IO.TextReader`.  You can also simply pass it a filename.  If you decide to write your own components (eg, storage for a particular database) you may also use this to store settings.

A settings file is set up with two types of heading; [DEFAULT] and [SESSION]. [SESSION] tells QuickFIX/N that a new Session is being defined.  [DEFAULT] is a section to define settings which will be associated with sessions that don't explicitly define them.  QuickFIX/N itself will not define default values for all required settings.  If you do not provide a setting that QuickFIX/N needs, it will throw a `ConfigError` telling you what setting is missing or improperly formatted.


Below are the settigns that can be associated with a session based on the default functionality provided with QuickFIX/N, followed by an example.

QuickFIX Settings
-----------------

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>
  <tr>
    <td colspan='4'>Session</td>
  </tr>
  <tr>
    <td>BeginString</td>
    <td>Version of FIX this session uses</td>
    <td>
    Version of FIX this session uses
    </td>
    <td>
    </td>
  </tr>
</table>

