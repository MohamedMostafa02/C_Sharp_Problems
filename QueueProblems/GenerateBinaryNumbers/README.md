# Generate Binary Numbers using Queue (C#)

This is a simple C# console application that generates the first `n` binary numbers using a queue, inspired by the Breadth-First Search (BFS) technique.

## 📌 Description

The goal is to generate binary numbers in order, from 1 to n.  
Instead of converting integers to binary, this solution builds the binary strings directly using a queue data structure.

We start with "1", then for each dequeued binary number, we enqueue two new numbers by appending "0" and "1".

## 💡 How It Works

1. Initialize a queue and enqueue the string `"1"`.
2. For `n` iterations:
   - Dequeue the front binary number.
   - Print it.
   - Enqueue two new binary numbers: current + `"0"` and current + `"1"`.

This ensures binary numbers are printed in correct order.

## 🖥️ Example Output

For `n = 5`, the output will be:
1  
10  
11  
100  
101

## ▶️ How to Run

1. Open the project in **Visual Studio** or any C# editor.
2. Build the project.
3. Run the program.
4. Change the value in `GenerateBinaryNumbers(n)` to test different outputs.

## ✅ Requirements

- .NET Core SDK / .NET Framework  
- C# version 7.0 or later

## 📂 Project Structure

GenerateBinaryNumbers/  
├── Program.cs ← Main logic  
├── GenerateBinaryNumbers.csproj  
└── README.md ← This file

## 📄 License

This project is open-source and free for educational use.
