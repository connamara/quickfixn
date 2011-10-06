Custom FIX
==========

We often connect to parties who have modified or customized the FIX
protocol to fit their needs.  QuickFIX/N provides us some powerful ways
to deal with this problem, the easiest of which is through the *Data
Dictionary*.

Data Dictionary
---------------

A Data Dictionary documents the protocol for a QuickFIX/N Session.  When 
a field, group, or message is custom for a session versus the
FIX specification, we change this document.

We specify data dictionary for a session in the config file:

```
[Session]
SenderCompID=CONNAMARA
TargetCompID=CBOE
BeginString=FIX4.2
UseDataDictionary=Y
DataDictionary=./spec/FIX4.2.xml
```

The XML-based document is fairly straightforoward.

A Data Dictionary defines all FIX **Fields**:

```
<fields>
  <field number="1" name="Account" type="STRING"/>
  <field number="2" name="AdvId" type="STRING"/>
  <field number="3" name="AdvRefID" type="STRING"/>
...
```
A Data Dictionary defines all FIX **Messages**:

```
<messages>
  <message name="Heartbeat" msgtype="0" msgcat="admin">
    <field name="TestReqID" required="N"/>
  </message>
  <message name="Logon" msgtype="A" msgcat="admin">
    <field name="EncryptMethod" required="Y"/>
    <field name="HeartBtInt" required="Y"/>
...
```

And a Data Dictionary defines all FIX **Groups** within a Message:

```
<message name="Logon" msgtype="A" msgcat="admin">
  <field name="EncryptMethod" required="Y"/>
  <field name="HeartBtInt" required="Y"/>
  <field name="RawDataLength" required="N"/>
  <field name="RawData" required="N"/>
  <field name="ResetSeqNumFlag" required="N"/>
  <field name="MaxMessageSize" required="N"/>
  <group name="NoMsgTypes" required="N">
    <field name="RefMsgType" required="N"/>
    <field name="MsgDirection" required="N"/>
  </group>
</message>
```

Customizing Our Data Dictionary
-------------------------------

Adding a custom field to a message is two steps.  For this example, we
will add field 9006, `AwesomeField`, which is a `String`.

First, we add it to the Fields section of the Data Dictionary:

```
<fields>
  <field number="1" name="Account" type="STRING"/>
  <field number="2" name="AdvId" type="STRING"/>
  <field number="3" name="AdvRefID" type="STRING"/>
...
  <field number="9006" name="AwesomeField" type="STRING"/>
</fields>
```

Then, we add it to our messages:

```
<message name="ExecutionReport" msgtype="8" msgcat="app">
  <field name="OrderID" required="Y"/>
  <field name="SecondaryOrderID" required="N"/>
  <field name="ClOrdID" required="N"/>
  <field name="OrigClOrdID" required="N"/>
  <field name="TestReqID" required="N"/>
...
  <field name="AwesomeField" required="N"/>
</message>
```

Now, QuickFIX/N will know how to handle an incoming or outgoing
`ExecutionReport` with `AwesomeField` in it.

Custom **Groups** are especially important to get right in our Data
Dictionary, since the FIX protocol gives us no other way to know about a
Group other than its defined specification.  Using `AwesomeField` from
above, we add it to a Group:

```
<message name="ExecutionReport" msgtype="8" msgcat="app">
  <field name="OrderID" required="Y"/>
...
  <field name="ExecBroker" required="N"/>
  <group name="NoContraBrokers" required="N">
    <field name="ContraBroker" required="N"/>
    <field name="ContraTrader" required="N"/>
    <field name="ContraTradeQty" required="N"/>
    <field name="ContraTradeTime" required="N"/>
    <field name="AwesomeField" required="N"/>
  </group>
...
```

The group would not work correctly without specifying this in our Data
Dictionary.
