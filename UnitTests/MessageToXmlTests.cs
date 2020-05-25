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
            msg.FromString(str1, true, null, null, _defaultMsgFactory);

            string expected = @"<message>
<header>
<field number=""8""><![CDATA[FIX.4.2]]></field><field number=""9""><![CDATA[55]]></field><field number=""34""><![CDATA[3]]></field><field number=""35""><![CDATA[0]]></field><field number=""49""><![CDATA[TW]]></field><field number=""52""><![CDATA[20000426-12:05:06]]></field><field number=""56""><![CDATA[ISLD]]></field>
</header>
<body>
<field number=""1""><![CDATA[acct123]]></field>
</body>
<trailer>
<field number=""10""><![CDATA[123]]></field>
</trailer>
</message>
";

            Assert.AreEqual(expected, msg.ToXML());
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

            string expected = @"<message>
<header>
<field number=""8""><![CDATA[FIX.4.4]]></field><field number=""9""><![CDATA[638]]></field><field number=""34""><![CDATA[360]]></field><field number=""35""><![CDATA[8]]></field><field number=""49""><![CDATA[BLPTSOX]]></field><field number=""52""><![CDATA[20130321-15:21:23]]></field><field number=""56""><![CDATA[THINKTSOX]]></field><field number=""57""><![CDATA[6804469]]></field><field number=""128""><![CDATA[ZERO]]></field>
</header>
<body>
<field number=""6""><![CDATA[122.255]]></field><field number=""11""><![CDATA[61101189]]></field><field number=""14""><![CDATA[1990000]]></field><field number=""15""><![CDATA[GBP]]></field><field number=""17""><![CDATA[VCON:20130321:50018:5:12]]></field><field number=""22""><![CDATA[4]]></field><field number=""31""><![CDATA[122.255]]></field><field number=""32""><![CDATA[1990000]]></field><field number=""37""><![CDATA[116]]></field><field number=""38""><![CDATA[1990000]]></field><field number=""39""><![CDATA[2]]></field><field number=""48""><![CDATA[GB0032452392]]></field><field number=""54""><![CDATA[1]]></field><field number=""55""><![CDATA[[N/A]]]></field><field number=""60""><![CDATA[20130321-15:21:23]]></field><field number=""64""><![CDATA[20130322]]></field><field number=""75""><![CDATA[20130321]]></field><field number=""106""><![CDATA[UK TSY 4 1/4% 2036]]></field><field number=""118""><![CDATA[2436321.85]]></field><field number=""150""><![CDATA[F]]></field><field number=""151""><![CDATA[0]]></field><field number=""157""><![CDATA[15]]></field><field number=""159""><![CDATA[3447.35]]></field><field number=""192""><![CDATA[0]]></field><field number=""198""><![CDATA[3739:20130321:50018:5]]></field><field number=""223""><![CDATA[0.0425]]></field><field number=""228""><![CDATA[1]]></field><field number=""236""><![CDATA[0.0291371041]]></field><field number=""238""><![CDATA[0]]></field><field number=""381""><![CDATA[2432874.5]]></field><field number=""423""><![CDATA[1]]></field><field number=""453""><![CDATA[6]]></field><field number=""470""><![CDATA[GB]]></field><field number=""541""><![CDATA[20360307]]></field><group><field number=""447""><![CDATA[D]]></field><field number=""448""><![CDATA[VCON]]></field><field number=""452""><![CDATA[1]]></field><field number=""802""><![CDATA[1]]></field><group><field number=""523""><![CDATA[14]]></field><field number=""803""><![CDATA[4]]></field></group></group><group><field number=""447""><![CDATA[D]]></field><field number=""448""><![CDATA[TFOLIO:6804469]]></field><field number=""452""><![CDATA[12]]></field></group><group><field number=""447""><![CDATA[D]]></field><field number=""448""><![CDATA[TFOLIO]]></field><field number=""452""><![CDATA[11]]></field></group><group><field number=""447""><![CDATA[D]]></field><field number=""448""><![CDATA[THINKFOLIO LTD]]></field><field number=""452""><![CDATA[13]]></field></group><group><field number=""447""><![CDATA[D]]></field><field number=""448""><![CDATA[SXT]]></field><field number=""452""><![CDATA[16]]></field></group><group><field number=""447""><![CDATA[D]]></field><field number=""448""><![CDATA[TFOLIO:6804469]]></field><field number=""452""><![CDATA[36]]></field></group>
</body>
<trailer>
<field number=""10""><![CDATA[152]]></field>
</trailer>
</message>
";

            Assert.AreEqual(expected, msg.ToXML());
        }
    }
}
