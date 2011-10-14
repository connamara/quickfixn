
namespace QuickFix
{
    public class SessionSchedule
    {
        public bool IsSessionTime(System.DateTime time)
        {
            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="sessionID"></param>
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

            System.DateTime startTime;
            System.DateTime endTime;


            try
            {
                startTime = System.DateTime.ParseExact(
                    settings.GetString(SessionSettings.START_TIME),"HH:mm:ss",System.Globalization.CultureInfo.InvariantCulture);

                endTime = System.DateTime.ParseExact(
                    settings.GetString(SessionSettings.END_TIME),"HH:mm:ss",System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (System.FormatException e)
            {
                throw new ConfigError(e.Message);
            }
        }
    }
}
