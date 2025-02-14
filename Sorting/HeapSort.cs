using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    using System;

    class HeapSort
    {
        public static void HeapSortSalaries(double[] salaries)
        {
            int n = salaries.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salaries, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                Swap(salaries, 0, i);
                Heapify(salaries, i, 0);
            }
        }

        private static void Heapify(double[] salaries, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && salaries[left] > salaries[largest])
                largest = left;

            if (right < n && salaries[right] > salaries[largest])
                largest = right;

            if (largest != i)
            {
                Swap(salaries, i, largest);
                Heapify(salaries, n, largest);
            }
        }

        private static void Swap(double[] salaries, int i, int j)
        {
            double temp = salaries[i];
            salaries[i] = salaries[j];
            salaries[j] = temp;
        }

        public static void Main()
        {
            double[] salaryDemands = { 55000, 70000, 50000, 80000, 65000, 60000 };
            Console.WriteLine("Original Salary Demands: " + string.Join(", ", salaryDemands));

            HeapSortSalaries(salaryDemands);

            Console.WriteLine("Sorted Salary Demands: " + string.Join(", ", salaryDemands));
        }
    }
}
