using System;

class Program
{
    static void Factors(int number)
    {
        
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;
		if(number<=0)
		{
		 Console.WriteLine("enter a valid number");
		}
		else{
		    for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) // Check if 'i' is a factor
            {
                if (index == maxFactor) // Expand the array if necessary
                {
                    maxFactor *= 2; // Double the size
                    int[] temp = new int[maxFactor]; // Create a larger array
                    Array.Copy(factors, temp, factors.Length); // Copy existing factors
                    factors = temp; // Assign the larger array
                }

                factors[index] = i; // Store the factor
                index++; // Increment the index
            }
        }

		}
		Console.WriteLine("factors of the given number is:");
		
		 for (int i = 0; i < index; i++)
        {
            Console.WriteLine(factors[i]);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());
		Factors(number);

        }
}