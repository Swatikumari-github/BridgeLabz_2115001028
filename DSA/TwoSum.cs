using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
   

    public class TwoSum
    {
        public static int[] Find(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return null;
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

            Console.WriteLine("Enter the target:");
            int target = int.Parse(Console.ReadLine());

            int[] result = Find(nums, target);
            Console.WriteLine(result != null ? string.Join(", ", result) : "No solution found");
        }
    }

}
