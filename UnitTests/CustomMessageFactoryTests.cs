using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFix;
using QuickFix.FIX44;
using QuickFix.Fields;
using BeginString = QuickFix.FixValues.BeginString;
using Text = QuickFix.Fields.Text;
using Message = QuickFix.Message;
using MessageFactory = QuickFix.FIX44.MessageFactory;

namespace UnitTests
{
    [TestFixture]
    public class CustomMessageFactoryTests
    {        
        public static class YourTags
        {
            public const int AWESOME_FIELD = 9006;
            public const int NoAwesomeFieldGrp = 9007;
        }

        #region Message Fields
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
                : base(YourTags.AWESOME_FIELD) { }
            public AwesomeField(string val)
                : base(YourTags.AWESOME_FIELD, val) { }
        }
        #endregion

        #region Custom message
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
        #endregion

        public class CustomMessageFactory : MessageFactory, IMessageFactory
        {
            #region Implementation of IMessageFactory

            public new Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case CustomMessageFactoryTests.YourNewFIXMessageType.MsgType:
                        return new CustomMessageFactoryTests.YourNewFIXMessageType();
                }
                return base.Create(beginString, msgType);
            }

            public new Group Create(string beginString, string msgType, int groupCounterTag)
            {
                if (CustomMessageFactoryTests.YourNewFIXMessageType.MsgType.Equals(msgType))
                {
                    switch (groupCounterTag)
                    {
                        case CustomMessageFactoryTests.YourTags.NoAwesomeFieldGrp: return new CustomMessageFactoryTests.YourNewFIXMessageType.NoAwesomeFieldGrpGroup();
                    }
                }
                else
                    return base.Create(beginString, msgType, groupCounterTag);
                return null;
            }
            #endregion
        }

        public class CustomDefaultMessageFactory: DefaultMessageFactory
        {
            public CustomDefaultMessageFactory()
            {
                _factories[BeginString.FIX44] = new CustomMessageFactory();
            }
        }

        [Test]
        public void CustomGroupCreateTest()
        {
            CustomDefaultMessageFactory cdmf = new CustomDefaultMessageFactory();

            Group g44 = cdmf.Create("FIX.4.4", "YNFM", 9007);
            Assert.IsInstanceOf<YourNewFIXMessageType.NoAwesomeFieldGrpGroup>(g44);

            // FIX50 is not handled by our CustomMessageFactory
            Group g50 = cdmf.Create("FIXT.1.1", "B", 33);
            Assert.IsInstanceOf<QuickFix.FIX50.News.NoLinesOfTextGroup>(g50);
        }
    }
}
