using System;


public class Substring
{
    
    public static void Main()
    {
        // Declare variables to store user input and count occurrences
        string str1;
        string findstring;
        int strt = 0; // Start index of search
        int cnt = -1; // Initialize counter for occurrences
        int idx = -1; // Initialize index of found substring

        // Prompt the user to input the original string
        Console.Write("\n\nFind the number of times a specific string appears in a string :\n");
        Console.Write("--------------------------------------------------------------------\n");
        Console.Write("Input the original string : ");
        str1 = Console.ReadLine();

        // Prompt the user to input the string to be searched for
        Console.Write("Input the string to be searched for : ");
        findstring = Console.ReadLine();

        // Loop to count occurrences of the findstring in the original string
        while (strt != -1)
        {
            // Find the index of the findstring in the original string after the last found index
            strt = str1.IndexOf(findstring, idx + 1);

            // Increment the count of occurrences and update the last found index
            cnt += 1;
            idx = strt;
        }

        // Display the count of occurrences of the findstring in the original string
        Console.Write("The string '{0}' occurs " + cnt + " times.\n", findstring);
    }
}
