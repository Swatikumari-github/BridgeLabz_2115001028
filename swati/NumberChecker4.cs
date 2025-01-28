using System;

class NumberChecker4
{
    static void Main(string[] args)
    {
        // Asking for user input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Counting digits and storing digits in an array
        int countOfDigits = CountDigits(number);
        int[] digits = StoreDigits(number);
        Console.WriteLine("Count of digits in " + number + ": " + countOfDigits);
        Console.WriteLine("Digits of " + number + ": " + string.Join(", ", digits));

        // Finding the sum of the digits
        int sumOfDigits = SumOfDigits(digits);
        Console.WriteLine("Sum of digits of " + number + ": " + sumOfDigits);

        // Finding the sum of the squares of the digits
        double sumOfSquares = SumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of squares of digits of " + number + ": " + sumOfSquares);

        // Checking if the number is a Harshad number
        bool isHarshad = IsHarshadNumber(number);
        Console.WriteLine(number + " is a Harshad number: " + isHarshad);

        // Finding the frequency of each digit
        int[,] digitFrequency = FindDigitFrequency(digits);
        Console.WriteLine("Frequency of each digit in " + number + ":");
        for (int i = 0; i < digitFrequency.GetLength(0); i++)
        {
            Console.WriteLine("Digit " + digitFrequency[i, 0] + " appears " + digitFrequency[i, 1] + " time(s).");
        }
    }

    // Method to count the digits in a number
    public static int CountDigits(int num)
    {
        int count = 0;
        while (num > 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }

    // Method to store the digits of a number in an array
    public static int[] StoreDigits(int num)
    {
        int count = CountDigits(num);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        return digits;
    }

    // Method to find the sum of the digits using the digits array
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of the squares of the digits using the digits array
    public static double SumOfSquaresOfDigits(int[] digits)
    {
        double sum = 0;
        foreach (int digit in digits)
        {
            sum += Math.Pow(digit, 2);  // Using Math.Pow() to square each digit
        }
        return sum;
    }

    // Method to check if the number is a Harshad number
    public static bool IsHarshadNumber(int num)
    {
        int sumOfDigits = SumOfDigits(StoreDigits(num));
        return num % sumOfDigits == 0;
    }

    // Method to find the frequency of each digit in the number
    public static int[,] FindDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];  // Array to store frequency of digits from 0 to 9
        foreach (int digit in digits)
        {
            frequency[digit, 0] = digit;  // Store the digit
            frequency[digit, 1]++;        // Increment the frequency
        }

        return frequency;
    }
}
