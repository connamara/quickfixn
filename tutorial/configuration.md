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
* [Logging](#logging)
* [Sample Settings File](#sample)

<a name='session'> </a>

### Session

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
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
</table>


<a name='validation'> </a>

### Validation

<table>
  <tr>
    <th>Setting</th>
    <th>Description</th>
    <th>Valid Values</th>
    <th>Default</th>
  </tr>

  <tr>
    <td>UseDataDictionary</td>
    <td>Tells session whether or not to expect a data dictionary.  <em>You should always use a DataDictionary if you are using repeating groups.</em></td>
    <td>
      <div>Y</div>
      <div>N</div>
    </td>
    <td>Y</td>
  </tr>

  <tr>
    <td>DataDictionary</td>
    <td>
      <div>XML definition file for validating incoming FIX messages. If no DataDictionary is supplied, only basic message validation will be done.</div><br/> 
      <div>This setting should only be used with FIX transport versions older than FIXT.1.1. See TransportDataDictionary and AppDataDictionary for FIXT.1.1 settings.</div>
    </td>
    <td>
      <div>Valid XML data dictionary file.  QuickFIX/N comes with the following defaults in the spec/fix directory</div><br/>
      <div>FIX44.xml</div>
      <div>FIX43.xml</div>
      <div>FIX42.xml</div>
      <div>FIX41.xml</div>
      <div>FIX40.xml</div>
    </td>
    <td/>
  </tr>

  <tr>
    <td>TransportDataDictionary</td>
    <td>
      <div>XML definition file for validating admin (transport) messages.  This setting is only valid for FIXT.1.1 (or newer) sessions.</div><br/>
      <div>See DataDictionary for older transport versions (FIX.4.0-FIX.4.4) for additional information.</div>
    </td>
    <td>
      <div>Valid XML data dictionary file. QuickFIX/N comes with the following defaults in the spec/fix directory</div><br/>
      <div>FIXT1.1.xml</div>
    </td>
    <td/>
  </tr>

  <tr>
    <td>AppDataDictionary</td>
    <td>
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
    <td>
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

###Initiator

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
    <td class='default'/>
  </tr>

  <tr>
    <td class='setting'>SocketConnectPort</td>
    <td class='description'>Socket port for connecting to a session.  Only used for initiators.</td>
    <td class='valid'>Positive integer</td>
    <td class='default'/>
  </tr>

  <tr>
    <td class='setting'>SocketConnectHost</td>
    <td class='description'>Host to connect to.  Only used for initiators.</td>
    <td class='valid'>Valid IP address in the format of x.x.x.x or a domain name</td>
    <td class='default'/>
  </tr>

  <tr>
    <td class='setting'>SocketConnectPort&lt;n&gt;</td>
    <td class='description'>Alternate socket ports for connecting to a session for failover, where <strong>n</strong> is a positive integer. ie, SocketConnectPort1, SocketConnectPort2... must be consecutive and have a matching SocketConnectHost&lt;n&gt;</td>
    <td class='valid'>Positive integer</td>
    <td class='default'/>
  </tr>

  <tr>
    <td class='setting'>SocketConnectHost&lt;n&gt;</td>
    <td class='description'>Alternate socket hosts for connecting to a session for failover, where <strong>n</strong> is a positive integer. ie, SocketConnectHost1, SocketConnectHost2... must be consecutive and have a matching SocketConnectPort&lt;n&gt;</td>
    <td class='valid'>Valid IP address in the format of x.x.x.x or a domain name</td>
    <td class='default'/>
  </tr>
</table>

<a name='acceptor'></a>

###Acceptor

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
    <td class='default'/>
  </tr>

  <tr>
    <td class='setting'>SocketAcceptHost</td>
    <td class='description'>Socket host for listening to incoming connections.  If not provided, the acceptor will listen on all network interfaces (0.0.0.0)</td>
    <td class='valid'>Valid IP address in the format of x.x.x.x</td>
    <td class='default'>0.0.0.0</td>
  </tr>
</table>

<a name='logging'></a>

###Logging

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
    <td class='default'/>
  </tr>
</table>

<a name='sample'></a>

###Sample Settings File

Here is a typical settings file you might find in a firm that wants to connect to several ECNs.

    # default settings for sessions
    [DEFAULT]
    ConnectionType=initiator
    ReconnectInterval=60
    SenderCompID=TW

    # session definition
    [SESSION]
    # inherit ConnectionType, ReconnectInterval and SenderCompID from default
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
    # (optional) alternate connection ports and hosts to cycle through on failover
    SocketConnectPort1=8392
    SocketConnectHost1=8.8.8.8
    SocketConnectPort2=2932
    SocketConnectHost2=12.12.12.12
    DataDictionary=somewhere/FIX42.xml
