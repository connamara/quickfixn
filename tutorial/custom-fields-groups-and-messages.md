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

Adding custom fields to existing messages
=========================================

Many counterparties' customizations are limited to only adding custom fields to existing FIX messages.

**Create the field:**

If your counterparty is adding a already-existing field to a message that doesn't
normally use it, then your field should already be defined, and you can skip this step.

If the counterparty has created this field, then you must define it.
Here, we'll add a new string field called `AwesomeField` as tag 9006.

**Note: your new field must have a name and tag unique from all other fields in your Data Dictionary.

To do this, we would go to the `fields` section of the Data Dictionary,
and add a new `field` entry for the new `AwesomeField` field.

```
<fields>
  <field number="1" name="Account" type="STRING"/>
  <field number="2" name="AdvId" type="STRING"/>
  <field number="3" name="AdvRefID" type="STRING"/>
...
  <field number="9006" name="AwesomeField" type="STRING"/>
</fields>
```

That's it!  Your field can now be used in other messages.

**Add the field to a message:**

If the field is *not* being added in a repeating group,
then your altered message will look like this:

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

If the field *is* being added to a repeating group,
then you must add it inside the appropriate `group` tag.
In the following excerpt, we add it to the `NoContraBrokers` group.

* **Note 1:** If your group is not specified correctly, your message will be rejected
or interpreted incorrectly.
* **Note 2:** For FIX 4.0-4.4, the order of fields inside a repeating group is important.
Make sure the position of your field matches that of the actual message to be received,
or your message will be rejected.

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

Adding new messages types
=========================

Some counterparies add entirely new message types to FIX.

To add a new message type to the Data Dictionary, there are two steps:

1. Add a new message definition to the `messages` section.
2. Add a new corresponding entry to the `MsgType` field within the `fields` section

For example, here is how you'd add a new message type called `CoolMessage`
that contains 3 fields (1 of which is required, the others mandatory):

    * **Note:** The msgtype and name (both are strings) must be unique from all other messages.

```
<messages>
  ...
  <message name="CoolMessage" msgcat="app" msgtype="xCM">
    <field name="Currency" required="N"/>
    <field name="Text" required="N"/>
    <field name="Account" required="Y"/>
  </message>
  ...
</messages>
...
<fields>
  ...
  <field number='35' name='MsgType' type='STRING'>
    ...
    <value enum='xCM' description='COOLMESSAGE'/>
  </field>
  ...
</fields>
```

Adding new groups
=================

Groups are a little more nuanced than other parts of the Data Dictionary.

A group is defined within a message, with the `group` tag.  The first child
element of the `group` tag is the group-counter tag, followed by the
other fields in the group in the order in which they should appear in
the message.

Don't forget to define the group counter field in the `fields` section!
By convention, the field usually starts with "No", e.g. if the group is called
"NeatGroup", the counter field would be called "NoNeatGroups" (though this is
not mandatory).

* **Note 1:** If your group is not specified correctly, your message will be rejected
or interpreted incorrectly.
* **Note 2:** For FIX 4.0-4.4, the order of fields inside a repeating group is important.
Make sure the position of your field matches that of the actual message to be received,
or your message will be rejected.

Here is how you would add a new group 'BrandNewGroup' to the message 'CoolMessage' that
created in the previous section:

```
<messages>
  ...
  <message name="CoolMessage" msgcat="app" msgtype="CM">
    <field name="Currency" required="N"/>
    <field name="Text" required="N"/>
    <field name="Account" required="Y"/>
    <group name="NoBrandNewGroups" required="N">
      <field name="ExecID" required="Y"/>
      <field name="OrderID" required="N"/>
      <!-- ... maybe other fields ... -->
    </group>
  </message>
  ...
</messages>
...
<fields>
  ...
  <field number='9876' name='NoBrandNewGroups' type='NUMINGROUP'/>
</fields>
```

In Code
-------

The easiest way to get a custom field from a message or group is to call
the typed getter:

```c#
const int AWESOME_FIELD = 9006;
string awsmFld = message.GetString(AWESOME_FIELD);
```

```c#
const int AWESOME_FIELD = 9006;
string awsmFld = contraBrokersGrp.GetString(AWESOME_FIELD);
```

For setting a custom field, we use one of the generic Field type classes:

```c#
const int AWESOME_FIELD = 9006;
message.SetField(new StringField(AWESOME_FIELD, "ohai"));
```

```c#
const int AWESOME_FIELD = 9006;
contraBrokersGrp.SetField(new StringField(AWESOME_FIELD, "ohai"));
```
