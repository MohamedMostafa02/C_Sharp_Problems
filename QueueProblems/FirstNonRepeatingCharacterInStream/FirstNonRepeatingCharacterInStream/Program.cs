using System;
using System.Collections.Generic;

namespace FirstNonRepeatingCharacterInStream
{
    internal class Program
    {
        // Method to find and print the first non-repeating character
        // in a stream of characters at each step
        static void FindFirstNonRepeating(string stream)
        {
            // Dictionary to keep count of each character's occurrences
            Dictionary<char, int> countMap = new Dictionary<char, int>();

            // Queue to keep track of characters in the order they appear
            Queue<char> queue = new Queue<char>();

            // Iterate over each character in the input stream
            foreach (char c in stream)
            {
                // If this character is not yet in the dictionary, initialize its count to 0
                if (!countMap.ContainsKey(c))
                    countMap[c] = 0;

                // Increment the count of the current character
                countMap[c]++;

                // Add the current character to the queue
                queue.Enqueue(c);

                // Remove characters from the front of the queue if they have appeared more than once
                while (queue.Count > 0 && countMap[queue.Peek()] > 1)
                {
                    queue.Dequeue();
                }

                // Print the first non-repeating character if there is one,
                // otherwise print '-' indicating no non-repeating character currently
                Console.WriteLine(queue.Count > 0 ? queue.Peek() : '-');
            }
        }

        static void Main(string[] args)
        {
            // Example usage: find first non-repeating character for the input string "aabc"
            FindFirstNonRepeating("aabc");

            // Wait for a key press to keep the console window open
            Console.ReadKey();
        }
    }
}
