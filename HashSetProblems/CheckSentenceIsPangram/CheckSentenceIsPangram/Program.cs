using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CheckSentenceIsPangram
{
    internal class Program
    {
        // This method checks if the input sentence is a pangram
        // A pangram is a sentence that contains every letter of the alphabet at least once
        static bool IsPangram(string sentence)
        {
            // Create a HashSet to store unique letters found in the sentence
            HashSet<char> letters = new HashSet<char>();

            // Convert sentence to lowercase and loop through each character
            foreach (char c in sentence.ToLower())
            {
                // Check if the character is a letter (ignore digits, punctuation, spaces, etc.)
                if (char.IsLetter(c))
                {
                    // Add the letter to the HashSet (duplicates are automatically ignored)
                    letters.Add(c);
                }
            }

            // A pangram must contain all 26 letters of the English alphabet
            return letters.Count == 26;
        }

        static void Main(string[] args)
        {
            // Example sentence to test
            string sentenc = "The quick brown fox jumps over the lazy dog ";

            // Call the IsPangram method and print the result (True or False)
            Console.WriteLine(IsPangram(sentenc));

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
