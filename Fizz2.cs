using System;

class Fizz2
{
    static void FizzBuzz(int number)
    {   
	    int i=0;
        if (number > 0)
        {
           while(i<=number)
            
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
			  i++;
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
