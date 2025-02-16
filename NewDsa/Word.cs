using System;
using System.Collections.Generic;
using System.Linq;

namespace NewDsa
{
    
    class Word
    {
        static void Main()
        {
            string[] sentences = {
           
            "Linear search is a simple search algorithm.",
            "C# is a powerful programming language.",
            "This sentence contains the word search.",
            "Another example without the keyword."
        };

            Console.Write("Enter the word to search for: ");
            string wordToFind = Console.ReadLine();

            string result = FindFirstSentenceContainingWord(sentences, wordToFind);

            if (result != null)
                Console.WriteLine($"First sentence containing \"{wordToFind}\":\n{result}");
            else
                Console.WriteLine($"No sentence contains the word \"{wordToFind}\".");
        }

        static string FindFirstSentenceContainingWord(string[] sentences, string word)
        {
            foreach (string sentence in sentences)
            {
                if (sentence.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    return sentence; // Return the first matching sentence
            }
            return null; // Return null if no sentence contains the word
        }
    }

}
