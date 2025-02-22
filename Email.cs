

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class EmailExtractor
    {
        public static List<string> ExtractEmails(string inputText)
        {
            // Define the regex pattern for matching email addresses
            string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            // Create a list to store matched email addresses
            List<string> emails = new List<string>();

            // Find matches using Regex
            MatchCollection matches = Regex.Matches(inputText, pattern);

            // Add all matched emails to the list
            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }

            return emails;
        }
    }

    class Email
    {
        static void Main()
        {
            // Example input text
            string inputText = "Contact us at support@example.com and info@company.org";

            // Extract email addresses from the text
            List<string> emails = EmailExtractor.ExtractEmails(inputText);

            // Print all extracted email addresses
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }

}
