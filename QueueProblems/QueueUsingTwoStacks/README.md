# Queue Using Two Stacks (C#)

This project demonstrates how to implement a **Queue** using **two Stacks** in C#. The goal is to simulate FIFO (First-In-First-Out) behavior using two LIFO (Last-In-First-Out) data structures.

## 📌 How It Works

- `stack1` is used to store elements as they are enqueued.
- `stack2` is used when dequeuing or peeking.
- When `stack2` is empty and a dequeue/peek is requested, all elements are transferred from `stack1` to `stack2`, reversing their order to maintain queue behavior.

## 🧠 Methods

- `Enqueue(int value)`: Adds an element to the queue.
- `Dequeue()`: Removes and returns the front element.
- `Peek()`: Returns the front element without removing it.
- `IsEmpty()`: Checks if the queue is empty.

## 🧪 Example Usage

```csharp
MyQueue queue = new MyQueue();
queue.Enqueue(1);
queue.Enqueue(2);
Console.WriteLine(queue.Peek());    // Output: 1
Console.WriteLine(queue.Dequeue()); // Output: 1
Console.WriteLine(queue.Dequeue()); // Output: 2

1
1
2

🛠 Technologies
Language: C#

Type: Console Application

Framework: .NET Core / .NET Framework

📁 File Structure
Program.cs — Contains the Main method and sample usage.

MyQueue.cs — Contains the queue implementation logic using two stacks.

📘 License
Free to use for educational and non-commercial purposes
