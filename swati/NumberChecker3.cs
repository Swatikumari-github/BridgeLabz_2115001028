using System;

class NumberChecker3
{
    static void Main()
    {
        // Asking for user input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Counting digits
        int countOfDigits = CountDigits(number);
        Console.WriteLine("Count of digits in " + number + ": " + countOfDigits);

        // Storing digits in an array
        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits of " + number + ": " + string.Join(", ", digits));

        // Reversing the digits array
        ReverseDigits(digits);
        Console.WriteLine("Reversed digits of " + number + ": " + string.Join(", ", digits));

        // Checking if the number is a palindrome
        bool isPalindrome = IsPalindrome(digits);
        Console.WriteLine(number + " is a palindrome: " + isPalindrome);

        // Checking if the number is a duck number
        bool isDuck = IsDuckNumber(digits);
        Console.WriteLine(number + " is a duck number: " + isDuck);
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

    // Method to reverse the digits array
    public static void ReverseDigits(int[] digits)
    {
        int start = 0, end = digits.Length - 1;
        while (start < end)
        {
            int temp = digits[start];
            digits[start] = digits[end];
            digits[end] = temp;
            start++;
            end--;
        }
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }
        return true;
    }

    // Method to check if a number is a palindrome using the digits array
    public static bool IsPalindrome(int[] digits)
    {
        int[] reversedDigits = (int[])digits.Clone();  // Clone the original array
        ReverseDigits(reversedDigits);
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check if a number is a duck number using the digits array
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit != 0) // It contains a non-zero digit
                return true;
        }
        return false;
    }
}
