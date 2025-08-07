Store Sales Data by Quarter - C# Console App

Description:
This is a simple C# console application that demonstrates how to use jagged arrays to store and display sales data by region, where each region may have sales data for a different number of quarters.

Features:
- Uses a jagged array to hold varying numbers of quarterly sales values for different regions.
- Displays each region’s sales data in a formatted output.
- Demonstrates fundamental C# array handling and loops.

How It Works:
- The salesData array is a jagged array (array of arrays), where each sub-array represents sales for a specific region.
- A for loop is used to iterate through each region.
- The string.Join method prints the quarterly sales of each region on a single line.

Example Output:
Region 1
10000, 12000, 11000
Region 2
15000, 16000
Region 3
9000, 9500, 9800, 10200

How to Compile and Run:
1. Open the project in Visual Studio.
2. Press Ctrl + F5 to run the program without debugging.

Requirements:
- .NET Framework or .NET SDK installed
- Visual Studio or any C# development environment

Author:
Mohamed Mostafa – This project is for educational purposes demonstrating jagged arrays in C#.
