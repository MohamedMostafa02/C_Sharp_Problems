using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountElementsGreaterThanValue
{
    internal class Program
    {
        // This method returns the count of elements in the set that are greater than the given value
        static int CountGreaterThan(SortedSet<int> set, int value)
        {
            // Get all elements between (value + 1) and int.MaxValue, then return how many there are
            return set.GetViewBetween(value + 1, int.MaxValue).Count();
        }

        static void Main(string[] args)
        {
            // Create a sorted set with some initial values
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Define the value to compare against
            int value = 3;

            // Print how many elements in the set are greater than the given value
            Console.WriteLine(CountGreaterThan(set, value)); // Output will be 2 (4 and 5)

            // Wait for key press before closing the console window
            Console.ReadKey();
        }
    }
}
