using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheFrequencyOfCharacter
{
    internal class Program
    {
        // Method to calculate the frequency of each character in a string
        static Dictionary<char, int> CharacterFrequency(string input)
        {
            // Create a dictionary to store character counts
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            // Loop through each character in the input string
            foreach (char c in input)
            {
                // If the character already exists in the dictionary, increment its count
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    // If the character is not in the dictionary, add it with count 1
                    frequency[c] = 1;
                }
            }

            // Return the dictionary containing character frequencies
            return frequency;
        }

        static void Main(string[] args)
        {
            // Define an input string
            string input = "hello";

            // Call the method to get the frequency of each character
            var result = CharacterFrequency(input);

            // Print each character and its frequency
            foreach (var c in result)
            {
                Console.WriteLine($"{c.Key}: {c.Value}");
            }

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
