# Graph Representation using Adjacency Matrix in C#

This C# console project demonstrates how to build and manage graphs using an **adjacency matrix**. It supports both **directed** and **undirected** graphs.

---

## ✅ Features

- Add and remove edges (with weight support)
- Check if an edge exists between two vertices
- Display the full adjacency matrix
- Compute **InDegree** and **OutDegree** of any vertex
- Handles invalid vertex names gracefully

---

## 📦 How It Works

- Vertices are stored as strings and mapped to matrix indices using a dictionary.
- The adjacency matrix stores the weight of edges (0 if no edge).
- The graph direction is defined during construction (`Directed` or `unDirected`).

---

## 📌 Example Output

A B C D E
A 0 5 3 0 0
B 5 0 0 12 2
C 3 0 0 10 0
D 0 12 10 0 7
E 0 2 0 7 0
 


---

## 🚀 Getting Started

1. Open the project in **Visual Studio** or any C# IDE.
2. Paste the full code in a **Console App**.
3. Press `Ctrl + F5` to run and view the output.

---

## 🧪 Methods Overview

- `AddEdge(string source, string destination, int weight)`
- `RemoveEdge(string source, string destination)`
- `IsEdge(string source, string destination)` → returns `true/false`
- `GetInDegree(string vertex)` → counts incoming edges
- `GetOutDegree(string vertex)` → counts outgoing edges
- `DisplayGraph(string message)` → prints the matrix

---

## 📚 Examples Included

- Undirected graph
- Directed graph (with loop on A)
- Weighted graph
- Edge removal demonstration
- Degree checks and edge existence testing

---

## 👨‍💻 Author

**Mohamed Mostafa**  

