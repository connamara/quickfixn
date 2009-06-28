using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using QuickFIX.NET;
using QuickFIX.NET.Fields;

namespace UnitTests
{
    [TestFixture]
    public class MessageTests
    {
        [Test]
        public void IdentifyMsgTypeTest()
        {
            string msg1 = "\u000135=A\u0001";
            Assert.That(Message.IdentifyType(msg1).Obj, Is.EqualTo(new MsgType("A").Obj));
            string msg2 = "a;sldkfjadls;k\u000135=A\u0001a;sldkfja;sdlfk";
            Assert.That(Message.IdentifyType(msg2).Obj, Is.EqualTo(new MsgType("A").Obj));
            string msg3 = "8=FIX4.2\u00019=12\u0001\u000135=B\u000110=031\u0001";
            Assert.That(Message.IdentifyType(msg3).Obj, Is.EqualTo(new MsgType("B").Obj));
        }

        [Test]
        public void CheckSum()
        {
            string str1 = "8=FIX.4.2\u00019=46\u000135=0\u000134=3\u000149=TW\u0001" +
                "52=20000426-12:05:06\u000156=ISLD\u0001";
            
            int chksum = 0;
            foreach( char c in str1 )
                chksum += (int)c;
            chksum %= 256;

            str1 += "10=000\u0001";  // checksum field

        }

        [Test]
        public void IsHeaderFieldTest()
        {
            Assert.That(Message.IsHeaderField(Tags.BeginString), Is.EqualTo(true));
            Assert.That(Message.IsHeaderField(Tags.TargetCompID), Is.EqualTo(true));
            Assert.That(Message.IsHeaderField(Tags.Account), Is.EqualTo(false));
        }

        [Test]
        public void IsTrailerFieldTest()
        {
            Assert.That(Message.IsTrailerField(Tags.CheckSum), Is.EqualTo(true));
            Assert.That(Message.IsTrailerField(Tags.Price), Is.EqualTo(false));
        }
    }
}
