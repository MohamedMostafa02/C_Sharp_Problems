using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElementsLessThanValue
{
    internal class Program
    {
        // This method returns all elements in the SortedSet that are less than the given value.
        static IEnumerable<int> ElementsLessThan(SortedSet<int> set, int value)
        {
            // GetViewBetween returns a view of the elements between two bounds (inclusive),
            // so we use int.MinValue to cover all possible values less than (value - 1).
            return set.GetViewBetween(int.MinValue, value - 1);
        }

        static void Main(string[] args)
        {
            // Create a sorted set with initial values
            SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Define the value to compare with
            int value = 4;

            // Print elements from the set that are less than the given value
            Console.WriteLine(string.Join(", ", ElementsLessThan(sortedSet, value)));

            // Wait for user key press before closing the console window
            Console.ReadKey();
        }
    }
}
