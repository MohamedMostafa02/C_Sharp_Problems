using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElementsNotInTheSecondArray
{
    internal class Program
    {
        // This method returns elements that are in nums1 but NOT in nums2
        static int[] ElementNotInTheSecondArray(int[] nums1, int[] nums2)
        {
            // Create a HashSet from nums2 for fast lookup
            HashSet<int> set2 = new HashSet<int>(nums2);

            // List to store elements that are in nums1 but not in nums2
            List<int> list = new List<int>();

            // Iterate through each number in nums1
            foreach (int num in nums1)
            {
                // If the number is NOT in nums2, add it to the result list
                if (!set2.Contains(num))
                {
                    list.Add(num);
                }
            }

            // Convert the list to an array and return it
            return list.ToArray();
        }

        static void Main(string[] args)
        {
            // First array of numbers
            int[] nums1 = { 1, 2, 3, 4 };

            // Second array of numbers
            int[] nums2 = { 3, 4, 5, 6 };

            // Print the elements that are in nums1 but not in nums2
            Console.WriteLine(string.Join(", ", ElementNotInTheSecondArray(nums1, nums2)));

            // Wait for user input before closing the console
            Console.ReadKey();
        }
    }
}
