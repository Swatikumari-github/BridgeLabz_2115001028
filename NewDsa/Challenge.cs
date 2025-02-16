using System;
using System.Collections.Generic;
using System.Linq;
namespace NewDsa
{
    

    class Challenge
    {
        static void Main()
        {
            int[] arr = { 2, 4, -1, 1 }; 
            int target = 4; // Target to search for using Binary Search

            // Find the first missing positive integer using Linear Search
            int firstMissingPositive = FindFirstMissingPositive(arr);
            Console.WriteLine($"First missing positive integer: {firstMissingPositive}");

            // Find the index of the target using Binary Search
            int targetIndex = BinarySearch(arr, target);
            Console.WriteLine($"Index of target {target}: {targetIndex}");
        }

        // Linear Search for the first missing positive integer
        static int FindFirstMissingPositive(int[] arr)
        {
            int n = arr.Length;

            // Mark numbers as visited using negative marking
            for (int i = 0; i < n; i++)
            {
                if (arr[i] <= 0 || arr[i] > n)
                    continue;

                int index = arr[i] - 1;
                if (arr[index] > 0)
                    arr[index] = -arr[index]; // Mark the number as visited
            }

            // Traverse the array to find the first unvisited index (i.e., positive value)
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    return i + 1; // The first missing positive integer
            }

            // If all positions are visited, return n + 1
            return n + 1;
        }

        // Binary Search for the target index after sorting the array
        static int BinarySearch(int[] arr, int target)
        {
            Array.Sort(arr); // Sort the array first

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid; // Return the index if target is found
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Return -1 if the target is not found
        }
    }

}
