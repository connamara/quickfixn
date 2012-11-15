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
            // 1. ==========
            // UTC Session
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            DateTime thisDayEnd = new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc);
            DateTime prevDayEnd = new DateTime(2012, 10, 17, 16, 00, 00, DateTimeKind.Utc);

            // before starttime + during session
            for( int hour = 0; hour < 16; hour++ )
                for( int min = 0; min < 60; min++ )
                    Assert.AreEqual(prevDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, hour, min, 00, DateTimeKind.Utc)));

            // at and after endtime
            for (int hour = 16; hour < 24; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(thisDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, hour, min, 00, DateTimeKind.Utc)));

            // 2. ==========
            // UTC Session spanning midnight
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "16:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "09:00:00");
            sched = new QuickFix.SessionSchedule(settings);

            thisDayEnd = new DateTime(2012, 10, 18, 09, 00, 00, DateTimeKind.Utc);
            prevDayEnd = new DateTime(2012, 10, 17, 09, 00, 00, DateTimeKind.Utc);

            // before endtime
            for (int hour = 0; hour < 09; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(prevDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, hour, min, 00, DateTimeKind.Utc)));

            // after session + after starttime
            for (int hour = 09; hour < 24; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(thisDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, hour, min, 00, DateTimeKind.Utc)));
            
            // 3. ==========
            // Timezone specific session
            string timezoneid = "Eastern Standard Time";
            TimeZoneInfo timezone = System.TimeZoneInfo.FindSystemTimeZoneById(timezoneid);
            DateTime starttime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2012, 10, 18, 09, 00, 00, DateTimeKind.Utc), timezone);
            DateTime endtime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc), timezone);

            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, starttime.ToString("hh:mm:ss"));
            settings.SetString(QuickFix.SessionSettings.END_TIME, endtime.ToString( "hh:mm:ss"));
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, timezoneid);
            sched = new QuickFix.SessionSchedule(settings);

            thisDayEnd = new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc);
            prevDayEnd = new DateTime(2012, 10, 17, 16, 00, 00, DateTimeKind.Utc);

            // before starttime + during session
            for (int hour = 0; hour < 16; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(prevDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, hour, min, 00, DateTimeKind.Utc)));

            // at and after endtime
            for (int hour = 16; hour < 24; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(thisDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, hour, min, 00, DateTimeKind.Utc)));

            // 4. ==========
            // Timezone specific session spanning midnight
            starttime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2012, 10, 17, 16, 00, 00, DateTimeKind.Utc), timezone);
            endtime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2012, 10, 18, 09, 00, 00, DateTimeKind.Utc), timezone);

            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, starttime.ToString("hh:mm:ss"));
            settings.SetString(QuickFix.SessionSettings.END_TIME, endtime.ToString("hh:mm:ss"));
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, timezoneid);
            sched = new QuickFix.SessionSchedule(settings);

            thisDayEnd = new DateTime(2012, 10, 18, 09, 00, 00, DateTimeKind.Utc);
            prevDayEnd = new DateTime(2012, 10, 17, 09, 00, 00, DateTimeKind.Utc);

            // before endtime
            for (int hour = 0; hour < 09; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(prevDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, hour, min, 00, DateTimeKind.Utc)));

            // after session + after starttime
            for (int hour = 09; hour < 24; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(thisDayEnd, sched.LastEndTime(new DateTime(2012, 10, 18, hour, min, 00, DateTimeKind.Utc)));
        }

        [Test]
        public void testLastEndTime_WeeklySessions()
        {
            // 1. ==========
            // UTC Session
            QuickFix.Dictionary settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            DateTime prevWeekEnd = new DateTime(2012, 10, 12, 16, 00, 00, DateTimeKind.Utc);
            DateTime thisWeekEnd = new DateTime(2012, 10, 19, 16, 00, 00, DateTimeKind.Utc);

            // before starttime + during session
            for( int day = 15; day <= 19; day++ )
                for (int hour = 0; hour < (day == 19 ? 16 : 24); hour++)
                    for (int min = 0; min < 60; min++)
                        Assert.AreEqual(prevWeekEnd, sched.LastEndTime(new DateTime(2012, 10, day, hour, min, 00, DateTimeKind.Utc)));

            // at and after endtime
            for (int day = 19; day <= 21; day++)
                for (int hour = (day == 19 ? 16 : 00) ; hour < 24; hour++)
                    for (int min = 0; min < 60; min++)
                        Assert.AreEqual(thisWeekEnd, sched.LastEndTime(new DateTime(2012, 10, day, hour, min, 00, DateTimeKind.Utc)));

            // 2. ==========
            // UTC Session spanning weekchange
            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "16:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "09:00:00");
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Friday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            sched = new QuickFix.SessionSchedule(settings);

            prevWeekEnd = new DateTime(2012, 10, 08, 09, 00, 00, DateTimeKind.Utc);
            thisWeekEnd = new DateTime(2012, 10, 15, 09, 00, 00, DateTimeKind.Utc);

            // before starttime + during session
            for (int hour = 0; hour < 9; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(prevWeekEnd, sched.LastEndTime(new DateTime(2012, 10, 15, hour, min, 00, DateTimeKind.Utc)));

            // at and after endtime
            for (int day = 15; day <= 21; day++)
                for (int hour = (day == 15 ? 09 : 00); hour < 24; hour++)
                    for (int min = 0; min < 60; min++)
                        Assert.AreEqual(thisWeekEnd, sched.LastEndTime(new DateTime(2012, 10, day, hour, min, 00, DateTimeKind.Utc)));

            // 3. ==========
            // Timezone specific session
            string timezoneid = "Eastern Standard Time";
            TimeZoneInfo timezone = System.TimeZoneInfo.FindSystemTimeZoneById(timezoneid);
            DateTime starttime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2012, 10, 18, 09, 00, 00, DateTimeKind.Utc), timezone);
            DateTime endtime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc), timezone);

            prevWeekEnd = new DateTime(2012, 10, 12, 16, 00, 00, DateTimeKind.Utc);
            thisWeekEnd = new DateTime(2012, 10, 19, 16, 00, 00, DateTimeKind.Utc);

            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, starttime.ToString("hh:mm:ss"));
            settings.SetString(QuickFix.SessionSettings.END_TIME, endtime.ToString("hh:mm:ss"));
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, timezoneid);
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            sched = new QuickFix.SessionSchedule(settings);

            // before starttime + during session
            for (int day = 15; day <= 19; day++)
                for (int hour = 0; hour < (day == 19 ? 16 : 24); hour++)
                    for (int min = 0; min < 60; min++)
                        Assert.AreEqual(prevWeekEnd, sched.LastEndTime(new DateTime(2012, 10, day, hour, min, 00, DateTimeKind.Utc)));

            // at and after endtime
            for (int day = 19; day <= 21; day++)
                for (int hour = (day == 19 ? 16 : 00); hour < 24; hour++)
                    for (int min = 0; min < 60; min++)
                        Assert.AreEqual(thisWeekEnd, sched.LastEndTime(new DateTime(2012, 10, day, hour, min, 00, DateTimeKind.Utc)));

            // 4. ==========
            // Timezone specific session spanning weekchange
            starttime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc), timezone);
            endtime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2012, 10, 18, 09, 00, 00, DateTimeKind.Utc), timezone);

            settings = new QuickFix.Dictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, starttime.ToString("hh:mm:ss"));
            settings.SetString(QuickFix.SessionSettings.END_TIME, endtime.ToString("hh:mm:ss"));
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, timezoneid);
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Friday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            sched = new QuickFix.SessionSchedule(settings);

            prevWeekEnd = new DateTime(2012, 10, 08, 09, 00, 00, DateTimeKind.Utc);
            thisWeekEnd = new DateTime(2012, 10, 15, 09, 00, 00, DateTimeKind.Utc);

            // before starttime + during session
            for (int hour = 0; hour < 9; hour++)
                for (int min = 0; min < 60; min++)
                    Assert.AreEqual(prevWeekEnd, sched.LastEndTime(new DateTime(2012, 10, 15, hour, min, 00, DateTimeKind.Utc)));

            // at and after endtime
            for (int day = 15; day <= 21; day++)
                for (int hour = (day == 15 ? 09 : 00); hour < 24; hour++)
                    for (int min = 0; min < 60; min++)
                        Assert.AreEqual(thisWeekEnd, sched.LastEndTime(new DateTime(2012, 10, day, hour, min, 00, DateTimeKind.Utc)));
        }
    }
}
