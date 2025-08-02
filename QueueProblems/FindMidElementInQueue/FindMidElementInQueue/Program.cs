using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMidElementInQueue
{
    internal class Program
    {
        // Function to find the middle element of the queue
        static int FindMidlle(Queue<int> queue)
        {
            // Convert the queue to a list to allow indexing
            List<int> list = new List<int>(queue);

            // Return the element at the middle index
            // If the number of elements is even, this returns the second middle element
            return list[list.Count / 2];
        }

        static void Main(string[] args)
        {
            // Create a queue with even number of elements
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            // Print the middle element
            Console.WriteLine(FindMidlle(queue)); // Output: 4

            // Wait for user to press any key before closing the console
            Console.ReadKey();
        }
    }
}
