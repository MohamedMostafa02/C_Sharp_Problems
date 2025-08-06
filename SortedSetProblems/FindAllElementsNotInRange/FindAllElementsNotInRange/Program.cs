using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllElementsNotInRange
{
    internal class Program
    {
        // This method returns all elements in the set that are NOT within the specified range [low, high]
        static IEnumerable<int> ElementsNotInRange(SortedSet<int> set, int low, int high)
        {
            // Get a live view of elements in the range [low, high] (inclusive)
            var range = set.GetViewBetween(low, high);

            // Create a copy of the original set to avoid modifying it directly
            SortedSet<int> result = new SortedSet<int>(set);

            // Remove all elements in the specified range from the copied set
            result.ExceptWith(range);

            // Return the remaining elements (those not in the range)
            return result;
        }

        static void Main(string[] args)
        {
            // Create a SortedSet with some initial values
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Call the method to get elements NOT in the range [2, 4]
            var result = ElementsNotInRange(set, 2, 4);

            // Print the result to the console
            Console.WriteLine(string.Join(", ", result)); // Expected Output: 1, 5

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
