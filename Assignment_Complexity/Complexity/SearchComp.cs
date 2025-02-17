

namespace Complexity
{
    using System;
    using System.Diagnostics;

    class SearchComparison
    {
        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };
            Random random = new Random();

            foreach (int size in sizes)
            {
                int[] data = new int[size];
                for (int i = 0; i < size; i++)
                {
                    data[i] = random.Next();
                }
                int target = data[random.Next(size)];

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                LinearSearch(data, target);
                stopwatch.Stop();
                long linearTime = stopwatch.ElapsedMilliseconds;

                Array.Sort(data);
                stopwatch.Restart();
                BinarySearch(data, target);
                stopwatch.Stop();
                long binaryTime = stopwatch.ElapsedMilliseconds;

                Console.WriteLine($"Dataset Size: {size}");
                Console.WriteLine($"Linear Search Time: {linearTime} ms");
                Console.WriteLine($"Binary Search Time: {binaryTime} ms");
                Console.WriteLine();
            }
        }

        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }

}
