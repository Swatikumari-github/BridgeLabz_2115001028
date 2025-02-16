using System;
using System.Collections.Generic;
using System.Linq;

namespace NewDsa
{
    

    class FirstNeg    {
        static void Main()
        {
            int[] numbers = { 2, 7, 8, -4, 9, -2, 3 }; // Example array

            int firstNegative = FindFirstNegative(numbers);

            if (firstNegative != int.MaxValue)
                Console.WriteLine($"First negative number found: {firstNegative}");
            else
                Console.WriteLine("No negative numbers found in the array.");
        }

        static int FindFirstNegative(int[] arr)
        {
            foreach (int num in arr)
            {
                if (num < 0)
                    return num; // Return the first negative number found
            }
            return int.MaxValue; // Return a special value if no negative numbers exist
        }
    }

}
