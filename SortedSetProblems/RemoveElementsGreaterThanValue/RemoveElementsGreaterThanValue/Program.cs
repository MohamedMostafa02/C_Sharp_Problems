using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsGreaterThanValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedSet with initial values
            SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Get a view (subset) of elements less than or equal to 3
            // int.MinValue is used to include all elements from the lowest possible integer up to 3
            var range = sortedSet.GetViewBetween(int.MinValue, 3);

            // Replace the original set with the filtered subset
            sortedSet = new SortedSet<int>(range);

            // Display the filtered set (only values <= 3)
            Console.WriteLine(string.Join(", ", sortedSet));

            // Wait for key press to keep the console open
            Console.ReadKey();
        }
    }
}
