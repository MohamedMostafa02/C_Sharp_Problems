# 🔙 Browser Back Button Simulation using Stack (C#)

This is a simple C# console application that simulates a **browser back button** using a **Stack** data structure.

## 📌 Description

The program demonstrates how a stack can be used to track navigation history, just like browsers use it to implement the **Back** button functionality.

Each page visited is pushed onto the stack. When the user presses the back button, the top page is popped from the stack, simulating going back to the previous page.

## 🧠 Concepts Used

- `Stack<T>` from `System.Collections.Generic`
- Basic stack operations:
  - `Push()` – to add a page to the history
  - `Pop()` – to go back (remove the current page)
  - `Peek()` – to view the current page without removing it

## 💻 Code Sample

```csharp
Stack<string> history = new Stack<string>();

history.Push("Page1");
history.Push("Page2");
history.Push("Page3");

Console.WriteLine("Back From: " + history.Pop());  // Simulates going back
Console.WriteLine("Current Page: " + history.Peek()); // Shows the page you're now on
```

## 🧪 Output

```
Back From: Page3
Current Page: Page2
```

## 📁 Project Structure

```
BrowserBackButton/
│
├── Program.cs       # Main program file
├── README.md        # Project documentation (this file)
```

## ✅ Requirements

- .NET Framework / .NET Core
- Visual Studio or any C# compiler
