using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeQueue
{
    internal class Program
    {
        // Method to check if the contents of a queue form a palindrome
        static bool IsPalindromQueue(Queue<int> queue)
        {
            // Create a stack and initialize it with the same elements as the queue
            Stack<int> stack = new Stack<int>(queue);

            // Compare each element in the queue with the top of the stack
            foreach (var item in queue)
            {
                // If any pair of elements doesn't match, it's not a palindrome
                if (stack.Pop() != item)
                    return false;
            }

            // All elements matched in reverse order, so it's a palindrome
            return true;
        }

        static void Main(string[] args)
        {
            // Define an array representing a palindrome sequence
            int[] numbers = { 1, 2, 3, 2, 1 };

            // Create a queue and fill it with the numbers
            Queue<int> queue = new Queue<int>(numbers);

            // Check if the queue is a palindrome and print the result
            if (IsPalindromQueue(queue))
                Console.WriteLine("The Queue is palindrome...");
            else
                Console.WriteLine("The Queue isn't palindrome...");

            // Optional: Wait for a key press before closing
            Console.ReadKey();
        }
    }
}
