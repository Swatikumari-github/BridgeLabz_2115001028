using System;

class ques11
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number (num1):");
        float num1 = float.Parse(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number (num2):");
        float num2 = float.Parse(Console.ReadLine());

        // Perform operations
        float addNum = num1 + num2; // Addition
        float sub = num1 - num2;    // Subtraction
        float mul = num1 * num2;    // Multiplication

        // Display the results with clear formatting
        Console.WriteLine("The result after addition is: " + addNum);
        Console.WriteLine("The result after subtraction is: " + sub);
        Console.WriteLine("The result after multiplication is: " + mul);

        Console.ReadLine(); // Wait for user input before exiting
    }
}
