using System;
using System.Collections.Generic;

namespace RearrangeQueueAlternately
{
    internal class Program
    {
        // Method 1: Using List – Easy to understand, simple indexing
        static Queue<int> RearrangeAlternately(Queue<int> queue)
        {
            List<int> list = new List<int>(queue); // Convert queue to list for index access
            Queue<int> result = new Queue<int>();

            int start = 0;               // Points to the front
            int end = list.Count - 1;    // Points to the back

            while (start <= end)
            {
                if (start == end)
                {
                    result.Enqueue(list[start]); // Add the middle element once if odd
                }
                else
                {
                    result.Enqueue(list[start]); // Front element
                    result.Enqueue(list[end]);   // Back element
                }
                start++;
                end--;
            }

            return result;
        }

        // Method 2: Using Stack and Queue only – space efficient
        static Queue<int> RearrangeAlternately2(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            int n = queue.Count;
            int secondHalf = n - n / 2; // Number of elements in the second half

            // Step 1: Rotate first half to back to bring second half to front
            for (int i = 0; i < n / 2; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            // Step 2: Push second half into stack (to reverse it)
            for (int i = 0; i < secondHalf; i++)
            {
                stack.Push(queue.Dequeue());
            }

            // Step 3: Alternate pushing front and back elements
            for (int i = 0; i < n / 2; i++)
            {
                queue.Enqueue(queue.Dequeue()); // Front element
                queue.Enqueue(stack.Pop());     // Back element (reversed from stack)
            }

            // Step 4: If odd size, add the middle element
            if (n % 2 != 0)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            // Method 1 - Using List
            Queue<int> RearrangedQueue1 = RearrangeAlternately(queue);

            // Method 2 - Using Stack (in-place modification)
            Queue<int> RearrangedQueue2 = RearrangeAlternately2(new Queue<int>(queue)); // Re-copy for fair comparison

            Console.WriteLine("Using First Method (List-based):");
            Console.WriteLine(string.Join(", ", RearrangedQueue1));

            Console.WriteLine("Using Second Method (Stack-based, in-place):");
            Console.WriteLine(string.Join(", ", RearrangedQueue2));

            Console.ReadKey();
        }
    }
}
