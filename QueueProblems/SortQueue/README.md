# Sort Queue in C# 🌀

This is a simple C# console application that sorts the elements of a `Queue<int>` in ascending order using a temporary `List<int>`.

## 📌 Description

The .NET `Queue<T>` class does not support direct sorting.  
This program demonstrates how to:  
- Convert a queue to a list  
- Sort the list using `List.Sort()`  
- Rebuild a new queue from the sorted list  

This approach is simple and efficient for small queues.

## 💡 Example Output

Queue Before Sorting:  
5, 1, 3, 2, 4  

Queue After Sorting:  
1, 2, 3, 4, 5

## 🧠 How It Works

1. Create a queue of integers.  
2. Convert it to a list.  
3. Sort the list.  
4. Create a new queue from the sorted list.  
5. Print the original and sorted queues.

## ▶️ How to Run

- Open the project in Visual Studio or any C# editor.  
- Build and run the project.  
- Modify the `numbers` array to test different values.

## ✅ Requirements

- .NET Core SDK or .NET Framework  
- C# 7.0 or later

## 📄 License

This project is open-source and free for educational use.
