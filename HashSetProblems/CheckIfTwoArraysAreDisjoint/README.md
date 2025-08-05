📌 Project Title: Check If Two Arrays Are Disjoint

🧾 Description  
This C# console application checks whether two integer arrays are **disjoint**, meaning they have no elements in common.

🎯 Features  
- Uses `HashSet` for efficient O(1) lookup.  
- Returns a boolean result: `true` if the arrays are disjoint, `false` otherwise.  
- Simple and efficient implementation suitable for arrays of any size.

🛠️ How It Works  
1. The method `AreDisjoint` takes two integer arrays as input.  
2. It creates a `HashSet` from the first array for fast membership checking.  
3. It iterates through the second array:
   - If any element is found in the `HashSet`, it returns `false` (arrays are **not** disjoint).  
4. If no common elements are found, it returns `true`.

🧪 Example  
Input:
    nums1 = { 1, 2, 3 }  
    nums2 = { 4, 5, 6 }

Output:
    True

Input:
    nums1 = { 1, 2, 3 }  
    nums2 = { 3, 4, 5 }

Output:
    False

📁 File Structure  
CheckIfTwoArraysAreDisjoint/  
├── Program.cs     // Main application code

👨‍💻 Author  
- Mohamed Mostafa

📝 Notes  
- Time Complexity: O(n + m), where n and m are the lengths of the input arrays.  
- Space Complexity: O(n), due to the `HashSet`.  
- This approach avoids nested loops and provides better performance.

✅ Usage  
Run the program using any C# IDE (e.g., Visual Studio) or compile via command line:
    csc Program.cs  
    ./Program.exe
