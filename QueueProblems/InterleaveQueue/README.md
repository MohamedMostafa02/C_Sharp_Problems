# Interleave Queue Elements (C#)

📋 This C# program demonstrates how to interleave the first and second halves of a queue using only a `Queue<T>` data structure.

---

## 📌 Problem Statement

Given a queue with even number of elements, interleave the first half with the second half.

🧠 Example:

Input:
```
Queue = 1, 2, 3, 4, 5, 6
```

Output:
```
Interleaved Queue = 1, 4, 2, 5, 3, 6
```

---

## 🛠️ How it Works

1. Split the original queue into two halves.
2. Store the first half in a new queue.
3. Reconstruct the original queue by alternating between elements of the first half and the remaining original queue.

---

## 📎 Code

```csharp
using System;
using System.Collections.Generic;

namespace InterleaveQueue
{
    internal class Program
    {
        // Method to interleave the queue elements
        static void InterleaveQueue(Queue<int> queue)
        {
            // Step 1: Check for even number of elements
            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("Queue must have an even number of elements.");
                return;
            }

            int halfSize = queue.Count / 2;

            // Step 2: Store first half in a separate queue
            Queue<int> FirstHalf = new Queue<int>();
            for (int i = 0; i < halfSize; i++)
            {
                FirstHalf.Enqueue(queue.Dequeue());
            }

            // Step 3: Interleave both halves
            while (FirstHalf.Count > 0)
            {
                queue.Enqueue(FirstHalf.Dequeue()); // from first half
                queue.Enqueue(queue.Dequeue());     // from second half
            }
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            InterleaveQueue(queue);

            Console.WriteLine("Interleaved Queue: " + string.Join(", ", queue));

            Console.ReadKey();
        }
    }
}
```

---

## ✅ Output

```
Original Queue: 1, 2, 3, 4, 5, 6  
Interleaved Queue: 1, 4, 2, 5, 3, 6
```

---

## 🧠 Notes

- Works only for **even-length queues**.
- Time Complexity: **O(n)**  
- Space Complexity: **O(n)** for temporary storage.

---

## 📂 How to Run

1. Paste the code into a C# console application.
2. Run the program.
3. Observe interleaved output.

---
