# Remove Invalid Parentheses – C# Console Application

📋 Description:
This C# console application removes invalid (unmatched) parentheses from a string, ensuring all opening '(' have matching closing ')' and vice versa.

💡 How It Works:
- Uses a Stack to track indices of opening parentheses.
- Uses a HashSet to mark unmatched or extra parentheses.
- Iterates through the input:
  - On '(', push its index to the stack.
  - On ')', if stack is empty → mark as invalid, else pop from the stack.
- Any indices left in the stack after traversal are unmatched '(' → also marked invalid.
- Builds a new string skipping all invalid indices.

🧪 Example:
Input:  "(()))"  
Output: "(())"  
Explanation: One extra ')' is removed to balance the parentheses.

🧑‍💻 Functions:
- `RemoveInvalidParentheses(string s)` → Main logic.
- `Main()` → Calls the function and prints the result.

🧠 Concepts Used:
- Stack
- HashSet
- String building and filtering
- Parentheses matching

📦 Sample Output:
(())   // Valid, balanced parentheses string

👨‍💻 Author:
Name: Mohamed Mostafa  

