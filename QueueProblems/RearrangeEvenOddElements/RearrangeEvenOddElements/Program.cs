using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangeEvenOddElements
{
    internal class Program
    {
        // This method rearranges the elements in the queue by placing all even numbers first, then odd numbers
        static Queue<int> RearrangeEven_Odd(Queue<int> queue)
        {
            Queue<int> even = new Queue<int>(); // Queue to store even numbers
            Queue<int> odd = new Queue<int>();  // Queue to store odd numbers

            // Separate the elements into even and odd queues
            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    even.Enqueue(queue.Dequeue()); // Move even number to 'even' queue
                }
                else
                {
                    odd.Enqueue(queue.Dequeue());  // Move odd number to 'odd' queue
                }
            }

            // Add all even numbers back into the original queue
            while (even.Count > 0)
            {
                queue.Enqueue(even.Dequeue());
            }

            // Add all odd numbers after the even numbers
            while (odd.Count > 0)
            {
                queue.Enqueue(odd.Dequeue());
            }

            return queue; // Return the rearranged queue
        }

        static void Main(string[] args)
        {
            // Initialize the original queue with a mix of even and odd numbers
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            // Call the method to rearrange even and odd numbers
            Queue<int> Arranged = RearrangeEven_Odd(queue);

            // Print the rearranged queue: even numbers come first, then odd numbers
            Console.WriteLine(string.Join(", ", Arranged)); // Output: 2, 4, 6, 1, 3, 5

            Console.ReadKey();
        }
    }
}
