# Count Elements Less Than or Equal to a Given Value - C# Console App

This C# console application demonstrates how to count the number of elements in a SortedSet<int> that are less than or equal to a specified value using the GetViewBetween method.

✅ Features:
- Uses SortedSet<int> to store sorted unique integers.
- Counts elements less than or equal to a specific value.
- Uses GetViewBetween to return a live view (not a copy).
- Outputs the result to the console.

🧠 How It Works:
- A SortedSet<int> is initialized with {1, 2, 3, 4, 5}.
- GetViewBetween(int.MinValue, value) gives all elements <= value.
- Count is taken from that view and printed.

🖥 Example Output:
3

▶️ How to Compile and Run:

Using Visual Studio:
1. Create a new Console App project.
2. Replace the code in Program.cs with the code below.
3. Press Ctrl + F5 to run.

Using Command Line:
csc Program.cs
Program.exe

📄 Code:
using System;
using System.Collections.Generic;

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

👤 Author:
Mohamed Mostafa - C# Console App Developer

