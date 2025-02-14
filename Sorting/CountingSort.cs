using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    using System;

    class CountingSort
    {
        public static void CountingSortAges(int[] ages)
        {
            int minAge = 10, maxAge = 18;
            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            int[] output = new int[ages.Length];

            foreach (int age in ages)
                count[age - minAge]++;

            for (int i = 1; i < range; i++)
                count[i] += count[i - 1];

            for (int i = ages.Length - 1; i >= 0; i--)
            {
                output[count[ages[i] - minAge] - 1] = ages[i];
                count[ages[i] - minAge]--;
            }

            for (int i = 0; i < ages.Length; i++)
                ages[i] = output[i];
        }

        public static void Main()
        {
            int[] studentAges = { 12, 14, 11, 10, 18, 13, 15, 17, 16, 12, 14 };
            Console.WriteLine("Original Ages: " + string.Join(", ", studentAges));

            CountingSortAges(studentAges);

            Console.WriteLine("Sorted Ages: " + string.Join(", ", studentAges));
        }
    }

}
