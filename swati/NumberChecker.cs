using System;

class NumberChecker
{
    static void Main(string[] args)
    {
        // Asking for user input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Finding factors
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors of " + number + ": " + string.Join(", ", factors));

        // Finding the greatest factor
        int greatestFactor = FindGreatestFactor(factors);
        Console.WriteLine("Greatest factor of " + number + ": " + greatestFactor);

        // Finding the sum of factors
        int sumOfFactors = SumOfFactors(factors);
        Console.WriteLine("Sum of factors of " + number + ": " + sumOfFactors);

        // Finding the product of factors
        int productOfFactors = ProductOfFactors(factors);
        Console.WriteLine("Product of factors of " + number + ": " + productOfFactors);

        // Finding the product of cubes of factors
        double productOfCubes = ProductOfCubes(factors);
        Console.WriteLine("Product of cubes of factors of " + number + ": " + productOfCubes);

        // Checking if the number is a perfect number
        bool isPerfect = IsPerfectNumber(number);
        Console.WriteLine(number + " is a perfect number: " + isPerfect);

        // Checking if the number is an abundant number
        bool isAbundant = IsAbundantNumber(number);
        Console.WriteLine(number + " is an abundant number: " + isAbundant);

        // Checking if the number is a deficient number
        bool isDeficient = IsDeficientNumber(number);
        Console.WriteLine(number + " is a deficient number: " + isDeficient);

        // Checking if the number is a strong number
        bool isStrong = IsStrongNumber(number);
        Console.WriteLine(number + " is a strong number: " + isStrong);
    }

    // Method to find the factors of a number and return them as an array
    public static int[] FindFactors(int num)
    {
        int count = 0;
        // First loop to count the factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                count++;
        }

        // Second loop to find and store the factors in the array
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    // Method to find the greatest factor using the factors array
    public static int FindGreatestFactor(int[] factors)
    {
        return factors[factors.Length - 1];  // The greatest factor is the last element in the sorted array
    }

    // Method to find the sum of the factors using the factors array
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using the factors array
    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cubes of the factors using the factors array
    public static double ProductOfCubes(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);  // Cube each factor
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int num)
    {
        int sum = 0;
        int[] factors = FindFactors(num);
        foreach (int factor in factors)
        {
            if (factor != num)
                sum += factor;
        }
        return sum == num;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int num)
    {
        int sum = 0;
        int[] factors = FindFactors(num);
        foreach (int factor in factors)
        {
            if (factor != num)
                sum += factor;
        }
        return sum > num;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int num)
    {
        int sum = 0;
        int[] factors = FindFactors(num);
        foreach (int factor in factors)
        {
            if (factor != num)
                sum += factor;
        }
        return sum < num;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int num)
    {
        int sum = 0;
        int originalNumber = num;

        // Loop to calculate the sum of the factorials of the digits
        while (num > 0)
        {
            int digit = num % 10;
            sum += Factorial(digit);
            num /= 10;
        }

        return sum == originalNumber;
    }

    // Helper method to calculate factorial of a number
    public static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
