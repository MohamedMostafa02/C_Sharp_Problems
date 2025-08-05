using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfTwoArraysAreDisjoint
{
    internal class Program
    {
        // This method checks whether two arrays are disjoint (i.e., have no elements in common)
        static bool AreDisjoint(int[] nums1, int[] nums2)
        {
            // Use a HashSet to store elements from the first array for fast lookup
            HashSet<int> set = new HashSet<int>(nums1);

            // Iterate through each element in the second array
            foreach (int num in nums2)
            {
                // If any element from nums2 is found in the HashSet, they are not disjoint
                if (set.Contains(num))
                {
                    return false; // There is a common element
                }
            }

            // If no common elements are found, the arrays are disjoint
            return true;
        }

        static void Main(string[] args)
        {
            // First array of integers
            int[] nums1 = { 1, 2, 3 };

            // Second array of integers
            int[] nums2 = { 4, 5, 6 };

            // Check if the arrays are disjoint and print the result (True or False)
            Console.WriteLine(AreDisjoint(nums1, nums2));

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
