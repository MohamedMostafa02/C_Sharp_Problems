using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionOfTwoSortedSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the first sorted set with elements 1, 2, 3
            SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3 };

            // Create the second sorted set with elements 3, 4, 5
            SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5 };

            // Perform union: set1 will now contain all unique elements from both sets
            set1.UnionWith(set2);  // set1 becomes {1, 2, 3, 4, 5}

            // Print the result of the union
            Console.WriteLine(string.Join(", ", set1));

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
