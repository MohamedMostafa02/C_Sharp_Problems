# Dynamic List of Students in Classroom - C# Console App

This simple C# console application demonstrates how to use the `ObservableCollection<T>` class to track changes (additions and removals) in a dynamic list of students in a classroom. The program reacts in real-time to changes by printing messages to the console whenever a student is added or removed.

## ✅ Features
- Uses `ObservableCollection<string>` to hold student names.
- Subscribes to the `CollectionChanged` event.
- Detects and logs added or removed students using lambda expression.
- Demonstrates basic reactive programming with collections in .NET.

## 🧠 How It Works
- An observable collection `students` is created.
- A lambda event handler is attached to the `CollectionChanged` event.
- When a student is added using `.Add()`, the event fires and logs: `"New Student Added: {StudentName}"`
- When a student is removed using `.Remove()`, the event fires and logs: `"Student Removed: {StudentName}"`

## 🖥 Example Output
New Student Added: Alice  
New Student Added: Bob  
Student Removed: Alice

## ▶️ How to Compile and Run
1. Open the project in Visual Studio or any C# IDE.
2. Make sure `System.Collections.ObjectModel` and `System.Collections.Specialized` namespaces are included.
3. Press **F5** to run or use `dotnet run` in terminal if using .NET Core.

## 📦 Requirements
- .NET Framework or .NET Core
- C# Compiler
- Console Application Environment

## 📄 Full Source Code
using System;  
using System.Collections.ObjectModel;  
using System.Collections.Specialized;  
  
namespace DynamicListOfStudentsInClassroom  
{  
    internal class Program  
    {  
        static void Main(string[] args)  
        {  
            ObservableCollection<string> students = new ObservableCollection<string>();  
  
            // Subscribe to collection change events  
            students.CollectionChanged += (sender, e) =>  
            {  
                if (e.Action == NotifyCollectionChangedAction.Add)  
                    Console.WriteLine($"New Student Added: {e.NewItems[0]}");  
                if (e.Action == NotifyCollectionChangedAction.Remove)  
                    Console.WriteLine($"Student Removed: {e.OldItems[0]}");  
            };  
  
            // Add and remove students  
            students.Add("Alice");  
            students.Add("Bob");  
            students.Remove("Alice");  
  
            Console.ReadKey();  
        }  
    }  
}

## 👤 Author
Mohamed Mostafa  
Simple console demo project using `ObservableCollection` to teach C# event handling.
