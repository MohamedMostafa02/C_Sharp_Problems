# Merge Two Sorted Queues

This C# console application merges two **sorted** queues into one sorted queue using the `Queue<T>` data structure.

> ✅ Both input queues must be sorted in ascending order.  
> ❌ If either queue is unsorted, the final result will also be unsorted.

---

## 📌 Description

- The method `MergeQueues(Queue<int> q1, Queue<int> q2)` merges two sorted queues by:
  - Comparing the front elements of each queue using `Peek()`
  - Dequeuing the smaller element and enqueuing it into the result queue
  - Repeating the process until all elements are merged

---

## 🧠 How it works (Step-by-step):

1. Create an empty result queue.
2. While both `q1` and `q2` have elements:
   - Compare the front elements.
   - Dequeue the smaller one and enqueue it into the result.
3. Add remaining elements from either queue to the result.

---

## 📦 Example

```csharp
Queue<int> q1 = new Queue<int>(new[] { 1, 3, 5 });
Queue<int> q2 = new Queue<int>(new[] { 2, 4, 6 });

Queue<int> result = MergeQueues(q1, q2);
Console.WriteLine(string.Join(", ", result));
```

**Output:**
```
1, 2, 3, 4, 5, 6
```

---

## 🛠 Technologies

- C#
- .NET Framework / .NET Core

---

## 📁 How to Run

1. Open the project in Visual Studio or any C# editor.
2. Paste the code in `Program.cs`.
3. Run the program (Ctrl + F5).

---

## ⚠️ Note

If you pass unsorted queues like:

```csharp
Queue<int> q1 = new Queue<int>(new[] { 5, 1, 3 });
Queue<int> q2 = new Queue<int>(new[] { 2, 4, 6 });
```

Then the merged output will be:
```
2, 4, 5, 1, 3, 6
```

✅ So make sure to sort the queues before merging if needed.
