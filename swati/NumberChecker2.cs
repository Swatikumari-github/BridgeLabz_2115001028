using System;

class NumberChecker2
{
    static void Main(string[] args)
    {
        // Asking for user input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking if the number is a prime number
        bool isPrime = IsPrime(number);
        Console.WriteLine(number + " is a prime number: " + isPrime);

        // Checking if the number is a neon number
        bool isNeon = IsNeonNumber(number);
        Console.WriteLine(number + " is a neon number: " + isNeon);

        // Checking if the number is a spy number
        bool isSpy = IsSpyNumber(number);
        Console.WriteLine(number + " is a spy number: " + isSpy);

        // Checking if the number is an automorphic number
        bool isAutomorphic = IsAutomorphicNumber(number);
        Console.WriteLine(number + " is an automorphic number: " + isAutomorphic);

        // Checking if the number is a buzz number
        bool isBuzz = IsBuzzNumber(number);
        Console.WriteLine(number + " is a buzz number: " + isBuzz);
    }

    // Method to check if a number is a prime number
    public static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeonNumber(int num)
    {
        int square = num * num;
        int sumOfDigits = 0;
        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == num;
    }

    // Method to check if a number is a spy number
    public static bool IsSpyNumber(int num)
    {
        int sum = 0;
        int product = 1;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit;
            product *= digit;
            num /= 10;
        }
        return sum == product;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphicNumber(int num)
    {
        int square = num * num;
        int temp = num;
        while (square > 0)
        {
            if (square % 10 != temp % 10)
                return false;
            square /= 10;
            temp /= 10;
        }
        return true;
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzzNumber(int num)
    {
        return num % 7 == 0 || num % 10 == 7;
    }
}
