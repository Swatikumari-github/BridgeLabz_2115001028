using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
   

    public class GivenSum
    {
        public static bool HasPair(int[] arr, int target)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in arr)
            {
                if (set.Contains(target - num)) return true;
                set.Add(num);
            }
            return false;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the target sum:");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(HasPair(arr, target));
        }
    }

}
