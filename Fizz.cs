using System;

class Fizz
{
    static void FizzBuzz(int number)
    {
        if (number > 0)
        {
            // Start the loop from 1 instead of 0
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid positive number.");
        }
    }

    static void Main(String[] args)
    {
        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());
        FizzBuzz(number);
        Console.ReadLine();
    }
}
