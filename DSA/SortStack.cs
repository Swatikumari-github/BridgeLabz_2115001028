using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
   

    class SortStackUsingRecursion
    {
        public static void Sort(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int temp = stack.Pop();
                Sort(stack);
                Insert(stack, temp);
            }
        }

        private static void Insert(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }
            int temp = stack.Pop();
            Insert(stack, value);
            stack.Push(temp);
        }

        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(15);
            stack.Push(12);
            stack.Push(44);
            stack.Push(21);

            Sort(stack);
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }

}
