using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicateElements
{
    internal class Program
    {
        // Method to find duplicate elements in an array
        static List<int> FindDublicates(int[] nums)
        {
            // Dictionary to store the frequency of each number
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // List to store the numbers that appear more than once
            List<int> duplicates = new List<int>();

            // Loop through each number in the array
            foreach (int num in nums)
            {
                // If the number already exists in the dictionary
                if (counts.ContainsKey(num))
                {
                    // Increment its count
                    counts[num]++;

                    // If it appears exactly twice, add it to the duplicates list
                    if (counts[num] == 2)
                    {
                        duplicates.Add(num);
                    }
                }
                else
                {
                    // If it's the first time we see this number, set count to 1
                    counts[num] = 1;
                }
            }

            // Return the list of duplicates
            return duplicates;
        }

        static void Main(string[] args)
        {
            // Input array with some duplicates
            int[] nums = { 1, 2, 3, 4, 2, 5, 6, 1 };

            // Call the method and print the duplicates
            Console.WriteLine(string.Join(", ", FindDublicates(nums)));

            // Keep the console window open
            Console.ReadKey();
        }
    }
}
