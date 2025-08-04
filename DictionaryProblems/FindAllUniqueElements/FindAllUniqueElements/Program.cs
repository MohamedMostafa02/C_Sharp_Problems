using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllUniqueElements
{
    internal class Program
    {
        // Method to find all elements that appear exactly once in the array
        static List<int> FindUniqueElements(int[] nums)
        {
            // Dictionary to count occurrences of each number
            Dictionary<int, int> counts = new Dictionary<int, int>();
            // List to store unique elements
            List<int> unique = new List<int>();

            // Count the occurrences of each number
            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            // Add numbers that appeared only once to the unique list
            foreach (var kvp in counts)
            {
                if (kvp.Value == 1)
                    unique.Add(kvp.Key);
            }

            return unique;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 3, 4, 5, 3 };

            // Print the unique elements, separated by commas
            Console.WriteLine(string.Join(", ", FindUniqueElements(nums)));
        }
    }
}
