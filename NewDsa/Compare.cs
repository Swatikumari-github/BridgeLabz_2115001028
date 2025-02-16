using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDsa
{

   

    class Compare
    {
        static void Main()
        {
            int iterations = 100000; // Number of times to concatenate

            Console.WriteLine("Comparing String Concatenation vs StringBuilder Performance...");

            // Measure time taken using string concatenation
            Stopwatch stopwatch = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < iterations; i++)
            {
                str += "a"; // Inefficient due to string immutability
            }
            stopwatch.Stop();
            Console.WriteLine("String concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");

            // Measure time taken using StringBuilder
            stopwatch.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }
            stopwatch.Stop();
            Console.WriteLine("StringBuilder time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }

}
