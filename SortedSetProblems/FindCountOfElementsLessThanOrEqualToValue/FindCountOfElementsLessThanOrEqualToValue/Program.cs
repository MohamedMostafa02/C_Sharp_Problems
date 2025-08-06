using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCountOfElementsLessThanOrEqualToValue
{
    internal class Program
    {
        // This method returns the count of elements in the set that are less than or equal to the given value
        static int CountLessThanOrEqual(SortedSet<int> set, int value)
        {
            // Get a live view of elements in the range from the smallest possible integer up to 'value' (inclusive)
            return set.GetViewBetween(int.MinValue, value).Count;
        }

        static void Main(string[] args)
        {
            // Create a SortedSet with initial values
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Call the method to count elements less than or equal to 3 and print the result
            Console.WriteLine(CountLessThanOrEqual(set, 3)); // Output: 3

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
