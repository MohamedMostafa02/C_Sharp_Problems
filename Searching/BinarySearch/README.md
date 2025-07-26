# Binary Search

This project implements the Binary Search algorithm in C#.

## 📌 Description  
Binary Search is an efficient algorithm used to find the position of a target value within a **sorted array**.  
It works by repeatedly dividing the search interval in half. If the target value is equal to the middle element, the search is successful. Otherwise, the search continues on the half in which the target may lie.

## ✅ Example  
Unsorted: [3, 1, 5, 2, 4]  
Sorted: [1, 2, 3, 4, 5]  
Target: 3  
Result: Found at index 2

## 🧠 Time Complexity  
- Best Case: O(1) — when the middle element is the target  
- Average Case: O(log n)  
- Worst Case: O(log n)

## 📁 Files  
- `Program.cs`: Contains the full implementation of Binary Search in C#.
