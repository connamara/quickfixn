Configuring QuickFIX/N
========================

An acceptor or initiator can maintain as many FIX sessions as you would like.  A FIX session is defined in QuickFix/N as a unique combination of a **BeginString** (the FIX version number), a **SenderCompID** (your ID), and a **TargetCompID** (the ID of your counterparty). A **SessionQualifier** can also be used to disambiguate otherwise identical sessions.

Each session can have several settings associated with them.  Some of these settings may not be known at compile time and are therefore passed via a class called `SessionSettings`.  `SessionSettings` behaves as a data dictionary that can be set and queried.

The `SessionSettings` class has the ability to parse settings out of any `System.IO.TextReader`.  You can also simply pass it a filename.  If you decide to write your own components (eg, storage for a particular database) you may also use this to store settings.

A settings file is set up with two types of heading; [DEFAULT] and [SESSION]. [SESSION] tells QuickFIX/N that a new Session is being defined.  [DEFAULT] is a section to define settings which will be associated with sessions that don't explicitly define them.  QuickFIX/N itself will not define default values for all required settings.  If you do not provide a setting that QuickFIX/N needs, it will throw a `ConfigError` telling you what setting is missing or improperly formatted.


Below are the settings that can be associated with a session based on the default functionality provided with QuickFIX/N, followed by an example.

QuickFIX Settings
-----------------

* [Session](#session)
* [Validation](#validation)
* [Initiator](#initiator)
* [Acceptor](#acceptor)
* [Storage](#storage)
* [File Storage](#file)
* [Logging](#logging)
* [Sample Settings File](#sample)

<a name='session'> </a>

## Session


<div id="config-table">


<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>

  <tr>
    <td class='setting'>BeginString</td>
    <td class='description'>
    Version of FIX this session uses
    </td>
    <td class='valid'>
      <div>FIXT.1.1</div>
      <div>FIX.4.4</div>
      <div>FIX.4.3</div>
      <div>FIX.4.2</div>
      <div>FIX.4.1</div>
      <div>FIX.4.0</div>
    </td>
    <td class='default'></td>
  </tr>

  <tr>
    <td class='setting'>SenderCompID</td>
    <td class='description'>Your ID as associated with this FIX session</td>
    <td class='valid'>case-sensitive alpha-numeric string</td>
    <td class='default'></td>
  </tr>

  <tr>
    <td class='setting'>SenderSubID</td>
    <td class='description'>(Optional) Your subID as associated with this FIX session</td>
    <td class='valid'>case-sensitive alpha-numeric string</td>
    <td class='default'></td>
  </tr>

  <tr>
    <td class='setting'>SenderLocationID</td>
    <td class='description'>(Optional) Your locationID as associated with this FIX session</td>
    <td class='valid'>case-sensitive alpha-numeric string</td>
    <td class='default'></td>
  </tr>

  <tr>
    <td class='setting'>TargetCompID</td>
    <td class='description'>Counterparty's ID as associated with this FIX session</td>
    <td class='valid'>case-sensitive alpha-numeric string</td>
    <td class='default'></td>
  </tr>

  <tr>
    <td class='setting'>TargetSubID</td>
    <td class='description'>(Optional) Counterparty's subID as associated with this FIX session</td>
    <td class='valid'>case-sensitive alpha-numeric string</td>
    <td class='default'></td>
  </tr>

  <tr>
    <td class='setting'>TargetLocationID</td>
    <td class='description'>(Optional) Counterparty's locationID as associated with this FIX session</td>
    <td class='valid'>case-sensitive alpha-numeric string</td>
    <td class='default'></td>
  </tr>

  <tr>
    <td class='setting'>SessionQualifier</td>
    <td class='description'>Additional qualifier to disambiguate otherwise identical sessions</td>
    <td class='valid'>case-sensitive alpha-numeric string</td>
    <td class='default'></td>
  </tr>

  <tr>
    <td class='setting'>DefaultApplVerID</td>
    <td class='description'>Required only for FIXT 1.1 (and newer).  Ignored for earlier transport versions. Specifies the default application version ID for the session.  This can be the ApplVerID enum (see the ApplVerID field) or the BeginString for the default version.</td>
    <td class='valid'>
      <div>FIX.5.0SP2</div>
      <div>FIX.5.0SP1</div>
      <div>FIX.5.0</div>
      <div>FIX.4.4</div>
      <div>FIX.4.3</div>
      <div>FIX.4.2</div>
      <div>FIX.4.1</div>
      <div>FIX.4.0</div>
    </td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>ConnectionType</td>
    <td class='description'>Defines if session will act as an acceptor or initiator</td>
    <td class='valid'>
      <div>initiator</div>
      <div>acceptor</div>
    </td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>StartTime</td>
    <td class='description'>Time of day that this FIX session becomes activated</td>
    <td class='valid'>Time in the format of HH:MM:SS, time is represented in UTC</td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>EndTime</td>
    <td class='description'>Time of day that this FIX session becomes deactivated</td>
    <td class='valid'>Time in the format of HH:MM:SS, time is represented in UTC</td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>StartDay</td>
    <td class='description'>For week long sessions, the starting day of week of the session.  Use in combination with StartTime.</td>
    <td class='valid'>
      Day of week in English using any abbreviation (ie mo, mon, mond, monda, monday are valid)
    </td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>EndDay</td>
    <td class='description'>For week long sessions, the ending day of week for the session.  Use in combination with EndTime.</td>
    <td class='valid'>
      Day of week in English using any abbreviation (ie mo, mon, mond, monda, monday are valid)
    </td>
    <td class='default'>-</td>
  </tr>
  
  <tr>
    <td class='setting'>MillisecondsInTimeStamp</td>
    <td class='description'>Determines if milliseconds should be added to timestamps. Only available for FIX.4.2 and greater.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>Y</td>
  </tr>

  <tr>
    <td class='setting'>ResetOnLogon</td>
    <td class='description'>Determines if sequence numbers should be reset when receiving a logon request. Acceptors only.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>N</td>
  </tr>

  <tr>
    <td class='setting'>ResetOnLogout</td>
    <td class='description'>Determines if sequence numbers should be reset to 1 after a normal logout termination.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>N</td>
  </tr>

  <tr>
    <td class='setting'>ResetOnDisconnect</td>
    <td class='description'>Determines if sequence numbers should be reset to 1 after an abnormal termination</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>N</td>
  </tr>

  <tr>
    <td class='setting'>RefreshOnLogon</td>
    <td class='description'>Determines if session state should be restored from persistence layer when logging on.  Useful for creating hot failover sessions.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>N</td>
  </tr>
  
  <tr>
    <td class='setting'>EnableLastMsgSeqNumProcessed</td>
    <td class='description'>Add the last message sequence number processed in the header (optional tag 369).</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>N</td>
  </tr>
  
  <tr>
    <td class='setting'>MaxMessagesInResendRequest</td>
    <td class='description'>Sets the maximum number of messages to retransmit in a single resend request.</td>
    <td class='valid'>
      Any integer greater than 0 is valid. Use 0 for infinity (default).
    </td>
    <td class='default'>0</td>
  </tr>
  
  <tr>
    <td class='setting'>SendLogoutBeforeDisconnectFromTimeout</td>
    <td class='description'>Specifies whether a logout message should be sent before a connection is disconnected due to a timeout.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>N</td>
  </tr>
  
  <tr>
    <td class='setting'>IgnorePossDupResendRequests</td>
    <td class='description'>Specifies whether to ignore a resend request when PossDupFlag (tag 43) is set to true</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>N</td>
  </tr>
  
  <tr>
    <td class='setting'>UseLocalTime</td>
    <td class='description'>Specifies whether to use local machine time for session schedule (StartTime and EndTime).</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>N</td>
  </tr>
  
  <tr>
    <td class='setting'>TimeZone</td>
    <td class='description'>Specifies time zone ID used for session schedule. Cannot be used with UseLocalTime. Supplied ID will be passed to <a href="http://msdn.microsoft.com/en-us/library/system.timezoneinfo.findsystemtimezonebyid.aspx">TimeZoneInfo.FindSystemTimeZoneById</a>.  (See <a href="http://stackoverflow.com/questions/7908343/list-of-timezone-ids-for-use-with-findtimezonebyid-in-c">here</a> for how to get a list of valid IDs on your system.)</td>
    <td class='valid'>Any time zone ID supported on target system.</td>
    <td class='default'>-</td>
  </tr>
</table>


<a name='validation'> </a>

<h2>Validation</h2>

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>

  <tr>
    <td class='setting'>UseDataDictionary</td>
    <td class='description'>Tells session whether or not to expect a data dictionary.  <em>You should always use a DataDictionary if you are using repeating groups.</em></td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>Y</td>
  </tr>

  <tr>
    <td class='setting'>DataDictionary</td>
    <td class='description'>
      <div>XML definition file for validating incoming FIX messages. If no DataDictionary is supplied, only basic message validation will be done.</div><br/> 
      <div>This setting should only be used with FIX transport versions older than FIXT.1.1. See TransportDataDictionary and AppDataDictionary for FIXT.1.1 settings.</div>
    </td>
    <td class='valid'>
      <div>Valid XML data dictionary file.  QuickFIX/N comes with the following defaults in the spec/fix directory</div><br/>
      <div>FIX44.xml</div>
      <div>FIX43.xml</div>
      <div>FIX42.xml</div>
      <div>FIX41.xml</div>
      <div>FIX40.xml</div>
    </td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>TransportDataDictionary</td>
    <td class='description'>
      <div>XML definition file for validating admin (transport) messages.  This setting is only valid for FIXT.1.1 (or newer) sessions.</div><br/>
      <div>See DataDictionary for older transport versions (FIX.4.0-FIX.4.4) for additional information.</div>
    </td>
    <td class='valid'>
      <div>Valid XML data dictionary file. QuickFIX/N comes with the following defaults in the spec/fix directory</div><br/>
      <div>FIXT1.1.xml</div>
    </td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>AppDataDictionary</td>
    <td class='description'>
      <div>XML definition file for validating application messages.  This setting is only valid for FIXT.1.1 (or newer) sessions.</div><br/>
      <div>See DataDictionary for older transport versions (FIX.4.0-FIX.4.4) for additional information.</div><br/>
      <div>This setting supports the possibility of a custom application data dictionary for each session.  This setting would only be used with FIXT.1.1 and newer transport protocols.  This setting can be used as a prefix to specify multiple application dictionaries for the FIXT transport.  For example:</div><br/>
      <code>
        DefaultApplVerID=FIX.4.2
        # For default application version ID
        AppDataDictionary=FIX42.xml
        # For nondefault application version ID
        # Use BeginString suffix for app version
        AppDataDictionary.FIX.4.4=FIX44.xml
      </code>
    </td>
    <td class='valid'>
      <div>Valid XML data dictionary file, QuickFIX/N comes with the following defaults in the spec/fix directory</div><br/>
      <div>FIX50SP2.xml</div>
      <div>FIX50SP1.xml</div>
      <div>FIX50.xml</div>
      <div>FIX44.xml</div>
      <div>FIX43.xml</div>
      <div>FIX42.xml</div>
      <div>FIX41.xml</div>
      <div>FIX40.xml</div>
    </td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>ValidateFieldsOutOfOrder</td>
    <td class='description'>If set to N, fields that are out of order (ie, body fields in the header, or header fields in the body) will not be rejected.  Useful for connecting to systems which do not properly order fields.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>Y</td>
  </tr>

  <tr>
    <td class='setting'>ValidateFieldsHaveValues</td>
    <td class='description'>If set to N, fields without values (empty) will not be rejected.  Useful for connecting to systems that improperly send empty tags.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>Y</td>
  </tr>

  <tr>
    <td class='setting'>ValidateUserDefinedFields</td>
    <td class='description'>If set to N, user defined fields will not be rejected if they are not defined in the data dictionary, or are not present in messages they do not belong to.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>Y</td>
  </tr>
</table>

<a name='initiator'></a>

<h2>Initiator</h2>

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>

  <tr>
    <td class='setting'>ReconnectInterval</td>
    <td class='description'>Time between reconnection attempts in seconds.  Only used for initiators.</td>
    <td class='valid'>Positive integer</td>
    <td class='default'>30</td>
  </tr>

  <tr>
    <td class='setting'>HeartBtInt</td>
    <td class='description'>Heartbeat interval in seconds. Only used for initiators.</td>
    <td class='valid'>Positive integer</td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>LogonTimeout</td>
    <td class='description'>Number of seconds to wait for a logon response before disconnecting.</td>
    <td class='valid'>Positive integer</td>
    <td class='default'>10</td>
  </tr>

  <tr>
    <td class='setting'>LogoutTimeout</td>
    <td class='description'>Number of seconds to wait for a logout response before disconnecting.</td>
    <td class='valid'>Positive integer</td>
    <td class='default'>2</td>
  </tr>

  <tr>
    <td class='setting'>SocketConnectPort</td>
    <td class='description'>Socket port for connecting to a session.  Only used for initiators.</td>
    <td class='valid'>Positive integer</td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>SocketConnectHost</td>
    <td class='description'>Host to connect to.  Only used for initiators.</td>
    <td class='valid'>Valid IP address in the format of x.x.x.x or a domain name</td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>SocketConnectPort&lt;n&gt;</td>
    <td class='description'>Alternate socket ports for connecting to a session for failover, where <strong>n</strong> is a positive integer. ie, SocketConnectPort1, SocketConnectPort2... must be consecutive and have a matching SocketConnectHost&lt;n&gt;</td>
    <td class='valid'>Positive integer</td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>SocketConnectHost&lt;n&gt;</td>
    <td class='description'>Alternate socket hosts for connecting to a session for failover, where <strong>n</strong> is a positive integer. ie, SocketConnectHost1, SocketConnectHost2... must be consecutive and have a matching SocketConnectPort&lt;n&gt;</td>
    <td class='valid'>Valid IP address in the format of x.x.x.x or a domain name</td>
    <td class='default'>-</td>
  </tr>
  
  <tr>
    <td class='setting'>SocketNodelay</td>
    <td class='description'>Disable Nagle's algorithm for this connection. Written data to the network is not buffered pending acknowledgement of previously written data. Currently, this must be defined in the [DEFAULT] section.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>Y</td>
  </tr>
</table>

<a name='acceptor'></a>

<h2>Acceptor</h2>

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>

  <tr>
    <td class='setting'>SocketAcceptPort</td>
    <td class='description'>Socket port for listening to incoming connections.  Only used with acceptors.</td>
    <td class='valid'>Positive integer, valid open socket port</td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>SocketAcceptHost</td>
    <td class='description'>Socket host for listening to incoming connections.  If not provided, the acceptor will listen on all network interfaces (0.0.0.0)</td>
    <td class='valid'>Valid IP address in the format of x.x.x.x</td>
    <td class='default'>0.0.0.0</td>
  </tr>
  
  <tr>
    <td class='setting'>SocketNodelay</td>
    <td class='description'>Disable Nagle's algorithm for this connection. Written data to the network is not buffered pending acknowledgement of previously written data. Currently, this must be defined in the [DEFAULT] section.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>Y</td>
  </tr>
</table>

<a name='storage'></a>

<h2>Storage</h2>

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>

  <tr>
    <td class='setting'>PersistMessages</td>
    <td class='description'>If set to N, no messages will be persisted. This will force QuickFIX to always send GapFills instead of resending messages. Use this if you know you never want to resend a message. Useful for market data streams.</td>
    <td class='valid'>
      <div>Y</div>
      <div>N</div>
    </td>
    <td class='default'>
      Y
    </td>
  </tr>

</table>

<a name='file'></a>

<h2>File Storage</h2>

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>

  <tr>
    <td class='setting'>FileStorePath</td>
    <td class='description'>Directory to store sequence number and message files.</td>
    <td class='valid'>Valid directory for storing files, must have write access.</td>
    <td class='default'>-</td>
  </tr>
</table>

<a name='logging'></a>

<h2>Logging</h2>

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>

  <tr>
    <td class='setting'>FileLogPath</td>
    <td class='description'>Directory to store logs.</td>
    <td class='valid'>Valid directory for storing files, must have write access</td>
    <td class='default'>-</td>
  </tr>

  <tr>
    <td class='setting'>DebugFileLogPath</td>
    <td class='description'>Directory to store ThreadedClientAcceptor thread logs.
    <td class='valid'>Valid directory for storing files, must have write access</td>
    <td class='default'>Value of <tt>FileLogPath</tt> if present, else "log".</td>
  </tr>
</table>


</div>


<a name='sample'></a>

##Sample Initiator Settings File

Here is a typical initiator settings file you might find in a firm that wants to connect to several ECNs.

    # default settings for sessions
    [DEFAULT]
    FileStorePath=store
    FileLogPath=log
    ConnectionType=initiator
    ReconnectInterval=60
    SenderCompID=TW

    # session definition
    [SESSION]
    # inherit FileStorePath, FileLogPath, ConnectionType, 
    #    ReconnectInterval and SenderCompID from default
    BeginString=FIX.4.1
    TargetCompID=ARCA
    StartTime=12:30:00
    EndTime=23:30:00
    HeartBtInt=20
    SocketConnectPort=9823
    SocketConnectHost=123.123.123.123
    DataDictionary=somewhere/FIX41.xml

    [SESSION]
    BeginString=FIX.4.0
    TargetCompID=ISLD
    StartTime=12:00:00
    EndTime=23:00:00
    HeartBtInt=30
    SocketConnectPort=8323
    SocketConnectHost=23.23.23.23
    DataDictionary=somewhere/FIX40.xml

    [SESSION]
    BeginString=FIX.4.2
    TargetCompID=INCA
    StartTime=12:30:00
    EndTime=21:30:00
    # overide default setting for RecconnectInterval
    ReconnectInterval=30
    HeartBtInt=30
    SocketConnectPort=6523
    SocketConnectHost=3.3.3.3
    # (optional) alternate connection ports 
    #  and hosts to cycle through on failover
    SocketConnectPort1=8392
    SocketConnectHost1=8.8.8.8
    SocketConnectPort2=2932
    SocketConnectHost2=12.12.12.12
    DataDictionary=somewhere/FIX42.xml

##Sample Acceptor Settings File

Here is a typical acceptor settings file.

    # default settings for sessions
    [DEFAULT]
    FileStorePath=store
    FileLogPath=log
    ConnectionType=acceptor
    ReconnectInterval=60
    SenderCompID=ARCA

    # session definition
    [SESSION]
    # inherit FileStorePath, FileLogPath, ConnectionType, 
    #  ReconnectInterval and SenderCompID from default
    BeginString=FIX.4.1
    TargetCompID=TW
    StartTime=12:30:00
    EndTime=23:30:00
    HeartBtInt=20
    SocketAcceptPort=9823
    DataDictionary=somewhere/FIX41.xml

    [SESSION]
    BeginString=FIX.4.0
    TargetCompID=TW
    StartTime=12:00:00
    EndTime=23:00:00
    HeartBtInt=30
    SocketAcceptPort=8323
    DataDictionary=somewhere/FIX40.xml

    [SESSION]
    BeginString=FIX.4.2
    TargetCompID=TW
    StartTime=12:30:00
    EndTime=21:30:00
    # overide default setting for RecconnectInterval
    ReconnectInterval=30
    HeartBtInt=30
    SocketAcceptPort=6523
    # (optional) only listen for incoming connections on a specific host
    SocketAcceptHost=127.0.0.1
    DataDictionary=somewhere/FIX42.xml
