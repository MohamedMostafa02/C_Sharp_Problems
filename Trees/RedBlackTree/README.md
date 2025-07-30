# Red-Black Tree in C#

This project implements a **Red-Black Tree** in C#. It supports the following operations:

- **Insertion**
- **Search**
- **Deletion**
- **Tree Printing (Console Visual)**
- Maintains Red-Black properties automatically after each operation.

---

## 🔧 Features

- **Self-Balancing BST** using Red-Black properties
- Efficient operations:  
  - `Insert(int value)`  
  - `Delete(int value)`  
  - `Find(int value)`  
  - `PrintTree()` – console-friendly tree view
- Includes **color handling** (Red/Black)
- Fully tested with sample data in `Main()`

---

## 📁 Project Structure

- `RedBlackTree` class  
  - Node class (nested)  
  - Insert with balancing (`FixInsert`)  
  - Delete with balancing (`FixDelete`)  
  - Rotations (`RotateLeft`, `RotateRight`)  
  - Tree traversal & printing  

- `Program` class  
  - Initializes and tests the Red-Black Tree with sample input  
  - Demonstrates Insert, Search, Delete, and Print  

---

## 🧪 Sample Output (PrintTree)

- `R----` = Right child  
- `L----` = Left child  
- `(RED)` / `(BLK)` indicates node color

Example:
R----20(BLK)
L----15(RED)
R----25(RED) 



---

## 📌 How to Use

1. **Clone / Copy** the code.
2. **Compile & Run** in any C# environment (e.g., Visual Studio, .NET CLI).
3. Modify the values in `Main()` as needed.
4. Output is printed in console.

---

## ✅ Notes

- Red-Black properties ensure:
  - Root is always black
  - No two consecutive red nodes
  - Balanced height: O(log n)
- This is an educational implementation, great for understanding how RBTs work internally.

---

## 📚 References

- [Wikipedia: Red-Black Tree](https://en.wikipedia.org/wiki/Red%E2%80%93black_tree)
- [CLRS Book - Introduction to Algorithms, Red-Black Tree Chapter]

---

## 👨‍💻 Author

- **Name**: Mohamed  
- **Language**: C#  
- **Purpose**: Educational, Demonstration of Red-Black Tree logic

