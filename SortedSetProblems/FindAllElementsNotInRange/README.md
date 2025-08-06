# 🚫 Find Elements Not In Range - C# Console App

This C# console application demonstrates how to find and return all elements in a SortedSet<int> that are NOT within a specified range, using the GetViewBetween() and ExceptWith() methods.

## ✅ Features
- Uses SortedSet<int> for sorted and unique values.
- Finds and removes a specified inclusive range from a copy.
- Original set remains unchanged.
- Displays only elements outside the specified range.

## 🧠 How It Works
- A SortedSet<int> is initialized with values {1, 2, 3, 4, 5}.
- GetViewBetween(2, 4) gets a live view of values in the range [2, 4].
- A copy of the original set is created.
- ExceptWith removes the range from the copy.
- The result is all elements NOT in the range.

## 🖥 Example Output
1, 5

## ▶️ How to Compile and Run

Using Visual Studio:
1. Create a new Console App project.
2. Paste the code below into Program.cs.
3. Press Ctrl + F5 to run.

Using Command Line:
csc Program.cs
Program.exe

## 📦 Requirements
- .NET Framework or .NET SDK
- Visual Studio or csc compiler

## 📄 Code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllElementsNotInRange
{
    internal class Program
    {
        // This method returns all elements in the set that are NOT within the specified range [low, high]
        static IEnumerable<int> ElementsNotInRange(SortedSet<int> set, int low, int high)
        {
            // Get a live view of elements in the range [low, high] (inclusive)
            var range = set.GetViewBetween(low, high);

            // Create a copy of the original set to avoid modifying it directly
            SortedSet<int> result = new SortedSet<int>(set);

            // Remove all elements in the specified range from the copied set
            result.ExceptWith(range);

            // Return the remaining elements (those not in the range)
            return result;
        }

        static void Main(string[] args)
        {
            // Create a SortedSet with some initial values
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Call the method to get elements NOT in the range [2, 4]
            var result = ElementsNotInRange(set, 2, 4);

            // Print the result to the console
            Console.WriteLine(string.Join(", ", result)); // Output: 1, 5

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}

## 👤 Author
Mohamed Mostafa  
C# Console Application Developer
