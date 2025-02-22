

namespace Regex
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class CurrencyExtractor
    {
        public static List<string> ExtractCurrencyValues(string inputText)
        {
            // Regular expression to match currency values (with or without currency symbol)
            string pattern = @"(?:\$\s?\d+(\.\d{1,2})?)|\d+(\.\d{1,2})?";

            // Use Regex.Matches to find all matches of currency values
            MatchCollection matches = Regex.Matches(inputText, pattern);

            // List to store extracted currency values
            List<string> currencyValues = new List<string>();

            // Add matched values to the list
            foreach (Match match in matches)
            {
                currencyValues.Add(match.Value);
            }

            return currencyValues;
        }
    }

    class Currency
    {
        static void Main()
        {
            // Example input text
            string inputText = "The price is $45.99, and the discount is $ 10.50.";

            // Extract currency values from the text
            List<string> currencyValues = CurrencyExtractor.ExtractCurrencyValues(inputText);

            // Print extracted currency values, separated by commas
            Console.WriteLine(string.Join(", ", currencyValues));
        }
    }

}
