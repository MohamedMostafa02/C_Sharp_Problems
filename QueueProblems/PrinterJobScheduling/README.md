# 🖨️ Printer Job Scheduling using Queue (C# Console App)

This is a simple C# console application that simulates a **printer job queue** using the `Queue` data structure.

## 📌 Description

In a real printer system, print jobs are handled in the order they arrive — **First In, First Out (FIFO)**.  
This program mimics that behavior using a `Queue<string>` to manage and process print jobs.

## 🧠 Concepts Used

- `Enqueue()` – Add a new print job to the queue
- `Dequeue()` – Process (remove) the first job in the queue
- `Peek()` – View the next job without removing it

## 💻 Code Example

```csharp
Queue<string> printQueue = new Queue<string>();

printQueue.Enqueue("Document1");
printQueue.Enqueue("Document2");
printQueue.Enqueue("Document3");

Console.WriteLine("Processing: " + printQueue.Dequeue()); // Output: Document1
Console.WriteLine("Next Job: " + printQueue.Peek());      // Output: Document2
```

## 🧪 Output

```
Processing: Document1
Next Job: Document2
```

## 📁 Project Structure

```
PrinterJobScheduling/
│
├── Program.cs       # Main program logic
├── README.md        # This documentation file
```

## ✅ Requirements

- .NET Framework or .NET Core
- Any C# IDE (e.g., Visual Studio)

---

This is a basic example of how queues work in real-world scenarios. You can enhance it by adding:
- Priority-based printing
- Job cancelation
- Estimated time display
