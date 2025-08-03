# 🧮 EvaluatePostfixExpression

A simple C# console application to **evaluate a postfix (Reverse Polish Notation) expression** using a **stack**.

---

## 📘 What is Postfix?

A **postfix expression** is a mathematical expression where the operator comes **after** its operands.

### 🔁 Example:
Infix: `2 + 3 * 1 - 9`  
Postfix: `2 3 1 * + 9 -`

---

## 🛠️ How It Works

- Read the postfix string one character at a time.
- **If the character is a digit**, convert it to integer and **push it to the stack**.
- **If the character is an operator** (`+`, `-`, `*`, `/`):
  - Pop **two** numbers from the stack.
  - Apply the operation: `a op b`
  - Push the result back onto the stack.
- The final result will be the **only element** left in the stack.

---

## ⚠️ Safety Checks

- Ensures there are at least **two operands** before applying any operation.
- Detects **division by zero**.
- Reports **invalid operators**.

---

## 📂 Project Structure

```
EvaluatePostfixExpression/
├── Program.cs       // Contains the core logic and testing
```

---

## 🧪 Example

### ▶️ Input:
```csharp
"231*+9-"
```

### 🔍 Evaluation Steps:
```
2       → push 2
3       → push 3
1       → push 1
*       → 3 * 1 = 3 → push 3
+       → 2 + 3 = 5 → push 5
9       → push 9
-       → 5 - 9 = -4 → push -4
```

### ✅ Final Result:
```
-4
```

---

## ▶️ How to Run

1. Open the project in **Visual Studio** or any C# IDE.
2. Build and run the project.
3. Modify the input string in `Main()` to test different expressions.

---

## 📌 Tech Stack

- Language: **C#**
- Runtime: **.NET Framework / .NET Core**
- Environment: Console Application

---

## 👨‍💻 Author

**Mohamed Mostafa**  

