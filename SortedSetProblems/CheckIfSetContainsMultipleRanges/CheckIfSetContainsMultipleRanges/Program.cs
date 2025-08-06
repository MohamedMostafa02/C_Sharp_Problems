using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfSetContainsMultipleRanges
{
    internal class Program
    {
        // This method checks if the SortedSet contains all elements in every given range
        static bool ContainsAllRanges(SortedSet<int> set, List<(int, int)> ranges)
        {
            // Loop through each (low, high) range tuple in the list
            foreach (var (low, high) in ranges)
            {
                // Get a live view of the elements in the specified range [low, high]
                var range = set.GetViewBetween(low, high);

                // If the count of elements in the range is not equal to (high - low + 1),
                // then some elements in the range are missing
                if (range.Count != (high - low + 1))
                    return false;
            }

            // If all ranges are fully present, return true
            return true;
        }

        static void Main(string[] args)
        {
            // Create a SortedSet with initial values
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Define a list of ranges to check; each range is a tuple (start, end)
            var ranges = new List<(int, int)> { (1, 2), (4, 5) };

            // Check if the set contains all elements in the given ranges and print the result
            Console.WriteLine(ContainsAllRanges(set, ranges)); // Output: True

            // Wait for user input before closing the console
            Console.ReadKey();
        }
    }
}
