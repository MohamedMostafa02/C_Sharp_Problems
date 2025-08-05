📌 Project Title: Find Elements in Range Using SortedSet

🧾 Description  
This C# console application demonstrates how to use `SortedSet<T>` and its method `GetViewBetween()` to extract and print a subset of elements that fall within a specific range.

🎯 Features  
- Automatically sorts the elements.  
- Efficiently retrieves elements within a given range.  
- Ensures all elements are unique and ordered.

🛠️ How It Works  
1. A `SortedSet<int>` is created with the elements `{1, 2, 3, 4, 5}`.  
2. The method `GetViewBetween(2, 4)` is called to retrieve all elements from **2 to 4** (inclusive).  
3. The resulting subset is printed using `string.Join()`.

🧪 Example  
Input Set:  
    {1, 2, 3, 4, 5}

Range Queried:  
    2 to 4

Output:  
    2, 3, 4

📁 File Structure  
FindElementsInRange/  
├── Program.cs     // Contains the range extraction logic using SortedSet

👨‍💻 Author  
- Mohamed Mostafa

📝 Notes  
- `SortedSet<T>` stores elements in sorted order and disallows duplicates.  
- `GetViewBetween(min, max)` provides a live view of all elements between `min` and `max` (inclusive).  
- Changes to the original set are reflected in the view and vice versa.

✅ Usage  
Run the program using any C# IDE (like Visual Studio) or compile it via command line:
    csc Program.cs  
    ./Program.exe
