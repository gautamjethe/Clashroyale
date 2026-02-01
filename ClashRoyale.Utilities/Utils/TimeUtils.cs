using System;

namespace ClashRoyale.Utilities.Utils
{
    public class TimeUtils
    {
        public static int GetSecondsUntilEndOfMonth
        {
            get
            {
                var now = DateTime.UtcNow;
                // Calculate last day of current month
                DateTime endOfMonth = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month), 23, 59, 59);

                return (int) (endOfMonth - now).TotalSeconds;
            }
        }

        public static int GetSecondsUntilTomorrow
        {
            get
            {
                var now = DateTime.UtcNow;
                var tomorrow = now.AddDays(1).Date;

                return (int) (tomorrow - now).TotalSeconds;
            }
        }

        public static int CurrentUnixTimestamp => (int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

        public static string GetCurrentMonthName()
        {
            var now = DateTime.UtcNow;
            return now.ToString("MMMM yyyy");
        }
    }
}