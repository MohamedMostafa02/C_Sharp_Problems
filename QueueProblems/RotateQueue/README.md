# 🔁 Rotate Queue Elements in C#

This simple C# console application demonstrates how to **rotate** the elements of a queue to the left by a specified number of positions.

## 📋 Problem Description

Given a queue of integers and an index `k`, the task is to **rotate the queue to the left** `k` times. Each rotation removes the front element and places it at the rear.

### ✅ Example

**Input:**
```
Queue: 1, 2, 3, 4, 5  
Rotations: 2
```

**Output:**
```
3, 4, 5, 1, 2
```

---

## 💡 How It Works

Each rotation:
1. Takes the front element of the queue.
2. Removes it using `Dequeue()`.
3. Adds it back to the end using `Enqueue()`.

---

## 💻 Code

```csharp
using System;
using System.Collections.Generic;

namespace RotateQueue
{
    internal class Program
    {
        // Method to rotate a queue to the left by 'index' positions
        static void RotateQueue(Queue<int> queue, int index)
        {
            // Rotate the queue 'index' times
            while (index > 0)
            {
                // Remove the front element and add it to the rear
                queue.Enqueue(queue.Dequeue());
                index--;
            }
        }

        static void Main(string[] args)
        {
            // Create a queue with elements 1 to 5
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });

            // Rotate the queue 2 times to the left
            RotateQueue(queue, 2);

            // Print the elements in the queue after rotation
            Console.WriteLine(string.Join(",", queue));

            Console.ReadKey();
        }
    }
}
```

---

## 🚀 How to Run

1. Open the project in Visual Studio or any C# IDE.
2. Build and run the project.
3. You’ll see the rotated queue printed to the console.

---

## 📦 Output

```
3,4,5,1,2
```

---

## 🧠 Notes

- This logic simulates a **left rotation**.
- If you want to rotate to the **right**, you’d need to take from the rear and insert at the front using a `Deque` or `Stack`.

---

## 📁 Folder Structure

```
/RotateQueue
│
├── Program.cs
└── README.md
```

---

## 🛠️ Technologies

- Language: **C#**
- Framework: **.NET Framework / .NET Core**
- Type: **Console Application**

---

## ✍️ Author
**Mohamed Mostafa**  
[GitHub Profile](https://github.com/MohamedMostafa02)

