
# File System Organization - C#

A simple console application that simulates a basic file system structure using a tree data model. The program allows representing directories and files, organizing them hierarchically, and printing the structure in a readable format.

## ✅ Features
- Represents both files and directories.
- Supports nested directories (hierarchical structure).
- Recursive printing of the file system with indentation.
- Easy to add more files or directories.

## 🧠 How It Works
- The `FileNode` class represents either a file or a directory.
- Each directory can contain a list of `FileNode` objects (children).
- The `Print` method uses recursion to traverse and print the entire file structure.
- The `Main` method builds a sample file system with one root directory, two subdirectories (`Documents` and `Photos`), and several files.

## 🖥 Example Output
File System:

Directory: root
  Directory: Documents
    File: Resume.docs
    File: Project.pdf
  Directory: Photos
    File: Vacation.jpg
    File: Diving.jpg
    File: Family.jpg

## ▶️ How to Compile and Run
1. Open the code in Visual Studio or any C# IDE.
2. Build the project.
3. Run the executable in the console.
4. The file system hierarchy will be printed to the console.

## 📦 Requirements
- .NET Framework or .NET Core SDK
- C# compiler

## 👤 Author
Created as a simple example to demonstrate tree structures, recursion, and basic object-oriented programming in C#.
