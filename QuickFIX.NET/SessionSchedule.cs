
namespace QuickFix
{
    public class SessionSchedule
    {
        public System.TimeSpan StartTime { get; private set; }
        public System.TimeSpan EndTime { get; private set; }

        public bool WeeklySession { get; private set; }
        public System.DayOfWeek StartDay { get; private set; }
        public System.DayOfWeek EndDay {get; private set;}

        public bool IsSessionTime(System.DateTime time)
        {
            return CheckTime(time.TimeOfDay) && CheckDay(time);
        }

        private bool CheckDay(System.DateTime time)
        {
            if (!WeeklySession)
                return true;

            if (StartTime.CompareTo(EndTime) > 0)
            {
                //if session goes over midnight and it's the start session day,
                //make sure start day occurs in session
                if (time.DayOfWeek == StartDay)
                {
                    return time.TimeOfDay.CompareTo(StartTime) >= 0;
                }

                //likewise, if day is the end part of a session, verify
                //time occurs in session
                System.DateTime yesterday = time.AddDays(-1);
                if (yesterday.DayOfWeek == EndDay)
                {
                    return time.TimeOfDay.CompareTo(EndTime) <= 0;
                }
            }

            if(StartDay <= EndDay)
                return time.DayOfWeek.CompareTo(StartDay) >= 0 && 
                    time.DayOfWeek.CompareTo(EndDay) <= 0; 
            else
                return time.DayOfWeek.CompareTo(EndDay) <=0 ||
                    time.DayOfWeek.CompareTo(StartDay) >=0;
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
             
            if(settings.Has(SessionSettings.START_DAY) && !settings.Has(SessionSettings.END_DAY))
            {
                throw new QuickFix.ConfigError("StartDay used without EndDay");
            }

            if (settings.Has(SessionSettings.START_DAY) && settings.Has(SessionSettings.END_DAY))
            {
                StartDay = settings.GetDay(SessionSettings.START_DAY);
                EndDay = settings.GetDay(SessionSettings.END_DAY);
                WeeklySession = true;
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
