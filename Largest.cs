using System;

class Program
{
    static void Largest()
    {
         Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		int maxDigit = 10;
        int[] digits = new int[maxDigit];
		int index = 0;
          while (number != 0 && index < maxDigit)
        {
            digits[index] = number % 10; // Get the last digit
            number /= 10;                 // Remove the last digit
            index++;                      // Increment the index
        }
		 int largest = -1; 
        int secondLargest = -1;

        // Loop to find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] < largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display the largest and second largest
        if (secondLargest == -1)
        {
            Console.WriteLine("There is no second largest digit.");
        }
        else
        {
            Console.WriteLine("The largest digit is:" +largest);
            Console.WriteLine("The second largest digit is:" +secondLargest);
		}

    }

    static void Main(string[] args)
    {
        Largest();
    }
}