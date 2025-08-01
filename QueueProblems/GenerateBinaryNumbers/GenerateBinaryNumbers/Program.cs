using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateBinaryNumbers
{
    internal class Program
    {
        // Method to generate the first 'n' binary numbers using a queue (BFS-like approach)
        static void GenerateBinaryNumbers(int n)
        {
            // check the n is more than 0
            if (n <= 0)
            {
                Console.WriteLine("No binary numbers to generate.");
                return;
            }

            // Create a queue to hold binary numbers
            Queue<string> queue = new Queue<string>();

            // Start by enqueueing the first binary number "1"
            queue.Enqueue("1");

            // Generate 'n' binary numbers
            for (int i = 0; i < n; i++)
            {
                // Dequeue the front element
                string binary = queue.Dequeue();

                // Print the current binary number
                Console.WriteLine(binary);

                // Enqueue the next two binary numbers by appending "0" and "1"
                queue.Enqueue(binary + "0");
                queue.Enqueue(binary + "1");
            }

            // Clear the queue after use
            queue.Clear();
        }

        static void Main(string[] args)
        {
            // Call the method to generate binary numbers from 1 to 5
            GenerateBinaryNumbers(5);

            Console.ReadKey(); // Wait for key press before closing
        }
    }
}
