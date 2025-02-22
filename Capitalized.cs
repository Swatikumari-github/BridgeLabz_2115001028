

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class CapitalizedWordsExtractor
    {
        public static List<string> ExtractCapitalizedWords(string inputText)
        {
            // Define the regex pattern for matching capitalized words
            string pattern = @"\b[A-Z][a-z]*\b";

            // Create a list to store matched capitalized words
            List<string> capitalizedWords = new List<string>();

            // Find matches using Regex
            MatchCollection matches = Regex.Matches(inputText, pattern);

            // Add all matched words to the list
            foreach (Match match in matches)
            {
                capitalizedWords.Add(match.Value);
            }

            return capitalizedWords;
        }
    }

    class Capatalized
    {
        static void Main()
        {
            // Example input text
            string inputText = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

            // Extract capitalized words from the text
            List<string> capitalizedWords = CapitalizedWordsExtractor.ExtractCapitalizedWords(inputText);

            // Print all extracted capitalized words, separated by commas
            Console.WriteLine(string.Join(", ", capitalizedWords));
        }
    }

}
