using System;
using System.Collections.Generic;
using System.Linq;


namespace NewDsa
{
   

    class Concatenate
    {
        static void Main()
        {
            string[] words = { "Hello", " ", "World", "!", " ", "How", " ", "are", " ", "you", "?" };

            string result = ConcatenateStrings(words);
            Console.WriteLine("Concatenated String: " + result);
        }

        static string ConcatenateStrings(string[] strings)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string str in strings)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }
    }

}
