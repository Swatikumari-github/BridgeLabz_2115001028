using System;

namespace ExceptionHandle
{

    using System;

    class Program
    {
        static void Main()
        {
            try
            {
                // Example array
                int[] numbers = { 10, 20, 30, 40, 50 };

                // Uncomment the next line to test NullReferenceException
                // numbers = null;

                Console.Write("Enter an index: ");
                int index = int.Parse(Console.ReadLine());

                // Attempt to retrieve value at the specified index
                Console.WriteLine($"Value at index {index}: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is not initialized!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }
    }

}