using System;
using System.Linq;


 class Anagram
 
{
     static bool IsAnagram(string str1, string str2)
    {
        // If the lengths are not equal, they can't be anagrams
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Sort both strings and compare
        var sortedStr1 = str1.OrderBy(c => c).ToArray();
        var sortedStr2 = str2.OrderBy(c => c).ToArray();

        return sortedStr1.SequenceEqual(sortedStr2);
    }
    
    
    public static void Main()
    {
       
         Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        // Call the IsAnagram function
        bool result = IsAnagram(str1, str2);

        // Display the result
        if (result)
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
}		
}
