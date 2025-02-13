using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    

    public class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>();
            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                    map[num] = true;
            }
            int longest = 0;

            foreach (int num in nums)
            {
                if (!map.ContainsKey(num - 1))
                {
                    int curr = num;
                    int count = 1;
                    while (map.ContainsKey(curr + 1))
                    {
                        curr++;
                        count++;
                    }
                    longest = Math.Max(longest, count);
                }
            }
            return longest;
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number of elements:");
            int length = int.Parse(Console.ReadLine());
            int[] nums = new int[length];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(LongestConsecutive(nums));
        }
    }

}
