

namespace Regex
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class CensorBadWords
    {
        public static string CensorWords(string inputText, List<string> badWords)
        {
            // Loop through each bad word and replace it with "****"
            foreach (var word in badWords)
            {
                // Use Regex.Replace to handle case insensitivity
                inputText = Regex.Replace(inputText, $@"\b{Regex.Escape(word)}\b", "****", RegexOptions.IgnoreCase);
            }
            return inputText;
        }
    }

    class CensorBad
    {
        static void Main()
        {
            // Example input text
            string inputText = "This is a damn bad example with some stupid words.";

            // List of bad words to censor
            List<string> badWords = new List<string> { "damn", "stupid" };

            // Censor bad words
            string result = CensorBadWords.CensorWords(inputText, badWords);

            // Print the modified string
            Console.WriteLine(result);
        }
    }

}
