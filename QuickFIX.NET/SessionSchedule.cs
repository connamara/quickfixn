﻿
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
            if (WeeklySession)
                return CheckDay(time);
            else
                return CheckTime(time.TimeOfDay);
        }

        private bool CheckDay(System.DateTime time)
        {
          if (StartDay < EndDay)
          {
            if (time.DayOfWeek < StartDay || time.DayOfWeek > EndDay)
            {
              return false;
            } else if (time.DayOfWeek < EndDay)
            {
              return (StartDay < time.DayOfWeek) || (StartTime.CompareTo(time.TimeOfDay) <= 0);
            } else
            {
	            return (time.DayOfWeek < EndDay) || (EndTime.CompareTo(time.TimeOfDay) >= 0);
            }
          } 

          if (EndDay < StartDay)
          {
            if (EndDay < time.DayOfWeek && time.DayOfWeek < StartDay)
            {
              return false;
            } else if (time.DayOfWeek < StartDay)
            {
              return (time.DayOfWeek < EndDay) || (EndTime.CompareTo(time.TimeOfDay) >= 0);
            } else
            {	
              return (time.DayOfWeek > StartDay) || (StartTime.CompareTo(time.TimeOfDay) <= 0);
            }
          } 

          //start day must be same as end day
          if(StartTime >= EndTime)
            return time.DayOfWeek!=StartDay || CheckTime(time.TimeOfDay);
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
