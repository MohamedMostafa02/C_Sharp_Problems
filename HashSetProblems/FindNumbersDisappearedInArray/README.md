📌 Project Title: Find Disappeared Numbers in an Array

🧾 Description  
This C# console application identifies all the numbers missing from an input array that should contain integers from 1 to n (inclusive), where n is the length of the array. The array may contain duplicates and some numbers may be missing.

🎯 Features  
- Uses `HashSet` for efficient O(1) lookups.  
- Detects missing numbers in the range [1, n].  
- Returns a list of the missing integers.

🛠️ How It Works  
1. The method `FindDisappearedNumbers` accepts an integer array as input.  
2. A `HashSet` is created to store all unique numbers from the input array.  
3. The method loops from 1 to n (length of array), and for each number:  
   - If the number is not found in the `HashSet`, it's considered missing.  
4. Missing numbers are added to a list, which is returned at the end.

🧪 Example  
Input:
    nums = { 4, 3, 2, 7, 8, 2, 3, 1 }  

Output:
    5, 6

Explanation:
- The array should have contained numbers from 1 to 8.  
- Numbers 5 and 6 are missing.

📁 File Structure  
FindNumbersDisappearedInArray/  
├── Program.cs     // Contains main logic for finding missing numbers

👨‍💻 Author  
- Name: Mohamed Mostafa  
- Email: mo@gmail.com

📝 Notes  
- Time Complexity: O(n)  
- Space Complexity: O(n) due to usage of a `HashSet`  
- This approach avoids modifying the original array or using extra arrays for indexing.

✅ Usage  
Run the program using any C# IDE (e.g., Visual Studio) or compile via command line:
    csc Program.cs  
    ./Program.exe
