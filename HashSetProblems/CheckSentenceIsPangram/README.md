
📌 Project Title: Check if a Sentence is a Pangram

🧾 Description  
This C# console application determines whether a given sentence is a **pangram** — meaning it contains **every letter of the English alphabet at least once**.

🎯 Features  
- Ignores letter case (works with uppercase and lowercase letters).  
- Skips non-letter characters (punctuation, numbers, spaces).  
- Efficient checking using a `HashSet<char>` for unique letter tracking.

🛠️ How It Works  
1. The method `IsPangram` takes a string input.  
2. It converts the sentence to lowercase.  
3. It iterates through each character:
   - If the character is a letter, it is added to a `HashSet`.  
4. If the `HashSet` contains exactly 26 letters, the sentence is a pangram.

🧪 Example  
Input:  
    "The quick brown fox jumps over the lazy dog"

Output:  
    True

Explanation:  
This sentence contains all the letters from 'a' to 'z', so it qualifies as a pangram.

📁 File Structure  
CheckSentenceIsPangram/  
├── Program.cs     // Contains the pangram checking logic

👨‍💻 Author  
- Mohamed Mostafa

📝 Notes  
- Time Complexity: O(n), where n is the length of the sentence.  
- Space Complexity: O(1), because the maximum size of the `HashSet` is 26 (fixed).  
- This is a case-insensitive solution.

✅ Usage  
You can run the program using any C# IDE (such as Visual Studio), or compile it from the command line:
    csc Program.cs  
    ./Program.exe
