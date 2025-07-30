# Graph Representation using Adjacency List in C#

This project implements a graph data structure using an **Adjacency List** in C#. It supports both **Directed** and **Undirected** graphs with **weighted edges**.

---

## ✅ Features

- Add and remove edges between vertices (with weights)
- Check if an edge exists between two vertices
- Display the adjacency list representation
- Compute **InDegree** and **OutDegree** for any vertex
- Gracefully handles invalid vertices

---

## 🛠️ How It Works

- The graph stores vertices in a dictionary: each key is a vertex, and its value is a list of neighbors and edge weights.
- A second dictionary maps vertex names to indices (for degree calculations).
- The graph direction (directed or undirected) is set during construction.

---

## 📦 Example Output

A -> B(1) C(1)
B -> A(1) D(1) E(1)
C -> A(1) D(1)
D -> B(1) C(1) E(1)
E -> B(1) D(1)




---

## 🧪 Methods Overview

- `AddEdge(string source, string destination, int weight)`  
- `RemoveEdge(string source, string destination)`  
- `DisplayGraph(string message)`  
- `IsEdge(string source, string destination)` → returns `true/false`  
- `GetInDegree(string vertex)` → returns count of incoming edges  
- `GetOutDegree(string vertex)` → returns count of outgoing edges  

---

## 📚 Examples Demonstrated

1. **Undirected graph** with 5 nodes and sample connections
2. **Directed graph** with loops and multiple edges
3. **Weighted graph** with meaningful edge weights
4. Removing an edge and re-displaying the graph
5. Checking edge existence and computing degrees

---

## 🚀 How to Run

1. Open the solution in **Visual Studio**
2. Create a new **Console Application**
3. Paste the full code from the `.cs` file
4. Press `Ctrl + F5` to run

---

## 👨‍💻 Author

**Mohamed Mostafa**  

