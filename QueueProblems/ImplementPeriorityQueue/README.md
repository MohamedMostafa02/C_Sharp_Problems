# 🧮 Priority Queue Implementation in C#

This project demonstrates how to implement a **Priority Queue** using `SortedDictionary` in C#.  
Each element has an associated priority. Elements with **lower priority numbers are dequeued first** (i.e., `1` is higher priority than `2`).

---

## 📂 Project Structure

- `PriorityQueue` class:
  - Uses `SortedDictionary<int, Queue<int>>` where:
    - `int` → the priority
    - `Queue<int>` → the values associated with that priority (FIFO order)

---

## 🚀 Features

✅ Add elements with a priority  
✅ Automatically orders by priority (smallest key = highest priority)  
✅ Supports multiple items with the same priority  
✅ Returns `null` if the queue is empty (`int?` used)

---

## 🧠 Code Overview

```csharp
PriorityQueue pq = new PriorityQueue();

pq.Enqueue(10, 3);  // Value 10 with priority 3
pq.Enqueue(5, 1);   // Value 5 with priority 1
pq.Enqueue(20, 2);  // Value 20 with priority 2

Console.WriteLine(pq.Dequeue());  // Output: 5 (priority 1 is highest)
```

---

## 📌 Why `int?`?

We use `int?` instead of `int` in `Dequeue()` to allow returning `null` when the queue is empty.

```csharp
public int? Dequeue()
{
    if (queue.Count == 0) return null;
    ...
}
```

---

## 📦 Output

```
5
```

---

## 🔧 How to Run

1. Open the project in Visual Studio
2. Build the project
3. Run the application

---

## 📝 Author

Mohamed Mostafa  
[GitHub Profile](https://github.com/MohamedMostafa02)

---

## 💡 Notes

- If you want `Max-Priority` behavior (where **larger** numbers have higher priority), replace `queue.Keys.Min()` with `queue.Keys.Max()`.
- You can throw exceptions instead of returning `null` if preferred.

