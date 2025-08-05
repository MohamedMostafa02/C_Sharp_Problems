using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElementsInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedSet with integers from 1 to 5
            SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Get a view (subset) of elements in the range [2, 4] (inclusive)
            var range = sortedSet.GetViewBetween(2, 4);

            // Print the elements in the range (will print: 2, 3, 4)
            Console.WriteLine(string.Join(", ", range));

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
