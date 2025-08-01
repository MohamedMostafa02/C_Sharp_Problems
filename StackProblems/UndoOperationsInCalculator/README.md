# 🔄 Undo Operations in Calculator (C# Console App)

This is a simple C# console application that simulates **undo functionality** in a calculator using a **stack**.

## 📌 Description

Each time a new result is calculated, it's added (pushed) to the stack.  
When the user performs an **undo**, the most recent result is removed (popped) from the stack, and the program shows the previous result.

## 💡 Features

- Uses `Stack<int>` to store calculation results
- Supports basic undo functionality (one step at a time)
- Displays current result after undo

## 🧠 Concepts Used

- `Push()` – Add a new result
- `Pop()` – Undo last result
- `Peek()` – View current result

## 💻 Code Example

```csharp
Stack<int> CalculatorStack = new Stack<int>();

CalculatorStack.Push(10);
CalculatorStack.Push(20);
CalculatorStack.Push(30);

Console.WriteLine("Undo: " + CalculatorStack.Pop());      // Output: 30
Console.WriteLine("Current Result: " + CalculatorStack.Peek()); // Output: 20
```

## 🧪 Output

```
Undo: 30
Current Result: 20
```

## 📁 Project Structure

```
UndoOperationsInCalculator/
│
├── Program.cs       # Main source code
├── README.md        # This file
```

## ✅ Requirements

- .NET Framework or .NET Core
- Any C# IDE (e.g., Visual Studio)

---

Feel free to extend this project to support more operations or a full calculator interface!
