using System;
using System.Text;
using System.Collections.Generic;
class RemoveDuplicates
{
    static string RemoveDuplicateCharacters(string str)
    {
        StringBuilder sb = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in str)
        {
            if (!seen.Contains(c))
            {
                sb.Append(c);
                seen.Add(c);
            }
        }
        return sb.ToString();
    }
 static void Main(string [] args)
 {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        string result = RemoveDuplicateCharacters(input);
        
        Console.WriteLine("Modified String: " +result);
        
 }
}