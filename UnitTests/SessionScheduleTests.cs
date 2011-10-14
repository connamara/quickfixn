using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class SessionScheduleTests
    {
        [Test]
        public void testRequiredArgs()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });

            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });

            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:0blkajsdf");
            Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });

            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
            Assert.DoesNotThrow(delegate { new QuickFix.SessionSchedule(settings); });
        }

        [Test]
        public void testOptArgs()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            settings.SetDay(QuickFix.SessionSettings.START_DAY, 5);
            Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });

            settings.SetDay(QuickFix.SessionSettings.END_DAY, 6);
            Assert.DoesNotThrow(delegate { new QuickFix.SessionSchedule(settings); });
        }
    }
}
