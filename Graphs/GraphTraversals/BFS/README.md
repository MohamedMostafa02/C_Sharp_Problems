# Graph Representation with BFS using Adjacency Matrix in C#

This C# console application demonstrates how to implement a **graph** using an **adjacency matrix** and how to perform **Breadth-First Search (BFS)** traversal.

---

## ✅ Features

- Create a graph (directed or undirected)
- Add weighted edges between vertices
- Display the adjacency matrix of the graph
- Perform Breadth-First Search (BFS) from a starting vertex
- Handles invalid vertices gracefully

---

## 📦 How It Works

- Vertices are represented by a list of strings (e.g., `"0"`, `"1"`, etc.).
- The graph is stored internally using a 2D array (`int[,]`) as an adjacency matrix.
- A dictionary maps vertex names to their matrix indices.
- BFS traversal uses a queue and a `visited[]` array to explore the graph level by level.

---

## 🧪 Methods Overview

- `AddEdge(string source, string destination, int weight)`  
  Adds a weighted edge between two vertices.
  
- `DisplayGraph(string message)`  
  Prints the adjacency matrix of the graph.

- `BFS(string startVertex)`  
  Performs a breadth-first traversal from the specified start vertex.

---

## 🧾 Example Output

Adjacency Matrix (Undirected Graph):

0 1 2 3 4
0 0 1 1 0 0
1 1 0 1 1 0
2 1 1 0 1 1
3 0 1 1 0 0
4 0 0 1 0 0

Breadth-First Search:
0 1 2 3 4



---

## 🚀 How to Run

1. Open **Visual Studio**
2. Create a new **Console Application**
3. Paste the full code
4. Press `Ctrl + F5` to run and view the output

---

## 👨‍💻 Author

**Mohamed Mostafa**  

