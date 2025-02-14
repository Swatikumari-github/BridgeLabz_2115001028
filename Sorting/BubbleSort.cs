//using System;
//namespace Sorting
//{
//    class BubbleSort
//    {
//        public static void Sort(int[] marks)
//        {
//            int n = marks.Length;
//            for (int i = 0; i < n - 1; i++)

//            {
//                int flag = 0;
//                for (int j = 0; j < n - 1 - i; j++)
//                {
//                    if (marks[j] > marks[j + 1])
//                    {
//                        int temp = marks[j];
//                        marks[j] = marks[j + 1];
//                        marks[j + 1] = temp;
//                        flag = 1;
//                    }
//                }
//                if (flag == 0)
//                {
//                    break;
//                }
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
//            int[] marks = { 3, 2, 4, 1 };
//            Display(marks);
//            Sort(marks);

//            Console.WriteLine("after sorting the marks value");
//            Display(marks);
//        }
//    }
//}
