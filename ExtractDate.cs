

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class DateExtractor
    {
        public static List<string> ExtractDates(string inputText)
        {
            // Define the regex pattern for matching dates in dd/mm/yyyy format
            string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

            // Create a list to store matched dates
            List<string> dates = new List<string>();

            // Find matches using Regex
            MatchCollection matches = Regex.Matches(inputText, pattern);

            // Add all matched dates to the list
            foreach (Match match in matches)
            {
                dates.Add(match.Value);
            }

            return dates;
        }
    }

    class ExtractDate
    {
        static void Main()
        {
            // Example input text
            string inputText = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

            // Extract dates from the text
            List<string> dates = DateExtractor.ExtractDates(inputText);

            // Print all extracted dates, separated by commas
            Console.WriteLine(string.Join(", ", dates));
        }
    }

}
