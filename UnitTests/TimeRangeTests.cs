namespace QuickFix
{
    public class TimeRange
    {

        public bool LocalTime {get; private set;}

        private System.TimeSpan StartTime {get; set;}
        private System.TimeSpan EndTime { get; set; }
        private System.DayOfWeek? StartDay {get; set;}
        private System.DayOfWeek? EndDay {get; set;}

        public TimeRange(System.TimeSpan startTime, System.TimeSpan endTime, System.DayOfWeek? startDay, System.DayOfWeek? endDay) : this(startTime, endTime, startDay, endDay, false) { }

        public TimeRange(System.TimeSpan startTime, System.TimeSpan endTime, System.DayOfWeek? startDay, System.DayOfWeek? endDay, bool useLocalTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            StartDay = startDay;
            EndDay = endDay;
            LocalTime = useLocalTime;

            if (startDay > 0 && endDay > 0 && startDay == endDay && endTime > startTime) { EndTime = StartTime; }
        }

        public static bool IsInRange(System.TimeSpan start, System.TimeSpan end, System.DateTime time)
        {
            return IsInRange(start, end, time.TimeOfDay);
        }

        private static bool IsInRange(System.TimeSpan start, System.TimeSpan end, System.TimeSpan timeOnly)
        {
            if (start < end)
            {
                return (timeOnly >= start && timeOnly <= end);
            }
            else
            {
                return (timeOnly >= start || timeOnly <= end);
            }
        }

        public static bool IsInRange(System.TimeSpan startTime, System.TimeSpan endTime, System.DayOfWeek startDay, System.DayOfWeek endDay, System.DateTime time)
        {
            System.DayOfWeek currentDay = time.DayOfWeek;
            System.TimeSpan timeOnly = time.TimeOfDay;

            if (startDay == endDay)
            {
                if (currentDay != startDay) { return true; }
                return IsInRange(startTime, endTime, time);
            }
            else if (startDay < endDay)
            {
                if (currentDay < startDay || currentDay > endDay) { return false; }
                else if (currentDay == startDay && timeOnly < startTime) { return false; }
                else if (currentDay == endDay && timeOnly > endTime) { return false; }
            }
            else if (startDay > endDay)
            {
                if (currentDay < startDay && currentDay > endDay) { return false; }
                else if (currentDay == startDay && timeOnly < startTime) { return false; }
                else if (currentDay == endDay && timeOnly > endTime) { return false; }
            }
            
            return true;
        }

        public static bool IsInSameRange(System.TimeSpan start, System.TimeSpan end, System.DateTime time1, System.DateTime time2)
        {
            if (!IsInRange(start, end, time1)) { return false; }
            if (!IsInRange(start, end, time2)) { return false; }
            if (time1 == time2) { return true; }

            if (start <= end)
            {
                return time1.Date == time2.Date;
            }
            else
            {
                System.TimeSpan sessionLength = start - end;

                if (time1 > time2)
                {
                    return (time1 - time2) < sessionLength;
                }
                else
                {
                    return (time2 - time1) < sessionLength;
                }
            }
        }

        public static bool IsInSameRange(System.TimeSpan startTime, System.TimeSpan endTime, System.DayOfWeek startDay, System.DayOfWeek endDay, System.DateTime time1, System.DateTime time2)
        {
            if (!IsInRange(startTime, endTime, startDay, endDay, time1)) { return false; }
            if (!IsInRange(startTime, endTime, startDay, endDay, time2)) { return false; }

            System.TimeSpan length;
            if (startTime <= endTime) { length = endTime - startTime; }
            else
            {
                System.TimeSpan endOfDay = new System.TimeSpan(24, 0, 0);
                length = (endOfDay - startTime) + endTime;
            }

            System.TimeSpan sessionLength = new System.TimeSpan(DaysBetweenDays(startDay, endDay), length.Hours, length.Minutes, length.Seconds);

            if(time1 > time2)
            {
                return (time1 - time2) < sessionLength;
            }
            else
            {
                return (time2 - time1) < sessionLength;
            }

        }

        private static int DaysBetweenDays(System.DayOfWeek start, System.DayOfWeek end)
        {
            while (start != end)
            {
                if (start >= System.DayOfWeek.Saturday) { start = System.DayOfWeek.Sunday; }
                else { start++; }
            }
            return System.Convert.ToInt32(start);
        }

        [System.Obsolete("Depricated, use public property LocalTime")]
        public bool UseLocalTime() { return LocalTime;}

        public bool IsInRange(System.TimeSpan time)
        {
            return IsInRange(StartTime, EndTime, time);
        }

        public bool IsInRange(System.DateTime dateTime)
        {
            if (StartDay == null && EndDay == null)
            {
                return IsInRange(StartTime, EndTime, dateTime);
            }
            else
            {
                return IsInRange(StartTime, EndTime, (System.DayOfWeek)StartDay, (System.DayOfWeek)EndDay, dateTime);
            }
        }

        public bool IsInRange()
        {
            return IsInRange(System.DateTime.Now);
        }

        public bool IsInSameRange(System.DateTime time1, System.DateTime time2)
        { 
            if(StartDay == null && EndDay == null)
            {
                return IsInSameRange(StartTime, EndTime, time1, time2);
            }
            else{
                return IsInSameRange(StartTime, EndTime, (System.DayOfWeek)StartDay, (System.DayOfWeek)EndDay, time1, time2);
            }
        }

    }
}
