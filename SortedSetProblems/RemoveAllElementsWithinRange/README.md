# 🧹 Remove Elements Within Range - C# Console App

This simple C# console application demonstrates how to remove all elements within a specific range from a SortedSet<int> using the GetViewBetween() method.

## ✅ Features
- Uses SortedSet<int> to maintain sorted unique integers.
- Removes a range of elements (inclusive) directly from the original set.
- Demonstrates how GetViewBetween provides a live view (not a copy).
- Outputs the updated set after deletion.

## 🧠 How It Works
- A SortedSet<int> is initialized with values {1, 2, 3, 4, 5}.
- GetViewBetween(2, 4) is used to get a live view of elements in the range [2, 4].
- Clear() is called on the view, which removes those elements from the original set.
- The final set is printed, showing only elements outside the removed range.

## 🖥 Example Output
1, 5

## ▶️ How to Compile and Run

Using Visual Studio:
1. Create a new Console App project.
2. Replace the code in Program.cs with the code below.
3. Press Ctrl + F5 to run.

Using Command Line:
csc Program.cs
Program.exe

## 📦 Requirements
- .NET Framework or .NET SDK
- C# compiler (like csc) or Visual Studio

## 📄 Code
using System;
using System.Collections.Generic;

namespace RemoveAllElementsWithinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedSet of integers with initial values
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            // Get a view of the elements in the range from 2 to 4 (inclusive)
            var range = set.GetViewBetween(2, 4);

            // Remove all elements in the specified range from the original set
            range.Clear();

            // Print the remaining elements in the set, separated by commas
            Console.WriteLine(string.Join(", ", set));

            // Wait for user input before closing the console window
            Console.ReadKey(); 
        }
    }
}

## 👤 Author
Mohamed Mostafa  
C# Console Application Enthusiast
