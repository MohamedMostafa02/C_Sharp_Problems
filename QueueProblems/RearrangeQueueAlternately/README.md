# Rearrange Queue Alternately

This C# project demonstrates two methods to rearrange a queue alternately from the front and the back.

### 🧠 Problem Description

Given a queue of integers, the goal is to rearrange the elements alternately such that the output pattern is:

front, back, front+1, back-1, ...

---

### 📥 Example Input

Queue: 1 2 3 4 5 6

### 📤 Expected Output

Queue: 1 6 2 5 3 4

---

## 📌 Implemented Methods

### ✅ Method 1: `RearrangeAlternately` – Using List

- Converts the queue to a `List<int>`.
- Uses two pointers (start and end) to alternate between the front and back.
- Creates a new result queue.

**Pros**:
- Easy to implement and understand.
- Very readable.

**Cons**:
- Uses extra space (List + result Queue).

---

### ✅ Method 2: `RearrangeAlternately2` – Using Stack (In-Place)

- Uses only a single stack and operates directly on the original queue.
- First rotates the first half to the back to expose the second half.
- Pushes the second half into the stack to reverse it.
- Alternates elements from queue front and stack top.
- Handles odd-sized queues by appending the middle element at the end.

**Pros**:
- Space-efficient.
- In-place rearrangement.

**Cons**:
- Slightly more complex logic.

---

## 🚀 How to Run

1. Open the project in Visual Studio or any C# IDE.
2. Compile and run the project.
3. Output:

Using First Method:  
1, 6, 2, 5, 3, 4

Using Second Method:  
1, 6, 2, 5, 3, 4

---

## 🆚 Method Comparison

| Feature                  | Method 1 (List)     | Method 2 (Stack)        |
|--------------------------|---------------------|--------------------------|
| Code Simplicity          | ✅ Easy to understand | ❌ More involved         |
| Memory Usage             | ❌ More (List + Queue) | ✅ Efficient (only Stack) |
| In-place Rearrangement   | ❌ No                | ✅ Yes                    |
| Best For                 | Learning/debugging  | Performance-sensitive apps |

---

## 🧪 Test Data

You can test with other inputs like:

Queue: 10, 20, 30, 40, 50  
Expected Output: 10, 50, 20, 40, 30

---

## 📂 Project Structure

RearrangeQueueAlternately/  
├── Program.cs (Main program with both methods)  
└── README.md (This file)

---

## 📃 License

This project is free to use for learning and educational purposes.

---

## ✍️ Author

- Mohamed Mostafa
