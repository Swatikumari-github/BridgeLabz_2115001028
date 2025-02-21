using System;


namespace ExceptionHandle
{
  

    class Prog9
    {
        static void Main()
        {
            try
            {
                // Taking array input
                Console.WriteLine("Enter the size of the array:");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[size];

                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < size; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Taking divisor input
                Console.WriteLine("Enter the divisor:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                try
                {
                    // Trying to access array element
                    Console.WriteLine("Enter the index of the element to divide:");
                    int index = Convert.ToInt32(Console.ReadLine());

                    // Trying to divide the array element by divisor
                    int result = array[index] / divisor;

                    Console.WriteLine("Result of division: " + result);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid array index!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numeric values.");
            }
        }
    }

}
