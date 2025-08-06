# ✅ Check If Set Contains Multiple Ranges - C# Console App

This C# console application checks whether all integers within a list of ranges are present in a given SortedSet<int>. It uses the GetViewBetween method to efficiently verify if each range is completely contained in the set.

## ✅ Features
- Uses SortedSet<int> for efficient sorted storage and range queries.
- Accepts multiple ranges as tuples (start, end).
- Verifies that all integers in every range exist in the set.
- Uses GetViewBetween to create live range views without copying data.
- Outputs true/false based on range presence.

## 🧠 How It Works
- Each range is defined as a tuple (low, high).
- For each range, the method uses GetViewBetween(low, high) to extract a view from the set.
- If the count of elements in that view is not equal to (high - low + 1), it means some elements are missing.
- If all ranges pass, the method returns true.

## 🖥 Example Output
True

(If the set contains all numbers in all provided ranges.)

## ▶️ How to Compile and Run

Using Visual Studio:
1. Create a new Console App project.
2. Replace the code in Program.cs with the code below.
3. Press Ctrl + F5 to run.

Using Command Line:
csc Program.cs
Program.exe

## 📄 Code

using System;
using System.Collections.Generic;

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

## 👤 Author
Mohamed Mostafa  
C# Console App Developer
