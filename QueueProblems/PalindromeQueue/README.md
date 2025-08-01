# 🔁 Palindrome Queue Checker in C#

This project demonstrates how to check if the contents of a **Queue** form a **palindrome** using a **Stack** in C#. A palindrome is a sequence that reads the same forward and backward.

---

## 📋 Project Description

The program creates a queue containing a sequence of integers and checks whether that sequence is a palindrome. This is done by comparing each element of the queue to the corresponding element in a stack (which reverses the order).

---

## 💡 Core Concepts

- **Queue (FIFO)**: Maintains the original order of elements.
- **Stack (LIFO)**: Reverses the order.
- A sequence is a **palindrome** if:
  - The first element == last element  
  - The second == second last  
  - And so on...

**Logic:**
1. Initialize a stack with the contents of the queue.
2. Iterate through the queue and compare each item with the top of the stack.
3. If all match → it's a palindrome.

---

## 🧪 Sample Output

```
The Queue is palindrome...
```

---

## 🧱 Example

Input queue:
```
1, 2, 3, 2, 1
```

Stack created from the queue:
```
Top → 1, 2, 3, 2, 1
```

Comparison:
```
1 == 1  
2 == 2  
3 == 3 → All match → Palindrome ✅
```

---

## 📁 Project Structure

```
PalindromeQueue/
│
├── Program.cs      ← Main C# code
└── README.md       ← This file
```

---

## 🛠️ Built With

- Language: C#  
- Framework: .NET Core or .NET Framework  
- IDE: Visual Studio

---

## 👨‍💻 Author

- Mohamed Mostafa
