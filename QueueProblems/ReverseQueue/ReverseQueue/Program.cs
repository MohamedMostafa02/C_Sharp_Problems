using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseQueue
{
    internal class Program
    {
        // Method to reverse the elements of a queue using a stack
        static Queue<int> ReverseQueue(Queue<int> queue)
        {
            // Create a stack to temporarily hold the queue elements
            Stack<int> stack = new Stack<int>();

            // Dequeue all elements from the queue and push them onto the stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            // Pop all elements from the stack and enqueue them back to the queue
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            // Return the reversed queue
            return queue;
        }

        static void Main(string[] args)
        {
            // Initialize an array of integers
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Create a queue and fill it with the array elements
            Queue<int> queue = new Queue<int>(numbers);

            // Reverse the queue using the ReverseQueue method
            Queue<int> ReversedQueue = ReverseQueue(queue);

            // Print the reversed queue as comma-separated values
            Console.WriteLine(string.Join(", ", ReversedQueue));

            // Wait for user to press a key before closing the console
            Console.ReadKey();
        }
    }
}
