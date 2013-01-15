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

            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Thursday);
            Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });

            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            Assert.DoesNotThrow(delegate { new QuickFix.SessionSchedule(settings); });
        }

        [Test]
        public void testDailyIsSessionTimeAllDay()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 23, 59, 59, DateTimeKind.Utc)));
        }

        [Test]
        public void testWeeklySessionSameDayAllWeek()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);
	    
            //a sunday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0, DateTimeKind.Utc)));

            //a monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 0, DateTimeKind.Utc)));

            //a tuesday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void testWeeklySessionSameDayMostWeek()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "05:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);
	    
            //a sunday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0, DateTimeKind.Utc)));

            //a monday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 1, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 4, 0, 1, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 23, 59, 59, DateTimeKind.Utc)));

            //a tuesday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0, DateTimeKind.Utc)));
        }

        //admittedly contrived, but full coverage
        [Test]
        public void testWeeklySessionSameDayOneDay()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "05:00:00");

            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);
	    
            //a sunday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0, DateTimeKind.Utc)));

            //a monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 1, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 4, 0, 1, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 59, 59, DateTimeKind.Utc)));

            //a tuesday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0, DateTimeKind.Utc)));
        }


        [Test]
        public void testWeeklySessionMultiDay()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            //only on monday-thur (note end time)
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            //a monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0, DateTimeKind.Utc)));

            // a thursday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 20, 23, 59, 59, DateTimeKind.Utc)));

            //a fri, sat, sun
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 0, 0, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void testWeeklySessionMultiDayOverlap()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            //only on wed-sunday night
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Wednesday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            //wed-monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 20, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 22, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0, DateTimeKind.Utc)));

            //monday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0, DateTimeKind.Utc)));

            //tuesday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void testWeeklySessionMultiDayHours()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "07:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "15:00:00");

            //only on monday-fri
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            //Monday Scenarios
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 59, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 7, 30, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 15, 30, 0, DateTimeKind.Utc)));

            //Midweek Scenarios
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 6, 59, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 7, 30, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 15, 30, 0, DateTimeKind.Utc)));

            //Friday Scenarios
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 6, 59, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 7, 30, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 15, 30, 0, DateTimeKind.Utc)));

            //Weekend
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 6, 59, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 7, 30, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 15, 30, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void testWeeklySessionMultiDayHoursOverlap()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "15:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "07:00:00");

            //only on monday-fri
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            //weekdays
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 15, 30, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 30, 0, DateTimeKind.Utc)), "foo");

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 5, 30, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 15, 30, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 6, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 7, 00, 1, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 15, 30, 0, DateTimeKind.Utc)));
        }
        

        [Test]
        public void testDailyIsSessionTime()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:12:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "06:00:23");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 12, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 5, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 23, DateTimeKind.Utc)));

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 11, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 24, DateTimeKind.Utc)));
        }

        [Test]
        public void testDailyIsSessionTimeWrapAround()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "06:00:23");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:12:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 0, 23, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 8, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 12, 00, DateTimeKind.Utc)));

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 12, 1, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 22, DateTimeKind.Utc)));

        }

        [Test]
        public void testInvalidTimeZone()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "06:00:23");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:12:00");
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Doh");

            Assert.Throws(typeof (TimeZoneNotFoundException), delegate { new QuickFix.SessionSchedule(settings); });
        }

        [Test]
        public void testLocalTimeTimeZoneConflict()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "06:00:23");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:12:00");
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Doh");
            settings.SetString(QuickFix.SessionSettings.USE_LOCAL_TIME, "Y");
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time");

            Assert.Throws(typeof (QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });
        }

        [Test]
        public void testTimeZone()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 13, 29, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 13, 30, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 20, 0, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 20, 0, 1, DateTimeKind.Utc)));
        }

        [Test]
        public void testLastEndTime_takesUtcOnly()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.Throws<ArgumentException>(
                delegate { sched.LastEndTime(new DateTime(2012, 10, 18, 12, 00, 00, DateTimeKind.Local)); });
            Assert.Throws<ArgumentException>(
                delegate { sched.LastEndTime(new DateTime(2012, 10, 18, 12, 00, 00, DateTimeKind.Unspecified)); });
        }

        [Test]
        public void testLastEndTime_DailySessions()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            DateTime thisDayEnd = new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc);
            DateTime prevDayEnd = new DateTime(2012, 10, 17, 16, 00, 00, DateTimeKind.Utc);

            // before starttime
            Assert.AreEqual(prevDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, 08, 00, 00, DateTimeKind.Utc)));
            // during session
            Assert.AreEqual(prevDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, 08, 00, 00, DateTimeKind.Utc)));
            // equals endtime
            Assert.AreEqual(thisDayEnd, sched.LastEndTime(thisDayEnd));
            // after endtime
            Assert.AreEqual(thisDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, 17, 00, 00, DateTimeKind.Utc)));

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time"); //-5
            sched = new QuickFix.SessionSchedule(settings);

            // before starttime
            Assert.AreEqual(prevDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, 08, 00, 00, DateTimeKind.Utc)));
            // during session
            Assert.AreEqual(prevDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, 10, 00, 00, DateTimeKind.Utc)));
            // equals endtime
            Assert.AreEqual(thisDayEnd, sched.LastEndTime(thisDayEnd));
            // after endtime
            Assert.AreEqual(thisDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, 17, 00, 00, DateTimeKind.Utc)));
        }

        [Test]
        public void testLastEndTime_WeeklySessions()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            DateTime thisWeekEnd = new DateTime(2012, 10, 19, 16, 00, 00, DateTimeKind.Utc);
            DateTime prevWeekEnd = new DateTime(2012, 10, 12, 16, 00, 00, DateTimeKind.Utc);

            // before starttime
            Assert.AreEqual(prevWeekEnd, sched.LastEndTime(new DateTime(2012, 10, 15, 08, 00, 00, DateTimeKind.Utc)));
            // during session
            Assert.AreEqual(prevWeekEnd, sched.LastEndTime(new DateTime(2012, 10, 17, 08, 00, 00, DateTimeKind.Utc)));
            // equals endtime
            Assert.AreEqual(thisWeekEnd, sched.LastEndTime(thisWeekEnd));
            // after endtime
            Assert.AreEqual(thisWeekEnd, sched.LastEndTime(new DateTime(2012, 10, 19, 17, 00, 00, DateTimeKind.Utc)));

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time"); //-5
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            sched = new QuickFix.SessionSchedule(settings);

            // before starttime
            Assert.AreEqual(prevWeekEnd, sched.LastEndTime(new DateTime(2012, 10, 15, 08, 00, 00, DateTimeKind.Utc)));
            // during session
            Assert.AreEqual(prevWeekEnd, sched.LastEndTime(new DateTime(2012, 10, 17, 08, 00, 00, DateTimeKind.Utc)));
            // equals endtime
            Assert.AreEqual(thisWeekEnd, sched.LastEndTime(thisWeekEnd));
            // after endtime
            Assert.AreEqual(thisWeekEnd, sched.LastEndTime(new DateTime(2012, 10, 19, 17, 00, 00, DateTimeKind.Utc)));
        }

        [Test]
        public void testIsSameSession_takesUtcOnly()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            DateTime local = new DateTime(2001, 1, 1, 1, 1, 1, DateTimeKind.Local);
            DateTime utc = new DateTime(2001, 1, 1, 1, 1, 1, DateTimeKind.Utc);
            DateTime none = new DateTime(2001, 1, 1, 1, 1, 1, DateTimeKind.Unspecified);

            Assert.Throws<ArgumentException>(delegate { sched.IsSameSession(local, utc); });
            Assert.Throws<ArgumentException>(delegate { sched.IsSameSession(utc, local); });
            Assert.Throws<ArgumentException>(delegate { sched.IsSameSession(none, utc); });
            Assert.Throws<ArgumentException>(delegate { sched.IsSameSession(utc, none); });
        }

        [Test]
        public void testIsSameSession_Daily()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.True(sched.IsSameSession(
                new DateTime(2012, 10, 18, 09, 30, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc)));
            Assert.True(sched.IsSameSession(
                new DateTime(2012, 10, 18, 09, 31, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 15, 59, 00, DateTimeKind.Utc)));
            Assert.False(sched.IsSameSession(
                new DateTime(2012, 10, 18, 10, 00, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 19, 10, 00, 00, DateTimeKind.Utc)));

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time"); //-5
            sched = new QuickFix.SessionSchedule(settings);

            Assert.True(sched.IsSameSession(
                new DateTime(2012, 10, 18, 09, 30, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc)));
            Assert.True(sched.IsSameSession(
                new DateTime(2012, 10, 18, 09, 31, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 15, 59, 00, DateTimeKind.Utc)));
            Assert.False(sched.IsSameSession(
                new DateTime(2012, 10, 18, 10, 00, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 19, 10, 00, 00, DateTimeKind.Utc)));
        }

        [Test]
        public void testIsSameSession_Weekly()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            // Oct 15 and 22 are Mondays, 19 and 26 are Fridays
            Assert.True(sched.IsSameSession(
                new DateTime(2012, 10, 15, 09, 30, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 19, 16, 00, 00, DateTimeKind.Utc)));
            Assert.True(sched.IsSameSession(
                new DateTime(2012, 10, 16, 09, 31, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 15, 59, 00, DateTimeKind.Utc)));
            Assert.False(sched.IsSameSession(
                new DateTime(2012, 10, 16, 12, 00, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 23, 10, 00, 00, DateTimeKind.Utc)));

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time"); //-5
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            sched = new QuickFix.SessionSchedule(settings);

            Assert.True(sched.IsSameSession(
                new DateTime(2012, 10, 15, 09, 30, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 19, 16, 00, 00, DateTimeKind.Utc)));
            Assert.True(sched.IsSameSession(
                new DateTime(2012, 10, 16, 09, 31, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 15, 59, 00, DateTimeKind.Utc)));
            Assert.False(sched.IsSameSession(
                new DateTime(2012, 10, 16, 12, 00, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 23, 10, 00, 00, DateTimeKind.Utc)));
        }

        [Test]
        public void testGetSessionRange_Daily()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.AreEqual("SessionRange[20121101-09:30:00 to 20121101-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 11, 01, 09, 30, 00, DateTimeKind.Utc)).ToString());
            Assert.AreEqual("SessionRange[20121101-09:30:00 to 20121101-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 11, 01, 04, 00, 00, DateTimeKind.Utc)).ToString());
            Assert.AreEqual("SessionRange[20010501-09:30:00 to 20010501-16:00:00]",
                sched.GetSessionRange(new DateTime(2001, 05, 01, 14, 00, 00, DateTimeKind.Utc)).ToString());
            // 8am is not within a session
            Assert.AreEqual("SessionRange[invalid]",
                sched.GetSessionRange(new DateTime(2001, 05, 01, 08, 00, 00, DateTimeKind.Utc)).ToString());

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time"); //-5
            sched = new QuickFix.SessionSchedule(settings);

            Assert.AreEqual("SessionRange[20121101-09:30:00 to 20121101-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 11, 01, 09, 30, 00, DateTimeKind.Utc)).ToString());
            Assert.AreEqual("SessionRange[20121101-09:30:00 to 20121101-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 11, 01, 04, 00, 00, DateTimeKind.Utc)).ToString());
            Assert.AreEqual("SessionRange[20010501-09:30:00 to 20010501-16:00:00]",
                sched.GetSessionRange(new DateTime(2001, 05, 01, 14, 00, 00, DateTimeKind.Utc)).ToString());
            // 8am is not within a session
            Assert.AreEqual("SessionRange[invalid]",
                sched.GetSessionRange(new DateTime(2001, 05, 01, 08, 00, 00, DateTimeKind.Utc)).ToString());

            // ================
            // Check that still works when session spans a day break
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "16:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "09:30:00");
            sched = new QuickFix.SessionSchedule(settings);

            Assert.AreEqual("SessionRange[20121101-16:30:00 to 20121102-09:30:00]",
                sched.GetSessionRange(new DateTime(2012, 11, 01, 17, 30, 00, DateTimeKind.Utc)).ToString());
        }

        [Test]
        public void testGetSessionRange_Weekly()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            // Oct 15 and 22 are Mondays, 19 and 26 are Fridays
            Assert.AreEqual("SessionRange[20121015-09:30:00 to 20121019-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 10, 15, 09, 30, 00, DateTimeKind.Utc)).ToString());
            Assert.AreEqual("SessionRange[20121015-09:30:00 to 20121015-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 10, 19, 04, 00, 00, DateTimeKind.Utc)).ToString());
            // Jan 1 2001 is a Monday
            Assert.AreEqual("SessionRange[20010101-09:30:00 to 20010105-16:00:00]",
                sched.GetSessionRange(new DateTime(2001, 01, 03, 14, 00, 00, DateTimeKind.Utc)).ToString());
            // this one's a little before the session
            Assert.AreEqual("SessionRange[invalid]",
                sched.GetSessionRange(new DateTime(2012, 10, 15, 08, 00, 00, DateTimeKind.Utc)).ToString());

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time"); //-5
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            sched = new QuickFix.SessionSchedule(settings);

            // Oct 15 and 22 are Mondays, 19 and 26 are Fridays
            Assert.AreEqual("SessionRange[20121015-09:30:00 to 20121019-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 10, 15, 09, 30, 00, DateTimeKind.Utc)).ToString());
            Assert.AreEqual("SessionRange[20121015-09:30:00 to 20121015-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 10, 19, 04, 00, 00, DateTimeKind.Utc)).ToString());
            // Jan 1 2001 is a Monday
            Assert.AreEqual("SessionRange[20010101-09:30:00 to 20010105-16:00:00]",
                sched.GetSessionRange(new DateTime(2001, 01, 03, 14, 00, 00, DateTimeKind.Utc)).ToString());
            // this one's a little before the session
            Assert.AreEqual("SessionRange[invalid]",
                sched.GetSessionRange(new DateTime(2012, 10, 15, 08, 00, 00, DateTimeKind.Utc)).ToString());

            // ===========
            // Check that still works when session spans a weekend break
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "16:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "09:30:00");
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Friday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            sched = new QuickFix.SessionSchedule(settings);

            // Oct 15 and 22 are Mondays, 19 and 26 are Fridays
            Assert.AreEqual("SessionRange[20121019-09:30:00 to 20121022-16:00:00]",
                sched.GetSessionRange(new DateTime(2012, 10, 20, 12, 00, 00, DateTimeKind.Utc)).ToString());
        }

        [Test]
        public void testAdjustDateTime()
        {
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            // 1) reject if param is not utc
            Assert.Throws<ArgumentException>(
                delegate { sched.AdjustUtcDateTime(new DateTime(2012, 10, 18, 12, 00, 00, DateTimeKind.Local)); });
            Assert.Throws<ArgumentException>(
                delegate { sched.AdjustUtcDateTime(new DateTime(2012, 10, 18, 12, 00, 00, DateTimeKind.Unspecified)); });

            // 2) if settings is UTC, don't convert
            DateTime d2 = new DateTime(2013, 01, 15, 12, 00, 00, DateTimeKind.Utc);
            Assert.AreEqual(d2, sched.AdjustUtcDateTime(d2));

            // 3) if settings has a TimeZone, convert to TimeZone
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time"); //-5
            sched = new QuickFix.SessionSchedule(settings);

            DateTime d3 = new DateTime(2013, 01, 15, 03, 00, 00, DateTimeKind.Utc);
            DateTime d3expected = new DateTime(2013, 01, 14, 22, 00, 00, DateTimeKind.Unspecified);
            DateTime d3actual = sched.AdjustUtcDateTime(d3);
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d3expected, d3actual);

            // 4) TimeZone with daylight savings
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Eastern Standard Time"); //-4 in June
            sched = new QuickFix.SessionSchedule(settings);

            DateTime d4 = new DateTime(2013, 06, 15, 03, 00, 00, DateTimeKind.Utc);
            DateTime d4expected = new DateTime(2013, 06, 14, 23, 00, 00, DateTimeKind.Unspecified);
            DateTime d4actual = sched.AdjustUtcDateTime(d4);
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d4expected, d4actual);

            // 5) if settings has UseLocalTime, convert to local time
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.USE_LOCAL_TIME, "Y");
            sched = new QuickFix.SessionSchedule(settings);

            DateTime d5 = new DateTime(2013, 01, 15, 16, 00, 00, DateTimeKind.Utc);
            DateTime d5expected = d5.ToLocalTime();
            DateTime d5actual = sched.AdjustUtcDateTime(d5);
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d5expected, d5actual);
            Assert.AreEqual(DateTimeKind.Local, d5actual.Kind);
        }
    }
}
