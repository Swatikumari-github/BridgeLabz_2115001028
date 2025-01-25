using System;

class Program
{
    static void FizzBuzz()
    {
         Console.Write("Enter a positive integer: ");
          int number=Convert.ToInt32(Console.ReadLine());
		 string[] results = new string[number + 1];
		if(number<=0){
		Console.WriteLine("invalid input");
		}
		else{
		 
        // Loop from 0 to the number
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz"; // Multiple of both 3 and 5
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz"; // Multiple of 3
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz"; // Multiple of 5
            }
            else
            {
                results[i] = i.ToString(); // Not a multiple of 3 or 5
            }
        }
		}
        // Display the results
        Console.WriteLine("\nFizzBuzz Results:");
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine("position" +i +"=" +results[i]);
        }
    }

    static void Main(string[] args)
    {
         FizzBuzz();

    }
}