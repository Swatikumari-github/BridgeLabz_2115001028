using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
   
    class ReverseQueu
    {
        // Recursive function to reverse a queue
        static void ReverseQueue(Queue<int> queue)
        {
            // Base case: if the queue is empty, do nothing
            if (queue.Count == 0)
            {
                return;
            }

            // Remove the front element
            int frontElement = queue.Dequeue();

            // Reverse the rest of the queue
            ReverseQueue(queue);

            // Add the front element back to the queue after reversing
            queue.Enqueue(frontElement);
        }

        static void Main()
        {
            // Define a queue with elements
            Queue<int> numberQueue = new Queue<int>();
            numberQueue.Enqueue(10);
            numberQueue.Enqueue(20);
            numberQueue.Enqueue(30);

            // Reverse the queue
            ReverseQueue(numberQueue);

            // Output the reversed queue
            Console.WriteLine("Reversed Queue: ");
            foreach (int item in numberQueue)
            {
                Console.WriteLine(item);
            }
        }
    }

}
