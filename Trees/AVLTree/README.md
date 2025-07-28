# 📚 AVL Tree in C#

This project implements a self-balancing binary search tree (AVL Tree) in C#. It demonstrates key AVL operations such as insertion, deletion, searching, and printing.

## 🚀 Features
- Insert values while maintaining balance  
- Delete nodes while preserving AVL properties  
- Search for a value or retrieve a node  
- Visualize the tree structure in console  
- Automatically balances itself using Left/Right/Double rotations

## 🧠 What is an AVL Tree?
An AVL Tree is a self-balancing Binary Search Tree where the height difference (balance factor) between the left and right subtrees is at most 1 for every node. To maintain this balance, AVL Trees perform rotations (LL, RR, LR, RL) during insertion or deletion.

## 🔧 How to Use

### Inserting Elements
```csharp
int[] values = { 10, 20, 30, 40, 50, 25 };
foreach (var value in values)
{
    tree.Insert(value);
}
```

### Searching for a Value
```csharp
bool exists = tree.Exists(30); // returns true or false
AVLNode node = tree.Search(30); // returns the node or null
```

### Deleting a Value
```csharp
tree.Delete(20);
```

### Printing the Tree
```csharp
tree.PrintTree();
```

## 🧪 Sample Output
```
R----30  
     L----20  
     |    L----10  
     |    R----25  
     R----40  
          R----50  
```

Search for value 30: Found  
Search for value 60: Not Found

## 📁 File Structure

| File        | Description                            |
|-------------|----------------------------------------|
| Program.cs  | Contains Main() method to run tests    |
| AVLNode     | Node class holding value, height, links|
| AVLTree     | Logic for insert, delete, search, print|

## 🛠 Algorithms Used
- Insert: BST insert → update height → check balance → apply rotations  
- Delete: BST delete → update height → rebalance  
- Search: Standard recursive binary search  
- Rotations:
  - Left Rotation (RR)
  - Right Rotation (LL)
  - Left-Right (LR)
  - Right-Left (RL)

## 📚 Learning Purpose
This project is ideal for learning:
- Data structures (trees)
- Self-balancing algorithms
- Recursive programming
- Console debugging for tree traversal

## 👨‍💻 Author
Written in C# for educational and algorithmic demonstration purposes.
