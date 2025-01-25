using System;

class Program
{
    static void Reverse()
    {
         Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		   string numberString = number.ToString();
        int countOfDigits = numberString.Length;
		 int[] digits = new int[countOfDigits];
		  for (int i = 0; i < countOfDigits; i++)
        {
            digits[i] = number % 10; 
            number /= 10;             
        }
		 int[] reversedDigits = new int[countOfDigits];
		  for (int i = 0; i < countOfDigits; i++)
        {
            reversedDigits[i] = digits[countOfDigits - 1 - i];
        }
         Console.Write("The reversed number is: ");
        foreach (var digit in reversedDigits)
        {
            Console.Write(digit);
        }
    }

    static void Main(string[] args)
    {
        Reverse();
    }
}