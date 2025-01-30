using System;

class LargestOf3
{
    static int GetIntegerInput(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
	  static int FindMaximum(int num1, int num2, int num3)
    {
        return Math.Max(num1, Math.Max(num2, num3));
    }
  static void Main(string [] args)
 {
     Console.WriteLine("Find the maximum of three numbers");
        int num1 = GetIntegerInput("Enter the first number: ");
        int num2 = GetIntegerInput("Enter the second number: ");
        int num3 = GetIntegerInput("Enter the third number: ");
        
        int max = FindMaximum(num1, num2, num3);
        Console.WriteLine("The maximum number is: "+max);
 }
 }