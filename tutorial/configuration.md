Configuring QuickFIX/N
========================

An acceptor or initiator can maintain as many FIX sessions as you would like.  A FIX session is defined in QuickFix/N as a unique combination of a **BeginString** (the FIX version number), a **SenderCompID** (your ID), and a **TargetCompID** (the ID of your counterparty). A **SessionQualifier** can also be used to disambiguate otherwise identical sessions.

Each session can have several settings associated with them.  Some of these settings may not be known at compile time and are therefore passed via a class called `SessionSettings`.  `SessionSettings` behaves as a data dictionary that can be set and queried.

The `SessionSettings` class has the ability to parse settings out of any `System.IO.TextReader`.  You can also simply pass it a filename.  If you decide to write your own components (eg, storage for a particular database) you may also use this to store settings.

A settings file is set up with two types of heading; [DEFAULT] and [SESSION]. [SESSION] tells QuickFIX/N that a new Session is being defined.  [DEFAULT] is a section to define settings which will be associated with sessions that don't explicitly define them.  QuickFIX/N itself will not define default values for all required settings.  If you do not provide a setting that QuickFIX/N needs, it will throw a `ConfigError` telling you what setting is missing or improperly formatted.


Below are the settings that can be associated with a session based on the default functionality provided with QuickFIX/N, followed by an example.

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
    <th colspan='4' class='th-sub'>Session</td>
  </tr>

  <tr>
    <td>BeginString</td>
    <td>
    Version of FIX this session uses
    </td>
    <td>
      <div>FIXT.1.1</div>
      <div>FIX.4.4</div>
      <div>FIX.4.3</div>
      <div>FIX.4.2</div>
      <div>FIX.4.1</div>
      <div>FIX.4.0</div>
    </td>
    <td></td>
  </tr>

  <tr>
    <td>SenderCompID</td>
    <td>Your ID as associated with this FIX session</td>
    <td>case-sensitive alpha-numeric string</td>
    <td></td>
  </tr>

  <tr>
    <td>TargetCompID</td>
    <td>Counterparty's ID as associated with this FIX session</td>
    <td>case-sensitive alpha-numeric string</td>
    <td></td>
  </tr>

  <tr>
    <td>SessionQualifier</td>
    <td>Additional qualifier to disambiguate otherwise identical sessions</td>
    <td>case-sensitive alpha-numeric string</td>
    <td></td>
  </tr>

  <tr>
    <td>DefaultApplVerID</td>
    <td>Required only for FIXT 1.1 (and newer).  Ignored for earlier transport versions. Specifies the default application version ID for the session.  This can be the ApplVerID enum (see the ApplVerID field) or the BeginString for the default version.</td>
    <td>
      <div>FIX.5.0SP2</div>
      <div>FIX.5.0SP1</div>
      <div>FIX.5.0</div>
      <div>FIX.4.4</div>
      <div>FIX.4.3</div>
      <div>FIX.4.2</div>
      <div>FIX.4.1</div>
      <div>FIX.4.0</div>
    </td>
    <td/>
  </tr>

  <tr>
    <td>ConnectionType</td>
    <td>Defines if session will act as an acceptor or initiator</td>
    <td>
      <div>initiator</div>
      <div>acceptor</div>
    </td>
    <td/>
  </tr>

  <tr>
    <td>ResetOnLogon</td>
    <td>Determines if sequence numbers should be reset when receiving a logon request. Acceptors only.</td>
    <td>
      <div>Y</div>
      <div>N</div>
    </td>
    <td>N</td>
  </tr>

  <tr>
    <td>ResetOnLogout</td>
    <td>Determines if sequence numbers should be reset to 1 after a normal logout termination.</td>
    <td>
      <div>Y</div>
      <div>N</div>
    </td>
    <td>N</td>
  </tr>

  <tr>
    <td>ResetOnDisconnect</td>
    <td>Determines if sequence numbers should be reset to 1 after an abnormal termination</td>
    <td>
      <div>Y</div>
      <div>N</div>
    </td>
    <td>N</td>
  </tr>

  <tr>
    <td>RefreshOnLogout</td>
    <td>Determines if session state should be restored from persistence layer when logging on.  Useful for creating hot failover sessions.</td>
    <td>
      <div>Y</div>
      <div>N</div>
    </td>
    <td>N</td>
  </tr>
  <tr>
    <th colspan='4' class='th-sub'>Validation</td>
  </tr>




</table>

