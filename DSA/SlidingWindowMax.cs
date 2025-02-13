using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    

    class SlidingWindowMax
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] result = new int[nums.Length - k + 1];
            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (deque.Count > 0 && deque.First.Value == i - k)
                {
                    deque.RemoveFirst();
                }
                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                {
                    deque.RemoveLast();
                }
                deque.AddLast(i);
                if (i >= k - 1)
                {
                    result[i - k + 1] = nums[deque.First.Value];
                }
            }
            return result;
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

            Console.WriteLine("Enter the window size:");
            int k = int.Parse(Console.ReadLine());

            int[] result = MaxSlidingWindow(nums, k);
            Console.WriteLine("Sliding window maximum values:");
            Console.WriteLine(string.Join(" ", result));
        }
    }

}
