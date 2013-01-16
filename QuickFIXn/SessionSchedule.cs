
using System;
namespace QuickFix
{
    public class SessionSchedule
    {
        public System.TimeSpan StartTime { get; private set; }
        public System.TimeSpan EndTime { get; private set; }

        public bool WeeklySession { get; private set; }
        public System.DayOfWeek StartDay { get; private set; }
        public System.DayOfWeek EndDay { get; private set; }

        public bool UseLocalTime { get; private set; }
        public System.TimeZoneInfo TimeZone { get; private set; }


        public class SessionRange
        {
            public SessionRange(DateTime start, DateTime end) { Start = start; End = end; IsValid = true; }
            public SessionRange(bool isValid) { IsValid = isValid; }
            public bool IsValid { get; private set; }
            public DateTime Start { get; private set; }
            public DateTime End { get; private set; }

            const string STRING_FORMAT = "yyyyMMdd-HH:mm:ss";
            public override string ToString()
            {
                if (IsValid)
                    return String.Format("SessionRange[{0} to {1}]", Start.ToString(STRING_FORMAT), End.ToString(STRING_FORMAT));
                else
                    return "SessionRange[invalid]";
            }
        }

        /// <summary>
        /// Get the start/end DateTimes that the input falls within.
        /// The range will be represented in the timezone specified in the config file.
        /// (Return value will have IsValid=false if the input does not fall within a session.)
        /// </summary>
        /// <param name="d">a time assumed to be in the config-file's timezone</param>
        /// <returns></returns>
        public SessionRange GetSessionRange(DateTime d)
        {
            Console.WriteLine("d    : " + d.ToString("yyyyMMdd-HH:mm:ss"));

            if (!WeeklySession)
            {
                DateTime start = new DateTime(d.Year, d.Month, d.Day, StartTime.Hours, StartTime.Minutes, StartTime.Seconds, d.Kind);
                if (DateTime.Compare(start, d) > 0) // start is later than d
                    start = start.AddDays(-1);
                DateTime end = new DateTime(d.Year, d.Month, d.Day, EndTime.Hours, EndTime.Minutes, EndTime.Seconds, d.Kind);
                if (DateTime.Compare(d, end) > 0) // d is later than end
                    end = end.AddDays(1);

                // if d is outside of the session times, then start/end will span more than a day
                if ((end - start).TotalHours > 24)
                    return new SessionRange(false);
                else
                    return new SessionRange(start, end);
            }

            if (WeeklySession)
            {
                DateTime start = new DateTime(d.Year, d.Month, d.Day, StartTime.Hours, StartTime.Minutes, StartTime.Seconds, d.Kind);
                while (start.DayOfWeek != StartDay)
                    start = start.AddDays(-1);
                if (DateTime.Compare(start, d) > 0) // start is later than d
                    start = start.AddDays(-7);

                DateTime end = new DateTime(d.Year, d.Month, d.Day, EndTime.Hours, EndTime.Minutes, EndTime.Seconds, d.Kind);
                while (end.DayOfWeek != EndDay)
                    end = end.AddDays(1);
                if (DateTime.Compare(d, end) > 0) // d is later than end
                    end = end.AddDays(7);

                // if d is outside of the session times, then start/end will span more than a week
                if ((end - start).TotalDays > 7)
                    return new SessionRange(false);
                else
                    return new SessionRange(start, end);
            }

            return new SessionRange(false);
        }

        /// <summary>
        /// Determines if d1 and d2 fall within the same session.
        /// </summary>
        /// <param name="utc1"></param>
        /// <param name="utc2"></param>
        /// <returns></returns>
        public bool IsSameSession(System.DateTime utc1, DateTime utc2)
        {
            if (utc1.Kind == System.DateTimeKind.Local)
                throw new System.ArgumentException("Only UTC time is supported", "d1");
            if (utc2.Kind == System.DateTimeKind.Local)
                throw new System.ArgumentException("Only UTC time is supported", "d2");
            


            // fill in here

            return false;
        }

        /// <summary>
        /// Convert the parameter to its equivalent datetime in the config file's stated timezone
        /// </summary>
        /// <param name="utc"></param>
        /// <returns></returns>
        public DateTime AdjustUtcDateTime(DateTime utc)
        {
            if (utc.Kind != System.DateTimeKind.Utc)
                throw new System.ArgumentException("Only UTC time is supported", "time");

            if(UseLocalTime)
                return utc.ToLocalTime();
            else if (TimeZone==null)
                return utc;
            else
                return System.TimeZoneInfo.ConvertTimeFromUtc(utc, TimeZone);
        }

        public bool IsSessionTime(System.DateTime utc)
        {
            if (utc.Kind != System.DateTimeKind.Utc)
                throw new System.ArgumentException("Only UTC time is supported", "time");

            System.DateTime adjusted = AdjustUtcDateTime(utc);

            if (WeeklySession)
                return CheckDay(adjusted);
            else
                return CheckTime(adjusted.TimeOfDay);
        }

        /// <summary>
        /// Return the latest EndTime (in UTC) before time.
        /// </summary>
        /// <param name="utc"></param>
        /// <returns></returns>
        public DateTime LastEndTime(DateTime utc)
        {
            if (utc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", "time");

            DateTime adjusted = AdjustUtcDateTime(utc);

            int daysBack = 0;
            if (WeeklySession)
            {
                daysBack = (7 - (int)EndDay + (int)adjusted.DayOfWeek) % 7;
                if (daysBack == 0 && adjusted.TimeOfDay < EndTime)
                    daysBack = 7;
            }
            else if (adjusted.TimeOfDay < EndTime)
                daysBack = 1;

            return (adjusted.Date + new TimeSpan(-daysBack, 0, 0, 0) + EndTime).ToUniversalTime();
        }

        private bool CheckDay(System.DateTime time)
        {
            if (StartDay < EndDay)
            {
                if (time.DayOfWeek < StartDay || time.DayOfWeek > EndDay)
                {
                    return false;
                }
                else if (time.DayOfWeek < EndDay)
                {
                    return (StartDay < time.DayOfWeek) || (StartTime.CompareTo(time.TimeOfDay) <= 0);
                }
                else
                {
                    return (time.DayOfWeek < EndDay) || (EndTime.CompareTo(time.TimeOfDay) >= 0);
                }
            }

            if (EndDay < StartDay)
            {
                if (EndDay < time.DayOfWeek && time.DayOfWeek < StartDay)
                {
                    return false;
                }
                else if (time.DayOfWeek < StartDay)
                {
                    return (time.DayOfWeek < EndDay) || (EndTime.CompareTo(time.TimeOfDay) >= 0);
                }
                else
                {
                    return (time.DayOfWeek > StartDay) || (StartTime.CompareTo(time.TimeOfDay) <= 0);
                }
            }

            //start day must be same as end day
            if (StartTime >= EndTime)
                return time.DayOfWeek != StartDay || CheckTime(time.TimeOfDay);
            else
                return time.DayOfWeek == StartDay && CheckTime(time.TimeOfDay);
        }

        private bool CheckTime(System.TimeSpan time)
        {
            if (StartTime.CompareTo(EndTime) < 0)
            {
                return (time.CompareTo(StartTime) >= 0 &&
                    time.CompareTo(EndTime) <= 0);
            }
            else if (StartTime.CompareTo(EndTime) > 0)
            {
                return (time.CompareTo(StartTime) >= 0 ||
                    time.CompareTo(EndTime) <= 0);
            }

            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="settings"></param>
        public SessionSchedule(QuickFix.Dictionary settings)
        {
            this.WeeklySession = false;

            if (!settings.Has(SessionSettings.START_DAY) && settings.Has(SessionSettings.END_DAY))
            {
                throw new QuickFix.ConfigError("EndDay used without StartDay");
            }

            if (settings.Has(SessionSettings.START_DAY) && !settings.Has(SessionSettings.END_DAY))
            {
                throw new QuickFix.ConfigError("StartDay used without EndDay");
            }

            if (settings.Has(SessionSettings.START_DAY) && settings.Has(SessionSettings.END_DAY))
            {
                StartDay = settings.GetDay(SessionSettings.START_DAY);
                EndDay = settings.GetDay(SessionSettings.END_DAY);
                WeeklySession = true;
            }

            if (settings.Has(SessionSettings.USE_LOCAL_TIME))
            {
                UseLocalTime = settings.GetBool(SessionSettings.USE_LOCAL_TIME);
            }

            if (settings.Has(SessionSettings.TIME_ZONE))
            {
                if (UseLocalTime)
                {
                    throw new ConfigError(
                        SessionSettings.TIME_ZONE + " conflicts with " + SessionSettings.USE_LOCAL_TIME);
                }
                string id = settings.GetString(SessionSettings.TIME_ZONE);
                TimeZone = System.TimeZoneInfo.FindSystemTimeZoneById(id);
            }

            try
            {
                this.StartTime = System.TimeSpan.Parse(
                    settings.GetString(SessionSettings.START_TIME));

                this.EndTime = System.TimeSpan.Parse(
                    settings.GetString(SessionSettings.END_TIME));
            }
            catch (System.FormatException e)
            {
                throw new ConfigError(e.Message);
            }
        }
    }
}
