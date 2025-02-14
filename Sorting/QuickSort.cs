using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    using System;

    class QuickSort
    {
        public static void QuickSortPrices(double[] prices, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(prices, low, high);
                QuickSortPrices(prices, low, pivotIndex - 1);
                QuickSortPrices(prices, pivotIndex + 1, high);
            }
        }

        private static int Partition(double[] prices, int low, int high)
        {
            double pivot = prices[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (prices[j] <= pivot)
                {
                    i++;
                    Swap(prices, i, j);
                }
            }
            Swap(prices, i + 1, high);
            return i + 1;
        }

        private static void Swap(double[] prices, int i, int j)
        {
            double temp = prices[i];
            prices[i] = prices[j];
            prices[j] = temp;
        }

        public static void Main()
        {
            double[] productPrices = { 49.99, 19.99, 79.50, 5.99, 34.75, 60.00 };
            Console.WriteLine("Original Prices: " + string.Join(", ", productPrices));

            QuickSortPrices(productPrices, 0, productPrices.Length - 1);

            Console.WriteLine("Sorted Prices: " + string.Join(", ", productPrices));
        }
    }

}
