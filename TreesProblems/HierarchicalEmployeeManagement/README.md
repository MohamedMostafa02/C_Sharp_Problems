
# Hierarchical Employee Management - C#

A simple console application that simulates a company's organizational chart using a tree data structure. It represents employees, their positions, and hierarchical relationships, and prints the structure in a readable format.

## ✅ Features
- Represents employees and their positions.
- Supports nested hierarchical relationships (manager-subordinate).
- Recursive printing of the company hierarchy with indentation.
- Easy to expand with more employees and positions.

## 🧠 How It Works
- The `EmployeeNode` class represents an employee and contains:
  - `Name` (employee's name)
  - `Position` (job title)
  - `Subordinates` (list of direct reports)
- The `Print` method uses recursion to traverse and display the hierarchy with indentation for visual clarity.
- The `Main` method builds a sample company hierarchy starting with a CEO, adding vice presidents, and their subordinates.

## 🖥 Example Output
Company Hierarchy
CEO: Alice
  VP Of Marketing: Bob
    Marketing Manager: Charlie
  VP Of Technology: Lara
    Architect: Tom

## ▶️ How to Compile and Run
1. Open the code in Visual Studio or any C# IDE.
2. Build the project.
3. Run the executable in the console.
4. The company hierarchy will be displayed.

## 📦 Requirements
- .NET Framework or .NET Core SDK
- C# compiler

## 👤 Author
Created as a simple example to demonstrate tree structures, recursion, and object-oriented programming in C#.
