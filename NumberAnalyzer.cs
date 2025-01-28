using System;
class NumberAnalyzer

{
     public static bool IsPositive(int number)
    {
        return number >= 0;
    }

    // Method to check whether the number is even or odd
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Method to compare two numbers
    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            return 1;
        }
        else if (number1 == number2)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

     
   static void Main(string [] args)
   {    
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.WriteLine("Number {0} is positive and it is {1}.", numbers[i], IsEven(numbers[i]) ? "even" : "odd");
            }
            else
            {
                Console.WriteLine("Number {0} is negative.", numbers[i]);
            }
        }

        int comparisonResult = Compare(numbers[0], numbers[1]);
        if (comparisonResult == 1)
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else if (comparisonResult == 0)
        {
            Console.WriteLine("The first and last numbers are equal.");
        }
        else
        {
            Console.WriteLine("The first number is less than the last number.");
        }
      
        Console.ReadLine();
	  
   }
}