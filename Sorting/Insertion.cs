//using System;
//using System.Collections.Generic;

//namespace Sorting
//{
//    class InsertionSort
//    {
//        public static void Sort(int[] id)
//        {
//            int n = id.Length;
//            for (int i = 1; i < n; i++)
//            {
//                int temp = id[i];
//                int j = i - 1;
//                while (j >= 0 && temp < id[j])
//                {
//                    id[j + 1] = id[j];
//                    j--;
//                }
//                id[j + 1] = temp;
//            }
//        }
//        public static void Display(int[] marks)
//        {
//            for (int i = 0; i < marks.Length; i++)
//            {
//                Console.WriteLine(marks[i]);
//            }

//        }
//        public static void Main(string[] args)
//        {
//            int[] id = { 3, 2, 4, 1 };
//            Display(id);
//            Sort(id);

//            Console.WriteLine("after sorting the id's value");
//            Display(id);
//        }
//    }

//}

