using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    
    class BinaryNumberGenerator
    {
        // Method to generate the first N binary numbers
        public static void GenerateBinaryNumbers(int N)
        {
            // Create a queue to store binary numbers as strings
            Queue<string> queue = new Queue<string>();

            // Enqueue the first binary number "1"
            queue.Enqueue("1");

            // Process the queue and generate binary numbers
            for (int i = 0; i < N; i++)
            {
                // Dequeue the front binary number
                string current = queue.Dequeue();

                // Print the current binary number
                Console.Write(current + " ");

                // Enqueue the next binary numbers formed by appending "0" and "1"
                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }
        }

        // Main method

    }
