# Remove Invalid Parentheses – C# Console Application

## 📋 Description
This simple C# console application removes invalid (unmatched) parentheses from a given string. It ensures that every opening parenthesis `(` has a corresponding closing parenthesis `)`, and vice versa.

## 💡 How It Works
The program uses a **stack** and a **hash set** to track indices of unmatched parentheses:

1. It loops through each character in the string:
   - If it sees `'('`, it pushes its index onto a stack.
   - If it sees `')'`:
     - If the stack is empty, it means there’s no matching `'('`, so it's marked invalid.
     - Otherwise, it pops from the stack, meaning a valid match was found.

2. After the loop, any indices left in the stack (unmatched `'('`) are also marked invalid.

3. Finally, it builds a new string excluding all characters at invalid indices.

## 🧪 Example
Input:  "(()))"  
Output: "(())"  
Explanation: There’s one extra closing parenthesis `)`, which is removed to balance the string.

## 🧑‍💻 Code Overview
- `RemoveInvalidParentheses(string s)` – Core function to process the string.
- `Main()` – Runs the function on a test case and displays the result.

## 🧠 Concepts Used
- Stack
- HashSet
- String traversal and building a result string
- Basic understanding of parentheses matching logic

## 📦 Output
# Remove Invalid Parentheses – C# Console Application

## 📋 Description
This simple C# console application removes invalid (unmatched) parentheses from a given string. It ensures that every opening parenthesis `(` has a corresponding closing parenthesis `)`, and vice versa.

## 💡 How It Works
The program uses a **stack** and a **hash set** to track indices of unmatched parentheses:

1. It loops through each character in the string:
   - If it sees `'('`, it pushes its index onto a stack.
   - If it sees `')'`:
     - If the stack is empty, it means there’s no matching `'('`, so it's marked invalid.
     - Otherwise, it pops from the stack, meaning a valid match was found.

2. After the loop, any indices left in the stack (unmatched `'('`) are also marked invalid.

3. Finally, it builds a new string excluding all characters at invalid indices.

## 🧪 Example
Input:  "(()))"  
Output: "(())"  
Explanation: There’s one extra closing parenthesis `)`, which is removed to balance the string.

## 🧑‍💻 Code Overview
- `RemoveInvalidParentheses(string s)` – Core function to process the string.
- `Main()` – Runs the function on a test case and displays the result.

## 🧠 Concepts Used
- Stack
- HashSet
- String traversal and building a result string
- Basic understanding of parentheses matching logic

## 📦 Output
# Remove Invalid Parentheses – C# Console Application

## 📋 Description
This simple C# console application removes invalid (unmatched) parentheses from a given string. It ensures that every opening parenthesis `(` has a corresponding closing parenthesis `)`, and vice versa.

## 💡 How It Works
The program uses a **stack** and a **hash set** to track indices of unmatched parentheses:

1. It loops through each character in the string:
   - If it sees `'('`, it pushes its index onto a stack.
   - If it sees `')'`:
     - If the stack is empty, it means there’s no matching `'('`, so it's marked invalid.
     - Otherwise, it pops from the stack, meaning a valid match was found.

2. After the loop, any indices left in the stack (unmatched `'('`) are also marked invalid.

3. Finally, it builds a new string excluding all characters at invalid indices.

## 🧪 Example
Input:  "(()))"  
Output: "(())"  
Explanation: There’s one extra closing parenthesis `)`, which is removed to balance the string.

## 🧑‍💻 Code Overview
- `RemoveInvalidParentheses(string s)` – Core function to process the string.
- `Main()` – Runs the function on a test case and displays the result.

## 🧠 Concepts Used
- Stack
- HashSet
- String traversal and building a result string
- Basic understanding of parentheses matching logic

## 📦 Output
(()) // Cleaned string with balanced parentheses


## 👨‍💻 Author
- **Name:** Mohamed Mostafa  

