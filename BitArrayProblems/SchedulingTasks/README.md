# Scheduling Tasks - C# Console Application  
This project demonstrates how to use **BitArray** in C# to manage a weekly schedule efficiently, storing information about which days are busy and which are free using minimal memory.  
## ✅ Features  
- Uses `BitArray` to represent 7 days of the week in a compact form.  
- Demonstrates marking specific days as busy or free.  
- Prints out the days that are free for tasks or activities.  
## 🧠 How It Works  
- A `BitArray` of size 7 is created, with all values initially set to `true` (meaning all days are busy).  
- Two days (day 6 and day 7) are marked as free by setting their values to `false`.  
- A loop checks each day, and if a day is `false`, it prints that day as free.  
## 🖥 Example Output  
Free Days:  
Day 6  
Day 7  
## ▶️ How to Compile and Run  
1. Open the project in **Visual Studio** or any C# IDE.  
2. Copy the code into a `.cs` file.  
3. Build and run the project (`Ctrl + F5`).  
## 📦 Requirements  
- .NET Framework or .NET Core SDK installed.  
- C# compiler (included with Visual Studio).  
## 👤 Author  
Developed by Mohamed Mostafa as a learning example for scheduling tasks with `BitArray` in C#.  
