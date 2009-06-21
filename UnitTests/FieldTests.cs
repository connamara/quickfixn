using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuickFIX.NET;

namespace UnitTests
{
    [TestFixture]
    public class FieldTests
    {
        [Test]
        public void IntFieldTest()
        {
            IntField field = new IntField(5, 500);
            Assert.That(field.getValue(), Is.EqualTo(500));
            Assert.That(field.Tag, Is.EqualTo(5));
        }
    }
}
