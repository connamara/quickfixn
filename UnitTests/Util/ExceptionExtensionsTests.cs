using System;
using NUnit.Framework;
using QuickFix.Util;

namespace UnitTests.Util
{
    public sealed class ExceptionExtensionsTests
    {
        [Test]
        public void WhenInnerExceptionShouldReturnJoinedInnerExceptionMessages()
        {
            var exception = new Exception(
                "Outer exception, see inner exception",
                new Exception("My inner exception message"));

            Assert.AreEqual(
                exception.GetFullMessage(),
                "Outer exception, see inner exception --> My inner exception message");
        }

        [Test]
        public void WhenNoInnerExceptionShouldReturnExceptionMessageUnmodified()
        {
            var exception = new Exception("My exception message");

            Assert.AreEqual(exception.GetFullMessage(), "My exception message");
        }
    }
}
