# Flight Seat Reservations - C# Console Application

This is a simple C# console program that demonstrates the use of a **jagged boolean array** to represent seat availability for multiple flights. Each flight can have a different number of seats, and each seat can be either available or occupied.

## ✅ Features
- Uses a jagged array of booleans to represent seat availability.
- Prints seat availability status clearly as "Available" or "Occupied".
- Handles flights with variable seat counts.
- Easy-to-understand code using loops and conditional printing.

## 🧠 How It Works
1. A jagged array `flightSeats` is declared with two flights.
2. Each element is an array of booleans indicating seat availability (`true` = available, `false` = occupied).
3. The program iterates over each flight and prints the availability of each seat.
4. Output is shown in the console, pausing until a key is pressed.

## 🖥 Example Output
Seat Availability
Flight 1
Available Occupied Available
Flight 2
Occupied Occupied Available Available

## ▶️ How to Compile and Run
1. Open the code in a C# IDE like Visual Studio or Visual Studio Code.
2. Paste the program code into `Program.cs`.
3. Build and run the application.
4. Observe the seat availability displayed in the console window.

## 📦 Requirements
- .NET Framework or .NET Core SDK installed.
- C# compiler or IDE supporting .NET development.

## 👤 Author
Mohamed Mostafa – Example demonstrating jagged arrays and boolean data for flight seat reservations.
