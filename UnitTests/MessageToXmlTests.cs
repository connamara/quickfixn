using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using UnitTests.TestHelpers;

namespace UnitTests
{
    [TestFixture]
    public class MessageToXmlTests
    {
        private readonly IMessageFactory _defaultMsgFactory = new DefaultMessageFactory();

        [Test]
        public void ToXMLTest()
        {
            string str1 = "8=FIX.4.2\x01" + "9=55\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" +
                "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "10=123\x01";
            Message msg = new Message();
            try
            {
                msg.FromString(str1, true, null, null, _defaultMsgFactory);
            }
            catch (InvalidMessage e)
            {
                Assert.Fail("Unexpected exception (InvalidMessage): " + e.Message);
            }

            string xmlDoc = msg.ToXML();
            XDocument doc = null;
            try
            {
                doc = XDocument.Parse(xmlDoc);
            }
            catch (Exception e)
            {
                Assert.Fail("Badly formed XML generated: " + e.Message);
            }

            var fields = doc.Descendants("message").Descendants("body")
                .Select(field =>
                    new
                    {
                        number = field.Descendants("field").Attributes("number").Single().Value,
                        value = field.Descendants("field").Single().Value
                    })
                    .ToList();

            foreach (var elem in fields)
            {
                int number = 0;
                if (int.TryParse(elem.number.ToString(), out number) == false)
                {
                    Assert.Fail("should be number " + elem.number.ToString() + " " + elem.value.ToString());
                }
                else
                {
                    string value = msg.GetString(number);
                    Assert.That(value, Is.EqualTo(elem.value));
                }
            }
        }


        [Test]
        public void ToXMLWithGroupsTest()
        {
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(Path.Combine(TestContext.CurrentContext.TestDirectory, "spec", "fix", "FIX44.xml"));

            string[] msgFields = {
                // header
                "8=FIX.4.4","9=638", "35=8", "34=360", "49=BLPTSOX", "52=20130321-15:21:23", "56=THINKTSOX", "57=6804469", "128=ZERO",
                // non-group body fields
                "6=122.255", "11=61101189", "14=1990000", "15=GBP", "17=VCON:20130321:50018:5:12", "22=4", "31=122.255", "32=1990000",
                "37=116", "38=1990000", "39=2", "48=GB0032452392", "54=1", "55=[N/A]", "60=20130321-15:21:23", "64=20130322", "75=20130321",
                "106=UK TSY 4 1/4% 2036", "118=2436321.85", "150=F", "151=0", "157=15", "159=3447.35", "192=0", "198=3739:20130321:50018:5",
                "223=0.0425", "228=1", "236=0.0291371041", "238=0", "381=2432874.5", "423=1", "470=GB", "541=20360307",
                // NoPartyIDs
                "453=6",
                "448=VCON", "447=D", "452=1", "802=1", "523=14", "803=4",
                "448=TFOLIO:6804469", "447=D", "452=12",
                "448=TFOLIO", "447=D", "452=11",
                "448=THINKFOLIO LTD", "447=D", "452=13",
                "448=SXT", "447=D", "452=16",
                "448=TFOLIO:6804469", "447=D", "452=36",
                "10=152"
            };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            QuickFix.FIX44.ExecutionReport msg = new QuickFix.FIX44.ExecutionReport();
            msg.FromString(msgStr, true, dd, dd, null); // <-- null factory!


            string xmlDoc = msg.ToXML();

            System.Diagnostics.Debug.Print(xmlDoc.ToString());

            XDocument doc = null;
            try
            {
                doc = XDocument.Parse(xmlDoc);
            }
            catch (Exception e)
            {
                Assert.Fail("Badly formed XML generated: " + e.Message);
            }


            var groups = doc.Descendants("message").Descendants("body").Elements("group")
                .Select(group =>
                    new
                    {
                        numbers = group.Descendants("field").Attributes("number"),
                        values = group.Descendants("field")
                    })

                    .ToList();
            int ct = 0;
            foreach (var elem in groups)
            {
                int number = 0;
                Group group = msg.GetGroup(++ct, 453);

                var valueEnum = elem.values.GetEnumerator();
                foreach (var numberEnum in elem.numbers)
                {
                    valueEnum.MoveNext();
                    string value = valueEnum.Current.Value;

                    if (int.TryParse(numberEnum.Value.ToString(), out number) == false)
                    {
                        Assert.Fail("should be number " + numberEnum.Value.ToString());
                    }
                    else
                    {
                        if (group.IsSetField(number))
                        {
                            string msgValue = group.GetString(number);
                            Assert.That(value, Is.EqualTo(msgValue));
                        }
                    }
                }
            }
        }
    }
}
