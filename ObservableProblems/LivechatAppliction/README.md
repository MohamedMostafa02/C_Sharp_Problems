# 💬 Live Chat Application – C# Console App

This is a simple C# console application that simulates a **live chat system** using `ObservableCollection` and real-time event handling. Every time a new message is added, it’s instantly displayed on the console.

## ✅ Features
- Uses `ObservableCollection<string>` to store incoming chat messages.
- Automatically displays new messages as soon as they are added.
- Demonstrates event-driven programming using `CollectionChanged`.

## 🧠 How It Works
- A collection called `chatMessages` is created to store the chat.
- The `CollectionChanged` event is subscribed to, to detect when new messages arrive.
- When a message is added, the event handler prints it with the label `New Message:`.

## 🖥 Example Output
New Message: Hello  
New Message: How Are You?

## ▶️ How to Compile and Run
1. Open Visual Studio.
2. Create a new **Console App (.NET Framework)** project.
3. Paste the code into `Program.cs`.
4. Press `Ctrl + F5` to run the program.

## 📦 Requirements
- .NET Framework
- C# compiler
- Visual Studio or equivalent IDE

## 👤 Author
Mohamed Mostafa  
A basic demo of real-time updates using `ObservableCollection` in C#.

