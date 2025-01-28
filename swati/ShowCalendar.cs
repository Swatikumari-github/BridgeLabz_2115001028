using System;

class ShowCalendar
{
    static void Main()
    {
        Console.WriteLine("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        // Validate the input
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid month. Please enter a value between 1 and 12.");
            return;
        }

        // Display the calendar
        DisplayCalendar(year, month);
    }

    static void DisplayCalendar(int year, int month)
    {
        // Get the first day of the month
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);

        Console.WriteLine("\nCalendar for " + firstDayOfMonth.ToString("MMMM yyyy") + "\n");

        // Days of the week header
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Get the starting day of the week (0 = Sunday, 6 = Saturday)
        int startDay = (int)firstDayOfMonth.DayOfWeek;

        // Print leading spaces for the first week
        for (int i = 0; i < startDay; i++)
        {
            Console.Write("    ");  // 4 spaces for each day of the week before the 1st
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(day.ToString().PadLeft(3) + " ");  // Print each day with padding

            // Move to the next line after Saturday (index 6)
            if ((startDay + day) % 7 == 0)
            {
                Console.WriteLine();  // Line break after Saturday
            }
        }


        if ((startDay + daysInMonth) % 7 != 0)
        {
            Console.WriteLine();  
        }
    }
}
