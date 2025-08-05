using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumbersDisappearedInArray
{
    internal class Program
    {
        // This method returns the list of numbers missing from the array
        // The input array should contain numbers from 1 to n with possible duplicates
        static List<int> FindDisappearedNumbers(int[] numbers)
        {
            // Create a HashSet to store all unique numbers present in the array
            HashSet<int> set = new HashSet<int>(numbers);

            // List to store the missing numbers
            List<int> list = new List<int>();

            // Loop through numbers from 1 to n (inclusive)
            for (int i = 1; i <= numbers.Length; i++)
            {
                // If the number i is not in the HashSet, it's missing
                if (!set.Contains(i))
                {
                    list.Add(i); // Add missing number to the result list
                }
            }

            // Return the list of missing numbers
            return list;
        }

        static void Main(string[] args)
        {
            // Example input array with numbers from 1 to n, some are missing or duplicated
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };

            // Call the method and store the result
            var result = FindDisappearedNumbers(nums);

            // Print the result to the console
            Console.WriteLine(string.Join(", ", result));

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
