using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuickFIX.NET;
using QuickFIX.NET.Fields;

namespace UnitTests
{
    [TestFixture]
    public class FIXDTTests
    {
        [Test]
        public void FDTTest()
        {
            DateTime dt = new DateTime(2009, 12, 25, 12, 11, 10);
            FIXDateTime fdt = new FIXDateTime(dt);
            Assert.That(fdt.DateTimeObj, Is.EqualTo(dt));
            Assert.That("20091225-12:11:10", Is.EqualTo(fdt.ToString()) );
        }
    }
}