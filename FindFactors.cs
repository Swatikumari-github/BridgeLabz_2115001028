using System;
using System.Linq;
class ques1

{
	static int[] FindFactors(int number)
    {
        // Find the count of factors
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Initialize the array with the count of factors
        int[] factors = new int[count];
        int index = 0;

        // Save the factors into the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    static int CalculateSum(int[] factors)
    {
        return factors.Sum();
    }

    static long CalculateProduct(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    static double CalculateSumOfSquares(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
	static void Main(string [] args)
	{
		        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find factors and store them in an array
        int[] factors = FindFactors(number);

        // Display the factors
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        // Calculate and display the sum of the factors
        int sumOfFactors = CalculateSum(factors);
        Console.WriteLine("Sum of factors: " + sumOfFactors);

        // Calculate and display the product of the factors
        long productOfFactors = CalculateProduct(factors);
        Console.WriteLine("Product of factors: " + productOfFactors);

        // Calculate and display the sum of the squares of the factors
        double sumOfSquares = CalculateSumOfSquares(factors);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    
	}
}