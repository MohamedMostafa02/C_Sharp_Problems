# CheckBalancedParentheses

A simple C# console application to check if a string containing parentheses `()`, curly braces `{}`, and square brackets `[]` is **balanced**.

## 💡 What does "balanced" mean?

A string is considered balanced if:
- Every opening bracket has a corresponding closing bracket.
- Brackets are correctly nested and closed in the correct order.

### ✅ Examples of balanced strings:
- `()`
- `({[]})`
- `{[()()]}`

### ❌ Examples of unbalanced strings:
- `([)]` → Incorrect nesting
- `((()` → Missing closing brackets
- `{[}` → Mismatched closing bracket

---

## 📂 Project Structure

```text
CheckBalancedParentheses/
├── Program.cs       // Main logic and test cases
```

---

## 🧠 How It Works

- Uses a **stack** to track opening brackets.
- When a closing bracket is encountered, it:
  - Checks if the stack is empty → if so, it's unbalanced.
  - Pops the top element and checks for a valid match.
- After traversing the entire string, the stack should be empty for the input to be balanced.

---

## 🧪 Sample Output

```csharp
Is "({[]})" balanced? True
Is "({[)]}" balanced? False
```

---

## 🛠️ Tech Used

- Language: C#
- Framework: .NET Console Application

---

## 📌 How to Run

1. Open the solution in Visual Studio or any C# editor.
2. Run the project.
3. You can modify the `input` strings in `Main()` to test different cases.

---

## 👨‍💻 Author

**Mohamed Mostafa**  

