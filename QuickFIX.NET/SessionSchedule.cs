
namespace QuickFix
{
    public class SessionSchedule
    {
        public System.TimeSpan StartTime { get; private set; }
        public System.TimeSpan EndTime { get; private set; }
        public int StartDay { get; private set; }
        public int EndDay {get; private set;}

        public bool IsSessionTime(System.DateTime time)
        {
            return CheckTime(time.TimeOfDay) && CheckDay(ref time);
        }

        private bool CheckDay(ref System.DateTime time)
        {
            if(StartDay <0 || EndDay<0)
                return true;

            if (StartTime.CompareTo(EndTime) > 0)
            {
                //if session goes over midnight and it's the start session day,
                //make sure start day occurs in session
                if (time.DayOfWeek == (System.DayOfWeek)StartDay)
                {
                    return time.TimeOfDay.CompareTo(StartTime) >= 0;
                }

                //likewise, if day is the end part of a session, verify
                //time occurs in session
                if (time.DayOfWeek == (System.DayOfWeek)((EndDay + 1)%7))
                {
                    return time.TimeOfDay.CompareTo(EndTime) <= 0;
                }
            }

            if(StartDay <= EndDay)
                return time.DayOfWeek.CompareTo((System.DayOfWeek)StartDay) >= 0 && 
                    time.DayOfWeek.CompareTo((System.DayOfWeek)EndDay) <= 0; 
            else
                return time.DayOfWeek.CompareTo((System.DayOfWeek)EndDay) <=0 ||
                    time.DayOfWeek.CompareTo((System.DayOfWeek)StartDay) >=0;
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
            this.StartDay = -1;
            this.EndDay = -1;

            if(settings.Has(SessionSettings.START_DAY))
                StartDay = settings.GetDay(SessionSettings.START_DAY);

            if(settings.Has(SessionSettings.END_DAY))
                EndDay = settings.GetDay(SessionSettings.END_DAY);

            if (StartDay >= 0 && EndDay < 0)
                throw new QuickFix.ConfigError("StartDay used without EndDay");

            if (EndDay >= 0 && StartDay < 0)
                throw new QuickFix.ConfigError("EndDay used without StartDay");

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
