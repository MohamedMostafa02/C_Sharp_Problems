using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPeriorityQueue
{
    // Class that implements a basic priority queue using a SortedDictionary
    class PriorityQueue
    {
        // Dictionary to hold priority as key and a queue of values as the value
        private SortedDictionary<int, Queue<int>> queue = new SortedDictionary<int, Queue<int>>();

        // Add an element with a specific priority
        public void Enqueue(int value, int priority)
        {
            // Check if the priority key exists; if not, create a new queue for it
            if (!queue.ContainsKey(priority))
            {
                queue[priority] = new Queue<int>();
            }

            // Enqueue the value in the queue of the given priority
            queue[priority].Enqueue(value);
        }

        // Remove and return the element with the highest priority (lowest key value)
        public int? Dequeue()
        {
            // If the queue is empty, return null
            if (queue.Count == 0) return null;

            // Get the smallest (highest) priority key
            int highestPriority = queue.Keys.Min();

            // Dequeue the value from the queue at that priority
            int value = queue[highestPriority].Dequeue();

            // If the queue at that priority becomes empty, remove the priority key
            if (queue[highestPriority].Count == 0)
            {
                queue.Remove(highestPriority);
            }

            // Return the dequeued value
            return value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue pq = new PriorityQueue();

            // Add elements with different priorities
            pq.Enqueue(10, 3);  // Priority 3
            pq.Enqueue(5, 1);   // Priority 1 (highest)
            pq.Enqueue(20, 2);  // Priority 2

            // This will dequeue the element with the highest priority (lowest number), which is 5
            Console.WriteLine(pq.Dequeue());  // Output: 5

            Console.ReadKey();
        }
    }
}
