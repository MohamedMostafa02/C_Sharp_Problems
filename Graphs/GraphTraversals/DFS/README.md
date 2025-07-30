# Graph Traversal in C# (Adjacency Matrix)

This project demonstrates how to implement a **graph** in C# using an **adjacency matrix** along with **BFS (Breadth-First Search)** and **DFS (Depth-First Search)** traversal algorithms.

---

## 📌 Features

- Supports **directed** and **undirected** graphs.
- Uses an **adjacency matrix** for internal representation.
- Allows adding weighted edges between vertices.
- Includes:
  - `DisplayGraph()` to print the adjacency matrix.
  - `BFS(startVertex)` traversal.
  - `DFS(startVertex)` traversal.

---

## 📦 File Structure

GraphTraversal/
├── Graph.cs
└── README.md


---

## ✅ Example Graph

Vertices:
0, 1, 2, 3, 4


Edges:

0 ↔ 1
0 ↔ 2
0 ↔ 3
2 ↔ 3
2 ↔ 4


---

## 🧠 Sample Output

Adjacency Matrix (Undirected Graph):

0 1 2 3 4
0 0 1 1 1 0
1 1 0 0 0 0
2 1 0 0 1 1
3 1 0 1 0 0
4 0 0 1 0 0

Depth-First Search:
0 3 2 4 1


---

## 🚀 How to Run

1. Open the solution in **Visual Studio** or any C# editor.
2. Compile and run `Graph.cs`.
3. Observe the printed matrix and DFS result.

---

## 🛠️ How to Edit this README in GitHub

1. Go to your repository on GitHub.
2. Navigate to the folder: `Trees/GraphTraversal` (or the folder where `README.md` is located).
3. Click on the file `README.md`.
4. Click the **pencil icon (Edit this file)** in the upper right.
5. Make your changes.
6. Scroll down and write a **commit message** (e.g., "Update README with output").
7. Click **Commit changes**.

✅ That's it — the file is now updated!

---

## 🔗 Related Topics

- Adjacency Matrix vs. Adjacency List
- Graph Traversals
- C# Data Structures

---

## 📧 Author

Mohamed Mostafa  

