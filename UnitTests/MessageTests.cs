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
    }
}
