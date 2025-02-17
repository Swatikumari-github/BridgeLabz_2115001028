

namespace Complexity
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    class DataStructureSearchComparison
    {
        static void Main()
        {
            int[] sizes = { 1000, 100000, 1000000 };
            Random random = new Random();

            foreach (int size in sizes)
            {
                int[] data = new int[size];
                for (int i = 0; i < size; i++)
                {
                    data[i] = random.Next();
                }
                int target = data[random.Next(size)];

                List<int> arrayList = new List<int>(data);
                HashSet<int> hashSet = new HashSet<int>(data);
                SortedSet<int> treeSet = new SortedSet<int>(data);

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                arrayList.Contains(target);
                stopwatch.Stop();
                long arrayTime = stopwatch.ElapsedMilliseconds;

                stopwatch.Restart();
                hashSet.Contains(target);
                stopwatch.Stop();
                long hashSetTime = stopwatch.ElapsedMilliseconds;

                stopwatch.Restart();
                treeSet.Contains(target);
                stopwatch.Stop();
                long treeSetTime = stopwatch.ElapsedMilliseconds;

                Console.WriteLine("Dataset Size: " + size);
                Console.WriteLine("Array Search Time: " + arrayTime + " ms");
                Console.WriteLine("HashSet Search Time: " + hashSetTime + " ms");
                Console.WriteLine("TreeSet Search Time: " + treeSetTime + " ms");
                Console.WriteLine();
            }
        }
    }

}
