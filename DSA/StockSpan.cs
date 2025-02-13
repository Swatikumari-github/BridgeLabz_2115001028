using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
   

    class StockSpan
    {
        public static int[] SpanCount(int[] prices)
        {
            int[] span = new int[prices.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < prices.Length; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }
                span[i] = stack.Count == 0 ? i + 1 : i - stack.Peek();
                stack.Push(i);
            }
            return span;
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number of stock prices:");
            int n = int.Parse(Console.ReadLine());
            int[] prices = new int[n];
            Console.WriteLine("Enter the stock prices:");
            for (int i = 0; i < n; i++)
            {
                prices[i] = int.Parse(Console.ReadLine());
            }

            int[] span = SpanCount(prices);
            Console.WriteLine("Stock span values:");
            foreach (int s in span)
            {
                Console.Write(s + " ");
            }
        }
    }

}
