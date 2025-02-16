using System;
using System.Collections.Generic;
using System.Linq;
namespace NewDsa
{
    

    class RotationPoint
    {
        static void Main()
        {
            int[] rotatedArray = { 6, 7, 9, 15, 19, 2, 3 }; // Example rotated sorted array

            int rotationPoint = FindRotationPoint(rotatedArray);

            Console.WriteLine($"The rotation point (index of the smallest element) is at index: {rotationPoint}");
        }

        static int FindRotationPoint(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if mid is the rotation point
                if (mid > 0 && arr[mid] < arr[mid - 1])
                    return mid;

                // If the left half is sorted, the rotation point is in the right half
                if (arr[left] <= arr[mid])
                    left = mid + 1;
                // If the right half is sorted, the rotation point is in the left half
                else
                    right = mid - 1;
            }

            // If no rotation point is found, return -1 (though it shouldn't happen for a rotated sorted array)
            return -1;
        }
    }

}
