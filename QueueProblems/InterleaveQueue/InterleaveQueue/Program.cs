using System;
using System.Collections.Generic;

namespace InterleaveQueue
{
    internal class Program
    {
        // Method to interleave the queue elements
        static void InterleaveQueue(Queue<int> queue)
        {
            // Step 1: Calculate half of the queue size
            int halfSize = queue.Count / 2;

            // Step 2: Create a queue to store the first half
            Queue<int> FirstHalf = new Queue<int>();

            // Step 3: Move first half of elements from 'queue' to 'FirstHalf'
            // Initial queue: 1, 2, 3, 4, 5, 6
            for (int i = 0; i < halfSize; i++)
            {
                FirstHalf.Enqueue(queue.Dequeue());
            }

            // Now:
            // FirstHalf: 1, 2, 3
            // queue: 4, 5, 6

            // Step 4: Interleave the two halves
            while (FirstHalf.Count > 0)
            {
                // Add one element from the first half to the queue
                queue.Enqueue(FirstHalf.Dequeue());
                // queue after adding from first half (e.g., add 1): 4, 5, 6, 1

                // Add one element from the second half (still in the original queue front)
                queue.Enqueue(queue.Dequeue());
                // queue after removing front (e.g., 4) and adding it to end: 5, 6, 1, 4

                // After full loop (first iteration):
                // FirstHalf: 2, 3
                // queue: 5, 6, 1, 4
            }

            // Final interleaved queue: 1, 4, 2, 5, 3, 6
        }

        static void Main(string[] args)
        {
            // Step 0: Create a queue with even number of elements
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            // Before interleaving:
            // queue: 1, 2, 3, 4, 5, 6

            // Step 5: Call the method to interleave the queue
            InterleaveQueue(queue);

            // Step 6: Print the final queue
            Console.WriteLine(string.Join(", ", queue)); // Output: 1, 4, 2, 5, 3, 6

            Console.ReadKey();
        }
    }
}
