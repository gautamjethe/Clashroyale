using System;
using ClashRoyale.Utilities.Utils;

class Program {
    static void Main() {
        Console.WriteLine("Current time: " + DateTime.UtcNow);
        Console.WriteLine("Seconds until next month: " + TimeUtils.GetSecondsUntilNextMonth);
        Console.WriteLine("Next month name: " + TimeUtils.GetNextMonthName());
        Console.WriteLine("Next month Unix timestamp: " + TimeUtils.GetNextMonthEndUnixTimestamp);

        var nextMonth = DateTime.UtcNow.Month == 12 ?
            new DateTime(DateTime.UtcNow.Year + 1, 1, 1, 0, 0, 0) :
            new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month + 1, 1, 0, 0, 0);

        Console.WriteLine("Calculated next month: " + nextMonth);
        Console.WriteLine("Seconds until next month (manual): " + (int)(nextMonth - DateTime.UtcNow).TotalSeconds);
    }
}
