
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

        public bool IsSessionTime(System.DateTime time)
        {
            if (time.Kind == System.DateTimeKind.Local)
                throw new System.ArgumentException("Only UTC time is supported", "time");

            System.DateTime adjusted =
                UseLocalTime
                    ? time.ToLocalTime()
                    : TimeZone == null
                          ? time
                          : System.TimeZoneInfo.ConvertTimeFromUtc(time, TimeZone);

            if (WeeklySession)
                return CheckDay(adjusted);
            else
                return CheckTime(adjusted.TimeOfDay);
        }

        /// <summary>
        /// Return the latest EndTime (in UTC) before time.
        /// </summary>
        /// <param name="utctime"></param>
        /// <returns></returns>
        public DateTime LastEndTime(DateTime utctime)
        {
            if (utctime.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Only UTC time is supported", "time");

            DateTime adjusted =
                UseLocalTime
                    ? utctime.ToLocalTime()
                    : TimeZone == null
                          ? utctime
                          : TimeZoneInfo.ConvertTimeFromUtc(utctime, TimeZone);

            int daysBack = 0;
            if (WeeklySession)
            {
                daysBack = (7 - (int)EndDay + (int)adjusted.DayOfWeek) % 7;
                if (daysBack == 0 && adjusted.TimeOfDay < EndTime)
                    daysBack = 7;
            }
            else if (adjusted.TimeOfDay < EndTime)
                daysBack = 1;

            adjusted = adjusted.Date + new TimeSpan(-daysBack, 0, 0, 0) + EndTime;
            return UseLocalTime
                ? adjusted.ToUniversalTime()
                : TimeZone == null
                    ? adjusted
                    : TimeZoneInfo.ConvertTimeToUtc(adjusted, TimeZone);
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
