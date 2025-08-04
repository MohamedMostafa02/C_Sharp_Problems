using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMajorityElement
{
    internal class Program
    {
        // Method to find the majority element in an array
        static int MajorityElement(int[] nums)
        {
            // Dictionary to store frequency of each element
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // The number of times an element must appear to be the majority
            int majorityCount = nums.Length / 2;

            // Iterate through each number in the array
            foreach (int num in nums)
            {
                // If number already exists in the dictionary, increment its count
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    // Otherwise, add it with count 1
                    counts[num] = 1;

                // If current number's count exceeds majority threshold, return it
                if (counts[num] > majorityCount)
                    return num;
            }

            // If no majority element is found, return -1 (problem constraint usually ensures there's one)
            return -1;
        }

        static void Main(string[] args)
        {
            // Example input array
            int[] nums = { 3, 2, 3 };

            // Print the majority element
            Console.WriteLine(MajorityElement(nums));

            // Wait for a key press to keep console open
            Console.ReadKey();
        }
    }
}
