# 🌐 Web Page Request Handling in C#

This project simulates a basic **web page request handling system** using a **Queue** in C#. It demonstrates how incoming web requests can be processed in the order they are received using a FIFO (First-In, First-Out) strategy.

---

## 📋 Project Description

Web servers often need to handle multiple incoming requests. This simple simulation uses a `Queue<string>` to represent incoming requests and processes them one by one, maintaining the order in which they arrived.

---

## 💡 Core Concepts

- **Queue** is used to manage incoming requests.
- Requests are added using `Enqueue()`.
- Requests are processed in order using `Dequeue()`.
- The simulation continues until the queue is empty.

---

## 🧪 Sample Output

```
Processing Web Page Requests:

Processed: Request1  
Processed: Request2  
Processed: Request3  
Processed: Request4
```

---

## 📁 Project Structure

```
WebPageRequestHandling/
│
├── Program.cs      ← Main source code
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
