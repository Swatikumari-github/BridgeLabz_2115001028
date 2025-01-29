using System;
using System.Collections.Generic;


 class Frequent
 
{
     static char FindMostFrequentCharacter(string str)
    {
     Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Iterate through each character in the string
        foreach (char c in str)
        {
            // Ignore spaces and count only non-space characters
            if (c != ' ')
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
        }

        // Find the character with the maximum frequency
        char mostFrequent = '\0';
        int maxCount = 0;

        foreach (var entry in charCount)
        {
            if (entry.Value > maxCount)
            {
                mostFrequent = entry.Key;
                maxCount = entry.Value;
            }
        }

        return mostFrequent;
    }
    
    public static void Main()
    {
       
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

       
        char mostFrequentChar = FindMostFrequentCharacter(input);

        // Display the result
        Console.WriteLine("The most frequent character is: " + mostFrequentChar);
}		
}
