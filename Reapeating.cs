

namespace Regex
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class RepeatingWordsFinder
    {
        public static List<string> FindRepeatingWords(string inputText)
        {
            // Normalize input text by removing non-alphanumeric characters (except spaces)
            string cleanedText = Regex.Replace(inputText, @"[^a-zA-Z0-9\s]", "").ToLower();

            // Split the cleaned text into words
            string[] words = cleanedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Dictionary to count occurrences of each word
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            // Count occurrences of each word
            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            // List to store repeated words
            List<string> repeatedWords = new List<string>();

            // Find words that appear more than once
            foreach (var entry in wordCounts)
            {
                if (entry.Value > 1)
                {
                    repeatedWords.Add(entry.Key);
                }
            }

            return repeatedWords;
        }
    }

    class Reapeating
    {
        static void Main()
        {
            // Example input text
            string inputText = "This is is a repeated repeated word test.";

            // Find repeating words in the sentence
            List<string> repeatingWords = RepeatingWordsFinder.FindRepeatingWords(inputText);

            // Print repeating words, separated by commas
            Console.WriteLine(string.Join(", ", repeatingWords));
        }
    }

}
