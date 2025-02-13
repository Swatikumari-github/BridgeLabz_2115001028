using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    

    public class ZeroSumSubarrays
    {
        public static void FindSubarrays(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum == 0 || map.ContainsKey(sum))
                {
                    Console.WriteLine("Subarray Found with Zero sum from index " + (map.ContainsKey(sum) ? map[sum] + 1 : 0) + " to " + i);
                }
                if (!map.ContainsKey(sum))
                {
                    map[sum] = i;
                }
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number of elements:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            FindSubarrays(arr);
        }
    }

}
