using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQueue
{
    internal class Program
    {
        // Method to sort the elements of a queue in ascending order
        static Queue<int> SortQueue(Queue<int> queue)
        {
            // Convert the queue to a list because Queue doesn't support sorting directly
            List<int> list = new List<int>(queue);

            // Sort the list in ascending order
            list.Sort();

            // Create a new queue from the sorted list and return it
            return new Queue<int>(list);
        }

        static void Main(string[] args)
        {
            // Create an array of unsorted numbers
            int[] numbers = { 5, 1, 3, 2, 4 };

            // Initialize a queue with the array elements
            Queue<int> queue = new Queue<int>(numbers);

            // Display the queue before sorting
            Console.WriteLine("Queue Before Sorting: \n");
            Console.WriteLine(string.Join(", ", queue));

            // Call the method to sort the queue
            Queue<int> sortedQueue = SortQueue(queue);

            // Display the queue after sorting
            Console.WriteLine("Queue After Sorting: \n");
            Console.WriteLine(string.Join(", ", sortedQueue));
        }
    }
}
