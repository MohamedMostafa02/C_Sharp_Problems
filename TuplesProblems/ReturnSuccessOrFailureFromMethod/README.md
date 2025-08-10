# Return Success or Failure From Method - C#  
A simple C# console application that demonstrates how to return multiple values from a method using tuples, specifically a success flag and an integer value.  
## ✅ Features  
- Returns multiple values from a method using tuples.  
- Uses a boolean flag to represent success or failure.  
- Demonstrates the use of the ternary operator for condition checks.  
- Displays the results in a formatted output.  
## 🧠 How It Works  
1. The `CheckStudentStatus` method takes an integer input (e.g., a student's score).  
2. If the score is greater than or equal to 50, `success` is set to `true`; otherwise, `false`.  
3. The method returns a tuple `(success, input)`.  
4. In `Main`, the method is called with a score of 55 and the returned tuple is stored in `result`.  
5. The program prints whether the operation was successful and the original value.  
6. The program waits for the user to press a key before closing.  
## 🖥 Example Output  
Success: True, Value: 55  
## ▶️ How to Compile and Run  
1. Open the project in Visual Studio or any C# IDE.  
2. Build the solution (Ctrl + Shift + B).  
3. Run the program (F5 or Ctrl + F5).  
## 📦 Requirements  
- .NET Framework or .NET Core SDK  
- A C# compiler (included with Visual Studio)  
## 👤 Author  
Mohamed Mostafa  
