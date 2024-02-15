#nullable enable
using System;

namespace QuickFix
{
    public class SessionSchedule
    {
        public TimeSpan? StartTime { get; }
        public TimeSpan? EndTime { get; }

        public bool WeeklySession { get; }
        public DayOfWeek? StartDay { get; }
        public DayOfWeek? EndDay { get; }

        public bool NonStopSession { get; }

        public bool UseLocalTime { get; }
        public TimeZoneInfo? TimeZone { get; }


        /// <summary>
        /// Returns true if testtime is in a different and newer session than old time
        /// (or more explicitly: oldtime &lt;= some EndTime &lt; testtime)
        /// </summary>
        /// <param name="oldtimeUtc"></param>
        /// <param name="testtimeUtc"></param>
        /// <returns></returns>
        public bool IsNewSession(DateTime oldtimeUtc, DateTime testtimeUtc)
        {
            if (NonStopSession)
            {
                return false;
            }

            if (oldtimeUtc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", nameof(oldtimeUtc));
            if (testtimeUtc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", nameof(testtimeUtc));

            DateTime old = AdjustUtcDateTime(oldtimeUtc);
            DateTime test = AdjustUtcDateTime(testtimeUtc);

            if (DateTime.Compare(old, test) < 0) // old is earlier than test
            {
                DateTime nextend = NextEndTime(oldtimeUtc);
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
            if (utc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", nameof(utc));

            if(UseLocalTime)
                return utc.ToLocalTime();

            return TimeZone==null ? utc : TimeZoneInfo.ConvertTimeFromUtc(utc, TimeZone);
        }

        public bool IsSessionTime(DateTime utc)
        {
            if (utc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", nameof(utc));

            DateTime adjusted = AdjustUtcDateTime(utc);

            return WeeklySession ? CheckDay(adjusted) : CheckTime(adjusted.TimeOfDay);
        }

        /// <summary>
        /// Get the next endtime (in config file's timezone) that is equal to or after the input.
        /// </summary>
        /// <param name="utc">a utc time (raises an ArgumentException if not utc)</param>
        /// <returns></returns>
        public DateTime NextEndTime(DateTime utc)
        {
            if (NonStopSession)
                throw new NotSupportedException("NonStopSession");

            TimeSpan vEndTime = EndTime ?? throw new QuickFix.ConfigError("EndTime is null");

            if (utc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", nameof(utc));

            DateTime d = AdjustUtcDateTime(utc);
            DateTime end = DateTime.MinValue;

            if (WeeklySession)
            {
                end = new DateTime(d.Year, d.Month, d.Day, vEndTime.Hours, vEndTime.Minutes, vEndTime.Seconds, d.Kind);
                while (end.DayOfWeek != EndDay)
                    end = end.AddDays(1);
                if (DateTime.Compare(d, end) > 0) // d is later than end
                    end = end.AddDays(7);
            }
            else
            {
                end = new DateTime(d.Year, d.Month, d.Day, vEndTime.Hours, vEndTime.Minutes, vEndTime.Seconds, d.Kind);
                if (DateTime.Compare(d, end) > 0) // d is later than end
                    end = end.AddDays(1);
            }

            return end;
        }

        /// <summary>
        /// return true if time falls within StartTime/EndTime
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private bool CheckDay(DateTime time)
        {
            if (NonStopSession)
                throw new InvalidOperationException("NonStopSession is set -- this should never be called.");

            DayOfWeek vStartDay = StartDay ?? throw new QuickFix.ConfigError("StartDay is null");
            DayOfWeek vEndDay = EndDay ?? throw new QuickFix.ConfigError("EndDay is null");
            TimeSpan vStartTime = StartTime ?? throw new QuickFix.ConfigError("StartTime is null");
            TimeSpan vEndTime = EndTime ?? throw new QuickFix.ConfigError("EndTime is null");

            if (vStartDay < vEndDay)
            {
                if (time.DayOfWeek < vStartDay || time.DayOfWeek > vEndDay)
                    return false;

                if (time.DayOfWeek < vEndDay)
                    return (vStartDay < time.DayOfWeek) || (vStartTime.CompareTo(time.TimeOfDay) <= 0);

                return (time.DayOfWeek < vEndDay) || (vEndTime.CompareTo(time.TimeOfDay) >= 0);
            }

            if (vEndDay < vStartDay)
            {
                if (vEndDay < time.DayOfWeek && time.DayOfWeek < vStartDay)
                    return false;

                if (time.DayOfWeek < vStartDay)
                    return (time.DayOfWeek < vEndDay) || (vEndTime.CompareTo(time.TimeOfDay) >= 0);

                return (time.DayOfWeek > vStartDay) || (vStartTime.CompareTo(time.TimeOfDay) <= 0);
            }

            //start day must be same as end day
            if (vStartTime >= vEndTime)
                return time.DayOfWeek != vStartDay || CheckTime(time.TimeOfDay);

            return time.DayOfWeek == vStartDay && CheckTime(time.TimeOfDay);
        }

        /// <summary>
        /// Return true if time is between StartDay:StartTime and EndDay:EndTime
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private bool CheckTime(TimeSpan time)
        {
            if (NonStopSession)
                return true;

            TimeSpan vStartTime = StartTime ?? throw new QuickFix.ConfigError("StartTime is null");
            TimeSpan vEndTime = EndTime ?? throw new QuickFix.ConfigError("EndTime is null");

            if (vStartTime.CompareTo(vEndTime) < 0)
            {
                return (time.CompareTo(vStartTime) >= 0 &&
                    time.CompareTo(vEndTime) <= 0);
            }

            if (vStartTime.CompareTo(vEndTime) > 0)
            {
                return time.CompareTo(vStartTime) >= 0 ||
                    time.CompareTo(vEndTime) <= 0;
            }

            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="settings"></param>
        public SessionSchedule(QuickFix.Dictionary settings)
        {
            if (settings.Has(SessionSettings.NON_STOP_SESSION))
                NonStopSession = settings.GetBool(SessionSettings.NON_STOP_SESSION);

            if (NonStopSession)
                return;

            if (!settings.Has(SessionSettings.START_DAY) && settings.Has(SessionSettings.END_DAY))
                throw new QuickFix.ConfigError("EndDay used without StartDay");

            if (settings.Has(SessionSettings.START_DAY) && !settings.Has(SessionSettings.END_DAY))
                throw new QuickFix.ConfigError("StartDay used without EndDay");

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
                TimeZone = TimeZoneInfo.FindSystemTimeZoneById(id);
            }

            try
            {
                StartTime = TimeSpan.Parse(
                    settings.GetString(SessionSettings.START_TIME));

                EndTime = TimeSpan.Parse(
                    settings.GetString(SessionSettings.END_TIME));
            }
            catch (FormatException e)
            {
                throw new ConfigError(e.Message);
            }
        }
    }
}
