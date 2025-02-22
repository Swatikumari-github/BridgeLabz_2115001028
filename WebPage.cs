

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class LinkExtractor
    {
        public static List<string> ExtractLinks(string inputText)
        {
            // Define the regex pattern for matching URLs
            string pattern = @"\bhttps?://[^\s]+\b";

            // Create a list to store matched URLs
            List<string> links = new List<string>();

            // Find matches using Regex
            MatchCollection matches = Regex.Matches(inputText, pattern);

            // Add all matched links to the list
            foreach (Match match in matches)
            {
                links.Add(match.Value);
            }

            return links;
        }
    }

    class WebPage
    {
        static void Main()
        {
            // Example input text
            string inputText = "Visit https://www.google.com and http://example.org for more info.";

            // Extract links from the text
            List<string> links = LinkExtractor.ExtractLinks(inputText);

            // Print all extracted links, separated by commas
            Console.WriteLine(string.Join(", ", links));
        }
    }

}
