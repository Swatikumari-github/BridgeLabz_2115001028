namespace Complexity
{
    using System;
    using System.Diagnostics;
    using System.Text;

    class StringConcatenationComparison
    {
        static void Main()
        {
            int size = 1000000;
            Random random = new Random();
            string[] data = new string[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = random.Next().ToString();
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            ConcatenateWithString(data);
            stopwatch.Stop();
            Console.WriteLine("String Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");

            stopwatch.Restart();
            ConcatenateWithStringBuilder(data);
            stopwatch.Stop();
            Console.WriteLine("StringBuilder Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");

            stopwatch.Restart();
            ConcatenateWithStringBuffer(data);
            stopwatch.Stop();
            Console.WriteLine("StringBuffer (StringBuilder in C#) Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        static string ConcatenateWithString(string[] data)
        {
            string result = "";
            foreach (string s in data)
            {
                result += s;
            }
            return result;
        }

        static string ConcatenateWithStringBuilder(string[] data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in data)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }

        static string ConcatenateWithStringBuffer(string[] data)
        {
            return ConcatenateWithStringBuilder(data); // StringBuffer is not a separate class in C#, StringBuilder serves the same purpose
        }
    }

}
