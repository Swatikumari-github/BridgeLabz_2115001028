namespace Colections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class ReverseList
    {
        // Reverse an ArrayList
        static ArrayList ReverseArrayList(ArrayList numList)
        {
            int start = 0, end = numList.Count - 1;
            while (start < end)
            {
                // Swap elements
                object temp = numList[start];
                numList[start] = numList[end];
                numList[end] = temp;

                start++;
                end--;
            }
            return numList;
        }

        // Reverse a LinkedList
        static LinkedList<int> ReverseLinkedList(LinkedList<int> numLinkedList)
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int element in numLinkedList)
            {
                reversedList.AddFirst(element);
            }
            return reversedList;
        }

        static void Main()
        {
            // Test for ArrayList
            ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original ArrayList: " + string.Join(", ", numbers.ToArray()));
            ReverseArrayList(numbers);
            Console.WriteLine("Reversed ArrayList: " + string.Join(", ", numbers.ToArray()));

            // Test for LinkedList
            LinkedList<int> numSequence = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("\nOriginal LinkedList: " + string.Join(", ", numSequence));
            LinkedList<int> reversedSequence = ReverseLinkedList(numSequence);
            Console.WriteLine("Reversed LinkedList: " + string.Join(", ", reversedSequence));
        }
    }

}
