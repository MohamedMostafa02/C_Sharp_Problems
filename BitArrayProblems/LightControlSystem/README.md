# Light Control System - C#  
A simple C# console application that simulates controlling lights using a `BitArray`, where each bit represents the state (on/off) of a light.  
## ✅ Features  
- Uses `BitArray` to efficiently store light states as boolean values.  
- Allows turning individual lights on or off by index.  
- Supports resetting all lights to off with one method call.  
- Displays light states before and after reset.  
## 🧠 How It Works  
1. A `BitArray` with 8 elements is created, all initially set to `false` (off).  
2. The program turns on the first light (index 0) and the sixth light (index 5).  
3. It prints the state of these lights to the console.  
4. The `SetAll(false)` method is used to turn all lights off at once.  
5. The program prints the state of the first light after the reset.  
6. The program waits for a key press before closing.  
## 🖥 Example Output  
Light 1: True, Light 6: True  
Light 1 After reset: False  
## ▶️ How to Compile and Run  
1. Open the project in Visual Studio or any C# IDE.  
2. Build the solution (Ctrl + Shift + B).  
3. Run the program (F5 or Ctrl + F5).  
## 📦 Requirements  
- .NET Framework or .NET Core SDK  
- A C# compiler (included with Visual Studio)  
## 👤 Author  
Mohamed Mostafa  

