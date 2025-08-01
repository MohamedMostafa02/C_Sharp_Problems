# 👥 Customer Service Queue in C#

This project demonstrates a basic **Customer Service Simulation** using a **Queue** in C#. It processes customers in the order they arrive — following the **First-In, First-Out (FIFO)** principle.

---

## 📋 Project Description

The program simulates a customer service line. Customers are added to a queue and served one by one in the same order they entered. This is a typical real-world example of queue usage in software systems like ticket counters, help desks, etc.

---

## 💡 Core Concepts

- Uses the `Queue<string>` class in C#.
- Customers are added using `Enqueue()`.
- Customers are served using `Dequeue()`.
- Processing continues until the queue is empty.

---

## 🧪 Sample Output

```
Serving Customers:

Serving: Customer1  
Serving: Customer2  
Serving: Customer3
```

---

## 📁 Project Structure

```
CustomerService/
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
