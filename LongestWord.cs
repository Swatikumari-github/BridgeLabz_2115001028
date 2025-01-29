using System;

class LongestWord
{
      static string FindLongestWord(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
            return string.Empty;
        
        string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        
        string longestWord = "";
        int maxLength = 0;

        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
                longestWord = word;
            }
        }
        
        return longestWord;
    }
   
 static void Main(string [] args)
 {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        
        string longestWord = FindLongestWord(input);
        
        Console.WriteLine("Longest Word: " + longestWord);
        
 }
}