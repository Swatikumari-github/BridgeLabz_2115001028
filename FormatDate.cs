using System;

class DateFormats
{
    static void Main()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Display the current date in three different formats
        Console.WriteLine("Current date in dd/MM/yyyy format: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Current date in yyyy-MM-dd format: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Current date in EEE, MMM dd, yyyy format: " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}
