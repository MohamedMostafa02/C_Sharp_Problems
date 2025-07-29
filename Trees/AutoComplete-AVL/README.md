# 🔍 AVL Tree with AutoComplete Feature in C#

This project implements a **Self-Balancing AVL Tree** in C# with support for:
- Insertion
- Deletion
- Search
- Tree Printing
- **Auto-complete** functionality based on prefix matching

---

## 📌 Description

An AVL Tree is a type of Binary Search Tree (BST) that maintains balance by ensuring that the height difference (balance factor) between left and right subtrees of any node is at most 1.

This project extends the AVL tree by implementing an **AutoComplete** method that returns all words starting with a given prefix.

---

## ✅ Features

- ⚙️ Self-Balancing Insertions and Deletions  
- 🔎 Efficient Search (O(log n))  
- 🌲 ASCII Tree Visualization in Console  
- ✨ AutoComplete functionality using prefix search  
- 📁 Well-commented and organized C# code  

---

## 🧪 Example

### Inserted Words:
```text
Ahmad, Mohammed, Motasem, Mohab, Abla, Abeer, Abdullah, Abbas, Montaser, Khalil, Khalid
```

### Sample Run:
```
Enter a prefix to search:
Mo

Suggestions for 'Mo':
Mohammed
Motasem
Mohab
Montaser
```

---

## 📂 Project Structure

```
/AVLTreeAutoComplete
│
├── Program.cs        # Main logic to test and demonstrate the tree
├── AVLTree.cs        # Core AVL Tree implementation with AutoComplete
├── README.md         # You are here!
```

---

## 📌 How It Works

- **Insert:** Maintains AVL balance using Left/Right/Double Rotations.  
- **AutoComplete:** Traverses the tree to collect all words starting with a given prefix using recursive logic.  
- **Delete:** Handles all AVL rebalancing after deletion.  
- **PrintTree():** Displays the tree in a readable rotated format for debugging.  

---

## 🧠 Why Use This?

Although .NET provides built-in data structures, implementing core data structures like AVL trees helps deepen your understanding of:
- Algorithmic logic
- Tree balancing
- Recursion
- Efficient searching

---

## 🚀 Getting Started

### Requirements:
- .NET Framework or .NET Core
- IDE: Visual Studio / Visual Studio Code

### Run the Project:
1. Clone the repo:
```bash
git clone https://github.com/your-username/AVLTreeAutoComplete.git
cd AVLTreeAutoComplete
```
2. Open in Visual Studio and run the project.

---

## ✍️ Author

**Mohamed Mostafa**

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).


