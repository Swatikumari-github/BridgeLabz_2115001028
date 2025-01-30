using System;

class TimeZoneExample
{
    static void Main()
    {
        // Get the current time in UTC
        DateTimeOffset currentUtcTime = DateTimeOffset.UtcNow;

        // Display the current UTC time
        Console.WriteLine("Current UTC Time (GMT): " + currentUtcTime);

        // Get the time for IST (Indian Standard Time)
        TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentUtcTime, istTimeZone);
        Console.WriteLine("Current Time in IST (Indian Standard Time): " + istTime);

        // Get the time for PST (Pacific Standard Time)
        TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentUtcTime, pstTimeZone);
        Console.WriteLine("Current Time in PST (Pacific Standard Time): " + pstTime);
    }
}
