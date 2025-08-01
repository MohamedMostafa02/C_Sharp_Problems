using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateQueue
{
    internal class Program
    {
        // Method to rotate a queue to the left by 'index' positions
        static void RotateQueue(Queue<int> queue, int index)
        {
            // Rotate the queue 'index' times
            while (index > 0)
            {
                // Remove the front element and add it to the rear
                queue.Enqueue(queue.Dequeue());

                // Decrease the number of remaining rotations
                index--;
            }
        }

        static void Main(string[] args)
        {
            // Create a queue with elements 1 to 5
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });

            // Rotate the queue 2 times to the left
            // Expected result: [3, 4, 5, 1, 2]
            RotateQueue(queue, 2);

            // Print the elements in the queue after rotation
            Console.WriteLine(string.Join(",", queue));

            // Wait for a key press before closing the program
            Console.ReadKey();
        }
    }
}
