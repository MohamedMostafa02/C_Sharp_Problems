using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneQueueUsingRecursion
{
    internal class Program
    {
        // Recursive method to clone a queue without using extra space (except recursion stack)
        static Queue<int> CloneQueue(Queue<int> queue)
        {
            // Base case: if the queue is empty, return a new empty queue
            if (queue.Count == 0) return new Queue<int>();

            // Remove the front element
            int front = queue.Dequeue();

            // Recursively clone the remaining queue
            Queue<int> clone = CloneQueue(queue);

            // After recursion: put the front element back in the original queue
            queue.Enqueue(front);

            // Also enqueue the element into the cloned queue
            clone.Enqueue(front);

            // Return the cloned queue
            return clone;
        }

        static void Main(string[] args)
        {
            // Initialize the original queue with sample values
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4 });

            // Call the recursive clone function
            Queue<int> clonedQueue = CloneQueue(queue);

            // Display both the cloned and original queues
            Console.WriteLine("Cloned Queue: " + string.Join(", ", clonedQueue));
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            Console.ReadKey();
        }
    }
}
