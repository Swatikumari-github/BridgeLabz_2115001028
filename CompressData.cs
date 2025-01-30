using System;

class DateComparison
{
    static void Main()
    {
        // Take user input for the two dates
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        string firstDateInput = Console.ReadLine();

        Console.Write("Enter the second date (yyyy-MM-dd): ");
        string secondDateInput = Console.ReadLine();

        // Try to parse the input dates
        DateTime firstDate, secondDate;
        if (DateTime.TryParse(firstDateInput, out firstDate) && DateTime.TryParse(secondDateInput, out secondDate))
        {
            // Compare the dates using DateTime.Compare()
            int comparisonResult = DateTime.Compare(firstDate, secondDate);

            if (comparisonResult < 0)
            {
                Console.WriteLine("The first date is before the second date.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("The first date is the same as the second date.");
            }

            // Alternatively, you can also use CompareTo method
            // int comparisonResult2 = firstDate.CompareTo(secondDate);
            // Console.WriteLine(comparisonResult2 < 0 ? "The first date is before the second date." :
            //                    comparisonResult2 > 0 ? "The first date is after the second date." :
            //                    "The first date is the same as the second date.");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter valid dates.");
        }
    }
}
