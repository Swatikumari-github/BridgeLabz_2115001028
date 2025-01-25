using System;

class Program
{
    static void Count()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Array to store the frequency of each digit (0-9)
        int[] frequency = new int[10];

        // Loop through each character of the input string (which represents the digits of the number)
        foreach (char c in input)
        {
            if (Char.IsDigit(c)) // Ensure it's a valid digit
            {
                int digit = c - '0'; // Convert character to corresponding digit (0-9)
                frequency[digit]++; // Increase the frequency of the digit
            }
        }

        // Display the frequency of each digit
        Console.WriteLine("\nFrequency of each digit:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0) // Only display the digits that appear at least once
            {
                Console.WriteLine("Digit" +(i) +":" +frequency[i] +"times");
            }
        }
    }

    static void Main(string[] args)
    {
      Count();
    }
}
