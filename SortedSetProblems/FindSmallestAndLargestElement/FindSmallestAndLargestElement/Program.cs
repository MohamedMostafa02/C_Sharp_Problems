using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestAndLargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedSet of integers
            // SortedSet automatically keeps elements in ascending order and removes duplicates
            SortedSet<int> sortdSet = new SortedSet<int>() { 4, 2, 5, 1, 3 };

            // Use Min and Max properties to get the smallest and largest elements
            Console.WriteLine($"Smallest: {sortdSet.Min}, Largest: {sortdSet.Max}");

            // Wait for user input before closing the console
            Console.ReadKey();
        }
    }
}
