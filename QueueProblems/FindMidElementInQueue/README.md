# Find Middle Element in a Queue

🔍 **Description:**

This C# console application demonstrates how to **find the middle element in a queue**.  
It uses a simple approach by converting the queue to a list and accessing the middle index directly.

---

📌 **Key Concepts Used:**
- `Queue<T>`: Generic queue data structure.
- `List<T>`: Used to access elements by index.
- Indexing and queue conversion.

---

🧠 **How It Works:**

1. A queue is created with integers:  
   `{1, 2, 3, 4, 5, 6}`
2. The queue is converted to a list:  
   `List<int> list = new List<int>(queue);`
3. The middle index is calculated using `list.Count / 2`.
4. The element at the middle index is returned:
   - If queue size is even, it returns the **second middle element**.

---

📤 **Example Output:**
4

The middle element in `{1, 2, 3, 4, 5, 6}` is `4` (second middle).

---

🚫 **Notes:**
- This method doesn't modify the original queue.
- Not efficient for very large queues (O(n) due to conversion to list).

---

🛠️ **How to Run:**

1. Open the solution in **Visual Studio**.
2. Set `FindMidElementInQueue` as the startup project.
3. Press `Ctrl + F5` to run without debugging.

---

👤 **Author:** Mohamed Mostafa  
📁 **Project Folder:** `QueueProblems/FindMidElementInQueue`  
📌 **Language:** C# (.NET Framework 4.7.2)

---


