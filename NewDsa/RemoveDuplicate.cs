using System;
using System.Collections.Generic;
using System.Linq;
namespace NewDsa
{
   

    class RemoveDuplicate
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string result = RemoveDuplicates(input);
            Console.WriteLine("String after removing duplicates: " + result);
        }

        static string RemoveDuplicates(string str)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<char> seen = new HashSet<char>();

            foreach (char c in str)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }

}
