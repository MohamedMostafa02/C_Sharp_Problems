# CheckDuplicateEntries

A simple C# console application that checks for duplicate entries using a HashSet.

## Features
- Uses HashSet<string> to automatically detect duplicates.
- Prints a message to the console when a duplicate is found.
- Demonstrates basic iteration and set logic.

## Example Input
string[] entries = { "A", "B", "C", "A" };

## Example Output
Duplicate detected: A

## Code Overview
- A HashSet is used to store unique entries.
- The program iterates through an array of strings.
- If HashSet.Add(entry) returns false, the entry is a duplicate and a message is printed.

## How to Run
1. Open the project in Visual Studio or any C# IDE.
2. Build and run the project.
3. View the duplicate detection messages in the console.

## Author
Mohamed Mostafa
