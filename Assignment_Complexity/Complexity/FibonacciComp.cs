

namespace Complexity
{
    using System;
    using System.Diagnostics;

    class FibonacciComparison
    {
        static void Main()
        {
            int num = 100;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            int recursiveResult = FibonacciRecursive(num);
            stopwatch.Stop();
            long recursiveTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();
            int iterativeResult = FibonacciIterative(num);
            stopwatch.Stop();
            long iterativeTime = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Fibonacci({num}) Recursive Result: {recursiveResult}");
            Console.WriteLine($"Recursive Time: {recursiveTime} ms");
            Console.WriteLine($"Fibonacci({num}) Iterative Result: {iterativeResult}");
            Console.WriteLine($"Iterative Time: {iterativeTime} ms");
        }

        static int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static int FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }

}
