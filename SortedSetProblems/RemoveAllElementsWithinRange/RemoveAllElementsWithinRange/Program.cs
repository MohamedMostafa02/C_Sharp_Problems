using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllElementsWithinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedSet of integers with initial values
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Get a view of the elements in the range from 2 to 4 (inclusive)
            var range = set.GetViewBetween(2, 4);

            // Remove all elements in the specified range from the original set
            range.Clear();

            // Print the remaining elements in the set, separated by commas
            Console.WriteLine(string.Join(", ", set));

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
