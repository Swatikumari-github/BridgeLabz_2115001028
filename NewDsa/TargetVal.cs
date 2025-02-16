using System;
using System.Collections.Generic;
using System.Linq;


namespace NewDsa
{
   

    class TargetVal
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 4, 7, 11 },
            { 2, 5, 8, 12 },
            { 3, 6, 9, 16 },
            { 10, 13, 14, 17 }
        }; // Example sorted matrix

            int target = 5; // Target value to search for

            bool found = SearchMatrix(matrix, target);

            if (found)
                Console.WriteLine($"Target value {target} found in the matrix.");
            else
                Console.WriteLine($"Target value {target} not found in the matrix.");
        }

        static bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int left = 0;
            int right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Convert mid index to 2D matrix coordinates
                int midElement = matrix[mid / cols, mid % cols];

                if (midElement == target)
                    return true; // Found the target
                else if (midElement < target)
                    left = mid + 1; // Search in the right half
                else
                    right = mid - 1; // Search in the left half
            }

            return false; // Target not found
        }
    }

}
