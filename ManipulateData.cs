using System;

class DateManipulation
{
    static void Main()
    {
        // Take user input for the initial date
        Console.Write("Enter a date (yyyy-MM-dd): ");
        string inputDate = Console.ReadLine();

        // Try to parse the input date
        DateTime date;
        if (DateTime.TryParse(inputDate, out date))
        {
            // Add 7 days, 1 month, and 2 years to the date
            DateTime updatedDate = date.AddDays(7);       // Add 7 days
            updatedDate = updatedDate.AddMonths(1);       // Add 1 month
            updatedDate = updatedDate.AddYears(2);        // Add 2 years

            // Subtract 3 weeks (21 days) from the updated date
            updatedDate = updatedDate.AddDays(-21);       // Subtract 3 weeks

            // Display the result
            Console.WriteLine("The final date after adding 7 days, 1 month, 2 years, and subtracting 3 weeks is: " + updatedDate.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a valid date.");
        }
    }
}
