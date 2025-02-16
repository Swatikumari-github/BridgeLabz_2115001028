using System;
using System.Collections.Generic;
using System.Linq;


namespace NewDsa
{
  

    class PeakElement
    {
        static void Main()
        {
            int[] arr = { 1, 3, 20, 4, 1, 0 }; // Example array

            int peakElementIndex = FindPeakElement(arr);

            if (peakElementIndex != -1)
                Console.WriteLine($"A peak element is found at index {peakElementIndex} with value {arr[peakElementIndex]}");
            else
                Console.WriteLine("No peak element found.");
        }

        static int FindPeakElement(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if mid is a peak element
                if ((mid == 0 || arr[mid] >= arr[mid - 1]) && (mid == arr.Length - 1 || arr[mid] >= arr[mid + 1]))
                {
                    return mid;
                }
                // If the element on the left is greater, the peak must be on the left side
                else if (mid > 0 && arr[mid - 1] > arr[mid])
                {
                    right = mid - 1;
                }
                // Otherwise, the peak must be on the right side
                else
                {
                    left = mid + 1;
                }
            }

            return -1; // If no peak element found
        }
    }

}
