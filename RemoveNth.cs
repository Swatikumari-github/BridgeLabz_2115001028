using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
   

    class Node
    {
        public char Data;
        public Node Next;

        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }

    class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        // Add a new node at the end
        public void Add(char data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        // Find the Nth node from the end
        public Node FindNthFromEnd(int n)
        {
            Node fast = Head;
            Node slow = Head;

            // Move the fast pointer N steps ahead
            for (int i = 0; i < n; i++)
            {
                if (fast == null)
                    return null; // If n is larger than the size of the list
                fast = fast.Next;
            }

            // Move both pointers one step at a time until fast reaches the end
            while (fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            return slow; // slow will be pointing to the Nth node from the end
        }
    }

    class Program
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            list.Add('A');
            list.Add('B');
            list.Add('C');
            list.Add('D');
            list.Add('E');

            int N = 2;
            Node result = list.FindNthFromEnd(N);

            if (result != null)
            {
                Console.WriteLine($"The {N}th element from the end is: {result.Data}");
            }
            else
            {
                Console.WriteLine("The list is shorter than N.");
            }
        }
    }

}
