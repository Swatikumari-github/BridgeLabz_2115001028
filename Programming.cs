

namespace Regex
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ProgrammingLanguageExtractor
    {
        public static List<string> ExtractProgrammingLanguages(string inputText)
        {
            // List of programming languages to match
            List<string> languages = new List<string>
        {
            "Java", "Python", "JavaScript", "Go", "C", "C++", "Ruby", "Swift", "PHP", "Kotlin", "Perl", "Rust"
        };

            // Create a regular expression pattern to match any of the languages in the list
            string pattern = @"\b(" + string.Join("|", languages) + @")\b";

            // Use Regex to find matches in the input text
            MatchCollection matches = Regex.Matches(inputText, pattern, RegexOptions.IgnoreCase);

            // List to store matched programming languages
            List<string> matchedLanguages = new List<string>();

            // Add matched languages to the list (case-insensitive)
            foreach (Match match in matches)
            {
                matchedLanguages.Add(match.Value);
            }

            return matchedLanguages;
        }
    }

    class Programming
    {
        static void Main()
        {
            // Example input text
            string inputText = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

            // Extract programming languages from the text
            List<string> languages = ProgrammingLanguageExtractor.ExtractProgrammingLanguages(inputText);

            // Print extracted languages, separated by commas
            Console.WriteLine(string.Join(", ", languages));
        }
    }

}
