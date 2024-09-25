using System;
using System.Collections.Generic;

namespace QuickFix
{
    public class SessionSchedule
    {
        public TimeSpan? StartTime { get; }
        public TimeSpan? EndTime { get; }

        public bool WeeklySession { get; }
        public DayOfWeek? StartDay { get; }
        public DayOfWeek? EndDay { get; }

        private readonly bool _isWeekdaysSession;
        private readonly HashSet<DayOfWeek> _weekdays = new();

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
                return false;

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

            if (_isWeekdaysSession)
                return CheckWeekdays(adjusted);

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
                throw new InvalidOperationException("NonStopSession is set; this statement should be unreachable");

            TimeSpan vEndTime = EndTime ?? throw new ConfigError("EndTime is null");

            if (utc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", nameof(utc));

            DateTime d = AdjustUtcDateTime(utc);
            DateTime end = DateTime.MinValue;


            if (_isWeekdaysSession)
            {
                end = new DateTime(d.Year, d.Month, d.Day, vEndTime.Hours, vEndTime.Minutes, vEndTime.Seconds, d.Kind);
                if (DateTime.Compare(d, end) > 0) // d is later than end
                    end = end.AddDays(1);
            }
            else if (WeeklySession)
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
        /// <param name="dt"></param>
        /// <returns></returns>
        private bool CheckDay(DateTime dt)
        {
            if (NonStopSession)
                throw new InvalidOperationException("NonStopSession is set; this statement should be unreachable");

            DayOfWeek vStartDay = StartDay ?? throw new ConfigError("StartDay is null");
            DayOfWeek vEndDay = EndDay ?? throw new ConfigError("EndDay is null");
            TimeSpan vStartTime = StartTime ?? throw new ConfigError("StartTime is null");
            TimeSpan vEndTime = EndTime ?? throw new ConfigError("EndTime is null");

            if (vStartDay < vEndDay)
            {
                if (dt.DayOfWeek < vStartDay || dt.DayOfWeek > vEndDay)
                    return false;

                if (dt.DayOfWeek < vEndDay)
                    return (vStartDay < dt.DayOfWeek) || (vStartTime.CompareTo(dt.TimeOfDay) <= 0);

                return (dt.DayOfWeek < vEndDay) || (vEndTime.CompareTo(dt.TimeOfDay) >= 0);
            }

            if (vEndDay < vStartDay)
            {
                if (vEndDay < dt.DayOfWeek && dt.DayOfWeek < vStartDay)
                    return false;

                if (dt.DayOfWeek < vStartDay)
                    return (dt.DayOfWeek < vEndDay) || (vEndTime.CompareTo(dt.TimeOfDay) >= 0);

                return (dt.DayOfWeek > vStartDay) || (vStartTime.CompareTo(dt.TimeOfDay) <= 0);
            }

            //start day must be same as end day
            if (vStartTime >= vEndTime)
                return dt.DayOfWeek != vStartDay || CheckTime(dt.TimeOfDay);

            return dt.DayOfWeek == vStartDay && CheckTime(dt.TimeOfDay);
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

            TimeSpan vStartTime = StartTime ?? throw new ConfigError("StartTime is null");
            TimeSpan vEndTime = EndTime ?? throw new ConfigError("EndTime is null");

            if (vStartTime.CompareTo(vEndTime) < 0)
            {
                return time.CompareTo(vStartTime) >= 0 &&
                    time.CompareTo(vEndTime) <= 0;
            }

            return time.CompareTo(vStartTime) >= 0 ||
                time.CompareTo(vEndTime) <= 0;
        }

        private bool CheckWeekdays(DateTime dt)
        {
            if (NonStopSession)
                throw new InvalidOperationException("NonStopSession is set; this statement should be unreachable");

            TimeSpan vStartTime = StartTime ?? throw new ConfigError("StartTime is null");
            TimeSpan vEndTime = EndTime ?? throw new ConfigError("EndTime is null");

            TimeSpan tod = dt.TimeOfDay;

            // session spans midnight
            if (vStartTime.CompareTo(vEndTime) < 0) {
                return _weekdays.Contains(dt.DayOfWeek) &&
                       tod.CompareTo(vStartTime) >= 0 &&
                       tod.CompareTo(vEndTime) < 0;
            }

            // session doesn't span midnight
            if (tod.CompareTo(vEndTime) >= 0 && tod.CompareTo(vStartTime) < 0)
                return false;
            var targetDay = tod.CompareTo(vStartTime) >= 0
                ? dt.DayOfWeek
                : PreviousDay(dt.DayOfWeek);
            return _weekdays.Contains(targetDay);
        }

        private static DayOfWeek PreviousDay(DayOfWeek d) {
            return d == DayOfWeek.Sunday
                ? DayOfWeek.Saturday
                : d - 1;
        }

        /// <summary>
        /// </summary>
        /// <param name="settings"></param>
        public SessionSchedule(SettingsDictionary settings)
        {
            if (settings.IsBoolPresentAndTrue(SessionSettings.NON_STOP_SESSION)) {
                NonStopSession = true;

                if (settings.Has(SessionSettings.START_DAY)
                    || settings.Has(SessionSettings.END_DAY)
                    || settings.Has(SessionSettings.START_TIME)
                    || settings.Has(SessionSettings.END_TIME))
                {
                    throw new ConfigError(
                        "NonStopSession is not compatible with StartDay/EndDay and StartTime/EndTime");
                }

                return;
            }

            if (settings.Has(SessionSettings.WEEKDAYS))
            {
                _isWeekdaysSession = true;
                if (settings.Has(SessionSettings.START_DAY) || settings.Has(SessionSettings.END_DAY) )
                    throw new ConfigError("StartDay/EndDay are not compatible with 'Weekdays' setting");

                _weekdays = settings.GetDays(SessionSettings.WEEKDAYS);
            }

            if (!settings.Has(SessionSettings.START_DAY) && settings.Has(SessionSettings.END_DAY))
                throw new ConfigError("EndDay used without StartDay");

            if (settings.Has(SessionSettings.START_DAY) && !settings.Has(SessionSettings.END_DAY))
                throw new ConfigError("StartDay used without EndDay");

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
