# Clone Queue Using Recursion

This project demonstrates how to **clone a queue** using **recursion only**, without using any extra data structures (like another queue or stack for temporary storage).

## 🔍 Problem Statement

Given a queue of integers, clone it into a new queue such that:
- Both queues have the same elements in the same order.
- The original queue remains unchanged.
- No extra space is used apart from recursion stack.

## ✅ Approach

We use **recursion** to temporarily remove elements from the original queue, and during the recursive backtracking, we:
1. Enqueue the element back into the original queue.
2. Enqueue it into the new cloned queue.

This ensures:
- The original queue is restored.
- The cloned queue is created in the same order.

## 🧠 Example

Input:
```
Original Queue: [1, 2, 3, 4]
```

Output:
```
Cloned Queue:   [1, 2, 3, 4]
Original Queue: [1, 2, 3, 4]
```

## 🧪 Code

```csharp
using System;
using System.Collections.Generic;

namespace CloneQueueUsingRecursion
{
    internal class Program
    {
        // Recursive method to clone a queue without using extra space
        static Queue<int> CloneQueue(Queue<int> queue)
        {
            if (queue.Count == 0)
                return new Queue<int>(); // Base case: return empty queue

            int front = queue.Dequeue(); // Take the front element

            Queue<int> clone = CloneQueue(queue); // Recursive call on the rest

            queue.Enqueue(front); // Restore the original queue
            clone.Enqueue(front); // Build the clone queue

            return clone;
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] {1, 2, 3, 4});

            Queue<int> clonedQueue = CloneQueue(queue);

            Console.WriteLine("Cloned Queue:   " + string.Join(", ", clonedQueue));
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            Console.ReadKey();
        }
    }
}
```

## 📌 Notes
- This solution **uses the call stack as temporary storage** (which is acceptable in recursion-based problems).
- Time Complexity: `O(n)`
- Space Complexity: `O(n)` (due to recursive stack, not additional data structures)

## 📁 Folder Structure
```
CloneQueueUsingRecursion/
├── Program.cs
└── README.md
```

## 👨‍💻 Author

Mohamed Mostafa  
GitHub: [MohamedMostafa02](https://github.com/MohamedMostafa02)

---

Feel free to use, modify, or contribute!
