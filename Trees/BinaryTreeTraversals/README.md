# Binary Tree Traversals

Tree traversal is the process of visiting (checking and/or updating) each node in a tree data structure exactly once. In Binary Trees, there are several ways to traverse the nodes. The most common traversal methods are:

---

## 1. Inorder Traversal (Left, Root, Right)

**Description:**  
Visit the left subtree, then the root node, and finally the right subtree.

**Use Case:**  
Used to get nodes of a Binary Search Tree (BST) in non-decreasing sorted order.

**Algorithm Steps:**
1. Traverse the left subtree.
2. Visit the root node.
3. Traverse the right subtree.

**Time Complexity:**  
- Worst, Average, Best: `O(n)` where `n` is the number of nodes.

---

## 2. Preorder Traversal (Root, Left, Right)

**Description:**  
Visit the root node first, then the left subtree, and finally the right subtree.

**Use Case:**  
Used to copy or serialize the tree structure.

**Algorithm Steps:**
1. Visit the root node.
2. Traverse the left subtree.
3. Traverse the right subtree.

**Time Complexity:**  
- `O(n)` for all cases.

---

## 3. Postorder Traversal (Left, Right, Root)

**Description:**  
Traverse the left subtree, then the right subtree, and finally visit the root node.

**Use Case:**  
Used to delete the tree or evaluate postfix expressions.

**Algorithm Steps:**
1. Traverse the left subtree.
2. Traverse the right subtree.
3. Visit the root node.

**Time Complexity:**  
- `O(n)` in all cases.

---

## 4. Level Order Traversal (Breadth-First Search)

**Description:**  
Traverse nodes level by level from top to bottom and left to right.

**Use Case:**  
Useful for printing the tree level by level or finding the shortest path in an unweighted tree.

**Algorithm Steps:**
1. Use a queue.
2. Enqueue the root node.
3. While the queue is not empty:
   - Dequeue a node and visit it.
   - Enqueue its left and right children (if they exist).

**Time Complexity:**  
- `O(n)`

---

## Summary Table

| Traversal Type   | Order               | Use Case                              |
|------------------|---------------------|----------------------------------------|
| Inorder          | Left, Root, Right   | Sorted order of BST                   |
| Preorder         | Root, Left, Right   | Copying/Serialization                 |
| Postorder        | Left, Right, Root   | Deleting or postfix evaluation        |
| Level Order      | Level by Level      | BFS, shortest path, printing levels   |

---

## Notes

- All traversal methods visit every node exactly once: `O(n)` time.
- Recursive and iterative (stack/queue-based) implementations exist.
