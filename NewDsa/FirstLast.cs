using System;
using System.Collections.Generic;
using System.Linq;

namespace NewDsa
{
   

    class FirstLast
    {
        static void Main()
        {
            int[] arr = { 1, 2, 2, 2, 3, 4, 5, 6 }; // Example sorted array
            int target = 2; // Target element to find

            int firstOccurrence = FindFirstOccurrence(arr, target);
            int lastOccurrence = FindLastOccurrence(arr, target);

            if (firstOccurrence != -1)
            {
                Console.WriteLine($"First occurrence of {target} is at index {firstOccurrence}");
                Console.WriteLine($"Last occurrence of {target} is at index {lastOccurrence}");
            }
            else
            {
                Console.WriteLine($"{target} not found in the array.");
            }
        }

        static int FindFirstOccurrence(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    right = mid - 1; // Move left to find the first occurrence
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return result;
        }

        static int FindLastOccurrence(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    left = mid + 1; // Move right to find the last occurrence
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return result;
        }
    }

}
