using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
   

    class MergeSort
    {
        public static void MergeSortPrices(double[] prices, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortPrices(prices, left, mid);
                MergeSortPrices(prices, mid + 1, right);
                Merge(prices, left, mid, right);
            }
        }

        private static void Merge(double[] prices, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            double[] leftArray = new double[n1];
            double[] rightArray = new double[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = prices[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = prices[mid + 1 + j];

            int k = left, i1 = 0, i2 = 0;
            while (i1 < n1 && i2 < n2)
            {
                if (leftArray[i1] <= rightArray[i2])
                {
                    prices[k] = leftArray[i1];
                    i1++;
                }
                else
                {
                    prices[k] = rightArray[i2];
                    i2++;
                }
                k++;
            }

            while (i1 < n1)
            {
                prices[k] = leftArray[i1];
                i1++;
                k++;
            }

            while (i2 < n2)
            {
                prices[k] = rightArray[i2];
                i2++;
                k++;
            }
        }

        public static void Main()
        {
            double[] bookPrices = { 29.99, 15.50, 42.75, 10.99, 22.30, 35.00 };
            Console.WriteLine("Original Prices: " + string.Join(", ", bookPrices));

            MergeSortPrices(bookPrices, 0, bookPrices.Length - 1);

            Console.WriteLine("Sorted Prices: " + string.Join(", ", bookPrices));
        }
    }

}
