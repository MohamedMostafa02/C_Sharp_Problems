# Optimizing Space in Large Data - C# Console Application  
This project demonstrates how to use **BitArray** in C# to efficiently store large amounts of boolean data, such as tracking seat bookings in a theater or stadium, while minimizing memory usage.  
## ✅ Features  
- Uses `BitArray` for memory-efficient storage of boolean values.  
- Demonstrates booking and checking specific seats.  
- Shows how indexing works with `BitArray` (0-based indexing).  
## 🧠 How It Works  
- A `BitArray` is created with 1000 bits, all initialized to `false` (meaning all seats are unbooked).  
- Specific seats (101 and 1000) are booked by setting their corresponding bit to `true`.  
- The program then displays whether these seats are booked using `Console.WriteLine`.  
## 🖥 Example Output  
Seat 101 booked: True  
Seat 1000 booked: True  
## ▶️ How to Compile and Run  
1. Open the project in **Visual Studio** or any C# IDE.  
2. Copy the code into a `.cs` file.  
3. Build and run the project (`Ctrl + F5`).  
## 📦 Requirements  
- .NET Framework or .NET Core SDK installed.  
- C# compiler (included with Visual Studio).  
## 👤 Author  
Developed by Mohamed Mostafa as a learning example for optimizing boolean data storage in C#.  
