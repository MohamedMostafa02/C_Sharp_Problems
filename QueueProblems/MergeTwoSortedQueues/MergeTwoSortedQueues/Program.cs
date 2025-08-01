using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedQueues
{
    internal class Program
    {
        // This method merges two sorted queues into one sorted queue
        // NOTE: Both input queues must be sorted in ascending order
        static Queue<int> MergeQueues(Queue<int> q1, Queue<int> q2)
        {
            // Create a new queue to store the merged result
            Queue<int> result = new Queue<int>();

            // Compare elements from both queues and add the smallest to the result
            while (q1.Count > 0 && q2.Count > 0)
            {
                if (q1.Peek() <= q2.Peek())
                {
                    result.Enqueue(q1.Dequeue()); // Add from q1 if it's smaller
                }
                else
                {
                    result.Enqueue(q2.Dequeue()); // Add from q2 if it's smaller
                }
            }

            // If any elements are left in q1, add them to the result
            while (q1.Count > 0)
            {
                result.Enqueue(q1.Dequeue());
            }

            // If any elements are left in q2, add them to the result
            while (q2.Count > 0)
            {
                result.Enqueue(q2.Dequeue());
            }

            // Return the merged sorted queue
            return result;
        }

        static void Main(string[] args)
        {
            // Define two sorted queues
            Queue<int> q1 = new Queue<int>(new[] { 1, 3, 5 });
            Queue<int> q2 = new Queue<int>(new[] { 2, 4, 6 });

            // Merge the two queues
            Queue<int> result = MergeQueues(q1, q2);

            // Print the merged queue
            Console.WriteLine(string.Join(", ", result));

            Console.ReadKey(); // Wait for key press before exiting
        }
    }
}
