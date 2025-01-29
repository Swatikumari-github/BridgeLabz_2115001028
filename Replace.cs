using System;

class Program
{
    static void Main()
    {
        // Read input sentence and words to replace
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Enter the word to replace:");
        string wordToReplace = Console.ReadLine();

        Console.WriteLine("Enter the new word:");
        string newWord = Console.ReadLine();

        // Call the ReplaceWord function
        string result = ReplaceWord(sentence, wordToReplace, newWord);

        // Display the result
        Console.WriteLine("Updated sentence: " + result);
    }

    static string ReplaceWord(string sentence, string wordToReplace, string newWord)
    {
        // Replace all occurrences of the word in the sentence
        string result = sentence.Replace(wordToReplace, newWord);
        return result;
    }
}
