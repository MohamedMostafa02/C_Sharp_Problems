# Binary Search Tree (BST) Traversals

Traversing a Binary Search Tree (BST) means visiting each node in a specific order. There are four main types of traversal:

---

## 1. Inorder Traversal (Left → Root → Right)

**Description:**  
- Traverse the left subtree  
- Visit the root  
- Traverse the right subtree  

**Use Case:**  
Returns the elements of a BST in **sorted (ascending) order**.

**Time Complexity:**  
- Best, Average, Worst: `O(n)`

---

## 2. Preorder Traversal (Root → Left → Right)

**Description:**  
- Visit the root  
- Traverse the left subtree  
- Traverse the right subtree  

**Use Case:**  
Used to **serialize** or **copy** the tree structure.

**Time Complexity:**  
- Best, Average, Worst: `O(n)`

---

## 3. Postorder Traversal (Left → Right → Root)

**Description:**  
- Traverse the left subtree  
- Traverse the right subtree  
- Visit the root  

**Use Case:**  
Used to **delete** the tree or **evaluate expressions**.

**Time Complexity:**  
- Best, Average, Worst: `O(n)`

---

## 4. Level Order Traversal (Breadth-First Search)

**Description:**  
- Traverse nodes **level by level** from top to bottom, and left to right  
- Uses a **queue** to manage the order of traversal  

**Use Case:**  
Useful for **printing** the tree level-by-level, or for **shortest path** problems in unweighted trees.

**Time Complexity:**  
- Best, Average, Worst: `O(n)`

---

## Summary Table

| Traversal Type   | Order               | Use Case                        | Output on BST         |
|------------------|---------------------|----------------------------------|------------------------|
| Inorder          | Left → Root → Right | Sorted Output                   | Sorted Values          |
| Preorder         | Root → Left → Right | Serialization, Copy Tree        | Root First Order       |
| Postorder        | Left → Right → Root | Deletion, Postfix Eval          | Root Last Order        |
| Level Order      | Level by Level      | BFS, Print by Level             | Breadth-First Order    |

---

## Notes

- All traversal types visit each node exactly once: **Time complexity is O(n)**
- Traversals can be implemented using **recursion** or **iteration** (stack or queue).
- BST follows the rule: **Left < Root < Right**
