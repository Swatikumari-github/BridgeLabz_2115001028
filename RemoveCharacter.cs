using System;
using System.Collections.Generic;


 class CharacterRemove
 
{
    static string RemoveCharacter(string str, char charToRemove)
    {
        // Create a new string by removing all occurrences of charToRemove
        string result = string.Empty;

        foreach (char c in str)
        {
            if (c != charToRemove)
            {
                result += c;
            }
        }

        return result;
    }
    
    
    public static void Main()
    {
       
         Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the character to remove:");
        char charToRemove = Console.ReadKey().KeyChar;
        Console.WriteLine();  // To move to the next line after the user input

        // Call the RemoveCharacter function
        string result = RemoveCharacter(input, charToRemove);

        // Display the result
        Console.WriteLine("String after removing the character: " + result);
}		
}
