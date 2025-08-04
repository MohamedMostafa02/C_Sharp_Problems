# Find All Unique Elements in an Array using Dictionary – C#

This simple C# console application finds all **unique elements** in an integer array using a `Dictionary<int, int>` to count the frequency of each number.

## 🔍 Problem Statement
Given an array of integers, find all the elements that appear **exactly once** (i.e., unique elements).

### 🧪 Example
**Input:**
```
[1, 2, 2, 3, 4, 5, 3]
```
**Output:**
```
1, 4, 5
```
Explanation:
- 1 → appears once ✅  
- 2 → appears twice ❌  
- 3 → appears twice ❌  
- 4 → once ✅  
- 5 → once ✅

---

## 💡 Approach

We use a dictionary to count how many times each number appears in the array. Then we collect all elements that appear **only once**.

### ✅ Steps:
1. Loop through the array and fill the dictionary with frequency counts.
2. Loop through the dictionary, and add elements with count == 1 to a result list.
3. Return the list.

---

## 🧠 Code

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllUniqueElements
{
    internal class Program
    {
        // Function to find all unique elements
        static List<int> FindUniqueElements(int[] nums)
        {
            // Dictionary to hold the count of each number
            Dictionary<int, int> counts = new Dictionary<int, int>();
            // List to store the unique elements
            List<int> unique = new List<int>();

            // Count occurrences of each number
            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            // Add numbers that appear only once to the result list
            foreach (var kvp in counts)
            {
                if (kvp.Value == 1)
                    unique.Add(kvp.Key);
            }

            return unique;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 3, 4, 5, 3 };

            Console.WriteLine(string.Join(", ", FindUniqueElements(nums)));
        }
    }
}
```

---

## 📂 File Structure

```
DictionaryProblems/
└── FindAllUniqueElements/
    └── Program.cs
```

---

## 🛠️ Technologies
- Language: C#
- Platform: Console App (.NET Framework or .NET Core)

---

## ✍️ Author
Mohamed Mostafa  

