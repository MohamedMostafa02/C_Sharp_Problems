📌 Project Title: Find Elements Not in the Second Array

🧾 Description  
This simple C# console application compares two arrays of integers and returns the elements that are present in the first array but not present in the second array.

🎯 Features  
- Efficient lookup using HashSet for O(1) search.
- Filters and returns a new array of values from the first array that don’t exist in the second.

🛠️ How It Works  
1. The method `ElementNotInTheSecondArray` takes two integer arrays as input.  
2. It uses a `HashSet` to store elements of the second array for fast lookup.  
3. It loops through the first array and adds elements to a result list only if they’re not in the second array.  
4. Finally, it returns the result as an array.

🧪 Example  
Input:
    nums1 = { 1, 2, 3, 4 }  
    nums2 = { 3, 4, 5, 6 }  

Output:
    1, 2

📁 File Structure  
FindElementsNotInTheSecondArray/  
├── Program.cs     // Main logic of the application

👨‍💻 Author  
- Name: Mohamed Mostafa  
- Email: mo@gmail.com

📝 Notes  
- The solution is optimized using `HashSet`, which gives better performance than using nested loops.  
- You can reuse the method in larger systems or integrate it with LINQ if needed.

✅ Usage  
Compile and run the program using any C# IDE (like Visual Studio) or from the terminal:
    csc Program.cs  
    ./Program.exe
