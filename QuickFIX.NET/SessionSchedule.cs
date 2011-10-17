
namespace QuickFix
{
    public class SessionSchedule
    {
        public System.TimeSpan StartTime { get; private set; }
        public System.TimeSpan EndTime { get; private set; }

        public bool IsSessionTime(System.DateTime time)
        {
            if (StartTime.CompareTo(EndTime) < 0)
            {
                return (time.TimeOfDay.CompareTo(StartTime) >= 0 &&
                    time.TimeOfDay.CompareTo(EndTime) <= 0);
            } else if(StartTime.CompareTo(EndTime)>0)
            {
                return (time.TimeOfDay.CompareTo(StartTime) >= 0 ||
                    time.TimeOfDay.CompareTo(EndTime) <= 0);
            }

            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="settings"></param>
        public SessionSchedule(QuickFix.Dictionary settings)
        {
            int startDay = -1;
            int endDay = -1;

            if(settings.Has(SessionSettings.START_DAY))
                startDay = settings.GetDay(SessionSettings.START_DAY);

            if(settings.Has(SessionSettings.END_DAY))
                endDay = settings.GetDay(SessionSettings.END_DAY);

            if (startDay >= 0 && endDay < 0)
                throw new QuickFix.ConfigError("StartDay used without EndDay");

            if (endDay >= 0 && startDay < 0)
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
