﻿using System;
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

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011,10,17,9,43,0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011,10,18,9,43,0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 23, 59, 59)));
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
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0)));

            //a monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 23, 59, 59)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 0)));

            //a tuesday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0)));
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
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0)));

            //a monday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 1)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 4, 0, 1)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 23, 59, 59)));

            //a tuesday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0)));
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
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0)));

            //a monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 1)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 4, 0, 1)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 59, 59)));

            //a tuesday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0)));
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
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0)));

            // a thursday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 20, 23, 59, 59)));

            //a fri, sat, sun
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 23, 59, 59)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 0, 0, 0)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0)));
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
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 9, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 20, 9, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 9, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 22, 9, 43, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0)));

            //monday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0)));

            //tuesday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0)));
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
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 59, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 7, 30, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 15, 30, 0)));

            //Midweek Scenarios
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 6, 59, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 7, 30, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 15, 30, 0)));

            //Friday Scenarios
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 6, 59, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 7, 30, 0)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 15, 30, 0)));

            //Weekend
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 6, 59, 0)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 7, 30, 0)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 15, 30, 0)));
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
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 15, 30, 0)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 30, 0)),"foo");

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 5, 30, 59)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 15, 30, 59)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 6, 59, 59)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 7, 00, 1)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 15, 30, 0)));
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

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 13, 29, 59)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 13, 30, 0)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 20, 0, 0)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 20, 0, 1)));
        }
    }
}
