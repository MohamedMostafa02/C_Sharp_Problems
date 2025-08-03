using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkDublicateEntries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a HashSet to store unique data entries
            // HashSet ensures all elements are unique and helps detect duplicates
            HashSet<string> dataEntries = new HashSet<string>();

            // Sample array of entries to be checked for duplicates
            string[] entries = { "A", "B", "C", "A" };

            // Iterate over each entry in the array
            foreach (string entry in entries)
            {
                // Try to add the entry to the HashSet
                // If Add returns false, the entry is a duplicate
                if (!dataEntries.Add(entry))
                {
                    Console.WriteLine($"Duplicate detected: {entry}");
                }
            }

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
