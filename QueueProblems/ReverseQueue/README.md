# 🔁 Reverse Queue in C#

This project demonstrates how to **reverse the contents of a Queue** using a **Stack** in C#. It shows the classic method of converting a FIFO structure into LIFO and then back into FIFO to achieve reversal.

---

## 📋 Project Description

The program takes a queue of integers, reverses its order using a stack, and prints the reversed queue. This technique uses the nature of stacks (LIFO) to invert the order of items in the queue (FIFO).

---

## 💡 Core Concepts

- **Queue** works on FIFO (First-In, First-Out).
- **Stack** works on LIFO (Last-In, First-Out).
- To reverse a queue:
  1. Dequeue all elements into a stack.
  2. Pop from the stack and enqueue back to the queue.

---

## 🧪 Sample Output

```
5, 4, 3, 2, 1
```

---

## 📁 Project Structure

```
ReverseQueue/
│
├── Program.cs      ← Main C# code with reverse logic
└── README.md       ← This file
```

---

## 🛠️ Built With

- Language: C#  
- Framework: .NET Core / .NET Framework  
- IDE: Visual Studio

---

## 👨‍💻 Author

- Mohamed Mostafa
