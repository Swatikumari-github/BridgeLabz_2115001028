using System;

class NumberChecker5
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

        // Checking if the number is a Duck number
        bool isDuckNumber = IsDuckNumber(digits);
        Console.WriteLine(number + " is a Duck number: " + isDuckNumber);

        // Checking if the number is an Armstrong number
        bool isArmstrong = IsArmstrongNumber(digits, countOfDigits);
        Console.WriteLine(number + " is an Armstrong number: " + isArmstrong);

        // Finding the largest and second largest digits
        int largest = FindLargest(digits);
        int secondLargest = FindSecondLargest(digits);
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);

        // Finding the smallest and second smallest digits
        int smallest = FindSmallest(digits);
        int secondSmallest = FindSecondSmallest(digits);
        Console.WriteLine("Smallest digit: " + smallest);
        Console.WriteLine("Second smallest digit: " + secondSmallest);
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

    // Method to check if a number is a Duck number using the digits array
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true; // Duck number must have a non-zero digit
            }
        }
        return false;
    }

    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int[] digits, int countOfDigits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, countOfDigits);  // Raise digit to the power of the count of digits
        }

        return sum == CountDigits(digits.Length); // Armstrong number condition
    }

    // Method to find the largest element in the digits array
    public static int FindLargest(int[] digits)
    {
        int largest = int.MinValue;
        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                largest = digit;
            }
        }
        return largest;
    }

    // Method to find the second largest element in the digits array
    public static int FindSecondLargest(int[] digits)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
        return secondLargest;
    }

    // Method to find the smallest element in the digits array
    public static int FindSmallest(int[] digits)
    {
        int smallest = int.MaxValue;
        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                smallest = digit;
            }
        }
        return smallest;
    }

    // Method to find the second smallest element in the digits array
    public static int FindSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }
        return secondSmallest;
    }
}
