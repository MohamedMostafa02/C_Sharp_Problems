using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordFrequenciesInText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The input text to analyze
            string text = "hello world hello universe";

            // Dictionary to store each word and its frequency count
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Split the text into words based on space and count each word
            foreach (string word in text.Split(' '))
            {
                // If the word is already in the dictionary, increment its count
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    // If the word is not in the dictionary, add it with a count of 1
                    wordCount[word] = 1;
                }
            }

            // Print each word and its frequency
            foreach (var word in wordCount)
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
            }

            // Wait for user input before closing the console
            Console.ReadKey();
        }
    }
}
