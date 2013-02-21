
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


        /// <summary>
        /// Returns true if testtime is in a different and newer session than old time
        /// (or more explicitly: oldtime &lt;= some EndTime &lt; testtime)
        /// </summary>
        /// <param name="oldtime_utc"></param>
        /// <param name="testtime_utc"></param>
        /// <returns></returns>
        public bool IsNewSession(DateTime oldtime_utc, DateTime testtime_utc)
        {
            if (oldtime_utc.Kind != System.DateTimeKind.Utc)
                throw new System.ArgumentException("Only UTC time is supported", "oldtime");
            if (testtime_utc.Kind != System.DateTimeKind.Utc)
                throw new System.ArgumentException("Only UTC time is supported", "testtime");

            DateTime old = AdjustUtcDateTime(oldtime_utc);
            DateTime test = AdjustUtcDateTime(testtime_utc);

            if (DateTime.Compare(old, test) < 0) // old is earlier than test
            {
                DateTime nextend = NextEndTime(oldtime_utc);
                return (DateTime.Compare(old, nextend) <= 0) && (DateTime.Compare(nextend, test) < 0);
            }

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
        /// Get the next endtime (in config file's timezone) that is equal to or after the input.
        /// </summary>
        /// <param name="utc">a utc time (raises an ArgumentException if not utc)</param>
        /// <returns></returns>
        public DateTime NextEndTime(DateTime utc)
        {
            if (utc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", "time");

            DateTime d = AdjustUtcDateTime(utc);
            DateTime end = DateTime.MinValue;

            if (WeeklySession)
            {
                end = new DateTime(d.Year, d.Month, d.Day, EndTime.Hours, EndTime.Minutes, EndTime.Seconds, d.Kind);
                while (end.DayOfWeek != EndDay)
                    end = end.AddDays(1);
                if (DateTime.Compare(d, end) > 0) // d is later than end
                    end = end.AddDays(7);
            }
            else
            {
                end = new DateTime(d.Year, d.Month, d.Day, EndTime.Hours, EndTime.Minutes, EndTime.Seconds, d.Kind);
                if (DateTime.Compare(d, end) > 0) // d is later than end
                    end = end.AddDays(1);
            }

            return end;
        }

        // TODO: consider removing this function in v2.0, as it's not used.
        /// <summary>
        /// Return the latest EndTime (in UTC) before time.
        /// </summary>
        /// <param name="utc"></param>
        /// <returns></returns>
        public DateTime LastEndTime(DateTime utc)
        {
            if (utc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", "time");

            DateTime n = NextEndTime(utc);
            if (WeeklySession)
                n = n.AddDays(-7);
            else
                n = n.AddDays(-1);

            if (UseLocalTime)
                return n.ToUniversalTime();
            if (TimeZone != null)
                return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(n, this.TimeZone.Id, "UTC");
            return n;
        }

        /// <summary>
        /// return true if time falls within StartTime/EndTime
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Return true if time is between StartDay:StartTime and EndDay:EndTime
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
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
