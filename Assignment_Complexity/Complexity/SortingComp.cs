

namespace Complexity
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    class SortingComparison
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

                int[] dataCopy1 = (int[])data.Clone();
                int[] dataCopy2 = (int[])data.Clone();

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                BubbleSort(data);
                stopwatch.Stop();
                long bubbleTime = stopwatch.ElapsedMilliseconds;

                stopwatch.Restart();
                MergeSort(dataCopy1);
                stopwatch.Stop();
                long mergeTime = stopwatch.ElapsedMilliseconds;

                stopwatch.Restart();
                QuickSort(dataCopy2, 0, dataCopy2.Length - 1);
                stopwatch.Stop();
                long quickTime = stopwatch.ElapsedMilliseconds;

                Console.WriteLine($"Dataset Size: {size}");
                Console.WriteLine($"Bubble Sort Time: {bubbleTime} ms");
                Console.WriteLine($"Merge Sort Time: {mergeTime} ms");
                Console.WriteLine($"Quick Sort Time: {quickTime} ms");
                Console.WriteLine();
            }
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }

        static void MergeSort(int[] arr)
        {
            if (arr.Length < 2) return;
            int mid = arr.Length / 2;
            int[] left = arr.Take(mid).ToArray();
            int[] right = arr.Skip(mid).ToArray();
            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);
        }

        static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                arr[k++] = left[i] <= right[j] ? left[i++] : right[j++];
            }
            while (i < left.Length) arr[k++] = left[i++];
            while (j < right.Length) arr[k++] = right[j++];
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
    }

}
