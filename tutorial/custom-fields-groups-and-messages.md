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

Custom **Groups** are especially important to get right in our Data
Dictionary. Using `AwesomeField` from above, we add it to the Fields
section of the document, then to a Group:

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

**The custom group would not work correctly without specifying this in our Data
Dictionary.**


Custom **Messages** are used when parties have their own custom messages. We will 
create new message with `AwesomeField` from above:

```
<message name="YourNewFIXMessageType" msgcat="app" msgtype="YNFM">
  <field name="Text" required="N"/>
  <group name="NoAwesomeFieldGrp" required="N">
	<field name="AwesomeField" required="N"/>
  </group>
</message>
...
<field number="35" name="MsgType" type="STRING">
...
	<value enum="YNFM" description="YOURNEWFIXMESSAGETYPE" />
</field>
<field name="NoAwesomeFieldGrp" number="9007" type="NUMINGROUP" />
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

The hard but type safe way is to use **Custom MessageFactory**. In that way you can 
receive and send type safe custom messages.  

1. Create your new FIX Message
-------
```c#
public static class YourTags
{
	public const int AWESOME_FIELD = 9006;
	public const int NoAwesomeFieldGrp = 9007;
}

public class NoAwesomeFieldGrp : IntField
{
	public NoAwesomeFieldGrp(int value)
		: base(YourTags.NoAwesomeFieldGrp, value)
	{
	}

	public NoAwesomeFieldGrp()
		: base(YourTags.NoAwesomeFieldGrp)
	{
	}
}

public class AwesomeField : StringField
{
	public AwesomeField()
		:base(YourTags.AWESOME_FIELD) {}
	public AwesomeField(string val)
		:base(YourTags.AWESOME_FIELD, val) {}
}

public class YourNewFIXMessageType : Message
{
		public const string MsgType = "YNFM";
		public YourNewFIXMessageType()
			: base()
		{
			this.Header.SetField(new MsgType("YNFM"));
		}

		#region Text
		public Text Text
		{
			get
			{
				Text val = new Text();
				GetField(val);
				return val;
			}
			set { SetField(value); }
		}

		public void Set(Text value)
		{
			this.Text = value;
		}
		public Text Get(Text value)
		{
			GetField(value);
			return value;
		}
		public bool IsSet(Text field)
		{
			return IsSetField(field);
		}
		public bool IsSetText()
		{
			return IsSetField(Tags.Text);
		}
		#endregion    

		#region NoAwesomeFieldGrp
		public NoAwesomeFieldGrp NoAwesomeFieldGrp
		{
			get
			{
				NoAwesomeFieldGrp val = new NoAwesomeFieldGrp();
				GetField(val);
				return val;
			}
			set { SetField(value); }
		}

		public void Set(NoAwesomeFieldGrp value)
		{
			this.NoAwesomeFieldGrp = value;
		}
		public NoAwesomeFieldGrp Get(NoAwesomeFieldGrp value)
		{
			GetField(value);
			return value;
		}
		public bool IsSet(NoAwesomeFieldGrp field)
		{
			return IsSetNoAwesomeFieldGrp();
		}
		public bool IsSetNoAwesomeFieldGrp()
		{
			return IsSetField(YourTags.NoAwesomeFieldGrp);
		}
		#endregion      

		#region NoAwesomeFieldGrpGroup
		public class NoAwesomeFieldGrpGroup : Group
		{
			public static int[] fieldOrder = {
												 YourTags.AWESOME_FIELD, 0
											 };
			public NoAwesomeFieldGrpGroup() : base(YourTags.NoAwesomeFieldGrp, YourTags.AWESOME_FIELD, fieldOrder) { }

			#region AwesomeField
			public AwesomeField AwesomeField
			{
				get
				{
					AwesomeField val = new AwesomeField();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(AwesomeField value)
			{
				this.AwesomeField = value;
			}
			public AwesomeField Get(AwesomeField value)
			{
				GetField(value);
				return value;
			}
			public bool IsSet(AwesomeField field)
			{
				return IsSetField(field);
			}
			public bool IsSetAwesomeField()
			{
				return IsSetField(YourTags.AWESOME_FIELD);
			}
			#endregion        
		}
		#endregion
	}
}
```
**Your new message must also exists in XML FIX Dictionary (see above)**

2. Create class: YourMessageFactory
```c#
using MessageFactory = QuickFix.FIX44.MessageFactory;
public class YourMessageFactory : MessageFactory, IMessageFactory
{
	#region Implementation of IMessageFactory

	public new Message Create(string beginString, string msgType)
	{
		switch (msgType)
		{
			case YourNewFIXMessageType.MsgType:
				return new YourNewFIXMessageType ();
		}
		return base.Create(beginString, msgType);
	}

	public new Group Create(string beginString, string msgType, int groupCounterTag)
	{
		if (YourNewFIXMessageType.MsgType.Equals(msgType))
		{
			switch (groupCounterTag)
			{
				case YourTags.NoAwesomeFieldGrp: return new YourNewFIXMessageType.NoAwesomeFieldGrpGroup();
			}
		}
		return base.Create(beginString, msgType, groupCounterTag);      
	}
	#endregion
}
```

3. Create class: YourDefaultMessageFactory
```c#
public class YourDefaultMessageFactory : DefaultMessageFactory
{
	public YourDefaultMessageFactory()
	{
		// If you use custom message in FIX 4.2 dictionary then assign YourMessageFactory over default 4.2 MessageFactory
		_factories[BeginString.FIX42] = new YourMessageFactory();
	}
}
```

4. Now use YourDefaultMessageFactory in Application
```c#
public class YourApplication : MessageCracker, Application
...
	SessionSettings settings = new SessionSettings(args[0]);
	Application myApp = new MyQuickFixApp();
	MessageStoreFactory storeFactory = new FileStoreFactory(settings);
	LogFactory logFactory = new FileLogFactory(settings);
	YourDefaultMessageFactory messageFactory = new YourDefaultMessageFactory();
	ThreadedSocketAcceptor acceptor = new ThreadedSocketAcceptor(
		myApp,
		storeFactory,
		settings,
		logFactory,
		messageFactory);
...
#region MessageCracker

 public new void Crack(Message message, SessionID sessionID)
 {
	 switch (message.Header.GetField(Tags.MsgType))
	 {
		 case YourNewFIXMessageType.MsgType:
			 OnMessage((YourNewFIXMessageType)message, sessionID);
			 break;
		 default:
			 base.Crack(message, sessionID);
			 break;
	 }
 }

 public void OnMessage(YourNewFIXMessageType message, SessionID sessionID)
 {
	 // Do your magic
 }
 #endregion
```
