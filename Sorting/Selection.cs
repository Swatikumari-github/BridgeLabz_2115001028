using System;
using System.Collections.Generic;


namespace Sorting
{
    class SelctionSort
    {
        public static void Sort(int[] marks)
        {
            int n = marks.Length;
            for(int i = 0; i < n-1; i++)
            {
                int min = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (marks[j] < marks[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = marks[min];
                    marks[min] = marks[i];
                    marks[i] = temp;
                }
            }
        }
        public static void Display(int[] marks)
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

        }
        public static void Main(string[] args)
        {
            int[] marks = { 3, 2, 4, 1 };
            Display(marks);
            Sort(marks);

            Console.WriteLine("after sorting the id's value");
            Display(marks);
        }
    }
}
