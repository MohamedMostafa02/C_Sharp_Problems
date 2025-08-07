# ✅ Task Management System – C# Console App

This is a simple C# console application that simulates a **basic task management system** using `ObservableCollection` and real-time event handling. The app displays messages in the console whenever a task is **added** or **removed** from the list.

## ✅ Features
- Uses `ObservableCollection<string>` to store task names.
- Automatically detects and reports when tasks are added or removed.
- Displays real-time task updates in the console window.

## 🧠 How It Works
- A task list is created using `ObservableCollection<string>`.
- The `CollectionChanged` event is used to track changes in the collection.
- When a task is added or removed, the event handler displays the action using `Console.WriteLine`.

## 🖥 Example Output
Task Added: Complete report  
Task Added: Attend meeting  
Task Removed: Complete report

## ▶️ How to Compile and Run
1. Open Visual Studio.
2. Create a new **Console App (.NET Framework)** project.
3. Replace the code in `Program.cs` with the provided code.
4. Run the project using `Ctrl + F5`.

## 📦 Requirements
- .NET Framework
- Visual Studio or any C# compatible IDE
- Basic understanding of C# collections and events

## 👤 Author
Mohamed Mostafa  
Simple project for practicing `ObservableCollection` and event-driven programming in C#.
