using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWordsTypedUsingOneRowOfKeyboard
{
    internal class Program
    {
        // Function to find words that can be typed using letters from one row of the keyboard
        static string[] FindWords(string[] words)
        {
            // Define the three rows of a QWERTY keyboard
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };

            // Dictionary to map each character to its corresponding row index (0, 1, or 2)
            Dictionary<char, int> charRow = new Dictionary<char, int>();

            // Populate the dictionary with characters and their corresponding row index
            for (int i = 0; i < rows.Length; i++)
            {
                foreach (char c in rows[i])
                {
                    charRow[c] = i;
                }
            }

            // List to store valid words that can be typed using one row
            List<string> result = new List<string>();

            // Check each word
            foreach (var word in words)
            {
                // Get the row of the first letter (converted to lowercase)
                int row = charRow[char.ToLower(word[0])];
                bool isValid = true;

                // Check if all characters in the word belong to the same row
                foreach (char c in word)
                {
                    if (charRow[char.ToLower(c)] != row)
                    {
                        isValid = false;
                        break; // Exit the loop if a letter from a different row is found
                    }
                }

                // If the word is valid (all letters from same row), add it to result
                if (isValid)
                    result.Add(word);
            }

            // Return the valid words as an array
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            // Example input
            string[] words = { "Hello", "Alaska", "Dad", "Peace" };

            // Output the words that can be typed using one keyboard row
            Console.WriteLine(string.Join(", ", FindWords(words)));
        }
    }
}
