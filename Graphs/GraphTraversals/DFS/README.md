# Graph Traversal (Adjacency Matrix) in C#

This project implements a simple graph using an **adjacency matrix** in C#. It supports the following operations:

- **Add Edges** (directed or undirected)
- **Display Graph** (Adjacency Matrix)
- **Breadth-First Search (BFS)**

---

## 💻 Sample Output

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

## 📁 File Structure

/GraphTraversal
│
├── Graph.cs # Main Graph class implementation with BFS
├── README.md # Project description and usage


---

## ▶️ How to Run

1. Create a new Console App in Visual Studio.
2. Copy the contents of `Graph.cs` into `Program.cs`.
3. Build and run the project.

---

## 📌 Notes

- The graph can be directed or undirected based on enum selection.
- Vertices are identified by names like `"0"`, `"1"`, etc.
- All edges are weighted (default weight = 1).

---

## ✍️ Author

Mohamed Mostafa  

