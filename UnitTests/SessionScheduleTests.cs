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

        [Test]
        public void testDailyIsSessionTimeAllDay()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011,10,17,9,43,0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011,10,18,9,43,0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 23, 59, 59)));
        }

        [Test]
        public void testDailyIsSessionTime()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:12:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "06:00:23");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 12, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 5, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 23)));

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 11, 0)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 24)));
        }

        [Test]
        public void testDailyIsSessionTimeWrapAround()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "06:00:23");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:12:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 0, 23)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 8, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 12, 00)));

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 12, 1)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 22)));

        }
    }
}
